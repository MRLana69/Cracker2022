namespace UI.Pages;

public class PageTop : MonoBehaviour
{
	private sealed class <>c__DisplayClass32_0
	{
		public PageTop <>4__this; //Field offset: 0x8
		public TopIconPayload payload; //Field offset: 0xC

		public <>c__DisplayClass32_0() { }

		internal void <MakeIcon>b__0() { }

	}

	private sealed class <>c__DisplayClass34_0
	{
		public PageTop <>4__this; //Field offset: 0x8
		public string newText; //Field offset: 0xC

		public <>c__DisplayClass34_0() { }

		internal void <UpdateMultiplierText>b__0() { }

		internal void <UpdateMultiplierText>b__1() { }

		internal void <UpdateMultiplierText>b__2() { }

		internal void <UpdateMultiplierText>b__3() { }

	}

	private sealed class <AnimateIconScale>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PageTop <>4__this; //Field offset: 0x10
		private float <currentDuration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 419
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateIconScale>d__40(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateShadowAlpha>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PageTop <>4__this; //Field offset: 0x10
		private float <currentDuration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 196
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateShadowAlpha>d__41(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateShadowExpansion>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PageTop <>4__this; //Field offset: 0x10
		private float <currentDuration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 522
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateShadowExpansion>d__42(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayCoroutine>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public Action action; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 147
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayCoroutine>d__37(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <FadeOutBlinkImage>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PageTop <>4__this; //Field offset: 0x10
		private float <currentDuration>5__2; //Field offset: 0x14
		private float <startAlpha>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 322
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FadeOutBlinkImage>d__39(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class EventsPageTopPayload
	{
		public string mainTitle; //Field offset: 0x8
		public string subTitle; //Field offset: 0xC
		public string multiplierText; //Field offset: 0x10
		public Color mainColor; //Field offset: 0x14
		public Color subTitleColor; //Field offset: 0x24
		public Color splatColor; //Field offset: 0x34
		public Color splatShadowColor; //Field offset: 0x44
		public TopSplatType topSplatType; //Field offset: 0x54

		public EventsPageTopPayload() { }

	}

	public class TopIconPayload
	{
		public GameObject iconPrefab; //Field offset: 0x8
		public Vector3 localPositionOffset; //Field offset: 0xC
		public Vector3 localRotationOffsetEuler; //Field offset: 0x18
		public Vector3 localScaleOffset; //Field offset: 0x24

		public TopIconPayload() { }

	}

	public enum TopSplatType
	{
		Bubble = 0,
		Star = 1,
	}

	private UILabel _mainTitle; //Field offset: 0xC
	private UILabel _subtitle; //Field offset: 0x10
	private UIWidget _slotForItemLoad; //Field offset: 0x14
	private UISprite _bubbleSplat; //Field offset: 0x18
	private UISprite _bubbleSplatShadow; //Field offset: 0x1C
	private UISprite _starSplat; //Field offset: 0x20
	private UISprite _starSplatShadow; //Field offset: 0x24
	private UILabel _multiplierText; //Field offset: 0x28
	private UILabel _shadowAnimText; //Field offset: 0x2C
	private UIWidget _iconGuideWidget; //Field offset: 0x30
	private Transform _iconAnchor; //Field offset: 0x34
	private AnimationCurve _iconScaleEffectCurve; //Field offset: 0x38
	private float _iconScaleEffectDuration; //Field offset: 0x3C
	private Vector3 _iconScaleEffectAmount; //Field offset: 0x40
	private float _iconScaleEffectDelay; //Field offset: 0x4C
	private AnimationCurve _shadowAlphaEffectCurve; //Field offset: 0x50
	private float _shadowAlphaEffectDuration; //Field offset: 0x54
	private float _shadowAlphaEffectAmount; //Field offset: 0x58
	private float _shadowAlphaEffectDelay; //Field offset: 0x5C
	private AnimationCurve _shadowExpansionEffectCurve; //Field offset: 0x60
	private float _shadowExpansionEffectDuration; //Field offset: 0x64
	private Vector3 _shadowExpansionEffectAmount; //Field offset: 0x68
	private float _shadowExpansionEffectDelay; //Field offset: 0x74
	private ParticleSystem _starBurstVFX; //Field offset: 0x78
	private float _blinkEffectDuration; //Field offset: 0x7C
	private Transform _icon; //Field offset: 0x80
	private UILabel _blinkImage; //Field offset: 0x84

	public PageTop() { }

	private void <PlayMultiplierAnimations>b__35_0() { }

	private void <PlayMultiplierAnimations>b__35_1() { }

	private void <PlayMultiplierAnimations>b__35_2() { }

	private void <PlayMultiplierAnimations>b__35_3() { }

	private void AdjustIcon(Vector3 localPositionOffset, Vector3 localRotationOffsetEuler, Vector3 localScaleOffset) { }

	private IEnumerator AnimateIconScale() { }

	private IEnumerator AnimateShadowAlpha() { }

	private IEnumerator AnimateShadowExpansion() { }

	private void Delay(float delay, Action action) { }

	private IEnumerator DelayCoroutine(float delay, Action action) { }

	private IEnumerator FadeOutBlinkImage() { }

	public float GetMultiplierAnimationDuration() { }

	public void MakeIcon(TopIconPayload payload) { }

	public GameObject MakeSlotItem(Func<UIWidget, GameObject> maker) { }

	public void PlayMultiplierAnimations() { }

	private void ResetAnimations() { }

	public void Setup(EventsPageTopPayload payload) { }

	public void UpdateMultiplierText(string newText, bool useEffect = false) { }

}

