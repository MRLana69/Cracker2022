using System;
using Cpp2ILInjected;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	private void Start()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void Update()
	{
	}

	public Rotator()
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got F4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		object obj = 0;
		_ = 0;
		obj = 0.5f;
		_ = 0f;
		_ = 0f;
		Transform transform = (Transform)(obj + 12);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject).LookAt(transform);
	}
}
