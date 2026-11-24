using System;

namespace SYBO.Components.Logging;

[Serializable]
public class LogFTPSettings
{
	public bool StoreLogsWithFtp = true;

	public string StoreLogsFtpUri;

	public int FtpBuffers;

	public string Username;

	public string Password;
}
