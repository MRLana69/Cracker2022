namespace SYBO.Components.Utilities;

public abstract class SingletonMonoBehaviour`1 : SingletonMonoBehaviour
{
	private static PrefabPathAttribute _attribute; //Field offset: 0x0
	private static T _instance; //Field offset: 0x0
	private bool _isSingletonInitialized; //Field offset: 0x0
	private bool _isSingletonInitializing; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 403
		protected set { } //Length: 216
	}

	internal bool IsInitialized
	{
		 get { } //Length: 32
		 set { } //Length: 107
	}

	protected SingletonMonoBehaviour`1() { }

	protected void Awake() { }

	protected T BaseInitialization() { }

	protected static object Construct(Type type) { }

	public void DestroyNewMeOrOldInstance(SingletonMonoBehaviour<T> newSingleton, SingletonMonoBehaviour<T> oldSingleton) { }

	public override bool Equals(object obj) { }

	public static T get_Instance() { }

	internal bool get_IsInitialized() { }

	public static ExecuteInEditMode GetExecuteInEditModeAttributes() { }

	public override int GetHashCode() { }

	public override SingletonMonoBehaviour GetInstance() { }

	public static PrefabPathAttribute GetPrefabPathAttribute() { }

	public static bool HasExecuteInEditModeAttribute() { }

	public static bool HasPrefabPathAttribute() { }

	private void Initialization() { }

	public static T Instantiate() { }

	public static T InstantiateFromPath(string path) { }

	public static bool IsInstantiated() { }

	protected virtual void OnDestroy() { }

	protected static void set_Instance(T value) { }

	internal void set_IsInitialized(bool value) { }

	protected virtual void SubclassInitialize() { }

	public override string ToString() { }

}

