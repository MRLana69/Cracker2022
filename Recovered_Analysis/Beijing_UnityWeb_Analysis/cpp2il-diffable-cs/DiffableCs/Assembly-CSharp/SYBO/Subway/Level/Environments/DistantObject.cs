namespace SYBO.Subway.Level.Environments;

public class DistantObject : MonoBehaviour
{
	private const int BaseRenderQueueOffset = 10; //Field offset: 0x0
	private Vector3 _trueSpawnPosition; //Field offset: 0xC
	private float _projectionFactor; //Field offset: 0x18

	public DistantObject() { }

	public void Initialize(Vector3 trueSpawnGamePosition, Vector3 cameraGamePosition, float projectionFactor) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void UpdateDistantObject(Vector3 camemarGamePosition) { }

}

