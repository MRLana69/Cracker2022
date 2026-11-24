namespace System.Runtime.Remoting.Messaging;

internal class CADMethodCallMessage : CADMessageBase
{
	private string _uri; //Field offset: 0x1C

	internal int PropertiesCount
	{
		 get { } //Length: 133
	}

	internal string Uri
	{
		 get { } //Length: 330
	}

	internal CADMethodCallMessage(IMethodCallMessage callMsg) { }

	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	internal int get_PropertiesCount() { }

	internal string get_Uri() { }

	internal object[] GetArgs(ArrayList args) { }

	internal ArrayList GetArguments() { }

}

