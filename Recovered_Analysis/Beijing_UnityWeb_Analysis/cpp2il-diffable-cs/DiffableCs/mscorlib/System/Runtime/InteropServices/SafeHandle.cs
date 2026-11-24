namespace System.Runtime.InteropServices;

public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	private const int RefCount_Mask = 2147483644; //Field offset: 0x0
	private const int RefCount_One = 4; //Field offset: 0x0
	protected nint handle; //Field offset: 0x8
	private int _state; //Field offset: 0xC
	private bool _ownsHandle; //Field offset: 0x10
	private bool _fullyInitialized; //Field offset: 0x11

	public bool IsClosed
	{
		 get { } //Length: 6
	}

	public abstract bool IsInvalid
	{
		 get { } //Length: 0
	}

	protected SafeHandle(nint invalidHandleValue, bool ownsHandle) { }

	public void Close() { }

	public void DangerousAddRef(ref bool success) { }

	public nint DangerousGetHandle() { }

	public void DangerousRelease() { }

	private void DangerousReleaseInternal(bool dispose) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public bool get_IsClosed() { }

	public abstract bool get_IsInvalid() { }

	private void InternalDispose() { }

	private void InternalFinalize() { }

	protected abstract bool ReleaseHandle() { }

	protected void SetHandle(nint handle) { }

	public void SetHandleAsInvalid() { }

}

