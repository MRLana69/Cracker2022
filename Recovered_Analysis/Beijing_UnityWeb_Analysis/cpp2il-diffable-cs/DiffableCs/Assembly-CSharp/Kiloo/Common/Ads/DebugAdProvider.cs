namespace Kiloo.Common.Ads;

public class DebugAdProvider : AbstractAdProvider
{
	private sealed class <CacheInterstitialCoroutine>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DebugAdProvider <>4__this; //Field offset: 0x10
		public string adLocationID; //Field offset: 0x14
		public string cacheID; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 481
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CacheInterstitialCoroutine>d__34(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CacheVideoCoroutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DebugAdProvider <>4__this; //Field offset: 0x10
		public string adLocationID; //Field offset: 0x14
		public string cacheID; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 536
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CacheVideoCoroutine>d__35(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const int DEVICE_CLOSE_BUTTON_SIZE = 150; //Field offset: 0x0
	private const int DEVICE_TEXT_FONT_SIZE = 60; //Field offset: 0x0
	private const float SIMULATED_FAIL_CHANCE = 0.15; //Field offset: 0x0
	private const float SIMULATED_CACHE_TIME = 1; //Field offset: 0x0
	public static bool forceNextCacheToFail; //Field offset: 0x0
	public static bool forceCacheToFail; //Field offset: 0x1
	private readonly string _id; //Field offset: 0x2C
	private readonly bool _supportsMulticaching; //Field offset: 0x30
	private DebugAdGUI _adGUI; //Field offset: 0x34
	private List<string> _cachedVideos; //Field offset: 0x38
	private List<string> _cachedInterstitials; //Field offset: 0x3C
	private MonoBehaviour _interstitialRunner; //Field offset: 0x40
	private bool _isCachingInterstitial; //Field offset: 0x44
	private bool _isCachingVideo; //Field offset: 0x45
	private MonoBehaviour _videoRunner; //Field offset: 0x48

	private bool errorHappened
	{
		 get { } //Length: 211
	}

	public override string id
	{
		 get { } //Length: 127
	}

	private static bool simulateErrors
	{
		 get { } //Length: 59
	}

	public override bool supportsMulticaching
	{
		 get { } //Length: 6
	}

	private static DebugAdProvider() { }

	public DebugAdProvider(string id, bool supportsMulticahing) { }

	private void <OnInitialize>b__30_0() { }

	private void <OnInitialize>b__30_1(AdType adType) { }

	protected override void CacheInterstitial(string adLocationID, string cacheID) { }

	private IEnumerator CacheInterstitialCoroutine(string adLocationID, string cacheID) { }

	protected override void CacheVideo(string adLocationID, string cacheID) { }

	private IEnumerator CacheVideoCoroutine(string adLocationID, string cacheID) { }

	protected override void CheckPlatformSupport(AdProviderConfiguration configuration) { }

	private bool get_errorHappened() { }

	public override string get_id() { }

	private static bool get_simulateErrors() { }

	public override bool get_supportsMulticaching() { }

	protected override bool HasCachedInterstitial(string cacheID) { }

	protected override bool HasCachedVideo(string cacheID) { }

	protected override void OnCacheTimeout(AdType adType, string adLocationID) { }

	protected override void OnInitialize(AdProviderConfiguration configuration) { }

	protected override void ShowInterstitial(string adLocationID, string cacheID) { }

	protected override void ShowVideo(string adLocationID, string cacheID) { }

	private void UpdateAdGuiProperties() { }

}

