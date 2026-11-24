namespace UI.Popups;

public class WelcomePopup : CharacterPopup
{
	private UILabel _calloutLabel; //Field offset: 0x38
	private UILabel _buttonText; //Field offset: 0x3C
	private UISprite _calloutBackgroundSprite; //Field offset: 0x40
	private UISprite _calloutBackgroundTriangleSprite; //Field offset: 0x44
	private GameObject _centerAnchor; //Field offset: 0x48
	private GameObject _tutorialMultiLinesPrefab; //Field offset: 0x4C
	private TutorialMultilineLabelsHelper _tutorialLinesHelper; //Field offset: 0x50

	public WelcomePopup() { }

	public override void GainFocus() { }

	public override void Init() { }

	public override void LoseFocus() { }

	public void OkClicked() { }

	public override void Show() { }

	public void UpdateColors() { }

}

