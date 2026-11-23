using Cpp2ILInjected;
using UnityEngine;

public class SyncPositionHelper : MonoBehaviour
{
	public GameObject fromObject;

	public GameObject toObject;

	private Transform fromTransform;

	private Transform toTransform;

	private void Start()
	{
		if (fromObject == null || toObject == null)
		{
			enabled = false;
			return;
		}
		Transform transform = fromObject.transform;
		fromTransform = transform;
		Transform transform2 = toObject.transform;
		toTransform = transform2;
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_00cd: Expected F4, but got I
		//IL_00c8: Expected native int or pointer, but got VT
		//IL_00f4: Expected F4, but got I
		//IL_00ef: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (fromObject != null && toObject != null)
		{
			object obj2 = this + 20;
			if (fromTransform == null)
			{
				Transform transform = fromObject.transform;
				fromTransform = transform;
			}
			object obj3 = this + 24;
			if (toTransform == null)
			{
				Transform transform2 = toObject.transform;
				toTransform = transform2;
			}
			Vector3 position = ((Transform)obj2).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			float num = 0f * 2.25f;
			Vector3 position2 = ((Transform)obj3).position;
			Vector3 position3 = ((Transform)obj3).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			((Transform)obj3).position = vector;
		}
	}
}
