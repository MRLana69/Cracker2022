namespace Kiloo.Common.Utility;

public static class BsonConverterExtensions
{

	public static T FromBson(IBsonSerializer serializer, byte[] data) { }

	public static byte[] ToBson(IBsonSerializer serializer, object value) { }

}

