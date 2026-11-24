namespace UI.Screens.CoinScreenInternal;

public class CoinContainer : MonoBehaviour
{
	private const float SPECIAL_SALE_ELEMENTS_OFFSET = -150; //Field offset: 0x0
	private const float DEFAULT_OFFSET_FOR_ELEMENTS_ON_DISPLAY_VALUE = -59.5; //Field offset: 0x0
	public float offsetForElementsOnDisplay; //Field offset: 0xC
	private UITable _table; //Field offset: 0x10
	private int <counterForElementsOnDisplay>k__BackingField; //Field offset: 0x14
	private Action onTableRepostioned; //Field offset: 0x18

	public event Action onTableRepostioned
	{
		 add { } //Length: 8
		 remove { } //Length: 111
	}

	public int counterForElementsOnDisplay
	{
		 get { } //Length: 109
		 set { } //Length: 3844
	}

	public CoinContainer() { }

	public void ActivateSpecialSale() { }

	public void add_onTableRepostioned(Action value) { }

	public GameObject AddChildGo(GameObject go) { }

	public GameObject AddChildPrefab(GameObject prefab) { }

	public int get_counterForElementsOnDisplay() { }

	private void OnTableReposition() { }

	public void remove_onTableRepostioned(Action value) { }

	public void RepositionTable() { }

	public void RepositionTableNow() { }

	public void Reset() { }

	public void set_counterForElementsOnDisplay(int value) { }

	private void Start() { }

	public void UseDefaultOffsetForElementsOnDisplay() { }

}

