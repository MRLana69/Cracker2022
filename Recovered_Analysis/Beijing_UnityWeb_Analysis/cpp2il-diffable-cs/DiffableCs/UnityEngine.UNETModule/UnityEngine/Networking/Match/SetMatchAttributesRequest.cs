namespace UnityEngine.Networking.Match;

internal class SetMatchAttributesRequest : Request
{
	private NetworkID <networkId>k__BackingField; //Field offset: 0x20
	private bool <isListed>k__BackingField; //Field offset: 0x28

	public bool isListed
	{
		 get { } //Length: 171
		 set { } //Length: 8
	}

	public NetworkID networkId
	{
		 get { } //Length: 275
		 set { } //Length: 2
	}

	public SetMatchAttributesRequest() { }

	public bool get_isListed() { }

	public NetworkID get_networkId() { }

	public void set_isListed(bool value) { }

	public void set_networkId(NetworkID value) { }

	public override string ToString() { }

}

