namespace System.Reflection;

internal abstract class RuntimeAssembly : Assembly
{

	protected RuntimeAssembly() { }

	public override AssemblyName GetName(bool copiedName) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

}

