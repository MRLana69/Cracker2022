namespace System.Runtime.Remoting.Channels;

public interface IClientChannelSinkProvider
{

	public IClientChannelSinkProvider Next
	{
		 set { } //Length: 0
	}

	public void set_Next(IClientChannelSinkProvider value) { }

}

