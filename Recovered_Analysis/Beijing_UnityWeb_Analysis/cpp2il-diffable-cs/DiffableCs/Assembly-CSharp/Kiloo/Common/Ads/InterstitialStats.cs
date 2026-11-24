namespace Kiloo.Common.Ads;

public class InterstitialStats
{
	private int <seenThisHour>k__BackingField; //Field offset: 0x8
	private int <currentHour>k__BackingField; //Field offset: 0xC
	private int <seenThisDay>k__BackingField; //Field offset: 0x10
	private int <currentDay>k__BackingField; //Field offset: 0x14
	private bool <hasSeenFirstInterstitial>k__BackingField; //Field offset: 0x18
	public Dictionary<string, string> listVersionForID; //Field offset: 0x1C

	private int actualCurrentDay
	{
		 get { } //Length: 264
	}

	private int actualCurrentHour
	{
		 get { } //Length: 9
	}

	public int currentDay
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int currentHour
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool hasSeenFirstInterstitial
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int seenThisDay
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int seenThisHour
	{
		 get { } //Length: 9
		 set { } //Length: 113
	}

	public InterstitialStats() { }

	private void CheckTime() { }

	private int get_actualCurrentDay() { }

	private int get_actualCurrentHour() { }

	public int get_currentDay() { }

	public int get_currentHour() { }

	public bool get_hasSeenFirstInterstitial() { }

	public int get_seenThisDay() { }

	public int get_seenThisHour() { }

	public bool HasVersionChangedForList(string waterfallID, string newVersion) { }

	public void IncrementShowCount() { }

	public bool ReachedDailyLimit(IAdSettingsProvider settings) { }

	public bool ReachedHourlyLimit(IAdSettingsProvider settings) { }

	public bool ReachedLimit(IAdSettingsProvider settings) { }

	public void set_currentDay(int value) { }

	public void set_currentHour(int value) { }

	public void set_hasSeenFirstInterstitial(bool value) { }

	public void set_seenThisDay(int value) { }

	public void set_seenThisHour(int value) { }

}

