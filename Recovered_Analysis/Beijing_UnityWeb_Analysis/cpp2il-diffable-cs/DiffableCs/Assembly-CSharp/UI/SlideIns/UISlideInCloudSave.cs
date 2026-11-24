namespace UI.SlideIns;

public class UISlideInCloudSave : UISlideIn
{
	protected UILabel _topLine; //Field offset: 0x3C
	protected UILabel _bottomLine; //Field offset: 0x40
	protected HorizontalLayout _layout; //Field offset: 0x44
	protected UISprite _icon; //Field offset: 0x48
	protected UISprite _accentIcon; //Field offset: 0x4C
	protected FitSpriteToWidget _fitter; //Field offset: 0x50
	protected SlideIn _payload; //Field offset: 0x54

	public UISlideInCloudSave() { }

	protected virtual void SetupBasic() { }

	private void SetupConflict() { }

	private void SetupDisconnected() { }

	private void SetupError() { }

	private void SetupOk() { }

	public override void SetupSlideIn(SlideIn slideIn) { }

	private void SetupSlideIn(CloudSaveState state) { }

	protected virtual void SetupSpecific(CloudSaveState state) { }

}

