using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using MiniJSON;
using SYBO.Subway.Info;

public class CharacterNameEventManager : IEventManager
{
	public class LetterCollectedEventArgs : EventArgs
	{
		private char _characterCollected;

		public char CharacterCollected => _characterCollected;

		public LetterCollectedEventArgs(char characterCollected)
		{
			_characterCollected = characterCollected;
		}

		public override string ToString()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = _characterCollected;
			object obj3 = obj + 14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			return $"[LetterCollectedEventArgs: l={arg}";
		}
	}

	public const string ONLINE_SETTING_DESCRIPTION_FIRST_UNLOCK_CHARATER_NAME = "event_popup_description_first_unlock_character_name";

	public const string ONLINE_SETTING_DESCRIPTION_SECOND_UNLOCK_CHARACTER_NAME = "event_popup_description_second_unlock_character_name";

	public const string ONLINE_SETTING_DESCRIPTION_FIRST_SELECT_CHARACTER_NAME = "event_popup_description_first_select_character_name";

	public const string ONLINE_SETTING_DESCRIPTION_SECOND_SELECT_CHARACTER_NAME = "event_popup_description_second_select_character_name";

	private const int DEFAULT_VALUE_FOR_COLLECT = -1;

	public static readonly char[] FILTERED_CHARACTERS;

	private SSEventType _eventType;

	private long _eventID;

	private CharacterNameEventData _eventProgressData;

	private Characters.CharacterType?[][] normalCharacters;

	private Characters.CharacterType?[][] _musicCharacters;

	private Characters.CharacterType?[][] _movieCharacters;

	private Characters.CharacterType?[][] _danceCharacters;

	private Characters.CharacterType[] _limitedCharacters;

	private Dictionary<Characters.CharacterType, StringID> _musicWordCollection;

	private Dictionary<Characters.CharacterType, StringID> _movieWordCollection;

	private Dictionary<Characters.CharacterType, StringID> _danceWordCollection;

	private List<SSEventCategory> _supportedCategories;

	private static EventHandler<LetterCollectedEventArgs> m_OnLetterCollected;

	public static event EventHandler<LetterCollectedEventArgs> OnLetterCollected
	{
		add
		{
			Delegate obj = CharacterNameEventManager.m_OnLetterCollected;
			EventHandler<LetterCollectedEventArgs> eventHandler = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == CharacterNameEventManager.m_OnLetterCollected;
				EventHandler<LetterCollectedEventArgs> onLetterCollected = eventHandler;
				if (!flag)
				{
					onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
				}
				CharacterNameEventManager.m_OnLetterCollected = onLetterCollected;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = CharacterNameEventManager.m_OnLetterCollected;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = CharacterNameEventManager.m_OnLetterCollected;
			EventHandler<LetterCollectedEventArgs> eventHandler = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == CharacterNameEventManager.m_OnLetterCollected;
				EventHandler<LetterCollectedEventArgs> onLetterCollected = eventHandler;
				if (!flag)
				{
					onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
				}
				CharacterNameEventManager.m_OnLetterCollected = onLetterCollected;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = CharacterNameEventManager.m_OnLetterCollected;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static CharacterNameEventManager Create(SSEventType eventType, long eventID)
	{
		CharacterNameEventManager characterNameEventManager = default;
		characterNameEventManager._002Ector();
		characterNameEventManager.Initialize(eventType, eventID);
		return characterNameEventManager;
	}

	private void Initialize(SSEventType eventType, long eventID)
	{
		_eventID = eventID;
		_eventType = eventType;
		if (eventID < 1)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._characterNameEventData == string.Empty)
		{
			CharacterNameEventData eventProgressData = InitCharacterNameEventData();
			_eventProgressData = eventProgressData;
		}
		else
		{
			CharacterNameEventData eventProgressData2 = DeserializeProgressFromJson();
			_eventProgressData = eventProgressData2;
			CharacterNameEventData eventProgressData3 = _eventProgressData;
			if (eventProgressData3.eventID__BackingField != eventID)
			{
				CharacterNameEventData eventProgressData4 = InitCharacterNameEventData();
				_eventProgressData = eventProgressData4;
			}
		}
		if (HasCompletedCollectionForSelectedCharacter())
		{
			SkipCurrentCharacter();
		}
	}

	private string SerializeProgressToJson()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_0457: Expected Obj, but got I
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_04a9: Expected Obj, but got I
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02c2: Expected Obj, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
		bool flag = _eventProgressData == null;
		string result = string.Empty;
		if (!flag)
		{
			List<int> list = default;
			list._002Ector();
			CharacterNameEventData eventProgressData = _eventProgressData;
			bool flag2 = eventProgressData.charactersList__BackingField == null;
			int num3 = 0;
			List<Characters.CharacterType> list2 = eventProgressData.charactersList__BackingField;
			if (!flag2)
			{
				while (true)
				{
					int num4 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ L4_v10 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
					if ((nint)num4 >= (nint)0)
					{
						break;
					}
					CharacterNameEventData eventProgressData2 = _eventProgressData;
					Characters.CharacterType item = eventProgressData2.charactersList__BackingField.get_Item(num3);
					list.Add((int)item);
					int num5 = num3 + 1;
					CharacterNameEventData eventProgressData3 = _eventProgressData;
					num3 = num5;
					list2 = eventProgressData3.charactersList__BackingField;
				}
			}
			List<string> list3 = default;
			list3._002Ector();
			CharacterNameEventData eventProgressData4 = _eventProgressData;
			if (eventProgressData4.categoryWordsList__BackingField != null)
			{
				int num6 = 0;
				List<StringID> list4 = eventProgressData4.categoryWordsList__BackingField;
				while (true)
				{
					int num7 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ L4_v7 (System.Collections.Generic.List`1<StringID>)+C]");
					if ((nint)num7 >= (nint)0)
					{
						break;
					}
					CharacterNameEventData eventProgressData5 = _eventProgressData;
					StringID stringID = eventProgressData5.categoryWordsList__BackingField.get_Item(num6);
					_ = -1;
					_ = typeof(StringID);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					_ = 0;
					Enum obj3 = (Enum)(obj + 32);
					string item2 = obj3.ToString();
					list3.Add(item2);
					int num8 = num6 + 1;
					CharacterNameEventData eventProgressData6 = _eventProgressData;
					num6 = num8;
					list4 = eventProgressData6.categoryWordsList__BackingField;
				}
			}
			nint num9 = 0;
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v167 @ S5_v5+4] (should have been resolved before IL gen)");
			nint num11 = 0;
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ S5_v10+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData7 = _eventProgressData;
			_ = eventProgressData7.eventCategory__BackingField;
			object obj6 = obj + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num13 = 0;
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ S5_v15+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData8 = _eventProgressData;
			_ = eventProgressData8.currentCharacter__BackingField;
			object obj8 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num15 = 0;
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v261 @ S5_v20+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData9 = _eventProgressData;
			_ = eventProgressData9.collectedLetterIndex__BackingField;
			object obj10 = obj + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num17 = 0;
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S5_v24 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ S5_v25+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData10 = _eventProgressData;
			_ = eventProgressData10.completedCharacters__BackingField;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num19 = 0;
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S5_v29 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v336 @ S5_v30+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData11 = _eventProgressData;
			_ = eventProgressData11.skippedCharacters__BackingField;
			object obj14 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num21 = 0;
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S5_v34 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ S5_v35+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData12 = _eventProgressData;
			_ = eventProgressData12.wasLastCharacterCompleted__BackingField;
			object obj16 = obj + 11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num23 = 0;
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S5_v39 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v398 @ S5_v40+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData13 = _eventProgressData;
			_ = eventProgressData13.eventID__BackingField;
			object obj18 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num25 = 0;
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S5_v44 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v423 @ S5_v45+4] (should have been resolved before IL gen)");
			object obj20 = default;
			string text = Json.Serialize(obj20);
			result = text;
		}
		return result;
	}

	private CharacterNameEventData DeserializeProgressFromJson()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_07fa: Expected VT, but got Obj
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_02f7: Expected I, but got Obj
		//IL_0778: Expected Obj, but got I
		//IL_070c: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I
		//IL_05a8: Expected Obj, but got I
		//IL_05fc: Expected Obj, but got I
		//IL_060c: Expected Obj, but got I
		//IL_061c: Expected Obj, but got I
		//IL_062c: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I
		//IL_0681: Expected Obj, but got I
		//IL_069d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		CharacterNameEventData characterNameEventData = InitCharacterNameEventData();
		PlayerInfo instance = PlayerInfo.Instance;
		object obj4 = Json.Deserialize(instance._characterNameEventData);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj5 = default;
		if (obj5 == null)
		{
			goto IL_0a8f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj6 = default;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj7 = default;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				List<object> list = default;
				if (list != null && list._size >= 1)
				{
					List<Characters.CharacterType> list2 = default;
					list2._002Ector();
					int num = 0;
					while (num < list._size)
					{
						object value = list.get_Item(num);
						int item = Convert.ToInt32(value);
						list2.Add((Characters.CharacterType)item);
						int num2 = num + 1;
						num = num2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v292 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
					if ((nint)0 >= (nint)1)
					{
						characterNameEventData.charactersList__BackingField = list2;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj9 = default;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value2 = default;
				int num3 = Convert.ToInt32(value2);
				characterNameEventData.currentCharacter__BackingField = (Characters.CharacterType)num3;
			}
		}
		List<StringID> list3 = default;
		list3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj10 = default;
		bool flag = obj10 == null;
		object obj11 = obj5;
		object obj12 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj13 = default;
			bool flag2 = obj13 == null;
			obj11 = obj5;
			obj12 = 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				List<object> list4 = default;
				bool flag3 = list4 == null;
				obj11 = obj5;
				obj12 = 0;
				if (!flag3)
				{
					bool flag4 = list4._size < 1;
					obj11 = obj5;
					obj12 = 0;
					if (!flag4)
					{
						int num4 = 0;
						object obj15 = default;
						object obj16 = default;
						object obj18 = default;
						object obj20 = default;
						object obj21 = default;
						object obj32 = default;
						object obj33 = default;
						CharacterNameEventData result = default;
						object obj35 = default;
						while (true)
						{
							bool flag5 = num4 >= list4._size;
							obj11 = obj5;
							if (flag5)
							{
								break;
							}
							object obj14 = list4.get_Item(num4);
							nint num5 = (nint)obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v511 @ S1_v108 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
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
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													goto IL_0b3c;
												}
											}
										}
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							bool flag6 = obj15 != obj16;
							object obj17 = obj18;
							obj11 = obj5;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj19 = obj20;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										if (obj21 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
											object obj22 = (nint)0 << 2;
											object obj23 = obj3 + obj22;
											obj23 = obj20;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
											object obj24 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @247");
											List<Characters.CharacterType> list5 = characterNameEventData.charactersList__BackingField;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v214+10]");
											object obj25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ S4_v23+60]");
											object obj26 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v214+10]");
											object obj27 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S5_v6+60]");
											object obj28 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S5_v7+8C]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v887 @ S5_v8+4] (should have been resolved before IL gen)");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v33 (System.Collections.Generic.List`1<StringID>)+C]");
											object obj30 = -1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
											object obj31 = -1;
											bool flag7 = obj32 == obj30;
											obj33 = 1;
											if (!flag7)
											{
												obj33 = obj33;
											}
											goto IL_0b3c;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
										object obj34 = obj20;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag8 = (nint)0 != 1;
										result = (CharacterNameEventData)flag8;
										if (flag8)
										{
											goto IL_0a5d;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag9 = (nint)0 == 1;
								obj17 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								obj11 = 0;
								if (flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
									goto IL_0a5d;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
							break;
							IL_0b3c:
							int num6 = num4 + 1;
							num4 = num6;
							continue;
							IL_0a5d:
							return result;
						}
						obj12 = obj33 & 1;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v33 (System.Collections.Generic.List`1<StringID>)+C]");
		bool flag10 = (nint)0 < (nint)1;
		List<StringID> list6 = null;
		if (!flag10)
		{
			list6 = list3;
		}
		characterNameEventData.categoryWordsList__BackingField = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj36 = default;
		int num7 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj37 = default;
			if (obj37 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value3 = default;
				num7 = Convert.ToInt32(value3);
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SSEventCategory));
				object obj38 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object value4 = default;
				if (!Enum.IsDefined(typeFromHandle, value4))
				{
					num7 = 0;
				}
			}
		}
		characterNameEventData.eventCategory__BackingField = (SSEventCategory)num7;
		int num8;
		if (obj12 != null)
		{
			num8 = -1;
			goto IL_08cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj39 = default;
		if (obj39 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj40 = default;
			if (obj40 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value5 = default;
				num8 = Convert.ToInt32(value5);
				goto IL_08cf;
			}
		}
		goto IL_0b81;
		IL_08cf:
		characterNameEventData.collectedLetterIndex__BackingField = num8;
		goto IL_0b81;
		IL_0b81:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj41 = default;
		if (obj41 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj42 = default;
			if (obj42 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value6 = default;
				int num9 = Convert.ToInt32(value6);
				characterNameEventData.completedCharacters__BackingField = num9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj43 = default;
		if (obj43 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj44 = default;
			if (obj44 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value7 = default;
				int num10 = Convert.ToInt32(value7);
				characterNameEventData.skippedCharacters__BackingField = num10;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj45 = default;
		if (obj45 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj46 = default;
			if (obj46 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value8 = default;
				bool flag11 = Convert.ToBoolean(value8);
				characterNameEventData.wasLastCharacterCompleted__BackingField = flag11;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj47 = default;
		if (obj47 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj48 = default;
			if (obj48 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object value9 = default;
				long num11 = Convert.ToInt64(value9);
				characterNameEventData.eventID__BackingField = num11;
			}
		}
		goto IL_0a8f;
		IL_0a8f:
		return characterNameEventData;
	}

	private CharacterNameEventData InitCharacterNameEventData()
	{
		List<Characters.CharacterType> list = CreateNewCharacterList();
		List<StringID> categoryWordsList = CreateNewCategoryWordsDict(list);
		SSEventCategory eventCategoryFromOnlineSetting = GetEventCategoryFromOnlineSetting();
		Characters.CharacterType currentCharacter = list.get_Item(0);
		CharacterNameEventData characterNameEventData = default;
		characterNameEventData._002Ector(list, categoryWordsList, eventCategoryFromOnlineSetting, currentCharacter, -1, 0, 0, wasLastCharacterCompleted: false, _eventID);
		return characterNameEventData;
	}

	public List<Characters.CharacterType> GetCharacterList()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			return eventProgressData.charactersList__BackingField;
		}
		return null;
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
		bool flag = _eventID < 1;
		bool result = false;
		if (!flag)
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			bool flag2 = _eventProgressData == null;
			result = false;
			if (!flag2)
			{
				List<Characters.CharacterType> list = eventProgressData.charactersList__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
				bool flag3 = (nint)0 < (nint)1;
				result = false;
				if (!flag3)
				{
					bool flag4 = HasLastCharacterBeenCompleted();
					bool flag5 = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
					result = flag5;
				}
			}
		}
		return result;
	}

	public unsafe T GetEventValue<T>(out bool found)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0891: Expected VT, but got I
		//IL_00b3: Expected VT, but got I
		//IL_00c4: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0786: Expected VT, but got I4
		//IL_0641: Expected Obj, but got I
		//IL_066c: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06db: Expected VT, but got I
		//IL_08dd: Expected Obj, but got I
		//IL_08f2: Expected VT, but got I
		//IL_0717: Expected I, but got Obj
		//IL_049e: Expected VT, but got Obj
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
				goto IL_0873;
			}
		}
		obj4 = 1;
		goto IL_0873;
		IL_0881:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (T)0;
		IL_0873:
		if (obj4 == null)
		{
			nint num = 0;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
			nint num2 = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S1_v15 (Il2CppClass<System.Type>)+1BC] (should have been resolved before IL gen)");
			object obj5 = default;
			if (obj5 != null)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v144 (Il2CppMethodRgctx<CharacterNameEventManager::GetEventValue>)+8]");
						object obj6 = 0;
						nint num4 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								nint num5 = 0;
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
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													nint num6 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
																			object obj7 = default;
																			return (T)obj7;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															goto IL_0539;
														}
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_0539;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0539;
			}
		}
		goto IL_0881;
		IL_0828:
		T result = default;
		return result;
		IL_0539:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag = obj8 == obj9;
		bool flag2 = !flag;
		object obj11 = default;
		object obj10 = obj11;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj13 = default;
				object obj12 = obj13;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj14 = default;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj15 = (nint)0 << 2;
						object obj16 = obj + obj15;
						obj16 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj17 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj18 = (nint)0 << 2;
						object obj19 = obj18 + obj;
						object obj20 = obj19 - 4;
						object obj21 = obj20;
						reference = ref *(bool*)null;
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)num7);
						bool flag3 = (object)typeFromHandle2 == null;
						string text2 = "The current event does not contain a value of the specified type: ";
						string text3 = null;
						if (!flag3)
						{
							nint num8 = (nint)typeFromHandle2;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ S1_v67 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
							text2 = "The current event does not contain a value of the specified type: ";
							string text4 = default;
							text3 = text4;
						}
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ S1_v58+10C] (should have been resolved before IL gen)");
						string text6 = default;
						string text5 = text2 + text3 + ", stack trace: " + text6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj23 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						return (T)0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj24 = obj13;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					result = (T)flag4;
					if (flag4)
					{
						goto IL_0828;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			object obj25 = default;
			obj10 = obj25;
			if (flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_0828;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0881;
	}

	public unsafe void GetPopupTitle(out string firstLine, out string secondLine)
	{
		//IL_00f1: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0029: Expected I4, but got Obj
		SSEventCategory eventCategory = GetEventCategory();
		object obj = eventCategory - 1;
		bool flag = (nint)obj <= 2;
		bool flag2 = !flag;
		StringID key = StringID.EVENTS_POPUP_WEEKEND_EVENT_TITLE_LINE_1;
		if (!flag2)
		{
			object obj2 = obj << 2;
			object obj3 = obj2 + 2288372;
			key = (StringID)obj3;
		}
		string text2;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			string text = Strings.Get(key);
			ref string reference = ref *(string*)text;
			text2 = Strings.Get(StringID.EVENTS_POPUP_WEEKEND_EVENT_TITLE_LINE_2);
		}
		else
		{
			OnlineSettings instance = OnlineSettings.instance;
			string defaultValue = Strings.Get(key);
			string value = instance.GetValue("event_popup_title_first", defaultValue);
			ref string reference = ref *(string*)value;
			OnlineSettings instance2 = OnlineSettings.instance;
			string defaultValue2 = Strings.Get(StringID.EVENTS_POPUP_WEEKEND_EVENT_TITLE_LINE_2);
			text2 = instance2.GetValue("event_popup_title_second", defaultValue2);
		}
		ref string reference2 = ref *(string*)text2;
	}

	public unsafe void GetPopupDescription(out string firstTitle, out string secondTitle)
	{
		string text3;
		if (SelectedCharacterMatchesFocusedCharacter())
		{
			string text = Strings.Get(StringID.EVENTS_POPUP_DESCRIPTION_TITLE_SELECT_CHARACTER_NAME);
			CharacterNameEventData eventProgressData = _eventProgressData;
			string text2 = ((_eventProgressData != null) ? GetCharacterDisplayName(eventProgressData.currentCharacter__BackingField) : string.Empty);
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				ref string reference = ref *(string*)text;
				text3 = text2;
			}
			else
			{
				OnlineSettings instance = OnlineSettings.instance;
				string value = instance.GetValue("event_popup_description_first_select_character_name", text);
				ref string reference = ref *(string*)value;
				OnlineSettings instance2 = OnlineSettings.instance;
				string value2 = instance2.GetValue("event_popup_description_second_select_character_name", text2);
				text3 = value2;
			}
		}
		else
		{
			string descriptionTitleForCharacterNotOwned = GetDescriptionTitleForCharacterNotOwned();
			string arg;
			if (_eventProgressData == null)
			{
				arg = string.Empty;
			}
			else
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				Characters.Model model = Characters.characterData.get_Item(eventProgressData2.currentCharacter__BackingField);
				arg = Strings.Get(model.name);
			}
			string format = Strings.Get(StringID.EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_UNLOCK_CHARACTER_NAME);
			string text4 = string.Format(format, arg);
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				ref string reference = ref *(string*)descriptionTitleForCharacterNotOwned;
				text3 = text4;
			}
			else
			{
				OnlineSettings instance3 = OnlineSettings.instance;
				string value3 = instance3.GetValue("event_popup_description_first_unlock_character_name", descriptionTitleForCharacterNotOwned);
				ref string reference = ref *(string*)value3;
				OnlineSettings instance4 = OnlineSettings.instance;
				string value4 = instance4.GetValue("event_popup_description_second_unlock_character_name", text4);
				text3 = value4;
			}
		}
		ref string reference2 = ref *(string*)text3;
	}

	private string GetDescriptionTitleForCharacterNotOwned()
	{
		//IL_003d: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		CharacterNameEventManager characterNameEventManager = default;
		StringID key;
		if (characterNameEventManager != null)
		{
			SSEventCategory eventCategory = characterNameEventManager.GetEventCategory();
			object obj = eventCategory - 1;
			key = (StringID)(obj + 1252);
			if ((nint)obj >= 3)
			{
				key = StringID.EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME;
			}
		}
		else
		{
			key = StringID.EVENTS_POPUP_DESCRIPTION_TITLE_UNLOCK_CHARACTER_NAME;
		}
		return Strings.Get(key);
	}

	public unsafe void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine)
	{
		ref string reference = ref *(string*)string.Empty;
		ref string reference2 = ref *(string*)string.Empty;
		ref string reference3 = ref *(string*)string.Empty;
	}

	private void SaveProgress()
	{
		if (_eventProgressData != null)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			string characterNameEventData = SerializeProgressToJson();
			instance.characterNameEventData = characterNameEventData;
		}
	}

	private List<StringID> CreateNewCategoryWordsDict(List<Characters.CharacterType> charactersList)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		List<StringID> list = default;
		list._002Ector();
		SSEventCategory eventCategoryFromOnlineSetting = GetEventCategoryFromOnlineSetting();
		object obj3 = eventCategoryFromOnlineSetting - 1;
		object obj4;
		if (eventCategoryFromOnlineSetting != SSEventCategory.Cat1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2)
				{
					goto IL_048b;
				}
				obj4 = this + 56;
			}
			else
			{
				obj4 = this + 52;
			}
		}
		else
		{
			obj4 = this + 48;
		}
		if (obj4 != null)
		{
			object obj5 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = obj + 32;
			obj = obj6;
			_ = 0;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			object obj12 = default;
			object obj14 = default;
			object obj15 = default;
			while (true)
			{
				_ = 0;
				object obj7 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj8 == null)
					{
						goto IL_03b6;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj9 = obj + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj10 != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj11 != obj12;
				object obj13 = obj14;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_03b6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj13 = obj15;
				}
				_ = 0;
				object obj16 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
				IL_03b6:
				object obj17 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
				break;
			}
		}
		goto IL_048b;
		IL_048b:
		return list;
	}

	private unsafe SSEventCategory GetEventCategoryFromOnlineSetting()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Ref, but got Unknown
		//IL_0445: Expected Obj, but got I
		//IL_01cc: Expected I4, but got Obj
		//IL_048e: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = 0;
		SSEventCategory sSEventCategory;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager instance = EventTesterManager.Instance;
			SSEventCategory eventCategory = instance.GetEventCategory();
			sSEventCategory = eventCategory;
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			bool flag = instance2.TryGetValue("event_category", out *(string*)(obj + 12));
			bool flag2 = !flag;
			sSEventCategory = SSEventCategory.None;
			if (!flag2)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
									object obj3 = default;
									sSEventCategory = (SSEventCategory)obj3;
									goto IL_04d9;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj4 = default;
				object obj5 = default;
				bool flag3 = obj4 != obj5;
				SSEventCategory sSEventCategory2 = default;
				sSEventCategory = sSEventCategory2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					CharacterNameEventManager characterNameEventManager;
					if ((nint)0 != 1)
					{
						SSEventCategory sSEventCategory3 = default;
						int value__ = ((SSEventCategory*)(int)sSEventCategory3)->value__;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj6 = default;
							if (obj6 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj7 = (nint)0 << 2;
								object obj8 = obj + obj7;
								obj8 = ((SSEventCategory*)(int)sSEventCategory3)->value__;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj9 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj10 = -1;
								sSEventCategory = SSEventCategory.None;
								goto IL_04d9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj11 = ((SSEventCategory*)(int)sSEventCategory3)->value__;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							characterNameEventManager = (CharacterNameEventManager)0;
							sSEventCategory = sSEventCategory3;
							if (flag4)
							{
								goto IL_0502;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					characterNameEventManager = (CharacterNameEventManager)0;
					SSEventCategory sSEventCategory4 = default;
					sSEventCategory = sSEventCategory4;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						characterNameEventManager = (CharacterNameEventManager)0;
						sSEventCategory = sSEventCategory4;
					}
				}
				goto IL_0502;
			}
		}
		goto IL_04d9;
		IL_04d9:
		bool flag6 = _supportedCategories.Contains(sSEventCategory);
		SSEventCategory result = sSEventCategory;
		if (!flag6)
		{
			result = SSEventCategory.None;
		}
		return result;
		IL_0502:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_04d9;
	}

	public SSEventCategory GetEventCategory()
	{
		SSEventCategory sSEventCategory;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager instance = EventTesterManager.Instance;
			sSEventCategory = instance.GetEventCategory();
		}
		else
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			bool flag = _eventProgressData == null;
			sSEventCategory = SSEventCategory.None;
			if (!flag)
			{
				sSEventCategory = eventProgressData.eventCategory__BackingField;
			}
		}
		if (!_supportedCategories.Contains(sSEventCategory))
		{
			sSEventCategory = SSEventCategory.None;
		}
		return sSEventCategory;
	}

	private unsafe bool TryGetListNumberAndIndexInExtrasList(out int listNumber, out int indexInExtrasList)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		ref int reference = ref *(int*)null;
		ref int reference2 = ref *(int*)null;
		_ = 0;
		int[] eventValue = GetEventValue<int[]>(out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		if ((nint)0 != 0 && eventValue.Length >= 1)
		{
			reference = ref *(int*)eventValue[0];
			Characters.CharacterType?[][] currentCharacterCollection = GetCurrentCharacterCollection();
			if (listNumber < 0 || listNumber >= currentCharacterCollection.Length)
			{
				reference = ref *(int*)null;
			}
			if (eventValue.Length >= 2)
			{
				reference2 = ref *(int*)eventValue[1];
				if (eventValue[1] >= 0)
				{
					Characters.CharacterType[] limitedCharacters = _limitedCharacters;
					if (eventValue[1] < limitedCharacters.Length)
					{
						goto IL_018f;
					}
				}
				reference2 = ref *(int*)null;
			}
		}
		goto IL_018f;
		IL_018f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		return false;
	}

	private Characters.CharacterType?[][] GetCurrentCharacterCollection()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		SSEventCategory eventCategoryFromOnlineSetting = GetEventCategoryFromOnlineSetting();
		object obj = eventCategoryFromOnlineSetting - 1;
		if (eventCategoryFromOnlineSetting != SSEventCategory.Cat1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					return (Characters.CharacterType?[][])(this + 40);
				}
				return (Characters.CharacterType?[][])(this + 28);
			}
			return (Characters.CharacterType?[][])(this + 36);
		}
		return (Characters.CharacterType?[][])(this + 32);
	}

	private unsafe List<Characters.CharacterType> CreateNewCharacterList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Ref, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Ref, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected VT, but got Unknown
		//IL_01a9: Expected Ref, but got VT
		//IL_0215: Expected Obj, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected VT, but got Unknown
		//IL_0116: Expected Ref, but got VT
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected VT, but got Unknown
		//IL_015f: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		List<Characters.CharacterType> list = default;
		list._002Ector();
		if (TryGetListNumberAndIndexInExtrasList(out *(int*)(obj + 28), out *(int*)(obj + 24)))
		{
			Characters.CharacterType?[][] currentCharacterCollection = GetCurrentCharacterCollection();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj3 = (nint)0 << 2;
			object obj4 = (object)currentCharacterCollection + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v23+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			object obj6 = 0;
			object obj8 = default;
			object obj15 = default;
			while (true)
			{
				object obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v24+C]");
				if ((nint)obj7 >= 0)
				{
					break;
				}
				object obj9 = obj8 << 3;
				object obj10 = obj5 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v20+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				if ((nint)0 != 0)
				{
					if (AgeRestriction.isRestricted)
					{
						Characters.CharacterType? characterType = (Characters.CharacterType?)(object)(obj + 16);
						Characters.CharacterType value = ((Characters.CharacterType?*)characterType)->Value;
						if (value == Characters.CharacterType.facebookRewardCharacter01)
						{
							PlayerInfo instance = PlayerInfo.Instance;
							Characters.CharacterType? characterType2 = (Characters.CharacterType?)(object)(obj + 16);
							Characters.CharacterType value2 = ((Characters.CharacterType?*)characterType2)->Value;
							if (!instance.IsCharacterOwned(value2))
							{
								goto IL_026d;
							}
						}
					}
					Characters.CharacterType? characterType3 = (Characters.CharacterType?)(object)(obj + 16);
					Characters.CharacterType value3 = ((Characters.CharacterType?*)characterType3)->Value;
					list.Add(value3);
				}
				else if (GetEventCategoryFromOnlineSetting() == SSEventCategory.None)
				{
					Characters.CharacterType[] limitedCharacters = _limitedCharacters;
					bool flag = (nint)obj6 < limitedCharacters.Length;
					object obj11 = obj6;
					if (!flag)
					{
						obj11 = 0;
					}
					object obj12 = obj11 << 2;
					object obj13 = (object)limitedCharacters + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v30+10]");
					list.Add(Characters.CharacterType.slick);
					object obj14 = obj11 + 1;
					obj6 = obj14;
				}
				goto IL_026d;
				IL_026d:
				obj8 = obj15 + 1;
			}
		}
		return list;
	}

	public List<Characters.CharacterType> GetCharactersToDisplay()
	{
		List<Characters.CharacterType> list = default;
		list._002Ector();
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			return TrimEventCharactersList(eventProgressData.charactersList__BackingField);
		}
		return list;
	}

	private List<Characters.CharacterType> TrimEventCharactersList(List<Characters.CharacterType> allEventCharacters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I4
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<Characters.CharacterType> list = default;
		list._002Ector();
		CharacterNameEventData eventProgressData = _eventProgressData;
		bool flag = _eventProgressData == null;
		object obj3 = 0;
		object obj6 = default;
		object obj8;
		object obj9;
		if (!flag)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S5_v6+4] (should have been resolved before IL gen)");
			object obj5 = default;
			bool flag2 = obj5 == null;
			obj3 = 0;
			if (!flag2)
			{
				obj6 = obj5 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [allEventCharacters @ L1 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
				object obj7 = -1;
				bool flag3 = obj7 == obj5;
				obj3 = obj5;
				obj8 = obj6;
				obj9 = obj5;
				if (flag3)
				{
					goto IL_0363;
				}
			}
		}
		object obj10 = obj3 + 1;
		obj8 = obj6;
		obj9 = obj10;
		goto IL_0363;
		IL_0363:
		object obj11 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj12 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj13 = 0;
		object obj15 = default;
		object obj16 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		while (true)
		{
			_ = 0;
			object obj14 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj15 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
					{
						goto IL_019c;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_019c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj16 == obj17;
			bool flag5 = !flag4;
			object obj18 = obj19;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj18 = obj20;
			}
			_ = 0;
			object obj21 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_019c:
			object obj22 = obj13 + 1;
			obj13 = obj22;
		}
		object obj23 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
		return list;
	}

	public int GetLastSelectedThemeForCharacterType(Characters.CharacterType charType)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int indexForLastSelectedTheme = instance.GetIndexForLastSelectedTheme(charType);
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(charType, indexForLastSelectedTheme);
		if (themeForCharacter != null)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			return instance2.GetIndexForLastSelectedTheme(charType);
		}
		return 0;
	}

	public bool IsShowingFirstElement()
	{
		//IL_0046: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I
		CharacterNameEventData eventProgressData = _eventProgressData;
		object obj2 = default;
		if (_eventProgressData != null)
		{
			List<Characters.CharacterType> list = eventProgressData.charactersList__BackingField;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		else
		{
			obj2 = 1;
		}
		return obj2 == null;
	}

	public bool IsShowingLastElement()
	{
		//IL_002e: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			List<Characters.CharacterType> list = eventProgressData.charactersList__BackingField;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S5_v5+4] (should have been resolved before IL gen)");
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			List<Characters.CharacterType> list2 = eventProgressData2.charactersList__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
			object obj2 = -1;
			object obj3 = default;
			return obj3 == obj2;
		}
		return false;
	}

	public unsafe void SkipCurrentCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected VT, but got Unknown
		//IL_00bb: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData == null)
		{
			return;
		}
		bool flag = HasCompletedCollectionForSelectedCharacter();
		eventProgressData.wasLastCharacterCompleted__BackingField = flag;
		CharacterNameEventData eventProgressData2 = _eventProgressData;
		if (~(eventProgressData2.wasLastCharacterCompleted__BackingField ? 1u : 0u) == 0)
		{
			int num = eventProgressData2.completedCharacters__BackingField + 1;
			eventProgressData2.completedCharacters__BackingField = num;
		}
		else
		{
			int num2 = eventProgressData2.skippedCharacters__BackingField + 1;
			eventProgressData2.skippedCharacters__BackingField = num2;
		}
		Characters.CharacterType? nextCharacterToDisplay = GetNextCharacterToDisplay();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if ((nint)0 != 0)
		{
			CharacterNameEventData eventProgressData3 = _eventProgressData;
			Characters.CharacterType? characterType = (Characters.CharacterType?)(object)(obj + 8);
			Characters.CharacterType value = ((Characters.CharacterType?*)characterType)->Value;
			eventProgressData3.currentCharacter__BackingField = value;
			CharacterNameEventData eventProgressData4 = _eventProgressData;
			if (_eventProgressData != null)
			{
				eventProgressData4.collectedLetterIndex__BackingField = -1;
			}
		}
		SaveProgress();
	}

	public Characters.CharacterType? GetNextCharacterToDisplay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00f3: Expected VT, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		if (!IsLastCharacterSelected())
		{
			CharacterNameEventData eventProgressData = _eventProgressData;
			if (_eventProgressData != null)
			{
				List<Characters.CharacterType> list = eventProgressData.charactersList__BackingField;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S5_v5+4] (should have been resolved before IL gen)");
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				object obj5 = default;
				int index = obj5 + 1;
				Characters.CharacterType characterType = eventProgressData2.charactersList__BackingField.get_Item(index);
				_ = 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return (Characters.CharacterType?)(object)0;
	}

	public bool ShouldShowTheCompletedSign()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData == null)
		{
			return false;
		}
		return eventProgressData.wasLastCharacterCompleted__BackingField;
	}

	public bool IsAbleToSkip()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		bool flag = _eventProgressData == null;
		bool flag2 = false;
		if (!flag)
		{
			Characters.Model model = Characters.characterData.get_Item(eventProgressData.currentCharacter__BackingField);
			if (model.unlockType == PurchaseData.UnlockType.Facebook)
			{
				SocialManager instance = SocialManager.instance;
				bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
				bool flag3 = !facebookIsLoggedIn;
				flag2 = false;
				if (flag3)
				{
					goto IL_0134;
				}
			}
			PlayerInfo instance2 = PlayerInfo.Instance;
			bool flag4 = instance2.IsCharacterOwned(eventProgressData.currentCharacter__BackingField);
			flag2 = flag4;
		}
		goto IL_0134;
		IL_0134:
		bool result;
		if (flag2)
		{
			bool flag5 = (byte)(~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u)) != 0;
			result = false;
			if (flag5)
			{
				goto IL_014d;
			}
		}
		bool flag6 = IsLastCharacterSelected();
		bool flag7 = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
		result = flag7;
		goto IL_014d;
		IL_014d:
		return result;
	}

	private bool HasLastCharacterBeenCompleted()
	{
		if (IsLastCharacterSelected())
		{
			return HasCompletedCollectionForSelectedCharacter();
		}
		return false;
	}

	public bool ShouldSpawnLetters()
	{
		if (SelectedCharacterMatchesFocusedCharacter())
		{
			bool flag = HasCompletedCollectionForSelectedCharacter();
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		return false;
	}

	private void ResetCollectProgress()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			eventProgressData.collectedLetterIndex__BackingField = -1;
		}
	}

	public char? NextLetterToSpawn()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_01ae: Expected VT, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			char[] characterNameArray = GetCharacterNameArray(eventProgressData.currentCharacter__BackingField);
			if (characterNameArray.Length != 0 && !HasCompletedCollectionForSelectedCharacter())
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				CharacterNameEventData eventProgressData3 = _eventProgressData;
				object obj4 = characterNameArray.Length - 1;
				if (eventProgressData3.collectedLetterIndex__BackingField < (nint)obj4)
				{
					object obj5 = eventProgressData2.collectedLetterIndex__BackingField + 1;
					object obj6 = obj5 << 1;
					object obj7 = (object)characterNameArray + obj6;
					_ = 0;
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v29+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj8 = 0;
				}
				else
				{
					int num = eventProgressData2.collectedLetterIndex__BackingField << 1;
					object obj9 = characterNameArray + num;
					_ = 0;
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v19+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					object obj8 = 0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (char?)(object)0;
	}

	public void NotifyLetterCollected(char collectedLetter)
	{
		//IL_0028: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_00bd: Expected VT, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected I4, but got Unknown
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			char[] characterNameArray = GetCharacterNameArray(eventProgressData.currentCharacter__BackingField);
			object obj = characterNameArray.Length - 1;
			CharacterNameEventData eventProgressData2 = _eventProgressData;
			bool flag = (nint)obj <= eventProgressData2.collectedLetterIndex__BackingField;
			int num = -1;
			if (!flag)
			{
				CharacterNameEventData eventProgressData3 = _eventProgressData;
				if (eventProgressData3.collectedLetterIndex__BackingField >= 0)
				{
					int startIndex = eventProgressData3.collectedLetterIndex__BackingField + 1;
					num = Array.IndexOf<T>((T[])(object)characterNameArray, (T)collectedLetter, startIndex);
				}
				else
				{
					num = Array.IndexOf(characterNameArray, collectedLetter);
				}
			}
			CharacterNameEventData eventProgressData4 = _eventProgressData;
			object obj2 = num - eventProgressData4.collectedLetterIndex__BackingField;
			if (num >= 0 && (nint)obj2 == 1)
			{
				CharacterNameEventData eventProgressData5 = _eventProgressData;
				eventProgressData5.collectedLetterIndex__BackingField = num;
				UIScreenController instance = UIScreenController.Instance;
				CharacterNameEventData eventProgressData6 = _eventProgressData;
				string characterDisplayName = GetCharacterDisplayName(eventProgressData6.currentCharacter__BackingField);
				char[] val = characterDisplayName.ToCharArray();
				string extraInfo = ((string)null).CreateString(val);
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.CharacterEventWord, eventProgressData6.collectedLetterIndex__BackingField, extraInfo);
				instance.QueueSlideIn(slideIn);
				if (HasCompletedCollectionForSelectedCharacter())
				{
					CelebrationReward celebrationReward = MysteryBox.Roll(MysteryBox.Type.Super);
					celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.CharacterEventSuperMysteryBox;
					CharacterNameEventData eventProgressData7 = _eventProgressData;
					object obj3 = eventProgressData7.completedCharacters__BackingField + eventProgressData7.skippedCharacters__BackingField;
					int characterEventCompleted = obj3 + 1;
					celebrationReward.characterEventCompleted = characterEventCompleted;
					string description = ((string)null).CreateString(characterNameArray);
					celebrationReward.description = description;
					RewardManager.AddRewardToUnlock(celebrationReward, shouldSaveToDisk: false);
					UIScreenController instance2 = UIScreenController.Instance;
					CharacterNameEventData eventProgressData8 = _eventProgressData;
					string characterDisplayName2 = GetCharacterDisplayName(eventProgressData8.currentCharacter__BackingField);
					char[] val2 = characterDisplayName2.ToCharArray();
					string payload = ((string)null).CreateString(val2);
					UIScreenController.SlideIn slideIn2 = default;
					slideIn2._002Ector(UIScreenController.SlideInType.CharacterEventWordReward, payload);
					instance2.QueueSlideIn(slideIn2);
					PlayerInfo instance3 = PlayerInfo.Instance;
					Statistics stats = instance3._stats;
					int[] values = stats._values;
					int value = values[31] + 1;
					stats.set_Item(Stat.WordyWeekendChallengesCompleted, value);
					PlayerInfo instance4 = PlayerInfo.Instance;
					Statistics stats2 = instance4._stats;
					int[] values2 = stats2._values;
					int value2 = values2[34] + 1;
					stats2.set_Item(Stat.WordyWeekendChallengesCompletedOneWeekend, value2);
				}
				SaveProgress();
			}
		}
		if (CharacterNameEventManager.m_OnLetterCollected != null)
		{
			EventHandler<LetterCollectedEventArgs> onLetterCollected = CharacterNameEventManager.m_OnLetterCollected;
			LetterCollectedEventArgs e = default;
			e._002Ector(collectedLetter);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S0_v21 (System.EventHandler`1<CharacterNameEventManager+LetterCollectedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	public int GetAmountOfCollectedLetters()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData == null)
		{
			return 0;
		}
		return eventProgressData.collectedLetterIndex__BackingField + 1;
	}

	public bool HasCompletedCollectionForSelectedCharacter()
	{
		//IL_0087: Expected Obj, but got I4
		CharacterNameEventData eventProgressData = _eventProgressData;
		bool flag = _eventProgressData == null;
		bool result = false;
		if (!flag)
		{
			char[] characterNameArray = GetCharacterNameArray(eventProgressData.currentCharacter__BackingField);
			bool flag2 = characterNameArray.Length == 0;
			result = false;
			if (!flag2)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				object obj = characterNameArray.Length - 1;
				bool flag3 = eventProgressData2.collectedLetterIndex__BackingField == (nint)obj;
				result = flag3;
			}
		}
		return result;
	}

	public bool IsFirstCharacterSelected()
	{
		//IL_0075: Expected Obj, but got I
		CharacterNameEventData eventProgressData = _eventProgressData;
		bool flag = _eventProgressData == null;
		bool result = false;
		if (!flag)
		{
			bool flag2 = eventProgressData.charactersList__BackingField.Contains(eventProgressData.currentCharacter__BackingField);
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				List<Characters.CharacterType> list = eventProgressData2.charactersList__BackingField;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S5_v5+4] (should have been resolved before IL gen)");
				object obj2 = default;
				bool flag4 = obj2 == null;
				result = flag4;
			}
		}
		return result;
	}

	public bool IsLastCharacterSelected()
	{
		//IL_0075: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		CharacterNameEventData eventProgressData = _eventProgressData;
		bool flag = _eventProgressData == null;
		bool result = false;
		if (!flag)
		{
			bool flag2 = eventProgressData.charactersList__BackingField.Contains(eventProgressData.currentCharacter__BackingField);
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				List<Characters.CharacterType> list = eventProgressData2.charactersList__BackingField;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S5_v5+4] (should have been resolved before IL gen)");
				CharacterNameEventData eventProgressData3 = _eventProgressData;
				List<Characters.CharacterType> list2 = eventProgressData3.charactersList__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v11 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
				object obj2 = -1;
				object obj3 = default;
				bool flag4 = obj3 == obj2;
				result = flag4;
			}
		}
		return result;
	}

	private string GetWordForCharacter(Characters.CharacterType characterType)
	{
		//IL_0050: Expected Obj, but got I
		CharacterNameEventData eventProgressData = _eventProgressData;
		StringID key;
		if (_eventProgressData != null && eventProgressData.categoryWordsList__BackingField != null)
		{
			List<Characters.CharacterType> list = eventProgressData.charactersList__BackingField;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>>)+8C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S5_v6+4] (should have been resolved before IL gen)");
			int num3 = default;
			if (num3 >= 0)
			{
				CharacterNameEventData eventProgressData2 = _eventProgressData;
				List<StringID> list2 = eventProgressData2.categoryWordsList__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v10 (System.Collections.Generic.List`1<StringID>)+C]");
				if ((nint)num3 < (nint)0)
				{
					CharacterNameEventData eventProgressData3 = _eventProgressData;
					StringID stringID = eventProgressData3.categoryWordsList__BackingField.get_Item(num3);
					key = stringID;
					if (stringID != StringID.NULL)
					{
						goto IL_013d;
					}
				}
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterType);
		key = model.name;
		goto IL_013d;
		IL_013d:
		return Strings.Get(key);
	}

	private char[] GetCharacterNameArray(Characters.CharacterType characterType)
	{
		string wordForCharacter = GetWordForCharacter(characterType);
		string text = FilterCharacterName(wordForCharacter);
		string text2 = text.ToUpper();
		return text2.ToCharArray();
	}

	private string GetCharacterDisplayName(Characters.CharacterType characterType)
	{
		string wordForCharacter = GetWordForCharacter(characterType);
		string text = wordForCharacter.Trim();
		return text.ToUpper();
	}

	private unsafe string FilterCharacterName(string characterName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected I4, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		char[] fILTERED_CHARACTERS = FILTERED_CHARACTERS;
		object obj3 = 0;
		string result = default;
		string text = default;
		while (fILTERED_CHARACTERS.Length > (nint)obj3)
		{
			object obj4 = obj3 << 1;
			object obj5 = (object)fILTERED_CHARACTERS + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v8+10]");
			_ = 0;
			char c = (char)(obj + 14);
			string oldValue = ((char*)(ushort)c)->ToString();
			result = text.Replace(oldValue, string.Empty);
			object obj6 = obj3 + 1;
			obj3 = obj6;
		}
		return result;
	}

	public void UnHookFromGameEvents()
	{
		SaveProgress();
	}

	public int GetNumberOfKeysToSkip()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData == null)
		{
			return 2;
		}
		return eventProgressData.skippedCharacters__BackingField + 3;
	}

	public bool CanAffordToSkip()
	{
		//IL_004f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0098: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfKeys = instance.amountOfKeys;
		CharacterNameEventData eventProgressData = _eventProgressData;
		object obj = ((_eventProgressData == null) ? ((object)2) : ((object)(eventProgressData.skippedCharacters__BackingField + 3)));
		object obj2 = amountOfKeys - obj;
		object obj3 = obj2 ^ -1;
		return (byte)(obj3 >> 31) != 0;
	}

	public unsafe void UseKeysToSkip()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			object obj3 = eventProgressData.skippedCharacters__BackingField + 3;
		}
		else
		{
			object obj3 = 2;
		}
		CharacterNameEventData eventProgressData2 = _eventProgressData;
		if (_eventProgressData != null)
		{
			_ = eventProgressData2.currentCharacter__BackingField;
			Enum obj4 = (Enum)(obj + 8);
			_ = -1;
			obj4 = (Enum)(object)typeof(Characters.CharacterType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			string text = obj4.ToString();
			int num = obj + 28;
			string text2 = ((int*)num)->ToString();
			string text3 = text + ";" + text2 + ";no";
		}
		MissionsManager instance = MissionsManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		instance.PlayerDidThis(MissionTarget.SpendKeys, 0);
		PlayerInfo instance2 = PlayerInfo.Instance;
		int amountOfKeys = instance2.amountOfKeys;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		int amountOfKeys2 = (int)((nint)amountOfKeys - (nint)0);
		instance2.amountOfKeys = amountOfKeys2;
	}

	public unsafe void LogWatchedAdToSkip()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			object obj3 = eventProgressData.skippedCharacters__BackingField + 3;
		}
		else
		{
			object obj3 = 2;
		}
		CharacterNameEventData eventProgressData2 = _eventProgressData;
		if (_eventProgressData != null)
		{
			_ = eventProgressData2.currentCharacter__BackingField;
			Enum obj4 = (Enum)(obj + 8);
			_ = -1;
			obj4 = (Enum)(object)typeof(Characters.CharacterType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			string text = obj4.ToString();
			int num = obj + 28;
			string text2 = ((int*)num)->ToString();
			string text3 = text + ";" + text2 + ";yes";
		}
	}

	public bool SelectedCharacterMatchesFocusedCharacter()
	{
		CharacterNameEventData eventProgressData = _eventProgressData;
		if (_eventProgressData != null)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			return eventProgressData.currentCharacter__BackingField == (Characters.CharacterType)instance._currentCharacter;
		}
		return false;
	}

	public CharacterNameEventManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_5451: Unknown result type (might be due to invalid IL or missing references)
		//IL_5456: Expected Obj, but got Unknown
		//IL_545f: Expected Obj, but got I4
		//IL_5488: Unknown result type (might be due to invalid IL or missing references)
		//IL_548d: Expected Obj, but got Unknown
		//IL_54a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_54a6: Expected Obj, but got Unknown
		//IL_54af: Expected Obj, but got I4
		//IL_54d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_54dd: Expected Obj, but got Unknown
		//IL_54f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_54f6: Expected Obj, but got Unknown
		//IL_54ff: Expected Obj, but got I4
		//IL_5528: Unknown result type (might be due to invalid IL or missing references)
		//IL_552d: Expected Obj, but got Unknown
		//IL_5541: Unknown result type (might be due to invalid IL or missing references)
		//IL_5546: Expected Obj, but got Unknown
		//IL_554f: Expected Obj, but got I4
		//IL_5578: Unknown result type (might be due to invalid IL or missing references)
		//IL_557d: Expected Obj, but got Unknown
		//IL_5591: Unknown result type (might be due to invalid IL or missing references)
		//IL_5596: Expected Obj, but got Unknown
		//IL_559f: Expected Obj, but got I4
		//IL_55c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_55cd: Expected Obj, but got Unknown
		//IL_55e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_55e6: Expected Obj, but got Unknown
		//IL_55ef: Expected Obj, but got I4
		//IL_5618: Unknown result type (might be due to invalid IL or missing references)
		//IL_561d: Expected Obj, but got Unknown
		//IL_5631: Unknown result type (might be due to invalid IL or missing references)
		//IL_5636: Expected Obj, but got Unknown
		//IL_563f: Expected Obj, but got I4
		//IL_5668: Unknown result type (might be due to invalid IL or missing references)
		//IL_566d: Expected Obj, but got Unknown
		//IL_5681: Unknown result type (might be due to invalid IL or missing references)
		//IL_5686: Expected Obj, but got Unknown
		//IL_568f: Expected Obj, but got I4
		//IL_56b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_56bd: Expected Obj, but got Unknown
		//IL_56d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_56d6: Expected Obj, but got Unknown
		//IL_56df: Expected Obj, but got I4
		//IL_5708: Unknown result type (might be due to invalid IL or missing references)
		//IL_570d: Expected Obj, but got Unknown
		//IL_5721: Unknown result type (might be due to invalid IL or missing references)
		//IL_5726: Expected Obj, but got Unknown
		//IL_572f: Expected Obj, but got I4
		//IL_5758: Unknown result type (might be due to invalid IL or missing references)
		//IL_575d: Expected Obj, but got Unknown
		//IL_5771: Unknown result type (might be due to invalid IL or missing references)
		//IL_5776: Expected Obj, but got Unknown
		//IL_577f: Expected Obj, but got I4
		//IL_57a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_57ad: Expected Obj, but got Unknown
		//IL_57c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_57c6: Expected Obj, but got Unknown
		//IL_57cf: Expected Obj, but got I4
		//IL_57f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_57fd: Expected Obj, but got Unknown
		//IL_5811: Unknown result type (might be due to invalid IL or missing references)
		//IL_5816: Expected Obj, but got Unknown
		//IL_581f: Expected Obj, but got I4
		//IL_5848: Unknown result type (might be due to invalid IL or missing references)
		//IL_584d: Expected Obj, but got Unknown
		//IL_5861: Unknown result type (might be due to invalid IL or missing references)
		//IL_5866: Expected Obj, but got Unknown
		//IL_586f: Expected Obj, but got I4
		//IL_5898: Unknown result type (might be due to invalid IL or missing references)
		//IL_589d: Expected Obj, but got Unknown
		//IL_58b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_58b6: Expected Obj, but got Unknown
		//IL_58bf: Expected Obj, but got I4
		//IL_58e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_58ed: Expected Obj, but got Unknown
		//IL_5901: Unknown result type (might be due to invalid IL or missing references)
		//IL_5906: Expected Obj, but got Unknown
		//IL_590f: Expected Obj, but got I4
		//IL_5938: Unknown result type (might be due to invalid IL or missing references)
		//IL_593d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 6128;
		_eventType = SSEventType.CharacterName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		object obj3 = obj + 6120;
		obj3 = 1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17E8]");
		_ = 0;
		object obj4 = obj + 2040;
		_ = 0;
		object obj5 = obj + 6104;
		obj5 = 1;
		_ = 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17D8]");
		_ = 0;
		object obj6 = obj + 2032;
		_ = 0;
		object obj7 = obj + 6088;
		obj7 = 1;
		_ = 11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C8]");
		_ = 0;
		object obj8 = obj + 2024;
		_ = 0;
		object obj9 = obj + 6072;
		obj9 = 1;
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17B8]");
		_ = 0;
		object obj10 = obj + 2016;
		_ = 0;
		object obj11 = obj + 6056;
		obj11 = 1;
		_ = 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17A8]");
		_ = 0;
		object obj12 = obj + 2008;
		_ = 0;
		object obj13 = obj + 6040;
		obj13 = 1;
		_ = 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1798]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1798]");
		_ = 0;
		object obj14 = obj + 2000;
		_ = 0;
		object obj15 = obj + 6024;
		obj15 = 1;
		_ = 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1788]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1788]");
		_ = 0;
		object obj16 = obj + 1992;
		_ = 0;
		object obj17 = obj + 6008;
		obj17 = 1;
		_ = 13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1778]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1778]");
		_ = 0;
		object obj18 = obj + 1984;
		_ = 0;
		object obj19 = obj + 5992;
		obj19 = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1768]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1768]");
		_ = 0;
		object obj20 = obj + 1976;
		_ = 0;
		object obj21 = obj + 5976;
		obj21 = 1;
		_ = 7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1758]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1758]");
		_ = 0;
		object obj22 = obj + 1968;
		_ = 0;
		object obj23 = obj + 5960;
		obj23 = 1;
		_ = 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1748]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1748]");
		_ = 0;
		object obj24 = obj + 1960;
		_ = 0;
		object obj25 = obj + 5944;
		obj25 = 1;
		_ = 5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1738]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1738]");
		_ = 0;
		object obj26 = obj + 1952;
		_ = 0;
		object obj27 = obj + 5928;
		obj27 = 1;
		_ = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1728]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1728]");
		_ = 0;
		object obj28 = obj + 1944;
		_ = 0;
		object obj29 = obj + 5912;
		obj29 = 1;
		_ = 14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1718]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1718]");
		_ = 0;
		object obj30 = obj + 1936;
		_ = 0;
		object obj31 = obj + 5896;
		obj31 = 1;
		_ = 9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1708]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1708]");
		_ = 0;
		object obj32 = obj + 1928;
		_ = 0;
		object obj33 = obj + 5880;
		obj33 = 1;
		_ = 10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+16F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+16F8]");
		_ = 0;
		object obj34 = obj + 1920;
		throw new ArrayTypeMismatchException();
	}

	static CharacterNameEventManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = ' ';
		FILTERED_CHARACTERS = array;
	}
}
