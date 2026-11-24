namespace SYBO.Components.Utilities;

public class SingletonMonoBehaviourManager : ScriptableObject
{
	private static SingletonMonoBehaviourManager _instance; //Field offset: 0x0
	private List<SingletonMonoBehaviour> Singletons; //Field offset: 0xC

	public static SingletonMonoBehaviourManager Instance
	{
		 get { } //Length: 93
	}

	public SingletonMonoBehaviourManager() { }

	private static void CheckInstance() { }

	internal void DestroySingleton(SingletonMonoBehaviour singletonToDestroy) { }

	internal T FindSingleton() { }

	internal SingletonMonoBehaviour FindSingleton(GameObject go) { }

	public static SingletonMonoBehaviourManager get_Instance() { }

	public int GetSingletonCount() { }

	public int GetSingletonCount() { }

	internal bool HasSingleton() { }

	internal bool HasSingleton(GameObject go) { }

	public static bool IsInstantiated() { }

	private bool IsSingletonUniqueByType(SingletonMonoBehaviour singleton) { }

	public void LogSingletons() { }

	protected void OnDisable() { }

	private void OnEnable() { }

	public void RegisterSingleton(SingletonMonoBehaviour singleton) { }

	private void RemoveAnyNullOrMissing() { }

	public void UnregisterAndDestroySingleton(SingletonMonoBehaviour singleton) { }

	public void UnregisterSingleton(SingletonMonoBehaviour singleton) { }

}

