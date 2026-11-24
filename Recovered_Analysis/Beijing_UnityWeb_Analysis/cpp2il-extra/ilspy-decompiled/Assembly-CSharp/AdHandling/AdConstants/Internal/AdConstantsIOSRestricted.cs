using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsIOSRestricted : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _flurryAdCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _adColonyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _tapjoyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _chartboostCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _inmobiCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _vungleCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _supersonicCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _facebookCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _mobvistaCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _yeahMobiCacheIDs;

	public bool isRestricted
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_yeahMobiCacheIDs != 0;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (Dictionary<AdLocationInfo, string>)1;
		}
	}

	public string AdColonyAppId => (string)(object)_flurryAdCacheIDs;

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"app5e9882cd3d6d44d6b3";

	public string TapJoyAppId => (string)(object)_adColonyCacheIDs;

	public string TapJoyAppKey => "";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string ChartboostAppId => (string)(object)_tapjoyCacheIDs;

	public string ChartboostAppSignature => "5922afa5f6cd4555d6ac141e";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"e2ef6a4792d5fd86f5dd4796b451f6d1b5bf2e27";

	public string InmobiAccountId => (string)(object)_chartboostCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"6c7ea8566bfd4b2c82269e3647046624";

	public string VungleAppId => (string)(object)_inmobiCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"591c3a6b1950241f4a000366";

	public string SupersonicAppId => (string)(object)_vungleCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"499b4845";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _supersonicCacheIDs;

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => _facebookCacheIDs;

	public string MobVistaAppId => (string)(object)_mobvistaCacheIDs;

	public string MobVistaAppSdkKey => "101367";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"f51fde5b5c666de31358328df8b3141a";

	public AdConstantsIOSRestricted()
	{
		//IL_14cf: Expected Obj, but got I
		//IL_14df: Expected Obj, but got I
		//IL_14f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f5: Expected Obj, but got Unknown
		//IL_14fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1503: Expected Obj, but got Unknown
		//IL_151b: Expected I, but got Obj
		//IL_1531: Expected Obj, but got I
		//IL_1564: Expected Obj, but got I
		//IL_1574: Expected Obj, but got I
		//IL_1584: Expected Obj, but got I
		//IL_158d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1592: Expected Obj, but got Unknown
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Expected Obj, but got Unknown
		//IL_15c0: Expected Obj, but got I
		//IL_15d0: Expected Obj, but got I
		//IL_15e0: Expected Obj, but got I
		//IL_15e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ee: Expected Obj, but got Unknown
		//IL_15f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fc: Expected Obj, but got Unknown
		//IL_161c: Expected Obj, but got I
		//IL_162c: Expected Obj, but got I
		//IL_163c: Expected Obj, but got I
		//IL_1645: Unknown result type (might be due to invalid IL or missing references)
		//IL_164a: Expected Obj, but got Unknown
		//IL_1653: Unknown result type (might be due to invalid IL or missing references)
		//IL_1658: Expected Obj, but got Unknown
		//IL_1678: Expected Obj, but got I
		//IL_1688: Expected Obj, but got I
		//IL_1698: Expected Obj, but got I
		//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a6: Expected Obj, but got Unknown
		//IL_16af: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b4: Expected Obj, but got Unknown
		//IL_16d4: Expected Obj, but got I
		//IL_16e4: Expected Obj, but got I
		//IL_16f4: Expected Obj, but got I
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected Obj, but got Unknown
		//IL_170b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1710: Expected Obj, but got Unknown
		//IL_1730: Expected Obj, but got I
		//IL_1740: Expected Obj, but got I
		//IL_1750: Expected Obj, but got I
		//IL_1759: Unknown result type (might be due to invalid IL or missing references)
		//IL_175e: Expected Obj, but got Unknown
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_176c: Expected Obj, but got Unknown
		//IL_178c: Expected Obj, but got I
		//IL_179c: Expected Obj, but got I
		//IL_17ac: Expected Obj, but got I
		//IL_17b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ba: Expected Obj, but got Unknown
		//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c8: Expected Obj, but got Unknown
		//IL_17e8: Expected Obj, but got I
		//IL_17f8: Expected Obj, but got I
		//IL_1808: Expected Obj, but got I
		//IL_1811: Unknown result type (might be due to invalid IL or missing references)
		//IL_1816: Expected Obj, but got Unknown
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1824: Expected Obj, but got Unknown
		//IL_1834: Unknown result type (might be due to invalid IL or missing references)
		//IL_1839: Expected Obj, but got Unknown
		//IL_1861: Expected Obj, but got I
		//IL_1871: Expected Obj, but got I
		//IL_1882: Unknown result type (might be due to invalid IL or missing references)
		//IL_1887: Expected Obj, but got Unknown
		//IL_1890: Unknown result type (might be due to invalid IL or missing references)
		//IL_1895: Expected Obj, but got Unknown
		//IL_18b5: Expected Obj, but got I
		//IL_18c5: Expected Obj, but got I
		//IL_18d5: Expected Obj, but got I
		//IL_18de: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e3: Expected Obj, but got Unknown
		//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f1: Expected Obj, but got Unknown
		//IL_1911: Expected Obj, but got I
		//IL_1921: Expected Obj, but got I
		//IL_1931: Expected Obj, but got I
		//IL_193a: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected Obj, but got Unknown
		//IL_1948: Unknown result type (might be due to invalid IL or missing references)
		//IL_194d: Expected Obj, but got Unknown
		//IL_196d: Expected Obj, but got I
		//IL_197d: Expected Obj, but got I
		//IL_198d: Expected Obj, but got I
		//IL_1996: Unknown result type (might be due to invalid IL or missing references)
		//IL_199b: Expected Obj, but got Unknown
		//IL_19a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a9: Expected Obj, but got Unknown
		//IL_19c9: Expected Obj, but got I
		//IL_19d9: Expected Obj, but got I
		//IL_19e9: Expected Obj, but got I
		//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f7: Expected Obj, but got Unknown
		//IL_1a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a05: Expected Obj, but got Unknown
		//IL_1a25: Expected Obj, but got I
		//IL_1a35: Expected Obj, but got I
		//IL_1a45: Expected Obj, but got I
		//IL_1a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Expected Obj, but got Unknown
		//IL_1a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a61: Expected Obj, but got Unknown
		//IL_1a81: Expected Obj, but got I
		//IL_1a91: Expected Obj, but got I
		//IL_1aa1: Expected Obj, but got I
		//IL_1aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aaf: Expected Obj, but got Unknown
		//IL_1ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abd: Expected Obj, but got Unknown
		//IL_1add: Expected Obj, but got I
		//IL_1aed: Expected Obj, but got I
		//IL_1afd: Expected Obj, but got I
		//IL_1b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0b: Expected Obj, but got Unknown
		//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b19: Expected Obj, but got Unknown
		//IL_1b39: Expected Obj, but got I
		//IL_1b49: Expected Obj, but got I
		//IL_1b59: Expected Obj, but got I
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b67: Expected Obj, but got Unknown
		//IL_1b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b75: Expected Obj, but got Unknown
		//IL_1b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8a: Expected Obj, but got Unknown
		//IL_1bb2: Expected Obj, but got I
		//IL_1bc2: Expected Obj, but got I
		//IL_1bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd8: Expected Obj, but got Unknown
		//IL_1be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be6: Expected Obj, but got Unknown
		//IL_1c06: Expected Obj, but got I
		//IL_1c16: Expected Obj, but got I
		//IL_1c26: Expected Obj, but got I
		//IL_1c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c34: Expected Obj, but got Unknown
		//IL_1c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c42: Expected Obj, but got Unknown
		//IL_1c62: Expected Obj, but got I
		//IL_1c72: Expected Obj, but got I
		//IL_1c82: Expected Obj, but got I
		//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Expected Obj, but got Unknown
		//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9e: Expected Obj, but got Unknown
		//IL_1cbe: Expected Obj, but got I
		//IL_1cce: Expected Obj, but got I
		//IL_1cde: Expected Obj, but got I
		//IL_1ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cec: Expected Obj, but got Unknown
		//IL_1cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfa: Expected Obj, but got Unknown
		//IL_1d1a: Expected Obj, but got I
		//IL_1d2a: Expected Obj, but got I
		//IL_1d3a: Expected Obj, but got I
		//IL_1d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d48: Expected Obj, but got Unknown
		//IL_1d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d56: Expected Obj, but got Unknown
		//IL_1d76: Expected Obj, but got I
		//IL_1d86: Expected Obj, but got I
		//IL_1d96: Expected Obj, but got I
		//IL_1d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da4: Expected Obj, but got Unknown
		//IL_1dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db2: Expected Obj, but got Unknown
		//IL_1dd2: Expected Obj, but got I
		//IL_1de2: Expected Obj, but got I
		//IL_1df2: Expected Obj, but got I
		//IL_1dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e00: Expected Obj, but got Unknown
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0e: Expected Obj, but got Unknown
		//IL_1e2e: Expected Obj, but got I
		//IL_1e3e: Expected Obj, but got I
		//IL_1e4e: Expected Obj, but got I
		//IL_1e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5c: Expected Obj, but got Unknown
		//IL_1e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Expected Obj, but got Unknown
		//IL_1e8a: Expected Obj, but got I
		//IL_1e9a: Expected Obj, but got I
		//IL_1eaa: Expected Obj, but got I
		//IL_1eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb8: Expected Obj, but got Unknown
		//IL_1ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec6: Expected Obj, but got Unknown
		//IL_1ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edb: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0340: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I
		//IL_04e5: Expected Obj, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0521: Expected Obj, but got I
		//IL_0531: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		//IL_05d9: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		//IL_05f9: Expected Obj, but got I
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_0635: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_0691: Expected Obj, but got I
		//IL_06a1: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06ed: Expected Obj, but got I
		//IL_06fd: Expected Obj, but got I
		//IL_070d: Expected Obj, but got I
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_0749: Expected Obj, but got I
		//IL_0759: Expected Obj, but got I
		//IL_0769: Expected Obj, but got I
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_0801: Expected Obj, but got I
		//IL_0811: Expected Obj, but got I
		//IL_0821: Expected Obj, but got I
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected Obj, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_087f: Expected Obj, but got I
		//IL_088f: Expected Obj, but got I
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected Obj, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected Obj, but got Unknown
		//IL_08d3: Expected Obj, but got I
		//IL_08e3: Expected Obj, but got I
		//IL_08f3: Expected Obj, but got I
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_092f: Expected Obj, but got I
		//IL_093f: Expected Obj, but got I
		//IL_094f: Expected Obj, but got I
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected Obj, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected Obj, but got Unknown
		//IL_098b: Expected Obj, but got I
		//IL_099b: Expected Obj, but got I
		//IL_09ab: Expected Obj, but got I
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected Obj, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected Obj, but got Unknown
		//IL_09e7: Expected Obj, but got I
		//IL_09f7: Expected Obj, but got I
		//IL_0a07: Expected Obj, but got I
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected Obj, but got Unknown
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a43: Expected Obj, but got I
		//IL_0a53: Expected Obj, but got I
		//IL_0a63: Expected Obj, but got I
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0a9f: Expected Obj, but got I
		//IL_0aaf: Expected Obj, but got I
		//IL_0abf: Expected Obj, but got I
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected Obj, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got Unknown
		//IL_0afb: Expected Obj, but got I
		//IL_0b0b: Expected Obj, but got I
		//IL_0b1b: Expected Obj, but got I
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b57: Expected Obj, but got I
		//IL_0b67: Expected Obj, but got I
		//IL_0b77: Expected Obj, but got I
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected Obj, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected Obj, but got Unknown
		//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Expected Obj, but got Unknown
		//IL_0bd0: Expected Obj, but got I
		//IL_0be0: Expected Obj, but got I
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected Obj, but got Unknown
		//IL_0c24: Expected Obj, but got I
		//IL_0c34: Expected Obj, but got I
		//IL_0c44: Expected Obj, but got I
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected Obj, but got Unknown
		//IL_0c80: Expected Obj, but got I
		//IL_0c90: Expected Obj, but got I
		//IL_0ca0: Expected Obj, but got I
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected Obj, but got Unknown
		//IL_0cdc: Expected Obj, but got I
		//IL_0cec: Expected Obj, but got I
		//IL_0cfc: Expected Obj, but got I
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected Obj, but got Unknown
		//IL_0d38: Expected Obj, but got I
		//IL_0d48: Expected Obj, but got I
		//IL_0d58: Expected Obj, but got I
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected Obj, but got Unknown
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected Obj, but got Unknown
		//IL_0d94: Expected Obj, but got I
		//IL_0da4: Expected Obj, but got I
		//IL_0db4: Expected Obj, but got I
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected Obj, but got Unknown
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected Obj, but got Unknown
		//IL_0df0: Expected Obj, but got I
		//IL_0e00: Expected Obj, but got I
		//IL_0e10: Expected Obj, but got I
		//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected Obj, but got Unknown
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Expected Obj, but got Unknown
		//IL_0e4c: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I
		//IL_0e6c: Expected Obj, but got I
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected Obj, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected Obj, but got Unknown
		//IL_0ea8: Expected Obj, but got I
		//IL_0eb8: Expected Obj, but got I
		//IL_0ec8: Expected Obj, but got I
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected Obj, but got Unknown
		//IL_0edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Expected Obj, but got Unknown
		//IL_0f04: Expected Obj, but got I
		//IL_0f14: Expected Obj, but got I
		//IL_0f24: Expected Obj, but got I
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f32: Expected Obj, but got Unknown
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f40: Expected Obj, but got Unknown
		//IL_0f60: Expected Obj, but got I
		//IL_0f70: Expected Obj, but got I
		//IL_0f80: Expected Obj, but got I
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected Obj, but got Unknown
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Expected Obj, but got Unknown
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Expected Obj, but got Unknown
		//IL_0fde: Expected Obj, but got I
		//IL_0fee: Expected Obj, but got I
		//IL_0fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected Obj, but got Unknown
		//IL_100d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Expected Obj, but got Unknown
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1027: Expected Obj, but got Unknown
		//IL_104f: Expected Obj, but got I
		//IL_105f: Expected Obj, but got I
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Expected Obj, but got Unknown
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Expected Obj, but got Unknown
		//IL_10a3: Expected Obj, but got I
		//IL_10b3: Expected Obj, but got I
		//IL_10c3: Expected Obj, but got I
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected Obj, but got Unknown
		//IL_10da: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Expected Obj, but got Unknown
		//IL_10ff: Expected Obj, but got I
		//IL_110f: Expected Obj, but got I
		//IL_111f: Expected Obj, but got I
		//IL_1128: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected Obj, but got Unknown
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_113b: Expected Obj, but got Unknown
		//IL_115b: Expected Obj, but got I
		//IL_116b: Expected Obj, but got I
		//IL_117b: Expected Obj, but got I
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected Obj, but got Unknown
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_1197: Expected Obj, but got Unknown
		//IL_11b7: Expected Obj, but got I
		//IL_11c7: Expected Obj, but got I
		//IL_11d7: Expected Obj, but got I
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e5: Expected Obj, but got Unknown
		//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Expected Obj, but got Unknown
		//IL_1203: Unknown result type (might be due to invalid IL or missing references)
		//IL_1208: Expected Obj, but got Unknown
		//IL_1235: Expected Obj, but got I
		//IL_1245: Expected Obj, but got I
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected Obj, but got Unknown
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_1269: Expected Obj, but got Unknown
		//IL_1289: Expected Obj, but got I
		//IL_1299: Expected Obj, but got I
		//IL_12a9: Expected Obj, but got I
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected Obj, but got Unknown
		//IL_12c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c5: Expected Obj, but got Unknown
		//IL_12e5: Expected Obj, but got I
		//IL_12f5: Expected Obj, but got I
		//IL_1305: Expected Obj, but got I
		//IL_130e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Expected Obj, but got Unknown
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Expected Obj, but got Unknown
		//IL_1341: Expected Obj, but got I
		//IL_1351: Expected Obj, but got I
		//IL_1361: Expected Obj, but got I
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_136f: Expected Obj, but got Unknown
		//IL_1378: Unknown result type (might be due to invalid IL or missing references)
		//IL_137d: Expected Obj, but got Unknown
		//IL_139d: Expected Obj, but got I
		//IL_13ad: Expected Obj, but got I
		//IL_13bd: Expected Obj, but got I
		//IL_13c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb: Expected Obj, but got Unknown
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d9: Expected Obj, but got Unknown
		//IL_13f9: Expected Obj, but got I
		//IL_1409: Expected Obj, but got I
		//IL_1419: Expected Obj, but got I
		//IL_1422: Unknown result type (might be due to invalid IL or missing references)
		//IL_1427: Expected Obj, but got Unknown
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_1435: Expected Obj, but got Unknown
		//IL_1455: Expected Obj, but got I
		//IL_1465: Expected Obj, but got I
		//IL_1475: Expected Obj, but got I
		//IL_147e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected Obj, but got Unknown
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected Obj, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9 (Il2CppClass<AdLocations>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v204 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S4_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S4_v8+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S5_v6 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v12+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v13+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v85 @ S5_v10 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v17+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v18+48]");
		object obj19 = 0;
		object obj20 = obj19 & 0x7FF;
		object obj21 = obj20 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v14 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v22+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v23+48]");
		object obj24 = 0;
		object obj25 = obj24 & 0x7FF;
		object obj26 = obj25 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S5_v18 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v27+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v28+48]");
		object obj29 = 0;
		object obj30 = obj29 & 0x7FF;
		object obj31 = obj30 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148 @ S5_v22 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S4_v32+60]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v33+48]");
		object obj34 = 0;
		object obj35 = obj34 & 0x7FF;
		object obj36 = obj35 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169 @ S5_v26 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S4_v37+60]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v38+48]");
		object obj39 = 0;
		object obj40 = obj39 & 0x7FF;
		object obj41 = obj40 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v190 @ S5_v30 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S4_v42+60]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S4_v43+48]");
		object obj44 = 0;
		object obj45 = obj44 & 0x7FF;
		object obj46 = obj45 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v211 @ S5_v34 (should have been resolved before IL gen)");
		object obj47 = this + 8;
		object obj48 = default;
		obj47 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S3_v15 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S3_v16+60]");
		object obj50 = 0;
		object obj51 = obj50;
		object obj52 = obj51 & 0x1FFF;
		object obj53 = obj52 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v236 @ S4_v48 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S4_v50 (Il2CppMethodInfo)+C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S4_v51+60]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S4_v52+48]");
		object obj56 = 0;
		object obj57 = obj56 & 0x7FF;
		object obj58 = obj57 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v257 @ S5_v40 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S4_v55 (Il2CppMethodInfo)+C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v56+60]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S4_v57+48]");
		object obj61 = 0;
		object obj62 = obj61 & 0x7FF;
		object obj63 = obj62 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v278 @ S5_v44 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S4_v60 (Il2CppMethodInfo)+C]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S4_v61+60]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S4_v62+48]");
		object obj66 = 0;
		object obj67 = obj66 & 0x7FF;
		object obj68 = obj67 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v299 @ S5_v48 (should have been resolved before IL gen)");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S4_v65 (Il2CppMethodInfo)+C]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v66+60]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v67+48]");
		object obj71 = 0;
		object obj72 = obj71 & 0x7FF;
		object obj73 = obj72 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v320 @ S5_v52 (should have been resolved before IL gen)");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S4_v70 (Il2CppMethodInfo)+C]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S4_v71+60]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S4_v72+48]");
		object obj76 = 0;
		object obj77 = obj76 & 0x7FF;
		object obj78 = obj77 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v341 @ S5_v56 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S4_v75 (Il2CppMethodInfo)+C]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S4_v76+60]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S4_v77+48]");
		object obj81 = 0;
		object obj82 = obj81 & 0x7FF;
		object obj83 = obj82 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v362 @ S5_v60 (should have been resolved before IL gen)");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S4_v80 (Il2CppMethodInfo)+C]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S4_v81+60]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S4_v82+48]");
		object obj86 = 0;
		object obj87 = obj86 & 0x7FF;
		object obj88 = obj87 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v383 @ S5_v64 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S4_v85 (Il2CppMethodInfo)+C]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S4_v86+60]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S4_v87+48]");
		object obj91 = 0;
		object obj92 = obj91 & 0x7FF;
		object obj93 = obj92 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v404 @ S5_v68 (should have been resolved before IL gen)");
		object obj94 = this + 12;
		object obj95 = default;
		obj94 = obj95;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S3_v28 (Il2CppMethodInfo)+C]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S3_v29+60]");
		object obj97 = 0;
		object obj98 = obj97;
		object obj99 = obj98 & 0x1FFF;
		object obj100 = obj99 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v428 @ S4_v92 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S4_v94 (Il2CppMethodInfo)+C]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S4_v95+60]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S4_v96+48]");
		object obj103 = 0;
		object obj104 = obj103 & 0x7FF;
		object obj105 = obj104 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v449 @ S5_v74 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S4_v99 (Il2CppMethodInfo)+C]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S4_v100+60]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S4_v101+48]");
		object obj108 = 0;
		object obj109 = obj108 & 0x7FF;
		object obj110 = obj109 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v470 @ S5_v78 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S4_v104 (Il2CppMethodInfo)+C]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S4_v105+60]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S4_v106+48]");
		object obj113 = 0;
		object obj114 = obj113 & 0x7FF;
		object obj115 = obj114 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v491 @ S5_v82 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S4_v109 (Il2CppMethodInfo)+C]");
		object obj116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S4_v110+60]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S4_v111+48]");
		object obj118 = 0;
		object obj119 = obj118 & 0x7FF;
		object obj120 = obj119 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v512 @ S5_v86 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S4_v114 (Il2CppMethodInfo)+C]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S4_v115+60]");
		object obj122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S4_v116+48]");
		object obj123 = 0;
		object obj124 = obj123 & 0x7FF;
		object obj125 = obj124 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v533 @ S5_v90 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S4_v119 (Il2CppMethodInfo)+C]");
		object obj126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S4_v120+60]");
		object obj127 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S4_v121+48]");
		object obj128 = 0;
		object obj129 = obj128 & 0x7FF;
		object obj130 = obj129 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v554 @ S5_v94 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S4_v124 (Il2CppMethodInfo)+C]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S4_v125+60]");
		object obj132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S4_v126+48]");
		object obj133 = 0;
		object obj134 = obj133 & 0x7FF;
		object obj135 = obj134 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v575 @ S5_v98 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S4_v129 (Il2CppMethodInfo)+C]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S4_v130+60]");
		object obj137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S4_v131+48]");
		object obj138 = 0;
		object obj139 = obj138 & 0x7FF;
		object obj140 = obj139 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v596 @ S5_v102 (should have been resolved before IL gen)");
		object obj141 = this + 16;
		object obj142 = default;
		obj141 = obj142;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S3_v41 (Il2CppMethodInfo)+C]");
		object obj143 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ S3_v42+60]");
		object obj144 = 0;
		object obj145 = obj144;
		object obj146 = obj145 & 0x1FFF;
		object obj147 = obj146 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v619 @ S4_v136 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S4_v138 (Il2CppMethodInfo)+C]");
		object obj148 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S4_v139+60]");
		object obj149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S4_v140+48]");
		object obj150 = 0;
		object obj151 = obj150 & 0x7FF;
		object obj152 = obj151 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v640 @ S5_v108 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S4_v143 (Il2CppMethodInfo)+C]");
		object obj153 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S4_v144+60]");
		object obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S4_v145+48]");
		object obj155 = 0;
		object obj156 = obj155 & 0x7FF;
		object obj157 = obj156 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v661 @ S5_v112 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S4_v148 (Il2CppMethodInfo)+C]");
		object obj158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S4_v149+60]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S4_v150+48]");
		object obj160 = 0;
		object obj161 = obj160 & 0x7FF;
		object obj162 = obj161 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v682 @ S5_v116 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S4_v153 (Il2CppMethodInfo)+C]");
		object obj163 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S4_v154+60]");
		object obj164 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S4_v155+48]");
		object obj165 = 0;
		object obj166 = obj165 & 0x7FF;
		object obj167 = obj166 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v703 @ S5_v120 (should have been resolved before IL gen)");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S4_v158 (Il2CppMethodInfo)+C]");
		object obj168 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S4_v159+60]");
		object obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S4_v160+48]");
		object obj170 = 0;
		object obj171 = obj170 & 0x7FF;
		object obj172 = obj171 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v724 @ S5_v124 (should have been resolved before IL gen)");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ S4_v163 (Il2CppMethodInfo)+C]");
		object obj173 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ S4_v164+60]");
		object obj174 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S4_v165+48]");
		object obj175 = 0;
		object obj176 = obj175 & 0x7FF;
		object obj177 = obj176 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v745 @ S5_v128 (should have been resolved before IL gen)");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ S4_v168 (Il2CppMethodInfo)+C]");
		object obj178 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S4_v169+60]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S4_v170+48]");
		object obj180 = 0;
		object obj181 = obj180 & 0x7FF;
		object obj182 = obj181 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v766 @ S5_v132 (should have been resolved before IL gen)");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S4_v173 (Il2CppMethodInfo)+C]");
		object obj183 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S4_v174+60]");
		object obj184 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S4_v175+48]");
		object obj185 = 0;
		object obj186 = obj185 & 0x7FF;
		object obj187 = obj186 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v787 @ S5_v136 (should have been resolved before IL gen)");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S4_v178 (Il2CppMethodInfo)+C]");
		object obj188 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S4_v179+60]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S4_v180+48]");
		object obj190 = 0;
		object obj191 = obj190 & 0x7FF;
		object obj192 = obj191 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v808 @ S5_v140 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S4_v183 (Il2CppMethodInfo)+C]");
		object obj193 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S4_v184+60]");
		object obj194 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S4_v185+48]");
		object obj195 = 0;
		object obj196 = obj195 & 0x7FF;
		object obj197 = obj196 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v829 @ S5_v144 (should have been resolved before IL gen)");
		object obj198 = this + 20;
		object obj199 = default;
		obj198 = obj199;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ S3_v56 (Il2CppMethodInfo)+C]");
		object obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ S3_v57+60]");
		object obj201 = 0;
		object obj202 = obj201;
		object obj203 = obj202 & 0x1FFF;
		object obj204 = obj203 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v852 @ S4_v190 (should have been resolved before IL gen)");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ S4_v192 (Il2CppMethodInfo)+C]");
		object obj205 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ S4_v193+60]");
		object obj206 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S4_v194+48]");
		object obj207 = 0;
		object obj208 = obj207 & 0x7FF;
		object obj209 = obj208 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v873 @ S5_v150 (should have been resolved before IL gen)");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ S4_v197 (Il2CppMethodInfo)+C]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S4_v198+60]");
		object obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S4_v199+48]");
		object obj212 = 0;
		object obj213 = obj212 & 0x7FF;
		object obj214 = obj213 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v894 @ S5_v154 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S4_v202 (Il2CppMethodInfo)+C]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ S4_v203+60]");
		object obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S4_v204+48]");
		object obj217 = 0;
		object obj218 = obj217 & 0x7FF;
		object obj219 = obj218 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v915 @ S5_v158 (should have been resolved before IL gen)");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S4_v207 (Il2CppMethodInfo)+C]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ S4_v208+60]");
		object obj221 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S4_v209+48]");
		object obj222 = 0;
		object obj223 = obj222 & 0x7FF;
		object obj224 = obj223 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v936 @ S5_v162 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S4_v212 (Il2CppMethodInfo)+C]");
		object obj225 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ S4_v213+60]");
		object obj226 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S4_v214+48]");
		object obj227 = 0;
		object obj228 = obj227 & 0x7FF;
		object obj229 = obj228 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v957 @ S5_v166 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ S4_v217 (Il2CppMethodInfo)+C]");
		object obj230 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ S4_v218+60]");
		object obj231 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S4_v219+48]");
		object obj232 = 0;
		object obj233 = obj232 & 0x7FF;
		object obj234 = obj233 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v978 @ S5_v170 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ S4_v222 (Il2CppMethodInfo)+C]");
		object obj235 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ S4_v223+60]");
		object obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S4_v224+48]");
		object obj237 = 0;
		object obj238 = obj237 & 0x7FF;
		object obj239 = obj238 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v999 @ S5_v174 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ S4_v227 (Il2CppMethodInfo)+C]");
		object obj240 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ S4_v228+60]");
		object obj241 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S4_v229+48]");
		object obj242 = 0;
		object obj243 = obj242 & 0x7FF;
		object obj244 = obj243 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1020 @ S5_v178 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ S4_v232 (Il2CppMethodInfo)+C]");
		object obj245 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ S4_v233+60]");
		object obj246 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ S4_v234+48]");
		object obj247 = 0;
		object obj248 = obj247 & 0x7FF;
		object obj249 = obj248 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1041 @ S5_v182 (should have been resolved before IL gen)");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S4_v237 (Il2CppMethodInfo)+C]");
		object obj250 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ S4_v238+60]");
		object obj251 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S4_v239+48]");
		object obj252 = 0;
		object obj253 = obj252 & 0x7FF;
		object obj254 = obj253 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1062 @ S5_v186 (should have been resolved before IL gen)");
		object obj255 = this + 24;
		object obj256 = default;
		obj255 = obj256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ S3_v71 (Il2CppMethodInfo)+C]");
		object obj257 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ S3_v72+60]");
		object obj258 = 0;
		object obj259 = obj258;
		object obj260 = obj259 & 0x1FFF;
		object obj261 = obj260 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1085 @ S4_v244 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ S4_v246 (Il2CppMethodInfo)+C]");
		object obj262 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ S4_v247+60]");
		object obj263 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ S4_v248+48]");
		object obj264 = 0;
		object obj265 = obj264 & 0x7FF;
		object obj266 = obj265 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1106 @ S5_v192 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ S4_v251 (Il2CppMethodInfo)+C]");
		object obj267 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ S4_v252+60]");
		object obj268 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ S4_v253+48]");
		object obj269 = 0;
		object obj270 = obj269 & 0x7FF;
		object obj271 = obj270 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1127 @ S5_v196 (should have been resolved before IL gen)");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S4_v256 (Il2CppMethodInfo)+C]");
		object obj272 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ S4_v257+60]");
		object obj273 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ S4_v258+48]");
		object obj274 = 0;
		object obj275 = obj274 & 0x7FF;
		object obj276 = obj275 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1148 @ S5_v200 (should have been resolved before IL gen)");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ S4_v261 (Il2CppMethodInfo)+C]");
		object obj277 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ S4_v262+60]");
		object obj278 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S4_v263+48]");
		object obj279 = 0;
		object obj280 = obj279 & 0x7FF;
		object obj281 = obj280 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1169 @ S5_v204 (should have been resolved before IL gen)");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ S4_v266 (Il2CppMethodInfo)+C]");
		object obj282 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ S4_v267+60]");
		object obj283 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S4_v268+48]");
		object obj284 = 0;
		object obj285 = obj284 & 0x7FF;
		object obj286 = obj285 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1190 @ S5_v208 (should have been resolved before IL gen)");
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ S4_v271 (Il2CppMethodInfo)+C]");
		object obj287 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ S4_v272+60]");
		object obj288 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ S4_v273+48]");
		object obj289 = 0;
		object obj290 = obj289 & 0x7FF;
		object obj291 = obj290 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1211 @ S5_v212 (should have been resolved before IL gen)");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ S4_v276 (Il2CppMethodInfo)+C]");
		object obj292 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ S4_v277+60]");
		object obj293 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ S4_v278+48]");
		object obj294 = 0;
		object obj295 = obj294 & 0x7FF;
		object obj296 = obj295 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1232 @ S5_v216 (should have been resolved before IL gen)");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ S4_v281 (Il2CppMethodInfo)+C]");
		object obj297 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ S4_v282+60]");
		object obj298 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ S4_v283+48]");
		object obj299 = 0;
		object obj300 = obj299 & 0x7FF;
		object obj301 = obj300 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1253 @ S5_v220 (should have been resolved before IL gen)");
		object obj302 = this + 28;
		object obj303 = default;
		obj302 = obj303;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S3_v84 (Il2CppMethodInfo)+C]");
		object obj304 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ S3_v85+60]");
		object obj305 = 0;
		object obj306 = obj305;
		object obj307 = obj306 & 0x1FFF;
		object obj308 = obj307 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1276 @ S4_v288 (should have been resolved before IL gen)");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S4_v290 (Il2CppMethodInfo)+C]");
		object obj309 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ S4_v291+60]");
		object obj310 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ S4_v292+48]");
		object obj311 = 0;
		object obj312 = obj311 & 0x7FF;
		object obj313 = obj312 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1297 @ S5_v226 (should have been resolved before IL gen)");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ S4_v295 (Il2CppMethodInfo)+C]");
		object obj314 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ S4_v296+60]");
		object obj315 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ S4_v297+48]");
		object obj316 = 0;
		object obj317 = obj316 & 0x7FF;
		object obj318 = obj317 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1318 @ S5_v230 (should have been resolved before IL gen)");
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S4_v300 (Il2CppMethodInfo)+C]");
		object obj319 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S4_v301+60]");
		object obj320 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ S4_v302+48]");
		object obj321 = 0;
		object obj322 = obj321 & 0x7FF;
		object obj323 = obj322 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1339 @ S5_v234 (should have been resolved before IL gen)");
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ S4_v305 (Il2CppMethodInfo)+C]");
		object obj324 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ S4_v306+60]");
		object obj325 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ S4_v307+48]");
		object obj326 = 0;
		object obj327 = obj326 & 0x7FF;
		object obj328 = obj327 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1360 @ S5_v238 (should have been resolved before IL gen)");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ S4_v310 (Il2CppMethodInfo)+C]");
		object obj329 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1372 @ S4_v311+60]");
		object obj330 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S4_v312+48]");
		object obj331 = 0;
		object obj332 = obj331 & 0x7FF;
		object obj333 = obj332 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1381 @ S5_v242 (should have been resolved before IL gen)");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S4_v315 (Il2CppMethodInfo)+C]");
		object obj334 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ S4_v316+60]");
		object obj335 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S4_v317+48]");
		object obj336 = 0;
		object obj337 = obj336 & 0x7FF;
		object obj338 = obj337 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1402 @ S5_v246 (should have been resolved before IL gen)");
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ S4_v320 (Il2CppMethodInfo)+C]");
		object obj339 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1414 @ S4_v321+60]");
		object obj340 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ S4_v322+48]");
		object obj341 = 0;
		object obj342 = obj341 & 0x7FF;
		object obj343 = obj342 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1423 @ S5_v250 (should have been resolved before IL gen)");
		nint num69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1434 @ S4_v325 (Il2CppMethodInfo)+C]");
		object obj344 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ S4_v326+60]");
		object obj345 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ S4_v327+48]");
		object obj346 = 0;
		object obj347 = obj346 & 0x7FF;
		object obj348 = obj347 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1444 @ S5_v254 (should have been resolved before IL gen)");
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ S4_v330 (Il2CppMethodInfo)+C]");
		object obj349 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1456 @ S4_v331+60]");
		object obj350 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1457 @ S4_v332+48]");
		object obj351 = 0;
		object obj352 = obj351 & 0x7FF;
		object obj353 = obj352 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1465 @ S5_v258 (should have been resolved before IL gen)");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ S4_v335 (Il2CppMethodInfo)+C]");
		object obj354 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1477 @ S4_v336+60]");
		object obj355 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ S4_v337+48]");
		object obj356 = 0;
		object obj357 = obj356 & 0x7FF;
		object obj358 = obj357 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1486 @ S5_v262 (should have been resolved before IL gen)");
		object obj359 = this + 32;
		object obj360 = default;
		obj359 = obj360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ S3_v99 (Il2CppMethodInfo)+C]");
		object obj361 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1500 @ S3_v100+60]");
		object obj362 = 0;
		object obj363 = obj362;
		object obj364 = obj363 & 0x1FFF;
		object obj365 = obj364 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1509 @ S4_v342 (should have been resolved before IL gen)");
		object obj366 = this + 36;
		object obj367 = default;
		obj366 = obj367;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ S3_v104 (Il2CppMethodInfo)+C]");
		object obj368 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ S3_v105+60]");
		object obj369 = 0;
		object obj370 = obj369;
		object obj371 = obj370 & 0x1FFF;
		object obj372 = obj371 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1532 @ S4_v346 (should have been resolved before IL gen)");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ S4_v348 (Il2CppMethodInfo)+C]");
		object obj373 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ S4_v349+60]");
		object obj374 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ S4_v350+48]");
		object obj375 = 0;
		object obj376 = obj375 & 0x7FF;
		object obj377 = obj376 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1553 @ S5_v270 (should have been resolved before IL gen)");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1564 @ S4_v353 (Il2CppMethodInfo)+C]");
		object obj378 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1565 @ S4_v354+60]");
		object obj379 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1566 @ S4_v355+48]");
		object obj380 = 0;
		object obj381 = obj380 & 0x7FF;
		object obj382 = obj381 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1574 @ S5_v274 (should have been resolved before IL gen)");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ S4_v358 (Il2CppMethodInfo)+C]");
		object obj383 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ S4_v359+60]");
		object obj384 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ S4_v360+48]");
		object obj385 = 0;
		object obj386 = obj385 & 0x7FF;
		object obj387 = obj386 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1595 @ S5_v278 (should have been resolved before IL gen)");
		nint num77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ S4_v363 (Il2CppMethodInfo)+C]");
		object obj388 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1607 @ S4_v364+60]");
		object obj389 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1608 @ S4_v365+48]");
		object obj390 = 0;
		object obj391 = obj390 & 0x7FF;
		object obj392 = obj391 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1616 @ S5_v282 (should have been resolved before IL gen)");
		object obj393 = this + 40;
		object obj394 = default;
		obj393 = obj394;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ S3_v113 (Il2CppMethodInfo)+C]");
		object obj395 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1630 @ S3_v114+60]");
		object obj396 = 0;
		object obj397 = obj396;
		object obj398 = obj397 & 0x1FFF;
		object obj399 = obj398 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1639 @ S4_v370 (should have been resolved before IL gen)");
		nint num79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ S4_v372 (Il2CppMethodInfo)+C]");
		object obj400 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1651 @ S4_v373+60]");
		object obj401 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1652 @ S4_v374+48]");
		object obj402 = 0;
		object obj403 = obj402 & 0x7FF;
		object obj404 = obj403 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1660 @ S5_v288 (should have been resolved before IL gen)");
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1671 @ S4_v377 (Il2CppMethodInfo)+C]");
		object obj405 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1672 @ S4_v378+60]");
		object obj406 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ S4_v379+48]");
		object obj407 = 0;
		object obj408 = obj407 & 0x7FF;
		object obj409 = obj408 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1681 @ S5_v292 (should have been resolved before IL gen)");
		nint num81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ S4_v382 (Il2CppMethodInfo)+C]");
		object obj410 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1693 @ S4_v383+60]");
		object obj411 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ S4_v384+48]");
		object obj412 = 0;
		object obj413 = obj412 & 0x7FF;
		object obj414 = obj413 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1702 @ S5_v296 (should have been resolved before IL gen)");
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ S4_v387 (Il2CppMethodInfo)+C]");
		object obj415 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ S4_v388+60]");
		object obj416 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ S4_v389+48]");
		object obj417 = 0;
		object obj418 = obj417 & 0x7FF;
		object obj419 = obj418 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1723 @ S5_v300 (should have been resolved before IL gen)");
		nint num83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1734 @ S4_v392 (Il2CppMethodInfo)+C]");
		object obj420 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ S4_v393+60]");
		object obj421 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1736 @ S4_v394+48]");
		object obj422 = 0;
		object obj423 = obj422 & 0x7FF;
		object obj424 = obj423 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1744 @ S5_v304 (should have been resolved before IL gen)");
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ S4_v397 (Il2CppMethodInfo)+C]");
		object obj425 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1756 @ S4_v398+60]");
		object obj426 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ S4_v399+48]");
		object obj427 = 0;
		object obj428 = obj427 & 0x7FF;
		object obj429 = obj428 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1765 @ S5_v308 (should have been resolved before IL gen)");
		object obj430 = this + 44;
		object obj431 = default;
		obj430 = obj431;
	}
}
