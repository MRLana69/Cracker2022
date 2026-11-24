using Cpp2ILInjected;
using UnityEngine;

public class UIScrollClick : MonoBehaviour
{
	private GameObject target;

	private void OnClick()
	{
	}

	public UIScrollClick()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		obj2 = currentTouch.pos;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object parameter = default;
		target.BroadcastMessage("ScrollClicked", parameter, SendMessageOptions.DontRequireReceiver);
	}
}
