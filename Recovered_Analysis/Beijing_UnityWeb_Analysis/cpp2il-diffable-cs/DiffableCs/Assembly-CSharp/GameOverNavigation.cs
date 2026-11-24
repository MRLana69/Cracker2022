//Type is in global namespace

public class GameOverNavigation : MonoBehaviour
{
	public GameOverTabHelper tabs; //Field offset: 0xC
	public List<UIButtonOverlayOff> buttons; //Field offset: 0x10
	private List<ButtonDisabler> _buttonDisablers; //Field offset: 0x14
	private List<UITexture> _buttonHighlight; //Field offset: 0x18
	private int _selectedButton; //Field offset: 0x1C
	private bool adseen; //Field offset: 0x20

	public GameOverNavigation() { }

	private void Init() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

