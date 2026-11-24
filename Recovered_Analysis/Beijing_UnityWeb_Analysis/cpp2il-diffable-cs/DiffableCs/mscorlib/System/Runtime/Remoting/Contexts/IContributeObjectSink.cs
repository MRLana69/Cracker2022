namespace System.Runtime.Remoting.Contexts;

public interface IContributeObjectSink
{

	public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

