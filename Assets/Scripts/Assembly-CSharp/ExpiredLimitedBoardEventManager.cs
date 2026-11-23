using System;
using Cpp2ILInjected;

public class ExpiredLimitedBoardEventManager : IEventManager
{
	private SSEventType _eventType = SSEventType.ExpiredLimitedBoard;

	private long _eventID;

	public static ExpiredLimitedBoardEventManager Create(SSEventType eventType, long eventID)
	{
		ExpiredLimitedBoardEventManager expiredLimitedBoardEventManager = default;
		expiredLimitedBoardEventManager._eventType = SSEventType.ExpiredLimitedBoard;
		expiredLimitedBoardEventManager._eventID = eventID;
		expiredLimitedBoardEventManager._eventType = eventType;
		return expiredLimitedBoardEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventID = eventID;
		_eventType = eventType;
	}

	public SSEventType GetEventType()
	{
		return _eventType;
	}

	public long GetEventID()
	{
		return _eventID;
	}

	public bool IsEventActive()
	{
		if (_eventID < 1)
		{
			return false;
		}
		return ShouldEventBeAvailable();
	}

	private unsafe bool ShouldEventBeAvailable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Hoverboards.BoardType eventValue = GetEventValue<Hoverboards.BoardType>(out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		if ((nint)0 != 0)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			bool flag = instance.IsHoverboardUnlocked(eventValue);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		bool result = default;
		return result;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0651: Expected VT, but got I
		//IL_0527: Expected VT, but got I4
		//IL_03af: Expected Obj, but got I
		//IL_03da: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0266: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		ref bool reference = ref *(bool*)null;
		string text;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager instance = EventTesterManager.Instance;
			text = instance.GetEventValue();
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			text = instance2.GetValue("event_value", string.Empty);
		}
		object obj4;
		if (text != null)
		{
			obj4 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0614;
			}
		}
		obj4 = 1;
		goto IL_0614;
		IL_05c9:
		T result = default;
		return result;
		IL_0614:
		if (obj4 == null)
		{
			nint num = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										reference = ref *(bool*)1;
										object obj5 = default;
										return (T)obj5;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_02a7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_02a7;
		}
		goto IL_0641;
		IL_0641:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (T)0;
		IL_02a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag = obj6 == obj7;
		bool flag2 = !flag;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj16 = (nint)0 << 2;
						object obj17 = obj16 + obj;
						object obj18 = obj17 - 4;
						object obj19 = obj18;
						reference = ref *(bool*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj20 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					result = (T)flag3;
					if (flag3)
					{
						goto IL_05c9;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			object obj21 = default;
			obj8 = obj21;
			if (flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_05c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0641;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		string text2;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			string text = Strings.Get(StringID.EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_1);
			ref string reference = ref *(string*)text;
			text2 = Strings.Get(StringID.EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_2);
		}
		else
		{
			OnlineSettings instance = OnlineSettings.instance;
			string defaultValue = Strings.Get(StringID.EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_1);
			string value = instance.GetValue("event_popup_title_first", defaultValue);
			ref string reference = ref *(string*)value;
			OnlineSettings instance2 = OnlineSettings.instance;
			string defaultValue2 = Strings.Get(StringID.EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_2);
			text2 = instance2.GetValue("event_popup_title_second", defaultValue2);
		}
		ref string reference2 = ref *(string*)text2;
	}

	public unsafe void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Hoverboards.BoardType eventValue = GetEventValue<Hoverboards.BoardType>(out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		string text3;
		string text4;
		if ((nint)0 != 0)
		{
			Hoverboards.Board board = Hoverboards.boardData.get_Item(eventValue);
			string format = Strings.Get(StringID.EVENTS_POPUP_DESCRIPTION_TITLE_LIMITED_BOARD);
			string arg = Strings.Get(board.name);
			string text = string.Format(format, arg);
			string format2 = Strings.Get(StringID.EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_LIMITED_BOARD);
			string arg2 = Strings.Get(board.name);
			string text2 = string.Format(format2, arg2);
			text3 = text2;
			text4 = text;
		}
		else
		{
			text3 = string.Empty;
			text4 = string.Empty;
		}
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			ref string reference = ref *(string*)text4;
		}
		else
		{
			OnlineSettings instance = OnlineSettings.instance;
			string value = instance.GetValue("event_popup_description_first", text4);
			ref string reference = ref *(string*)value;
			OnlineSettings instance2 = OnlineSettings.instance;
			string value2 = instance2.GetValue("event_popup_description_second", text3);
			text3 = value2;
		}
		ref string reference2 = ref *(string*)text3;
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Ref, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		bool flag = IsEventActive();
		bool flag2 = !flag;
		string text = string.Empty;
		string text2 = string.Empty;
		string text3 = string.Empty;
		object obj4;
		if (!flag2)
		{
			_ = 0;
			Hoverboards.BoardType eventValue = GetEventValue<Hoverboards.BoardType>(out *(bool*)(obj + 15));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
			bool flag3 = (nint)0 == 0;
			text = string.Empty;
			text2 = string.Empty;
			text3 = string.Empty;
			if (!flag3)
			{
				Hoverboards.Board board = Hoverboards.boardData.get_Item(eventValue);
				string text4 = Strings.Get(StringID.EVENT_RIBBON_TEXT_WILD);
				string text5 = Strings.Get(StringID.EVENT_RIBBON_TEXT_WEDNESDAY);
				string format = Strings.Get(StringID.EVENT_RIBBON_TEXT_COMEBACK);
				string arg = Strings.Get(board.name);
				string text6 = string.Format(format, arg);
				text = text6;
				text2 = text5;
				text3 = text4;
			}
			if (!Globals.DEBUG_USE_EVENT_TESTER)
			{
				_ = string.Empty;
				OnlineSettings instance = OnlineSettings.instance;
				if (instance.TryGetValue("event_ribbon_text", out *(string*)(obj + 8)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					if ((nint)0 != 0)
					{
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v50+8]");
						if ((nint)0 != 0)
						{
							goto IL_0284;
						}
					}
					obj4 = 1;
					goto IL_0284;
				}
			}
		}
		goto IL_025c;
		IL_025c:
		ref string reference = ref *(string*)text3;
		ref string reference2 = ref *(string*)text2;
		ref string reference3 = ref *(string*)text;
		return;
		IL_0284:
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			string[] array = ((string)0).Split(';');
			text = array[2];
			text2 = array[1];
			text3 = array[0];
		}
		goto IL_025c;
	}

	public void UnHookFromGameEvents()
	{
	}
}
