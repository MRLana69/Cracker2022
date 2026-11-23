using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Utilities;

public static class GameObjectUtil
{
	private struct HierarchyDepthContainer(Component component, int index)
	{
		public Component Component = component;

		public int HierarchyCount = 0;

		public int Index = index;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HierarchyDepthContainer> _003C_003E9__43_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003CGetComponentsInChildrenBFS_003Eb__43_0(HierarchyDepthContainer x, HierarchyDepthContainer y)
		{
			if (y.HierarchyCount != x.HierarchyCount)
			{
				if (y.HierarchyCount <= x.HierarchyCount)
				{
					return (y.HierarchyCount < x.HierarchyCount) ? 1 : 0;
				}
				return -1;
			}
			if (x.Index >= y.Index)
			{
				return (x.Index > y.Index) ? 1 : 0;
			}
			return -1;
		}
	}

	public static string GetLongName(Component comp)
	{
		Transform transform = comp.transform;
		return Utils.GetLongName(transform);
	}

	public static string GetLongName(GameObject obj)
	{
		Transform transform = obj.transform;
		return Utils.GetLongName(transform);
	}

	public static GameObject Instantiate(GameObject go)
	{
		if (go == null)
		{
			return null;
		}
		return UnityEngine.Object.Instantiate(go);
	}

	public static GameObject Instantiate(Transform transform)
	{
		if (transform == null)
		{
			return null;
		}
		GameObject gameObject = transform.gameObject;
		return UnityEngine.Object.Instantiate(gameObject);
	}

	public static Transform InstantiateTransform(GameObject go)
	{
		GameObject gameObject = Instantiate(go);
		if (gameObject == null)
		{
			return null;
		}
		return gameObject.transform;
	}

	public static Transform InstantiateTransform(Transform transform)
	{
		GameObject gameObject = transform.gameObject;
		GameObject gameObject2 = Instantiate(gameObject);
		if (gameObject2 == null)
		{
			return null;
		}
		return gameObject2.transform;
	}

