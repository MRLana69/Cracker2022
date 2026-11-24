namespace Kiloo.Serialization;

public static class KilooSerializerHTTPExtensions
{

	public static T ParseJson(IResponse response) { }

	public static bool TryParseJson(IResponse response, out T result) { }

	public static IRequest WithJsonContent(IRequest request, object jsonData) { }

}

