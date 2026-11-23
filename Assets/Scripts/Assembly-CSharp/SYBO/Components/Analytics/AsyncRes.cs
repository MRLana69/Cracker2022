namespace SYBO.Components.Analytics;

public class AsyncRes
{
	public bool IsReady;

	public bool ExceptionOccured;

	public int ChunkLength;

	public string UncompressedMD5Hash;

	public object Result;
}
