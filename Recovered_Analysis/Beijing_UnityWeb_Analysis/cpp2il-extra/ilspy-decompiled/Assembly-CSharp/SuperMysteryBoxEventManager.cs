using System;
using Cpp2ILInjected;
using InApp;
using Info;

public class SuperMysteryBoxEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static SuperMysteryBoxEventManager Create(SSEventType eventType, long eventID)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SuperMysteryBoxEventManager superMysteryBoxEventManager = default;
		superMysteryBoxEventManager._eventType = SSEventType.None;
		object obj = superMysteryBoxEventManager + 24;
		obj = eventType;
		superMysteryBoxEventManager._eventID = eventID;
		return superMysteryBoxEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventType = eventType;
		_eventID = eventID;
	}

	public unsafe SSEventType GetEventType()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected I4, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_013d: Expected I4, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_04ad: Expected Obj, but got I4
		//IL_04b9: Expected I4, but got Obj
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_02b0: Expected I, but got Obj
		//IL_02c6: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_02f1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 20;
		bool flag = (byte)(obj2 + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		if (((SSEventsManagerController)null).GetEnabledEventType() != SSEventType.None)
		{
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v24 (Il2CppClass<Globals>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v155 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v144 (Il2CppClass<EventTesterManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(EventTesterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v151 (Il2CppClass<EventTesterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInitialized = EventTesterManager.isInitialized;
				string eventValue = ((EventTesterManager)isInitialized).GetEventValue();
				return (SSEventType)eventValue;
			}
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v33 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v139 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_type", flag))
			{
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v43 (Il2CppClass<System.Type>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v129 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj2 = typeof(SSEventType);
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num9 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v92 (Il2CppClass<System.Enum>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v116 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj11 = default;
				object obj10 = obj11;
				object obj13 = default;
				object obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj14 = default;
				if (obj12 == obj14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj16 = default;
					object obj15 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj18 = default;
					object obj17 = obj18;
				}
				else
				{
					object obj17 = obj10;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
		SSEventType result = default;
		return result;
	}

	public unsafe long GetEventID()
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected I4, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_00ee: Expected I4, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_01b9: Expected I8, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01d0: Expected I8, but got I4
		IFormatProvider formatProvider = default;
		bool flag = (byte)(formatProvider + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v53 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long result = default;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v42 (Il2CppClass<EventTesterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v49 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			long eventID = ((EventTesterManager)isInitialized).GetEventID();
			result = eventID;
		}
		else
		{
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_start", flag))
			{
				formatProvider = (IFormatProvider)0;
				bool flag2 = (((bool*)(flag ? 1 : 0))->m_value ? ((long*)1) : ((long*)null))->System_002EIConvertible_002EToBoolean(formatProvider);
				bool flag3 = !flag2;
				bool flag4 = !flag3;
				result = (long)formatProvider;
				if (!flag4)
				{
					result = 0L;
				}
			}
		}
		return result;
	}

	public bool IsEventActive()
	{
		return (byte)_eventType != 0;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_0057: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		ref bool reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v11 (Il2CppClass<System.Type>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v24 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj3;
		nint num3 = (nint)(obj2 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num3);
		string msg = "The Mystery Powerup Event does not contain a value of the specified type: " + (string)(object)type;
		SDebug.LogFormat(msg, null);
		return (T)obj;
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
		Boards.BoardId eventValue = ((SpecialPowerBoardEventManager)this).GetEventValue<Boards.BoardId>(out reference);
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
			string format = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_POWER_BOARD");
			string args = Strings.GetDefault(board.name);
			string text = string.Format(format, (object[])(object)args);
			string format2 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_POWER_BOARD");
			string args2 = Strings.GetDefault(board.name);
			string text2 = string.Format(format2, (object[])(object)args2);
			reference2 = ref *(string*)text2;
			reference3 = ref *(string*)text;
		}
		else
		{
			SDebug.LogFormat("SpecialPowerBoardEventManager - GetPopupDescription: The Board type does not exist.", null);
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
			string text = Strings.GetDefault("EVENTS_POPUP_FRIDAY_EVENT_TITLE_LINE_1");
			reference = ref *(string*)text;
			string text2 = Strings.GetDefault("EVENTS_POPUP_FRIDAY_EVENT_TITLE_LINE_2");
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
		string text3 = Strings.GetDefault("EVENTS_POPUP_FRIDAY_EVENT_TITLE_LINE_1");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_first", out *(string*)text3);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		string text4 = Strings.GetDefault("EVENTS_POPUP_FRIDAY_EVENT_TITLE_LINE_2");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_second", out *(string*)text4);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_03e1: Expected I, but got Obj
		//IL_03f7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_0387: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_018f: Expected I4, but got Obj
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01de: Expected I, but got Obj
		//IL_0288: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = false;
		string text = string.Empty;
		ref bool reference = ref *(bool*)((flag ? 1 : 0) + 4);
		reference = ref *(bool*)null;
		Boards.BoardId eventValue = ((SpecialPowerBoardEventManager)this).GetEventValue<Boards.BoardId>(out reference);
		string text4;
		string text5;
		if (reference)
		{
			nint num = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v75 (Il2CppClass<Info.Boards>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v103 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item(eventValue);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v85 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v99 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("EVENT_RIBBON_TEXT_WILD");
			string text3 = Strings.GetDefault("EVENT_RIBBON_TEXT_WEDNESDAY");
			string format = Strings.GetDefault("EVENT_RIBBON_TEXT_TIME");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v67 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = (byte)(~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u)) != 0;
		bool flag3 = !flag2;
		string text6 = text;
		if (!flag3)
		{
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v63 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool flag4 = ((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_ribbon_text", flag);
			bool flag5 = !flag4;
			text6 = text;
			if (!flag5)
			{
				bool value = ((bool*)(flag ? 1 : 0))->m_value;
				bool flag6;
				if (~(((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v45 (System.Boolean)+8]");
					flag6 = (nint)0 == 0;
				}
				else
				{
					flag6 = true;
				}
				bool flag7 = !flag6;
				bool flag8 = !flag7;
				text6 = text;
				if (!flag8)
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
					text5 = (string)obj7;
					text6 = (string)obj8;
				}
			}
		}
		ref string reference2 = ref *(string*)text4;
		ref string reference3 = ref *(string*)text5;
		ref string reference4 = ref *(string*)text6;
	}

	public void SaveProgress()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SuperMysteryBoxEventManager)+C]");
		if ((nint)0 == 0)
		{
			((SSEventsManagerController)this).RestoreBoardAfterEventIfNeeded();
		}
	}
}
