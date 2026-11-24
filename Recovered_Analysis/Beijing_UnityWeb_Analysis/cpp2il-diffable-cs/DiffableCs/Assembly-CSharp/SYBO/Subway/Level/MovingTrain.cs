namespace SYBO.Subway.Level;

public class MovingTrain : MonoBehaviour
{
	private static float autoPilotActivationDistance; //Field offset: 0x0
	private static MovingTrainUpdater _updater; //Field offset: 0x4
	private static HashSet<MovingTrain> _activeTrains; //Field offset: 0x8
	private Transform _characterControllerTransform; //Field offset: 0xC
	private float speed; //Field offset: 0x10
	private float trainCount; //Field offset: 0x14
	private AudioClip trianPassClip; //Field offset: 0x18
	private Transform _transform; //Field offset: 0x1C
	private Transform _train; //Field offset: 0x20
	private BoxCollider _trainCollider; //Field offset: 0x24
	private Vector3 _trainColliderInitialSize; //Field offset: 0x28
	private TrackObject _trackObject; //Field offset: 0x34
	private bool _active; //Field offset: 0x38
	private bool _autoPilot; //Field offset: 0x39
	private bool _initalized; //Field offset: 0x3A
	private float _distanceToCameraZ; //Field offset: 0x3C

	public bool Active
	{
		 get { } //Length: 66
	}

	public float DistanceToCameraZ
	{
		 get { } //Length: 6
	}

	public float Speed
	{
		 get { } //Length: 52
		 set { } //Length: 8
	}

	private static MovingTrain() { }

	public MovingTrain() { }

	public static void ActivateAutoPilot() { }

	private void Awake() { }

	private void CheckInitialize() { }

	public override bool Equals(object o) { }

	public bool get_Active() { }

	public float get_DistanceToCameraZ() { }

	public float get_Speed() { }

	public static int GetActiveTrainCount() { }

	public override int GetHashCode() { }

	public Vector3 GetTrainModelPosition() { }

	private void OnActivate() { }

	private void OnDeactivate() { }

	private void OnDestroy() { }

	public void set_Speed(float value) { }

	public void UpdateMovingTrain(float gameSpeed, float characterPositionZ, float cameraPositionZ) { }

	private void UpdateTrainCollider() { }

}

