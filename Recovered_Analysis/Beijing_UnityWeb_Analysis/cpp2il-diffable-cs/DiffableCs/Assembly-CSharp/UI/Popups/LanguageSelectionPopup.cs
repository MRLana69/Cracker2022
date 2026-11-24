namespace UI.Popups;

public class LanguageSelectionPopup : UIScreen
{
	private class LanguageListAdapter
	{
		private GameObject _languageCell; //Field offset: 0x10
		private LanguageSelectionPopup _languagePopup; //Field offset: 0x14

		public LanguageListAdapter(List<Locale> list, GameObject cell, LanguageSelectionPopup popup) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

	}

	private LanguageListAdapter _adapter; //Field offset: 0x28
	private GameObject _languageCell; //Field offset: 0x2C
	private ScrollView _languageListView; //Field offset: 0x30
	private UILabel _popupSubtitle; //Field offset: 0x34
	private UILabel _popupTitle; //Field offset: 0x38

	public LanguageSelectionPopup() { }

	public override void GainFocus() { }

	public override void Init() { }

	public override void LoseFocus() { }

	private void OnClickContainer(GameObject go) { }

	private void SetBackButtonEnabledState(bool state) { }

	public override void Show() { }

	private void UpdateLabels() { }

}

