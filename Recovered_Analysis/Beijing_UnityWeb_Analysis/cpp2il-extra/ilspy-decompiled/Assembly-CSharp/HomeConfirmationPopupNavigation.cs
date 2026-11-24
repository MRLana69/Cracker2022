using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Popups;
using UnityEngine;

public class HomeConfirmationPopupNavigation : MonoBehaviour
{
	public List<UIButtonOverlayOff> buttons;

	private List<UITexture> _buttonHighlight;

	private int _selectedButton;

	private void Init()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 20;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj3 = this + 24;
		obj3 = list;
		_ = 3;
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0013: Expected Obj, but got I4
		UITexture uITexture = _buttonHighlight.get_Item(0);
		uITexture.tag = null;
		UITexture uITexture2 = _buttonHighlight.get_Item(1);
		uITexture2.tag = (string)1;
		UIButtonOverlayOff uIButtonOverlayOff = buttons.get_Item(1);
		BoxCollider component = uIButtonOverlayOff.GetComponent<BoxCollider>();
		component.isTrigger = true;
	}

	public HomeConfirmationPopupNavigation()
	{
		//IL_0081: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got VT
		if (Input.GetKeyDown((string)13) || Input.GetKeyDown((string)32))
		{
			bool isInitialized = AdSystemManager.isInitialized;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (System.Boolean)+E]");
			if ((nint)0 == 0)
			{
				_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
				((HomeConfirmationPopup)componentInChildren).Update();
			}
		}
	}
}
