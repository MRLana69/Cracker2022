using System;
using Cpp2ILInjected;
using UnityEngine;

public class RotateAroundTransform : MonoBehaviour
{
	private Transform _target;

	private Vector3 _offset;

	private Vector3 _eulerAngles;

	private float _distance;

	private Vector3 _lastMousePosition;

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0024: Expected VT, but got F4
		//IL_0033: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		_target = (Transform)128;
		_offset = (Vector3)0.01f;
		_ = 500f;
		obj = 0;
		obj = -1;
		obj2 = obj;
		object obj3 = obj2 + 4;
		obj3 = obj2;
		CancelInvoke();
	}

	public unsafe RotateAroundTransform()
	{
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_0585: Expected Obj, but got I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05a2: Expected Obj, but got I4
		//IL_05b6: Expected I, but got Obj
		//IL_05cc: Expected Obj, but got I
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected I4, but got Unknown
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected VT, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected Obj, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected Obj, but got Unknown
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected Obj, but got Unknown
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected Obj, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected Ref, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got Unknown
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected VT, but got Unknown
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected Obj, but got Unknown
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected Obj, but got Unknown
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected Obj, but got Unknown
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_02c3: Expected I, but got Obj
		//IL_02d9: Expected Obj, but got I
		//IL_090b: Expected I4, but got F4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I4
		//IL_088f: Expected VT, but got Obj
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08bd: Expected I, but got Obj
		//IL_08d3: Expected Obj, but got I
		//IL_0304: Expected I, but got Obj
		//IL_05ff: Expected F4, but got Obj
		//IL_05fa: Expected native int or pointer, but got VT
		//IL_0611: Expected F4, but got I
		//IL_060c: Expected native int or pointer, but got VT
		//IL_061e: Expected I4, but got Obj
		//IL_0638: Expected VT, but got I4
		//IL_0927: Expected F4, but got Obj
		//IL_0922: Expected native int or pointer, but got VT
		//IL_0939: Expected F4, but got I
		//IL_0934: Expected native int or pointer, but got VT
		//IL_0946: Expected I4, but got Obj
		//IL_0960: Expected VT, but got I4
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected Obj, but got Unknown
		//IL_09c6: Expected I, but got Obj
		//IL_09dc: Expected Obj, but got I
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_068c: Expected I, but got Obj
		//IL_06a2: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		//IL_0a06: Expected I4, but got Obj
		//IL_0a3b: Expected F4, but got VT
		//IL_0a36: Expected native int or pointer, but got VT
		//IL_0a50: Expected F4, but got I
		//IL_0a4b: Expected native int or pointer, but got VT
		//IL_0a5d: Expected I4, but got Obj
		//IL_0a7b: Expected VT, but got I4
		//IL_0a7b: Expected Ref, but got VT
		//IL_0351: Expected I, but got Obj
		//IL_06cc: Expected F4, but got Obj
		//IL_06c7: Expected native int or pointer, but got VT
		//IL_06de: Expected F4, but got I
		//IL_06d9: Expected native int or pointer, but got VT
		//IL_06eb: Expected I4, but got Obj
		//IL_0705: Expected VT, but got I4
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_0736: Expected F4, but got Obj
		//IL_0731: Expected native int or pointer, but got VT
		//IL_074b: Expected F4, but got I
		//IL_0746: Expected native int or pointer, but got VT
		//IL_0767: Expected Obj, but got F4
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_07c2: Expected F4, but got Obj
		//IL_07d0: Expected I, but got Obj
		//IL_07e6: Expected Obj, but got I
		//IL_01a3: Expected I4, but got F4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_03ef: Expected I4, but got F4
		//IL_0408: Expected VT, but got I4
		//IL_0419: Expected F4, but got Obj
		//IL_0414: Expected native int or pointer, but got VT
		//IL_042e: Expected F4, but got I
		//IL_0429: Expected native int or pointer, but got VT
		//IL_043b: Expected I4, but got Obj
		//IL_0455: Expected VT, but got I4
		//IL_039e: Expected I, but got Obj
		//IL_01e5: Expected I, but got Obj
		//IL_046b: Expected I4, but got Obj
		//IL_0481: Expected Obj, but got I4
		//IL_0232: Expected I, but got Obj
		//IL_04a3: Expected VT, but got Obj
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04d0: Expected F4, but got Obj
		//IL_04cb: Expected native int or pointer, but got VT
		//IL_04e2: Expected F4, but got I
		//IL_04dd: Expected native int or pointer, but got VT
		//IL_04ef: Expected I4, but got Obj
		//IL_0509: Expected VT, but got I4
		//IL_0833: Expected Obj, but got F4
		//IL_0849: Expected I4, but got Obj
		//IL_0528: Expected F4, but got Obj
		//IL_0523: Expected native int or pointer, but got VT
		//IL_053d: Expected F4, but got I
		//IL_0538: Expected native int or pointer, but got VT
		//IL_054a: Expected I4, but got Obj
		//IL_0568: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 + 184;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 172;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v221 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IMECompositionMode iMECompositionMode = (IMECompositionMode)(obj2 + 216);
		Vector3 vector = (Vector3)(obj2 + 200);
		Transform transform = (Transform)(obj2 + 160);
		object obj5 = obj2 + 148;
		object obj6 = obj2 + 136;
		object obj7 = obj2 + 124;
		object obj8 = obj2 + 112;
		ref Quaternion reference = ref *(Quaternion*)(obj2 + 96);
		object obj9 = obj2 + 84;
		Quaternion quaternion = (Quaternion)(obj2 + 72);
		object obj10 = obj2 + 60;
		object obj11 = obj2 + 48;
		Transform transform2 = (Transform)(obj2 + 36);
		object obj12 = obj2 + 24;
		object obj13 = obj2 + 12;
		if (((ComputeShader)(object)_target).FindKernel((string)null) == 0)
		{
			return;
		}
		Input.imeCompositionMode = iMECompositionMode;
		float unscaledTime = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15 (UnityEngine.IMECompositionMode)+4]");
		float num3 = 0f * unscaledTime;
		float num4 = num3 * 10f;
		float distance = _distance - num4;
		_distance = distance;
		if (Input.GetMouseButtonDown(0))
		{
			object obj14 = this + 44;
			transform = (Transform)obj14;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v135+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v67 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v121 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21+8]");
			_ = 0;
			if (vector != (Vector3)iMECompositionMode)
			{
				Vector2 mouseScrollDelta = Input.mouseScrollDelta;
				((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)vector.x;
				_ = vector.z;
				object obj16 = this + 44;
				obj16 = ((IMECompositionMode*)(int)iMECompositionMode)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15 (UnityEngine.IMECompositionMode)+8]");
				_ = 0;
			}
			Vector2 mouseScrollDelta2 = Input.mouseScrollDelta;
			object obj17 = this + 44;
			obj5 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v153+8]");
			_ = 0;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v83 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S0_v111 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21+8]");
			_ = 0;
			Quaternion quaternion2 = Quaternion.FromToRotation(vector, (Vector3)iMECompositionMode);
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23+8]");
			_ = 0;
			object obj19 = this + 32;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			float num9 = (float)obj19 + vector.x;
			obj19 = num9;
			object obj20 = this + 28;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v25+4]");
			object obj22 = obj21 - 0;
			obj20 = obj22;
			object obj23 = this + 28;
			object obj24 = this + 28;
			float num10 = (float)obj24;
			nint num11 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v190 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S1_v207 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num10 < -89f)
			{
				num10 = -89f;
			}
			else if (num10 > 89f)
			{
				num10 = 89f;
			}
			obj23 = num10;
			Vector2 mouseScrollDelta3 = Input.mouseScrollDelta;
			((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+8]");
			_ = 0;
		}
		else
		{
			nint num13 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v53 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num14 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one2 = Vector3.one;
			((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)vector.x;
			_ = vector.z;
		}
		object obj27 = this + 44;
		obj27 = ((IMECompositionMode*)(int)iMECompositionMode)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15 (UnityEngine.IMECompositionMode)+8]");
		_ = 0;
		transform.position = (Vector3)_target;
		object obj28 = this + 16;
		obj5 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v59+8]");
		_ = 0;
		nint num15 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v33 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num16 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21+8]");
		_ = 0;
		Vector3 vector3 = vector - (Vector3)iMECompositionMode;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23+8]");
		_ = 0;
		GameObject gameObject = base.gameObject;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj30 = this + 28;
		obj8 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S2_v32+8]");
		_ = 0;
		nint num17 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v83 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num18 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S1_v124 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)(int)iMECompositionMode);
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector)->x = (float)reference;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v29 (UnityEngine.Quaternion&)+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v31+8]");
		_ = 0;
		((Quaternion*)quaternion)->SetLookRotation(vector, (Vector3)iMECompositionMode);
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)quaternion.x;
		_ = quaternion.z;
		Vector3 vector5 = (Vector3)iMECompositionMode / _distance;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v25+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v35+8]");
		_ = 0;
		Quaternion quaternion3 = Quaternion.FromToRotation(vector, (Vector3)iMECompositionMode);
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v37+8]");
		_ = 0;
		Vector3 localPosition = ((Transform)iMECompositionMode).localPosition;
		GameObject gameObject2 = base.gameObject;
		transform2.position = (Vector3)_target;
		object obj32 = this + 16;
		obj12 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S2_v74+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v41+8]");
		_ = 0;
		Vector3 vector7 = vector - (Vector3)iMECompositionMode;
		Vector3 down = Vector3.down;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v43+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((IMECompositionMode*)(int)iMECompositionMode)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Transform)(object)gameObject2).Internal_LookAt(vector, (Vector3)iMECompositionMode);
	}
}
