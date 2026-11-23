using Cpp2ILInjected;
using UnityEngine;

public class UISlideInErrorMessage : UISlideIn
{
	private UILabel messageLabel;

	public void SetupErrorMessage(string message)
	{
		//IL_0031: Expected I, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		messageLabel.text = message;
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v4 (Il2CppClass<UISlideInErrorMessage>)+E4] (should have been resolved before IL gen)");
	}
}
