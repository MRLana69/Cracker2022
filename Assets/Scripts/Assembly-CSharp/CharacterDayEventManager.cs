using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;

public class CharacterDayEventManager : IEventManager
{
	private SSEventType _eventType = SSEventType.CharacterDay;

	private long _eventID;

	public static CharacterDayEventManager Create(SSEventType eventType, long eventID)
	{
		CharacterDayEventManager characterDayEventManager = default;
		characterDayEventManager._eventType = SSEventType.CharacterDay;
		characterDayEventManager._eventID = eventID;
		characterDayEventManager._eventType = eventType;
		return characterDayEventManager;
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

	public unsafe bool IsEventActive()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Characters.CharacterType eventValue = GetEventValue<Characters.CharacterType>(out *(bool*)(obj + 15));
		bool result;
		if (AgeRestriction.isRestricted && eventValue == Characters.CharacterType.facebookRewardCharacter01)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			bool flag = instance.IsCharacterOwned(Characters.CharacterType.facebookRewardCharacter01);
			bool flag2 = !flag;
			result = false;
			if (flag2)
			{
				goto IL_00e9;
			}
		}
		bool flag3 = _eventID > 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		result = (byte)((nuint)0u & (nuint)(flag3 ? 1 : 0)) != 0;
		goto IL_00e9;
		IL_00e9:
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		_ = 0;
		Characters.CharacterType eventValue = GetEventValue<Characters.CharacterType>(out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		if ((nint)0 != 0)
		{
			string format = Strings.Get(StringID.EVENTS_POPUP_THURSDAY_EVENT_TITLE_LINE_1);
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			string text = Strings.Get(model.name);
			string arg = text.ToUpper();
			string text2 = string.Format(format, arg);
			reference = ref *(string*)text2;
			string text3 = Strings.Get(StringID.EVENTS_POPUP_THURSDAY_EVENT_TITLE_LINE_2);
			reference2 = ref *(string*)text3;
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				return;
			}
		}
		OnlineSettings instance = OnlineSettings.instance;
		string value = instance.GetValue("event_popup_title_first", firstLine);
		reference = ref *(string*)value;
		OnlineSettings instance2 = OnlineSettings.instance;
		string value2 = instance2.GetValue("event_popup_title_second", secondLine);
		reference2 = ref *(string*)value2;
	}

	public unsafe virtual void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Characters.CharacterType eventValue = GetEventValue<Characters.CharacterType>(out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		string text3;
		string defaultValue;
		if ((nint)0 != 0)
		{
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			string text = Strings.Get(StringID.EVENTS_POPUP_DESCRIPTION_TITLE_CHARACTER_DAY);
			string format = Strings.Get(StringID.EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_CHARACTER_DAY);
			string arg = Strings.Get(model.name);
			string text2 = string.Format(format, arg);
			text3 = text2;
			defaultValue = text;
		}
		else
		{
			text3 = string.Empty;
			defaultValue = string.Empty;
		}
		ref string reference;
		ref string reference2;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			reference = ref *(string*)text3;
			reference2 = ref *(string*)text3;
			return;
		}
		OnlineSettings instance = OnlineSettings.instance;
		string value = instance.GetValue("event_popup_description_first", defaultValue);
		reference = ref *(string*)value;
		OnlineSettings instance2 = OnlineSettings.instance;
		string value2 = instance2.GetValue("event_popup_description_second", text3);
		reference2 = ref *(string*)value2;
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Ref, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Ref, but got Unknown
		//IL_010d: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		Characters.CharacterType eventValue = GetEventValue<Characters.CharacterType>(out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		string text5;
		string text6;
		string text7;
		if ((nint)0 != 0)
		{
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			string text = Strings.Get(model.name);
			string text2 = text.ToUpper();
			string text3 = Strings.Get(StringID.EVENT_RIBBON_TEXT_THURSDAY);
			string text4 = Strings.Get(StringID.EVENT_RIBBON_TEXT_MULTIPLIER);
			text5 = text4;
			text6 = text3;
			text7 = text2;
		}
		else
		{
			text5 = string.Empty;
			text6 = string.Empty;
			text7 = string.Empty;
		}
		object obj4;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v46+8]");
					if ((nint)0 != 0)
					{
						goto IL_022e;
					}
				}
				obj4 = 1;
				goto IL_022e;
			}
		}
		goto IL_0215;
		IL_022e:
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			string[] array = ((string)0).Split(';');
			text5 = array[2];
			text6 = array[1];
			text7 = array[0];
		}
		goto IL_0215;
		IL_0215:
		ref string reference = ref *(string*)text7;
		ref string reference2 = ref *(string*)text6;
		ref string reference3 = ref *(string*)text5;
	}

	public void UnHookFromGameEvents()
	{
	}
}
