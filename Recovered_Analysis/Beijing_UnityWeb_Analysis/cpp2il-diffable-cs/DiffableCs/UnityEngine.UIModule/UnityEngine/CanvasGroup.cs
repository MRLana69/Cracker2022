namespace UnityEngine;

public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{

	public float alpha
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public bool blocksRaycasts
	{
		 get { } //Length: 49
	}

	public bool ignoreParentGroups
	{
		 get { } //Length: 49
	}

	public bool interactable
	{
		 get { } //Length: 12
	}

	public float get_alpha() { }

	public bool get_blocksRaycasts() { }

	public bool get_ignoreParentGroups() { }

	public bool get_interactable() { }

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public void set_alpha(float value) { }

}

