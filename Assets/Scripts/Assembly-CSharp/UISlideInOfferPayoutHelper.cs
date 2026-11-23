using Cpp2ILInjected;
using UnityEngine;

public class UISlideInOfferPayoutHelper : UISlideIn
{
	private UILabel _price;

	private void Awake()
	{
		if (!(_price == null))
		{
		}
	}

	public void SetupSlideInOffer(string sum)
	{
		//IL_0025: Expected I, but got Obj
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0051: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		nint num = (nint)sum;
		object obj = sum + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S2_v3 (Il2CppClass<System.String>)+D4] (should have been resolved before IL gen)");
		string text = default;
		_price.text = text;
		nint num2 = (nint)this;
		object obj2 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v8 (Il2CppClass<UISlideInOfferPayoutHelper>)+E4] (should have been resolved before IL gen)");
	}
}
