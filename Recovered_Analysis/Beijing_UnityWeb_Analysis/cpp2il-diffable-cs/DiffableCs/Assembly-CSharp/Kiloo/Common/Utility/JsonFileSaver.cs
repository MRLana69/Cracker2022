namespace Kiloo.Common.Utility;

public class JsonFileSaver : IFileSaver
{
	private readonly IJsonSerializer _jsonSerializer; //Field offset: 0x8

	public JsonFileSaver(IJsonSerializer jsonSerializer) { }

	public T Load(string file) { }

	private static void LogError(string msg) { }

	public void Save(string file, object obj) { }

	public bool TryLoad(string file, out T obj) { }

}

