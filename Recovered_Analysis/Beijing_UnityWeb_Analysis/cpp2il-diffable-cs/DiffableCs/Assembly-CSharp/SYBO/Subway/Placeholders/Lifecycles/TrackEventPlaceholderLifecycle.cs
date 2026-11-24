namespace SYBO.Subway.Placeholders.Lifecycles;

public class TrackEventPlaceholderLifecycle : PlaceholderLifecycle
{
	private TrackEvent _trackEvent; //Field offset: 0x18

	public TrackEventPlaceholderLifecycle() { }

	protected override void Initialize() { }

	private void OnDestroy() { }

	private void TrackEvent_Launching() { }

	private void TrackEvent_Stopped() { }

}

