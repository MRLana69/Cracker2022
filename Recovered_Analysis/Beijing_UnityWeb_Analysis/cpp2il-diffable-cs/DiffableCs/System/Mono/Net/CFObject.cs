namespace Mono.Net;

internal class CFObject : IDisposable
{
	private nint <Handle>k__BackingField; //Field offset: 0x8

	public nint Handle
	{
		 get { } //Length: 4
		private set { } //Length: 109
	}

	public CFObject(nint handle, bool own) { }

	internal static void CFRelease(nint handle) { }

	internal static nint CFRetain(nint handle) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public static void dlclose(nint handle) { }

	public static nint dlopen(string path, int mode) { }

	private static nint dlsym(nint handle, string symbol) { }

	protected override void Finalize() { }

	public nint get_Handle() { }

	public static nint GetCFObjectHandle(nint handle, string symbol) { }

	public static nint GetIndirect(nint handle, string symbol) { }

	private void Release() { }

	private void Retain() { }

	private void set_Handle(nint value) { }

}

