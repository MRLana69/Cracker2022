using System.Globalization;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Native;

public class Platform
{
	public static string GetPlatformVersion()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo cultureInfo = CultureInfo.ConstructCurrentCulture();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string result = default;
		return result;
	}

	private static string _GetPlatformVersion()
	{
		//IL_0009: Expected Obj, but got I4
		return (string)SystemInfo.GetOperatingSystemFamily();
	}
}
