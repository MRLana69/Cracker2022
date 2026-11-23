using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonEvent : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private bool _isPressed;

	public UnityEvent OnPress;

	public UnityEvent OnRelease;

	private void OnEnable()
	{
		_isPressed = false;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		_isPressed = true;
		OnPress.Invoke();
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if (~(_isPressed ? 1u : 0u) == 0)
		{
			_isPressed = false;
			OnRelease.Invoke();
		}
	}
}
