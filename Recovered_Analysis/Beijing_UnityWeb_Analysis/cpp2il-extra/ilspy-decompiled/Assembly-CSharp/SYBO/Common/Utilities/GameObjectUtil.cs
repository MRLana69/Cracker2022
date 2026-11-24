using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Json;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Common.Utilities;

public static class GameObjectUtil
{
	private struct HierarchyDepthContainer(Component component, int index)
	{
		public Component Component;

		public int HierarchyCount;

		public int Index = index;
	}

	public static string GetLongName(Component comp)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [comp @ L0 (UnityEngine.Component)+C]");
		return (string)0;
	}

	public static string GetLongName(GameObject obj)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = ((Component)(object)obj).gameObject;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Utils>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Utils.GetLongNameList((Component[])(object)gameObject);
	}

	public static GameObject Instantiate(GameObject go)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		int layer = go.layer;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (GameObject)(object)Utils.GetLongNameList((Component[])layer);
	}

	public static GameObject Instantiate(Transform transform)
	{
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (transform != null)
		{
			return null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return UnityEngine.Object.Instantiate((GameObject)(object)transform);
	}

	public static Transform InstantiateTransform(GameObject go)
	{
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (go != null)
		{
			return null;
		}
		string tag = ((Component)(object)go).tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (Transform)(object)UnityEngine.Object.Instantiate((GameObject)(object)tag);
	}

	public static Transform InstantiateTransform(Transform transform)
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = Instantiate(transform);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (gameObject != null)
		{
			return null;
		}
		int layer = gameObject.layer;
		return (Transform)layer;
	}

	public unsafe static T AddComponentIfMissing<T>(Component comp) where T : Component
	{
		//IL_0179: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected I, but got Unknown
		//IL_0254: Expected I, but got Obj
		//IL_026f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v46 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type enumType = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<System.Enum>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v35 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		object obj8 = default;
		object obj7 = obj8 + 12;
		object obj9 = 0;
		T val = null;
		object obj13 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj10 = obj8 + 16;
				object obj11 = obj9 << 2;
				object obj12 = obj10 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				if (obj13 == null)
				{
					T val2 = (T)(val + 1);
					object obj14 = obj9 + 1;
					obj9 = obj14;
					val = val2;
					continue;
				}
				if ((nint)val != -1)
				{
					break;
				}
			}
			string msg = "Did not find enumvalue: " + (string)(object)comp + " in Enum";
			SDebug.LogFormat(msg, null);
			val = (T)(-1);
			break;
		}
		return val;
	}

	public static T AddComponentIfMissing<T>(GameObject go) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string tag = ((Component)(object)go).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FFF;
		object obj4 = obj3 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S2_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static Component AddComponentIfMissing(Component comp, Type type)
	{
		//IL_009d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			return null;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v9+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v10+44]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S3_v9 (should have been resolved before IL gen)");
		object obj12 = default;
		bool flag = (nint)obj12 > -1;
		return (Component)flag;
	}

	public static Component AddComponentIfMissing(GameObject go, Type type)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Obj
		//IL_001e: Expected Obj, but got I4
		string tag = ((Component)(object)go).tag;
		return (Component)ComparePositionZ((Vector3)tag, (Vector3)type);
	}

	public static void ResetLocal(Transform transform)
	{
	}

	public static void ResetLocalPosition(Transform transform)
	{
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01b7: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		Vector3 one = Vector3.one;
		Transform transform2 = (Transform)(obj3 + 48);
		transform2 = (Transform)obj2;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v34 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3 + 16;
		Vector2 zero = Vector2.zero;
		transform2 = (Transform)obj5;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v25+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform2.localScale;
		Vector3 forward = Vector3.forward;
		transform2 = (Transform)obj3;
		Transform transform5 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		transform.parent = transform2;
	}

	public static void ResetLocalRotation(Transform transform)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj2 = default;
		Transform transform2 = (Transform)(obj2 + 12);
		transform2 = (Transform)obj2;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
	}

	public static void ResetLocalScale(Transform transform)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v19 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		object obj2 = default;
		Transform transform2 = (Transform)(obj2 + 16);
		transform2 = (Transform)obj2;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform2.localScale;
	}

	public static void UnparentAndDestroy(Transform transform)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		object obj2 = default;
		Transform transform2 = (Transform)(obj2 + 12);
		transform2 = (Transform)obj2;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		transform.parent = transform2;
	}

	public static void UnparentAndDestroy(GameObject go)
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((Transform)(object)go).parentInternal = null;
		string tag = ((Component)(object)go).tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
	}

	public static bool IsDestroyed(GameObject gameObject)
	{
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string tag = ((Component)(object)gameObject).tag;
		GameObject gameObject2 = Instantiate((Transform)(object)tag);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (gameObject2 != null)
		{
			return false;
		}
		return (byte)gameObject2.layer != 0;
	}

	public static int ComparePositionZ(Vector3 lhs, Vector3 rhs)
	{
		//IL_007d: Expected Obj, but got VT
		//IL_007d: Expected Obj, but got VT
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00e3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got VT
		//IL_005f: Expected Obj, but got VT
		Component componentInParent = ((GameObject)lhs).GetComponentInParent((Type)rhs);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = componentInParent != null;
		bool flag2 = !flag;
		bool result = (byte)(int)componentInParent != 0;
		if (!flag2)
		{
			bool flag3 = ((GameObject)lhs).CompareTag((string)rhs);
			result = flag3;
		}
		return result ? 1 : 0;
	}

	public unsafe static void SortTransformChildren(Transform parentTransform, Comparison<Transform> cmp)
	{
		//IL_006e: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		ref Action<ModelInfo> reference = ref *(Action<ModelInfo>*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parentTransform @ L0 (UnityEngine.Transform)+1C]");
		if (((Dictionary<CombineableMeshGroup, Action<ModelInfo>>)0).TryGetValue((CombineableMeshGroup)(object)cmp, out reference) && reference != null)
		{
			reference(null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parentTransform @ L0 (UnityEngine.Transform)+1C]");
			bool flag = ((Dictionary<CombineableMeshGroup, Action<ModelInfo>>)0).Remove((CombineableMeshGroup)(object)cmp);
		}
	}

	public static bool IsPrefab(GameObject go)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (object)go != null;
		bool flag2 = go != null;
		return flag & flag2;
	}

	public unsafe static void GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, List<T> result) where T : Component
	{
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected I, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0378: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_04af: Expected I, but got F4
		//IL_02ef: Expected I, but got Obj
		//IL_03ad: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I4
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00de: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_0443: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_0470: Expected Obj, but got I
		//IL_047d: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0249: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+18]");
		if ((nint)0 != 0)
		{
			bool flag;
			if (result != null)
			{
				flag = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+18]");
				if ((nint)0 == 2)
				{
					flag = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+18]");
					flag = (nint)0 == 3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v16+C]");
			bool flag2 = (nint)0 != 0;
			object obj5 = flag & flag2;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S2_v24+4]");
				object obj7 = 0;
				object obj8 = obj7 & 0x3FFF;
				object obj9 = obj8 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v97 @ S3_v10 (should have been resolved before IL gen)");
				nint num2 = (nint)typeof(AnalyticsIntegration);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v39 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num3 = (nint)typeof(AnalyticsIntegration);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v60 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (AnalyticsIntegration.OnEventPosted != null)
				{
					nint num4 = (nint)typeof(AnalyticsIntegration);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v47 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num5 = (nint)typeof(AnalyticsIntegration);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v54 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+46]");
			object obj12 = default;
			if ((nint)0 != 0)
			{
				obj12 = 1;
			}
			else
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v27 (Il2CppClass<System.Type>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v39 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(SubwayPurchaseEvent);
				((IntPtr*)num)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v18+8]");
				obj = 0;
				((IntPtr*)num)->m_value = (void*)(nint)obj;
				Type type2 = Type.internal_from_handle((IntPtr)num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			}
			object obj15 = obj12 & 1;
			return;
		}
		nint num8 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num9 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v25 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		((IntPtr*)num)->m_value = (void*)(nint)timeSinceLevelLoad;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object arg = default;
		object arg2 = default;
		Log.Analytics.LogErrorFormat((Enum)null, "[SYBO Analytics] - {0:0.00}s : Attempted to post '{1}' event before initializing user ID", arg, arg2);
	}

	public static void GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, List<T> result, bool includeSelf) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		object obj = c + 24;
		obj = includeInactive;
		object obj2 = c + 28;
		obj2 = result;
		object obj3 = c + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78BA");
		object obj4 = default;
		obj3 = obj4;
	}

	public static void GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, List<T> result, bool includeSelf, int searchDepth) where T : Component
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		object obj = c + 12;
		obj = string.Empty;
		object obj2 = c + 20;
		obj2 = includeInactive;
		object obj3 = c + 12;
		bool flag = FileUtility.IsLocalPath((string)(object)result);
		obj3 = flag;
		if (includeSelf)
		{
			object obj4 = c + 8;
			obj4 = includeSelf;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer = default;
			jsonCustomSerializer._002Ector();
			object obj5 = c + 8;
			obj5 = jsonCustomSerializer;
		}
		if (searchDepth != 0)
		{
			object obj6 = c + 16;
			obj6 = searchDepth;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj8 = default;
		object obj7 = obj8 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+C]");
		obj7 = 0;
		object obj9 = c + 16;
		obj9 = obj8;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go) where T : Component
	{
		//IL_00ab: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S2_v5 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj7 = default;
		bool flag = obj7 != null;
		bool flag2 = !flag;
		UnityEngine.Object result = obj7;
		if (!flag2)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10+8]");
			object obj9 = 0;
			object obj10 = obj9 & 0x3FFF;
			object obj11 = obj10 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S2_v11 (should have been resolved before IL gen)");
			UnityEngine.Object obj12 = default;
			result = obj12;
		}
		return (T[])(object)result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_003b: Expected VT, but got I4
		//IL_003b: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Vector3 point = default;
		return (T[])Math3D.PointOnWhichSideOfLineSegment((Vector3)go, (Vector3)0, point);
	}

	public static T[] GetComponentsInChildrenBFS<T>(Component c) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S4_v4 (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(Component c, bool includeInactive) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S4_v4 (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public unsafe static T[] GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, bool includeSelf) where T : Component
	{
		//IL_003d: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_002a: Expected Obj, but got I
		//IL_007e: Expected F4, but got I4
		//IL_0079: Expected native int or pointer, but got VT
		//IL_0093: Expected F4, but got I
		//IL_008e: Expected native int or pointer, but got VT
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected VT, but got Unknown
		//IL_00b3: Expected F4, but got I4
		//IL_00ae: Expected native int or pointer, but got VT
		//IL_00c8: Expected F4, but got I
		//IL_00c3: Expected native int or pointer, but got VT
		//IL_00f1: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		MonoBehaviour prefab;
		if (((QualityManager)val).PrewarmParticleSystems((QualityFeature)(nint)((UnityEngine.Object)c).m_CachedPtr))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+10]");
			prefab = (MonoBehaviour)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ L0 (UnityEngine.Component)+C]");
			prefab = (MonoBehaviour)0;
		}
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = (((bool*)(includeInactive ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeInactive @ L1 (System.Boolean)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = (((bool*)(includeSelf ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeSelf @ L2 (System.Boolean)+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		MonoBehaviour monoBehaviour = ((QualityFx)(object)c).InstantiateInternal<MonoBehaviour>(prefab, vector, quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T[] result = default;
		return result;
	}

	public unsafe static T[] GetComponentsInChildrenBFS<T>(Component c, bool includeInactive, bool includeSelf, int searchDepth) where T : Component
	{
		//IL_0163: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_006d: Expected I4, but got Obj
		//IL_0116: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)includeInactive != null)
		{
			UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)includeInactive);
			string msg = string.ConcatArray((string[])(object)"Could not instantiate effect: ", (int)obj2);
			SDebug.LogFormat(msg, null);
		}
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = ((bool*)(includeSelf ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeSelf @ L2 (System.Boolean)+8]");
		_ = 0;
		obj4 = ((bool*)searchDepth)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [searchDepth @ L3 (System.Boolean)+8]");
		_ = 0;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v27+4]");
		object obj7 = 0;
		object obj8 = obj4 + 28;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17+8]");
		_ = 0;
		object obj9 = obj4 + 40;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj10 = obj7 & 0x1FFF;
		object obj11 = obj10 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v116 @ S4_v3 (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, bool includeSelf) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S5_v4 (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static T[] GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, bool includeSelf, int searchDepth) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string tag = ((Component)(object)go).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S5_v4 (should have been resolved before IL gen)");
		T[] result = default;
		return result;
	}

	public static void GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, List<T> result) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string tag = ((Component)(object)go).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 121922;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S5_v4 (should have been resolved before IL gen)");
	}

	public static void GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, List<T> result, bool includeSelf) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string tag = ((Component)(object)go).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FF;
		object obj4 = obj3 + 123986;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21 @ S6_v4 (should have been resolved before IL gen)");
	}

	public static void GetComponentsInChildrenBFS<T>(GameObject go, bool includeInactive, List<T> result, bool includeSelf, int searchDepth) where T : Component
	{
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		string tag = ((Component)(object)go).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L5 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 121922;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S5_v4 (should have been resolved before IL gen)");
	}

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 12;
		obj = c;
		_ = ((UnityEngine.Object)c).m_CachedPtr;
		obj2 = type;
		_ = type._impl;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		if (num < 0)
		{
			return (Component[])(-1);
		}
		obj = c;
		_ = ((UnityEngine.Object)c).m_CachedPtr;
		obj2 = type;
		_ = type._impl;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		bool flag = num2 > 0;
		return (Component[])flag;
	}

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		Component[] result = default;
		return result;
	}

	public unsafe static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive, bool includeSelf)
	{
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected VT, but got Unknown
		//IL_0209: Expected native int or pointer, but got VT
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected VT, but got Unknown
		//IL_0233: Expected native int or pointer, but got VT
		//IL_0241: Expected native int or pointer, but got VT
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02ce: Expected I, but got Obj
		//IL_02e4: Expected Obj, but got I
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected VT, but got Unknown
		//IL_052c: Expected F4, but got Obj
		//IL_0527: Expected native int or pointer, but got VT
		//IL_0541: Expected F4, but got I
		//IL_053c: Expected native int or pointer, but got VT
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected VT, but got Unknown
		//IL_055c: Expected F4, but got Obj
		//IL_0557: Expected native int or pointer, but got VT
		//IL_0571: Expected F4, but got I
		//IL_056c: Expected native int or pointer, but got VT
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_05b7: Expected F4, but got I4
		//IL_05b2: Expected native int or pointer, but got VT
		//IL_05cc: Expected F4, but got I
		//IL_05c7: Expected native int or pointer, but got VT
		//IL_05de: Expected F4, but got I4
		//IL_05d9: Expected native int or pointer, but got VT
		//IL_05f3: Expected F4, but got I
		//IL_05ee: Expected native int or pointer, but got VT
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected VT, but got Unknown
		//IL_031c: Expected F4, but got Obj
		//IL_0317: Expected native int or pointer, but got VT
		//IL_0331: Expected F4, but got I
		//IL_032c: Expected native int or pointer, but got VT
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected VT, but got Unknown
		//IL_034c: Expected F4, but got Obj
		//IL_0347: Expected native int or pointer, but got VT
		//IL_0361: Expected F4, but got I
		//IL_035c: Expected native int or pointer, but got VT
		//IL_036e: Expected F4, but got Obj
		//IL_0369: Expected native int or pointer, but got VT
		//IL_0383: Expected F4, but got I
		//IL_037e: Expected native int or pointer, but got VT
		//IL_0390: Expected F4, but got Obj
		//IL_038b: Expected native int or pointer, but got VT
		//IL_03a5: Expected F4, but got I
		//IL_03a0: Expected native int or pointer, but got VT
		//IL_00d3: Expected I, but got Obj
		//IL_011f: Expected F4, but got Obj
		//IL_011a: Expected native int or pointer, but got VT
		//IL_0131: Expected F4, but got I
		//IL_012c: Expected native int or pointer, but got VT
		//IL_0150: Expected Obj, but got F4
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_03ec: Expected native int or pointer, but got VT
		//IL_03fe: Expected native int or pointer, but got VT
		//IL_0410: Expected F4, but got Obj
		//IL_040b: Expected native int or pointer, but got VT
		//IL_0425: Expected F4, but got I
		//IL_0420: Expected native int or pointer, but got VT
		//IL_0432: Expected F4, but got Obj
		//IL_042d: Expected native int or pointer, but got VT
		//IL_0447: Expected F4, but got I
		//IL_0442: Expected native int or pointer, but got VT
		//IL_0458: Expected I4, but got VT
		//IL_0458: Expected Ref, but got VT
		//IL_046e: Expected F4, but got I4
		//IL_0469: Expected native int or pointer, but got VT
		//IL_0483: Expected F4, but got I
		//IL_047e: Expected native int or pointer, but got VT
		//IL_0495: Expected F4, but got I4
		//IL_0490: Expected native int or pointer, but got VT
		//IL_04aa: Expected F4, but got I
		//IL_04a5: Expected native int or pointer, but got VT
		//IL_04b7: Expected native int or pointer, but got VT
		//IL_04c9: Expected native int or pointer, but got VT
		//IL_04df: Expected I4, but got VT
		//IL_04df: Expected Ref, but got VT
		//IL_04f0: Expected Obj, but got I4
		//IL_0507: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 132);
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj + 120);
		((Vector3*)(nint)vector2)->x = 0f;
		((Vector3*)(nint)vector2)->z = 0f;
		object obj2 = obj + 108;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 84;
		obj4 = type;
		_ = type._impl;
		object obj5 = obj + 72;
		obj5 = c;
		_ = ((UnityEngine.Object)c).m_CachedPtr;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v106 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector3 = (Vector3)(obj + 168);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = (Vector3)(obj + 180);
		((Vector3*)(nint)vector4)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj7 = obj + 60;
		Quaternion quaternion = Quaternion.FromToRotation(vector3, vector4);
		obj2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v38+8]");
		_ = 0;
		((Vector3*)(nint)vector3)->x = (((bool*)(includeSelf ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeSelf @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector4)->x = (((bool*)(includeInactive ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeInactive @ L2 (System.Boolean)+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj8 = obj + 48;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector3, vector4);
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v46+8]");
		_ = 0;
		object obj9 = obj + 36;
		obj9 = c;
		_ = ((UnityEngine.Object)c).m_CachedPtr;
		object obj10 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		object obj11 = obj + 12;
		obj11 = ((bool*)(includeInactive ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeInactive @ L2 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		nint num3 = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v59 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v102 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector5 = (Vector3)(obj + 144);
		((Vector3*)(nint)vector5)->x = (float)obj9;
		Vector3 vector6 = vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v50+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 vector7 = (Vector3)(obj + 156);
		((Vector3*)(nint)vector7)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v53+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v55+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector4)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		if (Math3D.IsLineInRectangle(vector, vector2, vector5, vector7, vector3, vector4))
		{
			((Vector3*)(nint)vector5)->x = (float)c;
			((Vector3*)(nint)vector5)->z = (nint)((UnityEngine.Object)c).m_CachedPtr;
			obj4 = type;
			_ = type._impl;
			obj5 = vector.x;
			_ = vector.z;
			nint num5 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v84 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v98 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector7)->x = vector5.x;
			((Vector3*)(nint)vector7)->z = vector5.z;
			((Vector3*)(nint)vector3)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector4)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			bool flag = Math3D.LinearAcceleration(out *(Vector3*)vector7, vector3, (int)vector4);
			((Vector3*)(nint)vector7)->x = (((bool*)(includeInactive ? 1 : 0))->m_value ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeInactive @ L2 (System.Boolean)+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			((Vector3*)(nint)vector3)->x = (((bool*)(includeSelf ? 1 : 0))->m_value ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeSelf @ L3 (System.Boolean)+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector4)->x = vector2.x;
			((Vector3*)(nint)vector4)->z = vector2.z;
			bool flag2 = Math3D.LinearAcceleration(out *(Vector3*)vector7, vector3, (int)vector4);
			object obj14 = flag | flag2;
			bool flag3 = obj14 == null;
			return (Component[])flag3;
		}
		return null;
	}

	public unsafe static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive, bool includeSelf, int searchDepth)
	{
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0451: Expected Obj, but got I4
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0472: Expected Obj, but got I4
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_04ad: Expected I, but got Obj
		//IL_04c3: Expected Obj, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected VT, but got Unknown
		//IL_0634: Expected F4, but got Obj
		//IL_062f: Expected native int or pointer, but got VT
		//IL_0649: Expected F4, but got I
		//IL_0644: Expected native int or pointer, but got VT
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected VT, but got Unknown
		//IL_0664: Expected F4, but got Obj
		//IL_065f: Expected native int or pointer, but got VT
		//IL_0679: Expected F4, but got I
		//IL_0674: Expected native int or pointer, but got VT
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_06e8: Expected I, but got Obj
		//IL_06fe: Expected Obj, but got I
		//IL_04ed: Expected F4, but got Obj
		//IL_04e8: Expected native int or pointer, but got VT
		//IL_0502: Expected F4, but got I
		//IL_04fd: Expected native int or pointer, but got VT
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_055c: Expected F4, but got Obj
		//IL_0557: Expected native int or pointer, but got VT
		//IL_056e: Expected F4, but got VT
		//IL_0569: Expected native int or pointer, but got VT
		//IL_057b: Expected F4, but got Obj
		//IL_0576: Expected native int or pointer, but got VT
		//IL_0590: Expected F4, but got I
		//IL_058b: Expected native int or pointer, but got VT
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05c1: Expected F4, but got I4
		//IL_05bc: Expected native int or pointer, but got VT
		//IL_05d6: Expected F4, but got I
		//IL_05d1: Expected native int or pointer, but got VT
		//IL_05e3: Expected F4, but got Obj
		//IL_05de: Expected native int or pointer, but got VT
		//IL_05f5: Expected F4, but got VT
		//IL_05f0: Expected native int or pointer, but got VT
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00e0: Expected F4, but got I4
		//IL_00db: Expected native int or pointer, but got VT
		//IL_00f5: Expected F4, but got I
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_0102: Expected F4, but got Obj
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_0114: Expected F4, but got VT
		//IL_010f: Expected native int or pointer, but got VT
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected VT, but got Unknown
		//IL_01b2: Expected F4, but got Obj
		//IL_01ad: Expected native int or pointer, but got VT
		//IL_01c7: Expected F4, but got I
		//IL_01c2: Expected native int or pointer, but got VT
		//IL_01d4: Expected F4, but got Obj
		//IL_01cf: Expected native int or pointer, but got VT
		//IL_01e9: Expected F4, but got I
		//IL_01e4: Expected native int or pointer, but got VT
		//IL_01f6: Expected F4, but got Obj
		//IL_01f1: Expected native int or pointer, but got VT
		//IL_0208: Expected F4, but got I
		//IL_0203: Expected native int or pointer, but got VT
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0238: Expected F4, but got Obj
		//IL_0233: Expected native int or pointer, but got VT
		//IL_024d: Expected F4, but got I
		//IL_0248: Expected native int or pointer, but got VT
		//IL_025a: Expected F4, but got Obj
		//IL_0255: Expected native int or pointer, but got VT
		//IL_026c: Expected F4, but got I
		//IL_0267: Expected native int or pointer, but got VT
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02d9: Expected F4, but got Obj
		//IL_02d4: Expected native int or pointer, but got VT
		//IL_02ee: Expected F4, but got I
		//IL_02e9: Expected native int or pointer, but got VT
		//IL_02fb: Expected F4, but got Obj
		//IL_02f6: Expected native int or pointer, but got VT
		//IL_0310: Expected F4, but got I
		//IL_030b: Expected native int or pointer, but got VT
		//IL_031d: Expected F4, but got Obj
		//IL_0318: Expected native int or pointer, but got VT
		//IL_032f: Expected F4, but got I
		//IL_032a: Expected native int or pointer, but got VT
		//IL_0351: Expected F4, but got Obj
		//IL_034c: Expected native int or pointer, but got VT
		//IL_0366: Expected F4, but got I
		//IL_0361: Expected native int or pointer, but got VT
		//IL_0373: Expected F4, but got Obj
		//IL_036e: Expected native int or pointer, but got VT
		//IL_0385: Expected F4, but got I
		//IL_0380: Expected native int or pointer, but got VT
		//IL_03a8: Expected Obj, but got F4
		//IL_03c4: Invalid comparison between Obj and F4
		//IL_03e5: Invalid comparison between Obj and F4
		//IL_03fb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 192;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 180;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 168;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 156;
		obj5 = ((bool*)(includeInactive ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeInactive @ L2 (System.Boolean)+8]");
		_ = 0;
		object obj6 = obj2 + 144;
		obj6 = type;
		_ = type._impl;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v129 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 216);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 228);
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj8 = obj2 + 132;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		obj = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj9 = obj2 + 120;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num3 = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v44 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v125 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v41+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj11 = obj2 + 108;
		object obj12 = default;
		float num5 = (float)obj12 * 0.5f;
		float size = 0f - num5;
		Vector3 vector3 = Math3D.SetVectorLength(vector2, size);
		obj = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v51+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)type;
		((Vector3*)(nint)vector)->z = (float)type._impl;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v51+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj13 = obj2 + 96;
		Vector3 vector4 = vector - vector2;
		((Vector3*)(nint)vector)->x = (((bool*)(includeSelf ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [includeSelf @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)type;
		((Vector3*)(nint)vector2)->z = (float)type._impl;
		object obj14 = obj2 + 84;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector, vector2);
		obj3 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v65+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj15 = default;
		float num6 = (float)obj15 * 0.5f;
		((Vector3*)(nint)vector)->x = ((int*)searchDepth)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [searchDepth @ L4 (System.Int32)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)type;
		((Vector3*)(nint)vector2)->z = (float)type._impl;
		object obj16 = obj2 + 72;
		Quaternion quaternion3 = Quaternion.FromToRotation(vector, vector2);
		obj4 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v76+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj17 = obj2 + 60;
		obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v59+8]");
		_ = 0;
		object obj18 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		Vector3 vector5 = (Vector3)(obj2 + 204);
		((Vector3*)(nint)vector5)->x = (float)obj17;
		Vector3 vector6 = vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v82+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v85+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)c;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)c).m_CachedPtr;
		object obj19 = obj2 + 36;
		Vector3 vector7 = Math3D.ProjectPointOnLineSegment(vector5, vector, vector2);
		((Vector3*)(nint)vector)->x = (float)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v94+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)c;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)c).m_CachedPtr;
		object obj20 = obj2 + 24;
		Quaternion quaternion4 = Quaternion.FromToRotation(vector, vector2);
		obj = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v100+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj21 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		((Vector3*)(nint)vector5)->x = (float)obj17;
		Vector3 vector8 = vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v82+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v106+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)c;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)c).m_CachedPtr;
		Vector3 vector9 = Math3D.ProjectPointOnLineSegment(vector5, vector, vector2);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)c;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)c).m_CachedPtr;
		Quaternion quaternion5 = Quaternion.FromToRotation(vector, vector2);
		obj = vector5.x;
		_ = vector5.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj22 = default;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6);
		object obj23 = default;
		float num7 = (float)obj23 * 0.5f;
		object obj24 = default;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num7);
		return (Component[])(flag & flag2);
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
		//IL_0026: Expected Obj, but got I4
		//IL_0026: Expected VT, but got I4
		//IL_0026: Expected VT, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_002a: Expected Obj, but got I4
		string tag = ((Component)(object)go).tag;
		return (Component[])((RouteChunk)(object)tag).CreateEnvironmentBase((int)type, (EnvironmentBaseKind)includeInactive, (EnvironmentBaseKind)includeSelf, (EnvironmentKind)searchDepth);
	}

	public static void GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, List<Component> result, bool includeSelf, int searchDepth)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		((SubwaySessionStartedEvent)(object)go)._002Ector();
		object obj = result & 1;
		int num = searchDepth & 1;
	}
}
