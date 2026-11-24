namespace Kiloo.Serialization;

public class KilooSerializer : IJsonSerializer, IBsonSerializer
{
	public class Options
	{
		public static Options defaultOptions; //Field offset: 0x0
		public bool indent; //Field offset: 0x8
		public bool ignoreCase; //Field offset: 0x9
		public bool ignoreErrors; //Field offset: 0xA
		public IFormatProvider formatProvider; //Field offset: 0xC

		private static Options() { }

		public Options() { }

	}

	public readonly Options options; //Field offset: 0x8

	public KilooSerializer(Options options = null) { }

	private Array ConvertToArray(Type type, IList jsonList) { }

	private object ConvertToCollection(Type type, IEnumerable enumerable) { }

	private object ConvertToEnum(Type type, object value) { }

	private object ConvertToObject(Type type, IDictionary properties) { }

	private object ConvertValue(Type type, object value, string propertyName) { }

	public object ConvertValue(Type type, object value) { }

	public T ConvertValue(object value) { }

	public object FromBson(Type type, BinaryReader reader) { }

	public object FromBson(BinaryReader reader) { }

	public object FromBson(Type type, byte[] buffer) { }

	public object FromBson(byte[] buffer) { }

	public T FromBson(byte[] buffer) { }

	public T FromBson(BinaryReader reader) { }

	public object FromJson(Type type, string json) { }

	public object FromJson(string json) { }

	public T FromJson(string json) { }

	private static object GetDefault(Type type) { }

	private static string GetDisplayValue(object value) { }

	private Type GetEnumerableElementType(Type enumerableType) { }

	public byte[] ToBson(object value) { }

	public void ToBson(object obj, BinaryWriter writer) { }

	public string ToJson(object obj) { }

	private object TryConstruct(ConstructorInfo constructor, IDictionary properties) { }

}

