namespace SYBO.Components.Utilities;

public class PooledInstanceData
{
	private LinkedListNode<PooledInstanceData> <node>k__BackingField; //Field offset: 0x8
	public bool inUse; //Field offset: 0xC
	private int <instanceId>k__BackingField; //Field offset: 0x10
	private Transform <transform>k__BackingField; //Field offset: 0x14
	private PrefabPool <pool>k__BackingField; //Field offset: 0x18

	public int instanceId
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public LinkedListNode<PooledInstanceData> node
	{
		 get { } //Length: 118
		private set { } //Length: 79
	}

	public PrefabPool pool
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public Transform transform
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public PooledInstanceData(Transform transform, PrefabPool pool) { }

	public int get_instanceId() { }

	public LinkedListNode<PooledInstanceData> get_node() { }

	public PrefabPool get_pool() { }

	public Transform get_transform() { }

	private void set_instanceId(int value) { }

	private void set_node(LinkedListNode<PooledInstanceData> value) { }

	private void set_pool(PrefabPool value) { }

	private void set_transform(Transform value) { }

}

