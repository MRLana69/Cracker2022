using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.UI;
using Missions;
using SYBO.Subway.Info;
using UnityEngine;

public class CharacterNameEventManager : IEventManager
{
	public class LetterCollectedEventArgs : EventArgs
	{
		private char _characterCollected;

		public char CharacterCollected
		{
			get
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterNameEventManager+LetterCollectedEventArgs)+C]");
				return '\0';
			}
		}

		public LetterCollectedEventArgs(char characterCollected)
		{
			_characterCollected = characterCollected;
		}

		public override string ToString()
		{
			//IL_0007: Expected Obj, but got I4
			return (string)_characterCollected;
		}
	}

	private static EventHandler<LetterCollectedEventArgs> m_OnLetterCollected;

	private static Action<Characters.CharacterId, int> m_OnCharacterSkippedWithKeys;

	private static Action<Characters.CharacterId> m_OnCharacterSkippedWithVideo;

	public const string ONLINE_SETTING_DESCRIPTION_FIRST_UNLOCK_CHARATER_NAME = "event_popup_description_first_unlock_character_name";

	public const string ONLINE_SETTING_DESCRIPTION_SECOND_UNLOCK_CHARACTER_NAME = "event_popup_description_second_unlock_character_name";

	public const string ONLINE_SETTING_DESCRIPTION_FIRST_SELECT_CHARACTER_NAME = "event_popup_description_first_select_character_name";

	public const string ONLINE_SETTING_DESCRIPTION_SECOND_SELECT_CHARACTER_NAME = "event_popup_description_second_select_character_name";

	public const int DEFAULT_VALUE_FOR_COLLECT = -1;

	public static readonly char[] FILTERED_CHARACTERS;

	private SSEventType _eventType;

	private long _eventID;

	private CharacterNameEventData _eventProgressData;

	private bool _hasAddedAdSystemInitialisationEventListener;

	private Characters.CharacterId?[][] normalCharacters;

	private Characters.CharacterId?[][] _musicCharacters;

	private Characters.CharacterId?[][] _movieCharacters;

	private Characters.CharacterId?[][] _danceCharacters;

	private Characters.CharacterId[] _limitedCharacters;

	private Dictionary<Characters.CharacterId, string> _musicWordCollection;

	private Dictionary<Characters.CharacterId, string> _movieWordCollection;

	private Dictionary<Characters.CharacterId, string> _danceWordCollection;

	private List<SSEventCategory> _supportedCategories;

	public static event EventHandler<LetterCollectedEventArgs> OnLetterCollected
	{
		add
		{
			_ = 7;
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<CharacterNameEventManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
			EventHandler<LetterCollectedEventArgs> onLetterCollected2 = default;
			while (true)
			{
				Delegate obj2 = onLetterCollected.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(CharacterNameEventManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<CharacterNameEventManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)CharacterNameEventManager.m_OnLetterCollected == onLetterCollected)
				{
					CharacterNameEventManager.m_OnLetterCollected = onLetterCollected2;
				}
				if ((object)CharacterNameEventManager.m_OnLetterCollected != onLetterCollected)
				{
					onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<Characters.CharacterId, int> OnCharacterSkippedWithKeys
	{
		add
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<CharacterNameEventManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
			EventHandler<LetterCollectedEventArgs> onLetterCollected2 = default;
			while (true)
			{
				Delegate obj2 = onLetterCollected.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(CharacterNameEventManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<CharacterNameEventManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)CharacterNameEventManager.m_OnLetterCollected == onLetterCollected)
				{
					CharacterNameEventManager.m_OnLetterCollected = onLetterCollected2;
				}
				if ((object)CharacterNameEventManager.m_OnLetterCollected != onLetterCollected)
				{
					onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<CharacterNameEventManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterNameEventManager.m_OnCharacterSkippedWithKeys;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterNameEventManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterNameEventManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<CharacterNameEventManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterNameEventManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterNameEventManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<CharacterNameEventManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<Characters.CharacterId> OnCharacterSkippedWithVideo
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<CharacterNameEventManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterNameEventManager.m_OnCharacterSkippedWithKeys;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterNameEventManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterNameEventManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<CharacterNameEventManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterNameEventManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterNameEventManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<CharacterNameEventManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<CharacterNameEventManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterNameEventManager.m_OnCharacterSkippedWithVideo;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterNameEventManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterNameEventManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<CharacterNameEventManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterNameEventManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterNameEventManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<CharacterNameEventManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static CharacterNameEventManager Create(SSEventType eventType, long eventID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterNameEventManager characterNameEventManager = default;
		characterNameEventManager._eventType = SSEventType.CharacterDay;
		characterNameEventManager._eventType = eventType;
		characterNameEventManager._eventID = eventID;
		return characterNameEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventType = eventType;
		_eventID = eventID;
	}

	private void CheckIfDataIsValid()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = CharacterNameEventManager.m_OnCharacterSkippedWithVideo;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(CharacterNameEventManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<CharacterNameEventManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(CharacterNameEventManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(CharacterNameEventManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<CharacterNameEventManager>)+5C]");
			object obj5 = (nint)0 + (nint)8;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private CharacterNameEventData InitCharacterNameEventData()
	{
		return null;
	}

	public List<Characters.CharacterId> GetCharacterList()
	{
		//IL_0044: Expected VT, but got I4
		//IL_0044: Expected Obj, but got I4
		List<Characters.CharacterId> charactersToDisplay = GetCharactersToDisplay();
		List<Characters.CharacterId> callback = TrimEventCharactersList(charactersToDisplay);
		SSEventCategory eventCategory = GetEventCategory();
		Characters.CharacterId characterId = charactersToDisplay.get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RegisteredWaitHandle registeredWaitHandle = default;
		registeredWaitHandle._002Ector((WaitHandle)(object)charactersToDisplay, (WaitOrTimerCallback)(object)callback, (object)eventCategory, (TimeSpan)characterId, true);
		return (List<Characters.CharacterId>)(object)registeredWaitHandle;
	}

	public SSEventType GetEventType()
	{
		//IL_0062: Expected I4, but got Obj
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			if (eventProgressData.charactersList != null)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				return (SSEventType)eventProgressData2.charactersList;
			}
			return SSEventType.None;
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
		string msg = "The BiggerJackpot Event does not contain a value of the specified type: " + (string)(object)type;
		SDebug.LogFormat(msg, null);
		return (T)obj;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_021a: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Characters.CharacterId eventValue = ((CharacterDayEventManager)this).GetEventValue<Characters.CharacterId>(out reference);
		ref string reference2;
		ref string reference3;
		if (reference)
		{
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v54 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v79 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v64 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v75 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_CHARACTER_DAY");
			string format = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_CHARACTER_DAY");
			string args = Strings.GetDefault(model.name);
			string text2 = string.Format(format, (object[])(object)args);
			reference2 = ref *(string*)text;
			reference3 = ref *(string*)text2;
		}
		else
		{
			SDebug.LogFormat("CharacterDayEventManager - GetPopupDescription: The Character type in the Character Day Event does not exist.", null);
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
			reference4 = ref reference2;
			reference5 = ref reference3;
			return;
		}
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v33 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v39 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first", out reference2);
		reference4 = ref *(flag ? ((string*)1) : ((string*)null));
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second", out reference3);
		reference5 = ref *(flag2 ? ((string*)1) : ((string*)null));
	}

	public unsafe void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_016c: Expected I, but got Obj
		//IL_00fb: Expected I, but got Obj
		Characters.CharacterId?[][] currentCharacterCollection = GetCurrentCharacterCollection();
		object obj = currentCharacterCollection - 1;
		object key;
		if ((nint)currentCharacterCollection == 1)
		{
			key = "WEEKEND_EVENT_CATEGORY_MUSIC";
		}
		else if ((nint)obj == 1)
		{
			key = "WEEKEND_EVENT_CATEGORY_MOVIE";
		}
		else
		{
			key = (((nint)obj != 2) ? "EVENTS_POPUP_WEEKEND_EVENT_TITLE_LINE_1" : "WEEKEND_EVENT_CATEGORY_DANCE");
		}
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v11 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v43 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_EVENT_TESTER = Globals.DEBUG_USE_EVENT_TESTER;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		ref string reference;
		ref string reference2;
		if (dEBUG_USE_EVENT_TESTER)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault((string)key);
			reference = ref *(string*)text;
			string text2 = Strings.GetDefault("EVENTS_POPUP_WEEKEND_EVENT_TITLE_LINE_2");
			reference2 = ref *(string*)text2;
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault((string)key);
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_first", out *(string*)text3);
		reference = ref *(flag2 ? ((string*)1) : ((string*)null));
		string text4 = Strings.GetDefault("EVENTS_POPUP_WEEKEND_EVENT_TITLE_LINE_2");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_title_second", out *(string*)text4);
		reference2 = ref *(flag3 ? ((string*)1) : ((string*)null));
	}

	private string GetDescriptionTitleForCharacterNotOwned()
	{
		//IL_0083: Expected Obj, but got I4
		if (_eventID > 0)
		{
			if (_eventProgressData != null)
			{
				CharacterNameEventData eventProgressData = _eventProgressData;
				List<Characters.CharacterId> charactersList = eventProgressData.charactersList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v18 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				if ((nint)0 > (nint)0)
				{
					bool flag = ShouldSpawnLetters();
					return (string)((flag ? 1 : 0) ^ 1);
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		//IL_03d5: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0362: Expected I, but got Obj
		//IL_0378: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_0180: Expected I4, but got Obj
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01cf: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = false;
		string text = string.Empty;
		ref bool reference = ref *(bool*)((flag ? 1 : 0) + 4);
		reference = ref *(bool*)null;
		Characters.CharacterId eventValue = ((CharacterDayEventManager)this).GetEventValue<Characters.CharacterId>(out reference);
		string text5;
		string text6;
		if (reference)
		{
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v77 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v94 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(eventValue);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v36 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v44 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault(model.name);
			string text3 = text2.ToUpperInvariant();
			string text4 = Strings.GetDefault("EVENT_RIBBON_TEXT_THURSDAY");
			text = Strings.GetDefault("EVENT_RIBBON_TEXT_MULTIPLIER");
			text5 = text3;
			text6 = text4;
		}
		else
		{
			SDebug.LogFormat("CharacterDayEventManager - GetRibbonDescription: The Character type in the CharacterDay Event does not exist.", null);
			text5 = string.Empty;
			text6 = string.Empty;
		}
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v22 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v67 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = (byte)(~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u)) != 0;
		bool flag3 = !flag2;
		string text7 = text;
		if (!flag3)
		{
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v63 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool flag4 = ((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_ribbon_text", flag);
			bool flag5 = !flag4;
			text7 = text;
			if (!flag5)
			{
				bool value = ((bool*)(flag ? 1 : 0))->m_value;
				bool flag6;
				if (~(((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v45 (System.Boolean)+8]");
					flag6 = (nint)0 == 0;
				}
				else
				{
					flag6 = true;
				}
				bool flag7 = !flag6;
				bool flag8 = !flag7;
				text7 = text;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					int num9 = default;
					object obj5 = num9 + 16;
					obj5 = 59;
					string text8 = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring(num9);
					object obj6 = text8 + 16;
					object obj7 = text8 + 20;
					object obj8 = text8 + 24;
					text5 = (string)obj6;
					text6 = (string)obj7;
					text7 = (string)obj8;
				}
			}
		}
		ref string reference2 = ref *(string*)text5;
		ref string reference3 = ref *(string*)text6;
		ref string reference4 = ref *(string*)text7;
	}

	public void SaveProgress()
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_00ce: Expected VT, but got Obj
		//IL_00ce: Expected VT, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		CharacterNameEventData eventProgressData = _eventProgressData;
		List<string> categoryWordsList = eventProgressData.categoryWordsList;
		if (eventProgressData.categoryWordsList == null)
		{
			return;
		}
		object obj = 0;
		int num = default;
		object obj8 = default;
		int num5 = default;
		while (num < categoryWordsList._size)
		{
			string s = eventProgressData.categoryWordsList.get_Item(num);
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v9 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v19 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, string> dictionary = Strings.DeserializeObject(s);
			if (dictionary == null)
			{
				((Dictionary<TKey, TValue>)(object)eventProgressData.categoryWordsList).Add((TKey)num, (TValue)"");
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				List<Characters.CharacterId> charactersList = eventProgressData2.charactersList;
				CharacterNameEventData eventProgressData3 = _eventProgressData;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S6_v5 (Il2CppMethodInfo)+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S6_v6+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S6_v7+8C]");
				object obj5 = 0;
				object obj6 = obj5 & 0x7FF;
				object obj7 = obj6 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S7_v3 (should have been resolved before IL gen)");
				bool flag = num == (nint)obj8;
				object obj9 = obj | flag;
				obj = obj9;
			}
			num = num5 + 1;
		}
		if (obj != null)
		{
			CharacterNameEventData eventProgressData4 = _eventProgressData;
			eventProgressData4.collectedLetterIndex = -1;
		}
	}

	private List<string> CreateNewCategoryWordsDict(List<Characters.CharacterId> charactersList)
	{
		//IL_0093: Expected VT, but got Obj
		//IL_00af: Expected Obj, but got I8
		//IL_003f: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterNameEventManager)+C]");
		if ((nint)0 != 0)
		{
			UIScrollView uiScrollView = ((ScrollView)this).uiScrollView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v13 (UIScrollView)+104]");
			Transform transform = (Transform)0;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [charactersList @ L1 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+68]");
			if ((nint)transform2 < 0)
			{
				return (List<string>)1;
			}
		}
		else
		{
			UIPanel rootPanel = ((ScrollView)this).rootPanel;
			Transform transform = default;
			transform.localPosition = (Vector3)rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			object obj = 0 + _eventID;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [charactersList @ L1 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+5C]");
			if ((nint)obj < 0)
			{
				return (List<string>)1;
			}
		}
		return null;
	}

	private SSEventCategory GetEventCategoryFromOnlineSetting()
	{
		//IL_03b5: Expected I, but got Obj
		//IL_03cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0327: Expected I, but got Obj
		//IL_033d: Expected Obj, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_03f5: Expected I4, but got Obj
		//IL_0368: Expected I, but got Obj
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_013e: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_01cd: Expected I, but got Obj
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_025c: Expected I, but got Obj
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_02eb: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		CharacterNameEventManager characterNameEventManager = default;
		object key;
		if (characterNameEventManager != null)
		{
			Characters.CharacterId?[][] currentCharacterCollection = characterNameEventManager.GetCurrentCharacterCollection();
			object obj2 = currentCharacterCollection - 1;
			if ((nint)currentCharacterCollection != 1)
			{
				if ((nint)obj2 != 1)
				{
					if ((nint)obj2 == 2)
					{
						nint num3 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v27 (Il2CppClass<Strings>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						bool flag2 = obj3 == null;
						key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY3";
						if (!flag2)
						{
							nint num4 = (nint)typeof(Strings);
							key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY3";
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v31 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY3";
							}
						}
					}
					else
					{
						nint num5 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v34 (Il2CppClass<Strings>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						bool flag3 = obj4 == null;
						key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME";
						if (!flag3)
						{
							nint num6 = (nint)typeof(Strings);
							key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME";
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v38 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								goto IL_03fa;
							}
						}
					}
				}
				else
				{
					nint num7 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v20 (Il2CppClass<Strings>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					bool flag4 = obj5 == null;
					key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY2";
					if (!flag4)
					{
						nint num8 = (nint)typeof(Strings);
						key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY2";
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v24 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY2";
						}
					}
				}
			}
			else
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13 (Il2CppClass<Strings>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				bool flag5 = obj6 == null;
				key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY1";
				if (!flag5)
				{
					nint num10 = (nint)typeof(Strings);
					key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY1";
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v17 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME_CATEGORY1";
					}
				}
			}
			goto IL_03e8;
		}
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		goto IL_03fa;
		IL_03e8:
		return (SSEventCategory)Strings.GetDefault((string)key);
		IL_03fa:
		key = "EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME";
		goto IL_03e8;
	}

	public unsafe SSEventCategory GetEventCategory()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected I4, but got Unknown
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_051c: Expected I4, but got Obj
		//IL_013d: Expected I, but got Obj
		//IL_045c: Expected Obj, but got I4
		//IL_0567: Expected I4, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0261: Expected I, but got Obj
		//IL_0277: Expected Obj, but got I
		//IL_01cb: Expected I, but got Obj
		//IL_02a2: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		bool flag = (byte)(obj2 + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v159 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 20;
		List<string> list = default;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v148 (Il2CppClass<EventTesterManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v155 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			List<string> eventTypes = ((EventTesterPopup)isInitialized).GetEventTypes();
			list = eventTypes;
		}
		else
		{
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v143 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_category", flag))
			{
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v47 (Il2CppClass<System.Type>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v133 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj2 = typeof(SSEventCategory);
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num9 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v96 (Il2CppClass<System.Enum>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v120 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
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
		object obj19 = this - -64;
		if (!((List<SSEventCategory>)obj19).Contains((SSEventCategory)list))
		{
			list = null;
		}
		return (SSEventCategory)list;
	}

	private unsafe bool TryGetListNumberAndIndexInExtrasList(out int listNumber, out int indexInExtrasList)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got Ref
		//IL_004c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref listNumber);
		object obj3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref indexInExtrasList) & (nint)1;
		return flag;
	}

	private Characters.CharacterId?[][] GetCurrentCharacterCollection()
	{
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01b0: Expected I4, but got Obj
		//IL_0116: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
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
		List<string> list;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v28 (Il2CppClass<EventTesterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v35 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			list = ((EventTesterPopup)isInitialized).GetEventTypes();
		}
		else if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			list = (List<string>)eventProgressData.eventCategory;
		}
		else
		{
			list = null;
		}
		object obj3 = this - -64;
		if (((List<SSEventCategory>)obj3).Contains((SSEventCategory)list))
		{
			return (Characters.CharacterId?[][])(object)list;
		}
		return null;
	}

	private List<Characters.CharacterId> CreateNewCharacterList()
	{
		//IL_0018: Expected Obj, but got I4
		SSEventCategory eventCategory = GetEventCategory();
		object obj = eventCategory - 1;
		if (eventCategory != SSEventCategory.Cat1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					return (List<Characters.CharacterId>)(object)_danceCharacters;
				}
				return (List<Characters.CharacterId>)(object)normalCharacters;
			}
			return (List<Characters.CharacterId>)(object)_movieCharacters;
		}
		return (List<Characters.CharacterId>)(object)_musicCharacters;
	}

	public unsafe List<Characters.CharacterId> GetCharactersToDisplay()
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0311: Expected Obj, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0328: Expected Obj, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected VT, but got Unknown
		//IL_033f: Expected VT, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006b: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00a9: Expected VT, but got Obj
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02e3: Expected I4, but got Obj
		//IL_02e8: Expected I, but got Obj
		//IL_0200: Expected Ref, but got VT
		//IL_011d: Expected I, but got Obj
		//IL_0406: Expected I, but got Obj
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I
		//IL_02c1: Expected I4, but got Obj
		//IL_0165: Expected Ref, but got VT
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_03be: Expected I, but got Obj
		//IL_03cc: Expected I, but got Obj
		//IL_01b8: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 20);
		text = (string)0;
		Transform transform = (Transform)(obj + 16);
		transform = (Transform)0;
		Characters.CharacterId? characterId = (Characters.CharacterId?)(object)(obj + 8);
		characterId = (Characters.CharacterId?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Characters.CharacterId> list = default;
		list._002Ector();
		Transform childTransformByName = ((FollowingGuard)this).GetChildTransformByName(text, transform);
		if ((object)childTransformByName != null)
		{
			List<Characters.CharacterId> list2 = CreateNewCharacterList();
			object obj2 = list2 + 16;
			object obj3 = (object)text << 2;
			object obj4 = obj2 + obj3;
			object obj5 = obj4 + 12;
			nint num = (nint)transform;
			object obj6 = default;
			object obj16 = default;
			nint num5 = default;
			for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5); obj6 = obj16 + 1)
			{
				object obj7 = obj4 + 16;
				object obj8 = obj6 << 3;
				object obj9 = obj7 + obj8;
				obj = obj9;
				characterId = (Characters.CharacterId?)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4]");
				if ((nint)0 != 0)
				{
					nint num2 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v57 (Il2CppClass<Info.AgeRestriction>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num3 = (nint)typeof(AgeRestriction);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v69 (Il2CppClass<Info.AgeRestriction>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool waitForAgeRestriction = AgeRestriction.waitForAgeRestriction;
					bool flag = !waitForAgeRestriction;
					nint num4 = num5;
					if (!flag)
					{
						Characters.CharacterId value = ((Characters.CharacterId?*)characterId)->Value;
						nint num6 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v51 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num7 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v56 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = CharacterManager.IsCollectionComplete(value);
						bool flag3 = !flag2;
						num4 = (nint)typeof(CharacterManager);
						num5 = (nint)typeof(CharacterManager);
						if (flag3)
						{
							continue;
						}
					}
					Characters.CharacterId value2 = ((Characters.CharacterId?*)characterId)->Value;
					list.Add(value2);
					num5 = num4;
				}
				else if (GetEventCategory() == SSEventCategory.None)
				{
					Characters.CharacterId[] limitedCharacters = _limitedCharacters;
					if (num < limitedCharacters.Length)
					{
						object obj12 = _limitedCharacters + 16;
						object obj13 = num << 2;
						object obj14 = obj12 + obj13;
						list.Add((Characters.CharacterId)obj14);
					}
					else
					{
						object obj15 = _limitedCharacters + 16;
						list.Add((Characters.CharacterId)obj15);
						num = unchecked((nint)null);
					}
					nint num8 = num + 1;
					num5 = (nint)_limitedCharacters;
					num = num8;
				}
			}
			transform = (Transform)num;
		}
		return list;
	}

	private List<Characters.CharacterId> TrimEventCharactersList(List<Characters.CharacterId> allEventCharacters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03b1: Expected Obj, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I
		//IL_01a4: Expected I, but got Obj
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		SSEventCategory eventCategory = GetEventCategory();
		object obj6 = eventCategory - 1;
		Dictionary<Characters.CharacterId, string> dictionary;
		if (eventCategory != SSEventCategory.Cat1)
		{
			if ((nint)obj6 != 1)
			{
				if ((nint)obj6 != 2)
				{
					goto IL_03ef;
				}
				dictionary = _danceWordCollection;
			}
			else
			{
				dictionary = _movieWordCollection;
			}
		}
		else
		{
			dictionary = _musicWordCollection;
		}
		if (dictionary != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj7 = default;
			object obj8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				if (obj8 != null)
				{
					object obj9 = obj4;
				}
				else
				{
					nint num = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v102 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num2 = (nint)typeof(Characters);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v115 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v113+8]");
					object obj9 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj11 = obj5 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj5 + obj13;
			obj14 = 161;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj5 + obj15;
				if ((nint)obj16 == 161)
				{
					object obj17 = obj5 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					return (List<Characters.CharacterId>)(object)list;
				}
			}
			object obj19 = default;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				goto IL_03ef;
			}
			return (List<Characters.CharacterId>)(object)list;
		}
		return (List<Characters.CharacterId>)(object)list;
		IL_03ef:
		List<string> result = default;
		return (List<Characters.CharacterId>)(object)result;
	}

	public int GetLastSelectedThemeForCharacterType(Characters.CharacterId charId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_0438: Expected I4, but got Obj
		//IL_0274: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Characters.CharacterId> list = default;
		list._002Ector();
		object obj13;
		object obj14;
		object obj15;
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v5+60]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v6+8C]");
			object obj7 = 0;
			object obj8 = obj7 & 0x7FF;
			object obj9 = obj8 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S5_v6 (should have been resolved before IL gen)");
			object obj10 = default;
			if (obj10 != null)
			{
				object obj11 = obj10 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [charId @ L1 (SYBO.Subway.Info.Characters+CharacterId)+C]");
				object obj12 = -1;
				bool flag = obj10 != obj12;
				obj13 = obj10;
				obj14 = obj11;
				if (!flag)
				{
					obj15 = obj10;
					obj14 = obj11;
					goto IL_0389;
				}
			}
			else
			{
				obj13 = 0;
				obj14 = 0;
			}
		}
		else
		{
			obj13 = 0;
			obj14 = 0;
		}
		object obj16 = obj13 + 1;
		obj15 = obj16;
		goto IL_0389;
		IL_0389:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj17 = default;
		object obj18 = default;
		object obj20 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj17 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
			object obj19 = flag2 | flag3;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			obj18 = obj20 + 1;
		}
		object obj21 = obj4 + 4;
		object obj22 = obj21 + 1;
		obj21 = obj22;
		object obj23 = obj22 << 2;
		object obj24 = obj4 + obj23;
		obj24 = 147;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj25 = (nint)0 << 2;
			object obj26 = obj4 + obj25;
			if ((nint)obj26 == 147)
			{
				object obj27 = obj4 + 4;
				if ((nint)obj27 > -1)
				{
					object obj28 = obj27 + -1;
					obj27 = obj28;
				}
				goto IL_0433;
			}
		}
		object obj29 = default;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0433;
		IL_0433:
		return (int)list;
	}

	public bool IsShowingFirstElement()
	{
		//IL_005b: Expected I4, but got Obj
		//IL_001e: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Characters.CharacterId> list = default;
		list._002Ector();
		bool flag = _eventProgressData == null;
		int result = (int)list;
		if (!flag)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			int lastSelectedThemeForCharacterType = GetLastSelectedThemeForCharacterType((Characters.CharacterId)eventProgressData.charactersList);
			result = lastSelectedThemeForCharacterType;
		}
		return (byte)result != 0;
	}

	public bool IsShowingLastElement()
	{
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			List<Characters.CharacterId> charactersList = eventProgressData.charactersList;
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S4_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v5+8C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x7FF;
			object obj5 = obj4 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			return obj6 == null;
		}
		return false;
	}

	public void SkipCurrentCharacter()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (_eventProgressData == null)
		{
			return;
		}
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventsSave.lastEventItemID = (string)(object)_eventProgressData;
	}

	public unsafe Characters.CharacterId? GetNextCharacterToDisplay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected I4, but got Unknown
		//IL_1083: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Expected Obj, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected Obj, but got Unknown
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected Obj, but got Unknown
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_10bb: Expected Obj, but got I4
		//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cf: Expected Obj, but got Unknown
		//IL_10d8: Expected Obj, but got I4
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Expected Obj, but got Unknown
		//IL_10f5: Expected Obj, but got I4
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_110f: Expected Obj, but got Unknown
		//IL_1118: Expected Obj, but got I4
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Expected Obj, but got Unknown
		//IL_113b: Expected Obj, but got I4
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected Obj, but got Unknown
		//IL_1185: Expected I, but got Obj
		//IL_119b: Expected Obj, but got I
		//IL_1519: Expected Obj, but got I4
		//IL_1547: Expected I4, but got Obj
		//IL_0ad6: Expected I4, but got Obj
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected VT, but got Unknown
		//IL_0b0b: Expected VT, but got I4
		//IL_0a8a: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I4
		//IL_0dcb: Expected Obj, but got I4
		//IL_0b78: Expected Obj, but got I4
		//IL_1062: Expected VT, but got Obj
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_0700: Expected I4, but got Obj
		//IL_0731: Expected Obj, but got I
		//IL_149d: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Expected Obj, but got Unknown
		//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b0: Expected Obj, but got Unknown
		//IL_14dc: Expected Obj, but got I4
		//IL_14e5: Expected Obj, but got I4
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_056a: Expected I4, but got Obj
		//IL_0593: Expected Obj, but got F4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0180: Expected I4, but got Obj
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got F4
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected Obj, but got Unknown
		//IL_138a: Unknown result type (might be due to invalid IL or missing references)
		//IL_138f: Expected Obj, but got Unknown
		//IL_13bb: Expected Obj, but got I4
		//IL_13c4: Expected Obj, but got I4
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_07de: Expected Obj, but got F4
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_11c1: Expected Obj, but got F4
		//IL_11ef: Expected I4, but got Obj
		//IL_1213: Expected I4, but got Obj
		//IL_1236: Unknown result type (might be due to invalid IL or missing references)
		//IL_123b: Expected VT, but got Unknown
		//IL_1248: Expected VT, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f0: Expected I4, but got Obj
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I
		//IL_0e23: Expected Obj, but got I
		//IL_1317: Expected I4, but got Obj
		//IL_1339: Expected F4, but got I
		//IL_135b: Expected F4, but got Obj
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_06c0: Expected Obj, but got F4
		//IL_0284: Expected VT, but got Obj
		//IL_1707: Unknown result type (might be due to invalid IL or missing references)
		//IL_170c: Expected Obj, but got Unknown
		//IL_1719: Expected I4, but got Obj
		//IL_1736: Expected Obj, but got I
		//IL_1757: Unknown result type (might be due to invalid IL or missing references)
		//IL_175c: Expected Obj, but got Unknown
		//IL_0edb: Expected Obj, but got I
		//IL_0bd0: Expected Obj, but got I
		//IL_0297: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I
		//IL_0f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f93: Expected Obj, but got Unknown
		//IL_0fb1: Expected Obj, but got F4
		//IL_1008: Expected Obj, but got F4
		//IL_1675: Unknown result type (might be due to invalid IL or missing references)
		//IL_167a: Expected Obj, but got Unknown
		//IL_1687: Expected I4, but got Obj
		//IL_169c: Expected Obj, but got F4
		//IL_16c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ca: Expected Obj, but got Unknown
		//IL_0c88: Expected Obj, but got I
		//IL_15df: Expected I4, but got Obj
		//IL_1603: Expected I4, but got Obj
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_162b: Expected VT, but got Unknown
		//IL_1638: Expected VT, but got I4
		//IL_1285: Expected I4, but got Obj
		//IL_13e6: Expected Obj, but got I4
		//IL_1414: Expected I4, but got Obj
		//IL_1438: Expected I4, but got Obj
		//IL_145b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1460: Expected VT, but got Unknown
		//IL_146d: Expected VT, but got I4
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected Obj, but got Unknown
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Expected Obj, but got Unknown
		//IL_0da3: Expected Obj, but got F4
		//IL_02d8: Expected I, but got Obj
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected Obj, but got Unknown
		//IL_08a0: Expected I4, but got Obj
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected Obj, but got Unknown
		//IL_156c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1571: Expected Obj, but got Unknown
		//IL_158b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Expected Obj, but got Unknown
		//IL_15a2: Expected I4, but got Obj
		//IL_15ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b0: Expected Obj, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4c: Expected Obj, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_093c: Expected I4, but got Obj
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_09a6: Expected Obj, but got I
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected Obj, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 208;
		int num = obj2 + 176;
		object obj3 = obj2 + 160;
		object obj4 = obj2 + 40;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 148;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 136;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 112;
		obj8 = 0;
		_ = 0;
		_ = 0;
		object obj9 = obj2 + 88;
		obj9 = 0;
		_ = 0;
		_ = 0;
		object obj10 = obj2 + 72;
		obj10 = 0;
		_ = 0;
		object obj11 = obj2 - -64;
		obj11 = obj;
		_ = -1;
		ScrollView scrollView = default;
		float num3 = default;
		if (this != null)
		{
			if ((nint)this == 1)
			{
				ScrollView.RecycleBin recycleBin = scrollView._recycleBin;
				if (scrollView._arrangement != ScrollView.Arrangement.Vertical)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
					obj10 = ((int*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					_ = 0;
					object obj12 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj12 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v464+4C]");
						object obj13 = (nint)0 + (nint)scrollView.cellSpaceX;
						float num2 = num3 + (float)obj13;
						num3 = num2;
					}
					object obj14 = obj11 + 4;
					object obj15 = obj14 + 1;
					obj14 = obj15;
					object obj16 = obj15 << 2;
					object obj17 = obj11 + obj16;
					obj17 = 1320;
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37+4]");
						object obj19 = (nint)0 << 2;
						object obj20 = obj11 + obj19;
						if ((nint)obj20 == 1320)
						{
							object obj21 = obj11 + 4;
							if ((nint)obj21 > -1)
							{
								object obj22 = obj21 + -1;
								obj21 = obj22;
							}
							goto IL_165f;
						}
					}
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
					goto IL_165f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj10 = ((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
				_ = 0;
				object obj23 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj23 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v391+48]");
					object obj24 = (nint)0 + (nint)scrollView.cellSpaceY;
					float num4 = num3 + (float)obj24;
					num3 = num4;
				}
				object obj25 = obj11 + 4;
				object obj26 = obj25 + 1;
				obj25 = obj26;
				object obj27 = obj26 << 2;
				object obj28 = obj11 + obj27;
				obj28 = 1138;
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37+4]");
					object obj30 = (nint)0 << 2;
					object obj31 = obj11 + obj30;
					if ((nint)obj31 == 1138)
					{
						object obj32 = obj11 + 4;
						if ((nint)obj32 > -1)
						{
							object obj33 = obj32 + -1;
							obj32 = obj33;
						}
						goto IL_16f1;
					}
				}
				if (obj29 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_16f1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArithmeticException ex = default;
			ex._002Ector("mode");
			((ScrollView)(object)ex).CalculateVirtualRelativeWidgetBounds(ScrollView.BoundsCalculationMode.FullSize);
			return (Characters.CharacterId?)(object)ex;
		}
		if (scrollView._recycleBin != null)
		{
			if (scrollView._infinite == ScrollView.Infinite.None)
			{
				object obj34 = 0;
				object obj35 = default;
				Container item = default;
				Container container = default;
				int modelType = default;
				object obj37 = default;
				float num11 = default;
				float num14 = default;
				object obj38 = default;
				object obj41 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					bool flag = ((ScrollView._003C_003Ec__DisplayClass83_0)(object)scrollView._recycleBin)._003CSmoothScrollToIndex_003Eb__0(item);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					container.modelType = modelType;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					UIScrollView uiScrollView = scrollView.uiScrollView;
					GameObject gameObject = uiScrollView.gameObject;
					container.SetScale((Vector3)gameObject);
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ S0_v202 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num6 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ S0_v248 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					((int*)num)->m_value = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					container.SetModelType(num);
					if (scrollView._arrangement == ScrollView.Arrangement.Horizontal)
					{
						float num7 = container.width + (float)scrollView.cellSpaceX;
						float num8 = num3 + num7;
						if (scrollView._topDataIndexCursor >= 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							if (scrollView._topDataIndexCursor < (nint)obj37 && scrollView._topDataIndexCursor > (nint)obj34)
							{
								float num9 = container.width + (float)scrollView.cellSpaceX;
								float num10 = num11 + num9;
								num11 = num10;
							}
						}
						num3 = num8;
					}
					else
					{
						float num12 = container.height + (float)scrollView.cellSpaceY;
						float num13 = num14 + num12;
						bool flag2 = scrollView._topDataIndexCursor >= 0;
						bool flag3 = !flag2;
						num14 = num13;
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							bool flag4 = scrollView._topDataIndexCursor < (nint)obj38;
							bool flag5 = !flag4;
							num14 = num13;
							if (!flag5)
							{
								bool flag6 = scrollView._topDataIndexCursor > (nint)obj34;
								bool flag7 = !flag6;
								num14 = num13;
								if (!flag7)
								{
									float num15 = container.height + (float)scrollView.cellSpaceY;
									float num16 = num11 + num15;
									num11 = num16;
									num14 = num13;
								}
							}
						}
					}
					object obj39 = container + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					object obj40 = obj41 + 0;
					((ScrollView._003CAnimateSwapPositions_003Ed__86)(object)scrollView._recycleBin)._002Ector((int)container);
					object obj42 = obj34 + 1;
					obj34 = obj42;
				}
				if (scrollView._arrangement == ScrollView.Arrangement.Horizontal)
				{
					UIScrollView uiScrollView2 = scrollView.uiScrollView;
					object obj43 = uiScrollView2 + 220;
					((int*)num)->m_value = (int)obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S1_v184+8]");
					_ = 0;
					float num17 = num3 - (float)scrollView.cellSpaceX;
					obj6 = num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+C]");
					_ = 0;
					UIScrollView uiScrollView3 = scrollView.uiScrollView;
					object obj44 = uiScrollView3 + 220;
					obj3 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S1_v194+8]");
					_ = 0;
					UIScrollView uiScrollView4 = scrollView.uiScrollView;
					object obj45 = uiScrollView4 + 220;
					obj4 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S1_v200+8]");
					_ = 0;
					UIScrollView uiScrollView5 = scrollView.uiScrollView;
					object obj46 = uiScrollView5 + 220;
					obj5 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S1_v206+8]");
					_ = 0;
					float num18 = num3 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					float num19 = 0f * 0.5f;
					float num20 = num18 - num19;
					float num21 = num20 - num11;
					float num22 = num21 + (float)obj4;
					float num23 = (float)scrollView.cellSpaceX * 0.5f;
					float num24 = num22 - num23;
					obj7 = num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
					_ = 0;
					_ = 0f;
				}
				else
				{
					UIScrollView uiScrollView6 = scrollView.uiScrollView;
					object obj47 = uiScrollView6 + 220;
					((int*)num)->m_value = (int)obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S1_v143+8]");
					_ = 0;
					float num25 = num14 - (float)scrollView.cellSpaceY;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					obj6 = 0;
					UIScrollView uiScrollView7 = scrollView.uiScrollView;
					object obj48 = uiScrollView7 + 220;
					obj3 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S1_v155+8]");
					_ = 0;
					UIScrollView uiScrollView8 = scrollView.uiScrollView;
					object obj49 = uiScrollView8 + 220;
					obj4 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S1_v161+8]");
					_ = 0;
					UIScrollView uiScrollView9 = scrollView.uiScrollView;
					object obj50 = uiScrollView9 + 220;
					obj5 = obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ S1_v167+8]");
					_ = 0;
					object obj51 = 0f - num14;
					float num26 = (float)obj51 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+C]");
					float num27 = 0f * 0.5f;
					float num28 = num26 + num27;
					float num29 = num28 + num11;
					float num30 = (float)scrollView.cellSpaceY * 0.5f;
					float num31 = num29 + num30;
					float num32 = num31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
					float num33 = num32 + 0f;
					obj7 = obj3;
					_ = 0f;
				}
				((int*)num)->m_value = (int)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+4]");
				scrollView.scrollViewHeight = 0f;
				obj3 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				scrollView.scrollViewWidth = (float)obj3;
				if (scrollView._arrangement == ScrollView.Arrangement.Vertical && ~(scrollView.pullDownToRefreshList ? 1u : 0u) == 0)
				{
					((int*)num)->m_value = (int)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					UIScrollView uiScrollView10 = scrollView.uiScrollView;
					object obj52 = uiScrollView10 + 220;
					obj3 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ S2_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+4]");
					nint num34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
					if (num34 < 0)
					{
						UIScrollView uiScrollView11 = scrollView.uiScrollView;
						object obj53 = uiScrollView11 + 220;
						((int*)num)->m_value = (int)obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ S1_v110+8]");
						_ = 0;
						UIScrollView uiScrollView12 = scrollView.uiScrollView;
						object obj54 = uiScrollView12 + 220;
						obj3 = obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ S1_v116+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
						float num35 = 0f * 2f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
						obj6 = 0;
						UIScrollView uiScrollView13 = scrollView.uiScrollView;
						object obj55 = uiScrollView13 + 220;
						obj4 = obj55;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S1_v126+8]");
						_ = 0;
						UIScrollView uiScrollView14 = scrollView.uiScrollView;
						object obj56 = uiScrollView14 + 220;
						obj5 = obj56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1338 @ S1_v132+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+C]");
						float num36 = 0f * -0.5f;
						float num37 = num36 + num11;
						obj7 = obj4;
						_ = 0f;
					}
				}
				else if (scrollView._arrangement == ScrollView.Arrangement.Horizontal)
				{
					goto IL_0a7c;
				}
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
				_ = 0;
				((int*)num)->m_value = (int)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
				((int*)num)->m_value = (int)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23+10]");
				_ = 0;
				Characters.CharacterId? characterId = (Characters.CharacterId?)(object)(scrollView + 76);
				characterId = (Characters.CharacterId?)(object)((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+10]");
				_ = 0;
				return characterId;
			}
			if (scrollView._infinite == ScrollView.Infinite.BothWays)
			{
				bool flag8 = scrollView._arrangement == ScrollView.Arrangement.Vertical;
				UIScrollView uiScrollView15 = scrollView.uiScrollView;
				if (flag8)
				{
					object obj57 = uiScrollView15 + 220;
					((int*)num)->m_value = (int)obj57;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S1_v307+8]");
					_ = 0;
					UIScrollView uiScrollView16 = scrollView.uiScrollView;
					object obj58 = uiScrollView16 + 220;
					obj3 = obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S1_v313+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
					float num38 = 0f * 3f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					obj6 = 0;
					_ = 0f;
				}
				else
				{
					object obj59 = uiScrollView15 + 220;
					((int*)num)->m_value = (int)obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v292+8]");
					_ = 0;
					UIScrollView uiScrollView17 = scrollView.uiScrollView;
					object obj60 = uiScrollView17 + 220;
					obj3 = obj60;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S1_v298+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
					float num39 = 0f * 3f;
					obj6 = num39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
					_ = 0;
					_ = 0f;
				}
				obj7 = 0f;
				_ = 0f;
				_ = 0f;
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
				_ = 0;
				((int*)num)->m_value = (int)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
				((int*)num)->m_value = (int)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27+10]");
				_ = 0;
				Characters.CharacterId? characterId2 = (Characters.CharacterId?)(object)(scrollView + 76);
				characterId2 = (Characters.CharacterId?)(object)((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+10]");
				_ = 0;
				return characterId2;
			}
		}
		nint num40 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj61 = (nint)0 & (nint)0x200;
		if (obj61 != null)
		{
			goto IL_0a7c;
		}
		goto IL_14fe;
		IL_165f:
		UIScrollView uiScrollView18 = scrollView.uiScrollView;
		object obj62 = uiScrollView18 + 220;
		((int*)num)->m_value = (int)obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ S1_v430+8]");
		_ = 0;
		obj6 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+C]");
		_ = 0;
		_ = 0f;
		UIScrollView uiScrollView19 = scrollView.uiScrollView;
		object obj63 = uiScrollView19 + 220;
		obj3 = obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ S1_v439+8]");
		_ = 0;
		UIScrollView uiScrollView20 = scrollView.uiScrollView;
		object obj64 = uiScrollView20 + 220;
		obj4 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ S1_v445+8]");
		_ = 0;
		float num41 = num3 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		float num42 = 0f * 0.5f;
		float num43 = num41 - num42;
		float num44 = num43 + (float)obj4;
		obj7 = num44;
		_ = 0f;
		_ = 0f;
		goto IL_13dd;
		IL_16f1:
		UIScrollView uiScrollView21 = scrollView.uiScrollView;
		object obj65 = uiScrollView21 + 220;
		((int*)num)->m_value = (int)obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ S1_v362+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
		obj6 = 0;
		_ = 0f;
		UIScrollView uiScrollView22 = scrollView.uiScrollView;
		object obj66 = uiScrollView22 + 220;
		obj3 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ S1_v372+8]");
		_ = 0;
		UIScrollView uiScrollView23 = scrollView.uiScrollView;
		object obj67 = uiScrollView23 + 220;
		obj4 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ S1_v378+8]");
		_ = 0;
		object obj68 = 0f - num3;
		float num45 = (float)obj68 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
		float num46 = 0f * 0.5f;
		float num47 = num45 + num46;
		float num48 = num47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		float num49 = num48 + 0f;
		obj7 = 0f;
		_ = 0f;
		goto IL_13dd;
		IL_13dd:
		obj4 = 0;
		_ = 0;
		_ = 0;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
		_ = 0;
		((int*)num)->m_value = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		((int*)num)->m_value = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
		_ = 0;
		Characters.CharacterId? characterId3 = (Characters.CharacterId?)(object)(scrollView + 76);
		characterId3 = (Characters.CharacterId?)(object)((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+10]");
		_ = 0;
		return characterId3;
		IL_0a7c:
		nint num50 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v67 (Il2CppClass<UnityEngine.Vector3>)+74]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
		}
		goto IL_14fe;
		IL_14fe:
		Vector3 one = Vector3.one;
		Vector3 one2 = Vector3.one;
		obj2 = 0;
		_ = 0;
		_ = 0;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		((int*)num)->m_value = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Characters.CharacterId? characterId4 = (Characters.CharacterId?)(object)(scrollView + 76);
		characterId4 = (Characters.CharacterId?)(object)((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+10]");
		_ = 0;
		return characterId4;
	}

	public bool ShouldShowTheCompletedSign()
	{
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			List<Characters.CharacterId> charactersList = eventProgressData.charactersList;
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S4_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v5+8C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x7FF;
			object obj5 = obj4 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData3 = _eventProgressData;
			List<Characters.CharacterId> charactersList2 = eventProgressData3.charactersList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			object obj6 = -1;
			object obj7 = default;
			return obj7 == obj6;
		}
		return false;
	}

	public bool IsAbleToSkip()
	{
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			return eventProgressData.wasLastCharacterCompleted;
		}
		return false;
	}

	private bool HasLastCharacterBeenCompleted()
	{
		//IL_036e: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0271: Expected I, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0208: Expected I, but got Obj
		bool flag;
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v33 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v79 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(eventProgressData.currentCharacter);
			if (model.unlockType != PurchaseData.UnlockType.Facebook)
			{
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v69 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v75 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag = CharacterManager.IsCollectionComplete(eventProgressData.currentCharacter);
			}
			else
			{
				nint num5 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44 (Il2CppClass<SocialManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v64 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
				{
					nint num7 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v54 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v60 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					flag = CharacterManager.IsCollectionComplete(eventProgressData.currentCharacter);
				}
				else
				{
					flag = false;
				}
			}
		}
		else
		{
			flag = false;
		}
		nint num9 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v9 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v22 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = (flag ? 1 : 0) ^ 1;
		object obj7 = Globals.DEBUG_USE_EVENT_TESTER | obj6;
		if (obj7 != null)
		{
			int numberOfKeysToSkip = GetNumberOfKeysToSkip();
			return (byte)(numberOfKeysToSkip ^ 1) != 0;
		}
		return false;
	}

	public bool ShouldSpawnLetters()
	{
		if (GetNumberOfKeysToSkip() != 0)
		{
			return IsFirstCharacterSelected();
		}
		return false;
	}

	private unsafe void ResetCollectProgress()
	{
		//IL_010a: Expected VT, but got I4
		//IL_00b3: Expected Ref, but got VT
		Characters.CharacterId? characterId = (Characters.CharacterId?)(object)0;
		if (_eventProgressData == null)
		{
			return;
		}
		CharacterNameEventData eventProgressData = _eventProgressData;
		bool wasLastCharacterCompleted = IsFirstCharacterSelected();
		eventProgressData.wasLastCharacterCompleted = wasLastCharacterCompleted;
		CharacterNameEventData eventProgressData2 = _eventProgressData;
		CharacterNameEventData eventProgressData3 = _eventProgressData;
		if (~(eventProgressData3.wasLastCharacterCompleted ? 1u : 0u) == 0)
		{
			int completedCharacters = eventProgressData2.completedCharacters + 1;
			eventProgressData2.completedCharacters = completedCharacters;
		}
		else
		{
			int skippedCharacters = eventProgressData2.skippedCharacters + 1;
			eventProgressData2.skippedCharacters = skippedCharacters;
		}
		char? c = NextLetterToSpawn();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4]");
		if ((nint)0 != 0)
		{
			CharacterNameEventData eventProgressData4 = _eventProgressData;
			Characters.CharacterId value = ((Characters.CharacterId?*)characterId)->Value;
			eventProgressData4.currentCharacter = value;
			if (_eventProgressData != null)
			{
				CharacterNameEventData eventProgressData5 = _eventProgressData;
				eventProgressData5.collectedLetterIndex = -1;
			}
		}
		SkipCurrentCharacter();
	}

	public char? NextLetterToSpawn()
	{
		//IL_00eb: Expected Obj, but got I4
		//IL_012f: Expected VT, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I4, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		if (GetNumberOfKeysToSkip() == 0 && _eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			List<Characters.CharacterId> charactersList = eventProgressData.charactersList;
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v4+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v5+8C]");
			object obj4 = 0;
			object obj5 = obj4 & 0x7FF;
			object obj6 = obj5 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData3 = _eventProgressData;
			object obj7 = default;
			int index = obj7 + 1;
			Characters.CharacterId characterId = eventProgressData3.charactersList.get_Item(index);
			_ = 1;
			obj = characterId;
		}
		return (char?)obj;
	}

	public void NotifyLetterCollected(char collectedLetter)
	{
		//IL_016c: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collectedLetter @ L1 (System.Char)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collectedLetter @ L1 (System.Char)+18]");
			object obj2 = 0;
			char c = collectedLetter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v9+8]");
			string characterDisplayName = ((CharacterNameEventManager)c).GetCharacterDisplayName(Characters.CharacterId.slick);
			object obj3 = characterDisplayName + 12;
			if (obj3 != null && !((CharacterNameEventManager)collectedLetter).IsFirstCharacterSelected())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collectedLetter @ L1 (System.Char)+18]");
				object obj4 = 0;
				object obj5 = obj3 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23+C]");
				bool flag = 0 < (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collectedLetter @ L1 (System.Char)+18]");
				object obj6 = 0;
				object obj10;
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v17+C]");
					object obj7 = (nint)0 << 1;
					object obj8 = characterDisplayName + obj7;
					object obj9 = obj8 + 18;
					obj10 = obj9;
				}
				else
				{
					object obj11 = characterDisplayName + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v17+C]");
					object obj12 = (nint)0 << 1;
					object obj13 = obj11 + obj12;
					obj10 = obj13;
				}
				_ = 1;
				obj = obj10;
			}
		}
		CharacterNameEventManager characterNameEventManager = (CharacterNameEventManager)obj;
	}

	public int GetAmountOfCollectedLetters()
	{
		if (((ExpiredLimitedBoardEventManager)this).GetEventType() != SSEventType.None)
		{
			bool flag = IsFirstCharacterSelected();
			return (flag ? 1 : 0) ^ 1;
		}
		return 0;
	}

	public bool HasCompletedCollectionForSelectedCharacter()
	{
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			return (byte)(eventProgressData.collectedLetterIndex + 1) != 0;
		}
		return false;
	}

	public bool IsFirstCharacterSelected()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			string characterDisplayName = GetCharacterDisplayName(eventProgressData.currentCharacter);
			object obj = characterDisplayName + 12;
			if (obj != null)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				object obj2 = obj - 1;
				return eventProgressData2.collectedLetterIndex == (nint)obj2;
			}
			return false;
		}
		return false;
	}

	public bool IsLastCharacterSelected()
	{
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			if (eventProgressData.charactersList.Contains(eventProgressData2.currentCharacter))
			{
				CharacterNameEventData eventProgressData3 = _eventProgressData;
				List<Characters.CharacterId> charactersList = eventProgressData3.charactersList;
				CharacterNameEventData eventProgressData4 = _eventProgressData;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v4 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v5+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v6+8C]");
				object obj3 = 0;
				object obj4 = obj3 & 0x7FF;
				object obj5 = obj4 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v6 (should have been resolved before IL gen)");
				object obj6 = default;
				return obj6 == null;
			}
			return false;
		}
		return false;
	}

	private string GetWordForCharacter(Characters.CharacterId characterId)
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_01dc: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CharacterManager.HasCharacterBeenSeen(characterId);
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Info.Outfits>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v32 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((OutfitSet)characterId).HasOutfitWithName((string)flag))
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = CharacterManager.HasCharacterBeenSeen(characterId);
			return (string)flag2;
		}
		return null;
	}

	private char[] GetCharacterNameArray(Characters.CharacterId characterId)
	{
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_0265: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I
		//IL_01ac: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_01f9: Expected I, but got Obj
		//IL_012a: Expected I4, but got Obj
		string key;
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			if (eventProgressData.categoryWordsList != null)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				List<Characters.CharacterId> charactersList = eventProgressData2.charactersList;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v4 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v5+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v6+8C]");
				object obj3 = 0;
				object obj4 = obj3 & 0x7FF;
				object obj5 = obj4 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S5_v6 (should have been resolved before IL gen)");
				int num2 = default;
				if (num2 >= 0)
				{
					CharacterNameEventData eventProgressData3 = _eventProgressData;
					List<string> categoryWordsList = eventProgressData3.categoryWordsList;
					if (num2 < categoryWordsList._size)
					{
						CharacterNameEventData eventProgressData4 = _eventProgressData;
						string text = eventProgressData4.categoryWordsList.get_Item(num2);
						if (text.get_Chars((int)"") != '\0')
						{
							key = text;
							goto IL_0257;
						}
					}
				}
			}
		}
		nint num3 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v31 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		key = model.name;
		goto IL_0257;
		IL_0257:
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v10 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (char[])(object)Strings.GetDefault(key);
	}

	private string GetCharacterDisplayName(Characters.CharacterId characterId)
	{
		//IL_0018: Expected I4, but got Obj
		//IL_003b: Expected Obj, but got I4
		char[] characterNameArray = GetCharacterNameArray(characterId);
		IEventManager activeEventManager = ((SSEventsManagerController)null).GetActiveEventManager((SSEventType)characterNameArray);
		string value = ((string)(object)activeEventManager).ToUpperInvariant();
		return (string)string.IsNullOrEmpty(value);
	}

	private string FilterCharacterName(string characterName)
	{
		//IL_000a: Expected I4, but got Obj
		char[] characterNameArray = GetCharacterNameArray((Characters.CharacterId)characterName);
		string text = string.Copy((string)(object)characterNameArray);
		return text.ToUpperInvariant();
	}

	public void UnHookFromGameEvents()
	{
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			eventProgressData.collectedLetterIndex = -1;
		}
	}

	public int GetNumberOfKeysToSkip()
	{
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			if (eventProgressData.charactersList.Contains(eventProgressData2.currentCharacter))
			{
				CharacterNameEventData eventProgressData3 = _eventProgressData;
				List<Characters.CharacterId> charactersList = eventProgressData3.charactersList;
				CharacterNameEventData eventProgressData4 = _eventProgressData;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v4 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v5+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v6+8C]");
				object obj3 = 0;
				object obj4 = obj3 & 0x7FF;
				object obj5 = obj4 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71 @ S5_v6 (should have been resolved before IL gen)");
				CharacterNameEventData eventProgressData5 = _eventProgressData;
				List<Characters.CharacterId> charactersList2 = eventProgressData5.charactersList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v14 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				object obj6 = -1;
				object obj7 = default;
				return (obj7 == obj6) ? 1 : 0;
			}
			return 0;
		}
		return 0;
	}

	public bool CanAffordToSkip()
	{
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			return (byte)(eventProgressData.skippedCharacters + 3) != 0;
		}
		return true;
	}

	public void UseKeysToSkip()
	{
		SkipCurrentCharacter();
	}

	public void LogWatchedAdToSkip()
	{
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_031e: Expected Obj, but got I4
		//IL_031e: Expected Obj, but got I4
		//IL_0331: Expected I4, but got Obj
		//IL_0331: Expected I4, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_0201: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		PersistentAwardProgress persistentAwardProgress;
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			persistentAwardProgress = (PersistentAwardProgress)(eventProgressData.skippedCharacters + 3);
		}
		else
		{
			persistentAwardProgress = (PersistentAwardProgress)2;
		}
		if (_eventProgressData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			obj = eventProgressData2.currentCharacter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)71, persistentAwardProgress, (Action<Award>)(-1));
		InventorySave.LogEarnedEvent((int)persistentAwardProgress, (InAppItemModel.ItemType)"WordyWeekendSkip", "N/A");
		if (_eventProgressData == null)
		{
			return;
		}
		nint num = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v24 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v37 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterNameEventData eventProgressData3 = _eventProgressData;
		if (CharacterNameEventManager.m_OnCharacterSkippedWithKeys != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S3_v4 (Il2CppMethodInfo)+18]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118 @ S4_v6 (should have been resolved before IL gen)");
		}
	}

	public bool SelectedCharacterMatchesFocusedCharacter()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I4
		int coins = InventorySave.coins;
		object obj;
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			obj = eventProgressData.skippedCharacters + 3;
		}
		else
		{
			obj = 2;
		}
		object obj2 = coins - obj;
		return (nint)obj2 > -1;
	}

	public CharacterNameEventManager()
	{
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		if (_eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			object obj3 = eventProgressData.skippedCharacters + 3;
		}
		else
		{
			object obj3 = 2;
		}
		if (_eventProgressData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			obj = eventProgressData2.currentCharacter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	static CharacterNameEventManager()
	{
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I4
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_03fd: Expected I, but got Obj
		//IL_0413: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		int currentOutfitIndex = PlayerSave.currentOutfitIndex;
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v29 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (currentOutfitIndex > SaveMeManager.NUMBER_OF_RUNS_BEFORE_SAVE_ME_FUNCTIONALITY)
		{
			nint num3 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v28 (Il2CppClass<SaveMeManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v70 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (byte)(~(SaveMeManager._hasReviveWithAdsBeenAvailableInCurrentRun ? 1u : 0u)) != 0;
			string text = "Video not available";
			if (!flag)
			{
				nint num5 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v59 (Il2CppClass<SaveMeManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(SaveMeManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v66 (Il2CppClass<SaveMeManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B9");
				object obj7 = default;
				object obj6 = obj7 & 1;
				obj = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
				string text2 = default;
				text = text2;
			}
			nint num7 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v37 (Il2CppClass<SaveMeManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v54 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B5");
			object obj9 = default;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text4 = default;
			string text3 = text4 + ";" + text;
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v47 (Il2CppClass<Flurry>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num10 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v50 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		nint num11 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v15 (Il2CppClass<SaveMeManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v21 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.SkipReviveIfPurchaseFailed();
	}
}
