namespace Kiloo.Common.HTTP.Internal;

internal class SocketsResponse : Response
{
	private readonly object _chunksLock; //Field offset: 0x18
	private List<byte[]> _chunks; //Field offset: 0x1C

	public SocketsResponse() { }

	private static void LogVerbose(string msg) { }

	private static void LogWarning(string msg) { }

	public void ReadFromStream(Stream inputStream, bool ignoreContentMd5 = false) { }

	private bool ReadHeader(Stream stream, out string key, out string value) { }

	private string ReadHeaderLine(Stream stream) { }

	public byte[] TakeChunk() { }

}

