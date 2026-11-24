namespace Kiloo.Common.Utility;

public class BsonFileSaver : IFileSaver
{
	private readonly IBsonSerializer _bsonSerializer; //Field offset: 0x8

	public BsonFileSaver(IBsonSerializer bsonSerializer) { }

	public T Load(string file) { }

	private static void LogError(string msg) { }

	public void Save(string file, object obj) { }

	public bool TryLoad(string file, out T obj) { }

}

