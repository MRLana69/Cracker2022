using System.Collections.Generic;

namespace Kiloo.Common.Backend;

public interface IEventLogger
{
	void LogEvent(string eventName, Dictionary<string, object> parameters = null);
}
