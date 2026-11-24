using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Components;

public class InstantiatePrefabComponent : MonoBehaviour
{
	private GameObject _parent;

	private GameObject _prefab;

	private Vector3 _prefabLocalPosition;

	private bool _willInstantiateOnAwake;

	private GameObject _prefabInstance;

	protected void Awake()
	{
		CancelInvoke();
	}

	public virtual GameObject InstantiatePrefab()
	{
		return _prefab;
	}

	public InstantiatePrefabComponent()
	{
		if (~(_willInstantiateOnAwake ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
	}
}
