namespace UI.Popups;

public class CloudSavePromotionPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CloudSaveComparisonRow, bool> <>9__14_0; //Field offset: 0x4
		public static Action <>9__16_2; //Field offset: 0x8
		public static Action <>9__16_0; //Field offset: 0xC
		public static Action <>9__16_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <ButtonClicked>b__16_0() { }

		internal void <ButtonClicked>b__16_1() { }

		internal void <ButtonClicked>b__16_2() { }

		internal bool <SetupConflict>b__14_0(CloudSaveComparisonRow r) { }

	}

	private const float SLIDEIN_DELAY = 0.5; //Field offset: 0x0
	private CloudSaveProgressCell _cellPrefab; //Field offset: 0x28
	private Layout _cellLayout; //Field offset: 0x2C
	private UILabel _headline; //Field offset: 0x30
	private UILabel _subline; //Field offset: 0x34
	private UILabel _bannerTopLabel; //Field offset: 0x38
	private UILabel _bannerBottomLabel; //Field offset: 0x3C
	private UILabel _subtext; //Field offset: 0x40
	private UILabel _buttonLabel; //Field offset: 0x44
	private UISprite _banner; //Field offset: 0x48
	private UITexture _skyline; //Field offset: 0x4C

	public CloudSavePromotionPopup() { }

	public void ButtonClicked() { }

	public override void Init() { }

	public void MoreInformationClicked() { }

	private void SetupBasic() { }

	private void SetupConflict() { }

	public override void Show() { }

}

