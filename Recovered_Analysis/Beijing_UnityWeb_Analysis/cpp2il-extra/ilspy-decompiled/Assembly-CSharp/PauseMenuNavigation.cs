using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.MessageCenter;
using UI.Popups;
using UnityEngine;

public class PauseMenuNavigation : MonoBehaviour
{
	public List<UIButtonOverlayOff> buttons;

	private List<UITexture> _buttonHighlight;

	private int _selectedButton;

	private void Init()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		_selectedButton = 2;
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0036: Expected Obj, but got I4
		UITexture uITexture = _buttonHighlight.get_Item(0);
		uITexture.tag = null;
		UITexture uITexture2 = _buttonHighlight.get_Item(1);
		uITexture2.tag = null;
		UITexture uITexture3 = _buttonHighlight.get_Item(2);
		uITexture3.tag = (string)1;
		UIButtonOverlayOff uIButtonOverlayOff = buttons.get_Item(2);
		BoxCollider component = uIButtonOverlayOff.GetComponent<BoxCollider>();
		component.isTrigger = true;
	}

	public unsafe PauseMenuNavigation()
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected I, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0195: Expected I, but got Obj
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_000f: Expected Obj, but got I4
		//IL_0075: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		if (!Input.GetKeyDown((string)13) && !Input.GetKeyDown((string)32))
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v30 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(HomeConfirmationPopup);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((UnityEngine.Object)(object)type).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			UIButtonOverlayOff uIButtonOverlayOff = buttons.get_Item(2);
			UIButtonChangeScreen component = uIButtonOverlayOff.GetComponent<UIButtonChangeScreen>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
