namespace UI.Popups;

public class ABTestTesterPopup : UIScreen
{
	private class ABTestTesterListAdapter
	{
		private GameObject _cellPrefab; //Field offset: 0x10

		public ABTestTesterListAdapter(List<ABTestDataItem> identifiers, GameObject cell) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

	}

	private GameObject _cellPrefab; //Field offset: 0x28
	private ScrollView _scrollView; //Field offset: 0x2C
	private GameObject _initializationInfo; //Field offset: 0x30
	private ABTestTesterListAdapter _adapter; //Field offset: 0x34

	public ABTestTesterPopup() { }

	public override void Init() { }

	public override void Show() { }

}

