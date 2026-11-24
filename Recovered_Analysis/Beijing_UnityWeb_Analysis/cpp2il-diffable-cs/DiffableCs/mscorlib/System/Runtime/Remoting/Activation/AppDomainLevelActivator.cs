namespace System.Runtime.Remoting.Activation;

internal class AppDomainLevelActivator : IActivator
{
	private string _activationUrl; //Field offset: 0x8
	private IActivator _next; //Field offset: 0xC

	public IActivator NextActivator
	{
		 get { } //Length: 7
	}

	public AppDomainLevelActivator(string activationUrl, IActivator next) { }

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	public IActivator get_NextActivator() { }

}

