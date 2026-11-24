namespace UI.Screens.CharacterScreenInternal;

public class CharacterThemeButton : MonoBehaviour
{
	private UISprite _background; //Field offset: 0xC
	private UISprite _icon; //Field offset: 0x10
	private GameObject _giftBubble; //Field offset: 0x14
	private GameObject _newBubble; //Field offset: 0x18
	private GameObject _lockIcon; //Field offset: 0x1C
	private int <themeIndex>k__BackingField; //Field offset: 0x20
	private Action<int> OnPress; //Field offset: 0x24

	public event Action<int> OnPress
	{
		 add { } //Length: 8
		 remove { } //Length: 111
	}

	public int themeIndex
	{
		 get { } //Length: 6
		private set { } //Length: 245
	}

	public CharacterThemeButton() { }

	public void add_OnPress(Action<int> value) { }

	public void ButtonPressed() { }

	public int get_themeIndex() { }

	public void remove_OnPress(Action<int> value) { }

	private void set_themeIndex(int value) { }

	public void SetActiveBubbles(bool enableGiftBuble, bool enableNewBuble) { }

	public void SetLockIconEnabled(bool state) { }

	public void SetOutfitColors(Color32 bgColor, Color32 iconColor, int index) { }

}

