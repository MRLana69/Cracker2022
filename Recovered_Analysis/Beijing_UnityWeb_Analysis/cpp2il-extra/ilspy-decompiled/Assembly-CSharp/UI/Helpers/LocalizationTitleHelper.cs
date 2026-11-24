using Cpp2ILInjected;
using UnityEngine;

namespace UI.Helpers;

public class LocalizationTitleHelper : MonoBehaviour
{
	private UILabel _title;

	private UILabel _subTitle;

	private string _titleStringId;

	private string _subTitleStringId;

	private int _titleStringIdIndex;

	private int _subTitleStringIdIndex;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public LocalizationTitleHelper()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00c1: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(_titleStringId);
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault(_subTitleStringId);
		_subTitle.fontSize = (int)text2;
	}
}
