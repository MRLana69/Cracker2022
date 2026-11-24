//Type is in global namespace

public class CelebrationTesterPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<HoverboardTheme, string> <>9__25_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <BoardSelected>b__25_0(HoverboardTheme x) { }

	}

	private static CelebrationReward _currentCelebrationReward; //Field offset: 0x0
	private SelectPopupButton _originPopupButton; //Field offset: 0x28
	private SelectPopupButton _typePopupButton; //Field offset: 0x2C
	private SelectPopupButton _powerupPopupButton; //Field offset: 0x30
	private SelectPopupButton _charPopupButton; //Field offset: 0x34
	private SelectPopupButton _boardPopupButton; //Field offset: 0x38
	private SelectPopupButton _trophyPopupButton; //Field offset: 0x3C
	private SelectPopupButton _awardPopupButton; //Field offset: 0x40
	private SelectPopupButton _amountPopupButton; //Field offset: 0x44
	private SelectPopupButton _topRunRankPopupButton; //Field offset: 0x48
	private SelectPopupButton _themesPopupButton; //Field offset: 0x4C
	private UILabel buttonLabel; //Field offset: 0x50
	private GameObject charButton; //Field offset: 0x54
	private GameObject boardsButton; //Field offset: 0x58
	private GameObject powerupButtons; //Field offset: 0x5C
	private GameObject trrankButton; //Field offset: 0x60
	private GameObject awardButton; //Field offset: 0x64
	private GameObject trophyButton; //Field offset: 0x68
	private GameObject themesButton; //Field offset: 0x6C
	private UITable buttonTable; //Field offset: 0x70

	private static CelebrationTesterPopup() { }

	public CelebrationTesterPopup() { }

	public void AwardSelected() { }

	public void BoardSelected() { }

	public void CharSelected() { }

	public void NewAmountSelected() { }

	public void NewRankSelected() { }

	public void NewThemesSelected() { }

	public void OldTrophySelected() { }

	public void OriginSelected() { }

	public void PowerupSelected() { }

	public static void RewardDebugCelebrationReward() { }

	private void Start() { }

	public void ToggleDebugCelebration() { }

	public void TypeSelected() { }

}

