using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class TutorialHoverboardPopupNavigation : MonoBehaviour
{
	private void Update()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		CancelInvoke();
	}

	public TutorialHoverboardPopupNavigation()
	{
		//IL_0049: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got VT
		//IL_000f: Expected Obj, but got I4
		if (Input.GetKeyDown((string)32) || Input.GetKeyDown((string)13))
		{
			_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			((TutorialHoverboardPopup)componentInChildren).CloseClicked();
		}
	}
}
