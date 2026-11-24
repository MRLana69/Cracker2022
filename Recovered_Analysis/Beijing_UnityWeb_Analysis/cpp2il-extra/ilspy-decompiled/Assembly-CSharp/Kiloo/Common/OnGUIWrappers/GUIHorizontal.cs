using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIHorizontal : IDisposable
{
	public GUIHorizontal()
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.OnGUIWrappers.GUIHorizontal)+8]");
		bool depth = (nint)0 != 0;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v9 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUI.depth = (depth ? 1 : 0);
	}

	public GUIHorizontal(GUIStyle style, GUILayoutOption[] layoutOptions)
	{
		//IL_001a: Expected Obj, but got I
		//IL_0027: Expected I4, but got Obj
		((GUILayout.LayoutedWindow)(object)style).m_Func = (GUI.WindowFunction)(nint)style.m_Ptr;
		((GUILayout.LayoutedWindow)(object)style).DoWindow((int)layoutOptions);
	}

	public GUIHorizontal(GUILayoutOption[] layoutOptions)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b8: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int depth = GUI.depth;
		int num3 = depth & 1;
		GUI.depth = (int)layoutOptions;
	}

	public unsafe GUIHorizontal(string text, GUIStyle style, GUILayoutOption[] layoutOptions)
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected VT, but got Unknown
		//IL_00cd: Expected F4, but got Obj
		//IL_00c8: Expected native int or pointer, but got VT
		//IL_00e2: Expected F4, but got I
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_00f3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		_ = text.m_stringLength;
		nint num = (nint)typeof(GUIStyle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.GUIStyle>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GUIStyle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v22 (Il2CppClass<UnityEngine.GUIStyle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isHeightDependantOnWidth = ((GUIStyle)(object)layoutOptions).isHeightDependantOnWidth;
		Rect rect = (Rect)(text + 16);
		((Rect*)(nint)rect)->m_XMin = (float)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Rect*)(nint)rect)->m_Width = 0f;
		GUILayout.BeginArea(rect, (GUIContent)(object)style, (GUIStyle)isHeightDependantOnWidth);
	}

	public void Dispose()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		GUILayoutOption[] options = default;
		GUILayout.BeginVertical(options);
	}
}
