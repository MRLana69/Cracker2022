using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class EventTesterPopup : UIScreen
{
	private SelectPopupButton _eventTypePopupButton;

	private SelectPopupButton _charPopupButton;

	private SelectPopupButton _boardPopupButton;

	private SelectPopupButton _hoursLeftPopupButton;

	private SelectPopupButton _eventCategoryPopupButton;

	private GameObject boardTypeButton;

	private GameObject characterTypeButton;

	private GameObject _eventCategoryButton;

	private GameObject enableButton;

	private GameObject disableButton;

	private GameObject _updateButton;

	private string _hoursLeft;

	private string _charType;

	private string _boardType;

	private string _eventType;

	private string _eventCategory;

	public override void Init()
	{
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		((IngameScreen)this).reviveCount = 24;
		CheckDirty("event_value", "Slick");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private unsafe List<string> GetEventTypes()
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected I, but got Unknown
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_01ab: Expected I, but got Obj
		//IL_01c6: Expected I, but got Obj
		//IL_01dc: Expected Obj, but got I
		//IL_0068: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			string value = ((Dictionary<string, string>)(nint)((UnityEngine.Object)this).m_CachedPtr).get_Item("event_category");
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v22 (Il2CppClass<System.Type>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(SSEventCategory);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type enumType = Type.internal_from_handle((IntPtr)num);
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v17 (Il2CppClass<System.Enum>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v24 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Enum.GetName(enumType, value);
			throw new NullReferenceException();
		}
		return null;
	}

	public unsafe void EventTypeSelected()
	{
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03fd: Expected I, but got Obj
		//IL_0413: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected I, but got Unknown
		//IL_049c: Expected I, but got Obj
		//IL_04b7: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0188: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0276: Expected I4, but got Obj
		//IL_01dc: Expected I, but got Obj
		//IL_0296: Expected I, but got Obj
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0336: Expected I4, but got Obj
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		ShowIfInactive();
		SelectPopupButton eventTypePopupButton = _eventTypePopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(EventTesterPopup.EventTypeSelected);
		object obj = callback + 16;
		obj = this;
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v11 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v79 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(eventTypePopupButton.onChange, callback);
		int reviveCount = ((IngameScreen)null).reviveCount;
		((PurchaseHandler)(object)_eventTypePopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)reviveCount, (string)null);
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v18 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v71 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 4;
		obj4 = typeof(Characters.CharacterId);
		nint num5 = (nint)(obj5 + 8);
		((IntPtr*)num5)->m_value = (void*)(nint)obj4;
		Type enumType = Type.internal_from_handle((IntPtr)num5);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v26 (Il2CppClass<System.Enum>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v75 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] source = Enum.InternalGetNames((System.RuntimeType)enumType);
		List<string> list = Enumerable.ToList(source);
		SelectPopupButton charPopupButton = _charPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		EventDelegate.Callback callback2 = default;
		((Delegate)callback2).method_ptr = method_ptr2;
		((Delegate)callback2).method = (nint)__ldftn(EventTesterPopup.CharSelected);
		object obj7 = callback2 + 16;
		obj7 = this;
		bool flag2 = EventDelegate.Remove(charPopupButton.onChange, callback2);
		((PurchaseHandler)(object)_charPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list, (string)null);
		nint num8 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v37 (Il2CppClass<Info.Boards>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v67 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isVideoAddsSupported = EarnCoinsData.isVideoAddsSupported;
		List<string> list2 = Enumerable.ToList((IEnumerable<string>)isVideoAddsSupported);
		SelectPopupButton boardPopupButton = _boardPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		EventDelegate.Callback callback3 = default;
		((Delegate)callback3).method_ptr = method_ptr3;
		((Delegate)callback3).method = (nint)__ldftn(EventTesterPopup.BoardSelected);
		object obj9 = callback3 + 16;
		obj9 = this;
		bool flag3 = EventDelegate.Remove(boardPopupButton.onChange, callback3);
		((PurchaseHandler)(object)_boardPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list2, (string)null);
		obj5 = typeof(SSEventCategory);
		((IntPtr*)num5)->m_value = (void*)(nint)obj5;
		Type enumType2 = Type.internal_from_handle((IntPtr)num5);
		string[] source2 = Enum.InternalGetNames((System.RuntimeType)enumType2);
		List<string> list3 = Enumerable.ToList(source2);
		SelectPopupButton eventCategoryPopupButton = _eventCategoryPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		EventDelegate.Callback callback4 = default;
		((Delegate)callback4).method_ptr = method_ptr4;
		((Delegate)callback4).method = (nint)__ldftn(EventTesterPopup.EventCategorySelected);
		object obj10 = callback4 + 16;
		obj10 = this;
		bool flag4 = EventDelegate.Remove(eventCategoryPopupButton.onChange, callback4);
		((PurchaseHandler)(object)_eventCategoryPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list3, (string)null);
		SelectPopupButton hoursLeftPopupButton = _hoursLeftPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		EventDelegate.Callback callback5 = default;
		((Delegate)callback5).method_ptr = method_ptr5;
		((Delegate)callback5).method = (nint)__ldftn(EventTesterPopup.NewTimeLimitSelected);
		object obj11 = callback5 + 16;
		obj11 = this;
		bool flag5 = EventDelegate.Remove(hoursLeftPopupButton.onChange, callback5);
	}

	public void CharSelected()
	{
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_01ca: Expected I4, but got Obj
		//IL_01ca: Expected I4, but got Obj
		//IL_0195: Expected Obj, but got I4
		object obj = this - -64;
		((GameObject)obj).tag = null;
		boardTypeButton.tag = null;
		_eventCategoryButton.tag = null;
		SelectPopupButton eventTypePopupButton = _eventTypePopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj2 = num + 16;
		obj2 = 40;
		object obj3 = this + 96;
		string text = eventTypePopupButton.value__BackingField.Substring(num);
		object obj4 = text + 16;
		obj3 = obj4;
		if (_eventType == "CharacterDay" && _eventType == "ExpiredLimitedCharacter")
		{
			if (!(_eventType != "ExpiredLimitedBoard") && !(_eventType != "SpecialPowerBoard"))
			{
				if (_eventType != "CharacterName" || _eventType != "BiggerJackpot")
				{
					_eventCategoryButton.tag = (string)1;
				}
			}
			else
			{
				boardTypeButton.tag = (string)1;
			}
		}
		else
		{
			object obj5 = this - -64;
			((GameObject)obj5).tag = (string)1;
		}
		((IngameScreen)this).ToggleSpeedoMeterActive((IngameScreen.SpeedometerState)_eventType, (IngameScreen.PowerUpType)_eventType);
	}

	public void BoardSelected()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0034: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		object obj = this + 88;
		SelectPopupButton charPopupButton = _charPopupButton;
		obj = charPopupButton.value__BackingField;
		((IngameScreen)this).ToggleSpeedoMeterActive((IngameScreen.SpeedometerState)_charType, (IngameScreen.PowerUpType)_charType);
	}

	public void EventCategorySelected()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0034: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		object obj = this + 92;
		SelectPopupButton boardPopupButton = _boardPopupButton;
		obj = boardPopupButton.value__BackingField;
		((IngameScreen)this).ToggleSpeedoMeterActive((IngameScreen.SpeedometerState)_boardType, (IngameScreen.PowerUpType)_boardType);
	}

	public void NewTimeLimitSelected()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0034: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		object obj = this + 100;
		SelectPopupButton eventCategoryPopupButton = _eventCategoryPopupButton;
		obj = eventCategoryPopupButton.value__BackingField;
		((IngameScreen)this).ToggleSpeedoMeterActive((IngameScreen.SpeedometerState)_eventCategory, (IngameScreen.PowerUpType)_eventCategory);
	}

	private void CheckDirty(string originalValue, string newValue)
	{
		//IL_00dd: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v10 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S4_v11+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S4_v12+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S5_v9 (should have been resolved before IL gen)");
		}
		else
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v6+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v7+48]");
			object obj14 = 0;
			object obj15 = obj14 & 0x7FF;
			object obj16 = obj15 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public void UpdateEvent()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0034: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		object obj = this + 84;
		SelectPopupButton hoursLeftPopupButton = _hoursLeftPopupButton;
		obj = hoursLeftPopupButton.value__BackingField;
		((IngameScreen)this).ToggleSpeedoMeterActive((IngameScreen.SpeedometerState)_hoursLeft, (IngameScreen.PowerUpType)_hoursLeft);
	}

	public void EnableEvent()
	{
		this._002Ector();
		DisableEvent();
	}

	public void DisableEvent()
	{
		//IL_025d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_03a0: Expected I4, but got Obj
		//IL_03a0: Expected I4, but got Obj
		//IL_03a0: Expected Obj, but got I4
		//IL_03ae: Expected I, but got Obj
		//IL_03c4: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_02d2: Expected I, but got Obj
		//IL_02e8: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0401: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0362: Expected Obj, but got I4
		//IL_0188: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I4
		enableButton.tag = null;
		_updateButton.tag = null;
		disableButton.tag = (string)1;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v79 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Globals.DEBUG_USE_EVENT_TESTER = true;
		nint num3 = (nint)typeof(EventTesterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<EventTesterManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v75 (Il2CppClass<EventTesterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInitialized = EventTesterManager.isInitialized;
		((IngameScreen)isInitialized).AnimateGearAndGlow((IngameScreen.PowerUpType)_eventType, (int)_charType, (UISprite[])(object)_boardType, (UISprite[])(object)_eventCategory, (UILabel[])(object)_hoursLeft);
		nint num5 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v71 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		((UnityEngine.Object)instance).m_CachedPtr = (IntPtr)1;
		nint num7 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v33 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v65 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		nint num9 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v61 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		((OnlineSettings)(object)saveDataPath).LoadFromFile();
		nint num11 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v47 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v57 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).DebugCloseAllPopups();
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).DebugCloseAllPopups();
	}

	public EventTesterPopup()
	{
		//IL_01f8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_022d: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I
		//IL_02f0: Expected I, but got Obj
		//IL_0306: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0343: Expected I, but got Obj
		//IL_0359: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I4
		//IL_013b: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I4
		//IL_0188: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I4
		enableButton.tag = (string)1;
		_updateButton.tag = null;
		disableButton.tag = null;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v68 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Globals.DEBUG_USE_EVENT_TESTER = false;
		nint num3 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v64 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		((UnityEngine.Object)instance).m_CachedPtr = (IntPtr)1;
		nint num5 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v26 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v58 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		nint num7 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v54 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		((OnlineSettings)(object)saveDataPath).LoadFromFile();
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v40 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v50 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).DebugCloseAllPopups();
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).DebugCloseAllPopups();
	}
}
