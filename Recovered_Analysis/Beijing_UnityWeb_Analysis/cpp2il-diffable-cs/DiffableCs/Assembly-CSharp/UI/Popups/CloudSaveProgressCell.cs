namespace UI.Popups;

public class CloudSaveProgressCell : MonoBehaviour
{
	public class CloudSaveProgressCellPayload
	{
		public string iconName; //Field offset: 0x8
		public string text; //Field offset: 0xC
		public bool isImprovement; //Field offset: 0x10
		public bool showBackground; //Field offset: 0x11
		public int backgroundWidth; //Field offset: 0x14
		public int contentLeftOffset; //Field offset: 0x18
		public int backgroundHeight; //Field offset: 0x1C

		public CloudSaveProgressCellPayload() { }

	}

	private UISprite _background; //Field offset: 0xC
	private UISprite _icon; //Field offset: 0x10
	private UISprite _improvementIcon; //Field offset: 0x14
	private UILabel _label; //Field offset: 0x18
	private Layout _contentLayout; //Field offset: 0x1C
	private FitSpriteToWidget _iconFitter; //Field offset: 0x20

	public CloudSaveProgressCell() { }

	private void SetAsAwards() { }

	private void SetAsBoards() { }

	private void SetAsBoardThemes() { }

	private void SetAsCharacters() { }

	private void SetAsHighscore() { }

	private void SetAsKeys() { }

	private void SetAsLastModifiedTime() { }

	private void SetAsMultiplier() { }

	private void SetAsOutfits() { }

	private void SetAsUpgrades() { }

	public void SetupCell(CloudSaveProgressCellPayload payload) { }

}

