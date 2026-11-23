using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class PreRuntimePoolItem : MonoBehaviour
{
	public string poolName = string.Empty;

	public string prefabName = string.Empty;

	public bool despawnOnStart = true;

	public bool doNotReparent;

	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Ref, but got Unknown
		//IL_0088: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!PoolManager.Pools.TryGetValue(poolName, out *(SpawnPool*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			string text = name;
			throw new ArrayTypeMismatchException();
		}
		Transform instance = transform;
		bool parent = (byte)(~(doNotReparent ? 1u : 0u)) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		((SpawnPool)0).Add(instance, prefabName, despawnOnStart, parent);
	}
}
