namespace Kiloo.Common.JsonUtil;

public interface IJsonConverter`1
{

	public T DeserializeObject(string value) { }

	public string SerializeObject(T value) { }

}

