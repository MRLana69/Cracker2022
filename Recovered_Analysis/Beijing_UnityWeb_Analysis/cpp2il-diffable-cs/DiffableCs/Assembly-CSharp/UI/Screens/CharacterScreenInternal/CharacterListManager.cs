namespace UI.Screens.CharacterScreenInternal;

public class CharacterListManager
{
	private sealed class <>c__DisplayClass16_0
	{
		public CharacterId characterId; //Field offset: 0x8

		public <>c__DisplayClass16_0() { }

		internal bool <get_Item>b__0(CharacterScrollListSlot slot) { }

	}

	private sealed class <>c__DisplayClass21_0
	{
		public CharacterListManager <>4__this; //Field offset: 0x8
		public int centerIndex; //Field offset: 0xC

		public <>c__DisplayClass21_0() { }

		internal bool <GetPrioritizedPendingSlots>b__0(CharacterScrollListSlot slot) { }

		internal int <GetPrioritizedPendingSlots>b__1(CharacterScrollListSlot s) { }

	}

	private const string CHARACTER_LIST_MANAGER_DEBUG_LOG_TAG = "Character List manager: "; //Field offset: 0x0
	public readonly CharacterScrollListSlot[] _characterSlots; //Field offset: 0x8
	private readonly CharacterScreenManager _screenManager; //Field offset: 0xC
	private readonly CharacterScreen _characterScreen; //Field offset: 0x10
	private bool <allModelsLoaded>k__BackingField; //Field offset: 0x14

	public bool allModelsLoaded
	{
		 get { } //Length: 9
		private set { } //Length: 111
	}

	public CharacterScrollListSlot Item
	{
		 get { } //Length: 28
		 set { } //Length: 124
	}

	public CharacterScrollListSlot Item
	{
		 get { } //Length: 273
	}

	public int size
	{
		 get { } //Length: 6
	}

	public CharacterListManager(int size, CharacterScreen characterSscreen) { }

	public void EnableSlots(bool modelEnabled, bool uiEnabled) { }

	public bool get_allModelsLoaded() { }

	public CharacterScrollListSlot get_Item(int index) { }

	public CharacterScrollListSlot get_Item(CharacterId characterId) { }

	public int get_size() { }

	public IEnumerator GetEnumerator() { }

	private List<CharacterScrollListSlot> GetPrioritizedPendingSlots(int centerIndex, bool fullList = false) { }

	private bool IsWithinRange(int center, int position, int threshold) { }

	public void LoadAInitialModels() { }

	private void LoadModelsSynchronously(List<CharacterScrollListSlot> pendingSlots) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private void OnInitialModelLoadingComplete() { }

	public void OnModelLoaded(CharacterId characterId, int themeIndex, int scrollIndex, GameObject characterModel, bool synchronous) { }

	public void RefreshCharacter(CharacterId characterId, int themeIndex) { }

	private void set_allModelsLoaded(bool value) { }

	public void set_Item(int index, CharacterScrollListSlot value) { }

	public void SetLoadedState(int slotIndex, bool shouldBeLoaded, int priority) { }

	public void UpdateSlotsState(int centerIndex) { }

}

