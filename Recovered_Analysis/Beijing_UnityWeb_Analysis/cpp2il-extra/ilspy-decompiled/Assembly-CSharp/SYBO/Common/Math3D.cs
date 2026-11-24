using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using InApp;
using Info;
using SYBO.Components.Analytics;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Crypt;
using SYBO.Components.Json;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Common;

public class Math3D
{
	private static Transform tempChild;

	private static Transform tempParent;

	private static Vector3[] positionRegister;

	private static float[] posTimeRegister;

	private static int positionSamplesTaken;

	private static Quaternion[] rotationRegister;

	private static float[] rotTimeRegister;

	public unsafe static void Init()
	{
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected I, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_030a: Expected I, but got Obj
		//IL_0320: Expected Obj, but got I
		//IL_0442: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0359: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I
		//IL_03a7: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_022d: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v94 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 8);
		object obj3 = obj2 + 4;
		if (~(AnalyticsIntegration._jsonClassInfoCached ? 1u : 0u) == 0)
		{
			return;
		}
		nint num4 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v24 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v88 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnalyticsIntegration._jsonClassInfoCached = true;
		nint num6 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v33 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v84 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = typeof(AnalyticsEvent);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type assemblyString = Type.internal_from_handle((IntPtr)num3);
		Assembly assembly = Assembly.Load((string)(object)assemblyString);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj7 = default;
		object obj6 = obj7 + 12;
		object obj8 = default;
		object reflectedType;
		object obj11 = default;
		object obj13 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				return;
			}
			object obj9 = obj7 + 16;
			object obj10 = obj8 << 2;
			reflectedType = obj9 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(JsonClassInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v51 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num9 = (nint)typeof(JsonClassInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v80 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				break;
			}
			obj8 = obj13 + 1;
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection((Type)reflectedType);
		nint num10 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v60 (Il2CppClass<System.Type>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num11 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v76 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(TransferEvent<>);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static Vector3 AddVectorLength(Vector3 vector, float size)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got VT
		Vector3 vector2 = default;
		object obj = vector2 + 8;
		obj = vector;
		return vector2;
	}

	public unsafe static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		//IL_005f: Expected Obj, but got F4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c5: Expected F4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_00e3: Expected Ref, but got VT
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0124: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = vector.x;
		_ = vector.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = (Vector3)(obj + 12);
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		float magnitude = ((Vector3*)vector2)->magnitude;
		float num3 = magnitude + size;
		float num4 = num3 / magnitude;
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		Vector3 vector3 = vector2 / num4;
		Vector3 result = default;
		return result;
	}

	public static Quaternion SubtractRotation(Quaternion B, Quaternion A)
	{
		//IL_0009: Expected Obj, but got VT
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got VT
		Quaternion quaternion = default;
		((SubwaySessionStartedEvent)quaternion)._002Ector();
		object obj = quaternion + 36;
		obj = B;
		return quaternion;
	}

