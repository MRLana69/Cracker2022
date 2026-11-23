using System;
using UnityEngine;

public class BragButtonHelper : MonoBehaviour
{
	private UIButtonOverlayOff uiButtonOverlayOff;

	[NonSerialized]
	public bool buttonEnabled;

	public void EnableButton()
	{
		if (uiButtonOverlayOff == null)
		{
			UIButtonOverlayOff component = GetComponent<UIButtonOverlayOff>();
			uiButtonOverlayOff = component;
		}
		GameObject go = gameObject;
		NGUITools.AddWidgetCollider(go);
		uiButtonOverlayOff.GoToNormalState();
		buttonEnabled = true;
	}

	public void DisableButton()
	{
		if (uiButtonOverlayOff == null)
		{
			UIButtonOverlayOff component = GetComponent<UIButtonOverlayOff>();
			uiButtonOverlayOff = component;
		}
		GameObject gameObject = base.gameObject;
		Collider component2 = gameObject.GetComponent<Collider>();
		if (component2 != null)
		{
			GameObject gameObject2 = base.gameObject;
			Collider component3 = gameObject2.GetComponent<Collider>();
			UnityEngine.Object.Destroy(component3);
		}
		uiButtonOverlayOff.GoToNotAvailableState();
		buttonEnabled = false;
	}
}
