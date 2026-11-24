//Type is in global namespace

public static class AudioSourceExtensions
{
	private sealed class <fadeOut>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AudioSource audioSource; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Action onComplete; //Field offset: 0x18
		private float <startingVolume>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 170
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <fadeOut>d__0(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	public static IEnumerator fadeOut(AudioSource audioSource, float duration, Action onComplete) { }

}

