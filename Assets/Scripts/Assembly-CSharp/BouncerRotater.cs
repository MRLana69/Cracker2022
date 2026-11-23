using Cpp2ILInjected;
using UnityEngine;

public class BouncerRotater : MonoBehaviour
{
	private float yRotateSpeed = 0.1f;

	private float yBounceAmp;

	private float yBounceSpeed = 0.1f;

	private float timeOffset;

	private Vector3 initialTransform;

	private void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		initialTransform = (Vector3)obj;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006c: Expected I, but got Obj
		//IL_011a: Expected F4, but got I
		//IL_0115: Expected native int or pointer, but got VT
		//IL_0178: Expected F4, but got I
		//IL_0173: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Transform transform = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float time = Time.time;
		float num3 = time + timeOffset;
		float num4 = num3 * yBounceSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
		object obj2 = default;
		float num5 = (float)obj2 * yBounceAmp;
		float num6 = (float)Vector3.upVector * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num7 = 0f * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BouncerRotater)+24]");
		float num8 = 0f + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num9 = 0f * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BouncerRotater)+20]");
		float num10 = 0f + num9;
		float num11 = (float)initialTransform + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
		Transform transform2 = base.transform;
		float deltaTime = Time.deltaTime;
		float yAngle = deltaTime * yRotateSpeed;
		transform2.Rotate(0f, yAngle, 0f);
	}
}
