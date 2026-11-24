using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Serialization;
using Missions;

namespace Data.Migration;

public class PlayerPrefsMigrator
{
	private const int MIGRATE_VERSION = 1;

	private const string OPTION_SFX_KEY = "OPTION_SFX";

	private const string OPTION_MUSIC_KEY = "OPTION_MUSIC";

	private const string OPTION_TOPRUNCHALLENGERS_KEY = "OPTION_TOPRUNCHALLENGERS";

	private const string OPTION_REMINDER_DEFAULT_OFF_KEY = "OPTION_REMINDER_WITH_DEFAULT_OFF";

	private const string OPTION_REMINDER_PREFERENCE_KEY = "OPTION_REMINDER_PREFERENCE";

	private const string HAS_LOGGED_GAMECENTER_LOGIN_KEY = "flurry_has_logged_gc";

	private const string HAS_LOGGED_FACEBOOK_LOGIN_KEY = "flurry_has_logged_fb";

	private const string HAS_LOGGED_DAILY_EVENT_SOCIAL_PREFIX = "socflurdaily";

	private const string AWARD_ISNEW_KEY_PREFIX = "isAwardNew";

	private const string AWARD_HASPAYED_OUT_KEY_PREFIX = "hasPayed";

	private const string AWARDS_FIRST_LOADED_KEY = "awardsFirstLoaded";

	private const string KEY_FIRST_TIME_RUN = "SetShouldShowPopupToFalse";

	private const string BREADCRUMBS_KEY = "breadcrumbs";

	private const string LAST_EVENT_TYPE_SHOWN_KEY = "lastEventTypeShown";

	private const string LAST_EVENT_SHOWN_TIMESTAMP_KEY = "lastEventShownTimestamp";

	private const string LAST_SEEN_BUNDLE_VERSION_KEY = "lastSeenBundleVersionKey";

	private const string PrefsKeyPersistedSessionEventNumber = "SessionEventNumber";

	private static string _lastKeyRead;

	public static void ResetMigratedVersion()
	{
	}

