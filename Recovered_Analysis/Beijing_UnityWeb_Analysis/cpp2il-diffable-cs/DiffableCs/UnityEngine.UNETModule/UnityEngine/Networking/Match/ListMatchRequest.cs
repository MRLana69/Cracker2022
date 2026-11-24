namespace UnityEngine.Networking.Match;

internal class ListMatchRequest : Request
{
	private int <pageSize>k__BackingField; //Field offset: 0x1C
	private int <pageNum>k__BackingField; //Field offset: 0x20
	private string <nameFilter>k__BackingField; //Field offset: 0x24
	private bool <filterOutPrivateMatches>k__BackingField; //Field offset: 0x28
	private int <eloScore>k__BackingField; //Field offset: 0x2C
	private Dictionary<string, long> <matchAttributeFilterLessThan>k__BackingField; //Field offset: 0x30
	private Dictionary<string, long> <matchAttributeFilterEqualTo>k__BackingField; //Field offset: 0x34
	private Dictionary<string, long> <matchAttributeFilterGreaterThan>k__BackingField; //Field offset: 0x38

	public int eloScore
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool filterOutPrivateMatches
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Dictionary<string, long> matchAttributeFilterEqualTo
	{
		 get { } //Length: 6
	}

	public Dictionary<string, long> matchAttributeFilterGreaterThan
	{
		 get { } //Length: 6
	}

	public Dictionary<string, long> matchAttributeFilterLessThan
	{
		 get { } //Length: 6
	}

	public string nameFilter
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int pageNum
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int pageSize
	{
		 get { } //Length: 128
		 set { } //Length: 8
	}

	public ListMatchRequest() { }

	public int get_eloScore() { }

	public bool get_filterOutPrivateMatches() { }

	public Dictionary<string, long> get_matchAttributeFilterEqualTo() { }

	public Dictionary<string, long> get_matchAttributeFilterGreaterThan() { }

	public Dictionary<string, long> get_matchAttributeFilterLessThan() { }

	public string get_nameFilter() { }

	public int get_pageNum() { }

	public int get_pageSize() { }

	public void set_eloScore(int value) { }

	public void set_filterOutPrivateMatches(bool value) { }

	public void set_nameFilter(string value) { }

	public void set_pageNum(int value) { }

	public void set_pageSize(int value) { }

	public override string ToString() { }

}