	public static T AddComponentIfMissing<T>(Component comp) where T : Component
	{
		GameObject gameObject = comp.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::AddComponentIfMissing>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T AddComponentIfMissing<T>(GameObject go) where T : Component
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::AddComponentIfMissing>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj = default;
		if (obj == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v8 (Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::AddComponentIfMissing>)+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v9+4] (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		return (T)obj;
	}

	public static Component AddComponentIfMissing(Component comp, Type type)
	{
		GameObject gameObject = comp.gameObject;
		return AddComponentIfMissing(gameObject, type);
	}

	public static Component AddComponentIfMissing(GameObject go, Type type)
	{
		Component component = go.GetComponent(type);
		if (component == null)
		{
			component = go.AddComponent(type);
		}
		return component;
	}

	public unsafe static void ResetLocal(Transform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected VT, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_00f7: Expected I, but got Obj
		//IL_011c: Expected F4, but got I
		//IL_0117: Expected native int or pointer, but got VT
		//IL_012a: Expected F4, but got VT
		//IL_0125: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform.localPosition = localPosition;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform.localRotation = localRotation;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v24 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v25 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform.localScale = vector;
	}

	public unsafe static void ResetLocalPosition(Transform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0053: Expected F4, but got I
		//IL_004e: Expected native int or pointer, but got VT
		//IL_006e: Expected F4, but got I
		//IL_0069: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
	}

	public unsafe static void ResetLocalRotation(Transform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0053: Expected F4, but got I
		//IL_004e: Expected native int or pointer, but got VT
		//IL_006e: Expected F4, but got I
		//IL_0069: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform.localRotation = quaternion;
	}

	public unsafe static void ResetLocalScale(Transform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0046: Expected F4, but got I
		//IL_0041: Expected native int or pointer, but got VT
		//IL_0054: Expected F4, but got VT
		//IL_004f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform.localScale = vector;
	}

	public static void UnparentAndDestroy(Transform transform)
	{
		transform.parent = null;
		GameObject gameObject = transform.gameObject;
		UnityEngine.Object.Destroy(gameObject);
	}

	public static void UnparentAndDestroy(GameObject go)
	{
		Transform transform = go.transform;
		transform.parent = null;
		UnityEngine.Object.Destroy(go);
	}

	public static bool IsDestroyed(GameObject gameObject)
	{
		bool flag = gameObject == null;
		bool flag2 = (object)gameObject != null;
		return flag & flag2;
	}

	public static int ComparePositionZ(Vector3 lhs, Vector3 rhs)
	{
		bool flag = lhs.z < rhs.z;
		int result = -1;
		if (!flag)
		{
			bool flag2 = lhs.z > rhs.z;
			result = 1;
			if (!flag2)
			{
				result = 0;
			}
		}
		return result;
	}

	public static void SortTransformChildren(Transform parentTransform, Comparison<Transform> cmp)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		int childCount = parentTransform.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		int childCount2 = parentTransform.childCount;
		if (childCount2 > num)
		{
			Transform child = parentTransform.GetChild(num);
			throw new ArrayTypeMismatchException();
		}
		Transform[] array = default;
		Array.Sort(array, cmp);
		int num2 = 0;
		while (true)
		{
			int childCount3 = parentTransform.childCount;
			if (childCount3 > num2)
			{
				int num3 = num2 << 2;
				object obj = array + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v22+10]");
				((Transform)0).SetSiblingIndex(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v22+10]");
				SortTransformChildren((Transform)0, cmp);
				int num4 = num2 + 1;
				num2 = num4;
				continue;
			}
			break;
		}
	}

	public static bool IsPrefab(GameObject go)
	{
		return false;
	}

	public static void GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, List<T> result) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
	}

	public static void GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, List<T> result, bool includeSelf) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S6_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
	}

	public static void GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, List<T> result, bool includeSelf, int searchDepth) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(Component c) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(Component c, bool includeInactive) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, bool includeSelf) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, bool includeSelf, int searchDepth) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, bool includeSelf) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, bool includeSelf, int searchDepth) where T : Component
	{
		//IL_002b: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S6_v2 (Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>)+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S6_v3+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v7 (Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S2_v8+4] (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static void GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, List<T> result) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
	}

	public static void GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, List<T> result, bool includeSelf) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S6_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
	}

	public static void GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, List<T> result, bool includeSelf, int searchDepth) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Expected VT, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (result == null)
		{
			return;
		}
		List<Component> list = default;
		list._002Ector();
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		GetComponentsInChildrenBFS(go, typeFromHandle, includeInactive, list, includeSelf, searchDepth);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0297;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v86 (Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>)+C]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							nint num3 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0297;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_0297:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9858");
			return;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type)
	{
		return GetComponentsInChildrenBFS(c, type, includeInactive: false, includeSelf: true);
	}

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive)
	{
		return GetComponentsInChildrenBFS(c, type, includeInactive, includeSelf: true);
	}

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive, bool includeSelf)
	{
		return GetComponentsInChildrenBFS(c, type, includeInactive, includeSelf, int.MaxValue);
	}

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive, bool includeSelf, int searchDepth)
	{
		GameObject gameObject = c.gameObject;
		return GetComponentsInChildrenBFS(gameObject, type, includeInactive, includeSelf, searchDepth);
	}

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type)
	{
		return GetComponentsInChildrenBFS(go, type, includeInactive: false, includeSelf: true);
	}

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive)
	{
		return GetComponentsInChildrenBFS(go, type, includeInactive, includeSelf: true);
	}

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, bool includeSelf)
	{
		return GetComponentsInChildrenBFS(go, type, includeInactive, includeSelf, int.MaxValue);
	}

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, bool includeSelf, int searchDepth)
	{
		List<Component> list = default;
		list._002Ector();
		GetComponentsInChildrenBFS(go, type, includeInactive, list, includeSelf, searchDepth);
		return list.ToArray();
	}

	public unsafe static void GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, List<Component> result, bool includeSelf, int searchDepth)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0338: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_011e: Expected native int or pointer, but got VT
		//IL_0138: Expected Obj, but got I
		//IL_0133: Expected native int or pointer, but got VT
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected VT, but got Unknown
		object obj = default;
		HierarchyDepthContainer hierarchyDepthContainer = (HierarchyDepthContainer)(obj + -64);
		_ = 0;
		_ = 0;
		if (result == null)
		{
			return;
		}
		Component[] componentsInChildren = go.GetComponentsInChildren(type, includeInactive);
		List<HierarchyDepthContainer> list = default;
		list._002Ector(componentsInChildren.Length);
		object obj2 = default;
		object obj6 = default;
		while (componentsInChildren.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)componentsInChildren + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v59+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject == go)
			{
				if (includeSelf)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v59+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v18 (System.Collections.Generic.List`1<SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer>)+C]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+28]");
					((HierarchyDepthContainer*)(nint)hierarchyDepthContainer)->Index = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+20]");
					System.Runtime.CompilerServices.Unsafe.Write(&((HierarchyDepthContainer*)(nint)hierarchyDepthContainer)->Component, (Component)0);
					list.Add(hierarchyDepthContainer);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v59+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v18 (System.Collections.Generic.List`1<SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer>)+C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v59+10]");
				Transform transform = ((Component)0).transform;
				Transform transform2 = transform;
				bool flag;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+34]");
					object obj5 = (nint)0 + (nint)1;
					Transform parent = transform2.parent;
					Transform transform3 = go.transform;
					flag = parent == transform3;
					transform2 = parent;
				}
				while (!flag);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+34]");
				if ((nint)0 <= (nint)searchDepth)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+30]");
					_ = 0;
					HierarchyDepthContainer item = (HierarchyDepthContainer)(hierarchyDepthContainer + 16);
					list.Add(item);
				}
			}
			obj2 = obj6 + 1;
		}
		bool flag2 = _003C_003Ec._003C_003E9__43_0 == null;
		bool flag3 = !flag2;
		Comparison<HierarchyDepthContainer> comparison = _003C_003Ec._003C_003E9__43_0;
		if (!flag3)
		{
			throw new ArgumentException();
		}
		list.Sort(comparison);
		object obj7 = 0;
		while (true)
		{
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v18 (System.Collections.Generic.List`1<SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer>)+C]");
			if ((nint)obj8 < 0)
			{
				object obj9 = hierarchyDepthContainer + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Common.Utilities.GameObjectUtil+HierarchyDepthContainer)+20]");
				result.Add((Component)0);
				object obj10 = obj7 + 1;
				obj7 = obj10;
				continue;
			}
			break;
		}
	}
}
