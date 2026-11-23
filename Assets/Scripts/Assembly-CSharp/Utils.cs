using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

public static class Utils
{
	private enum LocaleComponents
	{
		language,
		countryCode
	}

	private static int randomNumber = -1;

	public static string stackTrace
	{
		get
		{
			//IL_0016: Expected I, but got Obj
			StackTrace stackTrace = default;
			stackTrace._002Ector();
			nint num = (nint)stackTrace;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v4 (Il2CppClass<System.Diagnostics.StackTrace>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
	}

	public static StringComparison stringComparison => StringComparison.InvariantCulture;

	public static StringComparison stringComparisonIgnoreCase => StringComparison.InvariantCultureIgnoreCase;

	public static StringComparer stringComparer => StringComparer.s_invariantCulture;

	public static StringComparer stringComparerIgnoreCase => StringComparer.s_invariantCultureIgnoreCase;

	public static T FindObject<T>(MonoBehaviour obj) where T : class
	{
		//IL_0058: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		UnityEngine.Object obj2 = UnityEngine.Object.FindObjectOfType(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		T result = default;
		return result;
	}

	public static T FindObject<T>(bool warnIfNotFound = true) where T : class
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c3: Expected VT, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+10]");
				return (T)0;
			}
		}
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (T)0;
	}

	public static T FindInThisOrParent<T>(Transform t, Func<T, bool> predicate) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Transform parent = default;
		UnityEngine.Object obj3 = default;
		UnityEngine.Object result;
		object obj5 = default;
		Transform transform = default;
		while (true)
		{
			if (parent != null)
			{
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v6 (Il2CppClass<Il2CppMethodRgctx<Utils::FindInThisOrParent>>)+4] (should have been resolved before IL gen)");
				if (obj3 != null)
				{
					bool flag = predicate == null;
					result = obj3;
					if (flag)
					{
						break;
					}
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S3_v5 (Il2CppMethodRgctx<Utils::FindInThisOrParent>)+C]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S3_v6+4] (should have been resolved before IL gen)");
					result = obj3;
					if (obj5 != null)
					{
						break;
					}
				}
				parent = transform.parent;
				continue;
			}
			object obj6 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			result = (UnityEngine.Object)0;
			break;
		}
		return (T)result;
	}

	public static T FindInParents<T>(MonoBehaviour obj, Func<T, bool> predicate) where T : Component
	{
		Transform transform = obj.transform;
		Transform parent = transform.parent;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Utils::FindInParents>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T FindComponentInThisOrParents<T>(MonoBehaviour obj) where T : Component
	{
		Transform transform = obj.transform;
		Transform parent = transform.parent;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Utils::FindComponentInThisOrParents>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T FindComponentInThisOrParents<T>(Transform t) where T : Component
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Utils::FindComponentInThisOrParents>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static string GetLongName(Transform transform)
	{
		if (transform == null)
		{
			return string.Empty;
		}
		Transform parent = transform.parent;
		string longName = GetLongName(parent);
		string name = transform.name;
		return longName + "/" + name;
	}

	public static string GetLongNameList(Component[] components)
	{
		//IL_00b7: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 0;
		if (components.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)components + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v17+10]");
			Transform transform = ((Component)0).transform;
			string longName = GetLongName(transform);
			throw new ArrayTypeMismatchException();
		}
		string[] value = default;
		return string.Join(", ", value);
	}

	public unsafe static void Bar(string text, float ratio, int offset, Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected VT, but got Unknown
		//IL_00b1: Expected F4, but got I
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00c6: Expected F4, but got I
		//IL_00c1: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 48);
		_ = color.b;
		_ = color.r;
		Color color2 = (Color)(rect + 16);
		GUI.color = color2;
		int height = Screen.height;
		int width = Screen.width;
		_ = 0;
		_ = 0;
		_ = 20f;
		float num = (float)width - 20f;
		float num2 = num * ratio;
		float num3 = (float)height - 20f;
		float num4 = num3 - 10f;
		float num5 = (float)offset * 20f;
		float num6 = num4 - num5;
		_ = 10f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
		((Rect*)(nint)rect)->m_XMin = 0f;
		bool flag = GUI.Button(rect, text);
	}

	public unsafe static DateTime StringToDateTime(string value, DateTime defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Ref, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Ref, but got Unknown
		//IL_00da: Expected VT, but got I
		//IL_00a1: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3;
		if (value != null)
		{
			obj3 = 0;
			if (value._stringLength != 0)
			{
				goto IL_0118;
			}
		}
		obj3 = 1;
		goto IL_0118;
		IL_0118:
		DateTime dateTime = default;
		if (obj3 == null)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (DateTime.TryParse(value, invariantCulture, DateTimeStyles.None, out *(DateTime*)(obj + 8)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				return (DateTime)0;
			}
			bool flag = DateTime.TryParse(value, out *(DateTime*)(obj + 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			DateTime result = (DateTime)0;
			if (!flag)
			{
				result = dateTime;
			}
			return result;
		}
		return dateTime;
	}

	private static int GetXorRandomValueForThisSession()
	{
		if (randomNumber == -1)
		{
			int num = UnityEngine.Random.Range(1, 10000);
			randomNumber = num;
		}
		return randomNumber;
	}

	public static int EncryptDecryptXORValue(int value)
	{
		int xorRandomValueForThisSession = GetXorRandomValueForThisSession();
		return xorRandomValueForThisSession ^ value;
	}

	private static string GetIntBinaryString(int n)
	{
		//IL_0086: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 31;
		object obj2 = 0;
		char[] array = default;
		while ((nint)obj2 < 32)
		{
			object obj3 = obj << 1;
			object obj4 = (object)array + obj3;
			int num = n >> (int)obj2;
			int num2 = num & 1;
			object obj5 = 49;
			if (num2 == 0)
			{
				obj5 = 48;
			}
			object obj6 = obj - 1;
			object obj7 = obj2 + 1;
			obj = obj6;
			obj2 = obj7;
		}
		return ((string)null).CreateString(array);
	}

	public static string toTitleCase(string value)
	{
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		nint num = (nint)invariantCulture;
		object obj = invariantCulture + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v3 (Il2CppClass<System.Globalization.CultureInfo>)+10C] (should have been resolved before IL gen)");
		TextInfo textInfo = default;
		return textInfo.ToTitleCase(value);
	}

	public static void DebugStar(Vector3 position, float radius, Color color, float duration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected VT, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0291: Invalid comparison between Obj and F4
		//IL_0738: Expected I, but got Obj
		//IL_0758: Expected Obj, but got I
		//IL_0771: Expected Obj, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected VT, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got F4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 160;
		_ = 0;
		_ = 0;
		_ = 0;
		List<Vector3> list = default;
		list._002Ector(27);
		object obj3 = -1;
		while ((nint)obj3 <= 1)
		{
			object obj4 = -1;
			while ((nint)obj4 <= 1)
			{
				object obj5 = -1;
				while ((nint)obj5 < 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Vector3 item = (Vector3)(obj + 8);
					list.Add(item);
					object obj6 = obj5 + 1;
					obj5 = obj6;
				}
				object obj7 = obj4 + 1;
				obj4 = obj7;
			}
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		object obj9 = obj + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1101");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj10 = obj + 136;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj12 = default;
		object obj25 = default;
		object obj26 = default;
		object obj28 = default;
		object obj29 = default;
		while (true)
		{
			_ = 0;
			object obj11 = obj + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj12 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+9C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [534CC8]");
					if ((nint)0 == 0)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0494;
						}
						_ = 1;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_0494;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					object obj13 = num * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+64]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+64]");
					object obj14 = num2 * 0;
					object obj15 = obj13 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					object obj16 = num3 * 0;
					object obj17 = obj15 + obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
					object obj19;
					Vector3 vector2;
					object obj20;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
						object obj18 = 0 / obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
						Vector3 vector = (Vector3)(0 / obj17);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+64]");
						obj19 = 0 / obj17;
						vector2 = vector;
						obj20 = obj18;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53703E]");
						if ((nint)0 == 0)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_0494;
							}
							_ = 1;
						}
						nint num4 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v141 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v142 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
						obj19 = 0;
						vector2 = Vector3.zeroVector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v142 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						obj20 = 0;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						float num6 = (float)obj20 * radius;
						float num7 = (float)obj19 * radius;
						float num8 = (float)vector2 * radius;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
						_ = 0;
						object obj21 = obj - -64;
						obj21 = position.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
						_ = 0;
						_ = position.x;
						_ = color.b;
						_ = color.r;
						object obj22 = obj + 56;
						object obj23 = obj + 40;
						object obj24 = obj + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6D");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
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
			goto IL_04b2;
			IL_04b2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj25 == obj26;
			bool flag2 = !flag;
			object obj27 = obj28;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj27 = obj29;
			}
			_ = 0;
			object obj30 = obj + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_0494:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_04b2;
		}
		object obj31 = obj + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @ADDE");
	}

	public static string GetContryCodeFromLocale(string deviceLocale)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (deviceLocale != null)
		{
			obj = 0;
			if (deviceLocale._stringLength != 0)
			{
				goto IL_0114;
			}
		}
		obj = 1;
		goto IL_0114;
		IL_0114:
		string result = string.Empty;
		if (obj == null)
		{
			string text = deviceLocale.Trim();
			string text2 = text.ToLower();
			string text3 = text2.Replace('-', '_');
			bool flag = text3.Contains("_");
			bool flag2 = !flag;
			result = string.Empty;
			if (!flag2)
			{
				string[] array = text3.Split('_');
				bool flag3 = array.Length != 2;
				result = string.Empty;
				if (!flag3)
				{
					result = array[1];
				}
			}
		}
		return result;
	}

	public static bool IsEnum(Type type)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+2EC] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static Attribute GetCustomAttribute(Type type, Type attributeType)
	{
		return Attribute.GetCustomAttribute(type, attributeType);
	}

	public static bool IsInterface(Type type)
	{
		return type.IsInterface;
	}

	public static Type BaseType(Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = type + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3+BC] (should have been resolved before IL gen)");
		Type result = default;
		return result;
	}

	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Utils::ConvertAll>>)+4] (should have been resolved before IL gen)");
		TOutput[] result = default;
		return result;
	}

	public static void ThreadSleep(TimeSpan timeSpan)
	{
		Thread.Sleep(timeSpan);
	}
}
