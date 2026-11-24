namespace System.Runtime.Remoting.Messaging;

public sealed class CallContext
{

	private CallContext() { }

	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

}

