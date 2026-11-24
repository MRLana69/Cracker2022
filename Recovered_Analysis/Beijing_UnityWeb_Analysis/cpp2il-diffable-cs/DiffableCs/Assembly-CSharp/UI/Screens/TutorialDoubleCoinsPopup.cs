namespace UI.Screens;

public class TutorialDoubleCoinsPopup : CharacterPopup
{
	private GameObject _centerAnchor; //Field offset: 0x38
	private UILabel _calloutText; //Field offset: 0x3C
	private GameObject _tutorialMultiLinesPrefab; //Field offset: 0x40
	private GameObject _doubleCoinsPrefab; //Field offset: 0x44
	private TutorialMultilineLabelsHelper _tutorialLinesHelper; //Field offset: 0x48
	private GameObject _doubleCoins; //Field offset: 0x4C

	public TutorialDoubleCoinsPopup() { }

	public override void Hide() { }

	public override void Init() { }

	private void OnNewPopupClosed(string popupName) { }

	private void OnNewPopupShown(string popupName) { }

	public override void Show() { }

}

