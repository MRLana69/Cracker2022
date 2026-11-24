using Cpp2ILInjected;
using Kiloo.Common.LocalizationManager;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIContentColor : InternalColor
{
	public GUIContentColor(Color newColor)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got F4
		//IL_00ca: Expected I4, but got F4
		//IL_00e1: Expected Obj, but got F4
		//IL_00f3: Expected I4, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = default;
		GUI.color = color;
		string text = (string)(color + 16);
		text = (string)color.r;
		text.m_stringLength = (int)color.b;
		((LegalTextData)(object)this).SetLocale(text);
		text = (string)newColor.r;
		text.m_stringLength = (int)newColor.b;
		Color backgroundColor = GUI.backgroundColor;
	}

	public override void Dispose()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = this + 8;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4+8]");
		_ = 0;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v20 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 16;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Color backgroundColor = GUI.backgroundColor;
	}
}
