using System;
using Cpp2ILInjected;
using Data.Managers;
using InApp;
using Info;

public class ExpiredLimitedCharacterEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static ExpiredLimitedCharacterEventManager Create(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ExpiredLimitedCharacterEventManager expiredLimitedCharacterEventManager = default;
		expiredLimitedCharacterEventManager._eventType = SSEventType.ExpiredLimitedBoard;
		expiredLimitedCharacterEventManager._eventType = eventType;
		expiredLimitedCharacterEventManager._eventID = eventID;
		return expiredLimitedCharacterEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventType = eventType;
		_eventID = eventID;
	}

	public unsafe SSEventType GetEventType()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Boards.BoardId eventValue = ((ExpiredLimitedBoardEventManager)this).GetEventValue<Boards.BoardId>(out reference);
		if (reference)
		{
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v23 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = BoardManager.HasAllThemesBeenSeen(eventValue);
			return (SSEventType)((flag ? 1 : 0) ^ 1);
		}
		return SSEventType.None;
	}

	public long GetEventID()
	{
		return _eventID;
	}

	public bool IsEventActive()
	{
		return (byte)_eventType != 0;
	}

	private bool ShouldEventBeAvailable()
	{
		if (_eventID > 0)
		{
			return (byte)((MysteryPowerupEventManager)this).GetEventType() != 0;
		}
		return false;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got I4
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_05a8: Expected I, but got Obj
		//IL_05be: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0632: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected I, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_013d: Expected I, but got Obj
		//IL_0605: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_06e2: Expected VT, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_01ff: Expected I, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_0299: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 20;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		ref bool reference = ref *(bool*)null;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v213 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v202 (Il2CppClass<EventTesterManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v209 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			SSEventCategory eventCategory = ((EventTesterManager)isInitialized).GetEventCategory();
			flag = (byte)eventCategory != 0;
		}
		else
		{
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v190 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v197 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			flag = ((OnlineSettings)(object)saveDataPath).GetValue("event_value", (byte)(int)string.Empty != 0);
		}
		nint num7 = (nint)(obj2 + 24);
		object obj8 = obj2 + 16;
		bool flag2;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v26 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			nint num8 = default;
			object obj9 = num8 + 24;
			object obj10 = obj9;
			nint num9 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v42 (Il2CppClass<System.Type>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num10 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v175 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj8 = obj10;
			((IntPtr*)num7)->m_value = (void*)(nint)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj13 = default;
			object obj12 = obj13;
			object obj15 = default;
			object obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj16 = default;
			if (obj14 == obj16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj18 = default;
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj20 = default;
				object obj19 = obj20;
			}
			else
			{
				object obj19 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		return (T)obj3;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_01fe: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Boards.BoardId eventValue = ((ExpiredLimitedBoardEventManager)this).GetEventValue<Boards.BoardId>(out reference);
		ref string reference2;
		ref string reference3;
		if (reference)
		{
			nint num = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v54 (Il2CppClass<Info.Boards>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v80 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item(eventValue);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v64 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v76 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_COMEBACK");
			string args = Strings.GetDefault(board.name);
			string text = string.Format(format, (object[])(object)args);
			string format2 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_LIMITED_BOARD");
			string args2 = Strings.GetDefault(board.name);
			string text2 = string.Format(format2, (object[])(object)args2);
			reference2 = ref *(string*)text2;
			reference3 = ref *(string*)text;
		}
		else
		{
			SDebug.LogFormat("ExpiredLimitedBoardEventManager - GetPopupDescription: The Board type does not exist.", null);
			reference2 = ref *(string*)string.Empty;
			reference3 = ref *(string*)string.Empty;
		}
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v45 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref string reference4;
		ref string reference5;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			reference4 = ref reference3;
			reference5 = ref reference2;
			return;
		}
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v33 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v39 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first", out reference3);
		reference4 = ref *(flag ? ((string*)1) : ((string*)null));
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second", out reference2);
		reference5 = ref *(flag2 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f5: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_EVENT_TESTER = Globals.DEBUG_USE_EVENT_TESTER;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		ref string reference;
		ref string reference2;
		if (dEBUG_USE_EVENT_TESTER)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v35 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_1");
			reference = ref *(string*)text;
			string text2 = Strings.GetDefault("EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_2");
			reference2 = ref *(string*)text2;
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_1");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_first", out *(string*)text3);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		string text4 = Strings.GetDefault("EVENTS_POPUP_WEDNESDAY_EVENT_TITLE_LINE_2");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_second", out *(string*)text4);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_042d: Expected I, but got Obj
		//IL_0443: Expected Obj, but got I
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_017b: Expected I, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_01c8: Expected I4, but got Obj
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_00da: Expected I, but got Obj
		//IL_0217: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		bool flag = default;
		ref bool reference = ref *(bool*)((flag ? 1 : 0) + 4);
		reference = ref *(bool*)null;
		((bool*)(flag ? 1 : 0))->m_value = false;
		string text = string.Empty;
		string text4;
		string text5;
		string text6;
		if (((ExpiredLimitedBoardEventManager)this).ShouldEventBeAvailable())
		{
			reference = ref *(bool*)null;
			Boards.BoardId eventValue = ((ExpiredLimitedBoardEventManager)this).GetEventValue<Boards.BoardId>(out reference);
			if (reference)
			{
				nint num = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v86 (Il2CppClass<Info.Boards>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Boards);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v114 (Il2CppClass<Info.Boards>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Boards.Board board = Boards.boardData.get_Item(eventValue);
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v96 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v110 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("EVENT_RIBBON_TEXT_WILD");
				string text3 = Strings.GetDefault("EVENT_RIBBON_TEXT_WEDNESDAY");
				string format = Strings.GetDefault("EVENT_RIBBON_TEXT_COMEBACK");
				string args = Strings.GetDefault(board.name);
				text = string.Format(format, (object[])(object)args);
				text4 = text2;
				text5 = text3;
			}
			else
			{
				text4 = string.Empty;
				text5 = string.Empty;
			}
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v38 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v78 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			text6 = text;
			if (!Globals.DEBUG_USE_EVENT_TESTER)
			{
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
				nint num7 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v47 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v74 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				bool flag2 = ((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_ribbon_text", flag);
				bool flag3 = !flag2;
				text6 = text;
				if (!flag3)
				{
					bool value = ((bool*)(flag ? 1 : 0))->m_value;
					bool flag4;
					if (~(((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v56 (System.Boolean)+8]");
						flag4 = (nint)0 == 0;
					}
					else
					{
						flag4 = true;
					}
					bool flag5 = !flag4;
					bool flag6 = !flag5;
					text6 = text;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						int num9 = default;
						object obj5 = num9 + 16;
						obj5 = 59;
						string text7 = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring(num9);
						object obj6 = text7 + 16;
						object obj7 = text7 + 20;
						object obj8 = text7 + 24;
						text4 = (string)obj6;
						text6 = (string)obj8;
						text5 = (string)obj7;
					}
				}
			}
		}
		else
		{
			text4 = string.Empty;
			text6 = string.Empty;
			text5 = string.Empty;
		}
		ref string reference2 = ref *(string*)text4;
		ref string reference3 = ref *(string*)text5;
		ref string reference4 = ref *(string*)text6;
	}

	public void SaveProgress()
	{
		_eventType = SSEventType.ExpiredLimitedBoard;
	}
}
