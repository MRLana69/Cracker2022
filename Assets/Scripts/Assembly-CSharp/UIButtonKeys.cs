using UnityEngine;

public class UIButtonKeys : UIKeyNavigation
{
	public UIButtonKeys selectOnClick;

	public UIButtonKeys selectOnUp;

	public UIButtonKeys selectOnDown;

	public UIButtonKeys selectOnLeft;

	public UIButtonKeys selectOnRight;

	protected override void OnEnable()
	{
		Upgrade();
		base.OnEnable();
	}

	public void Upgrade()
	{
		if (onClick == null && selectOnClick != null)
		{
			GameObject gameObject = selectOnClick.gameObject;
			onClick = gameObject;
			selectOnClick = null;
		}
		if (onLeft == null && selectOnLeft != null)
		{
			GameObject gameObject2 = selectOnLeft.gameObject;
			onLeft = gameObject2;
			selectOnLeft = null;
		}
		if (onRight == null && selectOnRight != null)
		{
			GameObject gameObject3 = selectOnRight.gameObject;
			onRight = gameObject3;
			selectOnRight = null;
		}
		if (onUp == null && selectOnUp != null)
		{
			GameObject gameObject4 = selectOnUp.gameObject;
			onUp = gameObject4;
			selectOnUp = null;
		}
		if (onDown == null && selectOnDown != null)
		{
			GameObject gameObject5 = selectOnDown.gameObject;
			onDown = gameObject5;
			selectOnDown = null;
		}
	}
}
