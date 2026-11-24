namespace SYBO.Components.Analytics.Integration;

public class DeviceInfoEvent : SubwayBaseSessionEvent
{
	public readonly string DeviceOS; //Field offset: 0x24
	public readonly string DevicePlatformConfig; //Field offset: 0x28
	public readonly string Device; //Field offset: 0x2C
	public readonly string DeviceID; //Field offset: 0x30
	public readonly string Language; //Field offset: 0x34
	public readonly int PerformanceLevel; //Field offset: 0x38
	public readonly int ScreenHeight; //Field offset: 0x3C
	public readonly int ScreenWidth; //Field offset: 0x40
	public readonly int ScreenPPI; //Field offset: 0x44
	public readonly string Gpu; //Field offset: 0x48
	public readonly int GpuScore; //Field offset: 0x4C
	public readonly int CpuTreads; //Field offset: 0x50
	public readonly int CpuFrequencey; //Field offset: 0x54
	public readonly int SystemMemory; //Field offset: 0x58
	public readonly string OnlineSettingsLocale; //Field offset: 0x5C

	public override string EventName
	{
		 get { } //Length: 6
	}

	public DeviceInfoEvent() { }

	public override string get_EventName() { }

	public PerformanceLevel GetPerformanceLevel() { }

	public static string GetTrimmedGPUName() { }

}

