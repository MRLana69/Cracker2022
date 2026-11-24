using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsKindle_TEST : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _flurryAdCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _adColonyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _tapjoyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _chartboostCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _inmobiCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _vungleCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _supersonicCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _facebookCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _yeahMobiCacheIDs;

	public bool isRestricted
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_yeahMobiCacheIDs != 0;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs => null;

	public string AdColonyAppId => (string)(object)_flurryAdCacheIDs;

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string TapJoyAppId => (string)(object)_adColonyCacheIDs;

	public string TapJoyAppKey => "";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string ChartboostAppId => (string)(object)_tapjoyCacheIDs;

	public string ChartboostAppSignature => "541c0fa51873da1a46201811";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"f7422a8be58ef109f22c0413dfffb6df6fa905dc";

	public string InmobiAccountId => (string)(object)_chartboostCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string VungleAppId => (string)(object)_inmobiCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string SupersonicAppId => (string)(object)_vungleCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _supersonicCacheIDs;

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => _facebookCacheIDs;

	public string MobVistaAppId
	{
		get
		{
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Obj, but got Unknown
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
			string result = default;
			return result;
		}
	}

	public string MobVistaAppSdkKey => "";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public AdConstantsKindle_TEST()
	{
		//IL_09fc: Expected Obj, but got I
		//IL_0a0c: Expected Obj, but got I
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected Obj, but got Unknown
		//IL_0a6d: Expected Obj, but got I
		//IL_0a7d: Expected Obj, but got I
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected Obj, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected Obj, but got Unknown
		//IL_0ab9: Expected I, but got Obj
		//IL_0acf: Expected Obj, but got I
		//IL_0b02: Expected Obj, but got I
		//IL_0b12: Expected Obj, but got I
		//IL_0b22: Expected Obj, but got I
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected Obj, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		//IL_0b5e: Expected Obj, but got I
		//IL_0b6e: Expected Obj, but got I
		//IL_0b7e: Expected Obj, but got I
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected Obj, but got Unknown
		//IL_0bba: Expected Obj, but got I
		//IL_0bca: Expected Obj, but got I
		//IL_0bda: Expected Obj, but got I
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c16: Expected Obj, but got I
		//IL_0c26: Expected Obj, but got I
		//IL_0c36: Expected Obj, but got I
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_0c72: Expected Obj, but got I
		//IL_0c82: Expected Obj, but got I
		//IL_0c92: Expected Obj, but got I
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_0cce: Expected Obj, but got I
		//IL_0cde: Expected Obj, but got I
		//IL_0cee: Expected Obj, but got I
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0d2a: Expected Obj, but got I
		//IL_0d3a: Expected Obj, but got I
		//IL_0d4a: Expected Obj, but got I
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected Obj, but got Unknown
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected Obj, but got Unknown
		//IL_0d86: Expected Obj, but got I
		//IL_0d96: Expected Obj, but got I
		//IL_0da6: Expected Obj, but got I
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected Obj, but got Unknown
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected Obj, but got Unknown
		//IL_0de2: Expected Obj, but got I
		//IL_0df2: Expected Obj, but got I
		//IL_0e02: Expected Obj, but got I
		//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Expected Obj, but got Unknown
		//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected Obj, but got Unknown
		//IL_0e3e: Expected Obj, but got I
		//IL_0e4e: Expected Obj, but got I
		//IL_0e5e: Expected Obj, but got I
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected Obj, but got Unknown
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected Obj, but got Unknown
		//IL_0e9a: Expected Obj, but got I
		//IL_0eaa: Expected Obj, but got I
		//IL_0eba: Expected Obj, but got I
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected Obj, but got Unknown
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected Obj, but got Unknown
		//IL_0eee: Expected I, but got Obj
		//IL_0f04: Expected Obj, but got I
		//IL_0f1a: Expected Obj, but got I
		//IL_0f2a: Expected Obj, but got I
		//IL_0f3a: Expected Obj, but got I
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected Obj, but got Unknown
		//IL_0f76: Expected Obj, but got I
		//IL_0f86: Expected Obj, but got I
		//IL_0f96: Expected Obj, but got I
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Expected Obj, but got Unknown
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Expected Obj, but got Unknown
		//IL_0fd2: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I
		//IL_0ff2: Expected Obj, but got I
		//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1000: Expected Obj, but got Unknown
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Expected Obj, but got Unknown
		//IL_102e: Expected Obj, but got I
		//IL_103e: Expected Obj, but got I
		//IL_104e: Expected Obj, but got I
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected Obj, but got Unknown
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_106a: Expected Obj, but got Unknown
		//IL_108a: Expected Obj, but got I
		//IL_109a: Expected Obj, but got I
		//IL_10aa: Expected Obj, but got I
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected Obj, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10e6: Expected Obj, but got I
		//IL_10f6: Expected Obj, but got I
		//IL_1106: Expected Obj, but got I
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected Obj, but got Unknown
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected Obj, but got Unknown
		//IL_1142: Expected Obj, but got I
		//IL_1152: Expected Obj, but got I
		//IL_1162: Expected Obj, but got I
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Expected Obj, but got Unknown
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_117e: Expected Obj, but got Unknown
		//IL_119e: Expected Obj, but got I
		//IL_11ae: Expected Obj, but got I
		//IL_11be: Expected Obj, but got I
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected Obj, but got Unknown
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da: Expected Obj, but got Unknown
		//IL_11fa: Expected Obj, but got I
		//IL_120a: Expected Obj, but got I
		//IL_121a: Expected Obj, but got I
		//IL_1223: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected Obj, but got Unknown
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Expected Obj, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_124b: Expected Obj, but got Unknown
		//IL_1273: Expected Obj, but got I
		//IL_1283: Expected Obj, but got I
		//IL_1294: Unknown result type (might be due to invalid IL or missing references)
		//IL_1299: Expected Obj, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a7: Expected Obj, but got Unknown
		//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Expected Obj, but got Unknown
		//IL_12e4: Expected Obj, but got I
		//IL_12f4: Expected Obj, but got I
		//IL_1305: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a: Expected Obj, but got Unknown
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_1318: Expected Obj, but got Unknown
		//IL_1338: Expected Obj, but got I
		//IL_1348: Expected Obj, but got I
		//IL_1358: Expected Obj, but got I
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected Obj, but got Unknown
		//IL_136f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1374: Expected Obj, but got Unknown
		//IL_1394: Expected Obj, but got I
		//IL_13a4: Expected Obj, but got I
		//IL_13b4: Expected Obj, but got I
		//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Expected Obj, but got Unknown
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Expected Obj, but got Unknown
		//IL_13f0: Expected Obj, but got I
		//IL_1400: Expected Obj, but got I
		//IL_1410: Expected Obj, but got I
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_141e: Expected Obj, but got Unknown
		//IL_1427: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Expected Obj, but got Unknown
		//IL_144c: Expected Obj, but got I
		//IL_145c: Expected Obj, but got I
		//IL_146c: Expected Obj, but got I
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected Obj, but got Unknown
		//IL_1483: Unknown result type (might be due to invalid IL or missing references)
		//IL_1488: Expected Obj, but got Unknown
		//IL_14a8: Expected Obj, but got I
		//IL_14b8: Expected Obj, but got I
		//IL_14c8: Expected Obj, but got I
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d6: Expected Obj, but got Unknown
		//IL_14df: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Expected Obj, but got Unknown
		//IL_1504: Expected Obj, but got I
		//IL_1514: Expected Obj, but got I
		//IL_1524: Expected Obj, but got I
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Expected Obj, but got Unknown
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1540: Expected Obj, but got Unknown
		//IL_1560: Expected Obj, but got I
		//IL_1570: Expected Obj, but got I
		//IL_1580: Expected Obj, but got I
		//IL_1589: Unknown result type (might be due to invalid IL or missing references)
		//IL_158e: Expected Obj, but got Unknown
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_159c: Expected Obj, but got Unknown
		//IL_15bc: Expected Obj, but got I
		//IL_15cc: Expected Obj, but got I
		//IL_15dc: Expected Obj, but got I
		//IL_15e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Expected Obj, but got Unknown
		//IL_15f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Expected Obj, but got Unknown
		//IL_1618: Expected Obj, but got I
		//IL_1628: Expected Obj, but got I
		//IL_1638: Expected Obj, but got I
		//IL_1641: Unknown result type (might be due to invalid IL or missing references)
		//IL_1646: Expected Obj, but got Unknown
		//IL_164f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1654: Expected Obj, but got Unknown
		//IL_1674: Expected Obj, but got I
		//IL_1684: Expected Obj, but got I
		//IL_1694: Expected Obj, but got I
		//IL_169d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a2: Expected Obj, but got Unknown
		//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Expected Obj, but got Unknown
		//IL_16d0: Expected Obj, but got I
		//IL_16e0: Expected Obj, but got I
		//IL_16f0: Expected Obj, but got I
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fe: Expected Obj, but got Unknown
		//IL_1707: Unknown result type (might be due to invalid IL or missing references)
		//IL_170c: Expected Obj, but got Unknown
		//IL_172c: Expected Obj, but got I
		//IL_173c: Expected Obj, but got I
		//IL_174c: Expected Obj, but got I
		//IL_1755: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Expected Obj, but got Unknown
		//IL_1763: Unknown result type (might be due to invalid IL or missing references)
		//IL_1768: Expected Obj, but got Unknown
		//IL_1788: Expected Obj, but got I
		//IL_1798: Expected Obj, but got I
		//IL_17a8: Expected Obj, but got I
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b6: Expected Obj, but got Unknown
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c4: Expected Obj, but got Unknown
		//IL_17e4: Expected Obj, but got I
		//IL_17f4: Expected Obj, but got I
		//IL_1804: Expected Obj, but got I
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1812: Expected Obj, but got Unknown
		//IL_181b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1820: Expected Obj, but got Unknown
		//IL_1838: Expected I, but got Obj
		//IL_184e: Expected Obj, but got I
		//IL_1864: Expected Obj, but got I
		//IL_1874: Expected Obj, but got I
		//IL_1884: Expected Obj, but got I
		//IL_188d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Expected Obj, but got Unknown
		//IL_189b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a0: Expected Obj, but got Unknown
		//IL_18c0: Expected Obj, but got I
		//IL_18d0: Expected Obj, but got I
		//IL_18e0: Expected Obj, but got I
		//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee: Expected Obj, but got Unknown
		//IL_18f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fc: Expected Obj, but got Unknown
		//IL_191c: Expected Obj, but got I
		//IL_192c: Expected Obj, but got I
		//IL_193c: Expected Obj, but got I
		//IL_1945: Unknown result type (might be due to invalid IL or missing references)
		//IL_194a: Expected Obj, but got Unknown
		//IL_1953: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Expected Obj, but got Unknown
		//IL_1978: Expected Obj, but got I
		//IL_1988: Expected Obj, but got I
		//IL_1998: Expected Obj, but got I
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a6: Expected Obj, but got Unknown
		//IL_19af: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected Obj, but got Unknown
		//IL_19d4: Expected Obj, but got I
		//IL_19e4: Expected Obj, but got I
		//IL_19f4: Expected Obj, but got I
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a02: Expected Obj, but got Unknown
		//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a10: Expected Obj, but got Unknown
		//IL_1a30: Expected Obj, but got I
		//IL_1a40: Expected Obj, but got I
		//IL_1a50: Expected Obj, but got I
		//IL_1a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5e: Expected Obj, but got Unknown
		//IL_1a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6c: Expected Obj, but got Unknown
		//IL_1a8c: Expected Obj, but got I
		//IL_1a9c: Expected Obj, but got I
		//IL_1aac: Expected Obj, but got I
		//IL_1ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aba: Expected Obj, but got Unknown
		//IL_1ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Expected Obj, but got Unknown
		//IL_1ae8: Expected Obj, but got I
		//IL_1af8: Expected Obj, but got I
		//IL_1b08: Expected Obj, but got I
		//IL_1b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b16: Expected Obj, but got Unknown
		//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b24: Expected Obj, but got Unknown
		//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b39: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_040d: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
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
		//IL_0519: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_05fd: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I
		//IL_061d: Expected Obj, but got I
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I
		//IL_0669: Expected Obj, but got I
		//IL_0679: Expected Obj, but got I
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_06b5: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_0711: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I
		//IL_0731: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_076d: Expected Obj, but got I
		//IL_077d: Expected Obj, but got I
		//IL_078d: Expected Obj, but got I
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got Unknown
		//IL_07c9: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I
		//IL_0835: Expected Obj, but got I
		//IL_0845: Expected Obj, but got I
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected Obj, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_08a3: Expected Obj, but got I
		//IL_08b3: Expected Obj, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Obj, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_0914: Expected Obj, but got I
		//IL_0924: Expected Obj, but got I
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected Obj, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected Obj, but got Unknown
		//IL_098a: Expected Obj, but got I
		//IL_099a: Expected Obj, but got I
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected Obj, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
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
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v8 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14 (Il2CppClass<AdLocations>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v179 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v10 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v11+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v12+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S5_v8 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v15 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v16+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v17+48]");
		object obj21 = 0;
		object obj22 = obj21 & 0x7FF;
		object obj23 = obj22 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v12 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v20 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S4_v21+60]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v22+48]");
		object obj26 = 0;
		object obj27 = obj26 & 0x7FF;
		object obj28 = obj27 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v130 @ S5_v16 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v25 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v26+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v27+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S5_v20 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v30 (Il2CppMethodInfo)+C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v31+60]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v32+48]");
		object obj36 = 0;
		object obj37 = obj36 & 0x7FF;
		object obj38 = obj37 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v24 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S4_v35 (Il2CppMethodInfo)+C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S4_v36+60]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S4_v37+48]");
		object obj41 = 0;
		object obj42 = obj41 & 0x7FF;
		object obj43 = obj42 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v193 @ S5_v28 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S4_v40 (Il2CppMethodInfo)+C]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S4_v41+60]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S4_v42+48]");
		object obj46 = 0;
		object obj47 = obj46 & 0x7FF;
		object obj48 = obj47 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S5_v32 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S4_v45 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v46+60]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v47+48]");
		object obj51 = 0;
		object obj52 = obj51 & 0x7FF;
		object obj53 = obj52 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v235 @ S5_v36 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S4_v50 (Il2CppMethodInfo)+C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S4_v51+60]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S4_v52+48]");
		object obj56 = 0;
		object obj57 = obj56 & 0x7FF;
		object obj58 = obj57 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v256 @ S5_v40 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S4_v55 (Il2CppMethodInfo)+C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S4_v56+60]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v57+48]");
		object obj61 = 0;
		object obj62 = obj61 & 0x7FF;
		object obj63 = obj62 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v277 @ S5_v44 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S4_v60 (Il2CppMethodInfo)+C]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S4_v61+60]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S4_v62+48]");
		object obj66 = 0;
		object obj67 = obj66 & 0x7FF;
		object obj68 = obj67 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v298 @ S5_v48 (should have been resolved before IL gen)");
		nint num16 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v51 (Il2CppClass<AdLocations>)+5C]");
		object obj69 = -(-64);
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v65 (Il2CppMethodInfo)+C]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v66+60]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S4_v67+48]");
		object obj72 = 0;
		object obj73 = obj72 & 0x7FF;
		object obj74 = obj73 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v321 @ S5_v52 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S4_v70 (Il2CppMethodInfo)+C]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S4_v71+60]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S4_v72+48]");
		object obj77 = 0;
		object obj78 = obj77 & 0x7FF;
		object obj79 = obj78 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v342 @ S5_v56 (should have been resolved before IL gen)");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S4_v75 (Il2CppMethodInfo)+C]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S4_v76+60]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S4_v77+48]");
		object obj82 = 0;
		object obj83 = obj82 & 0x7FF;
		object obj84 = obj83 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v363 @ S5_v60 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S4_v80 (Il2CppMethodInfo)+C]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S4_v81+60]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S4_v82+48]");
		object obj87 = 0;
		object obj88 = obj87 & 0x7FF;
		object obj89 = obj88 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v384 @ S5_v64 (should have been resolved before IL gen)");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S4_v85 (Il2CppMethodInfo)+C]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S4_v86+60]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S4_v87+48]");
		object obj92 = 0;
		object obj93 = obj92 & 0x7FF;
		object obj94 = obj93 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v405 @ S5_v68 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S4_v90 (Il2CppMethodInfo)+C]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S4_v91+60]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S4_v92+48]");
		object obj97 = 0;
		object obj98 = obj97 & 0x7FF;
		object obj99 = obj98 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v426 @ S5_v72 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S4_v95 (Il2CppMethodInfo)+C]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S4_v96+60]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S4_v97+48]");
		object obj102 = 0;
		object obj103 = obj102 & 0x7FF;
		object obj104 = obj103 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v447 @ S5_v76 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S4_v100 (Il2CppMethodInfo)+C]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S4_v101+60]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S4_v102+48]");
		object obj107 = 0;
		object obj108 = obj107 & 0x7FF;
		object obj109 = obj108 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v468 @ S5_v80 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S4_v105 (Il2CppMethodInfo)+C]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S4_v106+60]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S4_v107+48]");
		object obj112 = 0;
		object obj113 = obj112 & 0x7FF;
		object obj114 = obj113 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v489 @ S5_v84 (should have been resolved before IL gen)");
		object obj115 = this + 12;
		object obj116 = default;
		obj115 = obj116;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S3_v32 (Il2CppMethodInfo)+C]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S3_v33+60]");
		object obj118 = 0;
		object obj119 = obj118;
		object obj120 = obj119 & 0x1FFF;
		object obj121 = obj120 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v513 @ S4_v112 (should have been resolved before IL gen)");
		object obj122 = this + 16;
		object obj123 = default;
		obj122 = obj123;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S3_v37 (Il2CppMethodInfo)+C]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S3_v38+60]");
		object obj125 = 0;
		object obj126 = obj125;
		object obj127 = obj126 & 0x1FFF;
		object obj128 = obj127 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v537 @ S4_v116 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S4_v118 (Il2CppMethodInfo)+C]");
		object obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S4_v119+60]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S4_v120+48]");
		object obj131 = 0;
		object obj132 = obj131 & 0x7FF;
		object obj133 = obj132 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v558 @ S5_v92 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S4_v123 (Il2CppMethodInfo)+C]");
		object obj134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S4_v124+60]");
		object obj135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S4_v125+48]");
		object obj136 = 0;
		object obj137 = obj136 & 0x7FF;
		object obj138 = obj137 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v579 @ S5_v96 (should have been resolved before IL gen)");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S4_v128 (Il2CppMethodInfo)+C]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S4_v129+60]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S4_v130+48]");
		object obj141 = 0;
		object obj142 = obj141 & 0x7FF;
		object obj143 = obj142 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v600 @ S5_v100 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S4_v133 (Il2CppMethodInfo)+C]");
		object obj144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S4_v134+60]");
		object obj145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S4_v135+48]");
		object obj146 = 0;
		object obj147 = obj146 & 0x7FF;
		object obj148 = obj147 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v621 @ S5_v104 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S4_v138 (Il2CppMethodInfo)+C]");
		object obj149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S4_v139+60]");
		object obj150 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S4_v140+48]");
		object obj151 = 0;
		object obj152 = obj151 & 0x7FF;
		object obj153 = obj152 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v642 @ S5_v108 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S4_v143 (Il2CppMethodInfo)+C]");
		object obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S4_v144+60]");
		object obj155 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S4_v145+48]");
		object obj156 = 0;
		object obj157 = obj156 & 0x7FF;
		object obj158 = obj157 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v663 @ S5_v112 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S4_v148 (Il2CppMethodInfo)+C]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S4_v149+60]");
		object obj160 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S4_v150+48]");
		object obj161 = 0;
		object obj162 = obj161 & 0x7FF;
		object obj163 = obj162 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v684 @ S5_v116 (should have been resolved before IL gen)");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S4_v153 (Il2CppMethodInfo)+C]");
		object obj164 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S4_v154+60]");
		object obj165 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S4_v155+48]");
		object obj166 = 0;
		object obj167 = obj166 & 0x7FF;
		object obj168 = obj167 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v705 @ S5_v120 (should have been resolved before IL gen)");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S4_v158 (Il2CppMethodInfo)+C]");
		object obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S4_v159+60]");
		object obj170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S4_v160+48]");
		object obj171 = 0;
		object obj172 = obj171 & 0x7FF;
		object obj173 = obj172 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v726 @ S5_v124 (should have been resolved before IL gen)");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S4_v163 (Il2CppMethodInfo)+C]");
		object obj174 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S4_v164+60]");
		object obj175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S4_v165+48]");
		object obj176 = 0;
		object obj177 = obj176 & 0x7FF;
		object obj178 = obj177 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v747 @ S5_v128 (should have been resolved before IL gen)");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S4_v168 (Il2CppMethodInfo)+C]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S4_v169+60]");
		object obj180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S4_v170+48]");
		object obj181 = 0;
		object obj182 = obj181 & 0x7FF;
		object obj183 = obj182 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v768 @ S5_v132 (should have been resolved before IL gen)");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S4_v173 (Il2CppMethodInfo)+C]");
		object obj184 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S4_v174+60]");
		object obj185 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S4_v175+48]");
		object obj186 = 0;
		object obj187 = obj186 & 0x7FF;
		object obj188 = obj187 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v789 @ S5_v136 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S4_v178 (Il2CppMethodInfo)+C]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S4_v179+60]");
		object obj190 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ S4_v180+48]");
		object obj191 = 0;
		object obj192 = obj191 & 0x7FF;
		object obj193 = obj192 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v810 @ S5_v140 (should have been resolved before IL gen)");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S4_v183 (Il2CppMethodInfo)+C]");
		object obj194 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S4_v184+60]");
		object obj195 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ S4_v185+48]");
		object obj196 = 0;
		object obj197 = obj196 & 0x7FF;
		object obj198 = obj197 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v831 @ S5_v144 (should have been resolved before IL gen)");
		nint num42 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S1_v150 (Il2CppClass<AdLocations>)+5C]");
		object obj199 = -(-64);
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S4_v188 (Il2CppMethodInfo)+C]");
		object obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S4_v189+60]");
		object obj201 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S4_v190+48]");
		object obj202 = 0;
		object obj203 = obj202 & 0x7FF;
		object obj204 = obj203 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v854 @ S5_v148 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S4_v193 (Il2CppMethodInfo)+C]");
		object obj205 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S4_v194+60]");
		object obj206 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S4_v195+48]");
		object obj207 = 0;
		object obj208 = obj207 & 0x7FF;
		object obj209 = obj208 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v875 @ S5_v152 (should have been resolved before IL gen)");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S4_v198 (Il2CppMethodInfo)+C]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S4_v199+60]");
		object obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S4_v200+48]");
		object obj212 = 0;
		object obj213 = obj212 & 0x7FF;
		object obj214 = obj213 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v896 @ S5_v156 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S4_v203 (Il2CppMethodInfo)+C]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S4_v204+60]");
		object obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ S4_v205+48]");
		object obj217 = 0;
		object obj218 = obj217 & 0x7FF;
		object obj219 = obj218 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v917 @ S5_v160 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S4_v208 (Il2CppMethodInfo)+C]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S4_v209+60]");
		object obj221 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ S4_v210+48]");
		object obj222 = 0;
		object obj223 = obj222 & 0x7FF;
		object obj224 = obj223 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v938 @ S5_v164 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S4_v213 (Il2CppMethodInfo)+C]");
		object obj225 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S4_v214+60]");
		object obj226 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ S4_v215+48]");
		object obj227 = 0;
		object obj228 = obj227 & 0x7FF;
		object obj229 = obj228 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v959 @ S5_v168 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S4_v218 (Il2CppMethodInfo)+C]");
		object obj230 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ S4_v219+60]");
		object obj231 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ S4_v220+48]");
		object obj232 = 0;
		object obj233 = obj232 & 0x7FF;
		object obj234 = obj233 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v980 @ S5_v172 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S4_v223 (Il2CppMethodInfo)+C]");
		object obj235 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ S4_v224+60]");
		object obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ S4_v225+48]");
		object obj237 = 0;
		object obj238 = obj237 & 0x7FF;
		object obj239 = obj238 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1001 @ S5_v176 (should have been resolved before IL gen)");
		object obj240 = this + 20;
		object obj241 = default;
		obj240 = obj241;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ S3_v64 (Il2CppMethodInfo)+C]");
		object obj242 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S3_v65+60]");
		object obj243 = 0;
		object obj244 = obj243;
		object obj245 = obj244 & 0x1FFF;
		object obj246 = obj245 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1024 @ S4_v230 (should have been resolved before IL gen)");
		object obj247 = this + 24;
		object obj248 = default;
		obj247 = obj248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ S3_v69 (Il2CppMethodInfo)+C]");
		object obj249 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ S3_v70+60]");
		object obj250 = 0;
		object obj251 = obj250;
		object obj252 = obj251 & 0x1FFF;
		object obj253 = obj252 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1047 @ S4_v234 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ S4_v236 (Il2CppMethodInfo)+C]");
		object obj254 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ S4_v237+60]");
		object obj255 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ S4_v238+48]");
		object obj256 = 0;
		object obj257 = obj256 & 0x7FF;
		object obj258 = obj257 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1068 @ S5_v184 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ S4_v241 (Il2CppMethodInfo)+C]");
		object obj259 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ S4_v242+60]");
		object obj260 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ S4_v243+48]");
		object obj261 = 0;
		object obj262 = obj261 & 0x7FF;
		object obj263 = obj262 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1089 @ S5_v188 (should have been resolved before IL gen)");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ S4_v246 (Il2CppMethodInfo)+C]");
		object obj264 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ S4_v247+60]");
		object obj265 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ S4_v248+48]");
		object obj266 = 0;
		object obj267 = obj266 & 0x7FF;
		object obj268 = obj267 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1110 @ S5_v192 (should have been resolved before IL gen)");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S4_v251 (Il2CppMethodInfo)+C]");
		object obj269 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ S4_v252+60]");
		object obj270 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S4_v253+48]");
		object obj271 = 0;
		object obj272 = obj271 & 0x7FF;
		object obj273 = obj272 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1131 @ S5_v196 (should have been resolved before IL gen)");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ S4_v256 (Il2CppMethodInfo)+C]");
		object obj274 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S4_v257+60]");
		object obj275 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ S4_v258+48]");
		object obj276 = 0;
		object obj277 = obj276 & 0x7FF;
		object obj278 = obj277 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1152 @ S5_v200 (should have been resolved before IL gen)");
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ S4_v261 (Il2CppMethodInfo)+C]");
		object obj279 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ S4_v262+60]");
		object obj280 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ S4_v263+48]");
		object obj281 = 0;
		object obj282 = obj281 & 0x7FF;
		object obj283 = obj282 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1173 @ S5_v204 (should have been resolved before IL gen)");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S4_v266 (Il2CppMethodInfo)+C]");
		object obj284 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ S4_v267+60]");
		object obj285 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ S4_v268+48]");
		object obj286 = 0;
		object obj287 = obj286 & 0x7FF;
		object obj288 = obj287 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1194 @ S5_v208 (should have been resolved before IL gen)");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ S4_v271 (Il2CppMethodInfo)+C]");
		object obj289 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ S4_v272+60]");
		object obj290 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ S4_v273+48]");
		object obj291 = 0;
		object obj292 = obj291 & 0x7FF;
		object obj293 = obj292 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1215 @ S5_v212 (should have been resolved before IL gen)");
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ S4_v276 (Il2CppMethodInfo)+C]");
		object obj294 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ S4_v277+60]");
		object obj295 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ S4_v278+48]");
		object obj296 = 0;
		object obj297 = obj296 & 0x7FF;
		object obj298 = obj297 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1236 @ S5_v216 (should have been resolved before IL gen)");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S4_v281 (Il2CppMethodInfo)+C]");
		object obj299 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ S4_v282+60]");
		object obj300 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ S4_v283+48]");
		object obj301 = 0;
		object obj302 = obj301 & 0x7FF;
		object obj303 = obj302 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1257 @ S5_v220 (should have been resolved before IL gen)");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S4_v286 (Il2CppMethodInfo)+C]");
		object obj304 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S4_v287+60]");
		object obj305 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S4_v288+48]");
		object obj306 = 0;
		object obj307 = obj306 & 0x7FF;
		object obj308 = obj307 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1278 @ S5_v224 (should have been resolved before IL gen)");
		nint num64 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ S1_v233 (Il2CppClass<AdLocations>)+5C]");
		object obj309 = -(-64);
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ S4_v291 (Il2CppMethodInfo)+C]");
		object obj310 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ S4_v292+60]");
		object obj311 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ S4_v293+48]");
		object obj312 = 0;
		object obj313 = obj312 & 0x7FF;
		object obj314 = obj313 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1301 @ S5_v228 (should have been resolved before IL gen)");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S4_v296 (Il2CppMethodInfo)+C]");
		object obj315 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ S4_v297+60]");
		object obj316 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ S4_v298+48]");
		object obj317 = 0;
		object obj318 = obj317 & 0x7FF;
		object obj319 = obj318 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1322 @ S5_v232 (should have been resolved before IL gen)");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ S4_v301 (Il2CppMethodInfo)+C]");
		object obj320 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ S4_v302+60]");
		object obj321 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ S4_v303+48]");
		object obj322 = 0;
		object obj323 = obj322 & 0x7FF;
		object obj324 = obj323 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1343 @ S5_v236 (should have been resolved before IL gen)");
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ S4_v306 (Il2CppMethodInfo)+C]");
		object obj325 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ S4_v307+60]");
		object obj326 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ S4_v308+48]");
		object obj327 = 0;
		object obj328 = obj327 & 0x7FF;
		object obj329 = obj328 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1364 @ S5_v240 (should have been resolved before IL gen)");
		nint num69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ S4_v311 (Il2CppMethodInfo)+C]");
		object obj330 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ S4_v312+60]");
		object obj331 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ S4_v313+48]");
		object obj332 = 0;
		object obj333 = obj332 & 0x7FF;
		object obj334 = obj333 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1385 @ S5_v244 (should have been resolved before IL gen)");
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ S4_v316 (Il2CppMethodInfo)+C]");
		object obj335 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ S4_v317+60]");
		object obj336 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ S4_v318+48]");
		object obj337 = 0;
		object obj338 = obj337 & 0x7FF;
		object obj339 = obj338 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1406 @ S5_v248 (should have been resolved before IL gen)");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ S4_v321 (Il2CppMethodInfo)+C]");
		object obj340 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1418 @ S4_v322+60]");
		object obj341 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ S4_v323+48]");
		object obj342 = 0;
		object obj343 = obj342 & 0x7FF;
		object obj344 = obj343 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1427 @ S5_v252 (should have been resolved before IL gen)");
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ S4_v326 (Il2CppMethodInfo)+C]");
		object obj345 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ S4_v327+60]");
		object obj346 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ S4_v328+48]");
		object obj347 = 0;
		object obj348 = obj347 & 0x7FF;
		object obj349 = obj348 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1448 @ S5_v256 (should have been resolved before IL gen)");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ S4_v331 (Il2CppMethodInfo)+C]");
		object obj350 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1460 @ S4_v332+60]");
		object obj351 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ S4_v333+48]");
		object obj352 = 0;
		object obj353 = obj352 & 0x7FF;
		object obj354 = obj353 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1469 @ S5_v260 (should have been resolved before IL gen)");
		object obj355 = this + 28;
		object obj356 = default;
		obj355 = obj356;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1482 @ S3_v94 (Il2CppMethodInfo)+C]");
		object obj357 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ S3_v95+60]");
		object obj358 = 0;
		object obj359 = obj358;
		object obj360 = obj359 & 0x1FFF;
		object obj361 = obj360 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1492 @ S4_v338 (should have been resolved before IL gen)");
		object obj362 = this + 32;
		object obj363 = default;
		obj362 = obj363;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ S3_v99 (Il2CppMethodInfo)+C]");
		object obj364 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ S3_v100+60]");
		object obj365 = 0;
		object obj366 = obj365;
		object obj367 = obj366 & 0x1FFF;
		object obj368 = obj367 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1515 @ S4_v342 (should have been resolved before IL gen)");
		object obj369 = this + 36;
		object obj370 = default;
		obj369 = obj370;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ S3_v104 (Il2CppMethodInfo)+C]");
		object obj371 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1529 @ S3_v105+60]");
		object obj372 = 0;
		object obj373 = obj372;
		object obj374 = obj373 & 0x1FFF;
		object obj375 = obj374 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1538 @ S4_v346 (should have been resolved before IL gen)");
		object obj376 = this + 40;
		object obj377 = default;
		obj376 = obj377;
	}
}
