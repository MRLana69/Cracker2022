using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Components.Analytics;
using SYBO.Components.Crypt;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Profiling.Memory.Experimental;

namespace SYBO.Components.Logging;

public class GestureUnlock : MonoBehaviour
{
	public Vector2[] Gesture;

	public float InchWidth;

	public int Position;

	public Behaviour Target;

	public UnityEvent OnUnlock;

	private void Update()
	{
	}

	private unsafe void OnDrawGizmosSelected()
	{
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected VT, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_026e: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01a9: Expected F4, but got Obj
		//IL_01a4: Expected native int or pointer, but got VT
		//IL_01cb: Expected VT, but got Obj
		//IL_01cb: Expected VT, but got Obj
		//IL_01cb: Expected VT, but got Obj
		//IL_02b0: Expected I, but got Obj
		//IL_02c6: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_02f1: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I4
		object obj = default;
		AsyncRes asyncRes = (AsyncRes)(obj + 80);
		Vector3 vector = (Vector3)(obj + 72);
		object obj2 = obj + 56;
		object obj3 = obj + 48;
		object obj4 = obj + 40;
		object obj5 = obj + 32;
		object obj6 = obj + 16;
		object obj7 = obj + 24;
		object obj8 = obj + 8;
		LogDefault logDefault = (LogDefault)(obj - -64);
		logDefault._002Ector(0);
		if (Position == -1)
		{
			if (Input.GetMouseButtonUp(0))
			{
				object obj9 = Gesture + 16;
				obj3 = obj9;
				obj2 = logDefault;
				asyncRes = (AsyncRes)obj2;
				logDefault = (LogDefault)obj3;
				IEnumerator enumerator = ((AnalyticsManager)(object)this).WaitForResult(asyncRes, (Action<byte[], int, string>)(object)logDefault);
				if (enumerator != null)
				{
					Position = 0;
				}
			}
			return;
		}
		int num = Position << 3;
		object obj10 = Gesture + num;
		object obj11 = obj10 + 24;
		obj5 = obj11;
		obj4 = logDefault;
		asyncRes = (AsyncRes)obj4;
		logDefault = (LogDefault)obj5;
		IEnumerator enumerator2 = ((AnalyticsManager)(object)this).WaitForResult(asyncRes, (Action<byte[], int, string>)(object)logDefault);
		if (enumerator2 == null)
		{
			object obj12 = Gesture + 16;
			int num2 = Position << 3;
			object obj13 = obj12 + num2;
			obj6 = obj13;
			int num3 = Position << 3;
			object obj14 = Gesture + num3;
			object obj15 = obj14 + 24;
			obj = obj15;
			obj7 = logDefault;
			obj8 = obj6;
			((Vector3*)(nint)vector)->x = (float)obj7;
			asyncRes = (AsyncRes)obj8;
			logDefault = (LogDefault)obj;
			if (!Math3D.AreLineSegmentsCrossing((Vector3)this, vector, (Vector3)asyncRes, (Vector3)logDefault))
			{
				Position = -1;
			}
			else if (Input.GetKey(KeyCode.None))
			{
				Position = -1;
			}
			return;
		}
		int position = Position + 1;
		Position = position;
		Vector2[] gesture = Gesture;
		object obj16 = gesture.Length - 1;
		if (Position != (nint)obj16)
		{
			return;
		}
		((MetaData)(object)OnUnlock)._002Ector();
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)Target).FindKernel((string)null) != 0)
		{
			Target.tag = (string)1;
		}
		Position = -1;
		tag = null;
	}

	private Vector2 GetMouseScreenPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		Vector2 vector = default;
		object obj = vector + 28;
		obj = this;
		return vector;
	}

	private bool AtPosition(Vector2 input, Vector2 point)
	{
		//IL_0034: Expected I4, but got VT
		//IL_0034: Expected Obj, but got I
		//IL_0039: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.GestureUnlock)+30]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.GestureUnlock)+2C]");
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream.Write((byte[])num, (int)input, 0);
		return (byte)(int)encryptedCTRStream != 0;
	}

	private bool DistanceGreen(Vector2 input, Vector2 point1, Vector2 point2)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		bool result = default;
		return result;
	}

	private unsafe static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected VT, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got F4
		//IL_011e: Expected F4, but got Obj
		//IL_0119: Expected native int or pointer, but got VT
		//IL_012b: Expected I4, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0050: Expected F4, but got Obj
		//IL_004b: Expected native int or pointer, but got VT
		//IL_0065: Expected F4, but got I
		//IL_0060: Expected native int or pointer, but got VT
		//IL_0072: Expected Obj, but got VT
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0196: Expected F4, but got Obj
		//IL_0191: Expected native int or pointer, but got VT
		//IL_01ab: Expected F4, but got I
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01cd: Expected F4, but got Obj
		//IL_01c8: Expected native int or pointer, but got VT
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got F4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_00c5: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		object obj2 = obj + 36;
		object obj3 = obj + 24;
		object obj4 = obj + 16;
		object obj5 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj6 = default;
		string text = default;
		object obj13 = default;
		while ((nint)obj6 <= 3)
		{
			object obj7 = point + 16;
			object obj8 = obj6 * 12;
			object obj9 = obj7 + obj8;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v19+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = ((Camera)b).WorldToViewportPoint(vector);
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v34 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v48 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Vector3 vector5 = (Vector2)vector;
			obj4 = obj;
			((Vector3*)(nint)vector)->x = (float)obj4;
			object obj11 = text + 16;
			object obj12 = obj13 << 3;
			object obj14 = obj11 + obj12;
			obj14 = vector.x;
			obj6 = obj13 + 1;
		}
		obj5 = a.x;
		((Vector3*)(nint)vector)->x = (float)obj5;
		return NGUIText.ParseAlpha(text, (int)vector);
	}

	public unsafe GestureUnlock()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Ref, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got F4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected VT, but got Unknown
		//IL_00dd: Expected F4, but got Obj
		//IL_00d8: Expected native int or pointer, but got VT
		//IL_00f2: Expected F4, but got I
		//IL_00ed: Expected native int or pointer, but got VT
		//IL_0114: Expected VT, but got Ref
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got F4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got F4
		//IL_0192: Expected F4, but got Obj
		//IL_018d: Expected native int or pointer, but got VT
		//IL_01a7: Expected F4, but got I
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01c9: Expected VT, but got Ref
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I4
		//IL_025c: Expected F4, but got Obj
		//IL_0257: Expected native int or pointer, but got VT
		//IL_0271: Expected F4, but got I
		//IL_026c: Expected native int or pointer, but got VT
		//IL_0293: Expected VT, but got Ref
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got F4
		//IL_0318: Expected F4, but got Obj
		//IL_0313: Expected native int or pointer, but got VT
		//IL_032d: Expected F4, but got I
		//IL_0328: Expected native int or pointer, but got VT
		//IL_034f: Expected VT, but got Ref
		//IL_035d: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I4
		//IL_052c: Expected Obj, but got I4
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03d8: Expected Obj, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_0489: Expected Obj, but got I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b9: Expected Obj, but got I
		//IL_04d1: Expected F4, but got Obj
		//IL_04cc: Expected native int or pointer, but got VT
		//IL_04e6: Expected F4, but got I
		//IL_04e1: Expected native int or pointer, but got VT
		//IL_0508: Expected VT, but got Ref
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_05a7: Expected native int or pointer, but got VT
		//IL_05b5: Expected native int or pointer, but got VT
		//IL_05d1: Expected native int or pointer, but got VT
		//IL_05f5: Expected native int or pointer, but got VT
		//IL_0603: Expected native int or pointer, but got VT
		//IL_061e: Expected Obj, but got F4
		//IL_065b: Expected VT, but got Ref
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 96;
		Color black = Color.black;
		ref Color reference = ref *(Color*)(obj2 + 136);
		reference = ref *(Color*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		_ = 0;
		Gizmos.set_color_Injected(ref reference);
		object obj4 = obj2 + 84;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 0f;
		_ = 0f;
		int height = Screen.height;
		object obj5 = obj2 + 72;
		obj5 = 0;
		_ = 0;
		obj5 = height;
		_ = 0f;
		_ = 0f;
		Vector3 vector = (Vector3)(obj2 + 124);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		reference = ref *(Color*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+8]");
		_ = 0;
		Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		object obj6 = obj2 + 60;
		obj6 = 0;
		_ = 0;
		obj6 = 0f;
		_ = 0f;
		_ = 0f;
		int sleepTimeout = Screen.sleepTimeout;
		object obj7 = obj2 + 48;
		obj7 = 0;
		_ = 0;
		obj7 = 0f;
		_ = 0f;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v33+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		reference = ref *(Color*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v41+8]");
		_ = 0;
		Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		int height2 = Screen.height;
		int sleepTimeout2 = Screen.sleepTimeout;
		object obj8 = obj2 + 36;
		obj8 = 0;
		_ = 0;
		obj8 = height2;
		_ = 0f;
		int height3 = Screen.height;
		object obj9 = obj2 + 24;
		obj9 = 0;
		_ = 0;
		obj9 = height3;
		_ = 0f;
		_ = 0f;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v56+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		reference = ref *(Color*)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v64+8]");
		_ = 0;
		Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		int height4 = Screen.height;
		int sleepTimeout3 = Screen.sleepTimeout;
		object obj10 = obj2 + 12;
		obj10 = 0;
		_ = 0;
		obj10 = height4;
		_ = 0f;
		int sleepTimeout4 = Screen.sleepTimeout;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 0f;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v79+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		reference = ref *(Color*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		object obj11 = 0;
		while (true)
		{
			Vector2[] gesture = Gesture;
			object obj12 = gesture.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				break;
			}
			object obj13 = Gesture + 16;
			object obj14 = obj11 << 3;
			object obj15 = obj13 + obj14;
			int height5 = Screen.height;
			object obj16 = Gesture + 16;
			object obj17 = obj11 << 3;
			object obj18 = obj16 + obj17;
			int sleepTimeout5 = Screen.sleepTimeout;
			obj3 = 0;
			_ = 0;
			object obj19 = obj15 * height5;
			obj3 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v145+4]");
			object obj20 = (nint)0 * (nint)sleepTimeout5;
			_ = 0f;
			object obj21 = obj11 << 3;
			object obj22 = (object)Gesture + obj21;
			object obj23 = obj22 + 24;
			int height6 = Screen.height;
			object obj24 = obj11 << 3;
			object obj25 = (object)Gesture + obj24;
			object obj26 = obj25 + 24;
			int sleepTimeout6 = Screen.sleepTimeout;
			obj4 = 0;
			_ = 0;
			object obj27 = obj23 * height6;
			obj4 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v164+4]");
			object obj28 = (nint)0 * (nint)sleepTimeout6;
			_ = 0f;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			reference = ref *(Color*)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
			_ = 0;
			Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			object obj29 = obj11 + 1;
			obj11 = obj29;
		}
		object obj30 = 0;
		while (true)
		{
			Vector2[] gesture2 = Gesture;
			if ((nint)obj30 < gesture2.Length)
			{
				object obj31 = Gesture + 16;
				object obj32 = obj30 << 3;
				object obj33 = obj31 + obj32;
				int height7 = Screen.height;
				object obj34 = Gesture + 16;
				object obj35 = obj30 << 3;
				object obj36 = obj34 + obj35;
				int sleepTimeout7 = Screen.sleepTimeout;
				((Vector3*)(nint)vector)->x = 0f;
				((Vector3*)(nint)vector)->z = 0f;
				float x = (float)obj33 * (float)height7;
				((Vector3*)(nint)vector)->x = x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v115+4]");
				float y = 0f * (float)sleepTimeout7;
				((Vector3*)(nint)vector)->y = y;
				((Vector3*)(nint)vector)->z = 0f;
				float value = UnityEngine.Random.value;
				obj = vector.x;
				_ = vector.z;
				reference = ref *(Color*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				_ = 0;
				float radius = InchWidth * value;
				Gizmos.DrawSphere((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), radius);
				object obj37 = obj30 + 1;
				obj30 = obj37;
				continue;
			}
			break;
		}
	}
}
