namespace SYBO.Components.Utilities;

public class PrefabPool
{
	private class Comparer : IComparer<PrefabPool>
	{

		public Comparer() { }

		private int System.Collections.Generic.IComparer<SYBO.Components.Utilities.PrefabPool>.Compare(PrefabPool x, PrefabPool y) { }

	}

	private static IComparer<PrefabPool> _comparer; //Field offset: 0x0
	public Transform prefab; //Field offset: 0x8
	internal GameObject prefabGO; //Field offset: 0xC
	public int preloadAmount; //Field offset: 0x10
	public bool limitInstances; //Field offset: 0x14
	public int limitAmount; //Field offset: 0x18
	public bool limitFIFO; //Field offset: 0x1C
	public bool cullDespawned; //Field offset: 0x1D
	public int cullAbove; //Field offset: 0x20
	public SpawnPool spawnPool; //Field offset: 0x24
	public int maxActive; //Field offset: 0x28
	public int loadedOnDemand; //Field offset: 0x2C
	private bool initialized; //Field offset: 0x30
	internal LinkedList<PooledInstanceData> _spawned; //Field offset: 0x34
	internal LinkedList<PooledInstanceData> _despawned; //Field offset: 0x38

	public static IComparer<PrefabPool> comparer
	{
		 get { } //Length: 1389
	}

	public LinkedList<PooledInstanceData> despawned
	{
		 get { } //Length: 72
	}

	public LinkedList<PooledInstanceData> spawned
	{
		 get { } //Length: 52
	}

	public int totalCount
	{
		 get { } //Length: 72
	}

	public PrefabPool(Transform prefab) { }

	public PrefabPool() { }

	internal void AddUnpooled(Transform inst, bool despawn) { }

	public bool Contains(Transform transform) { }

	internal bool DespawnInstance(Transform xform) { }

	internal bool DespawnInstance(Transform xform, bool sendEventMessage) { }

	public static IComparer<PrefabPool> get_comparer() { }

	public LinkedList<PooledInstanceData> get_despawned() { }

	public LinkedList<PooledInstanceData> get_spawned() { }

	public int get_totalCount() { }

	internal void inspectorInstanceConstructor() { }

	private void nameInstance(Transform instance) { }

	internal void SelfDestruct() { }

	private void SetRecursively(Transform xform, int layer) { }

	internal Transform SpawnInstance(Vector3 pos, Quaternion rot) { }

	public Transform SpawnNew() { }

	public Transform SpawnNew(Vector3 pos, Quaternion rot) { }

}

