using System;
using Cpp2ILInjected;

public class MysteryPowerupEventManager : IEventManager
{
	private SSEventType _eventType = SSEventType.MysteryPowerup;

	private long _eventID;

	public static MysteryPowerupEventManager Create(SSEventType eventType, long eventID)
	{
		MysteryPowerupEventManager mysteryPowerupEventManager = default;
		mysteryPowerupEventManager._eventType = SSEventType.MysteryPowerup;
		mysteryPowerupEventManager._eventID = eventID;
		mysteryPowerupEventManager._eventType = eventType;
		return mysteryPowerupEventManager;
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
		return _eventID > 0;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0095: Expected VT, but got I
		//IL_00bd: Expected VT, but got I
		//IL_0038: Expected I, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		ref bool reference = ref *(bool*)null;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		string text = default;
		if ((object)typeFromHandle != null)
		{
			nint num2 = (nint)typeFromHandle;
			object obj4 = typeFromHandle + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S2_v4 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
		}
		else
		{
			text = null;
		}
		string text2 = "The Mystery Powerup Event does not contain a value of the specified type: " + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (T)0;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		string text2;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			string text = Strings.Get(StringID.EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_1);
			ref string reference = ref *(string*)text;
			text2 = Strings.Get(StringID.EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_2);
		}
		else
		{
			OnlineSettings instance = OnlineSettings.instance;
			string defaultValue = Strings.Get(StringID.EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_1);
			string value = instance.GetValue("event_popup_title_first", defaultValue);
			ref string reference = ref *(string*)value;
			OnlineSettings instance2 = OnlineSettings.instance;
			string defaultValue2 = Strings.Get(StringID.EVENTS_POPUP_MONDAY_EVENT_TITLE_LINE_2);
			text2 = instance2.GetValue("event_popup_title_second", defaultValue2);
		}
		ref string reference2 = ref *(string*)text2;
	}

	public unsafe void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		string text2;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			string text = Strings.Get(StringID.MYSTERY_POWERUP_POPUP_DESCRIPTION_TITLE);
			ref string reference = ref *(string*)text;
			text2 = Strings.Get(StringID.MYSTERY_POWERUP_POPUP_DESCRIPTION_SECOND_TITLE);
		}
		else
		{
			OnlineSettings instance = OnlineSettings.instance;
			string defaultValue = Strings.Get(StringID.MYSTERY_POWERUP_POPUP_DESCRIPTION_TITLE);
			string value = instance.GetValue("event_popup_description_first", defaultValue);
			ref string reference = ref *(string*)value;
			OnlineSettings instance2 = OnlineSettings.instance;
			string defaultValue2 = Strings.Get(StringID.MYSTERY_POWERUP_POPUP_DESCRIPTION_SECOND_TITLE);
			text2 = instance2.GetValue("event_popup_description_second", defaultValue2);
		}
		ref string reference2 = ref *(string*)text2;
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		ref string reference3 = ref *(string*)string.Empty;
	}

	public void UnHookFromGameEvents()
	{
	}
}
