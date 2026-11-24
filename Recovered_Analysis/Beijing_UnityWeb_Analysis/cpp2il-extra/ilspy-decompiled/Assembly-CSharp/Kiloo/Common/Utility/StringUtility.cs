using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class StringUtility
{
	public enum MatchType
	{
		Is,
		EndsWith,
		BeginsWith,
		Contains
	}

	public static bool Match(string str, string pattern, MatchType matchType, bool ignoreCase)
	{
		//IL_05bb: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_050f: Expected I4, but got Obj
		//IL_0555: Expected I4, but got Obj
		//IL_0161: Expected Obj, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I4
		if (str == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("path");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		object value = default;
		if (pattern != null)
		{
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
		else
		{
			value = null;
		}
		bool flag = matchType != MatchType.Is;
		bool fixTimestamps = flag & ignoreCase;
		int mostRecentSlot = FileUtil.GetMostRecentSlot(str, fixTimestamps);
		object obj = mostRecentSlot + 12;
		object obj2 = 0;
		object obj3 = default;
		IBsonSerializer serializer = default;
		object obj7 = default;
		byte[] array2 = default;
		IBsonSerializer serializer2 = default;
		FileLoadException ex2 = default;
		MemoryStream memoryStream = default;
		FileNotFoundException ex4 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj4 = mostRecentSlot + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				byte[] array = BsonConverterExtensions.ToBson(serializer, value);
				if (array == null)
				{
					obj3 = obj7 + 1;
					obj2 = 1;
					continue;
				}
				array2 = array;
				break;
			}
			byte[] array3;
			if (matchType != MatchType.Is)
			{
				int mostRecentSlot2 = FileUtil.GetMostRecentSlot((string)matchType, fixTimestamps);
				object obj8 = mostRecentSlot2 + 12;
				object obj9 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
				{
					object obj10 = mostRecentSlot2 + 16;
					object obj11 = obj9 << 2;
					object obj12 = obj10 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					array3 = BsonConverterExtensions.ToBson(serializer2, value);
					if (array3 != null)
					{
						goto IL_01b9;
					}
					object obj13 = obj9 + 1;
					obj9 = obj13;
					obj2 = 1;
				}
			}
			object obj14 = flag & ignoreCase;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ex2._002Ector(str);
				throw new ArrayTypeMismatchException();
			}
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				memoryStream._002Ector((int)"File is corrupt along with all redundant files");
				FileNotFoundException ex3 = (FileNotFoundException)(object)memoryStream;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ex4.SetMessageField();
				FileNotFoundException ex3 = ex4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			break;
			IL_01b9:
			array2 = array3;
			break;
		}
		return (byte)(int)array2 != 0;
	}

	public static string ArrayToString<MyType>(MyType[] array, string seperator = ", ")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		string result = default;
		return result;
	}

	public static void ValidateEnumValueString(Type enumType, string enumValueString, bool mayBeNullOrEmpty, string varName)
	{
		//IL_005d: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		object obj = 0;
		bool flag = default;
		object obj2 = default;
		bool flag2 = default;
		while (true)
		{
			if ((flag ? 1 : 0) >= (true ? 1 : 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				if (obj2 == null)
				{
					break;
				}
				object obj3 = obj2 + obj;
				flag = (byte)(flag2 - obj2) != 0;
				obj = obj3;
				continue;
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FileInfo fileInfo = default;
		fileInfo.Delete();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public unsafe static int NonEscapedIndexOf(string text, int startIndex, char ch)
	{
		//IL_00b7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text2 = PathHandling.RelativeToAbsolutePath(text, (string)startIndex);
		uint value;
		int result;
		if (text2 != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uint num3 = BitConverter.ToUInt32((byte[])(object)text2, 0);
			value = num3;
			result = 1;
		}
		else
		{
			value = 0u;
			result = 0;
		}
		((char*)(int)ch)->m_value = (char)value;
		return result;
	}

	public unsafe static int GetNextKeyValuePair(string text, int startIndex, out string key, out string value)
	{
		//IL_017f: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_01cc: Expected I4, but got Obj
		//IL_0157: Expected Obj, but got I4
		string text3 = default;
		int num = default;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref key) != null)
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref key) != (void*)1)
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref key) != (void*)2)
				{
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref key) == (void*)3)
					{
						string text2 = default;
						string value2 = default;
						if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref value) != null)
						{
							text2 = text3.ToLowerInvariant();
							value2 = ((string)num).ToLowerInvariant();
						}
						return text2.EndsWith(value2) ? 1 : 0;
					}
					return 0;
				}
				int trimType = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref value) == null) ? 4 : 5);
				string text4 = text3.TrimHelper((char[])num, trimType);
				return (int)text4;
			}
			int startIndex2 = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref value) == null) ? 4 : 5);
			return text3.IndexOf((char)num, startIndex2);
		}
		StringComparison comparisonType = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref value) == null) ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
		return string.Equals(text3, (string)num, comparisonType) ? 1 : 0;
	}

	public static Dictionary<string, string> ParseProperties(string text)
	{
		//IL_0016: Expected I4, but got Obj
		string persistentDataPath = Application.persistentDataPath;
		return (Dictionary<string, string>)(object)ToHexString((byte[])(object)text, (byte)(int)persistentDataPath != 0);
	}

	public unsafe static string FormatProperties(Dictionary<string, string> props)
	{
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		bool flag = default;
		MatchType matchType = (MatchType)((flag ? 1 : 0) + 4);
		((MatchType*)(int)matchType)->value__ = 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S4_v4 (should have been resolved before IL gen)");
		string pattern = null;
		bool flag2;
		do
		{
			Transform transform = TransformUtility.FindChild((Transform)(object)props, pattern, matchType, flag);
			if ((nint)transform < 0)
			{
				break;
			}
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v9 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v10+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v11+48]");
			object obj8 = 0;
			object obj9 = obj8 & 0x7FF;
			object obj10 = obj9 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S5_v8 (should have been resolved before IL gen)");
			flag2 = (object)transform != props.buckets;
			pattern = (string)(object)transform;
		}
		while (flag2);
		string result = default;
		return result;
	}

	public static string[][] ParseSets(string setsString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0a6c: Expected Obj, but got I4
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected Obj, but got Unknown
		//IL_0a8f: Expected Obj, but got I4
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_09ab: Expected Obj, but got I
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected Obj, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected Obj, but got Unknown
		//IL_0944: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder sb = default;
		System.Text.StringBuilderCache.Release(sb);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = 91;
		object obj8 = obj7 + 18;
		obj8 = 93;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			bool flag;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v134+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			bool flag2;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v145+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if ((nint)obj12 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			}
		}
		object obj13 = 43;
		object obj14 = obj13 - 7;
		object obj21;
		object obj22 = default;
		if ((nint)obj13 != 7 && (nint)obj14 != 1)
		{
			if ((nint)obj14 == 2 || (nint)obj14 == 3 || (nint)obj14 == 4)
			{
				goto IL_0b73;
			}
			if ((nint)obj14 != 5)
			{
				if ((nint)obj14 == 6 || (nint)obj14 == 7 || (nint)obj14 == 8)
				{
					goto IL_0b73;
				}
				if ((nint)obj14 != 9)
				{
					if ((nint)obj14 != 10)
					{
						if ((nint)obj14 == 11 || (nint)obj14 == 12 || (nint)obj14 == 13 || (nint)obj14 == 14 || (nint)obj14 == 15 || (nint)obj14 == 16 || (nint)obj14 == 17 || (nint)obj14 == 18 || (nint)obj14 == 19 || (nint)obj14 == 20 || (nint)obj14 == 21 || (nint)obj14 == 22 || (nint)obj14 == 23)
						{
							goto IL_0b73;
						}
						if ((nint)obj14 != 24)
						{
							if ((nint)obj14 != 25)
							{
								if ((nint)obj14 != 26)
								{
									if ((nint)obj14 != 27)
									{
										if ((nint)obj14 != 28)
										{
											if ((nint)obj14 != 29)
											{
												if ((nint)obj14 != 30)
												{
													if ((nint)obj14 != 31)
													{
														if ((nint)obj14 != 32)
														{
															if ((nint)obj14 != 33)
															{
																if ((nint)obj14 != 34 && (nint)obj14 != 35 && (nint)obj14 == 36)
																{
																	object obj15 = obj5 + 4;
																	object obj16 = obj15 + 1;
																	obj15 = obj16;
																	object obj17 = obj16 << 2;
																	object obj18 = obj5 + obj17;
																	obj18 = 175;
																}
																goto IL_0b73;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj20 = default;
															object obj19 = obj20;
															obj21 = obj22;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj23 = default;
															object obj19 = obj23;
															obj21 = obj22;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj24 = default;
														object obj19 = obj24;
														obj21 = obj22;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj25 = default;
													object obj19 = obj25;
													obj21 = obj22;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj26 = default;
												object obj19 = obj26;
												obj21 = obj22;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj27 = default;
											object obj19 = obj27;
											obj21 = obj22;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj28 = default;
										object obj19 = obj28;
										obj21 = obj22;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj29 = default;
									object obj19 = obj29;
									obj21 = obj22;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj30 = default;
								object obj19 = obj30;
								obj21 = obj22;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj31 = default;
							object obj19 = obj31;
							obj21 = obj22;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj32 = default;
						object obj19 = obj32;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj33 = default;
					object obj19 = obj33;
					obj21 = obj22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj34 = default;
				object obj19 = obj34;
				obj21 = obj22;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj35 = default;
			object obj19 = obj35;
			obj21 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj36 = default;
		if (obj21 == obj36)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0b73;
		IL_0b73:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj37 = (nint)0 << 2;
			object obj38 = obj5 + obj37;
			if ((nint)obj38 == 175)
			{
				object obj39 = obj5 + 4;
				if ((nint)obj39 > -1)
				{
					object obj40 = obj39 + -1;
					obj39 = obj40;
				}
				goto IL_0b98;
			}
		}
		object obj41 = default;
		if (obj41 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b98;
		IL_0b98:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string[][] result = default;
		return result;
	}

	public static string ToHexString(byte[] bytes, bool lowerCase = false)
	{
		//IL_039b: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00dd: Expected I, but got Obj
		//IL_00cf: Expected I4, but got Obj
		//IL_00cf: Expected I4, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I4
		//IL_00e7: Expected I, but got Obj
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_01e2: Expected I, but got Obj
		//IL_0366: Expected I4, but got Obj
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_02e2: Expected I, but got Obj
		//IL_0519: Expected Obj, but got I4
		//IL_02fe: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_0354: Expected I, but got Obj
		object obj = 0;
		string text = PathHandling.RelativeToAbsolutePath((string)(object)bytes);
		string text2 = PathHandling.RelativeToAbsolutePath((string)lowerCase);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v21 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v107 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = default;
		object obj3 = num3 + 16;
		obj3 = Path.DirectorySeparatorChar;
		string text3 = text.Substring(num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num4 = default;
		object obj4 = num4 + 16;
		obj4 = Path.DirectorySeparatorChar;
		string text4 = text2.Substring(num4);
		string text6;
		if (text.EndsWith(text2))
		{
			string text5 = text.Remove((int)text2, (int)"");
			text6 = text5;
		}
		else
		{
			nint num5 = unchecked((nint)null);
			while (true)
			{
				int num6 = Enumerable.Count((IEnumerable<string>)(object)text3);
				if (num5 >= num6)
				{
					num5 = unchecked((nint)null);
					break;
				}
				object obj5 = text3 + 16;
				object obj6 = num5 << 2;
				object obj7 = obj5 + obj6;
				object obj8 = text4 + 16;
				object obj9 = num5 << 2;
				object value = obj8 + obj9;
				if (((string)obj7).EndsWith((string)value, StringComparison.Ordinal))
				{
					break;
				}
				nint num7 = num5 + 1;
				num5 = num7;
			}
			int num8 = Enumerable.Count((IEnumerable<string>)(object)text4);
			object obj10 = num8 - num5;
			string text7 = string.Empty;
			object obj11 = 0;
			IFormatProvider provider = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				nint num9 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v79 (Il2CppClass<System.IO.Path>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num10 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v90 (Il2CppClass<System.IO.Path>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = Path.DirectorySeparatorChar;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
				object obj13 = ((IConvertible)text7).ToType((Type)(object)"..", provider);
				object obj14 = obj11 + 1;
				text7 = (string)obj13;
				obj11 = obj14;
			}
			text6 = text7;
			nint num11 = num5;
			IFormatProvider provider2 = default;
			while (true)
			{
				int num12 = Enumerable.Count((IEnumerable<string>)(object)text3);
				if (num11 >= num12)
				{
					break;
				}
				int num13 = Enumerable.Count((IEnumerable<string>)(object)text3);
				object obj15 = num13 - 1;
				bool flag = num11 < (nint)obj15;
				object obj16 = text3 + 16;
				object obj17 = num11 << 2;
				object obj18 = obj16 + obj17;
				string text8;
				if (flag)
				{
					nint num14 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v65 (Il2CppClass<System.IO.Path>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					bool flag2 = obj19 == null;
					num5 = (nint)typeof(Path);
					if (!flag2)
					{
						nint num15 = (nint)typeof(Path);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v72 (Il2CppClass<System.IO.Path>)+74]");
						bool flag3 = (nint)0 == 0;
						bool flag4 = !flag3;
						num5 = (nint)typeof(Path);
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num5 = (nint)typeof(Path);
						}
					}
					obj = Path.DirectorySeparatorChar;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
					object obj20 = ((IConvertible)text6).ToType((Type)obj18, provider2);
					text8 = (string)obj20;
				}
				else
				{
					text8 = string.ConcatArray((string[])(object)text6, (int)obj18);
				}
				nint num16 = num11 + 1;
				text6 = text8;
				num11 = num16;
			}
		}
		return text6;
	}

	private static int ParseHexDigit(char c)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static byte[] FromHexString(string hex)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got I4
		object obj = hex + -48;
		object obj2 = obj << 16;
		object obj3 = obj2 >> 16;
		object obj4 = obj3 & 0xFFFF;
		object obj5 = default;
		if ((nint)obj4 < 10)
		{
			obj5 = 48;
		}
		else
		{
			object obj6 = hex + -65;
			object obj7 = obj6 << 16;
			object obj8 = obj7 >> 16;
			object obj9 = obj8 & 0xFFFF;
			if ((nint)obj9 < 6)
			{
				obj5 = 65;
			}
			else
			{
				object obj10 = hex + -97;
				object obj11 = obj10 << 16;
				object obj12 = obj11 >> 16;
				object obj13 = obj12 & 0xFFFF;
				if ((nint)obj13 < 6)
				{
					obj5 = 97;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ArgumentNullException ex = default;
					ex._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
		}
		object obj14 = hex & 0xFFFF;
		return (byte[])(obj14 - obj5);
	}
}
