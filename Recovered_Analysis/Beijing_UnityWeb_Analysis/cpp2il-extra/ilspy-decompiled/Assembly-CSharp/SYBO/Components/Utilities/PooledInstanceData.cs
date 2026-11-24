using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class PooledInstanceData
{
	private LinkedListNode<PooledInstanceData> node__BackingField;

	public bool inUse;

	private int instanceId__BackingField;

	private Transform transform__BackingField;

	public LinkedListNode<PooledInstanceData> node
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			LinkedListNode<PooledInstanceData> result = default;
			return result;
		}
		private set
		{
			//IL_002c: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector("SpawnPools add themselves to PoolManager.Pools when created, so there is no need to Add() them explicitly. Create pools using PoolManager.Pools.Create() or add a SpawnPool component to a GameObject.");
			((SpawnPoolsDict)(object)ex).Add((KeyValuePair<string, SpawnPool>)0);
		}
	}

	public int instanceId
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)node__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public Transform transform
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Transform)instanceId__BackingField;
		}
		private set
		{
			//IL_000a: Expected I4, but got Obj
			instanceId__BackingField = (int)value;
		}
	}

	public PrefabPool pool
	{
		get
		{
			return (PrefabPool)(object)transform__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public PooledInstanceData(Transform transform, PrefabPool pool)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("PoolManager.Pools cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
