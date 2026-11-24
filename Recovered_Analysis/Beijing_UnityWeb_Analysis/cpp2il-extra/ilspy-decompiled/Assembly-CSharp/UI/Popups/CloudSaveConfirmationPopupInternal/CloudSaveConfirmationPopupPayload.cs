using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UI.Popups.ConsumablesPopupInternal;

namespace UI.Popups.CloudSaveConfirmationPopupInternal;

public class CloudSaveConfirmationPopupPayload
{
	public enum ConfirmationState
	{
		Disconnect,
		KeepLocal,
		KeepOnline,
		LoadProgress
	}

	public static readonly CloudSaveConfirmationPopupPayload DISCONNECT_PAYLOAD;

	public static readonly CloudSaveConfirmationPopupPayload KEEP_LOCAL_PAYLOAD;

	public static readonly CloudSaveConfirmationPopupPayload KEEP_ONLINE_PAYLOAD;

	public static readonly CloudSaveConfirmationPopupPayload LOAD_PROGRESS_PAYLOAD;

	public Action goodButtonClicked;

	public Action badButtonClicked;

	public string text;

	public string badButtonText;

	public string goodButtonText;

	public string cornerIcon;

	public string cornerAccentIcon;

	public string flurryParameter;

	public static CloudSaveConfirmationPopupPayload activePayload
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SellConsumablesHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CloudSaveConfirmationPopupPayload)(object)SellConsumablesHelper._videoRewardAmountOSKeys;
		}
		private set
		{
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_0124: Expected Obj, but got I
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0049: Expected Obj, but got I
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_00bd: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = text2 + ";Revive";
			object obj3 = obj2 + 4;
			obj3 = value.goodButtonClicked;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73B9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v3+120]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text4 = default;
			string text5 = default;
			string text3 = text4 + ";" + text5;
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v21 (Il2CppClass<Flurry>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
	}

	public static void PreparePayload(ConfirmationState state, Action goodButtonClicked, Action badButtonClicked)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = state;
		object obj3 = goodButtonClicked & 1;
		object obj4 = obj2 + 20;
		obj4 = badButtonClicked;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v13+8]");
			_ = 0;
		}
		OfferWallManager instance = OfferWallManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		bool isInRun = (nint)0 != 0;
		int consumableRewardForVideo = ((SellConsumablesHelper)state).GetConsumableRewardForVideo(isInRun);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj5 = text + 16;
		obj5 = obj2;
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)consumableRewardForVideo, text);
	}

	public CloudSaveConfirmationPopupPayload()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		if (!flag)
		{
			nint num3 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+5C]");
		object obj2 = (nint)0 + (nint)16;
		obj2 = this;
	}

	static CloudSaveConfirmationPopupPayload()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_0300: Expected I, but got Obj
		//IL_0316: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v14 (should have been resolved before IL gen)");
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = default;
		SellConsumablesHelper._defaultVideoRewardAmounts = defaultVideoRewardAmounts;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v10 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S3_v11+60]");
		object obj22 = 0;
		object obj23 = obj22;
		object obj24 = obj23 & 0x1FFF;
		object obj25 = obj24 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v102 @ S4_v23 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v25 (Il2CppMethodInfo)+C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S4_v26+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v27+48]");
		object obj28 = 0;
		object obj29 = obj28 & 0x7FF;
		object obj30 = obj29 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v120 @ S5_v20 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v30 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v31+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S4_v32+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v24 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S4_v35 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v36+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S4_v37+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S5_v28 (should have been resolved before IL gen)");
		nint num9 = (nint)typeof(SellConsumablesHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v27 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+5C]");
		object obj41 = (nint)0 + (nint)4;
		object obj42 = default;
		obj41 = obj42;
	}
}
