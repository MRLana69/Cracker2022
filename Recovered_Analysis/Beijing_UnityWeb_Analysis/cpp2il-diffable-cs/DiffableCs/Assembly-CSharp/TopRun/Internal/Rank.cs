namespace TopRun.Internal;

public class Rank : IRank
{
	private int <rank>k__BackingField; //Field offset: 0x8
	private string <country>k__BackingField; //Field offset: 0xC

	public string country
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int rank
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public Rank(string country, int rank) { }

	public string get_country() { }

	public int get_rank() { }

	private void set_country(string value) { }

	private void set_rank(int value) { }

}

