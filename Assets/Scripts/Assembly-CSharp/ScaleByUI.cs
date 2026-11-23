using Cpp2ILInjected;
using UnityEngine;

public class ScaleByUI : MonoBehaviour
{
	public Vector3 startScale;

	private float preScale = -1f;

	public Transform follow;

	public void Init(Transform target, Vector3 scale)
	{
		//IL_000f: Expected VT, but got F4
		startScale = (Vector3)scale.x;
		_ = scale.z;
		follow = target;
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0034: Invalid comparison between F4 and I
		//IL_0069: Expected F4, but got I
		//IL_00d7: Expected F4, but got I
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00f6: Expected F4, but got I
		//IL_00f1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (follow != null)
		{
			Vector3 localScale = follow.localScale;
			float num = preScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			if (num != 0f)
			{
				Vector3 localScale2 = follow.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				preScale = 0f;
				Transform transform = base.transform;
				float num2 = (float)startScale * preScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScaleByUI)+10]");
				float num3 = 0f * preScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScaleByUI)+14]");
				float num4 = 0f * preScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform.localScale = vector;
			}
		}
	}
}
