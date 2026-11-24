namespace Kiloo.Monetization.FlurryPlugin.Internal;

public class FlurryVideoAdsAndroid : MonoBehaviour, IFlurryVideoAds
{
	private static AndroidJavaObject _plugin; //Field offset: 0x0
	private const string NATIVE_ENABLEDEBUG = "setDebugLogsEnabled"; //Field offset: 0x0
	private const string NATIVE_DISPLAY = "displayAd"; //Field offset: 0x0
	private const string NATIVE_READY = "isReady"; //Field offset: 0x0
	private const string NATIVE_FETCH = "fetchAd"; //Field offset: 0x0
	private const string NATIVE_ENABLETESTADS = "setEnableTestAds"; //Field offset: 0x0
	private const string NATIVE_JAVA_CLASS = "com.kiloo.flurryads.FlurryAdsBridge"; //Field offset: 0x0
	private const string CALLBACK_RECEIVER_NAME = "FlurryAdsBridgeReceiver"; //Field offset: 0x0
	private const string NATIVE_INITIALIZE = "initialize"; //Field offset: 0x0
	private static bool _initialized; //Field offset: 0x4
	private static GameObject _callbackReceiver; //Field offset: 0x8
	private FlurryAdsCallback onAdClosedEvent; //Field offset: 0xC
	private FlurryAdsCallback onApplicationExitEvent; //Field offset: 0x10
	private FlurryAdsCallback onRenderFailedEvent; //Field offset: 0x14
	private FlurryAdsCallback onSpaceDidFailToReceiveAdEvent; //Field offset: 0x18
	private FlurryAdsCallback onSpaceDidReceiveAdEvent; //Field offset: 0x1C
	private FlurryAdsCallback onAdClickedEvent; //Field offset: 0x20
	private FlurryAdsCallback onAdOpenedEvent; //Field offset: 0x24
	private FlurryAdsCallback onVideoCompletedEvent; //Field offset: 0x28
	private Action<bool> onInitFinished; //Field offset: 0x2C

	public event FlurryAdsCallback onAdClickedEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onAdClosedEvent
	{
		 add { } //Length: 121
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onAdOpenedEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onApplicationExitEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<bool> onInitFinished
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onRenderFailedEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onSpaceDidFailToReceiveAdEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onSpaceDidReceiveAdEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event FlurryAdsCallback onVideoCompletedEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	private static FlurryVideoAdsAndroid() { }

	public FlurryVideoAdsAndroid() { }

	public void add_onAdClickedEvent(FlurryAdsCallback value) { }

	public void add_onAdClosedEvent(FlurryAdsCallback value) { }

	public void add_onAdOpenedEvent(FlurryAdsCallback value) { }

	public void add_onApplicationExitEvent(FlurryAdsCallback value) { }

	public void add_onInitFinished(Action<bool> value) { }

	public void add_onRenderFailedEvent(FlurryAdsCallback value) { }

	public void add_onSpaceDidFailToReceiveAdEvent(FlurryAdsCallback value) { }

	public void add_onSpaceDidReceiveAdEvent(FlurryAdsCallback value) { }

	public void add_onVideoCompletedEvent(FlurryAdsCallback value) { }

	private void callback_onAdClicked(string adSpace) { }

	private void callback_onAppExit(string adSpace) { }

	private void callback_onClose(string adSpace) { }

	private void callback_onDisplay(string adSpace) { }

	private void callback_onError(string error) { }

	private void callback_onFetched(string adSpace) { }

	private void callback_onInitFinished(string msg) { }

	private void callback_onVideoCompleted(string adSpace) { }

	public static FlurryVideoAdsAndroid CreatePlugin() { }

	public void DisplayAd(string adSpace) { }

	public void EnableDebugLogs() { }

	public void EnableTestAds() { }

	public void FetchAd(string adSpace) { }

	public void Initialize() { }

	private void InvokeHandlerIfNotNull(FlurryAdsCallback handler, string message) { }

	public bool IsReady(string adSpace) { }

	private void Log(string msg, Object context = null) { }

	private void LogError(string msg, Object context = null) { }

	private void LogWarning(string msg, Object context = null) { }

	private void native_DisplayAd(string adSpace) { }

	private void native_enableDebugLogs(bool enable) { }

	private void native_EnableTestAds(bool enable) { }

	private void native_FetchAd(string adSpace) { }

	private void native_Initialize() { }

	private bool native_Ready(string adSpace) { }

	public void remove_onAdClickedEvent(FlurryAdsCallback value) { }

	public void remove_onAdClosedEvent(FlurryAdsCallback value) { }

	public void remove_onAdOpenedEvent(FlurryAdsCallback value) { }

	public void remove_onApplicationExitEvent(FlurryAdsCallback value) { }

	public void remove_onInitFinished(Action<bool> value) { }

	public void remove_onRenderFailedEvent(FlurryAdsCallback value) { }

	public void remove_onSpaceDidFailToReceiveAdEvent(FlurryAdsCallback value) { }

	public void remove_onSpaceDidReceiveAdEvent(FlurryAdsCallback value) { }

	public void remove_onVideoCompletedEvent(FlurryAdsCallback value) { }

}

