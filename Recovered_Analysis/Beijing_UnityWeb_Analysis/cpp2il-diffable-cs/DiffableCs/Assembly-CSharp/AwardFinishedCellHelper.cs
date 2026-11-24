//Type is in global namespace

public class AwardFinishedCellHelper : MonoBehaviour
{
	private const string AWARD_COMPLETE_DESCRIPTION_HEX_COLOR = "[549133]"; //Field offset: 0x0
	private const string AWARD_COMPLETE_VALUE_HEX_COLOR = "[015A01]"; //Field offset: 0x0
	private const string END_COLOR_SYMBOL = "[-]"; //Field offset: 0x0
	private static readonly Color32 COMPLETED_TITLE_TEXT_COLOR; //Field offset: 0x0
	private const string COMPLETED_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed"; //Field offset: 0x0
	private const string COMPLETED_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed_small"; //Field offset: 0x0
	private static readonly Color32 COMPLETED_TITLE_TEXT_SHADOW_COLOR; //Field offset: 0x4
	private static readonly Color32 COMPLETE_SEGMENT_BACKGROUND_COLOR; //Field offset: 0x8
	private UILabel _missionTitle; //Field offset: 0xC
	private UILabel _missionTextDescription; //Field offset: 0x10
	private GameObject _missionIconsDescriptionParent; //Field offset: 0x14
	private UISprite _cellBackground; //Field offset: 0x18
	private AwardCollectibleHelper _mainGoalElementsHelper; //Field offset: 0x1C
	private UISprite _mysteryBoxIcon; //Field offset: 0x20
	private AwardCollectibleHelper[] _goalIcons; //Field offset: 0x24
	private string[] _mysteryBoxIconNames; //Field offset: 0x28
	private Award _currentAward; //Field offset: 0x2C

	private static AwardFinishedCellHelper() { }

	public AwardFinishedCellHelper() { }

	private string FindBackgroundToUse(bool mainGoalIcon) { }

	public void InitCell(Award award) { }

	private void SetupCellColors() { }

	private void SetupCellContent() { }

	private void SetupCellStructure() { }

}

