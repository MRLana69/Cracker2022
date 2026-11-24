namespace UI.Screens.CharacterScreenInternal;

public class CharacterModelRequest
{
	public class CharacterBundleRequest
	{
		public readonly CharacterId characterId; //Field offset: 0x8
		public readonly int Theme; //Field offset: 0xC
		public readonly string[] AssetBundleNames; //Field offset: 0x10
		private int _loadedBundleCount; //Field offset: 0x14
		private List<CharacterModelRequest> _requests; //Field offset: 0x18

		public CharacterBundleRequest(CharacterId characterId, int theme) { }

		public int GetPriority() { }

		public void OnBundleLoaded(AssetBundle bundle) { }

		public void RegisterModelRequest(CharacterModelRequest modelRequest) { }

		public bool RemoveModelRequest(CharacterModelRequest modelRequest) { }

	}

	public enum RequestState
	{
		None = 0,
		RequestingBundles = 1,
		BuildingCharacter = 2,
		Finished = 3,
		Cancelled = 4,
	}

	private const string CHARACTER_MODEL_REQUEST_DEBUG_LOG_TAG = "CharacterModelRequest: "; //Field offset: 0x0
	private readonly CharacterListManager _listManager; //Field offset: 0x8
	private readonly CharacterId _characterId; //Field offset: 0xC
	private readonly int _theme; //Field offset: 0x10
	private readonly int _scrollIndex; //Field offset: 0x14
	private readonly bool _synchronous; //Field offset: 0x18
	private RequestState _state; //Field offset: 0x1C
	private int _priority; //Field offset: 0x20

	public CharacterId characterId
	{
		 get { } //Length: 12
	}

	public RequestState State
	{
		 get { } //Length: 6
	}

	public CharacterModelRequest(CharacterId charId, int theme, int scrollIndex, CharacterListManager listManager, bool synchronous = false) { }

	public void CancelRequest() { }

	public CharacterId get_characterId() { }

	public RequestState get_State() { }

	private void HandleCompletedRequest(GameObject characterModel) { }

	private static void Log(string msg, Object context = null) { }

	private void OnCharacterBundlesLoaded() { }

	public void SetPriority(int priority) { }

}

