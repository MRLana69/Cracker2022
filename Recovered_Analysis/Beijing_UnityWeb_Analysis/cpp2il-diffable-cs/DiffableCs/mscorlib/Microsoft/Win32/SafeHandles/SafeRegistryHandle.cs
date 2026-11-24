namespace Microsoft.Win32.SafeHandles;

public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	public SafeRegistryHandle(nint preexistingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

