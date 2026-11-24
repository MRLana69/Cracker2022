using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic;

public class WidgetSizer : MonoBehaviour
{
	private void ResizeNow()
	{
		CancelInvoke();
	}

	public WidgetSizer()
	{
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0576: Expected Obj, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_05ed: Expected Obj, but got I
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0419: Invalid comparison between Obj and F4
		//IL_0452: Invalid comparison between Obj and F4
		//IL_040b: Expected Obj, but got I4
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_010a: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I4
		//IL_04ae: Invalid comparison between I and F4
		//IL_04ef: Invalid comparison between I and F4
		//IL_0498: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I
		//IL_04d9: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_051a: Expected Obj, but got I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_0324: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0296: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_0365: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 + 112;
		object obj4 = obj2 + 12;
		object obj5 = obj2 + 48;
		obj5 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj2 + 24;
		obj6 = 0;
		_ = 0;
		_ = 0;
		GameObject gameObject = base.gameObject;
		UIWidget component = GetComponent<UIWidget>();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S3_v12 (should have been resolved before IL gen)");
		object obj12 = default;
		object obj11 = obj12 + 12;
		if (obj11 == null)
		{
			return;
		}
		Matrix4x4 localToWorldMatrix = ((Transform)(object)gameObject).localToWorldMatrix;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj13 = 0;
		object obj23 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			object obj14 = obj12 + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v117 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj16 != component))
			{
				object obj18 = obj12 + 16;
				object obj19 = obj13 << 2;
				object obj20 = obj18 + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				obj10 = 2;
				object obj21 = 0;
				while ((nint)obj21 <= 3)
				{
					object obj22 = obj23 + 16;
					object obj24 = obj21 * 12;
					object obj25 = obj22 + obj24;
					obj3 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v74+8]");
					_ = 0;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					object obj26 = obj23 + 16;
					object obj27 = obj21 * 12;
					object obj28 = obj26 + obj27;
					obj28 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					object obj29 = obj21 | obj13;
					if (obj29 != null)
					{
						object obj30 = obj23 + 16;
						object obj31 = obj21 * 12;
						nint num4 = (nint)(obj30 + obj31);
						obj3 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v116 (Il2CppClass<UnityEngine.Vector3>)+8]");
						_ = 0;
						obj = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
						obj10 = 12;
					}
					else
					{
						object obj32 = obj23 + 16;
						object obj33 = obj21 * 12;
						object obj34 = obj32 + obj33;
						obj4 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S1_v99+8]");
						_ = 0;
						nint num5 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v98 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj35 = (nint)0 & (nint)0x200;
						if (obj35 != null)
						{
							nint num6 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v108 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one = Vector3.one;
						obj3 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						_ = 0;
						obj = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
						obj10 = 0;
					}
					object obj36 = obj21 + 1;
					obj21 = obj36;
				}
			}
			object obj37 = obj13 + 1;
			obj13 = obj37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		UIWidget uIWidget = (UIWidget)((obj != obj) ? ((UIWidget)int.MinValue) : ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f)) ? ((UIWidget)int.MinValue) : ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f))) ? obj : ((UIWidget)int.MinValue))));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
		Transform relativeParent;
		if (num7 != 0)
		{
			relativeParent = (Transform)int.MinValue;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
			if (!(0f < 2.1474836E+09f))
			{
				relativeParent = (Transform)int.MinValue;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
				if (!(0f > -2.1474836E+09f))
				{
					relativeParent = (Transform)int.MinValue;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
					relativeParent = (Transform)0;
				}
			}
		}
		Bounds bounds = uIWidget.CalculateBounds(relativeParent);
	}
}
