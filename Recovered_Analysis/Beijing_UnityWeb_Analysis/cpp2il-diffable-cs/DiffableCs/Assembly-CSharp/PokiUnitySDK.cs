//Type is in global namespace

public class PokiUnitySDK : MonoBehaviour
{
	private sealed class <>c__DisplayClass49_0
	{
		public string size; //Field offset: 0x8

		public <>c__DisplayClass49_0() { }

		internal bool <displayAd>b__0(string element) { }

	}

	public delegate CommercialBreakDelegate
	{

		public CommercialBreakDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public class LoadingProgressData : ScriptableObject
	{
		public float percentageDone; //Field offset: 0xC
		public int kbLoaded; //Field offset: 0x10
		public int kbTotal; //Field offset: 0x14
		public string fileNameLoaded; //Field offset: 0x18
		public int filesLoaded; //Field offset: 0x1C
		public int filesTotal; //Field offset: 0x20

		public LoadingProgressData() { }

	}

	public delegate RewardedBreakDelegate
	{

		public RewardedBreakDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool withReward, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool withReward) { }

	}

	private static PokiUnitySDK _instance; //Field offset: 0x0
	private bool initialized; //Field offset: 0xC
	public bool adblocked; //Field offset: 0xD
	private bool <isShowingAd>k__BackingField; //Field offset: 0xE
	public CommercialBreakDelegate commercialBreakCallBack; //Field offset: 0x10
	public RewardedBreakDelegate rewardedBreakCallBack; //Field offset: 0x14

	public static PokiUnitySDK Instance
	{
		 get { } //Length: 6
	}

	public bool isShowingAd
	{
		 get { } //Length: 28
		 set { } //Length: 81
	}

	public PokiUnitySDK() { }

	public void adblock() { }

	public bool adsBlocked() { }

	public void checkInit() { }

	public void commercialBreak() { }

	public void commercialBreakCompleted() { }

	public void customEvent(string eventNoun, string eventVerb, ScriptableObject eventData) { }

	public void destroyAd(string identifier) { }

	public void displayAd(string identifier, string size, string top, string left) { }

	public void gameInteractive() { }

	public void gameLoadingFinished() { }

	public void gameLoadingProgress(LoadingProgressData data) { }

	public void gameLoadingStart() { }

	public void gameplayStart() { }

	public void gameplayStop() { }

	public static PokiUnitySDK get_Instance() { }

	public bool get_isShowingAd() { }

	public void happyTime(float intensity) { }

	public void init() { }

	public bool isInitialized() { }

	private static void JS_PokiSDK_commercialBreak() { }

	private static void JS_PokiSDK_customEvent(string noun, string verb, string data) { }

	private static void JS_PokiSDK_destroyAd(string indentifier) { }

	private static void JS_PokiSDK_displayAd(string indentifier, string size, string top, string left) { }

	private static void JS_PokiSDK_gameInteractive() { }

	private static void JS_PokiSDK_gameLoadingFinished() { }

	private static void JS_PokiSDK_gameLoadingProgress(string data) { }

	private static void JS_PokiSDK_gameLoadingStart() { }

	private static void JS_PokiSDK_gameplayStart() { }

	private static void JS_PokiSDK_gameplayStop() { }

	private static void JS_PokiSDK_happyTime(string intensity) { }

	private static void JS_PokiSDK_initPokiBridge(string instanceName) { }

	private static void JS_PokiSDK_rewardedBreak() { }

	private static void JS_PokiSDK_roundEnd(string indentifier) { }

	private static void JS_PokiSDK_roundStart(string indentifier) { }

	private static void JS_PokiSDK_setPlayerAge(string age) { }

	private static void JS_PokiSDK_togglePlayerAdvertisingConsent(string consent) { }

	public void ready() { }

	public void rewardedBreak() { }

	public void rewardedBreakCompleted(string withReward) { }

	public void roundEnd(string indentifier) { }

	public void roundStart(string indentifier) { }

	public void set_isShowingAd(bool value) { }

	public void setPlayerAge(int age) { }

	public void togglePlayerAdvertisingConsent(bool consent) { }

}

