namespace SYBO.Subway.Level.TrackEvents.CarActivities;

public class LerpedTurn : MonoBehaviour, ITurnable
{
	protected MovingCarActivity _movingCarActivity; //Field offset: 0xC
	protected bool _turning; //Field offset: 0x10
	protected float _colliderPassProgress; //Field offset: 0x14
	private Transform _transform; //Field offset: 0x18
	private Collider _turnTrigger; //Field offset: 0x1C
	private Transform _turnTarget; //Field offset: 0x20
	private Quaternion _turnStartRotation; //Field offset: 0x24
	private float _distanceStartToTarget; //Field offset: 0x34
	private Vector3 _vectStartToTarget; //Field offset: 0x38
	private Vector3 _dirToTarget; //Field offset: 0x44
	private Vector3 _turnStartPoint; //Field offset: 0x50
	private Vector3 _turnTargetDirectionForward; //Field offset: 0x5C
	private Quaternion _turnTargetRotation; //Field offset: 0x68
	private Vector3 _turnHalfWayDirectionForward; //Field offset: 0x78
	private Vector3 _turnHalfWayDirectionUp; //Field offset: 0x84
	private Quaternion _turnHalfWayRotation; //Field offset: 0x90

	public LerpedTurn() { }

	public void Init(MovingCarActivity movingCarActivity) { }

	public void Reset() { }

	public void StartTurning(Collider trigger) { }

	public virtual void Turn() { }

}

