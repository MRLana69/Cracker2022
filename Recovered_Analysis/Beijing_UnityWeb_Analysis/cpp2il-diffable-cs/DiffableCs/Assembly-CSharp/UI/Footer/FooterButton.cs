namespace UI.Footer;

public class FooterButton : MonoBehaviour
{
	public class FooterPayload
	{
		public Action clicked; //Field offset: 0x8
		public string iconName; //Field offset: 0xC
		public ButtonColorScheme colorScheme; //Field offset: 0x10
		public int width; //Field offset: 0x30
		public string title; //Field offset: 0x34
		public BreadcrumbEvent[] breadcrumbEvents; //Field offset: 0x38
		public Vector3 iconOffset; //Field offset: 0x3C

		public FooterPayload() { }

	}

	private UIWidget _baseWidget; //Field offset: 0xC
	private Collider _collider; //Field offset: 0x10
	private UISprite _fill; //Field offset: 0x14
	private UISprite _overlay; //Field offset: 0x18
	private UISprite _icon; //Field offset: 0x1C
	private UILabel _title; //Field offset: 0x20
	private Breadcrumb _breadcrumb; //Field offset: 0x24
	private FooterPayload _payload; //Field offset: 0x28

	public FooterButton() { }

	public void Init(FooterPayload payload) { }

	public void OnClick() { }

	private void OnPress(bool pressed) { }

	public void SetSelectedState(bool selected) { }

}

