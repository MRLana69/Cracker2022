using Cpp2ILInjected;
using UnityEngine;

namespace UI.Helpers;

public class BuyMoreInStoreLabelHelper : MonoBehaviour
{
	private UILabel _buyMoreInStoreLabel;

	public void UpdateBuyMoreInStoreLabel()
	{
		CancelInvoke();
	}

	public BuyMoreInStoreLabelHelper()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("BUY_MORE_IN_STORE");
		_buyMoreInStoreLabel.fontSize = (int)text;
	}
}
