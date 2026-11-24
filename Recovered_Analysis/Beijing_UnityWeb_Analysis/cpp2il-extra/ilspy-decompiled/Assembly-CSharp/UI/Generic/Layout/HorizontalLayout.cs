using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic.Layout;

public class HorizontalLayout : Layout
{
	public HorizontalAlignment alignment;

	protected override void Align_Internal()
	{
		CancelInvoke();
	}

	public HorizontalLayout()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected Obj, but got Unknown
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected Obj, but got Unknown
		//IL_0b62: Expected Obj, but got I4
		//IL_0b84: Expected I, but got Obj
		//IL_0b9a: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00d7: Expected I, but got Obj
		//IL_0bd9: Expected I, but got Obj
		//IL_0bef: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_03ef: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_0526: Expected I, but got Obj
		//IL_05b6: Expected I, but got Obj
		//IL_05cc: Expected Obj, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02fd: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_05f7: Expected I, but got Obj
		//IL_0666: Expected I, but got Obj
		//IL_067c: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_06a7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 20;
		object obj4 = obj2 + 8;
		obj4 = 0;
		_ = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v467 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj6 = default;
		if (obj6 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v410 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj9 = this + 44;
			object obj10 = default;
			obj9 = obj10;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S0_v394 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		_calculatedWidth = 0f;
		if (~(_snapToLabelContent ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj14 = default;
			object obj13 = obj14 + 12;
			object obj15 = 0;
			object obj16 = default;
			object obj18 = default;
			object obj22 = default;
			object obj24 = default;
			object obj28 = default;
			object obj29 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj17 = obj18 + 8;
				object obj19 = obj14 + 16;
				object obj20 = obj16 << 2;
				object obj21 = obj19 + obj20;
				obj17 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if ((nint)obj22 != 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj23 = obj24 + 12;
					obj23 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v321+C]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v321+C]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v321+8]");
					if ((nint)obj3 < 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v321+C]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj15 = obj28;
				}
				obj16 = obj29 + 1;
			}
		}
		else
		{
			object obj15 = 0;
		}
		if (alignment != HorizontalAlignment.Center)
		{
			if (alignment != HorizontalAlignment.Left)
			{
				if (alignment == HorizontalAlignment.Right)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					float calculatedWidth = default;
					_calculatedWidth = calculatedWidth;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				float calculatedWidth2 = default;
				_calculatedWidth = calculatedWidth2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			float calculatedWidth3 = default;
			_calculatedWidth = calculatedWidth3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		if (~(autosizeWidget ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ S0_v235 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj31 = default;
		if (obj31 != null)
		{
			UIWidget uIWidget = targetWidget;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			UIWidget uIWidget2 = default;
			UIWidget uIWidget = uIWidget2;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S0_v218 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj33 = default;
		if (obj33 == null)
		{
			return;
		}
		nint num11 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ S0_v89 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num12 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S0_v211 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		float num13 = _calculatedWidth + autosizeWidgetMargin;
		if (!(num13 > autosizeWidgetMinWidth))
		{
			num13 = autosizeWidgetMinWidth;
		}
		_calculatedWidth = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj35 = default;
		object obj36 = default;
		if (obj35 == obj36)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj38 = default;
			object obj37 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj40 = default;
			object obj39 = obj40;
		}
		else
		{
			object obj41 = default;
			object obj39 = obj41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}
}
