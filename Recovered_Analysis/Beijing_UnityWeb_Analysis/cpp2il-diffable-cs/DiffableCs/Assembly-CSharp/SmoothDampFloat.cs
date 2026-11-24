//Type is in global namespace

public class SmoothDampFloat
{
	private float _target; //Field offset: 0x8
	private float _smoothTime; //Field offset: 0xC
	private float _value; //Field offset: 0x10
	public float valueSpeed; //Field offset: 0x14

	public float SmoothTime
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float Target
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float Value
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public SmoothDampFloat(float value, float smoothTime) { }

	public float get_SmoothTime() { }

	public float get_Target() { }

	public float get_Value() { }

	public void set_SmoothTime(float value) { }

	public void set_Target(float value) { }

	public void set_Value(float value) { }

	public override string ToString() { }

	public void Update() { }

}

