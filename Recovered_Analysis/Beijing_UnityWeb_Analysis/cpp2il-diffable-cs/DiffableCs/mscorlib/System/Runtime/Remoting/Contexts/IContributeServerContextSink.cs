namespace System.Runtime.Remoting.Contexts;

public interface IContributeServerContextSink
{

	public IMessageSink GetServerContextSink(IMessageSink nextSink) { }

}

