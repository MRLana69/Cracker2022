using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common.Components;

public class InstantiatePrefabComponent : MonoBehaviour
{
	private GameObject _parent;

	private GameObject _prefab;

	private Vector3 _prefabLocalPosition;

	private bool _willInstantiateOnAwake = true;

	private GameObject _prefabInstance;

	protected void Awake()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		if (~(_willInstantiateOnAwake ? 1u : 0u) == 0)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S1_v3 (Il2CppClass<SYBO.Common.Components.InstantiatePrefabComponent>)+DC] (should have been resolved before IL gen)");
		}
	}

	public unsafe virtual GameObject InstantiatePrefab()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008f: Expected F4, but got I
		//IL_008a: Expected native int or pointer, but got VT
		//IL_009e: Expected F4, but got VT
		//IL_0099: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (_prefab != null)
		{
			GameObject prefabInstance = Object.Instantiate(_prefab);
			_prefabInstance = prefabInstance;
			Transform childTransform = _prefabInstance.transform;
			Transform parentTransform = _parent.transform;
			HierarchyUtility.Reparent(childTransform, parentTransform);
			Transform transform = _prefabInstance.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Components.InstantiatePrefabComponent)+1C]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)_prefabLocalPosition;
			transform.localPosition = vector;
		}
		return _prefabInstance;
	}
}
