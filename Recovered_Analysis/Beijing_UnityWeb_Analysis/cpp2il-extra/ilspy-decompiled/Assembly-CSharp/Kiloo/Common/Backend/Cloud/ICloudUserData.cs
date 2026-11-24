using System.Collections;
using System.Collections.Generic;

namespace Kiloo.Common.Backend.Cloud;

public interface ICloudUserData : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	// C# has no syntax for parameterized property 'Item'.
	string get_Item(string key);
}
