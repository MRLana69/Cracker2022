using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Missions;
using SYBO.Subway.Info;

public class ExpiredLimitedBoardEventManager : IEventManager
{
	private SSEventType _eventType;

	private long _eventID;

	public static ExpiredLimitedBoardEventManager Create(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterNameEventData characterNameEventData = default;
		characterNameEventData._002Ector();
		((ExpiredLimitedBoardEventManager)(object)characterNameEventData).Initialize(eventType, eventID);
		return (ExpiredLimitedBoardEventManager)(object)characterNameEventData;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_0267: Expected I, but got Obj
		//IL_027d: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_00ff: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		_eventType = eventType;
		_eventID = eventID;
		if (eventID <= 0)
		{
			return;
		}
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v39 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 24;
		string lastEventItemID = EventsSave.lastEventItemID;
		obj2 = lastEventItemID;
		((CharacterNameEventManager)this).SaveProgress();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19+28]");
		if (0 != eventID)
		{
			object obj4 = this + 24;
			List<Characters.CharacterId> characterList = ((CharacterNameEventManager)this).GetCharacterList();
			obj4 = characterList;
			nint num3 = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<Missions.AwardsData>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(AwardsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v35 (Il2CppClass<Missions.AwardsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v20 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v25 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
			EventsSave.lastEventItemID = (string)0;
		}
		if (((CharacterNameEventManager)this).IsFirstCharacterSelected())
		{
			((CharacterNameEventManager)this).ResetCollectProgress();
		}
	}

	public SSEventType GetEventType()
	{
		//IL_0035: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
			object obj = 0;
			Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v6+8]");
			return ((nint)0 == (nint)currentBoardId) ? SSEventType.SpecialPowerBoard : SSEventType.None;
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
			return (byte)((ExpiredLimitedCharacterEventManager)this).GetEventType() != 0;
		}
		return false;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0071: Expected VT, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0059: Invalid comparison between Obj and Ref
		//IL_0067: Expected VT, but got I4
		if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref found) > (nint)(-1))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			bool flag = System.Runtime.CompilerServices.Unsafe.IsAddressGreaterThan(ref *(byte*)obj2, ref System.Runtime.CompilerServices.Unsafe.As<bool, byte>(ref found));
			return (T)flag;
		}
		return (T)null;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_04f2: Expected I, but got Obj
		//IL_0508: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0645: Expected I, but got Obj
		//IL_065b: Expected Obj, but got I
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_02d7: Expected I, but got Obj
		//IL_0535: Expected Obj, but got I
		//IL_055d: Expected I, but got Obj
		//IL_0573: Expected Obj, but got I
		//IL_0477: Expected I, but got Obj
		//IL_048d: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0386: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I
		//IL_0324: Expected I, but got Obj
		//IL_023d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_028a: Expected I, but got Obj
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_00d4: Expected I, but got Obj
		//IL_03c7: Expected I, but got Obj
		//IL_0177: Expected I, but got Obj
		ref string reference;
		ref string reference2;
		if (GetEventType() != SSEventType.None)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v83 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v126 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_SELECT_CHARACTER_NAME");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
			bool flag = (nint)0 == 0;
			string text2 = string.Empty;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v47+8]");
				string text3 = ((CharacterNameEventManager)this).FilterCharacterName((string)0);
				text2 = text3;
			}
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v98 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v118 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				reference = ref *(string*)text;
				reference2 = ref *(string*)text2;
				return;
			}
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v106 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v112 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first_select_character_name", out *(string*)text);
			reference = ref *(flag2 ? ((string*)1) : ((string*)null));
			bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second_select_character_name", out *(string*)text2);
			reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
			return;
		}
		SSEventCategory eventCategoryFromOnlineSetting = ((CharacterNameEventManager)null).GetEventCategoryFromOnlineSetting();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
		bool flag4 = (nint)0 == 0;
		object[] args = (object[])(object)string.Empty;
		if (!flag4)
		{
			nint num7 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v66 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v76 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ExpiredLimitedBoardEventManager)+18]");
			object obj6 = 0;
			Dictionary<Characters.CharacterId, Characters.Model> characterData = Characters.characterData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v21+8]");
			Characters.Model model = characterData.get_Item(Characters.CharacterId.slick);
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v24 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v29 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault(model.name);
			args = (object[])(object)text4;
		}
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v26 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v61 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_UNLOCK_CHARACTER_NAME");
		string text5 = string.Format(format, args);
		nint num13 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v35 (Il2CppClass<Globals>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v55 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			reference = ref *(string*)(int)eventCategoryFromOnlineSetting;
			reference2 = ref *(string*)text5;
			return;
		}
		nint num15 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v43 (Il2CppClass<Strings>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first_unlock_character_name", out *(string*)(int)eventCategoryFromOnlineSetting);
		reference = ref *(flag5 ? ((string*)1) : ((string*)null));
		bool flag6 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second_unlock_character_name", out *(string*)text5);
		reference2 = ref *(flag6 ? ((string*)1) : ((string*)null));
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
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		ref string reference3 = ref *(string*)string.Empty;
		SDebug.LogFormat("The Character Name Event does not contain information for a ribbon description", null);
	}

	public void SaveProgress()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Characters.CharacterId> list = default;
		list._002Ector();
		object obj = this + 28;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list2 = default;
		list2._002Ector();
		object obj2 = this + 32;
		obj2 = list2;
		_ = 1;
	}
}
