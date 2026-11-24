using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using UnityEngine;

public class CurvePoint : MonoBehaviour
{
	public float t;

	public bool smoothTangents;

	public CurvePointTangent customIn;

	public CurvePointTangent customOut;

	public float weight;

	public unsafe Vector3 TangentInPoint
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0025: Expected Obj, but got I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_0042: Expected Obj, but got I4
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected Ref, but got Unknown
			//IL_0074: Expected Obj, but got VT
			//IL_0086: Expected Obj, but got VT
			//IL_00a7: Expected Obj, but got I
			//IL_00be: Expected I4, but got VT
			//IL_00be: Expected Obj, but got Ref
			//IL_00d0: Expected Obj, but got VT
			//IL_00e6: Expected Obj, but got I4
			//IL_011e: Expected I4, but got VT
			//IL_013d: Expected F4, but got Obj
			//IL_0138: Expected native int or pointer, but got VT
			//IL_0152: Expected F4, but got I
			//IL_014d: Expected native int or pointer, but got VT
			//IL_0171: Expected VT, but got Ref
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected Obj, but got Unknown
			ScrollView scrollView = default;
			Vector3 vector = (Vector3)(scrollView + 36);
			object obj = scrollView + 24;
			obj = 0;
			_ = 0;
			object obj2 = scrollView + 12;
			obj2 = 0;
			_ = 0;
			ref Color reference = ref *(Color*)(scrollView + 48);
			reference = ref *(Color*)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			Gizmos.set_color_Injected(ref reference);
			Vector3 vector2 = default;
			string debugText = ((CurveParent)vector2).GetDebugText();
			string debugText2 = ((CurveParent)vector2).GetDebugText();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (System.String)+30]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v17 (System.String)+2C]");
			object obj3 = num - 0;
			((ScrollView)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).FillFromIndex((int)vector2, 0f, ContainerPivot.Top);
			obj = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Color&)+8]");
			_ = 0;
			object obj4 = 0;
			while ((nint)obj4 <= 12)
			{
				object obj5 = obj3 * obj4;
				float topOffset = (float)obj5 / 12f;
				scrollView.FillFromIndex((int)vector2, topOffset, ContainerPivot.Top);
				obj2 = scrollView;
				_ = ((UnityEngine.Object)scrollView).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				((Vector3*)(nint)vector)->z = 0f;
				reference = ref *(Color*)scrollView;
				_ = ((UnityEngine.Object)scrollView).m_CachedPtr;
				Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+8]");
				_ = 0;
				object obj6 = obj4 + 1;
				obj4 = obj6;
			}
			return vector2;
		}
	}

	public Vector3 TangentOutPoint
	{
		get
		{
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006e: Expected VT, but got Obj
			//IL_006e: Expected Obj, but got VT
			//IL_00c7: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = default;
			if (((ComputeShader)(object)customIn).FindKernel((string)null) != 0)
			{
				GameObject gameObject = customIn.gameObject;
				((Transform)vector).localPosition = (Vector3)gameObject;
			}
			else
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 up = Vector3.up;
			}
			return vector;
		}
	}

	private string GetName()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got F4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = 0f;
		Container container = (Container)(obj + 12);
		container = (Container)obj;
		Container container2 = container;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		container2.onRecycleContainer = (Action)0;
		return (string)((ScrollView)this).ShouldRecycleContainer(container);
	}

	public void OnDrawGizmosSelected()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		Color green = Color.green;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 16;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+8]");
		_ = 0;
		CancelInvoke();
	}

	public unsafe CurvePoint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Ref, but got Unknown
		//IL_006c: Expected Ref, but got F4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a9: Expected VT, but got Obj
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0210: Expected VT, but got Ref
		//IL_0264: Expected VT, but got Ref
		//IL_02c5: Expected VT, but got Obj
		//IL_02d7: Expected F4, but got Obj
		//IL_02d2: Expected native int or pointer, but got VT
		//IL_02e9: Expected F4, but got I
		//IL_02e4: Expected native int or pointer, but got VT
		//IL_030b: Expected VT, but got Ref
		//IL_0327: Expected VT, but got Obj
		//IL_0334: Expected F4, but got Obj
		//IL_032f: Expected native int or pointer, but got VT
		//IL_0346: Expected F4, but got I
		//IL_0341: Expected native int or pointer, but got VT
		//IL_0368: Expected VT, but got Ref
		//IL_0383: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 + 132;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 120;
		obj3 = 0;
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 144);
		Color green = Color.green;
		ref Color reference = ref *(Color*)(obj2 + 160);
		reference = ref *(Color*)vector.x;
		_ = vector.z;
		Gizmos.set_color_Injected(ref reference);
		Transform transform = (Transform)(obj2 + 108);
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		reference = ref *(Color*)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Gizmos.DrawWireSphere_Injected(ref System.Runtime.CompilerServices.Unsafe.As<Color, Vector3>(ref reference), 0.5f);
		string original = tag;
		UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		bool shouldMove = ((KUIScrollView)this).shouldMove;
		if (((string)(object)obj4).get_Chars(shouldMove ? 1 : 0) != '\0')
		{
			string obj5 = tag;
			bool shouldMove2 = ((KUIScrollView)this).shouldMove;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5, shouldMove2);
		}
		object obj6 = obj2 + 96;
		object obj7 = obj2 + 84;
		object obj8 = obj2 + 72;
		object obj9 = obj2 + 56;
		Transform transform2 = (Transform)(obj2 + 44);
		Transform transform3 = (Transform)(obj2 + 32);
		object obj10 = obj2 + 16;
		if (~(smoothTangents ? 1u : 0u) != 0)
		{
			GameObject gameObject2 = base.gameObject;
			Vector3 tangentOutPoint = TangentOutPoint;
			reference = ref *(Color*)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Vector3 vector2 = ((Transform)(object)gameObject2).InverseTransformPoint((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+8]");
			_ = 0;
			GameObject gameObject3 = base.gameObject;
			Bounds bounds = ((KUIScrollView)this).bounds;
			reference = ref *(Color*)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v29+8]");
			_ = 0;
			Vector3 vector3 = ((Transform)(object)gameObject3).InverseTransformPoint((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v31+8]");
			_ = 0;
			Color magenta = Color.magenta;
			reference = ref *(Color*)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v33+8]");
			_ = 0;
			Gizmos.set_color_Injected(ref reference);
			GameObject gameObject4 = base.gameObject;
			transform2.position = (Vector3)gameObject4;
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			reference = ref *(Color*)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			GameObject gameObject5 = base.gameObject;
			transform3.position = (Vector3)gameObject5;
			((Vector3*)(nint)vector)->x = (float)transform3;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			reference = ref *(Color*)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			Color magenta2 = Color.magenta;
			reference = ref *(Color*)vector.x;
			_ = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
			reference = ref *(Color*)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v39+8]");
			_ = 0;
			Gizmos.set_color_Injected(ref reference);
			reference = ref *(Color*)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Gizmos.DrawWireSphere_Injected(ref System.Runtime.CompilerServices.Unsafe.As<Color, Vector3>(ref reference), 0.3f);
			Color magenta3 = Color.magenta;
			reference = ref *(Color*)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Gizmos.set_color_Injected(ref reference);
			reference = ref *(Color*)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			Gizmos.DrawWireSphere_Injected(ref System.Runtime.CompilerServices.Unsafe.As<Color, Vector3>(ref reference), 0.3f);
		}
	}
}
