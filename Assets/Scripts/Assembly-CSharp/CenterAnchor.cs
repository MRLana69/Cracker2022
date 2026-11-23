using Cpp2ILInjected;
using UnityEngine;

public class CenterAnchor : MonoBehaviour
{
	private bool hasInited;

	private bool useY;

	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_009d: Expected F4, but got I
		//IL_0098: Expected native int or pointer, but got VT
		//IL_00d9: Expected F4, but got I
		//IL_00d4: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		UIScreenController instance = UIScreenController.Instance;
		if (~(hasInited ? 1u : 0u) != 0)
		{
			if (~(useY ? 1u : 0u) == 0)
			{
				UIRoot root = instance.root;
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				Vector3 localPosition = transform2.localPosition;
				Transform transform3 = base.transform;
				Vector3 localPosition2 = transform3.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				float num = (float)root.manualHeight * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform.localPosition = vector;
			}
			hasInited = true;
		}
	}
}
