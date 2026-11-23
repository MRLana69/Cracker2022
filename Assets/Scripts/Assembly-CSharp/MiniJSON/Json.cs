using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace MiniJSON;

public static class Json
{
	private sealed class Parser : IDisposable
	{
		private enum TOKEN
		{
			NONE,
			CURLY_OPEN,
			CURLY_CLOSE,
			SQUARED_OPEN,
			SQUARED_CLOSE,
			COLON,
			COMMA,
			STRING,
			NUMBER,
			TRUE,
			FALSE,
			NULL
		}

		private const string WHITE_SPACE = " \t\n\r";

		private const string WORD_BREAK = " \t\n\r{}[],:\"";

		private StringReader json;

		private char PeekChar
		{
			get
			{
				//IL_0017: Expected I, but got Obj
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected Obj, but got Unknown
				StringReader stringReader = json;
				nint num = (nint)stringReader;
				object obj = stringReader + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.IO.StringReader>)+104] (should have been resolved before IL gen)");
				int value = default;
				return Convert.ToChar(value);
			}
		}

		private char NextChar
		{
			get
			{
				//IL_0017: Expected I, but got Obj
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected Obj, but got Unknown
				StringReader stringReader = json;
				nint num = (nint)stringReader;
				object obj = stringReader + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
				int value = default;
				return Convert.ToChar(value);
			}
		}

		private string NextWord
		{
			get
			{
				//IL_00aa: Expected I, but got Obj
				//IL_0078: Expected I, but got Obj
				StringBuilder stringBuilder = default;
				stringBuilder._002Ector();
				object obj = default;
				do
				{
					char peekChar = PeekChar;
					int num = " \t\n\r{}[],:\"".IndexOf(peekChar);
					if (num != -1)
					{
						break;
					}
					char nextChar = NextChar;
					StringBuilder stringBuilder2 = stringBuilder.Append(nextChar);
					StringReader stringReader = json;
					nint num2 = (nint)stringReader;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S1_v14 (Il2CppClass<System.IO.StringReader>)+104] (should have been resolved before IL gen)");
				}
				while ((nint)obj != -1);
				nint num3 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v9 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				string result = default;
				return result;
			}
		}

		private TOKEN NextToken
		{
			get
			{
				//IL_053d: Expected I, but got Obj
				//IL_0546: Unknown result type (might be due to invalid IL or missing references)
				//IL_054b: Expected Obj, but got Unknown
				//IL_034a: Expected Obj, but got I4
				//IL_0053: Expected Obj, but got I4
				//IL_03c1: Expected I, but got Obj
				//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_03cf: Expected Obj, but got Unknown
				//IL_0411: Expected I, but got Obj
				//IL_041a: Unknown result type (might be due to invalid IL or missing references)
				//IL_041f: Expected Obj, but got Unknown
				//IL_0441: Expected I, but got Obj
				//IL_044a: Unknown result type (might be due to invalid IL or missing references)
				//IL_044f: Expected Obj, but got Unknown
				StringReader stringReader = json;
				nint num = (nint)stringReader;
				object obj = stringReader + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v3 (Il2CppClass<System.IO.StringReader>)+104] (should have been resolved before IL gen)");
				object obj2 = default;
				bool flag = (nint)obj2 == -1;
				TOKEN result = TOKEN.NONE;
				if (!flag)
				{
					EatWhitespace();
					char peekChar = PeekChar;
					if (peekChar <= '[')
					{
						object obj3 = peekChar - 34;
						if (peekChar != '"')
						{
							if ((nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 != 3 && (nint)obj3 != 4 && (nint)obj3 != 5 && (nint)obj3 != 6 && (nint)obj3 != 7 && (nint)obj3 != 8 && (nint)obj3 != 9)
							{
								if ((nint)obj3 != 10)
								{
									if ((nint)obj3 != 11)
									{
										if ((nint)obj3 == 12 || (nint)obj3 == 13)
										{
											goto IL_0485;
										}
										if ((nint)obj3 != 14 && (nint)obj3 != 15 && (nint)obj3 != 16 && (nint)obj3 != 17 && (nint)obj3 != 18 && (nint)obj3 != 19 && (nint)obj3 != 20 && (nint)obj3 != 21 && (nint)obj3 != 22 && (nint)obj3 != 23)
										{
											bool flag2 = (nint)obj3 == 24;
											result = TOKEN.COLON;
											if (!flag2)
											{
												bool flag3 = peekChar == '[';
												result = TOKEN.SQUARED_OPEN;
												if (!flag3)
												{
													goto IL_0485;
												}
											}
											goto IL_057b;
										}
									}
									return TOKEN.NUMBER;
								}
								StringReader stringReader2 = json;
								nint num2 = (nint)stringReader2;
								object obj4 = stringReader2 + 80;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S1_v30 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
								return TOKEN.COMMA;
							}
							goto IL_0485;
						}
						result = TOKEN.STRING;
					}
					else
					{
						object obj5 = peekChar - 123;
						bool flag4 = peekChar == '{';
						result = TOKEN.CURLY_OPEN;
						if (!flag4)
						{
							if ((nint)obj5 != 1)
							{
								if ((nint)obj5 == 2)
								{
									StringReader stringReader3 = json;
									nint num3 = (nint)stringReader3;
									object obj6 = stringReader3 + 80;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S1_v20 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
									return TOKEN.CURLY_CLOSE;
								}
								if (peekChar == ']')
								{
									StringReader stringReader4 = json;
									nint num4 = (nint)stringReader4;
									object obj7 = stringReader4 + 80;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S1_v25 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
									return TOKEN.SQUARED_CLOSE;
								}
							}
							goto IL_0485;
						}
					}
				}
				goto IL_057b;
				IL_057b:
				return result;
				IL_0485:
				string nextWord = NextWord;
				bool flag5 = nextWord != "false";
				result = TOKEN.FALSE;
				if (flag5)
				{
					bool flag6 = nextWord != "true";
					result = TOKEN.TRUE;
					if (flag6)
					{
						bool flag7 = nextWord != "null";
						TOKEN result2 = TOKEN.NULL;
						if (flag7)
						{
							result2 = TOKEN.NONE;
						}
						return result2;
					}
				}
				goto IL_057b;
			}
		}

		private Parser(string jsonString)
		{
			StringReader stringReader = default;
			stringReader._002Ector(jsonString);
			json = stringReader;
		}

		public static object Parse(string jsonString)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected Obj, but got Unknown
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected Obj, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			//IL_01a3: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			Parser parser = default;
			parser._002Ector(jsonString);
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			object obj4 = default;
			object result = obj4;
			object obj5 = obj;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj6 = default;
				object obj7 = default;
				bool flag2 = obj6 == obj7;
				bool flag3 = !flag2;
				object obj8 = default;
				result = obj8;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					result = null;
					obj5 = obj;
					if (flag4)
					{
						goto IL_0205;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj9 = default;
					result = obj9;
				}
				_ = 0;
				object obj10 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj5 = 0;
			}
			goto IL_0205;
			IL_0205:
			object obj11 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
			return result;
		}

		public void Dispose()
		{
			json.Dispose();
			json = null;
		}

		private Dictionary<string, object> ParseObject()
		{
			//IL_019c: Expected I, but got Obj
			//IL_0123: Expected I, but got Obj
			//IL_0153: Expected Obj, but got I
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			StringReader stringReader = json;
			nint num3 = (nint)stringReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v4 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
			Dictionary<string, object> result;
			Dictionary<string, object> dictionary = default;
			while (true)
			{
				TOKEN nextToken = NextToken;
				if (nextToken != TOKEN.NONE)
				{
					if (nextToken != TOKEN.CURLY_OPEN)
					{
						bool flag = nextToken == TOKEN.CURLY_CLOSE;
						result = dictionary;
						if (flag)
						{
							break;
						}
						if (nextToken != TOKEN.SQUARED_OPEN && nextToken != TOKEN.SQUARED_CLOSE && nextToken != TOKEN.COLON && nextToken == TOKEN.COMMA)
						{
							continue;
						}
					}
					string text = ParseString();
					if (text != null)
					{
						TOKEN nextToken2 = NextToken;
						if (nextToken2 == TOKEN.COLON)
						{
							StringReader stringReader2 = json;
							nint num4 = (nint)stringReader2;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S1_v14 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
							object obj = ParseValue();
							nint num5 = 0;
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S5_v5+4] (should have been resolved before IL gen)");
							continue;
						}
					}
				}
				result = null;
				break;
			}
			return result;
		}

		private List<object> ParseArray()
		{
			//IL_010a: Expected I, but got Obj
			List<object> list = default;
			list._002Ector();
			StringReader stringReader = json;
			nint num = (nint)stringReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v5 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
			List<object> result;
			while (true)
			{
				TOKEN nextToken = NextToken;
				if (nextToken != TOKEN.NONE)
				{
					if (nextToken != TOKEN.CURLY_OPEN && nextToken != TOKEN.CURLY_CLOSE && nextToken != TOKEN.SQUARED_OPEN)
					{
						bool flag = nextToken == TOKEN.SQUARED_CLOSE;
						result = list;
						if (flag)
						{
							break;
						}
						if (nextToken != TOKEN.COLON && nextToken == TOKEN.COMMA)
						{
							continue;
						}
					}
					object item = ParseByToken(nextToken);
					list.Add(item);
					continue;
				}
				result = null;
				break;
			}
			return result;
		}

		private object ParseValue()
		{
			TOKEN nextToken = NextToken;
			return ParseByToken(nextToken);
		}

		private object ParseByToken(TOKEN token)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01f6: Expected Obj, but got I4
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected Obj, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = token - 1;
			Dictionary<string, object> result;
			if (token != TOKEN.CURLY_OPEN)
			{
				bool flag = (nint)obj3 == 1;
				result = null;
				if (!flag)
				{
					if ((nint)obj3 != 2)
					{
						bool flag2 = (nint)obj3 == 3;
						result = null;
						if (!flag2)
						{
							bool flag3 = (nint)obj3 == 4;
							result = null;
							if (!flag3)
							{
								bool flag4 = (nint)obj3 == 5;
								result = null;
								if (!flag4)
								{
									if ((nint)obj3 != 6)
									{
										if ((nint)obj3 != 7)
										{
											if ((nint)obj3 != 8)
											{
												if ((nint)obj3 != 9)
												{
													result = null;
												}
												else
												{
													_ = 0;
													object obj4 = obj + 14;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
													Dictionary<string, object> dictionary = default;
													result = dictionary;
												}
											}
											else
											{
												_ = 1;
												object obj5 = obj + 15;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
												Dictionary<string, object> dictionary2 = default;
												result = dictionary2;
											}
										}
										else
										{
											object obj6 = ParseNumber();
											result = (Dictionary<string, object>)obj6;
										}
									}
									else
									{
										string text = ParseString();
										result = (Dictionary<string, object>)(object)text;
									}
								}
							}
						}
					}
					else
					{
						List<object> list = ParseArray();
						result = (Dictionary<string, object>)(object)list;
					}
				}
			}
			else
			{
				Dictionary<string, object> dictionary3 = ParseObject();
				result = dictionary3;
			}
			return result;
		}

		private string ParseString()
		{
			//IL_03d5: Expected I, but got Obj
			//IL_041a: Expected I, but got Obj
			//IL_03ab: Expected I, but got Obj
			//IL_0079: Expected I, but got Obj
			//IL_0175: Expected Obj, but got I4
			//IL_0248: Expected Obj, but got I4
			//IL_02f8: Expected Obj, but got I4
			//IL_0368: Expected I, but got Obj
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Expected Obj, but got Unknown
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector();
			StringReader stringReader = json;
			nint num = (nint)stringReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v4 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
			object obj = default;
			object obj2 = default;
			StringBuilder stringBuilder2 = default;
			string value = default;
			while (true)
			{
				StringReader stringReader2 = json;
				nint num2 = (nint)stringReader2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S1_v8 (Il2CppClass<System.IO.StringReader>)+104] (should have been resolved before IL gen)");
				if ((nint)obj == -1)
				{
					break;
				}
				char nextChar = NextChar;
				char c;
				if (nextChar != '\\')
				{
					bool flag = nextChar != '"';
					c = nextChar;
					if (!flag)
					{
						break;
					}
				}
				else
				{
					StringReader stringReader3 = json;
					nint num3 = (nint)stringReader3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S1_v21 (Il2CppClass<System.IO.StringReader>)+104] (should have been resolved before IL gen)");
					if ((nint)obj2 == -1)
					{
						break;
					}
					char nextChar2 = NextChar;
					if (nextChar2 <= '\\')
					{
						if (nextChar2 != '"' && nextChar2 != '/')
						{
							if (nextChar2 != '\\')
							{
								continue;
							}
							c = nextChar2;
						}
						else
						{
							c = nextChar2;
						}
					}
					else if (nextChar2 <= 'f')
					{
						object obj3 = nextChar2 - 98;
						bool flag2 = nextChar2 == 'b';
						c = '\b';
						if (!flag2)
						{
							if ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4)
							{
								continue;
							}
							c = '\f';
						}
					}
					else
					{
						bool flag3 = nextChar2 == 'n';
						c = '\n';
						if (!flag3)
						{
							object obj4 = nextChar2 - 114;
							bool flag4 = nextChar2 == 'r';
							c = '\r';
							if (!flag4)
							{
								if ((nint)obj4 == 1)
								{
									continue;
								}
								if ((nint)obj4 != 2)
								{
									if ((nint)obj4 != 3)
									{
										continue;
									}
									stringBuilder2._002Ector();
									object obj5 = 0;
									while ((nint)obj5 < 4)
									{
										char nextChar3 = NextChar;
										StringBuilder stringBuilder3 = stringBuilder2.Append(nextChar3);
										object obj6 = obj5 + 1;
										obj5 = obj6;
									}
									nint num4 = (nint)stringBuilder2;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S1_v33 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
									int num5 = Convert.ToInt32(value, 16);
									c = (char)num5;
								}
								else
								{
									c = '\t';
								}
							}
						}
					}
				}
				char value2 = (char)(c & 0xFFFF);
				StringBuilder stringBuilder4 = stringBuilder.Append(value2);
			}
			nint num6 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S1_v13 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}

		private unsafe object ParseNumber()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Ref, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Ref, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			_ = 0;
			string nextWord = NextWord;
			int num = nextWord.IndexOf('.');
			if (num == -1)
			{
				bool flag = long.TryParse(nextWord, out *(long*)(obj + 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj3 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			}
			else
			{
				bool flag2 = double.TryParse(nextWord, out *(double*)(obj + 24));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				object obj4 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			}
			object result = default;
			return result;
		}

		private void EatWhitespace()
		{
			//IL_0017: Expected I, but got Obj
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			//IL_0041: Expected I, but got Obj
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			object obj3 = default;
			do
			{
				char peekChar = PeekChar;
				int num = " \t\n\r".IndexOf(peekChar);
				if (num != -1)
				{
					StringReader stringReader = json;
					nint num2 = (nint)stringReader;
					object obj = stringReader + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v7 (Il2CppClass<System.IO.StringReader>)+10C] (should have been resolved before IL gen)");
					StringReader stringReader2 = json;
					nint num3 = (nint)stringReader2;
					object obj2 = stringReader2 + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S1_v11 (Il2CppClass<System.IO.StringReader>)+104] (should have been resolved before IL gen)");
					continue;
				}
				break;
			}
			while ((nint)obj3 != -1);
		}
	}

	private sealed class Serializer
	{
		private StringBuilder builder;

		private Serializer()
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector();
			builder = stringBuilder;
		}

		public static string Serialize(object obj)
		{
			//IL_001a: Expected I, but got Obj
			Serializer serializer = default;
			serializer._002Ector();
			serializer.SerializeValue(obj);
			StringBuilder stringBuilder = serializer.builder;
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v5 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}

		private void SerializeValue(object value)
		{
			//IL_00e3: Expected I, but got Obj
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected Obj, but got Unknown
			//IL_01e8: Expected I, but got Obj
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected Obj, but got Unknown
			if (value == null)
			{
				StringBuilder stringBuilder = builder.Append("null");
				return;
			}
			bool flag = value == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(string);
				obj = value;
				if (!flag2)
				{
					obj = null;
				}
			}
			if (obj != null)
			{
				SerializeString((string)obj);
				return;
			}
			bool flag3 = value == null;
			object obj2 = null;
			if (!flag3)
			{
				bool flag4 = (object)value.GetType() == typeof(bool);
				obj2 = value;
				if (!flag4)
				{
					obj2 = null;
				}
			}
			if (obj2 != null)
			{
				nint num = (nint)value;
				object obj3 = value + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ S2_v16 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				string text = default;
				string value2 = text.ToLower();
				StringBuilder stringBuilder2 = builder.Append(value2);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			IList list = default;
			if (list != null)
			{
				SerializeArray(list);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			IDictionary dictionary = default;
			if (dictionary != null)
			{
				SerializeObject(dictionary);
				return;
			}
			bool flag5 = value == null;
			object obj4 = null;
			if (!flag5)
			{
				bool flag6 = (object)value.GetType() == typeof(char);
				obj4 = value;
				if (!flag6)
				{
					obj4 = null;
				}
			}
			if (obj4 != null)
			{
				nint num2 = (nint)value;
				object obj5 = value + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ S2_v6 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				string str = default;
				SerializeString(str);
			}
			else
			{
				SerializeOther(value);
			}
		}

		private void SerializeObject(IDictionary obj)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected Obj, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_0055: Expected Obj, but got I4
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected Obj, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected Obj, but got Unknown
			//IL_038d: Expected Obj, but got I
			//IL_0254: Expected Obj, but got I4
			object obj3 = default;
			object obj2 = obj3 - 32;
			_ = 0;
			StringBuilder stringBuilder = builder.Append('{');
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = obj2 + 24;
			object obj5 = obj2 + 28;
			obj2 = obj5;
			_ = 0;
			object obj6 = 1;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			Serializer serializer = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj7 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj6 == null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_02a4;
							}
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											obj6 = 0;
											continue;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_02a4;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_02a4;
				IL_02a4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj8 == obj9;
				bool flag2 = !flag;
				object obj10 = obj11;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj10 = obj12;
				}
				_ = 0;
				object obj13 = obj2 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				serializer = (Serializer)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
			object obj14 = obj2 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			StringBuilder stringBuilder2 = serializer.builder.Append('}');
		}

		private void SerializeArray(IList anArray)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected Obj, but got Unknown
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected Obj, but got Unknown
			//IL_0302: Expected Obj, but got I4
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected Obj, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected Obj, but got Unknown
			//IL_023c: Expected Obj, but got I
			//IL_0121: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			StringBuilder stringBuilder = builder.Append('[');
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 24;
			object obj4 = obj + 28;
			obj = obj4;
			_ = 0;
			object obj5 = 1;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			Serializer serializer = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj5 == null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_0153;
							}
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							obj5 = 0;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_0153;
				IL_0153:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 == obj8;
				bool flag2 = !flag;
				object obj9 = obj10;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj11;
				}
				_ = 0;
				object obj12 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				serializer = (Serializer)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			StringBuilder stringBuilder2 = serializer.builder.Append(']');
		}

		private void SerializeString(string str)
		{
			//IL_031c: Expected Obj, but got I4
			//IL_0036: Expected Obj, but got I
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected Obj, but got Unknown
			//IL_0211: Expected Obj, but got I
			StringBuilder stringBuilder = builder.Append('"');
			char[] array = str.ToCharArray();
			object obj6;
			for (object obj = 0; array.Length > (nint)obj; obj6 = obj + 1, obj = obj6)
			{
				object obj2 = obj << 1;
				object obj3 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
				object obj4 = -8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
				if ((nint)0 != 8)
				{
					if ((nint)obj4 != 1)
					{
						if ((nint)obj4 != 2)
						{
							if ((nint)obj4 != 3)
							{
								if ((nint)obj4 == 4)
								{
									StringBuilder stringBuilder2 = builder.Append("\\f");
									continue;
								}
								if ((nint)obj4 == 5)
								{
									StringBuilder stringBuilder3 = builder.Append("\\r");
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
								if ((nint)0 == 92)
								{
									StringBuilder stringBuilder4 = builder.Append("\\\\");
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
								if ((nint)0 == 34)
								{
									StringBuilder stringBuilder5 = builder.Append("\\\"");
									continue;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
							object obj5 = -32;
							if ((nint)obj5 <= 94)
							{
								StringBuilder stringBuilder6 = builder;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
								StringBuilder stringBuilder7 = stringBuilder6.Append('\0');
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+10]");
								string text = Convert.ToString(0, 16);
								string text2 = text.PadLeft(4, '0');
								string value = "\\u" + text2;
								StringBuilder stringBuilder8 = builder.Append(value);
							}
						}
						else
						{
							StringBuilder stringBuilder9 = builder.Append("\\n");
						}
					}
					else
					{
						StringBuilder stringBuilder10 = builder.Append("\\t");
					}
				}
				else
				{
					StringBuilder stringBuilder11 = builder.Append("\\b");
				}
			}
			StringBuilder stringBuilder12 = builder.Append('"');
		}

		private void SerializeOther(object value)
		{
			//IL_03d4: Expected I, but got Obj
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Expected Obj, but got Unknown
			//IL_0408: Expected I, but got Obj
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Expected Obj, but got Unknown
			bool flag = value == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(float);
				obj = value;
				if (!flag2)
				{
					obj = null;
				}
			}
			if (obj == null)
			{
				bool flag3 = value == null;
				object obj2 = null;
				if (!flag3)
				{
					bool flag4 = (object)value.GetType() == typeof(int);
					obj2 = value;
					if (!flag4)
					{
						obj2 = null;
					}
				}
				if (obj2 == null)
				{
					bool flag5 = value == null;
					object obj3 = null;
					if (!flag5)
					{
						bool flag6 = (object)value.GetType() == typeof(uint);
						obj3 = value;
						if (!flag6)
						{
							obj3 = null;
						}
					}
					if (obj3 == null)
					{
						bool flag7 = value == null;
						object obj4 = null;
						if (!flag7)
						{
							bool flag8 = (object)value.GetType() == typeof(long);
							obj4 = value;
							if (!flag8)
							{
								obj4 = null;
							}
						}
						if (obj4 == null)
						{
							bool flag9 = value == null;
							object obj5 = null;
							if (!flag9)
							{
								bool flag10 = (object)value.GetType() == typeof(double);
								obj5 = value;
								if (!flag10)
								{
									obj5 = null;
								}
							}
							if (obj5 == null)
							{
								bool flag11 = value == null;
								object obj6 = null;
								if (!flag11)
								{
									bool flag12 = (object)value.GetType() == typeof(sbyte);
									obj6 = value;
									if (!flag12)
									{
										obj6 = null;
									}
								}
								if (obj6 == null)
								{
									bool flag13 = value == null;
									object obj7 = null;
									if (!flag13)
									{
										bool flag14 = (object)value.GetType() == typeof(byte);
										obj7 = value;
										if (!flag14)
										{
											obj7 = null;
										}
									}
									if (obj7 == null)
									{
										bool flag15 = value == null;
										object obj8 = null;
										if (!flag15)
										{
											bool flag16 = (object)value.GetType() == typeof(short);
											obj8 = value;
											if (!flag16)
											{
												obj8 = null;
											}
										}
										if (obj8 == null)
										{
											bool flag17 = value == null;
											object obj9 = null;
											if (!flag17)
											{
												bool flag18 = (object)value.GetType() == typeof(ushort);
												obj9 = value;
												if (!flag18)
												{
													obj9 = null;
												}
											}
											if (obj9 == null)
											{
												bool flag19 = value == null;
												object obj10 = null;
												if (!flag19)
												{
													bool flag20 = (object)value.GetType() == typeof(ulong);
													obj10 = value;
													if (!flag20)
													{
														obj10 = null;
													}
												}
												if (obj10 == null)
												{
													bool flag21 = value == null;
													object obj11 = null;
													if (!flag21)
													{
														bool flag22 = (object)value.GetType() == typeof(decimal);
														obj11 = value;
														if (!flag22)
														{
															obj11 = null;
														}
													}
													if (obj11 == null)
													{
														nint num = (nint)value;
														object obj12 = value + 24;
														Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ S2_v19 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
														string str = default;
														SerializeString(str);
														return;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			nint num2 = (nint)value;
			object obj13 = value + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S2_v4 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
			string value2 = default;
			StringBuilder stringBuilder = builder.Append(value2);
		}
	}

	public static object Deserialize(string json)
	{
		if (json == null)
		{
			return null;
		}
		return Parser.Parse(json);
	}

	public static string Serialize(object obj)
	{
		return Serializer.Serialize(obj);
	}
}
