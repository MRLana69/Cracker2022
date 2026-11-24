namespace UI.Popups.LanguageSelectionPopupInternal;

public class LanguageCellController : MonoBehaviour
{
	private const string SPRITENAME_SELECTED = "icon_character_selected"; //Field offset: 0x0
	private readonly Color32 _normalTextColor; //Field offset: 0xC
	private readonly Color32 _selectedTextColor; //Field offset: 0x10
	private UILabel _languageLabel; //Field offset: 0x14
	private UISprite _statusSprite; //Field offset: 0x18
	private Locale <locale>k__BackingField; //Field offset: 0x1C

	public Locale locale
	{
		 get { } //Length: 215
		private set { } //Length: 68
	}

	public LanguageCellController() { }

	public Locale get_locale() { }

	private void set_locale(Locale value) { }

	public void UpdateContent(Locale newLocale) { }

}

