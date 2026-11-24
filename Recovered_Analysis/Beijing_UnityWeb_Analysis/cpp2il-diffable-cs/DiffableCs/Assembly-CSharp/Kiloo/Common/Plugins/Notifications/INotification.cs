namespace Kiloo.Common.Plugins.Notifications;

public interface INotification
{

	public string alert
	{
		 get { } //Length: 0
	}

	public int badge
	{
		 get { } //Length: 0
	}

	public object Item
	{
		 get { } //Length: 0
	}

	public string sound
	{
		 get { } //Length: 0
	}

	public string get_alert() { }

	public int get_badge() { }

	public object get_Item(string key) { }

	public string get_sound() { }

}

