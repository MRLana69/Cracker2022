using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIToggledComponents : MonoBehaviour
{
	public List<MonoBehaviour> activate;

	public List<MonoBehaviour> deactivate;

	private MonoBehaviour target;

	private bool inverse;

	private void Awake()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 40;
		obj = list;
		object obj2 = this + 60;
		obj2 = "OnActivate";
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public unsafe void Toggle()
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0118: Expected I, but got Obj
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			List<MonoBehaviour> list = activate;
			if (list._size == 0)
			{
				List<MonoBehaviour> list2 = deactivate;
				if (list2._size == 0)
				{
					if (~(inverse ? 1u : 0u) == 0)
					{
						deactivate.Add(target);
					}
					else
					{
						activate.Add(target);
					}
					goto IL_01b1;
				}
			}
			object obj2 = this + 20;
			obj2 = 0;
		}
		goto IL_01b1;
		IL_01b1:
		UIToggle component = GetComponent<UIToggle>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(UIToggledComponents.Toggle);
		object obj3 = callback + 16;
		obj3 = this;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v14 (Il2CppClass<EventDelegate>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v19 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(component.onChange, callback);
	}

	public UIToggledComponents()
	{
		//IL_005c: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0194: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I4
		if (!isActiveAndEnabled)
		{
			return;
		}
		int num = default;
		int num4 = default;
		while (true)
		{
			List<MonoBehaviour> list = activate;
			if (num >= list._size)
			{
				break;
			}
			MonoBehaviour monoBehaviour = activate.get_Item(num);
			nint num2 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v39 (Il2CppClass<UIToggle>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v55 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIToggle current = UIToggle.current;
			string text;
			if (~(current.mStarted ? 1u : 0u) == 0)
			{
				bool mIsActive = current.mIsActive;
				text = (string)mIsActive;
			}
			else
			{
				bool startsActive = current.startsActive;
				text = (string)startsActive;
			}
			monoBehaviour.tag = text;
			num = num4 + 1;
		}
		int num5 = 0;
		while (true)
		{
			List<MonoBehaviour> list2 = deactivate;
			if (num5 >= list2._size)
			{
				break;
			}
			MonoBehaviour monoBehaviour2 = deactivate.get_Item(num5);
			nint num6 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v14 (Il2CppClass<UIToggle>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num7 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v31 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIToggle current2 = UIToggle.current;
			bool flag = ((~(current2.mStarted ? 1u : 0u) != 0) ? current2.startsActive : current2.mIsActive);
			string text2 = (string)((flag ? 1 : 0) ^ 1);
			monoBehaviour2.tag = text2;
			int num8 = num5 + 1;
			num5 = num8;
		}
	}
}
