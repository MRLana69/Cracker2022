namespace UnityEngine.Networking.Match;

internal abstract class Response
{
	public bool success; //Field offset: 0x8
	public string extendedInfo; //Field offset: 0xC

	protected Response() { }

	public void SetFailure(string info) { }

	public override string ToString() { }

}

