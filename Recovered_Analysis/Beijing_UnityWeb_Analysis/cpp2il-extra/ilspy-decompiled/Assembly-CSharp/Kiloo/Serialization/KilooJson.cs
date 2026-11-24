using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Google;
using Kiloo.Integration.Google;

namespace Kiloo.Serialization;

public static class KilooJson
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

		private readonly bool ignoreCase;

		private unsafe char PeekChar
		{
			get
			{
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Expected Ref, but got Unknown
				//IL_0107: Expected Ref, but got F8
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Expected Ref, but got Unknown
				//IL_0136: Expected Obj, but got I4
				//IL_0136: Expected Obj, but got I4
				//IL_0067: Expected I, but got Obj
				//IL_007d: Expected Obj, but got I
				//IL_016d: Expected Obj, but got I4
				//IL_017e: Expected Obj, but got F8
				//IL_0034: Expected Obj, but got I4
				//IL_0045: Expected Obj, but got F8
				//IL_00a8: Expected I, but got Obj
				object obj = default;
				ref double reference = ref *(double*)(obj + 16);
				reference = ref *(double*)0.0;
				ref double reference2 = ref *(double*)(obj + 8);
				reference2 = ref *(double*)null;
				TOKEN nextToken = NextToken;
				int num = ((string)nextToken).IndexOfAny((char[])46);
				bool flag = num == -1;
				NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
				if (flag)
				{
					bool flag2 = System.Number.TryParseDouble((string)nextToken, NumberStyles.Integer, currentInfo, out reference2);
					obj = reference2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				}
				else
				{
					nint num2 = (nint)typeof(double);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<System.Double>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num3 = (nint)typeof(double);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v28 (Il2CppClass<System.Double>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag3 = double.TryParse((string)nextToken, (NumberStyles)231, currentInfo, out reference);
					obj = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				}
				char result = default;
				return result;
			}
		}

		private char NextChar
		{
			get
			{
				//IL_006a: Expected I, but got Obj
				//IL_0080: Expected Obj, but got I
				//IL_0013: Expected I, but got Obj
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5 (Il2CppClass<System.Convert>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v10 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				uint value = default;
				return Convert.ToChar(value);
			}
		}

		private string NextWord
		{
			get
			{
				//IL_006a: Expected I, but got Obj
				//IL_0080: Expected Obj, but got I
				//IL_00aa: Expected Obj, but got I4
				//IL_0013: Expected I, but got Obj
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5 (Il2CppClass<System.Convert>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v10 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				uint value = default;
				return (string)Convert.ToChar(value);
			}
		}

		private TOKEN NextToken
		{
			get
			{
				//IL_001d: Expected Obj, but got I4
				//IL_005d: Expected I4, but got Obj
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				StringBuilder stringBuilder = default;
				System.Text.StringBuilderCache.Release(stringBuilder);
				object obj = default;
				do
				{
					char nextChar = NextChar;
					int num = " \t\n\r{}[],:\"".IndexOfAny((char[])nextChar);
					if (num != -1)
					{
						break;
					}
					string nextWord = NextWord;
					StringBuilder stringBuilder2 = stringBuilder.Append((int)nextWord);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				}
				while ((nint)obj != -1);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				TOKEN result = default;
				return result;
			}
		}

		private Parser(string jsonString, bool ignoreCase)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected Obj, but got Unknown
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_0038: Expected Obj, but got I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj = jsonString & 1;
			object obj3 = default;
			object obj2 = obj3 + 12;
			obj2 = ignoreCase;
			object obj4 = this + 8;
			obj4 = obj3;
		}

		public static object Parse(string jsonString, bool ignoreCase)
		{
			//IL_0023: Expected Obj, but got I
			//IL_0031: Expected Obj, but got I4
			int stringLength = jsonString.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S2_v2 (System.Int32)+8]");
			object arg = (nint)0 + (nint)1;
			return string.Format((string)ignoreCase, null, arg);
		}

		public void Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private Dictionary<string, object> ParseObject()
		{
			//IL_0007: Expected Obj, but got I4
			return (Dictionary<string, object>)ignoreCase;
		}

		private List<object> ParseArray()
		{
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0300: Expected Obj, but got I
			//IL_0310: Expected Obj, but got I
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_0326: Expected Obj, but got Unknown
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected Obj, but got Unknown
			//IL_0054: Expected I, but got Obj
			//IL_0263: Expected Obj, but got I
			//IL_0273: Expected Obj, but got I
			//IL_0283: Expected Obj, but got I
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected Obj, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Expected Obj, but got Unknown
			List<object> result;
			if (~(ignoreCase ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v31 (Il2CppClass<System.StringComparer>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(StringComparer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v40 (Il2CppClass<System.StringComparer>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v11 (Il2CppMethodInfo)+C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S3_v12+60]");
				object obj3 = 0;
				object obj4 = obj3;
				object obj5 = obj4 & 0x1FFF;
				object obj6 = obj5 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S4_v15 (should have been resolved before IL gen)");
				List<object> list = default;
				result = list;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v6 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v7+60]");
				object obj8 = 0;
				object obj9 = obj8;
				object obj10 = obj9 & 0x1FFF;
				object obj11 = obj10 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S4_v11 (should have been resolved before IL gen)");
				List<object> list2 = default;
				result = list2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			while (true)
			{
				bool flag = ((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this).MoveNext();
				if (flag)
				{
					if (!flag)
					{
						if ((flag ? 1 : 0) == 2)
						{
							break;
						}
						if ((flag ? 1 : 0) != 3 && (flag ? 1 : 0) != 4 && (flag ? 1 : 0) != 5 && (flag ? 1 : 0) == 6)
						{
							continue;
						}
					}
					object obj12 = ParseNumber();
					if (obj12 != null)
					{
						bool flag2 = ((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this).MoveNext();
						if ((flag2 ? 1 : 0) == 5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							string text = ParseString();
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v4 (Il2CppMethodInfo)+C]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S4_v5+60]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v6+48]");
							object obj15 = 0;
							object obj16 = obj15 & 0x7FF;
							object obj17 = obj16 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S5_v6 (should have been resolved before IL gen)");
							continue;
						}
					}
				}
				result = null;
				break;
			}
			return result;
		}

		private object ParseValue()
		{
			//IL_000e: Expected Obj, but got I4
			//IL_012d: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<object> list = default;
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = 1;
			List<object> result;
			while (true)
			{
				bool flag = obj == null;
				result = list;
				if (flag)
				{
					break;
				}
				bool flag2 = ((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this).MoveNext();
				if (flag2)
				{
					switch (flag2)
					{
					default:
					{
						string item = Serializer.Serialize(this, flag2);
						list.Add(item);
						break;
					}
					case true:
						obj = 0;
						break;
					case true:
						break;
					}
					continue;
				}
				result = null;
				break;
			}
			return result;
		}

		private object ParseByToken(TOKEN token)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			//IL_00d2: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Expected Obj, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GoogleSignInPlugin.ProfileUpdatedHandler profileUpdatedHandler = default;
			profileUpdatedHandler._002Ector(this, (nint)token);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj3 = obj2 + 4;
			object obj4 = obj3 + 1;
			obj3 = obj4;
			object obj5 = obj4 << 2;
			object obj6 = obj2 + obj5;
			obj6 = 27;
			if (profileUpdatedHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj7 = (nint)0 << 2;
				object obj8 = obj2 + obj7;
				if ((nint)obj8 == 27)
				{
					object obj9 = obj2 + 4;
					if ((nint)obj9 > -1)
					{
						object obj10 = obj9 + -1;
						obj9 = obj10;
					}
					goto IL_0222;
				}
			}
			object obj11 = default;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0222;
			IL_0222:
			object result = default;
			return result;
		}

		private string ParseString()
		{
			bool indent = ((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this).MoveNext();
			return Serializer.Serialize(this, indent);
		}

		private object ParseNumber()
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_11c8: Expected I4, but got Obj
			//IL_0753: Unknown result type (might be due to invalid IL or missing references)
			//IL_0758: Expected Obj, but got Unknown
			//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8d: Expected Obj, but got Unknown
			//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb8: Expected Obj, but got Unknown
			//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07aa: Expected Obj, but got Unknown
			//IL_1001: Unknown result type (might be due to invalid IL or missing references)
			//IL_1006: Expected Obj, but got Unknown
			//IL_100f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1014: Expected Obj, but got Unknown
			//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0edf: Expected Obj, but got Unknown
			//IL_0e75: Expected I4, but got Obj
			//IL_10c6: Expected Obj, but got I4
			//IL_111e: Expected I, but got Obj
			//IL_1134: Expected Obj, but got I
			//IL_10e2: Expected I4, but got Obj
			//IL_115f: Expected I, but got Obj
			//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f9: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			System.Text.StringBuilderCache.Release(stringBuilder);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			object obj5 = default;
			StringBuilder stringBuilder6 = default;
			string value = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if ((nint)obj == -1)
				{
					break;
				}
				string nextWord = NextWord;
				object obj2 = (object)nextWord << 16;
				object obj3 = obj2 >> 16;
				object obj4 = obj3 - 34;
				if ((nint)obj3 == 34)
				{
					break;
				}
				if ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 != 3 && (nint)obj4 != 4 && (nint)obj4 != 5 && (nint)obj4 != 6 && (nint)obj4 != 7 && (nint)obj4 != 8 && (nint)obj4 != 9 && (nint)obj4 != 10 && (nint)obj4 != 11 && (nint)obj4 != 12 && (nint)obj4 != 13 && (nint)obj4 != 14 && (nint)obj4 != 15 && (nint)obj4 != 16 && (nint)obj4 != 17 && (nint)obj4 != 18 && (nint)obj4 != 19 && (nint)obj4 != 20 && (nint)obj4 != 21 && (nint)obj4 != 22 && (nint)obj4 != 23 && (nint)obj4 != 24 && (nint)obj4 != 25 && (nint)obj4 != 26 && (nint)obj4 != 27 && (nint)obj4 != 28 && (nint)obj4 != 29 && (nint)obj4 != 30 && (nint)obj4 != 31 && (nint)obj4 != 32 && (nint)obj4 != 33 && (nint)obj4 != 34 && (nint)obj4 != 35 && (nint)obj4 != 36 && (nint)obj4 != 37 && (nint)obj4 != 38 && (nint)obj4 != 39 && (nint)obj4 != 40 && (nint)obj4 != 41 && (nint)obj4 != 42 && (nint)obj4 != 43 && (nint)obj4 != 44 && (nint)obj4 != 45 && (nint)obj4 != 46 && (nint)obj4 != 47 && (nint)obj4 != 48 && (nint)obj4 != 49 && (nint)obj4 != 50 && (nint)obj4 != 51 && (nint)obj4 != 52 && (nint)obj4 != 53 && (nint)obj4 != 54 && (nint)obj4 != 55 && (nint)obj4 != 56 && (nint)obj4 != 57 && (nint)obj4 == 58)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					if ((nint)obj5 == -1)
					{
						break;
					}
					string nextWord2 = NextWord;
					object obj6 = nextWord2 & 0xFFFF;
					if ((nint)obj6 < 93)
					{
						object obj7 = (object)nextWord2 << 16;
						object obj8 = obj7 >> 16;
						object obj9 = obj8 - 34;
						if ((nint)obj8 == 34 || ((nint)obj9 != 1 && (nint)obj9 != 2 && (nint)obj9 != 3 && (nint)obj9 != 4 && (nint)obj9 != 5 && (nint)obj9 != 6 && (nint)obj9 != 7 && (nint)obj9 != 8 && (nint)obj9 != 9 && (nint)obj9 != 10 && (nint)obj9 != 11 && (nint)obj9 != 12 && ((nint)obj9 == 13 || ((nint)obj9 != 14 && (nint)obj9 != 15 && (nint)obj9 != 16 && (nint)obj9 != 17 && (nint)obj9 != 18 && (nint)obj9 != 19 && (nint)obj9 != 20 && (nint)obj9 != 21 && (nint)obj9 != 22 && (nint)obj9 != 23 && (nint)obj9 != 24 && (nint)obj9 != 25 && (nint)obj9 != 26 && (nint)obj9 != 27 && (nint)obj9 != 28 && (nint)obj9 != 29 && (nint)obj9 != 30 && (nint)obj9 != 31 && (nint)obj9 != 32 && (nint)obj9 != 33 && (nint)obj9 != 34 && (nint)obj9 != 35 && (nint)obj9 != 36 && (nint)obj9 != 37 && (nint)obj9 != 38 && (nint)obj9 != 39 && (nint)obj9 != 40 && (nint)obj9 != 41 && (nint)obj9 != 42 && (nint)obj9 != 43 && (nint)obj9 != 44 && (nint)obj9 != 45 && (nint)obj9 != 46 && (nint)obj9 != 47 && (nint)obj9 != 48 && (nint)obj9 != 49 && (nint)obj9 != 50 && (nint)obj9 != 51 && (nint)obj9 != 52 && (nint)obj9 != 53 && (nint)obj9 != 54 && (nint)obj9 != 55 && (nint)obj9 != 56 && (nint)obj9 != 57 && (nint)obj9 == 58))))
						{
							StringBuilder stringBuilder2 = stringBuilder.Append((int)nextWord2);
						}
						continue;
					}
					object obj10 = nextWord2 & 0xFFFF;
					if ((nint)obj10 < 103)
					{
						object obj11 = (object)nextWord2 << 16;
						object obj12 = obj11 >> 16;
						object obj13 = obj12 - 98;
						if ((nint)obj12 != 98)
						{
							if ((nint)obj13 != 1 && (nint)obj13 != 2 && (nint)obj13 != 3 && (nint)obj13 == 4)
							{
								StringBuilder stringBuilder3 = stringBuilder.Append(12);
							}
						}
						else
						{
							StringBuilder stringBuilder4 = stringBuilder.Append(8);
						}
						continue;
					}
					object obj14 = nextWord2 & 0xFFFF;
					if ((nint)obj14 == 110)
					{
						StringBuilder stringBuilder5 = stringBuilder.Append(10);
						continue;
					}
					object obj15 = nextWord2 & 0xFFFF;
					object obj16 = obj15 - 114;
					if ((nint)obj15 != 114)
					{
						if ((nint)obj16 == 1)
						{
							continue;
						}
						if ((nint)obj16 != 2)
						{
							if ((nint)obj16 != 3)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							System.Text.StringBuilderCache.Release(stringBuilder6);
							object obj17 = 0;
							while ((nint)obj17 <= 3)
							{
								string nextWord3 = NextWord;
								StringBuilder stringBuilder7 = stringBuilder6.Append((int)nextWord3);
								object obj18 = obj17 + 1;
								obj17 = obj18;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							nint num = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v55 (Il2CppClass<System.Convert>)+BA]");
							object obj19 = (nint)0 & (nint)0x200;
							if (obj19 != null)
							{
								nint num2 = (nint)typeof(Convert);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v61 (Il2CppClass<System.Convert>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							uint num3 = Convert.ToUInt32(value, 16);
							int value2 = (int)(num3 & 0xFFFF);
							StringBuilder stringBuilder8 = stringBuilder.Append(value2);
						}
						else
						{
							StringBuilder stringBuilder9 = stringBuilder.Append(9);
						}
					}
					else
					{
						StringBuilder stringBuilder10 = stringBuilder.Append(13);
					}
				}
				else
				{
					StringBuilder stringBuilder11 = stringBuilder.Append((int)nextWord);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object result = default;
			return result;
		}

		private void EatWhitespace()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected Obj, but got Unknown
			//IL_001f: Expected Obj, but got I4
			((TextReader.NullTextReader)(object)json)._002Ector();
			object obj = this + 8;
			obj = 0;
		}
	}

	private sealed class Serializer
	{
		private readonly StringBuilder builder;

		private readonly bool indent;

		private int currentIndentation;

		private const char INDENT_CHAR = ' ';

		private const string NEWLINE = "\n";

		private const int INDENT_STEP = 2;

		private Serializer(bool indent)
		{
			//IL_000a: Expected Obj, but got I4
			builder = (StringBuilder)indent;
		}

		public static string Serialize(object obj, bool indent)
		{
			//IL_01bf: Expected Obj, but got I4
			//IL_0188: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got I4
			object obj2 = (indent ? 1 : 0) - 1;
			if (!indent)
			{
				if ((nint)obj2 != 1)
				{
					if ((nint)obj2 == 2)
					{
						return (string)((Parser)obj).ParseValue();
					}
					if ((nint)obj2 != 3 && (nint)obj2 != 4 && (nint)obj2 != 5)
					{
						if ((nint)obj2 != 6)
						{
							if ((nint)obj2 != 7)
							{
								if ((nint)obj2 != 8)
								{
									if ((nint)obj2 != 9)
									{
										goto IL_01a7;
									}
									object obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								}
								else
								{
									object obj3 = 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								}
								string result = default;
								return result;
							}
							char peekChar = ((Parser)obj).PeekChar;
							return (string)peekChar;
						}
						return (string)((Parser)obj).ParseNumber();
					}
				}
				goto IL_01a7;
			}
			return (string)(object)((Parser)obj).ParseArray();
			IL_01a7:
			return null;
		}

		private void SerializeValue(object value)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			System.Text.StringBuilderCache.Release(stringBuilder);
			object obj = this + 8;
			obj = stringBuilder;
			bool flag = (byte)(value & 1) != 0;
			indent = flag;
		}

		private void SerializeObject(IDictionary obj)
		{
			//IL_08fb: Expected Obj, but got I4
			//IL_003a: Expected I, but got Obj
			//IL_0050: Expected Obj, but got I
			//IL_092e: Expected I4, but got Obj
			//IL_093c: Expected I4, but got Obj
			//IL_007b: Expected I, but got Obj
			//IL_01f3: Expected I4, but got Obj
			//IL_097c: Expected I, but got Obj
			//IL_0992: Expected Obj, but got I
			//IL_0882: Expected I, but got Obj
			//IL_0772: Expected I, but got Obj
			//IL_0788: Expected Obj, but got I
			//IL_09f7: Expected I4, but got Obj
			//IL_07b3: Expected I, but got Obj
			//IL_07e2: Expected I4, but got Obj
			object obj2 = 0;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj3 = default;
				if (obj3 != null)
				{
					nint num = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v225 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num2 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v230 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					object obj5 = Deserialize((string)(object)obj, (byte)(int)currentCulture != 0);
					((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this)._002Ector((int)obj5);
					return;
				}
				IDictionary dictionary;
				if (obj == null)
				{
					dictionary = null;
				}
				else
				{
					dictionary = (((object)obj.GetType() != typeof(bool)) ? null : obj);
				}
				if (dictionary != null)
				{
					throw new NullReferenceException();
				}
				IDictionary dictionary2;
				if (obj == null)
				{
					dictionary2 = null;
				}
				else
				{
					dictionary2 = (((object)obj.GetType() != typeof(string)) ? null : obj);
				}
				if (dictionary2 != null)
				{
					((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this)._002Ector((int)dictionary2);
					return;
				}
				IDictionary dictionary3;
				if (obj == null)
				{
					dictionary3 = null;
				}
				else
				{
					dictionary3 = (((object)obj.GetType() != typeof(char)) ? null : obj);
				}
				if (dictionary3 != null)
				{
					throw new NullReferenceException();
				}
				IDictionary dictionary4;
				if (obj == null)
				{
					dictionary4 = null;
				}
				else
				{
					dictionary4 = (((object)obj.GetType() != typeof(float)) ? null : obj);
				}
				if (dictionary4 == null)
				{
					IDictionary dictionary5;
					if (obj == null)
					{
						dictionary5 = null;
					}
					else
					{
						dictionary5 = (((object)obj.GetType() != typeof(int)) ? null : obj);
					}
					if (dictionary5 == null)
					{
						IDictionary dictionary6;
						if (obj == null)
						{
							dictionary6 = null;
						}
						else
						{
							dictionary6 = (((object)obj.GetType() != typeof(uint)) ? null : obj);
						}
						if (dictionary6 == null)
						{
							IDictionary dictionary7;
							if (obj == null)
							{
								dictionary7 = null;
							}
							else
							{
								dictionary7 = (((object)obj.GetType() != typeof(long)) ? null : obj);
							}
							if (dictionary7 == null)
							{
								IDictionary dictionary8;
								if (obj == null)
								{
									dictionary8 = null;
								}
								else
								{
									dictionary8 = (((object)obj.GetType() != typeof(double)) ? null : obj);
								}
								if (dictionary8 == null)
								{
									IDictionary dictionary9;
									if (obj == null)
									{
										dictionary9 = null;
									}
									else
									{
										dictionary9 = (((object)obj.GetType() != typeof(sbyte)) ? null : obj);
									}
									if (dictionary9 == null)
									{
										IDictionary dictionary10;
										if (obj == null)
										{
											dictionary10 = null;
										}
										else
										{
											dictionary10 = (((object)obj.GetType() != typeof(byte)) ? null : obj);
										}
										if (dictionary10 == null)
										{
											IDictionary dictionary11;
											if (obj == null)
											{
												dictionary11 = null;
											}
											else
											{
												dictionary11 = (((object)obj.GetType() != typeof(short)) ? null : obj);
											}
											if (dictionary11 == null)
											{
												IDictionary dictionary12;
												if (obj == null)
												{
													dictionary12 = null;
												}
												else
												{
													dictionary12 = (((object)obj.GetType() != typeof(ushort)) ? null : obj);
												}
												if (dictionary12 == null)
												{
													IDictionary dictionary13;
													if (obj == null)
													{
														dictionary13 = null;
													}
													else
													{
														dictionary13 = (((object)obj.GetType() != typeof(ulong)) ? null : obj);
													}
													if (dictionary13 == null)
													{
														IDictionary dictionary14;
														if (obj == null)
														{
															dictionary14 = null;
														}
														else
														{
															dictionary14 = (((object)obj.GetType() != typeof(decimal)) ? null : obj);
														}
														if (dictionary14 == null)
														{
															nint num3 = (nint)typeof(CultureInfo);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v102 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
															object obj6 = (nint)0 & (nint)0x200;
															if (obj6 != null)
															{
																nint num4 = (nint)typeof(CultureInfo);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v117 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
																if ((nint)0 == 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																}
															}
															CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
															object obj7 = Deserialize((string)(object)obj, (byte)(int)currentCulture2 != 0);
															if (obj7 != null)
															{
																((GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9)this)._002Ector((int)obj7);
																return;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
															IEnumerable enumerable = default;
															if (enumerable != null)
															{
																SerializeArray(enumerable);
																return;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
															string text = default;
															if (text != null)
															{
																SerializeString(text);
																return;
															}
															object anArray = ConversionHelper.GetDefault((Type)obj);
															SerializeArray((IEnumerable)anArray);
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
				nint num5 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v36 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v47 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CultureInfo currentCulture3 = CultureInfo.CurrentCulture;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				string value = default;
				StringBuilder stringBuilder = builder.AppendLine(value);
			}
			else
			{
				StringBuilder stringBuilder2 = builder.AppendLine("null");
			}
		}

		private void SerializeArray(IEnumerable anArray)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_004f: Expected Obj, but got I4
			//IL_0947: Expected Obj, but got I4
			//IL_006c: Expected Obj, but got I4
			//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ff: Expected Obj, but got Unknown
			//IL_008d: Expected Obj, but got I4
			//IL_0129: Expected I, but got Obj
			//IL_013f: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I4
			//IL_092f: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got I4
			//IL_01c5: Expected Obj, but got I4
			//IL_016a: Expected I, but got Obj
			//IL_0116: Expected Obj, but got I4
			//IL_07a8: Expected Obj, but got I
			//IL_022d: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I4
			//IL_07de: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e3: Expected Obj, but got Unknown
			//IL_0245: Expected Obj, but got I4
			//IL_0215: Expected Obj, but got I4
			//IL_0814: Unknown result type (might be due to invalid IL or missing references)
			//IL_0819: Expected Obj, but got Unknown
			//IL_028e: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b2: Expected Obj, but got Unknown
			//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c0: Expected Obj, but got Unknown
			//IL_06ec: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			StringBuilder stringBuilder = builder.Append(123);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if ((nint)obj3 < 1)
			{
				goto IL_08dc;
			}
			int num = currentIndentation + 2;
			currentIndentation = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj4 = 1;
			object obj6 = default;
			object obj8 = default;
			object obj10 = default;
			object obj5;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj5 = 38;
				bool flag = obj6 == null;
				obj5 = 39;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj5 = 7;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj5 = 10;
				}
				if (~(indent ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj5 = 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					obj5 = 17;
				}
				nint num2 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v106 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num3 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v169 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj5 = 18;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj5 = 22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj5 = 23;
				bool flag2 = obj8 == null;
				bool flag3 = !flag2;
				object obj9 = obj8;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj9 = obj10;
					obj5 = 28;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = 29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj5 = 30;
				if (~(indent ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj5 = 36;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				obj5 = 37;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = 0;
			}
			object obj11 = obj5 - 7;
			if ((nint)obj5 != 7)
			{
				if ((nint)obj11 != 1 && (nint)obj11 != 2)
				{
					if ((nint)obj11 == 3)
					{
						goto IL_06f1;
					}
					if ((nint)obj11 != 4 && (nint)obj11 != 5 && (nint)obj11 != 6 && (nint)obj11 != 7 && (nint)obj11 != 8)
					{
						if ((nint)obj11 == 9 || (nint)obj11 == 10 || (nint)obj11 == 11)
						{
							goto IL_06f1;
						}
						if ((nint)obj11 != 12 && (nint)obj11 != 13 && (nint)obj11 != 14)
						{
							if ((nint)obj11 == 15 || (nint)obj11 == 16)
							{
								goto IL_06f1;
							}
							if ((nint)obj11 != 17 && (nint)obj11 != 18 && (nint)obj11 != 19 && (nint)obj11 != 20)
							{
								if ((nint)obj11 == 21 || (nint)obj11 == 22 || (nint)obj11 == 23)
								{
									goto IL_06f1;
								}
								if ((nint)obj11 != 24 && (nint)obj11 != 25 && (nint)obj11 != 26 && (nint)obj11 != 27 && (nint)obj11 != 28)
								{
									if ((nint)obj11 == 29 || (nint)obj11 == 30 || (nint)obj11 == 31)
									{
										goto IL_06f1;
									}
									if ((nint)obj11 == 32)
									{
										object obj12 = obj2 + 4;
										object obj13 = obj12 + 1;
										obj12 = obj13;
										object obj14 = obj13 << 2;
										object obj15 = obj2 + obj14;
										obj15 = 241;
									}
								}
							}
						}
					}
				}
				goto IL_0956;
			}
			goto IL_06f1;
			IL_08dc:
			StringBuilder stringBuilder2 = builder.Append(125);
			return;
			IL_0956:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj16 = default;
			if (obj16 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj17 = (nint)0 << 2;
				object obj18 = obj2 + obj17;
				if ((nint)obj18 == 241)
				{
					object obj19 = obj2 + 4;
					if ((nint)obj19 > -1)
					{
						object obj20 = obj19 + -1;
						obj19 = obj20;
					}
					goto IL_097d;
				}
			}
			object obj21 = default;
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_097d;
			IL_06f1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj22 = default;
			object obj23 = default;
			if (obj22 == obj23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_0956;
			IL_097d:
			int num4 = currentIndentation - 2;
			currentIndentation = num4;
			if (~(indent ? 1u : 0u) == 0)
			{
				StringBuilder stringBuilder3 = builder.AppendLine("\n");
				StringBuilder stringBuilder4 = builder.Remove(32, currentIndentation);
			}
			goto IL_08dc;
		}

		private void SerializeString(string str)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0320: Expected Obj, but got I4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected Obj, but got Unknown
			//IL_0113: Expected Obj, but got I4
			//IL_03aa: Expected Obj, but got I4
			//IL_01df: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I4
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected Obj, but got Unknown
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			StringBuilder stringBuilder = builder.Append(91);
			int num = currentIndentation + 2;
			currentIndentation = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = 1;
			object obj4 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj4 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				}
				if (~(indent ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj3 = 0;
			}
			object obj5 = obj2 + 4;
			object obj6 = obj5 + 1;
			obj5 = obj6;
			object obj7 = obj6 << 2;
			object obj8 = obj2 + obj7;
			obj8 = 144;
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj10 = default;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj2 + obj11;
				if ((nint)obj12 == 144)
				{
					object obj13 = obj2 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_036e;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_036e;
			IL_036e:
			int num2 = currentIndentation - 2;
			currentIndentation = num2;
			bool flag = indent;
			object obj16 = (flag ? 1 : 0) ^ 1;
			object obj17 = obj9 | obj16;
			if (obj17 == null)
			{
				StringBuilder stringBuilder2 = builder.AppendLine("\n");
				StringBuilder stringBuilder3 = builder.Remove(32, currentIndentation);
			}
			StringBuilder stringBuilder4 = builder.Append(93);
		}
	}

	public static object Deserialize(string json, bool ignoreCase = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got Unknown
		//IL_06af: Expected Obj, but got I4
		//IL_06be: Expected Obj, but got I4
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_014d: Expected I, but got Obj
		//IL_02e4: Expected I, but got Obj
		//IL_02fa: Expected Obj, but got I
		//IL_0399: Expected I, but got Obj
		//IL_03af: Expected Obj, but got I
		//IL_0325: Expected I, but got Obj
		//IL_0470: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I
		//IL_03da: Expected I, but got Obj
		//IL_07f0: Expected Obj, but got I4
		//IL_04b1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 8;
		obj5 = 0;
		_ = 0;
		obj2 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		string text;
		if (json == null)
		{
			text = null;
		}
		else
		{
			text = (((object)json.GetType() != typeof(string)) ? null : json);
		}
		if (text != null)
		{
			return text;
		}
		string text2;
		if (json == null)
		{
			text2 = null;
		}
		else
		{
			text2 = (((object)json.GetType() != typeof(DateTimeOffset)) ? null : json);
		}
		if (text2 != null)
		{
			NullReferenceException ex = new NullReferenceException();
			obj5 = ex;
			_ = ((Exception)ex)._className;
			nint num = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v183 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(DateTimeFormatInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v191 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F785");
		}
		else
		{
			string text3;
			if (json == null)
			{
				text3 = null;
			}
			else
			{
				text3 = (((object)json.GetType() != typeof(DateTime)) ? null : json);
			}
			if (text3 != null)
			{
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			string text4 = default;
			if (text4 != null)
			{
				nint num3 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v148 (Il2CppClass<System.Convert>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v154 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return Convert.FromBase64String(text4);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj9 = default;
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v58 (Il2CppClass<System.Type>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v137 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj4 = typeof(string);
				obj3 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num7 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v105 (Il2CppClass<System.Convert>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v124 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj13 = default;
				object obj12 = obj13;
				object obj15 = default;
				object obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj16 = default;
				if (obj14 == obj16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj18 = default;
					object obj17 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj20 = default;
					object obj19 = obj20;
				}
				else
				{
					object obj19 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj21 = default;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				IEnumerable<char> enumerable = default;
				if (enumerable != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					char[] array = default;
					bool flag = array == null;
					bool flag2 = !flag;
					char[] obj22 = array;
					if (!flag2)
					{
						char[] array2 = Enumerable.ToArray(enumerable);
						obj22 = array2;
					}
					int hashCode = ((StringComparer)null).GetHashCode((object)obj22);
					return hashCode;
				}
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		}
		object result = default;
		return result;
	}

	public static string Serialize(object obj, bool indent = false)
	{
		return (string)((Parser)obj)?.ParseByToken(indent ? Parser.TOKEN.CURLY_OPEN : Parser.TOKEN.NONE);
	}
}
