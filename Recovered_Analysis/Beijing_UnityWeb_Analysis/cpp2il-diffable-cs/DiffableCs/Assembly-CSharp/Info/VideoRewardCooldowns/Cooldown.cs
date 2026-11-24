namespace Info.VideoRewardCooldowns;

public class Cooldown
{
	private string <id>k__BackingField; //Field offset: 0x8
	private int <totalCharges>k__BackingField; //Field offset: 0xC
	private int <usedCharges>k__BackingField; //Field offset: 0x10
	private int <seconds>k__BackingField; //Field offset: 0x14
	private DateTime <startTime>k__BackingField; //Field offset: 0x18

	public string id
	{
		 get { } //Length: 110
		 set { } //Length: 97
	}

	public int seconds
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public DateTime startTime
	{
		 get { } //Length: 12
		 set { } //Length: 71
	}

	public int totalCharges
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public int usedCharges
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Cooldown() { }

	public string get_id() { }

	public int get_seconds() { }

	public DateTime get_startTime() { }

	public int get_totalCharges() { }

	public int get_usedCharges() { }

	public void set_id(string value) { }

	public void set_seconds(int value) { }

	public void set_startTime(DateTime value) { }

	public void set_totalCharges(int value) { }

	public void set_usedCharges(int value) { }

}

