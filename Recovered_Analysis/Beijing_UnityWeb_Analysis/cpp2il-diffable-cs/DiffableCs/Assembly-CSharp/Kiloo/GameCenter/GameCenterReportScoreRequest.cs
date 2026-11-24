namespace Kiloo.GameCenter;

public class GameCenterReportScoreRequest : GameCenterRequest
{
	private string <category>k__BackingField; //Field offset: 0x14
	private long <scoreValue>k__BackingField; //Field offset: 0x18
	private ulong <scoreContext>k__BackingField; //Field offset: 0x20

	public string category
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public ulong scoreContext
	{
		 get { } //Length: 3
		 set { } //Length: 58
	}

	public long scoreValue
	{
		 get { } //Length: 142
		 set { } //Length: 162
	}

	public GameCenterReportScoreRequest() { }

	public string get_category() { }

	public ulong get_scoreContext() { }

	public long get_scoreValue() { }

	public void set_category(string value) { }

	public void set_scoreContext(ulong value) { }

	public void set_scoreValue(long value) { }

}

