//Type is in global namespace

public class SlideinPowerupButton : UIButtonSender
{
	private sealed class <AnimateSpriteColor>d__16 : IEnumerator<object>, IEnumerator, IDisposable
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

		public <AnimateSpriteColor>d__16(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum SlideInButtonType
	{
		scorebooster = 0,
		headstart = 1,
	}

	private const float FADE_OUT_ANIMATION_SPEED_FACTOR = 2; //Field offset: 0x0
	private SlideinPowerupHelper _helper; //Field offset: 0x10
	private int _powerupNumber; //Field offset: 0x14
	private GameObject _headstartModel; //Field offset: 0x18
	private UISprite _background; //Field offset: 0x1C
	private int _counter; //Field offset: 0x20
	private SlideInButtonType buttonType; //Field offset: 0x24

	public SlideinPowerupButton() { }

	private IEnumerator AnimateSpriteColor(UISprite spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor) { }

	public void InitSlideinButton(SlideinPowerupHelper helper, int powerupNumber) { }

	private void OnDisable() { }

	public void OnPressButton() { }

	public void OnReleaseButton() { }

	public void ResetPowerupButtonColorToInitial() { }

	protected override void Send(bool isPressed) { }

	protected override void Send() { }

	private void SetPowerup1Color(bool animateIn) { }

	private void SetPowerup2Color(bool animateIn) { }

}

