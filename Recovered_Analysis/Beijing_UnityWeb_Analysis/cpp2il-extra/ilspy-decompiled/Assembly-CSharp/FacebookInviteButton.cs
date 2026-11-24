using Cpp2ILInjected;
using Kiloo.Plugins.Facebook;
using UnityEngine;

public class FacebookInviteButton : MonoBehaviour
{
	private UILabel _recommendLabel;

	private void OnEnable()
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FacebookInviteButton)+18]");
		((GameObject)0).tag = (string)1;
	}

	private void OnClick()
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
		string text = Strings.GetDefault("FACEBOOK_RECOMMEND_BUTTON_TEXT");
		_recommendLabel.fontSize = (int)text;
	}

	public FacebookInviteButton()
	{
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_00df: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I4
		//IL_012c: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 != null;
		if (flag)
		{
			if (flag2)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v27 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			((SocialManager)facebookDialogsSupported2).Invalidate();
			return;
		}
		if (flag2)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v19 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = flag3;
		bool flag4 = SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported3, obj5);
	}
}
