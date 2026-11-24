//Type is in global namespace

public class CurveParent : MonoBehaviour
{
	private bool _disableGizmos; //Field offset: 0xC
	public Color color; //Field offset: 0x10
	private Vector3 _localPositionAtCaching; //Field offset: 0x20
	private Curve _cachedCurve; //Field offset: 0x2C
	private bool _forceLinearZ; //Field offset: 0x30

	public Curve CachedCurve
	{
		 get { } //Length: 3
	}

	public float MaxTime
	{
		 get { } //Length: 9
	}

	public float MinTime
	{
		 get { } //Length: 12
	}

	public CurveParent() { }

	private static Curve CreateCurve(Transform curvePointsParent) { }

	private static Curve CreateCurve(Transform curvePointsParent, Vector3 offset) { }

	private void DrawCurve(Color color) { }

	public void ForceLinearZ(bool v) { }

	public Curve get_CachedCurve() { }

	public float get_MaxTime() { }

	public float get_MinTime() { }

	public string GetDebugText() { }

	public Vector3 GetDerivativeForTime(float time) { }

	public Vector3 GetLocalPositionForTime(float time) { }

	public Quaternion GetRotationForTime(float time, float timeOffset = 0.25) { }

	public float GetTimeForLocalZ(float z, bool clampForInvalidTime = false) { }

	public float GetTimeForWorldZ(float z, bool clampForInvalidTime = false) { }

	public Vector3 GetWorldPositionForTime(float time, bool clampForInvalidTime = false) { }

	public bool HasTimeForLocalZ(float z) { }

	public bool HasTimeForWorldZ(float z) { }

	private void LinearizeZ() { }

	public void OnDrawGizmos() { }

	public void RecacheCurve() { }

}

