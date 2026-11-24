using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIDragResize : MonoBehaviour
{
	public UIWidget target;

	public UIWidget.Pivot pivot;

	public int minWidth;

	public int minHeight;

	public int maxWidth;

	public int maxHeight;

	public bool updateAnchors;

	private Plane mPlane;

	private Vector3 mRayPos;

	private Vector3 mLocalPos;

	private int mWidth;

	private int mHeight;

	private bool mDragging = false;

	private void OnDragStart()
	{
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0134: Expected VT, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got F4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 36;
		Vector3 one = Vector3.one;
		object obj4 = obj3 + 48;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 20;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		mPlane = (Plane)2;
		_ = 35f;
		object obj6 = obj3 + 24;
		obj6 = 0;
		_ = 0;
		obj6 = 1f;
		_ = 1f;
		_ = 0f;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24+8]");
		_ = 0;
		object obj7 = this + 48;
		obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		object obj8 = obj3 + 12;
		Vector3 one2 = Vector3.one;
		obj4 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v35+8]");
		_ = 0;
		object obj9 = this + 104;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		Vector3 one3 = Vector3.one;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj10 = this + 116;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		CancelInvoke();
	}

	private unsafe void OnDrag(Vector2 delta)
	{
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_072d: Expected Obj, but got I4
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I4
		//IL_0782: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected VT, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected VT, but got Unknown
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Expected Obj, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9f: Expected Obj, but got Unknown
		//IL_0aab: Expected Obj, but got I4
		//IL_066d: Expected VT, but got Obj
		//IL_067a: Expected Obj, but got F4
		//IL_0695: Expected I, but got Obj
		//IL_06ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_09ee: Expected F4, but got Obj
		//IL_09e9: Expected native int or pointer, but got VT
		//IL_0a00: Expected F4, but got I
		//IL_09fb: Expected native int or pointer, but got VT
		//IL_0a0d: Expected F4, but got Obj
		//IL_0a08: Expected native int or pointer, but got VT
		//IL_0a22: Expected F4, but got I
		//IL_0a1d: Expected native int or pointer, but got VT
		//IL_0a40: Expected F4, but got Obj
		//IL_0a3b: Expected native int or pointer, but got VT
		//IL_0a55: Expected F4, but got I
		//IL_0a50: Expected native int or pointer, but got VT
		//IL_0a5e: Expected Obj, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got F4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_06d6: Expected I, but got Obj
		//IL_07c2: Expected F4, but got Obj
		//IL_07bd: Expected native int or pointer, but got VT
		//IL_07d4: Expected F4, but got I
		//IL_07cf: Expected native int or pointer, but got VT
		//IL_07e1: Expected F4, but got Obj
		//IL_07dc: Expected native int or pointer, but got VT
		//IL_07f6: Expected F4, but got I
		//IL_07f1: Expected native int or pointer, but got VT
		//IL_0814: Expected F4, but got Obj
		//IL_080f: Expected native int or pointer, but got VT
		//IL_0829: Expected F4, but got I
		//IL_0824: Expected native int or pointer, but got VT
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got Unknown
		//IL_0841: Expected Obj, but got F4
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_00e3: Expected I, but got Obj
		//IL_04b7: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got F4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0257: Expected F4, but got Obj
		//IL_0252: Expected native int or pointer, but got VT
		//IL_0269: Expected F4, but got I
		//IL_0264: Expected native int or pointer, but got VT
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05b2: Expected F4, but got Obj
		//IL_05ad: Expected native int or pointer, but got VT
		//IL_05c7: Expected F4, but got I
		//IL_05c2: Expected native int or pointer, but got VT
		//IL_05d4: Expected native int or pointer, but got VT
		//IL_05e6: Expected native int or pointer, but got VT
		//IL_05f4: Expected Obj, but got VT
		//IL_04f8: Expected I, but got Obj
		//IL_029a: Expected F4, but got Obj
		//IL_0295: Expected native int or pointer, but got VT
		//IL_02af: Expected F4, but got I
		//IL_02aa: Expected native int or pointer, but got VT
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0946: Expected Obj, but got I4
		//IL_0958: Expected I, but got Obj
		//IL_096e: Expected Obj, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_054f: Expected F4, but got Obj
		//IL_054a: Expected native int or pointer, but got VT
		//IL_0564: Expected F4, but got I
		//IL_055f: Expected native int or pointer, but got VT
		//IL_0571: Expected native int or pointer, but got VT
		//IL_0583: Expected native int or pointer, but got VT
		//IL_0591: Expected Obj, but got VT
		//IL_08dd: Expected I, but got Obj
		//IL_08f3: Expected Obj, but got I
		//IL_02fe: Expected I, but got Obj
		//IL_060b: Expected I, but got Obj
		//IL_047d: Expected F4, but got Obj
		//IL_0478: Expected native int or pointer, but got VT
		//IL_0492: Expected F4, but got I
		//IL_048d: Expected native int or pointer, but got VT
		//IL_049b: Expected Obj, but got VT
		//IL_034b: Expected I, but got Obj
		//IL_0397: Expected VT, but got Obj
		//IL_0397: Expected Obj, but got VT
		//IL_03a4: Expected Obj, but got F4
		//IL_0409: Expected F4, but got Obj
		//IL_0404: Expected native int or pointer, but got VT
		//IL_041e: Expected F4, but got I
		//IL_0419: Expected native int or pointer, but got VT
		//IL_044c: Expected F4, but got Obj
		//IL_0447: Expected native int or pointer, but got VT
		//IL_045e: Expected F4, but got I
		//IL_0459: Expected native int or pointer, but got VT
		//IL_0467: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 104;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v190 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 184);
		Vector3 vector2 = (Vector3)(obj2 + 120);
		Transform transform = (Transform)(obj2 + 24);
		object obj5 = obj2 + 12;
		if (((ComputeShader)pivot).FindKernel(null) != 0)
		{
			object obj6 = this + 80;
			transform = (Transform)obj6;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v52+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			obj5 = delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v180 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			Vector3 vector4 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			object obj8 = this + 80;
			obj8 = vector.x;
			_ = vector.z;
			Transform parentInternal = ((Transform)(object)target).parentInternal;
			Rigidbody component = target.GetComponent<Rigidbody>();
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v176 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
			{
				Matrix4x4 localToWorldMatrix = parentInternal.localToWorldMatrix;
				obj3 = vector2.x;
				_ = vector2.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+38]");
				_ = 0;
				object obj10 = this + 80;
				transform = (Transform)obj10;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v126+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
				obj = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Vector3 vector6 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+8]");
				((Vector3*)(nint)vector6)->z = 0f;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v133 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v172 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj12 = default;
				obj = obj12;
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v142 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v168 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					((Transform)vector2).Rotate((Vector3)parentInternal);
					obj3 = vector2.x;
					_ = vector2.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23 (UnityEngine.Vector3)+38]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj;
					Vector3 vector7 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
					obj = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					((Vector3*)(nint)vector)->x = (float)transform;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					Quaternion rotation = ((Rigidbody)vector).rotation;
				}
				else
				{
					((Vector3*)(nint)vector)->x = (float)obj;
					Vector3 vector8 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((Vector3*)(nint)vector8)->z = 0f;
					Vector3 eulerAngles = ((Transform)vector).eulerAngles;
				}
			}
			else
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v108 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					object obj15 = this + 80;
					((Vector3*)(nint)vector2)->x = (float)obj15;
					Vector3 vector9 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S1_v99+8]");
					((Vector3*)(nint)vector9)->z = 0f;
					((Vector3*)(nint)vector)->x = vector2.x;
					((Vector3*)(nint)vector)->z = vector2.z;
					Quaternion rotation2 = ((Rigidbody)vector).rotation;
				}
				else
				{
					object obj16 = this + 80;
					((Vector3*)(nint)vector2)->x = (float)obj16;
					Vector3 vector10 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S2_v20+8]");
					((Vector3*)(nint)vector10)->z = 0f;
					((Vector3*)(nint)vector)->x = vector2.x;
					((Vector3*)(nint)vector)->z = vector2.z;
					Vector3 localPosition = ((Transform)vector).localPosition;
				}
			}
			UIScrollView component2 = ((Component)pivot).GetComponent<UIScrollView>();
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			return;
		}
		transform.position = (Vector3)target;
		obj5 = delta.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		nint num15 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num16 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector11 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		Vector3 vector12 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		Vector3 localPosition2 = ((Transform)vector).localPosition;
	}

	private void OnDragEnd()
	{
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got F4
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0175: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_01b6: Expected I, but got Obj
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0252: Expected VT, but got Obj
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 56;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 52;
		obj3 = 0f;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v113 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 120;
		GameObject gameObject = (GameObject)(obj2 + 96);
		Transform transform = (Transform)(obj2 + 80);
		object obj6 = obj2 + 40;
		object obj7 = obj2 + 28;
		object obj8 = obj2 + 16;
		if (((ComputeShader)(object)target).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj10 = default;
		object obj9 = obj10 + 16;
		obj6 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v30+8]");
		_ = 0;
		object obj11 = obj10 + 28;
		obj7 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v35+8]");
		_ = 0;
		object obj12 = obj10 + 52;
		obj8 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v40+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		transform = (Transform)obj6;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		gameObject = (GameObject)obj7;
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v23+8]");
		((UnityEngine.Object)gameObject2).m_CachedPtr = (IntPtr)0;
		obj5 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D4");
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj13 = this + 40;
		obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15+8]");
		_ = 0;
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v40 (Il2CppClass<UICamera>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v69 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.genericEventHandler = gameObject;
		obj = gameObject;
		_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v17 (UnityEngine.GameObject)+10]");
		_ = 0;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		object obj15 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
			obj5 = gameObject;
			_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
			object obj17 = this + 56;
			obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15+8]");
			_ = 0;
			Camera anchorCamera = target.anchorCamera;
			transform.localPosition = (Vector3)anchorCamera;
			obj5 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj18 = this + 68;
			obj18 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15+8]");
			_ = 0;
			UIWidget uIWidget = target;
			mWidth = uIWidget.mWidth;
			UIWidget uIWidget2 = target;
			mHeight = uIWidget2.mHeight;
			mDragging = true;
		}
	}
}
