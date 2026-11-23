using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;

public class Hoverboards
{
	public enum BoardType
	{
		normal,
		bouncer,
		lowrider,
		snowboard,
		surfboard,
		theoriginal,
		starboard,
		miami,
		monster,
		skullfire,
		liberty,
		speedboard,
		toucan,
		treehugger,
		chick,
		rome,
		soccer,
		theOutback,
		greatWhiteWakeboard,
		cherry,
		kitty,
		hotrod,
		flamingo,
		rose,
		panda,
		dragon,
		moscowBoard01,
		halloweenBoard01,
		londonBoard01,
		londonBoard02,
		mumbaiBoard01,
		teleboard,
		gliderboard,
		seoulBoard01,
		mexicoBoard01,
		vancouverBoard01,
		saopauloBoard01,
		losangelesBoard01,
		cairoBoard01,
		bangkokBoard01,
		londonBoard03,
		lasVegasBoard01,
		hawaiiBoard01,
		arabiaBoard01,
		veniceBoard01,
		rioBoard01,
		sydneyBoard01,
		greeceBoard01,
		kenyaBoard01,
		transylvaniaBoard01,
		northpoleBoard01,
		sanfranciscoBoard01,
		pragueBoard01,
		madagascarBoard01,
		sydneyBoard02,
		peruBoard01,
		singaporeBoard01,
		veniceBoard02,
		rioBoard02,
		icelandBoard01,
		havanaBoard01,
		halloweenBoard02,
		washingtonBoard01,
		northpoleBoard02,
		amsterdamBoard01,
		arabiaBoard02,
		monacoBoard01,
		hawaiiBoard02,
		copenhagenBoard01,
		birthdayBoard01,
		marrakeshBoard01,
		shanghaiBoard01
	}

	public class Board
	{
		public StringID name;

		public string boardModelName;

		public int price;

		public PurchaseData.UnlockType unlockType;

		public string tokenSprite2dName;

		public StringID description;

		public StringID limitedDescription;

		public bool isNewInThisUpdate;

		public bool hasOnlineTimeLimit;

		public DateTime defaultExpirationTime;

		public DateTime defaultStartDate;

		public bool overrideDynamicIapIdAndroid;

		public bool overrideDynamicIapIdiOS;

		public bool overrideDynamicIapIdKindle;

		public bool overrideDynamicIapIdWP8;

		public string dynamicIapId;
	}

	public static List<BoardType> GM_Boards;

	public const string ONLINE_SETTINGS_BOARD_PREFIX_EXPIRE = "hoverboard_expiretime_";

	public const string ONLINE_SETTINGS_BOARD_PREFIX_START = "hoverboard_starttime_";

	public static readonly Dictionary<BoardType, Board> boardData;

	public static List<BoardType> exclusiveAndroidBoards;

	public static List<BoardType> boardOrder;

