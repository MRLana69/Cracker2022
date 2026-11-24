namespace UnityUtilities;

public class PersistentSingletonMonoBehaviour`1 : MonoBehaviour
{
	private static TSubclass _instance; //Field offset: 0x0
	private bool _skipOnLevelWasLoaded; //Field offset: 0x0

	public static TSubclass instance
	{
		 get { } //Length: 205
	}

	protected bool instanceExists
	{
		 get { } //Length: 153
	}

	public PersistentSingletonMonoBehaviour`1() { }

	private void <Awake>b__6_0(Scene scene, LoadSceneMode loadSceneMode) { }

	private void Awake() { }

	public static TSubclass get_instance() { }

	protected bool get_instanceExists() { }

	protected virtual void OnAwakeOrSwitch() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnPersistentSingletonAwake() { }

	protected virtual void OnPersistentSingletonDestroyed() { }

	protected virtual void OnSceneSwitched() { }

	protected virtual void Start() { }

}

