namespace System.Runtime.Remoting;

public interface IEnvoyInfo
{

	public IMessageSink EnvoySinks
	{
		 get { } //Length: 0
	}

	public IMessageSink get_EnvoySinks() { }

}

