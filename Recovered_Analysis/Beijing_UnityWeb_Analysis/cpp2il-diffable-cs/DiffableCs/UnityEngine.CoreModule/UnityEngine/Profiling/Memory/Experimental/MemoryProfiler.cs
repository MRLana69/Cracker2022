namespace UnityEngine.Profiling.Memory.Experimental;

public sealed class MemoryProfiler
{
	private static Action<string, bool> snapshotFinished; //Field offset: 0x0
	private static Action<MetaData> createMetaData; //Field offset: 0x4

	private static void FinalizeSnapshot(string path, bool result) { }

	private static byte[] PrepareMetadata() { }

	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

}

