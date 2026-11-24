using Cpp2ILInjected;
using UnityEngine;

namespace UI.Screens;

public class FriendsFooter : MonoBehaviour
{
	private UILabel _menuLabel;

	private UILabel _friendsLabel;

	private UILabel _leaderboardLabel;

	private UILabel _toprunLabel;

	private GameObject _collectButton;

	private void OnEnable()
	{
	}

	public FriendsFooter()
	{
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_0115: Expected I4, but got Obj
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FOOTER_MENU_BUTTON_TITLE");
		_menuLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("COLLECT_TITLE");
		_friendsLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("HIGH_SCORES_TITLE");
		_leaderboardLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("TOPRUN_TITLE");
		_toprunLabel.fontSize = (int)text4;
		_collectButton.tag = null;
	}
}
