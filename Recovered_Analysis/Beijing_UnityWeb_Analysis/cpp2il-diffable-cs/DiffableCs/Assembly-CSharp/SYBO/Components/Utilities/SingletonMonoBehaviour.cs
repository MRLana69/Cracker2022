namespace SYBO.Components.Utilities;

public abstract class SingletonMonoBehaviour : MonoBehaviour
{
	public static string LogCategoryName; //Field offset: 0x0
	private bool <IsDestroyed>k__BackingField; //Field offset: 0xC

	public int ID
	{
		 get { } //Length: 103
	}

	public bool IsDestroyed
	{
		 get { } //Length: 21
		internal set { } //Length: 11
	}

	public virtual bool IsSavedInHierarchy
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public static bool IsShuttingDown
	{
		 get { } //Length: 3
	}

	private static SingletonMonoBehaviour() { }

	protected SingletonMonoBehaviour() { }

	public int get_ID() { }

	public bool get_IsDestroyed() { }

	public virtual bool get_IsSavedInHierarchy() { }

	public static bool get_IsShuttingDown() { }

	public abstract SingletonMonoBehaviour GetInstance() { }

	public static GameObject InstantiateGameObjectFromPath(string path) { }

	public static void LogErrorFormat(string format, object[] args) { }

	public static void LogFormat(int level, string format, object[] args) { }

	public static void LogWarningFormat(string format, object[] args) { }

	internal void set_IsDestroyed(bool value) { }

	public virtual void set_IsSavedInHierarchy(bool value) { }

}

