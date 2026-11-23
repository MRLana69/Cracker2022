using System;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public abstract class CharacterTriggeredTrackEvent : TrackEvent
{
	protected CharacterPassTrigger _trigger;

	public TrackEventTrigger Trigger => _trigger;

	protected unsafe override void Initialize()
	{
		base.Initialize();
		Transform transform = base.transform;
		_transform = transform;
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(CharacterTriggeredTrackEvent.CharacterPassTrigger_Triggered));
		_trigger.Triggered += eventHandler;
	}

	protected unsafe override void OnDestroy()
	{
		base.OnDestroy();
		if (_trigger != null)
		{
			EventHandler eventHandler = default;
			eventHandler._002Ector(this, (nint)__ldftn(CharacterTriggeredTrackEvent.CharacterPassTrigger_Triggered));
			_trigger.Triggered -= eventHandler;
		}
	}

	private void CharacterPassTrigger_Triggered(object sender, EventArgs e)
	{
		if (~(_launched ? 1u : 0u) != 0)
		{
			EvaluateAndLaunchEvent();
		}
	}
}
