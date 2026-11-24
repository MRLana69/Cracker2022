namespace SYBO.Components.Logging.Ftp;

public class FtpClient
{
	public class FtpException : Exception
	{
		public int ResultCode; //Field offset: 0x44

		public FtpException(string message, int resultCode = -1) { }

		public FtpException(string message, Exception innerException, int resultCode = -1) { }

		public static FtpException FromResult(string result) { }

	}

	private static int BUFFER_SIZE; //Field offset: 0x0
	private static Encoding ASCII; //Field offset: 0x4
	private bool verboseDebugging; //Field offset: 0x8
	private string server; //Field offset: 0xC
	private string remotePath; //Field offset: 0x10
	private string username; //Field offset: 0x14
	private string password; //Field offset: 0x18
	private string message; //Field offset: 0x1C
	private string result; //Field offset: 0x20
	private int port; //Field offset: 0x24
	private int bytes; //Field offset: 0x28
	private int resultCode; //Field offset: 0x2C
	private bool loggedin; //Field offset: 0x30
	private bool binMode; //Field offset: 0x31
	private byte[] buffer; //Field offset: 0x34
	private Socket clientSocket; //Field offset: 0x38
	private int timeoutSeconds; //Field offset: 0x3C

	public bool BinaryMode
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string Password
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public int Port
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string RemotePath
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int RemotePort
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string Server
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int Timeout
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public string Username
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool VerboseDebugging
	{
		 get { } //Length: 81
		 set { } //Length: 153
	}

	private static FtpClient() { }

	public FtpClient(string server, string username, string password, int timeoutSeconds, int port) { }

	public FtpClient() { }

	public FtpClient(string server, string username, string password) { }

	public void AppendFile(string remoteFileName, byte[] data) { }

	public void ChangeDir(string dirName) { }

	private void cleanup() { }

	public void Close() { }

	private Socket createDataSocket() { }

	public void DeleteFile(string fileName) { }

	public void Download(string remFileName, string locFileName, bool resume) { }

	public void Download(string remFileName, string locFileName) { }

	public void Download(string remFileName, bool resume) { }

	public void Download(string remFileName) { }

	protected override void Finalize() { }

	public bool get_BinaryMode() { }

	public string get_Password() { }

	public int get_Port() { }

	public string get_RemotePath() { }

	public int get_RemotePort() { }

	public string get_Server() { }

	public int get_Timeout() { }

	public string get_Username() { }

	public bool get_VerboseDebugging() { }

	public string[] GetFileList(string mask) { }

	public string[] GetFileList() { }

	public long GetFileSize(string fileName) { }

	public void Login() { }

	public void MakeDir(string dirName) { }

	private string readLine() { }

	private void readResponse() { }

	public void RemoveDir(string dirName) { }

	public void RenameFile(string oldFileName, string newFileName, bool overwrite) { }

	private void sendCommand(string command) { }

	public void set_BinaryMode(bool value) { }

	public void set_Password(string value) { }

	public void set_Port(int value) { }

	public void set_RemotePath(string value) { }

	public void set_RemotePort(int value) { }

	public void set_Server(string value) { }

	public void set_Timeout(int value) { }

	public void set_Username(string value) { }

	public void set_VerboseDebugging(bool value) { }

	public void Upload(string fileName, bool resume, string destFilename) { }

	public void Upload(string fileName, bool resume) { }

	public void Upload(string fileName, string destFilename) { }

	public void Upload(string fileName) { }

	public void UploadDirectory(string path, bool recurse, string mask) { }

	public void UploadDirectory(string path, bool recurse) { }

	public void WriteFile(string remoteFileName, byte[] data) { }

}

