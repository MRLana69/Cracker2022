namespace Kiloo.Common.Utility;

public class DataStore`1
{
	public abstract class BaseValue
	{
		public const byte TYPE_BOOL = 0; //Field offset: 0x0
		public const byte TYPE_BOOL_ARRAY = 1; //Field offset: 0x0
		public const byte TYPE_FLOAT = 2; //Field offset: 0x0
		public const byte TYPE_FLOAT_ARRAY = 3; //Field offset: 0x0
		public const byte TYPE_ENUM = 4; //Field offset: 0x0
		public const byte TYPE_ENUM_ARRAY = 5; //Field offset: 0x0
		public const byte TYPE_INT = 6; //Field offset: 0x0
		public const byte TYPE_INT_ARRAY = 7; //Field offset: 0x0
		public const byte TYPE_STRING = 8; //Field offset: 0x0
		public const byte TYPE_STRING_ARRAY = 9; //Field offset: 0x0
		public const byte TYPE_DATETIME = 10; //Field offset: 0x0
		public TEnum key; //Field offset: 0x0
		public Action<TEnum> onValueChanged; //Field offset: 0x0

		protected BaseValue() { }

		public abstract object GetValue() { }

		public static BaseValue<TEnum> ReadFrom(BinaryReader reader) { }

		public abstract void SetValue(object value) { }

		public abstract void SetValueFrom(BaseValue<TEnum> other) { }

		public abstract void WriteTo(BinaryWriter writer) { }

	}

	public delegate Convert
	{

		public Convert(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(TEnum e, AsyncCallback callback, object object) { }

		public virtual int EndInvoke(IAsyncResult result) { }

		public virtual int Invoke(TEnum e) { }

	}

	public class Value`1
	{
		public T value; //Field offset: 0x0

		public Value`1() { }

		public Value`1(Value<TEnum, T> copyFrom) { }

		public Value`1(TEnum key, T value) { }

		public override bool Equals(object obj) { }

		public override int GetHashCode() { }

		public override object GetValue() { }

		public override void SetValue(object v) { }

		public void SetValueFrom(Value<TEnum, T> other) { }

		public override void SetValueFrom(BaseValue<TEnum> other) { }

		public override string ToString() { }

		public override void WriteTo(BinaryWriter writer) { }

	}

	private const string BASE_SIGNATURE = "DS1."; //Field offset: 0x0
	private readonly BaseValue<TEnum>[] _defaults; //Field offset: 0x0
	private BaseValue<TEnum>[] _values; //Field offset: 0x0
	private bool _dirty; //Field offset: 0x0
	private readonly Convert<TEnum> _convert; //Field offset: 0x0

	public bool isDirty
	{
		 get { } //Length: 0
	}

	public string signature
	{
		 get { } //Length: 0
	}

	private static DataStore`1() { }

	public DataStore`1(BaseValue<TEnum>[] defaults, Convert<TEnum> convert) { }

	public void AddChangedHandler(TEnum key, Action<TEnum> handler) { }

	public void ApplyValues(BaseValue<TEnum>[] newValues) { }

	private static void Assert(bool condition, string msg) { }

	public void ClearDirty() { }

	private int DefaultConvert(TEnum e) { }

	public bool get_isDirty() { }

	public string get_signature() { }

	public T GetArrayValue(TEnum key, int index) { }

	public T GetValue(TEnum key) { }

	private static void LogError(string msg) { }

	public void ReadFrom(Stream stream) { }

	public static DataStore<TEnum> ReadFrom(Stream stream, BaseValue<TEnum>[] defaults, Convert<TEnum> convert) { }

	public void RemoveChangedHandler(TEnum key, Action<TEnum> handler) { }

	public void SetArrayValue(TEnum key, int index, T value) { }

	public void SetValue(TEnum key, T value) { }

	public bool Toggle(TEnum key) { }

	private static bool ValidateValues(BaseValue<TEnum>[] values, Convert<TEnum> convert) { }

	public void WriteTo(Stream stream) { }

}

