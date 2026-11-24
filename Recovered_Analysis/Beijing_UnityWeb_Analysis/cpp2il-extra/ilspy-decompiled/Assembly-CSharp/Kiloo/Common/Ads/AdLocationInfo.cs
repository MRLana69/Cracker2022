using System;
using Cpp2ILInjected;

namespace Kiloo.Common.Ads;

public class AdLocationInfo
{
	public readonly string id;

	public readonly AdType adType;

	public readonly bool isPoolLocation;

	public AdLocationInfo(string id, AdType adType, bool isPoolLocation)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got VT
		//IL_0107: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdLocationInfo)+24]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		if (!((string)0 != (string)isPoolLocation))
		{
			return;
		}
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v24 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		obj2 = utcNow;
		obj = obj2;
		this.isPoolLocation = (byte)(int)obj != 0;
	}
}
