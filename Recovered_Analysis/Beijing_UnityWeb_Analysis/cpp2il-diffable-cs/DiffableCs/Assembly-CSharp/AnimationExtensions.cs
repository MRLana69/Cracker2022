//Type is in global namespace

public class AnimationExtensions : MonoBehaviour
{
	private sealed class <Play>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public bool useTimeScale; //Field offset: 0x10
		public Animation animation; //Field offset: 0x14
		public string clipName; //Field offset: 0x18
		public Action onComplete; //Field offset: 0x1C
		private AnimationState <_currState>5__2; //Field offset: 0x20
		private bool <isPlaying>5__3; //Field offset: 0x24
		private float <_progressTime>5__4; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 387
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Play>d__0(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	public AnimationExtensions() { }

	public static IEnumerator Play(Animation animation, string clipName, bool useTimeScale, Action onComplete) { }

}

