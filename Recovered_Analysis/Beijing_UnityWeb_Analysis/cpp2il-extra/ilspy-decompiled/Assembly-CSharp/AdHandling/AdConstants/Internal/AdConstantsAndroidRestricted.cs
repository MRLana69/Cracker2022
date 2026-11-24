using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsAndroidRestricted : IAdConstants
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

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"appf8a3f6e919564ed7b7";

	public string TapJoyAppId => (string)(object)_adColonyCacheIDs;

	public string TapJoyAppKey => "";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string ChartboostAppId => (string)(object)_tapjoyCacheIDs;

	public string ChartboostAppSignature => "5922afa3f6cd45741492fe26";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"47feec269d093a00d6af9e1e86cb4781ba7ee12a";

	public string InmobiAccountId => (string)(object)_chartboostCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"6c7ea8566bfd4b2c82269e3647046624";

	public string VungleAppId => (string)(object)_inmobiCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"591c39924753e6384a0002b3";

	public string SupersonicAppId => (string)(object)_vungleCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"4a25f10d";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _supersonicCacheIDs;

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => _facebookCacheIDs;

	public string MobVistaAppId => (string)(object)_mobvistaCacheIDs;

	public string MobVistaAppSdkKey => "101366";

	public string MobVistaEventName => "f51fde5b5c666de31358328df8b3141a";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"Subway iOS home_videos";

	public AdConstantsAndroidRestricted()
	{
		//IL_16f7: Expected Obj, but got I
		//IL_1707: Expected Obj, but got I
		//IL_1718: Unknown result type (might be due to invalid IL or missing references)
		//IL_171d: Expected Obj, but got Unknown
		//IL_1726: Unknown result type (might be due to invalid IL or missing references)
		//IL_172b: Expected Obj, but got Unknown
		//IL_1743: Expected I, but got Obj
		//IL_1759: Expected Obj, but got I
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
		//IL_1844: Expected Obj, but got I
		//IL_1854: Expected Obj, but got I
		//IL_1864: Expected Obj, but got I
		//IL_186d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Expected Obj, but got Unknown
		//IL_187b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1880: Expected Obj, but got Unknown
		//IL_18a0: Expected Obj, but got I
		//IL_18b0: Expected Obj, but got I
		//IL_18c0: Expected Obj, but got I
		//IL_18c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ce: Expected Obj, but got Unknown
		//IL_18d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dc: Expected Obj, but got Unknown
		//IL_18fc: Expected Obj, but got I
		//IL_190c: Expected Obj, but got I
		//IL_191c: Expected Obj, but got I
		//IL_1925: Unknown result type (might be due to invalid IL or missing references)
		//IL_192a: Expected Obj, but got Unknown
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_1938: Expected Obj, but got Unknown
		//IL_1958: Expected Obj, but got I
		//IL_1968: Expected Obj, but got I
		//IL_1978: Expected Obj, but got I
		//IL_1981: Unknown result type (might be due to invalid IL or missing references)
		//IL_1986: Expected Obj, but got Unknown
		//IL_198f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1994: Expected Obj, but got Unknown
		//IL_19b4: Expected Obj, but got I
		//IL_19c4: Expected Obj, but got I
		//IL_19d4: Expected Obj, but got I
		//IL_19dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e2: Expected Obj, but got Unknown
		//IL_19eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f0: Expected Obj, but got Unknown
		//IL_1a10: Expected Obj, but got I
		//IL_1a20: Expected Obj, but got I
		//IL_1a30: Expected Obj, but got I
		//IL_1a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3e: Expected Obj, but got Unknown
		//IL_1a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4c: Expected Obj, but got Unknown
		//IL_1a6c: Expected Obj, but got I
		//IL_1a7c: Expected Obj, but got I
		//IL_1a8c: Expected Obj, but got I
		//IL_1a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9a: Expected Obj, but got Unknown
		//IL_1aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa8: Expected Obj, but got Unknown
		//IL_1ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abd: Expected Obj, but got Unknown
		//IL_1ae5: Expected Obj, but got I
		//IL_1af5: Expected Obj, but got I
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
		//IL_1b95: Expected Obj, but got I
		//IL_1ba5: Expected Obj, but got I
		//IL_1bb5: Expected Obj, but got I
		//IL_1bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc3: Expected Obj, but got Unknown
		//IL_1bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd1: Expected Obj, but got Unknown
		//IL_1bf1: Expected Obj, but got I
		//IL_1c01: Expected Obj, but got I
		//IL_1c11: Expected Obj, but got I
		//IL_1c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1f: Expected Obj, but got Unknown
		//IL_1c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2d: Expected Obj, but got Unknown
		//IL_1c4d: Expected Obj, but got I
		//IL_1c5d: Expected Obj, but got I
		//IL_1c6d: Expected Obj, but got I
		//IL_1c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7b: Expected Obj, but got Unknown
		//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c89: Expected Obj, but got Unknown
		//IL_1ca9: Expected Obj, but got I
		//IL_1cb9: Expected Obj, but got I
		//IL_1cc9: Expected Obj, but got I
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd7: Expected Obj, but got Unknown
		//IL_1ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce5: Expected Obj, but got Unknown
		//IL_1d05: Expected Obj, but got I
		//IL_1d15: Expected Obj, but got I
		//IL_1d25: Expected Obj, but got I
		//IL_1d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d33: Expected Obj, but got Unknown
		//IL_1d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d41: Expected Obj, but got Unknown
		//IL_1d61: Expected Obj, but got I
		//IL_1d71: Expected Obj, but got I
		//IL_1d81: Expected Obj, but got I
		//IL_1d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8f: Expected Obj, but got Unknown
		//IL_1d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9d: Expected Obj, but got Unknown
		//IL_1dbd: Expected Obj, but got I
		//IL_1dcd: Expected Obj, but got I
		//IL_1ddd: Expected Obj, but got I
		//IL_1de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1deb: Expected Obj, but got Unknown
		//IL_1df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df9: Expected Obj, but got Unknown
		//IL_1e19: Expected Obj, but got I
		//IL_1e29: Expected Obj, but got I
		//IL_1e39: Expected Obj, but got I
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e47: Expected Obj, but got Unknown
		//IL_1e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e55: Expected Obj, but got Unknown
		//IL_1e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Expected Obj, but got Unknown
		//IL_1e92: Expected Obj, but got I
		//IL_1ea2: Expected Obj, but got I
		//IL_1eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb8: Expected Obj, but got Unknown
		//IL_1ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec6: Expected Obj, but got Unknown
		//IL_1ee6: Expected Obj, but got I
		//IL_1ef6: Expected Obj, but got I
		//IL_1f06: Expected Obj, but got I
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f14: Expected Obj, but got Unknown
		//IL_1f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Expected Obj, but got Unknown
		//IL_1f42: Expected Obj, but got I
		//IL_1f52: Expected Obj, but got I
		//IL_1f62: Expected Obj, but got I
		//IL_1f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f70: Expected Obj, but got Unknown
		//IL_1f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7e: Expected Obj, but got Unknown
		//IL_1f9e: Expected Obj, but got I
		//IL_1fae: Expected Obj, but got I
		//IL_1fbe: Expected Obj, but got I
		//IL_1fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcc: Expected Obj, but got Unknown
		//IL_1fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fda: Expected Obj, but got Unknown
		//IL_1ffa: Expected Obj, but got I
		//IL_200a: Expected Obj, but got I
		//IL_201a: Expected Obj, but got I
		//IL_2023: Unknown result type (might be due to invalid IL or missing references)
		//IL_2028: Expected Obj, but got Unknown
		//IL_2031: Unknown result type (might be due to invalid IL or missing references)
		//IL_2036: Expected Obj, but got Unknown
		//IL_2056: Expected Obj, but got I
		//IL_2066: Expected Obj, but got I
		//IL_2076: Expected Obj, but got I
		//IL_207f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2084: Expected Obj, but got Unknown
		//IL_208d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2092: Expected Obj, but got Unknown
		//IL_20b2: Expected Obj, but got I
		//IL_20c2: Expected Obj, but got I
		//IL_20d2: Expected Obj, but got I
		//IL_20db: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Expected Obj, but got Unknown
		//IL_20e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ee: Expected Obj, but got Unknown
		//IL_210e: Expected Obj, but got I
		//IL_211e: Expected Obj, but got I
		//IL_212e: Expected Obj, but got I
		//IL_2137: Unknown result type (might be due to invalid IL or missing references)
		//IL_213c: Expected Obj, but got Unknown
		//IL_2145: Unknown result type (might be due to invalid IL or missing references)
		//IL_214a: Expected Obj, but got Unknown
		//IL_216a: Expected Obj, but got I
		//IL_217a: Expected Obj, but got I
		//IL_218a: Expected Obj, but got I
		//IL_2193: Unknown result type (might be due to invalid IL or missing references)
		//IL_2198: Expected Obj, but got Unknown
		//IL_21a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a6: Expected Obj, but got Unknown
		//IL_21c6: Expected Obj, but got I
		//IL_21d6: Expected Obj, but got I
		//IL_21e6: Expected Obj, but got I
		//IL_21ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f4: Expected Obj, but got Unknown
		//IL_21fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2202: Expected Obj, but got Unknown
		//IL_2212: Unknown result type (might be due to invalid IL or missing references)
		//IL_2217: Expected Obj, but got Unknown
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
		//IL_0454: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04cd: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
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
		//IL_085d: Expected Obj, but got I
		//IL_086d: Expected Obj, but got I
		//IL_087d: Expected Obj, but got I
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected Obj, but got Unknown
		//IL_08b9: Expected Obj, but got I
		//IL_08c9: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0937: Expected Obj, but got I
		//IL_0947: Expected Obj, but got I
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
		//IL_0bb3: Expected Obj, but got I
		//IL_0bc3: Expected Obj, but got I
		//IL_0bd3: Expected Obj, but got I
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected Obj, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected Obj, but got Unknown
		//IL_0c0f: Expected Obj, but got I
		//IL_0c1f: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected Obj, but got Unknown
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Expected Obj, but got Unknown
		//IL_0c6b: Expected Obj, but got I
		//IL_0c7b: Expected Obj, but got I
		//IL_0c8b: Expected Obj, but got I
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected Obj, but got Unknown
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Expected Obj, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected Obj, but got Unknown
		//IL_0ce4: Expected Obj, but got I
		//IL_0cf4: Expected Obj, but got I
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
		//IL_0fbc: Expected Obj, but got I
		//IL_0fcc: Expected Obj, but got I
		//IL_0fdc: Expected Obj, but got I
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected Obj, but got Unknown
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected Obj, but got Unknown
		//IL_1018: Expected Obj, but got I
		//IL_1028: Expected Obj, but got I
		//IL_1038: Expected Obj, but got I
		//IL_1041: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Expected Obj, but got Unknown
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Expected Obj, but got Unknown
		//IL_1074: Expected Obj, but got I
		//IL_1084: Expected Obj, but got I
		//IL_1094: Expected Obj, but got I
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected Obj, but got Unknown
		//IL_10ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected Obj, but got Unknown
		//IL_10d0: Expected Obj, but got I
		//IL_10e0: Expected Obj, but got I
		//IL_10f0: Expected Obj, but got I
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fe: Expected Obj, but got Unknown
		//IL_1107: Unknown result type (might be due to invalid IL or missing references)
		//IL_110c: Expected Obj, but got Unknown
		//IL_111c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Expected Obj, but got Unknown
		//IL_114e: Expected Obj, but got I
		//IL_115e: Expected Obj, but got I
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1174: Expected Obj, but got Unknown
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1182: Expected Obj, but got Unknown
		//IL_11a2: Expected Obj, but got I
		//IL_11b2: Expected Obj, but got I
		//IL_11c2: Expected Obj, but got I
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected Obj, but got Unknown
		//IL_11d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11de: Expected Obj, but got Unknown
		//IL_11fe: Expected Obj, but got I
		//IL_120e: Expected Obj, but got I
		//IL_121e: Expected Obj, but got I
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected Obj, but got Unknown
		//IL_1235: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Expected Obj, but got Unknown
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_124f: Expected Obj, but got Unknown
		//IL_1277: Expected Obj, but got I
		//IL_1287: Expected Obj, but got I
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_129d: Expected Obj, but got Unknown
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected Obj, but got Unknown
		//IL_12cb: Expected Obj, but got I
		//IL_12db: Expected Obj, but got I
		//IL_12eb: Expected Obj, but got I
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected Obj, but got Unknown
		//IL_1302: Unknown result type (might be due to invalid IL or missing references)
		//IL_1307: Expected Obj, but got Unknown
		//IL_1327: Expected Obj, but got I
		//IL_1337: Expected Obj, but got I
		//IL_1347: Expected Obj, but got I
		//IL_1350: Unknown result type (might be due to invalid IL or missing references)
		//IL_1355: Expected Obj, but got Unknown
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected Obj, but got Unknown
		//IL_1383: Expected Obj, but got I
		//IL_1393: Expected Obj, but got I
		//IL_13a3: Expected Obj, but got I
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b1: Expected Obj, but got Unknown
		//IL_13ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf: Expected Obj, but got Unknown
		//IL_13df: Expected Obj, but got I
		//IL_13ef: Expected Obj, but got I
		//IL_13ff: Expected Obj, but got I
		//IL_1408: Unknown result type (might be due to invalid IL or missing references)
		//IL_140d: Expected Obj, but got Unknown
		//IL_1416: Unknown result type (might be due to invalid IL or missing references)
		//IL_141b: Expected Obj, but got Unknown
		//IL_142b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Expected Obj, but got Unknown
		//IL_145d: Expected Obj, but got I
		//IL_146d: Expected Obj, but got I
		//IL_147e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected Obj, but got Unknown
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected Obj, but got Unknown
		//IL_14b1: Expected Obj, but got I
		//IL_14c1: Expected Obj, but got I
		//IL_14d1: Expected Obj, but got I
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Expected Obj, but got Unknown
		//IL_14e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ed: Expected Obj, but got Unknown
		//IL_150d: Expected Obj, but got I
		//IL_151d: Expected Obj, but got I
		//IL_152d: Expected Obj, but got I
		//IL_1536: Unknown result type (might be due to invalid IL or missing references)
		//IL_153b: Expected Obj, but got Unknown
		//IL_1544: Unknown result type (might be due to invalid IL or missing references)
		//IL_1549: Expected Obj, but got Unknown
		//IL_1569: Expected Obj, but got I
		//IL_1579: Expected Obj, but got I
		//IL_1589: Expected Obj, but got I
		//IL_1592: Unknown result type (might be due to invalid IL or missing references)
		//IL_1597: Expected Obj, but got Unknown
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a5: Expected Obj, but got Unknown
		//IL_15c5: Expected Obj, but got I
		//IL_15d5: Expected Obj, but got I
		//IL_15e5: Expected Obj, but got I
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f3: Expected Obj, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1601: Expected Obj, but got Unknown
		//IL_1621: Expected Obj, but got I
		//IL_1631: Expected Obj, but got I
		//IL_1641: Expected Obj, but got I
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_164f: Expected Obj, but got Unknown
		//IL_1658: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Expected Obj, but got Unknown
		//IL_167d: Expected Obj, but got I
		//IL_168d: Expected Obj, but got I
		//IL_169d: Expected Obj, but got I
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected Obj, but got Unknown
		//IL_16b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Expected Obj, but got Unknown
		//IL_16c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ce: Expected Obj, but got Unknown
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v222 (Il2CppClass<AdLocations>)+74]");
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
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S4_v47+60]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S4_v48+48]");
		object obj49 = 0;
		object obj50 = obj49 & 0x7FF;
		object obj51 = obj50 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v232 @ S5_v38 (should have been resolved before IL gen)");
		object obj52 = this + 8;
		object obj53 = default;
		obj52 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S3_v16 (Il2CppMethodInfo)+C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S3_v17+60]");
		object obj55 = 0;
		object obj56 = obj55;
		object obj57 = obj56 & 0x1FFF;
		object obj58 = obj57 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v257 @ S4_v53 (should have been resolved before IL gen)");
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
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S4_v90 (Il2CppMethodInfo)+C]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S4_v91+60]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S4_v92+48]");
		object obj96 = 0;
		object obj97 = obj96 & 0x7FF;
		object obj98 = obj97 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v425 @ S5_v72 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S4_v95 (Il2CppMethodInfo)+C]");
		object obj99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S4_v96+60]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S4_v97+48]");
		object obj101 = 0;
		object obj102 = obj101 & 0x7FF;
		object obj103 = obj102 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v446 @ S5_v76 (should have been resolved before IL gen)");
		object obj104 = this + 12;
		object obj105 = default;
		obj104 = obj105;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S3_v30 (Il2CppMethodInfo)+C]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S3_v31+60]");
		object obj107 = 0;
		object obj108 = obj107;
		object obj109 = obj108 & 0x1FFF;
		object obj110 = obj109 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v470 @ S4_v102 (should have been resolved before IL gen)");
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
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S4_v134 (Il2CppMethodInfo)+C]");
		object obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S4_v135+60]");
		object obj142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S4_v136+48]");
		object obj143 = 0;
		object obj144 = obj143 & 0x7FF;
		object obj145 = obj144 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v617 @ S5_v106 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S4_v139 (Il2CppMethodInfo)+C]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S4_v140+60]");
		object obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S4_v141+48]");
		object obj148 = 0;
		object obj149 = obj148 & 0x7FF;
		object obj150 = obj149 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v638 @ S5_v110 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S4_v144 (Il2CppMethodInfo)+C]");
		object obj151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S4_v145+60]");
		object obj152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S4_v146+48]");
		object obj153 = 0;
		object obj154 = obj153 & 0x7FF;
		object obj155 = obj154 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v659 @ S5_v114 (should have been resolved before IL gen)");
		object obj156 = this + 16;
		object obj157 = default;
		obj156 = obj157;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S3_v44 (Il2CppMethodInfo)+C]");
		object obj158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S3_v45+60]");
		object obj159 = 0;
		object obj160 = obj159;
		object obj161 = obj160 & 0x1FFF;
		object obj162 = obj161 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v682 @ S4_v151 (should have been resolved before IL gen)");
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
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S4_v188 (Il2CppMethodInfo)+C]");
		object obj198 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ S4_v189+60]");
		object obj199 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ S4_v190+48]");
		object obj200 = 0;
		object obj201 = obj200 & 0x7FF;
		object obj202 = obj201 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v850 @ S5_v148 (should have been resolved before IL gen)");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ S4_v193 (Il2CppMethodInfo)+C]");
		object obj203 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S4_v194+60]");
		object obj204 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ S4_v195+48]");
		object obj205 = 0;
		object obj206 = obj205 & 0x7FF;
		object obj207 = obj206 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v871 @ S5_v152 (should have been resolved before IL gen)");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ S4_v198 (Il2CppMethodInfo)+C]");
		object obj208 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ S4_v199+60]");
		object obj209 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ S4_v200+48]");
		object obj210 = 0;
		object obj211 = obj210 & 0x7FF;
		object obj212 = obj211 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v892 @ S5_v156 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S4_v203 (Il2CppMethodInfo)+C]");
		object obj213 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ S4_v204+60]");
		object obj214 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S4_v205+48]");
		object obj215 = 0;
		object obj216 = obj215 & 0x7FF;
		object obj217 = obj216 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v913 @ S5_v160 (should have been resolved before IL gen)");
		object obj218 = this + 20;
		object obj219 = default;
		obj218 = obj219;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S3_v60 (Il2CppMethodInfo)+C]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ S3_v61+60]");
		object obj221 = 0;
		object obj222 = obj221;
		object obj223 = obj222 & 0x1FFF;
		object obj224 = obj223 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v936 @ S4_v210 (should have been resolved before IL gen)");
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
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ S4_v242 (Il2CppMethodInfo)+C]");
		object obj255 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ S4_v243+60]");
		object obj256 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ S4_v244+48]");
		object obj257 = 0;
		object obj258 = obj257 & 0x7FF;
		object obj259 = obj258 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1083 @ S5_v190 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ S4_v247 (Il2CppMethodInfo)+C]");
		object obj260 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ S4_v248+60]");
		object obj261 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ S4_v249+48]");
		object obj262 = 0;
		object obj263 = obj262 & 0x7FF;
		object obj264 = obj263 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1104 @ S5_v194 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ S4_v252 (Il2CppMethodInfo)+C]");
		object obj265 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ S4_v253+60]");
		object obj266 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ S4_v254+48]");
		object obj267 = 0;
		object obj268 = obj267 & 0x7FF;
		object obj269 = obj268 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1125 @ S5_v198 (should have been resolved before IL gen)");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ S4_v257 (Il2CppMethodInfo)+C]");
		object obj270 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ S4_v258+60]");
		object obj271 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S4_v259+48]");
		object obj272 = 0;
		object obj273 = obj272 & 0x7FF;
		object obj274 = obj273 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1146 @ S5_v202 (should have been resolved before IL gen)");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ S4_v262 (Il2CppMethodInfo)+C]");
		object obj275 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ S4_v263+60]");
		object obj276 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ S4_v264+48]");
		object obj277 = 0;
		object obj278 = obj277 & 0x7FF;
		object obj279 = obj278 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1167 @ S5_v206 (should have been resolved before IL gen)");
		object obj280 = this + 24;
		object obj281 = default;
		obj280 = obj281;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ S3_v76 (Il2CppMethodInfo)+C]");
		object obj282 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ S3_v77+60]");
		object obj283 = 0;
		object obj284 = obj283;
		object obj285 = obj284 & 0x1FFF;
		object obj286 = obj285 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1190 @ S4_v269 (should have been resolved before IL gen)");
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
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ S4_v286 (Il2CppMethodInfo)+C]");
		object obj302 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ S4_v287+60]");
		object obj303 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S4_v288+48]");
		object obj304 = 0;
		object obj305 = obj304 & 0x7FF;
		object obj306 = obj305 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1274 @ S5_v224 (should have been resolved before IL gen)");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S4_v291 (Il2CppMethodInfo)+C]");
		object obj307 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ S4_v292+60]");
		object obj308 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S4_v293+48]");
		object obj309 = 0;
		object obj310 = obj309 & 0x7FF;
		object obj311 = obj310 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1295 @ S5_v228 (should have been resolved before IL gen)");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ S4_v296 (Il2CppMethodInfo)+C]");
		object obj312 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ S4_v297+60]");
		object obj313 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ S4_v298+48]");
		object obj314 = 0;
		object obj315 = obj314 & 0x7FF;
		object obj316 = obj315 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1316 @ S5_v232 (should have been resolved before IL gen)");
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ S4_v301 (Il2CppMethodInfo)+C]");
		object obj317 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1328 @ S4_v302+60]");
		object obj318 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S4_v303+48]");
		object obj319 = 0;
		object obj320 = obj319 & 0x7FF;
		object obj321 = obj320 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1337 @ S5_v236 (should have been resolved before IL gen)");
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ S4_v306 (Il2CppMethodInfo)+C]");
		object obj322 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ S4_v307+60]");
		object obj323 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ S4_v308+48]");
		object obj324 = 0;
		object obj325 = obj324 & 0x7FF;
		object obj326 = obj325 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1358 @ S5_v240 (should have been resolved before IL gen)");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ S4_v311 (Il2CppMethodInfo)+C]");
		object obj327 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ S4_v312+60]");
		object obj328 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ S4_v313+48]");
		object obj329 = 0;
		object obj330 = obj329 & 0x7FF;
		object obj331 = obj330 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1379 @ S5_v244 (should have been resolved before IL gen)");
		object obj332 = this + 28;
		object obj333 = default;
		obj332 = obj333;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S3_v90 (Il2CppMethodInfo)+C]");
		object obj334 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ S3_v91+60]");
		object obj335 = 0;
		object obj336 = obj335;
		object obj337 = obj336 & 0x1FFF;
		object obj338 = obj337 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1402 @ S4_v318 (should have been resolved before IL gen)");
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
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ S4_v340 (Il2CppMethodInfo)+C]");
		object obj359 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ S4_v341+60]");
		object obj360 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ S4_v342+48]");
		object obj361 = 0;
		object obj362 = obj361 & 0x7FF;
		object obj363 = obj362 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1507 @ S5_v266 (should have been resolved before IL gen)");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1518 @ S4_v345 (Il2CppMethodInfo)+C]");
		object obj364 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ S4_v346+60]");
		object obj365 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ S4_v347+48]");
		object obj366 = 0;
		object obj367 = obj366 & 0x7FF;
		object obj368 = obj367 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1528 @ S5_v270 (should have been resolved before IL gen)");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ S4_v350 (Il2CppMethodInfo)+C]");
		object obj369 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1540 @ S4_v351+60]");
		object obj370 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ S4_v352+48]");
		object obj371 = 0;
		object obj372 = obj371 & 0x7FF;
		object obj373 = obj372 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1549 @ S5_v274 (should have been resolved before IL gen)");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1560 @ S4_v355 (Il2CppMethodInfo)+C]");
		object obj374 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ S4_v356+60]");
		object obj375 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ S4_v357+48]");
		object obj376 = 0;
		object obj377 = obj376 & 0x7FF;
		object obj378 = obj377 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1570 @ S5_v278 (should have been resolved before IL gen)");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1581 @ S4_v360 (Il2CppMethodInfo)+C]");
		object obj379 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S4_v361+60]");
		object obj380 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ S4_v362+48]");
		object obj381 = 0;
		object obj382 = obj381 & 0x7FF;
		object obj383 = obj382 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1591 @ S5_v282 (should have been resolved before IL gen)");
		nint num77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1602 @ S4_v365 (Il2CppMethodInfo)+C]");
		object obj384 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ S4_v366+60]");
		object obj385 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ S4_v367+48]");
		object obj386 = 0;
		object obj387 = obj386 & 0x7FF;
		object obj388 = obj387 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1612 @ S5_v286 (should have been resolved before IL gen)");
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ S4_v370 (Il2CppMethodInfo)+C]");
		object obj389 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1624 @ S4_v371+60]");
		object obj390 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ S4_v372+48]");
		object obj391 = 0;
		object obj392 = obj391 & 0x7FF;
		object obj393 = obj392 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1633 @ S5_v290 (should have been resolved before IL gen)");
		object obj394 = this + 32;
		object obj395 = default;
		obj394 = obj395;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ S3_v106 (Il2CppMethodInfo)+C]");
		object obj396 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S3_v107+60]");
		object obj397 = 0;
		object obj398 = obj397;
		object obj399 = obj398 & 0x1FFF;
		object obj400 = obj399 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1656 @ S4_v377 (should have been resolved before IL gen)");
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1667 @ S4_v379 (Il2CppMethodInfo)+C]");
		object obj401 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1668 @ S4_v380+60]");
		object obj402 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1669 @ S4_v381+48]");
		object obj403 = 0;
		object obj404 = obj403 & 0x7FF;
		object obj405 = obj404 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1677 @ S5_v296 (should have been resolved before IL gen)");
		nint num81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ S4_v384 (Il2CppMethodInfo)+C]");
		object obj406 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ S4_v385+60]");
		object obj407 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1690 @ S4_v386+48]");
		object obj408 = 0;
		object obj409 = obj408 & 0x7FF;
		object obj410 = obj409 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1698 @ S5_v300 (should have been resolved before IL gen)");
		object obj411 = this + 36;
		object obj412 = default;
		obj411 = obj412;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ S3_v113 (Il2CppMethodInfo)+C]");
		object obj413 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ S3_v114+60]");
		object obj414 = 0;
		object obj415 = obj414;
		object obj416 = obj415 & 0x1FFF;
		object obj417 = obj416 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1721 @ S4_v391 (should have been resolved before IL gen)");
		nint num83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1732 @ S4_v393 (Il2CppMethodInfo)+C]");
		object obj418 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1733 @ S4_v394+60]");
		object obj419 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1734 @ S4_v395+48]");
		object obj420 = 0;
		object obj421 = obj420 & 0x7FF;
		object obj422 = obj421 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1742 @ S5_v306 (should have been resolved before IL gen)");
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ S4_v398 (Il2CppMethodInfo)+C]");
		object obj423 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1754 @ S4_v399+60]");
		object obj424 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ S4_v400+48]");
		object obj425 = 0;
		object obj426 = obj425 & 0x7FF;
		object obj427 = obj426 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1763 @ S5_v310 (should have been resolved before IL gen)");
		nint num85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ S4_v403 (Il2CppMethodInfo)+C]");
		object obj428 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ S4_v404+60]");
		object obj429 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ S4_v405+48]");
		object obj430 = 0;
		object obj431 = obj430 & 0x7FF;
		object obj432 = obj431 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1784 @ S5_v314 (should have been resolved before IL gen)");
		nint num86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ S4_v408 (Il2CppMethodInfo)+C]");
		object obj433 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ S4_v409+60]");
		object obj434 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1797 @ S4_v410+48]");
		object obj435 = 0;
		object obj436 = obj435 & 0x7FF;
		object obj437 = obj436 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1805 @ S5_v318 (should have been resolved before IL gen)");
		object obj438 = this + 40;
		object obj439 = default;
		obj438 = obj439;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1818 @ S3_v122 (Il2CppMethodInfo)+C]");
		object obj440 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ S3_v123+60]");
		object obj441 = 0;
		object obj442 = obj441;
		object obj443 = obj442 & 0x1FFF;
		object obj444 = obj443 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1828 @ S4_v415 (should have been resolved before IL gen)");
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ S4_v417 (Il2CppMethodInfo)+C]");
		object obj445 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1840 @ S4_v418+60]");
		object obj446 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ S4_v419+48]");
		object obj447 = 0;
		object obj448 = obj447 & 0x7FF;
		object obj449 = obj448 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1849 @ S5_v324 (should have been resolved before IL gen)");
		nint num89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1860 @ S4_v422 (Il2CppMethodInfo)+C]");
		object obj450 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1861 @ S4_v423+60]");
		object obj451 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1862 @ S4_v424+48]");
		object obj452 = 0;
		object obj453 = obj452 & 0x7FF;
		object obj454 = obj453 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1870 @ S5_v328 (should have been resolved before IL gen)");
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1881 @ S4_v427 (Il2CppMethodInfo)+C]");
		object obj455 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ S4_v428+60]");
		object obj456 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ S4_v429+48]");
		object obj457 = 0;
		object obj458 = obj457 & 0x7FF;
		object obj459 = obj458 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1891 @ S5_v332 (should have been resolved before IL gen)");
		nint num91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ S4_v432 (Il2CppMethodInfo)+C]");
		object obj460 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1903 @ S4_v433+60]");
		object obj461 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ S4_v434+48]");
		object obj462 = 0;
		object obj463 = obj462 & 0x7FF;
		object obj464 = obj463 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1912 @ S5_v336 (should have been resolved before IL gen)");
		nint num92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ S4_v437 (Il2CppMethodInfo)+C]");
		object obj465 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1924 @ S4_v438+60]");
		object obj466 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ S4_v439+48]");
		object obj467 = 0;
		object obj468 = obj467 & 0x7FF;
		object obj469 = obj468 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1933 @ S5_v340 (should have been resolved before IL gen)");
		nint num93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ S4_v442 (Il2CppMethodInfo)+C]");
		object obj470 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1945 @ S4_v443+60]");
		object obj471 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1946 @ S4_v444+48]");
		object obj472 = 0;
		object obj473 = obj472 & 0x7FF;
		object obj474 = obj473 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1954 @ S5_v344 (should have been resolved before IL gen)");
		object obj475 = this + 44;
		object obj476 = default;
		obj475 = obj476;
	}
}
