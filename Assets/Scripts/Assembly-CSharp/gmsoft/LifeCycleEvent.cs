using System;

namespace gmsoft;

[Serializable]
public class LifeCycleEvent : AnalyticEvent
{
	public LifeCycleEventTracker.LifeCycle lifeCycle;
}
