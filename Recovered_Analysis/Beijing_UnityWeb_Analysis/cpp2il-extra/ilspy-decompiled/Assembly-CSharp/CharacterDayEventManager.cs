using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Info;

public class CharacterDayEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static CharacterDayEventManager Create(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterDayEventManager characterDayEventManager = default;
		characterDayEventManager._eventType = SSEventType.BiggerJackpot;
		characterDayEventManager._eventType = eventType;
		characterDayEventManager._eventID = eventID;
		return characterDayEventManager;
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
		//IL_033f: Expected VT, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_03c1: Expected VT, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04d8: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I
		//IL_0501: Expected VT, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref found) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("key");
			((Dictionary<object, bool>)(object)ex).Remove((object)null);
		}
		T result;
		if (_eventType != SSEventType.None)
		{
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v6+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj5 = default;
			object obj4 = obj5 & 0x7FFFFFFF;
			SSEventType eventType = _eventType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v18 (SSEventType)+C]");
			object obj8;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v18 (SSEventType)+C]");
				object obj6 = obj4 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v18 (SSEventType)+C]");
				object obj7 = obj6 * 0;
				obj8 = obj4 - obj7;
			}
			else
			{
				obj8 = 0;
			}
			object obj9 = _eventType + 16;
			object obj10 = obj8 << 2;
			object obj11 = obj9 + obj10;
			object obj12 = -1;
			object obj13 = obj11;
			object obj22 = default;
			while (true)
			{
				bool flag = (nint)obj13 < 0;
				result = (T)null;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
				object obj14 = (nint)0 + (nint)16;
				object obj15 = obj13 << 4;
				object obj16 = obj14 + obj15;
				if (obj16 == obj4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
					object obj17 = (nint)0 + (nint)16;
					object obj18 = obj13 << 4;
					object obj19 = obj17 + obj18;
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v30+60]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
					if (obj22 != null)
					{
						if ((nint)obj12 > -1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
							object obj23 = (nint)0 + (nint)16;
							object obj24 = obj12 << 4;
							object obj25 = obj23 + obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
							object obj26 = (nint)0 + (nint)16;
							object obj27 = obj13 << 4;
							object obj28 = obj26 + obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v74+4]");
							_ = 0;
						}
						else
						{
							object obj29 = _eventType + 16;
							object obj30 = obj8 << 2;
							object obj31 = obj29 + obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
							object obj32 = (nint)0 + (nint)16;
							object obj33 = obj13 << 4;
							object obj34 = obj32 + obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v66+4]");
							obj31 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
						object obj35 = (nint)0 + (nint)16;
						object obj36 = obj13 << 4;
						object obj37 = obj35 + obj36;
						obj37 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
						object obj38 = (nint)0 + (nint)16;
						object obj39 = obj13 << 4;
						object obj40 = obj38 + obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+18]");
						_ = 0;
						object obj41 = obj13 << 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
						object obj42 = 0 + obj41;
						object obj43 = obj42 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						object obj44 = obj13 << 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
						object obj45 = 0 + obj44;
						object obj46 = obj45 + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+1C]");
						object obj47 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+14]");
						object obj48 = (nint)0 + (nint)1;
						result = (T)1;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterDayEventManager)+C]");
				object obj49 = (nint)0 + (nint)16;
				object obj50 = obj13 << 4;
				object obj51 = obj49 + obj50;
				obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v39+4]");
				obj13 = 0;
			}
		}
		else
		{
			result = (T)null;
		}
		return result;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f5: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<Globals>)+74]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v32 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_JACKPOT");
			reference = ref *(string*)text;
			reference2 = ref *(string*)string.Empty;
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_JACKPOT");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first", out *(string*)text2);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second", out *(string*)string.Empty);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	public unsafe virtual void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_01df: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		ref bool reference3 = ref *(bool*)null;
		Characters.CharacterId eventValue = GetEventValue<Characters.CharacterId>(out reference3);
		if (reference3)
		{
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v34 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v69 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v44 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v65 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault(model.name);
			string text2 = text.ToUpperInvariant();
			reference = ref *(string*)text2;
			string text3 = Strings.GetDefault("EVENTS_POPUP_THURSDAY_EVENT_TITLE_LINE_2");
			reference2 = ref *(string*)text3;
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v51 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v59 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				return;
			}
		}
		else
		{
			SDebug.LogFormat("The CharacterDay Event does not contain a valid character type!", null);
		}
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v21 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v27 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Strings.TryGetLocalizedOnlineSettings("event_popup_title_first", out *(string*)firstTitle);
		reference = ref *(flag ? ((string*)1) : ((string*)null));
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_second", out *(string*)secondTitle);
		reference2 = ref *(flag2 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		ref string reference3 = ref *(string*)string.Empty;
		SDebug.LogFormat("The Bigger Jackpot Event does not contain information for a ribbon description", null);
	}

	public void SaveProgress()
	{
		_eventType = SSEventType.BiggerJackpot;
	}
}
