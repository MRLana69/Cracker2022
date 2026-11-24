//Type is in global namespace

public class CollectCoinsScreenManager
{
	public enum CollectCoinsScreenState
	{
		Offline = 0,
		Facebook = 1,
		GameCenter = 2,
		FacebookAndGamecenter = 3,
	}

	private static CollectCoinsScreenManager _instance; //Field offset: 0x0
	public const int GCFriendsThreshold = 3; //Field offset: 0x0
	public Action<CollectCoinsScreenState> OnCollectCoinsScreenStateChangedEvent; //Field offset: 0x8
	private CollectCoinsScreenState _screenState; //Field offset: 0xC

	public static CollectCoinsScreenManager Instance
	{
		 get { } //Length: 49
	}

	public static bool isInitialized
	{
		 get { } //Length: 217
	}

	public CollectCoinsScreenState screenState
	{
		 get { } //Length: 66
		private set { } //Length: 50
	}

	private static CollectCoinsScreenManager() { }

	public CollectCoinsScreenManager() { }

	public static CollectCoinsScreenManager get_Instance() { }

	public static bool get_isInitialized() { }

	public CollectCoinsScreenState get_screenState() { }

	private void ScreenStateChanged(CollectCoinsScreenState newState) { }

	private void set_screenState(CollectCoinsScreenState value) { }

	private void UpdateScreenState() { }

}

