namespace UI.Popups.ABTestTesterPopupInternal;

public class ABTestTesterCellHelper : MonoBehaviour
{
	private UILabel _title; //Field offset: 0xC
	private UILabel _description; //Field offset: 0x10
	private SelectPopupButton _selectPayloadButton; //Field offset: 0x14
	private UILabel _selectPayloadText; //Field offset: 0x18
	private GameObject _offIcon; //Field offset: 0x1C
	private GameObject _onIcon; //Field offset: 0x20
	private bool _currentIconState; //Field offset: 0x24
	private ABTestDataItem _testDataItem; //Field offset: 0x28

	public ABTestTesterCellHelper() { }

	public void Init(ABTestDataItem testDataItem) { }

	public void PayloadSelected() { }

	public void ToggleActive() { }

}

