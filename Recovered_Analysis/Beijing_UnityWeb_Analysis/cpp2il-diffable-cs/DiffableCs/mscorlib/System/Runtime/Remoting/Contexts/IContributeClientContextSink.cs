namespace System.Runtime.Remoting.Contexts;

public interface IContributeClientContextSink
{

	public IMessageSink GetClientContextSink(IMessageSink nextSink) { }

}

