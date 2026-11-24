namespace UnityEngine;

public static class StackTraceUtility
{
	private static string projectFolder; //Field offset: 0x0

	private static StackTraceUtility() { }

	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	public static string ExtractStackTrace() { }

	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	private static bool IsSystemStacktraceType(object name) { }

	internal static string PostprocessStacktrace(string oldString, bool stripEngineInternalInformation) { }

	internal static void SetProjectFolder(string folder) { }

}

