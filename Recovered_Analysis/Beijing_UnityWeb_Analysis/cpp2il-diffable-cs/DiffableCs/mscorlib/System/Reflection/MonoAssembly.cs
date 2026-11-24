namespace System.Reflection;

internal class MonoAssembly : RuntimeAssembly
{

	public MonoAssembly() { }

	public override Module GetModule(string name) { }

	public override Module[] GetModules(bool getResourceModules) { }

	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

}

