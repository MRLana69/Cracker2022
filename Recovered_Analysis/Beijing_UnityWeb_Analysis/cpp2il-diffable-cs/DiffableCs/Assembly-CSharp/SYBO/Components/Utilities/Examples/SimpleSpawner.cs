namespace SYBO.Components.Utilities.Examples;

public class SimpleSpawner : MonoBehaviour
{
	private sealed class <Despawner>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SimpleSpawner <>4__this; //Field offset: 0x10
		private SpawnPool <shapesPool>5__2; //Field offset: 0x14
		private Enumerator<Transform> <>7__wrap2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 950
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Despawner>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

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
		public SimpleSpawner <>4__this; //Field offset: 0x10
		private int <count>5__2; //Field offset: 0x14
		private SpawnPool <shapesPool>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 419
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

	public string poolName; //Field offset: 0xC
	public Transform testPrefab; //Field offset: 0x10
	public int spawnAmount; //Field offset: 0x14
	public float spawnInterval; //Field offset: 0x18
	public string particlesPoolName; //Field offset: 0x1C

	public SimpleSpawner() { }

	private IEnumerator Despawner() { }

	private IEnumerator Spawner() { }

	private void Start() { }

}

