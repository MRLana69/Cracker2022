namespace UI.Popups.SettingsPopupInternal;

public class SettingsButton : MonoBehaviour
{
	public class SettingsButtonPayload
	{
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<bool> <>9__10_0; //Field offset: 0x4

			private static <>c() { }

			public <>c() { }

			internal bool <.ctor>b__10_0() { }

		}

		public Action<UILabel> setTitle; //Field offset: 0x8
		public Action<UILabel> setDescription; //Field offset: 0xC
		public string descriptionID; //Field offset: 0x10
		public Action onClick; //Field offset: 0x14
		public Action<GameObject> setOfflineIndicator; //Field offset: 0x18
		public string iconName; //Field offset: 0x1C
		public Vector3 iconOffset; //Field offset: 0x20
		public BreadcrumbEvent[] breadcrumbEvents; //Field offset: 0x2C
		public Func<bool> shouldDisable; //Field offset: 0x30
		public Action<UISprite> setIcon; //Field offset: 0x34

		public SettingsButtonPayload() { }

	}

	private UISprite _icon; //Field offset: 0xC
	private UISprite _offIndicatorIcon; //Field offset: 0x10
	private UILabel _title; //Field offset: 0x14
	private UILabel _description; //Field offset: 0x18
	private Layout _layout; //Field offset: 0x1C
	private Breadcrumb _breadcrumb; //Field offset: 0x20
	private UISprite _disableOverlay; //Field offset: 0x24
	private Collider _buttonCollider; //Field offset: 0x28
	private SettingsButtonPayload _payload; //Field offset: 0x2C

	private bool buttonDisabled
	{
		 get { } //Length: 112
		 set { } //Length: 535
	}

	public SettingsButton() { }

	private bool get_buttonDisabled() { }

	public void InitButton(SettingsButtonPayload payload) { }

	public void OnClick() { }

	private void OnEnable() { }

	private void set_buttonDisabled(bool value) { }

	private void SetupButton() { }

}

