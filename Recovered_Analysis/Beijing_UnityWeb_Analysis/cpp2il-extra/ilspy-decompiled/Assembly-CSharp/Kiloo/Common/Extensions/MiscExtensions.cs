using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using UI.Screens;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;

namespace Kiloo.Common.Extensions;

public static class MiscExtensions
{
	public static void Destroy(UnityEngine.Object obj)
	{
		//IL_0049: Expected Obj, but got I4
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			((GameObject)obj).tag = null;
			((GameObject)obj).tag = (string)1;
		}
	}

	public static string UnifyNewlines(string content)
	{
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_005f: Expected VT, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0111: Expected VT, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_0169: Expected VT, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)(object)content);
		int layer = gameObject.layer;
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 28);
		int layer2 = ((GameObject)(object)content).layer;
		transform.position = (Vector3)layer2;
		Transform transform3 = (Transform)(transform2 + 40);
		transform3 = transform;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 localPosition = transform3.localPosition;
		int layer3 = gameObject.layer;
		int layer4 = ((GameObject)(object)content).layer;
		Transform parentInternal = ((Transform)layer4).parentInternal;
		((Transform)layer3).parentInternal = parentInternal;
		int layer5 = gameObject.layer;
		Transform transform4 = (Transform)(transform2 + 16);
		int layer6 = ((GameObject)(object)content).layer;
		transform4.localScale = (Vector3)layer6;
		transform3 = transform4;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
		((Transform)layer5).parent = transform3;
		int layer7 = gameObject.layer;
		int layer8 = ((GameObject)(object)content).layer;
		transform2.rotation = (Quaternion)layer8;
		transform3 = transform2;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion localRotation = transform3.localRotation;
		return (string)(object)gameObject;
	}

	public static string UnifyNewlines(string content, string newline)
	{
		//IL_004b: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		string result;
		if (content != null)
		{
			bool flag = (int)content.m_firstChar >= (nint)newline;
			bool flag2 = !flag;
			string text = (string)content.m_firstChar;
			if (!flag2)
			{
				text = newline;
			}
			object obj = 0;
			while (true)
			{
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text);
				result = (string)1;
				if (flag3)
				{
					break;
				}
				object obj2 = content + 16;
				object obj3 = obj2 + obj;
				object obj4 = obj3 & 0xFF;
				if ((nint)obj4 <= 31)
				{
					object obj5 = obj3 - 9;
					if ((nint)obj3 != 9 && (nint)obj5 != 1 && ((nint)obj5 == 2 || (nint)obj5 == 3 || (nint)obj5 != 4))
					{
						result = null;
						break;
					}
				}
				object obj6 = obj + 1;
				obj = obj6;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public unsafe static bool TryParseHexToColor(string hexString, out Color color)
	{
		//IL_001d: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		//IL_004a: Expected I4, but got Obj
		//IL_004e: Expected I4, but got Obj
		string text = hexString.Remove((int)"\r\n", (int)"\n");
		string text2 = text.Remove((int)"\r", (int)"\n");
		return (byte)(int)text2.Remove((int)"\n", (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref color)) != 0;
	}

	public unsafe static Color ToColor(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025b: Expected I4, but got Obj
		//IL_0271: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_029c: Invalid comparison between VT and I4
		//IL_0175: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected VT, but got Unknown
		//IL_01be: Invalid comparison between F4 and I4
		//IL_01fa: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		GameObject gameObject = default;
		gameObject.SetActive((byte)(int)s != 0);
		int layer = gameObject.layer;
		object current = ((Transform.Enumerator)layer).Current;
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 70;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		Color color = default;
		if (color != (Color)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		Color result;
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj2 + obj8;
			if ((nint)obj9 == 70)
			{
				Color color2 = (Color)(obj2 + 4);
				if (color2.r > -1f)
				{
					float r = color2.r + -1f;
					((Color*)(nint)color2)->r = r;
				}
				result = color2;
				goto IL_02bd;
			}
		}
		object obj10 = default;
		bool flag = obj10 == null;
		result = color;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			result = color;
		}
		goto IL_02bd;
		IL_02bd:
		return result;
	}

	public unsafe static string ToHex(Color color)
	{
		//IL_0016: Expected Obj, but got VT
		//IL_001a: Expected Obj, but got I4
		PlatformID platform = Environment.Platform;
		return (string)TryParseHexToColor((string)color, out *(Color*)(int)platform);
	}

	public unsafe static string ToUIHex(Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected I4, but got F4
		//IL_001b: Expected native int or pointer, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_005a: Expected I4, but got Obj
		//IL_0055: Expected native int or pointer, but got VT
		object obj = default;
		Color32 color2 = (Color32)(obj + 8);
		((Color32*)(nint)color2)->rgba = (int)color.r;
		_ = color.b;
		Color color3 = color2;
		object obj2 = obj + 4;
		obj2 = obj;
		((Color32*)(nint)color2)->rgba = (int)obj2;
		return ToUIHex(color2);
	}

	public unsafe static string ToHex(Color32 color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_005d: Expected I4, but got Obj
		//IL_0058: Expected native int or pointer, but got VT
		object obj = default;
		Color32 color2 = (Color32)(obj + 8);
		((Color32*)(nint)color2)->rgba = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [color @ L0 (UnityEngine.Color32)+8]");
		_ = 0;
		Color color3 = color2;
		object obj2 = obj + 4;
		obj2 = obj;
		((Color32*)(nint)color2)->rgba = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		string result = default;
		return result;
	}

	public static string ToUIHex(Color32 color)
	{
		//IL_0121: Expected I4, but got Obj
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		stringBuilder.Length = (int)"#";
		object obj2 = default;
		object obj = obj2 + 8;
		obj = color.rgba;
		object obj3 = obj2 + 14;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string value = $"{args:X2}";
		StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
		object obj4 = obj2 + 4;
		obj4 = color.rgba;
		object obj5 = obj2 + 13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16+1]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args2 = default;
		string value2 = $"{args2:X2}";
		StringBuilder stringBuilder3 = stringBuilder2.AppendLine(value2);
		obj2 = color.rgba;
		object obj6 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+2]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args3 = default;
		string value3 = $"{args3:X2}";
		StringBuilder stringBuilder4 = stringBuilder3.AppendLine(value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string result = default;
		return result;
	}

	public static Color WithAlpha(Color c, float a)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got VT
		//IL_00b1: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Convert.ToBoolean(a);
		Color color = default;
		((ThreadPooling)color).RunAsync((Action<ThreadPooling.ProgressDelegate>)c, (Action)flag);
		return color;
	}

	public unsafe static Color NormalizeRGB(Color color)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got VT
		//IL_0013: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected VT, but got Unknown
		//IL_0189: Expected F4, but got Obj
		//IL_0184: Expected native int or pointer, but got VT
		//IL_00c5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		char[] array = default;
		object obj = array + 16;
		obj = 35;
		string text = ((string)color).TrimStart(array);
		string s = text.InternalSubString(0, 2);
		byte b = byte.Parse(s, (IFormatProvider)515);
		string s2 = text.InternalSubString(2, 2);
		byte b2 = byte.Parse(s2, (IFormatProvider)515);
		string s3 = text.InternalSubString(4, 2);
		byte b3 = byte.Parse(s3, (IFormatProvider)515);
		if (text.m_stringLength > 6)
		{
			string s4 = text.InternalSubString(6, 2);
			byte b4 = byte.Parse(s4, (IFormatProvider)515);
		}
		else
		{
			byte b4 = byte.MaxValue;
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = 0;
		obj2 = 0;
		obj2 = b;
		obj3 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 8);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		Color result = default;
		return result;
	}

	public static TEnum ToEnum<TEnum>(string strEnumValue, TEnum defaultValue)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		TEnum result = default;
		return result;
	}

	public static T SafeInvoke<T>(Func<T> f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = f + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7BFC");
		T result = default;
		return result;
	}

	public static void SafeInvoke(Action action)
	{
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_014e: Expected I, but got Obj
		//IL_00dd: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)action != null)
		{
			return;
		}
		RuntimePlatform platform = Application.platform;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (platform != RuntimePlatform.OSXEditor)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)action);
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)action);
	}

	public static void SafeInvoke<T>(Action<T> action, T argument)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 40;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 8;
		object obj6 = action + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ L0 (System.Action`1<T>)+4]");
		if ((nint)0 == -1)
		{
			obj5 = obj6;
			obj = obj5;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+8]");
			bool flag = (nint)0 != 0;
		}
		else
		{
			obj4 = obj6;
			obj = obj4;
			obj3 = obj;
			_ = 1;
		}
		obj2 = argument;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @75ED");
		obj6 = obj3;
	}

	public static void SafeInvoke<T1, T2>(Action<T1, T2> action, T1 argument1, T2 argument2)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got VT
		object obj = action + 16;
		obj = argument1;
	}

	public static void SafeInvoke<T1, T2, T3>(Action<T1, T2, T3> action, T1 argument1, T2 argument2, T3 argument3)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FF;
		object obj4 = obj3 + 123986;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S6_v4 (should have been resolved before IL gen)");
	}

	public unsafe static void SafeInvoke<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
	{
		//IL_0009: Expected Ref, but got VT
		//IL_001d: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0068: Expected I4, but got VT
		//IL_0068: Expected Obj, but got VT
		//IL_0068: Expected I4, but got VT
		int end = ((RangeInt*)argument4)->end;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L5 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FFF;
		object obj4 = obj3 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23 @ S7_v4 (should have been resolved before IL gen)");
		int baseVertex = default;
		((Mesh)(object)action).SetTrianglesImpl((int)argument1, (Array)argument2, (int)argument3, (byte)end != 0, baseVertex);
	}

	public unsafe static string NicifyTimeString(TimeSpan ts)
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_01a3: Invalid comparison between VT and I4
		//IL_0018: Expected native int or pointer, but got VT
		//IL_008b: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got VT
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected VT, but got Unknown
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0115: Expected I, but got Obj
		object obj = ts + 2147483648L;
		if ((long)obj >= 4294967296L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.ParamsArray paramsArray = default;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)paramsArray, new System.ParamsArray("Part of OID doesn't fit in Int32"));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		TimeSpan timeSpan = ts;
		object obj2 = 1;
		while (timeSpan >= (object)128)
		{
			TimeSpan timeSpan2 = (TimeSpan)(timeSpan >> 7);
			object obj3 = obj2 + 1;
			timeSpan = timeSpan2;
			obj2 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = 0;
		string text = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj5 = obj4 * 7;
			object obj6 = obj5 & 0x3F;
			object obj7 = ts >> (int)obj6;
			TimeSpan timeSpan3 = (TimeSpan)(obj7 & 0x7F);
			bool flag = obj4 == null;
			TimeSpan ts2 = timeSpan3;
			if (!flag)
			{
				TimeSpan timeSpan4 = timeSpan3 + 128;
				ts2 = timeSpan4;
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v28 (Il2CppClass<System.Convert>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v37 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = obj2 - obj4;
			object obj10 = text + obj9;
			object obj11 = obj10 + 15;
			string text2 = PauseScreen.FormatTopRunTimeLeft(ts2);
			obj11 = text2;
			object obj12 = obj4 + 1;
			obj4 = obj12;
		}
		return text;
	}

	public unsafe static string NicifyTimeStringSubwayStyle(TimeSpan ts)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00ee: Expected I8, but got VT
		//IL_0013: Expected I, but got Obj
		ref NetworkAccessToken reference = ref *(NetworkAccessToken*)null;
		nint num = (nint)typeof(UnityEngine.Networking.Utility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Networking.Utility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Networking.Utility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<UnityEngine.Networking.Utility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Networking.Utility.s_dictTokens.TryGetValue((NetworkID)(long)ts, out reference))
		{
			return (string)(object)reference;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GlobalConfig globalConfig = default;
		NetworkTransport.Init(globalConfig);
		reference = ref *(NetworkAccessToken*)globalConfig;
		return (string)(object)globalConfig;
	}

	public static Texture2D Circle(Texture2D tex, int x, int y, int r, Color color)
	{
		//IL_00e9: Invalid comparison between VT and I4
		//IL_00db: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		if (color != (Color)(object)0)
		{
			if ((color & 2) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tex @ L0 (UnityEngine.Texture2D)+1C]");
				bool flag = (nint)0 != 0;
				return (Texture2D)flag;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			X509Certificate2 x509Certificate = default;
			x509Certificate.PrivateKey = (AsymmetricAlgorithm)y;
			WebClient.CacheInfo cacheInfo = WebClient.HandleCacheBeforeRequest((IRequest)x509Certificate);
			if (cacheInfo != null)
			{
				return (Texture2D)1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tex @ L0 (UnityEngine.Texture2D)+1C]");
			bool flag2 = (nint)0 != 0;
			return (Texture2D)flag2;
		}
		return (Texture2D)1;
	}
}
