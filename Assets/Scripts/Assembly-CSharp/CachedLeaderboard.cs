using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public static class CachedLeaderboard
{
	private const string FILENAME = "leaderboard";

	private const string PLAYERPREFS_KEY = "HasCachedLeaderboard";

	private static TimeSpan expirationDate;

	public static Friend[] Load()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0c0c: Expected Obj, but got I4
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Expected Obj, but got Unknown
		//IL_0a39: Expected Obj, but got I
		//IL_0a64: Expected Obj, but got I
		//IL_0a89: Expected Obj, but got I
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_0aeb: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected Obj, but got Unknown
		//IL_0819: Expected Obj, but got I4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_0481: Expected Obj, but got I
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I4
		//IL_080b: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I4
		//IL_06db: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj + 40;
		_ = 0;
		Friend[] result = default;
		Friend[] result2;
		object obj6;
		object obj13;
		Friend[] array2 = default;
		Friend[] array3;
		if (IsAvailable())
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v162+10]");
											nint num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v162+18]");
											object obj5 = num - 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
												result = null;
												Friend[] array = default;
												result2 = array;
												object obj7 = default;
												obj6 = obj7;
												goto IL_0c53;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj8 = obj + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
													_ = 0;
													object obj9 = obj - -64;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
													obj9 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
													_ = 0;
													object obj10 = obj + 56;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
													_ = 0;
													object obj12 = default;
													object obj21 = default;
													object obj22 = default;
													Friend[] array4 = default;
													Friend[] array5 = default;
													object obj23 = default;
													while (true)
													{
														_ = 0;
														object obj11 = obj + 56;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														object obj15;
														if ((nint)0 == 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															if (obj12 == null)
															{
																obj13 = 5;
																goto IL_0861;
															}
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
																_ = 0;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
																object obj14 = 0;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
																	if ((nint)0 != 0)
																	{
																		obj15 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S0_v290+8]");
																		if ((nint)0 != 0)
																		{
																			goto IL_0c7c;
																		}
																	}
																	obj15 = 1;
																	goto IL_0c7c;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														goto IL_076b;
														IL_0c7c:
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														object obj17;
														if ((nint)0 != 1)
														{
															if (obj15 != null)
															{
																continue;
															}
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
															object obj16 = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
																if ((nint)0 != 0)
																{
																	obj17 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S0_v313+8]");
																	if ((nint)0 != 0)
																	{
																		goto IL_0cfb;
																	}
																}
																obj17 = 1;
																goto IL_0cfb;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_076b;
														IL_0cfb:
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															if (obj17 != null)
															{
																continue;
															}
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
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
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				object obj18 = 0 << 2;
																				object obj19 = (object)array2 + obj18;
																				continue;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		goto IL_076b;
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
														goto IL_076b;
														IL_0861:
														_ = 0;
														object obj20 = obj + 16;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															goto IL_08b8;
														}
														goto IL_0943;
														IL_076b:
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
														bool flag = obj21 != obj22;
														array3 = array4;
														obj6 = obj21;
														if (flag)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															obj13 = 0;
															goto IL_0861;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														array3 = array5;
														obj6 = obj23;
														break;
													}
													_ = 0;
													object obj24 = obj + 16;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_0bb9;
													}
													result = array2;
													result2 = array3;
													goto IL_0c53;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												result = array2;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												result = null;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										goto IL_095a;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_095a;
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
			goto IL_095a;
		}
		goto IL_0c4e;
		IL_0d85:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result2;
		IL_0bb9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_0be1;
		IL_0be1:
		result2 = array3;
		goto IL_0d85;
		IL_0c53:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj25 = default;
		if (obj25 == obj6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj27 = default;
				object obj26 = obj27;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Friend[] array6 = default;
					if (array6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj28 = (nint)0 << 2;
						object obj29 = obj4 + obj28;
						obj29 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj30 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj31 = (nint)0 << 2;
						object obj32 = obj31 + obj4;
						object obj33 = obj32 - 4;
						object obj34 = obj33;
						object obj35 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v419 @ S1_v49+D4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "Error loading leaderboard: " + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj36 = -1;
						goto IL_0c4e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj37 = obj27;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					array3 = array6;
					if (flag2)
					{
						goto IL_0be1;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			Friend[] array7 = default;
			array3 = array7;
			result2 = array7;
			if (!flag3)
			{
				goto IL_0bb9;
			}
		}
		goto IL_0d85;
		IL_0943:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		result = array2;
		goto IL_095a;
		IL_095a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Friend[] array8 = default;
		result2 = array8;
		object obj38 = default;
		obj6 = obj38;
		goto IL_0c53;
		IL_0c4e:
		return result;
		IL_08b8:
		bool flag4 = (nint)obj13 != 5;
		if (obj13 == null)
		{
			flag4 = false;
		}
		result = array2;
		if (!flag4)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 != 1;
			result = array2;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				result = array2;
				goto IL_095a;
			}
		}
		goto IL_0c4e;
	}

	public unsafe static void Save(Friend[] friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected VT, but got Unknown
		//IL_007c: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		if (friends != null && friends.Length != 0)
		{
			SaveLeaderboardToFile(friends);
			DateTime now = CDateTime.Now;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			DateTime dateTime = (DateTime)(obj + 8);
			string value = ((DateTime*)dateTime)->ToString(invariantCulture);
			PlayerPrefs.SetString("HasCachedLeaderboard", value);
		}
	}

	private static void SaveLeaderboardToFile(Friend[] friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Expected Obj, but got Unknown
		//IL_0b1c: Expected Obj, but got I
		//IL_0b47: Expected Obj, but got I
		//IL_0b6c: Expected Obj, but got I
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Expected Obj, but got Unknown
		//IL_0bce: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_07af: Expected Obj, but got I
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								object obj4 = default;
								object obj12 = default;
								object obj13 = default;
								object obj14 = default;
								object obj16 = default;
								while (true)
								{
									if (friends.Length > (nint)obj4)
									{
										object obj5 = obj4 << 2;
										object obj6 = (object)friends + obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v206+10]");
										object obj7 = 0;
										_ = 0;
										object obj8 = obj + 28;
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
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v206+10]");
															object obj9 = (nint)0 + (nint)12;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v206+10]");
																		object obj10 = (nint)0 + (nint)20;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v207+20]");
																					if ((nint)0 != 0)
																					{
																						_ = 0;
																						_ = -1;
																						obj = typeof(OfflineProfile.ProfileOrigin);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																						_ = 0;
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 == 1)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							break;
																						}
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						bool flag = (nint)0 != 1;
																						object obj11 = obj12;
																						if (!flag)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							break;
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v207+1C]");
																						if ((nint)0 != 0)
																						{
																							_ = 1;
																							_ = -1;
																							obj = typeof(OfflineProfile.ProfileOrigin);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																							_ = 0;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 == 1)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								break;
																							}
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							bool flag2 = (nint)0 != 1;
																							object obj11 = obj13;
																							if (!flag2)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								break;
																							}
																						}
																						else
																						{
																							_ = 0;
																							_ = -1;
																							obj = typeof(OfflineProfile.ProfileOrigin);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																							_ = 0;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 == 1)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								break;
																							}
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							bool flag3 = (nint)0 == 1;
																							object obj11 = obj14;
																							if (flag3)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								break;
																							}
																						}
																					}
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
																						object obj15 = (nint)0 + (nint)1;
																						obj4 = obj16 + 1;
																						continue;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				break;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																	break;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														break;
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
										break;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																break;
															}
															return;
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
											break;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									break;
								}
								goto IL_0a1c;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0a1c;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0a1c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0a1c;
		IL_0d4f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0a1c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj17 = default;
		object obj18 = default;
		bool flag4 = obj17 != obj18;
		object obj20 = default;
		object obj19 = obj20;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj22 = default;
				object obj21 = obj22;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj23 = default;
					if (obj23 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj24 = (nint)0 << 2;
						object obj25 = obj3 + obj24;
						obj25 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj26 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj27 = (nint)0 << 2;
						object obj28 = obj27 + obj3;
						object obj29 = obj28 - 4;
						object obj30 = obj29;
						object obj31 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ S1_v48+D4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "Error saving leaderboard: " + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj32 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj33 = obj22;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					obj19 = obj33;
					if (flag5)
					{
						goto IL_0d4f;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			object obj34 = default;
			obj19 = obj34;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj19 = obj34;
			}
		}
		goto IL_0d4f;
	}

	private static Friend ParseFriend(string id, string values)
	{
		//IL_008a: Expected VT, but got Obj
		string[] array = values.Split(',');
		Friend friend = default;
		if (array.Length == 4)
		{
			friend.name = array[0];
			int score = int.Parse(array[1]);
			friend.score = score;
			int games = int.Parse(array[2]);
			friend.games = games;
			OfflineProfile offlineProfile = friend.offlineProfile;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(OfflineProfile.ProfileOrigin));
			object obj = Enum.Parse(typeFromHandle, array[3]);
			throw new NullReferenceException();
		}
		return friend;
	}

	private static string GetSavePath()
	{
		string userDataPath = DeviceUtility.GetUserDataPath();
		return userDataPath + "/leaderboard";
	}

	public static bool IsAvailable()
	{
		bool flag = HasExpired();
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public static void DeleteFile()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_022e: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		if (!Exists())
		{
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj14 + obj3;
						object obj16 = obj15 - 4;
						object obj17 = obj16;
						object obj18 = obj17;
						object obj19 = obj17 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ S1_v46+D4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "Error saving leaderboard: " + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj20 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj21 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj6 = obj9;
					if (flag2)
					{
						goto IL_0421;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj22 = default;
			obj6 = obj22;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj22;
			}
		}
		goto IL_0421;
		IL_0421:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public static void RemoveFacebookFriends()
	{
		//IL_0079: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		Friend[] array = Load();
		List<Friend> list = default;
		list._002Ector();
		if (array != null)
		{
			object obj = default;
			object obj4 = default;
			while ((nint)obj < array.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v33+10]");
				Friend friend = (Friend)0;
				OfflineProfile offlineProfile = friend.offlineProfile;
				if (offlineProfile.origin != OfflineProfile.ProfileOrigin.Facebook)
				{
					list.Add(friend);
				}
				obj = obj4 + 1;
			}
		}
		if (list._size >= 1)
		{
			Friend[] friends = list.ToArray();
			Save(friends);
		}
		else
		{
			DeleteFile();
		}
	}

	private static bool Exists()
	{
		return PlayerPrefs.HasKey("HasCachedLeaderboard");
	}

	private static bool HasExpired()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = Exists();
		bool flag2 = !flag;
		bool result = true;
		if (!flag2)
		{
			string value = PlayerPrefs.GetString("HasCachedLeaderboard");
			DateTime dateTime = Utils.StringToDateTime(value, DateTime.MinValue);
			DateTime now = CDateTime.Now;
			TimeSpan timeSpan = now - dateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0 * 1E-07;
			double num2 = (double)expirationDate * 1E-07;
			if (num < num2)
			{
				DateTime now2 = CDateTime.Now;
				if (dateTime < now2)
				{
					result = false;
					goto IL_0117;
				}
			}
			DeleteFile();
			result = true;
		}
		goto IL_0117;
		IL_0117:
		return result;
	}

	unsafe static CachedLeaderboard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected VT, but got Unknown
		//IL_003f: Expected native int or pointer, but got VT
		//IL_0055: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		TimeSpan timeSpan = (TimeSpan)(obj + 8);
		*(TimeSpan*)(nint)timeSpan = new TimeSpan(1, 0, 0, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		expirationDate = (TimeSpan)0;
	}
}
