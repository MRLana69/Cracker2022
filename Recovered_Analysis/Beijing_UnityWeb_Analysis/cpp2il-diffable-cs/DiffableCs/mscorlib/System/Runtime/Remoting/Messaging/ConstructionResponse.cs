namespace System.Runtime.Remoting.Messaging;

public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
{

	public override IDictionary Properties
	{
		 get { } //Length: 6
	}

	internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	internal ConstructionResponse(Exception e, IMethodCallMessage msg) { }

	internal ConstructionResponse(SerializationInfo info, StreamingContext context) { }

	public override IDictionary get_Properties() { }

}

