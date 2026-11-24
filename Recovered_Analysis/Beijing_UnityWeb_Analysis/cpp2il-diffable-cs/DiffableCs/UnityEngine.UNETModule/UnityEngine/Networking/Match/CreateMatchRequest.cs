namespace UnityEngine.Networking.Match;

internal class CreateMatchRequest : Request
{
	private string <name>k__BackingField; //Field offset: 0x1C
	private uint <size>k__BackingField; //Field offset: 0x20
	private string <publicAddress>k__BackingField; //Field offset: 0x24
	private string <privateAddress>k__BackingField; //Field offset: 0x28
	private int <eloScore>k__BackingField; //Field offset: 0x2C
	private bool <advertise>k__BackingField; //Field offset: 0x30
	private string <password>k__BackingField; //Field offset: 0x34
	private Dictionary<string, long> <matchAttributes>k__BackingField; //Field offset: 0x38

	public bool advertise
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int eloScore
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Dictionary<string, long> matchAttributes
	{
		 get { } //Length: 6
	}

	public string name
	{
		 get { } //Length: 174
		 set { } //Length: 29
	}

	public string password
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string privateAddress
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string publicAddress
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public uint size
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public CreateMatchRequest() { }

	public bool get_advertise() { }

	public int get_eloScore() { }

	public Dictionary<string, long> get_matchAttributes() { }

	public string get_name() { }

	public string get_password() { }

	public string get_privateAddress() { }

	public string get_publicAddress() { }

	public uint get_size() { }

	public void set_advertise(bool value) { }

	public void set_eloScore(int value) { }

	public void set_name(string value) { }

	public void set_password(string value) { }

	public void set_privateAddress(string value) { }

	public void set_publicAddress(string value) { }

	public void set_size(uint value) { }

	public override string ToString() { }

}

