//Type is in global namespace

public class CharacterNameEventManager : IEventManager
{
	private sealed class <>c__DisplayClass37_0`1
	{
		public Type elementType; //Field offset: 0x0

		public <>c__DisplayClass37_0`1() { }

		internal object <GetEventValue>b__0(string item) { }

	}

	public class LetterCollectedEventArgs : EventArgs
	{
		private char _characterCollected; //Field offset: 0x8

		public char CharacterCollected
		{
			 get { } //Length: 6
		}

		public LetterCollectedEventArgs(char characterCollected) { }

		public char get_CharacterCollected() { }

		public override string ToString() { }

	}

	private static EventHandler<LetterCollectedEventArgs> OnLetterCollected; //Field offset: 0x0
	public const string ONLINE_SETTING_DESCRIPTION_FIRST_UNLOCK_CHARATER_NAME = "event_popup_description_first_unlock_character_name"; //Field offset: 0x0
	public const string ONLINE_SETTING_DESCRIPTION_SECOND_UNLOCK_CHARACTER_NAME = "event_popup_description_second_unlock_character_name"; //Field offset: 0x0
	public const string ONLINE_SETTING_DESCRIPTION_FIRST_SELECT_CHARACTER_NAME = "event_popup_description_first_select_character_name"; //Field offset: 0x0
	public const string ONLINE_SETTING_DESCRIPTION_SECOND_SELECT_CHARACTER_NAME = "event_popup_description_second_select_character_name"; //Field offset: 0x0
	public const int DEFAULT_VALUE_FOR_COLLECT = -1; //Field offset: 0x0
	private static Action<CharacterId, int> OnCharacterSkippedWithKeys; //Field offset: 0x4
	private static Action<CharacterId> OnCharacterSkippedWithVideo; //Field offset: 0x8
	public static readonly char[] FILTERED_CHARACTERS; //Field offset: 0xC
	private SSEventType _eventType; //Field offset: 0x8
	private long _eventID; //Field offset: 0x10
	private CharacterNameEventData _eventProgressData; //Field offset: 0x18
	private bool _hasAddedAdSystemInitialisationEventListener; //Field offset: 0x1C
	private Nullable<CharacterId>[][] normalCharacters; //Field offset: 0x20
	private Nullable<CharacterId>[][] _musicCharacters; //Field offset: 0x24
	private Nullable<CharacterId>[][] _movieCharacters; //Field offset: 0x28
	private Nullable<CharacterId>[][] _danceCharacters; //Field offset: 0x2C
	private CharacterId[] _limitedCharacters; //Field offset: 0x30
	private Dictionary<CharacterId, string> _musicWordCollection; //Field offset: 0x34
	private Dictionary<CharacterId, string> _movieWordCollection; //Field offset: 0x38
	private Dictionary<CharacterId, string> _danceWordCollection; //Field offset: 0x3C
	private List<SSEventCategory> _supportedCategories; //Field offset: 0x40

	public static event Action<CharacterId, int> OnCharacterSkippedWithKeys
	{
		 add { } //Length: 206
		 remove { } //Length: 209
	}

	public static event Action<CharacterId> OnCharacterSkippedWithVideo
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event EventHandler<LetterCollectedEventArgs> OnLetterCollected
	{
		 add { } //Length: 8
		 remove { } //Length: 206
	}

	private static CharacterNameEventManager() { }

	public CharacterNameEventManager() { }

	public static void add_OnCharacterSkippedWithKeys(Action<CharacterId, int> value) { }

	public static void add_OnCharacterSkippedWithVideo(Action<CharacterId> value) { }

	public static void add_OnLetterCollected(EventHandler<LetterCollectedEventArgs> value) { }

	public bool CanAffordToSkip() { }

	private void CheckIfDataIsValid() { }

	public static CharacterNameEventManager Create(SSEventType eventType, long eventID) { }

	private List<string> CreateNewCategoryWordsDict(List<CharacterId> charactersList) { }

	private List<CharacterId> CreateNewCharacterList() { }

	private string FilterCharacterName(string characterName) { }

	public int GetAmountOfCollectedLetters() { }

	private string GetCharacterDisplayName(CharacterId characterId) { }

	public List<CharacterId> GetCharacterList() { }

	private char[] GetCharacterNameArray(CharacterId characterId) { }

	public List<CharacterId> GetCharactersToDisplay() { }

	private Nullable<CharacterId>[][] GetCurrentCharacterCollection() { }

	private string GetDescriptionTitleForCharacterNotOwned() { }

	public SSEventCategory GetEventCategory() { }

	private SSEventCategory GetEventCategoryFromOnlineSetting() { }

	public long GetEventID() { }

	public SSEventType GetEventType() { }

	public T GetEventValue(out bool found) { }

	public int GetLastSelectedThemeForCharacterType(CharacterId charId) { }

	public Nullable<CharacterId> GetNextCharacterToDisplay() { }

	public int GetNumberOfKeysToSkip() { }

	public void GetPopupDescription(out string firstTitle, out string secondTitle) { }

	public void GetPopupTitle(out string firstLine, out string secondLine) { }

	public void GetRibbonDescription(out string firstLine, out string secondLine, out string thirdLine) { }

	private string GetWordForCharacter(CharacterId characterId) { }

	public bool HasCompletedCollectionForSelectedCharacter() { }

	private bool HasLastCharacterBeenCompleted() { }

	private CharacterNameEventData InitCharacterNameEventData() { }

	private void Initialize(SSEventType eventType, long eventID) { }

	public bool IsAbleToSkip() { }

	public bool IsEventActive() { }

	public bool IsFirstCharacterSelected() { }

	public bool IsLastCharacterSelected() { }

	public bool IsShowingFirstElement() { }

	public bool IsShowingLastElement() { }

	public void LogWatchedAdToSkip() { }

	public Nullable<char> NextLetterToSpawn() { }

	public void NotifyLetterCollected(char collectedLetter) { }

	public static void remove_OnCharacterSkippedWithKeys(Action<CharacterId, int> value) { }

	public static void remove_OnCharacterSkippedWithVideo(Action<CharacterId> value) { }

	public static void remove_OnLetterCollected(EventHandler<LetterCollectedEventArgs> value) { }

	private void ResetCollectProgress() { }

	public void SaveProgress() { }

	public bool SelectedCharacterMatchesFocusedCharacter() { }

	public bool ShouldShowTheCompletedSign() { }

	public bool ShouldSpawnLetters() { }

	public void SkipCurrentCharacter() { }

	private List<CharacterId> TrimEventCharactersList(List<CharacterId> allEventCharacters) { }

	private bool TryGetListNumberAndIndexInExtrasList(out int listNumber, out int indexInExtrasList) { }

	public void UnHookFromGameEvents() { }

	public void UseKeysToSkip() { }

}

