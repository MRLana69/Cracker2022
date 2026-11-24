//Type is in global namespace

public class CurvePoint : MonoBehaviour
{
	public float t; //Field offset: 0xC
	public bool smoothTangents; //Field offset: 0x10
	public CurvePointTangent customIn; //Field offset: 0x14
	public CurvePointTangent customOut; //Field offset: 0x18
	public float weight; //Field offset: 0x1C

	public Vector3 TangentInPoint
	{
		 get { } //Length: 294
	}

	public Vector3 TangentOutPoint
	{
		 get { } //Length: 151
	}

	public CurvePoint() { }

	public Vector3 get_TangentInPoint() { }

	public Vector3 get_TangentOutPoint() { }

	private string GetName() { }

	public void OnDrawGizmosSelected() { }

}

