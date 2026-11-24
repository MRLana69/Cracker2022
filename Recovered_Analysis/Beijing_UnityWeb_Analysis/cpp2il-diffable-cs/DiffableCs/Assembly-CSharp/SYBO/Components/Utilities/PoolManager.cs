namespace SYBO.Components.Utilities;

public static class PoolManager
{
	private sealed class <PoolBalancing>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private Action<float> <thisProgress>5__2; //Field offset: 0x10
		private float <totalBalanceOperations>5__3; //Field offset: 0x14
		private float <balanceOperation>5__4; //Field offset: 0x18
		private int <i>5__5; //Field offset: 0x1C
		private PoolPriority <priority>5__6; //Field offset: 0x20
		private int <j>5__7; //Field offset: 0x24
		private PrefabPool <prefabPool>5__8; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1926
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PoolBalancing>d__27(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class PoolPriority
	{
		public int Priority; //Field offset: 0x8
		public bool IsSpawnPriority; //Field offset: 0xC
		public SpawnPool Pool; //Field offset: 0x10

		public PoolPriority() { }

	}

	private class PoolPriorityComparer : IComparer<PoolPriority>
	{

		public PoolPriorityComparer() { }

		public int Compare(PoolPriority x, PoolPriority y) { }

	}

	public static Action<Transform> OnObjectInstantiated; //Field offset: 0x0
	public static readonly SpawnPoolsDict Pools; //Field offset: 0x4
	private static bool _balancing; //Field offset: 0x8
	private static bool _restartBalancing; //Field offset: 0x9
	private static bool _forceRestartBalancing; //Field offset: 0xA
	private static Action<float> _onProgress; //Field offset: 0xC
	public static int BalancingBudgetMS; //Field offset: 0x10
	private static List<PoolPriority> _priorities; //Field offset: 0x14
	private static PoolPriorityComparer _comparer; //Field offset: 0x18
	private static int _frameCount; //Field offset: 0x1C
	private static Stopwatch _sw; //Field offset: 0x20
	private static Dictionary<Transform, PrefabPool> _prefabPoolLookup; //Field offset: 0x24
	private static Dictionary<int, PooledInstanceData> _pooledLookup; //Field offset: 0x28

	public static bool Working
	{
		 get { } //Length: 87
	}

	private static PoolManager() { }

	public static void AddPool(PrefabPool prefabPool) { }

	public static void BeginBalancing(Action<float> onProgress) { }

	public static void Despawn(Transform instance) { }

	public static bool get_Working() { }

	private static SpawnPool GetDefaultSpawnPool() { }

	public static PooledInstanceData GetInstanceData(Transform instance) { }

	public static PrefabPool GetPrefabPool(Transform prefab) { }

	private static IEnumerator PoolBalancing() { }

	public static bool PrefabPoolExists(Transform prefab) { }

	public static void RegisterInstance(PooledInstanceData instanceData) { }

	public static void Remove(SpawnPool spawnPool) { }

	public static Transform Spawn(Transform prefab) { }

	public static void StartClock() { }

	public static void StopClock() { }

	public static void TriggerPoolBalancing(MonoBehaviour coroutineHost = null) { }

	public static void UnregisterInstance(PooledInstanceData instanceData) { }

	private static int UpdatePriorityList() { }

}

