namespace UI.Screens;

public class CharacterScreenManager
{
	public enum CharacterPurchaseInitiator
	{
		none = 0,
		characterScreen = 1,
		characterNameEvent = 2,
		limitedCharacterPopup = 3,
		BirthdayCharacterComeback = 4,
	}

	private static CharacterScreenManager _instance; //Field offset: 0x0
	private static Action<CharacterId, int> characterUnlocked; //Field offset: 0x4
	private static Action characterUnlockedFailure; //Field offset: 0x8
	private static Action onCharacterSelected; //Field offset: 0xC
	private static Action onFacebookStatusChanged; //Field offset: 0x10
	private bool _purchaseInProgress; //Field offset: 0x8
	private bool _facebookLoginRunning; //Field offset: 0x9
	private CharacterPurchaseInitiator _characterPurchaseInitiator; //Field offset: 0xC
	private CharacterId <currentlyShownCharacter>k__BackingField; //Field offset: 0x10
	private int <currentlyShownThemeIndex>k__BackingField; //Field offset: 0x14

	public static event Action<CharacterId, int> characterUnlocked
	{
		 add { } //Length: 174
		 remove { } //Length: 209
	}

	public static event Action characterUnlockedFailure
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action onCharacterSelected
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action onFacebookStatusChanged
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public CharacterId currentlyShownCharacter
	{
		 get { } //Length: 9
		 set { } //Length: 258
	}

	public int currentlyShownThemeIndex
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public static CharacterScreenManager Instance
	{
		 get { } //Length: 89
	}

	private static CharacterScreenManager() { }

	private CharacterScreenManager() { }

	public static void add_characterUnlocked(Action<CharacterId, int> value) { }

	public static void add_characterUnlockedFailure(Action value) { }

	public static void add_onCharacterSelected(Action value) { }

	public static void add_onFacebookStatusChanged(Action value) { }

	public void CharacterPurchaseFailure() { }

	public void CharacterPurchaseSuccessful(CharacterId purchasedCharacter, int themeIndex) { }

	private void FacebookStatusChanged(bool success) { }

	public CharacterId get_currentlyShownCharacter() { }

	public int get_currentlyShownThemeIndex() { }

	public static CharacterScreenManager get_Instance() { }

	public Nullable<CharacterId> GetCharacterTypeActiveInEvent() { }

	public int GetLastSelectedThemeForCharacterType(CharacterId charId) { }

	public bool IsFacebookLoginRunning() { }

	public void OnCharacterScreenHide() { }

	private void OnCharacterUnlocked(CharacterId character, int outfit) { }

	public void OnFacebookCharacterUnlocked() { }

	public void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFacebookLoginStopped() { }

	public void OnFacebookLogout() { }

	public void OnFirstPurchaseCharacterUnlocked() { }

	public void PurchaseCharacter(CharacterPurchaseInitiator initiator, CharacterId characterId, int themeIndex, int priceOverride = -1) { }

	public void PurchaseCharacterWithInapp(CharacterPurchaseInitiator initiator, CharacterId characterId) { }

	private void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	public static void remove_characterUnlocked(Action<CharacterId, int> value) { }

	public static void remove_characterUnlockedFailure(Action value) { }

	public static void remove_onCharacterSelected(Action value) { }

	public static void remove_onFacebookStatusChanged(Action value) { }

	public void SelectCharacter(CharacterId charId, int themeIndex) { }

	public void set_currentlyShownCharacter(CharacterId value) { }

	public void set_currentlyShownThemeIndex(int value) { }

	public void StartLoginToFacebook() { }

}

