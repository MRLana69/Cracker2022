namespace System.Diagnostics;

public sealed class ProcessStartInfo
{
	private static readonly string[] empty; //Field offset: 0x0
	private string fileName; //Field offset: 0x8
	private string arguments; //Field offset: 0xC
	private string directory; //Field offset: 0x10
	private string verb; //Field offset: 0x14
	private ProcessWindowStyle windowStyle; //Field offset: 0x18
	private bool errorDialog; //Field offset: 0x1C
	private nint errorDialogParentHandle; //Field offset: 0x20
	private bool useShellExecute; //Field offset: 0x24
	private string userName; //Field offset: 0x28
	private string domain; //Field offset: 0x2C
	private SecureString password; //Field offset: 0x30
	private string passwordInClearText; //Field offset: 0x34
	private bool loadUserProfile; //Field offset: 0x38
	private bool redirectStandardInput; //Field offset: 0x39
	private bool redirectStandardOutput; //Field offset: 0x3A
	private bool redirectStandardError; //Field offset: 0x3B
	private Encoding standardOutputEncoding; //Field offset: 0x3C
	private Encoding standardErrorEncoding; //Field offset: 0x40
	private bool createNoWindow; //Field offset: 0x44
	private WeakReference weakParentProcess; //Field offset: 0x48
	internal StringDictionary environmentVariables; //Field offset: 0x4C
	private IDictionary<string, string> environment; //Field offset: 0x50

	public string Arguments
	{
		 get { } //Length: 714
	}

	public string Domain
	{
		 get { } //Length: 6
	}

	public StringDictionary EnvironmentVariables
	{
		 get { } //Length: 63
	}

	public string FileName
	{
		 get { } //Length: 9
	}

	internal bool HaveEnvVars
	{
		 get { } //Length: 63
	}

	public bool LoadUserProfile
	{
		 get { } //Length: 63
	}

	public SecureString Password
	{
		 get { } //Length: 63
	}

	public bool RedirectStandardError
	{
		 get { } //Length: 9
	}

	public bool RedirectStandardInput
	{
		 get { } //Length: 767
	}

	public bool RedirectStandardOutput
	{
		 get { } //Length: 9
	}

	public Encoding StandardErrorEncoding
	{
		 get { } //Length: 9
	}

	public Encoding StandardOutputEncoding
	{
		 get { } //Length: 9
	}

	public string UserName
	{
		 get { } //Length: 9
	}

	public bool UseShellExecute
	{
		 get { } //Length: 6
	}

	public string WorkingDirectory
	{
		 get { } //Length: 63
	}

	private static ProcessStartInfo() { }

	public ProcessStartInfo(string fileName, string arguments) { }

	internal ProcessStartInfo(Process parent) { }

	public ProcessStartInfo(string fileName) { }

	public string get_Arguments() { }

	public string get_Domain() { }

	public StringDictionary get_EnvironmentVariables() { }

	public string get_FileName() { }

	internal bool get_HaveEnvVars() { }

	public bool get_LoadUserProfile() { }

	public SecureString get_Password() { }

	public bool get_RedirectStandardError() { }

	public bool get_RedirectStandardInput() { }

	public bool get_RedirectStandardOutput() { }

	public Encoding get_StandardErrorEncoding() { }

	public Encoding get_StandardOutputEncoding() { }

	public string get_UserName() { }

	public bool get_UseShellExecute() { }

	public string get_WorkingDirectory() { }

}

