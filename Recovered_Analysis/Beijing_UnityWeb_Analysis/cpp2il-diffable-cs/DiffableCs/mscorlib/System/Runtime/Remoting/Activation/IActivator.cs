namespace System.Runtime.Remoting.Activation;

public interface IActivator
{

	public IActivator NextActivator
	{
		 get { } //Length: 0
	}

	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	public IActivator get_NextActivator() { }

}

