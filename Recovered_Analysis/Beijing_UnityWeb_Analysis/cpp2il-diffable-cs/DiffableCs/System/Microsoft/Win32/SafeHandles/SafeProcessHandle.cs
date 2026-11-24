namespace Microsoft.Win32.SafeHandles;

public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeProcessHandle InvalidHandle; //Field offset: 0x0

	private static SafeProcessHandle() { }

	internal SafeProcessHandle(nint handle) { }

	public SafeProcessHandle(nint existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

