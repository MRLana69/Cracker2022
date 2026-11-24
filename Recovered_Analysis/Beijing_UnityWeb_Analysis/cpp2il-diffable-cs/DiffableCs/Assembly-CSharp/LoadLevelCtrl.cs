//Type is in global namespace

public class LoadLevelCtrl : MonoBehaviour
{
	private sealed class <Progress>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LoadLevelCtrl <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 574
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Progress>d__27(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Start>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LoadLevelCtrl <>4__this; //Field offset: 0x10
		private IEnumerator <cacheCoroutine>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 567
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Start>d__26(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static bool <StartupFinished>k__BackingField; //Field offset: 0x0
	private const int DEFAULT_TITLE_POSTION_Y = 133; //Field offset: 0x0
	private const int PLAYERTIP_TITLE_POSTION_Y = 141; //Field offset: 0x0
	private const float CachingTimeBudget = 0.1; //Field offset: 0x0
	private AsyncOperation asyncMerge; //Field offset: 0xC
	private UILabel titleTipLabel; //Field offset: 0x10
	private UILabel tipLabel; //Field offset: 0x14
	private UILabel userNameLabel; //Field offset: 0x18
	private UILabel _loadingLabel; //Field offset: 0x1C
	private UISlider slider; //Field offset: 0x20
	private GameObject quad; //Field offset: 0x24
	private float sliderSteps; //Field offset: 0x28
	private bool sliderStepsIsSet; //Field offset: 0x2C
	private string[] standardTipArray; //Field offset: 0x30
	private float _markedProgress; //Field offset: 0x34
	private float _currentProgress; //Field offset: 0x38
	private float _loadSteps; //Field offset: 0x3C

	public static bool StartupFinished
	{
		 get { } //Length: 189
		private set { } //Length: 19
	}

	public LoadLevelCtrl() { }

	private void Awake() { }

	public static bool get_StartupFinished() { }

	private float GetProgress() { }

	private string GetRandomTipId() { }

	public float LoadBar() { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

	private void MarkProgress() { }

	private void PoolManager_onProgress(float balancingProgress) { }

	private IEnumerator Progress() { }

	private static void set_StartupFinished(bool value) { }

	private void SetCurrentProgress(float progress, float maxDeltaProgress = 1) { }

	private void SetDefaultTip() { }

	private void SetLabels() { }

	private void SetUserTip(string loadScreenTitle, UserTip[] userTips) { }

	private IEnumerator Start() { }

	private void UnloadAssets() { }

	private void Update() { }

}

