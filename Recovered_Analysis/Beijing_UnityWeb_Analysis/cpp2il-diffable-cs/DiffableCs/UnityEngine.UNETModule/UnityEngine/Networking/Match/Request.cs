namespace UnityEngine.Networking.Match;

internal abstract class Request
{
	public static readonly int currentVersion; //Field offset: 0x0
	private SourceID <sourceId>k__BackingField; //Field offset: 0x8
	private string <projectId>k__BackingField; //Field offset: 0x10
	private string <accessTokenString>k__BackingField; //Field offset: 0x14
	private int <domain>k__BackingField; //Field offset: 0x18

	public string accessTokenString
	{
		 get { } //Length: 6
	}

	public int domain
	{
		 get { } //Length: 6
		 set { } //Length: 92
	}

	public string projectId
	{
		 get { } //Length: 6
	}

	public SourceID sourceId
	{
		 get { } //Length: 131
	}

	private static Request() { }

	protected Request() { }

	public string get_accessTokenString() { }

	public int get_domain() { }

	public string get_projectId() { }

	public SourceID get_sourceId() { }

	public void set_domain(int value) { }

	public override string ToString() { }

}

