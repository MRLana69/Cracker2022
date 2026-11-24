using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIVertical : IDisposable
{
	public GUIVertical()
	{
		GUILayoutUtility.Layout();
	}

	public GUIVertical(GUILayoutOption[] layoutOptions)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = layoutOptions + 8;
		obj = layoutOptions;
	}

	public unsafe GUIVertical(GUIStyle style, GUILayoutOption[] layoutOptions)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		//IL_0031: Expected I4, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I4
		GUILayoutOption gUILayoutOption = default;
		object obj = gUILayoutOption + 8;
		obj = style;
		GUILayoutOption.Type type = (GUILayoutOption.Type)(gUILayoutOption + 16);
		((GUILayoutOption.Type*)(int)type)->value__ = (int)obj;
		gUILayoutOption._002Ector(type, (object)layoutOptions);
		((GUILayoutOption.Type*)(int)type)->value__ = (int)gUILayoutOption;
		this._002Ector((GUILayoutOption[])type);
	}

	public GUIVertical(string text, GUIStyle style, GUILayoutOption[] layoutOptions)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = text;
		GUIContent gUIContent = (GUIContent)(obj2 + 16);
		Rect rect = GUILayoutUtility.GetRect((GUIContent)obj, style, layoutOptions);
		this._002Ector((GUILayoutOption[])obj2);
	}

	public void Dispose()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		Rect screenRect = default;
		GUILayout.BeginArea(screenRect);
	}
}
