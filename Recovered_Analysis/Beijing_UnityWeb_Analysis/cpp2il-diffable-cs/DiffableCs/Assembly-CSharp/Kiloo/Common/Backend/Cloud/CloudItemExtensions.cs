namespace Kiloo.Common.Backend.Cloud;

public static class CloudItemExtensions
{

	public static byte[] GetBytes(ICloudItem item) { }

	public static void SaveToFile(ICloudItem item, string path) { }

	public static int SaveToFileAndOptionallyComputeCrc32(ICloudItem item, string path, bool calclulateCrc32) { }

	public static int SaveToFileComputingCrc32(ICloudItem item, string path) { }

	public static int WriteToStream(ICloudItem item, Stream stream) { }

}

