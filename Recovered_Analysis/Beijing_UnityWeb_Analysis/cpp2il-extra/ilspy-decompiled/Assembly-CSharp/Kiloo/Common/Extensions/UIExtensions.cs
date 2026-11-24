using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Common.HTTP;
using Kiloo.Common.HTTP.Internal;
using SYBO.Subway.Cameras;
using UI.Generic.Layout;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.U2D;

namespace Kiloo.Common.Extensions;

public static class UIExtensions
{
	public static void RepositionImmediately(UIGrid uiGrid)
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
		Transform transform = (Transform)(obj3 + 48);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
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
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v25+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)uiGrid).parent = transform;
	}

	public unsafe static void DrawBounds(Bounds b, Color col)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got F4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got F4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0093: Expected F4, but got Obj
		//IL_008e: Expected native int or pointer, but got VT
		//IL_00a8: Expected F4, but got I
		//IL_00a3: Expected native int or pointer, but got VT
		//IL_00bd: Expected F4, but got I
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00cf: Expected VT, but got F4
		//IL_00ca: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 32;
		obj = col.r;
		_ = col.b;
		object obj3 = obj2 + 16;
		obj3 = col.r;
		_ = col.b;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F533");
		object obj4 = obj2 + 48;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F520");
		((Color*)(nint)col)->r = (float)obj2;
		Color color = col;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		Color color2 = col;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+C]");
		((Color*)(nint)color2)->a = 0f;
		((Bounds*)(nint)b)->m_Center = (Vector3)col.r;
		_ = col.b;
	}

	public unsafe static Vector4 GetEndPositions(Transform transform, Renderer[] renderers = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I4
		//IL_0020: Expected I4, but got Obj
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got I4
		//IL_02d8: Invalid comparison between VT and I4
		//IL_01a6: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected VT, but got Unknown
		//IL_01ef: Invalid comparison between F4 and I4
		//IL_022b: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		GameObject gameObject = default;
		bool activeSelf = gameObject.activeSelf;
		if ((activeSelf ? 1 : 0) != (nint)renderers)
		{
			gameObject.SetActive((byte)(int)transform != 0);
		}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		Vector4 vector = default;
		if (vector != (Vector4)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		Vector4 result;
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj2 + obj8;
			if ((nint)obj9 == 80)
			{
				Vector4 vector2 = (Vector4)(obj2 + 4);
				if (vector2.x > -1f)
				{
					float x = vector2.x + -1f;
					((Vector4*)(nint)vector2)->x = x;
				}
				result = vector2;
				goto IL_02f9;
			}
		}
		object obj10 = default;
		bool flag = obj10 == null;
		result = vector;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			result = vector;
		}
		goto IL_02f9;
		IL_02f9:
		return result;
	}

	public static void PositionOnWidget(Transform t, UIWidget w, Camera modelCamera = null, Camera widgetCamera = null, UIWidget.Pivot pivot = UIWidget.Pivot.Center)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		((UnityEngine.Object)t).m_CachedPtr = (IntPtr)w;
		object obj = t + 12;
		obj = modelCamera;
		object obj2 = t + 20;
		obj2 = widgetCamera;
		object obj3 = t + 16;
		obj3 = pivot;
	}

	public static void SimpleFitToWidget(Transform transform, UIWidget widget, bool fitHorizontal = true)
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_034a: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got F4
		//IL_020a: Expected I, but got F4
		//IL_0069: Expected Obj, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		_ = 0;
		_ = 0;
		bool flag = default;
		if (!flag)
		{
			string tag = widget.tag;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v16 (Il2CppMethodInfo)+18]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v11 (should have been resolved before IL gen)");
		}
		Renderer renderer = (Renderer)(obj2 + 96);
		object obj7 = obj2 + 84;
		object obj8 = obj2 + 72;
		object obj9 = obj2 + 60;
		object obj10 = obj2 + 48;
		object obj11 = obj2 + 36;
		object obj12 = obj2 + 24;
		object obj13 = obj2 + 12;
		bool flag2 = default;
		object obj14 = (flag2 ? 1 : 0) + 12;
		float num2 = float.MaxValue;
		float num3 = float.MinValue;
		float num4 = float.MaxValue;
		float num5 = float.MinValue;
		object obj15 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
		{
			object obj16 = (flag2 ? 1 : 0) + 16;
			object obj17 = obj15 << 2;
			object material = obj16 + obj17;
			renderer.SetMaterial((Material)material);
			obj = renderer;
			_ = ((UnityEngine.Object)renderer).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v16 (UnityEngine.Renderer)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			float num6 = (float)obj7 + (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			float num7 = (float)obj9 - (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26+4]");
			float num8 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28+4]");
			float num9 = num8 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v30+4]");
			float num10 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num11 = num10 - 0f;
			obj15++;
			if (num6 > num5)
			{
				num5 = num6;
			}
			if (num7 < num4)
			{
				num4 = num7;
			}
			if (num9 > num3)
			{
				num3 = num9;
			}
			if (num11 < num2)
			{
				num2 = num11;
			}
		}
		Transform transform2 = (Transform)0;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		transform2 = (Transform)num4;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)num5;
	}

	public unsafe static Bounds CalculateMeshBounds(Transform t)
	{
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_04f0: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_050d: Expected Obj, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected VT, but got Unknown
		//IL_0590: Expected F4, but got Obj
		//IL_058b: Expected native int or pointer, but got VT
		//IL_05a5: Expected F4, but got I
		//IL_05a0: Expected native int or pointer, but got VT
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected VT, but got Unknown
		//IL_05c0: Expected F4, but got Obj
		//IL_05bb: Expected native int or pointer, but got VT
		//IL_05d5: Expected F4, but got I
		//IL_05d0: Expected native int or pointer, but got VT
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_00a0: Expected F4, but got Obj
		//IL_009b: Expected native int or pointer, but got VT
		//IL_00b5: Expected F4, but got I
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00c2: Expected F4, but got Obj
		//IL_00bd: Expected native int or pointer, but got VT
		//IL_00d7: Expected F4, but got I
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected VT, but got Unknown
		//IL_0659: Expected VT, but got Obj
		//IL_0654: Expected native int or pointer, but got VT
		//IL_0673: Expected F4, but got Obj
		//IL_066e: Expected native int or pointer, but got VT
		//IL_0688: Expected F4, but got I
		//IL_0683: Expected native int or pointer, but got VT
		//IL_0695: Expected F4, but got Obj
		//IL_0690: Expected native int or pointer, but got VT
		//IL_06aa: Expected F4, but got I
		//IL_06a5: Expected native int or pointer, but got VT
		//IL_06bb: Expected Obj, but got VT
		//IL_06bb: Expected Obj, but got VT
		//IL_06bb: Expected Obj, but got VT
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected Obj, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Obj, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_073b: Expected Obj, but got I4
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected Obj, but got Unknown
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07e3: Expected Obj, but got I4
		//IL_0818: Expected VT, but got Obj
		//IL_0813: Expected native int or pointer, but got VT
		//IL_0832: Expected F4, but got Obj
		//IL_082d: Expected native int or pointer, but got VT
		//IL_0847: Expected F4, but got I
		//IL_0842: Expected native int or pointer, but got VT
		//IL_0854: Expected F4, but got Obj
		//IL_084f: Expected native int or pointer, but got VT
		//IL_0866: Expected F4, but got I
		//IL_0861: Expected native int or pointer, but got VT
		//IL_0877: Expected Obj, but got VT
		//IL_0877: Expected Obj, but got VT
		//IL_0877: Expected Obj, but got VT
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected Obj, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected Obj, but got Unknown
		//IL_08f7: Expected Obj, but got I4
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected Obj, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_099f: Expected Obj, but got I4
		//IL_09d4: Expected VT, but got Obj
		//IL_09cf: Expected native int or pointer, but got VT
		//IL_09ee: Expected F4, but got Obj
		//IL_09e9: Expected native int or pointer, but got VT
		//IL_0a03: Expected F4, but got I
		//IL_09fe: Expected native int or pointer, but got VT
		//IL_0a10: Expected F4, but got Obj
		//IL_0a0b: Expected native int or pointer, but got VT
		//IL_0a22: Expected F4, but got I
		//IL_0a1d: Expected native int or pointer, but got VT
		//IL_0a33: Expected Obj, but got VT
		//IL_0a33: Expected Obj, but got VT
		//IL_0a33: Expected Obj, but got VT
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0389: Expected Obj, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0423: Expected Obj, but got I4
		//IL_0458: Expected VT, but got Obj
		//IL_0453: Expected native int or pointer, but got VT
		//IL_0472: Expected F4, but got Obj
		//IL_046d: Expected native int or pointer, but got VT
		//IL_0487: Expected F4, but got I
		//IL_0482: Expected native int or pointer, but got VT
		//IL_0494: Expected F4, but got Obj
		//IL_048f: Expected native int or pointer, but got VT
		//IL_04a6: Expected F4, but got I
		//IL_04a1: Expected native int or pointer, but got VT
		//IL_04b7: Expected Obj, but got VT
		//IL_04b7: Expected Obj, but got VT
		//IL_04b7: Expected Obj, but got VT
		//IL_02ca: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 508;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 496;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 484;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 460;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		object obj7 = obj2 + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v261 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 532);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 544);
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj9 = obj2 + 436;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v37+8]");
		_ = 0;
		object obj10 = obj2 + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		object obj11 = obj2 + 412;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		((Vector3*)(nint)vector)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v41+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v43+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj12 = obj2 + 400;
		Vector3 vector3 = vector - vector2;
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v49+8]");
		_ = 0;
		object obj13 = obj2 + 388;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj14 = obj2 + 376;
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj15 = obj2 + 364;
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj16 = obj2 + 352;
		obj16 = 0;
		_ = 0;
		obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v58+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v63+8]");
		_ = 0;
		object obj17 = obj2 + 340;
		obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj18 = obj2 + 328;
		obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj19 = obj2 + 316;
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj20 = obj2 + 304;
		obj20 = 0;
		_ = 0;
		obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v79+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v84+8]");
		_ = 0;
		object obj21 = obj2 + 288;
		obj21 = t;
		_ = ((UnityEngine.Object)t).m_CachedPtr;
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v98 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v257 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Bounds bounds = (Bounds)(obj2 + 520);
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v68+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v89+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v95+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Debug.LogFormat((UnityEngine.Object)bounds, (string)vector, (object[])vector2);
		object obj23 = obj2 + 276;
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj24 = obj2 + 264;
		obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj25 = obj2 + 252;
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj26 = obj2 + 240;
		obj26 = 0;
		_ = 0;
		obj26 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v116+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v121+8]");
		_ = 0;
		object obj27 = obj2 + 228;
		obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj28 = obj2 + 216;
		obj28 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj29 = obj2 + 204;
		obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj30 = obj2 + 192;
		obj30 = 0;
		_ = 0;
		obj30 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v137+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v142+8]");
		_ = 0;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v126+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v147+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)t;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)t).m_CachedPtr;
		Debug.LogFormat((UnityEngine.Object)bounds, (string)vector, (object[])vector2);
		object obj31 = obj2 + 180;
		obj31 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj32 = obj2 + 168;
		obj32 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj33 = obj2 + 156;
		obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj34 = obj2 + 144;
		obj34 = 0;
		_ = 0;
		obj34 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v165+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v170+8]");
		_ = 0;
		object obj35 = obj2 + 132;
		obj35 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj36 = obj2 + 120;
		obj36 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj37 = obj2 + 108;
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj38 = obj2 + 96;
		obj38 = 0;
		_ = 0;
		obj38 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v186+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v191+8]");
		_ = 0;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v175+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v196+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)t;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)t).m_CachedPtr;
		Debug.LogFormat((UnityEngine.Object)bounds, (string)vector, (object[])vector2);
		object obj39 = obj2 + 84;
		obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj40 = obj2 + 72;
		obj40 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj41 = obj2 + 60;
		obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj42 = obj2 + 48;
		obj42 = 0;
		_ = 0;
		obj42 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v214+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v219+8]");
		_ = 0;
		object obj43 = obj2 + 36;
		obj43 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj44 = obj2 + 24;
		obj44 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj45 = obj2 + 12;
		obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v235+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S0_v240+8]");
		_ = 0;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S0_v224+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)t;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)t).m_CachedPtr;
		Debug.LogFormat((UnityEngine.Object)bounds, (string)vector, (object[])vector2);
		return bounds;
	}

	public unsafe static Bounds CalculateRendererBounds(Transform t)
	{
		//IL_1a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3b: Expected Obj, but got Unknown
		//IL_1a44: Expected Obj, but got I4
		//IL_1a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a58: Expected Obj, but got Unknown
		//IL_1a61: Expected Obj, but got I4
		//IL_1a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7b: Expected Obj, but got Unknown
		//IL_1a84: Expected Obj, but got I4
		//IL_1a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a98: Expected Obj, but got Unknown
		//IL_1aa1: Expected Obj, but got I4
		//IL_1ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab5: Expected Obj, but got Unknown
		//IL_1abe: Expected Obj, but got I4
		//IL_1acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad2: Expected Obj, but got Unknown
		//IL_1adb: Expected Obj, but got I4
		//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aef: Expected Obj, but got Unknown
		//IL_1af8: Expected Obj, but got I4
		//IL_1b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0c: Expected Obj, but got Unknown
		//IL_1b15: Expected Obj, but got I4
		//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b29: Expected Obj, but got Unknown
		//IL_1b32: Expected Obj, but got I4
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Expected Obj, but got Unknown
		//IL_1b4f: Expected Obj, but got I4
		//IL_1b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b63: Expected Obj, but got Unknown
		//IL_1b6c: Expected Obj, but got I4
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Expected Obj, but got Unknown
		//IL_1b89: Expected Obj, but got I4
		//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9d: Expected Obj, but got Unknown
		//IL_1ba6: Expected Obj, but got I4
		//IL_1bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bba: Expected Obj, but got Unknown
		//IL_1bc3: Expected Obj, but got I4
		//IL_1bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd7: Expected Obj, but got Unknown
		//IL_1be0: Expected Obj, but got I4
		//IL_1bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf4: Expected Obj, but got Unknown
		//IL_1bfd: Expected Obj, but got I4
		//IL_1c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c30: Expected Obj, but got Unknown
		//IL_1c3d: Expected VT, but got Obj
		//IL_0025: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I
		//IL_1c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c50: Expected Obj, but got Unknown
		//IL_1c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5e: Expected Obj, but got Unknown
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Expected Obj, but got Unknown
		//IL_1c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7a: Expected Obj, but got Unknown
		//IL_1c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Expected VT, but got Unknown
		//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Expected Obj, but got Unknown
		//IL_1c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca4: Expected Obj, but got Unknown
		//IL_1cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb2: Expected Obj, but got Unknown
		//IL_1cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc0: Expected Obj, but got Unknown
		//IL_1ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce6: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0066: Expected I, but got Obj
		//IL_0889: Expected VT, but got Obj
		//IL_08ba: Expected VT, but got Obj
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00eb: Expected I4, but got Obj
		//IL_08cd: Expected I, but got Obj
		//IL_08e3: Expected Obj, but got I
		//IL_011b: Expected VT, but got I4
		//IL_233b: Expected VT, but got Obj
		//IL_233b: Expected VT, but got Obj
		//IL_234d: Expected I, but got Obj
		//IL_2363: Expected Obj, but got I
		//IL_23cb: Expected VT, but got Obj
		//IL_23cb: Expected VT, but got Obj
		//IL_23cb: Expected Ref, but got VT
		//IL_23f2: Expected Obj, but got F4
		//IL_2404: Expected I, but got F4
		//IL_2411: Expected VT, but got Obj
		//IL_2411: Expected VT, but got Obj
		//IL_2448: Unknown result type (might be due to invalid IL or missing references)
		//IL_244d: Expected Obj, but got Unknown
		//IL_090e: Expected I, but got Obj
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_09b1: Expected Obj, but got I4
		//IL_09c0: Expected Obj, but got F4
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected Obj, but got Unknown
		//IL_0a21: Expected VT, but got Obj
		//IL_0a21: Expected VT, but got Obj
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected VT, but got Unknown
		//IL_0a7e: Expected VT, but got Obj
		//IL_0a7e: Expected VT, but got Obj
		//IL_0a7e: Expected Ref, but got VT
		//IL_095b: Expected I, but got Obj
		//IL_019c: Expected VT, but got I4
		//IL_0aad: Expected Obj, but got F4
		//IL_0abf: Expected I, but got F4
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected Obj, but got Unknown
		//IL_0ada: Expected VT, but got Obj
		//IL_0ada: Expected VT, but got Obj
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected Obj, but got Unknown
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected Obj, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected Obj, but got Unknown
		//IL_0b6d: Expected Obj, but got I4
		//IL_0b7c: Expected Obj, but got F4
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected Obj, but got Unknown
		//IL_0bdd: Expected VT, but got Obj
		//IL_0bdd: Expected VT, but got Obj
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected VT, but got Unknown
		//IL_0c3a: Expected VT, but got Obj
		//IL_0c3a: Expected VT, but got Obj
		//IL_0c3a: Expected Ref, but got VT
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0c69: Expected Obj, but got F4
		//IL_0c7b: Expected I, but got F4
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0c96: Expected VT, but got Obj
		//IL_0c96: Expected VT, but got Obj
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Expected Obj, but got Unknown
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected Obj, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected Obj, but got Unknown
		//IL_1d61: Expected Obj, but got I4
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected Obj, but got Unknown
		//IL_0d29: Expected Obj, but got I4
		//IL_0d38: Expected Obj, but got F4
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Expected Obj, but got Unknown
		//IL_0d99: Expected VT, but got Obj
		//IL_0d99: Expected VT, but got Obj
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected VT, but got Unknown
		//IL_0df6: Expected VT, but got Obj
		//IL_0df6: Expected VT, but got Obj
		//IL_0df6: Expected Ref, but got VT
		//IL_0221: Expected I, but got Obj
		//IL_0e25: Expected Obj, but got F4
		//IL_0e37: Expected I, but got F4
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected Obj, but got Unknown
		//IL_0e52: Expected VT, but got Obj
		//IL_0e52: Expected VT, but got Obj
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e79: Expected Obj, but got Unknown
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9c: Expected Obj, but got Unknown
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected Obj, but got Unknown
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected Obj, but got Unknown
		//IL_0ee5: Expected Obj, but got I4
		//IL_0ef4: Expected Obj, but got F4
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Unknown
		//IL_0f55: Expected VT, but got Obj
		//IL_0f55: Expected VT, but got Obj
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected VT, but got Unknown
		//IL_0fb2: Expected VT, but got Obj
		//IL_0fb2: Expected VT, but got Obj
		//IL_0fb2: Expected Ref, but got VT
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_0fe1: Expected Obj, but got F4
		//IL_0ff3: Expected I, but got F4
		//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Expected Obj, but got Unknown
		//IL_100e: Expected VT, but got Obj
		//IL_100e: Expected VT, but got Obj
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_1035: Expected Obj, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_1076: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Expected Obj, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_06b9: Expected I, but got Obj
		//IL_06cf: Expected Obj, but got I
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Expected Obj, but got Unknown
		//IL_10a1: Expected Obj, but got I4
		//IL_10b0: Expected Obj, but got F4
		//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected Obj, but got Unknown
		//IL_1111: Expected VT, but got Obj
		//IL_1111: Expected VT, but got Obj
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Expected VT, but got Unknown
		//IL_116e: Expected VT, but got Obj
		//IL_116e: Expected VT, but got Obj
		//IL_116e: Expected Ref, but got VT
		//IL_2182: Expected VT, but got Obj
		//IL_2182: Expected VT, but got Obj
		//IL_2194: Expected I, but got Obj
		//IL_21aa: Expected Obj, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0325: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_119d: Expected Obj, but got F4
		//IL_11af: Expected I, but got F4
		//IL_11b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bd: Expected Obj, but got Unknown
		//IL_11ca: Expected VT, but got Obj
		//IL_11ca: Expected VT, but got Obj
		//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f1: Expected Obj, but got Unknown
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected Obj, but got Unknown
		//IL_1232: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Expected Obj, but got Unknown
		//IL_2212: Expected VT, but got Obj
		//IL_2212: Expected VT, but got Obj
		//IL_2212: Expected Ref, but got VT
		//IL_2239: Expected Obj, but got F4
		//IL_224b: Expected I, but got F4
		//IL_2258: Expected VT, but got Obj
		//IL_2258: Expected VT, but got Obj
		//IL_06fa: Expected I, but got Obj
		//IL_1daa: Expected VT, but got Obj
		//IL_1daa: Expected VT, but got Obj
		//IL_1dbc: Expected I, but got Obj
		//IL_1dd2: Expected Obj, but got I
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected Obj, but got Unknown
		//IL_125d: Expected Obj, but got I4
		//IL_126c: Expected Obj, but got F4
		//IL_12bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c0: Expected Obj, but got Unknown
		//IL_12cd: Expected VT, but got Obj
		//IL_12cd: Expected VT, but got Obj
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected VT, but got Unknown
		//IL_132a: Expected VT, but got Obj
		//IL_132a: Expected VT, but got Obj
		//IL_132a: Expected Ref, but got VT
		//IL_0747: Expected I, but got Obj
		//IL_1e3a: Expected VT, but got Obj
		//IL_1e3a: Expected VT, but got Obj
		//IL_1e3a: Expected Ref, but got VT
		//IL_1e61: Expected Obj, but got F4
		//IL_1e73: Expected I, but got F4
		//IL_1e80: Expected VT, but got Obj
		//IL_1e80: Expected VT, but got Obj
		//IL_0366: Expected I, but got Obj
		//IL_1359: Expected Obj, but got F4
		//IL_136b: Expected I, but got F4
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Expected Obj, but got Unknown
		//IL_1386: Expected VT, but got Obj
		//IL_1386: Expected VT, but got Obj
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected Obj, but got Unknown
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Expected Obj, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f3: Expected Obj, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_0441: Expected I, but got Obj
		//IL_03b3: Expected I, but got Obj
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected Obj, but got Unknown
		//IL_1419: Expected Obj, but got I4
		//IL_1428: Expected Obj, but got F4
		//IL_1477: Unknown result type (might be due to invalid IL or missing references)
		//IL_147c: Expected Obj, but got Unknown
		//IL_1489: Expected VT, but got Obj
		//IL_1489: Expected VT, but got Obj
		//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d5: Expected VT, but got Unknown
		//IL_14e6: Expected VT, but got Obj
		//IL_14e6: Expected VT, but got Obj
		//IL_14e6: Expected Ref, but got VT
		//IL_1f02: Expected Obj, but got I
		//IL_0417: Expected I, but got Obj
		//IL_1515: Expected Obj, but got F4
		//IL_1527: Expected I, but got F4
		//IL_1530: Unknown result type (might be due to invalid IL or missing references)
		//IL_1535: Expected Obj, but got Unknown
		//IL_1542: Expected VT, but got Obj
		//IL_1542: Expected VT, but got Obj
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_1569: Expected Obj, but got Unknown
		//IL_1587: Unknown result type (might be due to invalid IL or missing references)
		//IL_158c: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a9: Expected Obj, but got Unknown
		//IL_15b2: Expected Obj, but got I4
		//IL_15c1: Expected Obj, but got F4
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Expected Obj, but got Unknown
		//IL_1622: Expected VT, but got Obj
		//IL_1622: Expected VT, but got Obj
		//IL_1669: Unknown result type (might be due to invalid IL or missing references)
		//IL_166e: Expected VT, but got Unknown
		//IL_167f: Expected VT, but got Obj
		//IL_167f: Expected VT, but got Obj
		//IL_167f: Expected Ref, but got VT
		//IL_0473: Expected Obj, but got I
		//IL_16ae: Expected Obj, but got F4
		//IL_16c0: Expected I, but got F4
		//IL_16c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ce: Expected Obj, but got Unknown
		//IL_16db: Expected VT, but got Obj
		//IL_16db: Expected VT, but got Obj
		//IL_1729: Unknown result type (might be due to invalid IL or missing references)
		//IL_172e: Expected Obj, but got Unknown
		//IL_1766: Unknown result type (might be due to invalid IL or missing references)
		//IL_176b: Expected Obj, but got Unknown
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Expected Obj, but got Unknown
		//IL_17e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e5: Expected Obj, but got Unknown
		//IL_181d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1822: Expected Obj, but got Unknown
		//IL_185a: Unknown result type (might be due to invalid IL or missing references)
		//IL_185f: Expected Obj, but got Unknown
		//IL_1897: Unknown result type (might be due to invalid IL or missing references)
		//IL_189c: Expected Obj, but got Unknown
		//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d9: Expected Obj, but got Unknown
		//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f9: Expected Obj, but got Unknown
		//IL_1969: Unknown result type (might be due to invalid IL or missing references)
		//IL_196e: Expected Obj, but got Unknown
		//IL_1977: Expected Obj, but got I4
		//IL_0557: Expected I, but got Obj
		//IL_2051: Expected Obj, but got I
		//IL_052d: Expected I, but got Obj
		//IL_1a0e: Expected VT, but got Obj
		//IL_1a09: Expected native int or pointer, but got VT
		//IL_05bb: Expected Obj, but got I
		//IL_1985: Unknown result type (might be due to invalid IL or missing references)
		//IL_198a: Expected Obj, but got Unknown
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_1998: Expected Obj, but got Unknown
		//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f4: Expected Obj, but got Unknown
		//IL_0589: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 1016;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 992;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 980;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 968;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 956;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 944;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 932;
		obj8 = 0;
		_ = 0;
		object obj9 = obj2 + 920;
		obj9 = 0;
		_ = 0;
		object obj10 = obj2 + 908;
		obj10 = 0;
		_ = 0;
		object obj11 = obj2 + 896;
		obj11 = 0;
		_ = 0;
		object obj12 = obj2 + 884;
		obj12 = 0;
		_ = 0;
		object obj13 = obj2 + 872;
		obj13 = 0;
		_ = 0;
		object obj14 = obj2 + 856;
		obj14 = 0;
		_ = 0;
		object obj15 = obj2 + 840;
		obj15 = 0;
		_ = 0;
		object obj16 = obj2 + 828;
		obj16 = 0;
		_ = 0;
		object obj17 = obj2 + 816;
		obj17 = 0;
		_ = 0;
		string tag = t.tag;
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((GameObject)(object)tag).GetComponentsInParent<T>(true);
		Transform transform = (Transform)(obj2 + 1032);
		transform.rotation = (Quaternion)t;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v65 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v662 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj19 = obj2 + 784;
		object obj20 = obj2 + 772;
		Transform transform2 = (Transform)(obj2 + 760);
		object obj21 = obj2 + 748;
		Quaternion quaternion = (Quaternion)(obj2 + 736);
		object obj22 = obj2 + 724;
		object obj23 = obj2 + 712;
		object obj24 = obj2 + 696;
		Transform transform3 = (Transform)(obj2 + 800);
		transform3.Rotate(0f, 0f, 0f);
		Transform transform4 = (Transform)(obj2 + 1048);
		transform4 = transform3;
		((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		Quaternion localRotation = transform4.localRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj25 = componentsInParent + 12;
		object obj26 = default;
		object obj46 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25))
		{
			object obj27 = componentsInParent + 16;
			object obj28 = obj26 << 2;
			object obj29 = obj27 + obj28;
			bool flag = GraphicsFormatUtility.IsSRGBFormat((GraphicsFormat)obj29);
			string tag2 = ((Component)obj29).tag;
			int layer = ((GameObject)(object)tag2).layer;
			transform4.position = (Vector3)layer;
			obj12 = transform4;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			string tag3 = ((Component)obj29).tag;
			int layer2 = ((GameObject)(object)tag3).layer;
			transform.hasChanged = (byte)layer2 != 0;
			obj13 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			string tag4 = ((Component)obj29).tag;
			int layer3 = ((GameObject)(object)tag4).layer;
			transform3.rotation = (Quaternion)layer3;
			obj14 = transform3;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			int subMeshCount = ((Mesh)flag).subMeshCount;
			Vector3[] normals = ((Mesh)flag).normals;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v493 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v658 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			obj15 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70+8]");
			_ = 0;
			Vector3 one2 = Vector3.one;
			obj16 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v72+8]");
			_ = 0;
			object obj31 = 0;
			while ((nint)obj31 < subMeshCount)
			{
				object obj32 = obj31 | obj26;
				if (obj32 != null)
				{
					transform3 = (Transform)obj12;
					Transform transform5 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					obj19 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v46+8]");
					_ = 0;
					obj20 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v43+8]");
					_ = 0;
					object obj33 = normals + 16;
					object obj34 = obj31 * 12;
					object obj35 = obj33 + obj34;
					transform2 = (Transform)obj35;
					Transform transform6 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S1_v779+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v582 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num6 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S0_v654 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)obj20;
					Transform transform7 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v72+8]");
					((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
					transform4 = transform2;
					((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					Vector3 vector = Vector3.Cross((Vector3)transform, (Vector3)transform4);
					nint num7 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S0_v592 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num8 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ S0_v650 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)obj19;
					Transform transform8 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70+8]");
					((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
					transform4 = (Transform)obj21;
					Transform transform9 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v76+8]");
					((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
					((Quaternion*)quaternion)->SetLookRotation((Vector3)transform, (Vector3)transform4);
					transform = transform3;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
					transform4 = (Transform)quaternion.x;
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion.z;
					Vector3 vector2 = (Vector3)transform - (Vector3)transform4;
					obj17 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v80+8]");
					_ = 0;
					transform4 = (Transform)obj15;
					Transform transform10 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
					((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj17;
					Transform transform11 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
					((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
					nint num9;
					if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform4) > System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform))
					{
						transform4 = (Transform)obj17;
						Transform transform12 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
						((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
						num9 = (nint)transform4;
					}
					else
					{
						transform4 = (Transform)obj15;
						Transform transform13 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
						((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
						num9 = (nint)transform4;
					}
					obj15 = num9;
					transform4 = (Transform)obj15;
					Transform transform14 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
					((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj17;
					Transform transform15 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
					((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v88 (UnityEngine.Transform)+4]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v61 (UnityEngine.Transform)+4]");
					if (num10 > 0)
					{
						transform4 = (Transform)obj17;
						Transform transform16 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
						((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v88 (UnityEngine.Transform)+4]");
						object obj38 = 0;
					}
					else
					{
						transform4 = (Transform)obj15;
						Transform transform17 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
						((UnityEngine.Object)transform17).m_CachedPtr = (IntPtr)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v88 (UnityEngine.Transform)+4]");
						object obj38 = 0;
					}
					transform4 = (Transform)obj15;
					Transform transform18 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
					((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj17;
					Transform transform19 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
					((UnityEngine.Object)transform19).m_CachedPtr = (IntPtr)0;
					if ((nint)((UnityEngine.Object)transform4).m_CachedPtr > (nint)((UnityEngine.Object)transform).m_CachedPtr)
					{
						transform4 = (Transform)obj17;
						Transform transform20 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
						((UnityEngine.Object)transform20).m_CachedPtr = (IntPtr)0;
						IntPtr cachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
					}
					else
					{
						transform4 = (Transform)obj15;
						Transform transform21 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
						((UnityEngine.Object)transform21).m_CachedPtr = (IntPtr)0;
						IntPtr cachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
					}
					transform4 = (Transform)obj16;
					Transform transform22 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
					((UnityEngine.Object)transform22).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj17;
					Transform transform23 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
					((UnityEngine.Object)transform23).m_CachedPtr = (IntPtr)0;
					nint num11;
					if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform4) < System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform))
					{
						transform4 = (Transform)obj17;
						Transform transform24 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
						((UnityEngine.Object)transform24).m_CachedPtr = (IntPtr)0;
						num11 = (nint)transform4;
					}
					else
					{
						transform4 = (Transform)obj16;
						Transform transform25 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
						((UnityEngine.Object)transform25).m_CachedPtr = (IntPtr)0;
						num11 = (nint)transform4;
					}
					obj16 = num11;
					transform4 = (Transform)obj16;
					Transform transform26 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
					((UnityEngine.Object)transform26).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj17;
					Transform transform27 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
					((UnityEngine.Object)transform27).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v88 (UnityEngine.Transform)+4]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v61 (UnityEngine.Transform)+4]");
					if (num12 < 0)
					{
						transform4 = (Transform)obj17;
						Transform transform28 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
						((UnityEngine.Object)transform28).m_CachedPtr = (IntPtr)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v88 (UnityEngine.Transform)+4]");
						object obj39 = 0;
					}
					else
					{
						transform4 = (Transform)obj16;
						Transform transform29 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
						((UnityEngine.Object)transform29).m_CachedPtr = (IntPtr)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v88 (UnityEngine.Transform)+4]");
						object obj39 = 0;
					}
					transform4 = (Transform)obj16;
					Transform transform30 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
					((UnityEngine.Object)transform30).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj17;
					Transform transform31 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
					((UnityEngine.Object)transform31).m_CachedPtr = (IntPtr)0;
					if ((nint)((UnityEngine.Object)transform4).m_CachedPtr < (nint)((UnityEngine.Object)transform).m_CachedPtr)
					{
						transform4 = (Transform)obj17;
						Transform transform32 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v55+8]");
						((UnityEngine.Object)transform32).m_CachedPtr = (IntPtr)0;
						IntPtr cachedPtr2 = ((UnityEngine.Object)transform4).m_CachedPtr;
					}
					else
					{
						transform4 = (Transform)obj16;
						Transform transform33 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
						((UnityEngine.Object)transform33).m_CachedPtr = (IntPtr)0;
						IntPtr cachedPtr2 = ((UnityEngine.Object)transform4).m_CachedPtr;
					}
				}
				else
				{
					transform3 = (Transform)obj12;
					Transform transform34 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40+8]");
					((UnityEngine.Object)transform34).m_CachedPtr = (IntPtr)0;
					obj19 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v46+8]");
					_ = 0;
					obj20 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v43+8]");
					_ = 0;
					object obj40 = normals + 16;
					object obj41 = obj31 * 12;
					object obj42 = obj40 + obj41;
					transform2 = (Transform)obj42;
					Transform transform35 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ S1_v710+8]");
					((UnityEngine.Object)transform35).m_CachedPtr = (IntPtr)0;
					nint num13 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v529 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj43 = (nint)0 & (nint)0x200;
					if (obj43 != null)
					{
						nint num14 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v569 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)obj20;
					Transform transform36 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v72+8]");
					((UnityEngine.Object)transform36).m_CachedPtr = (IntPtr)0;
					transform4 = transform2;
					((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					Vector3 vector3 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
					nint num15 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ S0_v539 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj44 = (nint)0 & (nint)0x200;
					if (obj44 != null)
					{
						nint num16 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S0_v565 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)obj19;
					Transform transform37 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70+8]");
					((UnityEngine.Object)transform37).m_CachedPtr = (IntPtr)0;
					transform4 = (Transform)obj21;
					Transform transform38 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v76+8]");
					((UnityEngine.Object)transform38).m_CachedPtr = (IntPtr)0;
					((Quaternion*)quaternion)->SetLookRotation((Vector3)transform, (Vector3)transform4);
					transform = transform3;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
					transform4 = (Transform)quaternion.x;
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion.z;
					Vector3 vector4 = (Vector3)transform - (Vector3)transform4;
					obj15 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v80+8]");
					_ = 0;
					obj16 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v80+8]");
					_ = 0;
					obj23 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
					_ = 0;
					Vector3 one3 = Vector3.one;
					transform = (Transform)obj23;
					Transform transform39 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v82+8]");
					((UnityEngine.Object)transform39).m_CachedPtr = (IntPtr)0;
					transform4 = (Transform)obj24;
					Transform transform40 = transform4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v84+8]");
					((UnityEngine.Object)transform40).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
				}
				object obj45 = obj31 + 1;
				obj31 = obj45;
			}
			transform4 = (Transform)obj15;
			Transform transform41 = transform4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49+8]");
			((UnityEngine.Object)transform41).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
			transform4 = (Transform)obj16;
			Transform transform42 = transform4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52+8]");
			((UnityEngine.Object)transform42).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
			obj26 = obj46 + 1;
		}
		transform4 = (Transform)obj;
		Transform transform43 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform43).m_CachedPtr = (IntPtr)0;
		Quaternion localRotation2 = transform4.localRotation;
		transform3.position = (Vector3)t;
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		transform2.position = (Vector3)t;
		nint num17 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v106 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj47 = (nint)0 & (nint)0x200;
		if (obj47 != null)
		{
			nint num18 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v470 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj20;
		Transform transform44 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v72+8]");
		((UnityEngine.Object)transform44).m_CachedPtr = (IntPtr)0;
		transform4 = transform2;
		((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion quaternion2 = Quaternion.FromToRotation((Vector3)transform, (Vector3)transform4);
		nint num19 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v116 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj48 = (nint)0 & (nint)0x200;
		if (obj48 != null)
		{
			nint num20 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v466 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj19;
		Transform transform45 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70+8]");
		((UnityEngine.Object)transform45).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj21;
		Transform transform46 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v76+8]");
		((UnityEngine.Object)transform46).m_CachedPtr = (IntPtr)0;
		((Quaternion*)quaternion)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = transform3;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		transform4 = (Transform)quaternion.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion.z;
		Vector3 vector5 = (Vector3)transform - (Vector3)transform4;
		obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v80+8]");
		_ = 0;
		obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj49 = obj2 + 684;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj50 = obj2 + 672;
		obj50 = 0;
		_ = 0;
		obj50 = 1f;
		_ = 1f;
		_ = 1f;
		transform = (Transform)obj49;
		Transform transform47 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v135+8]");
		((UnityEngine.Object)transform47).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj50;
		Transform transform48 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v137+8]");
		((UnityEngine.Object)transform48).m_CachedPtr = (IntPtr)0;
		object obj51 = obj2 + 660;
		Vector3 vector6 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj24;
		Transform transform49 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v84+8]");
		((UnityEngine.Object)transform49).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj51;
		Transform transform50 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v147+8]");
		((UnityEngine.Object)transform50).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion3 = (Quaternion)(obj2 + 648);
		((Quaternion*)quaternion3)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj23;
		Transform transform51 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v82+8]");
		((UnityEngine.Object)transform51).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion3.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion3.z;
		object obj52 = obj2 + 636;
		Vector3 vector7 = (Vector3)transform - (Vector3)transform4;
		obj4 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v159+8]");
		_ = 0;
		object obj53 = obj2 + 624;
		obj53 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v82+8]");
		_ = 0;
		object obj54 = obj2 + 608;
		obj54 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj55 = obj2 + 596;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj56 = obj2 + 584;
		obj56 = 0;
		_ = 0;
		obj56 = -1f;
		_ = 1f;
		_ = 1f;
		transform = (Transform)obj55;
		Transform transform52 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S0_v169+8]");
		((UnityEngine.Object)transform52).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj56;
		Transform transform53 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v171+8]");
		((UnityEngine.Object)transform53).m_CachedPtr = (IntPtr)0;
		object obj57 = obj2 + 572;
		Vector3 vector8 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj54;
		Transform transform54 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S0_v166+8]");
		((UnityEngine.Object)transform54).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj57;
		Transform transform55 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v181+8]");
		((UnityEngine.Object)transform55).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion4 = (Quaternion)(obj2 + 560);
		((Quaternion*)quaternion4)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj53;
		Transform transform56 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S0_v163+8]");
		((UnityEngine.Object)transform56).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion4.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion4.z;
		object obj58 = obj2 + 548;
		Vector3 vector9 = (Vector3)transform - (Vector3)transform4;
		obj5 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v193+8]");
		_ = 0;
		object obj59 = obj2 + 536;
		obj59 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S0_v163+8]");
		_ = 0;
		object obj60 = obj2 + 520;
		obj60 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj61 = obj2 + 508;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj62 = obj2 + 496;
		obj62 = 0;
		_ = 0;
		obj62 = -1f;
		_ = 1f;
		_ = -1f;
		transform = (Transform)obj61;
		Transform transform57 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v203+8]");
		((UnityEngine.Object)transform57).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj62;
		Transform transform58 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S0_v205+8]");
		((UnityEngine.Object)transform58).m_CachedPtr = (IntPtr)0;
		object obj63 = obj2 + 484;
		Vector3 vector10 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj60;
		Transform transform59 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v200+8]");
		((UnityEngine.Object)transform59).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj63;
		Transform transform60 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v215+8]");
		((UnityEngine.Object)transform60).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion5 = (Quaternion)(obj2 + 472);
		((Quaternion*)quaternion5)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj59;
		Transform transform61 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v197+8]");
		((UnityEngine.Object)transform61).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion5.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion5.z;
		object obj64 = obj2 + 460;
		Vector3 vector11 = (Vector3)transform - (Vector3)transform4;
		obj6 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ S0_v227+8]");
		_ = 0;
		object obj65 = obj2 + 448;
		obj65 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v197+8]");
		_ = 0;
		object obj66 = obj2 + 432;
		obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj67 = obj2 + 420;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj68 = obj2 + 408;
		obj68 = 0;
		_ = 0;
		obj68 = 1f;
		_ = 1f;
		_ = -1f;
		transform = (Transform)obj67;
		Transform transform62 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ S0_v237+8]");
		((UnityEngine.Object)transform62).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj68;
		Transform transform63 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ S0_v239+8]");
		((UnityEngine.Object)transform63).m_CachedPtr = (IntPtr)0;
		object obj69 = obj2 + 396;
		Vector3 vector12 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj66;
		Transform transform64 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S0_v234+8]");
		((UnityEngine.Object)transform64).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj69;
		Transform transform65 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ S0_v249+8]");
		((UnityEngine.Object)transform65).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion6 = (Quaternion)(obj2 + 384);
		((Quaternion*)quaternion6)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj65;
		Transform transform66 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ S0_v231+8]");
		((UnityEngine.Object)transform66).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion6.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion6.z;
		object obj70 = obj2 + 372;
		Vector3 vector13 = (Vector3)transform - (Vector3)transform4;
		obj7 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ S0_v261+8]");
		_ = 0;
		object obj71 = obj2 + 360;
		obj71 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ S0_v231+8]");
		_ = 0;
		object obj72 = obj2 + 344;
		obj72 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj73 = obj2 + 332;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj74 = obj2 + 320;
		obj74 = 0;
		_ = 0;
		obj74 = 1f;
		_ = -1f;
		_ = 1f;
		transform = (Transform)obj73;
		Transform transform67 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ S0_v271+8]");
		((UnityEngine.Object)transform67).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj74;
		Transform transform68 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ S0_v273+8]");
		((UnityEngine.Object)transform68).m_CachedPtr = (IntPtr)0;
		object obj75 = obj2 + 308;
		Vector3 vector14 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj72;
		Transform transform69 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ S0_v268+8]");
		((UnityEngine.Object)transform69).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj75;
		Transform transform70 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ S0_v283+8]");
		((UnityEngine.Object)transform70).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion7 = (Quaternion)(obj2 + 296);
		((Quaternion*)quaternion7)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj71;
		Transform transform71 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ S0_v265+8]");
		((UnityEngine.Object)transform71).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion7.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion7.z;
		object obj76 = obj2 + 284;
		Vector3 vector15 = (Vector3)transform - (Vector3)transform4;
		obj8 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ S0_v295+8]");
		_ = 0;
		object obj77 = obj2 + 272;
		obj77 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ S0_v265+8]");
		_ = 0;
		object obj78 = obj2 + 256;
		obj78 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj79 = obj2 + 244;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj80 = obj2 + 232;
		obj80 = 0;
		_ = 0;
		obj80 = -1f;
		_ = -1f;
		_ = 1f;
		transform = (Transform)obj79;
		Transform transform72 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ S0_v305+8]");
		((UnityEngine.Object)transform72).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj80;
		Transform transform73 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ S0_v307+8]");
		((UnityEngine.Object)transform73).m_CachedPtr = (IntPtr)0;
		object obj81 = obj2 + 220;
		Vector3 vector16 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj78;
		Transform transform74 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1414 @ S0_v302+8]");
		((UnityEngine.Object)transform74).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj81;
		Transform transform75 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ S0_v317+8]");
		((UnityEngine.Object)transform75).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion8 = (Quaternion)(obj2 + 208);
		((Quaternion*)quaternion8)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj77;
		Transform transform76 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ S0_v299+8]");
		((UnityEngine.Object)transform76).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion8.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion8.z;
		object obj82 = obj2 + 196;
		Vector3 vector17 = (Vector3)transform - (Vector3)transform4;
		obj9 = obj82;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ S0_v329+8]");
		_ = 0;
		object obj83 = obj2 + 184;
		obj83 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ S0_v299+8]");
		_ = 0;
		object obj84 = obj2 + 168;
		obj84 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj85 = obj2 + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj86 = obj2 + 140;
		obj86 = 0;
		_ = 0;
		obj86 = -1f;
		_ = -1f;
		_ = -1f;
		transform = (Transform)obj85;
		Transform transform77 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ S0_v339+8]");
		((UnityEngine.Object)transform77).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj86;
		Transform transform78 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ S0_v341+8]");
		((UnityEngine.Object)transform78).m_CachedPtr = (IntPtr)0;
		object obj87 = obj2 + 128;
		Vector3 vector18 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj84;
		Transform transform79 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1591 @ S0_v336+8]");
		((UnityEngine.Object)transform79).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj87;
		Transform transform80 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S0_v351+8]");
		((UnityEngine.Object)transform80).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion9 = (Quaternion)(obj2 + 116);
		((Quaternion*)quaternion9)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj83;
		Transform transform81 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S0_v333+8]");
		((UnityEngine.Object)transform81).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion9.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion9.z;
		object obj88 = obj2 + 104;
		Vector3 vector19 = (Vector3)transform - (Vector3)transform4;
		obj10 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ S0_v363+8]");
		_ = 0;
		object obj89 = obj2 + 88;
		obj89 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj90 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj91 = obj2 + 60;
		obj91 = 0;
		_ = 0;
		obj91 = 1f;
		_ = -1f;
		_ = -1f;
		transform = (Transform)obj90;
		Transform transform82 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ S0_v370+8]");
		((UnityEngine.Object)transform82).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj91;
		Transform transform83 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ S0_v372+8]");
		((UnityEngine.Object)transform83).m_CachedPtr = (IntPtr)0;
		object obj92 = obj2 + 48;
		Vector3 vector20 = Vector3.Cross((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj89;
		Transform transform84 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ S0_v367+8]");
		((UnityEngine.Object)transform84).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj92;
		Transform transform85 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ S0_v382+8]");
		((UnityEngine.Object)transform85).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion10 = (Quaternion)(obj2 + 36);
		((Quaternion*)quaternion10)->SetLookRotation((Vector3)transform, (Vector3)transform4);
		transform = (Transform)obj83;
		Transform transform86 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S0_v333+8]");
		((UnityEngine.Object)transform86).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)quaternion10.x;
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)quaternion10.z;
		object obj93 = obj2 + 24;
		Vector3 vector21 = (Vector3)transform - (Vector3)transform4;
		obj11 = obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ S0_v394+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		transform4 = (Transform)obj4;
		Transform transform87 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
		((UnityEngine.Object)transform87).m_CachedPtr = (IntPtr)0;
		object obj95 = default;
		object obj94 = obj95 + 16;
		obj94 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj5;
		Transform transform88 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
		((UnityEngine.Object)transform88).m_CachedPtr = (IntPtr)0;
		object obj96 = obj95 + 28;
		obj96 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj6;
		Transform transform89 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		((UnityEngine.Object)transform89).m_CachedPtr = (IntPtr)0;
		object obj97 = obj95 + 40;
		obj97 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj7;
		Transform transform90 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
		((UnityEngine.Object)transform90).m_CachedPtr = (IntPtr)0;
		object obj98 = obj95 + 52;
		obj98 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj8;
		Transform transform91 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
		((UnityEngine.Object)transform91).m_CachedPtr = (IntPtr)0;
		object obj99 = obj95 - -64;
		obj99 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj9;
		Transform transform92 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31+8]");
		((UnityEngine.Object)transform92).m_CachedPtr = (IntPtr)0;
		object obj100 = obj95 + 76;
		obj100 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj10;
		Transform transform93 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34+8]");
		((UnityEngine.Object)transform93).m_CachedPtr = (IntPtr)0;
		object obj101 = obj95 + 88;
		obj101 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform4 = (Transform)obj11;
		Transform transform94 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37+8]");
		((UnityEngine.Object)transform94).m_CachedPtr = (IntPtr)0;
		object obj102 = obj95 + 100;
		obj102 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		object obj103 = obj2 + 12;
		obj103 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
		_ = 0;
		Vector3 one4 = Vector3.one;
		transform = (Transform)obj103;
		Transform transform95 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ S0_v441+8]");
		((UnityEngine.Object)transform95).m_CachedPtr = (IntPtr)0;
		transform4 = (Transform)obj2;
		Transform transform96 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform96).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		object obj104 = obj95 + 12;
		object obj105 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj105) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj104))
		{
			object obj106 = obj95 + 16;
			object obj107 = obj105 * 12;
			object obj108 = obj106 + obj107;
			transform = (Transform)obj108;
			Transform transform97 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1974 @ S1_v632+8]");
			((UnityEngine.Object)transform97).m_CachedPtr = (IntPtr)0;
			transform4 = transform;
			((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
			object obj109 = obj105 + 1;
			obj105 = obj109;
		}
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
		_ = 0;
		return bounds;
	}

	public static void CenterAlignOnZero(UIGrid grid)
	{
		grid.BroadcastMessage("Start", SendMessageOptions.DontRequireReceiver);
	}

	public static void CenterAlignOnZero(UITable table)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0108: Expected VT, but got Obj
		//IL_0137: Expected Obj, but got F4
		//IL_0065: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 24);
		object obj = transform2 + 12;
		obj = 0;
		_ = 0;
		object obj2 = 0;
		Sprite sprite = default;
		Sprite sprite2 = default;
		while (true)
		{
			GameObject gameObject = table.gameObject;
			int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			GameObject gameObject2 = table.gameObject;
			bool flag = ((SpriteAtlas)(object)gameObject2).CanBindTo(sprite);
			string tag = ((Component)flag).tag;
			if (!((GameObject)(object)tag).activeInHierarchy)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [table @ L0 (UITable)+25]");
				if ((nint)0 != 0)
				{
					goto IL_0174;
				}
			}
			object obj3 = obj2 + 1;
			obj2 = obj3;
			goto IL_0174;
			IL_0174:
			sprite = (Sprite)(sprite2 + 1);
		}
		object obj4 = obj2 - 1;
		object obj5 = obj4 * table.cellAlignment;
		GameObject gameObject3 = table.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		float num = (float)obj5 * -0.5f;
		obj = num;
		GameObject gameObject4 = table.gameObject;
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	public static float CenterChildrenHorizontally(Transform t, float padding)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F6");
		float result = default;
		return result;
	}

	public static float CenterChildrenHorizontally(Transform[] children, float padding, Transform parent)
	{
		//IL_0022: Invalid comparison between I and F4
		//IL_00bc: Expected F4, but got I
		//IL_005b: Expected Obj, but got I
		Transform transform = children[18];
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UnityEngine.Transform)+10]");
		if (0f > padding)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parent @ L2 (UnityEngine.Transform)+C]");
			object obj = -(nint)((UnityEngine.Object)parent).m_CachedPtr;
			Transform transform2 = children[18];
			float num = padding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v3 (UnityEngine.Transform)+10]");
			float num2 = num / 0f;
			float num3 = (float)obj * num2;
			return (float)(nint)((UnityEngine.Object)parent).m_CachedPtr + num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parent @ L2 (UnityEngine.Transform)+C]");
		return 0f;
	}

	public static float CenterTransformsHorizontalFixedWidth(Transform[] transforms, float width, float padding)
	{
		float num = width * 2f;
		float fOVForAspectRatio = ((CharacterCamera)(object)transforms).GetFOVForAspectRatio(padding);
		float num2 = num * fOVForAspectRatio;
		return num2 / (float)transforms[22];
	}

	public static float AlignChildrenHorizontally(Transform t, float padding, bool leftAligned)
	{
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_0486: Expected Obj, but got I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_04a9: Expected Obj, but got I4
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_0501: Expected I4, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I4
		//IL_0325: Expected VT, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_039a: Expected Obj, but got F4
		//IL_00e9: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I4
		//IL_013b: Expected VT, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a7: Expected Obj, but got I4
		object obj = default;
		Transform transform = (Transform)(obj + 136);
		object obj2 = obj + 48;
		Transform transform2 = (Transform)(obj + 36);
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		object obj5 = obj + 112;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj + 88;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj + 72;
		obj7 = 0;
		_ = 0;
		object obj8 = t + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector((int)obj8);
		int num = default;
		object obj13 = default;
		float num6 = default;
		float num7 = default;
		int num8 = default;
		while (num < (nint)obj8)
		{
			object obj9 = t + 16;
			int num2 = num << 2;
			object obj10 = obj9 + num2;
			string tag = ((Component)obj10).tag;
			if (((GameObject)(object)tag).activeInHierarchy)
			{
				IgnoreLayout component = ((Component)obj10).GetComponent<IgnoreLayout>();
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v120 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (component != null)
				{
					Vector3 vector = NGUIMath.WorldToLocalPoint((Vector3)leftAligned, (Camera)obj10, null, (Transform)1);
					obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
					_ = 0;
					transform = (Transform)obj2;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
					_ = 0;
					object obj12 = obj13 + 16;
					object obj14 = num * 24;
					object obj15 = obj12 + obj14;
					obj15 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
					float num5 = (float)transform * 2f;
					num6 = num7 + num5;
					list.Add(num);
				}
			}
			num = num8 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v34 (System.Collections.Generic.List`1<System.Int32>)+C]");
		object obj16 = -1;
		float num9 = (float)obj16 * padding;
		float num10 = num6 + num9;
		float num11 = num10 * -0.5f;
		int num12 = 0;
		float num13 = num11;
		while (true)
		{
			int num14 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v34 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num14 >= (nint)0)
			{
				break;
			}
			object obj17 = t + 16;
			int num15 = list.get_Item(num12);
			int num16 = num15 << 2;
			object obj18 = obj17 + num16;
			object obj19 = obj13 + 16;
			object obj20 = num15 * 24;
			object obj21 = obj19 + obj20;
			obj2 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v41+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v41+10]");
			_ = 0;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
			_ = 0;
			transform2.localPosition = (Vector3)obj18;
			obj7 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj3 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			object obj22 = obj3 - obj4;
			float num17 = num13 + (float)obj22;
			float num18 = num17 + (float)obj;
			obj7 = num18;
			transform = (Transform)obj7;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			float num19 = (float)transform * 2f;
			float num20 = num13 + num19;
			float num21 = num20 + padding;
			int num22 = num12 + 1;
			num12 = num22;
			num13 = num21;
		}
		return num10;
	}

	private static float AlignChildrenHorizontally(Transform[] children, float padding, Transform parent, bool leftAligned)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static float CenterChildrenVertically(Transform t, float padding)
	{
		//IL_007e: Expected I4, but got Obj
		int siblingIndex = t.GetSiblingIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Sprite sprite = null;
		int siblingIndex2 = t.GetSiblingIndex();
		if ((nint)sprite < siblingIndex2)
		{
			bool flag = ((SpriteAtlas)(object)t).CanBindTo(sprite);
			throw new ArrayTypeMismatchException();
		}
		Transform t2 = default;
		return AlignChildrenHorizontally(t2, padding, (byte)(int)t != 0);
	}

	private static float CenterChildrenVertically(Transform[] children, float padding, Transform parent)
	{
		//IL_0082: Expected I4, but got Obj
		int siblingIndex = ((Transform)(object)children).GetSiblingIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Sprite sprite = null;
		int siblingIndex2 = ((Transform)(object)children).GetSiblingIndex();
		if ((nint)sprite < siblingIndex2)
		{
			bool flag = ((SpriteAtlas)(object)children).CanBindTo(sprite);
			throw new ArrayTypeMismatchException();
		}
		Transform[] children2 = default;
		return AlignChildrenVertically(children2, padding, (Transform)(object)children, (byte)(int)parent != 0);
	}

	public static float AlignChildrenVertically(Transform t, float padding, bool downAlign)
	{
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0448: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_046b: Expected Obj, but got I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_04a0: Expected I4, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_02a4: Expected VT, but got Obj
		//IL_00a0: Expected Obj, but got I4
		//IL_00a0: Expected VT, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I
		object obj = default;
		Transform transform = (Transform)(obj + 136);
		object obj2 = obj + 48;
		Transform transform2 = (Transform)(obj + 36);
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		object obj5 = obj + 112;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj + 88;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj + 72;
		obj7 = 0;
		_ = 0;
		object obj8 = t + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector((int)obj8);
		int num = default;
		object obj12 = default;
		float num4 = default;
		float num5 = default;
		int num6 = default;
		while (num < (nint)obj8)
		{
			object obj9 = t + 16;
			int num2 = num << 2;
			object obj10 = obj9 + num2;
			string tag = ((Component)obj10).tag;
			if (((GameObject)(object)tag).activeInHierarchy)
			{
				Vector3 vector = NGUIMath.WorldToLocalPoint((Vector3)downAlign, (Camera)obj10, null, (Transform)1);
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
				_ = 0;
				transform = (Transform)obj2;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
				_ = 0;
				object obj11 = obj12 + 16;
				object obj13 = num * 24;
				object obj14 = obj11 + obj13;
				obj14 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
				float num3 = 0f * 2f;
				num4 = num5 + num3;
				list.Add(num);
			}
			num = num6 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v34 (System.Collections.Generic.List`1<System.Int32>)+C]");
		object obj15 = -1;
		float num7 = (float)obj15 * padding;
		float num8 = num4 + num7;
		float num9 = num8 * 0.5f;
		int num10 = 0;
		float num11 = num9;
		while (true)
		{
			int num12 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v34 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num12 >= (nint)0)
			{
				break;
			}
			object obj16 = t + 16;
			int num13 = list.get_Item(num10);
			int num14 = num13 << 2;
			object obj17 = obj16 + num14;
			object obj18 = obj12 + 16;
			object obj19 = num13 * 24;
			object obj20 = obj18 + obj19;
			obj2 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v41+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v41+10]");
			_ = 0;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
			_ = 0;
			transform2.localPosition = (Vector3)obj17;
			obj7 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+4]");
			object obj21 = num15 - 0;
			float num16 = num11 - (float)obj21;
			float num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num18 = num17 - 0f;
			transform = (Transform)obj7;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
			float num19 = 0f * 2f;
			float num20 = num11 - num19;
			float num21 = num20 - padding;
			int num22 = num10 + 1;
			num10 = num22;
			num11 = num21;
		}
		return num8;
	}

	private static float AlignChildrenVertically(Transform[] children, float padding, Transform parent, bool downAlign)
	{
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_043e: Expected Obj, but got I4
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0461: Expected Obj, but got I4
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_0503: Expected I, but got Obj
		//IL_0519: Expected Obj, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_0362: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I4
		//IL_0219: Expected VT, but got Obj
		//IL_024c: Expected VT, but got Obj
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_0087: Expected VT, but got Obj
		//IL_00ba: Expected VT, but got Obj
		//IL_02c4: Expected Obj, but got F4
		//IL_012f: Expected Obj, but got F4
		object obj = default;
		Transform transform = (Transform)(obj + 152);
		object obj2 = obj + 48;
		Transform transform2 = (Transform)(obj + 36);
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		object obj5 = obj + 128;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj + 112;
		obj6 = 0;
		_ = 0;
		object obj7 = obj + 88;
		obj7 = 0;
		_ = 0;
		_ = 0;
		object obj8 = obj + 72;
		obj8 = 0;
		_ = 0;
		object obj9 = children + 12;
		float num2 = default;
		if (downAlign)
		{
			object obj10 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj11 = children + 16;
				object obj12 = obj10 << 2;
				object obj13 = obj11 + obj12;
				string tag = ((Component)obj13).tag;
				if (((GameObject)(object)tag).activeInHierarchy)
				{
					Vector3 vector = NGUIMath.WorldToLocalPoint((Vector3)parent, (Camera)obj13, null, (Transform)1);
					obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
					_ = 0;
					transform2.localPosition = (Vector3)obj13;
					obj6 = transform2;
					_ = ((UnityEngine.Object)transform2).m_CachedPtr;
					obj3 = transform2;
					_ = ((UnityEngine.Object)transform2).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
					object obj14 = obj3 - obj4;
					float num = num2 + (float)obj14;
					float num3 = num + (float)obj;
					obj6 = num3;
					transform = (Transform)obj6;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = transform.eulerAngles;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
					float num4 = (float)transform * 2f;
					float num5 = num2 + num4;
					float num6 = num5 + padding;
					num2 = num6;
				}
				object obj15 = obj10 + 1;
				obj10 = obj15;
			}
		}
		else
		{
			object obj16 = obj9 - 1;
			object obj17 = obj16;
			while ((nint)obj17 >= 0)
			{
				object obj18 = children + 16;
				object obj19 = obj17 << 2;
				object obj20 = obj18 + obj19;
				string tag2 = ((Component)obj20).tag;
				if (((GameObject)(object)tag2).activeInHierarchy)
				{
					Vector3 vector2 = NGUIMath.WorldToLocalPoint((Vector3)parent, (Camera)obj20, null, (Transform)1);
					obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
					_ = 0;
					transform2.localPosition = (Vector3)obj20;
					obj8 = transform2;
					_ = ((UnityEngine.Object)transform2).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					obj = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30+8]");
					_ = 0;
					object obj21 = obj3 + obj4;
					float num7 = num2 - (float)obj21;
					float num8 = num7 + (float)obj;
					obj8 = num8;
					transform = (Transform)obj8;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = transform.eulerAngles;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
					float num9 = (float)transform * 2f;
					float num10 = num2 - num9;
					float num11 = num10 - padding;
					num2 = num11;
				}
				object obj22 = obj17 - 1;
				obj17 = obj22;
			}
		}
		float num12 = 0f - padding;
		float num13 = ((!downAlign) ? padding : num12);
		float value = num2 + num13;
		nint num14 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v68 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num15 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v73 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Math.Abs(value);
	}

	public static void SizeWidgetToChildren(UIWidget w)
	{
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02bc: Expected Obj, but got I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d9: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01f9: Expected VT, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got F4
		//IL_004d: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_0158: Expected I, but got Obj
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 56);
		object obj = transform2 + 40;
		obj = 0;
		_ = 0;
		object obj2 = transform2 + 16;
		obj2 = 0;
		_ = 0;
		_ = 0;
		object obj3 = 0;
		Sprite sprite = default;
		float num2 = default;
		float num5 = default;
		Sprite sprite2 = default;
		while (true)
		{
			GameObject gameObject = w.gameObject;
			int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			GameObject gameObject2 = w.gameObject;
			bool flag = ((SpriteAtlas)(object)gameObject2).CanBindTo(sprite);
			bool flag2 = (object)((UIRect)w).mGo != null;
			Transform content = (Transform)((flag2 ? 1 : 0) ^ 1);
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds((Transform)flag, content);
			obj2 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+10]");
			_ = 0;
			string tag = ((Component)flag).tag;
			if (((GameObject)(object)tag).activeInHierarchy || (object)((UIRect)w).mGo == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
				float num = (float)transform * 2f;
				num2 += num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v49 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				num5 = 0f * 2f;
				if (!(num5 > num5))
				{
					continue;
				}
				object obj5 = obj3 + 1;
				obj3 = obj5;
			}
			sprite = (Sprite)(sprite2 + 1);
		}
		object obj6 = obj3 - 1;
		object obj7 = w + 36;
		object obj8 = obj6 * obj7;
		float num6 = (float)obj8 * 2f;
		float num7 = num2 + num6;
		GameObject gameObject3 = w.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		float num8 = num7 * -0.5f;
		object obj9 = w + 36;
		float num9 = num8 - (float)obj9;
		obj = num9;
		float num10 = num5 * 0.5f;
		GameObject gameObject4 = w.gameObject;
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private unsafe static void EncapsulateViewportVertices(Vector3[] vertices, Transform transform, ref Bounds bounds, ref bool init, Camera modelCamera)
	{
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_06f0: Expected Obj, but got I4
		//IL_0704: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected VT, but got Unknown
		//IL_092a: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0177: Expected F4, but got Obj
		//IL_0172: Expected native int or pointer, but got VT
		//IL_018c: Expected F4, but got I
		//IL_0187: Expected native int or pointer, but got VT
		//IL_0199: Expected Obj, but got F4
		//IL_0745: Expected I, but got Obj
		//IL_075b: Expected Obj, but got I
		//IL_0957: Expected Obj, but got Ref
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01c3: Expected F4, but got Obj
		//IL_01be: Expected native int or pointer, but got VT
		//IL_01d8: Expected F4, but got I
		//IL_01d3: Expected native int or pointer, but got VT
		//IL_01e5: Expected Obj, but got F4
		//IL_0786: Expected I, but got Obj
		//IL_079c: Expected Obj, but got I
		//IL_03f3: Expected I, but got Obj
		//IL_097e: Expected Obj, but got Ref
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020f: Expected F4, but got Obj
		//IL_020a: Expected native int or pointer, but got VT
		//IL_0224: Expected F4, but got I
		//IL_021f: Expected native int or pointer, but got VT
		//IL_0231: Expected Obj, but got F4
		//IL_07d8: Expected F4, but got Obj
		//IL_07d3: Expected native int or pointer, but got VT
		//IL_07ed: Expected F4, but got I
		//IL_07e8: Expected native int or pointer, but got VT
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0849: Expected VT, but got Obj
		//IL_04ed: Expected I, but got Obj
		//IL_045f: Expected I, but got Obj
		//IL_0475: Expected Obj, but got I
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_0601: Expected VT, but got Obj
		//IL_07c2: Expected Obj, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_025b: Expected F4, but got Obj
		//IL_0256: Expected native int or pointer, but got VT
		//IL_0270: Expected F4, but got I
		//IL_026b: Expected native int or pointer, but got VT
		//IL_027d: Expected Obj, but got F4
		//IL_0614: Expected I, but got Obj
		//IL_062a: Expected Obj, but got I
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_04a0: Expected I, but got Obj
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08b4: Expected VT, but got Obj
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_08db: Expected F4, but got Obj
		//IL_08d6: Expected native int or pointer, but got VT
		//IL_08f0: Expected F4, but got I
		//IL_08eb: Expected native int or pointer, but got VT
		//IL_0857: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got F4
		//IL_06b6: Expected F4, but got Obj
		//IL_06b1: Expected native int or pointer, but got VT
		//IL_06cb: Expected F4, but got I
		//IL_06c6: Expected native int or pointer, but got VT
		//IL_06d4: Expected Obj, but got VT
		//IL_0655: Expected I, but got Obj
		//IL_059a: Expected I, but got Obj
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02d0: Expected F4, but got Obj
		//IL_02cb: Expected native int or pointer, but got VT
		//IL_02e5: Expected F4, but got I
		//IL_02e0: Expected native int or pointer, but got VT
		//IL_02f2: Expected Obj, but got F4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_031c: Expected F4, but got Obj
		//IL_0317: Expected native int or pointer, but got VT
		//IL_0331: Expected F4, but got I
		//IL_032c: Expected native int or pointer, but got VT
		//IL_033e: Expected Obj, but got F4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_0368: Expected F4, but got Obj
		//IL_0363: Expected native int or pointer, but got VT
		//IL_037d: Expected F4, but got I
		//IL_0378: Expected native int or pointer, but got VT
		//IL_038a: Expected Obj, but got F4
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03b4: Expected F4, but got Obj
		//IL_03af: Expected native int or pointer, but got VT
		//IL_03c9: Expected F4, but got I
		//IL_03c4: Expected native int or pointer, but got VT
		//IL_03d6: Expected Obj, but got F4
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v132 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 72);
		Vector3 one = Vector3.one;
		obj = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj5 = default;
		if ((object)modelCamera != null)
		{
			object obj7 = default;
			if ((nint)modelCamera != 1)
			{
				if ((nint)modelCamera != 2)
				{
					if ((nint)modelCamera != 3)
					{
						if ((nint)modelCamera != 4)
						{
							if ((nint)modelCamera != 5)
							{
								if ((nint)modelCamera != 6)
								{
									if ((nint)modelCamera != 7)
									{
										if ((nint)modelCamera == 8)
										{
											object obj4 = obj5 + 52;
											((Vector3*)(nint)vector)->x = (float)obj4;
											Vector3 vector2 = vector;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S1_v154+8]");
											((Vector3*)(nint)vector2)->z = 0f;
											obj = vector.x;
											_ = vector.z;
										}
									}
									else
									{
										object obj6 = obj7 + 52;
										((Vector3*)(nint)vector)->x = (float)obj6;
										Vector3 vector3 = vector;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v145+8]");
										((Vector3*)(nint)vector3)->z = 0f;
										obj = vector.x;
										_ = vector.z;
									}
								}
								else
								{
									object obj8 = obj5 + 28;
									((Vector3*)(nint)vector)->x = (float)obj8;
									Vector3 vector4 = vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v136+8]");
									((Vector3*)(nint)vector4)->z = 0f;
									obj = vector.x;
									_ = vector.z;
								}
							}
							else
							{
								object obj9 = obj7 + 40;
								((Vector3*)(nint)vector)->x = (float)obj9;
								Vector3 vector5 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v127+8]");
								((Vector3*)(nint)vector5)->z = 0f;
								obj = vector.x;
								_ = vector.z;
							}
						}
						else
						{
							Vector4 drawingDimensions = ((UIWidget)(object)transform).drawingDimensions;
							obj = vector.x;
							_ = vector.z;
						}
					}
					else
					{
						object obj10 = obj7 + 16;
						((Vector3*)(nint)vector)->x = (float)obj10;
						Vector3 vector6 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v113+8]");
						((Vector3*)(nint)vector6)->z = 0f;
						obj = vector.x;
						_ = vector.z;
					}
				}
				else
				{
					object obj11 = obj5 + 40;
					((Vector3*)(nint)vector)->x = (float)obj11;
					Vector3 vector7 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v104+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					obj = vector.x;
					_ = vector.z;
				}
			}
			else
			{
				object obj12 = obj7 + 28;
				((Vector3*)(nint)vector)->x = (float)obj12;
				Vector3 vector8 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v95+8]");
				((Vector3*)(nint)vector8)->z = 0f;
				obj = vector.x;
				_ = vector.z;
			}
		}
		else
		{
			object obj13 = obj5 + 28;
			((Vector3*)(nint)vector)->x = (float)obj13;
			Vector3 vector9 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v86+8]");
			((Vector3*)(nint)vector9)->z = 0f;
			obj = vector.x;
			_ = vector.z;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref bool reference = default;
		string typeName = default;
		if ((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != null)
		{
			string tag = transform.tag;
			bool activeSelf = ((GameObject)(object)tag).activeSelf;
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v76 (Il2CppClass<NGUITools>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v81 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v85 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Bounds reference2 = default;
		string typeName2 = default;
		if ((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != null)
		{
			string tag2 = ((Component)(object)vertices).tag;
			bool activeSelf2 = ((GameObject)(object)tag2).activeSelf;
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v64 (Il2CppClass<NGUITools>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v69 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			typeName2 = NGUITools.GetTypeName((UnityEngine.Object)activeSelf2);
		}
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		object obj18 = obj2 + 48;
		Vector3 vector11 = ((Camera)(object)typeName).WorldToViewportPoint(vector);
		obj = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v45+8]");
		_ = 0;
		Transform transform2 = (Transform)(obj2 + 36);
		GameObject gameObject = ((Component)(object)typeName).gameObject;
		transform2.position = (Vector3)gameObject;
		Transform transform3 = (Transform)(obj2 + 24);
		GameObject gameObject2 = ((Component)(object)typeName2).gameObject;
		transform3.position = (Vector3)gameObject2;
		nint num11 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v57 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num12 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v77 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = (float)(nint)((UnityEngine.Object)transform2).m_CachedPtr - (float)(nint)((UnityEngine.Object)transform3).m_CachedPtr;
		float num13 = Math.Abs(value);
		object obj20 = obj + 8;
		Transform transform4 = (Transform)(obj2 + 12);
		transform4.position = (Vector3)vertices;
		object obj21 = obj20 + (nint)((UnityEngine.Object)transform4).m_CachedPtr;
		obj20 = obj21;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		Vector3 vector13 = ((Camera)(object)typeName2).ScreenToViewportPoint(vector);
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector14 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
	}

	public static Bounds CalculateViewportBounds(Transform t, Camera modelCamera)
	{
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a0e: Expected Obj, but got I4
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a2b: Expected Obj, but got I4
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a48: Expected Obj, but got I4
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Obj, but got Unknown
		//IL_0a65: Expected Obj, but got I4
		//IL_0a74: Expected Obj, but got VT
		//IL_0a8e: Expected Obj, but got I
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected Obj, but got Unknown
		//IL_0ae4: Expected VT, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0064: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Expected Obj, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got F4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_00a5: Expected I, but got Obj
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_019b: Expected I4, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_0bf2: Expected I, but got Obj
		//IL_0c08: Expected Obj, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_0c2e: Expected Obj, but got I4
		//IL_0c3b: Expected Obj, but got VT
		//IL_0439: Expected Obj, but got I4
		//IL_03f1: Expected I, but got Obj
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0469: Expected VT, but got Obj
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_025c: Expected VT, but got Obj
		//IL_047c: Expected I, but got Obj
		//IL_0492: Expected Obj, but got I
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected Obj, but got Unknown
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected Obj, but got Unknown
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_06ee: Expected VT, but got Obj
		//IL_06f7: Expected Obj, but got I4
		//IL_0720: Expected I, but got F4
		//IL_0747: Expected VT, but got Obj
		//IL_04bd: Expected I, but got Obj
		//IL_0b60: Invalid comparison between I and F4
		//IL_02b9: Expected I, but got Obj
		//IL_076a: Expected VT, but got Obj
		//IL_0509: Expected VT, but got Obj
		//IL_0512: Expected Obj, but got I4
		//IL_0543: Expected I, but got F4
		//IL_056a: Expected VT, but got Obj
		//IL_0305: Invalid comparison between I and F4
		//IL_0778: Expected Obj, but got I4
		//IL_07bb: Expected VT, but got Obj
		//IL_07cf: Expected Obj, but got I
		//IL_058d: Expected VT, but got Obj
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got Unknown
		//IL_0b9e: Expected Obj, but got I4
		//IL_02f8: Expected F4, but got I
		//IL_07ea: Expected Obj, but got I4
		//IL_082c: Expected VT, but got Obj
		//IL_059b: Expected Obj, but got I4
		//IL_05e6: Expected VT, but got Obj
		//IL_032c: Expected F4, but got I
		//IL_084b: Expected Obj, but got I4
		//IL_088d: Expected VT, but got Obj
		//IL_08a1: Expected Obj, but got I
		//IL_08b1: Expected Obj, but got I
		//IL_08c1: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got F4
		//IL_0657: Expected VT, but got Obj
		//IL_0d03: Expected I, but got Obj
		//IL_0d19: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I4
		//IL_0684: Expected Obj, but got F4
		//IL_06c0: Expected VT, but got Obj
		//IL_0dff: Expected I, but got Obj
		//IL_0e15: Expected Obj, but got I
		//IL_0d96: Expected VT, but got Obj
		//IL_08d4: Expected I, but got Obj
		//IL_0987: Expected Obj, but got VT
		//IL_0921: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 180;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 168;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 156;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 144;
		obj5 = 0;
		_ = 0;
		Bounds bounds = default;
		string tag = ((Component)bounds).tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v192 @ S3_v50 (should have been resolved before IL gen)");
		Transform transform = (Transform)(obj2 + 132);
		GameObject gameObject = t.gameObject;
		transform.position = (Vector3)gameObject;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Transform transform2 = (Transform)(obj2 + 120);
		transform2.position = (Vector3)bounds;
		obj3 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Camera anchorCamera = ((UIRect)(object)t).anchorCamera;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v238 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 108;
		Vector3 one = Vector3.one;
		Transform transform3 = (Transform)(obj2 + 192);
		transform3 = (Transform)obj11;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v37+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform3.localPosition;
		Transform transform5 = (Transform)(obj2 + 96);
		transform5.position = (Vector3)bounds;
		object obj12 = obj2 + 84;
		obj12 = 0;
		_ = 0;
		obj12 = 0f;
		_ = 0f;
		_ = ((UnityEngine.Object)transform5).m_CachedPtr;
		transform3 = (Transform)obj12;
		Transform transform6 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v38+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition2 = transform3.localPosition;
		object obj14 = default;
		object obj13 = obj14 + 12;
		float num4 = float.MaxValue;
		float num5 = float.MinValue;
		object obj15 = default;
		object obj25 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj16 = obj14 + 16;
			object obj17 = obj15 << 2;
			object obj18 = obj16 + obj17;
			bool flag = GraphicsFormatUtility.IsSRGBFormat((GraphicsFormat)obj18);
			Vector3[] normals = ((Mesh)flag).normals;
			object obj19 = normals + 12;
			object obj20 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
			{
				object obj21 = normals + 16;
				object obj22 = obj20 * 12;
				object obj23 = obj21 + obj22;
				transform = (Transform)obj23;
				Transform transform7 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v207+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				obj4 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				GameObject gameObject2 = ((Component)obj18).gameObject;
				transform3 = (Transform)obj4;
				Transform transform8 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				localPosition2 = ((Transform)(object)gameObject2).InverseTransformPoint((Vector3)transform3);
				obj5 = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				nint num6;
				if ((object)modelCamera != null)
				{
					transform3 = (Transform)obj5;
					Transform transform9 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
					((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
					num6 = (nint)transform3;
				}
				else
				{
					transform3 = (Transform)obj5;
					Transform transform10 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
					((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v39 (UnityEngine.Transform)+4]");
					num6 = 0;
				}
				if ((float)num6 < num4)
				{
					num4 = num6;
				}
				else if ((float)num6 > num5)
				{
					num5 = num6;
				}
				object obj24 = obj20 + 1;
				obj20 = obj24;
				obj9 = 0;
			}
			obj15 = obj25 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj27 = default;
		object obj26 = obj27 + 16;
		object obj30;
		object obj31;
		if ((object)modelCamera != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj29 = default;
			object obj28 = obj29 + 40;
			obj30 = obj28;
			obj31 = obj26;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj33 = default;
			object obj32 = obj33 + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v156+4]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v55+4]");
			obj31 = 0;
		}
		Transform cachedTransform = ((UIRect)(object)t).cachedTransform;
		bool activeSelf = ((GameObject)(object)cachedTransform).activeSelf;
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v65 (Il2CppClass<NGUITools>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v187 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		string tag2 = ((Component)bounds).tag;
		bool activeSelf2 = ((GameObject)(object)tag2).activeSelf;
		string typeName2 = NGUITools.GetTypeName((UnityEngine.Object)activeSelf2);
		transform3.position = (Vector3)bounds;
		GameObject gameObject3 = ((Component)(object)typeName2).gameObject;
		transform.position = (Vector3)gameObject3;
		nint num9 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S2_v25 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S2_v109 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj36 = obj2 + 72;
		Transform transform11 = (Transform)(obj2 + 60);
		object obj37 = obj2 + 48;
		object obj38 = obj2 + 36;
		Transform transform12 = (Transform)(obj2 + 24);
		object obj39 = obj2 + 12;
		float value = (float)(nint)((UnityEngine.Object)transform3).m_CachedPtr - (float)(nint)((UnityEngine.Object)transform).m_CachedPtr;
		float num11 = Math.Abs(value);
		Camera anchorCamera2 = ((UIRect)(object)t).anchorCamera;
		object obj40;
		object obj41;
		object obj42;
		object obj43;
		if ((object)modelCamera != null)
		{
			transform.position = (Vector3)anchorCamera2;
			transform2 = (Transform)0;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			transform2 = (Transform)obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (UnityEngine.Transform)+4]");
			_ = 0;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0f;
			transform3 = transform2;
			((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			Vector3 vector = ((Camera)(object)typeName).WorldToViewportPoint((Vector3)transform3);
			Camera anchorCamera3 = ((UIRect)(object)t).anchorCamera;
			transform5.position = (Vector3)anchorCamera3;
			obj12 = 0;
			_ = 0;
			obj12 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v34 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = 0f;
			transform3 = (Transform)obj12;
			Transform transform13 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v38+8]");
			((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
			Vector3 vector2 = ((Camera)(object)typeName).WorldToViewportPoint((Vector3)transform3);
			obj40 = obj36;
			transform11.position = (Vector3)bounds;
			obj37 = 0;
			_ = 0;
			obj37 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S2_v32 (UnityEngine.Transform)+4]");
			_ = 0;
			transform3 = (Transform)obj37;
			Transform transform14 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S2_v34+8]");
			((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
			Vector3 vector3 = ((Camera)(object)typeName2).WorldToViewportPoint((Vector3)transform3);
			transform12.position = (Vector3)bounds;
			obj39 = 0;
			_ = 0;
			obj39 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S2_v38 (UnityEngine.Transform)+4]");
			_ = 0;
			transform3 = (Transform)obj39;
			Transform transform15 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S2_v40+8]");
			((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
			Vector3 vector4 = ((Camera)(object)typeName2).WorldToViewportPoint((Vector3)transform3);
			obj41 = obj2;
			obj42 = obj11;
			obj43 = obj38;
		}
		else
		{
			transform.position = (Vector3)anchorCamera2;
			transform2 = (Transform)0;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			transform2 = transform;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0f;
			transform3 = transform2;
			((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			Vector3 vector5 = ((Camera)(object)typeName).WorldToViewportPoint((Vector3)transform3);
			Camera anchorCamera4 = ((UIRect)(object)t).anchorCamera;
			transform5.position = (Vector3)anchorCamera4;
			obj12 = 0;
			_ = 0;
			obj12 = transform5;
			_ = 0f;
			transform3 = (Transform)obj12;
			Transform transform16 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v38+8]");
			((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
			Vector3 vector6 = ((Camera)(object)typeName).WorldToViewportPoint((Vector3)transform3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S2_v30+4]");
			obj40 = 0;
			transform11.position = (Vector3)bounds;
			obj37 = 0;
			_ = 0;
			obj37 = transform11;
			transform3 = (Transform)obj37;
			Transform transform17 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S2_v34+8]");
			((UnityEngine.Object)transform17).m_CachedPtr = (IntPtr)0;
			Vector3 vector7 = ((Camera)(object)typeName2).WorldToViewportPoint((Vector3)transform3);
			transform12.position = (Vector3)bounds;
			obj39 = 0;
			_ = 0;
			obj39 = transform12;
			transform3 = (Transform)obj39;
			Transform transform18 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S2_v40+8]");
			((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
			Vector3 vector8 = ((Camera)(object)typeName2).WorldToViewportPoint((Vector3)transform3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v37+4]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S2_v36+4]");
			obj43 = 0;
		}
		nint num12 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ S1_v80 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj44 = (nint)0 & (nint)0x200;
		if (obj44 != null)
		{
			nint num13 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S1_v107 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value2 = (float)obj40 - (float)obj42;
		float value3 = (float)obj43 - (float)obj41;
		transform.localScale = (Vector3)bounds;
		nint num14 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ S0_v80 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj45 = (nint)0 & (nint)0x200;
		if (obj45 != null)
		{
			nint num15 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform3 = transform;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		float num16 = Math.Abs(value2);
		float num17 = Math.Abs(value3);
		float num18 = num16 / num17;
		float num19 = num18 * 0.5f;
		Vector3 vector9 = (Vector3)transform3 / num19;
		transform3 = transform2;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Transform)bounds).parent = transform3;
		transform3 = (Transform)obj3;
		Transform transform19 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)transform19).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition3 = transform3.localPosition;
		Camera anchorCamera5 = ((UIRect)(object)t).anchorCamera;
		transform3 = (Transform)obj;
		Transform transform20 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform20).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition4 = transform3.localPosition;
		return bounds;
	}

	public unsafe static void CenterInViewport(Transform t, Camera modelCamera, Vector2 offset)
	{
		//IL_0268: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Ref, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Ref, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got VT
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got VT
		//IL_019c: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got VT
		ref Bounds reference = ref *(Bounds*)null;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		ref bool reference2 = ref System.Runtime.CompilerServices.Unsafe.As<Bounds, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
		reference2 = ref *(bool*)null;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		ref bool reference3 = ref *(bool*)(obj3 + 22691);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S3_v13 (System.Boolean&) (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 + 12;
		object obj6 = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj7 = obj5 + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			string tag = ((Component)obj9).tag;
			if (((GameObject)(object)tag).activeInHierarchy)
			{
				Mesh mesh = ((MeshFilter)obj9).mesh;
				Vector3[] normals = mesh.normals;
				GameObject gameObject = ((Component)obj9).gameObject;
				EncapsulateScreenVertices(normals, (Transform)(object)gameObject, ref reference, ref reference2, (Camera)offset);
			}
			obj6 = obj10 + 1;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v7 (Il2CppMethodInfo)+18]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x1FFF;
		ref bool reference4 = ref *(bool*)(obj13 + 22691);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S3_v11 (System.Boolean&) (should have been resolved before IL gen)");
		object obj15 = default;
		object obj14 = obj15 + 12;
		object obj16 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
		{
			object obj17 = obj15 + 16;
			object obj18 = obj16 << 2;
			object obj19 = obj17 + obj18;
			string tag2 = ((Component)obj19).tag;
			if (((GameObject)(object)tag2).activeInHierarchy)
			{
				int blendShapeCount = ((Mesh)obj19).blendShapeCount;
				Vector3[] normals2 = ((Mesh)blendShapeCount).normals;
				GameObject gameObject2 = ((Component)obj19).gameObject;
				EncapsulateScreenVertices(normals2, (Transform)(object)gameObject2, ref reference, ref reference2, (Camera)offset);
			}
			object obj20 = obj16 + 1;
			obj16 = obj20;
		}
		Transform transform = (Transform)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Bounds&)+8]");
		((UnityEngine.Object)t).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Bounds&)+10]");
		_ = 0;
	}

	public static void CenterInViewport(Transform t, Camera modelCamera)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0168: Expected VT, but got Obj
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform.position = (Vector3)modelCamera;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		Renderer renderer = (Renderer)(obj2 + 48);
		renderer = (Renderer)(object)transform;
		((UnityEngine.Object)renderer).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj4 = obj2 + 72;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		string tag = modelCamera.tag;
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((GameObject)(object)tag).GetComponentsInParent<T>(true);
		object obj5 = componentsInParent + 12;
		object obj6 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj7 = componentsInParent + 16;
			object obj8 = obj6 << 2;
			object material = obj7 + obj8;
			renderer.SetMaterial((Material)material);
			obj4 = renderer;
			_ = ((UnityEngine.Object)renderer).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (UnityEngine.Renderer)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B8");
			object obj9 = obj6 + 1;
			obj6 = obj9;
		}
		Transform transform2 = (Transform)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)t).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
	}

	private unsafe static void EncapsulateScreenVertices(Vector3[] vertices, Transform transform, ref Bounds bounds, ref bool init, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00b3: Expected F4, but got Obj
		//IL_00ae: Expected native int or pointer, but got VT
		//IL_00c8: Expected F4, but got I
		//IL_00c3: Expected native int or pointer, but got VT
		//IL_00e6: Expected F4, but got Obj
		//IL_00e1: Expected native int or pointer, but got VT
		//IL_00fb: Expected F4, but got I
		//IL_00f6: Expected native int or pointer, but got VT
		//IL_01bf: Expected F4, but got Obj
		//IL_01ba: Expected native int or pointer, but got VT
		//IL_01d4: Expected F4, but got I
		//IL_01cf: Expected native int or pointer, but got VT
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_015b: Expected F4, but got Obj
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0170: Expected F4, but got I
		//IL_016b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		object obj2 = obj + 48;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
		object obj5 = obj + 24;
		obj5 = 0;
		_ = 0;
		object obj6 = vertices + 12;
		object obj7 = default;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj8 = vertices + 16;
			object obj9 = obj7 * 12;
			object obj10 = obj8 + obj9;
			obj2 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v15+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = transform.InverseTransformPoint(vector);
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = modelCamera.ViewportToWorldPoint(vector);
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			_ = 0f;
			if (init)
			{
				((Vector3*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
			}
			else
			{
				ref bool reference = ref *(bool*)1;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				_ = 0;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AE");
			}
			obj7 = obj11 + 1;
		}
	}

	public unsafe static Bounds CalculateScreenBounds(Transform t, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got F4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected VT, but got Unknown
		//IL_00ea: Expected F4, but got Obj
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0130: Expected F4, but got Obj
		//IL_012b: Expected native int or pointer, but got VT
		//IL_0145: Expected F4, but got I
		//IL_0140: Expected native int or pointer, but got VT
		//IL_014e: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 8;
		obj = modelCamera;
		obj2 = modelCamera;
		float farClipPlane = ((Camera)(object)t).farClipPlane;
		float fieldOfView = ((Camera)(object)t).fieldOfView;
		float farClipPlane2 = ((Camera)(object)t).farClipPlane;
		object obj3 = obj2 + 28;
		obj3 = 0;
		_ = 0;
		float num = 0.5f + (float)obj;
		obj3 = num;
		float num2 = 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		float num3 = num2 + 0f;
		float num4 = fieldOfView - farClipPlane2;
		float num5 = num4 * 0.5f;
		float num6 = farClipPlane + num5;
		Vector3 vector = (Vector3)(obj2 + 40);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj4 = obj2 + 16;
		Vector3 vector2 = ((Camera)(object)t).ScreenToWorldPoint(vector);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
		Bounds result = default;
		return result;
	}

	public static void FitToWidget(Transform t, UIWidget w, Camera modelCamera = null)
	{
		//IL_021d: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_00ab: Expected I4, but got Obj
		//IL_00ab: Expected I4, but got Obj
		//IL_019c: Expected Obj, but got I4
		//IL_01cb: Expected I4, but got Obj
		//IL_01cb: Expected I4, but got Obj
		string text = (string)0;
		text.m_stringLength = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		string text2 = text + 24;
		text2 = (string)0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		string text3 = (string)(obj3 + 22691);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S3_v13 (System.String) (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 + 12;
		object obj6 = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj7 = obj5 + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			string tag = ((Component)obj9).tag;
			if (((GameObject)(object)tag).activeInHierarchy)
			{
				Mesh mesh = ((MeshFilter)obj9).mesh;
				Vector3[] normals = mesh.normals;
				GameObject gameObject = ((Component)obj9).gameObject;
				((AbstractAdProvider)(object)normals).CachedAd((AdType)gameObject, text, text2, (byte)(int)modelCamera != 0);
			}
			obj6 = obj10 + 1;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v7 (Il2CppMethodInfo)+18]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x1FFF;
		string text4 = (string)(obj13 + 22691);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S3_v11 (System.String) (should have been resolved before IL gen)");
		object obj15 = default;
		object obj14 = obj15 + 12;
		object obj16 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
		{
			object obj17 = obj15 + 16;
			object obj18 = obj16 << 2;
			object obj19 = obj17 + obj18;
			string tag2 = ((Component)obj19).tag;
			if (((GameObject)(object)tag2).activeInHierarchy)
			{
				int blendShapeCount = ((Mesh)obj19).blendShapeCount;
				Vector3[] normals2 = ((Mesh)blendShapeCount).normals;
				GameObject gameObject2 = ((Component)obj19).gameObject;
				((AbstractAdProvider)(object)normals2).CachedAd((AdType)gameObject2, text, text2, (byte)(int)modelCamera != 0);
			}
			object obj20 = obj16 + 1;
			obj16 = obj20;
		}
		Transform transform = (Transform)(object)text;
		((UnityEngine.Object)t).m_CachedPtr = (IntPtr)text.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.String)+10]");
		_ = 0;
	}

	public static void FitToWidget(Transform t, UIWidget w, Bounds b, Camera modelCamera = null)
	{
		//IL_0015: Expected Obj, but got VT
		((SocketsRequest)(object)t)._002Ector((string)(object)w, (Uri)b, (byte[])(object)modelCamera);
	}

	public static void FitToWidget(Transform t, Camera modelCamera, UIWidget widget, float zoom = 1f, int passes = 2)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got F4
		//IL_0177: Expected Obj, but got I4
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01cf: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = t;
		UIWidget uIWidget = (UIWidget)zoom;
		Camera camera = (Camera)0;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v38 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 12;
		string host = ((Connection)passes).host;
		obj4 = host;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v12+14]");
		object obj7;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v26+C]");
			obj7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v5+C]");
			obj7 = widget + 0;
		}
		uIWidget = (UIWidget)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23+14]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v35+18]");
			if ((nint)0 == 0)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = obj2;
		camera = (Camera)obj12;
	}

	public static void FitHeightToWidget(Transform t, UIWidget widget, Camera modelCamera = null, float zoom = 1f, int passes = 2)
	{
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_043c: Expected Obj, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_045f: Expected Obj, but got I4
		//IL_0476: Expected Obj, but got F4
		//IL_048a: Expected I, but got F4
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_0397: Expected VT, but got Obj
		//IL_03a5: Expected I, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_069d: Expected VT, but got Obj
		//IL_03e6: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_021f: Expected I, but got Obj
		//IL_026b: Expected VT, but got Obj
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_02ba: Expected I, but got Obj
		//IL_0643: Expected I, but got Obj
		//IL_0659: Expected Obj, but got I
		//IL_06f3: Expected VT, but got Obj
		//IL_034b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)0;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		transform = (Transform)5000f;
		_ = 5000f;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)5000f;
		Transform transform2 = (Transform)(obj2 + 48);
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		t.parent = transform2;
		object obj3 = default;
		object obj9 = default;
		while ((nint)obj3 < passes)
		{
			FitToWidget(transform2, (UIWidget)(object)t, (Camera)(object)widget);
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (UnityEngine.Transform)+10]");
			_ = 0;
			string tag = modelCamera.tag;
			nint num = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v9 (Il2CppClass<UIRoot>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S2_v27 (Il2CppClass<UIRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float pixelSize = ((UISprite)(object)tag).pixelSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			string tag2 = modelCamera.tag;
			float pixelSize2 = ((UISprite)(object)tag2).pixelSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num3 = 0f * 2f;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v56 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v92 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelCamera @ L2 (UnityEngine.Camera)+64]");
			float num6 = 0f / pixelSize;
			float num7 = (float)transform * 2f;
			float num8 = num6 / num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelCamera @ L2 (UnityEngine.Camera)+68]");
			float num9 = 0f / pixelSize2;
			float num10 = num9 / num3;
			if (!(num8 < num10))
			{
				num8 = num10;
			}
			float num11 = num8 * 0.95f;
			float num12 = Math.Abs(num11);
			if (num12 > Mathf.Epsilon)
			{
				nint num13 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v59 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v100 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value = num11 - 1f;
				float num15 = Math.Abs(value);
				if (num15 > 0.01f)
				{
					transform.localScale = (Vector3)t;
					nint num16 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v69 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num17 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v96 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (num11 < 0f)
					{
						num11 = 0f;
					}
					else if (num11 > 2.1474836E+09f)
					{
						num11 = 2.1474836E+09f;
					}
					nint num18 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num19 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v87 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform2 = transform;
					((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
					Vector3 vector = (Vector3)transform2 / num11;
					transform2 = (Transform)obj2;
					Transform transform3 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					t.parent = transform2;
				}
			}
			obj3 = obj9 + 1;
		}
		transform.localScale = (Vector3)t;
		nint num20 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)transform2 / zoom;
		transform2 = (Transform)obj2;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		t.parent = transform2;
	}

	public unsafe static void OffsetToCenter(Transform t)
	{
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected VT, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_044d: Expected Obj, but got I4
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_0071: Expected Obj, but got VT
		//IL_00df: Expected Obj, but got I4
		//IL_0384: Expected VT, but got Obj
		//IL_037f: Expected native int or pointer, but got VT
		//IL_03c0: Expected Obj, but got I
		//IL_03d2: Expected VT, but got Obj
		//IL_03cd: Expected native int or pointer, but got VT
		//IL_03f5: Expected Obj, but got VT
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0170: Expected VT, but got Obj
		//IL_016b: Expected native int or pointer, but got VT
		//IL_0194: Expected VT, but got Obj
		//IL_018f: Expected native int or pointer, but got VT
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got VT
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_056d: Expected VT, but got Obj
		//IL_0568: Expected native int or pointer, but got VT
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0237: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_0259: Expected VT, but got Obj
		//IL_0254: Expected native int or pointer, but got VT
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0302: Expected I, but got Obj
		object obj = default;
		Bounds bounds = (Bounds)(obj + 128);
		object obj2 = obj + 112;
		object obj3 = obj + 12;
		object obj4 = obj + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj + 24;
		obj5 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = t;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S3_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Func<_0021_00210, _0021_00211> func = default;
		object obj12 = func + 16;
		obj12 = obj7;
		IEnumerable<_0021_00210> source2 = default;
		IEnumerable<_0021_00211> source = (IEnumerable<_0021_00211>)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)source2, (Func<TSource, TResult>)(object)func);
		List<_0021_00210> list = (List<_0021_00210>)(object)Enumerable.ToList<TSource>((IEnumerable<TSource>)source);
		object obj13 = list + 12;
		if (obj13 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
		GameObject gameObject = ((Component)0).gameObject;
		Matrix4x4 localToWorldMatrix = ((Transform)(object)gameObject).localToWorldMatrix;
		obj4 = bounds.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj14 = 0;
		object obj20 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = list + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj18 = 0;
			while ((nint)obj18 <= 3)
			{
				object obj19 = obj20 + 16;
				object obj21 = obj18 * 12;
				object obj22 = obj19 + obj21;
				obj2 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v78+8]");
				_ = 0;
				((Bounds*)(nint)bounds)->m_Center = (Vector3)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
				((Bounds*)(nint)bounds)->m_Center = (Vector3)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				object obj23 = obj20 + 16;
				object obj24 = obj18 * 12;
				object obj25 = obj23 + obj24;
				obj25 = bounds.m_Center;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Bounds)+8]");
				_ = 0;
				object obj26 = obj18 | obj14;
				if (obj26 != null)
				{
					object obj27 = obj20 + 16;
					object obj28 = obj18 * 12;
					nint num3 = (nint)(obj27 + obj28);
					obj2 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v120 (Il2CppClass<UnityEngine.Vector3>)+8]");
					_ = 0;
					((Bounds*)(nint)bounds)->m_Center = (Vector3)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
				}
				else
				{
					object obj29 = obj20 + 16;
					object obj30 = obj18 * 12;
					object obj31 = obj29 + obj30;
					obj3 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S1_v103+8]");
					_ = 0;
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v85 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num5 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v95 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 one = Vector3.one;
					obj2 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
				}
				object obj33 = obj18 + 1;
				obj18 = obj33;
			}
			object obj34 = obj14 + 1;
			obj14 = obj34;
		}
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+10]");
		_ = 0;
		int height = BoundsExtensions.GetHeight(bounds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
		((UIWidget)0).height = height;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+10]");
		_ = 0;
		GameObject gameObject2 = GameObjectExtensions.Duplicate((GameObject)bounds);
		Color color = ((UIWidget)(object)gameObject2).color;
	}

	public static void FitWidthToWidget(Transform t, UIWidget widget, Camera modelCamera = null, float zoom = 1f, int passes = 2)
	{
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I4
		//IL_04d6: Expected I, but got Obj
		//IL_04ec: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_053a: Expected Obj, but got I4
		//IL_0551: Expected Obj, but got F4
		//IL_0565: Expected I, but got F4
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0417: Expected VT, but got Obj
		//IL_0425: Expected I, but got Obj
		//IL_043b: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I4
		//IL_075f: Expected VT, but got Obj
		//IL_00c0: Expected I, but got Obj
		//IL_0466: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_060f: Expected I, but got Obj
		//IL_0625: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_0211: Expected I, but got Obj
		//IL_025e: Expected I, but got Obj
		//IL_0274: Expected Obj, but got I
		//IL_029f: Expected I, but got Obj
		//IL_02eb: Expected VT, but got Obj
		//IL_02f9: Expected I, but got Obj
		//IL_030f: Expected Obj, but got I
		//IL_033a: Expected I, but got Obj
		//IL_0705: Expected I, but got Obj
		//IL_071b: Expected Obj, but got I
		//IL_07dc: Expected VT, but got Obj
		//IL_03cb: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera modelCamera2;
		if (modelCamera != null)
		{
			string tag = t.tag;
			bool activeSelf = ((GameObject)(object)tag).activeSelf;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v80 (Il2CppClass<NGUITools>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v85 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
			modelCamera2 = (Camera)(object)typeName;
		}
		else
		{
			modelCamera2 = modelCamera;
		}
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)0;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		transform = (Transform)5000f;
		_ = 5000f;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)5000f;
		Transform transform2 = (Transform)(obj2 + 48);
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		t.parent = transform2;
		object obj5 = default;
		object obj11 = default;
		while ((nint)obj5 < passes)
		{
			FitToWidget(transform2, (UIWidget)(object)t, modelCamera2);
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (UnityEngine.Transform)+10]");
			_ = 0;
			string tag2 = widget.tag;
			nint num5 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v11 (Il2CppClass<UIRoot>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v22 (Il2CppClass<UIRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float pixelSize = ((UISprite)(object)tag2).pixelSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
			float num7 = (float)widget.mHeight / pixelSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v21 (UnityEngine.Transform)+4]");
			float num8 = 0f * 2f;
			float num9 = num7 / num8;
			float num10 = num9 * 0.95f;
			nint num11 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v116 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num13 = Math.Abs(num10);
			if (num13 > Mathf.Epsilon)
			{
				nint num14 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num15 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v112 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value = num10 - 1f;
				float num16 = Math.Abs(value);
				if (num16 > 0.01f)
				{
					transform.localScale = (Vector3)t;
					nint num17 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v81 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num18 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v108 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (num10 < 0f)
					{
						num10 = 0f;
					}
					else if (num10 > 2.1474836E+09f)
					{
						num10 = 2.1474836E+09f;
					}
					nint num19 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v89 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num20 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v99 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform2 = transform;
					((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
					Vector3 vector = (Vector3)transform2 / num10;
					transform2 = (Transform)obj2;
					Transform transform3 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					t.parent = transform2;
				}
			}
			obj5 = obj11 + 1;
		}
		transform.localScale = (Vector3)t;
		nint num21 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num22 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)transform2 / zoom;
		transform2 = (Transform)obj2;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		t.parent = transform2;
	}

	public unsafe static void CenterOnWidget(Transform t, UIWidget widget, Camera modelCamera, Vector2 offset)
	{
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0526: Expected Obj, but got I4
		//IL_053a: Expected I, but got Obj
		//IL_0550: Expected Obj, but got I
		//IL_0733: Expected Obj, but got VT
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected VT, but got Unknown
		//IL_0159: Expected F4, but got Obj
		//IL_0154: Expected native int or pointer, but got VT
		//IL_016e: Expected F4, but got I
		//IL_0169: Expected native int or pointer, but got VT
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_0240: Expected F4, but got Obj
		//IL_023b: Expected native int or pointer, but got VT
		//IL_0255: Expected F4, but got I
		//IL_0250: Expected native int or pointer, but got VT
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0281: Expected F4, but got Obj
		//IL_027c: Expected native int or pointer, but got VT
		//IL_0296: Expected F4, but got I
		//IL_0291: Expected native int or pointer, but got VT
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_030c: Expected I, but got Obj
		//IL_0322: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I4
		//IL_00c0: Expected I, but got Obj
		//IL_076b: Expected I, but got Obj
		//IL_0781: Expected Obj, but got I
		//IL_034d: Expected I, but got Obj
		//IL_03a7: Expected I, but got Obj
		//IL_03f4: Expected I, but got Obj
		//IL_040a: Expected Obj, but got I
		//IL_0435: Expected I, but got Obj
		//IL_0481: Expected VT, but got Obj
		//IL_048f: Expected I, but got Obj
		//IL_04a5: Expected Obj, but got I
		//IL_06d2: Expected F4, but got Obj
		//IL_06cd: Expected native int or pointer, but got VT
		//IL_06e4: Expected F4, but got I
		//IL_06df: Expected native int or pointer, but got VT
		//IL_0702: Expected F4, but got Obj
		//IL_06fd: Expected native int or pointer, but got VT
		//IL_0717: Expected F4, but got I
		//IL_0712: Expected native int or pointer, but got VT
		//IL_0724: Expected Obj, but got VT
		//IL_04d0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 144;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v131 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = default;
		string typeName = default;
		if ((UnityEngine.Object)vector != null)
		{
			string tag = t.tag;
			bool activeSelf = ((GameObject)(object)tag).activeSelf;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v104 (Il2CppClass<NGUITools>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v109 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		}
		Transform transform = (Transform)(obj2 + 132);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj5 = obj2 + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj6 = obj2 + 108;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		object obj7 = obj2 + 96;
		obj7 = 0;
		_ = 0;
		obj7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v24+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v28+8]");
		_ = 0;
		Vector3 vector2 = (Vector3)(obj2 + 156);
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v32+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj8 = obj2 + 84;
		Vector3 vector4 = ((Camera)(object)typeName).WorldToViewportPoint(vector2);
		obj = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v41+8]");
		_ = 0;
		object obj9 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj10 = obj2 + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj11 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		object obj12 = obj2 + 36;
		obj12 = 0;
		_ = 0;
		obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v49+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v53+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj12;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v57+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj13 = obj2 + 24;
		Vector3 vector6 = ((Camera)(object)typeName).WorldToViewportPoint(vector2);
		((Vector3*)(nint)vector2)->x = (float)obj13;
		Vector3 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v65+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		object obj14 = obj2 + 12;
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		float num5 = vector2.x - (float)obj14;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		float num6 = vector2.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		float num7 = num6 - 0f;
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v66 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v97 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num10 = (float)widget.mWidth / num5;
		float num11 = (float)widget.mHeight / num7;
		bool flag = num10 < num11;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		float num12 = num10;
		if (!flag3)
		{
			num12 = num11;
		}
		Transform cachedTransform = widget.cachedTransform;
		nint num13 = (nint)typeof(UIRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v83 (Il2CppClass<UIRoot>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num14 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v122 (Il2CppClass<UIRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float pixelSize = ((UISprite)(object)cachedTransform).pixelSize;
		float num15 = num12 / pixelSize;
		float num16 = Math.Abs(num15);
		if (!(num16 > Mathf.Epsilon))
		{
			return;
		}
		nint num17 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v94 (Il2CppClass<System.Math>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num18 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v118 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = num15 - 1f;
		float num19 = Math.Abs(value);
		if (!(num19 > 0.01f))
		{
			return;
		}
		transform.localScale = (Vector3)t;
		nint num20 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v104 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v114 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector8 = vector2 / num15;
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Vector3 vector9 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v24+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		t.parent = (Transform)vector2;
	}

	public static void CenterOnWidget(Transform t, UIWidget widget, Camera modelCamera)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_005a: Expected VT, but got Obj
		Bounds bounds = CalculateRendererBounds(t);
		object obj = default;
		Camera camera = (Camera)(obj + 24);
		camera = (Camera)obj;
		Camera camera2 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		CenterOnWidget(t, widget, camera, (Vector2)modelCamera);
	}

	public static void CenterOnWidget(Transform t, UIWidget widget)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj2 = default;
		Camera camera = (Camera)(obj2 + 8);
		camera = (Camera)obj2;
		Bounds bounds = CalculateScreenBounds((Transform)(object)widget, camera);
	}
}
