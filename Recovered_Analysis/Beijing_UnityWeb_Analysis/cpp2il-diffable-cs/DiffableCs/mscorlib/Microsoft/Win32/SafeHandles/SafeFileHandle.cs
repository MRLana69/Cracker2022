namespace Microsoft.Win32.SafeHandles;

public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	public SafeFileHandle(nint preexistingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

