using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInFacebook : UISlideIn
{
	public enum FacebookSlideInState
	{
		ConnectFailed,
		ConnectSucceeded,
		LoggedOut
	}

	private UILabel _statusLabel;

	private UISprite _onlineIcon;

	private UISprite _offlineIcon;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0031: Expected I4, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		_statusLabel.fontSize = (int)slideIn.stringValue;
		object obj = this - -64;
		((RewardForVideoButton)obj).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
