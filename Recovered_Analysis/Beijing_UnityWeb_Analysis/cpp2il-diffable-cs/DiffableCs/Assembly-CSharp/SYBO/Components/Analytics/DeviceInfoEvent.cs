namespace SYBO.Components.Analytics;

public class DeviceInfoEvent : BaseSessionEvent
{
	public readonly string DeviceOS; //Field offset: 0x24
	public readonly string Device; //Field offset: 0x28
	public readonly string DeviceID; //Field offset: 0x2C
	public readonly string Language; //Field offset: 0x30
	public readonly int ScreenHeight; //Field offset: 0x34
	public readonly int ScreenWidth; //Field offset: 0x38
	public readonly int ScreenPPI; //Field offset: 0x3C
	public readonly string Gpu; //Field offset: 0x40
	public readonly int CpuTreads; //Field offset: 0x44
	public readonly int CpuFrequencey; //Field offset: 0x48
	public readonly int SystemMemory; //Field offset: 0x4C

	public override string EventName
	{
		 get { } //Length: 43
	}

	public DeviceInfoEvent() { }

	protected DeviceInfoEvent(bool initializeParentValues) { }

	public override string get_EventName() { }

	public static string GetDeviceInfoJson() { }

	public static string GetTrimmedGPUName() { }

}

