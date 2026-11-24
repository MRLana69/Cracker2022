namespace SYBO.Components.Utilities;

public class EnvironmentUtility
{
	public const ActiveTargetPlatform ActiveTargetPlatform = 0; //Field offset: 0x0
	public const string ActiveTargetPlatformString = "unknown"; //Field offset: 0x0

	public static string BuildNumber
	{
		 get { } //Length: 77
	}

	public static string GitBranch
	{
		 get { } //Length: 49
	}

	public static string GitCommit
	{
		 get { } //Length: 49
	}

	public static bool IsMainThread
	{
		 get { } //Length: 3
	}

	public static bool IsRunningUnitTests
	{
		 get { } //Length: 55
	}

	public static string Path
	{
		 get { } //Length: 49
	}

	public static string Workspace
	{
		 get { } //Length: 49
	}

	public EnvironmentUtility() { }

	public static string get_BuildNumber() { }

	public static string get_GitBranch() { }

	public static string get_GitCommit() { }

	public static bool get_IsMainThread() { }

	public static bool get_IsRunningUnitTests() { }

	public static string get_Path() { }

	public static string get_Workspace() { }

	public static string GetEnvironmentVariable(string name) { }

	public static bool HasEnvironmentVariable(string name) { }

	public static bool IsBatchMode() { }

	public static void SetEnvironmentVariable(string name, string value) { }

}

