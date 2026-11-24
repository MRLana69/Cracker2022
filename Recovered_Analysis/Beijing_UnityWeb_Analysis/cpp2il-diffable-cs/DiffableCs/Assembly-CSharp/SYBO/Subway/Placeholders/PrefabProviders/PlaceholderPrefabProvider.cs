namespace SYBO.Subway.Placeholders.PrefabProviders;

public class PlaceholderPrefabProvider : PlaceholderPrefabProviderBase
{
	protected Transform _prefab; //Field offset: 0x18
	public PerformanceLevel MinDevicePerformance; //Field offset: 0x1C
	protected bool evaluated; //Field offset: 0x20

	public Transform Prefab
	{
		 get { } //Length: 350
		 set { } //Length: 11
	}

	internal override int PrefabCount
	{
		 get { } //Length: 6
	}

	public PlaceholderPrefabProvider() { }

	internal override void Evaluate() { }

	public Transform get_Prefab() { }

	internal override int get_PrefabCount() { }

	internal override Transform GetPrefab(int prefabIndex) { }

	public void set_Prefab(Transform value) { }

}

