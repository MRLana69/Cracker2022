namespace SYBO.Components.Analytics;

public class AnalyticsIntegrationConstants
{
	public const string PrefsKeySamplingKey = "AnalyticsComponent_SamplingKey"; //Field offset: 0x0
	public const string PrefsKeySessionCounter = "AnalyticsComponent_SessionCounter"; //Field offset: 0x0
	public const int PrefsKeySessionCounterDefault = -1; //Field offset: 0x0
	public const string PrefsKeyUserID = "AnalyticsComponent_UserID"; //Field offset: 0x0
	public const string PrefsKeyClientVersion = "AnalyticsComponent_ClientVersion"; //Field offset: 0x0
	public const string PrefsKeyDeviceInfo = "AnalyticsComponent_DeviceInfo"; //Field offset: 0x0
	public const string PrefsKeySessionEventNumber = "AnalyticsComponent_SessionEventNumber"; //Field offset: 0x0
	public const int PrefsKeySessionEventNumberDefault = -1; //Field offset: 0x0
	public const string PrefsKeyLeavesForegroundTime = "LeavesForegroundTime"; //Field offset: 0x0
	public static readonly string PrefsKeyLeavesForegroundTimeDefault; //Field offset: 0x0
	public const string PrefsKeyLeavesForegroundSessionDelta = "LeavesForegroundSessionDelta"; //Field offset: 0x0
	public const int PrefsKeyLeavesForegroundSessionDeltaDefault = -1; //Field offset: 0x0
	public const int EventJsonDeviceIdFieldSize = 44; //Field offset: 0x0

	private static AnalyticsIntegrationConstants() { }

	public AnalyticsIntegrationConstants() { }

}

