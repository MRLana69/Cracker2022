//Type is in global namespace

public class TutorialHoverboardPopup : CharacterPopup
{
	private const int NUMBER_OF_FREE_HOVERBOARDS = 3; //Field offset: 0x0
	private UILabel _calloutLabel; //Field offset: 0x38
	private UILabel _subtitleLabel; //Field offset: 0x3C
	private Layout _labelLayout; //Field offset: 0x40
	private UILabel _buttonLabel; //Field offset: 0x44
	private GameObject _centerAnchor; //Field offset: 0x48
	private GameObject _tutorialMultiLinesPrefab; //Field offset: 0x4C
	private TutorialMultilineLabelsHelper _tutorialLinesHelper; //Field offset: 0x50
	private string _hoverboardScreenType; //Field offset: 0x54

	public TutorialHoverboardPopup() { }

	public void CloseClicked() { }

	public override void Init() { }

	public void OkClicked() { }

	public override void Show() { }

}

