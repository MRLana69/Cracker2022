using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class UIDailyTimerLabel : MonoBehaviour
{
	private TMP_Text label;

	private string baseText;

	private void OnEnable()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_002b: Expected I, but got Obj
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_00d7: Expected I, but got Obj
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		if (label == null)
		{
			TMP_Text component = GetComponent<TMP_Text>();
			label = component;
			TMP_Text tMP_Text = label;
			nint num = (nint)tMP_Text;
			object obj = tMP_Text + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
			string text = default;
			baseText = text;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance.isDailyWordComplete();
		TMP_Text tMP_Text2 = label;
		object obj2 = this + 16;
		object obj3 = "Next Challenge in";
		if (!flag)
		{
			obj3 = obj2;
		}
		nint num2 = (nint)tMP_Text2;
		object obj4 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}
}
