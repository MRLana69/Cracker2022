namespace System.Runtime.Remoting.Activation;

internal class ConstructionLevelActivator : IActivator
{

	public IActivator NextActivator
	{
		 get { } //Length: 6
	}

	public ConstructionLevelActivator() { }

	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	public IActivator get_NextActivator() { }

}

