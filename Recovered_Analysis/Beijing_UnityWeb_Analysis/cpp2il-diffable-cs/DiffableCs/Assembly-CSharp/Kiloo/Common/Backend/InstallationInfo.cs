namespace Kiloo.Common.Backend;

public class InstallationInfo : IInstallationInfo
{
	private class InstallationInfoModel
	{
		public string id; //Field offset: 0x8

		public InstallationInfoModel() { }

	}

	private const string INSTALLATION_INFO_FILE = ".installationInfo"; //Field offset: 0x0
	private readonly IFileSaver _fileSaver; //Field offset: 0x8
	private InstallationInfoModel _info; //Field offset: 0xC

	public string id
	{
		 get { } //Length: 137
	}

	public InstallationInfo(IFileSaver fileSaver) { }

	public static void DeleteInfoDebug() { }

	public string get_id() { }

	private InstallationInfoModel GetInfo() { }

	private void LogError(string msg) { }

}

