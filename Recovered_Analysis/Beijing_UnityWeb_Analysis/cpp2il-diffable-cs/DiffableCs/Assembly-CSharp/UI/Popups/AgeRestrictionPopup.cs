namespace UI.Popups;

public class AgeRestrictionPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<ListContentElement> <>9__17_0; //Field offset: 0x4
		public static Predicate<ListContentElement> <>9__17_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__17_0(ListContentElement entry) { }

		internal bool <Init>b__17_1(ListContentElement entry) { }

	}

	private sealed class <>c__DisplayClass27_0
	{
		public int currentValue; //Field offset: 0x8

		public <>c__DisplayClass27_0() { }

		internal bool <ArrowClicked>b__0(ListContentElement entry) { }

	}

	private sealed class <>c__DisplayClass35_0
	{
		public UIWidget tracker; //Field offset: 0x8
		public GameObject objectToPosition; //Field offset: 0xC
		public Vector3 positionOffset; //Field offset: 0x10
		public Vector3 newRotation; //Field offset: 0x1C
		public Vector3 newScale; //Field offset: 0x28

		public <>c__DisplayClass35_0() { }

		internal void <PositionModelOnSprite>b__0() { }

	}

	private const int YEAR_START = 1900; //Field offset: 0x0
	private const int YEAR_END = 2018; //Field offset: 0x0
	private const int INITIAL_YEAR = 2000; //Field offset: 0x0
	private const string DEFAULT_VALUE_MONTH = "----"; //Field offset: 0x0
	private const string DEFAULT_VALUE_YEAR = "----"; //Field offset: 0x0
	private GameObject _ageCellPrefab; //Field offset: 0x28
	private ScrollView _listViewMonth; //Field offset: 0x2C
	private ScrollView _listViewYear; //Field offset: 0x30
	private UIWidget _characterModelGuideWidget; //Field offset: 0x34
	private UIButtonOverlayOff _acceptButton; //Field offset: 0x38
	private UILabel _title; //Field offset: 0x3C
	private UILabel _okLabel; //Field offset: 0x40
	private List<ListContentElement> _contentListMonth; //Field offset: 0x44
	private List<ListContentElement> _contentListYear; //Field offset: 0x48
	private CenterOnChild _centerOnChildMonth; //Field offset: 0x4C
	private CenterOnChild _centerOnChildYear; //Field offset: 0x50
	private CharacterScreenController _character; //Field offset: 0x54

	public AgeRestrictionPopup() { }

	private void <Show>b__18_0(CharacterScreenController csc) { }

	public void AcceptClicked() { }

	private static void ArrowClicked(bool up, CenterOnChild centerer, List<ListContentElement> content, ScrollView listView) { }

	private List<ListContentElement> CreateContentListMonth() { }

	private List<ListContentElement> CreateContentListYear() { }

	public override void GainFocus() { }

	public override void Hide() { }

	public override void Init() { }

	private bool IsValidDateTime(int year, int month) { }

	private static void LogErr(string msg, Object obj = null) { }

	public override void LoseFocus() { }

	public void MonthArrowDownClicked() { }

	public void MonthArrowUpClicked() { }

	private void OnSelectionChanged() { }

	private static GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer) { }

	private static void PositionModelOnSprite(UIWidget tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void SetAcceptButtonActive(bool active) { }

	public override void Show() { }

	private static bool TryParseDateTime(int year, int month, out DateTime dt) { }

	public void YearArrowDownClicked() { }

	public void YearArrowUpClicked() { }

}

