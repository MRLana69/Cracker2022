namespace SYBO.Subway.Placeholders.Lifecycles;

public class PlaceholderLifecycle : MonoBehaviour
{
	protected bool _initialized; //Field offset: 0xC
	protected PlaceholderPrefabProviderBase _prefabProvider; //Field offset: 0x10
	protected Placeholder _placeholder; //Field offset: 0x14

	public Placeholder Placeholder
	{
		 get { } //Length: 6
	}

	public PlaceholderLifecycle() { }

	protected void Activate() { }

	protected void Awake() { }

	protected void Deactivate() { }

	public void Despawn() { }

	protected virtual void DespawnInstances() { }

	public void DespawnInstancesEditor() { }

	public Placeholder get_Placeholder() { }

	protected virtual void Initialize() { }

	protected virtual void InitializeCheck() { }

	private void OnValidate() { }

	public void Spawn() { }

	public void SpawnInstancesEditor() { }

}

