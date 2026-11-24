using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class TransformUtility
{
	public static Transform FindChild(Transform transform, string pattern)
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I4
		//IL_013b: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DateTimeFormatInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
		string shortDatePattern = currentInfo.ShortDatePattern;
		DateTimeFormatInfo currentInfo2 = DateTimeFormatInfo.CurrentInfo;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v22 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (Transform)(object)((System.DefaultBinder)(object)transform).BindToField((BindingFlags)shortDatePattern, (FieldInfo[])(object)currentInfo2, (object)80, (CultureInfo)(object)pattern);
	}

	public static Transform FindChild(Transform transform, string pattern, StringUtility.MatchType matchType)
	{
		//IL_0011: Expected I4, but got Obj
		//IL_0011: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		int num = ((string)(object)transform).IndexOfAny((char[])matchType, (int)pattern);
		int num2;
		int num3;
		if (num != 0)
		{
			if (num >= 1)
			{
				char[] separator = (char[])(num - 1);
				string[] array = ((string)(object)transform).Split(separator);
				object obj = array & 0xFFFF;
				bool flag = (nint)obj != 92;
				num2 = num;
				if (flag)
				{
					goto IL_00ce;
				}
			}
			num3 = -1;
		}
		else
		{
			num3 = 0;
		}
		num2 = num3;
		goto IL_00ce;
		IL_00ce:
		return (Transform)num2;
	}

	public unsafe static Transform FindChild(Transform transform, string pattern, StringUtility.MatchType matchType, bool ignoreCase)
	{
		//IL_015f: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected I4, but got Unknown
		//IL_00d1: Expected I4, but got Obj
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected I4, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I4, but got Unknown
		//IL_01bc: Expected I4, but got Obj
		//IL_0135: Expected Obj, but got I
		Transform transform2 = FindChild(transform, pattern, (StringUtility.MatchType)91);
		Transform transform5;
		if ((nint)transform2 >= 0)
		{
			string pattern2 = (string)(transform2 + 1);
			Transform transform3 = FindChild(transform, pattern2, (StringUtility.MatchType)93);
			if ((nint)transform3 >= 0)
			{
				int startIndex = transform2 + 1;
				object obj = (object)transform3 - (object)transform2;
				int length = obj - 1;
				string str = ((string)(object)transform).InternalSubString(startIndex, length);
				string text = string.Copy(str);
				((StringUtility.MatchType*)(int)matchType)->value__ = (int)text;
				string pattern3 = (string)(transform3 + 1);
				Transform transform4 = FindChild(transform, pattern3, (StringUtility.MatchType)91);
				bool flag = (nint)transform4 <= -1;
				bool flag2 = !flag;
				transform5 = transform4;
				if (!flag2)
				{
					transform5 = (Transform)(nint)((UnityEngine.Object)transform).m_CachedPtr;
				}
				int startIndex2 = transform3 + 1;
				object obj2 = (object)transform5 - (object)transform3;
				int length2 = obj2 - 1;
				string str2 = ((string)(object)transform).InternalSubString(startIndex2, length2);
				string text2 = string.Copy(str2);
				((bool*)(ignoreCase ? 1 : 0))->m_value = (byte)(int)text2 != 0;
				goto IL_01c1;
			}
		}
		((StringUtility.MatchType*)(int)matchType)->value__ = 0;
		((bool*)(ignoreCase ? 1 : 0))->m_value = false;
		transform5 = (Transform)(-1);
		goto IL_01c1;
		IL_01c1:
		return transform5;
	}

	public static void AddAndResetChild(Transform transform, Transform child)
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_ = ((UnityEngine.Object)child).m_CachedPtr;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = child + 16;
		obj2 = child;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D777");
	}

	public static int CountAllChildren(Transform parent)
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		object obj2 = default;
		object obj = obj2;
		nint num = (nint)typeof(DateTimeFormatInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF9");
		int result = default;
		return result;
	}

	public unsafe static T GetComponentInParents<T>(Transform child) where T : Component
	{
		//IL_026f: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0059: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected I, but got Unknown
		//IL_02bb: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0141: Expected I, but got Obj
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_01cf: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v2+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v93 @ S3_v6 (should have been resolved before IL gen)");
		object obj7 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v63 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v17+8]");
		object obj9 = 0;
		nint num4 = (nint)(obj9 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj9;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj10 = 97173;
		object obj11 = 0;
		object obj12 = default;
		Enum obj14 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v40 (Il2CppClass<System.Enum>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v59 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((Enum)(object)type).InternalHasFlag(obj14))
			{
				nint num7 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v50 (Il2CppClass<System.Enum>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num8 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v55 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((Enum)(object)type).ToString((string)(object)obj14, (IFormatProvider)1);
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				object obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S3_v9+10]");
				obj6 = 0;
				object obj18 = obj6 & 0x1FFF;
				obj10 = obj18 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S4_v4 (should have been resolved before IL gen)");
			}
			object obj19 = obj11 + 1;
			obj11 = obj19;
		}
		T result = default;
		return result;
	}

	public static void SetLayerRecursively(Transform t, int layer)
	{
		//IL_0126: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_0141: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		((Transform)layer).parentInternal = t;
		GameObject gameObject = ((Component)layer).gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v36 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		Vector2 zero = Vector2.zero;
		Transform transform = (Transform)(obj3 + 40);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		GameObject gameObject2 = ((Component)layer).gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3 + 12;
		Vector3 one = Vector3.one;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v23+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = ((Component)layer).gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject3).parent = transform;
	}
}
