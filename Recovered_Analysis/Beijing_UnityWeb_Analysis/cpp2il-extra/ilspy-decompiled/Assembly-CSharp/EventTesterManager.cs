using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Automation;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class EventTesterManager
{
	private static Action m_OnEventTesterInfoChanged;

	private static EventTesterManager _instance;

	private Dictionary<string, string> _settings;

	public static EventTesterManager Instance
	{
		get
		{
			//IL_02a7: Expected I, but got Obj
			//IL_02bd: Expected Obj, but got I
			//IL_00f3: Expected I, but got Obj
			//IL_0109: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0304: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0181: Expected I, but got Obj
			//IL_0197: Expected Obj, but got I
			//IL_0134: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_01c2: Expected I, but got Obj
			//IL_020f: Expected I, but got Obj
			//IL_0225: Expected Obj, but got I
			//IL_033c: Expected Obj, but got I4
			//IL_0250: Expected I, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v73 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v59 (Il2CppClass<Globals>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v67 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(Globals.DEBUG_POPUP ? 1u : 0u) == 0)
				{
					goto IL_0173;
				}
			}
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v48 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v54 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DebugCloseAllPopups();
			goto IL_0173;
			IL_0173:
			nint num7 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v16 (Il2CppClass<Globals>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v40 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG ? 1u : 0u) == 0)
			{
				nint num9 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v26 (Il2CppClass<Globals>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v34 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool dEBUG_POPUP = Globals.DEBUG_POPUP;
				return (EventTesterManager)dEBUG_POPUP;
			}
			return null;
		}
	}

	public static bool isInitialized
	{
		get
		{
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0210: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0202: Expected I4, but got Obj
			//IL_0130: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_01c6: Expected Obj, but got I
			//IL_00c7: Expected I, but got Obj
			//IL_00f7: Expected I, but got Obj
			//IL_011d: Expected I, but got Obj
			nint num = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<EventTesterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				EventTesterPopup eventTesterPopup = default;
				eventTesterPopup.Init();
				nint num3 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<EventTesterManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 == null;
				nint num4 = (nint)typeof(EventTesterManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(EventTesterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<EventTesterManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(EventTesterManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(EventTesterManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<EventTesterManager>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				obj3 = eventTesterPopup;
			}
			nint num6 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<EventTesterManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)_instance != 0;
		}
	}

	public static event Action OnEventTesterInfoChanged
	{
		add
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			object obj = value + 96;
			object obj2 = default;
			obj = obj2;
			((UpgradeScreen)(object)value).Start();
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<EventTesterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onEventTesterInfoChanged = EventTesterManager.m_OnEventTesterInfoChanged;
			Action onEventTesterInfoChanged2 = default;
			while (true)
			{
				Delegate obj2 = onEventTesterInfoChanged.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<EventTesterManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(EventTesterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<EventTesterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)EventTesterManager.m_OnEventTesterInfoChanged == onEventTesterInfoChanged)
				{
					EventTesterManager.m_OnEventTesterInfoChanged = onEventTesterInfoChanged2;
				}
				if ((object)EventTesterManager.m_OnEventTesterInfoChanged != onEventTesterInfoChanged)
				{
					onEventTesterInfoChanged = EventTesterManager.m_OnEventTesterInfoChanged;
					continue;
				}
				break;
			}
		}
	}

	public long GetEventEndTime()
	{
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bd: Expected I8, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v20 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("social_report_min_seconds", 1200u);
		object obj2 = 0;
		if ((int)value > -1)
		{
			uint num3 = value;
		}
		else
		{
			uint num3 = 1200u;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3CA");
		return (long)obj2;
	}

	public unsafe long GetEventStartTime()
	{
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0039: Expected I8, but got I4
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
			string text = _settings.get_Item("event_end");
			return ((TimeSpan*)text)->Ticks;
		}
		return 0L;
	}

	public unsafe long GetEventID()
	{
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0039: Expected I8, but got I4
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
			string text = _settings.get_Item("event_start");
			return ((TimeSpan*)text)->Ticks;
		}
		return 0L;
	}

	public SSEventType GetEventType()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		return ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.lucy) ? SSEventType.SpecialPowerBoard : SSEventType.None;
	}

	public unsafe string GetEventValue()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected I, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		//IL_01c6: Expected I, but got Obj
		//IL_01dc: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
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
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<System.Type>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v30 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(SSEventType);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type type = Type.internal_from_handle((IntPtr)num);
			string text = _settings.get_Item("event_type");
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v10 (Il2CppClass<System.Enum>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v15 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = ((Enum)(object)type).ToString(text, (IFormatProvider)1);
			throw new NullReferenceException();
		}
		return null;
	}

	public SSEventCategory GetEventCategory()
	{
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_002f: Expected I4, but got Obj
		//IL_0021: Expected I4, but got Obj
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
			string text = _settings.get_Item("event_value");
			return (SSEventCategory)text;
		}
		return (SSEventCategory)string.Empty;
	}

	private EventTesterManager()
	{
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(EventTesterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<EventTesterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<EventTesterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate onEventTesterInfoChanged = EventTesterManager.m_OnEventTesterInfoChanged;
		Action onEventTesterInfoChanged2 = default;
		while (true)
		{
			Delegate obj2 = onEventTesterInfoChanged.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<EventTesterManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((object)EventTesterManager.m_OnEventTesterInfoChanged == onEventTesterInfoChanged)
			{
				EventTesterManager.m_OnEventTesterInfoChanged = onEventTesterInfoChanged2;
			}
			if ((object)EventTesterManager.m_OnEventTesterInfoChanged != onEventTesterInfoChanged)
			{
				onEventTesterInfoChanged = EventTesterManager.m_OnEventTesterInfoChanged;
				continue;
			}
			break;
		}
	}

	public void UpdateInfo(string eventType, string charType, string boardType, string eventCategory, string hoursLeft)
	{
		//IL_00a5: Expected I4, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00ba: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0131: Expected I4, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventTesterManager)+C]");
		((UILabel)0).fontSize = (int)charType;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventTesterManager)+10]");
		((UILabel)0).fontSize = (int)boardType;
		object obj = this + 32;
		obj = eventCategory;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v22 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("COIN_BUTTON_EARNER_GET");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventTesterManager)+14]");
		((UILabel)0).fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventTesterManager)+18]");
		((GameObject)0).tag = null;
		_ = 0;
		string tag = ((Component)this).tag;
		UIDragScrollView component = ((GameObject)(object)tag).GetComponent<UIDragScrollView>();
		object obj3 = component + 12;
		obj3 = hoursLeft;
	}

	private void UpdateTimeLimit(int hoursFromNow)
	{
		//IL_00ab: Expected Obj, but got I4
		//IL_000e: Expected VT, but got Obj
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_00de: Expected Obj, but got VT
		//IL_005d: Expected I, but got Obj
		if (!((string)hoursFromNow != "OK"))
		{
			return;
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		nint num = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v12 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string selectedBencharmProcessorPostfix = SubwayBenchmarkContainer.SelectedBencharmProcessorPostfix;
		((AutomationStepExecutor)val)._002Ector((IAutomationStep[])(object)selectedBencharmProcessorPostfix);
	}

	private void UpdateSettingValue(string key, string value)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.Title;
		object obj = debugSettingsCell + 16;
		obj = key;
		object obj2 = debugSettingsCell + 20;
		obj2 = value;
		debugSettingsCell.cellButtonIcon = ButtonIcon.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventTesterManager)+60]");
		((List<DebugSettingsCell>)0).Add(debugSettingsCell);
	}

	static EventTesterManager()
	{
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		DebugSettingsPopup._isShowingFps = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (Il2CppClass<DebugSettingsPopup>)+5C]");
		object obj6 = (nint)0 + (nint)4;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v8+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S4_v8 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v19 (Il2CppClass<DebugSettingsPopup>)+5C]");
		object obj13 = (nint)0 + (nint)12;
		object obj14 = default;
		obj13 = obj14;
		DebugSettingsPopup.notificationTypeToDisplay = DebugSettingsPopup.DebugNotificationType.Test;
		DebugSettingsPopup._guidelineToDebug = DebugSettingsPopup.DebugGuidelineType.Empty;
		DebugSettingsPopup.TimeScaleInGameOverrideSelectedValue = -1f;
		DebugSettingsPopup.TimeScaleInMenuOverrideSelectedValue = -1f;
		DebugSettingsPopup.DownloadNewOS = false;
		DebugSettingsPopup.RefreshInterstitials = false;
		DebugSettingsPopup.RefreshVideoAds = false;
		DebugSettingsPopup.HasDeliveredFullUpgrades = false;
		DebugSettingsPopup.ScreenTimoutDisabled = false;
		DebugSettingsPopup.HasSkippedMissions = false;
		DebugSettingsPopup.PrintRouteChunksInDebugLabel = false;
		DebugSettingsPopup._shouldRefreshListOnShow = true;
	}
}
