using System;
using System.IO;

namespace Kiloo.Common.Utility;

public class DataStore<TEnum> where TEnum : struct
{
	public delegate int Convert(TEnum e);

	public abstract class BaseValue
	{
		public const byte TYPE_BOOL = 0;

		public const byte TYPE_BOOL_ARRAY = 1;

		public const byte TYPE_FLOAT = 2;

		public const byte TYPE_FLOAT_ARRAY = 3;

		public const byte TYPE_ENUM = 4;

		public const byte TYPE_ENUM_ARRAY = 5;

		public const byte TYPE_INT = 6;

		public const byte TYPE_INT_ARRAY = 7;

		public const byte TYPE_STRING = 8;

		public const byte TYPE_STRING_ARRAY = 9;

		public const byte TYPE_DATETIME = 10;

		public TEnum key;

		public Action<TEnum> onValueChanged;

		public abstract void WriteTo(BinaryWriter writer);

		public abstract void SetValueFrom(BaseValue other);

		public abstract object GetValue();

		public abstract void SetValue(object value);

		public static BaseValue ReadFrom(BinaryReader reader)
		{
			return null;
		}
	}

	public class Value<T> : BaseValue
	{
		public T value;

		public Value()
		{
		}

		public Value(Value<T> copyFrom)
		{
		}

		public Value(TEnum key, T value)
		{
		}

		public void SetValueFrom(Value<T> other)
		{
		}

		public override void SetValueFrom(BaseValue other)
		{
		}

		public override object GetValue()
		{
			return null;
		}

		public override void SetValue(object v)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public override void WriteTo(BinaryWriter writer)
		{
		}
	}

	private const string BASE_SIGNATURE = "DS1.";

	private readonly BaseValue[] _defaults;

	private BaseValue[] _values;

	private bool _dirty;

	private readonly Convert _convert;

	public string signature => null;

	public bool isDirty => false;

	public DataStore(BaseValue[] defaults, Convert convert)
	{
	}

	private int DefaultConvert(TEnum e)
	{
		return 0;
	}

	static DataStore()
	{
	}

	public void ClearDirty()
	{
	}

	public T GetValue<T>(TEnum key)
	{
		return default;
	}

	public T GetArrayValue<T>(TEnum key, int index)
	{
		return default;
	}

	public void SetValue<T>(TEnum key, T value)
	{
	}

	public void SetArrayValue<T>(TEnum key, int index, T value)
	{
	}

	public bool Toggle(TEnum key)
	{
		return false;
	}

	public void AddChangedHandler(TEnum key, Action<TEnum> handler)
	{
	}

	public void RemoveChangedHandler(TEnum key, Action<TEnum> handler)
	{
	}

	public void WriteTo(Stream stream)
	{
	}

	public void ReadFrom(Stream stream)
	{
	}

	public static DataStore<TEnum> ReadFrom(Stream stream, BaseValue[] defaults, Convert convert)
	{
		return null;
	}

	public void ApplyValues(BaseValue[] newValues)
	{
	}

	private static bool ValidateValues(BaseValue[] values, Convert convert)
	{
		return false;
	}

	private static void Assert(bool condition, string msg)
	{
	}

	private static void LogError(string msg)
	{
	}
}
