namespace System.Threading;

internal static class PlatformHelper
{
	private static int s_processorCount; //Field offset: 0x0
	private static int s_lastProcessorCountRefreshTicks; //Field offset: 0x4

	internal static bool IsSingleProcessor
	{
		 get { } //Length: 134
	}

	internal static int ProcessorCount
	{
		 get { } //Length: 35
	}

	internal static bool get_IsSingleProcessor() { }

	internal static int get_ProcessorCount() { }

}

