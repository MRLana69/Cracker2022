namespace SYBO.Subway.Placeholders.PrefabProviders;

public abstract class PlaceholderPrefabProviderBase : MonoBehaviour
{
	protected bool _initialized; //Field offset: 0xC
	private ThemeManager _themeManager; //Field offset: 0x10
	protected List<Transform> _prefabsToSpawn; //Field offset: 0x14

	internal abstract int PrefabCount
	{
		 get { } //Length: 0
	}

	internal List<Transform> PrefabsToSpawn
	{
		 get { } //Length: 3
	}

	protected PlaceholderPrefabProviderBase() { }

	private void Awake() { }

	internal abstract void Evaluate() { }

	internal abstract int get_PrefabCount() { }

	internal List<Transform> get_PrefabsToSpawn() { }

	internal abstract Transform GetPrefab(int prefabIndex) { }

	internal Transform GetThemedPrefab(Transform prefabTransform) { }

	protected virtual void Initialize() { }

	protected virtual void InitializeCheck() { }

}

