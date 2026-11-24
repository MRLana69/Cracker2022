namespace SYBO.Components.Analytics;

public class AsyncRes
{
	public bool IsReady; //Field offset: 0x8
	public bool ExceptionOccured; //Field offset: 0x9
	public int ChunkLength; //Field offset: 0xC
	public string UncompressedMD5Hash; //Field offset: 0x10
	public object Result; //Field offset: 0x14

	public AsyncRes() { }

}

