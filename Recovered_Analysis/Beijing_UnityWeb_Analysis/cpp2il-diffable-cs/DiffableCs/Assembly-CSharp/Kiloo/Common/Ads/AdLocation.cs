namespace Kiloo.Common.Ads;

public class AdLocation : AdEventListenerAdapter
{
	private sealed class <CacheCoroutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AdLocation <>4__this; //Field offset: 0x10
		private float <startTime>5__2; //Field offset: 0x14
		private float <elapsedTime>5__3; //Field offset: 0x18
		private double <cacheTimeoutLimit>5__4; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 888
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CacheCoroutine>d__23(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <WaitWhileConditionOrUntilTimedOut>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Func<bool> condition; //Field offset: 0x10
		public float timeoutInSeconds; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18
		private float <elapsedTime>5__3; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 179
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitWhileConditionOrUntilTimedOut>d__21(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <WaitWhileUnavailableThenCache>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AdLocation <>4__this; //Field offset: 0x10
		private Func<bool> <isInitializingFunc>5__2; //Field offset: 0x14
		private Func<bool> <isCachingFunc>5__3; //Field offset: 0x18
		private int <waitTimeout>5__4; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 687
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitWhileUnavailableThenCache>d__22(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float CHECK_TIMEOUT_INTERVAL = 0.5; //Field offset: 0x0
	private const float INITIALIZE_WAIT_TIME_SECONDS = 5; //Field offset: 0x0
	private AbstractAdProvider _adProvider; //Field offset: 0x8
	private IAdSettingsProvider _settingsProvider; //Field offset: 0xC
	private DateTime _timeOfLastShow; //Field offset: 0x10
	private IEnumerator _cacheCoroutine; //Field offset: 0x18
	private bool _shouldRestartIsCachingCheck; //Field offset: 0x1C
	private IEnumerator _unavailableCoroutine; //Field offset: 0x20
	public readonly AdLocationInfo info; //Field offset: 0x24
	public readonly string waterfallID; //Field offset: 0x28

	private bool hasProvider
	{
		 get { } //Length: 54
	}

	public bool isCaching
	{
		 get { } //Length: 9
	}

	public AdLocation(AdLocationInfo info, string waterfallID) { }

	private bool <WaitWhileUnavailableThenCache>b__22_0() { }

	private bool <WaitWhileUnavailableThenCache>b__22_1() { }

	public void Cache() { }

	private IEnumerator CacheCoroutine() { }

	public override void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID) { }

	public override void DismissedAd(AdType adType, string providerID, string adLocationID) { }

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	public override void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

	public override void FinishedWatchingVideo(string providerID, string adLocationID) { }

	private bool get_hasProvider() { }

	public bool get_isCaching() { }

	private string GetCacheId() { }

	public bool IsCached() { }

	private void MakeSureAdIsCached(string providerID, string adLocationId) { }

	public void SetAdProvider(AbstractAdProvider adProvider) { }

	public void SetSettingsProvider(IAdSettingsProvider settingsProvider) { }

	public bool Show() { }

	public override void ShowedAd(AdType adType, string providerID, string adLocationID) { }

	public override void StartedCachingAd(AdType adType, string providerID, string adLocationID) { }

	private IEnumerator WaitWhileConditionOrUntilTimedOut(Func<bool> condition, float timeoutInSeconds) { }

	private IEnumerator WaitWhileUnavailableThenCache() { }

}

