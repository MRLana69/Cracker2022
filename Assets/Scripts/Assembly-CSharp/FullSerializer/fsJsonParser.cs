using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;

namespace FullSerializer;

public class fsJsonParser
{
	private int _start;

	private string _input;

	private readonly StringBuilder _cachedStringBuilder;

	private fsResult MakeFailure(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string input = _input;
		int num = _start - 20;
		if (num <= 0)
		{
			num = 0;
		}
		int num2 = input._stringLength - num;
		if (num2 >= 50)
		{
			num2 = 50;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private bool TryMoveNext()
	{
		string input = _input;
		if (_start < input._stringLength)
		{
			int start = _start + 1;
			_start = start;
		}
		return _start < input._stringLength;
	}

	private bool HasValue()
	{
		if (_start >= 0)
		{
			string input = _input;
			return input._stringLength > _start;
		}
		return false;
	}

	private bool HasValue(int offset)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		object obj = offset + _start;
		if ((nint)obj >= 0)
		{
			string input = _input;
			object obj2 = offset + _start;
			return input._stringLength > (nint)obj2;
		}
		return false;
	}

	private char Character()
	{
		return Character(0);
	}

	private char Character(int offset)
	{
		int index = offset + _start;
		return _input.get_Chars(index);
	}

	private unsafe void SkipSpace()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected I4, but got Unknown
		//IL_059c: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		while (true)
		{
			bool flag;
			if (_start >= 0)
			{
				string input = _input;
				flag = input._stringLength > _start;
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				break;
			}
			char c = Character();
			if (!char.IsWhiteSpace(c))
			{
				object obj3 = _start + 1;
				bool flag2;
				if ((nint)obj3 >= 0)
				{
					string input2 = _input;
					object obj4 = _start + 1;
					flag2 = input2._stringLength > (nint)obj4;
				}
				else
				{
					flag2 = false;
				}
				if (!flag2)
				{
					break;
				}
				char c2 = Character(0);
				if (c2 != '/')
				{
					break;
				}
				char c3 = Character(1);
				if (c3 != '/')
				{
					char c4 = Character(1);
					if (c4 != '*')
					{
						continue;
					}
					string input3 = _input;
					if (_start < input3._stringLength)
					{
						int start = _start + 1;
						_start = start;
					}
					while (true)
					{
						string input4 = _input;
						if (_start < input4._stringLength)
						{
							int start2 = _start + 1;
							_start = start2;
						}
						object obj5 = _start + 1;
						bool flag3;
						if ((nint)obj5 >= 0)
						{
							string input5 = _input;
							object obj6 = _start + 1;
							flag3 = input5._stringLength > (nint)obj6;
						}
						else
						{
							flag3 = false;
						}
						if (!flag3)
						{
							break;
						}
						char c5 = Character(0);
						if (c5 != '*')
						{
							continue;
						}
						char c6 = Character(1);
						if (c6 != '/')
						{
							continue;
						}
						goto IL_0299;
					}
					continue;
				}
				while (true)
				{
					bool flag4;
					if (_start >= 0)
					{
						string input6 = _input;
						flag4 = input6._stringLength > _start;
					}
					else
					{
						flag4 = false;
					}
					if (!flag4)
					{
						break;
					}
					string newLine = Environment.NewLine;
					char c7 = Character();
					char c8 = (char)(obj + 14);
					string text = ((char*)(ushort)c8)->ToString();
					string value = text;
					if (text == null)
					{
						value = "";
					}
					if (newLine.Contains(value))
					{
						break;
					}
					string input7 = _input;
					if (_start < input7._stringLength)
					{
						int start3 = _start + 1;
						_start = start3;
					}
				}
				continue;
			}
			goto IL_03fd;
			IL_03fd:
			string input8 = _input;
			if (_start < input8._stringLength)
			{
				int start4 = _start + 1;
				_start = start4;
			}
			continue;
			IL_0299:
			string input9 = _input;
			if (_start < input9._stringLength)
			{
				int start5 = _start + 1;
				_start = start5;
			}
			string input10 = _input;
			if (_start < input10._stringLength)
			{
				int start6 = _start + 1;
				_start = start6;
			}
			goto IL_03fd;
		}
	}

