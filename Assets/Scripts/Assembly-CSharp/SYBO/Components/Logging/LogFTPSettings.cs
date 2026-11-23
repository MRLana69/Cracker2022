using System;

namespace SYBO.Components.Logging;

[Serializable]
public class LogFTPSettings
{
	public bool StoreLogsWithFtp = true;

	public string StoreLogsFtpUri = "ftp://ftp.sybogames.com/Logs/Brim/{0}/{1}";

	public int FtpBuffers = 3;

	public string Username = "brimlogsync";

	public string Password = "brimlogsync";
}
