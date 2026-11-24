//Type is in global namespace

public class Curve
{
	public AnimationCurve curveX; //Field offset: 0x8
	public AnimationCurve curveY; //Field offset: 0xC
	public AnimationCurve curveZ; //Field offset: 0x10
	private Vector3 <MinCoords>k__BackingField; //Field offset: 0x14
	private Vector3 <MaxCoords>k__BackingField; //Field offset: 0x20
	private float <MinTime>k__BackingField; //Field offset: 0x2C
	private float <MaxTime>k__BackingField; //Field offset: 0x30

	public Vector3 MaxCoords
	{
		 get { } //Length: 61
		private set { } //Length: 26
	}

	public float MaxTime
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public Vector3 MinCoords
	{
		 get { } //Length: 231
		private set { } //Length: 26
	}

	public float MinTime
	{
		 get { } //Length: 10
		private set { } //Length: 8
	}

	public Curve() { }

	public void AddKey(float t, Vector3 value) { }

	public void AddKey(float t, Vector3 value, Vector3 inTangent, Vector3 outTangent) { }

	public void DrawGizmos(Color color) { }

	public Vector3 Evaluate(float t) { }

	public Vector3 EvaluateDerivative(float t) { }

	public Vector3 get_MaxCoords() { }

	public float get_MaxTime() { }

	public Vector3 get_MinCoords() { }

	public float get_MinTime() { }

	public void MoveKey(int index, float t, Vector3 value, Vector3 inTangent, Vector3 outTangent) { }

	public void MoveKey(int index, float t, Vector3 value) { }

	private void set_MaxCoords(Vector3 value) { }

	private void set_MaxTime(float value) { }

	private void set_MinCoords(Vector3 value) { }

	private void set_MinTime(float value) { }

	public void SmoothTangents(int index, float weight) { }

	private void UpdateMinMaxCoords(Vector3 v) { }

	private void UpdateMinMaxTime(float t) { }

}

