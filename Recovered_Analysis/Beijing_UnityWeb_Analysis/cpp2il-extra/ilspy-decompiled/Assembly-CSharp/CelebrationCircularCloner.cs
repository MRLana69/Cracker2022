using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CelebrationCircularCloner : MonoBehaviour
{
	public enum Axis
	{
		X,
		Y,
		Z
	}

	private GameObject _targetObject;

	private int _copyCount;

	private bool _destroyOriginal;

	private Axis _axis;

	private bool _alignToCloner;

	private float _radius;

	private void Awake()
	{
		CancelInvoke();
	}

	private Vector3 CalcCenterOffset(int index)
	{
		//IL_0009: Expected Obj, but got VT
		Vector3 vector = default;
		((BundlePurchaseButton)vector).ShowBundleIcon();
		return vector;
	}

	private void OnDrawGizmos()
	{
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03dd: Expected Obj, but got I4
		//IL_0413: Invalid comparison between I4 and F4
		//IL_0440: Expected I, but got Obj
		//IL_0456: Expected Obj, but got I
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0023: Expected I, but got Obj
		//IL_0079: Expected VT, but got Obj
		//IL_00ac: Expected VT, but got I4
		//IL_030c: Expected I, but got Obj
		//IL_0322: Expected Obj, but got I
		//IL_04a9: Expected I, but got Obj
		//IL_04bf: Expected Obj, but got I
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_0615: Expected Obj, but got I4
		//IL_06e8: Expected VT, but got Obj
		//IL_06e8: Expected VT, but got Obj
		//IL_034d: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I4
		//IL_0224: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_029e: Expected VT, but got I4
		//IL_0523: Expected VT, but got Obj
		//IL_0523: Expected VT, but got Obj
		//IL_0535: Expected I, but got Obj
		//IL_054b: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I4
		//IL_05af: Expected VT, but got Obj
		//IL_05af: Expected VT, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01d7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 80;
		obj3 = 0;
		_ = 0;
		CenterOnChild centerOnChild = (CenterOnChild)(obj2 + 68);
		centerOnChild = (CenterOnChild)0;
		((UnityEngine.Object)centerOnChild).m_CachedPtr = (IntPtr)0;
		int sleepTimeout = Screen.sleepTimeout;
		int height = Screen.height;
		int num = sleepTimeout / height;
		if ((float)num > 2f)
		{
			_radius = 1.2f;
		}
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v128 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 128);
		Transform transform2 = (Transform)(obj2 + 112);
		object obj5 = obj2 + 56;
		object obj6 = obj2 + 40;
		object obj7 = obj2 + 28;
		object obj8 = obj2 + 16;
		if (((ComputeShader)(object)_targetObject).FindKernel((string)null) == 0)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		transform.localPosition = (Vector3)gameObject;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		int layer = _targetObject.layer;
		transform2.localRotation = (Quaternion)layer;
		obj3 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		bool flag = false;
		while ((flag ? 1 : 0) < _copyCount)
		{
			centerOnChild.CenterOnTransform((Transform)(object)this, flag);
			if (~(_alignToCloner ? 1u : 0u) == 0)
			{
				GameObject gameObject2 = base.gameObject;
				Vector3 forward = ((Transform)(object)gameObject2).forward;
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj7 = centerOnChild;
				_ = ((UnityEngine.Object)centerOnChild).m_CachedPtr;
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				transform2 = (Transform)obj6;
				Transform transform3 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v28+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				transform = (Transform)obj7;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v30+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Quaternion quaternion = Quaternion.FromToRotation((Vector3)transform2, (Vector3)transform);
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v71 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num7 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v82 (Il2CppClass<UnityEngine.Quaternion>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				transform2 = (Transform)obj5;
				Transform transform5 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v26+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				transform = (Transform)obj8;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v32+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Quaternion quaternion2 = (Quaternion)transform2 * (Quaternion)transform;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
			}
			obj5 = centerOnChild;
			_ = ((UnityEngine.Object)centerOnChild).m_CachedPtr;
			obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v90 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform2 = (Transform)obj5;
			Transform transform7 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v26+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			transform = (Transform)obj6;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v28+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			GameObject gameObject3 = UnityEngine.Object.Instantiate(_targetObject, (Vector3)transform2, (Quaternion)transform);
			int layer2 = gameObject3.layer;
			GameObject parentInternal = base.gameObject;
			((Transform)layer2).parentInternal = (Transform)(object)parentInternal;
			int layer3 = gameObject3.layer;
			int layer4 = _targetObject.layer;
			transform2.localScale = (Vector3)layer4;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Transform)layer3).parent = transform;
			bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
			flag = flag2;
		}
		if (~(_destroyOriginal ? 1u : 0u) != 0)
		{
			return;
		}
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(_targetObject);
		object obj13 = this + 12;
		obj13 = 0;
	}

	public unsafe CelebrationCircularCloner()
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_026a: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected VT, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Ref, but got Unknown
		//IL_02a2: Expected Ref, but got F4
		//IL_0012: Expected VT, but got Obj
		//IL_0012: Expected Obj, but got Ref
		//IL_001f: Expected Obj, but got VT
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_02d1: Expected F4, but got Obj
		//IL_02cc: Expected native int or pointer, but got VT
		//IL_02e6: Expected F4, but got I
		//IL_02e1: Expected native int or pointer, but got VT
		//IL_0305: Expected VT, but got Ref
		//IL_00a3: Expected I, but got Obj
		//IL_0121: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_0358: Expected VT, but got Ref
		//IL_037f: Expected VT, but got Ref
		//IL_0390: Expected F4, but got Obj
		//IL_038b: Expected native int or pointer, but got VT
		//IL_03a5: Expected F4, but got I
		//IL_03a0: Expected native int or pointer, but got VT
		//IL_03c7: Expected Ref, but got VT
		//IL_0162: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		CenterOnChild centerOnChild = (CenterOnChild)(obj2 + 24);
		object obj3 = obj2 + 12;
		object obj4 = obj2 + 60;
		object obj5 = obj2 + 72;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 88);
		Color white = Color.white;
		ref Color reference = ref *(Color*)(obj2 + 104);
		reference = ref *(Color*)vector.x;
		_ = vector.z;
		Gizmos.set_color_Injected(ref reference);
		GameObject gameObject = base.gameObject;
		((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).position = (Vector3)gameObject;
		obj5 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (UnityEngine.Color&)+8]");
		_ = 0;
		bool flag = default;
		bool flag2 = default;
		while ((flag ? 1 : 0) < _copyCount)
		{
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			centerOnChild.CenterOnTransform((Transform)(object)this, flag);
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v39 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v87 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			reference = ref *(Color*)centerOnChild;
			_ = ((UnityEngine.Object)centerOnChild).m_CachedPtr;
			Vector3 vector3 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			if (~(_alignToCloner ? 1u : 0u) == 0)
			{
				obj = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
				_ = 0;
				GameObject gameObject2 = base.gameObject;
				Vector3 forward = ((Transform)(object)gameObject2).forward;
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v83 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				reference = ref *(Color*)centerOnChild;
				_ = ((UnityEngine.Object)centerOnChild).m_CachedPtr;
				Vector3 vector4 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) / _radius;
				reference = ref *(Color*)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Vector3 vector5 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) / 0.5f;
				((Vector3*)(nint)vector)->x = (float)obj;
				Vector3 vector6 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector6)->z = 0f;
				reference = ref *(Color*)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Gizmos.DrawLine_Injected(ref *(Vector3*)vector, ref System.Runtime.CompilerServices.Unsafe.As<Color, Vector3>(ref reference));
			}
			obj4 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
			_ = 0;
			reference = ref *(Color*)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			float radius = _radius * 0.05f;
			Gizmos.DrawWireSphere_Injected(ref System.Runtime.CompilerServices.Unsafe.As<Color, Vector3>(ref reference), radius);
			flag = (byte)((flag2 ? 1u : 0u) + 1u) != 0;
		}
	}
}
