using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIInputOnGUI : MonoBehaviour
{
	[NonSerialized]
	private UIInput mInput;

	private void Awake()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got F4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got F4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		_ = 1;
		object obj2 = default;
		object obj = obj2 + 48;
		Color black = Color.black;
		object obj3 = obj2 - -64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+8]");
		_ = 0;
		object obj4 = this + 48;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
		_ = 0;
		object obj5 = obj2 + 32;
		obj5 = 0;
		_ = 0;
		obj5 = 1f;
		_ = 1f;
		_ = 1f;
		_ = 0.8f;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18+8]");
		_ = 0;
		object obj6 = this - -64;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
		_ = 0;
		object obj7 = obj2 + 16;
		obj7 = 0;
		_ = 0;
		obj7 = 1f;
		_ = 223f / 255f;
		_ = 141f / 255f;
		_ = 0.5f;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v30+8]");
		_ = 0;
		object obj8 = this + 80;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj9 = this + 96;
		obj9 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list2 = default;
		list2._002Ector();
		object obj10 = this + 100;
		obj10 = list2;
		object obj11 = this + 112;
		obj11 = "";
		Color black2 = Color.black;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = this + 116;
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
		_ = 0;
		_ = 1;
		_ = 1;
		_ = 1;
		object obj13 = this + 176;
		obj13 = "";
		_ = -1;
		_ = -1;
		CancelInvoke();
	}

	private void OnGUI()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		UIInput component = GetComponent<UIInput>();
		obj = component;
	}

	public UIInputOnGUI()
	{
		//IL_0012: Expected Obj, but got I4
		bool flag = GUI.enabled;
		EventModifiers modifiers = ((Event)flag).modifiers;
		if (modifiers == EventModifiers.Alt)
		{
			bool flag2 = GUI.enabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
	}
}
