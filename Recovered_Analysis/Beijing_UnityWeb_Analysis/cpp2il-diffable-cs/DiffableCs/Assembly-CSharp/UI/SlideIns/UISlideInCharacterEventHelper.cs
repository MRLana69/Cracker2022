namespace UI.SlideIns;

public class UISlideInCharacterEventHelper : UISlideIn
{
	private UILabel _textLabel; //Field offset: 0x3C
	private UILabel _shadowLabel; //Field offset: 0x40
	private Layout _layout; //Field offset: 0x44
	private string _myColorActive; //Field offset: 0x48
	private string _myColorInactive; //Field offset: 0x4C
	private string _shadowColorActive; //Field offset: 0x50
	private string _shadowColorInactive; //Field offset: 0x54

	public UISlideInCharacterEventHelper() { }

	private void Awake() { }

	private bool IsFilteredCharacter(char newChar) { }

	public override void SetupSlideIn(SlideIn slideIn) { }

	private void StoreColors() { }

	private void UpdateCharacterEventWord(int letterMask, string extraInfo) { }

}

