namespace Kiloo.Analytics;

internal class Event
{
	public readonly string name; //Field offset: 0x8
	public readonly Dictionary<string, object> parameters; //Field offset: 0xC

	public Event(string name, Dictionary<string, object> parameters = null) { }

}

