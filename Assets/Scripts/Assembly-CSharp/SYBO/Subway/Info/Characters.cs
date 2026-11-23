using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;

namespace SYBO.Subway.Info;

public class Characters
{
	public enum CharacterType
	{
		slick,
		tricky,
		fresh,
		spike,
		yutani,
		frank,
		frizzy,
		king,
		lucy,
		ninja,
		tag,
		tasha,
		zoe,
		brody,
		princek,
		zombiejake,
		elftricky,
		tony,
		carmen,
		roberto,
		kim,
		harumi,
		nick,
		coco,
		monkeyking,
		moscowCharacter01,
		halloweenCharacter01,
		londonCharacter01,
		mumbaiCharacter01,
		seoulCharacter01,
		mexicoCharacter01,
		vancouverCharacter01,
		saopauloCharacter01,
		losangelesCharacter01,
		cairoCharacter01,
		bangkokCharacter01,
		facebookRewardCharacter01,
		londonCharacter02,
		lasVegasCharacter01,
		hawaiiCharacter01,
		arabiaCharacter01,
		veniceCharacter01,
		greeceCharacter01,
		kenyaCharacter01,
		transylvaniaCharacter01,
		sanfranciscoCharacter01,
		pragueCharacter01,
		madagascarCharacter01,
		peruCharacter01,
		singaporeCharacter01,
		icelandCharacter01,
		havanaCharacter01,
		washingtonCharacter01,
		holidayCharacter2016,
		amsterdamCharacter01,
		monacoCharacter01,
		copenhagenCharacter01,
		marrakeshCharacter01,
		shanghaiCharacter01
	}

	public class Model
	{
		public StringID name;

		public string modelName;

		public int Price;

		public PurchaseData.UnlockType unlockType;

		public string tokenName;

		public string tokenSprite2dName;

		public MissionTarget missionTargetKey;

		public StringID characterLimitedDescription;

		public bool isNewInThisUpdate;

		public bool hasOnlineSettings;

		public DateTime defaultExpirationDate;

		public DateTime defaultStartDate;

		public bool overrideDynamicIapIdAndroid;

		public bool overrideDynamicIapIdiOS;

		public bool overrideDynamicIapIdKindle;

		public bool overrideDynamicIapIdWSA;

		public string dynamicIapId;
	}

	public static List<CharacterType> GM_Character;

	public const string ONLINE_SETTINGS_CHARACTER_PREFIX_EXPIRE = "character_expiretime_";

	public const string ONLINE_SETTINGS_CHARACTER_PREFIX_START = "character_starttime_";

	public static readonly Dictionary<CharacterType, Model> characterData;

	public static List<CharacterType> characterOrder;

