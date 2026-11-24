namespace SYBO.Components.Utilities;

public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
{
	private sealed class <DoDespawnAfterSeconds>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Transform instance; //Field offset: 0x10
		public float seconds; //Field offset: 0x14
		public SpawnPool <>4__this; //Field offset: 0x18
		private GameObject <go>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 159
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DoDespawnAfterSeconds>d__57(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <GetEnumerator>d__73 : IEnumerator<Transform>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private Transform <>2__current; //Field offset: 0xC
		public SpawnPool <>4__this; //Field offset: 0x10
		private int <j>5__2; //Field offset: 0x14
		private LinkedListNode<PooledInstanceData> <node>5__3; //Field offset: 0x18

		private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
		{
			 get { } //Length: 369
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetEnumerator>d__73(int <>1__state) { }

		private bool MoveNext() { }

		private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ListForAudioStop>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AudioSource src; //Field offset: 0x10
		public SpawnPool <>4__this; //Field offset: 0x14
		private GameObject <srcGameObject>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 189
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ListForAudioStop>d__64(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <System-Collections-IEnumerable-GetEnumerator>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SpawnPool <>4__this; //Field offset: 0x10
		private int <j>5__2; //Field offset: 0x14
		private LinkedListNode<PooledInstanceData> <node>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 366
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate DestroyDelegate
	{

		public DestroyDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject instance, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject instance) { }

	}

	public delegate InstantiateDelegate
	{

		public InstantiateDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject prefab, Vector3 pos, Quaternion rot, AsyncCallback callback, object object) { }

		public virtual GameObject EndInvoke(IAsyncResult result) { }

		public virtual GameObject Invoke(GameObject prefab, Vector3 pos, Quaternion rot) { }

	}

	public class PrefabPoolGroup
	{
		private class Comparer : IComparer<PrefabPoolGroup>
		{

			public Comparer() { }

			private int System.Collections.Generic.IComparer<SYBO.Components.Utilities.SpawnPool.PrefabPoolGroup>.Compare(PrefabPoolGroup x, PrefabPoolGroup y) { }

		}

		private static IComparer<PrefabPoolGroup> _comparer; //Field offset: 0x0
		public bool expandPrefabs; //Field offset: 0x8
		public string name; //Field offset: 0xC
		public List<PrefabPool> prefabPools; //Field offset: 0x10

		public static IComparer<PrefabPoolGroup> comparer
		{
			 get { } //Length: 92
		}

		public PrefabPoolGroup() { }

		public static IComparer<PrefabPoolGroup> get_comparer() { }

	}

	public int spawnPriority; //Field offset: 0xC
	public int despawnPriority; //Field offset: 0x10
	public int logLevelAdjust; //Field offset: 0x14
	public string poolName; //Field offset: 0x18
	public bool dontReparent; //Field offset: 0x1C
	public bool _dontDestroyOnLoad; //Field offset: 0x1D
	public bool sendUnityEvents; //Field offset: 0x1E
	public List<PrefabPoolGroup> _prefabPoolGroups; //Field offset: 0x20
	public Dictionary<object, bool> prefabsFoldOutStates; //Field offset: 0x24
	public float maxParticleDespawnTime; //Field offset: 0x28
	private Transform <group>k__BackingField; //Field offset: 0x2C
	public PrefabsDict prefabs; //Field offset: 0x30
	public Dictionary<object, bool> _editorListItemStates; //Field offset: 0x34
	private List<PrefabPool> _prefabPools; //Field offset: 0x38
	public InstantiateDelegate instantiateDelegates; //Field offset: 0x3C
	public DestroyDelegate destroyDelegates; //Field offset: 0x40

	public int Count
	{
		 get { } //Length: 1059
	}

	public bool dontDestroyOnLoad
	{
		 get { } //Length: 49
		 set { } //Length: 153
	}

	public Transform group
	{
		 get { } //Length: 9
		private set { } //Length: 150
	}

	public bool IsReadOnly
	{
		 get { } //Length: 66
	}

	public Transform Item
	{
		 get { } //Length: 76
		 set { } //Length: 11
	}

	public int PrefabPoolCount
	{
		 get { } //Length: 73
	}

	public SpawnPool() { }

	public void Add(Transform instance, string prefabName, bool despawn, bool parent) { }

	public void Add(Transform item) { }

	private void Awake() { }

	public void Clear() { }

	public bool Contains(Transform item) { }

	public void CopyTo(Transform[] array, int arrayIndex) { }

	public void CreatePrefabPool(PrefabPool prefabPool) { }

	public void Despawn(Transform instance, float seconds, Transform parent) { }

	public void Despawn(Transform instance, float seconds) { }

	public void Despawn(Transform instance, Transform parent) { }

	public void Despawn(Transform instance) { }

	public void DespawnAll() { }

	internal void DestroyInstance(GameObject instance) { }

	private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds) { }

	public int get_Count() { }

	public bool get_dontDestroyOnLoad() { }

	public Transform get_group() { }

	public bool get_IsReadOnly() { }

	public Transform get_Item(int index) { }

	public int get_PrefabPoolCount() { }

	public int GetBalanceOperations() { }

	public IEnumerator<Transform> GetEnumerator() { }

	public Transform GetPrefab(Transform instance) { }

	public GameObject GetPrefab(GameObject instance) { }

	public PrefabPool GetPrefabPool(Transform prefab) { }

	public PrefabPool GetPrefabPool(int idx) { }

	public PrefabPool GetPrefabPool(GameObject prefab) { }

	public int IndexOf(Transform item) { }

	public void Insert(int index, Transform item) { }

	internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot) { }

	public bool IsSpawned(Transform instance) { }

	private IEnumerator ListForAudioStop(AudioSource src) { }

	private void OnDestroy() { }

	public void Remove(Transform item) { }

	public void RemoveAt(int index) { }

	public void set_dontDestroyOnLoad(bool value) { }

	private void set_group(Transform value) { }

	public void set_Item(int index, Transform value) { }

	public T Spawn(T prefab, Vector3 position, Quaternion rotation, Transform parent) { }

	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent) { }

	public T Spawn(T prefab, Transform parent) { }

	public Transform Spawn(Transform prefab, Transform parent) { }

	public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent) { }

	public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot) { }

	public Transform Spawn(GameObject prefab) { }

	public Transform Spawn(GameObject prefab, Transform parent) { }

	public Transform Spawn(string prefabName) { }

	public T Spawn(T prefab) { }

	public Transform Spawn(string prefabName, Transform parent) { }

	public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent) { }

	public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot) { }

	public AudioSource Spawn(AudioSource prefab) { }

	public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent) { }

	public Transform Spawn(Transform prefab) { }

	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot) { }

	public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot) { }

	public AudioSource Spawn(AudioSource prefab, Transform parent) { }

	private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override string ToString() { }

}

