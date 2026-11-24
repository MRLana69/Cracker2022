namespace UI.Pages.MissionsPageInternal;

public class MissionSetProgress : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UISprite, bool> <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <BounceNextProgressDot>b__9_0(UISprite s) { }

	}

	private sealed class <BounceObject>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISprite spriteToBounce; //Field offset: 0x10
		public MissionSetProgress <>4__this; //Field offset: 0x14
		public float duration; //Field offset: 0x18
		public Action callWhenFinished; //Field offset: 0x1C
		private UISprite <blinkSprite>5__2; //Field offset: 0x20
		private float <currentDuration>5__3; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 833
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <BounceObject>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const string INACTIVE_DOT = "mission_progress_dot"; //Field offset: 0x0
	private const string ACTIVE_DOT = "mission_progress_dot_completed"; //Field offset: 0x0
	private List<UISprite> _fillSprites; //Field offset: 0xC
	private AnimationCurve _progressCellScaleEffect; //Field offset: 0x10
	private float _bounceEffectDuration; //Field offset: 0x14
	private GameObject _mysteryBoxIcon; //Field offset: 0x18
	private GameObject _starIcon; //Field offset: 0x1C
	private List<GameObject> _cachedBlinks; //Field offset: 0x20

	public MissionSetProgress() { }

	private void <TestMysteryBoxBounce>b__18_0() { }

	public void BounceNextProgressDot(Action callback = null) { }

	private IEnumerator BounceObject(UISprite spriteToBounce, float duration, Action callWhenFinished = null) { }

	public void BounceReward() { }

	public void ChangeToMysteryBoxReward(bool animate = false) { }

	public float GetBounceDuration() { }

	public void SetMissionSetProgress(int progress) { }

	private void TestBounce(UISprite sprite) { }

	private void TestBounce1() { }

	private void TestBounce2() { }

	private void TestBounce3() { }

	private void TestMysteryBoxBounce() { }

}