	public static CharacterType? GetCharacterTypeForName(string name)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0495: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_0381: Expected VT, but got I
		//IL_0523: Expected VT, but got I
		//IL_0431: Expected VT, but got I
		//IL_0091: Expected Obj, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0299: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj5 = obj + 56;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj7 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			CharacterType? characterType;
			if ((nint)0 != 1)
			{
				if (obj7 == null)
				{
					goto IL_033c;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					object obj8 = 0;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
									if (obj9 == null)
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
										_ = 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj10 = obj + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CF9");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
											characterType = (CharacterType?)(object)0;
											break;
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 != obj12;
			object obj13 = obj14;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_033c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			return (CharacterType?)(object)0;
			IL_033c:
			object obj17 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CF9");
			object obj18 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			characterType = (CharacterType?)(object)0;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		return (CharacterType?)(object)0;
	}

	unsafe static Characters()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b5: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I
		//IL_049f: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected VT, but got Unknown
		//IL_0539: Expected native int or pointer, but got VT
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected VT, but got Unknown
		//IL_0577: Expected native int or pointer, but got VT
		//IL_05ab: Expected Obj, but got I
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected VT, but got Unknown
		//IL_05fd: Expected native int or pointer, but got VT
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected VT, but got Unknown
		//IL_0636: Expected native int or pointer, but got VT
		//IL_066f: Expected Obj, but got I
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected VT, but got Unknown
		//IL_06bc: Expected native int or pointer, but got VT
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected VT, but got Unknown
		//IL_06fa: Expected native int or pointer, but got VT
		//IL_072e: Expected Obj, but got I
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected VT, but got Unknown
		//IL_0780: Expected native int or pointer, but got VT
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected VT, but got Unknown
		//IL_07b9: Expected native int or pointer, but got VT
		//IL_07f2: Expected Obj, but got I
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected VT, but got Unknown
		//IL_083f: Expected native int or pointer, but got VT
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected VT, but got Unknown
		//IL_087d: Expected native int or pointer, but got VT
		//IL_08b1: Expected Obj, but got I
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected VT, but got Unknown
		//IL_0903: Expected native int or pointer, but got VT
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected VT, but got Unknown
		//IL_093c: Expected native int or pointer, but got VT
		//IL_0975: Expected Obj, but got I
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected VT, but got Unknown
		//IL_09c2: Expected native int or pointer, but got VT
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected VT, but got Unknown
		//IL_0a00: Expected native int or pointer, but got VT
		//IL_0a34: Expected Obj, but got I
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected VT, but got Unknown
		//IL_0a86: Expected native int or pointer, but got VT
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected VT, but got Unknown
		//IL_0abf: Expected native int or pointer, but got VT
		//IL_0af8: Expected Obj, but got I
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected VT, but got Unknown
		//IL_0b45: Expected native int or pointer, but got VT
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected VT, but got Unknown
		//IL_0b83: Expected native int or pointer, but got VT
		//IL_0bb7: Expected Obj, but got I
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected VT, but got Unknown
		//IL_0c09: Expected native int or pointer, but got VT
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected VT, but got Unknown
		//IL_0c42: Expected native int or pointer, but got VT
		//IL_0c7b: Expected Obj, but got I
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Expected VT, but got Unknown
		//IL_0cc8: Expected native int or pointer, but got VT
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected VT, but got Unknown
		//IL_0d06: Expected native int or pointer, but got VT
		//IL_0d3a: Expected Obj, but got I
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected VT, but got Unknown
		//IL_0d8c: Expected native int or pointer, but got VT
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected VT, but got Unknown
		//IL_0dc5: Expected native int or pointer, but got VT
		//IL_0dfe: Expected Obj, but got I
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected VT, but got Unknown
		//IL_0e4b: Expected native int or pointer, but got VT
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected VT, but got Unknown
		//IL_0e89: Expected native int or pointer, but got VT
		//IL_0ebd: Expected Obj, but got I
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected VT, but got Unknown
		//IL_0f0f: Expected native int or pointer, but got VT
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Expected VT, but got Unknown
		//IL_0f48: Expected native int or pointer, but got VT
		//IL_0f81: Expected Obj, but got I
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected VT, but got Unknown
		//IL_0fce: Expected native int or pointer, but got VT
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff9: Expected VT, but got Unknown
		//IL_100c: Expected native int or pointer, but got VT
		//IL_1040: Expected Obj, but got I
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_1087: Expected VT, but got Unknown
		//IL_109a: Expected native int or pointer, but got VT
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected VT, but got Unknown
		//IL_10d3: Expected native int or pointer, but got VT
		//IL_110c: Expected Obj, but got I
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_114e: Expected VT, but got Unknown
		//IL_1161: Expected native int or pointer, but got VT
		//IL_1187: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Expected VT, but got Unknown
		//IL_119f: Expected native int or pointer, but got VT
		//IL_11d3: Expected Obj, but got I
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected VT, but got Unknown
		//IL_122d: Expected native int or pointer, but got VT
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected VT, but got Unknown
		//IL_1266: Expected native int or pointer, but got VT
		//IL_129f: Expected Obj, but got I
		//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e1: Expected VT, but got Unknown
		//IL_12f4: Expected native int or pointer, but got VT
		//IL_131a: Unknown result type (might be due to invalid IL or missing references)
		//IL_131f: Expected VT, but got Unknown
		//IL_1332: Expected native int or pointer, but got VT
		//IL_1366: Expected Obj, but got I
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected VT, but got Unknown
		//IL_13c0: Expected native int or pointer, but got VT
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e6: Expected VT, but got Unknown
		//IL_13f9: Expected native int or pointer, but got VT
		//IL_1432: Expected Obj, but got I
		//IL_146f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1474: Expected VT, but got Unknown
		//IL_1487: Expected native int or pointer, but got VT
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Expected VT, but got Unknown
		//IL_14c5: Expected native int or pointer, but got VT
		//IL_14f9: Expected Obj, but got I
		//IL_154e: Expected Obj, but got I
		//IL_158b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Expected VT, but got Unknown
		//IL_15a3: Expected native int or pointer, but got VT
		//IL_15c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ce: Expected VT, but got Unknown
		//IL_15e1: Expected native int or pointer, but got VT
		//IL_1615: Expected Obj, but got I
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_165c: Expected VT, but got Unknown
		//IL_166f: Expected native int or pointer, but got VT
		//IL_1690: Unknown result type (might be due to invalid IL or missing references)
		//IL_1695: Expected VT, but got Unknown
		//IL_16a8: Expected native int or pointer, but got VT
		//IL_16e1: Expected Obj, but got I
		//IL_171e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1723: Expected VT, but got Unknown
		//IL_1736: Expected native int or pointer, but got VT
		//IL_175c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Expected VT, but got Unknown
		//IL_1774: Expected native int or pointer, but got VT
		//IL_17a8: Expected Obj, but got I
		//IL_17ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Expected VT, but got Unknown
		//IL_1802: Expected native int or pointer, but got VT
		//IL_1823: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Expected VT, but got Unknown
		//IL_183b: Expected native int or pointer, but got VT
		//IL_1874: Expected Obj, but got I
		//IL_18b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b6: Expected VT, but got Unknown
		//IL_18c9: Expected native int or pointer, but got VT
		//IL_18ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f4: Expected VT, but got Unknown
		//IL_1907: Expected native int or pointer, but got VT
		//IL_193b: Expected Obj, but got I
		//IL_197d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1982: Expected VT, but got Unknown
		//IL_1995: Expected native int or pointer, but got VT
		//IL_19b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bb: Expected VT, but got Unknown
		//IL_19ce: Expected native int or pointer, but got VT
		//IL_1a07: Expected Obj, but got I
		//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a49: Expected VT, but got Unknown
		//IL_1a5c: Expected native int or pointer, but got VT
		//IL_1a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a87: Expected VT, but got Unknown
		//IL_1a9a: Expected native int or pointer, but got VT
		//IL_1ace: Expected Obj, but got I
		//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b15: Expected VT, but got Unknown
		//IL_1b28: Expected native int or pointer, but got VT
		//IL_1b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4e: Expected VT, but got Unknown
		//IL_1b61: Expected native int or pointer, but got VT
		//IL_1b9a: Expected Obj, but got I
		//IL_1bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdc: Expected VT, but got Unknown
		//IL_1bef: Expected native int or pointer, but got VT
		//IL_1c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1a: Expected VT, but got Unknown
		//IL_1c2d: Expected native int or pointer, but got VT
		//IL_1c61: Expected Obj, but got I
		//IL_1ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca8: Expected VT, but got Unknown
		//IL_1cbb: Expected native int or pointer, but got VT
		//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce1: Expected VT, but got Unknown
		//IL_1cf4: Expected native int or pointer, but got VT
		//IL_1d2d: Expected Obj, but got I
		//IL_1d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6f: Expected VT, but got Unknown
		//IL_1d82: Expected native int or pointer, but got VT
		//IL_1da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dad: Expected VT, but got Unknown
		//IL_1dc0: Expected native int or pointer, but got VT
		//IL_1df4: Expected Obj, but got I
		//IL_1e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3b: Expected VT, but got Unknown
		//IL_1e4e: Expected native int or pointer, but got VT
		//IL_1e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e74: Expected VT, but got Unknown
		//IL_1e87: Expected native int or pointer, but got VT
		//IL_1ec0: Expected Obj, but got I
		//IL_1efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f02: Expected VT, but got Unknown
		//IL_1f15: Expected native int or pointer, but got VT
		//IL_1f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f40: Expected VT, but got Unknown
		//IL_1f53: Expected native int or pointer, but got VT
		//IL_1f87: Expected Obj, but got I
		//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fce: Expected VT, but got Unknown
		//IL_1fe1: Expected native int or pointer, but got VT
		//IL_2002: Unknown result type (might be due to invalid IL or missing references)
		//IL_2007: Expected VT, but got Unknown
		//IL_201a: Expected native int or pointer, but got VT
		//IL_2053: Expected Obj, but got I
		//IL_2090: Unknown result type (might be due to invalid IL or missing references)
		//IL_2095: Expected VT, but got Unknown
		//IL_20a8: Expected native int or pointer, but got VT
		//IL_20ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d3: Expected VT, but got Unknown
		//IL_20e6: Expected native int or pointer, but got VT
		//IL_211a: Expected Obj, but got I
		//IL_215c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2161: Expected VT, but got Unknown
		//IL_2174: Expected native int or pointer, but got VT
		//IL_2195: Unknown result type (might be due to invalid IL or missing references)
		//IL_219a: Expected VT, but got Unknown
		//IL_21ad: Expected native int or pointer, but got VT
		//IL_21e6: Expected Obj, but got I
		//IL_2223: Unknown result type (might be due to invalid IL or missing references)
		//IL_2228: Expected VT, but got Unknown
		//IL_223b: Expected native int or pointer, but got VT
		//IL_2261: Unknown result type (might be due to invalid IL or missing references)
		//IL_2266: Expected VT, but got Unknown
		//IL_2279: Expected native int or pointer, but got VT
		//IL_22ad: Expected Obj, but got I
		//IL_22ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f4: Expected VT, but got Unknown
		//IL_2307: Expected native int or pointer, but got VT
		//IL_2328: Unknown result type (might be due to invalid IL or missing references)
		//IL_232d: Expected VT, but got Unknown
		//IL_2340: Expected native int or pointer, but got VT
		//IL_2379: Expected Obj, but got I
		//IL_23b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bb: Expected VT, but got Unknown
		//IL_23ce: Expected native int or pointer, but got VT
		//IL_23f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f9: Expected VT, but got Unknown
		//IL_240c: Expected native int or pointer, but got VT
		//IL_2440: Expected Obj, but got I
		//IL_2482: Unknown result type (might be due to invalid IL or missing references)
		//IL_2487: Expected VT, but got Unknown
		//IL_249a: Expected native int or pointer, but got VT
		//IL_24bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c0: Expected VT, but got Unknown
		//IL_24d3: Expected native int or pointer, but got VT
		//IL_250c: Expected Obj, but got I
		//IL_2549: Unknown result type (might be due to invalid IL or missing references)
		//IL_254e: Expected VT, but got Unknown
		//IL_2561: Expected native int or pointer, but got VT
		//IL_2587: Unknown result type (might be due to invalid IL or missing references)
		//IL_258c: Expected VT, but got Unknown
		//IL_259f: Expected native int or pointer, but got VT
		//IL_25d3: Expected Obj, but got I
		//IL_2615: Unknown result type (might be due to invalid IL or missing references)
		//IL_261a: Expected VT, but got Unknown
		//IL_262d: Expected native int or pointer, but got VT
		//IL_264d: Expected I8, but got I4
		//IL_2648: Expected native int or pointer, but got VT
		//IL_2660: Expected native int or pointer, but got VT
		//IL_2696: Expected Obj, but got I
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 688);
		List<CharacterType> list = default;
		list._002Ector();
		list.Add(CharacterType.frizzy);
		list.Add(CharacterType.king);
		list.Add(CharacterType.slick);
		list.Add(CharacterType.lucy);
		list.Add(CharacterType.brody);
		GM_Character = list;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>>)+4] (should have been resolved before IL gen)");
		_ = 339;
		_ = 0;
		_ = 0;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = 340;
		_ = 1;
		_ = 0;
		_ = 3;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ S5_v9+4] (should have been resolved before IL gen)");
		_ = 341;
		_ = 0;
		_ = 4294967346L;
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ S5_v14+4] (should have been resolved before IL gen)");
		_ = 342;
		_ = 1;
		_ = 0;
		_ = 200;
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S5_v19+4] (should have been resolved before IL gen)");
		_ = 343;
		_ = 1;
		_ = 0;
		_ = 54;
		_ = 500;
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v248 @ S5_v24+4] (should have been resolved before IL gen)");
		_ = 344;
		_ = 0;
		_ = 44;
		_ = 8589941592L;
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ S5_v29+4] (should have been resolved before IL gen)");
		_ = 345;
		_ = 0;
		_ = 45;
		_ = 8589954592L;
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ S5_v34+4] (should have been resolved before IL gen)");
		_ = 346;
		_ = 0;
		_ = 46;
		_ = 8589974592L;
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v341 @ S5_v39+4] (should have been resolved before IL gen)");
		_ = 347;
		_ = 0;
		_ = 43;
		_ = 8590014592L;
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ S5_v44+4] (should have been resolved before IL gen)");
		_ = 348;
		_ = 0;
		_ = 47;
		_ = 8590084592L;
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v403 @ S5_v49+4] (should have been resolved before IL gen)");
		_ = 349;
		_ = 0;
		_ = 49;
		_ = 8589946592L;
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v434 @ S5_v54+4] (should have been resolved before IL gen)");
		_ = 350;
		_ = 0;
		_ = 50;
		_ = 8589964592L;
		nint num25 = 0;
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S5_v58 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v465 @ S5_v59+4] (should have been resolved before IL gen)");
		_ = 351;
		_ = 0;
		_ = 51;
		_ = 8590054592L;
		nint num27 = 0;
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S5_v63 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v496 @ S5_v64+4] (should have been resolved before IL gen)");
		_ = 352;
		_ = 0;
		_ = 52;
		_ = 8590284592L;
		nint num29 = 0;
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S5_v68 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ S5_v69+4] (should have been resolved before IL gen)");
		_ = 353;
		_ = 0;
		_ = 53;
		_ = 8590914592L;
		nint num31 = 0;
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S5_v73 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v558 @ S5_v74+4] (should have been resolved before IL gen)");
		_ = 354;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime2 = dateTime + 680;
		*(DateTime*)(nint)dateTime2 = new DateTime(2012, 10, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2A8]");
		_ = 0;
		_ = 0;
		DateTime dateTime3 = dateTime + 672;
		*(DateTime*)(nint)dateTime3 = new DateTime(2012, 9, 18);
		_ = 692;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2A0]");
		_ = 0;
		nint num33 = 0;
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S5_v78 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v617 @ S5_v79+4] (should have been resolved before IL gen)");
		_ = 355;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime4 = dateTime + 664;
		*(DateTime*)(nint)dateTime4 = new DateTime(2016, 12, 29);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+298]");
		_ = 0;
		_ = 0;
		DateTime dateTime5 = dateTime + 656;
		*(DateTime*)(nint)dateTime5 = new DateTime(2016, 10, 31);
		_ = 693;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+290]");
		_ = 0;
		nint num35 = 0;
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S5_v83 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v676 @ S5_v84+4] (should have been resolved before IL gen)");
		_ = 356;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime6 = dateTime + 648;
		*(DateTime*)(nint)dateTime6 = new DateTime(2015, 9, 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+288]");
		_ = 0;
		_ = 0;
		DateTime dateTime7 = dateTime + 640;
		*(DateTime*)(nint)dateTime7 = new DateTime(2015, 8, 14);
		_ = 694;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+280]");
		_ = 0;
		nint num37 = 0;
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S5_v88 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v735 @ S5_v89+4] (should have been resolved before IL gen)");
		_ = 357;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime8 = dateTime + 632;
		*(DateTime*)(nint)dateTime8 = new DateTime(2016, 9, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+278]");
		_ = 0;
		_ = 0;
		DateTime dateTime9 = dateTime + 624;
		*(DateTime*)(nint)dateTime9 = new DateTime(2016, 6, 28);
		_ = 695;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+270]");
		_ = 0;
		nint num39 = 0;
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S5_v93 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v794 @ S5_v94+4] (should have been resolved before IL gen)");
		_ = 358;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime10 = dateTime + 616;
		*(DateTime*)(nint)dateTime10 = new DateTime(2014, 5, 8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+268]");
		_ = 0;
		_ = 0;
		DateTime dateTime11 = dateTime + 608;
		*(DateTime*)(nint)dateTime11 = new DateTime(2014, 3, 20);
		_ = 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+260]");
		_ = 0;
		nint num41 = 0;
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ S5_v98 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v853 @ S5_v99+4] (should have been resolved before IL gen)");
		_ = 359;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime12 = dateTime + 600;
		*(DateTime*)(nint)dateTime12 = new DateTime(2016, 5, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+258]");
		_ = 0;
		_ = 0;
		DateTime dateTime13 = dateTime + 592;
		*(DateTime*)(nint)dateTime13 = new DateTime(2016, 3, 30);
		_ = 697;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+250]");
		_ = 0;
		nint num43 = 0;
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S5_v103 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v912 @ S5_v104+4] (should have been resolved before IL gen)");
		_ = 360;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime14 = dateTime + 584;
		*(DateTime*)(nint)dateTime14 = new DateTime(2015, 12, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+248]");
		_ = 0;
		_ = 0;
		DateTime dateTime15 = dateTime + 576;
		*(DateTime*)(nint)dateTime15 = new DateTime(2015, 10, 13);
		_ = 698;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+240]");
		_ = 0;
		nint num45 = 0;
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S5_v108 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v971 @ S5_v109+4] (should have been resolved before IL gen)");
		_ = 361;
		_ = 257;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime16 = dateTime + 568;
		*(DateTime*)(nint)dateTime16 = new DateTime(2017, 7, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+238]");
		_ = 0;
		_ = 0;
		DateTime dateTime17 = dateTime + 560;
		*(DateTime*)(nint)dateTime17 = new DateTime(2017, 8, 31);
		_ = 373;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+230]");
		_ = 0;
		nint num47 = 0;
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ S5_v113 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1030 @ S5_v114+4] (should have been resolved before IL gen)");
		_ = 362;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime18 = dateTime + 552;
		*(DateTime*)(nint)dateTime18 = new DateTime(2015, 4, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+228]");
		_ = 0;
		_ = 0;
		DateTime dateTime19 = dateTime + 544;
		*(DateTime*)(nint)dateTime19 = new DateTime(2015, 2, 25);
		_ = 374;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+220]");
		_ = 0;
		nint num49 = 0;
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S5_v118 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1089 @ S5_v119+4] (should have been resolved before IL gen)");
		_ = 363;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime20 = dateTime + 536;
		*(DateTime*)(nint)dateTime20 = new DateTime(2014, 9, 18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+218]");
		_ = 0;
		_ = 0;
		DateTime dateTime21 = dateTime + 528;
		*(DateTime*)(nint)dateTime21 = new DateTime(2014, 7, 8);
		_ = 375;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+210]");
		_ = 0;
		nint num51 = 0;
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ S5_v123 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1148 @ S5_v124+4] (should have been resolved before IL gen)");
		_ = 364;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime22 = dateTime + 520;
		*(DateTime*)(nint)dateTime22 = new DateTime(2013, 10, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+208]");
		_ = 0;
		_ = 0;
		DateTime dateTime23 = dateTime + 512;
		*(DateTime*)(nint)dateTime23 = new DateTime(2013, 9, 4);
		_ = 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+200]");
		_ = 0;
		nint num53 = 0;
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ S5_v128 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1207 @ S5_v129+4] (should have been resolved before IL gen)");
		_ = 365;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime24 = dateTime + 504;
		*(DateTime*)(nint)dateTime24 = new DateTime(2014, 11, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1F8]");
		_ = 0;
		_ = 0;
		DateTime dateTime25 = dateTime + 496;
		*(DateTime*)(nint)dateTime25 = new DateTime(2014, 9, 15);
		_ = 377;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1F0]");
		_ = 0;
		nint num55 = 0;
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ S5_v133 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1266 @ S5_v134+4] (should have been resolved before IL gen)");
		_ = 366;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime26 = dateTime + 488;
		*(DateTime*)(nint)dateTime26 = new DateTime(2014, 1, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1E8]");
		_ = 0;
		_ = 0;
		DateTime dateTime27 = dateTime + 480;
		*(DateTime*)(nint)dateTime27 = new DateTime(2013, 11, 5);
		_ = 378;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1E0]");
		_ = 0;
		nint num57 = 0;
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ S5_v138 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1325 @ S5_v139+4] (should have been resolved before IL gen)");
		_ = 369;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime28 = dateTime + 472;
		*(DateTime*)(nint)dateTime28 = new DateTime(2015, 3, 26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1D8]");
		_ = 0;
		_ = 0;
		DateTime dateTime29 = dateTime + 464;
		*(DateTime*)(nint)dateTime29 = new DateTime(2015, 2, 4);
		_ = 380;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1D0]");
		_ = 0;
		nint num59 = 0;
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ S5_v143 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1384 @ S5_v144+4] (should have been resolved before IL gen)");
		_ = 370;
		_ = 256;
		_ = 8590029592L;
		_ = 0;
		DateTime dateTime30 = dateTime + 456;
		*(DateTime*)(nint)dateTime30 = new DateTime(2015, 2, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1C8]");
		_ = 0;
		_ = 0;
		DateTime dateTime31 = dateTime + 448;
		*(DateTime*)(nint)dateTime31 = new DateTime(2014, 12, 16);
		_ = 381;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1C0]");
		_ = 0;
		nint num61 = 0;
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ S5_v148 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1443 @ S5_v149+4] (should have been resolved before IL gen)");
		_ = 371;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime32 = dateTime + 440;
		*(DateTime*)(nint)dateTime32 = new DateTime(2014, 4, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1B8]");
		_ = 0;
		_ = 0;
		DateTime dateTime33 = dateTime + 432;
		*(DateTime*)(nint)dateTime33 = new DateTime(2014, 3, 19);
		_ = 382;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1B0]");
		_ = 0;
		nint num63 = 0;
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ S5_v153 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1506 @ S5_v154+4] (should have been resolved before IL gen)");
		_ = 372;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime34 = dateTime + 424;
		*(DateTime*)(nint)dateTime34 = new DateTime(2014, 5, 28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1A8]");
		_ = 0;
		_ = 0;
		DateTime dateTime35 = dateTime + 416;
		*(DateTime*)(nint)dateTime35 = new DateTime(2014, 4, 1);
		_ = 383;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1A0]");
		_ = 0;
		nint num65 = 0;
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ S5_v158 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1569 @ S5_v159+4] (should have been resolved before IL gen)");
		_ = 1025;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime36 = dateTime + 408;
		*(DateTime*)(nint)dateTime36 = new DateTime(2014, 7, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+198]");
		_ = 0;
		_ = 0;
		DateTime dateTime37 = dateTime + 400;
		*(DateTime*)(nint)dateTime37 = new DateTime(2014, 5, 2);
		_ = 1026;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+190]");
		_ = 0;
		nint num67 = 0;
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ S5_v163 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1629 @ S5_v164+4] (should have been resolved before IL gen)");
		_ = 1027;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime38 = dateTime + 392;
		*(DateTime*)(nint)dateTime38 = new DateTime(2015, 6, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+188]");
		_ = 0;
		_ = 0;
		DateTime dateTime39 = dateTime + 384;
		*(DateTime*)(nint)dateTime39 = new DateTime(2015, 4, 21);
		_ = 1028;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+180]");
		_ = 0;
		nint num69 = 0;
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ S5_v168 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1689 @ S5_v169+4] (should have been resolved before IL gen)");
		_ = 1128;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime40 = dateTime + 376;
		*(DateTime*)(nint)dateTime40 = new DateTime(2014, 10, 9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+178]");
		_ = 0;
		_ = 0;
		DateTime dateTime41 = dateTime + 368;
		*(DateTime*)(nint)dateTime41 = new DateTime(2014, 8, 7);
		_ = 1129;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+170]");
		_ = 0;
		nint num71 = 0;
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1748 @ S5_v173 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1749 @ S5_v174+4] (should have been resolved before IL gen)");
		_ = 1130;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime42 = dateTime + 360;
		*(DateTime*)(nint)dateTime42 = new DateTime(2017, 3, 30);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+168]");
		_ = 0;
		_ = 0;
		DateTime dateTime43 = dateTime + 352;
		*(DateTime*)(nint)dateTime43 = new DateTime(2017, 2, 8);
		_ = 1131;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+160]");
		_ = 0;
		nint num73 = 0;
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ S5_v178 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1809 @ S5_v179+4] (should have been resolved before IL gen)");
		_ = 1167;
		_ = 0;
		_ = 0;
		_ = 1;
		_ = 7;
		_ = 1168;
		nint num75 = 0;
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1842 @ S5_v183 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1843 @ S5_v184+4] (should have been resolved before IL gen)");
		_ = 367;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime44 = dateTime + 344;
		*(DateTime*)(nint)dateTime44 = new DateTime(2015, 12, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+158]");
		_ = 0;
		_ = 0;
		DateTime dateTime45 = dateTime + 336;
		*(DateTime*)(nint)dateTime45 = new DateTime(2015, 11, 4);
		_ = 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+150]");
		_ = 0;
		nint num77 = 0;
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ S5_v188 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1903 @ S5_v189+4] (should have been resolved before IL gen)");
		_ = 368;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime46 = dateTime + 328;
		*(DateTime*)(nint)dateTime46 = new DateTime(2016, 6, 23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+148]");
		_ = 0;
		_ = 0;
		DateTime dateTime47 = dateTime + 320;
		*(DateTime*)(nint)dateTime47 = new DateTime(2016, 4, 5);
		_ = 379;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+140]");
		_ = 0;
		nint num79 = 0;
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1962 @ S5_v193 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1963 @ S5_v194+4] (should have been resolved before IL gen)");
		_ = 1219;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime48 = dateTime + 312;
		*(DateTime*)(nint)dateTime48 = new DateTime(2017, 5, 11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+138]");
		_ = 0;
		_ = 0;
		DateTime dateTime49 = dateTime + 304;
		*(DateTime*)(nint)dateTime49 = new DateTime(2017, 3, 29);
		_ = 1220;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+130]");
		_ = 0;
		nint num81 = 0;
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ S5_v198 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2023 @ S5_v199+4] (should have been resolved before IL gen)");
		_ = 1246;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime50 = dateTime + 296;
		*(DateTime*)(nint)dateTime50 = new DateTime(2017, 1, 5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+128]");
		_ = 0;
		_ = 0;
		DateTime dateTime51 = dateTime + 288;
		*(DateTime*)(nint)dateTime51 = new DateTime(2017, 3, 2);
		_ = 1247;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+120]");
		_ = 0;
		nint num83 = 0;
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2082 @ S5_v203 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2083 @ S5_v204+4] (should have been resolved before IL gen)");
		_ = 1270;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime52 = dateTime + 280;
		*(DateTime*)(nint)dateTime52 = new DateTime(2016, 8, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+118]");
		_ = 0;
		_ = 0;
		DateTime dateTime53 = dateTime + 272;
		*(DateTime*)(nint)dateTime53 = new DateTime(2015, 5, 7);
		_ = 1271;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+110]");
		_ = 0;
		nint num85 = 0;
		nint num86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2142 @ S5_v208 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2143 @ S5_v209+4] (should have been resolved before IL gen)");
		_ = 1288;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime54 = dateTime + 264;
		*(DateTime*)(nint)dateTime54 = new DateTime(2015, 9, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+108]");
		_ = 0;
		_ = 0;
		DateTime dateTime55 = dateTime + 256;
		*(DateTime*)(nint)dateTime55 = new DateTime(2015, 7, 15);
		_ = 1289;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+100]");
		_ = 0;
		nint num87 = 0;
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ S5_v213 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2203 @ S5_v214+4] (should have been resolved before IL gen)");
		_ = 1297;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime56 = dateTime + 248;
		*(DateTime*)(nint)dateTime56 = new DateTime(2015, 10, 15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+F8]");
		_ = 0;
		_ = 0;
		DateTime dateTime57 = dateTime + 240;
		*(DateTime*)(nint)dateTime57 = new DateTime(2015, 9, 3);
		_ = 1298;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+F0]");
		_ = 0;
		nint num89 = 0;
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ S5_v218 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2263 @ S5_v219+4] (should have been resolved before IL gen)");
		_ = 1304;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime58 = dateTime + 232;
		*(DateTime*)(nint)dateTime58 = new DateTime(2016, 11, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+E8]");
		_ = 0;
		_ = 0;
		DateTime dateTime59 = dateTime + 224;
		*(DateTime*)(nint)dateTime59 = new DateTime(2016, 9, 23);
		_ = 1305;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+E0]");
		_ = 0;
		nint num91 = 0;
		nint num92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2322 @ S5_v223 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2323 @ S5_v224+4] (should have been resolved before IL gen)");
		_ = 1322;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime60 = dateTime + 216;
		*(DateTime*)(nint)dateTime60 = new DateTime(2017, 2, 9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+D8]");
		_ = 0;
		_ = 0;
		DateTime dateTime61 = dateTime + 208;
		*(DateTime*)(nint)dateTime61 = new DateTime(2016, 12, 19);
		_ = 1323;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+D0]");
		_ = 0;
		nint num93 = 0;
		nint num94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2382 @ S5_v228 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2383 @ S5_v229+4] (should have been resolved before IL gen)");
		_ = 1340;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime62 = dateTime + 200;
		*(DateTime*)(nint)dateTime62 = new DateTime(2016, 3, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+C8]");
		_ = 0;
		_ = 0;
		DateTime dateTime63 = dateTime + 192;
		*(DateTime*)(nint)dateTime63 = new DateTime(2016, 1, 22);
		_ = 1341;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+C0]");
		_ = 0;
		nint num95 = 0;
		nint num96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2442 @ S5_v233 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2443 @ S5_v234+4] (should have been resolved before IL gen)");
		_ = 1349;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime64 = dateTime + 184;
		*(DateTime*)(nint)dateTime64 = new DateTime(2016, 4, 21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+B8]");
		_ = 0;
		_ = 0;
		DateTime dateTime65 = dateTime + 176;
		*(DateTime*)(nint)dateTime65 = new DateTime(2016, 2, 17);
		_ = 1350;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+B0]");
		_ = 0;
		nint num97 = 0;
		nint num98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2502 @ S5_v238 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2503 @ S5_v239+4] (should have been resolved before IL gen)");
		_ = 1361;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime66 = dateTime + 168;
		*(DateTime*)(nint)dateTime66 = new DateTime(2017, 6, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+A8]");
		_ = 0;
		_ = 0;
		DateTime dateTime67 = dateTime + 160;
		*(DateTime*)(nint)dateTime67 = new DateTime(2017, 5, 4);
		_ = 1362;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+A0]");
		_ = 0;
		nint num99 = 0;
		nint num100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2562 @ S5_v243 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2563 @ S5_v244+4] (should have been resolved before IL gen)");
		_ = 1370;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime68 = dateTime + 152;
		*(DateTime*)(nint)dateTime68 = new DateTime(2016, 7, 14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+98]");
		_ = 0;
		_ = 0;
		DateTime dateTime69 = dateTime + 144;
		*(DateTime*)(nint)dateTime69 = new DateTime(2016, 4, 17);
		_ = 1371;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+90]");
		_ = 0;
		nint num101 = 0;
		nint num102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2622 @ S5_v248 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2623 @ S5_v249+4] (should have been resolved before IL gen)");
		_ = 1386;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime70 = dateTime + 136;
		*(DateTime*)(nint)dateTime70 = new DateTime(2016, 9, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+88]");
		_ = 0;
		_ = 0;
		DateTime dateTime71 = dateTime + 128;
		*(DateTime*)(nint)dateTime71 = new DateTime(2016, 7, 14);
		_ = 1387;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+80]");
		_ = 0;
		nint num103 = 0;
		nint num104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2682 @ S5_v253 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2683 @ S5_v254+4] (should have been resolved before IL gen)");
		_ = 1391;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime72 = dateTime + 120;
		*(DateTime*)(nint)dateTime72 = new DateTime(2016, 10, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+78]");
		_ = 0;
		_ = 0;
		DateTime dateTime73 = dateTime + 112;
		*(DateTime*)(nint)dateTime73 = new DateTime(2016, 8, 31);
		_ = 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+70]");
		_ = 0;
		nint num105 = 0;
		nint num106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2742 @ S5_v258 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2743 @ S5_v259+4] (should have been resolved before IL gen)");
		_ = 1400;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime74 = dateTime + 104;
		*(DateTime*)(nint)dateTime74 = new DateTime(2016, 12, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+68]");
		_ = 0;
		_ = 0;
		DateTime dateTime75 = dateTime + 96;
		*(DateTime*)(nint)dateTime75 = new DateTime(2016, 10, 12);
		_ = 1401;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+60]");
		_ = 0;
		nint num107 = 0;
		nint num108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2802 @ S5_v263 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2803 @ S5_v264+4] (should have been resolved before IL gen)");
		_ = 1403;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime76 = dateTime + 88;
		*(DateTime*)(nint)dateTime76 = new DateTime(2016, 12, 29);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+58]");
		_ = 0;
		_ = 0;
		DateTime dateTime77 = dateTime + 80;
		*(DateTime*)(nint)dateTime77 = new DateTime(2016, 10, 31);
		_ = 1404;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+50]");
		_ = 0;
		nint num109 = 0;
		nint num110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2862 @ S5_v268 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2863 @ S5_v269+4] (should have been resolved before IL gen)");
		_ = 1409;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime78 = dateTime + 72;
		*(DateTime*)(nint)dateTime78 = new DateTime(2017, 1, 19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+48]");
		_ = 0;
		_ = 0;
		DateTime dateTime79 = dateTime - -64;
		*(DateTime*)(nint)dateTime79 = new DateTime(2016, 11, 7);
		_ = 1410;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+40]");
		_ = 0;
		nint num111 = 0;
		nint num112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2922 @ S5_v273 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2923 @ S5_v274+4] (should have been resolved before IL gen)");
		_ = 1456;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime80 = dateTime + 56;
		*(DateTime*)(nint)dateTime80 = new DateTime(2017, 4, 20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+38]");
		_ = 0;
		_ = 0;
		DateTime dateTime81 = dateTime + 48;
		*(DateTime*)(nint)dateTime81 = new DateTime(2017, 3, 1);
		_ = 1457;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+30]");
		_ = 0;
		nint num113 = 0;
		nint num114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2982 @ S5_v278 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2983 @ S5_v279+4] (should have been resolved before IL gen)");
		_ = 1491;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime82 = dateTime + 40;
		*(DateTime*)(nint)dateTime82 = new DateTime(2017, 6, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+28]");
		_ = 0;
		_ = 0;
		DateTime dateTime83 = dateTime + 32;
		*(DateTime*)(nint)dateTime83 = new DateTime(2017, 4, 6);
		_ = 1492;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+20]");
		_ = 0;
		nint num115 = 0;
		nint num116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3042 @ S5_v283 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3043 @ S5_v284+4] (should have been resolved before IL gen)");
		_ = 1501;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime84 = dateTime + 24;
		*(DateTime*)(nint)dateTime84 = new DateTime(2017, 7, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+18]");
		_ = 0;
		_ = 0;
		DateTime dateTime85 = dateTime + 16;
		*(DateTime*)(nint)dateTime85 = new DateTime(2017, 5, 17);
		_ = 1502;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+10]");
		_ = 0;
		nint num117 = 0;
		nint num118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3102 @ S5_v288 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3103 @ S5_v289+4] (should have been resolved before IL gen)");
		_ = 1514;
		_ = 1;
		_ = 0;
		_ = 95000;
		_ = 2;
		_ = 0;
		DateTime dateTime86 = dateTime + 8;
		*(DateTime*)(nint)dateTime86 = new DateTime(2017, 8, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
		_ = 0;
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		*(DateTime*)(nint)dateTime = new DateTime(2017, 4, 6);
		_ = 1515;
		_ = dateTime._dateData;
		nint num119 = 0;
		nint num120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3160 @ S5_v293 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+5C]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3161 @ S5_v294+4] (should have been resolved before IL gen)");
		Dictionary<CharacterType, Model> dictionary = default;
		characterData = dictionary;
		List<CharacterType> list2 = default;
		list2._002Ector();
		list2.Add(CharacterType.yutani);
		list2.Add(CharacterType.spike);
		list2.Add(CharacterType.fresh);
		list2.Add(CharacterType.tricky);
		list2.Add(CharacterType.slick);
		list2.Add(CharacterType.facebookRewardCharacter01);
		list2.Add(CharacterType.nick);
		list2.Add(CharacterType.shanghaiCharacter01);
		list2.Add(CharacterType.marrakeshCharacter01);
		list2.Add(CharacterType.peruCharacter01);
		list2.Add(CharacterType.copenhagenCharacter01);
		list2.Add(CharacterType.hawaiiCharacter01);
		list2.Add(CharacterType.monacoCharacter01);
		list2.Add(CharacterType.bangkokCharacter01);
		list2.Add(CharacterType.arabiaCharacter01);
		list2.Add(CharacterType.sanfranciscoCharacter01);
		list2.Add(CharacterType.amsterdamCharacter01);
		list2.Add(CharacterType.holidayCharacter2016);
		list2.Add(CharacterType.elftricky);
		list2.Add(CharacterType.washingtonCharacter01);
		list2.Add(CharacterType.transylvaniaCharacter01);
		list2.Add(CharacterType.havanaCharacter01);
		list2.Add(CharacterType.icelandCharacter01);
		list2.Add(CharacterType.carmen);
		list2.Add(CharacterType.veniceCharacter01);
		list2.Add(CharacterType.singaporeCharacter01);
		list2.Add(CharacterType.lasVegasCharacter01);
		list2.Add(CharacterType.kim);
		list2.Add(CharacterType.madagascarCharacter01);
		list2.Add(CharacterType.pragueCharacter01);
		list2.Add(CharacterType.londonCharacter02);
		list2.Add(CharacterType.harumi);
		list2.Add(CharacterType.kenyaCharacter01);
		list2.Add(CharacterType.tony);
		list2.Add(CharacterType.greeceCharacter01);
		list2.Add(CharacterType.losangelesCharacter01);
		list2.Add(CharacterType.cairoCharacter01);
		list2.Add(CharacterType.saopauloCharacter01);
		list2.Add(CharacterType.vancouverCharacter01);
		list2.Add(CharacterType.mexicoCharacter01);
		list2.Add(CharacterType.seoulCharacter01);
		list2.Add(CharacterType.mumbaiCharacter01);
		list2.Add(CharacterType.londonCharacter01);
		list2.Add(CharacterType.halloweenCharacter01);
		list2.Add(CharacterType.moscowCharacter01);
		list2.Add(CharacterType.monkeyking);
		list2.Add(CharacterType.coco);
		list2.Add(CharacterType.roberto);
		list2.Add(CharacterType.zombiejake);
		list2.Add(CharacterType.frank);
		list2.Add(CharacterType.frizzy);
		list2.Add(CharacterType.king);
		list2.Add(CharacterType.lucy);
		list2.Add(CharacterType.ninja);
		list2.Add(CharacterType.tag);
		list2.Add(CharacterType.tasha);
		list2.Add(CharacterType.zoe);
		list2.Add(CharacterType.brody);
		list2.Add(CharacterType.princek);
		characterOrder = list2;
	}
}
