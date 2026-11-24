using System;
using System.Collections.Generic;
using System.Globalization;
using ABTest;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Debugging;
using Info;
using Kiloo;
using SYBO.Components.Analytics;
using UI.VideoAdPrizes;
using UnityEngine;
using WeeklyHunt;

namespace UI;

public class WelcomePackManager
{
	private const int WELCOME_PACK_DAYS_ACTIVE = 3;

	private const int WELCOME_PACK_ACTIVE_FROM_VERSION = 1890;

	public static string WelcomePackInAppID
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_16d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16de: Expected Obj, but got Unknown
			//IL_16e7: Expected Obj, but got I4
			//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fb: Expected Obj, but got Unknown
			//IL_1704: Expected Obj, but got I4
			//IL_1719: Unknown result type (might be due to invalid IL or missing references)
			//IL_171e: Expected Obj, but got Unknown
			//IL_1727: Expected Obj, but got I4
			//IL_1730: Unknown result type (might be due to invalid IL or missing references)
			//IL_1735: Expected Obj, but got Unknown
			//IL_173e: Expected Obj, but got I4
			//IL_174d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1752: Expected Obj, but got Unknown
			//IL_176e: Expected I, but got Obj
			//IL_1784: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00cf: Expected I, but got Obj
			//IL_00e5: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I4
			//IL_0419: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Expected Obj, but got Unknown
			//IL_017a: Expected I, but got Obj
			//IL_0190: Expected Obj, but got I
			//IL_0110: Expected I, but got Obj
			//IL_01bb: Expected I, but got Obj
			//IL_0243: Expected I, but got Obj
			//IL_0259: Expected Obj, but got I
			//IL_0284: Expected I, but got Obj
			//IL_0317: Expected I, but got Obj
			//IL_032d: Expected Obj, but got I
			//IL_1933: Expected I, but got Obj
			//IL_1949: Expected Obj, but got I
			//IL_08d3: Expected Obj, but got I
			//IL_181d: Expected Obj, but got I4
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Expected Obj, but got Unknown
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Expected Obj, but got Unknown
			//IL_0358: Expected I, but got Obj
			//IL_098b: Expected I, but got Obj
			//IL_0909: Unknown result type (might be due to invalid IL or missing references)
			//IL_090e: Expected Obj, but got Unknown
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_040a: Expected Obj, but got Unknown
			//IL_093f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0944: Expected Obj, but got Unknown
			//IL_0a09: Expected Obj, but got I4
			//IL_0a5e: Expected I, but got Obj
			//IL_0a74: Expected Obj, but got I
			//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e55: Expected Obj, but got Unknown
			//IL_0a9f: Expected I, but got Obj
			//IL_1590: Expected Obj, but got I4
			//IL_161a: Expected Obj, but got I
			//IL_1650: Unknown result type (might be due to invalid IL or missing references)
			//IL_1655: Expected Obj, but got Unknown
			//IL_1849: Unknown result type (might be due to invalid IL or missing references)
			//IL_184e: Expected Obj, but got Unknown
			//IL_1857: Unknown result type (might be due to invalid IL or missing references)
			//IL_185c: Expected Obj, but got Unknown
			//IL_1888: Expected Obj, but got I4
			//IL_1686: Unknown result type (might be due to invalid IL or missing references)
			//IL_168b: Expected Obj, but got Unknown
			//IL_0bbc: Expected I, but got Obj
			//IL_0bd2: Expected Obj, but got I
			//IL_0e42: Expected Obj, but got I4
			//IL_0d88: Expected Obj, but got I
			//IL_0e34: Expected Obj, but got I4
			//IL_0bfd: Expected I, but got Obj
			//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc3: Expected Obj, but got Unknown
			//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df9: Expected Obj, but got Unknown
			//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8d: Expected Obj, but got Unknown
			//IL_1404: Expected Obj, but got I4
			//IL_1434: Expected Obj, but got I4
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Expected Obj, but got Unknown
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Expected Obj, but got Unknown
			//IL_081b: Expected Obj, but got I4
			//IL_1464: Expected Obj, but got I4
			//IL_1494: Expected Obj, but got I4
			//IL_14d3: Expected Obj, but got I4
			//IL_1503: Expected Obj, but got I4
			//IL_1511: Unknown result type (might be due to invalid IL or missing references)
			//IL_1516: Expected Obj, but got Unknown
			//IL_151f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1524: Expected Obj, but got Unknown
			//IL_1550: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 96;
			object obj3 = obj2 + 80;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 56;
			obj4 = 0;
			_ = 0;
			_ = 0;
			object obj5 = obj2 + 24;
			obj5 = 0;
			object obj6 = obj2 + 40;
			obj6 = 0;
			_ = 0;
			object obj7 = obj2 + 32;
			obj7 = obj;
			_ = -1;
			nint num = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<Info.Boards>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v439 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj9 = default;
			object obj12 = default;
			object obj14 = default;
			object obj16 = default;
			object obj18 = default;
			object obj20 = default;
			object obj21 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj9 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v353 (Il2CppClass<Info.Boards>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num4 = (nint)typeof(Boards);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v427 (Il2CppClass<Info.Boards>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v368 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v418 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj12 == null)
				{
					continue;
				}
				nint num7 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v377 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num8 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S0_v410 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj14 != null)
				{
					continue;
				}
				nint num9 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v386 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num10 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v402 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag = obj16 == null;
				object obj17 = obj18 ^ 1;
				object obj19 = flag | obj17;
				if (obj19 == null)
				{
					obj20 = obj21 + 1;
				}
			}
			object obj22 = 42;
			object obj23 = obj22 - 12;
			if ((nint)obj22 != 12)
			{
				if ((nint)obj23 != 1 && (nint)obj23 != 2 && (nint)obj23 != 3 && (nint)obj23 != 4)
				{
					if ((nint)obj23 == 5 || (nint)obj23 == 6)
					{
						goto IL_0825;
					}
					if ((nint)obj23 != 7 && (nint)obj23 != 8 && (nint)obj23 != 9)
					{
						if ((nint)obj23 == 10)
						{
							goto IL_0825;
						}
						if ((nint)obj23 != 11 && (nint)obj23 != 12 && (nint)obj23 != 13)
						{
							if ((nint)obj23 == 14)
							{
								goto IL_0825;
							}
							if ((nint)obj23 != 15 && (nint)obj23 != 16)
							{
								if ((nint)obj23 == 17)
								{
									goto IL_0825;
								}
								if ((nint)obj23 != 18 && (nint)obj23 != 19 && (nint)obj23 != 20)
								{
									if ((nint)obj23 == 21)
									{
										goto IL_0825;
									}
									if ((nint)obj23 != 22 && (nint)obj23 != 23)
									{
										if ((nint)obj23 == 24)
										{
											goto IL_0825;
										}
										if ((nint)obj23 != 25 && (nint)obj23 != 26 && (nint)obj23 != 27 && (nint)obj23 != 28)
										{
											if ((nint)obj23 == 29)
											{
												goto IL_0825;
											}
											if ((nint)obj23 == 30)
											{
												object obj24 = obj7 + 4;
												object obj25 = obj24 + 1;
												obj24 = obj25;
												object obj26 = obj25 << 2;
												object obj27 = obj7 + obj26;
												obj27 = 93;
												goto IL_0898;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_16c4;
			}
			goto IL_0825;
			IL_16c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			return null;
			IL_19b7:
			object obj28 = default;
			return obj28 + obj20;
			IL_0898:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
				object obj29 = (nint)0 << 2;
				object obj30 = obj7 + obj29;
				if ((nint)obj30 == 93)
				{
					object obj31 = obj7 + 4;
					if ((nint)obj31 > -1)
					{
						object obj32 = obj31 + -1;
						obj31 = obj32;
					}
					goto IL_1925;
				}
			}
			object obj33 = default;
			if (obj33 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_1925;
			IL_1565:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj35;
			object obj34 = obj35;
			object obj37 = default;
			object obj36 = obj37;
			object obj39 = default;
			object obj38 = obj39;
			object obj40 = 104;
			goto IL_18c5;
			IL_18c5:
			object obj42 = default;
			if ((nint)obj40 == 104)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj41 = default;
				if (obj36 != obj41)
				{
					obj33 = obj38;
					goto IL_16c4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				object obj43 = default;
				obj42 = obj43;
				obj28 = obj34;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
				object obj44 = (nint)0 << 2;
				object obj45 = obj7 + obj44;
				if ((nint)obj45 == 239)
				{
					object obj46 = obj7 + 4;
					if ((nint)obj46 > -1)
					{
						object obj47 = obj46 + -1;
						obj46 = obj47;
					}
					goto IL_19b7;
				}
			}
			if (obj42 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_19b7;
			IL_0825:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj48 = default;
			if (obj37 == obj48)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				object obj49 = default;
				obj33 = obj49;
				goto IL_0898;
			}
			object obj50 = default;
			obj33 = obj50;
			goto IL_16c4;
			IL_1925:
			nint num11 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v54 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj51 = (nint)0 & (nint)0x200;
			if (obj51 != null)
			{
				nint num12 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v308 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			obj35 = 0;
			object obj52 = default;
			object obj54 = default;
			object obj55 = default;
			object obj56 = default;
			object obj58 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj52 == null)
				{
					obj40 = 106;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num13 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ S0_v171 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj53 = (nint)0 & (nint)0x200;
				if (obj53 != null)
				{
					nint num14 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S0_v297 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj54 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				obj55 = obj35;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj56 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num15 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ S0_v275 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj57 = (nint)0 & (nint)0x200;
					if (obj57 != null)
					{
						nint num16 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ S0_v288 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj58 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ S0_v262+18]");
						if ((nint)0 != 0)
						{
							object obj59 = obj55 + 1;
							obj55 = obj59;
						}
					}
				}
				object obj60 = obj7 + 4;
				object obj61 = obj60 + 1;
				obj60 = obj61;
				object obj62 = obj61 << 2;
				object obj63 = obj7 + obj62;
				obj63 = 214;
				object obj64 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
				object obj69;
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
					object obj65 = (nint)0 << 2;
					object obj66 = obj7 + obj65;
					if ((nint)obj66 == 214)
					{
						object obj67 = obj7 + 4;
						if ((nint)obj67 > -1)
						{
							object obj68 = obj67 + -1;
							obj67 = obj68;
						}
						obj69 = obj64;
						goto IL_1975;
					}
				}
				object obj70;
				if (obj64 != null)
				{
					obj70 = obj64;
					obj40 = 99;
					break;
				}
				obj69 = 0;
				goto IL_1975;
				IL_1975:
				obj70 = obj64;
				obj33 = obj69;
				obj35 = obj55;
			}
			object obj71 = obj40 - 59;
			if ((nint)obj40 != 59 && (nint)obj71 != 1)
			{
				if ((nint)obj71 != 2 && (nint)obj71 != 3)
				{
					if ((nint)obj71 == 4)
					{
						goto IL_1565;
					}
					if ((nint)obj71 != 5 && (nint)obj71 != 6 && (nint)obj71 != 7 && (nint)obj71 != 8)
					{
						if ((nint)obj71 != 9)
						{
							if ((nint)obj71 != 10)
							{
								if ((nint)obj71 != 11 && (nint)obj71 != 12 && (nint)obj71 != 13 && (nint)obj71 != 14 && (nint)obj71 != 15 && (nint)obj71 != 16 && (nint)obj71 != 17 && (nint)obj71 != 18 && (nint)obj71 != 19 && (nint)obj71 != 20 && (nint)obj71 != 21 && (nint)obj71 != 22 && (nint)obj71 != 23 && (nint)obj71 != 24 && (nint)obj71 != 25 && (nint)obj71 != 26 && (nint)obj71 != 27 && (nint)obj71 != 28 && (nint)obj71 != 29 && (nint)obj71 != 30 && (nint)obj71 != 31)
								{
									if ((nint)obj71 != 32)
									{
										if ((nint)obj71 != 33)
										{
											if ((nint)obj71 != 34)
											{
												if ((nint)obj71 != 35 && (nint)obj71 != 36 && (nint)obj71 != 37 && (nint)obj71 != 38 && (nint)obj71 != 39)
												{
													if ((nint)obj71 != 40)
													{
														if ((nint)obj71 != 41 && (nint)obj71 != 42 && (nint)obj71 != 43)
														{
															if ((nint)obj71 != 44)
															{
																if ((nint)obj71 != 45 && (nint)obj71 != 46 && (nint)obj71 == 47)
																{
																	object obj72 = obj7 + 4;
																	object obj73 = obj72 + 1;
																	obj72 = obj73;
																	object obj74 = obj73 << 2;
																	object obj75 = obj7 + obj74;
																	obj75 = 239;
																	obj42 = obj33;
																	obj28 = obj35;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																obj34 = obj35;
																obj36 = obj37;
																object obj76 = default;
																obj38 = obj76;
																obj40 = 104;
															}
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														obj34 = obj55;
														obj36 = obj37;
														object obj77 = default;
														obj38 = obj77;
														obj40 = 104;
													}
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												obj34 = obj55;
												obj36 = obj37;
												object obj78 = default;
												obj38 = obj78;
												obj40 = 104;
											}
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj34 = obj55;
										obj36 = obj37;
										object obj79 = default;
										obj38 = obj79;
										obj40 = 104;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj34 = obj35;
								obj36 = obj37;
								object obj80 = default;
								obj38 = obj80;
								obj40 = 104;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj34 = obj35;
							obj36 = obj37;
							object obj81 = default;
							obj38 = obj81;
							obj40 = 104;
						}
					}
				}
				goto IL_18c5;
			}
			goto IL_1565;
		}
	}

	public static TimeSpan welcomePackTimeLeft
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_011b: Expected I, but got Obj
			//IL_0131: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool key = WeeklyHuntManager.IsAnyPeriodActive();
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FPSCounter instance = FPSCounter.Instance;
			WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(key ? 1 : 0);
			return (TimeSpan)weeklyHuntPeriodData.periodEndDate;
		}
	}

	public static bool IsWelcomeBoardActive(Boards.BoardId boardId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L0 (Info.Boards+BoardId)+30]");
		return false;
	}

	public static bool IsWelcomePackActive()
	{
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ea: Expected I4, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ABTestManager.IsDateToday("welcomepackprice");
		object obj2 = (((flag ? 1 : 0) != 2) ? "" : "com.kiloo.subwaysurfers.welcomePackTier02");
		if (flag)
		{
			obj2 = "com.kiloo.subwaysurfers.welcomePackTier01";
		}
		return (byte)(int)obj2 != 0;
	}

	private static int ParseFirstInstalledVersion()
	{
		//IL_0129: Expected Obj, but got I8
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00d4: Expected I, but got Obj
		ResetWelcomePack();
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		object obj = msTicksSinceDeviceStartup;
		object obj2 = obj / 10000000;
		object obj3 = obj2 / 60;
		object obj4 = obj3 * 60;
		object obj5 = obj2 - obj4;
		if ((nint)obj5 >= 0)
		{
			bool flag;
			if (IsWelcomePackActive())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v33 (System.Boolean)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				string firstInstalledVersion = GetFirstInstalledVersion();
				if ((nint)firstInstalledVersion >= 1890)
				{
					return 1;
				}
			}
		}
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<Globals>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v26 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Globals.DEBUG_ENABLE_WELCOME_PACK ? 1 : 0;
	}

	private unsafe static string GetFirstInstalledVersion()
	{
		//IL_0077: Expected I4, but got Obj
		//IL_0077: Expected I4, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		ref long reference = ref *(long*)null;
		VideoAdPrizeManager instance = VideoAdPrizeManager.instance;
		string s = ((string)(object)instance).Remove((int)".", (int)"");
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v13 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		bool flag = long.TryParse(s, NumberStyles.Number, currentCulture, out reference);
		return (string)reference;
	}

	private unsafe static void UpdateSetWelcomePackStartTime()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_0020: Expected I4, but got Obj
		//IL_004e: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_008f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RootScaler rootScaler = default;
		rootScaler.Awake();
		_ = 1;
		_ = 15f;
		_ = 0.3f;
		_ = 35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
		object obj = default;
		int num = obj + 16;
		((int*)num)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((CameraSettings)(object)rootScaler).fieldOfView = num;
		_ = 20f;
		nint num2 = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<Layers>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v31 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v18 (System.Boolean)+48]");
		rootScaler._myUIRoot = (UIRoot)0;
		CameraSettings._renderTextureCameraSettings = (CameraSettings)(object)rootScaler;
	}

	public unsafe static void ResetWelcomePack()
	{
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_02cf: Expected I, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got VT
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got VT
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected I4, but got Unknown
		//IL_0221: Expected I4, but got Obj
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_029d: Expected Obj, but got VT
		//IL_02aa: Expected I4, but got Obj
		//IL_0143: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v65 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime latestSuccessfulCloudSaveSyncTime = UserSave.latestSuccessfulCloudSaveSyncTime;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v59 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = latestSuccessfulCloudSaveSyncTime;
		object obj5 = obj4 + 8;
		obj5 = DateTime.MinValue;
		object obj6 = obj4 + 24;
		obj6 = obj3;
		bool flag = (byte)(obj4 + 32) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj5 != 0;
		object obj7 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj8 = (((bool*)(flag ? 1 : 0))->m_value ? 1 : 0) & 0x3FFFFFFFFFFFFFFFL;
		if (obj7 != obj8)
		{
			return;
		}
		bool flag2;
		if (IsWelcomePackActive())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v38 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			return;
		}
		DateTime today = CDateTime.Today;
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v44 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v51 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = today;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj4 != 0;
		UserSave.cloudSaveEnabled = flag;
	}

	private unsafe static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I4
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected VT, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0333: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_015a: Expected VT, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected I4, but got Unknown
		//IL_03c5: Expected Obj, but got F4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03fa: Expected VT, but got Obj
		//IL_0407: Expected F4, but got Obj
		//IL_0402: Expected native int or pointer, but got VT
		//IL_041c: Expected F4, but got I
		//IL_0417: Expected native int or pointer, but got VT
		//IL_0443: Expected VT, but got Obj
		//IL_0205: Expected VT, but got Obj
		//IL_0205: Expected Obj, but got VT
		//IL_0212: Expected Obj, but got F4
		//IL_0224: Expected I, but got F4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		Camera camera = default;
		object obj = camera + 32;
		obj = 0;
		_ = 0;
		string tag = ((Component)(object)msg).tag;
		Camera component = ((GameObject)(object)tag).GetComponent<Camera>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera camera2 = (Camera)(camera - -64);
		Rect rect = (Rect)(camera + 48);
		object obj3 = camera + 16;
		if (component != null)
		{
			SDebug.LogFormat("The UICameraScreenClipping script is not attached to a Camera", null);
			return;
		}
		nint num3 = (nint)typeof(UIRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30 (Il2CppClass<UIRoot>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v75 (Il2CppClass<UIRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIRoot uIRoot = UIRoot.list.get_Item(0);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIRoot != null)
		{
			SDebug.LogFormat("UIRoot doesn't exist.", null);
			return;
		}
		camera2.rect = (Rect)component;
		obj = camera2;
		_ = ((UnityEngine.Object)camera2).m_CachedPtr;
		Texture mainTexture = ((UISprite)(object)uIRoot).mainTexture;
		int height = Screen.height;
		object obj6 = mainTexture * height;
		int sleepTimeout = Screen.sleepTimeout;
		int num7 = obj6 / sleepTimeout;
		float num8 = 1f / (float)num7;
		float num9 = (((object)context == null) ? 306f : 265f);
		float num10 = num8 * num9;
		float num11 = 1f - num10;
		float num12 = num11 * 0.5f;
		obj = num12;
		object obj7 = msg + 12;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v29+8]");
		_ = 0;
		camera.rect = (Rect)component;
		((Rect*)(nint)rect)->m_XMin = (float)obj3;
		Rect rect2 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24+8]");
		((Rect*)(nint)rect2)->m_Width = 0f;
		camera2 = camera;
		((UnityEngine.Object)camera2).m_CachedPtr = ((UnityEngine.Object)camera).m_CachedPtr;
		if (rect == (Rect)camera2)
		{
			((Camera)rect).rect = (Rect)component;
			camera2 = (Camera)rect.m_XMin;
			((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)rect.m_Width;
			object obj8 = msg + 12;
			obj8 = camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
		}
		camera2 = (Camera)obj;
		Camera camera3 = camera2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
		Rect pixelRect = camera2.pixelRect;
	}

	public WelcomePackManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
