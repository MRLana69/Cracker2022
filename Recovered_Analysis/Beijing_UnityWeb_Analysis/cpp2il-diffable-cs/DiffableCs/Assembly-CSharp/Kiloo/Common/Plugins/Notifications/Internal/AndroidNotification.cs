namespace Kiloo.Common.Plugins.Notifications.Internal;

internal class AndroidNotification : INotification
{
	private object _payload; //Field offset: 0x8

	public string alert
	{
		 get { } //Length: 141
	}

	public int badge
	{
		 get { } //Length: 87
	}

	public object Item
	{
		 get { } //Length: 15
	}

	public IDictionary<string, object> payload
	{
		 get { } //Length: 90
	}

	public string sound
	{
		 get { } //Length: 113
	}

	public AndroidNotification(string payload) { }

	public string get_alert() { }

	public int get_badge() { }

	public object get_Item(string key) { }

	public IDictionary<string, object> get_payload() { }

	public string get_sound() { }

}

