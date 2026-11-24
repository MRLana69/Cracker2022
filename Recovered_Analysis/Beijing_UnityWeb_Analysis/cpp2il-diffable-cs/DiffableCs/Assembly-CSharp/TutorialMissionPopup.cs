//Type is in global namespace

public class TutorialMissionPopup : CharacterPopup
{
	private GameObject _centerAnchor; //Field offset: 0x38
	private GameObject _tutorialMultiLinesPrefab; //Field offset: 0x3C
	private UILabel _calloutLabel; //Field offset: 0x40
	private UILabel _buttonText; //Field offset: 0x44
	private TutorialMultilineLabelsHelper _tutorialLinesHelper; //Field offset: 0x48

	public TutorialMissionPopup() { }

	public void CloseClicked() { }

	public override void Init() { }

	public void OkClicked() { }

	public override void Show() { }

}

