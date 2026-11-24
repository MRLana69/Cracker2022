namespace System.Reflection;

internal class MonoModule : RuntimeModule
{

	public override Assembly Assembly
	{
		 get { } //Length: 3
	}

	public override Guid ModuleVersionId
	{
		 get { } //Length: 77
	}

	public override string ScopeName
	{
		 get { } //Length: 6
	}

	public MonoModule() { }

	public override Assembly get_Assembly() { }

	public override Guid get_ModuleVersionId() { }

	public override string get_ScopeName() { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override bool IsResource() { }

}

