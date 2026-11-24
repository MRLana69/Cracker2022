namespace Kiloo.Serialization;

public static class BsonBinaryWriterExtensions
{
	private static readonly DateTime _epoch; //Field offset: 0x0

	private static BsonBinaryWriterExtensions() { }

	private static bool CanBeBsonObject(object obj) { }

	private static void WriteBsonArray(BinaryWriter writer, IEnumerable array) { }

	private static void WriteBsonBinaryData(BinaryWriter writer, byte subType, byte[] buf) { }

	private static void WriteBsonCString(BinaryWriter writer, string value) { }

	private static void WriteBsonDateTime(BinaryWriter writer, DateTime value) { }

	public static void WriteBsonObject(BinaryWriter writer, object obj) { }

	private static void WriteBsonProperty(BinaryWriter writer, string name, object value) { }

	private static void WriteBsonString(BinaryWriter writer, string value) { }

}

