using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class UISlideInMissionHelper : UISlideIn
{
	public TMP_Text line1;

	public void SetupSlideInMission(string message)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002a: Expected I, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		TMP_Text tMP_Text = line1;
		string text = message + "\nComplete";
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj2 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v9 (Il2CppClass<UISlideInMissionHelper>)+E4] (should have been resolved before IL gen)");
	}
}
