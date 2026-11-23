using UnityEngine;

public class Rotator : MonoBehaviour
{
	private void Start()
	{
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0027: Expected native int or pointer, but got VT
		//IL_003b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Transform transform = base.transform;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 1056964608;
		((Vector3*)(nint)vector)->x = 0.5f;
		transform.Rotate(vector);
	}
}
