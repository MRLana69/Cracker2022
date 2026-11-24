namespace UI.SlideIns;

public class UISlideInFacebook : UISlideIn
{
	public enum FacebookSlideInState
	{
		ConnectFailed = 0,
		ConnectSucceeded = 1,
		LoggedOut = 2,
	}

	private UILabel _statusLabel; //Field offset: 0x3C
	private UISprite _onlineIcon; //Field offset: 0x40
	private UISprite _offlineIcon; //Field offset: 0x44
	private Layout _layout; //Field offset: 0x48

	public UISlideInFacebook() { }

	public override void SetupSlideIn(SlideIn slideIn) { }

}

