namespace SYBO.Components.Utilities.Examples;

public class ReallySimpleAudioSpawner : MonoBehaviour
{
	private sealed class <MusicSpawner>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ReallySimpleAudioSpawner <>4__this; //Field offset: 0x10
		private AudioSource <music>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 459
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MusicSpawner>d__5(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Spawner>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ReallySimpleAudioSpawner <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 277
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Spawner>d__6(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public AudioSource prefab; //Field offset: 0xC
	public AudioSource musicPrefab; //Field offset: 0x10
	public float spawnInterval; //Field offset: 0x14
	private SpawnPool pool; //Field offset: 0x18

	public ReallySimpleAudioSpawner() { }

	private IEnumerator MusicSpawner() { }

	private IEnumerator Spawner() { }

	private void Start() { }

}

