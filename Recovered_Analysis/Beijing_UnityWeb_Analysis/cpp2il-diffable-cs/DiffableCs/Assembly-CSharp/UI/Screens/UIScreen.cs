namespace UI.Screens;

public class UIScreen : MonoBehaviour
{
	public bool showOldFooterSection; //Field offset: 0xC
	protected GameObject _footerPrefab; //Field offset: 0x10
	protected int _selectedFooterButton; //Field offset: 0x14
	protected UIFooterHandler _footerHandler; //Field offset: 0x18
	private bool _footerInited; //Field offset: 0x1C
	private bool _isActive; //Field offset: 0x1D
	public string screenName; //Field offset: 0x20
	private string <parentScreen>k__BackingField; //Field offset: 0x24

	public bool isActive
	{
		 get { } //Length: 231
	}

	public string parentScreen
	{
		protected get { } //Length: 9
		 set { } //Length: 9
	}

	public UIScreen() { }

	public virtual void AdjustToResolution() { }

	public virtual bool BlocksCelebrationPopup() { }

	public virtual void GainFocus() { }

	public bool get_isActive() { }

	protected string get_parentScreen() { }

	protected virtual string GetFlurryName() { }

	public virtual void Hide() { }

	public void HideIfActive() { }

	public virtual void Init() { }

	private void InitFooter() { }

	protected GameObject InitializeCoinbox(UIWidget widgetAnchor, bool fundsEnabled, bool coinsEnabled, bool keysEnabled, float xOffset = 0, float yOffset = 0, float zOffset = 0) { }

	public static bool IsScreenHeightOutOfProportion() { }

	public virtual void LoseFocus() { }

	public void set_parentScreen(string value) { }

	public virtual void Show() { }

	public void ShowIfInactive() { }

}

