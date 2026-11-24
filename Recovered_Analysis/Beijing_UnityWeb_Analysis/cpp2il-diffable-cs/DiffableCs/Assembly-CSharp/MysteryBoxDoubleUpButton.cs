//Type is in global namespace

public class MysteryBoxDoubleUpButton : MonoBehaviour
{
	private sealed class <AnimateAlpha>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIWidget widget; //Field offset: 0x10
		public float from; //Field offset: 0x14
		public float duration; //Field offset: 0x18
		public float to; //Field offset: 0x1C
		private float <factor>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 283
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateAlpha>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateButton>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MysteryBoxDoubleUpButton <>4__this; //Field offset: 0x10
		private float <bounceDuration>5__2; //Field offset: 0x14
		private float <p>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 508
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateButton>d__22(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const string ONLINESETTINGS_MYSTERY_BOX_DOUBLE_REWARD_CHANCE_KEY = "mystery_box_double_reward_chance"; //Field offset: 0x0
	private const int DEFAULT_MYSTERY_BOX_DOUBLE_REWARD_CHANCE = 100; //Field offset: 0x0
	private const string ONLINESETTINGS_MYSTERY_BOX_DOUBLE_REWARD_ALLOW_KEYS_KEY = "mystery_box_double_reward_allow_keys"; //Field offset: 0x0
	private const bool DEFAULT_MYSTERY_BOX_DOUBLE_REWARD_ALLOW_KEYS = False; //Field offset: 0x0
	private GameObject _doubleButton; //Field offset: 0xC
	private UILabel _buttonLabel; //Field offset: 0x10
	private GameObject _stickerGameObject; //Field offset: 0x14
	private Animation _stickerAnimation; //Field offset: 0x18
	private CelebrationReward _rewardToDouble; //Field offset: 0x1C
	private bool _wasRewardDoubled; //Field offset: 0x20
	private bool _isButtonEnabled; //Field offset: 0x21
	private Dictionary<CelebrationRewardType, Action> _doubleRewardCallbacks; //Field offset: 0x24
	private Coroutine _animateButtonCoroutine; //Field offset: 0x28
	private Coroutine _animateAlphaCoroutine; //Field offset: 0x2C
	private bool _hasSetDefaultButtonColorOnce; //Field offset: 0x30

	private int chance
	{
		 get { } //Length: 104
	}

	public MysteryBoxDoubleUpButton() { }

	private IEnumerator AnimateAlpha(UIWidget widget, float duration, float from, float to) { }

	private IEnumerator AnimateButton() { }

	private bool ChanceRoll() { }

	public void DisableButton() { }

	public void FlurryLogDoubleUpResultAs(bool doubledUp) { }

	private int get_chance() { }

	public string GroupCoinsForFlurryLogging(int originalCoinAmount) { }

	private bool IsDoublable(CelebrationReward reward) { }

	private bool IsValidOrigin(CelebrationReward reward) { }

	private bool IsVideoAvailable() { }

	private void Log(string msg, Object context = null) { }

	private void LogAttemptToShowButton(bool isValidOrigin, bool isDoublable, bool chanceRoll) { }

	public void OnClick() { }

	private void OnDoubleReward() { }

	private void OnEnable() { }

	private void ResetAnimationState() { }

	private void SetDefaultButtonColorOnce() { }

	public bool TryEnable(CelebrationReward rewardToDouble, Dictionary<CelebrationRewardType, Action> doubleRewardCallbacks) { }

}

