namespace SYBO.Components.Analytics.Integration;

public class SessionTracker
{
	private int _sessionTimeoutSeconds; //Field offset: 0x8
	private long _msTicksWhenLastActive; //Field offset: 0x10

	public SessionTracker(int sessionTimeoutSeconds) { }

	public long GetMSTicksSinceLastActive() { }

	public void RegisterLastActiveMsTicks() { }

	public bool ShouldStartNewSession() { }

	public bool ShouldStartNewSession(long msTicksSinceLastActive) { }

}

