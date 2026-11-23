using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

namespace SYBO.Components.Json.Internal;

public class JsonParser
{
	protected enum Token
	{
		None,
		CurlyOpen,
		CurlyClose,
		SquaredOpen,
		SquaredClose,
		Colon,
		Comma,
		String,
		Number,
		True,
		False,
		Null
	}

	public static int BuilderCapacity = 2000;

	protected static int _lastErrorIndex = -1;

	protected static string _lastDecode = string.Empty;

	private static int _indentation;

	private static List<string> _indentations;

	private static StringBuilder _stringParsingBuffer;

	private static HashSet<char> _possibleNumberChars;

	public static T Deserialize<T>(string json, JsonContext context = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003b: Expected VT, but got I
		//IL_00b0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = DeserializeDom(json);
		if (obj3 == null)
		{
			object obj4 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return (T)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj5 = default;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		}
		else
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v3 (Il2CppMethodRgctx<SYBO.Components.Json.Internal.JsonParser::Deserialize>)+4]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S3_v4+4] (should have been resolved before IL gen)");
		}
		T result = default;
		return result;
	}

	public static string Serialize<T>(T obj, JsonContext context = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.Internal.JsonParser::Serialize>>)+4] (should have been resolved before IL gen)");
		JsonContext jsonContext = default;
		JsonContext jsonContext2 = default;
		if (jsonContext == null)
		{
			jsonContext2._002Ector();
		}
		object json = default;
		return SerializeDom(json, jsonContext2);
	}

	public unsafe static object DeserializeDom(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Ref, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_lastDecode = json;
		object result = default;
		if (json != null)
		{
			_ = 1;
			_ = 0;
			result = ParseValue(json, ref *(int*)(obj + 12), ref *(bool*)(obj + 11));
			int lastErrorIndex = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				lastErrorIndex = 0;
			}
			_lastErrorIndex = lastErrorIndex;
		}
		return result;
	}

	public static string SerializeDom(object json, JsonContext context)
	{
		//IL_003b: Expected I, but got Obj
		_indentation = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(BuilderCapacity);
		if (SerializeValue(json, stringBuilder, context))
		{
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v7 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
		return null;
	}

	public static bool LastDecodeSuccessful()
	{
		return _lastErrorIndex == -1;
	}

	public static int GetLastErrorIndex()
	{
		return _lastErrorIndex;
	}

	public static string GetLastErrorSnippet()
	{
		//IL_0029: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		if (_lastErrorIndex == -1)
		{
			return string.Empty;
		}
		int num = _lastErrorIndex - 5;
		object obj = _lastErrorIndex + 15;
		bool flag = num > 0;
		int num2 = num;
		if (!flag)
		{
			num2 = 0;
		}
		object obj2 = obj - num2;
		int length = obj2 + 1;
		return _lastDecode.Substring(num2, length);
	}

	protected unsafe static JsonDict ParseObject(string json, ref int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Ref, but got Unknown
		//IL_021b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		JsonDict jsonDict = default;
		jsonDict._002Ector();
		Token token = NextToken(json, ref index);
		JsonDict result;
		while (true)
		{
			Token token2 = LookAhead(json, index);
			bool flag = token2 == Token.None;
			result = null;
			if (flag)
			{
				break;
			}
			switch (token2)
			{
			case Token.Comma:
			{
				Token token5 = NextToken(json, ref index);
				continue;
			}
			default:
			{
				string text = ParseString(json, ref index);
				bool flag2 = text == null;
				result = null;
				if (flag2)
				{
					break;
				}
				Token token4 = NextToken(json, ref index);
				bool flag3 = token4 != Token.Colon;
				result = null;
				if (!flag3)
				{
					_ = 1;
					object obj3 = ParseValue(json, ref index, ref *(bool*)(obj + 15));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
					bool flag4 = (nint)0 == 0;
					result = null;
					if (!flag4)
					{
						nint num = 0;
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ S5_v5+4] (should have been resolved before IL gen)");
						continue;
					}
				}
				break;
			}
			case Token.CurlyClose:
			{
				Token token3 = NextToken(json, ref index);
				result = jsonDict;
				break;
			}
			}
			break;
		}
		return result;
	}

	protected unsafe static JsonList ParseArray(string json, ref int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		JsonList jsonList = default;
		jsonList._002Ector();
		Token token = NextToken(json, ref index);
		JsonList result;
		while (true)
		{
			Token token2 = LookAhead(json, index);
			bool flag = token2 == Token.None;
			result = null;
			if (flag)
			{
				break;
			}
			switch (token2)
			{
			default:
			{
				_ = 1;
				object item = ParseValue(json, ref index, ref *(bool*)(obj + 15));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
				bool flag2 = (nint)0 == 0;
				result = null;
				if (!flag2)
				{
					jsonList.Add(item);
					continue;
				}
				break;
			}
			case Token.Comma:
			{
				Token token4 = NextToken(json, ref index);
				continue;
			}
			case Token.SquaredClose:
			{
				Token token3 = NextToken(json, ref index);
				result = jsonList;
				break;
			}
			}
			break;
		}
		return result;
	}

	protected unsafe static object ParseValue(string json, ref int index, ref bool success)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Token token = LookAhead(json, index);
		object obj3 = token - 1;
		if (token != Token.CurlyOpen)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 == 2)
				{
					return ParseArray(json, ref index);
				}
				if ((nint)obj3 != 3 && (nint)obj3 != 4 && (nint)obj3 != 5)
				{
					if ((nint)obj3 != 6)
					{
						if ((nint)obj3 != 7)
						{
							if ((nint)obj3 != 8)
							{
								if ((nint)obj3 != 9)
								{
									if ((nint)obj3 != 10)
									{
										goto IL_0274;
									}
									Token token2 = NextToken(json, ref index);
									return null;
								}
								Token token3 = NextToken(json, ref index);
								bool flag = bool.Parse("FALSE");
								object obj4 = obj + 14;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							}
							else
							{
								Token token4 = NextToken(json, ref index);
								bool flag2 = bool.Parse("TRUE");
								object obj5 = obj + 15;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							}
							string result = default;
							return result;
						}
						return ParseNumber(json, ref index);
					}
					return ParseString(json, ref index);
				}
			}
			goto IL_0274;
		}
		return ParseObject(json, ref index);
		IL_0274:
		ref bool reference = ref *(bool*)null;
		return null;
	}

	protected unsafe static string ParseString(string json, ref int index)
	{
		//IL_053a: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_04d3: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I4
		//IL_042f: Expected Obj, but got I4
		//IL_04b5: Expected Obj, but got I4
		EatWhitespace(json, ref index);
		if (_stringParsingBuffer == null)
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector(1024);
			_stringParsingBuffer = stringBuilder;
		}
		_stringParsingBuffer.Length = 0;
		object obj = index + 1;
		ref int reference = ref *(int*)obj;
		char c = json.get_Chars(index);
		while (index != json._stringLength)
		{
			object obj2 = index + 1;
			reference = ref *(int*)obj2;
			char c2 = json.get_Chars(index);
			switch (c2)
			{
			default:
			{
				StringBuilder stringBuilder11 = _stringParsingBuffer.Append(c2);
				continue;
			}
			case '\\':
			{
				if (index == json._stringLength)
				{
					break;
				}
				object obj3 = index + 1;
				reference = ref *(int*)obj3;
				char c3 = json.get_Chars(index);
				if (c3 <= '\\')
				{
					switch (c3)
					{
					case '\\':
					{
						StringBuilder stringBuilder4 = _stringParsingBuffer.Append('\\');
						break;
					}
					case '"':
					{
						StringBuilder stringBuilder3 = _stringParsingBuffer.Append('"');
						break;
					}
					case '/':
					{
						StringBuilder stringBuilder2 = _stringParsingBuffer.Append('/');
						break;
					}
					}
					continue;
				}
				if (c3 <= 'f')
				{
					object obj4 = c3 - 98;
					if (c3 != 'b')
					{
						if ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 != 3 && (nint)obj4 == 4)
						{
							StringBuilder stringBuilder5 = _stringParsingBuffer.Append('\f');
						}
					}
					else
					{
						StringBuilder stringBuilder6 = _stringParsingBuffer.Append('\b');
					}
					continue;
				}
				if (c3 != 'n')
				{
					object obj5 = c3 - 114;
					if (c3 != 'r')
					{
						if ((nint)obj5 == 1)
						{
							continue;
						}
						if ((nint)obj5 != 2)
						{
							if ((nint)obj5 != 3)
							{
								continue;
							}
							object obj6 = json._stringLength - index;
							if ((nint)obj6 >= 4)
							{
								string s = json.Substring(index, 4);
								uint utf = uint.Parse(s, NumberStyles.HexNumber);
								string value = char.ConvertFromUtf32((int)utf);
								StringBuilder stringBuilder7 = _stringParsingBuffer.Append(value);
								object obj7 = index + 4;
								reference = ref *(int*)obj7;
								continue;
							}
							break;
						}
						StringBuilder stringBuilder8 = _stringParsingBuffer.Append('\t');
						continue;
					}
					StringBuilder stringBuilder9 = _stringParsingBuffer.Append('\r');
					continue;
				}
				StringBuilder stringBuilder10 = _stringParsingBuffer.Append('\n');
				continue;
			}
			case '"':
			{
				StringBuilder stringParsingBuffer = _stringParsingBuffer;
				nint num = (nint)stringParsingBuffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ S1_v51 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				break;
			}
			}
			break;
		}
		string result = default;
		return result;
	}

	protected unsafe static object ParseNumber(string json, ref int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		EatWhitespace(json, ref index);
		int lastIndexOfNumber = GetLastIndexOfNumber(json, index);
		object obj3 = lastIndexOfNumber - index;
		int num = obj3 + 1;
		ref int reference;
		if (num >= 3)
		{
			char c = json.get_Chars(index);
			if (c == '0')
			{
				int index2 = index + 1;
				char c2 = json.get_Chars(index2);
				if (c2 != 'x')
				{
					int index3 = index + 1;
					char c3 = json.get_Chars(index3);
					if (c3 != 'X')
					{
						goto IL_017c;
					}
				}
				int startIndex = index + 2;
				int length = num - 2;
				string hexString = json.Substring(startIndex, length);
				object obj4 = lastIndexOfNumber + 1;
				reference = ref *(int*)obj4;
				return ParseHex(hexString);
			}
		}
		goto IL_017c;
		IL_017c:
		string text = json.Substring(index, num);
		object obj5 = lastIndexOfNumber + 1;
		reference = ref *(int*)obj5;
		if (text.Contains("."))
		{
			double num2 = double.Parse(text);
			object obj6 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		}
		else
		{
			long num3 = long.Parse(text);
			object obj7 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		}
		object result = default;
		return result;
	}

	private static object ParseHex(string hexString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (hexString._stringLength >= 9)
		{
			long num = long.Parse(hexString, NumberStyles.HexNumber);
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		}
		else
		{
			int num2 = int.Parse(hexString, NumberStyles.HexNumber);
			object obj4 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		}
		object result = default;
		return result;
	}

	protected static int GetLastIndexOfNumber(string json, int index)
	{
		int num = default;
		int num2 = default;
		while (num < json._stringLength)
		{
			char item = json.get_Chars(num);
			if (!_possibleNumberChars.Contains(item))
			{
				break;
			}
			num = num2 + 1;
		}
		return num - 1;
	}

	protected unsafe static void EatWhitespace(string json, ref int index)
	{
		int num = index;
		while (num < json._stringLength)
		{
			char value = json.get_Chars(num);
			int num2 = " \t\n\r".IndexOf(value);
			if (num2 != -1)
			{
				int num3 = index + 1;
				ref int reference = ref *(int*)num3;
				num = num3;
				continue;
			}
			break;
		}
	}

	protected unsafe static Token LookAhead(string json, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		return NextToken(json, ref *(int*)(obj + 12));
	}

	protected unsafe static Token NextToken(string json, ref int index)
	{
		//IL_002e: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_071f: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I4
		EatWhitespace(json, ref index);
		bool flag = index == json._stringLength;
		Token result = Token.None;
		ref int reference;
		if (!flag)
		{
			char c = json.get_Chars(index);
			object obj = index + 1;
			reference = ref *(int*)obj;
			if (c <= '[')
			{
				object obj2 = c - 34;
				bool flag2 = c == '"';
				result = Token.String;
				if (!flag2)
				{
					if ((nint)obj2 != 1 && (nint)obj2 != 2 && (nint)obj2 != 3 && (nint)obj2 != 4 && (nint)obj2 != 5 && (nint)obj2 != 6 && (nint)obj2 != 7 && (nint)obj2 != 8 && (nint)obj2 != 9)
					{
						if ((nint)obj2 == 10)
						{
							return Token.Comma;
						}
						if ((nint)obj2 == 11)
						{
							goto IL_0358;
						}
						if ((nint)obj2 != 12 && (nint)obj2 != 13)
						{
							if ((nint)obj2 == 14 || (nint)obj2 == 15 || (nint)obj2 == 16 || (nint)obj2 == 17 || (nint)obj2 == 18 || (nint)obj2 == 19 || (nint)obj2 == 20 || (nint)obj2 == 21 || (nint)obj2 == 22 || (nint)obj2 == 23)
							{
								goto IL_0358;
							}
							if ((nint)obj2 == 24)
							{
								return Token.Colon;
							}
							bool flag3 = c == '[';
							result = Token.SquaredOpen;
							if (flag3)
							{
								goto IL_08c4;
							}
						}
					}
					goto IL_0422;
				}
			}
			else
			{
				object obj3 = c - 123;
				if (c == '{')
				{
					return Token.CurlyOpen;
				}
				if ((nint)obj3 == 1)
				{
					goto IL_0422;
				}
				if ((nint)obj3 != 2)
				{
					if (c != ']')
					{
						goto IL_0422;
					}
					result = Token.SquaredClose;
				}
				else
				{
					result = Token.CurlyClose;
				}
			}
		}
		goto IL_08c4;
		IL_0358:
		return Token.Number;
		IL_0422:
		object obj4 = index - 1;
		reference = ref *(int*)obj4;
		object obj5 = json._stringLength - obj4;
		if ((nint)obj5 >= 5)
		{
			char c2 = json.get_Chars(index);
			if (c2 == 'f')
			{
				int index2 = index + 1;
				char c3 = json.get_Chars(index2);
				if (c3 == 'a')
				{
					int index3 = index + 2;
					char c4 = json.get_Chars(index3);
					if (c4 == 'l')
					{
						int index4 = index + 3;
						char c5 = json.get_Chars(index4);
						if (c5 == 's')
						{
							int index5 = index + 4;
							char c6 = json.get_Chars(index5);
							if (c6 == 'e')
							{
								object obj6 = index + 5;
								reference = ref *(int*)obj6;
								return Token.False;
							}
						}
					}
				}
			}
		}
		else
		{
			bool flag4 = (nint)obj5 != 4;
			result = Token.None;
			if (flag4)
			{
				goto IL_08c4;
			}
		}
		char c7 = json.get_Chars(index);
		if (c7 == 't')
		{
			int index6 = index + 1;
			char c8 = json.get_Chars(index6);
			if (c8 == 'r')
			{
				int index7 = index + 2;
				char c9 = json.get_Chars(index7);
				if (c9 == 'u')
				{
					int index8 = index + 3;
					char c10 = json.get_Chars(index8);
					if (c10 == 'e')
					{
						object obj7 = index + 4;
						reference = ref *(int*)obj7;
						return Token.True;
					}
				}
			}
		}
		char c11 = json.get_Chars(index);
		bool flag5 = c11 != 'n';
		result = Token.None;
		if (!flag5)
		{
			int index9 = index + 1;
			char c12 = json.get_Chars(index9);
			bool flag6 = c12 != 'u';
			result = Token.None;
			if (!flag6)
			{
				int index10 = index + 2;
				char c13 = json.get_Chars(index10);
				bool flag7 = c13 != 'l';
				result = Token.None;
				if (!flag7)
				{
					int index11 = index + 3;
					char c14 = json.get_Chars(index11);
					bool flag8 = c14 != 'l';
					result = Token.None;
					if (!flag8)
					{
						object obj8 = index + 4;
						reference = ref *(int*)obj8;
						return Token.Null;
					}
				}
			}
		}
		goto IL_08c4;
		IL_08c4:
		return result;
	}

	protected static bool SerializeObject(IDictionary dict, StringBuilder builder, JsonContext context)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I4, but got Unknown
		//IL_00df: Expected Obj, but got I4
		StringBuilder stringBuilder = builder.Append("{");
		int indentation = _indentation + 1;
		_indentation = indentation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = 1;
		object obj2 = default;
		object obj4 = default;
		string aString = default;
		object value = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj3 = obj4;
				object obj5 = obj4 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S1_v27+D4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				if (obj == null)
				{
					StringBuilder stringBuilder2 = builder.Append(",");
				}
				AppendIndentation(builder, context);
				SerializeString(aString, builder);
				StringBuilder stringBuilder3 = builder.Append(":");
				bool flag = SerializeValue(value, builder, context);
				obj = 0;
				if (!flag)
				{
					int indentation2 = _indentation - 1;
					_indentation = indentation2;
					break;
				}
				continue;
			}
			int indentation3 = _indentation - 1;
			_indentation = indentation3;
			AppendIndentation(builder, context);
			StringBuilder stringBuilder4 = builder.Append("}");
			break;
		}
		return (byte)(obj2 ^ 1) != 0;
	}

	protected static string GetIndentationString()
	{
		if (_indentations == null)
		{
			List<string> list = default;
			list._002Ector();
			_indentations = list;
			_indentations.Add("\n");
		}
		while (true)
		{
			List<string> indentations = _indentations;
			if (_indentation < indentations._size)
			{
				break;
			}
			List<string> indentations2 = _indentations;
			int index = indentations2._size - 1;
			string text = _indentations.get_Item(index);
			string item = text + "\t";
			_indentations.Add(item);
		}
		return _indentations.get_Item(_indentation);
	}

	protected static bool SerializeArray(Array anArray, StringBuilder builder, JsonContext context)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		StringBuilder stringBuilder = builder.Append("[");
		int length = anArray.Length;
		bool result;
		if (length >= 1)
		{
			int indentation = _indentation + 1;
			_indentation = indentation;
			object obj = 1;
			int num = 0;
			while (true)
			{
				int length2 = anArray.Length;
				if (length2 <= num)
				{
					break;
				}
				object value = anArray.GetValue(num);
				if (obj == null)
				{
					StringBuilder stringBuilder2 = builder.Append(",");
				}
				AppendIndentation(builder, context);
				bool flag = SerializeValue(value, builder, context);
				bool flag2 = !flag;
				result = false;
				if (!flag2)
				{
					int num2 = num + 1;
					obj = 0;
					num = num2;
					continue;
				}
				goto IL_0185;
			}
			int indentation2 = _indentation - 1;
			_indentation = indentation2;
			AppendIndentation(builder, context);
		}
		StringBuilder stringBuilder3 = builder.Append("]");
		result = true;
		goto IL_0185;
		IL_0185:
		return result;
	}

	protected static bool SerializeArray(IList anArray, StringBuilder builder, JsonContext context)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		StringBuilder stringBuilder = builder.Append("[");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		bool result;
		if ((nint)obj >= 1)
		{
			int indentation = _indentation + 1;
			_indentation = indentation;
			object obj2 = 1;
			object obj3 = 0;
			object obj4 = default;
			object value = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				if (obj2 == null)
				{
					StringBuilder stringBuilder2 = builder.Append(",");
				}
				AppendIndentation(builder, context);
				bool flag = SerializeValue(value, builder, context);
				bool flag2 = !flag;
				result = false;
				if (!flag2)
				{
					object obj5 = obj3 + 1;
					obj2 = 0;
					obj3 = obj5;
					continue;
				}
				goto IL_017b;
			}
			int indentation2 = _indentation - 1;
			_indentation = indentation2;
			AppendIndentation(builder, context);
		}
		StringBuilder stringBuilder3 = builder.Append("]");
		result = true;
		goto IL_017b;
		IL_017b:
		return result;
	}

	protected unsafe static bool SerializeValue(object value, StringBuilder builder, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_020d: Expected I4, but got Obj
		//IL_0208: Expected native int or pointer, but got VT
		//IL_021a: Expected I4, but got Obj
		//IL_0215: Expected native int or pointer, but got VT
		//IL_0408: Expected VT, but got Obj
		//IL_043c: Expected VT, but got Obj
		//IL_0470: Expected VT, but got Obj
		//IL_04a4: Expected VT, but got Obj
		//IL_04d8: Expected VT, but got Obj
		object obj = default;
		decimal num = obj - 16;
		bool result;
		if (value == null)
		{
			StringBuilder stringBuilder = builder.Append("null");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj3 = default;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S1_v7+1BC] (should have been resolved before IL gen)");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				Array anArray = default;
				bool flag = SerializeArray(anArray, builder, context);
			}
			else
			{
				bool flag2 = value == null;
				object obj5 = null;
				if (!flag2)
				{
					bool flag3 = (object)value.GetType() == typeof(string);
					obj5 = value;
					if (!flag3)
					{
						obj5 = null;
					}
				}
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
					string aString = default;
					SerializeString(aString, builder);
				}
				else
				{
					bool flag4 = value == null;
					object obj6 = null;
					if (!flag4)
					{
						bool flag5 = (object)value.GetType() == typeof(char);
						obj6 = value;
						if (!flag5)
						{
							obj6 = null;
						}
					}
					if (obj6 != null)
					{
						throw new NullReferenceException();
					}
					bool flag6 = value == null;
					object obj7 = null;
					if (!flag6)
					{
						bool flag7 = (object)value.GetType() == typeof(decimal);
						obj7 = value;
						if (!flag7)
						{
							obj7 = null;
						}
					}
					if (obj7 != null)
					{
						NullReferenceException ex = new NullReferenceException();
						((decimal*)(nint)num)->lo = (int)((Exception)ex)._className;
						((decimal*)(nint)num)->flags = (int)ex;
						string aString2 = Convert.ToString(num);
						SerializeString(aString2, builder);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
						object obj8 = default;
						if (obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
							IDictionary dict = default;
							bool flag8 = SerializeObject(dict, builder, context);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
							object obj9 = default;
							if (obj9 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
								IList anArray2 = default;
								bool flag9 = SerializeArray(anArray2, builder, context);
							}
							else
							{
								bool flag10 = value == null;
								object obj10 = null;
								if (!flag10)
								{
									bool flag11 = (object)value.GetType() == typeof(bool);
									obj10 = value;
									if (!flag11)
									{
										obj10 = null;
									}
								}
								if (obj10 != null)
								{
									throw new NullReferenceException();
								}
								bool flag12 = value == null;
								object obj11 = null;
								if (!flag12)
								{
									bool flag13 = (object)value.GetType() == typeof(bool);
									obj11 = value;
									if (!flag13)
									{
										obj11 = null;
									}
								}
								if (obj11 != null)
								{
									throw new NullReferenceException();
								}
								Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(sbyte));
								if (typeFromHandle != obj3)
								{
									Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(byte));
									if (typeFromHandle2 != obj3)
									{
										Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(short));
										if (typeFromHandle3 != obj3)
										{
											Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
											if (typeFromHandle4 != obj3)
											{
												Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
												if (typeFromHandle5 != obj3)
												{
													object obj12 = obj3;
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ S1_v43+30C] (should have been resolved before IL gen)");
													object obj13 = default;
													bool flag14 = obj13 == null;
													result = false;
													if (!flag14)
													{
														double number = Convert.ToDouble(value);
														SerializeNumber(number, builder);
														goto IL_0572;
													}
													goto IL_0639;
												}
											}
										}
									}
								}
								StringBuilder stringBuilder2 = builder.Append(value);
							}
						}
					}
				}
			}
		}
		goto IL_0572;
		IL_0639:
		return result;
		IL_0572:
		result = true;
		goto IL_0639;
	}

	protected static void SerializeString(string aString, StringBuilder builder)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		StringBuilder stringBuilder = builder.Append("\"");
		int num2;
		for (int num = 0; aString._stringLength > num; num2 = num + 1, num = num2)
		{
			char c = aString.get_Chars(num);
			object obj = c - 8;
			if (c != '\b')
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj != 2)
					{
						if ((nint)obj != 3)
						{
							if ((nint)obj == 4)
							{
								StringBuilder stringBuilder2 = builder.Append("\\f");
								continue;
							}
							if ((nint)obj == 5)
							{
								StringBuilder stringBuilder3 = builder.Append("\\r");
								continue;
							}
							switch (c)
							{
							case '"':
							{
								StringBuilder stringBuilder5 = builder.Append("\\\"");
								continue;
							}
							case '\\':
							{
								StringBuilder stringBuilder4 = builder.Append("\\\\");
								continue;
							}
							}
						}
						object obj2 = c - 32;
						if ((nint)obj2 <= 94)
						{
							StringBuilder stringBuilder6 = builder.Append(c);
							continue;
						}
						string text = Convert.ToString(c, 16);
						string text2 = text.PadLeft(4, '0');
						string value = "\\u" + text2;
						StringBuilder stringBuilder7 = builder.Append(value);
					}
					else
					{
						StringBuilder stringBuilder8 = builder.Append("\\n");
					}
				}
				else
				{
					StringBuilder stringBuilder9 = builder.Append("\\t");
				}
			}
			else
			{
				StringBuilder stringBuilder10 = builder.Append("\\b");
			}
		}
		StringBuilder stringBuilder11 = builder.Append("\"");
	}

	protected unsafe static void SerializeNumber(double number, StringBuilder builder)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_003b: Expected Ref, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = number & 0x7FFFFFFFFFFFFFFFL;
		if ((long)obj3 == 9218868437227405312L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			JsonSerializationException ex = default;
			ex._002Ector("Cannot serialize infinity to JSON.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		else
		{
			object obj4 = number & 0x7FFFFFFFFFFFFFFFL;
			if ((long)obj4 < 9218868437227405313L)
			{
				double num = (double)obj + 8.0;
				string value = ((double*)num)->ToString("R");
				StringBuilder stringBuilder = builder.Append(value);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		JsonSerializationException ex2 = default;
		ex2._002Ector("Cannot serialize NaN to JSON.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	protected static void AppendIndentation(StringBuilder builder, JsonContext context)
	{
		if (~(context.RemoveWhitespace ? 1u : 0u) != 0)
		{
			string indentationString = GetIndentationString();
			StringBuilder stringBuilder = builder.Append(indentationString);
		}
	}

	static JsonParser()
	{
		//IL_0048: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I
		HashSet<char> hashSet = default;
		hashSet._002Ector();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v8 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S3_v9+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S3_v13 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S3_v14+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S3_v18 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ S3_v19+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S3_v23 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S3_v24+4] (should have been resolved before IL gen)");
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S3_v28 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S3_v29+4] (should have been resolved before IL gen)");
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S3_v33 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S3_v34+4] (should have been resolved before IL gen)");
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S3_v38 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S3_v39+4] (should have been resolved before IL gen)");
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S3_v43 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S3_v44+4] (should have been resolved before IL gen)");
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S3_v48 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ S3_v49+4] (should have been resolved before IL gen)");
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S3_v53 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ S3_v54+4] (should have been resolved before IL gen)");
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S3_v58 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ S3_v59+4] (should have been resolved before IL gen)");
		nint num25 = 0;
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S3_v63 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ S3_v64+4] (should have been resolved before IL gen)");
		nint num27 = 0;
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S3_v68 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S3_v69+4] (should have been resolved before IL gen)");
		nint num29 = 0;
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S3_v73 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ S3_v74+4] (should have been resolved before IL gen)");
		nint num31 = 0;
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S3_v78 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ S3_v79+4] (should have been resolved before IL gen)");
		nint num33 = 0;
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S3_v83 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ S3_v84+4] (should have been resolved before IL gen)");
		nint num35 = 0;
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S3_v88 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ S3_v89+4] (should have been resolved before IL gen)");
		nint num37 = 0;
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S3_v93 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ S3_v94+4] (should have been resolved before IL gen)");
		nint num39 = 0;
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S3_v98 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v313 @ S3_v99+4] (should have been resolved before IL gen)");
		nint num41 = 0;
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S3_v103 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v327 @ S3_v104+4] (should have been resolved before IL gen)");
		nint num43 = 0;
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S3_v108 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v341 @ S3_v109+4] (should have been resolved before IL gen)");
		nint num45 = 0;
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S3_v113 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ S3_v114+4] (should have been resolved before IL gen)");
		nint num47 = 0;
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S3_v118 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ S3_v119+4] (should have been resolved before IL gen)");
		nint num49 = 0;
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S3_v123 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v383 @ S3_v124+4] (should have been resolved before IL gen)");
		nint num51 = 0;
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S3_v128 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ S3_v129+4] (should have been resolved before IL gen)");
		nint num53 = 0;
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S3_v133 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Char>>)+3C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v411 @ S3_v134+4] (should have been resolved before IL gen)");
		_possibleNumberChars = hashSet;
	}
}
