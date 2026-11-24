namespace Cloud.Internal;

public class CloudSaveComparisonRow
{
	public CloudSaveComparisonElement id; //Field offset: 0x8
	public float localValue; //Field offset: 0xC
	public float onlineValue; //Field offset: 0x10
	public bool isLocalImprovement; //Field offset: 0x14
	public bool isOnlineImprovement; //Field offset: 0x15

	public CloudSaveComparisonRow(CloudSaveComparisonElement id, int localValue, int onlineValue) { }

	public CloudSaveComparisonRow(CloudSaveComparisonElement id, float localValue, float onlineValue) { }

}

