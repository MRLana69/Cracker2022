//Type is in global namespace

public class AvatarAnimations : MonoBehaviour
{
	private sealed class <>c__DisplayClass39_0
	{
		public AnimationClip selectedClip; //Field offset: 0x8
		public Predicate<AnimationClip> <>9__0; //Field offset: 0xC
		public Predicate<AnimationClip> <>9__1; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <Play>b__0(AnimationClip a) { }

		internal bool <Play>b__1(AnimationClip a) { }

	}

	private sealed class <Play>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AvatarAnimations <>4__this; //Field offset: 0x10
		private <>c__DisplayClass39_0 <>8__1; //Field offset: 0x14
		private string <clipName>5__2; //Field offset: 0x18
		private int <count>5__3; //Field offset: 0x1C
		private int <i>5__4; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1162
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Play>d__39(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PlayAnimationsInOrder>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AvatarAnimations <>4__this; //Field offset: 0x10
		public AnimationClip[] animationClips; //Field offset: 0x14
		public bool useUnscaledTime; //Field offset: 0x18
		private AnimationClip <selectedClip>5__2; //Field offset: 0x1C
		private int <animationIndex>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 517
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlayAnimationsInOrder>d__38(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private SkinnedMeshRenderer _head; //Field offset: 0xC
	private Transform _blendshapeController; //Field offset: 0x10
	private Animation _target; //Field offset: 0x14
	private List<AnimationClip> IdlesPopup; //Field offset: 0x18
	public bool Paused; //Field offset: 0x1C
	public bool PlayIdleAnimations; //Field offset: 0x1D
	private AnimationClip startClip; //Field offset: 0x20
	private List<AnimationClip> _idles; //Field offset: 0x24
	private AnimationClip _breath; //Field offset: 0x28
	private CharacterAssetsBundle currentCharacterBundle; //Field offset: 0x2C
	private int _currentOutfitIndex; //Field offset: 0x30
	private bool usePopupIdles; //Field offset: 0x34
	private bool useStartClip; //Field offset: 0x35
	private IEnumerator animationRoutine; //Field offset: 0x38
	private float nextAnimationTime; //Field offset: 0x3C
	private int _blendshapeCount; //Field offset: 0x40
	private int MinIdleTimes; //Field offset: 0x44
	private int MaxIdleTimes; //Field offset: 0x48
	private CharacterIdlesBundle _idlesBundle; //Field offset: 0x4C

	public Transform BlendshapeController
	{
		 set { } //Length: 11
	}

	public SkinnedMeshRenderer Head
	{
		 set { } //Length: 546
	}

	public Animation Target
	{
		 set { } //Length: 11
	}

	public AvatarAnimations() { }

	private void <StartIdleAnimations>b__32_0(CharacterIdlesBundle idlesBundle) { }

	private void ClearBundleAnimation() { }

	private Animation FindAnimationInParent(GameObject current) { }

	public float GetBlendShapeValue(int index) { }

	public void Initialize(CharacterAssetsBundle characterAssetsBundle, int outfitIndex) { }

	public static float NormalizeBlendShape(float value) { }

	private void OnDestroy() { }

	public void PauseIdleAnimations() { }

	private IEnumerator Play() { }

	private IEnumerator PlayAnimationsInOrder(AnimationClip[] animationClips, bool useUnscaledTime) { }

	public void ResumeIdleAnimations() { }

	public void set_BlendshapeController(Transform value) { }

	public void set_Head(SkinnedMeshRenderer value) { }

	public void set_Target(Animation value) { }

	public void StartCustomAnimations(AnimationClip[] animationClips, bool useUnscaledTime) { }

	public void StartIdleAnimations() { }

	public void StartIdlePopupAnimations() { }

	public void StopIdleAnimations() { }

	private void Update() { }

}

