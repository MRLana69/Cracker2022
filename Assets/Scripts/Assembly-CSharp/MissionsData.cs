using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public class MissionsData
{
	public const int NUMBER_OF_MISSIONS_IN_MISSION_SET = 3;

	public const int MISSIONS_VERSION = 3;

	public static List<MissionIndicator> missionsModificationsForStoryline;

	public static List<MissionIndicator> missionsModificationsForRepeatable;

	public static Dictionary<int, int[]> missionsInsertedForRepeatable;

	public static Mission[][] repeatableMissions;

	public static Mission[][] storylineMissions;

	public static readonly Dictionary<MissionType, MissionTemplate> missionTemplates;

	static MissionsData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_85ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_85b3: Expected Obj, but got Unknown
		//IL_85bc: Expected Obj, but got I4
		//IL_85c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_85ca: Expected Obj, but got Unknown
		//IL_85d3: Expected Obj, but got I4
		//IL_85eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_85f0: Expected Obj, but got Unknown
		//IL_85f9: Expected Obj, but got I4
		//IL_8608: Unknown result type (might be due to invalid IL or missing references)
		//IL_860d: Expected Obj, but got Unknown
		//IL_8622: Expected Obj, but got I4
		//IL_862b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8630: Expected Obj, but got Unknown
		//IL_864e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8653: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected VT, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected VT, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_012b: Expected Obj, but got I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected VT, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected VT, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected VT, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I4
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected VT, but got Unknown
		//IL_038d: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I4
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_042c: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_047c: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		object obj = default;
		MissionTemplate missionTemplate = (MissionTemplate)(obj - 7904);
		object obj2 = missionTemplate + 7896;
		obj2 = 0;
		object obj3 = missionTemplate + 7888;
		obj3 = 0;
		_ = 0;
		List<MissionIndicator> list = default;
		list._002Ector();
		object obj4 = missionTemplate + 7872;
		obj4 = 0;
		_ = 0;
		object obj5 = missionTemplate + 7864;
		_ = 2;
		_ = 6;
		obj5 = 1;
		object obj6 = missionTemplate + 4256;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1EB8]");
		_ = 0;
		MissionIndicator item = (MissionIndicator)(missionTemplate + 4248);
		list.Add(item);
		object obj7 = missionTemplate + 7856;
		obj7 = 0;
		_ = 0;
		object obj8 = missionTemplate + 7848;
		_ = 0;
		_ = 13;
		obj8 = 1;
		object obj9 = missionTemplate + 4240;
		obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1EA8]");
		_ = 0;
		MissionIndicator item2 = (MissionIndicator)(missionTemplate + 4232);
		list.Add(item2);
		object obj10 = missionTemplate + 7840;
		obj10 = 0;
		_ = 0;
		object obj11 = missionTemplate + 7832;
		_ = 0;
		_ = 19;
		obj11 = 1;
		object obj12 = missionTemplate + 4224;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E98]");
		_ = 0;
		MissionIndicator item3 = (MissionIndicator)(missionTemplate + 4216);
		list.Add(item3);
		object obj13 = missionTemplate + 7824;
		obj13 = 0;
		_ = 0;
		object obj14 = missionTemplate + 7816;
		_ = 0;
		_ = 23;
		obj14 = 1;
		object obj15 = missionTemplate + 4208;
		obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E88]");
		_ = 0;
		MissionIndicator item4 = (MissionIndicator)(missionTemplate + 4200);
		list.Add(item4);
		object obj16 = missionTemplate + 7808;
		obj16 = 0;
		_ = 0;
		object obj17 = missionTemplate + 7800;
		_ = 1;
		_ = 7;
		obj17 = 3;
		object obj18 = missionTemplate + 4192;
		obj18 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E78]");
		_ = 0;
		MissionIndicator item5 = (MissionIndicator)(missionTemplate + 4184);
		list.Add(item5);
		object obj19 = missionTemplate + 7792;
		obj19 = 0;
		_ = 0;
		object obj20 = missionTemplate + 7784;
		_ = 0;
		_ = 23;
		obj20 = 3;
		object obj21 = missionTemplate + 4176;
		obj21 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E68]");
		_ = 0;
		MissionIndicator item6 = (MissionIndicator)(missionTemplate + 4168);
		list.Add(item6);
		missionsModificationsForStoryline = list;
		List<MissionIndicator> list2 = default;
		list2._002Ector();
		object obj22 = missionTemplate + 7776;
		obj22 = 0;
		_ = 0;
		object obj23 = missionTemplate + 7768;
		_ = 2;
		_ = 38;
		obj23 = 3;
		object obj24 = missionTemplate + 4160;
		obj24 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E58]");
		_ = 0;
		MissionIndicator item7 = (MissionIndicator)(missionTemplate + 4152);
		list2.Add(item7);
		missionsModificationsForRepeatable = list2;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v290 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32[]>>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.FA0420EF077569F61F775C8C49B66FEA9BB4C90D1DED5000F2E7DE1765FDF576));
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32[]>>)+5C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ S5_v4+4] (should have been resolved before IL gen)");
		Dictionary<int, int[]> dictionary = default;
		missionsInsertedForRepeatable = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		object obj26 = missionTemplate + 7760;
		_ = 4;
		obj26 = 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E50]");
		_ = 0;
		object obj27 = missionTemplate + 4144;
		_ = 0;
		object obj28 = missionTemplate + 7744;
		_ = 3;
		obj28 = 18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E40]");
		_ = 0;
		object obj29 = missionTemplate + 4136;
		_ = 0;
		object obj30 = missionTemplate + 7728;
		_ = 1200;
		obj30 = 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (MissionTemplate)+1E30]");
		_ = 0;
		object obj31 = missionTemplate + 4128;
		throw new ArrayTypeMismatchException();
	}
}
