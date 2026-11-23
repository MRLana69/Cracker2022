using Cpp2ILInjected;
using UnityEngine;

public class FriendProgressHelper : MonoBehaviour
{
	public UILabel label;

	public UISlider slider;

	public UISprite coinPouch;

	public unsafe Vector3 GetCoinPouchGlobalPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected F4, but got I
		//IL_003f: Expected native int or pointer, but got VT
		//IL_0051: Expected F4, but got Obj
		//IL_004c: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = coinPouch.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		return vector;
	}
}
