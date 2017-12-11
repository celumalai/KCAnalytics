using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::CompilerServices;
using namespace System::Runtime::InteropServices;
using namespace System::Security::Permissions;

[assembly:AssemblyTitleAttribute("BarcodeHelper")];
[assembly:AssemblyDescriptionAttribute("Provides native interop assistance to the UI.")];
#ifdef DEBUG
[assembly:AssemblyConfigurationAttribute("DEBUG")];
#else
[assembly:AssemblyConfigurationAttribute("RELEASE")];
#endif
[assembly:AssemblyCompanyAttribute("KCA Software, Inc.")];
[assembly:AssemblyProductAttribute("Barcode Helper")];
[assembly:AssemblyCopyrightAttribute("Copyright © 2014 KCASoftware")];
[assembly:AssemblyTrademarkAttribute("")];
[assembly:AssemblyCultureAttribute("")];
[assembly:AssemblyVersionAttribute("1.0")];
[assembly:ComVisible(false)];
[assembly:CLSCompliantAttribute(true)];
[assembly:SecurityPermission(SecurityAction::RequestMinimum, UnmanagedCode = true)];
