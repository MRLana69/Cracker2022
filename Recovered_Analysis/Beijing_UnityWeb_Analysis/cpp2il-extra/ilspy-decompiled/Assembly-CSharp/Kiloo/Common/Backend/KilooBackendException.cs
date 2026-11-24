using System;
using System.IO;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Common.Backend;

public class KilooBackendException : Exception
{
	public Error backendError
	{
		get
		{
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected Obj, but got Unknown
			//IL_0220: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00b1: Expected I, but got Obj
			//IL_00c7: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_02a3: Expected Obj, but got I4
			//IL_00f2: Expected I, but got Obj
			//IL_0189: Expected I, but got Obj
			//IL_019f: Expected Obj, but got I
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected Obj, but got Unknown
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Expected Obj, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_01ca: Expected I, but got Obj
			IndexOutOfRangeException ex = default;
			object obj = ex + 16;
			obj = 0;
			_ = 0;
			if (base._message == null)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v18 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v63 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string cachePath = DeviceUtility.GetCachePath();
				if (cachePath == null)
				{
					((KilooBackendException)null).backendError = (Error)(object)"User data path was null.";
				}
				else
				{
					nint num3 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v26 (Il2CppClass<System.IO.Path>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(Path);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v58 (Il2CppClass<System.IO.Path>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = Path.SameRoot(cachePath, ".installationInfo");
					string fullPathInternal = Path.GetFullPathInternal((string)flag);
					if (File.GetAttributes(fullPathInternal) != 0)
					{
						object obj4 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BD7");
						object obj5 = default;
						if (obj5 != null)
						{
							goto IL_0281;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = (nint)typeof(Guid);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v39 (Il2CppClass<System.Guid>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(Guid);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v51 (Il2CppClass<System.Guid>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					ex._002Ector();
					obj = ex;
					_ = ((Exception)ex)._className;
					object obj8 = default;
					object obj7 = obj8 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EF7B");
					object obj9 = default;
					obj7 = obj9;
					object obj10 = this + 12;
					obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
				}
			}
			goto IL_0281;
			IL_0281:
			return (Error)(object)base._message;
		}
		private set
		{
			//IL_0060: Expected I4, but got Obj
			//IL_0072: Expected I, but got Obj
			//IL_0088: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			string exception = string.ConcatArray((string[])(object)"[InstallationInfo] ", (int)value);
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)exception);
		}
	}

	public KilooBackendException(string message)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 68;
		obj = message;
	}

	public KilooBackendException(Error error)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		base.SetErrorCode((int)error);
	}
}
