using Cpp2ILInjected;
using UnityEngine;

public class MeFooter : MonoBehaviour
{
	private UILabel _menuLabel;

	private UILabel _charactersLabel;

	private UILabel _boarsLabel;

	private UILabel _awardsLabel;

	public static int selectedTab;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public MeFooter()
	{
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0104: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00a5: Expected I4, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FOOTER_MENU_BUTTON_TITLE");
		_menuLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("ME_FOOTER_CHARACTERS");
		_charactersLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("ME_FOOTER_BOARDS");
		_boarsLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("AWARDS_TITLE");
		_awardsLabel.fontSize = (int)text4;
	}

	static MeFooter()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		DeviceInfo.ShaderBackgroundBlendSrcPropName = "_BackgroundBlendSrcMode";
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<DeviceInfo>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = "_BackgroundBlendDstMode";
	}
}
