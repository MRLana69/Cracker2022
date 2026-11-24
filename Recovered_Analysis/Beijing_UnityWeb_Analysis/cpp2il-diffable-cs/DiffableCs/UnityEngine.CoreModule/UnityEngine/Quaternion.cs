namespace UnityEngine;

public struct Quaternion : IEquatable<Quaternion>
{
	private static readonly Quaternion identityQuaternion; //Field offset: 0x0
	public const float kEpsilon = 1E-06; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8
	public float w; //Field offset: 0xC

	public Vector3 eulerAngles
	{
		 get { } //Length: 214
		 set { } //Length: 14
	}

	public static Quaternion identity
	{
		 get { } //Length: 183
	}

	private static Quaternion() { }

	public Quaternion(float x, float y, float z, float w) { }

	public static float Angle(Quaternion a, Quaternion b) { }

	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	public static float Dot(Quaternion a, Quaternion b) { }

	public override bool Equals(object other) { }

	public bool Equals(Quaternion other) { }

	public static Quaternion Euler(float x, float y, float z) { }

	public static Quaternion Euler(Vector3 euler) { }

	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	public Vector3 get_eulerAngles() { }

	public static Quaternion get_identity() { }

	public override int GetHashCode() { }

	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	public static Quaternion Inverse(Quaternion rotation) { }

	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	private static bool IsEqualUsingDot(float dot) { }

	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	public static Quaternion LookRotation(Vector3 forward) { }

	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }

	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	public void set_eulerAngles(Vector3 value) { }

	public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	public void SetLookRotation(Vector3 view, Vector3 up) { }

	public void SetLookRotation(Vector3 view) { }

	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	public override string ToString() { }

}

