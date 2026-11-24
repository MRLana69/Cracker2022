namespace Kiloo.Common.Utility;

public interface IJsonSerializer
{
	string ToJson(object value);

	T FromJson<T>(string json);
}
