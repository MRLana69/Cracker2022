using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class UISlideInItemHunt : UISlideIn
{
	private TMP_Text _textLabel;

	public void SetupSlideInOffer(string sum)
	{
		//IL_0022: Expected I, but got Obj
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S2_v3 (Il2CppClass<UISlideInItemHunt>)+E4] (should have been resolved before IL gen)");
	}
}
