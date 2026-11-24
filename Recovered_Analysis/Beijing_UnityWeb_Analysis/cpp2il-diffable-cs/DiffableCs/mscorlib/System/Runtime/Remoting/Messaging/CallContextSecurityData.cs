namespace System.Runtime.Remoting.Messaging;

internal class CallContextSecurityData : ICloneable
{
	private IPrincipal _principal; //Field offset: 0x8

	internal bool HasInfo
	{
		 get { } //Length: 12
	}

	public CallContextSecurityData() { }

	public object Clone() { }

	internal bool get_HasInfo() { }

}

