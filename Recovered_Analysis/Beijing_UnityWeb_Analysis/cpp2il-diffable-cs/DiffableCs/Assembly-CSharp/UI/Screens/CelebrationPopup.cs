namespace UI.Screens;

public class CelebrationPopup : UIScreen
{
	private sealed class <_ShowReward>d__173 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public int currentRewardIndex; //Field offset: 0x14
		private <>c__DisplayClass173_0 <>8__1; //Field offset: 0x18
		private GameObject <rewardGo>5__2; //Field offset: 0x1C
		private GameObject <labelGo>5__3; //Field offset: 0x20
		private CelebrationPopupLabelTemplate <template>5__4; //Field offset: 0x24
		private Animation <anim>5__5; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 10733
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <_ShowReward>d__173(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <>c__DisplayClass173_0
	{
		public CelebrationReward reward; //Field offset: 0x8

		public <>c__DisplayClass173_0() { }

		internal bool <_ShowReward>b__0(HoverboardTheme x) { }

		internal bool <_ShowReward>b__1(HoverboardTheme x) { }

	}

	private sealed class <>c__DisplayClass225_0
	{
		public TweenScale tweenScale; //Field offset: 0x8
		public CelebrationPopup <>4__this; //Field offset: 0xC

		public <>c__DisplayClass225_0() { }

		internal void <TweenScaleUpDown>b__0() { }

	}

	private sealed class <AnimateAlpha>d__181 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UILabel label; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public float toAlpha; //Field offset: 0x18
		private float <fromAlpha>5__2; //Field offset: 0x1C
		private float <factor>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 283
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateAlpha>d__181(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateAlpha>d__182 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopupLabelTemplate template; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public float toAlpha; //Field offset: 0x18
		private float <fromAlpha>5__2; //Field offset: 0x1C
		private float <factor>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 283
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateAlpha>d__182(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateColor>d__183 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIWidget widget; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Color toColor; //Field offset: 0x18
		private Color <fromColor>5__2; //Field offset: 0x28
		private float <factor>5__3; //Field offset: 0x38

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 497
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateColor>d__183(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateColor>d__184 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Material material; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Color toColor; //Field offset: 0x18
		private Color <fromColor>5__2; //Field offset: 0x28
		private float <factor>5__3; //Field offset: 0x38

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 497
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateColor>d__184(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateEffectColor>d__186 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public bool instant; //Field offset: 0x10
		public UISprite spriteToAnimate; //Field offset: 0x14
		public Color color2; //Field offset: 0x18
		public CelebrationPopup <>4__this; //Field offset: 0x28
		public float speedFactor; //Field offset: 0x2C
		public Color color1; //Field offset: 0x30

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 389
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateEffectColor>d__186(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateScreenFlash>d__169 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISprite effectSprite; //Field offset: 0x10
		public CelebrationPopup <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 471
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateScreenFlash>d__169(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateStripes>d__190 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		private int <minSpeed>5__2; //Field offset: 0x14
		private int <maxSpeed>5__3; //Field offset: 0x18
		private float <minAlpha>5__4; //Field offset: 0x1C
		private float <maxAlpha>5__5; //Field offset: 0x20
		private float <minScale>5__6; //Field offset: 0x24
		private float <maxScale>5__7; //Field offset: 0x28
		private Vector2 <minimumThreshold>5__8; //Field offset: 0x2C
		private Vector2 <maximumThreshold>5__9; //Field offset: 0x34
		private float[] <stripeSpeeds>5__10; //Field offset: 0x3C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 2893
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateStripes>d__190(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <BoxIdleAnimCoroutine>d__164 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationReward reward; //Field offset: 0x10
		public CelebrationPopup <>4__this; //Field offset: 0x14
		public Transform rewardTrans; //Field offset: 0x18
		private Vector3 <baseLocalPos>5__2; //Field offset: 0x1C
		private float <t>5__3; //Field offset: 0x28
		private Vector3 <newLocalPos>5__4; //Field offset: 0x2C
		private bool <doneResetting>5__5; //Field offset: 0x38

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 741
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <BoxIdleAnimCoroutine>d__164(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CountUpCoins>d__179 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public int toAmount; //Field offset: 0x14
		public int fromAmount; //Field offset: 0x18
		public float countTimeMultiplier; //Field offset: 0x1C
		public int coinboxAmount; //Field offset: 0x20
		public CelebrationPopupLabelTemplate rewardTemplate; //Field offset: 0x24
		public bool isMegaJackpot; //Field offset: 0x28
		public bool doubled; //Field offset: 0x29
		private float <countFactor>5__2; //Field offset: 0x2C
		private float <countTime>5__3; //Field offset: 0x30
		private int <coinboxFrom>5__4; //Field offset: 0x34
		private int <coinboxTo>5__5; //Field offset: 0x38
		private int <rewardLabelFrom>5__6; //Field offset: 0x3C
		private int <rewardLabelTo>5__7; //Field offset: 0x40

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 508
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CountUpCoins>d__179(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DoubleCoins_Routine>d__218 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public CelebrationReward reward; //Field offset: 0x14
		public CelebrationPopupLabelTemplate template; //Field offset: 0x18
		private int <coinboxCountFromAmount>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 414
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DoubleCoins_Routine>d__218(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DoubleKeys_Routine>d__220 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public CelebrationReward reward; //Field offset: 0x14
		public CelebrationPopupLabelTemplate template; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 290
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DoubleKeys_Routine>d__220(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DoublePowerups_Routine>d__224 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public CelebrationReward reward; //Field offset: 0x14
		public CelebrationPopupLabelTemplate template; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 290
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DoublePowerups_Routine>d__224(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DoubleTokens_Routine>d__222 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public CelebrationReward reward; //Field offset: 0x14
		public CelebrationPopupLabelTemplate template; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 314
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DoubleTokens_Routine>d__222(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Initial_Generic_DoubleUp_Routine>d__217 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public CelebrationPopupLabelTemplate template; //Field offset: 0x14
		public CelebrationReward reward; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1052
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Initial_Generic_DoubleUp_Routine>d__217(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <MoveGameObject>d__187 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Transform trans; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Vector3 toPos; //Field offset: 0x18
		private Vector3 <fromPos>5__2; //Field offset: 0x24
		private float <factor>5__3; //Field offset: 0x30

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 830
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MoveGameObject>d__187(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <MoveNextBoxToFront>d__177 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 751
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MoveNextBoxToFront>d__177(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PlaySoundDelayed>d__226 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public AudioClip clip; //Field offset: 0x14
		public float volume; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 177
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlaySoundDelayed>d__226(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RotateGameObject>d__178 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Transform trans; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Vector3 angleToRotate; //Field offset: 0x18
		private Quaternion <fromRotation>5__2; //Field offset: 0x24
		private float <factor>5__3; //Field offset: 0x34

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 674
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RotateGameObject>d__178(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ScaleGameObject>d__188 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Transform trans; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Vector3 toScale; //Field offset: 0x18
		private float <factor>5__2; //Field offset: 0x24
		private Vector3 <fromScale>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 668
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ScaleGameObject>d__188(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StartIdleAnimationFor>d__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Transform rewardTrans; //Field offset: 0x10
		public Vector3 baseLocalPos; //Field offset: 0x14
		private float <t>5__2; //Field offset: 0x20
		private Vector3 <newLocalPos>5__3; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 487
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartIdleAnimationFor>d__165(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TweenScaleUpDown>d__225 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CelebrationPopup <>4__this; //Field offset: 0x10
		public GameObject go; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 672
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TweenScaleUpDown>d__225(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float MOVE_IN_NEXT_CELEBRATION_DURATION = 0.35; //Field offset: 0x0
	private const float BOX_IDLE_ANIM_END_SPEED = 20; //Field offset: 0x0
	private const string STRIPE_COROUTINE_NAME = "AnimateStripes"; //Field offset: 0x0
	private const float DOUBLE_UP_REWARD_DELAY = 0.5; //Field offset: 0x0
	private const float DOUBLE_UP_SFX_VOLUME = 0.7; //Field offset: 0x0
	private const float BOX_IDLE_ANIM_AMOUNT = 10; //Field offset: 0x0
	private static readonly Vector3 FIRST_SLOT_POSITION; //Field offset: 0x0
	private const float BOX_IDLE_ANIM_SPEED = 2; //Field offset: 0x0
	private const float SHOW_PRIZE_BUTTON_POSITION = -46; //Field offset: 0x0
	private const float REMOVE_CELEBRATION_POPUP_AFTER_OPEN = 0.7; //Field offset: 0x0
	private static readonly Vector3 OTHER_SLOT_OFFSET; //Field offset: 0xC
	private static readonly Vector3 SUPERBOX_EFFECT_POSITION; //Field offset: 0x18
	private static Action<CelebrationReward> OnRewardDoubleUp; //Field offset: 0x24
	public GameObject boxParent; //Field offset: 0x28
	public GameObject rewardLabelTemplate; //Field offset: 0x2C
	private Vector3 _outOfScreenPosition; //Field offset: 0x30
	private GameObject _prizeButtonNormal; //Field offset: 0x3C
	private GameObject _prizeButtonSuper; //Field offset: 0x40
	private GameObject _prizeButtonMini; //Field offset: 0x44
	private UILabel _prizeButtonNormalLabel; //Field offset: 0x48
	private UILabel _prizeButtonSuperLabel; //Field offset: 0x4C
	private UILabel _prizeButtonMiniLabel; //Field offset: 0x50
	private Layout _prizeButtonNormalLayout; //Field offset: 0x54
	private Layout _prizeButtonSuperLayout; //Field offset: 0x58
	private Layout _prizeButtonMiniLayout; //Field offset: 0x5C
	private Collider openButtonCollider; //Field offset: 0x60
	private Collider skipButtonCollider; //Field offset: 0x64
	private Collider continueButtonCollider; //Field offset: 0x68
	private GameObject tapToStartLabelPrefab; //Field offset: 0x6C
	private GameObject _coinbox; //Field offset: 0x70
	private UILabel _coinboxLabel; //Field offset: 0x74
	public UILabel newTrophyLabel; //Field offset: 0x78
	private GameObject[] _slots; //Field offset: 0x7C
	private GameObject achievementBagPrefab; //Field offset: 0x80
	private GameObject mysteryEggPrefab; //Field offset: 0x84
	private GameObject mysteryBoxPrefab; //Field offset: 0x88
	private GameObject superMysteryBoxPrefab; //Field offset: 0x8C
	private GameObject miniMysteryBoxPrefab; //Field offset: 0x90
	private GameObject hiddenPrizePrefab_blue; //Field offset: 0x94
	private GameObject hiddenPrizePrefab_green; //Field offset: 0x98
	private GameObject hiddenPrizePrefab_red; //Field offset: 0x9C
	private GameObject superMysteryBoxEffectPrefab; //Field offset: 0xA0
	private GameObject roundGlowEffectPrefab; //Field offset: 0xA4
	public GameObject testRewardPrefab; //Field offset: 0xA8
	public GameObject rewardCoins; //Field offset: 0xAC
	public GameObject rewardCoinsJackpot; //Field offset: 0xB0
	private GameObject rewardTokenTricky; //Field offset: 0xB4
	private GameObject rewardTokenFresh; //Field offset: 0xB8
	private GameObject rewardTokenSpike; //Field offset: 0xBC
	private GameObject rewardTokenYutani; //Field offset: 0xC0
	private GameObject trophyDiamond; //Field offset: 0xC4
	private GameObject trophyGoldBar; //Field offset: 0xC8
	private GameObject trophyChainClock; //Field offset: 0xCC
	private GameObject trophyChainDollar; //Field offset: 0xD0
	private GameObject trophyGoldSkull; //Field offset: 0xD4
	private GameObject trophyHeadphones; //Field offset: 0xD8
	private GameObject trophyLPBlack; //Field offset: 0xDC
	private GameObject trophyTapeBlack; //Field offset: 0xE0
	private GameObject rewardPowerupHoverboard; //Field offset: 0xE4
	private GameObject rewardPowerupHeadstart500; //Field offset: 0xE8
	private GameObject rewardPowerupHeadstart2000; //Field offset: 0xEC
	private GameObject rewardPowerupScoreBooster; //Field offset: 0xF0
	private GameObject rewardSpecialBoard; //Field offset: 0xF4
	private GameObject rewardWelcomePackBoard; //Field offset: 0xF8
	private GameObject rewardKey; //Field offset: 0xFC
	private GameObject rewardBronzeCan; //Field offset: 0x100
	private GameObject rewardSilverCan; //Field offset: 0x104
	private GameObject rewardGoldCan; //Field offset: 0x108
	private GameObject rewardDiamondCan; //Field offset: 0x10C
	private GameObject[] rewardsTopRun; //Field offset: 0x110
	private GameObject _weeklyHuntTopTitle; //Field offset: 0x114
	private UILabel _weeklyHuntTopTitleLabel; //Field offset: 0x118
	private Layout _weeklyHuntTopLayout; //Field offset: 0x11C
	private GameObject fleshEffectPrefab; //Field offset: 0x120
	private GameObject preOpenLabel; //Field offset: 0x124
	private UILabel _bonusTextLabel; //Field offset: 0x128
	private GameObject _flashEffectGO; //Field offset: 0x12C
	private UISprite _flashEffectSprite; //Field offset: 0x130
	private UILabel _tapToStartLabel; //Field offset: 0x134
	public AudioStateLoop audioStateLoop; //Field offset: 0x138
	private int _currentReward; //Field offset: 0x13C
	public GameObject[] _celebrationRewardContainer; //Field offset: 0x140
	private bool _anotherReward; //Field offset: 0x144
	private Vector3 _boxScale; //Field offset: 0x148
	private Vector3 _boxRotation; //Field offset: 0x154
	private Vector3 _boxScaleAward; //Field offset: 0x160
	private Vector3 _boxRotationAward; //Field offset: 0x16C
	private Vector3 _boxPositionAward; //Field offset: 0x178
	private Vector3 _boxScaleTopRun; //Field offset: 0x184
	private Vector3 _miniboxScale; //Field offset: 0x190
	private Vector3 _boxRotationTopRun; //Field offset: 0x19C
	private Vector3 _boxPositionTopRun; //Field offset: 0x1A8
	private Vector3 _rewardStartRotation; //Field offset: 0x1B4
	private Vector3 _rewardStartScale; //Field offset: 0x1C0
	private Vector3 _rewardStartScaleCans; //Field offset: 0x1CC
	private Vector3 _rewardStartRotationJackpot; //Field offset: 0x1D8
	private Vector3 _rewardStartRotationCans; //Field offset: 0x1E4
	private Vector3 _rewardStartRotationTopRunRank; //Field offset: 0x1F0
	private Vector3 _rewardStartRotationTopRunMedal; //Field offset: 0x1FC
	private Vector3 _rewardStartPositionCans; //Field offset: 0x208
	private Vector3 _rewardStartScaleJackpot; //Field offset: 0x214
	private Vector3 _rewardEndScaleCoin; //Field offset: 0x220
	private Vector3 _rewardEndScaleCoiniPhoneX; //Field offset: 0x22C
	private Vector3 _rewardEndScaleCoinJackpot; //Field offset: 0x238
	private Vector3 _rewardEndPositionJackpot; //Field offset: 0x244
	private Vector3 _rewardEndScale; //Field offset: 0x250
	private Vector3 _rewardEndScaleToken; //Field offset: 0x25C
	private Vector3 _rewardEndScaleCan; //Field offset: 0x268
	private Vector3 _rewardEndScaleTopRunRank; //Field offset: 0x274
	private Vector3 _rewardEndPositionCan; //Field offset: 0x280
	private Vector3 _rewardEndPositionTopRunRank; //Field offset: 0x28C
	private Vector3 _rewardEndPositionTopRunMedal; //Field offset: 0x298
	private GameObject _rewardMain; //Field offset: 0x2A4
	private UILabel _labelSingle; //Field offset: 0x2A8
	private UILabel _labelDouble1; //Field offset: 0x2AC
	private Vector3 _labelPosition; //Field offset: 0x2B0
	private Vector3 _labelPositionCelebration; //Field offset: 0x2BC
	private Vector3 _labelPositionBoardBundleCelebration; //Field offset: 0x2C8
	private Vector3 _continueLabelPosition; //Field offset: 0x2D4
	private bool _maySetTimeScale; //Field offset: 0x2E0
	public GameObject GlowEffect; //Field offset: 0x2E4
	private Color32 EFFECT_INITIAL_COLOR; //Field offset: 0x2E8
	private float TAP_TO_START_ALPHA; //Field offset: 0x2EC
	private bool _stopIdleAnim; //Field offset: 0x2F0
	private int _numberOfRewards; //Field offset: 0x2F4
	private CoinBoxSizer _coinboxSizer; //Field offset: 0x2F8
	private CelebrationReward[] _rewardsToUnlock; //Field offset: 0x2FC
	private bool _celebrationHasStarted; //Field offset: 0x300
	private bool _isFingerPressed; //Field offset: 0x301
	private SuperMysteryBoxEffect _superMysteryBoxEffect; //Field offset: 0x304
	private SuperMysteryBoxEffect _roundGlowEffect; //Field offset: 0x308
	private float _timeScaleBeforeCelebrationPopup; //Field offset: 0x30C
	private Texture2D awardsBackground; //Field offset: 0x310
	private Texture2D normalBackground; //Field offset: 0x314
	private Texture2D _weeklyHuntBackground; //Field offset: 0x318
	private Texture2D _weeklyHuntStripe; //Field offset: 0x31C
	private GameObject stripePanel; //Field offset: 0x320
	private Texture2D characterEventBackgroundTexture; //Field offset: 0x324
	private UITexture backgroundTexture; //Field offset: 0x328
	private UIPanel _backgroundPanel; //Field offset: 0x32C
	private UITexture[] _stripeTextures; //Field offset: 0x330
	private bool _stripeCoroutineRunning; //Field offset: 0x334
	private GameObject _tapToStartGo; //Field offset: 0x338
	private bool _isRewardingJackpot; //Field offset: 0x33C
	private BragCelebrationHandler _bragCelebrationHandlerPrefab; //Field offset: 0x340
	private BragCelebrationHandler _currentBragCelebrationHandler; //Field offset: 0x344
	private MysteryBoxDoubleUpButton _mysteryBoxDoubleUpButton; //Field offset: 0x348
	private Vector3 _scaleTargetFactor; //Field offset: 0x34C
	private Method _scaleUpMethod; //Field offset: 0x358
	private Method _scaleDownMethod; //Field offset: 0x35C
	private float _scaleUpDuration; //Field offset: 0x360
	private float _scaleDownDurationFactor; //Field offset: 0x364
	private AudioClip _doubleRewardClip; //Field offset: 0x368
	private Dictionary<CelebrationRewardType, Action> _doubleRewardCallbacks; //Field offset: 0x36C
	private float _animationLerpFactor; //Field offset: 0x370
	private bool _isWaitingForInput; //Field offset: 0x374
	private bool _skipWaitBackButtonPressed; //Field offset: 0x375
	private CelebrationReward _rewardToDouble; //Field offset: 0x378
	private CelebrationPopupLabelTemplate _rewardTemplate; //Field offset: 0x37C

	public static event Action<CelebrationReward> OnRewardDoubleUp
	{
		 add { } //Length: 269
		 remove { } //Length: 209
	}

	private void _FinishOpening() { }

	private IEnumerator _ShowReward(int currentRewardIndex) { }

	private static CelebrationPopup() { }

	public CelebrationPopup() { }

	public static void add_OnRewardDoubleUp(Action<CelebrationReward> value) { }

	private IEnumerator AnimateAlpha(CelebrationPopupLabelTemplate template, float duration, float toAlpha) { }

	private IEnumerator AnimateAlpha(UILabel label, float duration, float toAlpha) { }

	private IEnumerator AnimateColor(UIWidget widget, float duration, Color toColor) { }

	private IEnumerator AnimateColor(Material material, float duration, Color toColor) { }

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1, bool instant = false) { }

	private IEnumerator AnimateScreenFlash(UISprite effectSprite) { }

	private IEnumerator AnimateStripes() { }

	private IEnumerator BoxIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward) { }

	private float CalcCoinCountTime(int toAmount, int fromAmount, float countTimeMultiplier) { }

	private GameObject ChooseRewardPrefab(CelebrationReward reward) { }

	public void ClosePrizeList() { }

	private IEnumerator CountUpCoins(int coinboxAmount, int toAmount, CelebrationPopupLabelTemplate rewardTemplate, bool isMegaJackpot = false, int fromAmount = 0, float countTimeMultiplier = 1, bool doubled = false) { }

	private void DoubleCoins() { }

	private IEnumerator DoubleCoins_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template) { }

	private void DoubleKeys() { }

	private IEnumerator DoubleKeys_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template) { }

	private void DoublePowerups() { }

	private IEnumerator DoublePowerups_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template) { }

	private void DoubleTokens() { }

	private IEnumerator DoubleTokens_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template) { }

	private void FillOutAllTheSlotsWithRewardContainers() { }

	public void FingerPressed() { }

	public void FingerReleased() { }

	private string GetCelebrationRewardSource(CelebrationReward reward) { }

	public override void Hide() { }

	private void HideCelebrationTunnel() { }

	private void HideModel() { }

	private void HidePrizeButtons() { }

	private void HideSpecialBoard() { }

	public override void Init() { }

	private IEnumerator Initial_Generic_DoubleUp_Routine(CelebrationReward reward, CelebrationPopupLabelTemplate template) { }

	private bool IsJackpot(CelebrationReward reward) { }

	private bool IsTwoStepsCelebration(int rewardIndex) { }

	private IEnumerator MoveGameObject(Transform trans, float duration, Vector3 toPos) { }

	private IEnumerator MoveNextBoxToFront() { }

	private void OnApplicationPause(bool pause) { }

	private void OnPopClosed(string popupName) { }

	public void OnTopRunAnimationFinished() { }

	private void PayoutReward(CelebrationReward reward, bool allowRemove, bool isDoubledReward) { }

	private IEnumerator PlaySoundDelayed(AudioClip clip, float delay = 0, float volume = 1) { }

	private void PlayTopRunAnimation(bool didHighFive) { }

	public void PrizeListMiniClicked() { }

	public void PrizeListNormalClicked() { }

	public void PrizeListSuperClicked() { }

	public static void remove_OnRewardDoubleUp(Action<CelebrationReward> value) { }

	private void ResetBackgroundToNormal() { }

	private IEnumerator RotateGameObject(Transform trans, float duration, Vector3 angleToRotate) { }

	private IEnumerator ScaleGameObject(Transform trans, float duration, Vector3 toScale) { }

	private void SetPreOpenedCelebrationLabelTemplate(CelebrationReward reward) { }

	private void SetupCelebrationScreen() { }

	private bool ShouldWaitForInput() { }

	public override void Show() { }

	private void ShowBackgroundWithStripes(BoardId boardId, ModelScreen modelScreen) { }

	private GameObject ShowModel(CharacterId charId, int themeIndex, ModelScreen modelScreen, bool cache) { }

	private void ShowPrizeList(Type type) { }

	public void SkipNow() { }

	private IEnumerator StartIdleAnimationFor(Transform rewardTrans, Vector3 baseLocalPos) { }

	private void StartIdleAnimCoroutine(Transform rewardTrans, CelebrationReward reward) { }

	private void StartOneStepUnlock() { }

	public void StopWaitingForInput() { }

	private void TogglePrizeButtons(CelebrationRewardOrigin origin) { }

	private void ToggleSuperMysteryBoxEffect(CelebrationRewardOrigin origin) { }

	private IEnumerator TweenScaleUpDown(GameObject go) { }

	private void Update() { }

	private void UpdateGui(CelebrationReward reward) { }

}

