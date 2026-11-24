namespace System.Runtime.Remoting;

internal class ChannelData
{
	internal string Ref; //Field offset: 0x8
	internal string Type; //Field offset: 0xC
	internal string Id; //Field offset: 0x10
	internal string DelayLoadAsClientChannel; //Field offset: 0x14
	private ArrayList _serverProviders; //Field offset: 0x18
	private ArrayList _clientProviders; //Field offset: 0x1C
	private Hashtable _customProperties; //Field offset: 0x20

	public ArrayList ClientProviders
	{
		 get { } //Length: 79
	}

	public Hashtable CustomProperties
	{
		 get { } //Length: 79
	}

	internal ArrayList ServerProviders
	{
		 get { } //Length: 183
	}

	public ChannelData() { }

	public void CopyFrom(ChannelData other) { }

	public ArrayList get_ClientProviders() { }

	public Hashtable get_CustomProperties() { }

	internal ArrayList get_ServerProviders() { }

}

