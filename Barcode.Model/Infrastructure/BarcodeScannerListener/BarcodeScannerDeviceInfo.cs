﻿namespace Barcode.Model
{
    using System;
    using System.Globalization;

    /// <summary>
    /// An enumeration of barcode scanner device types.
    /// </summary>
    public enum BarcodeScannerDeviceType : int
    {
        /// <summary>
        /// An unknown type.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// A keyboard type.
        /// </summary>
        Keyboard = 1,

        /// <summary>
        /// A human interface device type.
        /// </summary>
        HumanInterfaceDevice = 2
    }

    /// <summary>
    /// Provides information about a barcode scanner device.
    /// </summary>
    public class BarcodeScannerDeviceInfo
    {
        /// <summary>
        /// Initializes a new instance of the BarcodeScannerDeviceInfo class.
        /// </summary>
        /// <param name="deviceName">the hardware device name</param>
        /// <param name="deviceType">the type of the device</param>
        /// <param name="deviceHandle">the handle to the device</param>
        public BarcodeScannerDeviceInfo(
            string deviceName,
            BarcodeScannerDeviceType deviceType,
            IntPtr deviceHandle)
        {
            this.DeviceName = deviceName;
            this.DeviceType = deviceType;
            this.DeviceHandle = deviceHandle;
        }

        /// <summary>
        /// Gets the hardware device name.
        /// </summary>
        public string DeviceName { get; private set; }

        /// <summary>
        /// Gets the type of the device.
        /// </summary>
        public BarcodeScannerDeviceType DeviceType { get; private set; }

        /// <summary>
        /// Gets a handle to the device.
        /// </summary>
        public IntPtr DeviceHandle { get; private set; }

        /// <summary>
        /// Gets a human-readable string that describes the device info.
        /// </summary>
        /// <returns>the human-readble string</returns>
        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0} (handle: {1}; type: {2})",
                GetType().Name,
                this.DeviceHandle,
                this.DeviceType);
        }
    }
}
