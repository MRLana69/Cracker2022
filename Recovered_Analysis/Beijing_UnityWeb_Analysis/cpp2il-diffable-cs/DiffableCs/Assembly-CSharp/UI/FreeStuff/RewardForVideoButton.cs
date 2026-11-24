namespace UI.FreeStuff;

public class RewardForVideoButton : MonoBehaviour
{
	private sealed class <CheckCacheState>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RewardForVideoButton <>4__this; //Field offset: 0x10
		private float <delay>5__2; //Field offset: 0x14
		private int <i>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 375
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CheckCacheState>d__38(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum VideoState
	{
		Ready = 0,
		Loading = 1,
		NoFill = 2,
	}

	private const string FLURRY_PARAMETER_VALUE_FORMAT = "{0};{1}"; //Field offset: 0x0
	private const float CHECK_CACHE_STATE_TIMEOUT = 10; //Field offset: 0x0
	private const int CHECK_CACHE_STATE_COUNT = 3; //Field offset: 0x0
	private UISprite _firstFill; //Field offset: 0xC
	private UISprite _firstFillHighlight; //Field offset: 0x10
	private UISprite _secondFill; //Field offset: 0x14
	private UISprite _secondFillHighlight; //Field offset: 0x18
	private UISprite _rewardIcon; //Field offset: 0x1C
	private UISprite _rewardIconBackground; //Field offset: 0x20
	private UILabel _title; //Field offset: 0x24
	private UILabel _description; //Field offset: 0x28
	private UILabel _loadingLabel; //Field offset: 0x2C
	private UILabel _noVideosLabel; //Field offset: 0x30
	private UILabel _noVideosTryAgainLabel; //Field offset: 0x34
	private GameObject _activeState; //Field offset: 0x38
	private GameObject _loadingState; //Field offset: 0x3C
	private GameObject _noFillState; //Field offset: 0x40
	private VideoButtonPayload _payload; //Field offset: 0x44
	private VideoState _state; //Field offset: 0x48
	private bool _subscribed; //Field offset: 0x4C
	private int _cachedRewardAmount; //Field offset: 0x50
	private ButtonPressedColorChange[] _colorPressedManager; //Field offset: 0x54
	private IEnumerator _cacheCoroutine; //Field offset: 0x58

	public int cachedRewardAmount
	{
		 get { } //Length: 66
	}

	public RewardForVideoButton() { }

	private IEnumerator CheckCacheState() { }

	public int get_cachedRewardAmount() { }

	public void Init(VideoButtonPayload payload) { }

	private void LogButtonClickedToFlurry() { }

	private void LogButtonHasNoFill() { }

	private void LogButtonShownToFlurry() { }

	private void LogToFlurryWithParameter(string parameter) { }

	private void OnCachedVideo(string adLocationId, bool wasAlreadyCached) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnDismissedVideo(string adLocationId) { }

	private void OnEnable() { }

	private void OnFailedToCacheVideo(string adLocationId) { }

	private void OnVideoWatched(bool withreward) { }

	private void RefreshState() { }

	private void SetState(VideoState state) { }

	private void SetupBasic() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