	private bool IsHex(char c)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		object obj = c - 48;
		object obj2 = obj & 0xFFFF;
		if ((nint)obj2 >= 10)
		{
			object obj3 = c - 97;
			object obj4 = obj3 & 0xFFFF;
			if ((nint)obj4 >= 6)
			{
				object obj5 = c - 65;
				object obj6 = obj5 & 0xFFFF;
				return (nint)obj6 < 6;
			}
		}
		return true;
	}

	private uint ParseSingleChar(char c1, uint multipliyer)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		object obj = c1 - 48;
		object obj2 = c1 - 48;
		object obj3 = obj2 & 0xFFFF;
		uint result;
		if ((nint)obj3 > 9)
		{
			obj = c1 - 55;
			object obj4 = c1 - 65;
			object obj5 = obj4 & 0xFFFF;
			if ((nint)obj5 > 5)
			{
				object obj6 = c1 - 97;
				object obj7 = obj6 & 0xFFFF;
				bool flag = (nint)obj7 > 5;
				result = 0u;
				if (flag)
				{
					goto IL_00fb;
				}
				obj = c1 - 87;
			}
		}
		result = (uint)(int)(obj * multipliyer);
		goto IL_00fb;
		IL_00fb:
		return result;
	}

	private uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		//IL_0059: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13C7");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13C7");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13C7");
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 + obj3;
		object obj5 = default;
		object obj4 = obj5 + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13C7");
		object obj6 = default;
		return (uint)(int)(obj4 + obj6);
	}

	private unsafe fsResult TryUnescapeChar(out char escaped)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Expected native int or pointer, but got VT
		//IL_0257: Expected Obj, but got I4
		//IL_0b18: Expected I4, but got VT
		//IL_0b13: Expected native int or pointer, but got VT
		//IL_0ae0: Expected I4, but got VT
		//IL_0adb: Expected native int or pointer, but got VT
		//IL_0b88: Expected I4, but got VT
		//IL_0b83: Expected native int or pointer, but got VT
		//IL_0b34: Expected I4, but got VT
		//IL_0b2f: Expected native int or pointer, but got VT
		//IL_02de: Expected Obj, but got I4
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		//IL_0ac4: Expected I4, but got VT
		//IL_0abf: Expected native int or pointer, but got VT
		//IL_0afc: Expected I4, but got VT
		//IL_0af7: Expected native int or pointer, but got VT
		//IL_0b50: Expected I4, but got VT
		//IL_0b4b: Expected native int or pointer, but got VT
		//IL_0a0a: Expected native int or pointer, but got VT
		//IL_0aa8: Expected I4, but got VT
		//IL_0aa3: Expected native int or pointer, but got VT
		//IL_0a8c: Expected I4, but got VT
		//IL_0a87: Expected native int or pointer, but got VT
		//IL_0b6c: Expected I4, but got VT
		//IL_0b67: Expected native int or pointer, but got VT
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got Unknown
		//IL_0cae: Expected I4, but got VT
		//IL_0ca9: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		string input = _input;
		if (_start < input._stringLength)
		{
			int start = _start + 1;
			_start = start;
		}
		bool flag;
		if (_start >= 0)
		{
			string input2 = _input;
			flag = input2._stringLength > _start;
		}
		else
		{
			flag = false;
		}
		fsResult fsResult3 = default;
		ref char reference;
		if (!flag)
		{
			reference = ref *(char*)32;
			fsResult fsResult2 = MakeFailure("Unexpected end of input after \\");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			char c = Character();
			if (c <= '\\')
			{
				if (c <= '/')
				{
					if (c != '"')
					{
						if (c != '/')
						{
							goto IL_09a0;
						}
						string input3 = _input;
						if (_start < input3._stringLength)
						{
							int start2 = _start + 1;
							_start = start2;
						}
						reference = ref *(char*)47;
						((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
					}
					else
					{
						string input4 = _input;
						if (_start < input4._stringLength)
						{
							int start3 = _start + 1;
							_start = start3;
						}
						reference = ref *(char*)34;
						((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
					}
				}
				else if (c != '0')
				{
					if (c != '\\')
					{
						goto IL_09a0;
					}
					string input5 = _input;
					if (_start < input5._stringLength)
					{
						int start4 = _start + 1;
						_start = start4;
					}
					reference = ref *(char*)92;
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
				}
				else
				{
					string input6 = _input;
					if (_start < input6._stringLength)
					{
						int start5 = _start + 1;
						_start = start5;
					}
					reference = ref *(char*)null;
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
				}
			}
			else if (c <= 'b')
			{
				object obj3 = c - 97;
				if (c != 'a')
				{
					if ((nint)obj3 != 1)
					{
						goto IL_09a0;
					}
					string input7 = _input;
					if (_start < input7._stringLength)
					{
						int start6 = _start + 1;
						_start = start6;
					}
					reference = ref *(char*)8;
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
				}
				else
				{
					string input8 = _input;
					if (_start < input8._stringLength)
					{
						int start7 = _start + 1;
						_start = start7;
					}
					reference = ref *(char*)7;
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
				}
			}
			else if (c != 'f')
			{
				if (c != 'n')
				{
					object obj4 = c - 114;
					if (c != 'r')
					{
						if ((nint)obj4 != 1)
						{
							if ((nint)obj4 == 2)
							{
								string input9 = _input;
								if (_start < input9._stringLength)
								{
									int start8 = _start + 1;
									_start = start8;
								}
								reference = ref *(char*)9;
								((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
								goto IL_0a70;
							}
							if ((nint)obj4 == 3)
							{
								string input10 = _input;
								if (_start < input10._stringLength)
								{
									int start9 = _start + 1;
									_start = start9;
								}
								char c2 = Character(0);
								if (IsHex(c2))
								{
									char c3 = Character(1);
									if (IsHex(c3))
									{
										char c4 = Character(2);
										if (IsHex(c4))
										{
											char c5 = Character(3);
											if (IsHex(c5))
											{
												char c6 = Character(0);
												char c7 = Character(1);
												char c8 = Character(2);
												char c9 = Character(3);
												uint num = ParseUnicode(c6, c7, c8, c9);
												string input11 = _input;
												if (_start < input11._stringLength)
												{
													int start10 = _start + 1;
													_start = start10;
												}
												string input12 = _input;
												if (_start < input12._stringLength)
												{
													int start11 = _start + 1;
													_start = start11;
												}
												string input13 = _input;
												if (_start < input13._stringLength)
												{
													int start12 = _start + 1;
													_start = start12;
												}
												string input14 = _input;
												if (_start < input14._stringLength)
												{
													int start13 = _start + 1;
													_start = start13;
												}
												reference = ref *(char*)num;
												((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
												goto IL_0a70;
											}
										}
									}
								}
								reference = ref *(char*)null;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
								char c10 = Character(0);
								object obj5 = obj + 6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
								throw new ArrayTypeMismatchException();
							}
						}
						goto IL_09a0;
					}
					string input15 = _input;
					if (_start < input15._stringLength)
					{
						int start14 = _start + 1;
						_start = start14;
					}
					reference = ref *(char*)13;
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
				}
				else
				{
					string input16 = _input;
					if (_start < input16._stringLength)
					{
						int start15 = _start + 1;
						_start = start15;
					}
					reference = ref *(char*)10;
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
				}
			}
			else
			{
				string input17 = _input;
				if (_start < input17._stringLength)
				{
					int start16 = _start + 1;
					_start = start16;
				}
				reference = ref *(char*)12;
				((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
			}
		}
		goto IL_0a70;
		IL_09a0:
		reference = ref *(char*)null;
		char c11 = Character();
		object obj6 = obj + 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string message = $"Invalid escape sequence \\{arg}";
		fsResult fsResult4 = MakeFailure(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		((fsResult*)(nint)fsResult3)->_success = false;
		goto IL_0a70;
		IL_0a70:
		return fsResult3;
	}

	private unsafe fsResult TryParseExact(string content)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e3: Expected I4, but got VT
		//IL_01de: Expected native int or pointer, but got VT
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected I4, but got Unknown
		//IL_0166: Expected I4, but got Obj
		//IL_0161: Expected native int or pointer, but got VT
		//IL_00c5: Expected I4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		int num = default;
		fsResult fsResult3 = default;
		int num2 = default;
		while (true)
		{
			if (content._stringLength > num)
			{
				char c = Character();
				char c2 = content.get_Chars(num);
				if (c != c2)
				{
					char c3 = content.get_Chars(num);
					char c4 = (char)(obj + 14);
					string text = ((char*)(ushort)c4)->ToString();
					string message = "Expected " + text;
					fsResult fsResult2 = MakeFailure(message);
					((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
					break;
				}
				string input = _input;
				if (_start < input._stringLength)
				{
					int start = _start + 1;
					_start = start;
				}
				if (_start < input._stringLength)
				{
					num = num2 + 1;
					continue;
				}
				string message2 = "Unexpected end of content when parsing " + content;
				fsResult fsResult4 = MakeFailure(message2);
				((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
				break;
			}
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
			break;
		}
		return fsResult3;
	}

	private unsafe fsResult TryParseTrue(out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I
		//IL_005a: Expected native int or pointer, but got VT
		//IL_003c: Expected I4, but got VT
		//IL_0037: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = TryParseExact("true");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = (nint)0 & (nint)0xFF;
		fsResult fsResult3 = default;
		if (obj3 != null)
		{
			fsData fsData2 = default;
			fsData2._002Ector(boolean: true);
			ref fsData reference = ref *(fsData*)fsData2;
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			ref fsData reference = ref *(fsData*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		return fsResult3;
	}

	private unsafe fsResult TryParseFalse(out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I
		//IL_005a: Expected native int or pointer, but got VT
		//IL_003c: Expected I4, but got VT
		//IL_0037: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = TryParseExact("false");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = (nint)0 & (nint)0xFF;
		fsResult fsResult3 = default;
		if (obj3 != null)
		{
			fsData fsData2 = default;
			fsData2._002Ector(boolean: false);
			ref fsData reference = ref *(fsData*)fsData2;
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			ref fsData reference = ref *(fsData*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		return fsResult3;
	}

	private unsafe fsResult TryParseNull(out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_0052: Expected native int or pointer, but got VT
		//IL_0034: Expected I4, but got VT
		//IL_002f: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = TryParseExact("null");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = (nint)0 & (nint)0xFF;
		fsResult fsResult3 = default;
		if (obj3 != null)
		{
			_ = 0;
			object obj4 = default;
			ref fsData reference = ref *(fsData*)obj4;
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			ref fsData reference = ref *(fsData*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		return fsResult3;
	}

	private bool IsSeparator(char c)
	{
		bool flag = char.IsWhiteSpace(c);
		bool result = true;
		if (!flag)
		{
			bool flag2 = c == ',';
			result = true;
			if (!flag2)
			{
				bool flag3 = c == ']';
				result = true;
				if (!flag3)
				{
					bool flag4 = c == '}';
					result = true;
					if (!flag4)
					{
						result = false;
					}
				}
			}
		}
		return result;
	}

	private unsafe fsResult TryParseNumber(out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Ref, but got Unknown
		//IL_0278: Expected F8, but got I
		//IL_0293: Expected I4, but got VT
		//IL_028e: Expected native int or pointer, but got VT
		//IL_0259: Expected native int or pointer, but got VT
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Ref, but got Unknown
		//IL_034f: Expected I8, but got I
		//IL_036a: Expected I4, but got VT
		//IL_0365: Expected native int or pointer, but got VT
		//IL_0330: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		char c;
		do
		{
			string input = _input;
			if (_start < input._stringLength)
			{
				int start = _start + 1;
				_start = start;
			}
			if (_start >= input._stringLength)
			{
				break;
			}
			bool flag;
			if (_start >= 0)
			{
				string input2 = _input;
				flag = input2._stringLength > _start;
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				break;
			}
			c = Character();
		}
		while (!IsSeparator(c));
		int length = _start - _start;
		string text = _input.Substring(_start, length);
		fsResult fsResult3 = default;
		if (text.Contains(".") || text.Contains("e") || text.Contains("E") || !(text != "Infinity") || !(text != "-Infinity") || text == "NaN")
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (!double.TryParse(text, NumberStyles.Any, invariantCulture, out *(double*)(obj + 24)))
			{
				ref fsData reference = ref *(fsData*)null;
				string message = "Bad double format with " + text;
				fsResult fsResult2 = MakeFailure(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				fsData fsData2 = default;
				fsData2._002Ector(0.0);
				ref fsData reference = ref *(fsData*)fsData2;
				((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
			}
		}
		else
		{
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			if (!long.TryParse(text, NumberStyles.Any, invariantCulture2, out *(long*)(obj + 16)))
			{
				ref fsData reference = ref *(fsData*)null;
				string message2 = "Bad Int64 format with " + text;
				fsResult fsResult4 = MakeFailure(message2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				fsData fsData3 = default;
				fsData3._002Ector(0L);
				ref fsData reference = ref *(fsData*)fsData3;
				((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
			}
		}
		return fsResult3;
	}

	private unsafe fsResult TryParseString(out string str)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0097: Expected native int or pointer, but got VT
		//IL_0357: Expected native int or pointer, but got VT
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Ref, but got Unknown
		//IL_0225: Expected native int or pointer, but got VT
		//IL_0373: Expected I, but got Obj
		//IL_0393: Expected I4, but got VT
		//IL_038e: Expected native int or pointer, but got VT
		//IL_0189: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_cachedStringBuilder.Length = 0;
		char c = Character();
		fsResult fsResult3 = default;
		ref string reference;
		if (c == '"')
		{
			string input = _input;
			if (_start < input._stringLength)
			{
				int start = _start + 1;
				_start = start;
			}
			if (_start < input._stringLength)
			{
				object obj3 = default;
				while (true)
				{
					bool flag;
					if (_start >= 0)
					{
						string input2 = _input;
						flag = input2._stringLength > _start;
					}
					else
					{
						flag = false;
					}
					if (flag)
					{
						char c2 = Character();
						if (c2 != '"')
						{
							char c3 = Character();
							if (c3 == '\\')
							{
								fsResult fsResult2 = TryUnescapeChar(out *(char*)(obj + 30));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								if ((nint)0 == 0)
								{
									reference = ref *(string*)string.Empty;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
									((fsResult*)(nint)fsResult3)->_success = false;
									break;
								}
								StringBuilder cachedStringBuilder = _cachedStringBuilder;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E]");
								StringBuilder stringBuilder = cachedStringBuilder.Append('\0');
							}
							else
							{
								StringBuilder stringBuilder2 = _cachedStringBuilder.Append(c3);
								string input3 = _input;
								if (_start < input3._stringLength)
								{
									int start2 = _start + 1;
									_start = start2;
								}
								if (_start >= input3._stringLength)
								{
									reference = ref *(string*)string.Empty;
									fsResult fsResult4 = MakeFailure("Unexpected end of input when reading a string");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
									((fsResult*)(nint)fsResult3)->_success = false;
									break;
								}
							}
							continue;
						}
					}
					bool flag2;
					if (_start >= 0)
					{
						string input4 = _input;
						flag2 = input4._stringLength > _start;
					}
					else
					{
						flag2 = false;
					}
					if (flag2)
					{
						char c4 = Character();
						if (c4 == '"')
						{
							string input5 = _input;
							if (_start < input5._stringLength)
							{
								int start3 = _start + 1;
								_start = start3;
							}
							if (_start < input5._stringLength)
							{
								StringBuilder cachedStringBuilder2 = _cachedStringBuilder;
								nint num = (nint)cachedStringBuilder2;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ S2_v13 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
								reference = ref *(string*)obj3;
								((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
								break;
							}
						}
					}
					reference = ref *(string*)string.Empty;
					fsResult fsResult5 = MakeFailure("No closing \" when parsing a string");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					((fsResult*)(nint)fsResult3)->_success = false;
					break;
				}
				goto IL_03fe;
			}
		}
		reference = ref *(string*)string.Empty;
		fsResult fsResult6 = MakeFailure("Expected initial \" when parsing a string");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		((fsResult*)(nint)fsResult3)->_success = false;
		goto IL_03fe;
		IL_03fe:
		return fsResult3;
	}

	private unsafe fsResult TryParseArray(out fsData arr)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003b: Expected native int or pointer, but got VT
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_0401: Expected native int or pointer, but got VT
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Ref, but got Unknown
		//IL_0203: Expected Obj, but got I
		//IL_01e4: Expected native int or pointer, but got VT
		//IL_042b: Expected I4, but got VT
		//IL_0426: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		char c = Character();
		fsResult fsResult3 = default;
		if (c != '[')
		{
			ref fsData reference = ref *(fsData*)null;
			fsResult fsResult2 = MakeFailure("Expected initial [ when parsing an array");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			string input = _input;
			if (_start < input._stringLength)
			{
				int start = _start + 1;
				_start = start;
			}
			if (input._stringLength <= _start)
			{
				ref fsData reference = ref *(fsData*)null;
				fsResult fsResult4 = MakeFailure("Unexpected end of input when parsing an array");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else
			{
				SkipSpace();
				List<fsData> list = default;
				list._002Ector();
				object obj3 = default;
				while (true)
				{
					bool flag;
					if (_start >= 0)
					{
						string input2 = _input;
						flag = input2._stringLength > _start;
					}
					else
					{
						flag = false;
					}
					ref fsData reference;
					if (flag)
					{
						char c2 = Character();
						if (c2 != ']')
						{
							fsResult fsResult5 = RunParse(out *(fsData*)(obj + 28));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							if ((nint)0 == 0)
							{
								reference = ref *(fsData*)null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								((fsResult*)(nint)fsResult3)->_success = false;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							list.Add((fsData)0);
							SkipSpace();
							bool flag2;
							if (_start >= 0)
							{
								string input3 = _input;
								flag2 = input3._stringLength > _start;
							}
							else
							{
								flag2 = false;
							}
							if (!flag2)
							{
								continue;
							}
							char c3 = Character();
							if (c3 != ',')
							{
								continue;
							}
							string input4 = _input;
							if (_start < input4._stringLength)
							{
								int start2 = _start + 1;
								_start = start2;
							}
							if (_start < input4._stringLength)
							{
								SkipSpace();
								continue;
							}
						}
					}
					bool flag3;
					if (_start >= 0)
					{
						string input5 = _input;
						flag3 = input5._stringLength > _start;
					}
					else
					{
						flag3 = false;
					}
					if (flag3)
					{
						char c4 = Character();
						if (c4 == ']')
						{
							string input6 = _input;
							if (_start < input6._stringLength)
							{
								int start3 = _start + 1;
								_start = start3;
							}
							if (_start < input6._stringLength)
							{
								reference = ref *(fsData*)obj3;
								((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
								break;
							}
						}
					}
					reference = ref *(fsData*)null;
					fsResult fsResult6 = MakeFailure("No closing ] for array");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					((fsResult*)(nint)fsResult3)->_success = false;
					break;
				}
			}
		}
		return fsResult3;
	}

	private unsafe fsResult TryParseObject(out fsData obj)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003b: Expected native int or pointer, but got VT
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_013b: Expected Obj, but got I4
		//IL_06e3: Expected I, but got Obj
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_0629: Expected native int or pointer, but got VT
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Ref, but got Unknown
		//IL_023e: Expected native int or pointer, but got VT
		//IL_0352: Expected Obj, but got I
		//IL_0653: Expected I4, but got VT
		//IL_064e: Expected native int or pointer, but got VT
		//IL_0379: Expected native int or pointer, but got VT
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Ref, but got Unknown
		//IL_0426: Expected Obj, but got I
		//IL_0400: Expected native int or pointer, but got VT
		object obj3 = default;
		object obj2 = obj3 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		char c = Character();
		fsResult fsResult3 = default;
		object obj4;
		if (c != '{')
		{
			ref fsData reference = ref *(fsData*)null;
			fsResult fsResult2 = MakeFailure("Expected initial { when parsing an object");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			string input = _input;
			if (_start < input._stringLength)
			{
				int start = _start + 1;
				_start = start;
			}
			if (_start < input._stringLength)
			{
				SkipSpace();
				object obj5;
				if (~(fsGlobalConfig.IsCaseSensitive ? 1u : 0u) != 0)
				{
					obj4 = 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [536279]");
					if ((nint)0 != 0)
					{
						goto IL_06d5;
					}
					obj4 = 12;
					obj5 = 5464697;
				}
				else
				{
					obj4 = 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [536B2D]");
					if ((nint)0 != 0)
					{
						goto IL_06d5;
					}
					obj4 = 8;
					obj5 = 5466925;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_codegen_initialize_runtime_metadata\"");
				obj5 = 1;
				goto IL_06d5;
			}
			ref fsData reference = ref *(fsData*)null;
			fsResult fsResult4 = MakeFailure("Unexpected end of input when parsing an object");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		goto IL_069f;
		IL_06d5:
		nint num = (nint)typeof(StringComparer);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v19 (Il2CppClass<System.StringComparer>)+5C]");
		object obj7 = obj6 + 0;
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>>)+4] (should have been resolved before IL gen)");
		object obj9 = default;
		while (true)
		{
			bool flag;
			if (_start >= 0)
			{
				string input2 = _input;
				flag = input2._stringLength > _start;
			}
			else
			{
				flag = false;
			}
			ref fsData reference;
			if (flag)
			{
				char c2 = Character();
				if (c2 != '}')
				{
					SkipSpace();
					fsResult fsResult5 = TryParseString(out *(string*)(obj2 + 20));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					if ((nint)0 == 0)
					{
						reference = ref *(fsData*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						((fsResult*)(nint)fsResult3)->_success = false;
						break;
					}
					SkipSpace();
					bool flag2;
					if (_start >= 0)
					{
						string input3 = _input;
						flag2 = input3._stringLength > _start;
					}
					else
					{
						flag2 = false;
					}
					if (flag2)
					{
						char c3 = Character();
						if (c3 == ':')
						{
							string input4 = _input;
							if (_start < input4._stringLength)
							{
								int start2 = _start + 1;
								_start = start2;
							}
							if (_start < input4._stringLength)
							{
								SkipSpace();
								fsResult fsResult6 = RunParse(out *(fsData*)(obj2 + 16));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								if ((nint)0 == 0)
								{
									reference = ref *(fsData*)null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
									((fsResult*)(nint)fsResult3)->_success = false;
									break;
								}
								nint num4 = 0;
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S5_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
								object obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ S5_v8+4] (should have been resolved before IL gen)");
								SkipSpace();
								bool flag3;
								if (_start >= 0)
								{
									string input5 = _input;
									flag3 = input5._stringLength > _start;
								}
								else
								{
									flag3 = false;
								}
								if (!flag3)
								{
									continue;
								}
								char c4 = Character();
								if (c4 != ',')
								{
									continue;
								}
								string input6 = _input;
								if (_start < input6._stringLength)
								{
									int start3 = _start + 1;
									_start = start3;
								}
								if (_start < input6._stringLength)
								{
									SkipSpace();
									continue;
								}
								goto IL_0521;
							}
						}
					}
					reference = ref *(fsData*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
					string message = "Expected : after key \"" + (string)0 + "\"";
					fsResult fsResult7 = MakeFailure(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					((fsResult*)(nint)fsResult3)->_success = false;
					break;
				}
			}
			goto IL_0521;
			IL_0521:
			bool flag4;
			if (_start >= 0)
			{
				string input7 = _input;
				flag4 = input7._stringLength > _start;
			}
			else
			{
				flag4 = false;
			}
			if (flag4)
			{
				char c5 = Character();
				if (c5 == '}')
				{
					string input8 = _input;
					if (_start < input8._stringLength)
					{
						int start4 = _start + 1;
						_start = start4;
					}
					if (_start < input8._stringLength)
					{
						reference = ref *(fsData*)obj9;
						((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
						break;
					}
				}
			}
			reference = ref *(fsData*)null;
			fsResult fsResult8 = MakeFailure("No closing } for object");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
			break;
		}
		goto IL_069f;
		IL_069f:
		return fsResult3;
	}

	private unsafe fsResult RunParse(out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006d: Expected native int or pointer, but got VT
		//IL_0344: Expected native int or pointer, but got VT
		//IL_036c: Expected native int or pointer, but got VT
		//IL_042d: Expected native int or pointer, but got VT
		//IL_00e5: Expected Obj, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected I4, but got Unknown
		//IL_02ef: Expected native int or pointer, but got VT
		//IL_0110: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0405: Expected native int or pointer, but got VT
		//IL_028a: Expected native int or pointer, but got VT
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Ref, but got Unknown
		//IL_0321: Expected I4, but got VT
		//IL_031c: Expected native int or pointer, but got VT
		//IL_019a: Expected I4, but got Obj
		//IL_0195: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		SkipSpace();
		bool flag;
		if (_start >= 0)
		{
			string input = _input;
			flag = input._stringLength > _start;
		}
		else
		{
			flag = false;
		}
		fsResult fsResult3 = default;
		ref fsData reference;
		if (!flag)
		{
			reference = ref *(fsData*)null;
			fsResult fsResult2 = MakeFailure("Unexpected end of input");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			char c = Character();
			if (c <= '[')
			{
				if (c <= 'I')
				{
					object obj3 = c - 34;
					if ((nint)obj3 <= 23)
					{
						object obj4 = 1 << (int)obj3;
						object obj5 = obj4 & 0xFFDA00;
						if (obj5 == null)
						{
							object obj6 = obj4 & 0x25FE;
							if (obj6 != null)
							{
								goto IL_0393;
							}
							fsResult fsResult4 = TryParseString(out *(string*)(obj + 28));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							if ((nint)0 == 0)
							{
								reference = ref *(fsData*)null;
								((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								_ = 0;
								object obj7 = default;
								reference = ref *(fsData*)obj7;
								((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
							}
							goto IL_049a;
						}
					}
					else if (c != 'I')
					{
						goto IL_0393;
					}
				}
				else if (c != 'N')
				{
					if (c != '[')
					{
						goto IL_0393;
					}
					fsResult fsResult5 = TryParseArray(out data);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					((fsResult*)(nint)fsResult3)->_success = false;
					goto IL_049a;
				}
				fsResult fsResult6 = TryParseNumber(out data);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else if (c <= 'n')
			{
				if (c != 'f')
				{
					if (c != 'n')
					{
						goto IL_0393;
					}
					fsResult fsResult7 = TryParseNull(out data);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					((fsResult*)(nint)fsResult3)->_success = false;
				}
				else
				{
					fsResult fsResult8 = TryParseFalse(out data);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					((fsResult*)(nint)fsResult3)->_success = false;
				}
			}
			else if (c != 't')
			{
				if (c != '{')
				{
					goto IL_0393;
				}
				fsResult fsResult9 = TryParseObject(out data);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else
			{
				fsResult fsResult10 = TryParseTrue(out data);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
		}
		goto IL_049a;
		IL_049a:
		return fsResult3;
		IL_0393:
		reference = ref *(fsData*)null;
		char c2 = Character();
		char c3 = (char)(obj + 14);
		string text = ((char*)(ushort)c3)->ToString();
		string message = "unable to parse; invalid token \"" + text + "\"";
		fsResult fsResult11 = MakeFailure(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		((fsResult*)(nint)fsResult3)->_success = false;
		goto IL_049a;
	}

	public unsafe static fsResult Parse(string input, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0096: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3;
		if (input != null)
		{
			obj3 = 0;
			if (input._stringLength != 0)
			{
				goto IL_00bd;
			}
		}
		obj3 = 1;
		goto IL_00bd;
		IL_00bd:
		if (obj3 != null)
		{
			ref fsData reference = ref *(fsData*)null;
			fsResult fsResult2 = fsResult.Fail("No input");
		}
		else
		{
			fsJsonParser fsJsonParser2 = default;
			fsJsonParser2._002Ector(input);
			fsResult fsResult3 = fsJsonParser2.RunParse(out data);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult4 = default;
		((fsResult*)(nint)fsResult4)->_success = false;
		return fsResult4;
	}

	public unsafe static fsData Parse(string input)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Ref, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected VT, but got Unknown
		//IL_0062: Expected Ref, but got VT
		//IL_0020: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		fsResult fsResult2 = Parse(input, out *(fsData*)(obj + 28));
		fsResult fsResult3 = (fsResult)(obj + 16);
		fsResult fsResult4 = ((fsResult*)fsResult3)->AssertSuccess();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		return (fsData)0;
	}

	private fsJsonParser(string input)
	{
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(256);
		_cachedStringBuilder = stringBuilder;
		_input = input;
		_start = 0;
	}
}