	public unsafe static bool PlanePlaneIntersection(out Vector3 linePoint, out Vector3 lineVec, Vector3 plane1Normal, Vector3 plane1Position, Vector3 plane2Normal, Vector3 plane2Position)
	{
		//IL_00e0: Expected Obj, but got I4
		//IL_00ed: Invalid comparison between Obj and VT
		//IL_00d7: Expected I4, but got VT
		//IL_000e: Expected Obj, but got Ref
		//IL_004e: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got Ref
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I4, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got Ref
		object obj = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref plane1Position))
		{
			if (((CounterModeCryptoTransform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref linePoint)).InputBlockSize != 0)
			{
				((CounterModeCryptoTransform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref linePoint)).IncrementCounter();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [linePoint @ L0 (UnityEngine.Vector3&)+10]");
			byte b = ((Queue<byte>)0).Dequeue();
			object obj2 = plane2Normal + 16;
			object obj3 = obj + plane2Position;
			object obj4 = obj2 + obj3;
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref lineVec, 16));
			object obj6 = obj + plane1Normal;
			object obj7 = obj5 + obj6;
			int num = obj7 ^ b;
			obj4 = num;
			object obj8 = obj + 1;
			obj = obj8;
		}
		return (byte)(int)plane1Position != 0;
	}

	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planePoint, Vector3 planeNormal)
	{
		//IL_01d2: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02d1: Invalid comparison between VT and I4
		//IL_0013: Invalid comparison between F4 and I4
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0096: Invalid comparison between VT and I4
		//IL_0347: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_0315: Expected Obj, but got VT
		//IL_0315: Expected Obj, but got VT
		//IL_00c0: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I
		//IL_0132: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_03d5: Expected Obj, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0173: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S5_v10 (should have been resolved before IL gen)");
		Vector3 vector = default;
		if (vector != (Vector3)(object)0 && vector.z != 0f)
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S4_v23 (Il2CppMethodInfo)+C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S4_v24+60]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S4_v25+48]");
			object obj18 = 0;
			object obj19 = obj18 & 0x7FF;
			object obj20 = obj19 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S5_v19 (should have been resolved before IL gen)");
			if (planeNormal != (Vector3)(object)0)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v34 (Il2CppMethodInfo)+C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v35+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v36+48]");
				object obj23 = 0;
				object obj24 = obj23 & 0x7FF;
				object obj25 = obj24 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v150 @ S5_v28 (should have been resolved before IL gen)");
			}
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v29 (Il2CppMethodInfo)+C]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v30+60]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S4_v31+48]");
			object obj28 = 0;
			object obj29 = obj28 & 0x7FF;
			object obj30 = obj29 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v112 @ S5_v24 (should have been resolved before IL gen)");
		}
		string text = string.Format((IFormatProvider)(object)"{0} {1}\n{2}", (string)linePoint, lineVec, "");
		Encoding latin = Encoding.Latin1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [intersection @ L0 (UnityEngine.Vector3&)+18]");
		Func<HashAlgorithm> createFipsHashAlgorithmCallback = default;
		HashAlgorithm hashAlgorithmWithFipsFallback = HMAC.GetHashAlgorithmWithFipsFallback((Func<HashAlgorithm>)0, createFipsHashAlgorithmCallback);
		nint num7 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v12 (Il2CppClass<System.Convert>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num8 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v19 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = Convert.FromBase64String((string)(object)hashAlgorithmWithFipsFallback);
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S4_v18 (Il2CppMethodInfo)+C]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S4_v19+60]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S4_v20+48]");
		object obj34 = 0;
		object obj35 = obj34 & 0x7FF;
		object obj36 = obj35 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213 @ S5_v15 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public unsafe static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected VT, but got Unknown
		//IL_031f: Expected native int or pointer, but got VT
		//IL_0331: Expected native int or pointer, but got VT
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected VT, but got Unknown
		//IL_0351: Expected native int or pointer, but got VT
		//IL_0363: Expected native int or pointer, but got VT
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0394: Expected F4, but got Obj
		//IL_038f: Expected native int or pointer, but got VT
		//IL_03a6: Expected F4, but got I4
		//IL_03a1: Expected native int or pointer, but got VT
		//IL_03b3: Expected native int or pointer, but got VT
		//IL_03c5: Expected native int or pointer, but got VT
		//IL_0440: Expected native int or pointer, but got VT
		//IL_0452: Expected native int or pointer, but got VT
		//IL_0464: Expected native int or pointer, but got VT
		//IL_0476: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got F4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_01a0: Expected F4, but got Obj
		//IL_019b: Expected native int or pointer, but got VT
		//IL_01b5: Expected F4, but got I
		//IL_01b0: Expected native int or pointer, but got VT
		//IL_01d5: Expected Obj, but got VT
		//IL_01e2: Expected Obj, but got F4
		//IL_020c: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_024c: Expected F4, but got Obj
		//IL_0247: Expected native int or pointer, but got VT
		//IL_0261: Expected F4, but got I
		//IL_025c: Expected native int or pointer, but got VT
		//IL_026e: Expected F4, but got Obj
		//IL_0269: Expected native int or pointer, but got VT
		//IL_0283: Expected F4, but got I
		//IL_027e: Expected native int or pointer, but got VT
		//IL_00b8: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v85 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		object obj4 = obj3 + 12;
		object obj5 = obj3 + 48;
		Vector3 one = Vector3.one;
		ref Vector3 reference = ref *(Vector3*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj3 + 60);
		((Vector3*)(nint)vector)->x = linePoint2.x;
		((Vector3*)(nint)vector)->z = linePoint2.z;
		Vector3 vector2 = (Vector3)(obj3 + 72);
		((Vector3*)(nint)vector2)->x = linePoint1.x;
		((Vector3*)(nint)vector2)->z = linePoint1.z;
		SafeAnimation safeAnimation = (SafeAnimation)(obj3 + 36);
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		((Vector3*)(nint)vector)->x = (float)safeAnimation;
		((Vector3*)(nint)vector)->z = (safeAnimation._loggingEnabled ? 1 : 0);
		((Vector3*)(nint)vector2)->x = lineVec2.x;
		((Vector3*)(nint)vector2)->z = lineVec2.z;
		float num3 = vector.x * vector2.x;
		float num4 = vector.y * vector2.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector2.z;
		float num7 = num5 + num6;
		((Vector3*)(nint)vector)->x = lineVec1.x;
		((Vector3*)(nint)vector)->z = lineVec1.z;
		((Vector3*)(nint)vector2)->x = lineVec2.x;
		((Vector3*)(nint)vector2)->z = lineVec2.z;
		float num8 = vector.x * vector2.x;
		float num9 = vector.y * vector2.y;
		float num10 = num8 + num9;
		float num11 = vector.z * vector2.z;
		float num12 = num10 + num11;
		if (num12 != 0f)
		{
			obj5 = lineVec1.x;
			_ = lineVec1.z;
			nint num13 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v53 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num14 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v81 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj5;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			float speed = num7 / num12;
			safeAnimation.SetSpeed((string)vector2, speed);
			obj2 = linePoint1.x;
			_ = linePoint1.z;
			obj4 = safeAnimation;
			_ = safeAnimation._loggingEnabled;
			nint num15 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v65 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num16 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Vector3 vector5 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Vector3 vector6 = vector - vector2;
			reference = ref *(Vector3*)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			return true;
		}
		return false;
	}

	public unsafe static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I4
		//IL_0336: Expected I, but got Obj
		//IL_034c: Expected Obj, but got I
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected VT, but got Unknown
		//IL_05b8: Expected native int or pointer, but got VT
		//IL_05ca: Expected native int or pointer, but got VT
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected VT, but got Unknown
		//IL_05ea: Expected native int or pointer, but got VT
		//IL_05fc: Expected native int or pointer, but got VT
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_0074: Expected native int or pointer, but got VT
		//IL_0086: Expected native int or pointer, but got VT
		//IL_0098: Expected F4, but got Obj
		//IL_0093: Expected native int or pointer, but got VT
		//IL_00ad: Expected F4, but got I
		//IL_00a8: Expected native int or pointer, but got VT
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ee: Expected native int or pointer, but got VT
		//IL_0100: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got Obj
		//IL_010d: Expected native int or pointer, but got VT
		//IL_0127: Expected F4, but got I
		//IL_0122: Expected native int or pointer, but got VT
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01df: Expected I, but got Obj
		//IL_022b: Expected Obj, but got F4
		//IL_0242: Expected Obj, but got F4
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_03ab: Expected F4, but got Obj
		//IL_03a6: Expected native int or pointer, but got VT
		//IL_03c0: Expected F4, but got I
		//IL_03bb: Expected native int or pointer, but got VT
		//IL_03cd: Expected F4, but got Obj
		//IL_03c8: Expected native int or pointer, but got VT
		//IL_03e2: Expected F4, but got I
		//IL_03dd: Expected native int or pointer, but got VT
		//IL_0400: Expected native int or pointer, but got VT
		//IL_0412: Expected native int or pointer, but got VT
		//IL_0424: Expected F4, but got Obj
		//IL_041f: Expected native int or pointer, but got VT
		//IL_0439: Expected F4, but got I
		//IL_0434: Expected native int or pointer, but got VT
		//IL_04be: Expected F4, but got Obj
		//IL_04b9: Expected native int or pointer, but got VT
		//IL_04d3: Expected F4, but got I
		//IL_04ce: Expected native int or pointer, but got VT
		//IL_04f1: Expected native int or pointer, but got VT
		//IL_0503: Expected native int or pointer, but got VT
		//IL_0515: Expected F4, but got Obj
		//IL_0510: Expected native int or pointer, but got VT
		//IL_052a: Expected F4, but got I
		//IL_0525: Expected native int or pointer, but got VT
		//IL_029b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v104 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 48;
		Vector3 one = Vector3.one;
		ref Vector3 reference = ref *(Vector3*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
		_ = 0;
		object obj5 = obj2 + 36;
		Vector3 one2 = Vector3.one;
		ref Vector3 reference2 = ref *(Vector3*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 72);
		((Vector3*)(nint)vector)->x = linePoint1.x;
		((Vector3*)(nint)vector)->z = linePoint1.z;
		Vector3 vector2 = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector2)->x = linePoint2.x;
		((Vector3*)(nint)vector2)->z = linePoint2.z;
		object obj6 = obj2 + 24;
		Vector3 vector3 = Vector3.Min(vector, vector2);
		reference2 = ref *(Vector3*)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v31+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = linePoint2.x;
		((Vector3*)(nint)vector)->z = linePoint2.z;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v31+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj7 = obj2 + 12;
		Vector3 vector5 = Vector3.Min(vector, vector2);
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v39+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = linePoint1.x;
		((Vector3*)(nint)vector)->z = linePoint1.z;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v39+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		float num3 = vector.x * vector2.x;
		float num4 = vector.y * vector2.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector2.z;
		float num7 = num5 + num6;
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v100 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num10 = System.Math.Abs(num7);
		if (num10 > 0.006f)
		{
			obj4 = lineVec1.x;
			_ = lineVec1.z;
			obj5 = lineVec2.x;
			_ = lineVec2.z;
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v66 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj5;
			Vector3 vector8 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
			((Vector3*)(nint)vector)->x = linePoint1.x;
			((Vector3*)(nint)vector)->z = linePoint1.z;
			((Vector3*)(nint)vector2)->x = (float)obj6;
			Vector3 vector9 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v31+8]");
			((Vector3*)(nint)vector9)->z = 0f;
			float num13 = vector.x * vector2.x;
			float num14 = vector.y * vector2.y;
			float num15 = num13 + num14;
			float num16 = vector.z * vector2.z;
			float num17 = num15 + num16;
			float angle = num17 / num7;
			((Vector3*)(nint)vector2)->x = (float)obj;
			Vector3 vector10 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			Quaternion quaternion2 = Quaternion.AngleAxis(angle, vector2);
			((Vector3*)(nint)vector)->x = lineVec2.x;
			((Vector3*)(nint)vector)->z = lineVec2.z;
			((Vector3*)(nint)vector2)->x = (float)obj7;
			Vector3 vector11 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v39+8]");
			((Vector3*)(nint)vector11)->z = 0f;
			Vector3 vector12 = vector - vector2;
			reference = ref *(Vector3*)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			return true;
		}
		return false;
	}

	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		//IL_0009: Expected Obj, but got VT
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got VT
		//IL_002c: Expected Obj, but got F4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		Vector3 vector = default;
		((ClientUpdatedEvent)vector)._002Ector();
		object obj = vector + 44;
		obj = linePoint;
		object obj2 = point.x;
		AnalyticsEvent analyticsEvent = (AnalyticsEvent)(obj2 + 8);
		analyticsEvent = (AnalyticsEvent)obj2;
		object obj3 = vector + 48;
		string text = analyticsEvent.ToString();
		obj3 = text;
		return vector;
	}

	public unsafe static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got F4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got F4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected VT, but got Unknown
		//IL_00fd: Expected F4, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got I
		//IL_010d: Expected native int or pointer, but got VT
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_012d: Expected F4, but got Obj
		//IL_0128: Expected native int or pointer, but got VT
		//IL_0142: Expected F4, but got I
		//IL_013d: Expected native int or pointer, but got VT
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_016e: Expected F4, but got Obj
		//IL_0169: Expected native int or pointer, but got VT
		//IL_0183: Expected F4, but got I
		//IL_017e: Expected native int or pointer, but got VT
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_021d: Expected native int or pointer, but got VT
		//IL_022f: Expected native int or pointer, but got VT
		//IL_0252: Expected native int or pointer, but got VT
		//IL_0264: Expected native int or pointer, but got VT
		//IL_0276: Expected F4, but got Obj
		//IL_0271: Expected native int or pointer, but got VT
		//IL_028b: Expected F4, but got I
		//IL_0286: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = point.x;
		_ = point.z;
		object obj3 = obj2 + 24;
		obj3 = linePoint1.x;
		_ = linePoint1.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj5 = obj2 + 12;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector3);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector3)->x = linePoint2.x;
		((Vector3*)(nint)vector3)->z = linePoint2.z;
		float num3 = vector.x * vector3.x;
		float num4 = vector.y * vector3.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector3.z;
		float num7 = num5 + num6;
		((Vector3*)(nint)vector3)->x = linePoint2.x;
		((Vector3*)(nint)vector3)->z = linePoint2.z;
		Vector3 vector6 = vector3 / num7;
		((Vector3*)(nint)vector)->x = linePoint1.x;
		((Vector3*)(nint)vector)->z = linePoint1.z;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Vector3 vector7 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Vector3 vector8 = vector - vector3;
		Vector3 result = default;
		return result;
	}

	public unsafe static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got F4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0264: Expected Obj, but got F4
		//IL_027c: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected VT, but got Unknown
		//IL_040e: Expected F4, but got Obj
		//IL_0409: Expected native int or pointer, but got VT
		//IL_0423: Expected F4, but got I
		//IL_041e: Expected native int or pointer, but got VT
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected VT, but got Unknown
		//IL_043e: Expected F4, but got Obj
		//IL_0439: Expected native int or pointer, but got VT
		//IL_0453: Expected F4, but got I
		//IL_044e: Expected native int or pointer, but got VT
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got F4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04df: Expected Obj, but got F4
		//IL_04f7: Expected I, but got Obj
		//IL_050d: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected VT, but got Unknown
		//IL_02ca: Expected F4, but got Obj
		//IL_02c5: Expected native int or pointer, but got VT
		//IL_02df: Expected F4, but got I
		//IL_02da: Expected native int or pointer, but got VT
		//IL_02ec: Expected F4, but got Obj
		//IL_02e7: Expected native int or pointer, but got VT
		//IL_0301: Expected F4, but got I
		//IL_02fc: Expected native int or pointer, but got VT
		//IL_030e: Expected F4, but got Obj
		//IL_0309: Expected native int or pointer, but got VT
		//IL_0323: Expected F4, but got I
		//IL_031e: Expected native int or pointer, but got VT
		//IL_035a: Expected native int or pointer, but got VT
		//IL_036c: Expected native int or pointer, but got VT
		//IL_037e: Expected native int or pointer, but got VT
		//IL_0390: Expected native int or pointer, but got VT
		//IL_03a2: Expected F4, but got Obj
		//IL_039d: Expected native int or pointer, but got VT
		//IL_03b7: Expected F4, but got I
		//IL_03b2: Expected native int or pointer, but got VT
		//IL_03c8: Expected I4, but got VT
		//IL_03c8: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00eb: Expected F4, but got Obj
		//IL_00e6: Expected native int or pointer, but got VT
		//IL_0100: Expected F4, but got I
		//IL_00fb: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0124: Expected native int or pointer, but got VT
		//IL_013b: Expected native int or pointer, but got VT
		//IL_014d: Expected native int or pointer, but got VT
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 84;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 72;
		obj4 = planePoint.x;
		_ = planePoint.z;
		object obj5 = obj2 + 60;
		obj5 = planeNormal.x;
		_ = planeNormal.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 120);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 132);
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj2 + 48;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32+8]");
		_ = 0;
		object obj8 = obj2 + 36;
		obj8 = planeNormal.x;
		_ = planeNormal.z;
		object obj9 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		object obj10 = obj2 + 12;
		obj10 = point.x;
		_ = point.z;
		nint num3 = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v44 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v84 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector3 = (Vector3)(obj2 + 108);
		((Vector3*)(nint)vector3)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v36+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v39+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v41+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector4 = ProjectPointOnLineSegment(vector3, vector, vector2);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector3)->x = planeNormal.x;
		((Vector3*)(nint)vector3)->z = planeNormal.z;
		((Vector3*)(nint)vector)->x = planePoint.x;
		((Vector3*)(nint)vector)->z = planePoint.z;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector5 = default;
		switch (LinearAcceleration(out *(Vector3*)vector3, vector, (int)vector2))
		{
		case false:
			((Vector3*)(nint)vector5)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			break;
		case true:
			((Vector3*)(nint)vector5)->x = planeNormal.x;
			((Vector3*)(nint)vector5)->z = planeNormal.z;
			break;
		case true:
			((Vector3*)(nint)vector5)->x = planePoint.x;
			((Vector3*)(nint)vector5)->z = planePoint.z;
			break;
		default:
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v75 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v80 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			break;
		}
		}
		return vector5;
	}

	public unsafe static Vector3 ProjectVectorOnPlane(Vector3 planeNormal, Vector3 vector)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got F4
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00d3: Expected F4, but got Obj
		//IL_00ce: Expected native int or pointer, but got VT
		//IL_00e8: Expected F4, but got I
		//IL_00e3: Expected native int or pointer, but got VT
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected VT, but got Unknown
		//IL_0110: Expected F4, but got Obj
		//IL_010b: Expected native int or pointer, but got VT
		//IL_0125: Expected F4, but got I
		//IL_0120: Expected native int or pointer, but got VT
		//IL_0132: Expected native int or pointer, but got VT
		//IL_0144: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = vector.x;
		_ = vector.z;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v27 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(vector2);
		Quaternion quaternion2 = (Quaternion)(obj2 + 32);
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		((Vector3*)(nint)vector2)->x = planeNormal.x;
		((Vector3*)(nint)vector2)->z = planeNormal.z;
		Vector3 vector3 = quaternion2 * vector2;
		Vector3 result = default;
		return result;
	}

	public unsafe static float SignedDistancePlanePoint(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_0918: Expected Obj, but got I4
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Ref, but got Unknown
		//IL_092f: Expected Ref, but got F4
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Obj, but got Unknown
		//IL_0946: Expected Obj, but got I4
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_095d: Expected Obj, but got I4
		//IL_0c0c: Invalid comparison between Obj and F4
		//IL_01a1: Expected I4, but got Obj
		//IL_01a1: Expected I4, but got Obj
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_0012: Expected Obj, but got VT
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_098c: Expected I4, but got Obj
		//IL_0c42: Expected I, but got Obj
		//IL_0c58: Expected Obj, but got I
		//IL_0206: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Expected Obj, but got Unknown
		//IL_0c9d: Expected Obj, but got I4
		//IL_0cc4: Expected Obj, but got I4
		//IL_02e1: Expected I, but got Obj
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected Obj, but got Unknown
		//IL_0a93: Expected I, but got Obj
		//IL_0aa9: Expected Obj, but got I
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Expected Obj, but got Unknown
		//IL_09a7: Expected I4, but got Obj
		//IL_09d9: Expected Obj, but got I4
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected Obj, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected Obj, but got Unknown
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_0294: Expected I, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_076f: Expected Ref, but got F4
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected Obj, but got Unknown
		//IL_0b2d: Expected I, but got Obj
		//IL_0b43: Expected Obj, but got I
		//IL_03d5: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_036f: Expected I, but got Obj
		//IL_0b61: Expected I4, but got Obj
		//IL_07ca: Expected I, but got Obj
		//IL_07e0: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_0416: Expected I, but got Obj
		//IL_0bf0: Expected Obj, but got F4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_080b: Expected I, but got Obj
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_0580: Expected Obj, but got I4
		//IL_05f9: Expected Obj, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_06ab: Expected I, but got Obj
		//IL_06c1: Expected Obj, but got I
		//IL_0baf: Expected I4, but got Obj
		//IL_06ec: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		ref float reference = ref *(float*)(obj2 + 8);
		reference = ref *(float*)0f;
		object obj3 = obj2 + 14;
		obj3 = 0;
		object obj4 = obj2 + 12;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = default;
		CultureInfo.CheckDomainSafetyObject(obj5, (object)"en-US");
		string text = "";
		char[] array = default;
		char[] array3 = default;
		int totalLength = default;
		for (; System.Runtime.CompilerServices.Unsafe.As<char[], UIntPtr>(ref array) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)planeNormal.z); array = (char[])(array3 + 1))
		{
			string[] array2 = ((string)planeNormal).Split(array);
			obj3 = array2;
			nint num = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v160 (Il2CppClass<System.Char>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v183 (Il2CppClass<System.Char>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!char.CheckLetter((UnicodeCategory)array2))
			{
				nint num3 = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v165 (Il2CppClass<System.Char>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(char);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v175 (Il2CppClass<System.Char>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = char.IsUpper((char)(int)obj3);
				bool flag2 = (nint)obj3 != 46;
				bool flag3 = (nint)obj3 == 44;
				object obj8 = flag | flag3;
				object obj9 = obj8 ^ 1;
				object obj10 = flag2 & obj9;
				if (obj10 != null)
				{
					if (text.m_stringLength > 0)
					{
						break;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			string text2 = string.ConcatArray((string[])(object)text, totalLength);
			text = text2;
		}
		string str = text.Remove((int)" ", (int)"");
		string text3 = string.Copy(str);
		nint num5 = (nint)typeof(AnalyticsHelper._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v29 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(AnalyticsHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v152 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = AnalyticsHelper._003C_003Ec._003C_003E9__0_0 == null;
		bool flag5 = !flag4;
		Func<char, bool> predicate = AnalyticsHelper._003C_003Ec._003C_003E9__0_0;
		if (!flag5)
		{
			nint num7 = (nint)typeof(AnalyticsHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v126 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num8 = (nint)typeof(AnalyticsHelper._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v146 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			Func<char, bool> func = default;
			object obj13 = func + 16;
			obj13 = AnalyticsHelper._003C_003Ec._003C_003E9;
			nint num10 = (nint)typeof(AnalyticsHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v143 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+5C]");
			object obj14 = (nint)0 + (nint)4;
			obj14 = func;
			predicate = func;
		}
		int num11 = Enumerable.Count(text3, predicate);
		nint num12 = (nint)typeof(AnalyticsHelper._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v24 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num13 = (nint)typeof(AnalyticsHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v140 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6 = AnalyticsHelper._003C_003Ec._003C_003E9__0_1 == null;
		bool flag7 = !flag6;
		Func<char, bool> predicate2 = AnalyticsHelper._003C_003Ec._003C_003E9__0_1;
		if (!flag7)
		{
			nint num14 = (nint)typeof(AnalyticsHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v114 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num15 = (nint)typeof(AnalyticsHelper._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v134 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num16 = 0;
			_ = 0;
			Func<char, bool> func2 = default;
			object obj17 = func2 + 16;
			obj17 = AnalyticsHelper._003C_003Ec._003C_003E9;
			nint num17 = (nint)typeof(AnalyticsHelper._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v131 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper+<>c>)+5C]");
			object obj18 = (nint)0 + (nint)8;
			obj18 = func2;
			predicate2 = func2;
		}
		object obj19 = obj2 + 4;
		int num18 = Enumerable.Count(text3, predicate2);
		obj = 46;
		string text4 = "";
		char[] array4 = null;
		int num19 = num11;
		int num20 = num18;
		char[] array5 = (char[])(-1);
		char[] array7;
		int totalLength2 = default;
		int totalLength3 = default;
		for (; (nint)array4 < text3.m_stringLength; array7 = (char[])(array4 + 1), array4 = array7)
		{
			string[] array6 = text3.Split(array4);
			obj4 = array6;
			nint num21 = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v69 (Il2CppClass<System.Char>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num22 = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v121 (Il2CppClass<System.Char>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (char.CheckLetter((UnicodeCategory)array6))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
				string text5 = string.ConcatArray((string[])(object)text4, totalLength2);
				text4 = text5;
				continue;
			}
			bool flag8 = (nint)obj4 == 44;
			bool flag9 = obj4 == obj;
			object obj21 = flag8 | flag9;
			if (obj21 == null)
			{
				continue;
			}
			if ((nint)array5 >= 1)
			{
				object obj22 = (object)array4 - (object)array5;
				if ((nint)obj22 <= 2)
				{
					goto IL_0758;
				}
			}
			object obj23 = text3.m_stringLength - array4;
			if ((nint)obj23 > 2)
			{
				bool flag10 = num19 < 2;
				bool flag11 = obj4 != obj;
				object obj24 = flag10 | flag11;
				if (obj24 == null)
				{
					int num23 = num19 - 1;
					num19 = num23;
					array5 = array4;
					continue;
				}
				bool flag12 = num20 < 2;
				bool flag13 = (nint)obj4 != 44;
				object obj25 = flag12 | flag13;
				if (obj25 == null)
				{
					int num24 = num20 - 1;
					num20 = num24;
					array5 = array4;
					continue;
				}
				object obj26 = text3.m_stringLength - array4;
				if ((nint)obj26 == 3)
				{
					char[] trimChars = (char[])(array4 + 1);
					string text6 = text3.Trim(trimChars);
					nint num25 = (nint)typeof(AnalyticsHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S1_v96 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
					object obj27 = (nint)0 & (nint)0x200;
					if (obj27 != null)
					{
						nint num26 = (nint)typeof(AnalyticsHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S1_v103 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (AnalyticsHelper.ConvertFacebookRewardToItemType((FacebookRewardsInfo.FacebookRewardType)text6) != InAppItemModel.ItemType.Undefined)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
						string text7 = string.ConcatArray((string[])(object)text4, totalLength3);
						text4 = text7;
					}
				}
				array5 = array4;
				continue;
			}
			goto IL_0758;
			IL_0758:
			return -1f;
		}
		reference = ref *(float*)(-1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		NumberFormatInfo info = default;
		if (!float.TryParse(text4, NumberStyles.Float, info, out reference))
		{
			nint num27 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v54 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num28 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v61 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			obj19 = timeSinceLevelLoad;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		return reference;
	}

	public unsafe static float SignedDotProduct(Vector3 vectorA, Vector3 vectorB, Vector3 normal)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got F4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got F4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got F4
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected VT, but got Unknown
		//IL_011d: Expected F4, but got Obj
		//IL_0118: Expected native int or pointer, but got VT
		//IL_0132: Expected F4, but got I
		//IL_012d: Expected native int or pointer, but got VT
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_014d: Expected F4, but got Obj
		//IL_0148: Expected native int or pointer, but got VT
		//IL_0162: Expected F4, but got I
		//IL_015d: Expected native int or pointer, but got VT
		//IL_0180: Expected F4, but got Obj
		//IL_017b: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got I
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01a2: Expected F4, but got Obj
		//IL_019d: Expected native int or pointer, but got VT
		//IL_01b7: Expected F4, but got I
		//IL_01b2: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = vectorA.x;
		_ = vectorA.z;
		object obj3 = obj2 + 24;
		obj3 = normal.x;
		_ = normal.z;
		object obj4 = obj2 + 12;
		obj4 = vectorB.x;
		_ = vectorB.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector3);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Vector3 vector6 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		float num3 = vector.x * vector3.x;
		float num4 = vector.y * vector3.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector3.z;
		return num5 + num6;
	}

	public unsafe static float SignedVectorAngle(Vector3 referenceVector, Vector3 otherVector, Vector3 normal)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got F4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got F4
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected VT, but got Unknown
		//IL_00f8: Expected F4, but got Obj
		//IL_00f3: Expected native int or pointer, but got VT
		//IL_010d: Expected F4, but got I
		//IL_0108: Expected native int or pointer, but got VT
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected VT, but got Unknown
		//IL_0128: Expected F4, but got Obj
		//IL_0123: Expected native int or pointer, but got VT
		//IL_013d: Expected F4, but got I
		//IL_0138: Expected native int or pointer, but got VT
		//IL_015b: Expected F4, but got Obj
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0170: Expected F4, but got I
		//IL_016b: Expected native int or pointer, but got VT
		//IL_017d: Expected native int or pointer, but got VT
		//IL_018f: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = normal.x;
		_ = normal.z;
		object obj3 = obj2 + 12;
		obj3 = referenceVector.x;
		_ = referenceVector.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 36);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = Vector3.Min(vector, vector3);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector3)->x = otherVector.x;
		((Vector3*)(nint)vector3)->z = otherVector.z;
		float num3 = vector.x * vector3.x;
		float num4 = vector.y * vector3.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector3.z;
		return num5 + num6;
	}

	public static float AngleVectorPlane(Vector3 vector, Vector3 normal)
	{
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_01e1: Invalid comparison between I4 and VT
		//IL_017b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got VT
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref vector2))
		{
			/*Error: End of method reached without returning.*/;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3)+C]");
		if ((nint)0 == 2)
		{
			obj2 = 0;
		}
		if ((nint)obj2 == 1)
		{
			Texture mainTexture = ((UISprite)vector).mainTexture;
			return (float)mainTexture / 2f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3)+18]");
		if ((nint)2 < (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3)+18]");
			return 0f / 2f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3)+1C]");
		if ((nint)2 > (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3)+1C]");
			return 0f / 2f;
		}
		return 1f;
	}

	public static float DotProductAngle(Vector3 vec1, Vector3 vec2)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got F4
		//IL_00d1: Expected Obj, but got F4
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = vec1.x;
		_ = vec1.z;
		obj2 = vec2.x;
		_ = vec2.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v40 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj5 = obj2 + 36;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = obj4 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22+4]");
		object obj7 = num3 * 0;
		object obj8 = obj6 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22+8]");
		object obj9 = num4 * 0;
		object obj10 = obj8 + obj9;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122EB");
		object obj12 = default;
		return (float)System.Math.PI / 2f - (float)obj12;
	}

	public unsafe static void PlaneFrom3Points(out Vector3 planeNormal, out Vector3 planePoint, Vector3 pointA, Vector3 pointB, Vector3 pointC)
	{
		//IL_0009: Expected Obj, but got Ref
		//IL_0017: Expected Obj, but got Ref
		//IL_001f: Expected Obj, but got Ref
		//IL_002d: Expected Obj, but got Ref
		//IL_0035: Expected Obj, but got VT
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		((SubwaySessionStartedEvent)System.Runtime.CompilerServices.Unsafe.AsPointer(ref planeNormal))._002Ector();
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planeNormal, 36));
		obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref planePoint);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planeNormal, 40));
		obj2 = pointA;
		object obj3 = pointC & 1;
	}

	public static Vector3 GetForwardVector(Quaternion q)
	{
		//IL_0039: Expected Obj, but got VT
		//IL_0039: Expected Obj, but got I
		//IL_001a: Expected Obj, but got VT
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
		((List<Collider>)0).Add((Collider)q);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+18]");
			((Action<Collider>)0)((Collider)q);
		}
		Vector3 result = default;
		return result;
	}

	public unsafe static Vector3 GetUpVector(Quaternion q)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got F4
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0120: Expected F4, but got Obj
		//IL_011b: Expected native int or pointer, but got VT
		//IL_0135: Expected F4, but got I
		//IL_0130: Expected native int or pointer, but got VT
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected VT, but got Unknown
		//IL_0150: Expected F4, but got Obj
		//IL_014b: Expected native int or pointer, but got VT
		//IL_0165: Expected F4, but got I
		//IL_0160: Expected native int or pointer, but got VT
		//IL_0176: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = q.x;
		_ = q.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v30 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 32);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = default;
		((Quaternion*)vector3)->SetLookRotation(vector, vector2);
		return vector3;
	}

	public unsafe static Vector3 GetRightVector(Quaternion q)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got F4
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0120: Expected F4, but got Obj
		//IL_011b: Expected native int or pointer, but got VT
		//IL_0135: Expected F4, but got I
		//IL_0130: Expected native int or pointer, but got VT
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected VT, but got Unknown
		//IL_0150: Expected F4, but got Obj
		//IL_014b: Expected native int or pointer, but got VT
		//IL_0165: Expected F4, but got I
		//IL_0160: Expected native int or pointer, but got VT
		//IL_0176: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = q.x;
		_ = q.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down = Vector3.down;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v30 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 32);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = default;
		((Quaternion*)vector3)->SetLookRotation(vector, vector2);
		return vector3;
	}

	public unsafe static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got F4
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0120: Expected F4, but got Obj
		//IL_011b: Expected native int or pointer, but got VT
		//IL_0135: Expected F4, but got I
		//IL_0130: Expected native int or pointer, but got VT
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected VT, but got Unknown
		//IL_0150: Expected F4, but got Obj
		//IL_014b: Expected native int or pointer, but got VT
		//IL_0165: Expected F4, but got I
		//IL_0160: Expected native int or pointer, but got VT
		//IL_0176: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = m.m00;
		_ = m.m20;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion identity = Quaternion.identity;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v30 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 32);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion quaternion = default;
		((Quaternion*)quaternion)->SetLookRotation(vector, vector2);
		return quaternion;
	}

	public unsafe static Vector3 PositionFromMatrix(Matrix4x4 m)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected VT, but got Unknown
		//IL_0154: Expected F4, but got Obj
		//IL_014f: Expected native int or pointer, but got VT
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01a1: Expected F4, but got Obj
		//IL_019c: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected VT, but got Unknown
		//IL_01db: Expected F4, but got Obj
		//IL_01d6: Expected native int or pointer, but got VT
		//IL_01f0: Expected F4, but got I
		//IL_01eb: Expected native int or pointer, but got VT
		//IL_01fd: Expected F4, but got Obj
		//IL_01f8: Expected native int or pointer, but got VT
		//IL_00a1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v41 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 80);
		((Vector2*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = obj2 + 32;
		Vector4 vector2 = vector;
		object obj5 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
		((Vector2*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v21+8]");
		_ = 0;
		Vector4 vector3 = vector;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v37 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj2 - -64);
		((Quaternion*)(nint)quaternion)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		((Vector2*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Quaternion quaternion2 = quaternion * (Quaternion)vector;
		Vector3 result = default;
		return result;
	}

	public unsafe static void LookRotationExtended(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 customForward, Vector3 customUp)
	{
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0576: Expected Obj, but got I4
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_0593: Expected Obj, but got I4
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05b0: Expected Obj, but got I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05cd: Expected Obj, but got I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got I4
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected VT, but got Unknown
		//IL_0607: Expected native int or pointer, but got VT
		//IL_0615: Expected native int or pointer, but got VT
		//IL_0628: Expected I, but got Obj
		//IL_063e: Expected Obj, but got I
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0771: Expected F4, but got Obj
		//IL_076c: Expected native int or pointer, but got VT
		//IL_0786: Expected F4, but got I
		//IL_0781: Expected native int or pointer, but got VT
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected VT, but got Unknown
		//IL_07a1: Expected native int or pointer, but got VT
		//IL_07b3: Expected native int or pointer, but got VT
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected VT, but got Unknown
		//IL_07d3: Expected native int or pointer, but got VT
		//IL_07e5: Expected native int or pointer, but got VT
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected Obj, but got Unknown
		//IL_0074: Expected native int or pointer, but got VT
		//IL_0086: Expected native int or pointer, but got VT
		//IL_0098: Expected native int or pointer, but got VT
		//IL_00aa: Expected native int or pointer, but got VT
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00f0: Expected F4, but got Obj
		//IL_00eb: Expected native int or pointer, but got VT
		//IL_0105: Expected F4, but got I
		//IL_0100: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got Obj
		//IL_010d: Expected native int or pointer, but got VT
		//IL_0127: Expected F4, but got I
		//IL_0122: Expected native int or pointer, but got VT
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0158: Expected F4, but got Obj
		//IL_0153: Expected native int or pointer, but got VT
		//IL_016d: Expected F4, but got I
		//IL_0168: Expected native int or pointer, but got VT
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Expected Ref, but got VT
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got F4
		//IL_01cf: Expected F4, but got Obj
		//IL_01ca: Expected native int or pointer, but got VT
		//IL_01e4: Expected F4, but got I
		//IL_01df: Expected native int or pointer, but got VT
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected VT, but got Unknown
		//IL_0204: Expected I4, but got VT
		//IL_0204: Expected Ref, but got VT
		//IL_0216: Expected F4, but got Obj
		//IL_0211: Expected native int or pointer, but got VT
		//IL_022b: Expected F4, but got I
		//IL_0226: Expected native int or pointer, but got VT
		//IL_0238: Expected native int or pointer, but got VT
		//IL_0252: Expected F4, but got I
		//IL_024d: Expected native int or pointer, but got VT
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got F4
		//IL_02b8: Expected F4, but got Obj
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02cd: Expected F4, but got I
		//IL_02c8: Expected native int or pointer, but got VT
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected VT, but got Unknown
		//IL_02ed: Expected I4, but got VT
		//IL_02ed: Expected Ref, but got VT
		//IL_02ff: Expected F4, but got Obj
		//IL_02fa: Expected native int or pointer, but got VT
		//IL_0314: Expected F4, but got I
		//IL_030f: Expected native int or pointer, but got VT
		//IL_0321: Expected native int or pointer, but got VT
		//IL_033b: Expected F4, but got I
		//IL_0336: Expected native int or pointer, but got VT
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_037c: Expected native int or pointer, but got VT
		//IL_038e: Expected native int or pointer, but got VT
		//IL_03a0: Expected F4, but got Obj
		//IL_039b: Expected native int or pointer, but got VT
		//IL_03b5: Expected F4, but got I
		//IL_03b0: Expected native int or pointer, but got VT
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03fb: Expected native int or pointer, but got VT
		//IL_040d: Expected native int or pointer, but got VT
		//IL_041f: Expected F4, but got Obj
		//IL_041a: Expected native int or pointer, but got VT
		//IL_0434: Expected F4, but got I
		//IL_042f: Expected native int or pointer, but got VT
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04df: Expected I, but got Obj
		//IL_04f5: Expected Obj, but got I
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected VT, but got Unknown
		//IL_0676: Expected F4, but got Obj
		//IL_0671: Expected native int or pointer, but got VT
		//IL_068b: Expected F4, but got I
		//IL_0686: Expected native int or pointer, but got VT
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected VT, but got Unknown
		//IL_06a6: Expected F4, but got Obj
		//IL_06a1: Expected native int or pointer, but got VT
		//IL_06bb: Expected F4, but got I
		//IL_06b6: Expected native int or pointer, but got VT
		//IL_06c8: Expected F4, but got Obj
		//IL_06c3: Expected native int or pointer, but got VT
		//IL_06dd: Expected F4, but got I
		//IL_06d8: Expected native int or pointer, but got VT
		//IL_06ea: Expected F4, but got Obj
		//IL_06e5: Expected native int or pointer, but got VT
		//IL_06ff: Expected F4, but got I
		//IL_06fa: Expected native int or pointer, but got VT
		//IL_0520: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 276;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 264;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 252;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 240;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 228;
		obj6 = 0;
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 216);
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v146 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = obj2 + 204;
		Vector3 one = Vector3.one;
		ref GameObject reference = ref *(GameObject*)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+8]");
		_ = 0;
		object obj9 = obj2 + 192;
		Vector3 one2 = Vector3.one;
		((Vector3*)(nint)alignWithVector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v36+8]");
		((Vector3*)(nint)alignWithVector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 312);
		((Vector3*)(nint)vector2)->x = customForward.x;
		((Vector3*)(nint)vector2)->z = customForward.z;
		Vector3 vector3 = (Vector3)(obj2 + 324);
		((Vector3*)(nint)vector3)->x = alignWithNormal.x;
		((Vector3*)(nint)vector3)->z = alignWithNormal.z;
		object obj10 = obj2 + 180;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector3);
		obj = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v46+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = customUp.x;
		((Vector3*)(nint)vector2)->z = customUp.z;
		((Vector3*)(nint)vector3)->x = alignWithNormal.x;
		((Vector3*)(nint)vector3)->z = alignWithNormal.z;
		object obj11 = obj2 + 168;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector3);
		obj3 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v54+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v54+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj12 = obj2 + 156;
		Vector3 vector4 = Vector3.Min(vector2, vector3);
		((Vector3*)(nint)vector3)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v62+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj13 = obj2 + 144;
		Vector3 normalized = ((Vector3*)vector3)->normalized;
		reference = ref *(GameObject*)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v66+8]");
		_ = 0;
		object obj14 = obj2 + 132;
		obj14 = alignWithNormal.x;
		_ = alignWithNormal.z;
		((Vector3*)(nint)vector3)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector2 vector5 = (Vector2)(obj2 + 120);
		((Vector2*)vector5)->set_Item((int)vector3, 2f);
		((Vector3*)(nint)vector2)->x = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v70+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = vector5.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v75 (UnityEngine.Vector2)+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj15 = obj2 + 108;
		Vector3 vector6 = vector2 - vector3;
		obj4 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v81+8]");
		_ = 0;
		object obj16 = obj2 + 96;
		obj16 = alignWithNormal.x;
		_ = alignWithNormal.z;
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector2 vector7 = (Vector2)(obj2 + 84);
		((Vector2*)vector7)->set_Item((int)vector3, 2f);
		((Vector3*)(nint)vector2)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v85+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = vector7.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v90 (UnityEngine.Vector2)+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj17 = obj2 + 72;
		Vector3 vector8 = vector2 - vector3;
		obj5 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v96+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = customUp.x;
		((Vector3*)(nint)vector2)->z = customUp.z;
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj18 = obj2 + 60;
		Quaternion quaternion3 = Quaternion.FromToRotation(vector2, vector3);
		obj6 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v104+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = customForward.x;
		((Vector3*)(nint)vector2)->z = customForward.z;
		((Vector3*)(nint)vector3)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj19 = obj2 + 48;
		Quaternion quaternion4 = Quaternion.FromToRotation(vector2, vector3);
		object obj20 = obj2 + 36;
		obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj21 = obj2 + 24;
		obj21 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		_ = 0;
		object obj22 = obj2 + 12;
		obj22 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		obj2 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v112+8]");
		_ = 0;
		nint num3 = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v125 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num4 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v142 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector9 = (Vector3)(obj2 + 288);
		((Vector3*)(nint)vector9)->x = (float)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v114+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		Vector3 vector10 = (Vector3)(obj2 + 300);
		((Vector3*)(nint)vector10)->x = (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v117+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v120+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		bool flag = IsLineInRectangle(alignWithVector, vector, vector9, vector10, vector2, vector3);
	}

	public unsafe static void TransformWithParent(out Quaternion childRotation, out Vector3 childPosition, Quaternion parentRotation, Vector3 parentPosition, Quaternion startParentRotation, Vector3 startParentPosition, Quaternion startChildRotation, Vector3 startChildPosition)
	{
		//IL_0b15: Expected F4, but got I
		//IL_0b10: Expected native int or pointer, but got VT
		//IL_0b25: Expected Obj, but got I
		//IL_004d: Expected F4, but got I
		//IL_0b6b: Expected native int or pointer, but got VT
		//IL_0b86: Expected Obj, but got I
		//IL_0038: Expected F4, but got I4
		//IL_0228: Expected F4, but got I
		//IL_0223: Expected native int or pointer, but got VT
		//IL_0231: Expected native int or pointer, but got VT
		//IL_03b7: Expected Obj, but got I
		//IL_054b: Expected F4, but got I4
		//IL_0546: Expected native int or pointer, but got VT
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_0c16: Expected Obj, but got I4
		//IL_0c27: Expected F4, but got Obj
		//IL_0c22: Expected native int or pointer, but got VT
		//IL_0c42: Expected Obj, but got F4
		//IL_0c53: Expected F4, but got Obj
		//IL_0c4e: Expected native int or pointer, but got VT
		//IL_0c61: Expected I, but got Obj
		//IL_0c77: Expected Obj, but got I
		//IL_059a: Expected I, but got Obj
		//IL_05ea: Expected Obj, but got I
		//IL_05fb: Expected F4, but got Obj
		//IL_05f6: Expected native int or pointer, but got VT
		//IL_0609: Expected I, but got Obj
		//IL_061f: Expected Obj, but got I
		//IL_0e12: Expected Obj, but got I
		//IL_0e12: Expected Obj, but got F4
		//IL_0e23: Expected F4, but got Obj
		//IL_0e1e: Expected native int or pointer, but got VT
		//IL_0e38: Expected F4, but got I
		//IL_0e33: Expected native int or pointer, but got VT
		//IL_0cae: Expected F4, but got Obj
		//IL_0ca9: Expected native int or pointer, but got VT
		//IL_0ac1: Expected I, but got Obj
		//IL_064a: Expected I, but got Obj
		//IL_0697: Expected F4, but got I4
		//IL_0692: Expected native int or pointer, but got VT
		//IL_06a5: Expected I, but got Obj
		//IL_06bb: Expected Obj, but got I
		//IL_0cf4: Expected F4, but got Obj
		//IL_0cef: Expected native int or pointer, but got VT
		//IL_06e6: Expected I, but got Obj
		//IL_0733: Expected F4, but got I4
		//IL_072e: Expected native int or pointer, but got VT
		//IL_0741: Expected Obj, but got Ref
		//IL_0a12: Expected native int or pointer, but got VT
		//IL_0a25: Expected F4, but got Obj
		//IL_0a20: Expected native int or pointer, but got VT
		//IL_0a33: Expected I, but got Obj
		//IL_0a49: Expected Obj, but got I
		//IL_0dce: Expected Obj, but got I
		//IL_0a74: Expected I, but got Obj
		//IL_0790: Expected F4, but got I4
		//IL_078b: Expected native int or pointer, but got VT
		//IL_079e: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I
		//IL_0d0b: Expected Obj, but got I4
		//IL_0d1c: Expected F4, but got Obj
		//IL_0d17: Expected native int or pointer, but got VT
		//IL_07df: Expected I, but got Obj
		//IL_082c: Expected F4, but got I4
		//IL_0827: Expected native int or pointer, but got VT
		//IL_083a: Expected I, but got Obj
		//IL_0850: Expected Obj, but got I
		//IL_0321: Expected I, but got Obj
		//IL_0337: Expected Obj, but got I
		//IL_0d4b: Expected F4, but got Obj
		//IL_0d46: Expected native int or pointer, but got VT
		//IL_0bea: Expected Obj, but got I
		//IL_087b: Expected I, but got Obj
		//IL_0362: Expected I, but got Obj
		//IL_097b: Expected F4, but got I4
		//IL_0976: Expected native int or pointer, but got VT
		//IL_0989: Expected I, but got Obj
		//IL_099f: Expected Obj, but got I
		//IL_0db1: Expected F4, but got Obj
		//IL_0dac: Expected native int or pointer, but got VT
		//IL_08ed: Expected I, but got Obj
		//IL_0903: Expected Obj, but got I
		//IL_09ca: Expected I, but got Obj
		//IL_0d68: Expected Obj, but got I
		//IL_092e: Expected I, but got Obj
		//IL_026e: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I
		//IL_0bb4: Expected Obj, but got Ref
		//IL_02af: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+68]");
		((Quaternion*)(nint)parentRotation)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+70]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+70]");
		bool flag;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		float x;
		if (flag)
		{
			x = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+70]");
			x = 0f;
		}
		((Vector3*)(nint)parentPosition)->x = x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+8]");
		object obj2 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+8]");
		if ((nint)0 == 1 || (nint)obj2 == 1)
		{
			goto IL_020a;
		}
		ref Vector3 reference;
		object obj5;
		if ((nint)obj2 != 2)
		{
			if ((nint)obj2 == 3 || (nint)obj2 == 4)
			{
				goto IL_020a;
			}
			if ((nint)obj2 != 5)
			{
				if ((nint)obj2 != 6)
				{
					if ((nint)obj2 != 7 && (nint)obj2 != 8)
					{
						if ((nint)obj2 == 9)
						{
							reference = ref *(Vector3*)12;
							goto IL_03a1;
						}
						if ((nint)obj2 != 10)
						{
							if ((nint)obj2 == 11 || (nint)obj2 == 12)
							{
								goto IL_020a;
							}
							if ((nint)obj2 != 13 && (nint)obj2 != 14 && (nint)obj2 == 15)
							{
								reference = ref *(Vector3*)null;
								nint num = (nint)typeof(AnalyticsHelper);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v167 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
								object obj3 = (nint)0 & (nint)0x200;
								if (obj3 != null)
								{
									nint num2 = (nint)typeof(AnalyticsHelper);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v175 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (AnalyticsHelper.GetItemPayoutAmount((InAppItemModel)System.Runtime.CompilerServices.Unsafe.AsPointer(ref childRotation)) != 0)
								{
									reference = ref *(Vector3*)13;
								}
								goto IL_03a1;
							}
						}
					}
					reference = ref *(Vector3*)null;
					nint num3 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v151 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v158 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] args = default;
					Log.Analytics.LogErrorFormat("Undefined item source from origin {0}", args);
				}
				else
				{
					reference = ref *(Vector3*)11;
				}
				goto IL_03a1;
			}
		}
		reference = ref *(Vector3*)8;
		goto IL_03a1;
		IL_081e:
		((Vector3*)(nint)startParentPosition)->x = 3f;
		nint num5 = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v103 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v109 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+20]");
		string itemTitleId = ItemInfo.GetItemTitleId(InAppItemModel.ItemType.Undefined);
		((Quaternion*)(nint)startParentRotation)->x = (float)itemTitleId;
		Quaternion quaternion = startParentRotation;
		goto IL_0c34;
		IL_03a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+C]");
		object obj7 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+C]");
		if ((nint)0 == 1)
		{
			goto IL_053d;
		}
		if ((nint)obj7 != 1)
		{
			if ((nint)obj7 != 2)
			{
				if ((nint)obj7 == 3)
				{
					((Vector3*)(nint)startParentPosition)->x = 19f;
					object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref childRotation, 36));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				if ((nint)obj7 == 4)
				{
					goto IL_0a09;
				}
				if ((nint)obj7 != 5)
				{
					if ((nint)obj7 == 6)
					{
						goto IL_081e;
					}
					if ((nint)obj7 != 7)
					{
						if ((nint)obj7 != 8 && (nint)obj7 != 9 && (nint)obj7 != 10)
						{
							if ((nint)obj7 == 11)
							{
								goto IL_081e;
							}
							if ((nint)obj7 == 12)
							{
								goto IL_053d;
							}
						}
						goto IL_0a09;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+1C]");
					if ((nint)0 != 0)
					{
						nint num7 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v131 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num8 = (nint)typeof(Log);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v138 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+1C]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						object[] args2 = default;
						Log.Analytics.LogErrorFormat("The characterOutfitIndex '{0}' != 0 (a character outfit has been rewarded), this should not happen!", args2);
					}
					((Vector3*)(nint)startParentPosition)->x = 1f;
					nint num9 = (nint)typeof(ItemInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v120 (Il2CppClass<Info.ItemInfo>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num10 = (nint)typeof(ItemInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S0_v126 (Il2CppClass<Info.ItemInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+18]");
					string itemTitleId2 = ItemInfo.GetItemTitleId(Boards.BoardId.normal, HoverboardThemes.ThemeIdentifier.none);
					((Quaternion*)(nint)startParentRotation)->x = (float)itemTitleId2;
					quaternion = startParentRotation;
				}
				else
				{
					((Vector3*)(nint)startParentPosition)->x = 6f;
					nint num11 = (nint)typeof(ItemInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v89 (Il2CppClass<Info.ItemInfo>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num12 = (nint)typeof(ItemInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v95 (Il2CppClass<Info.ItemInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string itemTitleId3 = ItemInfo.GetItemTitleId((InAppItemModel.BundleItem)6);
					((Quaternion*)(nint)startParentRotation)->x = (float)itemTitleId3;
					quaternion = startParentRotation;
				}
			}
			else
			{
				((Vector3*)(nint)startParentPosition)->x = 18f;
				nint num13 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v33 (Il2CppClass<Info.ItemInfo>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num14 = (nint)typeof(ItemInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v41 (Il2CppClass<Info.ItemInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+18]");
				string itemTitleId4 = ItemInfo.GetItemTitleId(Boards.BoardId.normal, HoverboardThemes.ThemeIdentifier.none);
				string text = $"token_{(object[])(object)itemTitleId4}";
				((Quaternion*)(nint)startParentRotation)->x = (float)text;
				quaternion = startParentRotation;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+28]");
			string localizedPrice = ((InAppItemModel)0).localizedPrice;
			((Vector3*)(nint)startParentPosition)->x = (float)localizedPrice;
			nint num15 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v48 (Il2CppClass<Info.ItemInfo>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num16 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v54 (Il2CppClass<Info.ItemInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string itemTitleId5 = ItemInfo.GetItemTitleId((InAppItemModel.BundleItem)(object)localizedPrice);
			((Quaternion*)(nint)startParentRotation)->x = (float)itemTitleId5;
			quaternion = startParentRotation;
		}
		goto IL_0c34;
		IL_020a:
		reference = ref *(Vector3*)5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+30]");
		((Quaternion*)(nint)parentRotation)->x = 0f;
		((Vector3*)(nint)parentPosition)->x = 0f;
		goto IL_03a1;
		IL_0c34:
		string text2 = ((string)startParentRotation.x).ToUpper();
		((Quaternion*)(nint)quaternion)->x = (float)text2;
		nint num17 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v23 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num18 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v30 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float x2 = startParentPosition.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+18]");
		string androidDeviceOsString = AnalyticsHelper.GetAndroidDeviceOsString((string)x2, (string)0);
		((Quaternion*)(nint)startChildRotation)->x = (float)androidDeviceOsString;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+14]");
		((Vector3*)(nint)startChildPosition)->x = 0f;
		return;
		IL_0a09:
		((Vector3*)(nint)startParentPosition)->x = 0f;
		((Quaternion*)(nint)startParentRotation)->x = (float)string.Empty;
		nint num19 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v73 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num20 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v81 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [childRotation @ L0 (UnityEngine.Quaternion&)+C]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args3 = default;
		Log.Analytics.LogErrorFormat("Undefined item type & item source for reward type {0}", args3);
		quaternion = startParentRotation;
		goto IL_0c34;
		IL_053d:
		((Vector3*)(nint)startParentPosition)->x = 5f;
		nint num21 = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v36 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num22 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v42 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string itemTitleId6 = ItemInfo.GetItemTitleId((InAppItemModel.BundleItem)5);
		((Quaternion*)(nint)startParentRotation)->x = (float)itemTitleId6;
		quaternion = startParentRotation;
		goto IL_0c34;
	}

	public unsafe static void PreciseAlign(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 alignWithPosition, Vector3 triangleForward, Vector3 triangleNormal, Vector3 trianglePosition)
	{
		//IL_0013: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got Ref
		//IL_0031: Expected Obj, but got VT
		//IL_003f: Expected Obj, but got Ref
		//IL_0047: Expected Obj, but got VT
		//IL_0055: Expected Obj, but got Ref
		//IL_005d: Expected Obj, but got VT
		//IL_0074: Expected Obj, but got VT
		//IL_0082: Expected Obj, but got Ref
		//IL_0098: Expected Obj, but got Ref
		//IL_00a0: Expected Obj, but got VT
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref gameObjectInOut, 8));
		obj = alignWithVector;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref gameObjectInOut, 12));
		obj2 = alignWithNormal;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref gameObjectInOut, 20));
		obj3 = alignWithPosition;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref gameObjectInOut, 16));
		obj4 = triangleForward;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HMACSHA256 hMACSHA = default;
		hMACSHA._002Ector((byte[])triangleNormal);
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref gameObjectInOut, 24));
		obj5 = hMACSHA;
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref gameObjectInOut, 28));
		obj6 = trianglePosition;
	}

	public unsafe static void VectorsToTransform(ref GameObject gameObjectInOut, Vector3 positionVector, Vector3 directionVector, Vector3 normalVector)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got F4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got F4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got F4
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01c0: Expected F4, but got Obj
		//IL_01bb: Expected native int or pointer, but got VT
		//IL_01d5: Expected F4, but got I
		//IL_01d0: Expected native int or pointer, but got VT
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected VT, but got Unknown
		//IL_01f0: Expected F4, but got Obj
		//IL_01eb: Expected native int or pointer, but got VT
		//IL_0205: Expected F4, but got I
		//IL_0200: Expected native int or pointer, but got VT
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected VT, but got Unknown
		//IL_0220: Expected F4, but got Obj
		//IL_021b: Expected native int or pointer, but got VT
		//IL_0235: Expected F4, but got I
		//IL_0230: Expected native int or pointer, but got VT
		//IL_0267: Expected native int or pointer, but got VT
		//IL_0279: Expected native int or pointer, but got VT
		//IL_028f: Expected Obj, but got VT
		//IL_028f: Expected Obj, but got VT
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got F4
		//IL_02c1: Expected Obj, but got F4
		//IL_02d9: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_015c: Expected F4, but got Obj
		//IL_0157: Expected native int or pointer, but got VT
		//IL_0171: Expected F4, but got I
		//IL_016c: Expected native int or pointer, but got VT
		//IL_017e: Expected F4, but got Obj
		//IL_0179: Expected native int or pointer, but got VT
		//IL_0193: Expected F4, but got I
		//IL_018e: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = positionVector.x;
		_ = positionVector.z;
		object obj3 = obj2 + 36;
		obj3 = directionVector.x;
		_ = directionVector.z;
		object obj4 = obj2 + 24;
		obj4 = normalVector.x;
		_ = normalVector.z;
		nint num = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v57 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 72);
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector4)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		float num3 = SignedDotProduct(vector, vector3, vector4);
		float speed = num3 * -1f;
		((Vector3*)(nint)vector4)->x = positionVector.x;
		((Vector3*)(nint)vector4)->z = positionVector.z;
		((SafeAnimation)vector).SetSpeed((string)vector4, speed);
		object obj6 = obj2 + 12;
		obj6 = normalVector.x;
		_ = normalVector.z;
		obj2 = vector.x;
		_ = vector.z;
		nint num4 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v53 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector3)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v38+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector4)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = vector3 - vector4;
	}

	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		//IL_0100: Expected I4, but got VT
		//IL_0034: Expected Obj, but got VT
		//IL_0087: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got VT
		//IL_0099: Expected Obj, but got VT
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected VT, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		Vector3 vector = default;
		Vector3 vector2 = default;
		if (point > vector)
		{
			object obj = point - vector;
			object obj4;
			if (point != vector)
			{
				object obj2 = -1 / obj;
				object obj3 = obj2 * obj;
				obj4 = -1 - obj3;
			}
			else
			{
				obj4 = 0;
			}
			object obj5 = -1 - obj4;
			bool flag;
			do
			{
				flag = ((SyboRandom)linePoint1).Bool();
			}
			while ((flag ? 1 : 0) > (nint)obj5);
			object obj6 = point - vector;
			object obj7;
			if (obj6 == null)
			{
				obj7 = 0;
			}
			else
			{
				object obj8 = flag / obj6;
				object obj9 = obj8 * obj6;
				obj7 = flag - obj9;
			}
			vector2 = vector + obj7;
		}
		return (int)vector2;
	}

	public static float MouseDistanceToLine(Vector3 linePoint1, Vector3 linePoint2)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got F4
		//IL_0110: Expected Obj, but got F4
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = linePoint1.x;
		_ = linePoint1.z;
		obj2 = linePoint2.x;
		_ = linePoint2.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj5 = obj2 + 36;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = obj4 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22+4]");
		object obj7 = num3 * 0;
		object obj8 = obj6 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22+8]");
		object obj9 = num4 * 0;
		float num5 = (float)obj8 + (float)obj9;
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v44 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num8;
		if (num5 < -1f)
		{
			num8 = -1f;
			num5 = -1f;
		}
		else
		{
			num8 = num5;
		}
		if (num5 > 1f)
		{
			float num9 = 1f;
		}
		else
		{
			float num9 = num8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122EB");
		float result = default;
		return result;
	}

	public static float MouseDistanceToCircle(Vector3 point, float radius)
	{
		if (radius < 0.363636f)
		{
			float num = 7.5685f * radius;
			return num * radius;
		}
		if (radius < 0.727272f)
		{
			float num2 = radius - 0.545454f;
			float num3 = 7.5625f * num2;
			float num4 = num3 * num2;
			return num4 + 0.75f;
		}
		if (radius < 0.90909f)
		{
			float num5 = radius - 0.818181f;
			float num6 = 7.5625f * num5;
			float num7 = num6 * num5;
			return num7 + 0.9375f;
		}
		float num8 = radius - 0.9545454f;
		float num9 = 7.5625f * num8;
		float num10 = num9 * num8;
		return num10 + 63f / 64f;
	}

	public unsafe static bool IsLineInRectangle(Vector3 linePoint1, Vector3 linePoint2, Vector3 rectA, Vector3 rectB, Vector3 rectC, Vector3 rectD)
	{
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I4
		//IL_0266: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_058f: Expected F4, but got Obj
		//IL_058a: Expected native int or pointer, but got VT
		//IL_05a4: Expected F4, but got I
		//IL_059f: Expected native int or pointer, but got VT
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_05c8: Expected F4, but got Obj
		//IL_05c3: Expected native int or pointer, but got VT
		//IL_05dd: Expected F4, but got I
		//IL_05d8: Expected native int or pointer, but got VT
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got F4
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected VT, but got Unknown
		//IL_061d: Expected F4, but got Obj
		//IL_0618: Expected native int or pointer, but got VT
		//IL_0632: Expected F4, but got I
		//IL_062d: Expected native int or pointer, but got VT
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected VT, but got Unknown
		//IL_064d: Expected native int or pointer, but got VT
		//IL_065f: Expected native int or pointer, but got VT
		//IL_06da: Expected native int or pointer, but got VT
		//IL_06ec: Expected native int or pointer, but got VT
		//IL_06fe: Expected native int or pointer, but got VT
		//IL_0710: Expected native int or pointer, but got VT
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected Obj, but got Unknown
		//IL_0799: Expected Obj, but got F4
		//IL_07b0: Expected F4, but got Obj
		//IL_07ab: Expected native int or pointer, but got VT
		//IL_07c5: Expected F4, but got I
		//IL_07c0: Expected native int or pointer, but got VT
		//IL_07d2: Expected native int or pointer, but got VT
		//IL_07e4: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got F4
		//IL_0076: Expected Obj, but got F4
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_02a6: Expected F4, but got Obj
		//IL_02a1: Expected native int or pointer, but got VT
		//IL_02bb: Expected F4, but got I
		//IL_02b6: Expected native int or pointer, but got VT
		//IL_02c8: Expected F4, but got Obj
		//IL_02c3: Expected native int or pointer, but got VT
		//IL_02dd: Expected F4, but got I
		//IL_02d8: Expected native int or pointer, but got VT
		//IL_0310: Expected native int or pointer, but got VT
		//IL_0322: Expected native int or pointer, but got VT
		//IL_0334: Expected F4, but got Obj
		//IL_032f: Expected native int or pointer, but got VT
		//IL_0349: Expected F4, but got I
		//IL_0344: Expected native int or pointer, but got VT
		//IL_03bf: Expected native int or pointer, but got VT
		//IL_03d1: Expected native int or pointer, but got VT
		//IL_03e3: Expected F4, but got Obj
		//IL_03de: Expected native int or pointer, but got VT
		//IL_03f8: Expected F4, but got I
		//IL_03f3: Expected native int or pointer, but got VT
		//IL_04aa: Expected native int or pointer, but got VT
		//IL_04bc: Expected native int or pointer, but got VT
		//IL_04df: Expected native int or pointer, but got VT
		//IL_04f1: Expected native int or pointer, but got VT
		//IL_0503: Expected F4, but got Obj
		//IL_04fe: Expected native int or pointer, but got VT
		//IL_0518: Expected F4, but got I
		//IL_0513: Expected native int or pointer, but got VT
		//IL_011b: Expected F4, but got Obj
		//IL_0116: Expected native int or pointer, but got VT
		//IL_0130: Expected F4, but got I
		//IL_012b: Expected native int or pointer, but got VT
		//IL_013d: Expected native int or pointer, but got VT
		//IL_014f: Expected native int or pointer, but got VT
		//IL_01ae: Expected native int or pointer, but got VT
		//IL_01c0: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got Obj
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01e7: Expected F4, but got I
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_00cf: Expected I, but got Obj
		//IL_020a: Expected F4, but got Obj
		//IL_0205: Expected native int or pointer, but got VT
		//IL_021f: Expected F4, but got I
		//IL_021a: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 84;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v126 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 36;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 12;
		object obj8 = obj2 + 72;
		Vector3 one = Vector3.one;
		((Vector3*)(nint)linePoint1)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
		((Vector3*)(nint)linePoint1)->z = 0f;
		object obj9 = obj2 + 60;
		Vector3 one2 = Vector3.one;
		((Vector3*)(nint)linePoint2)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29+8]");
		((Vector3*)(nint)linePoint2)->z = 0f;
		object obj10 = obj2 + 108;
		obj10 = rectB.x;
		_ = rectB.z;
		Vector3 vector = (Vector3)(obj2 + 120);
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 132);
		((Vector3*)(nint)vector3)->x = rectB.x;
		((Vector3*)(nint)vector3)->z = rectB.z;
		float num3 = vector.x * vector3.x;
		float num4 = vector.y * vector3.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector3.z;
		float num7 = num5 + num6;
		((Vector3*)(nint)vector)->x = rectB.x;
		((Vector3*)(nint)vector)->z = rectB.z;
		((Vector3*)(nint)vector3)->x = rectD.x;
		((Vector3*)(nint)vector3)->z = rectD.z;
		float num8 = vector.x * vector3.x;
		float num9 = vector.y * vector3.y;
		float num10 = num8 + num9;
		float num11 = vector.z * vector3.z;
		float num12 = num10 + num11;
		object obj11 = obj2 + 96;
		obj11 = rectD.x;
		_ = rectD.z;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v56+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector3)->x = rectD.x;
		((Vector3*)(nint)vector3)->z = rectD.z;
		float num13 = vector.x * vector3.x;
		float num14 = vector.y * vector3.y;
		float num15 = num13 + num14;
		float num16 = vector.z * vector3.z;
		float num17 = num15 + num16;
		float num18 = num7 * num17;
		float num19 = num12 * num12;
		float num20 = num18 - num19;
		if (num20 != 0f)
		{
			obj8 = rectA.x;
			_ = rectA.z;
			obj9 = rectC.x;
			_ = rectC.z;
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v73 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num22 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v122 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			((Vector3*)(nint)vector3)->x = (float)obj9;
			Vector3 vector6 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector, vector3);
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = rectB.x;
			((Vector3*)(nint)vector)->z = rectB.z;
			((Vector3*)(nint)vector3)->x = (float)obj4;
			Vector3 vector7 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			float num23 = vector.x * vector3.x;
			float num24 = vector.y * vector3.y;
			float num25 = num23 + num24;
			float num26 = vector.z * vector3.z;
			float num27 = num25 + num26;
			((Vector3*)(nint)vector)->x = rectD.x;
			((Vector3*)(nint)vector)->z = rectD.z;
			((Vector3*)(nint)vector3)->x = (float)obj;
			Vector3 vector8 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			float num28 = vector.x * vector3.x;
			float num29 = vector.y * vector3.y;
			float num30 = num28 + num29;
			float num31 = vector.z * vector3.z;
			float num32 = num30 + num31;
			float num33 = num12 * num32;
			float num34 = num27 * num17;
			float num35 = num33 - num34;
			float num36 = num35 / num20;
			((Vector3*)(nint)vector3)->x = rectB.x;
			((Vector3*)(nint)vector3)->z = rectB.z;
			Vector3 vector9 = vector3 / num36;
			((Vector3*)(nint)vector)->x = rectA.x;
			((Vector3*)(nint)vector)->z = rectA.z;
			((Vector3*)(nint)vector3)->x = (float)obj5;
			Vector3 vector10 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			Vector3 vector11 = vector - vector3;
			((Vector3*)(nint)linePoint1)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21+8]");
			((Vector3*)(nint)linePoint1)->z = 0f;
			((Vector3*)(nint)vector3)->x = rectD.x;
			((Vector3*)(nint)vector3)->z = rectD.z;
			float num37 = num7 * num32;
			float num38 = num27 * num12;
			float num39 = num37 - num38;
			float num40 = num39 / num20;
			Vector3 vector12 = vector3 / num40;
			((Vector3*)(nint)vector)->x = rectC.x;
			((Vector3*)(nint)vector)->z = rectC.z;
			((Vector3*)(nint)vector3)->x = (float)obj7;
			Vector3 vector13 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			((Vector3*)(nint)vector13)->z = 0f;
			Vector3 vector14 = vector - vector3;
			((Vector3*)(nint)linePoint2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)linePoint2)->z = 0f;
			return true;
		}
		return false;
	}

	public unsafe static bool IsPointInRectangle(Vector3 point, Vector3 rectA, Vector3 rectC, Vector3 rectB, Vector3 rectD)
	{
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0398: Expected Obj, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Expected Obj, but got I4
		//IL_03c9: Expected I, but got Obj
		//IL_03df: Expected Obj, but got I
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_065e: Expected F4, but got Obj
		//IL_0659: Expected native int or pointer, but got VT
		//IL_0673: Expected F4, but got I
		//IL_066e: Expected native int or pointer, but got VT
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected VT, but got Unknown
		//IL_068e: Expected native int or pointer, but got VT
		//IL_06a0: Expected native int or pointer, but got VT
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected VT, but got Unknown
		//IL_06c0: Expected native int or pointer, but got VT
		//IL_06d2: Expected native int or pointer, but got VT
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_0703: Expected native int or pointer, but got VT
		//IL_0715: Expected native int or pointer, but got VT
		//IL_0727: Expected native int or pointer, but got VT
		//IL_0739: Expected native int or pointer, but got VT
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0097: Expected F4, but got Obj
		//IL_0092: Expected native int or pointer, but got VT
		//IL_00ac: Expected F4, but got I
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00cb: Expected native int or pointer, but got VT
		//IL_0103: Expected F4, but got Obj
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_0118: Expected F4, but got I
		//IL_0113: Expected native int or pointer, but got VT
		//IL_0125: Expected F4, but got Obj
		//IL_0120: Expected native int or pointer, but got VT
		//IL_013a: Expected F4, but got I
		//IL_0135: Expected native int or pointer, but got VT
		//IL_01d4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0237: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I
		//IL_040e: Expected F4, but got Obj
		//IL_0409: Expected native int or pointer, but got VT
		//IL_0423: Expected F4, but got I
		//IL_041e: Expected native int or pointer, but got VT
		//IL_0430: Expected F4, but got Obj
		//IL_042b: Expected native int or pointer, but got VT
		//IL_0445: Expected F4, but got I
		//IL_0440: Expected native int or pointer, but got VT
		//IL_04d8: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got F4
		//IL_02e9: Expected Obj, but got F4
		//IL_0301: Expected I, but got Obj
		//IL_0317: Expected Obj, but got I
		//IL_0278: Expected I, but got Obj
		//IL_058f: Expected F4, but got Obj
		//IL_058a: Expected native int or pointer, but got VT
		//IL_05a4: Expected F4, but got I
		//IL_059f: Expected native int or pointer, but got VT
		//IL_05c2: Expected F4, but got Obj
		//IL_05bd: Expected native int or pointer, but got VT
		//IL_05d7: Expected F4, but got I
		//IL_05d2: Expected native int or pointer, but got VT
		//IL_05e4: Expected F4, but got Obj
		//IL_05df: Expected native int or pointer, but got VT
		//IL_05f9: Expected F4, but got I
		//IL_05f4: Expected native int or pointer, but got VT
		//IL_0617: Expected F4, but got Obj
		//IL_0612: Expected native int or pointer, but got VT
		//IL_062c: Expected F4, but got I
		//IL_0627: Expected native int or pointer, but got VT
		//IL_0342: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 60;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v113 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 48;
		Vector3 one = Vector3.one;
		((Vector3*)(nint)point)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
		((Vector3*)(nint)point)->z = 0f;
		Vector3 vector = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector)->x = rectB.x;
		((Vector3*)(nint)vector)->z = rectB.z;
		Vector3 vector2 = (Vector3)(obj2 + 96);
		((Vector3*)(nint)vector2)->x = rectA.x;
		((Vector3*)(nint)vector2)->z = rectA.z;
		object obj6 = obj2 + 36;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		((Vector3*)(nint)vector)->x = rectC.x;
		((Vector3*)(nint)vector)->z = rectC.z;
		((Vector3*)(nint)vector2)->x = rectD.x;
		((Vector3*)(nint)vector2)->z = rectD.z;
		object obj7 = obj2 + 24;
		Vector3 vector3 = Vector3.Min(vector, vector2);
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v36+8]");
		_ = 0;
		object obj8 = obj2 + 12;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector2)->x = rectD.x;
		((Vector3*)(nint)vector2)->z = rectD.z;
		Vector3 vector5 = Vector3.Min(vector, vector2);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v40+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Vector3 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		float num3 = vector.x * vector2.x;
		float num4 = vector.y * vector2.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector2.z;
		float num7 = num5 + num6;
		bool flag = !(num7 < 1E-05f);
		bool flag2 = !(num7 > -1E-05f);
		object obj9 = flag | flag2;
		if (obj9 != null)
		{
			return false;
		}
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v66 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v108 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector9 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		float num10 = vector.x * vector2.x;
		float num11 = vector.y * vector2.y;
		float num12 = num10 + num11;
		float num13 = vector.z * vector2.z;
		float num14 = num12 + num13;
		object obj11 = obj * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj12 = num15 * 0;
		object obj13 = obj11 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		object obj14 = num16 * 0;
		object obj15 = obj13 + obj14;
		float num17 = num14 / (float)obj15;
		bool flag3 = !(num17 < 0f);
		bool flag4 = !flag3;
		bool flag5 = !(num17 > 1f);
		bool flag6 = !flag5;
		object obj16 = flag4 | flag6;
		if (obj16 != null)
		{
			return false;
		}
		obj5 = rectA.x;
		_ = rectA.z;
		obj6 = rectC.x;
		_ = rectC.z;
		nint num18 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num19 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v103 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector10 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Vector3 vector11 = vector2 / num17;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector13 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v36+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		Vector3 vector14 = vector - vector2;
		((Vector3*)(nint)point)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v40+8]");
		((Vector3*)(nint)point)->z = 0f;
		return true;
	}

	public unsafe static bool AreLineSegmentsCrossing(Vector3 pointA1, Vector3 pointA2, Vector3 pointB1, Vector3 pointB2)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0083: Expected native int or pointer, but got VT
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0126: Expected native int or pointer, but got VT
		//IL_014f: Expected native int or pointer, but got VT
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got F4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got F4
		//IL_0197: Expected Obj, but got F4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected I4, but got Unknown
		//IL_01c8: Expected I4, but got Obj
		//IL_0212: Invalid comparison between F4 and I
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		obj = height;
		object obj3 = obj2 + 48;
		obj3 = obj;
		string text = (string)(obj2 + 72);
		text = (string)obj3;
		float x = pointB1.x * (float)text;
		((Vector3*)(nint)pointB1)->x = x;
		float num = pointB1.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (System.String)+4]");
		float y = num * 0f;
		((Vector3*)(nint)pointB1)->y = y;
		int height2 = Screen.height;
		int sleepTimeout2 = Screen.sleepTimeout;
		object obj4 = obj2 + 32;
		obj4 = 0;
		obj4 = height2;
		object obj5 = obj2 + 24;
		obj5 = obj4;
		text = (string)obj5;
		float x2 = pointB2.x * (float)text;
		((Vector3*)(nint)pointB2)->x = x2;
		float num2 = pointB2.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (System.String)+4]");
		float y2 = num2 * 0f;
		((Vector3*)(nint)pointB2)->y = y2;
		object obj6 = obj2 + 16;
		obj6 = pointA2.x;
		object obj7 = obj2 + 8;
		obj7 = pointB1.x;
		obj2 = pointB2.x;
		string text2 = (string)(obj2 + 56);
		text2 = (string)obj6;
		InAppItemModel.ItemType itemType = (InAppItemModel.ItemType)(obj2 - -64);
		((InAppItemModel.ItemType*)(int)itemType)->value__ = (int)obj7;
		text = (string)obj2;
		float localCurrencyPriceAsFloat = AnalyticsHelper.GetLocalCurrencyPriceAsFloat(text2, itemType, text);
		float value = UnityEngine.Random.value;
		float num3 = localCurrencyPriceAsFloat / value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pointA1 @ L0 (UnityEngine.Vector3)+10]");
		return num3 < 0f;
	}

	public unsafe static bool LinearAcceleration(out Vector3 vector, Vector3 position, int samples)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got F4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got VT
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected VT, but got Unknown
		//IL_01a7: Expected F4, but got Obj
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01bc: Expected F4, but got I
		//IL_01b7: Expected native int or pointer, but got VT
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected VT, but got Unknown
		//IL_01d7: Expected F4, but got Obj
		//IL_01d2: Expected native int or pointer, but got VT
		//IL_01ec: Expected F4, but got I
		//IL_01e7: Expected native int or pointer, but got VT
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0232: Expected F4, but got I4
		//IL_022d: Expected native int or pointer, but got VT
		//IL_0247: Expected F4, but got I
		//IL_0242: Expected native int or pointer, but got VT
		//IL_0259: Expected F4, but got VT
		//IL_0254: Expected native int or pointer, but got VT
		//IL_026e: Expected F4, but got I
		//IL_0269: Expected native int or pointer, but got VT
		//IL_02a1: Expected F4, but got Obj
		//IL_029c: Expected native int or pointer, but got VT
		//IL_02b6: Expected F4, but got I
		//IL_02b1: Expected native int or pointer, but got VT
		//IL_02c3: Expected F4, but got Obj
		//IL_02be: Expected native int or pointer, but got VT
		//IL_02d8: Expected F4, but got I
		//IL_02d3: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 36;
		obj4 = position.x;
		_ = position.z;
		object obj5 = obj2 + 24;
		obj5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3&)+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = (Vector3)(obj2 + 72);
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector4)->x = (float)obj5;
		Vector3 vector5 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj7 = obj2 + 12;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector4);
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = ((int*)samples)->m_value;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [samples @ L2 (System.Int32)+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector4)->x = (float)vector;
		Vector3 vector7 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vector @ L0 (UnityEngine.Vector3&)+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector4);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Vector3 vector8 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((Vector3*)(nint)vector4)->x = (float)obj;
		Vector3 vector9 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		float num3 = vector2.x * vector4.x;
		float num4 = vector2.y * vector4.y;
		float num5 = num3 + num4;
		float num6 = vector2.z * vector4.z;
		float num7 = num5 + num6;
		if (num7 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
			object obj8 = default;
			object obj9 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				return false;
			}
			return true;
		}
		return true;
	}

	public static float LinearFunction2DBasic(float x, float Qx, float Qy)
	{
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		float num = Qx - x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B70F");
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = default;
		float num4 = System.Math.Abs(num5);
		bool flag = num4 > Qy;
		bool flag2 = !flag;
		float num6 = num5;
		if (!flag2)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num9 = ((num5 < 0f) ? (-1f) : 1f);
			float num10 = Qy * num9;
			num6 = num10;
		}
		return x + num6;
	}

	public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Py - x;
		float num4 = Px - x;
		float num5 = num3 / num4;
		if (num5 < 0f)
		{
			num5 = 0f;
		}
		else if (num5 > 1f)
		{
			num5 = 1f;
		}
		return Mathf.LerpUnclamped(Qx, Qy, num5);
	}

	public Math3D()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Collider> list = default;
		list._002Ector();
		object obj = this + 28;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Collider> list2 = default;
		list2._002Ector();
		object obj2 = this + 32;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	static Math3D()
	{
		//IL_01c0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_01f3: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_013d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"Math3d_TempChild";
		int layer = gameObject.layer;
		nint num = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v50 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		tempChild = (Transform)layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject2 = default;
		gameObject2.layer = (int)"Math3d_TempParent";
		int layer2 = gameObject2.layer;
		nint num3 = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23 (Il2CppClass<SYBO.Common.Math3D>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = layer2;
		string tag = tempChild.tag;
		UnityEngine.Object.CheckNullArgument((object)tag, (string)61);
		string tag2 = tempChild.tag;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)tag2).Exec();
		string tag3 = tempParent.tag;
		UnityEngine.Object.CheckNullArgument((object)tag3, (string)61);
		string tag4 = tempParent.tag;
		((UnityEngine.UnitySynchronizationContext)(object)tag4).Exec();
		tempChild.parentInternal = tempParent;
	}
}
