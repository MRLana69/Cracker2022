using Cpp2ILInjected;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	private Transform m_trans;

	public float Rotate_X;

	public float Rotate_Y;

	public float Rotate_Z;

	private void Start()
	{
		GameObject gameObject = base.gameObject;
		Transform trans = gameObject.transform;
		m_trans = trans;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bc: Expected F4, but got I
		//IL_00b7: Expected native int or pointer, but got VT
		//IL_00fd: Expected F4, but got I
		//IL_00f8: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (Rotate_X != 0f || Rotate_Y != 0f || Rotate_Z != 0f)
		{
			float deltaTime = Time.deltaTime;
			float deltaTime2 = Time.deltaTime;
			float deltaTime3 = Time.deltaTime;
			float num = Rotate_Z * deltaTime3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			float num2 = Rotate_Y * deltaTime2;
			float num3 = Rotate_X * deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			m_trans.Rotate(vector);
		}
	}
}
