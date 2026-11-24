namespace System.Runtime.Remoting.Messaging;

internal class CallContextRemotingData : ICloneable
{
	private string _logicalCallID; //Field offset: 0x8

	internal bool HasInfo
	{
		 get { } //Length: 6
	}

	internal string LogicalCallID
	{
		 get { } //Length: 62
		 set { } //Length: 11
	}

	public CallContextRemotingData() { }

	public object Clone() { }

	internal bool get_HasInfo() { }

	internal string get_LogicalCallID() { }

	internal void set_LogicalCallID(string value) { }

}

