using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer;

public sealed class fsData
{
	private object _value;

	public static readonly fsData True;

	public static readonly fsData False;

	public static readonly fsData Null;

	public fsDataType Type
	{
		get
		{
			object value = _value;
			fsDataType result;
			if (_value == null)
			{
				result = fsDataType.Null;
			}
			else
			{
				bool flag = _value == null;
				object obj = null;
				if (!flag)
				{
					bool flag2 = (object)value.GetType() == typeof(double);
					obj = _value;
					if (!flag2)
					{
						obj = null;
					}
				}
				result = fsDataType.Double;
				if (obj == null)
				{
					object value2 = _value;
					bool flag3 = _value == null;
					object obj2 = null;
					if (!flag3)
					{
						bool flag4 = (object)value2.GetType() == typeof(long);
						obj2 = _value;
						if (!flag4)
						{
							obj2 = null;
						}
					}
					result = fsDataType.Int64;
					if (obj2 == null)
					{
						object value3 = _value;
						bool flag5 = _value == null;
						object obj3 = null;
						if (!flag5)
						{
							bool flag6 = (object)value3.GetType() == typeof(bool);
							obj3 = _value;
							if (!flag6)
							{
								obj3 = null;
							}
						}
						result = fsDataType.Boolean;
						if (obj3 == null)
						{
							object value4 = _value;
							bool flag7 = _value == null;
							object obj4 = null;
							if (!flag7)
							{
								bool flag8 = (object)value4.GetType() == typeof(string);
								obj4 = _value;
								if (!flag8)
								{
									obj4 = null;
								}
							}
							result = fsDataType.String;
							if (obj4 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
								result = fsDataType.Object;
								object obj5 = default;
								if (obj5 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
									result = fsDataType.Array;
									object obj6 = default;
									if (obj6 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
										InvalidOperationException ex = default;
										ex._002Ector("unknown JSON data type");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
										result = fsDataType.Array;
									}
								}
							}
						}
					}
				}
			}
			return result;
		}
	}

	public bool IsNull => _value == null;

