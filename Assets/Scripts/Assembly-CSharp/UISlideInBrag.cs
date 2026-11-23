using Cpp2ILInjected;
using UnityEngine;

public class UISlideInBrag : UISlideIn
{
	private UILabel firstLine;

	private UILabel secondLine;

	public void SetupSlideInBrag()
	{
		//IL_004e: Expected I, but got Obj
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		string text = Strings.Get(StringID.SLIDE_IN_BRAG_FIRST_LINE);
		firstLine.text = text;
		string text2 = Strings.Get(StringID.SLIDE_IN_BRAG_SECOND_LINE);
		secondLine.text = text2;
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v7 (Il2CppClass<UISlideInBrag>)+E4] (should have been resolved before IL gen)");
	}
}
