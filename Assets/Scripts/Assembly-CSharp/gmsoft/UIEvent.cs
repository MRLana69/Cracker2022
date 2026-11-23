using System;

namespace gmsoft;

[Serializable]
public class UIEvent : AnalyticEvent
{
	public UIEventTracker.PointerState pointerState;
}
