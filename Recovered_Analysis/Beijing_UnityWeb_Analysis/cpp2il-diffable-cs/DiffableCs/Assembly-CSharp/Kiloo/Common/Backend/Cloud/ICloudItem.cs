namespace Kiloo.Common.Backend.Cloud;

public interface ICloudItem
{

	public int dataVersion
	{
		 get { } //Length: 0
	}

	public bool isModified
	{
		 get { } //Length: 0
	}

	public bool isOutOfDate
	{
		 get { } //Length: 0
	}

	public Nullable<DateTime> lastModified
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public string revision
	{
		 get { } //Length: 0
	}

	public string sourceDescription
	{
		 get { } //Length: 0
	}

	public string sourceInstallationId
	{
		 get { } //Length: 0
	}

	public ICloudUserData userData
	{
		 get { } //Length: 0
	}

	public int get_dataVersion() { }

	public bool get_isModified() { }

	public bool get_isOutOfDate() { }

	public Nullable<DateTime> get_lastModified() { }

	public string get_name() { }

	public string get_revision() { }

	public string get_sourceDescription() { }

	public string get_sourceInstallationId() { }

	public ICloudUserData get_userData() { }

	public Stream GetDataStream() { }

}

