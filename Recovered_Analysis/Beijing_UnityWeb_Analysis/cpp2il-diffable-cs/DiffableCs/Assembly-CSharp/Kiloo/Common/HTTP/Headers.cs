namespace Kiloo.Common.HTTP;

public class Headers : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	private sealed class <GetEnumerator>d__26 : IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private KeyValuePair<string, string> <>2__current; //Field offset: 0xC
		public Headers <>4__this; //Field offset: 0x14
		private Enumerator<string, List<string>> <>7__wrap1; //Field offset: 0x18

		private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
		{
			 get { } //Length: 8
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 783
		}

		public <GetEnumerator>d__26(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static readonly string[] _niceNameExceptions; //Field offset: 0x0
	private readonly Dictionary<string, List<string>> _headers; //Field offset: 0x8
	private string _contentType; //Field offset: 0xC
	private ContentType _parsedContentType; //Field offset: 0x10

	public ContentType contentType
	{
		 get { } //Length: 508
	}

	public int Count
	{
		 get { } //Length: 6
	}

	public string Item
	{
		 get { } //Length: 95
		 set { } //Length: 11
	}

	private static Headers() { }

	public Headers() { }

	public Headers Add(KeyValuePair<string, string> header) { }

	public Headers Add(string name, object value) { }

	public Headers AddAll(IEnumerable<KeyValuePair<string, string>> headers) { }

	public void Clear() { }

	public bool Contains(string name) { }

	private string ConvertValue(object value) { }

	public string Get(string name) { }

	public string Get(string name, string defaultValue) { }

	public DateTime Get(string name, DateTime defaultValue, bool allowDeltaTimeSeconds = false) { }

	public Nullable<DateTime> Get(string name, Nullable<DateTime> defaultValue, bool allowDeltaTimeSeconds = false) { }

	public long Get(string name, long defaultValue) { }

	public ContentType get_contentType() { }

	public int get_Count() { }

	public string get_Item(string name) { }

	public IEnumerable<string> GetAll(string name) { }

	public IEnumerator<KeyValuePair<string, string>> GetEnumerator() { }

	public Dictionary<string, List<string>> GetInternalDictionary() { }

	private static bool IsNameNice(string name) { }

	private static string NicifyName(string name) { }

	public void ReadFrom(BinaryReader reader) { }

	public void Remove(string name) { }

	public Headers Set(string name, object value) { }

	public void set_Item(string name, string value) { }

	public Headers SetAll(IEnumerable<KeyValuePair<string, string>> headers) { }

	public Headers SetAll(string name, IEnumerable<string> values) { }

	public Headers SetAll(Dictionary<string, List<string>> headers) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override string ToString() { }

	public void WriteTo(BinaryWriter writer) { }

}

