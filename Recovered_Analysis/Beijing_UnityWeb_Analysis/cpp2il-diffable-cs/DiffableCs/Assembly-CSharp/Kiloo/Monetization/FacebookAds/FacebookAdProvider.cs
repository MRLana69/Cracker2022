namespace Kiloo.Monetization.FacebookAds;

public class FacebookAdProvider : AbstractAdProvider
{
	public const string ID = "facebook"; //Field offset: 0x0
	private bool _addedListeners; //Field offset: 0x29
	private bool _videoWatched; //Field offset: 0x2A
	private Dictionary<string, string> _adLocationToCacheId; //Field offset: 0x2C

	public override List<AdType> adTypesWithClickCallbackSupport
	{
		 get { } //Length: 3
	}

	public override string id
	{
		 get { } //Length: 3
	}

	public override bool supportsMulticaching
	{
		 get { } //Length: 43
	}

	public FacebookAdProvider() { }

	private void <OnInitialize>b__10_0(string cacheID) { }

	private void <OnInitialize>b__10_1(string msg) { }

	private void <OnInitialize>b__10_10(string cacheID) { }

	private void <OnInitialize>b__10_2(string msg) { }

	private void <OnInitialize>b__10_3(string msg) { }

	private void <OnInitialize>b__10_4(string placement) { }

	private void <OnInitialize>b__10_5(string cacheID) { }

	private void <OnInitialize>b__10_6(string msg) { }

	private void <OnInitialize>b__10_7(string msg) { }

	private void <OnInitialize>b__10_8(string cacheID) { }

	private void <OnInitialize>b__10_9(string cacheID) { }

	protected override void CacheInterstitial(string adLocationID, string cacheID) { }

	protected override void CacheVideo(string adLocationID, string cacheID) { }

	protected override void CheckPlatformSupport(AdProviderConfiguration configuration) { }

	public override List<AdType> get_adTypesWithClickCallbackSupport() { }

	public override string get_id() { }

	public override bool get_supportsMulticaching() { }

	protected override bool HasCachedInterstitial(string cacheID) { }

	protected override bool HasCachedVideo(string cacheID) { }

	private void Log(string message) { }

	private void LogError(string message) { }

	private void LogWarning(string message) { }

	protected override void OnInitialize(AdProviderConfiguration configuration) { }

	protected override void ShowInterstitial(string adLocationID, string cacheID) { }

	protected override void ShowVideo(string adLocationId, string cacheId) { }

}

