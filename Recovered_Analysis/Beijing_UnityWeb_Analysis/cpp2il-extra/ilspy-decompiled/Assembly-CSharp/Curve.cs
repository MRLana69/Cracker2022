using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Networking;

public class Curve
{
	public AnimationCurve curveX;

	public AnimationCurve curveY = (AnimationCurve)0.1f;

	public AnimationCurve curveZ = (AnimationCurve)0.1f;

	private Vector3 MinCoords__BackingField = (Vector3)0.1f;

	private Vector3 MaxCoords__BackingField;

	private float MinTime__BackingField;

	private float MaxTime__BackingField;

	public Vector3 MinCoords
	{
		get
		{
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected Obj, but got Unknown
			//IL_01b5: Expected Obj, but got VT
			//IL_01c7: Expected I, but got Obj
			//IL_01dd: Expected Obj, but got I
			//IL_001b: Expected Obj, but got I
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0060: Expected Obj, but got I4
			//IL_00cc: Expected I, but got Obj
			//IL_0120: Expected Obj, but got I
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_00a3: Expected Obj, but got I
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			Vector3 vector = default;
			object obj = vector + 20;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+10]");
			if ((nint)0 != 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v5 (Il2CppMethodInfo)+18]");
				object obj2 = 0;
				object obj3 = obj2;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
				object obj7 = default;
				object obj6 = obj7 + 12;
				object obj8 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
				{
					object obj9 = obj7 + 16;
					object obj10 = obj8 << 2;
					object obj11 = obj9 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
					((Renderer)obj11).sharedMaterials = (Material[])0;
					object obj12 = obj8 + 1;
					obj8 = obj12;
				}
			}
			else
			{
				Renderer component = ((Component)vector).GetComponent<Renderer>();
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
					component.sharedMaterials = (Material[])0;
				}
			}
			return vector;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected Obj, but got I
			object obj = value + 20;
			Curve curve = (Curve)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			curveX = (AnimationCurve)0;
		}
	}

	public unsafe Vector3 MaxCoords
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = curveX;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 20);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected Obj, but got I
			object obj = value + 32;
			Curve curve = (Curve)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			curveX = (AnimationCurve)0;
		}
	}

	public float MinTime
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_001d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+68]");
			return 0f;
		}
		private set
		{
		}
	}

	public float MaxTime
	{
		get
		{
			return MinTime__BackingField;
		}
		private set
		{
			MinTime__BackingField = value;
		}
	}

	public Curve()
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0016: Expected Obj, but got F4
		//IL_0021: Expected VT, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void AddKey(float t, Vector3 value)
	{
		//IL_0016: Expected VT, but got F4
		//IL_0029: Expected Obj, but got F4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got VT
		//IL_0046: Expected Obj, but got F4
		//IL_0051: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		if (curveY != null)
		{
			return;
		}
		_ = 1;
		MinCoords__BackingField = (Vector3)0f;
		float maxDelay = NetworkServer.maxDelay;
		curveZ = (AnimationCurve)maxDelay;
		object obj = this + 36;
		obj = value;
		curveX = (AnimationCurve)t;
		curveY = (AnimationCurve)1;
		object obj2 = this + 32;
		Dictionary<string, string> items = ((DebugSettingsCell)this)._items;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)items);
		obj2 = coroutine;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v19 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("CountdownPopup");
	}

	public void AddKey(float t, Vector3 value, Vector3 inTangent, Vector3 outTangent)
	{
		//IL_0008: Expected Obj, but got I
		//IL_001e: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_0129: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		IntPtr intPtr = default;
		object obj = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2+14]");
		object obj2 = (nint)0 & (nint)0x7FFF;
		object obj3 = obj2 + 46824;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v8 @ S1_v5 (should have been resolved before IL gen)");
		object obj4 = this + 4;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v4+3D0]");
		object obj6 = (nint)0 << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12369");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v4+3DC]");
		object obj7 = (nint)0 << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12369");
		object obj8 = obj5 + 996;
		obj8 = 0;
		_ = 0;
		_ = 0;
		object obj9 = obj4 + 1800;
		obj9 = 0;
		object obj10 = obj4 + 1804;
		obj10 = 0;
		object obj11 = obj4 + 1808;
		obj11 = 0;
		object obj12 = obj4 + 1876;
		obj12 = 0;
		object obj13 = obj4 + 1872;
		obj13 = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v2 (Il2CppClass<Curve>)+7C]");
		object obj14 = (nint)0 & (nint)0x3F;
		object obj15 = obj14 + 80416;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S4_v5 (should have been resolved before IL gen)");
	}

	public void MoveKey(int index, float t, Vector3 value, Vector3 inTangent, Vector3 outTangent)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void MoveKey(int index, float t, Vector3 value)
	{
		//IL_2160: Unknown result type (might be due to invalid IL or missing references)
		//IL_2165: Expected Obj, but got Unknown
		//IL_216e: Expected Obj, but got I4
		//IL_2786: Unknown result type (might be due to invalid IL or missing references)
		//IL_278b: Expected Obj, but got Unknown
		//IL_2794: Unknown result type (might be due to invalid IL or missing references)
		//IL_2799: Expected Obj, but got Unknown
		//IL_27a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a7: Expected Obj, but got Unknown
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b5: Expected Obj, but got Unknown
		//IL_27be: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c3: Expected Obj, but got Unknown
		//IL_27cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d1: Expected Obj, but got Unknown
		//IL_27da: Unknown result type (might be due to invalid IL or missing references)
		//IL_27df: Expected Obj, but got Unknown
		//IL_27e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ed: Expected Obj, but got Unknown
		//IL_2845: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_21aa: Expected Obj, but got I
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b5: Expected Obj, but got Unknown
		//IL_21be: Expected Obj, but got I4
		//IL_0064: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_2247: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I
		//IL_01e5: Expected I, but got Obj
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0471: Invalid comparison between VT and I4
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_048e: Invalid comparison between VT and I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected Obj, but got Unknown
		//IL_04ab: Invalid comparison between VT and I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected Obj, but got Unknown
		//IL_0ad4: Expected F4, but got I
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected Obj, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_083a: Expected Obj, but got I
		//IL_22ee: Expected Obj, but got I4
		//IL_22f6: Expected Obj, but got F4
		//IL_2318: Expected VT, but got Obj
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0a94: Expected F4, but got Obj
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0926: Expected Obj, but got F4
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected Obj, but got Unknown
		//IL_0bdb: Expected VT, but got Obj
		//IL_0be9: Expected I, but got Obj
		//IL_0bff: Expected Obj, but got I
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_239d: Expected I4, but got Obj
		//IL_23a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a8: Expected Obj, but got Unknown
		//IL_0c2a: Expected I, but got Obj
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_0d02: Expected Obj, but got F4
		//IL_23da: Unknown result type (might be due to invalid IL or missing references)
		//IL_23df: Expected Obj, but got Unknown
		//IL_23ff: Expected Obj, but got I
		//IL_241a: Expected Obj, but got I
		//IL_2428: Unknown result type (might be due to invalid IL or missing references)
		//IL_242d: Expected Obj, but got Unknown
		//IL_2435: Expected Obj, but got I4
		//IL_2440: Invalid comparison between VT and I4
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected Obj, but got Unknown
		//IL_0cd8: Expected Obj, but got F4
		//IL_2468: Unknown result type (might be due to invalid IL or missing references)
		//IL_246d: Expected Obj, but got Unknown
		//IL_249e: Expected Obj, but got I
		//IL_2537: Invalid comparison between VT and I4
		//IL_1065: Expected Obj, but got I
		//IL_1075: Expected Obj, but got I
		//IL_1085: Expected Obj, but got I
		//IL_10b0: Expected Obj, but got I
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected Obj, but got Unknown
		//IL_25f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fb: Expected Obj, but got Unknown
		//IL_260b: Expected Obj, but got I
		//IL_2621: Expected Obj, but got I
		//IL_2633: Unknown result type (might be due to invalid IL or missing references)
		//IL_2638: Expected Obj, but got Unknown
		//IL_2648: Expected Obj, but got I
		//IL_2658: Expected Obj, but got I
		//IL_2668: Expected Obj, but got I
		//IL_2693: Expected Obj, but got I
		//IL_1209: Expected Obj, but got I
		//IL_121f: Expected Obj, but got I
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected Obj, but got Unknown
		//IL_1103: Invalid comparison between F4 and I
		//IL_0da8: Expected Obj, but got I
		//IL_0db8: Expected Obj, but got I
		//IL_0dc8: Expected Obj, but got I
		//IL_0df3: Expected Obj, but got I
		//IL_0f3b: Expected Obj, but got I
		//IL_0f51: Expected Obj, but got I
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e14: Expected Obj, but got Unknown
		//IL_0e43: Invalid comparison between F4 and I
		//IL_2058: Expected Obj, but got I4
		//IL_2062: Unknown result type (might be due to invalid IL or missing references)
		//IL_2067: Expected Obj, but got Unknown
		//IL_126f: Expected Obj, but got I
		//IL_1141: Expected Obj, but got I
		//IL_2108: Unknown result type (might be due to invalid IL or missing references)
		//IL_210d: Expected Obj, but got Unknown
		//IL_0fa1: Expected Obj, but got I
		//IL_0e81: Expected Obj, but got I
		//IL_2138: Expected Obj, but got F4
		//IL_2769: Unknown result type (might be due to invalid IL or missing references)
		//IL_276e: Expected Obj, but got Unknown
		//IL_20db: Expected Obj, but got F4
		//IL_1396: Expected Obj, but got I
		//IL_13a6: Expected Obj, but got I
		//IL_13b6: Expected Obj, but got I
		//IL_13e1: Expected Obj, but got I
		//IL_12c5: Invalid comparison between VT and I4
		//IL_1a90: Expected Obj, but got I
		//IL_1aa6: Expected Obj, but got I
		//IL_13fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1402: Expected Obj, but got Unknown
		//IL_1434: Invalid comparison between F4 and I
		//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Expected Obj, but got Unknown
		//IL_0ff7: Invalid comparison between VT and I4
		//IL_1ae7: Expected Obj, but got I
		//IL_1afd: Expected Obj, but got I
		//IL_1463: Expected Obj, but got I
		//IL_1473: Expected Obj, but got I
		//IL_1483: Expected Obj, but got I
		//IL_14ae: Expected Obj, but got I
		//IL_11d7: Invalid comparison between VT and I4
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Expected Obj, but got Unknown
		//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Expected Obj, but got Unknown
		//IL_1b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6e: Expected Obj, but got Unknown
		//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cf: Expected Obj, but got Unknown
		//IL_14ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f2: Expected Obj, but got Unknown
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected Obj, but got Unknown
		//IL_0f09: Invalid comparison between VT and I4
		//IL_1b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8b: Expected Obj, but got Unknown
		//IL_1c1d: Expected Obj, but got I
		//IL_1514: Unknown result type (might be due to invalid IL or missing references)
		//IL_1519: Expected Obj, but got Unknown
		//IL_1537: Unknown result type (might be due to invalid IL or missing references)
		//IL_153c: Expected Obj, but got Unknown
		//IL_154d: Expected Obj, but got I
		//IL_15d7: Expected Obj, but got I
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected Obj, but got Unknown
		//IL_1c4d: Expected Obj, but got I
		//IL_15ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Expected Obj, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1611: Expected Obj, but got Unknown
		//IL_1c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c86: Expected Obj, but got Unknown
		//IL_1c96: Expected Obj, but got I
		//IL_1c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca4: Expected Obj, but got Unknown
		//IL_162e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1633: Expected Obj, but got Unknown
		//IL_1652: Expected Obj, but got I
		//IL_1cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc6: Expected Obj, but got Unknown
		//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce9: Expected Obj, but got Unknown
		//IL_166e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1673: Expected Obj, but got Unknown
		//IL_1d51: Expected VT, but got Obj
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a8: Expected Obj, but got Unknown
		//IL_1d64: Expected I, but got Obj
		//IL_1d7a: Expected Obj, but got I
		//IL_16c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c5: Expected Obj, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16db: Expected Obj, but got Unknown
		//IL_16f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Expected Obj, but got Unknown
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_171b: Expected Obj, but got Unknown
		//IL_2722: Expected I4, but got Obj
		//IL_273c: Expected Obj, but got I
		//IL_173b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1740: Expected Obj, but got Unknown
		//IL_176a: Expected F4, but got I
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Expected Obj, but got Unknown
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd8: Expected Obj, but got Unknown
		//IL_1e05: Expected Obj, but got I
		//IL_1e20: Expected Obj, but got I
		//IL_1da5: Expected I, but got Obj
		//IL_17ed: Expected VT, but got Obj
		//IL_17fb: Expected I, but got Obj
		//IL_1811: Expected Obj, but got I
		//IL_1fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd3: Expected Obj, but got Unknown
		//IL_1ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2000: Expected Obj, but got Unknown
		//IL_2017: Expected Obj, but got F4
		//IL_203a: Unknown result type (might be due to invalid IL or missing references)
		//IL_203f: Expected Obj, but got Unknown
		//IL_25ce: Expected I4, but got Obj
		//IL_25d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25dc: Expected Obj, but got Unknown
		//IL_1e3a: Expected Obj, but got I
		//IL_1e4a: Expected Obj, but got I
		//IL_1e5a: Expected Obj, but got I
		//IL_1e85: Expected Obj, but got I
		//IL_1888: Expected Obj, but got I
		//IL_189e: Expected Obj, but got I
		//IL_18b9: Expected Obj, but got I
		//IL_183c: Expected I, but got Obj
		//IL_1ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea6: Expected Obj, but got Unknown
		//IL_1ed8: Invalid comparison between F4 and I
		//IL_1a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a05: Expected Obj, but got Unknown
		//IL_1a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a32: Expected Obj, but got Unknown
		//IL_1a49: Expected Obj, but got F4
		//IL_1a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a71: Expected Obj, but got Unknown
		//IL_1f16: Expected Obj, but got I
		//IL_18d3: Expected Obj, but got I
		//IL_18e9: Expected Obj, but got I
		//IL_1939: Expected Obj, but got I
		//IL_1fa6: Invalid comparison between VT and I4
		//IL_1994: Invalid comparison between VT and I4
		//IL_19eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+78]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+78]");
			object obj3 = 0;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v675 (Il2CppClass<NGUITools>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v682 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v558+18]");
			NGUITools.DestroyChildren((Transform)0);
			object obj5 = this + 120;
			obj5 = 0;
		}
		Transform transform = (Transform)(obj2 + 128);
		object obj6 = obj2 + 16;
		object obj7 = obj2 + 40;
		object obj8 = obj2 + 96;
		object obj9 = obj2 + 80;
		object obj10 = obj2 - -64;
		object obj11 = obj2 + 32;
		object obj12 = obj2 + 48;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 4;
		_ = 0f;
		_ = 0f;
		bool flag = index > -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj13 = default;
		bool flag2 = (nint)obj13 > index;
		object obj14 = flag & flag2;
		if (obj14 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj15 = default;
		if (obj15 == null)
		{
			return;
		}
		_ = 1;
		ScrollView.ScrollDirection scrollDirection = ((ScrollView)this).scrollDirection;
		((UIScrollView)scrollDirection).UpdateScrollbars();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
		((ScrollView.RecycleBin)0).ScrapActiveContainers();
		UIPanel rootPanel = ((ScrollView)this).rootPanel;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v670 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		transform = (Transform)obj6;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		UIScrollView uiScrollView = ((ScrollView)this).uiScrollView;
		nint num5 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v44 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num6 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v666 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one2 = Vector2.one;
		obj7 = obj2;
		transform = (Transform)obj7;
		((UIPanel)(object)uiScrollView).clipTexture = (Texture2D)(object)transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+BC]");
		Characters.CharacterId? nextCharacterToDisplay = ((CharacterNameEventManager)0).GetNextCharacterToDisplay();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
		Container item = default;
		bool flag3 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		Container container = default;
		if (container != null)
		{
			container.isMeasured = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			UIScrollView uiScrollView2 = ((ScrollView)this).uiScrollView;
			object obj18 = uiScrollView2 + 220;
			transform = (Transform)obj18;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v66+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			UIScrollView uiScrollView3 = ((ScrollView)this).uiScrollView;
			object obj19 = uiScrollView3 + 220;
			obj6 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S2_v30+8]");
			_ = 0;
			object obj20 = container + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
			float num7 = 0f * 0.5f;
			float num8 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+4]");
			float num9 = num8 + 0f;
			float num10 = container.height * 0.5f;
			float num11 = num9 - num10;
			float num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num13 = num12 - 0f;
			float num14 = num13 - t;
			UIScrollView uiScrollView4 = ((ScrollView)this).uiScrollView;
			object obj21 = uiScrollView4 + 220;
			obj8 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S2_v39+8]");
			_ = 0;
			UIScrollView uiScrollView5 = ((ScrollView)this).uiScrollView;
			object obj22 = uiScrollView5 + 220;
			obj9 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S2_v45+8]");
			_ = 0;
			object obj23 = container + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			float num15 = container.width * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21+8]");
			float num16 = 0f * 0.5f;
			float num17 = num15 - num16;
			float num18 = num17 + (float)obj9;
			float num19 = num18 + (float)obj10;
			float num20 = num19 + t;
			float num35;
			float num36;
			if (value != (Vector3)(object)0)
			{
				if (value != (Vector3)(object)1)
				{
					if (value == (Vector3)(object)2)
					{
						UIScrollView uiScrollView6 = ((ScrollView)this).uiScrollView;
						object obj24 = uiScrollView6 + 220;
						transform = (Transform)obj24;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S1_v616+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						UIScrollView uiScrollView7 = ((ScrollView)this).uiScrollView;
						object obj25 = uiScrollView7 + 220;
						obj6 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ S2_v346+8]");
						_ = 0;
						object obj26 = container + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
						object obj27 = -0;
						float num21 = (float)obj27 * 0.5f;
						float num22 = num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+4]");
						float num23 = num22 + 0f;
						float num24 = container.height * 0.5f;
						float num25 = num23 + num24;
						float num26 = num25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						float num27 = num26 - 0f;
						UIScrollView uiScrollView8 = ((ScrollView)this).uiScrollView;
						object obj28 = uiScrollView8 + 220;
						obj8 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S2_v355+8]");
						_ = 0;
						UIScrollView uiScrollView9 = ((ScrollView)this).uiScrollView;
						object obj29 = uiScrollView9 + 220;
						obj9 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S2_v361+8]");
						_ = 0;
						object obj30 = container + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
						object obj31 = 0f - container.width;
						float num28 = (float)obj31 * 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21+8]");
						float num29 = 0f * 0.5f;
						float num30 = num28 + num29;
						float num31 = num30 + (float)obj9;
						float num32 = num31 + (float)obj10;
						bool flag4 = (nint)curveY == 1;
						UIScrollView uiScrollView10 = ((ScrollView)this).uiScrollView;
						float num33;
						if (flag4)
						{
							object obj32 = uiScrollView10 + 220;
							transform = (Transform)obj32;
							Transform transform5 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S1_v660+8]");
							((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
							num33 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr - container.width;
						}
						else
						{
							object obj33 = uiScrollView10 + 220;
							transform = (Transform)obj33;
							Transform transform6 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S1_v653+8]");
							((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
							num33 = 0f - container.height;
						}
						float num34 = num27;
						num35 = num32;
						num36 = num33;
					}
					else
					{
						float num34 = num14;
						num35 = num20;
						num36 = t;
					}
				}
				else
				{
					bool flag5 = (nint)curveY == 1;
					UIScrollView uiScrollView11 = ((ScrollView)this).uiScrollView;
					float num39;
					if (flag5)
					{
						object obj34 = uiScrollView11 + 220;
						transform = (Transform)obj34;
						Transform transform7 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S1_v606+8]");
						((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
						float num37 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr * 0.5f;
						float num38 = container.width * 0.5f;
						num39 = num37 - num38;
					}
					else
					{
						object obj35 = uiScrollView11 + 220;
						transform = (Transform)obj35;
						Transform transform8 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v597+8]");
						((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
						float num40 = 0f * 0.5f;
						float num41 = container.height * 0.5f;
						num39 = num40 - num41;
					}
					float num34 = 0f;
					num35 = 0f;
					num36 = num39;
				}
			}
			else
			{
				UIScrollView uiScrollView12 = ((ScrollView)this).uiScrollView;
				object obj36 = uiScrollView12 + 220;
				transform = (Transform)obj36;
				Transform transform9 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v559+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				UIScrollView uiScrollView13 = ((ScrollView)this).uiScrollView;
				object obj37 = uiScrollView13 + 220;
				obj6 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S2_v314+8]");
				_ = 0;
				object obj38 = container + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
				float num42 = 0f * 0.5f;
				float num43 = num42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+4]");
				float num44 = num43 + 0f;
				float num45 = container.height * 0.5f;
				float num46 = num44 - num45;
				float num47 = num46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num48 = num47 - 0f;
				UIScrollView uiScrollView14 = ((ScrollView)this).uiScrollView;
				object obj39 = uiScrollView14 + 220;
				obj8 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S2_v323+8]");
				_ = 0;
				UIScrollView uiScrollView15 = ((ScrollView)this).uiScrollView;
				object obj40 = uiScrollView15 + 220;
				obj9 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S2_v329+8]");
				_ = 0;
				object obj41 = container + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				float num49 = container.width * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21+8]");
				float num50 = 0f * 0.5f;
				float num51 = num49 - num50;
				float num52 = num51 + (float)obj9;
				float num53 = num52 + (float)obj10;
				float num34 = num48;
				num35 = num53;
				num36 = 0f;
			}
			bool flag6 = curveY == null;
			UIScrollView uiScrollView16 = ((ScrollView)this).uiScrollView;
			if (flag6)
			{
				object obj42 = uiScrollView16 + 220;
				transform = (Transform)obj42;
				Transform transform10 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S1_v553+8]");
				((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
				num35 = (float)transform;
			}
			else
			{
				object obj43 = uiScrollView16 + 220;
				transform = (Transform)obj43;
				Transform transform11 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S1_v548+8]");
				((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+4]");
				float num34 = 0f;
			}
			obj6 = 0;
			obj6 = num35;
			obj11 = obj6;
			transform = (Transform)obj11;
			container.coordinates = (Vector2)transform;
			if (curveY != null)
			{
				container.top = 0f;
				float bottom = container.top + container.height;
				container.bottom = bottom;
				container.left = num36;
				float num54 = num36 + container.width;
				float right = num54 + (float)MinCoords__BackingField;
				container.right = right;
			}
			else
			{
				container.top = num36;
				float num55 = container.top + container.height;
				float bottom2 = num55 + (float)curveZ;
				container.bottom = bottom2;
				container.left = 0f;
				float right2 = container.left + container.width;
				container.right = right2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			int modelType = default;
			container.modelType = modelType;
			UIScrollView uiScrollView17 = ((ScrollView)this).uiScrollView;
			GameObject gameObject = uiScrollView17.gameObject;
			container.SetScale((Vector3)gameObject);
			nint num56 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ S0_v100 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num57 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v473 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj6;
			Transform transform12 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+8]");
			((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
			container.SetModelType((int)transform);
			object obj45 = this + 76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			if (curveY != null)
			{
				object obj46 = container + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				float num58 = num36 + (float)obj6;
				float num59 = (float)obj + num58;
				obj = num59;
			}
			else
			{
				object obj47 = obj + 4;
				float num60 = (float)obj47 - num36;
				obj47 = num60;
			}
			transform = (Transform)obj;
			Transform transform13 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
			object obj48 = this + 76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
			object obj49 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
			object obj50 = (nint)0 + (nint)1;
			object obj51 = container - -64;
			obj51 = index;
			if (MaxCoords__BackingField == (Vector3)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
				if ((nint)0 <= (nint)(-1))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj53 = default;
					object obj52 = obj53 - 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
				object obj54 = default;
				if (0 == (nint)obj54)
				{
					_ = 0;
				}
			}
			object obj55 = container - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730E");
			long rowId = default;
			container.rowId = rowId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
			((FollowingGuard.OnCatchPlayerDelegate)0)._002Ector(container, (IntPtr)1);
			if (curveY != null)
			{
				object obj56 = default;
				Container item2 = default;
				ContainerPivot containerPivot = default;
				object obj61 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
					if (0 >= (nint)obj56)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj57 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ S1_v497+8]");
					object obj59 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ S1_v498+C]");
					int index2 = (int)(-1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ S0_v441+8]");
					Container container2 = ((List<Container>)0).get_Item(index2);
					UIScrollView uiScrollView18 = ((ScrollView)this).uiScrollView;
					object obj60 = uiScrollView18 + 220;
					transform = (Transform)obj60;
					Transform transform14 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ S2_v274+8]");
					((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
					if (!(container2.right < (float)(nint)((UnityEngine.Object)transform).m_CachedPtr))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					bool flag7 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					if (containerPivot != ContainerPivot.Top)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
						((ScrollView)this).SmoothScrollToIndex(0, containerPivot, (Action)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
						if (0 == (nint)obj61 && MaxCoords__BackingField == (Vector3)(object)1)
						{
							_ = 0;
						}
					}
				}
				Container item3 = default;
				Container container4 = default;
				object obj64 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
					if ((nint)0 < (nint)0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj62 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ S0_v423+8]");
					Container container3 = ((List<Container>)0).get_Item(0);
					if (!(container3.left > 0f))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					bool flag8 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					if (container4 == null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
					((ScrollView)this).AppendContainer(0, container4, false);
					if (MaxCoords__BackingField == (Vector3)(object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
						if ((nint)0 <= (nint)(-1))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							object obj63 = obj64 - 1;
						}
					}
				}
			}
			else
			{
				object obj65 = default;
				Container item4 = default;
				ContainerPivot containerPivot2 = default;
				object obj71 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
					if (0 >= (nint)obj65)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj66 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ S1_v459+8]");
					object obj68 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S1_v460+C]");
					int index3 = (int)(-1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ S0_v397+8]");
					Container container5 = ((List<Container>)0).get_Item(index3);
					UIScrollView uiScrollView19 = ((ScrollView)this).uiScrollView;
					object obj69 = uiScrollView19 + 220;
					transform = (Transform)obj69;
					Transform transform15 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1178 @ S2_v243+8]");
					((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
					float bottom3 = container5.bottom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
					if (!(bottom3 < 0f))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					bool flag9 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item4);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					if (containerPivot2 != ContainerPivot.Top)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
						((ScrollView)this).SmoothScrollToIndex(0, containerPivot2, (Action)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj70 = obj71 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
						if (0 == (nint)obj70 && MaxCoords__BackingField == (Vector3)(object)1)
						{
							_ = 0;
						}
					}
				}
				Container item5 = default;
				Container container7 = default;
				object obj74 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
					if ((nint)0 < (nint)0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj72 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ S0_v379+8]");
					Container container6 = ((List<Container>)0).get_Item(0);
					if (!(container6.top > 0f))
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					bool flag10 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item5);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					if (container7 == null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
					((ScrollView)this).AppendContainer(0, container7, false);
					if (MaxCoords__BackingField == (Vector3)(object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
						if ((nint)0 <= (nint)(-1))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							object obj73 = obj74 - 1;
						}
					}
				}
			}
			if (MaxCoords__BackingField != (Vector3)(object)1 && curveY == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
				object obj75 = default;
				if (0 == (nint)obj75)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S1_v313+8]");
					object obj78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ S1_v314+C]");
					int index4 = (int)(-1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ S0_v274+8]");
					Container container8 = ((List<Container>)0).get_Item(index4);
					UIScrollView uiScrollView20 = ((ScrollView)this).uiScrollView;
					object obj79 = uiScrollView20 + 220;
					transform = (Transform)obj79;
					Transform transform16 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ S2_v158+8]");
					((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
					float bottom4 = container8.bottom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
					if (bottom4 < 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						object obj80 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						object obj81 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ S1_v324+8]");
						object obj82 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1422 @ S1_v325+C]");
						int index5 = (int)(-1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ S0_v281+8]");
						Container container9 = ((List<Container>)0).get_Item(index5);
						UIScrollView uiScrollView21 = ((ScrollView)this).uiScrollView;
						object obj83 = uiScrollView21 + 220;
						obj6 = obj83;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ S1_v330+8]");
						_ = 0;
						object obj84 = container9 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
						UIScrollView uiScrollView22 = ((ScrollView)this).uiScrollView;
						object obj85 = uiScrollView22 + 220;
						obj8 = obj85;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ S1_v338+8]");
						_ = 0;
						object obj86 = container9 + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+C]");
						object obj87 = -0;
						float num61 = (float)obj87 * 0.5f;
						float num62 = container9.height * 0.5f;
						float num63 = num61 + num62;
						float num64 = num63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						float num65 = num64 - 0f;
						float num66 = num65;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21+4]");
						float num67 = num66 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ S0_v296+4]");
						float num68 = 0f - num67;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						ScrollView.RecycleBin.Log((string)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj89 = default;
						object obj88 = obj89 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj91 = default;
						object obj90 = obj91 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj93 = default;
						object obj92 = obj93 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						Container item6 = default;
						bool flag11 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item6);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj95 = default;
						object obj94 = obj95 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
						Container container10 = default;
						container10.isMeasured = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						object obj96 = container10 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj98 = default;
						object obj97 = obj98 - 1;
						obj96 = obj97;
						object obj99 = container10 + 28;
						UIScrollView uiScrollView23 = ((ScrollView)this).uiScrollView;
						object obj100 = uiScrollView23 + 220;
						obj9 = obj100;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1748 @ S1_v368+8]");
						_ = 0;
						object obj101 = container10 + 28;
						obj101 = obj9;
						UIScrollView uiScrollView24 = ((ScrollView)this).uiScrollView;
						object obj102 = uiScrollView24 + 220;
						obj10 = obj102;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ S1_v377+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v25+C]");
						container10.bottom = 0f;
						float top = container10.bottom - container10.height;
						container10.top = top;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj104 = default;
						object obj103 = obj104 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						int modelType2 = default;
						container10.modelType = modelType2;
						UIScrollView uiScrollView25 = ((ScrollView)this).uiScrollView;
						GameObject gameObject2 = uiScrollView25.gameObject;
						container10.SetScale((Vector3)gameObject2);
						nint num69 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1856 @ S0_v321 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj105 = (nint)0 & (nint)0x200;
						if (obj105 != null)
						{
							nint num70 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ S0_v367 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 forward2 = Vector3.forward;
						transform = (Transform)obj12;
						Transform transform17 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29+8]");
						((UnityEngine.Object)transform17).m_CachedPtr = (IntPtr)0;
						container10.SetModelType((int)transform);
						object obj106 = container10 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730E");
						long rowId2 = default;
						container10.rowId = rowId2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						((FollowingGuard.OnCatchPlayerDelegate)0)._002Ector(container10, (IntPtr)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
						object obj107 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
						object obj108 = (nint)0 + (nint)1;
						Container item7 = default;
						Container container12 = default;
						object obj111 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
							if ((nint)0 < (nint)0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
							object obj109 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1995 @ S0_v349+8]");
							Container container11 = ((List<Container>)0).get_Item(0);
							if (!(container11.top > 0f))
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
							bool flag12 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item7);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
							if (container12 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
								((ScrollView)this).AppendContainer(0, container12, false);
							}
							if (MaxCoords__BackingField == (Vector3)(object)1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
								if ((nint)0 <= (nint)(-1))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
									object obj110 = obj111 - 1;
								}
							}
						}
						object obj112 = this + 76;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
						obj = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+8]");
						_ = 0;
						object obj113 = obj + 4;
						float num71 = (float)obj113 - num68;
						obj113 = num71;
						transform = (Transform)obj;
						Transform transform18 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
						object obj114 = this + 76;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
				if ((nint)0 <= (nint)(-1))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
					object obj115 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ S0_v179+8]");
					Container container13 = ((List<Container>)0).get_Item(0);
					if (container13.top > 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						object obj116 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ S0_v186+8]");
						Container container14 = ((List<Container>)0).get_Item(0);
						UIScrollView uiScrollView26 = ((ScrollView)this).uiScrollView;
						object obj117 = uiScrollView26 + 220;
						obj6 = obj117;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1514 @ S1_v206+8]");
						_ = 0;
						UIScrollView uiScrollView27 = ((ScrollView)this).uiScrollView;
						object obj118 = uiScrollView27 + 220;
						obj2 = obj118;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ S1_v212+8]");
						_ = 0;
						object obj119 = container14 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
						object obj120 = container14 + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+C]");
						float num72 = 0f * 0.5f;
						float num73 = num72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						float num74 = num73 + 0f;
						float num75 = container14.height * 0.5f;
						float num76 = num74 - num75;
						float num77 = num76;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21+4]");
						float num78 = num77 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1597 @ S0_v201+4]");
						float num79 = 0f - num78;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						ScrollView.RecycleBin.Log((string)0);
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						Container item8 = default;
						bool flag13 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item8);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
						Container container15 = default;
						container15.isMeasured = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						object obj121 = container15 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
						obj121 = 0;
						object obj122 = container15 + 28;
						UIScrollView uiScrollView28 = ((ScrollView)this).uiScrollView;
						object obj123 = uiScrollView28 + 220;
						obj9 = obj123;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ S1_v238+8]");
						_ = 0;
						object obj124 = container15 + 28;
						obj124 = obj9;
						container15.bottom = container15.height;
						container15.top = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						int modelType3 = default;
						container15.modelType = modelType3;
						UIScrollView uiScrollView29 = ((ScrollView)this).uiScrollView;
						GameObject gameObject3 = uiScrollView29.gameObject;
						container15.SetScale((Vector3)gameObject3);
						nint num80 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ S0_v224 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj125 = (nint)0 & (nint)0x200;
						if (obj125 != null)
						{
							nint num81 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1763 @ S0_v270 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 forward3 = Vector3.forward;
						transform = (Transform)obj10;
						Transform transform19 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v25+8]");
						((UnityEngine.Object)transform19).m_CachedPtr = (IntPtr)0;
						container15.SetModelType((int)transform);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
						((FollowingGuard.OnCatchPlayerDelegate)0)._002Ector(container15, (IntPtr)1);
						object obj126 = container15 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730E");
						long rowId3 = default;
						container15.rowId = rowId3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
						object obj127 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
						object obj128 = (nint)0 + (nint)1;
						object obj129 = default;
						Container item9 = default;
						ContainerPivot containerPivot3 = default;
						object obj134 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
							if (0 >= (nint)obj129)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
							object obj130 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
							object obj131 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1875 @ S1_v292+8]");
							object obj132 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ S1_v293+C]");
							int index6 = (int)(-1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1870 @ S0_v252+8]");
							Container container16 = ((List<Container>)0).get_Item(index6);
							UIScrollView uiScrollView30 = ((ScrollView)this).uiScrollView;
							object obj133 = uiScrollView30 + 220;
							transform = (Transform)obj133;
							Transform transform20 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1941 @ S2_v142+8]");
							((UnityEngine.Object)transform20).m_CachedPtr = (IntPtr)0;
							float bottom5 = container16.bottom;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (UnityEngine.Transform)+C]");
							if (!(bottom5 < 0f))
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
							bool flag14 = ((ScrollView._003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item9);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
							if (containerPivot3 != ContainerPivot.Top)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
								((ScrollView)this).SmoothScrollToIndex(0, containerPivot3, (Action)null);
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
							if (0 == (nint)obj134 && MaxCoords__BackingField == (Vector3)(object)1)
							{
								_ = 0;
							}
						}
						object obj135 = this + 76;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
						obj = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+8]");
						_ = 0;
						object obj136 = obj + 4;
						float num82 = (float)obj136 - num79;
						obj136 = num82;
						transform = (Transform)obj;
						Transform transform21 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						((UnityEngine.Object)transform21).m_CachedPtr = (IntPtr)0;
						object obj137 = this + 76;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
					}
				}
			}
			object obj138 = this + 140;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
			object obj139 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ S1_v157+8]");
			Container container17 = ((List<Container>)0).get_Item(0);
			obj138 = container17;
			object obj140 = this + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
			object obj141 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+64]");
			object obj142 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ S2_v78+8]");
			object obj143 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ S2_v79+C]");
			int index7 = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ S1_v162+8]");
			Container container18 = ((List<Container>)0).get_Item(index7);
			obj140 = container18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+74]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+BC]");
			if ((nint)0 == 1)
			{
				Characters.CharacterId? nextCharacterToDisplay2 = ((CharacterNameEventManager)1).GetNextCharacterToDisplay();
				object obj144 = this + 76;
				if ((nint)curveY == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+8]");
					_ = 0;
					Container lastVisibleContainerOnScreen = ((ScrollView)this).GetLastVisibleContainerOnScreen();
					float num83 = (float)obj + lastVisibleContainerOnScreen.left;
					obj = num83;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17+8]");
					_ = 0;
					object obj145 = obj + 4;
					Container lastVisibleContainerOnScreen2 = ((ScrollView)this).GetLastVisibleContainerOnScreen();
					float num84 = (float)obj145 - lastVisibleContainerOnScreen2.top;
					obj145 = num84;
				}
				transform = (Transform)obj;
				Transform transform22 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform22).m_CachedPtr = (IntPtr)0;
				object obj146 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+94]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		((ScrollView)this).ClearList();
	}

	public void SmoothTangents(int index, float weight)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected VT, but got I4
		Camera camera = default;
		object obj = camera + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera camera2 = (Camera)(camera + 32);
		if (((ComputeShader)index).FindKernel(null) != 0)
		{
			camera.rect = (Rect)index;
			obj = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			camera2 = (Camera)obj;
			Camera camera3 = camera2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
			Rect pixelRect = camera2.pixelRect;
		}
	}

	public Vector3 Evaluate(float t)
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0018: Expected VT, but got Obj
		//IL_002b: Expected VT, but got Obj
		LinearColor linearColor = LinearColor.Convert((Color)this, t);
		LinearColor linearColor2 = LinearColor.Convert((Color)this, t);
		LinearColor linearColor3 = LinearColor.Convert((Color)this, t);
		Vector3 result = default;
		return result;
	}

	public unsafe Vector3 EvaluateDerivative(float t)
	{
		//IL_0047: Expected native int or pointer, but got VT
		//IL_0055: Expected native int or pointer, but got VT
		//IL_0062: Expected native int or pointer, but got VT
		//IL_006f: Expected native int or pointer, but got VT
		//IL_007c: Expected native int or pointer, but got VT
		float x = PlayerPrefs.GetFloat((string)(object)curveX, t);
		float y = PlayerPrefs.GetFloat((string)(object)curveY, t);
		float z = PlayerPrefs.GetFloat((string)(object)curveZ, t);
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = x;
		((Vector3*)(nint)vector)->y = y;
		((Vector3*)(nint)vector)->z = z;
		return vector;
	}

	public void DrawGizmos(Color color)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		object obj = color.r;
		_ = color.b;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	private void UpdateMinMaxTime(float t)
	{
		MaxTime__BackingField = t;
	}

	private unsafe void UpdateMinMaxCoords(Vector3 v)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Ref, but got Unknown
		//IL_0063: Expected Ref, but got F4
		//IL_0097: Expected Obj, but got VT
		//IL_00ad: Expected Obj, but got I4
		//IL_0114: Expected F4, but got Obj
		//IL_010f: Expected native int or pointer, but got VT
		//IL_0129: Expected F4, but got I
		//IL_0124: Expected native int or pointer, but got VT
		//IL_014b: Expected VT, but got Ref
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 36);
		object obj2 = obj + 24;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 12;
		obj3 = 0;
		_ = 0;
		ref Color reference = ref *(Color*)(obj + 48);
		reference = ref *(Color*)v.x;
		_ = v.z;
		Gizmos.set_color_Injected(ref reference);
		Vector3 vector2 = EvaluateDerivative(0f);
		obj2 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Color&)+8]");
		_ = 0;
		object obj4 = 0;
		while ((nint)obj4 <= 999)
		{
			float num = MaxTime__BackingField - MinTime__BackingField;
			float num2 = num * (float)obj4;
			float t = num2 / 999f;
			Vector3 vector3 = EvaluateDerivative(t);
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			reference = ref *(Color*)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+8]");
			_ = 0;
			object obj5 = obj4 + 1;
			obj4 = obj5;
		}
	}
}
