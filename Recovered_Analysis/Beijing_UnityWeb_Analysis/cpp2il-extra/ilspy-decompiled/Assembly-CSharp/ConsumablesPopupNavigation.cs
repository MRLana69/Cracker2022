using UI.Popups;
using UnityEngine;

public class ConsumablesPopupNavigation : MonoBehaviour
{
	private void Update()
	{
		_ = 1;
		CancelInvoke();
	}

	public ConsumablesPopupNavigation()
	{
		//IL_0049: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got VT
		//IL_000f: Expected Obj, but got I4
		if (Input.GetKeyDown((string)32) || Input.GetKeyDown((string)13))
		{
			_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			((ConsumablesPopup)componentInChildren).OnVideoButtonClicked();
		}
	}
}
