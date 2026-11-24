//Type is in global namespace

public class SmoothDampVector3
{
	private Vector3 _target; //Field offset: 0x8
	private float _smoothTime; //Field offset: 0x14
	private Vector3 _value; //Field offset: 0x18
	private Vector3 _velocity; //Field offset: 0x24

	public float SmoothTime
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Vector3 Target
	{
		 get { } //Length: 81
		 set { } //Length: 26
	}

	public Vector3 Value
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public Vector3 Velocity
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public SmoothDampVector3(Vector3 value, float smoothTime) { }

	public float get_SmoothTime() { }

	public Vector3 get_Target() { }

	public Vector3 get_Value() { }

	public Vector3 get_Velocity() { }

	public void set_SmoothTime(float value) { }

	public void set_Target(Vector3 value) { }

	public void set_Value(Vector3 value) { }

	public void set_Velocity(Vector3 value) { }

	public override string ToString() { }

	public void Update() { }

}

