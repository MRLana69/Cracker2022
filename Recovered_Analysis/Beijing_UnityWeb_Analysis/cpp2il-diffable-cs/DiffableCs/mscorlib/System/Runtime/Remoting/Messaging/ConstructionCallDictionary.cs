namespace System.Runtime.Remoting.Messaging;

internal class ConstructionCallDictionary : MessageDictionary
{
	public static string[] InternalKeys; //Field offset: 0x0

	private static ConstructionCallDictionary() { }

	public ConstructionCallDictionary(IConstructionCallMessage message) { }

	protected override object GetMethodProperty(string key) { }

	protected override void SetMethodProperty(string key, object value) { }

}

