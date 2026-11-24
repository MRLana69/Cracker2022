namespace System.Runtime.Remoting.Activation;

internal class ContextLevelActivator : IActivator
{
	private IActivator m_NextActivator; //Field offset: 0x8

	public IActivator NextActivator
	{
		 get { } //Length: 3
	}

	public ContextLevelActivator(IActivator next) { }

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	public IActivator get_NextActivator() { }

}

