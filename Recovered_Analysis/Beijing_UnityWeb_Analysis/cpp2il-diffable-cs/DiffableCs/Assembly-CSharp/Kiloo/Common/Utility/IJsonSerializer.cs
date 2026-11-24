namespace Kiloo.Common.Utility;

public interface IJsonSerializer
{

	public T FromJson(string json) { }

	public string ToJson(object value) { }

}

