using Cpp2ILInjected;
using Missions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlideInAwards : UISlideIn
{
	private Image _icon;

	private TMP_Text _textLine1;

	public void SetupSlideInAward(string payload, AwardTierType awardTierType)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_00a8: Expected I, but got Obj
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		TMP_Text textLine = _textLine1;
		string text = payload + "\nComplete";
		nint num = (nint)textLine;
		object obj = textLine + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		object obj2 = awardTierType - 1;
		if ((nint)obj2 <= 2)
		{
			object obj3 = obj2 << 2;
			object obj4 = obj3 + 2293140;
			object path = obj4;
			Sprite sprite = Resources.Load<Sprite>((string)path);
			_icon.sprite = sprite;
		}
		nint num2 = (nint)this;
		object obj5 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S2_v10 (Il2CppClass<UISlideInAwards>)+E4] (should have been resolved before IL gen)");
	}
}