	public bool IsDouble
	{
		get
		{
			object value = _value;
			bool flag = _value == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(double);
				obj = _value;
				if (!flag2)
				{
					obj = null;
				}
			}
			return obj != null;
		}
	}

	public bool IsInt64
	{
		get
		{
			object value = _value;
			bool flag = _value == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(long);
				obj = _value;
				if (!flag2)
				{
					obj = null;
				}
			}
			return obj != null;
		}
	}

	public bool IsBool
	{
		get
		{
			object value = _value;
			bool flag = _value == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(bool);
				obj = _value;
				if (!flag2)
				{
					obj = null;
				}
			}
			return obj != null;
		}
	}

	public bool IsString
	{
		get
		{
			object value = _value;
			bool flag = _value == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(string);
				obj = _value;
				if (!flag2)
				{
					obj = null;
				}
			}
			return obj != null;
		}
	}

	public bool IsDictionary
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj = default;
			return obj != null;
		}
	}

	public bool IsList
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj = default;
			return obj != null;
		}
	}

	public double AsDouble
	{
		get
		{
			//IL_0013: Expected F8, but got Obj
			ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
			return (double)ex;
		}
	}

	public long AsInt64
	{
		get
		{
			//IL_0013: Expected I8, but got Obj
			ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
			return (long)ex;
		}
	}

	public bool AsBool
	{
		get
		{
			//IL_000f: Expected I4, but got VT
			return (byte)(int)Cast<T>() != 0;
		}
	}

	public string AsString => (string)(object)new ArrayTypeMismatchException();

	public Dictionary<string, fsData> AsDictionary => (Dictionary<string, fsData>)(object)new ArrayTypeMismatchException();

	public List<fsData> AsList => (List<fsData>)(object)new ArrayTypeMismatchException();

	public fsData()
	{
		_value = null;
	}

	public fsData(bool boolean)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value = default;
		_value = value;
	}

	public fsData(double f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value = default;
		_value = value;
	}

	public fsData(long i)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value = default;
		_value = value;
	}

	public fsData(string str)
	{
		_value = str;
	}

	public fsData(Dictionary<string, fsData> dict)
	{
		_value = dict;
	}

	public fsData(List<fsData> list)
	{
		_value = list;
	}

	public static fsData CreateDictionary()
	{
		//IL_0044: Expected Obj, but got I4
		//IL_00b4: Expected I, but got Obj
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		object obj;
		object obj2;
		if (~(fsGlobalConfig.IsCaseSensitive ? 1u : 0u) != 0)
		{
			obj = 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [536279]");
			if ((nint)0 != 0)
			{
				goto IL_00a6;
			}
			obj = 12;
			obj2 = 5464697;
		}
		else
		{
			obj = 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [536B2D]");
			if ((nint)0 != 0)
			{
				goto IL_00a6;
			}
			obj = 8;
			obj2 = 5466925;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_codegen_initialize_runtime_metadata\"");
		obj2 = 1;
		goto IL_00a6;
		IL_00a6:
		nint num = (nint)typeof(StringComparer);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v5 (Il2CppClass<System.StringComparer>)+5C]");
		object obj4 = obj3 + 0;
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>>)+4] (should have been resolved before IL gen)");
		fsData fsData2 = default;
		object value = default;
		fsData2._value = value;
		return fsData2;
	}

	public static fsData CreateList()
	{
		List<fsData> list = default;
		list._002Ector();
		fsData fsData2 = default;
		fsData2._value = list;
		return fsData2;
	}

	public static fsData CreateList(int capacity)
	{
		List<fsData> list = default;
		list._002Ector(capacity);
		fsData fsData2 = default;
		fsData2._value = list;
		return fsData2;
	}

	internal void BecomeDictionary()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>>)+4] (should have been resolved before IL gen)");
		object value = default;
		_value = value;
	}

	internal fsData Clone()
	{
		fsData fsData2 = default;
		fsData2._value = null;
		fsData2._value = _value;
		return fsData2;
	}

	private T Cast<T>()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		throw new NullReferenceException();
	}

	public override string ToString()
	{
		return fsJsonPrinter.CompressedJson(this);
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		fsData other = null;
		if (!flag)
		{
			bool flag2 = (object)obj.GetType() == typeof(fsData);
			other = (fsData)obj;
			if (!flag2)
			{
				other = null;
			}
		}
		return Equals(other);
	}

	public bool Equals(fsData other)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected I4, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		bool result = default;
		if (other != null)
		{
			fsDataType type = Type;
			fsDataType type2 = other.Type;
			if (type == type2)
			{
				fsDataType type3 = Type;
				if (type3 != fsDataType.Array)
				{
					if (type3 != fsDataType.Object)
					{
						if (type3 != fsDataType.Double)
						{
							if (type3 != fsDataType.Int64)
							{
								if (type3 != fsDataType.Boolean)
								{
									if (type3 != fsDataType.String)
									{
										bool flag = type3 == fsDataType.Null;
										result = true;
										if (!flag)
										{
											result = true;
											goto IL_0812;
										}
									}
									else
									{
										string asString = AsString;
										string asString2 = other.AsString;
										bool flag2 = asString == asString2;
										result = flag2;
									}
								}
								else
								{
									bool asBool = AsBool;
									bool asBool2 = other.AsBool;
									object obj3 = asBool ^ asBool2;
									bool flag3 = (byte)(obj3 ^ 1) != 0;
									result = flag3;
								}
							}
							else
							{
								long asInt = AsInt64;
								long asInt2 = other.AsInt64;
								bool flag4 = asInt == asInt2;
								result = flag4;
							}
						}
						else
						{
							double asDouble = AsDouble;
							double asDouble2 = other.AsDouble;
							bool flag5 = asDouble == asDouble2;
							result = true;
							if (!flag5)
							{
								double asDouble3 = AsDouble;
								double asDouble4 = other.AsDouble;
								double value = asDouble3 - asDouble4;
								double num = Math.Abs(value);
								bool flag6 = num < double.Epsilon;
								result = flag6;
							}
						}
					}
					else
					{
						Dictionary<string, fsData> asDictionary = AsDictionary;
						Dictionary<string, fsData> asDictionary2 = other.AsDictionary;
						object obj4 = asDictionary._count - asDictionary._freeCount;
						object obj5 = asDictionary2._count - asDictionary2._freeCount;
						bool flag7 = obj4 != obj5;
						result = false;
						if (!flag7)
						{
							object obj6 = obj + 16;
							Dictionary<string, fsData>.KeyCollection keys = asDictionary.Keys;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							_ = 0;
							object obj7 = obj + 32;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							object obj9 = default;
							object obj10 = default;
							object obj11 = default;
							object obj12 = default;
							object obj13 = default;
							bool flag10 = default;
							bool flag12 = default;
							while (true)
							{
								_ = 0;
								object obj8 = obj + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									if (obj9 == null)
									{
										result = true;
										goto IL_070d;
									}
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											bool flag8 = obj10 == null;
											result = false;
											if (flag8)
											{
												goto IL_070d;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														if (obj11 != null)
														{
															continue;
														}
														result = false;
														goto IL_070d;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag9 = obj12 != obj13;
								result = flag10;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag11 = (nint)0 == 1;
									result = true;
									if (!flag11)
									{
										goto IL_070d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									result = flag12;
								}
								_ = 0;
								object obj14 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
								goto IL_0812;
								IL_070d:
								object obj15 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9517");
								break;
							}
						}
					}
				}
				else
				{
					List<fsData> asList = AsList;
					List<fsData> asList2 = other.AsList;
					bool flag13 = asList._size != asList2._size;
					int num2 = 0;
					result = false;
					if (!flag13)
					{
						while (num2 < asList._size)
						{
							fsData fsData2 = asList.get_Item(num2);
							fsData other2 = asList2.get_Item(num2);
							if (!fsData2.Equals(other2))
							{
								break;
							}
							int num3 = num2 + 1;
							num2 = num3;
						}
						bool flag14 = num2 >= asList._size;
						result = flag14;
					}
				}
			}
		}
		goto IL_080d;
		IL_0812:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector("Unknown data type");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_080d;
		IL_080d:
		return result;
	}

	public static bool operator ==(fsData a, fsData b)
	{
		if ((object)a == b)
		{
			return true;
		}
		bool flag = (object)a == null;
		bool result = false;
		if (!flag)
		{
			bool flag2 = (object)b == null;
			result = false;
			if (!flag2)
			{
				if (a.IsDouble && b.IsDouble)
				{
					double asDouble = a.AsDouble;
					double asDouble2 = b.AsDouble;
					double value = asDouble - asDouble2;
					double num = Math.Abs(value);
					return num < double.Epsilon;
				}
				bool flag3 = a.Equals(b);
				result = flag3;
			}
		}
		return result;
	}

	public static bool operator !=(fsData a, fsData b)
	{
		bool flag = a == b;
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public override int GetHashCode()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		object value = _value;
		nint num = (nint)value;
		object obj = value + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Object>)+CC] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	static fsData()
	{
		fsData fsData2 = default;
		fsData2._002Ector(boolean: true);
		True = fsData2;
		fsData fsData3 = default;
		fsData3._002Ector(boolean: false);
		False = fsData3;
		fsData fsData4 = default;
		fsData4._value = null;
		Null = fsData4;
	}
}
