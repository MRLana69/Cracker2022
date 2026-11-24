namespace SYBO.Components.Utilities.Examples;

public class CreationExample : MonoBehaviour
{
	private sealed class <Despawner>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CreationExample <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 187
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Despawner>d__7(int <>1__state) { }

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
		public CreationExample <>4__this; //Field offset: 0x10
		private int <count>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 460
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

	public Transform testPrefab; //Field offset: 0xC
	public string poolName; //Field offset: 0x10
	public int spawnAmount; //Field offset: 0x14
	public float spawnInterval; //Field offset: 0x18
	private SpawnPool pool; //Field offset: 0x1C

	public CreationExample() { }

	private IEnumerator Despawner() { }

	private IEnumerator Spawner() { }

	private void Start() { }

}

