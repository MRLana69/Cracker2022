using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIForwardEvents : MonoBehaviour
{
	public GameObject target;

	public bool onHover;

	public bool onPress;

	public bool onClick;

	public bool onDoubleClick;

	public bool onSelect;

	public bool onDrag;

	public bool onDrop;

	public bool onSubmit;

	public bool onScroll;

	private void OnHover(bool isOver)
	{
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_00a7: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)UIEventTrigger.current).FindKernel((string)null) != 0)
		{
			return;
		}
		UIEventTrigger.current = (UIEventTrigger)(object)this;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v17 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIForwardEvents)+3C]");
		Localization.dictionary = (Dictionary<string, string[]>)0;
		UIEventTrigger.current = null;
	}

	private void OnPress(bool pressed)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		if (~(onHover ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			object obj2 = pressed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object parameter = default;
			target.BroadcastMessage("OnHover", parameter, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnClick()
	{
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list2 = default;
		list2._002Ector();
		object obj2 = this + 16;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list3 = default;
		list3._002Ector();
		object obj3 = this + 20;
		obj3 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list4 = default;
		list4._002Ector();
		object obj4 = this + 24;
		obj4 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list5 = default;
		list5._002Ector();
		object obj5 = this + 28;
		obj5 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list6 = default;
		list6._002Ector();
		object obj6 = this + 32;
		obj6 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list7 = default;
		list7._002Ector();
		object obj7 = this + 36;
		obj7 = list7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list8 = default;
		list8._002Ector();
		object obj8 = this + 40;
		obj8 = list8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list9 = default;
		list9._002Ector();
		object obj9 = this + 44;
		obj9 = list9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list10 = default;
		list10._002Ector();
		object obj10 = this + 48;
		obj10 = list10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list11 = default;
		list11._002Ector();
		object obj11 = this + 52;
		obj11 = list11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list12 = default;
		list12._002Ector();
		object obj12 = this + 56;
		obj12 = list12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list13 = default;
		list13._002Ector();
		object obj13 = this + 60;
		obj13 = list13;
		CancelInvoke();
	}

	private unsafe void OnDoubleClick()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_00a3: Expected native int or pointer, but got Obj
		if (~(onClick ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			*(RangeInt*)(nint)target = new RangeInt((int)"OnClick", 1);
		}
	}

	private void OnSelect(bool selected)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		if (~(onPress ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			object obj2 = selected;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object parameter = default;
			target.BroadcastMessage("OnPress", parameter, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnDrag(Vector2 delta)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = delta & 1;
		if (~(onSelect ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object parameter = default;
			target.BroadcastMessage("OnSelect", parameter, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnDrop(GameObject go)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (~(onDrag ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object parameter = default;
			target.BroadcastMessage("OnDrag", parameter, SendMessageOptions.DontRequireReceiver);
		}
	}

	private unsafe void OnSubmit()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_00a3: Expected native int or pointer, but got Obj
		if (~(onDoubleClick ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			*(RangeInt*)(nint)target = new RangeInt((int)"OnDoubleClick", 1);
		}
	}

	private void OnScroll(float delta)
	{
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Object.IsNativeObjectAlive((Object)target))
		{
			return;
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			((UISlider)(object)target).sliderValue = delta;
		}
	}

	public unsafe UIForwardEvents()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_00a3: Expected native int or pointer, but got Obj
		if (~(onSubmit ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			*(RangeInt*)(nint)target = new RangeInt((int)"OnSubmit", 1);
		}
	}
}
