using System.Collections.Generic;
using UnityEngine;

namespace Kiloo.Common.Backend.Cloud;

public interface ICloudServer
{
	string kilooTag { get; }

	Coroutine ListItemsAsync(string forKilooTag, CloudServerRequestCompleteHandler completeHandler);

	CloudServerResult ListItems(string forKilooTag);

	Coroutine UpdateItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler);

	CloudServerResult UpdateItems(string forKilooTag, IEnumerable<ICloudItem> items);

	Coroutine CommitItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler);

	CloudServerCommitResult CommitItems(string forKilooTag, IEnumerable<ICloudItem> items);
}
