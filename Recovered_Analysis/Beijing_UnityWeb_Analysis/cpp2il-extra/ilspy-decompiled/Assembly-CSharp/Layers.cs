using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cloud;
using Cpp2ILInjected;
using Data.Managers;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.PauseScreenInternal;

public class Layers
{
	public readonly int Default;

	public readonly int Hit;

	public readonly int Unremovable;

	public readonly int Character;

	public readonly int Guard;

	public readonly int Pickup;

	public readonly int Coin;

	public readonly int Background;

	public readonly int TutorialTrigger;

	public readonly int TrackEvent;

	public readonly int TrackEventTrigger;

	public readonly int SkateparkSetPiece;

	public readonly int Ramp;

	public readonly int LoadScreenLayer;

	public readonly int _3DGUI;

	public readonly int _3DCLIP;

	public readonly int _RENDERTEXTURE;

	public readonly int CELEBRATION;

	public readonly int _2DGUI;

	public readonly int _2DOVERLAY;

	public readonly int _2DOVERLAYCLIP;

	public readonly int _3DOVERLAY;

	private static Layers _instance;

	public static Layers Instance
	{
		get
		{
			//IL_015d: Expected I, but got Obj
			//IL_0173: Expected Obj, but got I
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected Obj, but got Unknown
			//IL_01a8: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_008a: Expected I, but got Obj
			//IL_00a0: Expected Obj, but got I
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			//IL_00cb: Expected I, but got Obj
			//IL_0117: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Characters.CharacterId> list = default;
			list._002Ector();
			nint num = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<MysteryBox>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v41 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = MysteryBox.TOKEN_REWARD_IDS + 12;
			object obj3 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj4 = MysteryBox.TOKEN_REWARD_IDS + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ICloudServer cloudServer = CloudSave.CreateServer((string)obj6, (IKilooAuth)null, (IBsonSerializer)null);
				if (cloudServer != null)
				{
					list.Add((Characters.CharacterId)obj6);
				}
				object obj8 = obj3 + 1;
				obj3 = obj8;
			}
			return (Layers)(object)list;
		}
	}

	private Layers()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private static int FindLayer(string name)
	{
		//IL_0016: Expected Obj, but got I4
		bool flag = ((TableElementAlwaysVisible)(object)name).hasAnotherElementOpenOnTop();
		bool flag2 = ((UpgradeScreen)flag).BundlesActiveInThisLocale();
		return (flag2 ? 1 : 0) ^ 1;
	}

	public unsafe static void Init()
	{
		//IL_16c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c9: Expected Obj, but got Unknown
		//IL_16cf: Expected Obj, but got I
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dd: Expected I4, but got Unknown
		//IL_16ea: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_0237: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I4
		//IL_0297: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I
		//IL_02c3: Expected I, but got Obj
		//IL_02d9: Expected Obj, but got I
		//IL_172a: Expected I4, but got Obj
		//IL_1745: Expected I, but got Obj
		//IL_175b: Expected Obj, but got I
		//IL_0304: Expected I, but got Obj
		//IL_039e: Expected I, but got Obj
		//IL_03b4: Expected Obj, but got I
		//IL_0351: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 8);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		MysteryBox.TOKEN_REWARD_IDS = (Characters.CharacterId[])(object)unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v3+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v12+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v13+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v17+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v18+48]");
		object obj20 = 0;
		object obj21 = obj20 & 0x7FF;
		object obj22 = obj21 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v14 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S4_v22+60]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v23+48]");
		object obj25 = 0;
		object obj26 = obj25 & 0x7FF;
		object obj27 = obj26 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v126 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v31 (Il2CppClass<MysteryBox>)+5C]");
		object obj28 = (nint)0 + (nint)4;
		object obj29 = default;
		obj28 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		dailyChallengeRewardHelper._rewardLayout = (Layout)1;
		dailyChallengeRewardHelper._checkmark = (UISprite)500;
		nint num7 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v40 (Il2CppClass<MysteryBox>)+5C]");
		object obj30 = (nint)0 + (nint)12;
		obj30 = dailyChallengeRewardHelper;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper2 = default;
		dailyChallengeRewardHelper2.Refresh();
		dailyChallengeRewardHelper2._rewardLayout = (Layout)1;
		dailyChallengeRewardHelper2._checkmark = (UISprite)1500;
		nint num8 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v49 (Il2CppClass<MysteryBox>)+5C]");
		object obj31 = (nint)0 + (nint)16;
		obj31 = dailyChallengeRewardHelper2;
		nint num9 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v55 (Il2CppClass<System.Type>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num10 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v763 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(MysteryBox.Type);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		Type enumType = Type.internal_from_handle((IntPtr)(nint)callingConvention);
		nint num11 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v35 (Il2CppClass<System.Enum>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num12 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v602 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num13 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v68 (Il2CppClass<MysteryBox>)+5C]");
		object obj34 = (nint)0 + (nint)8;
		object obj35 = default;
		obj34 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 1;
		_ = 3;
		_ = 30f;
		_ = 1;
		_ = 1;
		throw new ArrayTypeMismatchException();
	}

	static Layers()
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TrackEventTrigger trackEventTrigger = default;
		trackEventTrigger._002Ector();
		nint num = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<Layers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v15 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = (Layers)(object)trackEventTrigger;
	}
}
