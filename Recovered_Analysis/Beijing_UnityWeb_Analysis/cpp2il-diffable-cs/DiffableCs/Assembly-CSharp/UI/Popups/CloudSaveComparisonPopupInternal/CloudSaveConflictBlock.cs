namespace UI.Popups.CloudSaveComparisonPopupInternal;

public class CloudSaveConflictBlock : MonoBehaviour
{
	public class ConflictBlockPayload
	{
		public string buttonText; //Field offset: 0x8
		public string topSpriteName; //Field offset: 0xC
		public bool isImprovement; //Field offset: 0x10
		public List<CloudSaveProgressCellPayload> cellPayloads; //Field offset: 0x14
		public Action onButtonClicked; //Field offset: 0x18

		public ConflictBlockPayload() { }

		public void OnButtonClicked() { }

	}

	private CloudSaveProgressCell _cellPrefab; //Field offset: 0xC
	private UISprite _banner; //Field offset: 0x10
	private FitSpriteToWidget _topIconFitter; //Field offset: 0x14
	private UISprite _topIcon; //Field offset: 0x18
	private UILabel _bannerTopLabel; //Field offset: 0x1C
	private UILabel _bannerBottomLabel; //Field offset: 0x20
	private UILabel _buttonLabel; //Field offset: 0x24
	private Layout _cellLayout; //Field offset: 0x28
	private ConflictBlockPayload _payload; //Field offset: 0x2C

	public CloudSaveConflictBlock() { }

	public void ButtonClicked() { }

	public void Setup(ConflictBlockPayload payload) { }

	private void SetupBasic() { }

}

