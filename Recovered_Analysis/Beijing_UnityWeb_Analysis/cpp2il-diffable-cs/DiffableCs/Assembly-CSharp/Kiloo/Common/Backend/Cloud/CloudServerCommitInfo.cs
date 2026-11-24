namespace Kiloo.Common.Backend.Cloud;

public class CloudServerCommitInfo
{
	public int crc32; //Field offset: 0x8
	public int size; //Field offset: 0xC
	public int compressedSize; //Field offset: 0x10

	public CloudServerCommitInfo() { }

}

