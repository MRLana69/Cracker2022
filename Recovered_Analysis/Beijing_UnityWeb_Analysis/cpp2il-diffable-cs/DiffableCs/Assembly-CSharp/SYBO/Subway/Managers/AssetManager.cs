namespace SYBO.Subway.Managers;

public class AssetManager
{
	private Dictionary<EnvironmentBaseInfo, Transform> _combinedEnvBaseModels; //Field offset: 0x10

	public AssetManager() { }

	public void CombineEnvironmentBaseModelsAndStore(EnvironmentBaseInfo envBaseInfo, Transform left, Transform mid, Transform right, int preloadAmount = 2) { }

	public void CombineGroundModels() { }

	private void CreateModelInstances(out GroundAssetGroup instances) { }

	private void DestroyModelInstances(ref GroundAssetGroup ga) { }

	public Transform GetEnvironmentBaseModel(EnvironmentBaseInfo envBaseInfo) { }

	public static Transform[] GetEnvironmentBasePrefabs(EnvironmentBaseInfo envBaseInfo) { }

	public static Transform[] GetPrefabsForBaseInfo(GroundAssetGroup ga, EnvironmentBaseInfo envBaseInfo) { }

	protected override void SubclassInitialize() { }

}

