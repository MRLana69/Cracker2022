using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace SYBO.Components.Logging;

public class GestureUnlock : MonoBehaviour
{
	public Vector2[] Gesture;

	public float InchWidth;

	public int Position = -1;

	public Behaviour Target;

	public UnityEvent OnUnlock;

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected VT, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected VT, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_027d: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected VT, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected VT, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected VT, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected VT, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5500");
		if (Position == -1)
		{
			if (Input.GetMouseButtonDown(0))
			{
				Vector2[] gesture = Gesture;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v54 (UnityEngine.Vector2[])+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Vector2 input = (Vector2)(obj + 16);
				Vector2 point = (Vector2)(obj + 8);
				if (AtPosition(input, point))
				{
					Position = 0;
				}
			}
			return;
		}
		object obj3 = Position + 1;
		object obj4 = obj3 << 3;
		object obj5 = (object)Gesture + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v10+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Vector2 input2 = (Vector2)(obj + 56);
		Vector2 point2 = (Vector2)(obj + 48);
		if (AtPosition(input2, point2))
		{
			int num = ++Position;
			Vector2[] gesture2 = Gesture;
			object obj6 = gesture2.Length - 1;
			if (num == (nint)obj6)
			{
				OnUnlock.Invoke();
				if (Target != null)
				{
					Target.enabled = true;
				}
				Position = -1;
				enabled = false;
			}
			return;
		}
		int num2 = Position << 3;
		object obj7 = Gesture + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v20+10]");
		_ = 0;
		object obj8 = obj - -64;
		object obj9 = Position + 1;
		object obj10 = obj9 << 3;
		object obj11 = (object)Gesture + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v25+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
		_ = 0;
		Vector2 input3 = (Vector2)(obj + 40);
		Vector2 point3 = (Vector2)(obj + 32);
		Vector2 point4 = (Vector2)(obj + 24);
		if (!DistanceGreen(input3, point3, point4))
		{
			Position = -1;
		}
		else if (Input.GetMouseButtonUp(0))
		{
			Position = -1;
		}
	}

	private unsafe void OnDrawGizmosSelected()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected VT, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected VT, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected VT, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected VT, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected VT, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected VT, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected VT, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected VT, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_054c: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02ef: Expected Obj, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got I
		//IL_038c: Expected native int or pointer, but got VT
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03e1: Expected F4, but got I
		//IL_03dc: Expected native int or pointer, but got VT
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected VT, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected VT, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 384);
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color color = (Color)(vector + 176);
		Gizmos.color = color;
		int width = Screen.width;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+158]");
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Vector3 vector2 = vector + 160;
		Vector3 to = vector + 144;
		Gizmos.DrawLine(vector2, to);
		int height = Screen.height;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		_ = 0;
		Vector3 vector3 = vector + 128;
		Vector3 to2 = vector + 112;
		Gizmos.DrawLine(vector3, to2);
		int width2 = Screen.width;
		int height2 = Screen.height;
		int width3 = Screen.width;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Vector3 vector4 = vector + 96;
		Vector3 to3 = vector + 80;
		Gizmos.DrawLine(vector4, to3);
		int width4 = Screen.width;
		int height3 = Screen.height;
		int height4 = Screen.height;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		_ = 0;
		Vector3 vector5 = vector - -64;
		Vector3 to4 = vector + 48;
		Gizmos.DrawLine(vector5, to4);
		object obj2 = 0;
		while (true)
		{
			Vector2[] gesture = Gesture;
			object obj3 = gesture.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				break;
			}
			object obj4 = obj2 << 3;
			object obj5 = (object)Gesture + obj4;
			object obj6 = obj5 + 16;
			int width5 = Screen.width;
			object obj7 = obj2 << 3;
			object obj8 = (object)Gesture + obj7;
			object obj9 = obj8 + 16;
			int height5 = Screen.height;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v116+4]");
			object obj10 = (nint)0 * (nint)height5;
			object obj11 = obj2 << 3;
			object obj12 = (object)Gesture + obj11;
			object obj13 = obj12 + 24;
			int width6 = Screen.width;
			object obj14 = obj2 << 3;
			object obj15 = (object)Gesture + obj14;
			object obj16 = obj15 + 24;
			int height6 = Screen.height;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v129+4]");
			object obj17 = (nint)0 * (nint)height6;
			_ = 0;
			_ = 0;
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			object obj18 = obj6 * width5;
			object obj19 = obj13 * width6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector6 = vector + 16;
			Gizmos.DrawLine(vector6, vector);
			object obj20 = obj2 + 1;
			obj2 = obj20;
		}
		object obj21 = 0;
		while (true)
		{
			Vector2[] gesture2 = Gesture;
			if (gesture2.Length > (nint)obj21)
			{
				object obj22 = obj21 << 3;
				object obj23 = (object)gesture2 + obj22;
				object obj24 = obj23 + 16;
				int width7 = Screen.width;
				object obj25 = obj21 << 3;
				object obj26 = (object)Gesture + obj25;
				object obj27 = obj26 + 16;
				int height7 = Screen.height;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v90+4]");
				object obj28 = (nint)0 * (nint)height7;
				float dpi = Screen.dpi;
				_ = 0;
				object obj29 = obj24 * width7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
				_ = 0;
				Vector3 center = vector + 32;
				float radius = InchWidth * dpi;
				Gizmos.DrawWireSphere(center, radius);
				object obj30 = obj21 + 1;
				obj21 = obj30;
				continue;
			}
			break;
		}
	}

	private unsafe Vector2 GetMouseScreenPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0024: Expected F4, but got Obj
		//IL_001f: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = (float)obj;
		return vector;
	}

	private unsafe bool AtPosition(Vector2 input, Vector2 point)
	{
		//IL_0033: Expected native int or pointer, but got VT
		//IL_0054: Expected native int or pointer, but got VT
		int width = Screen.width;
		int height = Screen.height;
		float x = point.x * (float)width;
		((Vector2*)(nint)point)->x = x;
		float num = (((Vector2*)(nint)point)->y = point.y * (float)height);
		float num2 = input.x - point.x;
		float num3 = input.y - num;
		float num4 = num2 * num2;
		float num5 = num3 * num3;
		float num6 = num4 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float dpi = Screen.dpi;
		float num7 = num6 / dpi;
		return num7 < InchWidth;
	}

	private unsafe bool DistanceGreen(Vector2 input, Vector2 point1, Vector2 point2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0041: Expected native int or pointer, but got VT
		//IL_0062: Expected native int or pointer, but got VT
		//IL_009a: Expected native int or pointer, but got VT
		//IL_00bb: Expected native int or pointer, but got VT
		//IL_00ff: Expected Obj, but got F4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		int width = Screen.width;
		int height = Screen.height;
		float x = point1.x * (float)width;
		((Vector2*)(nint)point1)->x = x;
		float y = point1.y * (float)height;
		((Vector2*)(nint)point1)->y = y;
		int width2 = Screen.width;
		int height2 = Screen.height;
		float x2 = point2.x * (float)width2;
		((Vector2*)(nint)point2)->x = x2;
		float y2 = point2.y * (float)height2;
		((Vector2*)(nint)point2)->y = y2;
		_ = point1.x;
		_ = input.x;
		_ = point2.x;
		_ = input.x;
		_ = point1.x;
		obj = point2.x;
		object obj3 = obj + 16;
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38AE");
		float dpi = Screen.dpi;
		object obj5 = default;
		float num = (float)obj5 / dpi;
		return num < InchWidth;
	}

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		float num = b.x - a.x;
		float num2 = num * num;
		float num3 = b.y - a.y;
		float num4 = num3 * num3;
		float num5 = num2 + num4;
		float num6 = point.x - a.x;
		float num7 = point.y - a.y;
		float result;
		if (num5 != 0f)
		{
			float num8 = b.x - a.x;
			float num9 = num6 * num8;
			float num10 = b.y - a.y;
			float num11 = num7 * num10;
			float num12 = num9 + num11;
			float num13 = num12 / num5;
			if (num13 < 0f)
			{
				float num14 = point.x - a.x;
				float num15 = point.y - a.y;
				float num16 = num14 * num14;
				float num17 = num15 * num15;
				result = num16 + num17;
			}
			else if (num13 > 1f)
			{
				float num18 = point.x - b.x;
				float num19 = point.y - b.y;
				float num20 = num18 * num18;
				float num21 = num19 * num19;
				result = num20 + num21;
			}
			else
			{
				float num22 = b.x - a.x;
				float num23 = num22 * num13;
				float num24 = a.x + num23;
				float num25 = point.x - num24;
				float num26 = b.y - a.y;
				float num27 = num26 * num13;
				float num28 = a.y + num27;
				float num29 = point.y - num28;
				float num30 = num25 * num25;
				float num31 = num29 * num29;
				result = num30 + num31;
			}
		}
		else
		{
			float num32 = num6 * num6;
			float num33 = num7 * num7;
			result = num32 + num33;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return result;
	}
}
