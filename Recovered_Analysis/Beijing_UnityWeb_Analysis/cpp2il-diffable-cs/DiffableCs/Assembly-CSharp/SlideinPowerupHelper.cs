//Type is in global namespace

public class SlideinPowerupHelper : MonoBehaviour
{
	private sealed class <AnimateButtonBackground>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SlideinPowerupHelper <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 548
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateButtonBackground>d__69(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateButtonBackgrounGlow>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SlideinPowerupHelper <>4__this; //Field offset: 0x10
		public UISprite sprite; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 476
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateButtonBackgrounGlow>d__72(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateSpriteColor>d__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float speedFactor; //Field offset: 0x10
		public UISprite spriteToAnimate; //Field offset: 0x14
		public Color32 startValue; //Field offset: 0x18
		public Color32 endValue; //Field offset: 0x1C
		private float <animationLerpFactor>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 364
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateSpriteColor>d__73(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayResumeButtonsGlow>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SlideinPowerupHelper <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 135
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayResumeButtonsGlow>d__58(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum SlideinPowerup
	{
		_notset = 0,
		powerup1 = 1,
		powerup2 = 2,
	}

	private const bool HIDE_ON_ZERO_PURCHASE = True; //Field offset: 0x0
	private const int MAX_AMOUNT_OF_HEADSTART_GEARS = 3; //Field offset: 0x0
	private const int MAX_AMOUNT_OF_SCOREBOOSTER_GEARS = 3; //Field offset: 0x0
	private const float DELAY_ANIMATION_AMOUNT_ON_PRESS_POWERUP_BUTTON = 1.5; //Field offset: 0x0
	private const float PAUSE_BETWEEN_ANIMATIONs = 1.4; //Field offset: 0x0
	private const float LONG_TIME_BETWEEN_ANIMATION = 0.5; //Field offset: 0x0
	private const float SHORT_TIME_BETWEEN_ANIMATION = 0.1; //Field offset: 0x0
	private const float ANIMATE_GLOW_SPEED = 5; //Field offset: 0x0
	private const float _DELAY_AMOUNT_FOR_HIDING_THE_POWERUP_BUTTONS = 5; //Field offset: 0x0
	private static SlideinPowerupHelper instance; //Field offset: 0x0
	private static Action<int> OnHeadstartActivated; //Field offset: 0x4
	private static Action<int> OnScoreBoostActivated; //Field offset: 0x8
	private static Action OnButtonsShow; //Field offset: 0xC
	private static Action OnButtonsHide; //Field offset: 0x10
	private SlideinPowerupButton powerup1Button; //Field offset: 0xC
	private SlideinPowerupButton powerup2Button; //Field offset: 0x10
	private UILabel powerup1AmountLabel; //Field offset: 0x14
	private UILabel powerup2AmountLabel; //Field offset: 0x18
	private UISprite _powerup1ButtonGlow; //Field offset: 0x1C
	private UISprite _powerup2ButtonGlow; //Field offset: 0x20
	private SpringPosition powerup1Spring; //Field offset: 0x24
	private SpringPosition powerup2Spring; //Field offset: 0x28
	private Vector3 powerup1PositionOff; //Field offset: 0x2C
	private Vector3 powerup2PositionOff; //Field offset: 0x38
	private Vector3 powerup1PositionOn; //Field offset: 0x44
	private Vector3 powerup2PositionOn; //Field offset: 0x50
	private bool _hasInited; //Field offset: 0x5C
	private bool _initialButtonGlowHasStarted; //Field offset: 0x5D
	private int _currentHeadstartGear; //Field offset: 0x60
	private int _currentScoreboosterGear; //Field offset: 0x64

	public static event Action OnButtonsHide
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnButtonsShow
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<int> OnHeadstartActivated
	{
		 add { } //Length: 16
		 remove { } //Length: 209
	}

	public static event Action<int> OnScoreBoostActivated
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public float DELAY_AMOUNT_FOR_HIDING_THE_POWERUP_BUTTONS
	{
		 get { } //Length: 6
	}

	public static SlideinPowerupHelper Instance
	{
		 get { } //Length: 87
	}

	private static SlideinPowerupHelper() { }

	public SlideinPowerupHelper() { }

	public static void add_OnButtonsHide(Action value) { }

	public static void add_OnButtonsShow(Action value) { }

	public static void add_OnHeadstartActivated(Action<int> value) { }

	public static void add_OnScoreBoostActivated(Action<int> value) { }

	private IEnumerator AnimateButtonBackground() { }

	private IEnumerator AnimateButtonBackgrounGlow(UISprite sprite) { }

	private IEnumerator AnimateSpriteColor(UISprite spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor) { }

	private IEnumerator DelayResumeButtonsGlow() { }

	private void FireHideEventIfNecessary() { }

	public float get_DELAY_AMOUNT_FOR_HIDING_THE_POWERUP_BUTTONS() { }

	public static SlideinPowerupHelper get_Instance() { }

	public bool HeadstartButtonIsActive() { }

	private void HideHeadstart() { }

	public void HidePowerup1(bool instant = false) { }

	public void HidePowerup2(bool instant = false) { }

	private void HidePowerups() { }

	private void HideScorebooster() { }

	private void InitHelper() { }

	private void LogPowerupActivated(int powerup, bool success) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGameRevived() { }

	private void OnGameReviveOffer() { }

	private void OnJetpackStart() { }

	private void OnMenuScreenShown() { }

	private void OnPauseChange(bool pause) { }

	private void OnPogostickStart() { }

	private void OnPowerup1ButtonAnimatedOut() { }

	private void OnPowerup2ButtonAnimatedOut() { }

	private void OnPowerupButtonAnimatedIn() { }

	private void OnSellConsumableCompleted(UpgradeType upgradeType, int amountSold) { }

	private void OnUpgradeUsed(UpgradeType upgradeType, int newAmount) { }

	public static void remove_OnButtonsHide(Action value) { }

	public static void remove_OnButtonsShow(Action value) { }

	public static void remove_OnHeadstartActivated(Action<int> value) { }

	public static void remove_OnScoreBoostActivated(Action<int> value) { }

	private void ResetButtonGlowInvokes() { }

	private void ResetHeadstartButtonGlowColor() { }

	private void ResetHeadstartGear() { }

	private void ResetScoreboosterButtonGlowColor() { }

	private void ResetScoreboosterGear() { }

	private void ResumeButtonsGlowColor() { }

	public bool ScoreboosterButtonIsActive() { }

	private void ScreenDidChange(string screenOrPopupName) { }

	public void ShowPowerup1() { }

	public void ShowPowerup2() { }

	public void ShowPowerups() { }

	public void SlideinPowerupClicked(int powerupAsInt) { }

	private void Start() { }

	private void UpdateAmountLabel(UILabel label, int amount) { }

}

