using System;
using UnityEngine.Events;

namespace SYBO.Components.Utilities.Tickable;

[Serializable]
public class TickableEvent : UnityEvent<ITickable>
{
	public TickableEvent()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		TickableEvent tickableEvent = (TickableEvent)0;
		_ = 0;
		tickableEvent = (TickableEvent)(-1);
		_ = 0;
		_ = 0;
	}
}
