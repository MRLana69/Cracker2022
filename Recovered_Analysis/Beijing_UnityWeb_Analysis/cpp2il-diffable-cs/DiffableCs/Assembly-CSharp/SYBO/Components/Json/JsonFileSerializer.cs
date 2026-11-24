namespace SYBO.Components.Json;

public class JsonFileSerializer
{
	public delegate GetFileTextDelegate
	{

		public GetFileTextDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string filename, AsyncCallback callback, object object) { }

		public virtual string EndInvoke(IAsyncResult result) { }

		public virtual string Invoke(string filename) { }

	}

	public delegate WriteFileTextDelegate
	{

		public WriteFileTextDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string filename, string text, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string filename, string text) { }

	}

	private GetFileTextDelegate _getFileText; //Field offset: 0x8
	private WriteFileTextDelegate _writeFileText; //Field offset: 0xC

	public JsonFileSerializer(GetFileTextDelegate getFileText, WriteFileTextDelegate writeFileText) { }

	private object DeserializeFromFile(Type type, string filename, JsonContext context) { }

	public object DeserializeFromMultipleFiles(Type type, string filename, JsonContext context = null) { }

	private void SerializeToFile(Type type, object obj, string filename, JsonContext context) { }

	public void SerializeToMultipleFiles(Type type, object obj, string filename, JsonContext context = null) { }

}

