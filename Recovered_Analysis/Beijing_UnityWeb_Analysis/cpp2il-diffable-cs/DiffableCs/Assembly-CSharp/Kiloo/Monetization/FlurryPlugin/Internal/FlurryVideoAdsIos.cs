namespace Kiloo.Monetization.FlurryPlugin.Internal;

public class FlurryVideoAdsIos : MonoBehaviour, IFlurryVideoAds
{
	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "FlurryAdsBridgeReceiver"; //Field offset: 0x0
	private static bool _initialized; //Field offset: 0x0
	private static GameObject _callbackReceiver; //Field offset: 0x4
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
		 add { } //Length: 71
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

	private static void _flurryadsplugin_enableDebugLogs(bool enable) { }

	private static void _flurryadsplugin_enableTestAds(bool enable) { }

	private static void _flurryadsplugin_fetchAd(string adSpace) { }

	private static void _flurryadsplugin_initWithSpace() { }

	private static void _flurryadsplugin_presentWithViewController(string adSpace) { }

	private static bool _flurryadsplugin_ready(string adSpace) { }

	private static FlurryVideoAdsIos() { }

	public FlurryVideoAdsIos() { }

	public void add_onAdClickedEvent(FlurryAdsCallback value) { }

	public void add_onAdClosedEvent(FlurryAdsCallback value) { }

	public void add_onAdOpenedEvent(FlurryAdsCallback value) { }

	public void add_onApplicationExitEvent(FlurryAdsCallback value) { }

	public void add_onInitFinished(Action<bool> value) { }

	public void add_onRenderFailedEvent(FlurryAdsCallback value) { }

	public void add_onSpaceDidFailToReceiveAdEvent(FlurryAdsCallback value) { }

	public void add_onSpaceDidReceiveAdEvent(FlurryAdsCallback value) { }

	public void add_onVideoCompletedEvent(FlurryAdsCallback value) { }

	private void callback_adError(string error) { }

	private void callback_didDismiss(string adSpace) { }

	private void callback_didFetchAd(string adSpace) { }

	private void callback_didRecieveClick(string adSpace) { }

	private void callback_didRender(string adSpace) { }

	private void callback_onInitFinished(string msg) { }

	private void callback_videoDidFinish(string adSpace) { }

	private void callback_willDismiss(string adSpace) { }

	private void callback_willLeaveApplication(string adSpace) { }

	private void callback_willPresent(string adSpace) { }

	public static FlurryVideoAdsIos CreatePlugin() { }

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

	private void PresentWithViewController(string adSpace) { }

	private bool Ready(string adSpace) { }

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

