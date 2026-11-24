namespace Kiloo.Serialization;

public static class BsonBinaryReaderExtensions
{

	private static IList ReadBsonArray(BinaryReader reader, bool ignoreCase, ref int bytesRead) { }

	private static string ReadBsonCString(BinaryReader reader, ref int bytesRead) { }

	public static IDictionary ReadBsonObject(BinaryReader reader, bool ignoreCase) { }

	private static IDictionary ReadBsonObject(BinaryReader reader, bool ignoreCase, ref int bytesRead) { }

	private static KeyValuePair<string, object> ReadBsonProperty(BinaryReader reader, bool ignoreCase, ref int bytesRead) { }

	private static string ReadBsonString(BinaryReader reader, ref int bytesRead) { }

}

