namespace UnityEngine.SceneManagement;

public class SceneManager
{
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; //Field offset: 0x0
	private static UnityAction<Scene> sceneUnloaded; //Field offset: 0x4
	private static UnityAction<Scene, Scene> activeSceneChanged; //Field offset: 0x8

	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		 add { } //Length: 51
		 remove { } //Length: 132
	}

	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	public static Scene GetActiveScene() { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	public static Scene GetSceneAt(int index) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	private static void Internal_SceneUnloaded(Scene scene) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

}

