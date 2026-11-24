namespace System.Runtime.Remoting.Contexts;

public interface IDynamicMessageSink
{

	public void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync) { }

	public void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync) { }

}

