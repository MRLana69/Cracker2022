using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP.Internal;
using UnityEngine;

namespace Kiloo.Common.Diagnostics;

public static class Assert
{
	public class AssertFailedException : Exception
	{
	}

	private static void FailAssert()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Dictionary<string, Hosts.HostData> hostData = default;
		Hosts._hostData = hostData;
	}

	public unsafe static void IsNotNull(object obj, string paramName, UnityEngine.Object context)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		//IL_00b7: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj3 = default;
		LogType logType = (LogType)(obj3 + 8);
		((LogType*)(int)logType)->value__ = (int)obj3;
		((Console)obj).HandleLog(paramName, (string)(object)context, logType);
	}

	public static void IsNotNull(object obj, string paramName)
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string tag = ((Component)obj).tag;
		bool activeSelf = ((GameObject)(object)tag).activeSelf;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		IsNotNull(obj, paramName, (UnityEngine.Object)(object)typeName);
	}

	public static void IsTrue(bool condition, string message, UnityEngine.Object context)
	{
		if (!condition)
		{
			object msg = ((IConvertible)"Assert failed: ").ToType((Type)(object)message, (IFormatProvider)(object)" is null!");
			SDebug.LogFormat((string)msg, (object[])(object)context);
			Console._002Ecctor();
		}
	}

	public static void IsFalse(bool condition, string message, UnityEngine.Object context)
	{
		//IL_0013: Expected I4, but got Obj
		if (!condition)
		{
			string msg = string.ConcatArray((string[])(object)"Assert failed: ", (int)message);
			SDebug.LogFormat(msg, (object[])(object)context);
			Console._002Ecctor();
		}
	}

	public unsafe static void IsTrue(bool condition)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016f: Expected VT, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0020: Expected VT, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected VT, but got Unknown
		//IL_018f: Expected F4, but got Obj
		//IL_018a: Expected native int or pointer, but got VT
		//IL_01a1: Expected F4, but got I
		//IL_019c: Expected native int or pointer, but got VT
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected VT, but got Unknown
		//IL_01bc: Expected F4, but got Obj
		//IL_01b7: Expected native int or pointer, but got VT
		//IL_01d1: Expected F4, but got I
		//IL_01cc: Expected native int or pointer, but got VT
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01fd: Expected F4, but got Obj
		//IL_01f8: Expected native int or pointer, but got VT
		//IL_020f: Expected F4, but got I
		//IL_020a: Expected native int or pointer, but got VT
		//IL_021c: Expected F4, but got Obj
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0231: Expected F4, but got I
		//IL_022c: Expected native int or pointer, but got VT
		//IL_024f: Expected F4, but got Obj
		//IL_024a: Expected native int or pointer, but got VT
		//IL_0264: Expected F4, but got I
		//IL_025f: Expected native int or pointer, but got VT
		//IL_026d: Expected Obj, but got VT
		//IL_0092: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 88);
		transform = (Transform)0;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		_ = 0;
		object obj2 = obj + 72;
		obj2 = 0;
		_ = 0;
		UIExtensions.CenterInViewport(transform, (Camera)condition);
		object obj3 = obj + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17+8]");
		_ = 0;
		Transform transform2 = (Transform)(obj + 48);
		transform2.position = (Vector3)condition;
		Transform transform3 = (Transform)(obj + 36);
		transform3.position = (Vector3)condition;
		object obj4 = obj + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 112);
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj + 124);
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v25+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj6 = obj + 12;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v39+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 localPosition = ((Transform)vector2).localPosition;
	}

	public static void IsFalse(bool condition)
	{
		if (!condition)
		{
			SDebug.LogFormat("Assert failed!", null);
			Console._002Ecctor();
		}
	}

	public static void IsTrue(bool condition, string message)
	{
		if (!condition)
		{
			object msg = ((IConvertible)"Assert failed: ").ToType((Type)(object)message, (IFormatProvider)(object)" is null!");
			SDebug.LogFormat((string)msg, null);
			Console._002Ecctor();
		}
	}

	public static void IsFalse(bool condition, string message)
	{
		//IL_0013: Expected I4, but got Obj
		if (!condition)
		{
			string msg = string.ConcatArray((string[])(object)"Assert failed: ", (int)message);
			SDebug.LogFormat(msg, null);
			Console._002Ecctor();
		}
	}
}
