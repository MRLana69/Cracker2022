using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Missions;
using SYBO.Subway.Info;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

public class CelebrationTesterPopup : UIScreen
{
	private SelectPopupButton _originPopupButton;

	private SelectPopupButton _typePopupButton;

	private SelectPopupButton _powerupPopupButton;

	private SelectPopupButton _charPopupButton;

	private SelectPopupButton _boardPopupButton;

	private SelectPopupButton _trophyPopupButton;

	private SelectPopupButton _awardPopupButton;

	private SelectPopupButton _amountPopupButton;

	private SelectPopupButton _topRunRankPopupButton;

	private SelectPopupButton _themesPopupButton;

	private UILabel buttonLabel;

	private GameObject charButton;

	private GameObject boardsButton;

	private GameObject powerupButtons;

	private GameObject trrankButton;

	private GameObject awardButton;

	private GameObject trophyButton;

	private GameObject themesButton;

	private UITable buttonTable;

	private static CelebrationReward _currentCelebrationReward;

	private void Start()
	{
		CancelInvoke();
	}

	public unsafe void OriginSelected()
	{
		//IL_081c: Expected I, but got Obj
		//IL_0832: Expected Obj, but got I
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected Obj, but got Unknown
		//IL_0a33: Expected I, but got Obj
		//IL_0a49: Expected Obj, but got I
		//IL_0873: Expected I, but got Obj
		//IL_0889: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected I, but got Unknown
		//IL_08dd: Expected I, but got Obj
		//IL_08f8: Expected I, but got Obj
		//IL_090e: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0955: Expected I4, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_00fa: Expected I, but got Obj
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01c6: Expected I, but got Obj
		//IL_0202: Expected I4, but got Obj
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0294: Expected I, but got Obj
		//IL_02d0: Expected I4, but got Obj
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0362: Expected I, but got Obj
		//IL_039e: Expected I4, but got Obj
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_0415: Expected I, but got Obj
		//IL_042b: Expected Obj, but got I
		//IL_096c: Expected Obj, but got I4
		//IL_0980: Expected I4, but got Obj
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_0456: Expected I, but got Obj
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_0522: Expected I, but got Obj
		//IL_055e: Expected I4, but got Obj
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05ca: Expected Obj, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05f9: Expected I, but got Obj
		//IL_0633: Expected I4, but got Obj
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_0772: Expected I, but got Obj
		//IL_0788: Expected Obj, but got I
		//IL_0809: Expected I4, but got Obj
		//IL_07b3: Expected I, but got Obj
		//IL_07fb: Expected I4, but got Obj
		nint num = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v80 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		currentCelebrationReward.characterOutfitIndex = 0;
		object obj2 = _currentCelebrationReward + 60;
		obj2 = "Award Title";
		SelectPopupButton originPopupButton = _originPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(CelebrationTesterPopup.OriginSelected);
		object obj3 = callback + 16;
		obj3 = this;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v15 (Il2CppClass<EventDelegate>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v171 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(originPopupButton.onChange, callback);
		nint num5 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v23 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v167 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		object obj6 = obj7 + 20;
		obj6 = typeof(CelebrationRewardOrigin);
		nint num7 = (nint)(obj7 + 24);
		((IntPtr*)num7)->m_value = (void*)(nint)obj6;
		Type enumType = Type.internal_from_handle((IntPtr)num7);
		nint num8 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v17 (Il2CppClass<System.Enum>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v143 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] source = Enum.InternalGetNames((System.RuntimeType)enumType);
		List<string> list = Enumerable.ToList(source);
		((PurchaseHandler)(object)_originPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list, (string)null);
		SelectPopupButton typePopupButton = _typePopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		EventDelegate.Callback callback2 = default;
		((Delegate)callback2).method_ptr = method_ptr2;
		((Delegate)callback2).method = (nint)__ldftn(CelebrationTesterPopup.TypeSelected);
		object obj9 = callback2 + 16;
		obj9 = this;
		bool flag2 = EventDelegate.Remove(typePopupButton.onChange, callback2);
		object obj10 = obj7 + 16;
		obj10 = typeof(CelebrationRewardType);
		((IntPtr*)num7)->m_value = (void*)(nint)obj10;
		Type enumType2 = Type.internal_from_handle((IntPtr)num7);
		string[] source2 = Enum.InternalGetNames((System.RuntimeType)enumType2);
		List<string> list2 = Enumerable.ToList(source2);
		((PurchaseHandler)(object)_typePopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list2, (string)null);
		SelectPopupButton powerupPopupButton = _powerupPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		EventDelegate.Callback callback3 = default;
		((Delegate)callback3).method_ptr = method_ptr3;
		((Delegate)callback3).method = (nint)__ldftn(CelebrationTesterPopup.PowerupSelected);
		object obj11 = callback3 + 16;
		obj11 = this;
		bool flag3 = EventDelegate.Remove(powerupPopupButton.onChange, callback3);
		object obj12 = obj7 + 12;
		obj12 = typeof(UpgradeType);
		((IntPtr*)num7)->m_value = (void*)(nint)obj12;
		Type enumType3 = Type.internal_from_handle((IntPtr)num7);
		string[] source3 = Enum.InternalGetNames((System.RuntimeType)enumType3);
		List<string> list3 = Enumerable.ToList(source3);
		((PurchaseHandler)(object)_powerupPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list3, (string)null);
		SelectPopupButton charPopupButton = _charPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		EventDelegate.Callback callback4 = default;
		((Delegate)callback4).method_ptr = method_ptr4;
		((Delegate)callback4).method = (nint)__ldftn(CelebrationTesterPopup.CharSelected);
		object obj13 = callback4 + 16;
		obj13 = this;
		bool flag4 = EventDelegate.Remove(charPopupButton.onChange, callback4);
		object obj14 = obj7 + 8;
		obj14 = typeof(Characters.CharacterId);
		((IntPtr*)num7)->m_value = (void*)(nint)obj14;
		Type enumType4 = Type.internal_from_handle((IntPtr)num7);
		string[] source4 = Enum.InternalGetNames((System.RuntimeType)enumType4);
		List<string> list4 = Enumerable.ToList(source4);
		((PurchaseHandler)(object)_charPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list4, (string)null);
		SelectPopupButton boardPopupButton = _boardPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		EventDelegate.Callback callback5 = default;
		((Delegate)callback5).method_ptr = method_ptr5;
		((Delegate)callback5).method = (nint)__ldftn(CelebrationTesterPopup.BoardSelected);
		object obj15 = callback5 + 16;
		obj15 = this;
		bool flag5 = EventDelegate.Remove(boardPopupButton.onChange, callback5);
		nint num10 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v85 (Il2CppClass<Info.Boards>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num11 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v163 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isVideoAddsSupported = EarnCoinsData.isVideoAddsSupported;
		List<string> list5 = Enumerable.ToList((IEnumerable<string>)isVideoAddsSupported);
		((PurchaseHandler)(object)_boardPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list5, (string)null);
		SelectPopupButton trophyPopupButton = _trophyPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		EventDelegate.Callback callback6 = default;
		((Delegate)callback6).method_ptr = method_ptr6;
		((Delegate)callback6).method = (nint)__ldftn(CelebrationTesterPopup.OldTrophySelected);
		object obj17 = callback6 + 16;
		obj17 = this;
		bool flag6 = EventDelegate.Remove(trophyPopupButton.onChange, callback6);
		object obj18 = obj7 + 4;
		obj18 = typeof(Trophies.Trophy);
		((IntPtr*)num7)->m_value = (void*)(nint)obj18;
		Type enumType5 = Type.internal_from_handle((IntPtr)num7);
		string[] source5 = Enum.InternalGetNames((System.RuntimeType)enumType5);
		List<string> list6 = Enumerable.ToList(source5);
		((PurchaseHandler)(object)_trophyPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list6, (string)null);
		object obj19 = this - -64;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr7 = 0;
		EventDelegate.Callback callback7 = default;
		((Delegate)callback7).method_ptr = method_ptr7;
		((Delegate)callback7).method = (nint)__ldftn(CelebrationTesterPopup.AwardSelected);
		object obj21 = callback7 + 16;
		obj21 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v59+2C]");
		bool flag7 = EventDelegate.Remove((List<EventDelegate>)0, callback7);
		object obj22 = this - -64;
		obj7 = typeof(AwardTierType);
		((IntPtr*)num7)->m_value = (void*)(nint)obj7;
		Type enumType6 = Type.internal_from_handle((IntPtr)num7);
		string[] source6 = Enum.InternalGetNames((System.RuntimeType)enumType6);
		List<string> list7 = Enumerable.ToList(source6);
		((PurchaseHandler)obj22).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list7, (string)null);
		SelectPopupButton amountPopupButton = _amountPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr8 = 0;
		EventDelegate.Callback callback8 = default;
		((Delegate)callback8).method_ptr = method_ptr8;
		((Delegate)callback8).method = (nint)__ldftn(CelebrationTesterPopup.NewAmountSelected);
		object obj23 = callback8 + 16;
		obj23 = this;
		bool flag8 = EventDelegate.Remove(amountPopupButton.onChange, callback8);
		SelectPopupButton topRunRankPopupButton = _topRunRankPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr9 = 0;
		EventDelegate.Callback callback9 = default;
		((Delegate)callback9).method_ptr = method_ptr9;
		((Delegate)callback9).method = (nint)__ldftn(CelebrationTesterPopup.NewRankSelected);
		object obj24 = callback9 + 16;
		obj24 = this;
		bool flag9 = EventDelegate.Remove(topRunRankPopupButton.onChange, callback9);
		SelectPopupButton themesPopupButton = _themesPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr10 = 0;
		EventDelegate.Callback callback10 = default;
		((Delegate)callback10).method_ptr = method_ptr10;
		((Delegate)callback10).method = (nint)__ldftn(CelebrationTesterPopup.NewThemesSelected);
		object obj25 = callback10 + 16;
		obj25 = this;
		bool flag10 = EventDelegate.Remove(themesPopupButton.onChange, callback10);
		nint num12 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S1_v143 (Il2CppClass<Globals>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num13 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S1_v157 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int fontSize = ((~(Globals.DEBUG_USE_CELEBRATION_TESTER ? 1u : 0u) != 0) ? ((int)"Enable") : ((int)"Disable"));
		buttonLabel.fontSize = fontSize;
	}

	public unsafe void TypeSelected()
	{
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected I, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_057a: Expected I, but got Obj
		//IL_0590: Expected Obj, but got I
		//IL_060b: Expected I, but got Obj
		//IL_0626: Expected I, but got Obj
		//IL_063c: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_05c4: Expected Obj, but got I4
		//IL_00d2: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton originPopupButton = _originPopupButton;
		string text = originPopupButton.value__BackingField;
		if (originPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton originPopupButton2 = _originPopupButton;
		nint num2 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v79 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v9 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v47 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(CelebrationRewardOrigin);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v39 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Enum)(object)type).ToString(originPopupButton2.value__BackingField, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void PowerupSelected()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected I, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0262: Expected I, but got Obj
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_00d2: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton typePopupButton = _typePopupButton;
		string text = typePopupButton.value__BackingField;
		if (typePopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton typePopupButton2 = _typePopupButton;
		nint num2 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v9 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v20 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(CelebrationRewardType);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v15 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Enum)(object)type).ToString(typePopupButton2.value__BackingField, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void CharSelected()
	{
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected I, but got Unknown
		//IL_01d9: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		SelectPopupButton powerupPopupButton = _powerupPopupButton;
		nint num = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v20 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v7 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v19 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(UpgradeType);
		nint num5 = (nint)(typeFromHandle + 4);
		((IntPtr*)num5)->m_value = (void*)(nint)typeFromHandle;
		Type type = Type.internal_from_handle((IntPtr)num5);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v15 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((Enum)(object)type).ToString(powerupPopupButton.value__BackingField, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void BoardSelected()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected I, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0262: Expected I, but got Obj
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_00d2: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton charPopupButton = _charPopupButton;
		string text = charPopupButton.value__BackingField;
		if (charPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton charPopupButton2 = _charPopupButton;
		nint num2 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v9 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v20 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(Characters.CharacterId);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v15 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Enum)(object)type).ToString(charPopupButton2.value__BackingField, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void OldTrophySelected()
	{
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected I, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0471: Expected I, but got Obj
		//IL_0487: Expected Obj, but got I
		//IL_0640: Expected I, but got Obj
		//IL_065b: Expected I, but got Obj
		//IL_0671: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_04bb: Expected Obj, but got I4
		//IL_00d2: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton boardPopupButton = _boardPopupButton;
		string text = boardPopupButton.value__BackingField;
		if (boardPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton boardPopupButton2 = _boardPopupButton;
		nint num2 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v52 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v9 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v55 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(Boards.BoardId);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S2_v84 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Enum)(object)type).ToString(boardPopupButton2.value__BackingField, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void AwardSelected()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected I, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0262: Expected I, but got Obj
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_00d2: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton trophyPopupButton = _trophyPopupButton;
		string text = trophyPopupButton.value__BackingField;
		if (trophyPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton trophyPopupButton2 = _trophyPopupButton;
		nint num2 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v9 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v20 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(Trophies.Trophy);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v15 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Enum)(object)type).ToString(trophyPopupButton2.value__BackingField, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void NewAmountSelected()
	{
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected I, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_0280: Expected I, but got Obj
		//IL_029b: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_0091: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		object obj2 = this - -64;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+24]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+24]");
		bool flag;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return;
		}
		object obj5 = this - -64;
		object obj6 = obj5;
		nint num2 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v11 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v22 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(AwardTierType);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v8 (Il2CppClass<System.Enum>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S2_v15 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20+24]");
		string text = ((Enum)(object)type).ToString((string)0, (IFormatProvider)1);
		throw new NullReferenceException();
	}

	public unsafe void NewRankSelected()
	{
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		SelectPopupButton amountPopupButton = _amountPopupButton;
		string text = amountPopupButton.value__BackingField;
		if (amountPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton amountPopupButton2 = _amountPopupButton;
		nint num = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		TypeCode typeCode = ((int*)amountPopupButton2.value__BackingField)->GetTypeCode();
		currentCelebrationReward.amount = (int)typeCode;
	}

	public unsafe void NewThemesSelected()
	{
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0085: Expected I, but got Obj
		SelectPopupButton topRunRankPopupButton = _topRunRankPopupButton;
		string text = topRunRankPopupButton.value__BackingField;
		if (topRunRankPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		SelectPopupButton topRunRankPopupButton2 = _topRunRankPopupButton;
		nint num = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v31 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = _currentCelebrationReward - -64;
		TypeCode typeCode = ((int*)topRunRankPopupButton2.value__BackingField)->GetTypeCode();
		obj2 = typeCode;
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		currentCelebrationReward.score = 123543510;
		CelebrationReward currentCelebrationReward2 = _currentCelebrationReward;
		currentCelebrationReward2.weekNumber = 12;
	}

	public void ToggleDebugCelebration()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_04b9: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_0336: Expected I, but got Obj
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_00d3: Expected I, but got Obj
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 8;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<HoverboardThemes.ThemeIdentifier> list = default;
		list._002Ector();
		SelectPopupButton themesPopupButton = _themesPopupButton;
		if (themesPopupButton.multipleValues__BackingField != null)
		{
			SelectPopupButton themesPopupButton2 = _themesPopupButton;
			Dictionary<string, string>.ValueCollection values = themesPopupButton2.multipleValues__BackingField.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @773C");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v99 (Il2CppClass<System.Type>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v140 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj2 = typeof(HoverboardThemes.ThemeIdentifier);
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v111 (Il2CppClass<System.Enum>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v133 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj9 = obj5 + 4;
			object obj10 = obj9 + 1;
			obj9 = obj10;
			object obj11 = obj10 << 2;
			object obj12 = obj5 + obj11;
			obj12 = 106;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+4]");
				object obj13 = (nint)0 << 2;
				object obj14 = obj5 + obj13;
				if ((nint)obj14 == 106)
				{
					object obj15 = obj5 + 4;
					if ((nint)obj15 > -1)
					{
						object obj16 = obj15 + -1;
						obj15 = obj16;
					}
					goto IL_04ab;
				}
			}
			object obj17 = default;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_04ab;
		IL_04ab:
		nint num5 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v27 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num6 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj19 = _currentCelebrationReward + 88;
		obj19 = list;
	}

	public static void RewardDebugCelebrationReward()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"SaveMePopup");
		nint num3 = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Revive>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		((Revive)(object)deviceToken)._002Ector();
	}

	public CelebrationTesterPopup()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0069: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected I4, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_CELEBRATION_TESTER = Globals.DEBUG_USE_CELEBRATION_TESTER;
		bool dEBUG_USE_CELEBRATION_TESTER2 = (byte)((dEBUG_USE_CELEBRATION_TESTER ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_USE_CELEBRATION_TESTER = dEBUG_USE_CELEBRATION_TESTER2;
		int fontSize = ((~(Globals.DEBUG_USE_CELEBRATION_TESTER ? 1u : 0u) != 0) ? ((int)"Enable") : ((int)"Disable"));
		buttonLabel.fontSize = fontSize;
	}

	static CelebrationTesterPopup()
	{
		//IL_0454: Expected I, but got Obj
		//IL_046a: Expected Obj, but got I
		//IL_064a: Expected I, but got Obj
		//IL_0660: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0518: Expected I, but got Obj
		//IL_052e: Expected Obj, but got I
		//IL_0179: Expected I, but got Obj
		//IL_049e: Expected I, but got Obj
		//IL_04b4: Expected Obj, but got I
		//IL_05dd: Expected I, but got Obj
		//IL_05f3: Expected Obj, but got I
		//IL_06a7: Expected I, but got Obj
		//IL_06bd: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_0778: Expected I, but got Obj
		//IL_078e: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_0729: Expected I, but got Obj
		//IL_073f: Expected Obj, but got I
		//IL_01df: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_036d: Expected I, but got Obj
		//IL_06e8: Expected I, but got Obj
		//IL_06fe: Expected Obj, but got I
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_03ba: Expected I, but got Obj
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_0407: Expected I, but got Obj
		//IL_026d: Expected I, but got Obj
		nint num = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v130 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		bool flag = currentCelebrationReward.rewardType == CelebrationRewardType.specialBoard;
		nint num3 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 != null;
		if (flag)
		{
			if (flag2)
			{
				nint num4 = (nint)typeof(CelebrationTesterPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v124 (Il2CppClass<CelebrationTesterPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward currentCelebrationReward2 = _currentCelebrationReward;
			nint num5 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v43 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v50 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.LockBoard(currentCelebrationReward2.boardId);
			nint num7 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v114 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v120 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			((UnityEngine.Object)instance).m_CachedPtr = (IntPtr)1;
		}
		else
		{
			if (flag2)
			{
				nint num9 = (nint)typeof(CelebrationTesterPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v101 (Il2CppClass<CelebrationTesterPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward currentCelebrationReward3 = _currentCelebrationReward;
			bool flag3 = currentCelebrationReward3.rewardType == CelebrationRewardType.character;
			nint num10 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v20 (Il2CppClass<CelebrationTesterPopup>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag4 = obj5 != null;
			if (!flag3)
			{
				if (flag4)
				{
					nint num11 = (nint)typeof(CelebrationTesterPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v95 (Il2CppClass<CelebrationTesterPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CelebrationReward currentCelebrationReward4 = _currentCelebrationReward;
				if (currentCelebrationReward4.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
				{
					nint num12 = (nint)typeof(CelebrationTesterPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v77 (Il2CppClass<CelebrationTesterPopup>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num13 = (nint)typeof(CelebrationTesterPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v89 (Il2CppClass<CelebrationTesterPopup>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CelebrationReward currentCelebrationReward5 = _currentCelebrationReward;
					currentCelebrationReward5.characterEventCompleted = 1;
					object obj7 = _currentCelebrationReward + 84;
					obj7 = "JAKE";
				}
			}
			else
			{
				if (flag4)
				{
					nint num14 = (nint)typeof(CelebrationTesterPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v63 (Il2CppClass<CelebrationTesterPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CelebrationReward currentCelebrationReward6 = _currentCelebrationReward;
				nint num15 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v25 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v32 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterManager.LockCharacter(currentCelebrationReward6.characterId);
				nint num17 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v51 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num18 = (nint)typeof(CharacterScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v57 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterScreen.forceRefreshOnCharacterScreen = true;
			}
		}
		nint num19 = (nint)typeof(CelebrationTesterPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v23 (Il2CppClass<CelebrationTesterPopup>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num20 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v30 (Il2CppClass<CelebrationTesterPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num21 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v9 (Il2CppClass<RewardManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num22 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v14 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.AddMysteryBoxToUnlock(_currentCelebrationReward);
	}
}
