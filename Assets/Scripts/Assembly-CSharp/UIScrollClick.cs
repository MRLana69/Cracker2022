using Cpp2ILInjected;
using UnityEngine;

public class UIScrollClick : MonoBehaviour
{
	private GameObject target;

	private void OnClick()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		_ = currentTouch.pos;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value = default;
		target.SendMessage("ScrollClicked", value, SendMessageOptions.DontRequireReceiver);
	}
}
