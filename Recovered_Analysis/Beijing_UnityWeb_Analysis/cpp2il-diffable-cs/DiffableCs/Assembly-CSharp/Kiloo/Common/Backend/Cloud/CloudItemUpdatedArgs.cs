namespace Kiloo.Common.Backend.Cloud;

public class CloudItemUpdatedArgs : EventArgs
{
	private string <file>k__BackingField; //Field offset: 0x8
	private ICloudItem <item>k__BackingField; //Field offset: 0xC

	public string file
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public ICloudItem item
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public CloudItemUpdatedArgs(ICloudItem item, string file) { }

	public string get_file() { }

	public ICloudItem get_item() { }

	private void set_file(string value) { }

	private void set_item(ICloudItem value) { }

}

