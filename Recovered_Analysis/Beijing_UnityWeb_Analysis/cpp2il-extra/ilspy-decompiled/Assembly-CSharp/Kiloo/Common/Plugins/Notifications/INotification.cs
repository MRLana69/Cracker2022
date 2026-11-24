namespace Kiloo.Common.Plugins.Notifications;

public interface INotification
{
	string alert { get; }

	int badge { get; }

	string sound { get; }

	// C# has no syntax for parameterized property 'Item'.
	object get_Item(string key);
}
