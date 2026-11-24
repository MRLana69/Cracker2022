namespace Kiloo.Common.HTTP;

public static class ResponseExtensions
{

	public static string AsString(IResponse response) { }

	public static Texture2D AsTexture(IResponse response) { }

	public static bool IsBson(IResponse response) { }

	public static bool IsJson(IResponse response) { }

	public static bool IsTexture(IResponse response) { }

	public static T ParseBson(IResponse response, IBsonSerializer bsonSerializer) { }

	public static T ParseJson(IResponse response, IJsonSerializer jsonSerializer) { }

	public static bool TryParseBson(IResponse response, out T result, IBsonSerializer bsonSerializer) { }

	public static bool TryParseJson(IResponse response, out T result, IJsonSerializer jsonSerializer) { }

}

