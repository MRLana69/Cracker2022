namespace SYBO.Components.Json;

public class LocalStorage`1
{
	protected JsonContext _jsonContext; //Field offset: 0x0
	protected string _localUrl; //Field offset: 0x0
	private IStringStorage _stringStorage; //Field offset: 0x0
	private T _object; //Field offset: 0x0

	public bool CanLoad
	{
		 get { } //Length: 6
	}

	public string LocalUrl
	{
		 get { } //Length: 6
	}

	public T Object
	{
		 get { } //Length: 9
	}

	public LocalStorage`1(T obj, string localUrl, JsonContext jsonContext = null, IStringStorage stringStorage = null) { }

	public bool Clear() { }

	public void DeleteLocalFile() { }

	public bool get_CanLoad() { }

	public string get_LocalUrl() { }

	public T get_Object() { }

	public bool Read() { }

	public void ReadAndSerializeOnto(T targetObject) { }

	public bool Write() { }

}

