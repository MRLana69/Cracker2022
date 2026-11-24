namespace Kiloo.Common.Backend.Cloud;

public interface ICloudConflict
{

	public ICloudItem mine
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public ICloudItem resolution
	{
		 get { } //Length: 0
	}

	public CloudConflictResolution resolveMethod
	{
		 get { } //Length: 0
	}

	public ICloudItem theirs
	{
		 get { } //Length: 0
	}

	public ICloudItem get_mine() { }

	public string get_name() { }

	public ICloudItem get_resolution() { }

	public CloudConflictResolution get_resolveMethod() { }

	public ICloudItem get_theirs() { }

	public void ResolveUsingMine() { }

	public void ResolveUsingTheirs() { }

	public void ResolveWith(byte[] data, ICloudUserData userData) { }

}

