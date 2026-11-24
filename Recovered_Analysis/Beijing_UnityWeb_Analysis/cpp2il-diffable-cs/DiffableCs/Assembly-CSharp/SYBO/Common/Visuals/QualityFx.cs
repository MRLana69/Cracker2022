namespace SYBO.Common.Visuals;

public class QualityFx
{
	private QualityFeature _feature; //Field offset: 0x8
	private MonoBehaviour _unsupportedPrefab; //Field offset: 0xC
	private MonoBehaviour _supportedPrefab; //Field offset: 0x10

	public QualityFx() { }

	public T InstantiateEffect() { }

	public T InstantiateEffect(Vector3 position, Quaternion rotation) { }

	private T InstantiateInternal(T prefab, Vector3 position, Quaternion rotation) { }

}

