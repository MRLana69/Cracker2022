namespace UI.ScrollListSelectPopup;

public class ScrollListSelectPopup : UIScreen
{
	private class ScrollListSelectAdapter
	{
		private const int DEBUGSETTINGS_TOGGLE_PREFAB = 0; //Field offset: 0x0
		private const int DEBUGSETTINGS_BUTTON_PREFAB = 1; //Field offset: 0x0
		private const int DEBUGSETTINGS_SPACE_PREFAB = 2; //Field offset: 0x0
		private ScrollListSelectPopup _scrollListSettingsPopup; //Field offset: 0x10
		private GameObject _scrollListTogglePrefab; //Field offset: 0x14
		private GameObject _scrollListSpacePrefab; //Field offset: 0x18

		public ScrollListSelectAdapter(List<ScrollListPopupCell> contentList, GameObject scrollListTogglePrefab, GameObject scrollListSpacePrefab, ScrollListSelectPopup screenReference) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass) { }

		public override int GetModelType(int index) { }

	}

	private const int POPUP_MINIMUM_HEIGHT = 58; //Field offset: 0x0
	private const int POPUP_MAXIMUM_HEIGHT = 400; //Field offset: 0x0
	private const int CELL_HEIGHT_WITH_SPACE = 34; //Field offset: 0x0
	private const int FRAME_OFFSET = 13; //Field offset: 0x0
	private static ScrollListSelectPopup _instance; //Field offset: 0x0
	private GameObject ScrollListTogglePrefab; //Field offset: 0x28
	private GameObject ScrollListSpacePrefab; //Field offset: 0x2C
	private UISprite _popupBackground; //Field offset: 0x30
	private UISprite _popupFrame; //Field offset: 0x34
	private List<ScrollListPopupCell> _contentList; //Field offset: 0x38
	private ScrollListSelectAdapter _adapter; //Field offset: 0x3C
	private ScrollView _scrollView; //Field offset: 0x40
	private Dictionary<string, string> items; //Field offset: 0x44
	private Dictionary<string, bool> indicators; //Field offset: 0x48
	private bool multiSelect; //Field offset: 0x4C
	private Action<Dictionary<string, string>> callBack; //Field offset: 0x50

	public static ScrollListSelectPopup instance
	{
		 get { } //Length: 268
	}

	public ScrollListSelectPopup() { }

	private void AdjustPopupSize() { }

	public static ScrollListSelectPopup get_instance() { }

	public List<string> getSelected() { }

	public override void Hide() { }

	public override void Init() { }

	public void Initialize(Dictionary<string, string> items, Action<Dictionary<string, string>> callback, List<string> selectedItems = null, bool multiSelect = false) { }

	private void InsertSpace() { }

	private void InsertToggle(string title, string id) { }

	private void OnClickContainer(GameObject go) { }

	private void RefreshScrollList() { }

	private void ResetList() { }

	private void SelectItem(string key) { }

	private void SendCallBack() { }

	private void SetContentList(Dictionary<string, string> items) { }

	public override void Show() { }

}

