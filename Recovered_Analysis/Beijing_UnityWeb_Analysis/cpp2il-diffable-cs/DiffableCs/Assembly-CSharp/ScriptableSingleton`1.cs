//Type is in global namespace

public abstract class ScriptableSingleton`1 : ScriptableObject
{
	private static T _cachedInstance; //Field offset: 0x0

	private static string _fileName
	{
		 get { } //Length: 65
	}

	private static string _resourcePath
	{
		 get { } //Length: 139
	}

	public static T instance
	{
		 get { } //Length: 54
	}

	protected ScriptableSingleton`1() { }

	private static string get__fileName() { }

	private static string get__resourcePath() { }

	public static T get_instance() { }

	protected virtual void OnCreate() { }

}

