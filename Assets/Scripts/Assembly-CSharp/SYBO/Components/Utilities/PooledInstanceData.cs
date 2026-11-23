using System.Collections.Generic;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class PooledInstanceData
{
	public bool inUse;

	public LinkedListNode<PooledInstanceData> node
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public int instanceId
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public Transform transform
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public PrefabPool pool
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public PooledInstanceData(Transform transform, PrefabPool pool)
	{
		this.pool__BackingField = pool;
		this.transform__BackingField = transform;
		LinkedListNode<PooledInstanceData> linkedListNode = default;
		linkedListNode.item = this;
		node__BackingField = linkedListNode;
		int instanceID = transform.GetInstanceID();
		instanceId__BackingField = instanceID;
	}
}
