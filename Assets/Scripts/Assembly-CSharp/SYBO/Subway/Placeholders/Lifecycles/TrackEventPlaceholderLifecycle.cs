using System;
using SYBO.Subway.Level.TrackEvents;

namespace SYBO.Subway.Placeholders.Lifecycles;

public class TrackEventPlaceholderLifecycle : PlaceholderLifecycle
{
	private TrackEvent _trackEvent;

	protected unsafe override void Initialize()
	{
		base.Initialize();
		if (_trackEvent != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Launching));
			_trackEvent.Launching += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Stopped));
			_trackEvent.Stopped += action2;
		}
	}

	private unsafe void OnDestroy()
	{
		if (_trackEvent != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Launching));
			_trackEvent.Launching -= action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Stopped));
			_trackEvent.Stopped -= action2;
		}
	}

	private void TrackEvent_Launching()
	{
		Spawn();
	}

	private void TrackEvent_Stopped()
	{
		Despawn();
	}
}
