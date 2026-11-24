using System.Collections;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using SYBO.Subway.Info;
using UnityEngine;

public class CoinsForVideoManager
{
	private static CoinsForVideoManager _instance;

	private NotEnoughCoinsLootTableEntry[] _lootTable;

	private const string VIDEO_AVAIL_YES = "Yes";

	private const string BUTTON_NAME_VIDEO = "Video";

	private const string BUTTON_NO_COOLDOWN = "No Cooldown";

	private const string BUTTON_COOLDOWN = "Cooldown_{0}_watched";

	public static CoinsForVideoManager instance
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_1582: Unknown result type (might be due to invalid IL or missing references)
			//IL_1587: Expected Obj, but got Unknown
			//IL_1590: Expected Obj, but got I4
			//IL_159f: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a4: Expected Obj, but got Unknown
			//IL_15ad: Expected Obj, but got I4
			//IL_15bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c1: Expected Obj, but got Unknown
			//IL_15dd: Expected I, but got Obj
			//IL_15f3: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_015d: Expected I, but got Obj
			//IL_0173: Expected Obj, but got I
			//IL_012d: Expected Obj, but got I4
			//IL_0869: Unknown result type (might be due to invalid IL or missing references)
			//IL_086e: Expected Obj, but got Unknown
			//IL_019e: Expected I, but got Obj
			//IL_1100: Expected Obj, but got I4
			//IL_0224: Expected I, but got Obj
			//IL_023a: Expected Obj, but got I
			//IL_1130: Expected Obj, but got I4
			//IL_0265: Expected I, but got Obj
			//IL_14d7: Expected Obj, but got I
			//IL_17ab: Expected I, but got Obj
			//IL_17c1: Expected Obj, but got I
			//IL_02f3: Expected I, but got Obj
			//IL_0309: Expected Obj, but got I
			//IL_1515: Unknown result type (might be due to invalid IL or missing references)
			//IL_151a: Expected Obj, but got Unknown
			//IL_04bb: Expected I, but got Obj
			//IL_0334: Expected I, but got Obj
			//IL_154b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1550: Expected Obj, but got Unknown
			//IL_1160: Expected Obj, but got I4
			//IL_03c7: Expected I, but got Obj
			//IL_03dd: Expected Obj, but got I
			//IL_0408: Expected I, but got Obj
			//IL_0496: Unknown result type (might be due to invalid IL or missing references)
			//IL_049b: Expected Obj, but got Unknown
			//IL_05e9: Expected Obj, but got I4
			//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a6: Expected Obj, but got Unknown
			//IL_16af: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b4: Expected Obj, but got Unknown
			//IL_16e0: Expected Obj, but got I4
			//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fb: Expected Obj, but got Unknown
			//IL_144e: Expected Obj, but got I4
			//IL_085b: Expected Obj, but got I4
			//IL_0799: Expected Obj, but got I
			//IL_084d: Expected Obj, but got I4
			//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d4: Expected Obj, but got Unknown
			//IL_0680: Unknown result type (might be due to invalid IL or missing references)
			//IL_0685: Expected Obj, but got Unknown
			//IL_0805: Unknown result type (might be due to invalid IL or missing references)
			//IL_080a: Expected Obj, but got Unknown
			//IL_11a2: Expected Obj, but got I4
			//IL_11d2: Expected Obj, but got I4
			//IL_1202: Expected Obj, but got I4
			//IL_1232: Expected Obj, but got I4
			//IL_1262: Expected Obj, but got I4
			//IL_1292: Expected Obj, but got I4
			//IL_12c2: Expected Obj, but got I4
			//IL_12f2: Expected Obj, but got I4
			//IL_1322: Expected Obj, but got I4
			//IL_1352: Expected Obj, but got I4
			//IL_1391: Expected Obj, but got I4
			//IL_13c1: Expected Obj, but got I4
			//IL_13cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d4: Expected Obj, but got Unknown
			//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e2: Expected Obj, but got Unknown
			//IL_140e: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			_ = 0;
			object obj5 = obj2 + 16;
			obj5 = obj;
			_ = -1;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v390 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9;
			CoinsForVideoManager result = default;
			object obj40 = default;
			object obj41 = default;
			CoinsForVideoManager coinsForVideoManager6 = default;
			if (UserSave.lastPurchasedBundle == InAppData.BundleTier.None)
			{
				nint num3 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v32 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v384 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				CoinsForVideoManager coinsForVideoManager = null;
				object obj8 = default;
				object obj11 = default;
				object obj14 = default;
				object obj16 = default;
				object obj18 = default;
				object obj19 = default;
				CoinsForVideoManager coinsForVideoManager3 = default;
				object obj21 = default;
				object obj22 = default;
				object obj29 = default;
				CoinsForVideoManager coinsForVideoManager5 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj8 == null)
					{
						obj9 = 88;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num5 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v186 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num6 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v374 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj11 == null)
					{
						continue;
					}
					nint num7 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S0_v195 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num8 = (nint)typeof(Characters);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S0_v364 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v206+28]");
					CoinsForVideoManager coinsForVideoManager2;
					if ((nint)0 != 0)
					{
						nint num9 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S0_v328 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num10 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S0_v356 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj14 != null)
						{
							coinsForVideoManager2 = coinsForVideoManager;
						}
						else
						{
							nint num11 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ S0_v337 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
							object obj15 = (nint)0 & (nint)0x200;
							if (obj15 != null)
							{
								nint num12 = (nint)typeof(CharacterManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ S0_v347 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							coinsForVideoManager2 = ((obj16 == null) ? ((CoinsForVideoManager)(coinsForVideoManager + 1)) : coinsForVideoManager);
						}
					}
					else
					{
						coinsForVideoManager2 = coinsForVideoManager;
					}
					nint num13 = (nint)typeof(Outfits);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S0_v210 (Il2CppClass<Info.Outfits>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num14 = (nint)typeof(Outfits);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ S0_v318 (Il2CppClass<Info.Outfits>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj28;
					object obj34;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if ((nint)obj19 >= 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj4 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							coinsForVideoManager3 = coinsForVideoManager2;
							object obj20 = 1;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (obj21 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ S0_v305+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									if (obj22 == null)
									{
										CoinsForVideoManager coinsForVideoManager4 = (CoinsForVideoManager)(coinsForVideoManager3 + 1);
										coinsForVideoManager3 = coinsForVideoManager4;
									}
								}
								object obj23 = obj20 + 1;
								obj20 = obj23;
							}
							object obj24 = obj5 + 4;
							object obj25 = obj24 + 1;
							obj24 = obj25;
							object obj26 = obj25 << 2;
							object obj27 = obj5 + obj26;
							obj27 = 176;
							obj28 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
							if ((nint)0 != -1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
								object obj30 = (nint)0 << 2;
								object obj31 = obj5 + obj30;
								if ((nint)obj31 == 176)
								{
									object obj32 = obj5 + 4;
									if ((nint)obj32 > -1)
									{
										object obj33 = obj32 + -1;
										obj32 = obj33;
									}
									obj29 = obj28;
									goto IL_17fc;
								}
							}
							if (obj28 != null)
							{
								obj34 = obj28;
								coinsForVideoManager5 = coinsForVideoManager2;
								obj9 = 80;
								break;
							}
							obj29 = 0;
							goto IL_17fc;
						}
					}
					coinsForVideoManager5 = coinsForVideoManager2;
					coinsForVideoManager = coinsForVideoManager2;
					continue;
					IL_17fc:
					obj34 = obj28;
					coinsForVideoManager5 = coinsForVideoManager2;
					coinsForVideoManager = coinsForVideoManager3;
				}
				object obj35 = obj9 - 15;
				object obj42 = default;
				if ((nint)obj9 != 15)
				{
					if ((nint)obj35 != 1)
					{
						if ((nint)obj35 != 2 && (nint)obj35 != 3)
						{
							if ((nint)obj35 != 4)
							{
								if ((nint)obj35 != 5 && (nint)obj35 != 6 && (nint)obj35 != 7 && (nint)obj35 != 8)
								{
									object obj43;
									if ((nint)obj35 != 9)
									{
										if ((nint)obj35 != 10)
										{
											if ((nint)obj35 != 11 && (nint)obj35 != 12 && (nint)obj35 != 13)
											{
												if ((nint)obj35 != 14)
												{
													if ((nint)obj35 != 15 && (nint)obj35 != 16 && (nint)obj35 != 17)
													{
														if ((nint)obj35 != 18)
														{
															if ((nint)obj35 != 19 && (nint)obj35 != 20)
															{
																if ((nint)obj35 != 21)
																{
																	if ((nint)obj35 != 22 && (nint)obj35 != 23 && (nint)obj35 != 24)
																	{
																		if ((nint)obj35 != 25)
																		{
																			if ((nint)obj35 != 26 && (nint)obj35 != 27)
																			{
																				if ((nint)obj35 != 28)
																				{
																					if ((nint)obj35 != 29 && (nint)obj35 != 30 && (nint)obj35 != 31 && (nint)obj35 != 32)
																					{
																						if ((nint)obj35 != 33)
																						{
																							if ((nint)obj35 != 34 && (nint)obj35 != 35 && (nint)obj35 != 36)
																							{
																								if ((nint)obj35 != 37)
																								{
																									if ((nint)obj35 != 38 && (nint)obj35 != 39)
																									{
																										if ((nint)obj35 != 40)
																										{
																											if ((nint)obj35 != 41 && (nint)obj35 != 42)
																											{
																												if ((nint)obj35 != 43)
																												{
																													if ((nint)obj35 != 44 && (nint)obj35 != 45 && (nint)obj35 != 46 && (nint)obj35 != 47 && (nint)obj35 != 48 && (nint)obj35 != 49 && (nint)obj35 != 50 && (nint)obj35 != 51 && (nint)obj35 != 52 && (nint)obj35 != 53 && (nint)obj35 != 54 && (nint)obj35 != 55 && (nint)obj35 != 56 && (nint)obj35 != 57)
																													{
																														if ((nint)obj35 != 58)
																														{
																															if ((nint)obj35 != 59 && (nint)obj35 != 60 && (nint)obj35 != 61 && (nint)obj35 != 62 && (nint)obj35 != 63 && (nint)obj35 != 64)
																															{
																																if ((nint)obj35 != 65)
																																{
																																	if ((nint)obj35 != 66 && (nint)obj35 != 67 && (nint)obj35 != 68 && (nint)obj35 != 69)
																																	{
																																		if ((nint)obj35 != 70)
																																		{
																																			if ((nint)obj35 != 71 && (nint)obj35 != 72 && (nint)obj35 == 73)
																																			{
																																				object obj36 = obj5 + 4;
																																				object obj37 = obj36 + 1;
																																				obj36 = obj37;
																																				object obj38 = obj37 << 2;
																																				object obj39 = obj5 + obj38;
																																				obj39 = 204;
																																				result = coinsForVideoManager;
																																				obj40 = obj29;
																																			}
																																		}
																																		else
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																			obj41 = obj42;
																																			object obj44 = default;
																																			obj43 = obj44;
																																			coinsForVideoManager6 = coinsForVideoManager;
																																			obj9 = 86;
																																		}
																																	}
																																}
																																else
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																	obj41 = obj42;
																																	object obj45 = default;
																																	obj43 = obj45;
																																	coinsForVideoManager6 = coinsForVideoManager3;
																																	obj9 = 86;
																																}
																															}
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																															obj41 = obj42;
																															object obj46 = default;
																															obj43 = obj46;
																															coinsForVideoManager6 = coinsForVideoManager3;
																															obj9 = 86;
																														}
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																													obj41 = obj42;
																													object obj47 = default;
																													obj43 = obj47;
																													coinsForVideoManager6 = coinsForVideoManager5;
																													obj9 = 86;
																												}
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																											obj41 = obj42;
																											object obj48 = default;
																											obj43 = obj48;
																											coinsForVideoManager6 = coinsForVideoManager5;
																											obj9 = 86;
																										}
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																									obj41 = obj42;
																									object obj49 = default;
																									obj43 = obj49;
																									coinsForVideoManager6 = coinsForVideoManager5;
																									obj9 = 86;
																								}
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																							obj41 = obj42;
																							object obj50 = default;
																							obj43 = obj50;
																							coinsForVideoManager6 = coinsForVideoManager5;
																							obj9 = 86;
																						}
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																					obj41 = obj42;
																					object obj51 = default;
																					obj43 = obj51;
																					coinsForVideoManager6 = coinsForVideoManager;
																					obj9 = 86;
																				}
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			obj41 = obj42;
																			object obj52 = default;
																			obj43 = obj52;
																			coinsForVideoManager6 = coinsForVideoManager;
																			obj9 = 86;
																		}
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj41 = obj42;
																	object obj53 = default;
																	obj43 = obj53;
																	coinsForVideoManager6 = coinsForVideoManager;
																	obj9 = 86;
																}
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															obj41 = obj42;
															object obj54 = default;
															obj43 = obj54;
															coinsForVideoManager6 = coinsForVideoManager;
															obj9 = 86;
														}
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													obj41 = obj42;
													object obj55 = default;
													obj43 = obj55;
													coinsForVideoManager6 = coinsForVideoManager;
													obj9 = 86;
												}
											}
											goto IL_171a;
										}
										coinsForVideoManager = coinsForVideoManager3;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									obj41 = obj42;
									object obj56 = default;
									obj43 = obj56;
									coinsForVideoManager6 = coinsForVideoManager;
									obj9 = 86;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj41 = obj42;
								object obj57 = default;
								object obj43 = obj57;
								coinsForVideoManager6 = coinsForVideoManager;
								obj9 = 86;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj41 = obj42;
						object obj58 = default;
						object obj43 = obj58;
						coinsForVideoManager6 = coinsForVideoManager;
						obj9 = 86;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj41 = obj42;
					object obj59 = default;
					object obj43 = obj59;
					coinsForVideoManager6 = coinsForVideoManager;
					obj9 = 86;
				}
				goto IL_171a;
			}
			goto IL_184c;
			IL_184c:
			CoinsForVideoManager result2 = default;
			return result2;
			IL_171a:
			if ((nint)obj9 == 86)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj60 = default;
				if (obj41 == obj60)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					result = coinsForVideoManager6;
					object obj61 = default;
					obj40 = obj61;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj62 = (nint)0 << 2;
				object obj63 = obj5 + obj62;
				if ((nint)obj63 == 204)
				{
					object obj64 = obj5 + 4;
					if ((nint)obj64 > -1)
					{
						object obj65 = obj64 + -1;
						obj64 = obj65;
					}
					return result;
				}
			}
			if (obj40 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				goto IL_184c;
			}
			return result;
		}
	}

	private CoinsForVideoManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public int GetRewardAmount()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		return num;
	}

	private void CreateLootTable()
	{
	}

	private NotEnoughCoinsLootTableEntry MakeRoll()
	{
		//IL_004c: Expected Obj, but got I
		if (_lootTable == null)
		{
			((NotEnoughCoinsLootTableEntry)this)._002Ector();
		}
		IEnumerator enumerator = ((ContactSupportPopUp)this).DelayContactSupport();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Collections.IEnumerator)+10]");
		return (NotEnoughCoinsLootTableEntry)0;
	}

	static CoinsForVideoManager()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0075: Expected VT, but got Obj
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d7: Expected VT, but got Obj
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_012b: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		obj = 0;
		obj = 1;
		_ = 90;
		_ = 1;
		_ = -1;
		object obj3 = obj2 + 20;
		obj3 = obj;
		object obj4 = obj2 + 24;
		obj4 = obj3;
		AwardFinishedCellHelper.COMPLETED_TITLE_TEXT_COLOR = (Color32)obj4;
		object obj5 = obj2 + 8;
		obj5 = 0;
		obj5 = 0;
		obj5 = -24;
		_ = -8;
		_ = -28;
		_ = -1;
		object obj6 = obj2 + 12;
		obj6 = obj5;
		obj4 = obj6;
		AwardFinishedCellHelper.COMPLETED_TITLE_TEXT_SHADOW_COLOR = (Color32)obj4;
		object obj7 = obj2 + 4;
		obj7 = 0;
		obj7 = 0;
		obj7 = -110;
		_ = -25;
		_ = 127;
		_ = -76;
		obj2 = obj7;
		obj4 = obj2;
		AwardFinishedCellHelper.COMPLETE_SEGMENT_BACKGROUND_COLOR = (Color32)obj4;
	}
}
