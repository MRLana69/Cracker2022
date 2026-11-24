namespace Kiloo.Common.Backend.Cloud;

public interface ICloudServer
{

	public string kilooTag
	{
		 get { } //Length: 0
	}

	public CloudServerCommitResult CommitItems(string forKilooTag, IEnumerable<ICloudItem> items) { }

	public Coroutine CommitItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler) { }

	public string get_kilooTag() { }

	public CloudServerResult ListItems(string forKilooTag) { }

	public Coroutine ListItemsAsync(string forKilooTag, CloudServerRequestCompleteHandler completeHandler) { }

	public CloudServerResult UpdateItems(string forKilooTag, IEnumerable<ICloudItem> items) { }

	public Coroutine UpdateItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler) { }

}

