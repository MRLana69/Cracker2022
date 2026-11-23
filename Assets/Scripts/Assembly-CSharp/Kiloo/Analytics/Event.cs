using System.Collections.Generic;

namespace Kiloo.Analytics;

internal class Event(string name, Dictionary<string, object> parameters = null)
{
	public readonly string name = name;

	public readonly Dictionary<string, object> parameters = parameters;
}
