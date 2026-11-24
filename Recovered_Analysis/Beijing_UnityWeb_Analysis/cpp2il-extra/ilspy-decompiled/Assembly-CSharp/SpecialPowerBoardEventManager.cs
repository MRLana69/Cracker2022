using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public class SpecialPowerBoardEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static SpecialPowerBoardEventManager Create(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SpecialPowerBoardEventManager specialPowerBoardEventManager = default;
		specialPowerBoardEventManager._eventType = SSEventType.MysteryPowerup;
		specialPowerBoardEventManager._eventType = eventType;
		specialPowerBoardEventManager._eventID = eventID;
		return specialPowerBoardEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventType = eventType;
		_eventID = eventID;
	}

	public SSEventType GetEventType()
	{
		return (_eventID > 0) ? SSEventType.SpecialPowerBoard : SSEventType.None;
	}

	public long GetEventID()
	{
		return _eventID;
	}

	public bool IsEventActive()
	{
		return (byte)_eventType != 0;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (this == null)
		{
			Exception source = System.Linq.Error.ArgumentOutOfRange("source");
			Enumerable.ElementAt((IEnumerable<System.Int32Enum>)source, 0);
		}
		nint num = default;
		object obj3 = num + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj5 = default;
		if (obj5 != null)
		{
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			T result = default;
			return result;
		}
		ref bool reference = default;
		if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) <= (nint)(-1))
		{
			int num2 = Enumerable.Sum((IEnumerable<int>)(object)"index");
			Enumerable.ElementAt((IEnumerable<System.Int32Enum>)num2, 0);
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj8 = default;
		ref bool reference2 = default;
		object obj11 = default;
		object obj12;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj10;
			if (obj8 != null)
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != null)
				{
					reference2 = ref System.Runtime.CompilerServices.Unsafe.Subtract(ref reference, 1);
					continue;
				}
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj10 = obj11;
				obj12 = obj13;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj10 = obj14;
			obj12 = obj13;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj15 = default;
		if (obj12 == obj15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		T result2 = default;
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj2 + obj17;
			if ((nint)obj18 == 102)
			{
				object obj19 = obj2 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				return result2;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			T result3 = default;
			return result3;
		}
		return result2;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
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
			string text = Strings.GetDefault("MYSTERY_POWERUP_POPUP_DESCRIPTION_TITLE");
			reference = ref *(string*)text;
			string text2 = Strings.GetDefault("MYSTERY_POWERUP_POPUP_DESCRIPTION_SECOND_TITLE");
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
		string text3 = Strings.GetDefault("MYSTERY_POWERUP_POPUP_DESCRIPTION_TITLE");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first", out *(string*)text3);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		string text4 = Strings.GetDefault("MYSTERY_POWERUP_POPUP_DESCRIPTION_SECOND_TITLE");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second", out *(string*)text4);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	public unsafe virtual void GetPopupDescription(out string firstTitle, out string secondTitle)
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
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		ref string reference3 = ref *(string*)string.Empty;
		SDebug.LogFormat("The Mystery Powerup Event does not contain information for a ribbon description", null);
	}

	public void SaveProgress()
	{
		_eventType = SSEventType.MysteryPowerup;
	}
}
