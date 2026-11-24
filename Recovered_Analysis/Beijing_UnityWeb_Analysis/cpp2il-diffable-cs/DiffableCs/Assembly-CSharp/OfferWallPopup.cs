//Type is in global namespace

public class OfferWallPopup : UIScreen
{
	private class OfferListAdapter
	{
		private const int OFFER_TITLE_PREFAB = 0; //Field offset: 0x0
		private const int OFFER_CELL_PREFAB = 1; //Field offset: 0x0
		private GameObject _offerPrefab; //Field offset: 0x10
		private GameObject _titlePrefab; //Field offset: 0x14
		private Action _onClick; //Field offset: 0x18

		public OfferListAdapter(List<OfferWallCell> awardList, GameObject offerCell, GameObject titleCell, Action onClick) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

		public override int GetModelType(int index) { }

	}

	private GameObject coinEarnerPrefab; //Field offset: 0x28
	public Font headerFont; //Field offset: 0x2C
	private GameObject _contentAnchor; //Field offset: 0x30
	private UIWidget _outline; //Field offset: 0x34
	private GameObject listTitleComponent; //Field offset: 0x38
	private ScrollView _contentListView; //Field offset: 0x3C
	private UIPanel _scrollPanel; //Field offset: 0x40
	private UIPanel _scrollBarPanel; //Field offset: 0x44
	private GameObject _noOffersLabel; //Field offset: 0x48
	private List<OfferWallCell> _contentList; //Field offset: 0x4C
	private OfferListAdapter _adapter; //Field offset: 0x50

	public OfferWallPopup() { }

	public override void Hide() { }

	public override void Init() { }

	private void Log(string msg) { }

	private void OfferClicked() { }

	private void OnApplicationPause(bool pause) { }

	private void RequestForOffersFailed() { }

	private void RewardsNotRecieved() { }

	private void RewardsRecieved(int i) { }

	private void SetListContent() { }

	public override void Show() { }

	public void UpdatePopupList() { }

}