	unsafe static Hoverboards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected VT, but got Unknown
		//IL_03b3: Expected native int or pointer, but got VT
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected VT, but got Unknown
		//IL_03ec: Expected native int or pointer, but got VT
		//IL_041f: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected VT, but got Unknown
		//IL_04c3: Expected native int or pointer, but got VT
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected VT, but got Unknown
		//IL_04fc: Expected native int or pointer, but got VT
		//IL_052f: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected VT, but got Unknown
		//IL_05d5: Expected native int or pointer, but got VT
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected VT, but got Unknown
		//IL_060e: Expected native int or pointer, but got VT
		//IL_0641: Expected Obj, but got I
		//IL_0689: Expected Obj, but got I
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected VT, but got Unknown
		//IL_06e5: Expected native int or pointer, but got VT
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected VT, but got Unknown
		//IL_071e: Expected native int or pointer, but got VT
		//IL_0751: Expected Obj, but got I
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected VT, but got Unknown
		//IL_07a8: Expected native int or pointer, but got VT
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected VT, but got Unknown
		//IL_07e6: Expected native int or pointer, but got VT
		//IL_0814: Expected Obj, but got I
		//IL_0861: Expected Obj, but got I
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected VT, but got Unknown
		//IL_08be: Expected native int or pointer, but got VT
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected VT, but got Unknown
		//IL_08fc: Expected native int or pointer, but got VT
		//IL_092a: Expected Obj, but got I
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected VT, but got Unknown
		//IL_0986: Expected native int or pointer, but got VT
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Expected VT, but got Unknown
		//IL_09bf: Expected native int or pointer, but got VT
		//IL_09f2: Expected Obj, but got I
		//IL_0a3a: Expected Obj, but got I
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected VT, but got Unknown
		//IL_0a96: Expected native int or pointer, but got VT
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Expected VT, but got Unknown
		//IL_0acf: Expected native int or pointer, but got VT
		//IL_0b02: Expected Obj, but got I
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected VT, but got Unknown
		//IL_0b59: Expected native int or pointer, but got VT
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected VT, but got Unknown
		//IL_0b97: Expected native int or pointer, but got VT
		//IL_0bc5: Expected Obj, but got I
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Expected VT, but got Unknown
		//IL_0c21: Expected native int or pointer, but got VT
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected VT, but got Unknown
		//IL_0c5a: Expected native int or pointer, but got VT
		//IL_0c8d: Expected Obj, but got I
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected VT, but got Unknown
		//IL_0cea: Expected native int or pointer, but got VT
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected VT, but got Unknown
		//IL_0d28: Expected native int or pointer, but got VT
		//IL_0d56: Expected Obj, but got I
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected VT, but got Unknown
		//IL_0db2: Expected native int or pointer, but got VT
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected VT, but got Unknown
		//IL_0deb: Expected native int or pointer, but got VT
		//IL_0e1e: Expected Obj, but got I
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Expected VT, but got Unknown
		//IL_0e75: Expected native int or pointer, but got VT
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Expected VT, but got Unknown
		//IL_0eb3: Expected native int or pointer, but got VT
		//IL_0eed: Expected Obj, but got I
		//IL_0f40: Expected Obj, but got I
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected VT, but got Unknown
		//IL_0f97: Expected native int or pointer, but got VT
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected VT, but got Unknown
		//IL_0fd5: Expected native int or pointer, but got VT
		//IL_1003: Expected Obj, but got I
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Expected VT, but got Unknown
		//IL_105f: Expected native int or pointer, but got VT
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_1085: Expected VT, but got Unknown
		//IL_1098: Expected native int or pointer, but got VT
		//IL_10cb: Expected Obj, but got I
		//IL_1121: Expected Obj, but got I
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1174: Expected VT, but got Unknown
		//IL_1187: Expected native int or pointer, but got VT
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected VT, but got Unknown
		//IL_11c0: Expected native int or pointer, but got VT
		//IL_11f3: Expected Obj, but got I
		//IL_123c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1241: Expected VT, but got Unknown
		//IL_1254: Expected native int or pointer, but got VT
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f: Expected VT, but got Unknown
		//IL_1292: Expected native int or pointer, but got VT
		//IL_12c0: Expected Obj, but got I
		//IL_130e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Expected VT, but got Unknown
		//IL_1326: Expected native int or pointer, but got VT
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected VT, but got Unknown
		//IL_135f: Expected native int or pointer, but got VT
		//IL_1392: Expected Obj, but got I
		//IL_13e8: Expected Obj, but got I
		//IL_1436: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected VT, but got Unknown
		//IL_144e: Expected native int or pointer, but got VT
		//IL_146f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1474: Expected VT, but got Unknown
		//IL_1487: Expected native int or pointer, but got VT
		//IL_14ba: Expected Obj, but got I
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_1508: Expected VT, but got Unknown
		//IL_151b: Expected native int or pointer, but got VT
		//IL_1541: Unknown result type (might be due to invalid IL or missing references)
		//IL_1546: Expected VT, but got Unknown
		//IL_1559: Expected native int or pointer, but got VT
		//IL_1587: Expected Obj, but got I
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15da: Expected VT, but got Unknown
		//IL_15ed: Expected native int or pointer, but got VT
		//IL_160e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Expected VT, but got Unknown
		//IL_1626: Expected native int or pointer, but got VT
		//IL_1659: Expected Obj, but got I
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Expected VT, but got Unknown
		//IL_16ba: Expected native int or pointer, but got VT
		//IL_16e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e5: Expected VT, but got Unknown
		//IL_16f8: Expected native int or pointer, but got VT
		//IL_1726: Expected Obj, but got I
		//IL_1781: Expected Obj, but got I
		//IL_17ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cf: Expected VT, but got Unknown
		//IL_17e2: Expected native int or pointer, but got VT
		//IL_1808: Unknown result type (might be due to invalid IL or missing references)
		//IL_180d: Expected VT, but got Unknown
		//IL_1820: Expected native int or pointer, but got VT
		//IL_184e: Expected Obj, but got I
		//IL_189c: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a1: Expected VT, but got Unknown
		//IL_18b4: Expected native int or pointer, but got VT
		//IL_18d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18da: Expected VT, but got Unknown
		//IL_18ed: Expected native int or pointer, but got VT
		//IL_1920: Expected Obj, but got I
		//IL_1969: Unknown result type (might be due to invalid IL or missing references)
		//IL_196e: Expected VT, but got Unknown
		//IL_1981: Expected native int or pointer, but got VT
		//IL_19a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Expected VT, but got Unknown
		//IL_19bf: Expected native int or pointer, but got VT
		//IL_19ed: Expected Obj, but got I
		//IL_1a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a40: Expected VT, but got Unknown
		//IL_1a53: Expected native int or pointer, but got VT
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected VT, but got Unknown
		//IL_1a8c: Expected native int or pointer, but got VT
		//IL_1abf: Expected Obj, but got I
		//IL_1b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0d: Expected VT, but got Unknown
		//IL_1b20: Expected native int or pointer, but got VT
		//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Expected VT, but got Unknown
		//IL_1b5e: Expected native int or pointer, but got VT
		//IL_1b8c: Expected Obj, but got I
		//IL_1bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdf: Expected VT, but got Unknown
		//IL_1bf2: Expected native int or pointer, but got VT
		//IL_1c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c18: Expected VT, but got Unknown
		//IL_1c2b: Expected native int or pointer, but got VT
		//IL_1c5e: Expected Obj, but got I
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cac: Expected VT, but got Unknown
		//IL_1cbf: Expected native int or pointer, but got VT
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Expected VT, but got Unknown
		//IL_1cfd: Expected native int or pointer, but got VT
		//IL_1d2b: Expected Obj, but got I
		//IL_1d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7e: Expected VT, but got Unknown
		//IL_1d91: Expected native int or pointer, but got VT
		//IL_1db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db7: Expected VT, but got Unknown
		//IL_1dca: Expected native int or pointer, but got VT
		//IL_1dfd: Expected Obj, but got I
		//IL_1e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4b: Expected VT, but got Unknown
		//IL_1e5e: Expected native int or pointer, but got VT
		//IL_1e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e89: Expected VT, but got Unknown
		//IL_1e9c: Expected native int or pointer, but got VT
		//IL_1eca: Expected Obj, but got I
		//IL_1f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1d: Expected VT, but got Unknown
		//IL_1f30: Expected native int or pointer, but got VT
		//IL_1f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Expected VT, but got Unknown
		//IL_1f69: Expected native int or pointer, but got VT
		//IL_1f9c: Expected Obj, but got I
		//IL_1fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fea: Expected VT, but got Unknown
		//IL_1ffd: Expected native int or pointer, but got VT
		//IL_2023: Unknown result type (might be due to invalid IL or missing references)
		//IL_2028: Expected VT, but got Unknown
		//IL_203b: Expected native int or pointer, but got VT
		//IL_2069: Expected Obj, but got I
		//IL_20b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bc: Expected VT, but got Unknown
		//IL_20cf: Expected native int or pointer, but got VT
		//IL_20f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f5: Expected VT, but got Unknown
		//IL_2108: Expected native int or pointer, but got VT
		//IL_213b: Expected Obj, but got I
		//IL_2184: Unknown result type (might be due to invalid IL or missing references)
		//IL_2189: Expected VT, but got Unknown
		//IL_219c: Expected native int or pointer, but got VT
		//IL_21c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c7: Expected VT, but got Unknown
		//IL_21da: Expected native int or pointer, but got VT
		//IL_2208: Expected Obj, but got I
		//IL_2256: Unknown result type (might be due to invalid IL or missing references)
		//IL_225b: Expected VT, but got Unknown
		//IL_226e: Expected native int or pointer, but got VT
		//IL_228f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2294: Expected VT, but got Unknown
		//IL_22a7: Expected native int or pointer, but got VT
		//IL_22da: Expected Obj, but got I
		//IL_2323: Unknown result type (might be due to invalid IL or missing references)
		//IL_2328: Expected VT, but got Unknown
		//IL_233b: Expected native int or pointer, but got VT
		//IL_2361: Unknown result type (might be due to invalid IL or missing references)
		//IL_2366: Expected VT, but got Unknown
		//IL_2379: Expected native int or pointer, but got VT
		//IL_23a7: Expected Obj, but got I
		//IL_23f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fa: Expected VT, but got Unknown
		//IL_240d: Expected native int or pointer, but got VT
		//IL_242e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2433: Expected VT, but got Unknown
		//IL_2446: Expected native int or pointer, but got VT
		//IL_2479: Expected Obj, but got I
		//IL_24c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c7: Expected VT, but got Unknown
		//IL_24da: Expected native int or pointer, but got VT
		//IL_2500: Unknown result type (might be due to invalid IL or missing references)
		//IL_2505: Expected VT, but got Unknown
		//IL_2518: Expected native int or pointer, but got VT
		//IL_2546: Expected Obj, but got I
		//IL_25a1: Expected Obj, but got I
		//IL_25ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ef: Expected VT, but got Unknown
		//IL_2602: Expected native int or pointer, but got VT
		//IL_2628: Unknown result type (might be due to invalid IL or missing references)
		//IL_262d: Expected VT, but got Unknown
		//IL_2640: Expected native int or pointer, but got VT
		//IL_266e: Expected Obj, but got I
		//IL_26bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c1: Expected VT, but got Unknown
		//IL_26d4: Expected native int or pointer, but got VT
		//IL_26f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26fa: Expected VT, but got Unknown
		//IL_270d: Expected native int or pointer, but got VT
		//IL_2740: Expected Obj, but got I
		//IL_2783: Unknown result type (might be due to invalid IL or missing references)
		//IL_2788: Expected VT, but got Unknown
		//IL_279b: Expected native int or pointer, but got VT
		//IL_27c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c6: Expected VT, but got Unknown
		//IL_27d9: Expected native int or pointer, but got VT
		//IL_2807: Expected Obj, but got I
		//IL_2855: Unknown result type (might be due to invalid IL or missing references)
		//IL_285a: Expected VT, but got Unknown
		//IL_286d: Expected native int or pointer, but got VT
		//IL_288e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2893: Expected VT, but got Unknown
		//IL_28a6: Expected native int or pointer, but got VT
		//IL_28d9: Expected Obj, but got I
		//IL_2922: Unknown result type (might be due to invalid IL or missing references)
		//IL_2927: Expected VT, but got Unknown
		//IL_293a: Expected native int or pointer, but got VT
		//IL_2960: Unknown result type (might be due to invalid IL or missing references)
		//IL_2965: Expected VT, but got Unknown
		//IL_2978: Expected native int or pointer, but got VT
		//IL_29a6: Expected Obj, but got I
		//IL_29f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f9: Expected VT, but got Unknown
		//IL_2a0c: Expected native int or pointer, but got VT
		//IL_2a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a32: Expected VT, but got Unknown
		//IL_2a45: Expected native int or pointer, but got VT
		//IL_2a78: Expected Obj, but got I
		//IL_2ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac6: Expected VT, but got Unknown
		//IL_2ad9: Expected native int or pointer, but got VT
		//IL_2aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b04: Expected VT, but got Unknown
		//IL_2b17: Expected native int or pointer, but got VT
		//IL_2b45: Expected Obj, but got I
		//IL_2b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b98: Expected VT, but got Unknown
		//IL_2bab: Expected native int or pointer, but got VT
		//IL_2bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd1: Expected VT, but got Unknown
		//IL_2be4: Expected native int or pointer, but got VT
		//IL_2c17: Expected Obj, but got I
		//IL_2c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c65: Expected VT, but got Unknown
		//IL_2c78: Expected native int or pointer, but got VT
		//IL_2c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca3: Expected VT, but got Unknown
		//IL_2cb6: Expected native int or pointer, but got VT
		//IL_2ce4: Expected Obj, but got I
		//IL_2d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d37: Expected VT, but got Unknown
		//IL_2d4a: Expected native int or pointer, but got VT
		//IL_2d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d70: Expected VT, but got Unknown
		//IL_2d83: Expected native int or pointer, but got VT
		//IL_2db6: Expected Obj, but got I
		//IL_2dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e04: Expected VT, but got Unknown
		//IL_2e17: Expected native int or pointer, but got VT
		//IL_2e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e42: Expected VT, but got Unknown
		//IL_2e55: Expected native int or pointer, but got VT
		//IL_2e83: Expected Obj, but got I
		//IL_2ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed6: Expected VT, but got Unknown
		//IL_2ee9: Expected native int or pointer, but got VT
		//IL_2f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0f: Expected VT, but got Unknown
		//IL_2f22: Expected native int or pointer, but got VT
		//IL_2f55: Expected Obj, but got I
		//IL_2f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa3: Expected VT, but got Unknown
		//IL_2fb6: Expected native int or pointer, but got VT
		//IL_2fdb: Expected I8, but got I4
		//IL_2fd6: Expected native int or pointer, but got VT
		//IL_2fee: Expected native int or pointer, but got VT
		//IL_3019: Expected Obj, but got I
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 832);
		List<BoardType> list = default;
		list._002Ector();
		list.Add(BoardType.normal);
		list.Add(BoardType.skullfire);
		list.Add(BoardType.starboard);
		list.Add(BoardType.miami);
		list.Add(BoardType.monster);
		GM_Boards = list;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>>)+4] (should have been resolved before IL gen)");
		_ = 287;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = 288;
		_ = 0;
		_ = 289;
		_ = 8590214592L;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S5_v9+4] (should have been resolved before IL gen)");
		_ = 290;
		_ = 0;
		_ = 291;
		_ = 8590254592L;
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S5_v14+4] (should have been resolved before IL gen)");
		_ = 292;
		_ = 0;
		_ = 8589979592L;
		_ = 0;
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ S5_v19+4] (should have been resolved before IL gen)");
		_ = 293;
		_ = 0;
		_ = 8589999592L;
		_ = 0;
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ S5_v24+4] (should have been resolved before IL gen)");
		_ = 294;
		_ = 0;
		_ = 8589942592L;
		_ = 0;
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ S5_v29+4] (should have been resolved before IL gen)");
		_ = 295;
		_ = 0;
		_ = 8589944592L;
		_ = 0;
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v288 @ S5_v34+4] (should have been resolved before IL gen)");
		_ = 296;
		_ = 0;
		_ = 8589946592L;
		_ = 0;
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ S5_v39+4] (should have been resolved before IL gen)");
		_ = 297;
		_ = 0;
		_ = 8589964592L;
		_ = 0;
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v350 @ S5_v44+4] (should have been resolved before IL gen)");
		_ = 298;
		_ = 0;
		_ = 8590009592L;
		_ = 0;
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ S5_v49+4] (should have been resolved before IL gen)");
		_ = 299;
		_ = 256;
		_ = 1288490188800L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime2 = dateTime + 824;
		*(DateTime*)(nint)dateTime2 = new DateTime(2015, 9, 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+338]");
		_ = 0;
		_ = 0;
		DateTime dateTime3 = dateTime + 816;
		*(DateTime*)(nint)dateTime3 = new DateTime(2015, 8, 18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+330]");
		_ = 0;
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ S5_v54+4] (should have been resolved before IL gen)");
		_ = 301;
		_ = 0;
		_ = 303;
		_ = 8590019592L;
		nint num25 = 0;
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S5_v58 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v469 @ S5_v59+4] (should have been resolved before IL gen)");
		_ = 305;
		_ = 256;
		_ = 1314259992576L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime4 = dateTime + 808;
		*(DateTime*)(nint)dateTime4 = new DateTime(2013, 2, 28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+328]");
		_ = 0;
		_ = 0;
		DateTime dateTime5 = dateTime + 800;
		*(DateTime*)(nint)dateTime5 = new DateTime(2013, 1, 28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+320]");
		_ = 0;
		nint num27 = 0;
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S5_v63 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v526 @ S5_v64+4] (should have been resolved before IL gen)");
		_ = 307;
		_ = 0;
		_ = 8589938592L;
		_ = 0;
		nint num29 = 0;
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S5_v68 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v557 @ S5_v69+4] (should have been resolved before IL gen)");
		_ = 308;
		_ = 0;
		_ = 25769803876L;
		_ = 256;
		_ = 0;
		DateTime dateTime6 = dateTime + 792;
		*(DateTime*)(nint)dateTime6 = new DateTime(2017, 3, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+318]");
		_ = 0;
		_ = 0;
		DateTime dateTime7 = dateTime + 784;
		*(DateTime*)(nint)dateTime7 = new DateTime(2017, 4, 20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+310]");
		_ = 0;
		nint num31 = 0;
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S5_v73 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v617 @ S5_v74+4] (should have been resolved before IL gen)");
		_ = 310;
		_ = 0;
		_ = 8589969592L;
		_ = 0;
		nint num33 = 0;
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S5_v78 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ S5_v79+4] (should have been resolved before IL gen)");
		_ = 311;
		_ = 256;
		_ = 1340029796352L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime8 = dateTime + 776;
		*(DateTime*)(nint)dateTime8 = new DateTime(2014, 5, 8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+308]");
		_ = 0;
		_ = 0;
		DateTime dateTime9 = dateTime + 768;
		*(DateTime*)(nint)dateTime9 = new DateTime(2014, 3, 20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+300]");
		_ = 0;
		nint num35 = 0;
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S5_v83 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v705 @ S5_v84+4] (should have been resolved before IL gen)");
		_ = 313;
		_ = 256;
		_ = 1348619730944L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime10 = dateTime + 760;
		*(DateTime*)(nint)dateTime10 = new DateTime(2013, 5, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2F8]");
		_ = 0;
		_ = 0;
		DateTime dateTime11 = dateTime + 752;
		*(DateTime*)(nint)dateTime11 = new DateTime(2013, 3, 20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2F0]");
		_ = 0;
		nint num37 = 0;
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ S5_v88 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v762 @ S5_v89+4] (should have been resolved before IL gen)");
		_ = 315;
		_ = 0;
		_ = 8589954592L;
		_ = 0;
		nint num39 = 0;
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ S5_v93 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v793 @ S5_v94+4] (should have been resolved before IL gen)");
		_ = 316;
		_ = 256;
		_ = 1361504632832L;
		_ = 12884901948L;
		_ = 0;
		DateTime dateTime12 = dateTime + 744;
		*(DateTime*)(nint)dateTime12 = new DateTime(2013, 5, 30);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2E8]");
		_ = 0;
		_ = 0;
		DateTime dateTime13 = dateTime + 736;
		*(DateTime*)(nint)dateTime13 = new DateTime(2013, 5, 23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2E0]");
		_ = 0;
		nint num41 = 0;
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ S5_v98 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v853 @ S5_v99+4] (should have been resolved before IL gen)");
		_ = 318;
		_ = 256;
		_ = 1370094567424L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime14 = dateTime + 728;
		*(DateTime*)(nint)dateTime14 = new DateTime(2015, 12, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2D8]");
		_ = 0;
		_ = 0;
		DateTime dateTime15 = dateTime + 720;
		*(DateTime*)(nint)dateTime15 = new DateTime(2015, 10, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2D0]");
		_ = 0;
		nint num43 = 0;
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ S5_v103 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v910 @ S5_v104+4] (should have been resolved before IL gen)");
		_ = 320;
		_ = 0;
		_ = 321;
		_ = 8590214592L;
		nint num45 = 0;
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S5_v108 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v941 @ S5_v109+4] (should have been resolved before IL gen)");
		_ = 324;
		_ = 257;
		_ = 1395864371200L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime16 = dateTime + 712;
		*(DateTime*)(nint)dateTime16 = new DateTime(2017, 7, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2C8]");
		_ = 0;
		_ = 0;
		DateTime dateTime17 = dateTime + 704;
		*(DateTime*)(nint)dateTime17 = new DateTime(2017, 8, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2C0]");
		_ = 0;
		nint num47 = 0;
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ S5_v113 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v998 @ S5_v114+4] (should have been resolved before IL gen)");
		_ = 326;
		_ = 256;
		_ = 1404454305792L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime18 = dateTime + 696;
		*(DateTime*)(nint)dateTime18 = new DateTime(2015, 4, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2B8]");
		_ = 0;
		_ = 0;
		DateTime dateTime19 = dateTime + 688;
		*(DateTime*)(nint)dateTime19 = new DateTime(2015, 2, 25);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2B0]");
		_ = 0;
		nint num49 = 0;
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S5_v118 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1055 @ S5_v119+4] (should have been resolved before IL gen)");
		_ = 328;
		_ = 256;
		_ = 1413044240384L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime20 = dateTime + 680;
		*(DateTime*)(nint)dateTime20 = new DateTime(2014, 9, 18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2A8]");
		_ = 0;
		_ = 0;
		DateTime dateTime21 = dateTime + 672;
		*(DateTime*)(nint)dateTime21 = new DateTime(2014, 7, 8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+2A0]");
		_ = 0;
		nint num51 = 0;
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ S5_v123 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1112 @ S5_v124+4] (should have been resolved before IL gen)");
		_ = 330;
		_ = 256;
		_ = 1421634174976L;
		_ = 12884901948L;
		_ = 0;
		DateTime dateTime22 = dateTime + 664;
		*(DateTime*)(nint)dateTime22 = new DateTime(2013, 8, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+298]");
		_ = 0;
		_ = 0;
		DateTime dateTime23 = dateTime + 656;
		*(DateTime*)(nint)dateTime23 = new DateTime(2013, 6, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+290]");
		_ = 0;
		nint num53 = 0;
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ S5_v128 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1172 @ S5_v129+4] (should have been resolved before IL gen)");
		_ = 788;
		_ = 256;
		_ = 3345779523584L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime24 = dateTime + 648;
		*(DateTime*)(nint)dateTime24 = new DateTime(2013, 10, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+288]");
		_ = 0;
		_ = 0;
		DateTime dateTime25 = dateTime + 640;
		*(DateTime*)(nint)dateTime25 = new DateTime(2013, 9, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+280]");
		_ = 0;
		nint num55 = 0;
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ S5_v133 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1229 @ S5_v134+4] (should have been resolved before IL gen)");
		_ = 790;
		_ = 256;
		_ = 3388729196544L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime26 = dateTime + 632;
		*(DateTime*)(nint)dateTime26 = new DateTime(2014, 11, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+278]");
		_ = 0;
		_ = 0;
		DateTime dateTime27 = dateTime + 624;
		*(DateTime*)(nint)dateTime27 = new DateTime(2014, 9, 15);
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+270]");
		_ = 0;
		nint num57 = 0;
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ S5_v138 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1293 @ S5_v139+4] (should have been resolved before IL gen)");
		_ = 793;
		_ = 0;
		_ = 17179869244L;
		_ = 0;
		nint num59 = 0;
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ S5_v143 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1327 @ S5_v144+4] (should have been resolved before IL gen)");
		_ = 794;
		_ = 256;
		_ = 3354369458176L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime28 = dateTime + 616;
		*(DateTime*)(nint)dateTime28 = new DateTime(2015, 1, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+268]");
		_ = 0;
		_ = 0;
		DateTime dateTime29 = dateTime + 608;
		*(DateTime*)(nint)dateTime29 = new DateTime(2014, 10, 21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+260]");
		_ = 0;
		nint num61 = 0;
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ S5_v148 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1384 @ S5_v149+4] (should have been resolved before IL gen)");
		_ = 796;
		_ = 256;
		_ = 3362959392768L;
		_ = 8589984592L;
		_ = 0;
		DateTime dateTime30 = dateTime + 600;
		*(DateTime*)(nint)dateTime30 = new DateTime(2015, 3, 26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+258]");
		_ = 0;
		_ = 0;
		DateTime dateTime31 = dateTime + 592;
		*(DateTime*)(nint)dateTime31 = new DateTime(2015, 2, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+250]");
		_ = 0;
		nint num63 = 0;
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ S5_v153 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1441 @ S5_v154+4] (should have been resolved before IL gen)");
		_ = 302;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 304;
		_ = 2;
		_ = 220000;
		nint num65 = 0;
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1477 @ S5_v158 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1478 @ S5_v159+4] (should have been resolved before IL gen)");
		_ = 797;
		_ = 1;
		_ = 0;
		_ = 784;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime32 = dateTime + 584;
		*(DateTime*)(nint)dateTime32 = new DateTime(2015, 2, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+248]");
		_ = 0;
		_ = 0;
		DateTime dateTime33 = dateTime + 576;
		*(DateTime*)(nint)dateTime33 = new DateTime(2014, 12, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+240]");
		_ = 0;
		nint num67 = 0;
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1540 @ S5_v163 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1541 @ S5_v164+4] (should have been resolved before IL gen)");
		_ = 798;
		_ = 1;
		_ = 0;
		_ = 785;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime34 = dateTime + 568;
		*(DateTime*)(nint)dateTime34 = new DateTime(2014, 4, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+238]");
		_ = 0;
		_ = 0;
		DateTime dateTime35 = dateTime + 560;
		*(DateTime*)(nint)dateTime35 = new DateTime(2014, 3, 20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+230]");
		_ = 0;
		nint num69 = 0;
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ S5_v168 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1604 @ S5_v169+4] (should have been resolved before IL gen)");
		_ = 799;
		_ = 1;
		_ = 0;
		_ = 786;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime36 = dateTime + 552;
		*(DateTime*)(nint)dateTime36 = new DateTime(2014, 5, 28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+228]");
		_ = 0;
		_ = 0;
		DateTime dateTime37 = dateTime + 544;
		*(DateTime*)(nint)dateTime37 = new DateTime(2014, 4, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+220]");
		_ = 0;
		nint num71 = 0;
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ S5_v173 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1667 @ S5_v174+4] (should have been resolved before IL gen)");
		_ = 322;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 323;
		_ = 2;
		_ = 360000;
		nint num73 = 0;
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ S5_v178 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1704 @ S5_v179+4] (should have been resolved before IL gen)");
		_ = 1030;
		_ = 1;
		_ = 0;
		_ = 1029;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime38 = dateTime + 536;
		*(DateTime*)(nint)dateTime38 = new DateTime(2014, 7, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+218]");
		_ = 0;
		_ = 0;
		DateTime dateTime39 = dateTime + 528;
		*(DateTime*)(nint)dateTime39 = new DateTime(2014, 5, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+210]");
		_ = 0;
		nint num75 = 0;
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1766 @ S5_v183 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1767 @ S5_v184+4] (should have been resolved before IL gen)");
		_ = 1032;
		_ = 1;
		_ = 0;
		_ = 1031;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime40 = dateTime + 520;
		*(DateTime*)(nint)dateTime40 = new DateTime(2015, 6, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+208]");
		_ = 0;
		_ = 0;
		DateTime dateTime41 = dateTime + 512;
		*(DateTime*)(nint)dateTime41 = new DateTime(2015, 4, 21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+200]");
		_ = 0;
		nint num77 = 0;
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1826 @ S5_v188 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1827 @ S5_v189+4] (should have been resolved before IL gen)");
		_ = 1137;
		_ = 1;
		_ = 0;
		_ = 1138;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime42 = dateTime + 504;
		*(DateTime*)(nint)dateTime42 = new DateTime(2014, 10, 9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1F8]");
		_ = 0;
		_ = 0;
		DateTime dateTime43 = dateTime + 496;
		*(DateTime*)(nint)dateTime43 = new DateTime(2014, 8, 7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1F0]");
		_ = 0;
		nint num79 = 0;
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1886 @ S5_v193 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1887 @ S5_v194+4] (should have been resolved before IL gen)");
		_ = 1139;
		_ = 1;
		_ = 0;
		_ = 1140;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime44 = dateTime + 488;
		*(DateTime*)(nint)dateTime44 = new DateTime(2017, 3, 30);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1E8]");
		_ = 0;
		_ = 0;
		DateTime dateTime45 = dateTime + 480;
		*(DateTime*)(nint)dateTime45 = new DateTime(2017, 2, 8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1E0]");
		_ = 0;
		nint num81 = 0;
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1946 @ S5_v198 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1947 @ S5_v199+4] (should have been resolved before IL gen)");
		_ = 795;
		_ = 0;
		_ = 0;
		_ = 782;
		_ = 0;
		_ = 4;
		_ = 1;
		nint num83 = 0;
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1982 @ S5_v203 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1983 @ S5_v204+4] (should have been resolved before IL gen)");
		_ = 800;
		_ = 1;
		_ = 0;
		_ = 787;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime46 = dateTime + 472;
		*(DateTime*)(nint)dateTime46 = new DateTime(2016, 6, 23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1D8]");
		_ = 0;
		_ = 0;
		DateTime dateTime47 = dateTime + 464;
		*(DateTime*)(nint)dateTime47 = new DateTime(2014, 11, 26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1D0]");
		_ = 0;
		nint num85 = 0;
		nint num86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2042 @ S5_v208 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2043 @ S5_v209+4] (should have been resolved before IL gen)");
		_ = 1221;
		_ = 1;
		_ = 0;
		_ = 1222;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime48 = dateTime + 456;
		*(DateTime*)(nint)dateTime48 = new DateTime(2016, 1, 21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1C8]");
		_ = 0;
		_ = 0;
		DateTime dateTime49 = dateTime + 448;
		*(DateTime*)(nint)dateTime49 = new DateTime(2015, 11, 26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1C0]");
		_ = 0;
		nint num87 = 0;
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2102 @ S5_v213 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2103 @ S5_v214+4] (should have been resolved before IL gen)");
		_ = 1249;
		_ = 1;
		_ = 0;
		_ = 1250;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime50 = dateTime + 440;
		*(DateTime*)(nint)dateTime50 = new DateTime(2017, 3, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1B8]");
		_ = 0;
		_ = 0;
		DateTime dateTime51 = dateTime + 432;
		*(DateTime*)(nint)dateTime51 = new DateTime(2017, 1, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1B0]");
		_ = 0;
		nint num89 = 0;
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2162 @ S5_v218 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2163 @ S5_v219+4] (should have been resolved before IL gen)");
		_ = 1272;
		_ = 1;
		_ = 0;
		_ = 1273;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime52 = dateTime + 424;
		*(DateTime*)(nint)dateTime52 = new DateTime(2015, 7, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1A8]");
		_ = 0;
		_ = 0;
		DateTime dateTime53 = dateTime + 416;
		*(DateTime*)(nint)dateTime53 = new DateTime(2015, 5, 7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+1A0]");
		_ = 0;
		nint num91 = 0;
		nint num92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2222 @ S5_v223 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2223 @ S5_v224+4] (should have been resolved before IL gen)");
		_ = 1277;
		_ = 1;
		_ = 0;
		_ = 1278;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime54 = dateTime + 408;
		*(DateTime*)(nint)dateTime54 = new DateTime(2016, 6, 27);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+198]");
		_ = 0;
		_ = 0;
		DateTime dateTime55 = dateTime + 400;
		*(DateTime*)(nint)dateTime55 = new DateTime(2016, 9, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+190]");
		_ = 0;
		nint num93 = 0;
		nint num94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2282 @ S5_v228 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2283 @ S5_v229+4] (should have been resolved before IL gen)");
		_ = 1280;
		_ = 1;
		_ = 0;
		_ = 1281;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime56 = dateTime + 392;
		*(DateTime*)(nint)dateTime56 = new DateTime(2015, 6, 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+188]");
		_ = 0;
		_ = 0;
		DateTime dateTime57 = dateTime + 384;
		*(DateTime*)(nint)dateTime57 = new DateTime(2015, 8, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+180]");
		_ = 0;
		nint num95 = 0;
		nint num96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2342 @ S5_v233 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2343 @ S5_v234+4] (should have been resolved before IL gen)");
		_ = 1291;
		_ = 1;
		_ = 0;
		_ = 1292;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime58 = dateTime + 376;
		*(DateTime*)(nint)dateTime58 = new DateTime(2015, 7, 15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+178]");
		_ = 0;
		_ = 0;
		DateTime dateTime59 = dateTime + 368;
		*(DateTime*)(nint)dateTime59 = new DateTime(2015, 9, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+170]");
		_ = 0;
		nint num97 = 0;
		nint num98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2402 @ S5_v238 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2403 @ S5_v239+4] (should have been resolved before IL gen)");
		_ = 1300;
		_ = 1;
		_ = 0;
		_ = 1301;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime60 = dateTime + 360;
		*(DateTime*)(nint)dateTime60 = new DateTime(2015, 9, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+168]");
		_ = 0;
		_ = 0;
		DateTime dateTime61 = dateTime + 352;
		*(DateTime*)(nint)dateTime61 = new DateTime(2015, 10, 15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+160]");
		_ = 0;
		nint num99 = 0;
		nint num100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ S5_v243 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2463 @ S5_v244+4] (should have been resolved before IL gen)");
		_ = 1308;
		_ = 1;
		_ = 0;
		_ = 1309;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime62 = dateTime + 344;
		*(DateTime*)(nint)dateTime62 = new DateTime(2016, 9, 23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+158]");
		_ = 0;
		_ = 0;
		DateTime dateTime63 = dateTime + 336;
		*(DateTime*)(nint)dateTime63 = new DateTime(2016, 11, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+150]");
		_ = 0;
		nint num101 = 0;
		nint num102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2522 @ S5_v248 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2523 @ S5_v249+4] (should have been resolved before IL gen)");
		_ = 1317;
		_ = 1;
		_ = 0;
		_ = 1318;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime64 = dateTime + 328;
		*(DateTime*)(nint)dateTime64 = new DateTime(2015, 11, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+148]");
		_ = 0;
		_ = 0;
		DateTime dateTime65 = dateTime + 320;
		*(DateTime*)(nint)dateTime65 = new DateTime(2015, 12, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+140]");
		_ = 0;
		nint num103 = 0;
		nint num104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2582 @ S5_v253 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2583 @ S5_v254+4] (should have been resolved before IL gen)");
		_ = 1325;
		_ = 1;
		_ = 0;
		_ = 1326;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime66 = dateTime + 312;
		*(DateTime*)(nint)dateTime66 = new DateTime(2016, 12, 19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+138]");
		_ = 0;
		_ = 0;
		DateTime dateTime67 = dateTime + 304;
		*(DateTime*)(nint)dateTime67 = new DateTime(2017, 2, 9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+130]");
		_ = 0;
		nint num105 = 0;
		nint num106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2642 @ S5_v258 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2643 @ S5_v259+4] (should have been resolved before IL gen)");
		_ = 1342;
		_ = 1;
		_ = 0;
		_ = 1343;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime68 = dateTime + 296;
		*(DateTime*)(nint)dateTime68 = new DateTime(2016, 1, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+128]");
		_ = 0;
		_ = 0;
		DateTime dateTime69 = dateTime + 288;
		*(DateTime*)(nint)dateTime69 = new DateTime(2016, 3, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+120]");
		_ = 0;
		nint num107 = 0;
		nint num108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2702 @ S5_v263 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2703 @ S5_v264+4] (should have been resolved before IL gen)");
		_ = 1359;
		_ = 1;
		_ = 0;
		_ = 1360;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime70 = dateTime + 280;
		*(DateTime*)(nint)dateTime70 = new DateTime(2016, 3, 30);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+118]");
		_ = 0;
		_ = 0;
		DateTime dateTime71 = dateTime + 272;
		*(DateTime*)(nint)dateTime71 = new DateTime(2016, 5, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+110]");
		_ = 0;
		nint num109 = 0;
		nint num110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2762 @ S5_v268 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2763 @ S5_v269+4] (should have been resolved before IL gen)");
		_ = 1351;
		_ = 1;
		_ = 0;
		_ = 1352;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime72 = dateTime + 264;
		*(DateTime*)(nint)dateTime72 = new DateTime(2016, 1, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+108]");
		_ = 0;
		_ = 0;
		DateTime dateTime73 = dateTime + 256;
		*(DateTime*)(nint)dateTime73 = new DateTime(2016, 4, 21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+100]");
		_ = 0;
		nint num111 = 0;
		nint num112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2822 @ S5_v273 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2823 @ S5_v274+4] (should have been resolved before IL gen)");
		_ = 1364;
		_ = 1;
		_ = 0;
		_ = 1365;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime74 = dateTime + 248;
		*(DateTime*)(nint)dateTime74 = new DateTime(2017, 5, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+F8]");
		_ = 0;
		_ = 0;
		DateTime dateTime75 = dateTime + 240;
		*(DateTime*)(nint)dateTime75 = new DateTime(2017, 6, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+F0]");
		_ = 0;
		nint num113 = 0;
		nint num114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2882 @ S5_v278 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2883 @ S5_v279+4] (should have been resolved before IL gen)");
		_ = 1373;
		_ = 1;
		_ = 0;
		_ = 1374;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime76 = dateTime + 232;
		*(DateTime*)(nint)dateTime76 = new DateTime(2016, 5, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+E8]");
		_ = 0;
		_ = 0;
		DateTime dateTime77 = dateTime + 224;
		*(DateTime*)(nint)dateTime77 = new DateTime(2016, 7, 14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+E0]");
		_ = 0;
		nint num115 = 0;
		nint num116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ S5_v283 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2943 @ S5_v284+4] (should have been resolved before IL gen)");
		_ = 1376;
		_ = 1;
		_ = 0;
		_ = 1377;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime78 = dateTime + 216;
		*(DateTime*)(nint)dateTime78 = new DateTime(2016, 6, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+D8]");
		_ = 0;
		_ = 0;
		DateTime dateTime79 = dateTime + 208;
		*(DateTime*)(nint)dateTime79 = new DateTime(2016, 8, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+D0]");
		_ = 0;
		nint num117 = 0;
		nint num118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3002 @ S5_v288 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3003 @ S5_v289+4] (should have been resolved before IL gen)");
		_ = 1380;
		_ = 0;
		_ = 0;
		_ = 1381;
		_ = 0;
		_ = 3;
		_ = 60;
		nint num119 = 0;
		nint num120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3038 @ S5_v293 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3039 @ S5_v294+4] (should have been resolved before IL gen)");
		_ = 1389;
		_ = 1;
		_ = 0;
		_ = 1390;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime80 = dateTime + 200;
		*(DateTime*)(nint)dateTime80 = new DateTime(2016, 7, 14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+C8]");
		_ = 0;
		_ = 0;
		DateTime dateTime81 = dateTime + 192;
		*(DateTime*)(nint)dateTime81 = new DateTime(2016, 9, 22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+C0]");
		_ = 0;
		nint num121 = 0;
		nint num122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3098 @ S5_v298 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3099 @ S5_v299+4] (should have been resolved before IL gen)");
		_ = 1394;
		_ = 1;
		_ = 0;
		_ = 1395;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime82 = dateTime + 184;
		*(DateTime*)(nint)dateTime82 = new DateTime(2016, 8, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+B8]");
		_ = 0;
		_ = 0;
		DateTime dateTime83 = dateTime + 176;
		*(DateTime*)(nint)dateTime83 = new DateTime(2016, 10, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+B0]");
		_ = 0;
		nint num123 = 0;
		nint num124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3158 @ S5_v303 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3159 @ S5_v304+4] (should have been resolved before IL gen)");
		_ = 792;
		_ = 1;
		_ = 0;
		_ = 791;
		_ = 0;
		_ = 6;
		_ = 0;
		DateTime dateTime84 = dateTime + 168;
		*(DateTime*)(nint)dateTime84 = new DateTime(2016, 9, 23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+A8]");
		_ = 0;
		_ = 0;
		DateTime dateTime85 = dateTime + 160;
		*(DateTime*)(nint)dateTime85 = new DateTime(2016, 11, 3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+A0]");
		_ = 0;
		nint num125 = 0;
		nint num126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3216 @ S5_v308 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3217 @ S5_v309+4] (should have been resolved before IL gen)");
		_ = 1398;
		_ = 1;
		_ = 0;
		_ = 1399;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime86 = dateTime + 152;
		*(DateTime*)(nint)dateTime86 = new DateTime(2016, 10, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+98]");
		_ = 0;
		_ = 0;
		DateTime dateTime87 = dateTime + 144;
		*(DateTime*)(nint)dateTime87 = new DateTime(2016, 12, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+90]");
		_ = 0;
		nint num127 = 0;
		nint num128 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3276 @ S5_v313 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3277 @ S5_v314+4] (should have been resolved before IL gen)");
		_ = 1407;
		_ = 1;
		_ = 0;
		_ = 1408;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime88 = dateTime + 136;
		*(DateTime*)(nint)dateTime88 = new DateTime(2016, 10, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+88]");
		_ = 0;
		_ = 0;
		DateTime dateTime89 = dateTime + 128;
		*(DateTime*)(nint)dateTime89 = new DateTime(2016, 12, 29);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+80]");
		_ = 0;
		nint num129 = 0;
		nint num130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3336 @ S5_v318 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3337 @ S5_v319+4] (should have been resolved before IL gen)");
		_ = 1412;
		_ = 1;
		_ = 0;
		_ = 1413;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime90 = dateTime + 120;
		*(DateTime*)(nint)dateTime90 = new DateTime(2016, 11, 7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+78]");
		_ = 0;
		_ = 0;
		DateTime dateTime91 = dateTime + 112;
		*(DateTime*)(nint)dateTime91 = new DateTime(2017, 1, 19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+70]");
		_ = 0;
		nint num131 = 0;
		nint num132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3396 @ S5_v323 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3397 @ S5_v324+4] (should have been resolved before IL gen)");
		_ = 1441;
		_ = 1;
		_ = 0;
		_ = 1442;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime92 = dateTime + 104;
		*(DateTime*)(nint)dateTime92 = new DateTime(2017, 1, 5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+68]");
		_ = 0;
		_ = 0;
		DateTime dateTime93 = dateTime + 96;
		*(DateTime*)(nint)dateTime93 = new DateTime(2017, 3, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+60]");
		_ = 0;
		nint num133 = 0;
		nint num134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3456 @ S5_v328 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3457 @ S5_v329+4] (should have been resolved before IL gen)");
		_ = 1460;
		_ = 1;
		_ = 0;
		_ = 1461;
		_ = 1462;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime94 = dateTime + 88;
		*(DateTime*)(nint)dateTime94 = new DateTime(2017, 3, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+58]");
		_ = 0;
		_ = 0;
		DateTime dateTime95 = dateTime + 80;
		*(DateTime*)(nint)dateTime95 = new DateTime(2017, 4, 20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+50]");
		_ = 0;
		nint num135 = 0;
		nint num136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3516 @ S5_v333 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3517 @ S5_v334+4] (should have been resolved before IL gen)");
		_ = 1495;
		_ = 1;
		_ = 0;
		_ = 1496;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime96 = dateTime + 72;
		*(DateTime*)(nint)dateTime96 = new DateTime(2017, 4, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+48]");
		_ = 0;
		_ = 0;
		DateTime dateTime97 = dateTime - -64;
		*(DateTime*)(nint)dateTime97 = new DateTime(2017, 6, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+40]");
		_ = 0;
		nint num137 = 0;
		nint num138 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3576 @ S5_v338 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3577 @ S5_v339+4] (should have been resolved before IL gen)");
		_ = 1465;
		_ = 1;
		_ = 0;
		_ = 1466;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime98 = dateTime + 56;
		*(DateTime*)(nint)dateTime98 = new DateTime(2017, 3, 29);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+38]");
		_ = 0;
		_ = 0;
		DateTime dateTime99 = dateTime + 48;
		*(DateTime*)(nint)dateTime99 = new DateTime(2017, 5, 11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+30]");
		_ = 0;
		nint num139 = 0;
		nint num140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3636 @ S5_v343 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3637 @ S5_v344+4] (should have been resolved before IL gen)");
		_ = 1497;
		_ = 1;
		_ = 0;
		_ = 1498;
		_ = 0;
		_ = 2;
		_ = 0;
		_ = 0;
		DateTime dateTime100 = dateTime + 40;
		*(DateTime*)(nint)dateTime100 = new DateTime(2017, 4, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+28]");
		_ = 0;
		_ = 0;
		DateTime dateTime101 = dateTime + 32;
		*(DateTime*)(nint)dateTime101 = new DateTime(2017, 6, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+20]");
		_ = 0;
		nint num141 = 0;
		nint num142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3696 @ S5_v348 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3697 @ S5_v349+4] (should have been resolved before IL gen)");
		_ = 1499;
		_ = 1;
		_ = 0;
		_ = 1500;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime102 = dateTime + 24;
		*(DateTime*)(nint)dateTime102 = new DateTime(2017, 5, 17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+18]");
		_ = 0;
		_ = 0;
		DateTime dateTime103 = dateTime + 16;
		*(DateTime*)(nint)dateTime103 = new DateTime(2017, 7, 13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+10]");
		_ = 0;
		nint num143 = 0;
		nint num144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3756 @ S5_v353 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3757 @ S5_v354+4] (should have been resolved before IL gen)");
		_ = 1517;
		_ = 1;
		_ = 0;
		_ = 1518;
		_ = 0;
		_ = 2;
		_ = 50000;
		_ = 0;
		DateTime dateTime104 = dateTime + 8;
		*(DateTime*)(nint)dateTime104 = new DateTime(2017, 5, 17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
		_ = 0;
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		*(DateTime*)(nint)dateTime = new DateTime(2017, 8, 10);
		_ = dateTime._dateData;
		nint num145 = 0;
		nint num146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3814 @ S5_v358 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, Hoverboards+Board>>)+5C]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3815 @ S5_v359+4] (should have been resolved before IL gen)");
		Dictionary<BoardType, Board> dictionary = default;
		boardData = dictionary;
		List<BoardType> list2 = default;
		list2._002Ector();
		list2.Add(BoardType.halloweenBoard02);
		exclusiveAndroidBoards = list2;
		List<BoardType> list3 = default;
		list3._002Ector();
		list3.Add(BoardType.snowboard);
		list3.Add(BoardType.bouncer);
		list3.Add(BoardType.hotrod);
		list3.Add(BoardType.teleboard);
		list3.Add(BoardType.skullfire);
		list3.Add(BoardType.normal);
		list3.Add(BoardType.flamingo);
		list3.Add(BoardType.shanghaiBoard01);
		list3.Add(BoardType.marrakeshBoard01);
		list3.Add(BoardType.peruBoard01);
		list3.Add(BoardType.copenhagenBoard01);
		list3.Add(BoardType.birthdayBoard01);
		list3.Add(BoardType.hawaiiBoard02);
		list3.Add(BoardType.monacoBoard01);
		list3.Add(BoardType.chick);
		list3.Add(BoardType.bangkokBoard01);
		list3.Add(BoardType.arabiaBoard02);
		list3.Add(BoardType.arabiaBoard01);
		list3.Add(BoardType.sanfranciscoBoard01);
		list3.Add(BoardType.amsterdamBoard01);
		list3.Add(BoardType.northpoleBoard02);
		list3.Add(BoardType.londonBoard03);
		list3.Add(BoardType.washingtonBoard01);
		list3.Add(BoardType.halloweenBoard02);
		list3.Add(BoardType.transylvaniaBoard01);
		list3.Add(BoardType.havanaBoard01);
		list3.Add(BoardType.icelandBoard01);
		list3.Add(BoardType.rioBoard02);
		list3.Add(BoardType.rioBoard01);
		list3.Add(BoardType.veniceBoard02);
		list3.Add(BoardType.singaporeBoard01);
		list3.Add(BoardType.lasVegasBoard01);
		list3.Add(BoardType.sydneyBoard02);
		list3.Add(BoardType.madagascarBoard01);
		list3.Add(BoardType.pragueBoard01);
		list3.Add(BoardType.hawaiiBoard01);
		list3.Add(BoardType.northpoleBoard01);
		list3.Add(BoardType.londonBoard01);
		list3.Add(BoardType.kitty);
		list3.Add(BoardType.kenyaBoard01);
		list3.Add(BoardType.liberty);
		list3.Add(BoardType.greeceBoard01);
		list3.Add(BoardType.sydneyBoard01);
		list3.Add(BoardType.veniceBoard01);
		list3.Add(BoardType.losangelesBoard01);
		list3.Add(BoardType.cairoBoard01);
		list3.Add(BoardType.saopauloBoard01);
		list3.Add(BoardType.vancouverBoard01);
		list3.Add(BoardType.mexicoBoard01);
		list3.Add(BoardType.seoulBoard01);
		list3.Add(BoardType.mumbaiBoard01);
		list3.Add(BoardType.londonBoard02);
		list3.Add(BoardType.halloweenBoard01);
		list3.Add(BoardType.moscowBoard01);
		list3.Add(BoardType.panda);
		list3.Add(BoardType.dragon);
		list3.Add(BoardType.rose);
		list3.Add(BoardType.toucan);
		list3.Add(BoardType.soccer);
		list3.Add(BoardType.cherry);
		list3.Add(BoardType.theOutback);
		list3.Add(BoardType.lowrider);
		list3.Add(BoardType.starboard);
		list3.Add(BoardType.speedboard);
		list3.Add(BoardType.greatWhiteWakeboard);
		list3.Add(BoardType.gliderboard);
		list3.Add(BoardType.rome);
		list3.Add(BoardType.treehugger);
		list3.Add(BoardType.theoriginal);
		list3.Add(BoardType.surfboard);
		list3.Add(BoardType.miami);
		list3.Add(BoardType.monster);
		boardOrder = list3;
	}
}
