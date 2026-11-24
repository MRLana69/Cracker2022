namespace System.Diagnostics;

public class Process : Component
{
	private struct ProcInfo
	{
		public nint process_handle; //Field offset: 0x0
		public int pid; //Field offset: 0x4
		public string[] envVariables; //Field offset: 0x8
		public string UserName; //Field offset: 0xC
		public string Domain; //Field offset: 0x10
		public nint Password; //Field offset: 0x14
		public bool LoadUserProfile; //Field offset: 0x18

	}

	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12,
	}

	private enum StreamReadMode
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2,
	}

	private bool haveProcessId; //Field offset: 0x14
	private int processId; //Field offset: 0x18
	private bool haveProcessHandle; //Field offset: 0x1C
	private SafeProcessHandle m_processHandle; //Field offset: 0x20
	private bool isRemoteMachine; //Field offset: 0x24
	private string machineName; //Field offset: 0x28
	private int m_processAccess; //Field offset: 0x2C
	private ProcessThreadCollection threads; //Field offset: 0x30
	private ProcessModuleCollection modules; //Field offset: 0x34
	private bool haveWorkingSetLimits; //Field offset: 0x38
	private bool havePriorityClass; //Field offset: 0x39
	private ProcessStartInfo startInfo; //Field offset: 0x3C
	private bool watchForExit; //Field offset: 0x40
	private bool watchingForExit; //Field offset: 0x41
	private EventHandler onExited; //Field offset: 0x44
	private bool exited; //Field offset: 0x48
	private int exitCode; //Field offset: 0x4C
	private bool signaled; //Field offset: 0x50
	private bool haveExitTime; //Field offset: 0x51
	private bool raisedOnExited; //Field offset: 0x52
	private RegisteredWaitHandle registeredWaitHandle; //Field offset: 0x54
	private WaitHandle waitHandle; //Field offset: 0x58
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0x5C
	private StreamReader standardOutput; //Field offset: 0x60
	private StreamWriter standardInput; //Field offset: 0x64
	private StreamReader standardError; //Field offset: 0x68
	private bool disposed; //Field offset: 0x6C
	private StreamReadMode outputStreamReadMode; //Field offset: 0x70
	private StreamReadMode errorStreamReadMode; //Field offset: 0x74
	private StreamReadMode inputStreamReadMode; //Field offset: 0x78
	internal AsyncStreamReader output; //Field offset: 0x7C
	internal AsyncStreamReader error; //Field offset: 0x80
	private string process_name; //Field offset: 0x84

	private bool Associated
	{
		 get { } //Length: 6
	}

	public nint Handle
	{
		 get { } //Length: 1217
	}

	public bool HasExited
	{
		 get { } //Length: 20
	}

	private static bool IsWindows
	{
		 get { } //Length: 95
	}

	public string ProcessName
	{
		 get { } //Length: 323
	}

	public ProcessStartInfo StartInfo
	{
		 get { } //Length: 27
		 set { } //Length: 427
	}

	public ISynchronizeInvoke SynchronizingObject
	{
		 get { } //Length: 81
	}

	public Process() { }

	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	public void Close() { }

	private void CompletionCallback(object context, bool wasSignaled) { }

	private static void CreatePipe(out nint read, out nint write, bool writeDirection) { }

	private static bool CreateProcess_internal(ProcessStartInfo startInfo, nint stdin, nint stdout, nint stderr, ref ProcInfo procInfo) { }

	protected override void Dispose(bool disposing) { }

	private void EnsureState(State state) { }

	private void EnsureWatchingForExit() { }

	private static void FillUserInfo(ProcessStartInfo startInfo, ref ProcInfo procInfo) { }

	private bool get_Associated() { }

	public nint get_Handle() { }

	public bool get_HasExited() { }

	private static bool get_IsWindows() { }

	public string get_ProcessName() { }

	public ProcessStartInfo get_StartInfo() { }

	public ISynchronizeInvoke get_SynchronizingObject() { }

	public static Process GetCurrentProcess() { }

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	private SafeProcessHandle GetProcessHandle(int access) { }

	protected void OnExited() { }

	private SafeProcessHandle OpenProcessHandle(int access) { }

	private static string ProcessName_internal(SafeProcessHandle handle) { }

	private static string ProcessName_internal(nint handle) { }

	private void RaiseOnExited() { }

	public void Refresh() { }

	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	public void set_StartInfo(ProcessStartInfo value) { }

	private void SetProcessHandle(SafeProcessHandle processHandle) { }

	private void SetProcessId(int processId) { }

	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref ProcInfo procInfo) { }

	public static Process Start(ProcessStartInfo startInfo) { }

	public static Process Start(string fileName) { }

	public bool Start() { }

	public static Process Start(string fileName, string arguments) { }

	private bool StartWithCreateProcess(ProcessStartInfo startInfo) { }

	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) { }

	private void StopWatchingForExit() { }

	public override string ToString() { }

}

