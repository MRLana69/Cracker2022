namespace Microsoft.Win32.SafeHandles;

internal sealed class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	internal SafeFindHandle(nint preexistingHandle) { }

	protected override bool ReleaseHandle() { }

}

