using Cpp2ILInjected;
using UI.FreeStuff;
using UI.RenderTexture;
using UnityEngine;

namespace UI.SlideIns;

public class UiSlideInFirstPurchaseBonus : UISlideIn
{
	private UILabel _title;

	private UILabel _subTitle;

	private FirstPurchaseBonusRenderTextureSetup _firstPurchaseBonusRenderTextureSetup;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_02b5: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_02f4: Expected I4, but got Obj
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0316: Expected I4, but got Obj
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_017f: Expected I, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0338: Expected I4, but got Obj
		//IL_0237: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		if (slideIn.facebookState != UISlideInFacebook.FacebookSlideInState.ConnectFailed)
		{
			if (slideIn.facebookState != UISlideInFacebook.FacebookSlideInState.ConnectSucceeded)
			{
				if (slideIn.facebookState == UISlideInFacebook.FacebookSlideInState.LoggedOut)
				{
					object obj = this - -64;
					((Component)obj).tag = (string)1;
					((Component)(object)_firstPurchaseBonusRenderTextureSetup).tag = null;
					nint num = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v42 (Il2CppClass<Strings>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v49 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text2 = Strings.GetDefault("FACEBOOK_LOGOUT_SLIDEIN");
					_title.fontSize = (int)text2;
				}
			}
			else
			{
				object obj3 = this - -64;
				((Component)obj3).tag = (string)1;
				((Component)(object)_firstPurchaseBonusRenderTextureSetup).tag = null;
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v27 (Il2CppClass<Strings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v34 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("FACEBOOK_ONLINE_SLIDEIN");
				_title.fontSize = (int)text3;
			}
		}
		else
		{
			object obj5 = this - -64;
			((Component)obj5).tag = null;
			((Component)(object)_firstPurchaseBonusRenderTextureSetup).tag = (string)1;
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v12 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v19 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("FACEBOOK_OFFLINE_SLIDEIN");
			_title.fontSize = (int)text4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UiSlideInFirstPurchaseBonus)+48]");
		((RewardForVideoButton)0).Init(null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)(object)slideIn.onDidShowCallback);
	}

	protected override void SlideOut()
	{
		((UISlideInAdsRemoved)this)._002Ector();
	}

	public UiSlideInFirstPurchaseBonus()
	{
		base.ReadyForNewMessage();
		((RenderTextureSetupBase)_firstPurchaseBonusRenderTextureSetup).OnReleaseRenderTexture();
	}
}
