namespace Kiloo.Common.Ads;

public class PriorityList
{
	private sealed class <>c__DisplayClass29_0
	{
		public int maxPriority; //Field offset: 0x8
		public PriorityList <>4__this; //Field offset: 0xC

		public <>c__DisplayClass29_0() { }

		internal bool <get_reachedLastProvider>b__0(AdProviderInfo p) { }

	}

	private int _numberOfFails; //Field offset: 0x8
	private int _numberOfImpressions; //Field offset: 0xC
	private int _currentPriority; //Field offset: 0x10
	private DateTime _timeOfProviderChange; //Field offset: 0x18
	private readonly List<string> _exhaustedProviders; //Field offset: 0x20
	private IList<AdProviderInfo> _priorityList; //Field offset: 0x24
	private IAdSettingsProvider _settings; //Field offset: 0x28
	private AdType _adType; //Field offset: 0x2C
	private string _waterfallID; //Field offset: 0x30
	private string <currentProvider>k__BackingField; //Field offset: 0x34
	private Action changedProvider; //Field offset: 0x38
	private Action resetToTop; //Field offset: 0x3C
	private bool <wrapped>k__BackingField; //Field offset: 0x40

	public event Action changedProvider
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public event Action resetToTop
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public string currentProvider
	{
		 get { } //Length: 264
		private set { } //Length: 11
	}

	public bool hasProviders
	{
		 get { } //Length: 12
	}

	private int maxPriorityInList
	{
		 get { } //Length: 68
	}

	public bool reachedLastProvider
	{
		 get { } //Length: 405
	}

	public bool wrapped
	{
		 get { } //Length: 6
		 set { } //Length: 111
	}

	public PriorityList(string waterfallID, AdType adType, IAdSettingsProvider settings) { }

	private bool <ChangeToNextProvider>b__35_0(AdProviderInfo p) { }

	private bool <ChangeToNextProvider>b__35_1(AdProviderInfo p) { }

	private bool <ResetToTop>b__36_0(AdProviderInfo p) { }

	public void add_changedProvider(Action value) { }

	public void add_resetToTop(Action value) { }

	public void ChangeToNextProvider() { }

	public void CheckIfProviderExpired() { }

	private void ChooseProvider(IList<AdProviderInfo> possibleProviders) { }

	private void ClearExhaustedProviders() { }

	public string get_currentProvider() { }

	public bool get_hasProviders() { }

	private int get_maxPriorityInList() { }

	public bool get_reachedLastProvider() { }

	public bool get_wrapped() { }

	public bool IncrementNumberOfFails() { }

	public void IncrementNumberOfImpressions() { }

	private void MarkCurrentProviderAsExhausted() { }

	public void remove_changedProvider(Action value) { }

	public void remove_resetToTop(Action value) { }

	public void ResetToTop() { }

	private void set_currentProvider(string value) { }

	public void set_wrapped(bool value) { }

}

