namespace UnityEngine.Networking.Match;

internal class JoinMatchRequest : Request
{
	private NetworkID <networkId>k__BackingField; //Field offset: 0x20
	private string <publicAddress>k__BackingField; //Field offset: 0x28
	private string <privateAddress>k__BackingField; //Field offset: 0x2C
	private int <eloScore>k__BackingField; //Field offset: 0x30
	private string <password>k__BackingField; //Field offset: 0x34

	public int eloScore
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public NetworkID networkId
	{
		 get { } //Length: 500
		 set { } //Length: 2
	}

	public string password
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public string privateAddress
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string publicAddress
	{
		 get { } //Length: 391
		 set { } //Length: 11
	}

	public JoinMatchRequest() { }

	public int get_eloScore() { }

	public NetworkID get_networkId() { }

	public string get_password() { }

	public string get_privateAddress() { }

	public string get_publicAddress() { }

	public void set_eloScore(int value) { }

	public void set_networkId(NetworkID value) { }

	public void set_password(string value) { }

	public void set_privateAddress(string value) { }

	public void set_publicAddress(string value) { }

	public override string ToString() { }

}

