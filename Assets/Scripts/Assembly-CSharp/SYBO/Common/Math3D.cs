using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
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

	public static void Init()
	{
		GameObject gameObject = default;
		gameObject._002Ector("Math3d_TempChild");
		Transform transform = gameObject.transform;
		tempChild = transform;
		GameObject gameObject2 = default;
		gameObject2._002Ector("Math3d_TempParent");
		Transform transform2 = gameObject2.transform;
		tempParent = transform2;
		GameObject gameObject3 = tempChild.gameObject;
		gameObject3.hideFlags = HideFlags.HideAndDontSave;
		GameObject gameObject4 = tempChild.gameObject;
		UnityEngine.Object.DontDestroyOnLoad(gameObject4);
		GameObject gameObject5 = tempParent.gameObject;
		gameObject5.hideFlags = HideFlags.HideAndDontSave;
		GameObject gameObject6 = tempParent.gameObject;
		UnityEngine.Object.DontDestroyOnLoad(gameObject6);
		tempChild.parent = tempParent;
	}

	public unsafe static Vector3 AddVectorLength(Vector3 vector, float size)
	{
		//IL_00c6: Expected native int or pointer, but got VT
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_00f4: Expected native int or pointer, but got VT
		float num = vector.x * vector.x;
		float num2 = vector.y * vector.y;
		float num3 = num + num2;
		float num4 = vector.z * vector.z;
		float num5 = num3 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num6 = num5 + size;
		float num7 = num6 / num5;
		float x = vector.x * num7;
		float z = vector.z * num7;
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = z;
		float y = vector.y * num7;
		((Vector3*)(nint)vector2)->y = y;
		((Vector3*)(nint)vector2)->x = x;
		return vector2;
	}

	public unsafe static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		//IL_015d: Expected I, but got Obj
		//IL_017d: Expected F4, but got I
		//IL_0186: Expected F4, but got VT
		//IL_0196: Expected F4, but got I
		//IL_010d: Expected native int or pointer, but got VT
		//IL_0129: Expected native int or pointer, but got VT
		//IL_0145: Expected native int or pointer, but got VT
		float num = vector.x * vector.x;
		float num2 = vector.y * vector.y;
		float num3 = num + num2;
		float num4 = vector.z * vector.z;
		float num5 = num3 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num8;
		float num9;
		float num10;
		if (num5 > 1E-05f)
		{
			float num6 = vector.z / num5;
			float num7 = vector.x / num5;
			num8 = vector.y / num5;
			num9 = num7;
			num10 = num6;
		}
		else
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			num8 = 0f;
			num9 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			num10 = 0f;
		}
		float z = num10 * size;
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = z;
		float y = num8 * size;
		((Vector3*)(nint)vector2)->y = y;
		float x = num9 * size;
		((Vector3*)(nint)vector2)->x = x;
		return vector2;
	}

	public unsafe static Quaternion SubtractRotation(Quaternion B, Quaternion A)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		//IL_0181: Expected native int or pointer, but got VT
		//IL_022b: Expected native int or pointer, but got VT
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02e2: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		((Quaternion*)(nint)quaternion)->z = A.z;
		((Quaternion*)(nint)quaternion)->x = A.x;
		Quaternion quaternion2 = Quaternion.Inverse(quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+1C]");
		float num = 0f * B.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
		float num2 = 0f * B.w;
		float num3 = num + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+14]");
		float num4 = 0f * B.z;
		float num5 = num3 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
		float num6 = 0f * B.y;
		float x = num5 - num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+1C]");
		float num7 = 0f * B.w;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
		float num8 = 0f * B.x;
		float num9 = num7 - num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+14]");
		float num10 = 0f * B.y;
		float num11 = num9 - num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
		float num12 = 0f * B.z;
		float w = num11 - num12;
		Quaternion quaternion3 = default;
		((Quaternion*)(nint)quaternion3)->w = w;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+1C]");
		float num13 = 0f * B.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
		float num14 = 0f * B.w;
		float num15 = num13 + num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
		float num16 = 0f * B.y;
		float num17 = num15 + num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+14]");
		float num18 = 0f * B.x;
		float z = num17 - num18;
		((Quaternion*)(nint)quaternion3)->z = z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+1C]");
		float num19 = 0f * B.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+14]");
		float num20 = 0f * B.w;
		float num21 = num19 + num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
		float num22 = 0f * B.x;
		float num23 = num21 + num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
		float num24 = 0f * B.z;
		float y = num23 - num24;
		((Quaternion*)(nint)quaternion3)->y = y;
		((Quaternion*)(nint)quaternion3)->x = x;
		return quaternion3;
	}

	public unsafe static bool PlanePlaneIntersection(out Vector3 linePoint, out Vector3 lineVec, Vector3 plane1Normal, Vector3 plane1Position, Vector3 plane2Normal, Vector3 plane2Position)
	{
		//IL_0147: Expected I, but got Obj
		//IL_016d: Expected Ref, but got VT
		//IL_0185: Expected I, but got Obj
		//IL_01ab: Expected Ref, but got VT
		//IL_0280: Expected Ref, but got F4
		//IL_0134: Expected Ref, but got F4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)Vector3.zeroVector;
		float num5 = plane1Normal.y * plane2Normal.z;
		float num6 = plane1Normal.z * plane2Normal.y;
		float num7 = num5 - num6;
		float num8 = plane1Normal.z * plane2Normal.x;
		float num9 = plane1Normal.x * plane2Normal.z;
		float num10 = num8 - num9;
		float num11 = plane1Normal.x * plane2Normal.y;
		float num12 = plane1Normal.y * plane2Normal.x;
		float num13 = num11 - num12;
		reference2 = ref *(Vector3*)num7;
		float num14 = plane2Normal.y * num13;
		float num15 = plane2Normal.z * num10;
		float num16 = num14 - num15;
		float num17 = plane1Normal.x * num16;
		float num18 = plane2Normal.z * num7;
		float num19 = plane2Normal.x * num13;
		float num20 = num18 - num19;
		float num21 = plane1Normal.y * num20;
		float num22 = num17 + num21;
		float num23 = plane2Normal.x * num10;
		float num24 = plane2Normal.y * num7;
		float num25 = num23 - num24;
		float num26 = plane1Normal.z * num25;
		float num27 = num22 + num26;
		float num28 = System.Math.Abs(num27);
		bool flag = num28 > 0.006f;
		if (flag)
		{
			float num29 = plane1Position.x - plane2Position.x;
			float num30 = plane1Normal.x * num29;
			float num31 = plane1Position.y - plane2Position.y;
			float num32 = plane1Normal.y * num31;
			float num33 = num30 + num32;
			float num34 = plane1Position.z - plane2Position.z;
			float num35 = plane1Normal.z * num34;
			float num36 = num33 + num35;
			float num37 = num36 / num27;
			float num38 = num16 * num37;
			float num39 = num25 * num37;
			float num40 = plane2Position.z + num39;
			float num41 = num20 * num37;
			float num42 = plane2Position.y + num41;
			float num43 = plane2Position.x + num38;
			reference = ref *(Vector3*)num43;
		}
		return flag;
	}

	public unsafe static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planePoint, Vector3 planeNormal)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00f6: Expected Ref, but got VT
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		//IL_00bd: Expected Ref, but got F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)Vector3.zeroVector;
		float num3 = planePoint.x - linePoint.x;
		float num4 = num3 * planeNormal.x;
		float num5 = planePoint.y - linePoint.y;
		float num6 = num5 * planeNormal.y;
		float num7 = num4 + num6;
		float num8 = planePoint.z - linePoint.z;
		float num9 = num8 * planeNormal.z;
		float num10 = num7 + num9;
		float num11 = lineVec.x * planeNormal.x;
		float num12 = lineVec.y * planeNormal.y;
		float num13 = num11 + num12;
		float num14 = lineVec.z * planeNormal.z;
		float num15 = num13 + num14;
		if (num15 != 0f)
		{
			((Vector3*)(nint)vector)->z = lineVec.z;
			((Vector3*)(nint)vector)->x = lineVec.x;
			float size = num10 / num15;
			Vector3 vector2 = SetVectorLength(vector, size);
			float num16 = linePoint.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			float num17 = num16 + 0f;
			float num18 = linePoint.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			float num19 = num18 + 0f;
			float num20 = linePoint.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			float num21 = num20 + 0f;
			reference = ref *(Vector3*)num17;
		}
		return num15 != 0f;
	}

	public unsafe static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		//IL_01e1: Expected I, but got Obj
		//IL_0207: Expected Ref, but got VT
		//IL_01c5: Expected Ref, but got F4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)Vector3.zeroVector;
		float num3 = lineVec1.y * lineVec2.z;
		float num4 = lineVec1.z * lineVec2.y;
		float num5 = num3 - num4;
		float num6 = lineVec1.z * lineVec2.x;
		float num7 = lineVec1.x * lineVec2.z;
		float num8 = num6 - num7;
		float num9 = linePoint2.y - linePoint1.y;
		float num10 = num9 * lineVec2.z;
		float num11 = linePoint2.z - linePoint1.z;
		float num12 = num11 * lineVec2.y;
		float num13 = num10 - num12;
		float num14 = num11 * lineVec2.x;
		float num15 = linePoint2.x - linePoint1.x;
		float num16 = num15 * lineVec2.z;
		float num17 = num14 - num16;
		float num18 = num15 * lineVec2.y;
		float num19 = num9 * lineVec2.x;
		float num20 = num18 - num19;
		float num21 = num15 * num5;
		float num22 = num9 * num8;
		float num23 = num21 + num22;
		float num24 = lineVec1.x * lineVec2.y;
		float num25 = lineVec1.y * lineVec2.x;
		float num26 = num24 - num25;
		float num27 = num11 * num26;
		float num28 = num23 + num27;
		bool flag = !(num28 < 1E-05f);
		bool result = false;
		if (!flag)
		{
			bool flag2 = !(num28 > -1E-05f);
			result = false;
			if (!flag2)
			{
				float num29 = num13 * num5;
				float num30 = num17 * num8;
				float num31 = num29 + num30;
				float num32 = num20 * num26;
				float num33 = num31 + num32;
				float num34 = num5 * num5;
				float num35 = num8 * num8;
				float num36 = num34 + num35;
				float num37 = num26 * num26;
				float num38 = num36 + num37;
				float num39 = num33 / num38;
				bool flag3 = !(num39 < 0f);
				bool flag4 = !flag3;
				result = false;
				if (!flag4)
				{
					bool flag5 = !(num39 > 1f);
					bool flag6 = !flag5;
					result = false;
					if (!flag6)
					{
						float num40 = lineVec1.z * num39;
						float num41 = linePoint1.z + num40;
						float num42 = lineVec1.y * num39;
						float num43 = linePoint1.y + num42;
						float num44 = lineVec1.x * num39;
						float num45 = linePoint1.x + num44;
						reference = ref *(Vector3*)num45;
						result = true;
					}
				}
			}
		}
		return result;
	}

	public unsafe static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		//IL_02a3: Expected I, but got Obj
		//IL_02c9: Expected Ref, but got VT
		//IL_02f3: Expected I, but got Obj
		//IL_0319: Expected Ref, but got VT
		//IL_01ca: Expected Ref, but got F4
		//IL_0290: Expected Ref, but got F4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)Vector3.zeroVector;
		float num5 = lineVec1.x * lineVec1.x;
		float num6 = lineVec1.y * lineVec1.y;
		float num7 = num5 + num6;
		float num8 = lineVec1.z * lineVec1.z;
		float num9 = num7 + num8;
		float num10 = lineVec1.x * lineVec2.x;
		float num11 = lineVec1.y * lineVec2.y;
		float num12 = num10 + num11;
		float num13 = lineVec1.z * lineVec2.z;
		float num14 = num12 + num13;
		float num15 = lineVec2.x * lineVec2.x;
		float num16 = lineVec2.y * lineVec2.y;
		float num17 = num15 + num16;
		float num18 = lineVec2.z * lineVec2.z;
		float num19 = num17 + num18;
		float num20 = num9 * num19;
		float num21 = num14 * num14;
		float num22 = num20 - num21;
		if (num22 != 0f)
		{
			float num23 = linePoint1.x - linePoint2.x;
			float num24 = lineVec1.x * num23;
			float num25 = linePoint1.y - linePoint2.y;
			float num26 = lineVec1.y * num25;
			float num27 = num24 + num26;
			float num28 = linePoint1.z - linePoint2.z;
			float num29 = lineVec1.z * num28;
			float num30 = num27 + num29;
			float num31 = lineVec2.x * num23;
			float num32 = lineVec2.y * num25;
			float num33 = num31 + num32;
			float num34 = lineVec2.z * num28;
			float num35 = num33 + num34;
			float num36 = num14 * num35;
			float num37 = num30 * num19;
			float num38 = num36 - num37;
			float num39 = num38 / num22;
			float num40 = lineVec1.x * num39;
			float num41 = lineVec1.z * num39;
			float num42 = linePoint1.z + num41;
			float num43 = lineVec1.y * num39;
			float num44 = linePoint1.y + num43;
			float num45 = linePoint1.x + num40;
			reference = ref *(Vector3*)num45;
			float num46 = num9 * num35;
			float num47 = num30 * num14;
			float num48 = num46 - num47;
			float num49 = num48 / num22;
			float num50 = lineVec2.x * num49;
			float num51 = lineVec2.z * num49;
			float num52 = linePoint2.z + num51;
			float num53 = lineVec2.y * num49;
			float num54 = linePoint2.y + num53;
			float num55 = linePoint2.x + num50;
			reference2 = ref *(Vector3*)num55;
		}
		return num22 != 0f;
	}

	public unsafe static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_011e: Expected native int or pointer, but got VT
		//IL_013f: Expected native int or pointer, but got VT
		float num = point.x - linePoint.x;
		float num2 = num * lineVec.x;
		float num3 = point.y - linePoint.y;
		float num4 = num3 * lineVec.y;
		float num5 = num2 + num4;
		float num6 = point.z - linePoint.z;
		float num7 = num6 * lineVec.z;
		float num8 = num5 + num7;
		float num9 = lineVec.x * num8;
		float num10 = lineVec.z * num8;
		float z = linePoint.z + num10;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		float num11 = lineVec.y * num8;
		float y = linePoint.y + num11;
		((Vector3*)(nint)vector)->y = y;
		float x = linePoint.x + num9;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0353: Expected I, but got Obj
		//IL_036c: Expected F4, but got VT
		//IL_037c: Expected F4, but got I
		//IL_038c: Expected F4, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected VT, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected VT, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected VT, but got Unknown
		//IL_02b2: Expected F4, but got I
		//IL_02ad: Expected native int or pointer, but got VT
		//IL_02d1: Expected F4, but got I
		//IL_02cc: Expected native int or pointer, but got VT
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected I, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected VT, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected VT, but got Unknown
		//IL_0328: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_03e9: Expected I, but got Obj
		//IL_03c1: Expected F4, but got VT
		//IL_03bc: Expected native int or pointer, but got VT
		//IL_03d6: Expected F4, but got I
		//IL_03d1: Expected native int or pointer, but got VT
		//IL_0165: Expected I, but got VT
		//IL_0172: Expected I, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		_ = 0;
		_ = 0;
		float num = linePoint2.x - linePoint1.x;
		float num2 = linePoint2.y - linePoint1.y;
		float num3 = linePoint2.z - linePoint1.z;
		float num4 = num * num;
		float num5 = num2 * num2;
		float num6 = num4 + num5;
		float num7 = num3 * num3;
		float num8 = num6 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (num8 > 1E-05f)
		{
			float num9 = num3 / num8;
			float num10 = num2 / num8;
			float num11 = num / num8;
			float num12 = num9;
			float num13 = num10;
		}
		else
		{
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v81 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num15 = 0;
			float num11 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v82 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num12 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v82 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num13 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		_ = linePoint1.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		_ = linePoint1.x;
		_ = point.z;
		_ = point.x;
		Vector3 linePoint3 = vector + 80;
		Vector3 lineVec = vector - -64;
		Vector3 point2 = vector + 48;
		Vector3 vector2 = ProjectPointOnLine(linePoint3, lineVec, point2);
		_ = linePoint1.z;
		_ = linePoint1.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = linePoint2.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		((Vector3*)(nint)vector)->x = 0f;
		_ = linePoint2.x;
		nint num16 = (nint)(vector + 112);
		Vector3 linePoint4 = vector + 32;
		Vector3 linePoint5 = vector + 16;
		int num17 = PointOnWhichSideOfLineSegment(linePoint4, linePoint5, vector);
		object obj2 = num17 + 3;
		if (num17 >= 3)
		{
			obj2 = 0;
		}
		if (obj2 != null)
		{
			if ((nint)obj2 == 1 || (nint)obj2 == 2)
			{
				goto IL_03ae;
			}
			bool flag = (nint)obj2 == 3;
			nint num18 = num16;
			if (!flag)
			{
				if ((nint)obj2 != 4)
				{
					if ((nint)obj2 != 5)
					{
						goto IL_03ae;
					}
					num18 = (nint)linePoint2;
				}
				else
				{
					num18 = (nint)linePoint1;
				}
			}
		}
		else
		{
			nint num19 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v69 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num18 = 0;
		}
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->x = (float)Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ L3_v3 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		goto IL_03ae;
		IL_03ae:
		return vector3;
	}

	public unsafe static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected VT, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected VT, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_00a6: Expected native int or pointer, but got VT
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_012f: Expected native int or pointer, but got VT
		//IL_013c: Expected native int or pointer, but got VT
		//IL_0149: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = planeNormal.z;
		_ = planeNormal.x;
		_ = planePoint.z;
		_ = planePoint.x;
		_ = point.z;
		_ = point.x;
		Vector3 planeNormal2 = vector + 48;
		Vector3 planePoint2 = vector + 32;
		Vector3 point2 = vector + 16;
		float num = SignedDistancePlanePoint(planeNormal2, planePoint2, point2);
		float size = -0f - num;
		((Vector3*)(nint)vector)->z = planeNormal.z;
		((Vector3*)(nint)vector)->x = planeNormal.x;
		Vector3 vector2 = SetVectorLength(vector, size);
		float num2 = point.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		float x = num2 + 0f;
		float num3 = point.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		float y = num3 + 0f;
		float num4 = point.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		float z = num4 + 0f;
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->z = z;
		((Vector3*)(nint)vector3)->y = y;
		((Vector3*)(nint)vector3)->x = x;
		return vector3;
	}

	public unsafe static Vector3 ProjectVectorOnPlane(Vector3 planeNormal, Vector3 vector)
	{
		//IL_00ad: Expected native int or pointer, but got VT
		//IL_00e2: Expected native int or pointer, but got VT
		//IL_0103: Expected native int or pointer, but got VT
		float num = vector.x * planeNormal.x;
		float num2 = vector.y * planeNormal.y;
		float num3 = num + num2;
		float num4 = vector.z * planeNormal.z;
		float num5 = num3 + num4;
		float num6 = planeNormal.x * num5;
		float num7 = planeNormal.z * num5;
		float z = vector.z - num7;
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = z;
		float num8 = planeNormal.y * num5;
		float y = vector.y - num8;
		((Vector3*)(nint)vector2)->y = y;
		float x = vector.x - num6;
		((Vector3*)(nint)vector2)->x = x;
		return vector2;
	}

	public static float SignedDistancePlanePoint(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		float num = point.x - planePoint.x;
		float num2 = planeNormal.x * num;
		float num3 = point.y - planePoint.y;
		float num4 = planeNormal.y * num3;
		float num5 = num2 + num4;
		float num6 = point.z - planePoint.z;
		float num7 = planeNormal.z * num6;
		return num5 + num7;
	}

	public static float SignedDotProduct(Vector3 vectorA, Vector3 vectorB, Vector3 normal)
	{
		float num = normal.y * vectorA.z;
		float num2 = normal.z * vectorA.y;
		float num3 = num - num2;
		float num4 = num3 * vectorB.x;
		float num5 = normal.z * vectorA.x;
		float num6 = normal.x * vectorA.z;
		float num7 = num5 - num6;
		float num8 = num7 * vectorB.y;
		float num9 = num4 + num8;
		float num10 = normal.x * vectorA.y;
		float num11 = normal.y * vectorA.x;
		float num12 = num10 - num11;
		float num13 = num12 * vectorB.z;
		return num9 + num13;
	}

	public static float SignedVectorAngle(Vector3 referenceVector, Vector3 otherVector, Vector3 normal)
	{
		float num = normal.y * referenceVector.z;
		float num2 = normal.z * referenceVector.y;
		float num3 = num - num2;
		float num4 = normal.z * referenceVector.x;
		float num5 = normal.x * referenceVector.z;
		float num6 = num4 - num5;
		float num7 = normal.x * referenceVector.y;
		float num8 = normal.y * referenceVector.x;
		float num9 = num7 - num8;
		float num10 = referenceVector.x * referenceVector.x;
		float num11 = referenceVector.y * referenceVector.y;
		float num12 = num10 + num11;
		float num13 = referenceVector.z * referenceVector.z;
		float num14 = num12 + num13;
		float num15 = otherVector.x * otherVector.x;
		float num16 = otherVector.y * otherVector.y;
		float num17 = num15 + num16;
		float num18 = otherVector.z * otherVector.z;
		float num19 = num17 + num18;
		float num20 = num14 * num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num21;
		if (num20 < 1E-15f)
		{
			num21 = 0f;
		}
		else
		{
			float num22 = referenceVector.x * otherVector.x;
			float num23 = referenceVector.y * otherVector.y;
			float num24 = num22 + num23;
			float num25 = referenceVector.z * otherVector.z;
			float num26 = num24 + num25;
			float num27 = num26 / num20;
			float num28 = System.Math.Min(num27, 1f);
			bool flag = num27 < -1f;
			float num29 = -1f;
			if (!flag)
			{
				num29 = num28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1978");
			object obj = default;
			num21 = (float)obj * 57.29578f;
		}
		float num30 = num3 * otherVector.x;
		float num31 = num6 * otherVector.y;
		float num32 = num30 + num31;
		float num33 = num9 * otherVector.z;
		float num34 = num32 + num33;
		bool flag2 = !(num34 < 0f);
		float num35 = 1f;
		if (!flag2)
		{
			num35 = -1f;
		}
		return num21 * num35;
	}

	public static float AngleVectorPlane(Vector3 vector, Vector3 normal)
	{
		float num = vector.x * normal.x;
		float num2 = vector.y * normal.y;
		float num3 = num + num2;
		float num4 = vector.z * normal.z;
		float num5 = num3 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EAD");
		object obj = default;
		return (float)System.Math.PI / 2f - (float)obj;
	}

	public static float DotProductAngle(Vector3 vec1, Vector3 vec2)
	{
		float num = vec1.x * vec2.x;
		float num2 = vec1.y * vec2.y;
		float num3 = num + num2;
		float num4 = vec1.z * vec2.z;
		float val = num3 + num4;
		float val2 = System.Math.Max(val, -1f);
		float num5 = System.Math.Min(val2, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EAD");
		float result = default;
		return result;
	}

	public unsafe static void PlaneFrom3Points(out Vector3 planeNormal, out Vector3 planePoint, Vector3 pointA, Vector3 pointB, Vector3 pointC)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_009a: Expected Ref, but got VT
		//IL_03e6: Expected I, but got Obj
		//IL_040c: Expected Ref, but got VT
		//IL_039a: Expected I, but got Obj
		//IL_03b3: Expected F4, but got VT
		//IL_03c3: Expected F4, but got I
		//IL_03d3: Expected F4, but got I
		//IL_012e: Expected Ref, but got F4
		//IL_031d: Expected F4, but got I
		//IL_0318: Expected native int or pointer, but got VT
		//IL_0332: Expected F4, but got I
		//IL_032d: Expected native int or pointer, but got VT
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Ref, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected VT, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected VT, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)Vector3.zeroVector;
		float num5 = pointB.x - pointA.x;
		float num6 = pointB.z - pointA.z;
		float num7 = pointB.y - pointA.y;
		float num8 = pointC.z - pointA.z;
		float num9 = num7 * num8;
		float num10 = pointC.y - pointA.y;
		float num11 = num6 * num10;
		float num12 = num9 - num11;
		float num13 = pointC.x - pointA.x;
		float num14 = num6 * num13;
		float num15 = num5 * num8;
		float num16 = num14 - num15;
		float num17 = num5 * num10;
		float num18 = num7 * num13;
		float num19 = num17 - num18;
		float num20 = num12 * num12;
		float num21 = num16 * num16;
		float num22 = num20 + num21;
		float num23 = num19 * num19;
		float num24 = num22 + num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num27;
		if (num24 > 1E-05f)
		{
			float num25 = num19 / num24;
			float num26 = num16 / num24;
			num27 = num12 / num24;
			float num28 = num26;
			float num29 = num25;
		}
		else
		{
			nint num30 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num31 = 0;
			num27 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v87 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num28 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v87 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num29 = 0f;
		}
		reference = ref *(Vector3*)num27;
		float num32 = num6 * 0.5f;
		float num33 = pointA.z + num32;
		float num34 = pointC.z - num33;
		float num35 = num8 * 0.5f;
		float num36 = pointA.z + num35;
		float num37 = pointB.z - num36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		float num38 = num7 * 0.5f;
		float num39 = pointA.y + num38;
		float num40 = num5 * 0.5f;
		float num41 = pointA.x + num40;
		float num42 = pointC.y - num39;
		float num43 = pointC.x - num41;
		float num44 = num10 * 0.5f;
		float num45 = pointA.y + num44;
		float num46 = num13 * 0.5f;
		float num47 = pointA.x + num46;
		float num48 = pointB.y - num45;
		float num49 = pointB.x - num47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		ref Vector3 closestPointLine = ref *(Vector3*)(vector + 128);
		Vector3 linePoint = vector + 48;
		Vector3 lineVec = vector + 32;
		Vector3 linePoint2 = vector + 16;
		bool flag = ClosestPointsOnTwoLines(out planePoint, out closestPointLine, linePoint, lineVec, linePoint2, vector);
	}

	public unsafe static Vector3 GetForwardVector(Quaternion q)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_0068: Expected F4, but got VT
		//IL_0063: Expected native int or pointer, but got VT
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		//IL_009c: Expected F4, but got I
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00b1: Expected F4, but got I
		//IL_00ac: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		_ = q.z;
		_ = q.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.forwardVector;
		Quaternion quaternion = (Quaternion)(vector + 16);
		Vector3 vector2 = quaternion * vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector3)->x = 0f;
		return vector3;
	}

	public unsafe static Vector3 GetUpVector(Quaternion q)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_0068: Expected F4, but got VT
		//IL_0063: Expected native int or pointer, but got VT
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		//IL_009c: Expected F4, but got I
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00b1: Expected F4, but got I
		//IL_00ac: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		_ = q.z;
		_ = q.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.upVector;
		Quaternion quaternion = (Quaternion)(vector + 16);
		Vector3 vector2 = quaternion * vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector3)->x = 0f;
		return vector3;
	}

	public unsafe static Vector3 GetRightVector(Quaternion q)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_0068: Expected F4, but got VT
		//IL_0063: Expected native int or pointer, but got VT
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		//IL_009c: Expected F4, but got I
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00b1: Expected F4, but got I
		//IL_00ac: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		_ = q.z;
		_ = q.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+44]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.rightVector;
		Quaternion quaternion = (Quaternion)(vector + 16);
		Vector3 vector2 = quaternion * vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector3)->x = 0f;
		return vector3;
	}

	public unsafe static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001c: Expected Ref, but got VT
		//IL_002e: Expected Ref, but got VT
		//IL_0073: Expected F4, but got I
		//IL_006e: Expected native int or pointer, but got VT
		//IL_00af: Expected F4, but got I
		//IL_00aa: Expected native int or pointer, but got VT
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected VT, but got Unknown
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		//IL_00f8: Expected F4, but got I
		//IL_00f3: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Vector4 column = ((Matrix4x4*)m)->GetColumn(2);
		Vector4 column2 = ((Matrix4x4*)m)->GetColumn(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 forward = vector + 16;
		Quaternion quaternion = Quaternion.LookRotation(forward, vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		Quaternion quaternion2 = default;
		((Quaternion*)(nint)quaternion2)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Quaternion*)(nint)quaternion2)->x = 0f;
		return quaternion2;
	}

	public unsafe static Vector3 PositionFromMatrix(Matrix4x4 m)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Expected Ref, but got VT
		//IL_0035: Expected F4, but got I
		//IL_0030: Expected native int or pointer, but got VT
		//IL_0042: Expected F4, but got Obj
		//IL_003d: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector4 column = ((Matrix4x4*)m)->GetColumn(3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		return vector;
	}

	public unsafe static void LookRotationExtended(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 customForward, Vector3 customUp)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected VT, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected VT, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected VT, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected VT, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected VT, but got Unknown
		//IL_013c: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_030f: Expected F4, but got I
		//IL_030a: Expected native int or pointer, but got VT
		//IL_032c: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_03c9: Expected F4, but got I
		//IL_03c4: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 144);
		_ = alignWithVector.z;
		_ = alignWithVector.x;
		_ = alignWithNormal.z;
		_ = alignWithNormal.x;
		Vector3 forward = (Vector3)(quaternion + 80);
		Vector3 upwards = (Vector3)(quaternion - -64);
		Quaternion quaternion2 = Quaternion.LookRotation(forward, upwards);
		_ = customForward.z;
		_ = customForward.x;
		_ = customUp.z;
		_ = customUp.x;
		Vector3 forward2 = (Vector3)(quaternion + 48);
		Vector3 upwards2 = (Vector3)(quaternion + 32);
		Quaternion quaternion3 = Quaternion.LookRotation(forward2, upwards2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
		_ = 0;
		Transform transform = gameObjectInOut.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		_ = 0;
		Quaternion rotation = (Quaternion)(quaternion + 16);
		Quaternion quaternion4 = Quaternion.Inverse(rotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+8C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
		object obj2 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+7C]");
		object obj3 = num2 * 0;
		object obj4 = obj2 + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+84]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
		object obj5 = num3 * 0;
		object obj6 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+74]");
		object obj7 = num4 * 0;
		object obj8 = obj6 - obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+8C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
		object obj9 = num5 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+7C]");
		object obj10 = num6 * 0;
		object obj11 = obj9 + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+74]");
		object obj12 = num7 * 0;
		object obj13 = obj11 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+84]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
		object obj14 = num8 * 0;
		object obj15 = obj13 - obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+8C]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+7C]");
		object obj16 = num9 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
		object obj17 = num10 * 0;
		object obj18 = obj16 - obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+84]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+74]");
		object obj19 = num11 * 0;
		object obj20 = obj18 - obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
		object obj21 = num12 * 0;
		object obj22 = obj20 - obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+8C]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+74]");
		object obj23 = num13 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+84]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+7C]");
		object obj24 = num14 * 0;
		object obj25 = obj23 + obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
		object obj26 = num15 * 0;
		object obj27 = obj25 + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
		object obj28 = num16 * 0;
		object obj29 = obj27 - obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform.rotation = quaternion;
	}

	public unsafe static void TransformWithParent(out Quaternion childRotation, out Vector3 childPosition, Quaternion parentRotation, Vector3 parentPosition, Quaternion startParentRotation, Vector3 startParentPosition, Quaternion startChildRotation, Vector3 startChildPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02ba: Expected I, but got Obj
		//IL_02e0: Expected Ref, but got VT
		//IL_00bb: Expected I, but got Obj
		//IL_00e1: Expected Ref, but got VT
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected VT, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected VT, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected VT, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected VT, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected VT, but got Unknown
		//IL_0206: Expected I, but got Obj
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected VT, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected VT, but got Unknown
		//IL_0282: Expected native int or pointer, but got VT
		//IL_0294: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		ref Quaternion reference = ref *(Quaternion*)Quaternion.identityQuaternion;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)Vector3.zeroVector;
		_ = startParentRotation.z;
		_ = startParentRotation.x;
		Quaternion rotation = (Quaternion)(vector + 112);
		tempParent.rotation = rotation;
		_ = startParentPosition.z;
		_ = startParentPosition.x;
		Vector3 position = vector + 96;
		tempParent.position = position;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_ = Vector3.oneVector;
		Vector3 localScale = vector + 80;
		tempParent.localScale = localScale;
		_ = startChildRotation.z;
		_ = startChildRotation.x;
		Quaternion rotation2 = (Quaternion)(vector - -64);
		tempChild.rotation = rotation2;
		_ = startChildPosition.z;
		_ = startChildPosition.x;
		Vector3 position2 = vector + 48;
		tempChild.position = position2;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v46 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v47 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_ = Vector3.oneVector;
		Vector3 localScale2 = vector + 32;
		tempChild.localScale = localScale2;
		_ = parentRotation.z;
		_ = parentRotation.x;
		Quaternion rotation3 = (Quaternion)(vector + 16);
		tempParent.rotation = rotation3;
		((Vector3*)(nint)vector)->z = parentPosition.z;
		((Vector3*)(nint)vector)->x = parentPosition.x;
		tempParent.position = vector;
		Quaternion rotation4 = tempChild.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		reference = ref *(Quaternion*)null;
		Vector3 position3 = tempChild.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		reference2 = ref *(Vector3*)null;
	}

	public unsafe static void PreciseAlign(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 alignWithPosition, Vector3 triangleForward, Vector3 triangleNormal, Vector3 trianglePosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected VT, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected VT, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected VT, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected VT, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected VT, but got Unknown
		//IL_0176: Expected F4, but got I
		//IL_0171: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got I
		//IL_0190: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		_ = alignWithVector.z;
		_ = alignWithVector.x;
		_ = alignWithNormal.z;
		_ = alignWithNormal.x;
		_ = triangleForward.z;
		_ = triangleForward.x;
		_ = triangleNormal.z;
		_ = triangleNormal.x;
		Vector3 alignWithVector2 = vector + 80;
		Vector3 alignWithNormal2 = vector - -64;
		Vector3 customForward = vector + 48;
		Vector3 customUp = vector + 32;
		LookRotationExtended(ref gameObjectInOut, alignWithVector2, alignWithNormal2, customForward, customUp);
		Transform transform = gameObjectInOut.transform;
		_ = trianglePosition.z;
		_ = trianglePosition.x;
		Vector3 position = vector + 16;
		Vector3 vector2 = transform.TransformPoint(position);
		float num = alignWithPosition.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		float num2 = num - 0f;
		float num3 = alignWithPosition.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		float num4 = num3 - 0f;
		float num5 = alignWithPosition.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		float num6 = num5 - 0f;
		Transform transform2 = gameObjectInOut.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.Translate(vector, Space.World);
	}

	public unsafe static void VectorsToTransform(ref GameObject gameObjectInOut, Vector3 positionVector, Vector3 directionVector, Vector3 normalVector)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected VT, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected VT, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected VT, but got Unknown
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_00fc: Expected F4, but got I
		//IL_00f7: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 96);
		Transform transform = gameObjectInOut.transform;
		_ = positionVector.z;
		_ = positionVector.x;
		Vector3 position = (Vector3)(quaternion + 48);
		transform.position = position;
		Transform transform2 = gameObjectInOut.transform;
		_ = directionVector.z;
		_ = directionVector.x;
		_ = normalVector.z;
		_ = normalVector.x;
		Vector3 forward = (Vector3)(quaternion + 32);
		Vector3 upwards = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.LookRotation(forward, upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform2.rotation = quaternion;
	}

	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		float num = linePoint2.x - linePoint1.x;
		float num2 = linePoint2.y - linePoint1.y;
		float num3 = linePoint2.z - linePoint1.z;
		float num4 = point.x - linePoint1.x;
		float num5 = num4 * num;
		float num6 = point.y - linePoint1.y;
		float num7 = num6 * num2;
		float num8 = num5 + num7;
		float num9 = point.z - linePoint1.z;
		float num10 = num9 * num3;
		float num11 = num8 + num10;
		if (!(num11 > 0f))
		{
			return 1;
		}
		float num12 = num4 * num4;
		float num13 = num6 * num6;
		float num14 = num12 + num13;
		float num15 = num9 * num9;
		float num16 = num14 + num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num17 = num * num;
		float num18 = num2 * num2;
		float num19 = num17 + num18;
		float num20 = num3 * num3;
		float num21 = num19 + num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		bool flag = !(num16 > num21);
		bool flag2 = !flag;
		return (int)((flag2 ? 1u : 0u) << 1);
	}

	public unsafe static float MouseDistanceToLine(Vector3 linePoint1, Vector3 linePoint2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected VT, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected VT, but got Unknown
		//IL_00f3: Expected F4, but got I
		//IL_00ee: Expected native int or pointer, but got VT
		//IL_0149: Expected F4, but got I
		//IL_0144: Expected native int or pointer, but got VT
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected VT, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected VT, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		Camera main = Camera.main;
		Vector3 mousePosition = Input.mousePosition;
		_ = linePoint1.z;
		_ = linePoint1.x;
		Vector3 position = vector - -64;
		Vector3 vector2 = main.WorldToScreenPoint(position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		_ = linePoint2.z;
		_ = linePoint2.x;
		Vector3 position2 = vector + 48;
		Vector3 vector3 = main.WorldToScreenPoint(position2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 linePoint3 = vector + 32;
		Vector3 linePoint4 = vector + 16;
		Vector3 vector4 = ProjectPointOnLineSegment(linePoint3, linePoint4, vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		object obj2 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		object obj3 = num2 - 0;
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num4 = num3 - 0f;
		object obj4 = obj2 * obj2;
		object obj5 = obj3 * obj3;
		object obj6 = obj4 + obj5;
		float num5 = num4 * num4;
		float result = (float)obj6 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return result;
	}

	public unsafe static float MouseDistanceToCircle(Vector3 point, float radius)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0044: Expected native int or pointer, but got VT
		//IL_0077: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Camera main = Camera.main;
		Vector3 mousePosition = Input.mousePosition;
		((Vector3*)(nint)vector)->z = point.z;
		((Vector3*)(nint)vector)->x = point.x;
		Vector3 vector2 = main.WorldToScreenPoint(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		object obj2 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
		object obj3 = num2 - 0;
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		float num4 = num3 - 0f;
		object obj4 = obj2 * obj2;
		object obj5 = obj3 * obj3;
		object obj6 = obj4 + obj5;
		float num5 = num4 * num4;
		float num6 = (float)obj6 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return num6 - radius;
	}

	public unsafe static bool IsLineInRectangle(Vector3 linePoint1, Vector3 linePoint2, Vector3 rectA, Vector3 rectB, Vector3 rectC, Vector3 rectD)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected VT, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected VT, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected VT, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected VT, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected VT, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected VT, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected VT, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected VT, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected VT, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected VT, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected VT, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected VT, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected VT, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected VT, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected VT, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected VT, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected VT, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected VT, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected VT, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected VT, but got Unknown
		//IL_03e9: Expected native int or pointer, but got VT
		//IL_03fb: Expected native int or pointer, but got VT
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected VT, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected VT, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected VT, but got Unknown
		//IL_0455: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected I4, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 416);
		_ = linePoint1.z;
		_ = linePoint1.x;
		_ = rectA.z;
		_ = rectA.x;
		_ = rectC.z;
		_ = rectC.x;
		_ = rectB.z;
		_ = rectB.x;
		_ = rectD.z;
		_ = rectD.x;
		Vector3 point = vector + 400;
		Vector3 rectA2 = vector + 384;
		Vector3 rectC2 = vector + 368;
		Vector3 rectB2 = vector + 352;
		Vector3 rectD2 = vector + 336;
		if (!IsPointInRectangle(point, rectA2, rectC2, rectB2, rectD2))
		{
			_ = linePoint2.z;
			_ = linePoint2.x;
			_ = rectA.z;
			_ = rectA.x;
			_ = rectC.z;
			_ = rectC.x;
			_ = rectB.z;
			_ = rectB.x;
			_ = rectD.z;
			_ = rectD.x;
			Vector3 point2 = vector + 320;
			Vector3 rectA3 = vector + 304;
			Vector3 rectC3 = vector + 288;
			Vector3 rectB3 = vector + 272;
			Vector3 rectD3 = vector + 256;
			if (!IsPointInRectangle(point2, rectA3, rectC3, rectB3, rectD3))
			{
				_ = linePoint1.z;
				_ = linePoint1.x;
				_ = linePoint2.z;
				_ = linePoint2.x;
				_ = rectA.z;
				_ = rectA.x;
				_ = rectB.z;
				_ = rectB.x;
				Vector3 pointA = vector + 240;
				Vector3 pointA2 = vector + 224;
				Vector3 pointB = vector + 208;
				Vector3 pointB2 = vector + 192;
				bool flag = AreLineSegmentsCrossing(pointA, pointA2, pointB, pointB2);
				_ = linePoint1.z;
				_ = linePoint1.x;
				_ = linePoint2.z;
				_ = linePoint2.x;
				_ = rectB.z;
				_ = rectB.x;
				_ = rectC.z;
				_ = rectC.x;
				Vector3 pointA3 = vector + 176;
				Vector3 pointA4 = vector + 160;
				Vector3 pointB3 = vector + 144;
				Vector3 pointB4 = vector + 128;
				bool flag2 = AreLineSegmentsCrossing(pointA3, pointA4, pointB3, pointB4);
				_ = linePoint1.z;
				_ = linePoint1.x;
				_ = linePoint2.z;
				_ = linePoint2.x;
				_ = rectC.z;
				_ = rectC.x;
				_ = rectD.z;
				_ = rectD.x;
				Vector3 pointA5 = vector + 112;
				Vector3 pointA6 = vector + 96;
				Vector3 pointB5 = vector + 80;
				Vector3 pointB6 = vector - -64;
				bool flag3 = AreLineSegmentsCrossing(pointA5, pointA6, pointB5, pointB6);
				_ = linePoint1.z;
				_ = linePoint1.x;
				_ = linePoint2.z;
				_ = linePoint2.x;
				_ = rectD.z;
				_ = rectD.x;
				((Vector3*)(nint)vector)->z = rectA.z;
				((Vector3*)(nint)vector)->x = rectA.x;
				Vector3 pointA7 = vector + 48;
				Vector3 pointA8 = vector + 32;
				Vector3 pointB7 = vector + 16;
				bool flag4 = AreLineSegmentsCrossing(pointA7, pointA8, pointB7, vector);
				object obj2 = flag2 | flag;
				object obj3 = flag3 | obj2;
				return (byte)((flag4 | obj3) ? 1 : 0) != 0;
			}
		}
		return true;
	}

	public unsafe static bool IsPointInRectangle(Vector3 point, Vector3 rectA, Vector3 rectC, Vector3 rectB, Vector3 rectD)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected VT, but got Unknown
		//IL_0509: Expected I, but got Obj
		//IL_0522: Expected F4, but got VT
		//IL_0532: Expected F4, but got I
		//IL_0542: Expected F4, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected VT, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected VT, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected VT, but got Unknown
		//IL_0722: Expected I, but got Obj
		//IL_073b: Expected F4, but got VT
		//IL_074b: Expected F4, but got I
		//IL_075b: Expected F4, but got I
		//IL_0673: Expected native int or pointer, but got VT
		//IL_0685: Expected native int or pointer, but got VT
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected VT, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		float num = rectC.x - rectA.x;
		float num2 = rectC.y - rectA.y;
		float num3 = rectC.z - rectA.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Vector3 vector2 = vector + 96;
		float num4 = num * num;
		float num5 = num2 * num2;
		float num6 = num4 + num5;
		float num7 = num3 * num3;
		float num8 = num6 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num9 = num8 * 0.5f;
		float size = 0f - num9;
		Vector3 vector3 = AddVectorLength(vector2, size);
		float num10 = rectA.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		float num11 = num10 + 0f;
		float num12 = rectA.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
		float num13 = num12 + 0f;
		float num14 = rectA.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		float num15 = num14 + 0f;
		float num16 = rectB.x - rectA.x;
		float num17 = rectB.y - rectA.y;
		float num18 = rectB.z - rectA.z;
		float num19 = num16 * num16;
		float num20 = num17 * num17;
		float num21 = num19 + num20;
		float num22 = num18 * num18;
		float num23 = num21 + num22;
		float num24 = rectD.x - rectA.x;
		float num25 = rectD.y - rectA.y;
		float num26 = rectD.z - rectA.z;
		float num27 = num24 * num24;
		float num28 = num25 * num25;
		float num29 = num27 + num28;
		float num30 = num26 * num26;
		float num31 = num29 + num30;
		float num32 = num16 * num16;
		float num33 = num17 * num17;
		float num34 = num32 + num33;
		float num35 = num18 * num18;
		float num36 = num34 + num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (num36 > 1E-05f)
		{
			float num37 = num18 / num36;
			float num38 = num17 / num36;
			float num39 = num16 / num36;
			float num40 = num38;
			float num41 = num37;
		}
		else
		{
			nint num42 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v197 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num43 = 0;
			float num39 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v198 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num40 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v198 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num41 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		_ = point.z;
		_ = point.x;
		Vector3 linePoint = vector + 80;
		Vector3 lineVec = vector - -64;
		Vector3 point2 = vector + 48;
		Vector3 vector4 = ProjectPointOnLine(linePoint, lineVec, point2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		float num44 = 0f - point.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
		float num45 = 0f - point.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		float num46 = 0f - point.z;
		float num47 = num44 * num44;
		float num48 = num45 * num45;
		float num49 = num47 + num48;
		float num50 = num46 * num46;
		float num51 = num49 + num50;
		float num52 = num24 * num24;
		float num53 = num25 * num25;
		float num54 = num52 + num53;
		float num55 = num26 * num26;
		float num56 = num54 + num55;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (num56 > 1E-05f)
		{
			float num57 = num26 / num56;
			float num58 = num25 / num56;
			float num59 = num24 / num56;
			float num60 = num57;
			float num61 = num58;
		}
		else
		{
			nint num62 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v173 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num63 = 0;
			float num59 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v174 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num60 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v174 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num61 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		((Vector3*)(nint)vector)->z = point.z;
		((Vector3*)(nint)vector)->x = point.x;
		Vector3 linePoint2 = vector + 32;
		Vector3 lineVec2 = vector + 16;
		Vector3 vector5 = ProjectPointOnLine(linePoint2, lineVec2, vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		float num64 = 0f - point.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
		float num65 = 0f - point.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		float num66 = 0f - point.z;
		float num67 = num64 * num64;
		float num68 = num65 * num65;
		float num69 = num67 + num68;
		float num70 = num66 * num66;
		float num71 = num69 + num70;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num72 = num23 * 0.5f;
		if (!(num71 > num72))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			float num73 = num31 * 0.5f;
			return !(num51 > num73);
		}
		return false;
	}

	public unsafe static bool AreLineSegmentsCrossing(Vector3 pointA1, Vector3 pointA2, Vector3 pointB1, Vector3 pointB2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0311: Expected I, but got Obj
		//IL_032a: Expected F4, but got VT
		//IL_033a: Expected F4, but got I
		//IL_034a: Expected F4, but got I
		//IL_046e: Expected I, but got Obj
		//IL_0487: Expected F4, but got VT
		//IL_0497: Expected F4, but got I
		//IL_04a7: Expected F4, but got I
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Ref, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Ref, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected VT, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected VT, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected VT, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected VT, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected VT, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected VT, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected VT, but got Unknown
		//IL_01f9: Expected F4, but got I
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_0218: Expected F4, but got I
		//IL_0213: Expected native int or pointer, but got VT
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected VT, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 224);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		float num = pointA2.x - pointA1.x;
		float num2 = pointA2.y - pointA1.y;
		float num3 = pointA2.z - pointA1.z;
		float num4 = pointB2.x - pointB1.x;
		float num5 = pointB2.y - pointB1.y;
		float num6 = pointB2.z - pointB1.z;
		float num7 = num4 * num4;
		float num8 = num5 * num5;
		float num9 = num7 + num8;
		float num10 = num6 * num6;
		float num11 = num9 + num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (num11 > 1E-05f)
		{
			float num12 = num6 / num11;
			float num13 = num5 / num11;
			float num14 = num4 / num11;
			float num15 = num12;
			float num16 = num13;
		}
		else
		{
			nint num17 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v132 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num18 = 0;
			float num14 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v133 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num15 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v133 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num16 = 0f;
		}
		float num19 = num * num;
		float num20 = num2 * num2;
		float num21 = num19 + num20;
		float num22 = num3 * num3;
		float num23 = num21 + num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (num23 > 1E-05f)
		{
			float num24 = num3 / num23;
			float num25 = num2 / num23;
			float num26 = num / num23;
			float num27 = num24;
			float num28 = num25;
		}
		else
		{
			nint num29 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v110 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num30 = 0;
			float num26 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v111 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num27 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v111 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num28 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		_ = pointA1.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		_ = pointA1.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		_ = pointB1.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		_ = pointB1.x;
		ref Vector3 closestPointLine = ref *(Vector3*)(vector + 208);
		ref Vector3 closestPointLine2 = ref *(Vector3*)(vector + 192);
		Vector3 linePoint = vector + 144;
		Vector3 lineVec = vector + 128;
		Vector3 linePoint2 = vector + 112;
		Vector3 lineVec2 = vector + 96;
		bool flag = ClosestPointsOnTwoLines(out closestPointLine, out closestPointLine2, linePoint, lineVec, linePoint2, lineVec2);
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			_ = pointA1.z;
			_ = pointA1.x;
			_ = pointA2.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			_ = pointA2.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Vector3 linePoint3 = vector + 80;
			Vector3 linePoint4 = vector - -64;
			Vector3 point = vector + 48;
			int num31 = PointOnWhichSideOfLineSegment(linePoint3, linePoint4, point);
			_ = pointB1.z;
			_ = pointB1.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = pointB2.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			((Vector3*)(nint)vector)->x = 0f;
			_ = pointB2.x;
			Vector3 linePoint5 = vector + 32;
			Vector3 linePoint6 = vector + 16;
			int num32 = PointOnWhichSideOfLineSegment(linePoint5, linePoint6, vector);
			int num33 = num32 | num31;
			bool flag3 = num33 == 0;
			result = flag3;
		}
		return result;
	}

	public unsafe static bool LinearAcceleration(out Vector3 vector, Vector3 position, int samples)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07eb: Expected I, but got Obj
		//IL_0707: Expected I, but got Obj
		//IL_072d: Expected Ref, but got VT
		//IL_075b: Expected Obj, but got I4
		//IL_0779: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		//IL_07be: Expected Obj, but got I4
		//IL_0621: Expected Obj, but got I4
		//IL_0647: Expected Obj, but got I4
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_06e6: Expected Ref, but got F4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_039d: Expected Obj, but got I
		//IL_03a6: Invalid comparison between Obj and F4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I
		//IL_051c: Invalid comparison between Obj and F4
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected VT, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v25 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)Vector3.zeroVector;
		bool flag = samples > 3;
		int num5 = samples;
		if (!flag)
		{
			num5 = 3;
		}
		if (positionRegister == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Vector3[] array = default;
			positionRegister = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			float[] array2 = default;
			posTimeRegister = array2;
		}
		object obj3 = 0;
		while (true)
		{
			Vector3[] array3 = positionRegister;
			object obj4 = array3.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				break;
			}
			object obj5 = obj3 + 1;
			object obj6 = obj5 * 12;
			object obj7 = (object)positionRegister + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v123+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v123+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			obj = 0;
			object obj8 = obj3 * 12;
			object obj9 = (object)positionRegister + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj10 = obj3 << 2;
			object obj11 = (object)posTimeRegister + obj10;
			object obj12 = obj3 + 1;
			object obj13 = obj12 << 2;
			object obj14 = (object)posTimeRegister + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v143+10]");
			_ = 0;
			object obj15 = obj3 + 1;
			obj3 = obj15;
		}
		Vector3[] array4 = positionRegister;
		object obj16 = array4.Length - 1;
		_ = position.z;
		_ = position.x;
		object obj17 = obj16 * 12;
		object obj18 = (object)positionRegister + obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		float[] array5 = posTimeRegister;
		float time = Time.time;
		object obj19 = array5.Length - 1;
		object obj20 = obj19 << 2;
		object obj21 = (object)posTimeRegister + obj20;
		int num6 = positionSamplesTaken + 1;
		positionSamplesTaken = num6;
		bool flag2 = positionSamplesTaken < num5;
		bool result = false;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			object obj23 = 0;
			Vector3 vector2 = Vector3.zeroVector;
			object obj24 = 0;
			while (true)
			{
				Vector3[] array6 = positionRegister;
				object obj25 = array6.Length - 2;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
				{
					object obj26 = obj24 + 1;
					object obj27 = obj26 * 12;
					object obj28 = (object)positionRegister + obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v55+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v55+10]");
					_ = 0;
					object obj29 = obj24 * 12;
					object obj30 = (object)positionRegister + obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v63+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v63+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					object obj31 = num7 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
					object obj32 = num8 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					object obj33 = num9 - 0;
					object obj34 = obj24 + 1;
					object obj35 = obj34 << 2;
					object obj36 = (object)posTimeRegister + obj35;
					object obj37 = obj24 << 2;
					object obj38 = (object)posTimeRegister + obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S1_v77+10]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S2_v38+10]");
					object obj39 = num10 - 0;
					bool flag3 = obj39 == (object)0f;
					result = false;
					if (flag3)
					{
						break;
					}
					object obj40 = obj24 + 2;
					object obj41 = obj40 * 12;
					object obj42 = (object)positionRegister + obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S1_v85+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S1_v85+10]");
					_ = 0;
					object obj43 = obj24 + 1;
					object obj44 = obj43 * 12;
					object obj45 = (object)positionRegister + obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S1_v93+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S1_v93+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					object obj46 = num11 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
					object obj47 = num12 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					object obj48 = num13 - 0;
					object obj49 = obj24 + 2;
					object obj50 = obj49 << 2;
					object obj51 = (object)posTimeRegister + obj50;
					object obj52 = obj24 + 1;
					object obj53 = obj52 << 2;
					object obj54 = (object)posTimeRegister + obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S1_v107+10]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S2_v54+10]");
					object obj55 = num14 - 0;
					bool flag4 = obj55 == (object)0f;
					result = false;
					if (flag4)
					{
						break;
					}
					object obj56 = obj46 / obj55;
					object obj57 = obj31 / obj39;
					object obj58 = obj56 - obj57;
					Vector3 vector3 = vector2 + obj58;
					object obj59 = obj47 / obj55;
					object obj60 = obj32 / obj39;
					object obj61 = obj59 - obj60;
					object obj62 = obj23 + obj61;
					object obj63 = obj48 / obj55;
					object obj64 = obj33 / obj39;
					object obj65 = obj63 - obj64;
					object obj66 = obj22 + obj65;
					object obj67 = obj24 + 1;
					obj22 = obj66;
					obj23 = obj62;
					vector2 = vector3;
					obj24 = obj67;
					continue;
				}
				Vector3[] array7 = positionRegister;
				object obj68 = array7.Length - 2;
				object obj69 = obj22 / obj68;
				float[] array8 = posTimeRegister;
				object obj70 = array8.Length - 1;
				object obj71 = obj70 << 2;
				object obj72 = (object)posTimeRegister + obj71;
				float[] array9 = posTimeRegister;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S2_v19+10]");
				float num15 = 0f - array9[0];
				float num16 = (float)obj69 / num15;
				object obj73 = obj23 / obj68;
				float num17 = (float)obj73 / num15;
				object obj74 = vector2 / obj68;
				float num18 = (float)obj74 / num15;
				reference = ref *(Vector3*)num18;
				result = true;
				break;
			}
		}
		return result;
	}

	public static float LinearFunction2DBasic(float x, float Qx, float Qy)
	{
		float num = Qy / Qx;
		return x * num;
	}

	public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy)
	{
		float num = Qy - Py;
		float num2 = Qx - Px;
		float num3 = num / num2;
		float num4 = x - Px;
		float num5 = num3 * num4;
		return Py + num5;
	}
}
