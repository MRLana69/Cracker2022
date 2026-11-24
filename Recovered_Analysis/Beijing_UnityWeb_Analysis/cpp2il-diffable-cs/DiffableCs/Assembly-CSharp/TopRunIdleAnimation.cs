//Type is in global namespace

public class TopRunIdleAnimation : MonoBehaviour
{
	private sealed class <>c__DisplayClass21_0
	{
		public AnimationClip selectedClip; //Field offset: 0x8

		public <>c__DisplayClass21_0() { }

		internal bool <PlayTRIdles>b__0(AnimationClip a) { }

	}

	private sealed class <PlayTRhit>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TopRunIdleAnimation <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 250
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlayTRhit>d__23(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PlayTRIdles>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TopRunIdleAnimation <>4__this; //Field offset: 0x10
		private <>c__DisplayClass21_0 <>8__1; //Field offset: 0x14
		private TopRunAnimationSettings <aSettings>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 658
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlayTRIdles>d__21(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PlayTRmiss>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TopRunIdleAnimation <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 331
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlayTRmiss>d__22(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class AnimationElement
	{
		public AnimationClip clip; //Field offset: 0x8
		public int propability; //Field offset: 0xC

		public AnimationElement() { }

	}

	public delegate AnimationFinishDelegate
	{

		public AnimationFinishDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public class TopRunAnimationSettings
	{
		public string name; //Field offset: 0x8
		public AnimationClip topRunStart; //Field offset: 0xC
		public List<AnimationClip> topRunIdles; //Field offset: 0x10
		public List<AnimationClip> topRunHandMiss; //Field offset: 0x14
		public List<AnimationElement> topRunHandHit; //Field offset: 0x18

		public TopRunAnimationSettings() { }

	}

	private Animation Target; //Field offset: 0xC
	public bool PlayIdleAnimations; //Field offset: 0x10
	public bool paused; //Field offset: 0x11
	private IEnumerator animationRoutine; //Field offset: 0x14
	private float nextAnimationTime; //Field offset: 0x18
	public TopRunAnimationSettings[] animationSettings; //Field offset: 0x1C
	private List<AnimationClip> topRunHandHitWeighted; //Field offset: 0x20
	private Dictionary<string, TopRunAnimationSettings> _characterToAnimationSettings; //Field offset: 0x24
	private AnimationFinishDelegate AnimationFinished; //Field offset: 0x28

	public event AnimationFinishDelegate AnimationFinished
	{
		 add { } //Length: 272
		 remove { } //Length: 111
	}

	public TopRunIdleAnimation() { }

	public void add_AnimationFinished(AnimationFinishDelegate value) { }

	private void Awake() { }

	private Animation FindAnimationInParent(GameObject current) { }

	private TopRunAnimationSettings GetAnnimationSettingsFor(string name) { }

	private IEnumerator PlayTRhit() { }

	private IEnumerator PlayTRIdles() { }

	private IEnumerator PlayTRmiss() { }

	public void remove_AnimationFinished(AnimationFinishDelegate value) { }

	public void TR_ActivateIdle() { }

	public void TR_PlayHit() { }

	public void TR_PlayMiss() { }

	private void Update() { }

}

