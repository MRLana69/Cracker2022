namespace SYBO.Subway.Pickups;

public class PickupRotate : MonoBehaviour
{
	private Transform _target; //Field offset: 0xC
	private float _speed; //Field offset: 0x10
	private float _rotatePhase; //Field offset: 0x14
	private float _worldPosZ; //Field offset: 0x18
	private Vector3 _localEuler; //Field offset: 0x1C
	private bool _willRotate; //Field offset: 0x28

	public bool WillRotate
	{
		 get { } //Length: 179
	}

	public PickupRotate() { }

	private void Activate() { }

	public void Awake() { }

	public bool get_WillRotate() { }

	protected void OnDestroy() { }

	public void PhasedRotate(float time) { }

	private void PickupController_OnActivate() { }

	private void StopRotating() { }

	private void TrackObject_OnActivate() { }

	private void TrackObject_OnDeactivate() { }

}

