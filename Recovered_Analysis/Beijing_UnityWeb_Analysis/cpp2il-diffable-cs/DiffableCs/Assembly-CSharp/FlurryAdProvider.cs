//Type is in global namespace

public class FlurryAdProvider : AbstractAdProvider
{
	public const string ID = "flurry"; //Field offset: 0x0
	private bool _addedListeners; //Field offset: 0x29

	public override List<AdType> adTypesWithClickCallbackSupport
	{
		 get { } //Length: 3
	}

	public override string id
	{
		 get { } //Length: 127
	}

	public override bool supportsMulticaching
	{
		 get { } //Length: 43
	}

	public FlurryAdProvider() { }

	private void <OnInitialize>b__9_0(string key) { }

	private void <OnInitialize>b__9_1(string key) { }

	private void <OnInitialize>b__9_2(string key) { }

	private void <OnInitialize>b__9_3(string key) { }

	private void <OnInitialize>b__9_4(string key) { }

	private void <OnInitialize>b__9_5(string key) { }

	private void <OnInitialize>b__9_6(string key) { }

	protected override void CacheVideo(string adLocationID, string cacheID) { }

	protected override void CheckPlatformSupport(AdProviderConfiguration configuration) { }

	public override List<AdType> get_adTypesWithClickCallbackSupport() { }

	public override string get_id() { }

	public override bool get_supportsMulticaching() { }

	protected override bool HasCachedVideo(string cacheID) { }

	protected override void OnInitialize(AdProviderConfiguration configuration) { }

	protected override void ShowVideo(string adLocationID, string cacheID) { }

}

