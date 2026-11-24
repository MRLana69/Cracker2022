namespace SYBO.Common.Data;

public class SmoothDampVector3B
{
	private Vector3 _target; //Field offset: 0x8
	private Vector3 _smoothTime; //Field offset: 0x14
	private Vector3 _value; //Field offset: 0x20
	private Vector3 _velocity; //Field offset: 0x2C

	public Vector3 SmoothTime
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public Vector3 Target
	{
		 get { } //Length: 64
		 set { } //Length: 26
	}

	public float TargetX
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public float TargetY
	{
		 get { } //Length: 9
		 set { } //Length: 121
	}

	public float TargetZ
	{
		 get { } //Length: 9
		 set { } //Length: 121
	}

	public Vector3 Value
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public Vector3 Velocity
	{
		 get { } //Length: 61
	}

	public SmoothDampVector3B(Vector3 value, Vector3 smoothTime) { }

	public Vector3 get_SmoothTime() { }

	public Vector3 get_Target() { }

	public float get_TargetX() { }

	public float get_TargetY() { }

	public float get_TargetZ() { }

	public Vector3 get_Value() { }

	public Vector3 get_Velocity() { }

	public void set_SmoothTime(Vector3 value) { }

	public void set_Target(Vector3 value) { }

	public void set_TargetX(float value) { }

	public void set_TargetY(float value) { }

	public void set_TargetZ(float value) { }

	public void set_Value(Vector3 value) { }

	public override string ToString() { }

	public void Update() { }

}

