//Type is in global namespace

public class CharacterOwnageDebugCellHelper : MonoBehaviour
{
	private UILabel _title; //Field offset: 0xC
	private UILabel _description; //Field offset: 0x10
	private GameObject _offIcon; //Field offset: 0x14
	private GameObject _onIcon; //Field offset: 0x18
	private bool _currentIconState; //Field offset: 0x1C
	private KeyValuePair<CharacterId, Model> _character; //Field offset: 0x20

	public CharacterOwnageDebugCellHelper() { }

	public void Init(KeyValuePair<CharacterId, Model> character) { }

	public void ToggleActive() { }

}

