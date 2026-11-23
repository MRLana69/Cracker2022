using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.EventSystems;

namespace gmsoft;

public class UIEventTracker : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
	public enum PointerState
	{
		None = 0,
		Enter = 1,
		Exit = 2,
		Down = 4,
		Up = 8,
		Click = 0x10
	}

	public List<UIEvent> events;

	private UIEvent GetEvent(PointerState pointerState)
	{
		if (events != null)
		{
			throw new ArgumentException();
		}
		return null;
	}

	private void AnalyticsUIEvent(PointerState pointerState)
	{
		UIEvent uIEvent = GetEvent(pointerState);
		if (uIEvent == null)
		{
			return;
		}
		string text = uIEvent.name;
		if (~(uIEvent.hasParams ? 1u : 0u) != 0)
		{
			if (text == null)
			{
				text = "";
			}
			Analytics.LogEvent(text);
			return;
		}
		string eventParam = JsonConvert.SerializeObject(uIEvent.@params);
		if (uIEvent.name == null)
		{
			text = "";
		}
		Analytics.LogEventParameter(text, eventParam);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		AnalyticsUIEvent(PointerState.Click);
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		AnalyticsUIEvent(PointerState.Down);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		AnalyticsUIEvent(PointerState.Enter);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		AnalyticsUIEvent(PointerState.Exit);
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		AnalyticsUIEvent(PointerState.Up);
	}
}
