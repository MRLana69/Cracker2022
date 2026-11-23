using Cpp2ILInjected;
using UnityEngine;

public class PointConstraint : MonoBehaviour
{
	private Transform transformCached;

	public Transform master
	{
		set
		{
			transformCached = value;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0062: Expected F4, but got I
		//IL_005d: Expected native int or pointer, but got VT
		//IL_008a: Expected F4, but got I
		//IL_0085: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (!(transformCached == null))
		{
			Transform transform = base.transform;
			Vector3 localPosition = transformCached.localPosition;
			Vector3 localPosition2 = transformCached.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
		}
	}
}
