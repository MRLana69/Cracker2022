//Type is in global namespace

public class TopRunPlayerCell : MonoBehaviour
{
	private sealed class <AnimateEffectColor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TopRunPlayerCell <>4__this; //Field offset: 0x10
		public float speedFactor; //Field offset: 0x14
		public UISprite spriteToAnimate; //Field offset: 0x18
		public Color color1; //Field offset: 0x1C
		public Color color2; //Field offset: 0x2C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 312
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateEffectColor>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateMedalSprite>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISprite glowSprite; //Field offset: 0x10
		public UISprite medalSprite; //Field offset: 0x14
		public TopRunPlayerCell <>4__this; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 829
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateMedalSprite>d__27(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float MEDAL_ANIMATION_TIME_OFFSET = 0.5; //Field offset: 0x0
	private const int SCORE_SPACING = 10; //Field offset: 0x0
	private static readonly Color32 EFFECT_INITIAL_COLOR; //Field offset: 0x0
	private UITexture _picture; //Field offset: 0xC
	private UILabel _name; //Field offset: 0x10
	private UISprite _medal; //Field offset: 0x14
	private UISprite _glow; //Field offset: 0x18
	private UISprite _flag; //Field offset: 0x1C
	private UISprite _shadow; //Field offset: 0x20
	private UILabel _score; //Field offset: 0x24
	private UISprite _background; //Field offset: 0x28
	private UISprite _competitorIcon; //Field offset: 0x2C
	private AudioClip _medalAnimationSound; //Field offset: 0x30
	public Texture dummyImage; //Field offset: 0x34
	private bool isLocalUser; //Field offset: 0x38
	private IPlayer player; //Field offset: 0x3C
	private bool useDarkColour; //Field offset: 0x40
	private int rank; //Field offset: 0x44
	private float soundVolume; //Field offset: 0x48
	private float soundPitch; //Field offset: 0x4C
	private float _animationLerpFactor; //Field offset: 0x50

	private static TopRunPlayerCell() { }

	public TopRunPlayerCell() { }

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1) { }

	public void AnimateMedalIfNeeded() { }

	private IEnumerator AnimateMedalSprite(UISprite glowSprite, UISprite medalSprite, bool isThisWeeksResult) { }

	private bool HasShownMedalForWeek(int weekNumber) { }

	public void InitCell(IPlayer playerT, bool useDarkColourT, int rankT, bool isLocalUserT) { }

	public bool IsLocalUser() { }

	public void Refresh() { }

	private void ResizeNameIfNeeded() { }

	private void SetBackgroundColour(bool useDark, int rank) { }

	private void SetMedalForRank(int rank, string countryID) { }

}

