namespace System.Runtime.Remoting.Messaging;

internal class CADMethodRef
{
	private bool ctor; //Field offset: 0x8
	private string typeName; //Field offset: 0xC
	private string methodName; //Field offset: 0x10
	private string[] param_names; //Field offset: 0x14
	private string[] generic_arg_names; //Field offset: 0x18

	public CADMethodRef(IMethodMessage msg) { }

	private Type[] GetTypes(string[] typeArray) { }

	public MethodBase Resolve() { }

}

