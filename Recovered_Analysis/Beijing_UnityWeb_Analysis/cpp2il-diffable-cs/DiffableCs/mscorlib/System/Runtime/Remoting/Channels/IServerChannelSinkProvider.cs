namespace System.Runtime.Remoting.Channels;

public interface IServerChannelSinkProvider
{

	public IServerChannelSinkProvider Next
	{
		 set { } //Length: 0
	}

	public void set_Next(IServerChannelSinkProvider value) { }

}

