namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListElementHelper : MonoBehaviour
{
	private const int threshold = 50; //Field offset: 0x0
	private UILabel _label; //Field offset: 0xC
	private Color _defaultColor; //Field offset: 0x10
	private Color _selectedColor; //Field offset: 0x20
	private ListContentElement _listContentElement; //Field offset: 0x30
	private ListContentElementReferences _references; //Field offset: 0x34
	private UIPanel _scrollViewPanel; //Field offset: 0x38

	public ListContentElement listContentElement
	{
		 get { } //Length: 6
	}

	public ListElementHelper() { }

	public ListContentElement get_listContentElement() { }

	public void InitCell(ListContentElement lce, ListContentElementReferences references) { }

	private void OnClick() { }

	private void Update() { }

}

