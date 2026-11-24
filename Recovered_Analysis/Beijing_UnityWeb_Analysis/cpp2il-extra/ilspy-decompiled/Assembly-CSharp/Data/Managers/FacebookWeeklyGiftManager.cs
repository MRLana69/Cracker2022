using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Data.Save;
using Data.Save.Internal;
using Info;
using SYBO.Subway.Info;

namespace Data.Managers;

public static class FacebookWeeklyGiftManager
{
	public static void GiftWasClaimed()
	{
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = default;
		CultureInfo.CheckDomainSafetyObject(obj, (object)"da-DK");
		CharacterManager.DATETIME_CULTUREINFO = (CultureInfo)obj;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = 0;
	}

	private static DateTime GetNextUnlockTime()
	{
		//IL_001b: Expected VT, but got I
		LocalDebugData localDebug = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1D8]");
		return (DateTime)0;
	}

	private static DateTime GetNextWeekday(DateTime startDate, DayOfWeek weekday)
	{
		//IL_0010: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return (DateTime)0;
	}

	public static bool IsGiftAvailable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected Obj, but got Unknown
		//IL_0b99: Expected Obj, but got I4
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected Obj, but got Unknown
		//IL_0bdc: Expected I, but got Obj
		//IL_0bf2: Expected Obj, but got I
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected Obj, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_0179: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_02ee: Expected I, but got Obj
		//IL_0304: Expected Obj, but got I
		//IL_0231: Expected I, but got Obj
		//IL_0247: Expected Obj, but got I
		//IL_032f: Expected I, but got Obj
		//IL_0cfa: Expected I4, but got Obj
		//IL_0ad8: Expected Obj, but got I
		//IL_0c99: Expected Obj, but got I4
		//IL_0272: Expected I, but got Obj
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_03e5: Expected I, but got Obj
		//IL_03fb: Expected Obj, but got I
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected Obj, but got Unknown
		//IL_0426: Expected I, but got Obj
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected Obj, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected Obj, but got Unknown
		//IL_0a50: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> list = default;
		list._002Ector();
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v208 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28+8]");
		_ = 0;
		object obj8 = default;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v89 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v196 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v104 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v187 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 == null)
			{
				nint num7 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v171 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num8 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v178 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj13 == null)
				{
					continue;
				}
			}
			nint num9 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v117 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num10 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v162 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v100+14]");
				if ((nint)0 == 7)
				{
					nint num11 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v146 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num12 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v154 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj17 == null)
					{
						continue;
					}
				}
			}
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj6 = obj2;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj18 = 54;
		object obj19 = obj18 - 12;
		if ((nint)obj18 != 12)
		{
			if ((nint)obj19 != 1 && (nint)obj19 != 2 && (nint)obj19 != 3 && (nint)obj19 != 4)
			{
				if ((nint)obj19 == 5 || (nint)obj19 == 6)
				{
					goto IL_0a55;
				}
				if ((nint)obj19 != 7 && (nint)obj19 != 8)
				{
					if ((nint)obj19 == 9)
					{
						goto IL_0a55;
					}
					if ((nint)obj19 != 10 && (nint)obj19 != 11 && (nint)obj19 != 12)
					{
						if ((nint)obj19 == 13)
						{
							goto IL_0a55;
						}
						if ((nint)obj19 != 14 && (nint)obj19 != 15)
						{
							if ((nint)obj19 == 16)
							{
								goto IL_0a55;
							}
							if ((nint)obj19 != 17 && (nint)obj19 != 18 && (nint)obj19 != 19)
							{
								if ((nint)obj19 == 20)
								{
									goto IL_0a55;
								}
								if ((nint)obj19 != 21 && (nint)obj19 != 22)
								{
									if ((nint)obj19 == 23)
									{
										goto IL_0a55;
									}
									if ((nint)obj19 != 24 && (nint)obj19 != 25 && (nint)obj19 != 26 && (nint)obj19 != 27)
									{
										if ((nint)obj19 == 28)
										{
											goto IL_0a55;
										}
										if ((nint)obj19 != 29 && (nint)obj19 != 30)
										{
											if ((nint)obj19 == 31)
											{
												goto IL_0a55;
											}
											if ((nint)obj19 != 32 && (nint)obj19 != 33 && (nint)obj19 != 34 && (nint)obj19 != 35 && (nint)obj19 != 36 && (nint)obj19 != 37)
											{
												if ((nint)obj19 == 38 || (nint)obj19 == 39)
												{
													goto IL_0a55;
												}
												if ((nint)obj19 != 40 && (nint)obj19 != 41 && (nint)obj19 == 42)
												{
													object obj20 = obj4 + 4;
													object obj21 = obj20 + 1;
													obj20 = obj21;
													object obj22 = obj21 << 2;
													object obj23 = obj4 + obj22;
													obj23 = 117;
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
			goto IL_0cd0;
		}
		goto IL_0a55;
		IL_0cf5:
		return (byte)(int)list != 0;
		IL_0a55:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj24 = default;
		object obj25 = default;
		if (obj24 == obj25)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0cd0;
		IL_0cd0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj26 = (nint)0 << 2;
			object obj27 = obj4 + obj26;
			if ((nint)obj27 == 117)
			{
				object obj28 = obj4 + 4;
				if ((nint)obj28 > -1)
				{
					object obj29 = obj28 + -1;
					obj28 = obj29;
				}
				goto IL_0cf5;
			}
		}
		object obj30 = default;
		if (obj30 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0cf5;
	}
}
