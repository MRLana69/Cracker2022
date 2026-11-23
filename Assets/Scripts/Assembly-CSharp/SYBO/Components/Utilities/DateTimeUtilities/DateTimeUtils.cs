using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities.DateTimeUtilities;

public static class DateTimeUtils
{
	private enum Months
	{
		Jan = 1,
		Feb,
		Mar,
		Apr,
		May,
		Jun,
		Jul,
		Aug,
		Sep,
		Oct,
		Nov,
		Dec
	}

	private static readonly char[] RFC3339SplitSymbols;

	private static readonly char[] RFC822SplitSymbols;

	public const int TicksPerSecond = 10000000;

	public const int TicksPerMillisecond = 10000;

	public const int NanosecondsPerTicks = 100;

	public static readonly DateTime FallbackDateTime;

	public unsafe static bool TryParseRFC3339(string timestamp, out DateTime parsedDateTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_08ae: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_0916: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_02e1: Expected F8, but got I4
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I4
		//IL_03c4: Expected F8, but got I4
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		_ = 0;
		string text = timestamp.ToUpper();
		bool flag = text.Contains(".");
		bool flag2 = text.Contains("Z");
		object obj4 = default;
		if (!flag2)
		{
			bool flag3 = text.Contains("+");
			obj4 = -1;
			if (!flag3)
			{
				obj4 = 1;
			}
		}
		string[] array = text.Split(RFC3339SplitSymbols, StringSplitOptions.RemoveEmptyEntries);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj6 = default;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj5 = obj + 24;
									bool flag4 = (nint)obj6 == 60;
									object obj7 = 59;
									if (!flag4)
									{
										obj7 = obj6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										if (flag)
										{
											string text2 = array[6];
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												double num = Math.Pow(10.0, text2._stringLength);
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														double num2 = 10000000.0 / num;
														object obj8 = default;
														double num3 = (double)obj8 * num2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
														double value = default;
														double num4 = Math.Abs(value);
														if (!(num4 < 2147483648.0))
														{
															value = -2147483648.0;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															object obj9 = obj + 24;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FD2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																goto IL_0b00;
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
											goto IL_07ae;
										}
										goto IL_0b00;
									}
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
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_07ae;
		IL_0b00:
		if (!flag2)
		{
			object obj10 = (flag ? 1 : 0) + 6;
			object obj11 = obj10 << 2;
			object obj12 = (object)array + obj11;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj13 = obj + 24;
					object obj15 = default;
					object obj14 = obj15 * obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj16 = (flag ? 1 : 0) + 7;
						object obj17 = obj16 << 2;
						object obj18 = (object)array + obj17;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj19 = obj + 16;
							object obj21 = default;
							object obj20 = obj21 * obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_0b74;
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
			goto IL_07ae;
		}
		goto IL_0b74;
		IL_07ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj22 = default;
		object obj23 = default;
		bool flag5 = obj22 != obj23;
		bool flag6 = default;
		bool result = flag6;
		ref DateTime reference;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj25 = default;
				object obj24 = obj25;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj26 = default;
					if (obj26 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj27 = (nint)0 << 2;
						object obj28 = obj3 + obj27;
						obj28 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj29 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S1_v57+5C]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S1_v58+8]");
						reference = ref *(DateTime*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj31 = -1;
						result = false;
						goto IL_0b5f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj32 = obj25;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag7 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
					if (flag7)
					{
						goto IL_0b64;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag8 = (nint)0 != 1;
			bool flag9 = default;
			result = flag9;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = flag9;
			}
		}
		goto IL_0b64;
		IL_0b5f:
		return result;
		IL_0b64:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0b5f;
		IL_076b:
		object obj33;
		reference = ref *(DateTime*)obj33;
		result = true;
		goto IL_0b5f;
		IL_0b74:
		if ((nint)obj6 != 60)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj33 = 0;
			goto IL_076b;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			object obj34 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag10 = (nint)0 == 1;
			object obj35 = default;
			obj33 = obj35;
			if (!flag10)
			{
				goto IL_076b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_07ae;
	}

	public unsafe static string ToStringRFC3339(DateTime time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected VT, but got Unknown
		//IL_03a9: Expected Ref, but got VT
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected VT, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected VT, but got Unknown
		//IL_03d7: Expected Ref, but got VT
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected VT, but got Unknown
		//IL_002f: Expected Ref, but got VT
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected VT, but got Unknown
		//IL_004a: Expected Ref, but got VT
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		//IL_006a: Expected Ref, but got VT
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected VT, but got Unknown
		//IL_0085: Expected Ref, but got VT
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected VT, but got Unknown
		//IL_00a5: Expected Ref, but got VT
		//IL_00ca: Expected native int or pointer, but got VT
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected VT, but got Unknown
		//IL_00f5: Expected Ref, but got VT
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 40);
		DateTime dateTime2 = ((DateTime*)dateTime)->ToUniversalTime();
		DateTime dateTime3 = (DateTime)(obj + 32);
		DateTime dateTime4 = (DateTime)(obj + 40);
		int year = ((DateTime*)dateTime4)->Year;
		DateTime dateTime5 = (DateTime)(obj + 40);
		int month = ((DateTime*)dateTime5)->Month;
		DateTime dateTime6 = (DateTime)(obj + 40);
		int day = ((DateTime*)dateTime6)->Day;
		DateTime dateTime7 = (DateTime)(obj + 40);
		int hour = ((DateTime*)dateTime7)->Hour;
		DateTime dateTime8 = (DateTime)(obj + 40);
		int minute = ((DateTime*)dateTime8)->Minute;
		DateTime dateTime9 = (DateTime)(obj + 40);
		int second = ((DateTime*)dateTime9)->Second;
		*(DateTime*)(nint)dateTime3 = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		DateTime dateTime10 = (DateTime)(obj + 40);
		int year2 = ((DateTime*)dateTime10)->Year;
		object obj3 = obj + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public unsafe static bool TryParseRFC822(string timestamp, out DateTime parsedDateTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_044f: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		string[] array = timestamp.Split(RFC822SplitSymbols, StringSplitOptions.RemoveEmptyEntries);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												obj = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													ref DateTime reference = ref *(DateTime*)obj;
													result = true;
													goto IL_062a;
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
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_034f;
						}
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
		goto IL_034f;
		IL_062f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_062a;
		IL_062a:
		return result;
		IL_034f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		bool flag2 = default;
		result = flag2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj7 = default;
				object obj6 = obj7;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj8 = default;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj9 = (nint)0 << 2;
						object obj10 = obj3 + obj9;
						obj10 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S1_v50+5C]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S1_v51+8]");
						ref DateTime reference = ref *(DateTime*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = -1;
						result = false;
						goto IL_062a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj7;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
					if (flag3)
					{
						goto IL_062f;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			bool flag5 = default;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = flag5;
			}
		}
		goto IL_062f;
	}

	unsafe static DateTimeUtils()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected VT, but got Unknown
		//IL_0065: Expected native int or pointer, but got VT
		//IL_0080: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._5500CD4935AA7AD89125EB7856CA60D99B18862314BBA925F33E55A70DEF45C0));
		RFC3339SplitSymbols = (char[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E._3C1CB71FC5E236534B329DC05F9FC1C998EBB6482961A8578E2DC2634B31FD24));
		RFC822SplitSymbols = (char[])array2;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		FallbackDateTime = (DateTime)0;
	}
}
