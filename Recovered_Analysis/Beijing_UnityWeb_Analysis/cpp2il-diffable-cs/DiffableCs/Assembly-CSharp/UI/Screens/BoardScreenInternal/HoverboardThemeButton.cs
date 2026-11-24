namespace UI.Screens.BoardScreenInternal;

public class HoverboardThemeButton : MonoBehaviour
{
	public delegate OnPressEvent
	{

		public OnPressEvent(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int index, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int index) { }

	}

	public enum ThemeState
	{
		NotOwned = 0,
		OwnedAndInactive = 1,
		OwnedAndActive = 2,
		NotPurchaseable = 3,
	}

	private UISprite _background; //Field offset: 0xC
	private UISprite _icon; //Field offset: 0x10
	private GameObject giftBuble; //Field offset: 0x14
	private GameObject newBuble; //Field offset: 0x18
	private GameObject selectedCircle; //Field offset: 0x1C
	private GameObject ownedCircle; //Field offset: 0x20
	private GameObject _lockIcon; //Field offset: 0x24
	private ThemeIdentifier _identifier; //Field offset: 0x28
	private int <themeIndex>k__BackingField; //Field offset: 0x2C
	private OnPressEvent OnPress; //Field offset: 0x30

	public event OnPressEvent OnPress
	{
		 add { } //Length: 8
		 remove { } //Length: 111
	}

	public int themeIndex
	{
		 get { } //Length: 6
		private set { } //Length: 246
	}

	public HoverboardThemeButton() { }

	public void add_OnPress(OnPressEvent value) { }

	public void ButtonPressed() { }

	public int get_themeIndex() { }

	public void InitButton(string iconName, Color32 bgColor, Color32 iconColor, int index) { }

	public void remove_OnPress(OnPressEvent value) { }

	private void set_themeIndex(int value) { }

	public void SetActiveBubbles(bool enableGiftBuble, bool enableNewBuble) { }

	public void SetCurrentState(ThemeState newState) { }

}

