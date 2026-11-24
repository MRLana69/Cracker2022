namespace Kiloo;

public class AnimationPlayAfterDelay : MonoBehaviour
{
	private sealed class <PlayAnimationAfterDelay>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AnimationPlayAfterDelay <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 149
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlayAnimationAfterDelay>d__3(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private BaseTimeDelay _timeDelay; //Field offset: 0xC
	private Animation _animation; //Field offset: 0x10

	public AnimationPlayAfterDelay() { }

	public void OnEnable() { }

	private IEnumerator PlayAnimationAfterDelay() { }

}

