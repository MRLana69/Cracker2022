namespace System.Runtime.Remoting;

internal class EnvoyInfo : IEnvoyInfo
{
	private IMessageSink envoySinks; //Field offset: 0x8

	public IMessageSink EnvoySinks
	{
		 get { } //Length: 17
	}

	public EnvoyInfo(IMessageSink sinks) { }

	public IMessageSink get_EnvoySinks() { }

}

