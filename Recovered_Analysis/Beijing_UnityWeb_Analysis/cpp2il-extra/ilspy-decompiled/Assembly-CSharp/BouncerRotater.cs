using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class BouncerRotater : MonoBehaviour
{
	private float yRotateSpeed;

	private float yBounceAmp;

	private float yBounceSpeed;

	private float timeOffset;

	private Vector3 initialTransform;

	private void Awake()
	{
		//IL_000b: Expected F4, but got I4
		yBounceAmp = 1f;
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0017: Expected VT, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		Transform transform = default;
		transform.localPosition = (Vector3)gameObject;
		object obj = transform + 12;
		obj = transform;
		_ = ((Object)transform).m_CachedPtr;
		object obj2 = this + 28;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
		_ = 0;
	}

	public unsafe BouncerRotater()
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected VT, but got Unknown
		//IL_0258: Expected F4, but got Obj
		//IL_0253: Expected native int or pointer, but got VT
		//IL_026d: Expected F4, but got I
		//IL_0268: Expected native int or pointer, but got VT
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected VT, but got Unknown
		//IL_02b8: Expected F4, but got Obj
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02cd: Expected F4, but got I
		//IL_02c8: Expected native int or pointer, but got VT
		//IL_02da: Expected F4, but got Obj
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02ef: Expected F4, but got I
		//IL_02ea: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected F4, but got Obj
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00c1: Expected F4, but got I
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00ca: Expected Obj, but got VT
		//IL_0060: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = this + 28;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v3+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 24;
		Vector3 down = Vector3.down;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S3_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = timeSinceLevelLoad + timeOffset;
		float num6 = num5 * yBounceSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj7 = obj2 + 36;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v13+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 72);
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj8 = obj2 + 12;
		object obj9 = default;
		float num7 = (float)obj9 * yBounceAmp;
		Vector3 vector2 = vector / num7;
		Vector3 vector3 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector3)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v28+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector4 = vector3 - vector;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		GameObject gameObject2 = base.gameObject;
		float unscaledTime = Time.unscaledTime;
		float start = unscaledTime * yRotateSpeed;
		((Dropdown)(object)gameObject2).AlphaFadeList(0f, start, 0f);
	}
}
