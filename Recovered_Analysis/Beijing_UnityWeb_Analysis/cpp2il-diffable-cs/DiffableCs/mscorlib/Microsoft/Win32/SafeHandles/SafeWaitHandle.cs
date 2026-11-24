namespace Microsoft.Win32.SafeHandles;

public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	public SafeWaitHandle(nint existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

