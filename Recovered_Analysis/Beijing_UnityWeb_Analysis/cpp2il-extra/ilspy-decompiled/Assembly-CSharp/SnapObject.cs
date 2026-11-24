using Cpp2ILInjected;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
	public Vector3 spacing;

	public Vector3 offset;

	protected unsafe void Awake()
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Ref, but got Unknown
		//IL_0166: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_01be: Expected F4, but got I
		//IL_01be: Expected F4, but got Obj
		//IL_01be: Expected F4, but got Obj
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Ref, but got Unknown
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_029b: Expected F4, but got I
		//IL_029b: Expected F4, but got I
		//IL_029b: Expected F4, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got F4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Ref, but got Unknown
		//IL_0310: Expected I, but got Obj
		//IL_0326: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_0378: Expected F4, but got I
		//IL_0378: Expected F4, but got I
		//IL_0378: Expected F4, but got I
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00da: Expected I, but got Obj
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		object obj = this + 24;
		object obj2 = this + 8;
		ref float currentVelocity = ref *(float*)(this + 36);
		float unscaledTime = Time.unscaledTime;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S4_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+14]");
		float maxSpeed = default;
		float num3 = Mathf.SmoothDampAngle((float)obj, (float)obj2, ref currentVelocity, 0f, maxSpeed, unscaledTime);
		object obj4 = num3 & 0x7FFFFFFF;
		if ((nint)obj4 <= 2139095040)
		{
			object obj5 = this + 24;
			obj5 = num3;
		}
		object obj6 = this + 24;
		object obj7 = this + 8;
		ref float currentVelocity2 = ref *(float*)(this + 40);
		float unscaledTime2 = Time.unscaledTime;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v29 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13+4]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v11+4]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+14]");
		float num8 = Mathf.SmoothDampAngle(num6, num7, ref currentVelocity2, 0f, maxSpeed, unscaledTime2);
		object obj9 = num8 & 0x7FFFFFFF;
		if ((nint)obj9 <= 2139095040)
		{
			object obj10 = this + 24;
		}
		object obj11 = this + 24;
		object obj12 = this + 8;
		ref float currentVelocity3 = ref *(float*)(this + 44);
		float unscaledTime3 = Time.unscaledTime;
		nint num9 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v25 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v20+8]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v18+8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+14]");
		float num13 = Mathf.SmoothDampAngle(num11, num12, ref currentVelocity3, 0f, maxSpeed, unscaledTime3);
		object obj14 = num13 & 0x7FFFFFFF;
		if ((nint)obj14 <= 2139095040)
		{
			object obj15 = this + 24;
		}
	}

	protected virtual void Reset()
	{
	}

	public void Snap()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		obj = 10f;
		_ = 10f;
		_ = 10f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 24;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
	}

	public unsafe SnapObject()
	{
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01f8: Expected VT, but got Obj
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_024e: Expected I, but got Obj
		//IL_0264: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_039b: Expected Obj, but got I
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_010d: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected VT, but got Unknown
		//IL_03ea: Expected F4, but got Obj
		//IL_03e5: Expected native int or pointer, but got VT
		//IL_03fc: Expected F4, but got I
		//IL_03f7: Expected native int or pointer, but got VT
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected VT, but got Unknown
		//IL_0417: Expected F4, but got Obj
		//IL_0412: Expected native int or pointer, but got VT
		//IL_042c: Expected F4, but got I
		//IL_0427: Expected native int or pointer, but got VT
		//IL_0454: Expected F4, but got Obj
		//IL_044f: Expected native int or pointer, but got VT
		//IL_0469: Expected F4, but got I
		//IL_0464: Expected native int or pointer, but got VT
		//IL_0472: Expected Obj, but got VT
		//IL_0176: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 60);
		GameObject gameObject = base.gameObject;
		transform.localPosition = (Vector3)gameObject;
		obj = transform;
		_ = ((Object)transform).m_CachedPtr;
		object obj3 = obj2 + 48;
		obj3 = transform;
		_ = ((Object)transform).m_CachedPtr;
		object obj4 = this + 24;
		object obj5 = this + 12;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj3 - obj4;
		float width = (float)obj7 / (float)obj5;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		object obj8 = this + 12;
		object obj9 = this + 24;
		object obj10 = obj2 + 36;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj11 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v31+4]");
		object obj12 = num3 - 0;
		object obj13 = this + 12;
		float num4 = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v34+4]");
		float width2 = num4 / 0f;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(width2);
		object obj14 = this + 12;
		object obj15 = this + 24;
		object obj16 = obj2 + 24;
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj17 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v44+8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v45+8]");
		object obj18 = num5 - 0;
		object obj19 = this + 12;
		float num6 = (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v48+8]");
		float width3 = num6 / 0f;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width3);
		object obj20 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v52+8]");
		object obj21 = gUILayoutOption3 * 0;
		object obj22 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v55+8]");
		object obj23 = obj21 + 0;
		object obj24 = (object)gUILayoutOption * obj8;
		object obj25 = obj24 + obj9;
		obj = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v38+4]");
		object obj26 = gUILayoutOption2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v41+4]");
		object obj27 = obj26 + 0;
		Transform transform2 = (Transform)(obj2 + 12);
		GameObject gameObject2 = base.gameObject;
		transform2.localPosition = (Vector3)gameObject2;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj2 + 84);
		((Quaternion*)(nint)quaternion)->x = (float)transform2;
		((Quaternion*)(nint)quaternion)->z = (nint)((Object)transform2).m_CachedPtr;
		Quaternion quaternion2 = (Quaternion)(obj2 + 96);
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		bool flag = quaternion == quaternion2;
		GameObject gameObject3 = base.gameObject;
		((Quaternion*)(nint)quaternion2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		Vector3 eulerAngles = ((Transform)quaternion2).eulerAngles;
	}
}