	public static void Migrate()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91BF");
	}

	public unsafe static bool HasPlayerPrefsKey(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got Unknown
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected Obj, but got Unknown
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected Obj, but got Unknown
		//IL_10f9: Expected Obj, but got I4
		//IL_110e: Expected Obj, but got I4
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c: Expected Obj, but got Unknown
		//IL_1125: Expected Obj, but got I4
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected Obj, but got Unknown
		//IL_1161: Expected Obj, but got I
		//IL_1171: Expected Obj, but got I
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected Obj, but got Unknown
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected I, but got Unknown
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0143: Expected I, but got Obj
		//IL_020b: Expected I, but got Obj
		//IL_0221: Expected Obj, but got I
		//IL_101c: Expected Obj, but got I
		//IL_024c: Expected I, but got Obj
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Expected Obj, but got Unknown
		//IL_03be: Expected I, but got Obj
		//IL_03d4: Expected Obj, but got I
		//IL_1088: Unknown result type (might be due to invalid IL or missing references)
		//IL_108d: Expected Obj, but got Unknown
		//IL_03ff: Expected I, but got Obj
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_04c7: Expected I, but got Obj
		//IL_04dd: Expected Obj, but got I
		//IL_037d: Expected I, but got Obj
		//IL_0508: Expected I, but got Obj
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Expected Obj, but got Unknown
		//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f89: Expected Obj, but got Unknown
		//IL_0fb5: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 56;
		obj5 = 0;
		_ = 0;
		_ = 0;
		obj2 = 0;
		object obj6 = obj2 + 52;
		obj6 = 0;
		object obj7 = obj2 + 40;
		obj7 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v3+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		nint num2 = (nint)(obj11 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S4_v5 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		object obj12 = obj2 + 8;
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)key)->Current;
		obj5 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29+10]");
		_ = 0;
		object obj13 = default;
		object obj14 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		object obj23 = default;
		object obj25 = default;
		object obj26 = default;
		object obj28 = default;
		object obj29 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj2 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj6 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if ((nint)obj6 == 2)
			{
				object obj15 = 3;
			}
			else
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v196 (Il2CppClass<System.Type>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num4 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v347 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj3 = typeof(UpgradeType);
				obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj6 = obj17;
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ S0_v226 (Il2CppClass<System.Enum>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num6 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v335 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					obj6 = obj20;
					nint num7 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ S0_v321 (Il2CppClass<Flurry>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num8 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S0_v325 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					continue;
				}
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S0_v237 (Il2CppClass<System.Type>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num10 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v294 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj4 = typeof(UpgradeType);
				obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj6 = obj23;
				nint num11 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ S0_v267 (Il2CppClass<System.Enum>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num12 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ S0_v283 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj15 = obj25;
				if (obj25 == null)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				num2 = 0;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj27 = obj28 + obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			num2 = 0;
		}
		object obj30 = 69;
		object obj31 = obj30 - 8;
		object obj38;
		object obj39 = default;
		if ((nint)obj30 != 8 && (nint)obj31 != 1 && (nint)obj31 != 2)
		{
			if ((nint)obj31 == 3 || (nint)obj31 == 4 || (nint)obj31 == 5 || (nint)obj31 == 6)
			{
				goto IL_129d;
			}
			if ((nint)obj31 != 7)
			{
				if ((nint)obj31 == 8 || (nint)obj31 == 9 || (nint)obj31 == 10 || (nint)obj31 == 11 || (nint)obj31 == 12 || (nint)obj31 == 13 || (nint)obj31 == 14)
				{
					goto IL_129d;
				}
				if ((nint)obj31 != 15)
				{
					if ((nint)obj31 != 16)
					{
						if ((nint)obj31 != 17)
						{
							if ((nint)obj31 == 18 || (nint)obj31 == 19)
							{
								goto IL_129d;
							}
							if ((nint)obj31 != 20)
							{
								if ((nint)obj31 == 21 || (nint)obj31 == 22 || (nint)obj31 == 23)
								{
									goto IL_129d;
								}
								if ((nint)obj31 != 24)
								{
									if ((nint)obj31 == 25 || (nint)obj31 == 26 || (nint)obj31 == 27 || (nint)obj31 == 28 || (nint)obj31 == 29 || (nint)obj31 == 30 || (nint)obj31 == 31)
									{
										goto IL_129d;
									}
									if ((nint)obj31 != 32)
									{
										if ((nint)obj31 != 33)
										{
											if ((nint)obj31 != 34)
											{
												if ((nint)obj31 == 35 || (nint)obj31 == 36)
												{
													goto IL_129d;
												}
												if ((nint)obj31 != 37)
												{
													if ((nint)obj31 == 38 || (nint)obj31 == 39 || (nint)obj31 == 40 || (nint)obj31 == 41 || (nint)obj31 == 42 || (nint)obj31 == 43)
													{
														goto IL_129d;
													}
													if ((nint)obj31 != 44)
													{
														if ((nint)obj31 != 45)
														{
															if ((nint)obj31 == 46 || (nint)obj31 == 47 || (nint)obj31 == 48 || (nint)obj31 == 49 || (nint)obj31 == 50)
															{
																goto IL_129d;
															}
															if ((nint)obj31 != 51)
															{
																if ((nint)obj31 == 52 || (nint)obj31 == 53)
																{
																	goto IL_129d;
																}
																if ((nint)obj31 != 54)
																{
																	if ((nint)obj31 != 55)
																	{
																		if ((nint)obj31 == 56 || (nint)obj31 == 57 || (nint)obj31 == 58)
																		{
																			goto IL_129d;
																		}
																		if ((nint)obj31 != 59)
																		{
																			if ((nint)obj31 != 60)
																			{
																				if ((nint)obj31 == 61)
																				{
																					object obj32 = obj7 + 4;
																					object obj33 = obj32 + 1;
																					obj32 = obj33;
																					object obj34 = obj33 << 2;
																					object obj35 = obj7 + obj34;
																					obj35 = 232;
																				}
																				goto IL_129d;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			object obj37 = default;
																			object obj36 = obj37;
																			obj38 = obj39;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			object obj40 = default;
																			object obj36 = obj40;
																			obj38 = obj39;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		object obj41 = default;
																		object obj36 = obj41;
																		obj38 = obj39;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj42 = default;
																	object obj36 = obj42;
																	obj38 = obj39;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj43 = default;
																object obj36 = obj43;
																obj38 = obj39;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj44 = default;
															object obj36 = obj44;
															obj38 = obj39;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj45 = default;
														object obj36 = obj45;
														obj38 = obj39;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj46 = default;
													object obj36 = obj46;
													obj38 = obj39;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj47 = default;
												object obj36 = obj47;
												obj38 = obj39;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj48 = default;
											object obj36 = obj48;
											obj38 = obj39;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj49 = default;
										object obj36 = obj49;
										obj38 = obj39;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj50 = default;
									object obj36 = obj50;
									obj38 = obj39;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj51 = default;
								object obj36 = obj51;
								obj38 = obj39;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj52 = default;
							object obj36 = obj52;
							obj38 = obj39;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj53 = default;
						object obj36 = obj53;
						obj38 = obj39;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj54 = default;
					object obj36 = obj54;
					obj38 = obj39;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj55 = default;
				object obj36 = obj55;
				obj38 = obj39;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj56 = default;
			object obj36 = obj56;
			obj38 = obj39;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj57 = default;
		if (obj38 == obj57)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_129d;
		IL_129d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
			object obj58 = (nint)0 << 2;
			object obj59 = obj7 + obj58;
			if ((nint)obj59 == 232)
			{
				object obj60 = obj7 + 4;
				if ((nint)obj60 > -1)
				{
					object obj61 = obj60 + -1;
					obj60 = obj61;
				}
				goto IL_12c2;
			}
		}
		object obj62 = default;
		if (obj62 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_12c2;
		IL_12c2:
		bool result = default;
		return result;
	}

	public static bool CanMigrate()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected I4, but got Obj
		//IL_00ae: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		return (byte)(int)string.ConcatArray((string[])(object)cachePath, (int)"/playerdata") != 0;
	}

	public static void TryCleanPlayerPrefsKeys()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_5c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c3f: Expected Obj, but got Unknown
		//IL_5c48: Expected Obj, but got I4
		//IL_5c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c56: Expected Obj, but got Unknown
		//IL_5c5f: Expected Obj, but got I4
		//IL_5c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c6d: Expected Obj, but got Unknown
		//IL_5c89: Expected I, but got Obj
		//IL_5c9f: Expected Obj, but got I
		//IL_6744: Unknown result type (might be due to invalid IL or missing references)
		//IL_6749: Expected Obj, but got Unknown
		//IL_6752: Unknown result type (might be due to invalid IL or missing references)
		//IL_6757: Expected Obj, but got Unknown
		//IL_6760: Unknown result type (might be due to invalid IL or missing references)
		//IL_6765: Expected Obj, but got Unknown
		//IL_676e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6773: Expected Obj, but got Unknown
		//IL_677c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6781: Expected Obj, but got Unknown
		//IL_678a: Unknown result type (might be due to invalid IL or missing references)
		//IL_678f: Expected Obj, but got Unknown
		//IL_6798: Unknown result type (might be due to invalid IL or missing references)
		//IL_679d: Expected Obj, but got Unknown
		//IL_67b4: Expected Obj, but got I4
		//IL_67c5: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_2968: Unknown result type (might be due to invalid IL or missing references)
		//IL_296d: Expected Obj, but got Unknown
		//IL_50aa: Expected Obj, but got I4
		//IL_6402: Expected I, but got Obj
		//IL_6418: Expected Obj, but got I
		//IL_68d9: Expected I, but got Obj
		//IL_68ef: Expected Obj, but got I
		//IL_68b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_68be: Expected Obj, but got Unknown
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_2920: Expected I, but got Obj
		//IL_5bf2: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_5cd9: Expected I, but got Obj
		//IL_5cef: Expected Obj, but got I
		//IL_50d2: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_5d1a: Expected I, but got Obj
		//IL_5d30: Expected Obj, but got I
		//IL_027b: Expected I, but got Obj
		//IL_5d5b: Expected I, but got Obj
		//IL_5d71: Expected Obj, but got I
		//IL_034d: Expected I, but got Obj
		//IL_0412: Expected I, but got Obj
		//IL_0428: Expected Obj, but got I
		//IL_0453: Expected I, but got Obj
		//IL_5dab: Expected I, but got Obj
		//IL_5dc1: Expected Obj, but got I
		//IL_50fa: Expected Obj, but got I4
		//IL_0519: Expected I, but got Obj
		//IL_5dfb: Expected I, but got Obj
		//IL_5e11: Expected Obj, but got I
		//IL_05d1: Expected I, but got Obj
		//IL_5e4b: Expected I, but got Obj
		//IL_5e61: Expected Obj, but got I
		//IL_5122: Expected Obj, but got I4
		//IL_0689: Expected I, but got Obj
		//IL_5e9b: Expected I, but got Obj
		//IL_5eb1: Expected Obj, but got I
		//IL_074e: Expected I, but got Obj
		//IL_5eeb: Expected I, but got Obj
		//IL_5f01: Expected Obj, but got I
		//IL_0813: Expected I, but got Obj
		//IL_5f3b: Expected I, but got Obj
		//IL_5f51: Expected Obj, but got I
		//IL_0927: Expected I, but got Obj
		//IL_093d: Expected Obj, but got I
		//IL_08d8: Expected I, but got Obj
		//IL_514a: Expected Obj, but got I4
		//IL_0968: Expected I, but got Obj
		//IL_0a05: Expected Obj, but got I4
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Expected Obj, but got Unknown
		//IL_5172: Expected Obj, but got I4
		//IL_0a70: Expected I, but got Obj
		//IL_0a86: Expected Obj, but got I
		//IL_0ab1: Expected I, but got Obj
		//IL_0e24: Expected I, but got Obj
		//IL_0e3a: Expected Obj, but got I
		//IL_1c9f: Expected Obj, but got I4
		//IL_0b50: Expected I, but got Obj
		//IL_0b66: Expected Obj, but got I
		//IL_1ce1: Expected Obj, but got I4
		//IL_0e65: Expected I, but got Obj
		//IL_0be3: Expected I, but got Obj
		//IL_0bf9: Expected Obj, but got I
		//IL_0b91: Expected I, but got Obj
		//IL_0f04: Expected I, but got Obj
		//IL_0f1a: Expected Obj, but got I
		//IL_0c24: Expected I, but got Obj
		//IL_1dd6: Expected Obj, but got I4
		//IL_6823: Expected I, but got Obj
		//IL_6839: Expected Obj, but got I
		//IL_1d40: Expected Obj, but got I
		//IL_0f97: Expected I, but got Obj
		//IL_0fad: Expected Obj, but got I
		//IL_0f45: Expected I, but got Obj
		//IL_1ded: Expected Obj, but got I4
		//IL_519a: Expected Obj, but got I4
		//IL_0cb0: Expected I, but got Obj
		//IL_0cc6: Expected Obj, but got I
		//IL_1e00: Expected I, but got Obj
		//IL_1d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7b: Expected Obj, but got Unknown
		//IL_0fd8: Expected I, but got Obj
		//IL_60f0: Expected I, but got Obj
		//IL_6106: Expected Obj, but got I
		//IL_0d43: Expected I, but got Obj
		//IL_0d59: Expected Obj, but got I
		//IL_0cf1: Expected I, but got Obj
		//IL_1dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db1: Expected Obj, but got Unknown
		//IL_1eb9: Expected I, but got Obj
		//IL_1064: Expected I, but got Obj
		//IL_107a: Expected Obj, but got I
		//IL_0d84: Expected I, but got Obj
		//IL_6140: Expected I, but got Obj
		//IL_6156: Expected Obj, but got I
		//IL_1f25: Expected I, but got Obj
		//IL_1f3b: Expected Obj, but got I
		//IL_51c2: Expected Obj, but got I4
		//IL_10f7: Expected I, but got Obj
		//IL_110d: Expected Obj, but got I
		//IL_10a5: Expected I, but got Obj
		//IL_1fb5: Expected I, but got Obj
		//IL_619f: Expected I, but got Obj
		//IL_61b5: Expected Obj, but got I
		//IL_1f66: Expected I, but got Obj
		//IL_1138: Expected I, but got Obj
		//IL_20eb: Expected I, but got Obj
		//IL_205b: Expected I, but got Obj
		//IL_2071: Expected Obj, but got I
		//IL_6873: Expected I, but got Obj
		//IL_6889: Expected Obj, but got I
		//IL_2157: Expected I, but got Obj
		//IL_216d: Expected Obj, but got I
		//IL_51ea: Expected Obj, but got I4
		//IL_209c: Expected I, but got Obj
		//IL_2586: Expected I, but got Obj
		//IL_21e7: Expected I, but got Obj
		//IL_21fd: Expected Obj, but got I
		//IL_2198: Expected I, but got Obj
		//IL_6333: Expected I, but got Obj
		//IL_6349: Expected Obj, but got I
		//IL_2228: Expected I, but got Obj
		//IL_274d: Expected I, but got Obj
		//IL_260f: Expected I, but got Obj
		//IL_2625: Expected Obj, but got I
		//IL_63a3: Expected I, but got Obj
		//IL_63b9: Expected Obj, but got I
		//IL_6316: Expected Obj, but got VT
		//IL_2650: Expected I, but got Obj
		//IL_622d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6232: Expected Obj, but got Unknown
		//IL_623b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6240: Expected Obj, but got Unknown
		//IL_626c: Expected Obj, but got I4
		//IL_6275: Expected Obj, but got I4
		//IL_2866: Expected I, but got Obj
		//IL_27d6: Expected I, but got Obj
		//IL_27ec: Expected Obj, but got I
		//IL_26bd: Expected I, but got Obj
		//IL_26d3: Expected Obj, but got I
		//IL_2817: Expected I, but got Obj
		//IL_26fe: Expected I, but got Obj
		//IL_2566: Expected Obj, but got I4
		//IL_24c1: Expected Obj, but got I
		//IL_5212: Expected Obj, but got I4
		//IL_2550: Expected Obj, but got I4
		//IL_24f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24fc: Expected Obj, but got Unknown
		//IL_252d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2532: Expected Obj, but got Unknown
		//IL_2348: Expected I, but got Obj
		//IL_235e: Expected Obj, but got I
		//IL_523a: Expected Obj, but got I4
		//IL_2389: Expected I, but got Obj
		//IL_5262: Expected Obj, but got I4
		//IL_528a: Expected Obj, but got I4
		//IL_52b2: Expected Obj, but got I4
		//IL_52da: Expected Obj, but got I4
		//IL_5302: Expected Obj, but got I4
		//IL_532a: Expected Obj, but got I4
		//IL_5352: Expected Obj, but got I4
		//IL_537a: Expected Obj, but got I4
		//IL_53a2: Expected Obj, but got I4
		//IL_53ca: Expected Obj, but got I4
		//IL_53f2: Expected Obj, but got I4
		//IL_541a: Expected Obj, but got I4
		//IL_5442: Expected Obj, but got I4
		//IL_546a: Expected Obj, but got I4
		//IL_5492: Expected Obj, but got I4
		//IL_54ba: Expected Obj, but got I4
		//IL_54e2: Expected Obj, but got I4
		//IL_1bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf3: Expected Obj, but got Unknown
		//IL_1bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c01: Expected Obj, but got Unknown
		//IL_1c2d: Expected Obj, but got I4
		//IL_1c3e: Expected Obj, but got I4
		//IL_550a: Expected Obj, but got I4
		//IL_5532: Expected Obj, but got I4
		//IL_555a: Expected Obj, but got I4
		//IL_5582: Expected Obj, but got I4
		//IL_55aa: Expected Obj, but got I4
		//IL_55d2: Expected Obj, but got I4
		//IL_5609: Expected Obj, but got I4
		//IL_5631: Expected Obj, but got I4
		//IL_5659: Expected Obj, but got I4
		//IL_5681: Expected Obj, but got I4
		//IL_56a9: Expected Obj, but got I4
		//IL_56d1: Expected Obj, but got I4
		//IL_56f9: Expected Obj, but got I4
		//IL_5721: Expected Obj, but got I4
		//IL_5749: Expected Obj, but got I4
		//IL_5771: Expected Obj, but got I4
		//IL_5799: Expected Obj, but got I4
		//IL_57c1: Expected Obj, but got I4
		//IL_57e9: Expected Obj, but got I4
		//IL_5811: Expected Obj, but got I4
		//IL_5839: Expected Obj, but got I4
		//IL_5870: Expected Obj, but got I4
		//IL_5898: Expected Obj, but got I4
		//IL_58c0: Expected Obj, but got I4
		//IL_58e8: Expected Obj, but got I4
		//IL_5910: Expected Obj, but got I4
		//IL_5938: Expected Obj, but got I4
		//IL_5960: Expected Obj, but got I4
		//IL_5988: Expected Obj, but got I4
		//IL_59b0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 48;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v1606 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 60;
		object obj9 = obj2 + 56;
		object obj10 = obj2 + 52;
		object obj11 = obj2 + 44;
		object obj12 = obj2 + 40;
		object obj13 = obj2 + 24;
		bool hasPurchasedOrRestored = UserSave.hasPurchasedOrRestored;
		object obj14 = (hasPurchasedOrRestored ? 1 : 0) + 1;
		object obj15 = obj14;
		object obj16 = 0;
		object obj18 = default;
		object obj19 = default;
		object obj21 = default;
		object obj22 = default;
		object obj24 = default;
		object obj25 = default;
		object obj27 = default;
		object obj29 = default;
		object obj30 = default;
		object obj32 = default;
		object obj33 = default;
		object obj35 = default;
		object obj36 = default;
		object obj38 = default;
		object obj40 = default;
		object obj42 = default;
		object obj45 = default;
		IntPtr intPtr = default;
		object obj47 = default;
		object obj50 = default;
		IntPtr intPtr2 = default;
		object obj54 = default;
		object obj57 = default;
		object obj60 = default;
		object obj66 = default;
		bool flag8 = default;
		object obj72 = default;
		object obj74 = default;
		object obj77 = default;
		object obj80 = default;
		object obj82 = default;
		object obj83 = default;
		object obj84 = default;
		object obj85 = default;
		object obj86 = default;
		object obj87 = default;
		object obj89 = default;
		object obj90 = default;
		object obj92 = default;
		object obj95 = default;
		object obj98 = default;
		object obj101 = default;
		object obj102 = default;
		object obj103 = default;
		object obj104 = default;
		bool flag12 = default;
		while ((nint)obj15 <= 1)
		{
			if ((nint)obj15 != 1)
			{
				goto IL_63f4;
			}
			nint num3 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ S0_v408 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num4 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S0_v1598 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag = obj19 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num5 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ S0_v419 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num6 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1621 @ S0_v1577 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag2 = obj22 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num7 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1718 @ S0_v430 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num8 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1731 @ S0_v1556 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag3 = obj25 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num9 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ S0_v441 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num10 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1840 @ S0_v1535 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj27 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			else
			{
				nint num11 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1909 @ S0_v1493 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num12 = (nint)typeof(PlayerPrefsMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2003 @ S0_v1514 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj29 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if ((nint)obj30 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					}
				}
			}
			nint num13 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2059 @ S0_v455 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num14 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2067 @ S0_v1485 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj32 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag4 = obj33 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num15 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2115 @ S0_v466 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num16 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2123 @ S0_v1465 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj35 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag5 = obj36 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num17 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ S0_v479 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num18 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2184 @ S0_v1445 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj38 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			nint num19 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2233 @ S0_v490 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num20 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2242 @ S0_v1417 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj40 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			nint num21 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2299 @ S0_v501 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num22 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2310 @ S0_v1389 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj42 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			nint num23 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2367 @ S0_v512 (Il2CppClass<System.Type>)+BA]");
			object obj43 = (nint)0 & (nint)0x200;
			if (obj43 != null)
			{
				nint num24 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2378 @ S0_v1361 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj8 = typeof(AwardId);
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num25 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2416 @ S0_v524 (Il2CppClass<System.Enum>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num26 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ S0_v1353 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj45 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num27 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2908 @ S0_v1098 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
				object obj46 = (nint)0 & (nint)0x200;
				if (obj46 != null)
				{
					nint num28 = (nint)typeof(PlayerPrefsMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2918 @ S0_v1340 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (intPtr != (IntPtr)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					bool flag6 = obj47 != null;
					nint num29 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3060 @ S0_v1245 (Il2CppClass<System.Type>)+BA]");
					object obj48 = (nint)0 & (nint)0x200;
					if (obj48 != null)
					{
						nint num30 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3075 @ S0_v1332 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj9 = typeof(AwardId);
					obj7 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num31 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3163 @ S0_v1257 (Il2CppClass<System.Enum>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num32 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3186 @ S0_v1324 (Il2CppClass<System.Enum>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj50 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						nint num33 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3334 @ S0_v1273 (Il2CppClass<System.Type>)+BA]");
						object obj51 = (nint)0 & (nint)0x200;
						if (obj51 != null)
						{
							nint num34 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3368 @ S0_v1316 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						obj10 = typeof(AwardId);
						obj7 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						nint num35 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3446 @ S0_v1285 (Il2CppClass<System.Enum>)+BA]");
						object obj52 = (nint)0 & (nint)0x200;
						if (obj52 != null)
						{
							nint num36 = (nint)typeof(Enum);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3463 @ S0_v1308 (Il2CppClass<System.Enum>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num37 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3067 @ S0_v1117 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
				object obj53 = (nint)0 & (nint)0x200;
				if (obj53 != null)
				{
					nint num38 = (nint)typeof(PlayerPrefsMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3092 @ S0_v1230 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (intPtr2 == (IntPtr)0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				bool flag7 = obj54 != null;
				nint num39 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3249 @ S0_v1135 (Il2CppClass<System.Type>)+BA]");
				object obj55 = (nint)0 & (nint)0x200;
				if (obj55 != null)
				{
					nint num40 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3286 @ S0_v1222 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj11 = typeof(AwardId);
				obj7 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num41 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3343 @ S0_v1147 (Il2CppClass<System.Enum>)+BA]");
				object obj56 = (nint)0 & (nint)0x200;
				if (obj56 != null)
				{
					nint num42 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3385 @ S0_v1214 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj57 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				nint num43 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3572 @ S0_v1163 (Il2CppClass<System.Type>)+BA]");
				object obj58 = (nint)0 & (nint)0x200;
				if (obj58 != null)
				{
					nint num44 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3610 @ S0_v1206 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj12 = typeof(AwardId);
				obj7 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num45 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3681 @ S0_v1175 (Il2CppClass<System.Enum>)+BA]");
				object obj59 = (nint)0 & (nint)0x200;
				if (obj59 != null)
				{
					nint num46 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3716 @ S0_v1198 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			obj60 = 212;
			object obj61 = obj60 - 129;
			if ((nint)obj60 != 129 && (nint)obj61 != 1 && (nint)obj61 != 2)
			{
				if ((nint)obj61 != 3 && (nint)obj61 != 4)
				{
					if ((nint)obj61 == 5)
					{
						goto IL_1c43;
					}
					if ((nint)obj61 != 6 && (nint)obj61 != 7 && (nint)obj61 != 8 && (nint)obj61 != 9)
					{
						if ((nint)obj61 == 10 || (nint)obj61 == 11)
						{
							goto IL_1c43;
						}
						if ((nint)obj61 != 12 && (nint)obj61 != 13 && (nint)obj61 != 14 && (nint)obj61 != 15)
						{
							if ((nint)obj61 == 16 || (nint)obj61 == 17)
							{
								goto IL_1c43;
							}
							if ((nint)obj61 != 18 && (nint)obj61 != 19)
							{
								if ((nint)obj61 == 20)
								{
									goto IL_1c43;
								}
								if ((nint)obj61 != 21 && (nint)obj61 != 22 && (nint)obj61 != 23 && (nint)obj61 != 24)
								{
									if ((nint)obj61 == 25 || (nint)obj61 == 26)
									{
										goto IL_1c43;
									}
									if ((nint)obj61 != 27 && (nint)obj61 != 28 && (nint)obj61 != 29 && (nint)obj61 != 30)
									{
										if ((nint)obj61 == 31 || (nint)obj61 == 32)
										{
											goto IL_1c43;
										}
										if ((nint)obj61 != 33 && (nint)obj61 != 34 && (nint)obj61 != 35 && (nint)obj61 != 36 && (nint)obj61 != 37 && (nint)obj61 != 38 && (nint)obj61 != 39)
										{
											if ((nint)obj61 == 40 || (nint)obj61 == 41 || (nint)obj61 == 42 || (nint)obj61 == 43)
											{
												goto IL_1c43;
											}
											if ((nint)obj61 != 44 && (nint)obj61 != 45)
											{
												if ((nint)obj61 == 46)
												{
													goto IL_1c43;
												}
												if ((nint)obj61 != 47 && (nint)obj61 != 48 && (nint)obj61 != 49 && (nint)obj61 != 50)
												{
													if ((nint)obj61 == 51 || (nint)obj61 == 52)
													{
														goto IL_1c43;
													}
													if ((nint)obj61 != 53 && (nint)obj61 != 54 && (nint)obj61 != 55 && (nint)obj61 != 56)
													{
														if ((nint)obj61 == 57 || (nint)obj61 == 58)
														{
															goto IL_1c43;
														}
														if ((nint)obj61 != 59 && (nint)obj61 != 60)
														{
															if ((nint)obj61 == 61)
															{
																goto IL_1c43;
															}
															if ((nint)obj61 != 62 && (nint)obj61 != 63 && (nint)obj61 != 64 && (nint)obj61 != 65)
															{
																if ((nint)obj61 == 66 || (nint)obj61 == 67)
																{
																	goto IL_1c43;
																}
																if ((nint)obj61 != 68 && (nint)obj61 != 69 && (nint)obj61 != 70 && (nint)obj61 != 71)
																{
																	if ((nint)obj61 == 72 || (nint)obj61 == 73)
																	{
																		goto IL_1c43;
																	}
																	if ((nint)obj61 != 74 && (nint)obj61 != 75 && (nint)obj61 != 76 && (nint)obj61 != 77 && (nint)obj61 != 78 && (nint)obj61 != 79)
																	{
																		if ((nint)obj61 == 80 || (nint)obj61 == 81 || (nint)obj61 == 82)
																		{
																			goto IL_1c43;
																		}
																		if ((nint)obj61 == 83)
																		{
																			object obj62 = obj5 + 4;
																			object obj63 = obj62 + 1;
																			obj62 = obj63;
																			object obj64 = obj63 << 2;
																			object obj65 = obj5 + obj64;
																			obj65 = 580;
																			obj66 = obj16;
																			obj60 = 0;
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
							}
						}
					}
				}
				goto IL_6806;
			}
			goto IL_1c43;
			IL_6806:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
				object obj67 = (nint)0 << 2;
				object obj68 = obj5 + obj67;
				if ((nint)obj68 == 580)
				{
					object obj69 = obj5 + 4;
					if ((nint)obj69 > -1)
					{
						object obj70 = obj69 + -1;
						obj69 = obj70;
					}
					goto IL_6815;
				}
			}
			bool flag9 = obj66 == null;
			obj60 = 0;
			if (!flag9)
			{
				obj60 = 225;
				break;
			}
			goto IL_6815;
			IL_6865:
			nint num47 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3555 @ S0_v609 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj71 = (nint)0 & (nint)0x200;
			if (obj71 != null)
			{
				nint num48 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3592 @ S0_v745 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj72 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num49 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3763 @ S0_v704 (Il2CppClass<System.DateTime>)+BA]");
				object obj73 = (nint)0 & (nint)0x200;
				if (obj73 != null)
				{
					nint num50 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3813 @ S0_v734 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj4 = DateTime.MinValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj74 != null)
				{
					nint num51 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3987 @ S0_v716 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj75 = (nint)0 & (nint)0x200;
					if (obj75 != null)
					{
						nint num52 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4025 @ S0_v727 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj2 = obj4;
					obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
			}
			nint num53 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3711 @ S0_v623 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj76 = (nint)0 & (nint)0x200;
			if (obj76 != null)
			{
				nint num54 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3738 @ S0_v689 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj77 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num55 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3993 @ S0_v672 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj78 = (nint)0 & (nint)0x200;
				if (obj78 != null)
				{
					nint num56 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4041 @ S0_v681 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num57 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3861 @ S0_v634 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj79 = (nint)0 & (nint)0x200;
			if (obj79 != null)
			{
				nint num58 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3933 @ S0_v657 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			bool flag10 = obj80 == null;
			object obj81;
			obj16 = obj81;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				obj16 = obj81;
			}
			goto IL_63f4;
			IL_1c43:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			if (obj82 != obj83)
			{
				obj84 = obj82;
				obj85 = obj86;
				obj60 = 356;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			obj66 = obj87;
			obj60 = 0;
			goto IL_6806;
			IL_6815:
			nint num59 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2993 @ S0_v562 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj88 = (nint)0 & (nint)0x200;
			if (obj88 != null)
			{
				nint num60 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ S0_v1017 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj89 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				bool flag11 = obj90 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num61 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3121 @ S0_v573 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj91 = (nint)0 & (nint)0x200;
			if (obj91 != null)
			{
				nint num62 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3146 @ S0_v997 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj92 != null)
			{
				nint num63 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3225 @ S0_v981 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj93 = (nint)0 & (nint)0x200;
				if (obj93 != null)
				{
					nint num64 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3256 @ S0_v990 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num65 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3237 @ S0_v584 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj94 = (nint)0 & (nint)0x200;
			if (obj94 != null)
			{
				nint num66 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3267 @ S0_v973 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj95 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num67 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3484 @ S0_v955 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj96 = (nint)0 & (nint)0x200;
				if (obj96 != null)
				{
					nint num68 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3512 @ S0_v964 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num69 = (nint)typeof(PlayerPrefsMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3363 @ S0_v595 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+BA]");
			object obj97 = (nint)0 & (nint)0x200;
			if (obj97 != null)
			{
				nint num70 = (nint)typeof(PlayerPrefsMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3400 @ S0_v933 (Il2CppClass<Data.Migration.PlayerPrefsMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj98 != null)
			{
				nint num71 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3492 @ S0_v756 (Il2CppClass<System.Type>)+BA]");
				object obj99 = (nint)0 & (nint)0x200;
				if (obj99 != null)
				{
					nint num72 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3523 @ S0_v925 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj13 = typeof(SSEventType);
				obj7 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num73 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3632 @ S0_v768 (Il2CppClass<System.Enum>)+BA]");
				object obj100 = (nint)0 & (nint)0x200;
				if (obj100 != null)
				{
					nint num74 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3660 @ S0_v917 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj101 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj3 = obj102;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					obj3 = obj103;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj104 == null)
					{
						continue;
					}
					nint num75 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4219 @ S0_v901 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj105 = (nint)0 & (nint)0x200;
					if (obj105 != null)
					{
						nint num76 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4223 @ S0_v909 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				object obj106 = obj5 + 4;
				object obj107 = obj106 + 1;
				obj106 = obj107;
				object obj108 = obj107 << 2;
				object obj109 = obj5 + obj108;
				obj109 = 776;
				obj60 = 0;
				obj81 = obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
				object obj114;
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
					object obj110 = (nint)0 << 2;
					object obj111 = obj5 + obj110;
					if ((nint)obj111 == 776)
					{
						object obj112 = obj5 + 4;
						if ((nint)obj112 > -1)
						{
							object obj113 = obj112 + -1;
							obj112 = obj113;
						}
						obj114 = obj81;
						goto IL_6865;
					}
				}
				if (obj81 != null)
				{
					obj114 = obj81;
					obj60 = 314;
					break;
				}
				obj114 = obj81;
				obj81 = 0;
			}
			else
			{
				obj81 = obj66;
			}
			goto IL_6865;
			IL_63f4:
			nint num77 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ S0_v396 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj115 = (nint)0 & (nint)0x200;
			if (obj115 != null)
			{
				nint num78 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ S0_v403 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91BF");
			object obj116 = obj15 + 1;
			obj15 = obj116;
		}
		object obj117 = obj60 - 11;
		if ((nint)obj60 != 11)
		{
			if ((nint)obj117 != 1 && (nint)obj117 != 2)
			{
				if ((nint)obj117 != 3)
				{
					if ((nint)obj117 != 4 && (nint)obj117 != 5 && (nint)obj117 != 6 && (nint)obj117 != 7 && (nint)obj117 != 8)
					{
						if ((nint)obj117 != 9)
						{
							if ((nint)obj117 != 10 && (nint)obj117 != 11)
							{
								if ((nint)obj117 != 12)
								{
									if ((nint)obj117 != 13 && (nint)obj117 != 14 && (nint)obj117 != 15 && (nint)obj117 != 16 && (nint)obj117 != 17)
									{
										if ((nint)obj117 != 18)
										{
											if ((nint)obj117 != 19 && (nint)obj117 != 20)
											{
												if ((nint)obj117 != 21)
												{
													if ((nint)obj117 != 22 && (nint)obj117 != 23 && (nint)obj117 != 24 && (nint)obj117 != 25 && (nint)obj117 != 26)
													{
														if ((nint)obj117 != 27)
														{
															if ((nint)obj117 != 28 && (nint)obj117 != 29)
															{
																if ((nint)obj117 != 30)
																{
																	if ((nint)obj117 != 31 && (nint)obj117 != 32)
																	{
																		if ((nint)obj117 != 33)
																		{
																			if ((nint)obj117 != 34 && (nint)obj117 != 35 && (nint)obj117 != 36 && (nint)obj117 != 37 && (nint)obj117 != 38)
																			{
																				if ((nint)obj117 != 39)
																				{
																					if ((nint)obj117 != 40 && (nint)obj117 != 41)
																					{
																						if ((nint)obj117 != 42)
																						{
																							if ((nint)obj117 != 43 && (nint)obj117 != 44 && (nint)obj117 != 45 && (nint)obj117 != 46 && (nint)obj117 != 47 && (nint)obj117 != 48)
																							{
																								if ((nint)obj117 != 49)
																								{
																									if ((nint)obj117 != 50 && (nint)obj117 != 51 && (nint)obj117 != 52 && (nint)obj117 != 53 && (nint)obj117 != 54)
																									{
																										if ((nint)obj117 != 55)
																										{
																											if ((nint)obj117 != 56 && (nint)obj117 != 57)
																											{
																												if ((nint)obj117 != 58)
																												{
																													if ((nint)obj117 != 59 && (nint)obj117 != 60 && (nint)obj117 != 61 && (nint)obj117 != 62 && (nint)obj117 != 63)
																													{
																														if ((nint)obj117 != 64)
																														{
																															if ((nint)obj117 != 65)
																															{
																																if ((nint)obj117 != 66 && (nint)obj117 != 67)
																																{
																																	if ((nint)obj117 != 68)
																																	{
																																		if ((nint)obj117 != 69 && (nint)obj117 != 70 && (nint)obj117 != 71 && (nint)obj117 != 72 && (nint)obj117 != 73 && (nint)obj117 != 74)
																																		{
																																			if ((nint)obj117 != 75)
																																			{
																																				if ((nint)obj117 != 76)
																																				{
																																					if ((nint)obj117 != 77)
																																					{
																																						if ((nint)obj117 != 78 && (nint)obj117 != 79)
																																						{
																																							if ((nint)obj117 != 80)
																																							{
																																								if ((nint)obj117 != 81 && (nint)obj117 != 82 && (nint)obj117 != 83 && (nint)obj117 != 84 && (nint)obj117 != 85 && (nint)obj117 != 86)
																																								{
																																									if ((nint)obj117 != 87)
																																									{
																																										if ((nint)obj117 != 88)
																																										{
																																											if ((nint)obj117 != 89)
																																											{
																																												if ((nint)obj117 != 90 && (nint)obj117 != 91)
																																												{
																																													if ((nint)obj117 != 92)
																																													{
																																														if ((nint)obj117 != 93 && (nint)obj117 != 94 && (nint)obj117 != 95 && (nint)obj117 != 96 && (nint)obj117 != 97 && (nint)obj117 != 98)
																																														{
																																															if ((nint)obj117 != 99)
																																															{
																																																if ((nint)obj117 != 100)
																																																{
																																																	if ((nint)obj117 != 101)
																																																	{
																																																		if ((nint)obj117 != 102 && (nint)obj117 != 103 && (nint)obj117 != 104 && (nint)obj117 != 105)
																																																		{
																																																			if ((nint)obj117 != 106)
																																																			{
																																																				if ((nint)obj117 != 107 && (nint)obj117 != 108 && (nint)obj117 != 109)
																																																				{
																																																					if ((nint)obj117 != 110)
																																																					{
																																																						if ((nint)obj117 != 111)
																																																						{
																																																							if ((nint)obj117 != 112 && (nint)obj117 != 113 && (nint)obj117 != 114 && (nint)obj117 != 115 && (nint)obj117 != 116 && (nint)obj117 != 117 && (nint)obj117 != 118 && (nint)obj117 != 119 && (nint)obj117 != 120 && (nint)obj117 != 121 && (nint)obj117 != 122 && (nint)obj117 != 123 && (nint)obj117 != 124 && (nint)obj117 != 125 && (nint)obj117 != 126 && (nint)obj117 != 127 && (nint)obj117 != 128 && (nint)obj117 != 129 && (nint)obj117 != 130 && (nint)obj117 != 131 && (nint)obj117 != 132 && (nint)obj117 != 133 && (nint)obj117 != 134 && (nint)obj117 != 135 && (nint)obj117 != 136 && (nint)obj117 != 137 && (nint)obj117 != 138 && (nint)obj117 != 139 && (nint)obj117 != 140 && (nint)obj117 != 141 && (nint)obj117 != 142 && (nint)obj117 != 143 && (nint)obj117 != 144 && (nint)obj117 != 145 && (nint)obj117 != 146 && (nint)obj117 != 147 && (nint)obj117 != 148 && (nint)obj117 != 149 && (nint)obj117 != 150 && (nint)obj117 != 151 && (nint)obj117 != 152 && (nint)obj117 != 153 && (nint)obj117 != 154 && (nint)obj117 != 155 && (nint)obj117 != 156 && (nint)obj117 != 157 && (nint)obj117 != 158 && (nint)obj117 != 159 && (nint)obj117 != 160 && (nint)obj117 != 161 && (nint)obj117 != 162 && (nint)obj117 != 163 && (nint)obj117 != 164 && (nint)obj117 != 165 && (nint)obj117 != 166 && (nint)obj117 != 167 && (nint)obj117 != 168 && (nint)obj117 != 169 && (nint)obj117 != 170 && (nint)obj117 != 171 && (nint)obj117 != 172 && (nint)obj117 != 173 && (nint)obj117 != 174 && (nint)obj117 != 175 && (nint)obj117 != 176 && (nint)obj117 != 177 && (nint)obj117 != 178 && (nint)obj117 != 179 && (nint)obj117 != 180 && (nint)obj117 != 181 && (nint)obj117 != 182 && (nint)obj117 != 183 && (nint)obj117 != 184 && (nint)obj117 != 185 && (nint)obj117 != 186 && (nint)obj117 != 187 && (nint)obj117 != 188 && (nint)obj117 != 189 && (nint)obj117 != 190 && (nint)obj117 != 191 && (nint)obj117 != 192 && (nint)obj117 != 193 && (nint)obj117 != 194 && (nint)obj117 != 195 && (nint)obj117 != 196 && (nint)obj117 != 197 && (nint)obj117 != 198 && (nint)obj117 != 199 && (nint)obj117 != 200 && (nint)obj117 != 201 && (nint)obj117 != 202 && (nint)obj117 != 203)
																																																							{
																																																								if ((nint)obj117 != 204)
																																																								{
																																																									if ((nint)obj117 != 205 && (nint)obj117 != 206)
																																																									{
																																																										if ((nint)obj117 != 207)
																																																										{
																																																											if ((nint)obj117 != 208)
																																																											{
																																																												if ((nint)obj117 != 209)
																																																												{
																																																													if ((nint)obj117 != 210 && (nint)obj117 != 211 && (nint)obj117 != 212 && (nint)obj117 != 213)
																																																													{
																																																														if ((nint)obj117 != 214)
																																																														{
																																																															if ((nint)obj117 != 215 && (nint)obj117 != 216 && (nint)obj117 != 217 && (nint)obj117 != 218 && (nint)obj117 != 219)
																																																															{
																																																																if ((nint)obj117 != 220)
																																																																{
																																																																	if ((nint)obj117 != 221 && (nint)obj117 != 222 && (nint)obj117 != 223 && (nint)obj117 != 224 && (nint)obj117 != 225)
																																																																	{
																																																																		if ((nint)obj117 != 226)
																																																																		{
																																																																			if ((nint)obj117 != 227 && (nint)obj117 != 228)
																																																																			{
																																																																				if ((nint)obj117 != 229)
																																																																				{
																																																																					if ((nint)obj117 != 230 && (nint)obj117 != 231 && (nint)obj117 != 232 && (nint)obj117 != 233 && (nint)obj117 != 234 && (nint)obj117 != 235 && (nint)obj117 != 236 && (nint)obj117 != 237 && (nint)obj117 != 238)
																																																																					{
																																																																						if ((nint)obj117 != 239)
																																																																						{
																																																																							if ((nint)obj117 != 240 && (nint)obj117 != 241 && (nint)obj117 != 242 && (nint)obj117 != 243 && (nint)obj117 != 244)
																																																																							{
																																																																								if ((nint)obj117 != 245)
																																																																								{
																																																																									if ((nint)obj117 != 246)
																																																																									{
																																																																										if ((nint)obj117 != 247 && (nint)obj117 != 248 && (nint)obj117 != 249 && (nint)obj117 != 250 && (nint)obj117 != 251 && (nint)obj117 != 252)
																																																																										{
																																																																											if ((nint)obj117 != 253)
																																																																											{
																																																																												if ((nint)obj117 != 254 && (nint)obj117 != 255 && (nint)obj117 != 256)
																																																																												{
																																																																													if ((nint)obj117 != 257)
																																																																													{
																																																																														if ((nint)obj117 != 258 && (nint)obj117 != 259 && (nint)obj117 != 260 && (nint)obj117 != 261)
																																																																														{
																																																																															if ((nint)obj117 != 262)
																																																																															{
																																																																																if ((nint)obj117 != 263 && (nint)obj117 != 264 && (nint)obj117 != 265)
																																																																																{
																																																																																	if ((nint)obj117 != 266)
																																																																																	{
																																																																																		if ((nint)obj117 != 267)
																																																																																		{
																																																																																			if ((nint)obj117 != 268 && (nint)obj117 != 269 && (nint)obj117 != 270 && (nint)obj117 != 271 && (nint)obj117 != 272 && (nint)obj117 != 273 && (nint)obj117 != 274 && (nint)obj117 != 275 && (nint)obj117 != 276 && (nint)obj117 != 277 && (nint)obj117 != 278 && (nint)obj117 != 279 && (nint)obj117 != 280 && (nint)obj117 != 281 && (nint)obj117 != 282 && (nint)obj117 != 283 && (nint)obj117 != 284 && (nint)obj117 != 285 && (nint)obj117 != 286 && (nint)obj117 != 287 && (nint)obj117 != 288 && (nint)obj117 != 289 && (nint)obj117 != 290 && (nint)obj117 != 291 && (nint)obj117 != 292)
																																																																																			{
																																																																																				if ((nint)obj117 != 293)
																																																																																				{
																																																																																					if ((nint)obj117 != 294 && (nint)obj117 != 295)
																																																																																					{
																																																																																						if ((nint)obj117 != 296)
																																																																																						{
																																																																																							if ((nint)obj117 != 297)
																																																																																							{
																																																																																								if ((nint)obj117 != 298)
																																																																																								{
																																																																																									if ((nint)obj117 != 299 && (nint)obj117 != 300 && (nint)obj117 != 301 && (nint)obj117 != 302)
																																																																																									{
																																																																																										if ((nint)obj117 != 303)
																																																																																										{
																																																																																											if ((nint)obj117 != 304 && (nint)obj117 != 305 && (nint)obj117 != 306 && (nint)obj117 != 307 && (nint)obj117 != 308)
																																																																																											{
																																																																																												if ((nint)obj117 != 309)
																																																																																												{
																																																																																													if ((nint)obj117 != 310 && (nint)obj117 != 311 && (nint)obj117 != 312 && (nint)obj117 != 313 && (nint)obj117 != 314)
																																																																																													{
																																																																																														if ((nint)obj117 != 315)
																																																																																														{
																																																																																															if ((nint)obj117 != 316 && (nint)obj117 != 317)
																																																																																															{
																																																																																																if ((nint)obj117 != 318)
																																																																																																{
																																																																																																	if ((nint)obj117 != 319 && (nint)obj117 != 320 && (nint)obj117 != 321)
																																																																																																	{
																																																																																																		if ((nint)obj117 != 322)
																																																																																																		{
																																																																																																			if ((nint)obj117 != 323 && (nint)obj117 != 324 && (nint)obj117 != 325 && (nint)obj117 != 326 && (nint)obj117 != 327 && (nint)obj117 != 328)
																																																																																																			{
																																																																																																				if ((nint)obj117 != 329)
																																																																																																				{
																																																																																																					if ((nint)obj117 != 330 && (nint)obj117 != 331 && (nint)obj117 != 332 && (nint)obj117 != 333)
																																																																																																					{
																																																																																																						if ((nint)obj117 != 334)
																																																																																																						{
																																																																																																							if ((nint)obj117 != 335 && (nint)obj117 != 336 && (nint)obj117 != 337 && (nint)obj117 != 338 && (nint)obj117 != 339 && (nint)obj117 != 340)
																																																																																																							{
																																																																																																								if ((nint)obj117 != 341)
																																																																																																								{
																																																																																																									if ((nint)obj117 != 342 && (nint)obj117 != 343 && (nint)obj117 == 344)
																																																																																																									{
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																																										obj84 = obj82;
																																																																																																										object obj118 = default;
																																																																																																										obj85 = obj118;
																																																																																																										obj60 = 356;
																																																																																																									}
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																																									obj84 = obj82;
																																																																																																									object obj119 = default;
																																																																																																									obj85 = obj119;
																																																																																																									obj60 = 356;
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																																							obj84 = obj82;
																																																																																																							object obj120 = default;
																																																																																																							obj85 = obj120;
																																																																																																							obj60 = 356;
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																																					obj84 = obj82;
																																																																																																					object obj121 = default;
																																																																																																					obj85 = obj121;
																																																																																																					obj60 = 356;
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																																			obj84 = obj82;
																																																																																																			object obj122 = default;
																																																																																																			obj85 = obj122;
																																																																																																			obj60 = 356;
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																																	obj84 = obj82;
																																																																																																	object obj123 = default;
																																																																																																	obj85 = obj123;
																																																																																																	obj60 = 356;
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																															obj84 = obj82;
																																																																																															object obj124 = default;
																																																																																															obj85 = obj124;
																																																																																															obj60 = 356;
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																													obj84 = obj82;
																																																																																													object obj125 = default;
																																																																																													obj85 = obj125;
																																																																																													obj60 = 356;
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																											obj84 = obj82;
																																																																																											object obj126 = default;
																																																																																											obj85 = obj126;
																																																																																											obj60 = 356;
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																									obj84 = obj82;
																																																																																									object obj127 = default;
																																																																																									obj85 = obj127;
																																																																																									obj60 = 356;
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																							obj84 = obj82;
																																																																																							object obj128 = default;
																																																																																							obj85 = obj128;
																																																																																							obj60 = 356;
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																					obj84 = obj82;
																																																																																					object obj129 = default;
																																																																																					obj85 = obj129;
																																																																																					obj60 = 356;
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																			obj84 = obj82;
																																																																																			object obj130 = default;
																																																																																			obj85 = obj130;
																																																																																			obj60 = 356;
																																																																																		}
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																		obj84 = obj82;
																																																																																		object obj131 = default;
																																																																																		obj85 = obj131;
																																																																																		obj60 = 356;
																																																																																	}
																																																																																}
																																																																															}
																																																																															else
																																																																															{
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																																obj84 = obj82;
																																																																																object obj132 = default;
																																																																																obj85 = obj132;
																																																																																obj60 = 356;
																																																																															}
																																																																														}
																																																																													}
																																																																													else
																																																																													{
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																														obj84 = obj82;
																																																																														object obj133 = default;
																																																																														obj85 = obj133;
																																																																														obj60 = 356;
																																																																													}
																																																																												}
																																																																											}
																																																																											else
																																																																											{
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																												obj84 = obj82;
																																																																												object obj134 = default;
																																																																												obj85 = obj134;
																																																																												obj60 = 356;
																																																																											}
																																																																										}
																																																																									}
																																																																									else
																																																																									{
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																										obj84 = obj82;
																																																																										object obj135 = default;
																																																																										obj85 = obj135;
																																																																										obj60 = 356;
																																																																									}
																																																																								}
																																																																								else
																																																																								{
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																									obj84 = obj82;
																																																																									object obj136 = default;
																																																																									obj85 = obj136;
																																																																									obj60 = 356;
																																																																								}
																																																																							}
																																																																						}
																																																																						else
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																							obj84 = obj82;
																																																																							object obj137 = default;
																																																																							obj85 = obj137;
																																																																							obj60 = 356;
																																																																						}
																																																																					}
																																																																				}
																																																																				else
																																																																				{
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																					obj84 = obj82;
																																																																					object obj138 = default;
																																																																					obj85 = obj138;
																																																																					obj60 = 356;
																																																																				}
																																																																			}
																																																																		}
																																																																		else
																																																																		{
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																			obj84 = obj82;
																																																																			object obj139 = default;
																																																																			obj85 = obj139;
																																																																			obj60 = 356;
																																																																		}
																																																																	}
																																																																}
																																																																else
																																																																{
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																																	obj84 = obj82;
																																																																	object obj140 = default;
																																																																	obj85 = obj140;
																																																																	obj60 = 356;
																																																																}
																																																															}
																																																														}
																																																														else
																																																														{
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																															obj84 = obj82;
																																																															object obj141 = default;
																																																															obj85 = obj141;
																																																															obj60 = 356;
																																																														}
																																																													}
																																																												}
																																																												else
																																																												{
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																													obj84 = obj82;
																																																													object obj142 = default;
																																																													obj85 = obj142;
																																																													obj60 = 356;
																																																												}
																																																											}
																																																										}
																																																										else
																																																										{
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																											obj84 = obj82;
																																																											object obj143 = default;
																																																											obj85 = obj143;
																																																											obj60 = 356;
																																																										}
																																																									}
																																																								}
																																																								else
																																																								{
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																									obj84 = obj82;
																																																									object obj144 = default;
																																																									obj85 = obj144;
																																																									obj60 = 356;
																																																								}
																																																							}
																																																						}
																																																						else
																																																						{
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																							obj84 = obj82;
																																																							object obj145 = default;
																																																							obj85 = obj145;
																																																							obj60 = 356;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																						obj84 = obj82;
																																																						object obj146 = default;
																																																						obj85 = obj146;
																																																						obj60 = 356;
																																																					}
																																																				}
																																																			}
																																																			else
																																																			{
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																				obj84 = obj82;
																																																				object obj147 = default;
																																																				obj85 = obj147;
																																																				obj60 = 356;
																																																			}
																																																		}
																																																	}
																																																	else
																																																	{
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																		obj84 = obj82;
																																																		object obj148 = default;
																																																		obj85 = obj148;
																																																		obj60 = 356;
																																																	}
																																																}
																																																else
																																																{
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																	obj84 = obj82;
																																																	object obj149 = default;
																																																	obj85 = obj149;
																																																	obj60 = 356;
																																																}
																																															}
																																															else
																																															{
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																obj84 = obj82;
																																																object obj150 = default;
																																																obj85 = obj150;
																																																obj60 = 356;
																																															}
																																														}
																																													}
																																													else
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																														obj84 = obj82;
																																														object obj151 = default;
																																														obj85 = obj151;
																																														obj60 = 356;
																																													}
																																												}
																																											}
																																											else
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																												obj84 = obj82;
																																												object obj152 = default;
																																												obj85 = obj152;
																																												obj60 = 356;
																																											}
																																										}
																																										else
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																											obj84 = obj82;
																																											object obj153 = default;
																																											obj85 = obj153;
																																											obj60 = 356;
																																										}
																																									}
																																									else
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																										obj84 = obj82;
																																										object obj154 = default;
																																										obj85 = obj154;
																																										obj60 = 356;
																																									}
																																								}
																																							}
																																							else
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																								obj84 = obj82;
																																								object obj155 = default;
																																								obj85 = obj155;
																																								obj60 = 356;
																																							}
																																						}
																																					}
																																					else
																																					{
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																						obj84 = obj82;
																																						object obj156 = default;
																																						obj85 = obj156;
																																						obj60 = 356;
																																					}
																																				}
																																				else
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																					obj84 = obj82;
																																					object obj157 = default;
																																					obj85 = obj157;
																																					obj60 = 356;
																																				}
																																			}
																																			else
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																				obj84 = obj82;
																																				object obj158 = default;
																																				obj85 = obj158;
																																				obj60 = 356;
																																			}
																																		}
																																	}
																																	else
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																		obj84 = obj82;
																																		object obj159 = default;
																																		obj85 = obj159;
																																		obj60 = 356;
																																	}
																																}
																															}
																															else
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																obj84 = obj82;
																																object obj160 = default;
																																obj85 = obj160;
																																obj60 = 356;
																															}
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																															obj84 = obj82;
																															object obj161 = default;
																															obj85 = obj161;
																															obj60 = 356;
																														}
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																													obj84 = obj82;
																													object obj162 = default;
																													obj85 = obj162;
																													obj60 = 356;
																												}
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																											obj84 = obj82;
																											object obj163 = default;
																											obj85 = obj163;
																											obj60 = 356;
																										}
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																									obj84 = obj82;
																									object obj164 = default;
																									obj85 = obj164;
																									obj60 = 356;
																								}
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																							obj84 = obj82;
																							object obj165 = default;
																							obj85 = obj165;
																							obj60 = 356;
																						}
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																					obj84 = obj82;
																					object obj166 = default;
																					obj85 = obj166;
																					obj60 = 356;
																				}
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			obj84 = obj82;
																			object obj167 = default;
																			obj85 = obj167;
																			obj60 = 356;
																		}
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj84 = obj82;
																	object obj168 = default;
																	obj85 = obj168;
																	obj60 = 356;
																}
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															obj84 = obj82;
															object obj169 = default;
															obj85 = obj169;
															obj60 = 356;
														}
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													obj84 = obj82;
													object obj170 = default;
													obj85 = obj170;
													obj60 = 356;
												}
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											obj84 = obj82;
											object obj171 = default;
											obj85 = obj171;
											obj60 = 356;
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									obj84 = obj82;
									object obj172 = default;
									obj85 = obj172;
									obj60 = 356;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj84 = obj82;
							object obj173 = default;
							obj85 = obj173;
							obj60 = 356;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj84 = obj82;
					object obj174 = default;
					obj85 = obj174;
					obj60 = 356;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj84 = obj82;
			object obj175 = default;
			obj85 = obj175;
			obj60 = 356;
		}
		if ((nint)obj60 == 356)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj176 = default;
			if (obj84 == obj176)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj178 = default;
				object obj177 = obj178;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj180 = default;
				object obj179 = obj180;
			}
			else
			{
				object obj179 = obj85;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		nint num79 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ S0_v53 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj181 = (nint)0 & (nint)0x200;
		if (obj181 != null)
		{
			nint num80 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ S0_v59 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	public PlayerPrefsMigrator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05a7: Expected Obj, but got I4
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_05d1: Expected I, but got Obj
		//IL_05e7: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v201 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IDictionary<string, object> dictionary = PlayerInfoMigrator.LoadAdSystemDataFile();
		if (this == null)
		{
			return;
		}
		if (!Directory.IsRootDirectory((string)(object)dictionary))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal((string)(object)dictionary);
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v31 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v195 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = PlayerInfoMigrator.MigrateSyboAnalyticsSave((Dictionary<Key, string>)dictionary);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder sb = default;
		System.Text.StringBuilderCache.Release(sb);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 141;
		object obj12 = 0;
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 141)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_06cd;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_06cd;
		IL_06cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
		string text = ((KilooSerializer)this).ToJson((object)null);
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32");
	}

	static PlayerPrefsMigrator()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasPurchasedOrRestored = UserSave.hasPurchasedOrRestored;
		object obj2 = 0;
		while ((nint)obj2 < (hasPurchasedOrRestored ? 1 : 0))
		{
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
	}
}
