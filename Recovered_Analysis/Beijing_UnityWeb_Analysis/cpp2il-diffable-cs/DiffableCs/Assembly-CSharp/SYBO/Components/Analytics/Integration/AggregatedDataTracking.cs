namespace SYBO.Components.Analytics.Integration;

public class AggregatedDataTracking
{
	public enum DataCompleteness
	{
		Undefined = 0,
		Full = 1,
		Partial = 2,
		None = 3,
	}

	public class DataContainer
	{
		public int KeysReceived; //Field offset: 0x8
		public int CoinsReceived; //Field offset: 0xC
		public int LastDayPlayed; //Field offset: 0x10
		public int UniqueDaysPlayed; //Field offset: 0x14
		public int SessionCount; //Field offset: 0x18
		public int MissingKeysCount; //Field offset: 0x1C
		public int MissingCoinsCount; //Field offset: 0x20
		private List<UnsampledPurchaseData> _unsampledPurchases; //Field offset: 0x24
		private DataCompleteness _dataCompleteness; //Field offset: 0x28

		public DataCompleteness DataCompleteness
		{
			 get { } //Length: 85
		}

		public List<UnsampledPurchaseData> UnsampledPurchases
		{
			 get { } //Length: 6
		}

		public DataContainer(DataCompleteness dataCompleteness, int initialKeysAmount = 0) { }

		public void AddUnsampledPurchase(string itemTitleId) { }

		public static DataContainer Deserialize(string dataString) { }

		public DataCompleteness get_DataCompleteness() { }

		public List<UnsampledPurchaseData> get_UnsampledPurchases() { }

		public static string Serialize(DataContainer dataContainer) { }

	}

	public class UnsampledPurchaseData
	{
		public string ItemTitleId; //Field offset: 0x8
		public int Count; //Field offset: 0xC

		public UnsampledPurchaseData() { }

	}

	private const int MaxDaysInYear = 366; //Field offset: 0x0
	private bool _initialized; //Field offset: 0xF
	private bool _stoppedTracking; //Field offset: 0x10
	private DataContainer _dataContainer; //Field offset: 0x14
	private int _currentKeysAmount; //Field offset: 0x18
	private int _currentCoinsAmount; //Field offset: 0x1C
	private SessionTracker _sessionTracker; //Field offset: 0x20

	public AggregatedDataTracking() { }

	private void CheckForNewUniqueDay() { }

	private int ConvertDateTimeToDay(DateTime dateTime) { }

	private void IncrementSession() { }

	public void Initialize(bool hadUserInPlayerInfo, int sessionTimeoutSeconds) { }

	private void Load(bool hadUserInPlayerInfo) { }

	private void OnApplicationFocus(bool focusStatus) { }

	private void PlayerInfo_OnCoinsChanged() { }

	private void PlayerInfo_OnKeysChanged() { }

	private void PurchaseHandler_OnIngameCurrencyPurchaseCompleted(object sender, SyboInGameCurrencyPurchaseEventArgs e) { }

	private void Save() { }

	public void StopAggregatedDataTracking() { }

	private void UIScreenController_OnAwake() { }

	private void UIScreenController_OnPopupShown(string screenName) { }

}

