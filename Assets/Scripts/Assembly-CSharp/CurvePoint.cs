using Cpp2ILInjected;
using UnityEngine;

public class CurvePoint : MonoBehaviour
{
	public float t;

	public bool smoothTangents = true;

	public CurvePointTangent customIn;

	public CurvePointTangent customOut;

	public float weight = 50f;

	public unsafe Vector3 TangentInPoint
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_009c: Expected I, but got Obj
			//IL_00ba: Expected F4, but got VT
			//IL_00b5: Expected native int or pointer, but got VT
			//IL_00cf: Expected F4, but got I
			//IL_00ca: Expected native int or pointer, but got VT
			//IL_0049: Expected F4, but got I
			//IL_0044: Expected native int or pointer, but got VT
			//IL_0056: Expected F4, but got Obj
			//IL_0051: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 vector = default;
			if (customIn != null)
			{
				Transform transform = customIn.transform;
				Vector3 localPosition = transform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj;
			}
			else
			{
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				((Vector3*)(nint)vector)->x = (float)Vector3.backVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
				((Vector3*)(nint)vector)->z = 0f;
			}
			return vector;
		}
	}

	public unsafe Vector3 TangentOutPoint
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_009c: Expected I, but got Obj
			//IL_00ba: Expected F4, but got VT
			//IL_00b5: Expected native int or pointer, but got VT
			//IL_00cf: Expected F4, but got I
			//IL_00ca: Expected native int or pointer, but got VT
			//IL_0049: Expected F4, but got I
			//IL_0044: Expected native int or pointer, but got VT
			//IL_0056: Expected F4, but got Obj
			//IL_0051: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 vector = default;
			if (customOut != null)
			{
				Transform transform = customOut.transform;
				Vector3 localPosition = transform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj;
			}
			else
			{
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				((Vector3*)(nint)vector)->x = (float)Vector3.forwardVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
				((Vector3*)(nint)vector)->z = 0f;
			}
			return vector;
		}
	}

	private unsafe string GetName()
	{
		//IL_001b: Expected Ref, but got F4
		float num = (float)this + 12f;
		string text = ((float*)num)->ToString();
		return "CurvePoint (" + text + ")";
	}

	public unsafe void OnDrawGizmosSelected()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected VT, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected VT, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected VT, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected VT, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected VT, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected VT, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected VT, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected VT, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected VT, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected VT, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected VT, but got Unknown
		//IL_0496: Expected F4, but got I
		//IL_0491: Expected native int or pointer, but got VT
		//IL_04ab: Expected F4, but got I
		//IL_04a6: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 400);
		_ = 0;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 0;
		_ = 0;
		_ = 1065353216;
		_ = 1065353216;
		_ = 0;
		Color color = (Color)(vector + 192);
		Gizmos.color = color;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Vector3 center = vector + 176;
		Gizmos.DrawSphere(center, 0.5f);
		GameObject gameObject = base.gameObject;
		string text = gameObject.name;
		string text2 = GetName();
		if (text != text2)
		{
			GameObject gameObject2 = base.gameObject;
			string text3 = GetName();
			gameObject2.name = text3;
		}
		if (~(smoothTangents ? 1u : 0u) != 0)
		{
			Transform transform2 = base.transform;
			Vector3 tangentInPoint = TangentInPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Vector3 position2 = vector + 160;
			Vector3 vector2 = transform2.TransformPoint(position2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			Transform transform3 = base.transform;
			Vector3 tangentOutPoint = TangentOutPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Vector3 position3 = vector + 144;
			Vector3 vector3 = transform3.TransformPoint(position3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
			_ = 0;
			_ = 4575657222423478401L;
			_ = 4575657222423478401L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			_ = 4570005646807662592L;
			_ = 4570005646807662592L;
			Color color2 = (Color)(vector + 128);
			Gizmos.color = color2;
			Transform transform4 = base.transform;
			Vector3 position4 = transform4.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+188]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+180]");
			_ = 0;
			Vector3 vector4 = vector + 112;
			Vector3 to = vector + 96;
			Gizmos.DrawLine(vector4, to);
			Transform transform5 = base.transform;
			Vector3 position5 = transform5.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+178]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+170]");
			_ = 0;
			Vector3 vector5 = vector + 80;
			Vector3 to2 = vector - -64;
			Gizmos.DrawLine(vector5, to2);
			_ = 0.01254902f;
			_ = 0.8f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			_ = 188f / 255f;
			_ = 0.8f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Color color3 = (Color)(vector + 48);
			Gizmos.color = color3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+188]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+180]");
			_ = 0;
			Vector3 center2 = vector + 32;
			Gizmos.DrawSphere(center2, 0.3f);
			_ = 4575657222423478401L;
			_ = 4575657222423478401L;
			_ = 4570005646807662592L;
			_ = 4570005646807662592L;
			Color color4 = (Color)(vector + 16);
			Gizmos.color = color4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+178]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+170]");
			((Vector3*)(nint)vector)->x = 0f;
			Gizmos.DrawSphere(vector, 0.3f);
		}
	}
}
