using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;

namespace UI.Generic.Layout;

public class VerticalLayout : Layout
{
	public enum Alignment
	{
		Center,
		Up,
		Down
	}

	public Alignment alignment;

	protected unsafe override void Align_Internal()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b7: Expected F4, but got I4
		//IL_003e: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00eb: Expected F4, but got I4
		//IL_011f: Expected F4, but got I4
		//IL_01f2: Expected I4, but got F8
		//IL_0215: Expected Obj, but got I4
		//IL_0351: Expected F4, but got I
		//IL_034c: Expected native int or pointer, but got VT
		//IL_0378: Expected F4, but got I
		//IL_0373: Expected native int or pointer, but got VT
		//IL_0261: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (_panel == null)
		{
			UIPanel componentInParent = GetComponentInParent<UIPanel>();
			_panel = componentInParent;
		}
		if (_panel != null)
		{
			UIPanel panel = _panel;
			nint num = (nint)panel;
			object obj2 = panel + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S2_v19 (Il2CppClass<UIPanel>)+11C] (should have been resolved before IL gen)");
		}
		float num3 = default;
		if (alignment != Alignment.Center)
		{
			if (alignment != Alignment.Up)
			{
				if (alignment == Alignment.Down)
				{
					Transform t = base.transform;
					float num2 = UIExtensions.AlignChildrenVertically(t, padding, downAlign: true);
					num3 = num2;
				}
			}
			else
			{
				Transform t2 = base.transform;
				float num4 = UIExtensions.AlignChildrenVertically(t2, padding, downAlign: false);
				num3 = num4;
			}
		}
		else
		{
			Transform t3 = base.transform;
			float num5 = UIExtensions.CenterChildrenVertically(t3, padding);
			num3 = num5;
		}
		if (~(autosizeWidget ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag = (object)targetWidget == null;
		bool flag2 = !flag;
		UIWidget uIWidget = targetWidget;
		if (!flag2)
		{
			UIWidget component = GetComponent<UIWidget>();
			uIWidget = component;
		}
		if (!(uIWidget != null))
		{
			return;
		}
		float num6 = num3 + autosizeWidgetMargin;
		if (!(num6 > autosizeWidgetMinWidth))
		{
			num6 = autosizeWidgetMinWidth;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num8 = default;
		double num7 = Math.Abs(num8);
		int height = ((!(num7 < 2147483648.0)) ? int.MinValue : ((int)num8));
		uIWidget.height = height;
		Transform transform = uIWidget.transform;
		Vector3 localPosition = transform.localPosition;
		object obj3 = alignment - 1;
		object message;
		float num11;
		float num9;
		if (alignment != Alignment.Up)
		{
			if ((nint)obj3 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				num9 = 0f;
			}
			else
			{
				float num10 = num6 * -0.5f;
				bool flag3 = targetWidget;
				message = "Down alignment on self widget isn't supported";
				num11 = num10;
				num9 = num10;
				if (!flag3)
				{
					goto IL_030c;
				}
			}
		}
		else
		{
			float num12 = num6 * 0.5f;
			bool flag4 = targetWidget;
			bool flag5 = !flag4;
			message = "Up alignment on self widget isn't supported";
			num11 = num12;
			if (flag5)
			{
				goto IL_030c;
			}
			num9 = num12;
		}
		goto IL_0322;
		IL_030c:
		Debug.LogWarning(message);
		num9 = num11;
		goto IL_0322;
		IL_0322:
		Transform transform2 = uIWidget.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localPosition = vector;
	}
}
