#include "BarcodeScannerListenerInteropHelper.h"

using namespace System::ComponentModel;

BEGIN_INTEROP_NAMESPACE

	/// <summary>
	/// Gets information from a WM_INPUT message.
	/// </summary>
	/// <param name="rawInputHeader">The LParam from the WM_INPUT message.</param>
	/// <param name="deviceHandle">[Out] The device handle that the message came from.</param>
	/// <param name="handled">[Out] True if the message represents a keystroke from that device.</param>
	/// <param name="buffer">[Out] If handled is true, this contains the characters that the keystroke represents.</param>
	void BarcodeScannerListenerInteropHelper::GetRawInputInfo(
		IntPtr rawInputHeader,
		IntPtr% deviceHandle, 
		bool% handled,
		String^% buffer)
	{
		UINT cbSize;
		HRAWINPUT hRawInput;

		hRawInput = (HRAWINPUT)rawInputHeader.ToPointer();
		if (GetRawInputData(hRawInput, RID_INPUT, NULL, &cbSize, sizeof(RAWINPUTHEADER)) == 0)
		{
			RAWINPUT* raw;

			raw = (RAWINPUT*)malloc(cbSize);

			if (GetRawInputData(hRawInput, RID_INPUT, raw, &cbSize, sizeof(RAWINPUTHEADER)) == cbSize)
			{
				deviceHandle = IntPtr(raw->header.hDevice);
				handled = raw->header.dwType == RIM_TYPEKEYBOARD &&
					raw->data.keyboard.Message == WM_KEYDOWN;

				if (handled)
				{
					BYTE state[256];

					// Force the keyboard status cache to update
					GetKeyState(0);

                    // Note: GetKeyboardState only returns valid state when
                    // the application has focus -- this is why we weren't
                    // getting shift keys when the application was not focused
					if (GetKeyboardState(state))
					{
						WCHAR unmanagedBuffer[64];

						if (ToUnicode(raw->data.keyboard.VKey,
								raw->data.keyboard.MakeCode,
								state,
								unmanagedBuffer,
								64,
								0) > 0)
						{
							buffer = gcnew String(unmanagedBuffer);
						}
					}
				}
			}

			free(raw);
		}
	}

	/// <summary>
	/// Registers ourselves to listen to raw input from keyboard-like devices.
	/// </summary>
	/// <param name="hwnd">the handle of the form that will receive the raw
	/// input messages</param>
	/// <exception cref="InvalidOperationException">if the call to register with the
	/// raw input API fails for some reason</exception>
	void BarcodeScannerListenerInteropHelper::HookRawInput(IntPtr hwnd)
	{
		RAWINPUTDEVICE rid[1];

		rid[0].dwFlags = 0;
		rid[0].hwndTarget = (HWND)hwnd.ToPointer();
		rid[0].usUsage = 0x06;     // Keyboard Usage ID
		rid[0].usUsagePage = 0x01; // USB HID Generic Desktop Page

		if (!RegisterRawInputDevices(rid, 1, sizeof(RAWINPUTDEVICE)))
		{
			InvalidOperationException^ e;

			e = gcnew InvalidOperationException(
				"The barcode scanner listener could not register for raw input devices.",
				gcnew Win32Exception());
			throw e;
		}
	}

	/// <summary>
	/// Returns a dictionary of barcode device handles to information about
	/// the device.
	/// </summary>
	Dictionary<IntPtr, BarcodeScannerDeviceInfo^>^ BarcodeScannerListenerInteropHelper::InitializeBarcodeScannerDeviceHandles(IEnumerable<String^>^ hardwareIds)
	{
		Dictionary<IntPtr, BarcodeScannerDeviceInfo^>^ devices;
		UINT uiNumDevices;
		UINT cbSize;

		devices = gcnew Dictionary<IntPtr, BarcodeScannerDeviceInfo^>();
		uiNumDevices = 0;
		cbSize = sizeof(RAWINPUTDEVICELIST);

		if (GetRawInputDeviceList(NULL, &uiNumDevices, cbSize) != -1)
		{
			PRAWINPUTDEVICELIST pRawInputDeviceList;

			if (pRawInputDeviceList = (PRAWINPUTDEVICELIST)malloc(cbSize * uiNumDevices))
			{
				if (GetRawInputDeviceList(pRawInputDeviceList, &uiNumDevices, cbSize) != -1)
				{
					for (UINT i = 0; i < uiNumDevices; ++i)
					{
						UINT pcbSize;
						RAWINPUTDEVICELIST rid;

						rid = pRawInputDeviceList[i];

						if (GetRawInputDeviceInfo(rid.hDevice, RIDI_DEVICENAME, NULL, &pcbSize) >= 0 &&
							pcbSize > 0)
						{
							WCHAR* deviceName;

							deviceName = (WCHAR*)malloc(sizeof(WCHAR) * (pcbSize + 1));
							if (GetRawInputDeviceInfo(rid.hDevice, RIDI_DEVICENAME, deviceName, &pcbSize) >= 0)
							{
								bool add;
								IntPtr deviceHandle;
								BarcodeScannerDeviceInfo^ info;
								String^ managedDeviceName;

								add = false;
								deviceHandle = IntPtr(rid.hDevice);
								managedDeviceName = gcnew String(deviceName);

								for each (String^ hardwareId in hardwareIds)
								{
									if (managedDeviceName->IndexOf(hardwareId, StringComparison::OrdinalIgnoreCase) >= 0)
									{
										add = true;
										break;
									}
								}
								
								if (add)
								{
									info = gcnew BarcodeScannerDeviceInfo(
										managedDeviceName,
										BarcodeScannerListenerInteropHelper::GetBarcodeScannerDeviceType(rid.dwType),
										deviceHandle);

									devices->Add(deviceHandle, info);
								}
							}

							free(deviceName);
						}
					}
				}

				free(pRawInputDeviceList);
			}
		}

		return devices;
	}

	/// <summary>
	/// Converts a native raw input type into our version.
	/// </summary>
	/// <param name="rawInputType">The raw input type.</param>
	/// <returns>Our version of the type.</returns>
	BarcodeScannerDeviceType BarcodeScannerListenerInteropHelper::GetBarcodeScannerDeviceType(DWORD rawInputType)
	{
		BarcodeScannerDeviceType type;

		switch (rawInputType)
		{
			case RIM_TYPEHID:
				type = BarcodeScannerDeviceType::HumanInterfaceDevice;
				break;
			case RIM_TYPEKEYBOARD:
				type = BarcodeScannerDeviceType::Keyboard;
				break;
			default:
				type = BarcodeScannerDeviceType::Unknown;
				break;
		}

		return type;
	}

END_INTEROP_NAMESPACE
