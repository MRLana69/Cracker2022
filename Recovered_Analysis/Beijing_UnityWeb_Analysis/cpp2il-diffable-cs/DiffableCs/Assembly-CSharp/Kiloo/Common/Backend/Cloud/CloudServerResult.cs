namespace Kiloo.Common.Backend.Cloud;

public class CloudServerResult
{
	public CloudSaveStatus status; //Field offset: 0x8
	public ICloudItem[] items; //Field offset: 0xC

	public CloudServerResult() { }

}

