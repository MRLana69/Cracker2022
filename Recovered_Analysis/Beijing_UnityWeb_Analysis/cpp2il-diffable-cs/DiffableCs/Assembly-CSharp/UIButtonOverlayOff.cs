//Type is in global namespace

public class UIButtonOverlayOff : MonoBehaviour
{
	public enum ButtonType
	{
		Custom = 0,
		Primary = 1,
		Secondary = 2,
		Tertiary = 3,
		Facebook = 4,
		Footer_back = 8,
		Footer_me = 9,
		Footer_friends = 10,
		Footer_shop = 11,
		Seasonal = 12,
		SocialGrey = 13,
		Exit = 17,
	}

	public GameObject fillWithPrimeColor; //Field offset: 0xC
	private Color _originalFillColor; //Field offset: 0x10
	private UIWidget _fillSprite; //Field offset: 0x20
	private UISprite _overlay; //Field offset: 0x24
	private bool _initDone; //Field offset: 0x28
	private bool _buttonStateLocked; //Field offset: 0x29
	public ButtonType buttonType; //Field offset: 0x2C
	private ButtonColorScheme _buttonColorScheme; //Field offset: 0x30

	public UIButtonOverlayOff() { }

	private void ApplyDefaultColors() { }

	private void Awake() { }

	public void ButtonPressed(bool isPressed) { }

	public void GoToNormalState() { }

	public void GoToNotAvailableState() { }

	public void GoToSelectedState() { }

	private void Init() { }

	public void LockState(bool locked) { }

	private void OnDisable() { }

	public virtual void OnPress(bool isPressed) { }

	public void SetButtonType(ButtonType type) { }

}

