namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListContentElementAdapter
{
	private readonly GameObject _ageCellPrefab; //Field offset: 0x10
	private readonly ScrollView _scrollView; //Field offset: 0x14
	private readonly CenterOnChild _centerOnChild; //Field offset: 0x18
	private readonly string _initialContent; //Field offset: 0x1C

	public ListContentElementAdapter(List<ListContentElement> list, GameObject ageCell, ScrollView scrollView, CenterOnChild centerOnChild, string initialContent) { }

	public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

}

