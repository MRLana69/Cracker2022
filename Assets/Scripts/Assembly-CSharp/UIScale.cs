using Cpp2ILInjected;
using UnityEngine;

public class UIScale : MonoBehaviour
{
	private Vector2 iPadSize = (Vector2)4900479345669373952L;

	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005b: Expected F4, but got I
		//IL_0056: Expected native int or pointer, but got VT
		//IL_0071: Expected F4, but got VT
		//IL_006c: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		DeviceInfo instance = DeviceInfo.Instance;
		if (instance.formFactor__BackingField == DeviceInfo.FormFactor.iPad)
		{
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 localScale = transform2.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = iPadSize;
			((Vector3*)(nint)vector)->x = (float)iPadSize;
			transform.localScale = vector;
		}
	}

	public UIScale()
	{
		//IL_000f: Expected VT, but got I8
	}
}
