using System;
using Cpp2ILInjected;
using Info;
using UI.DoubleCoinsVideo;
using UI.Screens.RewardManagement;
using UnityEngine;
using WeeklyHunt;

namespace UI.Pages.WeeklyHuntPageInternal;

public class WeekCell : MonoBehaviour
{
	public class WeekCellPayload
	{
		public Action<WeeklyHuntData.PrizePeriodId> clicked;

		public WeeklyHuntData.PrizePeriodId periodId;

		public unsafe WeekCellPayload()
		{
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected Obj, but got Unknown
			//IL_010b: Expected Obj, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected Obj, but got Unknown
			//IL_0139: Expected Obj, but got I
			//IL_014a: Expected Obj, but got I
			//IL_015e: Expected Obj, but got I
			//IL_0186: Expected I, but got Obj
			//IL_019c: Expected Obj, but got I
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected I4, but got Unknown
			//IL_01d4: Expected I4, but got Obj
			//IL_0222: Expected Obj, but got I4
			//IL_0222: Expected Obj, but got I
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected Obj, but got Unknown
			//IL_0262: Expected Obj, but got I
			//IL_0273: Expected Obj, but got I
			//IL_028c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0062: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I
			//IL_0084: Expected VT, but got I4
			//IL_00b2: Expected I4, but got Obj
			//IL_00d5: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 56;
			obj = 0;
			_ = 0;
			Transform transform = (Transform)(obj2 + 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @826D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+30]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+7C]");
			int layer = ((GameObject)0).layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+30]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+34]");
			bool flag = (nint)0 != 0;
			nint num = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v24 (Il2CppClass<PrizePositionData>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v48 (Il2CppClass<PrizePositionData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationRewardOrigin celebrationRewardOrigin = (CelebrationRewardOrigin)(obj2 + 72);
			((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (UnityEngine.Transform)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (UnityEngine.Transform)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (UnityEngine.Transform)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18+54]");
			RewardManager.AddRewardToUnlock(celebrationRewardOrigin, (ObtainableItemSource)layer, (string)0, (string)flag);
			object obj6 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v38+24]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+30]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v6+7C]");
				int layer2 = ((GameObject)0).layer;
				transform.rotation = (Quaternion)layer2;
				obj = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
				((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+30]");
				object obj8 = (nint)0 + (nint)128;
				obj8 = ((CelebrationRewardOrigin*)(int)celebrationRewardOrigin)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v29 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+30]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v26+7C]");
			int layer3 = ((GameObject)0).layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.WeeklyHuntPageInternal.WeekCell+WeekCellPayload)+30]");
			((WeeklyHuntPage)0).SetObjectVisibility((byte)layer3 != 0);
		}
	}

	private UISprite _cellBG;

	private UISprite _dottedLine;

	private UILabel _weekLabel;

	private UILabel _statusLabel;

	private Collider _collider;

	private int _inactiveBottomAnchorOffset;

	private int _activeBottomAnchorOffset;

	private Action<WeeklyHuntData.PrizePeriodId> _clickedAction;

	private WeeklyHuntData.PrizePeriodId _periodId;

	public unsafe WeeklyHuntData.PrizePeriodId periodId
	{
		get
		{
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Expected Obj, but got Unknown
			//IL_04a8: Expected Obj, but got I4
			//IL_04c8: Expected I, but got Obj
			//IL_04de: Expected Obj, but got I
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_007e: Expected Obj, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected VT, but got Unknown
			//IL_00ae: Expected I4, but got Obj
			//IL_00a9: Expected native int or pointer, but got VT
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected VT, but got Unknown
			//IL_00f2: Expected VT, but got I4
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected Obj, but got Unknown
			//IL_0115: Expected I4, but got Obj
			//IL_0110: Expected native int or pointer, but got VT
			//IL_011d: Expected native int or pointer, but got VT
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected Obj, but got Unknown
			//IL_0138: Expected Obj, but got VT
			//IL_0145: Expected I4, but got Obj
			//IL_0140: Expected native int or pointer, but got VT
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected Obj, but got Unknown
			//IL_016b: Expected Obj, but got I4
			//IL_018d: Expected I4, but got Obj
			//IL_0188: Expected native int or pointer, but got VT
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected Obj, but got Unknown
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected VT, but got Unknown
			//IL_01d1: Expected VT, but got I4
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected Obj, but got Unknown
			//IL_01f4: Expected I4, but got Obj
			//IL_01ef: Expected native int or pointer, but got VT
			//IL_01fc: Expected native int or pointer, but got VT
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected Obj, but got Unknown
			//IL_0217: Expected Obj, but got VT
			//IL_0224: Expected I4, but got Obj
			//IL_021f: Expected native int or pointer, but got VT
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected Obj, but got Unknown
			//IL_024a: Expected Obj, but got I4
			//IL_026c: Expected I4, but got Obj
			//IL_0267: Expected native int or pointer, but got VT
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected Obj, but got Unknown
			//IL_02a2: Expected VT, but got I4
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected Obj, but got Unknown
			//IL_02c5: Expected I4, but got Obj
			//IL_02c0: Expected native int or pointer, but got VT
			//IL_02cd: Expected native int or pointer, but got VT
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Expected Obj, but got Unknown
			//IL_02e8: Expected Obj, but got VT
			//IL_02f5: Expected I4, but got Obj
			//IL_02f0: Expected native int or pointer, but got VT
			//IL_0302: Expected Obj, but got I4
			//IL_030f: Expected I4, but got Obj
			//IL_030a: Expected native int or pointer, but got VT
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Expected Obj, but got Unknown
			//IL_0351: Expected Obj, but got I4
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected Obj, but got Unknown
			//IL_0398: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Expected Obj, but got Unknown
			//IL_03a6: Expected Obj, but got I4
			//IL_03b5: Expected Obj, but got F4
			//IL_03ce: Expected I4, but got Obj
			//IL_03c9: Expected native int or pointer, but got VT
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected Obj, but got Unknown
			//IL_03f6: Expected Obj, but got I4
			//IL_0411: Expected I, but got Obj
			//IL_0427: Expected Obj, but got I
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Expected Obj, but got Unknown
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Expected Obj, but got Unknown
			//IL_0540: Expected Obj, but got I4
			//IL_0549: Unknown result type (might be due to invalid IL or missing references)
			//IL_054e: Expected Obj, but got Unknown
			//IL_055b: Expected I4, but got Obj
			//IL_0452: Expected I, but got Obj
			Color32? color = default;
			object obj = (Nullable)color + 128;
			obj = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			nint num = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UI.ColorData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v123 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			DoubleCoinsVideoBanner._003CActivateStars_003Ed__14 obj3 = default;
			((IDisposable)obj3).Dispose();
			_ = 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			object obj4 = (Nullable)color + 112;
			object obj5 = (flag ? 1 : 0) + 940;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v14+8]");
			_ = 0;
			Color32 color2 = (Color32)((Nullable)color + 168);
			((Color32*)(nint)color2)->rgba = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
			_ = 0;
			object obj6 = (Nullable)color + 104;
			Color color3 = color2;
			Color32? color4 = (Color32?)(object)((Nullable)color + 24);
			color4 = (Color32?)(object)0;
			object obj7 = (Nullable)color + 164;
			obj7 = obj6;
			((Color32*)(nint)color2)->rgba = (int)obj7;
			*(Color32?*)(nint)color4 = color2;
			object obj8 = (Nullable)color + 40;
			obj8 = color4;
			((Color32*)(nint)color2)->rgba = (int)obj8;
			_ = color2.rgba;
			object obj9 = (Nullable)color + 88;
			object obj10 = (flag ? 1 : 0) + 972;
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v42+8]");
			_ = 0;
			((Color32*)(nint)color2)->rgba = (int)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v46+8]");
			_ = 0;
			object obj11 = (Nullable)color + 80;
			Color color5 = color2;
			Color32? color6 = (Color32?)(object)((Nullable)color + 8);
			color6 = (Color32?)(object)0;
			object obj12 = (Nullable)color + 160;
			obj12 = obj11;
			((Color32*)(nint)color2)->rgba = (int)obj12;
			*(Color32?*)(nint)color6 = color2;
			object obj13 = (Nullable)color + 32;
			obj13 = color6;
			((Color32*)(nint)color2)->rgba = (int)obj13;
			_ = color2.rgba;
			object obj14 = (Nullable)color - -64;
			object obj15 = (flag ? 1 : 0) + 956;
			obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v69+8]");
			_ = 0;
			((Color32*)(nint)color2)->rgba = (int)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v65+8]");
			_ = 0;
			object obj16 = (Nullable)color + 60;
			Color color7 = color2;
			color = (Color32?)(object)0;
			object obj17 = (Nullable)color + 84;
			obj17 = obj16;
			((Color32*)(nint)color2)->rgba = (int)obj17;
			*(Color32?*)(nint)color = color2;
			object obj18 = (Nullable)color + 16;
			obj18 = color;
			((Color32*)(nint)color2)->rgba = (int)obj18;
			obj = color2.rgba;
			((Color32*)(nint)color2)->rgba = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
			_ = 0;
			object obj19 = obj3 + 16;
			obj19 = color2.rgba;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+18]");
			_ = 0;
			object obj20 = obj3 + 12;
			obj20 = "icon_weekly_hunt";
			object obj21 = (Nullable)color + 48;
			obj21 = 0;
			_ = 0;
			obj21 = 1f;
			_ = 0f;
			_ = 0f;
			((Color32*)(nint)color2)->rgba = (int)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v94+8]");
			_ = 0;
			object obj22 = obj3 + 60;
			obj22 = color2.rgba;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (UnityEngine.Color32)+8]");
			_ = 0;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v105 (Il2CppClass<Strings>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v119 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj24 = obj3 + 52;
			string text = Strings.GetDefault("WEEKLY_HUNT_TITLE");
			obj24 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj26 = default;
			object obj25 = obj26 + 16;
			obj25 = 1;
			object obj27 = obj3 + 56;
			obj27 = obj26;
			return (WeeklyHuntData.PrizePeriodId)obj3;
		}
	}

	public void Init(WeekCellPayload payload)
	{
		((WeeklyHuntPage)this).TabClicked(WeeklyHuntData.PrizePeriodId.None);
	}

	public unsafe void SetCellActive(bool active)
	{
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I4
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_03a0: Expected I4, but got Obj
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0422: Expected Obj, but got VT
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected VT, but got Unknown
		//IL_0453: Expected F4, but got Obj
		//IL_044e: Expected native int or pointer, but got VT
		//IL_046d: Expected F4, but got Obj
		//IL_0468: Expected native int or pointer, but got VT
		//IL_0482: Expected F4, but got I
		//IL_047d: Expected native int or pointer, but got VT
		//IL_0491: Expected I4, but got VT
		//IL_03c2: Expected I4, but got Obj
		//IL_02e8: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_018b: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_03e4: Expected I4, but got Obj
		//IL_01cc: Expected I, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0406: Expected I4, but got Obj
		//IL_025a: Expected I, but got Obj
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [active @ L1 (System.Boolean)+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [active @ L1 (System.Boolean)+C]");
		_periodId = WeeklyHuntData.PrizePeriodId.None;
		object obj2 = _periodId - 1;
		if (_periodId != WeeklyHuntData.PrizePeriodId.PeriodOne)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 == 3)
					{
						nint num = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v68 (Il2CppClass<Strings>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v75 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text = Strings.GetDefault("WEEKLY_HUNT_PERIOD_FOUR_PERIOD_TITLE");
						_weekLabel.fontSize = (int)text;
					}
				}
				else
				{
					nint num3 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v56 (Il2CppClass<Strings>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v63 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text2 = Strings.GetDefault("WEEKLY_HUNT_PERIOD_THREE_PERIOD_TITLE");
					_weekLabel.fontSize = (int)text2;
				}
			}
			else
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v44 (Il2CppClass<Strings>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v51 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("WEEKLY_HUNT_PERIOD_TWO_PERIOD_TITLE");
				_weekLabel.fontSize = (int)text3;
			}
		}
		else
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v32 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("WEEKLY_HUNT_PERIOD_ONE_PERIOD_TITLE");
			_weekLabel.fontSize = (int)text4;
		}
		nint num9 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v11 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v25 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = default;
		object obj8 = obj9 + 20;
		obj8 = GlobalColorsGenerated.WEEKLYHUNT_DIVIDER;
		object obj10 = obj9 + 16;
		obj10 = obj8;
		Matrix4x4 matrix4x = (Matrix4x4)(obj9 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dottedLine.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void UpdateStatus()
	{
		((WeeklyHuntPage)this).TabClicked(WeeklyHuntData.PrizePeriodId.PeriodOne);
	}

	public void OnClicked()
	{
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_029a: Expected I4, but got Obj
		//IL_00e0: Expected I, but got Obj
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_02bc: Expected I4, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_02de: Expected I4, but got Obj
		//IL_01fc: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v21 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(_periodId);
		if (prizeDataForPeriod != null)
		{
			if ((nint)prizeDataForPeriod != 1)
			{
				if ((nint)prizeDataForPeriod != 2)
				{
					return;
				}
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v30 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v37 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("WEEKLY_HUNT_CURRENT");
				_statusLabel.fontSize = (int)text;
				return;
			}
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v18 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v25 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("WEEKLY_HUNT_EVENT_ENDED_SHORT");
			_statusLabel.fontSize = (int)text2;
			return;
		}
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("WEEKLY_HUNT_UPCOMING");
		_statusLabel.fontSize = (int)text3;
	}

	public WeekCell()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		if (_clickedAction != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v5 (should have been resolved before IL gen)");
		}
	}
}
