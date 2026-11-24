//Type is in global namespace

public class CountryPopup : UIScreen
{
	private sealed class <DelayedSelect>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CountryPopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 79
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedSelect>d__11(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class CountryListAdapter
	{
		private GameObject _countryCell; //Field offset: 0x10
		private CountryPopup _countryPopup; //Field offset: 0x14

		public CountryListAdapter(List<Country> countryList, GameObject cell, CountryPopup popup) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

	}

	private ScrollView countryListView; //Field offset: 0x28
	private GameObject countryCell; //Field offset: 0x2C
	private UILabel popupTitle; //Field offset: 0x30
	private UISprite currentCountryFlag; //Field offset: 0x34
	private UILabel currentCountryName; //Field offset: 0x38
	private UILabel infoText; //Field offset: 0x3C
	private HorizontalLayout currentCountryLayout; //Field offset: 0x40
	private CountryListAdapter _adapter; //Field offset: 0x44
	private bool _firstShow; //Field offset: 0x48

	public CountryPopup() { }

	private IEnumerator DelayedSelect() { }

	public override void Hide() { }

	public override void Init() { }

	private void OnClickContainer(GameObject go) { }

	private void SelectCurrentCountry() { }

	public override void Show() { }

	private void TournamentChanged(object sender, TournamentChangedEventArgs eventArg) { }

	private void UpdatePopupUI() { }

}

