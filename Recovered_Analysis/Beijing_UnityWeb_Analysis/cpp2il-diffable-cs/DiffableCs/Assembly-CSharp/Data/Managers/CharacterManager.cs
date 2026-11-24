namespace Data.Managers;

public static class CharacterManager
{
	private sealed class <>c__DisplayClass21_0
	{
		public int outfitIndex; //Field offset: 0x8

		public <>c__DisplayClass21_0() { }

		internal bool <IsOutfitUnlocked>b__0(int t) { }

	}

	private static readonly CultureInfo DATETIME_CULTUREINFO; //Field offset: 0x0
	private static List<KeyValuePair<CharacterId, Model>> _characterList; //Field offset: 0x4
	private static Action<CharacterId> characterUnlocked; //Field offset: 0x8
	private static Action<CharacterId> characterTokenCollected; //Field offset: 0xC
	private static Action<CharacterId> outfitUnlocked; //Field offset: 0x10

	public static event Action<CharacterId> characterTokenCollected
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<CharacterId> characterUnlocked
	{
		 add { } //Length: 56
		 remove { } //Length: 209
	}

	public static event Action<CharacterId> outfitUnlocked
	{
		 add { } //Length: 56
		 remove { } //Length: 209
	}

	private static CharacterManager() { }

	public static void add_characterTokenCollected(Action<CharacterId> value) { }

	public static void add_characterUnlocked(Action<CharacterId> value) { }

	public static void add_outfitUnlocked(Action<CharacterId> value) { }

	public static DateTime CharacterExpirationDate(CharacterId characterId) { }

	public static TimeSpan CharacterExpirationTimespan(CharacterId characterId) { }

	public static DateTime CharacterStartAvailabilityDate(CharacterId characterId) { }

	public static void CollectToken(CharacterId characterId, int amount) { }

	private static DateTime DefaultExpirationDateForCharacter(CharacterId cId) { }

	private static List<KeyValuePair<CharacterId, Model>> GenerateAvailableCharacters() { }

	public static List<KeyValuePair<CharacterId, Model>> GetAvailableCharacters(bool forceRefresh = false) { }

	public static int GetCollectedTokens(CharacterId characterId) { }

	public static int GetOutfitIndex(CharacterId characterId) { }

	public static bool HasCharacterBeenSeen(CharacterId characterId) { }

	public static bool IsCharacterAvailable(CharacterId characterId) { }

	public static bool IsCharacterOwned(CharacterId characterId) { }

	private static bool IsCollectionComplete(CharacterId characterId) { }

	public static bool IsOutfitUnlocked(CharacterId character, int outfitIndex) { }

	public static bool IsTokenUseful(CharacterId characterId, CelebrationReward currentReward = null, bool isDoubling = false) { }

	public static void LockCharacter(CharacterId characterId) { }

	public static void MarkCharacterAsSeen(CharacterId characterId) { }

	public static void remove_characterTokenCollected(Action<CharacterId> value) { }

	public static void remove_characterUnlocked(Action<CharacterId> value) { }

	public static void remove_outfitUnlocked(Action<CharacterId> value) { }

	public static void SetOutfitSelectionIndex(CharacterId character, int outfitIndex) { }

	public static void UnlockCharacter(CharacterId characterId) { }

	public static void UnlockOutfit(CharacterId character, int outfitIndex) { }

}

