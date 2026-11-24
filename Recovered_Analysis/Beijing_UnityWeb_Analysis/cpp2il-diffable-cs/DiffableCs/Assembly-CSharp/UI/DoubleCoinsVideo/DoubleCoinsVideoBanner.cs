namespace UI.DoubleCoinsVideo;

public class DoubleCoinsVideoBanner : DoubleCoinsVideo
{
	private sealed class <ActivateStars>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DoubleCoinsVideoBanner <>4__this; //Field offset: 0x10
		private Enumerator<GameObject> <>7__wrap1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1893
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ActivateStars>d__14(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UISprite _innerBanner; //Field offset: 0x14
	private UISprite _bannerEdge; //Field offset: 0x18
	private UILabel _title; //Field offset: 0x1C
	private UILabel _buttonLabel; //Field offset: 0x20
	private float _starAnimationPause; //Field offset: 0x24
	private float _starCountDown; //Field offset: 0x28
	private List<GameObject> _startSpawnPoints; //Field offset: 0x2C
	private GameObject _starPrefab; //Field offset: 0x30
	private List<GameObject> _stars; //Field offset: 0x34

	public DoubleCoinsVideoBanner() { }

	private IEnumerator ActivateStars() { }

	public void ButtonClicked() { }

	public override int GetHeight() { }

	private void OnDisable() { }

	public override void SetCoinVisualValue(int coinValue) { }

	public override void Setup(DoubleCoinsVideoPayload payload) { }

	private void SetupBasic() { }

}

