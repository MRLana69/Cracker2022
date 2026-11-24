using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic;

public class ButtonPressedColorChange : MonoBehaviour
{
	private UIWidget _widget;

	public Color normalColor
	{
		private get
		{
			//IL_000e: Expected Obj, but got F4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected Obj, but got Unknown
			Color result = default;
			string text = ((Component)result.a).tag;
			string text2 = (string)(this ^ 1);
			((GameObject)(object)text).tag = text2;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 16;
			ButtonPressedColorChange buttonPressedColorChange = (ButtonPressedColorChange)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Color pressedColor
	{
		private get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			object obj = default;
			Color color = (Color)(obj + 16);
			((Color*)(nint)color)->r = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 32;
			ButtonPressedColorChange buttonPressedColorChange = (ButtonPressedColorChange)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	private unsafe void OnPress(bool pressed)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		object obj = ((bool*)(pressed ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pressed @ L1 (System.Boolean)+8]");
		_ = 0;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	public ButtonPressedColorChange()
	{
		CancelInvoke();
	}
}
