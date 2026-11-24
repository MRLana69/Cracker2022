//Type is in global namespace

public class CharacterOwnagePopup : UIScreen
{
	private class CharacterOwnageListAdapter
	{
		private GameObject _cellPrefab; //Field offset: 0x10

		public CharacterOwnageListAdapter(List<KeyValuePair<CharacterId, Model>> items, GameObject cell) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

	}

	private GameObject _cellPrefab; //Field offset: 0x28
	private ScrollView _scrollView; //Field offset: 0x2C
	private CharacterOwnageListAdapter _adapter; //Field offset: 0x30
	private bool _showAllCharacters; //Field offset: 0x34
	private GameObject _offIcon; //Field offset: 0x38
	private GameObject _onIcon; //Field offset: 0x3C
	private List<KeyValuePair<CharacterId, Model>> _list; //Field offset: 0x40

	public CharacterOwnagePopup() { }

	public override void Init() { }

	public override void Show() { }

	public void ToggleActive() { }

}

