using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
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

	private unsafe void Start()
	{
		//IL_0052: Expected VT, but got Obj
		//IL_00d7: Expected VT, but got Obj
		//IL_0157: Expected VT, but got Obj
		SelectPopupButton eventTypePopupButton = _eventTypePopupButton;
		EventDelegate.Callback callback = default;
		callback._002Ector(this, (nint)__ldftn(EventTesterPopup.EventTypeSelected));
		EventDelegate eventDelegate = EventDelegate.Add(eventTypePopupButton.onChange, callback);
		List<string> eventTypes = GetEventTypes();
		_eventTypePopupButton.SetItems(eventTypes);
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Characters.CharacterType));
		string[] names = Enum.GetNames(typeFromHandle);
		List<string> items = Enumerable.ToList(names);
		SelectPopupButton charPopupButton = _charPopupButton;
		EventDelegate.Callback callback2 = default;
		callback2._002Ector(this, (nint)__ldftn(EventTesterPopup.CharSelected));
		EventDelegate eventDelegate2 = EventDelegate.Add(charPopupButton.onChange, callback2);
		_charPopupButton.SetItems(items);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Hoverboards.BoardType));
		string[] names2 = Enum.GetNames(typeFromHandle2);
		List<string> items2 = Enumerable.ToList(names2);
		SelectPopupButton boardPopupButton = _boardPopupButton;
		EventDelegate.Callback callback3 = default;
		callback3._002Ector(this, (nint)__ldftn(EventTesterPopup.BoardSelected));
		EventDelegate eventDelegate3 = EventDelegate.Add(boardPopupButton.onChange, callback3);
		_boardPopupButton.SetItems(items2);
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SSEventCategory));
		string[] names3 = Enum.GetNames(typeFromHandle3);
		List<string> items3 = Enumerable.ToList(names3);
		SelectPopupButton eventCategoryPopupButton = _eventCategoryPopupButton;
		EventDelegate.Callback callback4 = default;
		callback4._002Ector(this, (nint)__ldftn(EventTesterPopup.EventCategorySelected));
		EventDelegate eventDelegate4 = EventDelegate.Add(eventCategoryPopupButton.onChange, callback4);
		_eventCategoryPopupButton.SetItems(items3);
		SelectPopupButton hoursLeftPopupButton = _hoursLeftPopupButton;
		EventDelegate.Callback callback5 = default;
		callback5._002Ector(this, (nint)__ldftn(EventTesterPopup.NewTimeLimitSelected));
		EventDelegate eventDelegate5 = EventDelegate.Add(hoursLeftPopupButton.onChange, callback5);
	}

	private List<string> GetEventTypes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0290: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SSEventType));
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		List<string> list = default;
		list._002Ector();
		object obj3 = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+C]");
			if (0 <= (nint)obj3)
			{
				break;
			}
			_ = -1;
			obj = (Enum)(object)typeof(SSEventType);
			object obj4 = obj3 << 2;
			object obj5 = obj6 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v15+10]");
			_ = 0;
			string text = obj.ToString();
			object obj7 = obj3 << 2;
			object obj8 = obj6 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v37+10]");
			object obj9 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v37+10]");
			string item;
			if ((nint)0 != 1)
			{
				if ((nint)obj9 == 1)
				{
					string text2 = text + "(Fri)";
					item = text2;
					goto IL_0299;
				}
				if ((nint)obj9 != 2)
				{
					if ((nint)obj9 == 3)
					{
						string text3 = text + "(Tue)";
						item = text3;
						goto IL_0299;
					}
					if ((nint)obj9 == 4)
					{
						string text4 = text + "(Mon)";
						item = text4;
						goto IL_0299;
					}
					if ((nint)obj9 != 5)
					{
						if ((nint)obj9 != 6)
						{
							if ((nint)obj9 != 7)
							{
								item = text;
							}
							else
							{
								string text5 = text + "(Sat/Sun)";
								item = text5;
							}
						}
						else
						{
							string text6 = text + "(Thu)";
							item = text6;
						}
						goto IL_0299;
					}
				}
			}
			string text7 = text + "(Wed)";
			item = text7;
			goto IL_0299;
			IL_0299:
			list.Add(item);
			object obj10 = obj3 + 1;
			obj3 = obj10;
		}
		return list;
	}

	public void EventTypeSelected()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		characterTypeButton.SetActive(value: false);
		boardTypeButton.SetActive(value: false);
		_eventCategoryButton.SetActive(value: false);
		string[] array = ((string)null).Split('(', StringSplitOptions.None);
		_eventType = array[0];
		object obj = this + 76;
		bool flag = _eventType != "CharacterDay";
		object obj2 = obj;
		if (flag)
		{
			bool flag2 = _eventType != "ExpiredLimitedCharacter";
			obj2 = obj;
			if (flag2)
			{
				object obj3 = this + 72;
				bool flag3 = _eventType != "ExpiredLimitedBoard";
				obj2 = obj3;
				if (flag3)
				{
					bool flag4 = _eventType != "SpecialPowerBoard";
					obj2 = obj3;
					if (flag4)
					{
						object obj4 = this + 80;
						bool flag5 = _eventType != "CharacterName";
						obj2 = obj4;
						if (flag5)
						{
							bool flag6 = _eventType == "BiggerJackpot";
							bool flag7 = !flag6;
							obj2 = obj4;
							if (flag7)
							{
								goto IL_016d;
							}
						}
					}
				}
			}
		}
		((GameObject)obj2).SetActive(true);
		goto IL_016d;
		IL_016d:
		CheckDirty(_eventType, _eventType);
	}

	public void CharSelected()
	{
		_charType = null;
		CheckDirty(_charType, _charType);
	}

	public void BoardSelected()
	{
		_boardType = null;
		CheckDirty(_boardType, _boardType);
	}

	public void EventCategorySelected()
	{
		_eventCategory = null;
		CheckDirty(_eventCategory, _eventCategory);
	}

	public void NewTimeLimitSelected()
	{
		_hoursLeft = null;
		CheckDirty(_hoursLeft, _hoursLeft);
	}

	private void CheckDirty(string originalValue, string newValue)
	{
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0 && originalValue != newValue)
		{
			_updateButton.SetActive(value: true);
			disableButton.SetActive(value: false);
		}
	}

	public void UpdateEvent()
	{
		DisableEvent();
		EnableEvent();
	}

	public void EnableEvent()
	{
		enableButton.SetActive(value: false);
		_updateButton.SetActive(value: false);
		disableButton.SetActive(value: true);
		Globals.DEBUG_USE_EVENT_TESTER = true;
		EventTesterManager instance = EventTesterManager.Instance;
		instance.UpdateInfo(_eventType, _charType, _boardType, _eventCategory, _hoursLeft);
		BoardScreenManager instance2 = BoardScreenManager.Instance;
		instance2.forceRefreshOnBoardScreen__BackingField = true;
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		OnlineSettings instance3 = OnlineSettings.instance;
		instance3.DownloadNow();
		UIScreenController instance4 = UIScreenController.Instance;
		instance4.ClosePopup();
		UIScreenController instance5 = UIScreenController.Instance;
		instance5.ClosePopup();
		UIScreenController instance6 = UIScreenController.Instance;
		instance6.ClosePopup();
	}

	public void DisableEvent()
	{
		enableButton.SetActive(value: true);
		_updateButton.SetActive(value: false);
		disableButton.SetActive(value: false);
		Globals.DEBUG_USE_EVENT_TESTER = false;
		BoardScreenManager instance = BoardScreenManager.Instance;
		instance.forceRefreshOnBoardScreen__BackingField = true;
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		OnlineSettings instance2 = OnlineSettings.instance;
		instance2.DownloadNow();
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.ClosePopup();
		UIScreenController instance4 = UIScreenController.Instance;
		instance4.ClosePopup();
		UIScreenController instance5 = UIScreenController.Instance;
		instance5.ClosePopup();
	}
}
