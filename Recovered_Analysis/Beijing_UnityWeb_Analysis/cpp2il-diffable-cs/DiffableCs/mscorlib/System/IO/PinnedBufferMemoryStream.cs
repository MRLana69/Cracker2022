namespace System.IO;

internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	private byte[] _array; //Field offset: 0x4C
	private GCHandle _pinningHandle; //Field offset: 0x50

	internal PinnedBufferMemoryStream(byte[] array) { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

}

