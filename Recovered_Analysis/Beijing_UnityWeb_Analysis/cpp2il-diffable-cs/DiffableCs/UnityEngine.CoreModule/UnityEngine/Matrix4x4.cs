namespace UnityEngine;

public struct Matrix4x4 : IEquatable<Matrix4x4>
{
	private static readonly Matrix4x4 zeroMatrix; //Field offset: 0x0
	private static readonly Matrix4x4 identityMatrix; //Field offset: 0x40
	public float m00; //Field offset: 0x0
	public float m10; //Field offset: 0x4
	public float m20; //Field offset: 0x8
	public float m30; //Field offset: 0xC
	public float m01; //Field offset: 0x10
	public float m11; //Field offset: 0x14
	public float m21; //Field offset: 0x18
	public float m31; //Field offset: 0x1C
	public float m02; //Field offset: 0x20
	public float m12; //Field offset: 0x24
	public float m22; //Field offset: 0x28
	public float m32; //Field offset: 0x2C
	public float m03; //Field offset: 0x30
	public float m13; //Field offset: 0x34
	public float m23; //Field offset: 0x38
	public float m33; //Field offset: 0x3C

	public static Matrix4x4 identity
	{
		 get { } //Length: 329
	}

	public Matrix4x4 inverse
	{
		 get { } //Length: 232
	}

	public int Item
	{
		 set { } //Length: 345
	}

	public float Item
	{
		 get { } //Length: 51
		 set { } //Length: 16
	}

	public static Matrix4x4 zero
	{
		 get { } //Length: 228
	}

	private static Matrix4x4() { }

	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	public override bool Equals(object other) { }

	public bool Equals(Matrix4x4 other) { }

	public static Matrix4x4 get_identity() { }

	public Matrix4x4 get_inverse() { }

	public float get_Item(int index) { }

	public static Matrix4x4 get_zero() { }

	public Vector4 GetColumn(int index) { }

	public override int GetHashCode() { }

	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	public Vector3 MultiplyPoint(Vector3 point) { }

	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	public Vector3 MultiplyVector(Vector3 vector) { }

	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	public static Matrix4x4 Scale(Vector3 vector) { }

	public void set_Item(int index, float value) { }

	public void set_Item(int row, int column, float value) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public override string ToString() { }

	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

}

