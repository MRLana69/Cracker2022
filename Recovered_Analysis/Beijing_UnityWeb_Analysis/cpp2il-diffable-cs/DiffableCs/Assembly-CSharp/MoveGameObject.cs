//Type is in global namespace

public class MoveGameObject : MonoBehaviour
{
	private const float MinCameraSpeedDelta = 0.15; //Field offset: 0x0
	public Vector3 vector; //Field offset: 0xC
	public float MaxMagnitude; //Field offset: 0x18
	public float Speed; //Field offset: 0x1C
	public Transform model; //Field offset: 0x20
	private CharacterCamera characterCamera; //Field offset: 0x24
	private float _speedMultiplier; //Field offset: 0x28
	private float _lastCameraSpeed; //Field offset: 0x2C
	private Vector3 _startLocal; //Field offset: 0x30

	public float SpeedMultiplier
	{
		 get { } //Length: 88
		 set { } //Length: 341
	}

	public MoveGameObject() { }

	public float get_SpeedMultiplier() { }

	public void set_SpeedMultiplier(float value) { }

	public void Update() { }

	public void UpdatePosition(Vector3 localPos) { }

}

