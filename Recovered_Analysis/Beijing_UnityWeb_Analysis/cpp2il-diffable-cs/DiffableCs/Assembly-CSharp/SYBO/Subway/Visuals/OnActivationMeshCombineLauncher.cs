namespace SYBO.Subway.Visuals;

public class OnActivationMeshCombineLauncher : MonoBehaviour
{
	private TrackObject _trackObject; //Field offset: 0xC
	private MeshCombiner _meshCombiner; //Field offset: 0x10

	public OnActivationMeshCombineLauncher() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void TrackObject_OnActivate() { }

	private void TrackObject_OnDeactivate() { }

}

