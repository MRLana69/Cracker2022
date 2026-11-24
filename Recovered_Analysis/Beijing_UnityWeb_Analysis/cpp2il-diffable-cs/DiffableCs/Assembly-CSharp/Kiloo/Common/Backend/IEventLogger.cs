namespace Kiloo.Common.Backend;

public interface IEventLogger
{

	public void LogEvent(string eventName, Dictionary<string, object> parameters = null) { }

}

