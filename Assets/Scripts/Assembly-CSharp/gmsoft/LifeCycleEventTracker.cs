using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace gmsoft;

public class LifeCycleEventTracker : MonoBehaviour
{
	public enum LifeCycle
	{
		None = 0,
		Awake = 1,
		Start = 2,
		Enable = 4,
		Disable = 8,
		Pause = 0x10,
		Unpause = 0x20,
		Destroy = 0x40
	}

	public List<LifeCycleEvent> events;

	private LifeCycleEvent GetEvent(LifeCycle lifeCycle)
	{
		if (events != null)
		{
			throw new ArgumentException();
		}
		return null;
	}

	private void AnalyticLifeCycle(LifeCycle lifeCycle)
	{
		LifeCycleEvent lifeCycleEvent = GetEvent(lifeCycle);
		if (lifeCycleEvent == null)
		{
			return;
		}
		string text = lifeCycleEvent.name;
		if (~(lifeCycleEvent.hasParams ? 1u : 0u) != 0)
		{
			if (text == null)
			{
				text = "";
			}
			Analytics.LogEvent(text);
			return;
		}
		string eventParam = JsonConvert.SerializeObject(lifeCycleEvent.@params);
		if (lifeCycleEvent.name == null)
		{
			text = "";
		}
		Analytics.LogEventParameter(text, eventParam);
	}

	private void Awake()
	{
		AnalyticLifeCycle(LifeCycle.Awake);
	}

	private void Start()
	{
		AnalyticLifeCycle(LifeCycle.Start);
	}

	private void OnEnable()
	{
		AnalyticLifeCycle(LifeCycle.Enable);
	}

	private void OnDisable()
	{
		AnalyticLifeCycle(LifeCycle.Disable);
	}

	private void OnApplicationPause(bool pause)
	{
		LifeCycle lifeCycle = LifeCycle.Pause;
		if (!pause)
		{
			lifeCycle = LifeCycle.Unpause;
		}
		AnalyticLifeCycle(lifeCycle);
	}

	private void OnDestroy()
	{
		AnalyticLifeCycle(LifeCycle.Destroy);
	}
}
