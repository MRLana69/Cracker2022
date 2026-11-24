namespace SYBO.Components.Logging;

public class LogFTPSettings
{
	public bool StoreLogsWithFtp; //Field offset: 0x8
	public string StoreLogsFtpUri; //Field offset: 0xC
	public int FtpBuffers; //Field offset: 0x10
	public string Username; //Field offset: 0x14
	public string Password; //Field offset: 0x18

	public LogFTPSettings() { }

}

