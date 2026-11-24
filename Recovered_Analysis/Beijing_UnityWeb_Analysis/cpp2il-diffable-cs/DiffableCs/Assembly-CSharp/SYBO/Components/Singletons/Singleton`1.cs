namespace SYBO.Components.Singletons;

public abstract class Singleton`1
{
	private static object _lockObject; //Field offset: 0x0
	private static T _instance; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 132
	}

	private static Singleton`1() { }

	public Singleton`1() { }

	public static T get_Instance() { }

	public static T GetInstance() { }

	public virtual void Initialize() { }

}

