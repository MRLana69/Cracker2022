namespace System.Runtime.Remoting.Contexts;

public interface IContributeEnvoySink
{

	public IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

