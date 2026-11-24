namespace UI.Screens;

public class ChallengesScreen : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <LoadFooter>b__17_0() { }

	}

	private sealed class <>c__DisplayClass17_0
	{
		public int pageIndex; //Field offset: 0x8
		public ChallengesScreen <>4__this; //Field offset: 0xC

		public <>c__DisplayClass17_0() { }

		internal void <LoadFooter>b__1() { }

	}

	public enum PageIndex
	{
		DailyChallengePage = 0,
		MissionsPage = 1,
		WeeklyHuntPage = 2,
	}

	private static int _currentlySelectedPageIndex; //Field offset: 0x0
	private UIWidget _footerGuideWidget; //Field offset: 0x28
	private UIWidget _pageGuideWidget; //Field offset: 0x2C
	private Layout _footerLayout; //Field offset: 0x30
	private FooterButton _footerButtonPrefab; //Field offset: 0x34
	private Page[] _pagePrefabs; //Field offset: 0x38
	private Page[] _pages; //Field offset: 0x3C
	private FooterButton[] _footerButtons; //Field offset: 0x40

	private static ChallengesScreen() { }

	public ChallengesScreen() { }

	private void ActivatePage(int pageIndex, bool calledFromFooterButton) { }

	public override bool BlocksCelebrationPopup() { }

	private void ChangePage(int index, bool calledFromFooterButton = false) { }

	private string GetButtonName(PageIndex pageIndex) { }

	protected override string GetFlurryName() { }

	public static int GetPageIndex() { }

	public override void Hide() { }

	public override void Init() { }

	private void LoadFooter() { }

	private void SelectFooterButton(int selectIndex) { }

	public static void SetPageIndex(int newIndex) { }

	public override void Show() { }

}

