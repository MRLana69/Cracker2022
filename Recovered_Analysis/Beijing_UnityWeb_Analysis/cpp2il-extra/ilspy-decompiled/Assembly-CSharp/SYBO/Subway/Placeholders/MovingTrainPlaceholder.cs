using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Level;
using SYBO.Subway.Promotion;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class MovingTrainPlaceholder : Placeholder
{
	private float _speed;

	public float Speed => _speed;

	protected override Transform InitializeSpawnedInstance(Transform objectTransform, string newName)
	{
		//IL_02db: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_016c: Expected I, but got Obj
		//IL_01ba: Expected I4, but got Obj
		//IL_01c6: Expected Obj, but got I4
		//IL_03b5: Expected I, but got Obj
		//IL_037a: Expected I, but got Obj
		//IL_0390: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_0284: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = (string)0;
		EnvironmentKind desiredEnvironmentKind = ((RouteBuilder)(object)this).DesiredEnvironmentKind;
		object obj;
		if ((object)desiredEnvironmentKind == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj3 = default;
			object obj2 = obj3 + 16;
			object obj4 = default;
			obj2 = obj4;
			NullReferenceException ex = new NullReferenceException();
			if (ex != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)((Exception)ex)._message).FindKernel((string)null) != 0)
				{
					int progressStateSectionCount = ((RouteBuilder)(object)this).GetProgressStateSectionCount((RouteBuildProgress)((Exception)ex)._message);
					text = (string)progressStateSectionCount;
					while (true)
					{
						nint num4 = (nint)newName;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v36 (Il2CppClass<System.String>)+58]");
						if ((nint)0 == 3)
						{
							break;
						}
						Color backgroundColor = ((BoardPromotion)(object)newName).BackgroundColor;
					}
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return (Transform)((ComputeShader)(object)newName).FindKernel((string)null);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public void OnDrawGizmos()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public unsafe MovingTrainPlaceholder()
	{
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got I4
		//IL_02dd: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Ref, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected VT, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016f: Expected VT, but got Obj
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0401: Expected VT, but got Ref
		//IL_0423: Expected Obj, but got F4
		//IL_043a: Expected VT, but got Obj
		//IL_020a: Expected F4, but got Obj
		//IL_0205: Expected native int or pointer, but got VT
		//IL_021c: Expected F4, but got I
		//IL_0217: Expected native int or pointer, but got VT
		//IL_023e: Expected VT, but got Ref
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_025d: Expected VT, but got Obj
		//IL_01be: Expected I, but got Obj
		//IL_026f: Expected F4, but got Obj
		//IL_026a: Expected native int or pointer, but got VT
		//IL_0284: Expected F4, but got I
		//IL_027f: Expected native int or pointer, but got VT
		//IL_02a3: Expected VT, but got Ref
		BoxCollider boxCollider = default;
		object obj = boxCollider + 80;
		obj = 0;
		_ = 0;
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Color reference = ref *(Color*)(boxCollider + 104);
		Vector3 vector = (Vector3)(boxCollider + 92);
		object obj3 = boxCollider - -64;
		BoxCollider boxCollider2 = (BoxCollider)(boxCollider + 48);
		object obj4 = boxCollider + 36;
		Transform transform = (Transform)(boxCollider + 24);
		object obj5 = boxCollider + 12;
		if ((UnityEngine.Object)(object)componentsInChildren != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)componentsInChildren[2] != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BDA4");
		object obj7 = default;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [C]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		Color green = Color.green;
		reference = ref *(Color*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
		_ = 0;
		Gizmos.set_color_Injected(ref reference);
		object obj8 = obj7 + 16;
		boxCollider2.size = (Vector3)obj8;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		reference = ref *(Color*)boxCollider2;
		_ = ((UnityEngine.Object)boxCollider2).m_CachedPtr;
		Vector3 vector2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) / 0.5f;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
		_ = 0;
		obj = 0f;
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		reference = ref *(Color*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Vector3 vector3 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		object obj10 = obj7 + 16;
		boxCollider.size = (Vector3)obj10;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31+8]");
		((Vector3*)(nint)vector)->z = 0f;
		reference = ref *(Color*)boxCollider;
		_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
		Gizmos.DrawRay(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
	}
}
