namespace Kiloo.Common.Utility.Singleton;

public class SingletonMonoBehaviour`1 : MonoBehaviour
{
	private static TSubclass _instance; //Field offset: 0x0

	public static TSubclass instance
	{
		 get { } //Length: 414
	}

	public static TSubclass instanceOptional
	{
		 get { } //Length: 189
	}

	public SingletonMonoBehaviour`1() { }

	public static TSubclass get_instance() { }

	public static TSubclass get_instanceOptional() { }

	protected virtual void OnDestroy() { }

	private static void UpdateInstance(bool optional) { }

}

