//Type is in global namespace

public class CharacterScreenNavigation : MonoBehaviour
{
	public UITexture highlight; //Field offset: 0xC
	public UITexture selectOutfitHighlight; //Field offset: 0x10
	private UITexture selectButtonHighlight; //Field offset: 0x14
	private CharacterSelectButton selectButton; //Field offset: 0x18
	private int _selectedCharacter; //Field offset: 0x1C
	private CharacterScreen screen; //Field offset: 0x20
	private List<CharacterScrollListSlot> indexes; //Field offset: 0x24
	private MeFooterNavigation _meFooter; //Field offset: 0x28
	private int height; //Field offset: 0x2C

	public CharacterScreenNavigation() { }

	private bool <Update>b__11_0(CharacterScrollListSlot x) { }

	private bool <Update>b__11_1(CharacterScrollListSlot x) { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

