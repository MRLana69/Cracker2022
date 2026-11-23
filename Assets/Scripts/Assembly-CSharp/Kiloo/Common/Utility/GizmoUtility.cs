using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class GizmoUtility
{
	public unsafe static void DrawArrow(Vector3 fromPos, Vector3 toPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007f: Expected native int or pointer, but got VT
		//IL_0091: Expected native int or pointer, but got VT
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		float num = fromPos.x - toPos.x;
		float num2 = fromPos.y - toPos.y;
		float num3 = fromPos.z - toPos.z;
		_ = fromPos.z;
		_ = fromPos.x;
		((Vector3*)(nint)vector)->z = toPos.z;
		((Vector3*)(nint)vector)->x = toPos.x;
		Vector3 fromPos2 = vector + 16;
		float num4 = num * num;
		float num5 = num2 * num2;
		float num6 = num4 + num5;
		float num7 = num3 * num3;
		float num8 = num6 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float arrowHeadSize = num8 * 0.1f;
		DrawArrow(fromPos2, vector, arrowHeadSize);
	}

	public unsafe static void DrawArrow(Vector3 fromPos, Vector3 toPos, float arrowHeadSize)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03af: Expected I, but got Obj
		//IL_03c8: Expected F4, but got VT
		//IL_03d8: Expected F4, but got I
		//IL_03e8: Expected F4, but got I
		//IL_0438: Expected I, but got Obj
		//IL_0458: Expected F4, but got I
		//IL_0468: Expected F4, but got I
		//IL_0471: Expected F4, but got VT
		//IL_06e4: Expected I, but got Obj
		//IL_06fd: Expected F4, but got VT
		//IL_070d: Expected F4, but got I
		//IL_071d: Expected F4, but got I
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected VT, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected VT, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected VT, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected VT, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected VT, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected VT, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected VT, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected VT, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected VT, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected VT, but got Unknown
		//IL_02cf: Expected F4, but got I
		//IL_02ca: Expected native int or pointer, but got VT
		//IL_02fe: Expected F4, but got I
		//IL_02f9: Expected native int or pointer, but got VT
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 368);
		float num = fromPos.x - toPos.x;
		float num2 = fromPos.y - toPos.y;
		float num3 = fromPos.z - toPos.z;
		float num4 = num * num;
		float num5 = num2 * num2;
		float num6 = num4 + num5;
		float num7 = num3 * num3;
		float num8 = num6 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num11;
		float num12;
		float num13;
		if (num8 > 1E-05f)
		{
			float num9 = num3 / num8;
			float num10 = num2 / num8;
			num11 = num / num8;
			num12 = num9;
			num13 = num10;
		}
		else
		{
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v161 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num15 = 0;
			num11 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v162 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			num12 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v162 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			num13 = 0f;
		}
		float value = num12 - num11;
		float num16 = Math.Abs(value);
		float num17 = Math.Abs(num11);
		float num18 = Math.Abs(num12);
		if (!(num17 > num18))
		{
			num17 = num18;
		}
		float num19 = num17 * 1E-06f;
		float num20 = Mathf.Epsilon * 8f;
		if (!(num19 > num20))
		{
			num19 = num20;
		}
		float num28;
		float num29;
		float num30;
		if (!(num16 < num19))
		{
			float num21 = 0f - num11;
			float num22 = num12 * num12;
			float num23 = num22 + 0f;
			float num24 = num21 * num21;
			float num25 = num23 + num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (num25 > 1E-05f)
			{
				float num26 = num21 / num25;
				float num27 = 0f / num25;
				num28 = num12 / num25;
				num29 = num27;
				num30 = num26;
			}
			else
			{
				nint num31 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v123 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num32 = 0;
				num28 = (float)Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v124 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				num29 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v124 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				num30 = 0f;
			}
		}
		else
		{
			nint num33 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v145 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v146 (Il2CppStaticFields<UnityEngine.Vector3>)+40]");
			num29 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v146 (Il2CppStaticFields<UnityEngine.Vector3>)+44]");
			num30 = 0f;
			num28 = (float)Vector3.rightVector;
		}
		_ = fromPos.z;
		_ = fromPos.x;
		_ = toPos.z;
		_ = toPos.x;
		Vector3 vector2 = vector + 176;
		Vector3 to = vector + 160;
		Gizmos.DrawLine(vector2, to);
		float num35 = num11 * num29;
		float num36 = num13 * num28;
		float num37 = num35 - num36;
		_ = toPos.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+148]");
		_ = 0;
		float num38 = num12 * num28;
		float num39 = num11 * num30;
		float num40 = num38 - num39;
		float num41 = num13 * num30;
		float num42 = num12 * num29;
		float num43 = num41 - num42;
		_ = toPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		_ = 0;
		Vector3 axis = vector + 144;
		Quaternion quaternion = Quaternion.AngleAxis(25f, axis);
		float num44 = num12 * arrowHeadSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
		_ = 0;
		float num45 = num13 * arrowHeadSize;
		float num46 = num11 * arrowHeadSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Quaternion quaternion2 = (Quaternion)(vector + 128);
		Vector3 vector3 = vector + 112;
		Vector3 vector4 = quaternion2 * vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+168]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+160]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Vector3 vector5 = vector + 96;
		Vector3 direction = vector + 80;
		Gizmos.DrawRay(vector5, direction);
		_ = toPos.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
		_ = 0;
		_ = toPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		_ = 0;
		Vector3 axis2 = vector - -64;
		Quaternion quaternion3 = Quaternion.AngleAxis(-25f, axis2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Quaternion quaternion4 = (Quaternion)(vector + 48);
		Vector3 vector6 = vector + 32;
		Vector3 vector7 = quaternion4 * vector6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 vector8 = vector + 16;
		Gizmos.DrawRay(vector8, vector);
	}

	public unsafe static void DrawCircle(Vector3 center, float radius)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0114: Expected F4, but got I
		//IL_010f: Expected native int or pointer, but got VT
		//IL_015f: Expected F4, but got I
		//IL_015a: Expected native int or pointer, but got VT
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected VT, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		float num = center.x + radius;
		float num2 = center.y + 0f;
		float num3 = center.z + 0f;
		object obj2 = 1;
		object obj3 = default;
		object obj4 = default;
		while ((nint)obj2 < 17)
		{
			float num4 = (float)obj2 * 0.0625f;
			float num5 = num4 * (float)Math.PI;
			float num6 = num5 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			float num7 = (float)obj3 * radius;
			float num8 = center.x + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
			float num9 = (float)obj4 * radius;
			float num10 = center.z + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			float num11 = center.y + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector2 = vector + 16;
			Gizmos.DrawLine(vector2, vector);
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}
}
