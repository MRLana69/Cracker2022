using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

public class CountryManager
{
	private enum LocaleComponents
	{
		language,
		countryCode
	}

	private static CountryManager _instance;

	public static CountryManager instance
	{
		get
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected Obj, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected Obj, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected Obj, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected Obj, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected Obj, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected Obj, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected Obj, but got Unknown
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected Obj, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected Obj, but got Unknown
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected Obj, but got Unknown
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected Obj, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected Obj, but got Unknown
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Expected Obj, but got Unknown
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected Obj, but got Unknown
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Expected Obj, but got Unknown
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected Obj, but got Unknown
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected Obj, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected Obj, but got Unknown
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Expected Obj, but got Unknown
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Expected Obj, but got Unknown
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Expected Obj, but got Unknown
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Expected Obj, but got Unknown
			//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Expected Obj, but got Unknown
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Expected Obj, but got Unknown
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Expected Obj, but got Unknown
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected Obj, but got Unknown
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Expected Obj, but got Unknown
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Expected Obj, but got Unknown
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Expected Obj, but got Unknown
			//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Expected Obj, but got Unknown
			//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d9: Expected Obj, but got Unknown
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Expected Obj, but got Unknown
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Expected Obj, but got Unknown
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Expected Obj, but got Unknown
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected Obj, but got Unknown
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Expected Obj, but got Unknown
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_059b: Expected Obj, but got Unknown
			//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b2: Expected Obj, but got Unknown
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e5: Expected Obj, but got Unknown
			//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Expected Obj, but got Unknown
			//IL_060e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0613: Expected Obj, but got Unknown
			//IL_0641: Unknown result type (might be due to invalid IL or missing references)
			//IL_0646: Expected Obj, but got Unknown
			//IL_0658: Unknown result type (might be due to invalid IL or missing references)
			//IL_065d: Expected Obj, but got Unknown
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0674: Expected Obj, but got Unknown
			//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a7: Expected Obj, but got Unknown
			//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06be: Expected Obj, but got Unknown
			//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d5: Expected Obj, but got Unknown
			//IL_0703: Unknown result type (might be due to invalid IL or missing references)
			//IL_0708: Expected Obj, but got Unknown
			//IL_071a: Unknown result type (might be due to invalid IL or missing references)
			//IL_071f: Expected Obj, but got Unknown
			//IL_0731: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Expected Obj, but got Unknown
			//IL_0764: Unknown result type (might be due to invalid IL or missing references)
			//IL_0769: Expected Obj, but got Unknown
			//IL_077b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0780: Expected Obj, but got Unknown
			//IL_0792: Unknown result type (might be due to invalid IL or missing references)
			//IL_0797: Expected Obj, but got Unknown
			//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ca: Expected Obj, but got Unknown
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Expected Obj, but got Unknown
			//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f8: Expected Obj, but got Unknown
			//IL_0826: Unknown result type (might be due to invalid IL or missing references)
			//IL_082b: Expected Obj, but got Unknown
			//IL_083d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Expected Obj, but got Unknown
			//IL_0854: Unknown result type (might be due to invalid IL or missing references)
			//IL_0859: Expected Obj, but got Unknown
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_088c: Expected Obj, but got Unknown
			//IL_089e: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a3: Expected Obj, but got Unknown
			//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ba: Expected Obj, but got Unknown
			//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ed: Expected Obj, but got Unknown
			//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Expected Obj, but got Unknown
			//IL_0916: Unknown result type (might be due to invalid IL or missing references)
			//IL_091b: Expected Obj, but got Unknown
			//IL_0949: Unknown result type (might be due to invalid IL or missing references)
			//IL_094e: Expected Obj, but got Unknown
			//IL_0960: Unknown result type (might be due to invalid IL or missing references)
			//IL_0965: Expected Obj, but got Unknown
			//IL_0977: Unknown result type (might be due to invalid IL or missing references)
			//IL_097c: Expected Obj, but got Unknown
			//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_09af: Expected Obj, but got Unknown
			//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c6: Expected Obj, but got Unknown
			//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dd: Expected Obj, but got Unknown
			//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a10: Expected Obj, but got Unknown
			//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a27: Expected Obj, but got Unknown
			//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3e: Expected Obj, but got Unknown
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a71: Expected Obj, but got Unknown
			//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a88: Expected Obj, but got Unknown
			//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9f: Expected Obj, but got Unknown
			//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad2: Expected Obj, but got Unknown
			//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae9: Expected Obj, but got Unknown
			//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b00: Expected Obj, but got Unknown
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b33: Expected Obj, but got Unknown
			//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4a: Expected Obj, but got Unknown
			//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b61: Expected Obj, but got Unknown
			//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b94: Expected Obj, but got Unknown
			//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bab: Expected Obj, but got Unknown
			//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc2: Expected Obj, but got Unknown
			//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf5: Expected Obj, but got Unknown
			//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0c: Expected Obj, but got Unknown
			//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c23: Expected Obj, but got Unknown
			//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c56: Expected Obj, but got Unknown
			//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c6d: Expected Obj, but got Unknown
			//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c84: Expected Obj, but got Unknown
			//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb7: Expected Obj, but got Unknown
			//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cce: Expected Obj, but got Unknown
			//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce5: Expected Obj, but got Unknown
			//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d18: Expected Obj, but got Unknown
			//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2f: Expected Obj, but got Unknown
			//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d46: Expected Obj, but got Unknown
			//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d79: Expected Obj, but got Unknown
			//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d90: Expected Obj, but got Unknown
			//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da7: Expected Obj, but got Unknown
			//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dda: Expected Obj, but got Unknown
			//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df1: Expected Obj, but got Unknown
			//IL_0e03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e08: Expected Obj, but got Unknown
			//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3b: Expected Obj, but got Unknown
			//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e52: Expected Obj, but got Unknown
			//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e69: Expected Obj, but got Unknown
			//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9c: Expected Obj, but got Unknown
			//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb3: Expected Obj, but got Unknown
			//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eca: Expected Obj, but got Unknown
			//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efd: Expected Obj, but got Unknown
			//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f14: Expected Obj, but got Unknown
			//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2b: Expected Obj, but got Unknown
			//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f5e: Expected Obj, but got Unknown
			//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f75: Expected Obj, but got Unknown
			//IL_0f87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8c: Expected Obj, but got Unknown
			//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbf: Expected Obj, but got Unknown
			//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd6: Expected Obj, but got Unknown
			//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fed: Expected Obj, but got Unknown
			//IL_101b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1020: Expected Obj, but got Unknown
			//IL_1032: Unknown result type (might be due to invalid IL or missing references)
			//IL_1037: Expected Obj, but got Unknown
			//IL_1049: Unknown result type (might be due to invalid IL or missing references)
			//IL_104e: Expected Obj, but got Unknown
			//IL_107c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1081: Expected Obj, but got Unknown
			//IL_1093: Unknown result type (might be due to invalid IL or missing references)
			//IL_1098: Expected Obj, but got Unknown
			//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_10af: Expected Obj, but got Unknown
			//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e2: Expected Obj, but got Unknown
			//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f9: Expected Obj, but got Unknown
			//IL_110b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1110: Expected Obj, but got Unknown
			//IL_113e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1143: Expected Obj, but got Unknown
			//IL_1155: Unknown result type (might be due to invalid IL or missing references)
			//IL_115a: Expected Obj, but got Unknown
			//IL_116c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1171: Expected Obj, but got Unknown
			//IL_119f: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a4: Expected Obj, but got Unknown
			//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_11bb: Expected Obj, but got Unknown
			//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d2: Expected Obj, but got Unknown
			//IL_1200: Unknown result type (might be due to invalid IL or missing references)
			//IL_1205: Expected Obj, but got Unknown
			//IL_1217: Unknown result type (might be due to invalid IL or missing references)
			//IL_121c: Expected Obj, but got Unknown
			//IL_122e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1233: Expected Obj, but got Unknown
			//IL_1261: Unknown result type (might be due to invalid IL or missing references)
			//IL_1266: Expected Obj, but got Unknown
			//IL_1278: Unknown result type (might be due to invalid IL or missing references)
			//IL_127d: Expected Obj, but got Unknown
			//IL_128f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1294: Expected Obj, but got Unknown
			//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c7: Expected Obj, but got Unknown
			//IL_12d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_12de: Expected Obj, but got Unknown
			//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f5: Expected Obj, but got Unknown
			//IL_1323: Unknown result type (might be due to invalid IL or missing references)
			//IL_1328: Expected Obj, but got Unknown
			//IL_133a: Unknown result type (might be due to invalid IL or missing references)
			//IL_133f: Expected Obj, but got Unknown
			//IL_1351: Unknown result type (might be due to invalid IL or missing references)
			//IL_1356: Expected Obj, but got Unknown
			//IL_1384: Unknown result type (might be due to invalid IL or missing references)
			//IL_1389: Expected Obj, but got Unknown
			//IL_139b: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a0: Expected Obj, but got Unknown
			//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b7: Expected Obj, but got Unknown
			//IL_13e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ea: Expected Obj, but got Unknown
			//IL_13fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1401: Expected Obj, but got Unknown
			//IL_1413: Unknown result type (might be due to invalid IL or missing references)
			//IL_1418: Expected Obj, but got Unknown
			//IL_1446: Unknown result type (might be due to invalid IL or missing references)
			//IL_144b: Expected Obj, but got Unknown
			//IL_145d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1462: Expected Obj, but got Unknown
			//IL_1474: Unknown result type (might be due to invalid IL or missing references)
			//IL_1479: Expected Obj, but got Unknown
			//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ac: Expected Obj, but got Unknown
			//IL_14be: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c3: Expected Obj, but got Unknown
			//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_14da: Expected Obj, but got Unknown
			//IL_1508: Unknown result type (might be due to invalid IL or missing references)
			//IL_150d: Expected Obj, but got Unknown
			//IL_151f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1524: Expected Obj, but got Unknown
			//IL_1536: Unknown result type (might be due to invalid IL or missing references)
			//IL_153b: Expected Obj, but got Unknown
			//IL_1569: Unknown result type (might be due to invalid IL or missing references)
			//IL_156e: Expected Obj, but got Unknown
			//IL_1580: Unknown result type (might be due to invalid IL or missing references)
			//IL_1585: Expected Obj, but got Unknown
			//IL_1597: Unknown result type (might be due to invalid IL or missing references)
			//IL_159c: Expected Obj, but got Unknown
			//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_15cf: Expected Obj, but got Unknown
			//IL_15e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_15e6: Expected Obj, but got Unknown
			//IL_15f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fd: Expected Obj, but got Unknown
			//IL_162b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1630: Expected Obj, but got Unknown
			//IL_1642: Unknown result type (might be due to invalid IL or missing references)
			//IL_1647: Expected Obj, but got Unknown
			//IL_1659: Unknown result type (might be due to invalid IL or missing references)
			//IL_165e: Expected Obj, but got Unknown
			//IL_168c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1691: Expected Obj, but got Unknown
			//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a8: Expected Obj, but got Unknown
			//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_16bf: Expected Obj, but got Unknown
			//IL_16ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f2: Expected Obj, but got Unknown
			//IL_1704: Unknown result type (might be due to invalid IL or missing references)
			//IL_1709: Expected Obj, but got Unknown
			//IL_171b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1720: Expected Obj, but got Unknown
			//IL_174e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1753: Expected Obj, but got Unknown
			//IL_1765: Unknown result type (might be due to invalid IL or missing references)
			//IL_176a: Expected Obj, but got Unknown
			//IL_177c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1781: Expected Obj, but got Unknown
			//IL_17af: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b4: Expected Obj, but got Unknown
			//IL_17c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_17cb: Expected Obj, but got Unknown
			//IL_17dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e2: Expected Obj, but got Unknown
			//IL_1810: Unknown result type (might be due to invalid IL or missing references)
			//IL_1815: Expected Obj, but got Unknown
			//IL_1827: Unknown result type (might be due to invalid IL or missing references)
			//IL_182c: Expected Obj, but got Unknown
			//IL_183e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1843: Expected Obj, but got Unknown
			//IL_1871: Unknown result type (might be due to invalid IL or missing references)
			//IL_1876: Expected Obj, but got Unknown
			//IL_1888: Unknown result type (might be due to invalid IL or missing references)
			//IL_188d: Expected Obj, but got Unknown
			//IL_189f: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a4: Expected Obj, but got Unknown
			//IL_18d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d7: Expected Obj, but got Unknown
			//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ee: Expected Obj, but got Unknown
			//IL_1900: Unknown result type (might be due to invalid IL or missing references)
			//IL_1905: Expected Obj, but got Unknown
			//IL_1933: Unknown result type (might be due to invalid IL or missing references)
			//IL_1938: Expected Obj, but got Unknown
			//IL_194a: Unknown result type (might be due to invalid IL or missing references)
			//IL_194f: Expected Obj, but got Unknown
			//IL_1961: Unknown result type (might be due to invalid IL or missing references)
			//IL_1966: Expected Obj, but got Unknown
			//IL_1994: Unknown result type (might be due to invalid IL or missing references)
			//IL_1999: Expected Obj, but got Unknown
			//IL_19ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b0: Expected Obj, but got Unknown
			//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_19c7: Expected Obj, but got Unknown
			//IL_19f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19fa: Expected Obj, but got Unknown
			//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a11: Expected Obj, but got Unknown
			//IL_1a23: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a28: Expected Obj, but got Unknown
			//IL_1a56: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a5b: Expected Obj, but got Unknown
			//IL_1a6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a72: Expected Obj, but got Unknown
			//IL_1a84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a89: Expected Obj, but got Unknown
			//IL_1ab7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1abc: Expected Obj, but got Unknown
			//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad3: Expected Obj, but got Unknown
			//IL_1ae5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aea: Expected Obj, but got Unknown
			//IL_1b18: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b1d: Expected Obj, but got Unknown
			//IL_1b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b34: Expected Obj, but got Unknown
			//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b4b: Expected Obj, but got Unknown
			//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b7e: Expected Obj, but got Unknown
			//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b95: Expected Obj, but got Unknown
			//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bac: Expected Obj, but got Unknown
			//IL_1bda: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bdf: Expected Obj, but got Unknown
			//IL_1bf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf6: Expected Obj, but got Unknown
			//IL_1c08: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c0d: Expected Obj, but got Unknown
			//IL_1c3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c40: Expected Obj, but got Unknown
			//IL_1c52: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c57: Expected Obj, but got Unknown
			//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c6e: Expected Obj, but got Unknown
			//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ca1: Expected Obj, but got Unknown
			//IL_1cb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cb8: Expected Obj, but got Unknown
			//IL_1cca: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ccf: Expected Obj, but got Unknown
			//IL_1cfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d02: Expected Obj, but got Unknown
			//IL_1d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d19: Expected Obj, but got Unknown
			//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d30: Expected Obj, but got Unknown
			//IL_1d5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d63: Expected Obj, but got Unknown
			//IL_1d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d7a: Expected Obj, but got Unknown
			//IL_1d8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d91: Expected Obj, but got Unknown
			//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dc4: Expected Obj, but got Unknown
			//IL_1dd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ddb: Expected Obj, but got Unknown
			//IL_1ded: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df2: Expected Obj, but got Unknown
			//IL_1e20: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e25: Expected Obj, but got Unknown
			//IL_1e37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e3c: Expected Obj, but got Unknown
			//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e53: Expected Obj, but got Unknown
			//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e86: Expected Obj, but got Unknown
			//IL_1e98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e9d: Expected Obj, but got Unknown
			//IL_1eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eb4: Expected Obj, but got Unknown
			//IL_1ee2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ee7: Expected Obj, but got Unknown
			//IL_1ef9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1efe: Expected Obj, but got Unknown
			//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f15: Expected Obj, but got Unknown
			//IL_1f43: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f48: Expected Obj, but got Unknown
			//IL_1f5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5f: Expected Obj, but got Unknown
			//IL_1f71: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f76: Expected Obj, but got Unknown
			//IL_1fa4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa9: Expected Obj, but got Unknown
			//IL_1fbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fc0: Expected Obj, but got Unknown
			//IL_1fd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fd7: Expected Obj, but got Unknown
			//IL_2005: Unknown result type (might be due to invalid IL or missing references)
			//IL_200a: Expected Obj, but got Unknown
			//IL_201c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2021: Expected Obj, but got Unknown
			//IL_2033: Unknown result type (might be due to invalid IL or missing references)
			//IL_2038: Expected Obj, but got Unknown
			//IL_2066: Unknown result type (might be due to invalid IL or missing references)
			//IL_206b: Expected Obj, but got Unknown
			//IL_207d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2082: Expected Obj, but got Unknown
			//IL_2094: Unknown result type (might be due to invalid IL or missing references)
			//IL_2099: Expected Obj, but got Unknown
			//IL_20c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20cc: Expected Obj, but got Unknown
			//IL_20de: Unknown result type (might be due to invalid IL or missing references)
			//IL_20e3: Expected Obj, but got Unknown
			//IL_20f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_20fa: Expected Obj, but got Unknown
			//IL_2128: Unknown result type (might be due to invalid IL or missing references)
			//IL_212d: Expected Obj, but got Unknown
			//IL_213f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2144: Expected Obj, but got Unknown
			//IL_2156: Unknown result type (might be due to invalid IL or missing references)
			//IL_215b: Expected Obj, but got Unknown
			//IL_2189: Unknown result type (might be due to invalid IL or missing references)
			//IL_218e: Expected Obj, but got Unknown
			//IL_21a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_21a5: Expected Obj, but got Unknown
			//IL_21b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_21bc: Expected Obj, but got Unknown
			//IL_21ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_21ef: Expected Obj, but got Unknown
			//IL_2201: Unknown result type (might be due to invalid IL or missing references)
			//IL_2206: Expected Obj, but got Unknown
			//IL_2218: Unknown result type (might be due to invalid IL or missing references)
			//IL_221d: Expected Obj, but got Unknown
			//IL_224b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2250: Expected Obj, but got Unknown
			//IL_2262: Unknown result type (might be due to invalid IL or missing references)
			//IL_2267: Expected Obj, but got Unknown
			//IL_2279: Unknown result type (might be due to invalid IL or missing references)
			//IL_227e: Expected Obj, but got Unknown
			//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_22b1: Expected Obj, but got Unknown
			//IL_22c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_22c8: Expected Obj, but got Unknown
			//IL_22da: Unknown result type (might be due to invalid IL or missing references)
			//IL_22df: Expected Obj, but got Unknown
			//IL_230d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2312: Expected Obj, but got Unknown
			//IL_2324: Unknown result type (might be due to invalid IL or missing references)
			//IL_2329: Expected Obj, but got Unknown
			//IL_233b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2340: Expected Obj, but got Unknown
			//IL_236e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2373: Expected Obj, but got Unknown
			//IL_2385: Unknown result type (might be due to invalid IL or missing references)
			//IL_238a: Expected Obj, but got Unknown
			//IL_239c: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a1: Expected Obj, but got Unknown
			//IL_23cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_23d4: Expected Obj, but got Unknown
			//IL_23e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_23eb: Expected Obj, but got Unknown
			//IL_23fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_2402: Expected Obj, but got Unknown
			//IL_2430: Unknown result type (might be due to invalid IL or missing references)
			//IL_2435: Expected Obj, but got Unknown
			//IL_2447: Unknown result type (might be due to invalid IL or missing references)
			//IL_244c: Expected Obj, but got Unknown
			//IL_245e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2463: Expected Obj, but got Unknown
			//IL_2491: Unknown result type (might be due to invalid IL or missing references)
			//IL_2496: Expected Obj, but got Unknown
			//IL_24a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_24ad: Expected Obj, but got Unknown
			//IL_24bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_24c4: Expected Obj, but got Unknown
			//IL_24f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_24f7: Expected Obj, but got Unknown
			//IL_2509: Unknown result type (might be due to invalid IL or missing references)
			//IL_250e: Expected Obj, but got Unknown
			//IL_2520: Unknown result type (might be due to invalid IL or missing references)
			//IL_2525: Expected Obj, but got Unknown
			//IL_2553: Unknown result type (might be due to invalid IL or missing references)
			//IL_2558: Expected Obj, but got Unknown
			//IL_256a: Unknown result type (might be due to invalid IL or missing references)
			//IL_256f: Expected Obj, but got Unknown
			//IL_2581: Unknown result type (might be due to invalid IL or missing references)
			//IL_2586: Expected Obj, but got Unknown
			//IL_25b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25b9: Expected Obj, but got Unknown
			//IL_25cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_25d0: Expected Obj, but got Unknown
			//IL_25e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_25e7: Expected Obj, but got Unknown
			//IL_2615: Unknown result type (might be due to invalid IL or missing references)
			//IL_261a: Expected Obj, but got Unknown
			//IL_262c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2631: Expected Obj, but got Unknown
			//IL_2643: Unknown result type (might be due to invalid IL or missing references)
			//IL_2648: Expected Obj, but got Unknown
			//IL_2676: Unknown result type (might be due to invalid IL or missing references)
			//IL_267b: Expected Obj, but got Unknown
			//IL_268d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2692: Expected Obj, but got Unknown
			//IL_26a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_26a9: Expected Obj, but got Unknown
			//IL_26d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_26dc: Expected Obj, but got Unknown
			//IL_26ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_26f3: Expected Obj, but got Unknown
			//IL_2705: Unknown result type (might be due to invalid IL or missing references)
			//IL_270a: Expected Obj, but got Unknown
			//IL_2738: Unknown result type (might be due to invalid IL or missing references)
			//IL_273d: Expected Obj, but got Unknown
			//IL_274f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2754: Expected Obj, but got Unknown
			//IL_2766: Unknown result type (might be due to invalid IL or missing references)
			//IL_276b: Expected Obj, but got Unknown
			//IL_2799: Unknown result type (might be due to invalid IL or missing references)
			//IL_279e: Expected Obj, but got Unknown
			//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_27b5: Expected Obj, but got Unknown
			//IL_27c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_27cc: Expected Obj, but got Unknown
			//IL_27fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_27ff: Expected Obj, but got Unknown
			//IL_2811: Unknown result type (might be due to invalid IL or missing references)
			//IL_2816: Expected Obj, but got Unknown
			//IL_2828: Unknown result type (might be due to invalid IL or missing references)
			//IL_282d: Expected Obj, but got Unknown
			//IL_285b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2860: Expected Obj, but got Unknown
			//IL_2872: Unknown result type (might be due to invalid IL or missing references)
			//IL_2877: Expected Obj, but got Unknown
			//IL_2889: Unknown result type (might be due to invalid IL or missing references)
			//IL_288e: Expected Obj, but got Unknown
			//IL_28bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_28c1: Expected Obj, but got Unknown
			//IL_28d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_28d8: Expected Obj, but got Unknown
			//IL_28ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_28ef: Expected Obj, but got Unknown
			//IL_291d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2922: Expected Obj, but got Unknown
			//IL_2934: Unknown result type (might be due to invalid IL or missing references)
			//IL_2939: Expected Obj, but got Unknown
			//IL_294b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2950: Expected Obj, but got Unknown
			//IL_297e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2983: Expected Obj, but got Unknown
			//IL_2995: Unknown result type (might be due to invalid IL or missing references)
			//IL_299a: Expected Obj, but got Unknown
			//IL_29ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_29b1: Expected Obj, but got Unknown
			//IL_29df: Unknown result type (might be due to invalid IL or missing references)
			//IL_29e4: Expected Obj, but got Unknown
			//IL_29f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_29fb: Expected Obj, but got Unknown
			//IL_2a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a12: Expected Obj, but got Unknown
			//IL_2a40: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a45: Expected Obj, but got Unknown
			//IL_2a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a5c: Expected Obj, but got Unknown
			//IL_2a6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a73: Expected Obj, but got Unknown
			//IL_2aa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aa6: Expected Obj, but got Unknown
			//IL_2ab8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2abd: Expected Obj, but got Unknown
			//IL_2acf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ad4: Expected Obj, but got Unknown
			//IL_2b02: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b07: Expected Obj, but got Unknown
			//IL_2b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b1e: Expected Obj, but got Unknown
			//IL_2b30: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b35: Expected Obj, but got Unknown
			//IL_2b63: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b68: Expected Obj, but got Unknown
			//IL_2b7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b7f: Expected Obj, but got Unknown
			//IL_2b91: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b96: Expected Obj, but got Unknown
			//IL_2bc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bc9: Expected Obj, but got Unknown
			//IL_2bdb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2be0: Expected Obj, but got Unknown
			//IL_2bf2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bf7: Expected Obj, but got Unknown
			//IL_2c25: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c2a: Expected Obj, but got Unknown
			//IL_2c3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c41: Expected Obj, but got Unknown
			//IL_2c53: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c58: Expected Obj, but got Unknown
			//IL_2c86: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c8b: Expected Obj, but got Unknown
			//IL_2c9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca2: Expected Obj, but got Unknown
			//IL_2cb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb9: Expected Obj, but got Unknown
			//IL_2ce7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cec: Expected Obj, but got Unknown
			//IL_2cfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d03: Expected Obj, but got Unknown
			//IL_2d15: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d1a: Expected Obj, but got Unknown
			//IL_2d48: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d4d: Expected Obj, but got Unknown
			//IL_2d5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d64: Expected Obj, but got Unknown
			//IL_2d76: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d7b: Expected Obj, but got Unknown
			//IL_2da9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dae: Expected Obj, but got Unknown
			//IL_2dc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dc5: Expected Obj, but got Unknown
			//IL_2dd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ddc: Expected Obj, but got Unknown
			//IL_2e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e0f: Expected Obj, but got Unknown
			//IL_2e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e26: Expected Obj, but got Unknown
			//IL_2e38: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e3d: Expected Obj, but got Unknown
			//IL_2e6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e70: Expected Obj, but got Unknown
			//IL_2e82: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e87: Expected Obj, but got Unknown
			//IL_2e99: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e9e: Expected Obj, but got Unknown
			//IL_2ecc: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ed1: Expected Obj, but got Unknown
			//IL_2ee3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ee8: Expected Obj, but got Unknown
			//IL_2efa: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eff: Expected Obj, but got Unknown
			//IL_2f2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f32: Expected Obj, but got Unknown
			//IL_2f44: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f49: Expected Obj, but got Unknown
			//IL_2f5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f60: Expected Obj, but got Unknown
			//IL_2f8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f93: Expected Obj, but got Unknown
			//IL_2fa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2faa: Expected Obj, but got Unknown
			//IL_2fbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fc1: Expected Obj, but got Unknown
			//IL_2fef: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ff4: Expected Obj, but got Unknown
			//IL_3006: Unknown result type (might be due to invalid IL or missing references)
			//IL_300b: Expected Obj, but got Unknown
			//IL_301d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3022: Expected Obj, but got Unknown
			//IL_3050: Unknown result type (might be due to invalid IL or missing references)
			//IL_3055: Expected Obj, but got Unknown
			//IL_3067: Unknown result type (might be due to invalid IL or missing references)
			//IL_306c: Expected Obj, but got Unknown
			//IL_307e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3083: Expected Obj, but got Unknown
			//IL_30b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_30b6: Expected Obj, but got Unknown
			//IL_30c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_30cd: Expected Obj, but got Unknown
			//IL_30df: Unknown result type (might be due to invalid IL or missing references)
			//IL_30e4: Expected Obj, but got Unknown
			//IL_3112: Unknown result type (might be due to invalid IL or missing references)
			//IL_3117: Expected Obj, but got Unknown
			//IL_3129: Unknown result type (might be due to invalid IL or missing references)
			//IL_312e: Expected Obj, but got Unknown
			//IL_3140: Unknown result type (might be due to invalid IL or missing references)
			//IL_3145: Expected Obj, but got Unknown
			//IL_3173: Unknown result type (might be due to invalid IL or missing references)
			//IL_3178: Expected Obj, but got Unknown
			//IL_318a: Unknown result type (might be due to invalid IL or missing references)
			//IL_318f: Expected Obj, but got Unknown
			//IL_31a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_31a6: Expected Obj, but got Unknown
			//IL_31d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_31d9: Expected Obj, but got Unknown
			//IL_31eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_31f0: Expected Obj, but got Unknown
			//IL_3202: Unknown result type (might be due to invalid IL or missing references)
			//IL_3207: Expected Obj, but got Unknown
			//IL_3235: Unknown result type (might be due to invalid IL or missing references)
			//IL_323a: Expected Obj, but got Unknown
			//IL_324c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3251: Expected Obj, but got Unknown
			//IL_3263: Unknown result type (might be due to invalid IL or missing references)
			//IL_3268: Expected Obj, but got Unknown
			//IL_3296: Unknown result type (might be due to invalid IL or missing references)
			//IL_329b: Expected Obj, but got Unknown
			//IL_32ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_32b2: Expected Obj, but got Unknown
			//IL_32c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_32c9: Expected Obj, but got Unknown
			//IL_32f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_32fc: Expected Obj, but got Unknown
			//IL_330e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3313: Expected Obj, but got Unknown
			//IL_3325: Unknown result type (might be due to invalid IL or missing references)
			//IL_332a: Expected Obj, but got Unknown
			//IL_3358: Unknown result type (might be due to invalid IL or missing references)
			//IL_335d: Expected Obj, but got Unknown
			//IL_336f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3374: Expected Obj, but got Unknown
			//IL_3386: Unknown result type (might be due to invalid IL or missing references)
			//IL_338b: Expected Obj, but got Unknown
			//IL_33b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_33be: Expected Obj, but got Unknown
			//IL_33d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_33d5: Expected Obj, but got Unknown
			//IL_33e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_33ec: Expected Obj, but got Unknown
			//IL_341a: Unknown result type (might be due to invalid IL or missing references)
			//IL_341f: Expected Obj, but got Unknown
			//IL_3431: Unknown result type (might be due to invalid IL or missing references)
			//IL_3436: Expected Obj, but got Unknown
			//IL_3448: Unknown result type (might be due to invalid IL or missing references)
			//IL_344d: Expected Obj, but got Unknown
			//IL_347b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3480: Expected Obj, but got Unknown
			//IL_3492: Unknown result type (might be due to invalid IL or missing references)
			//IL_3497: Expected Obj, but got Unknown
			//IL_34a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ae: Expected Obj, but got Unknown
			//IL_34dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_34e1: Expected Obj, but got Unknown
			//IL_34f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_34f8: Expected Obj, but got Unknown
			//IL_350a: Unknown result type (might be due to invalid IL or missing references)
			//IL_350f: Expected Obj, but got Unknown
			//IL_353d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3542: Expected Obj, but got Unknown
			//IL_3554: Unknown result type (might be due to invalid IL or missing references)
			//IL_3559: Expected Obj, but got Unknown
			//IL_356b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3570: Expected Obj, but got Unknown
			//IL_359e: Unknown result type (might be due to invalid IL or missing references)
			//IL_35a3: Expected Obj, but got Unknown
			//IL_35b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_35ba: Expected Obj, but got Unknown
			//IL_35cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_35d1: Expected Obj, but got Unknown
			//IL_35ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_3604: Expected Obj, but got Unknown
			//IL_3616: Unknown result type (might be due to invalid IL or missing references)
			//IL_361b: Expected Obj, but got Unknown
			//IL_362d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3632: Expected Obj, but got Unknown
			//IL_3660: Unknown result type (might be due to invalid IL or missing references)
			//IL_3665: Expected Obj, but got Unknown
			//IL_3677: Unknown result type (might be due to invalid IL or missing references)
			//IL_367c: Expected Obj, but got Unknown
			//IL_368e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3693: Expected Obj, but got Unknown
			//IL_36c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_36c6: Expected Obj, but got Unknown
			//IL_36d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_36dd: Expected Obj, but got Unknown
			//IL_36ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_36f4: Expected Obj, but got Unknown
			//IL_3722: Unknown result type (might be due to invalid IL or missing references)
			//IL_3727: Expected Obj, but got Unknown
			//IL_3739: Unknown result type (might be due to invalid IL or missing references)
			//IL_373e: Expected Obj, but got Unknown
			//IL_3750: Unknown result type (might be due to invalid IL or missing references)
			//IL_3755: Expected Obj, but got Unknown
			//IL_3783: Unknown result type (might be due to invalid IL or missing references)
			//IL_3788: Expected Obj, but got Unknown
			//IL_379a: Unknown result type (might be due to invalid IL or missing references)
			//IL_379f: Expected Obj, but got Unknown
			//IL_37b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_37b6: Expected Obj, but got Unknown
			//IL_37e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_37e9: Expected Obj, but got Unknown
			//IL_37fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_3800: Expected Obj, but got Unknown
			//IL_3812: Unknown result type (might be due to invalid IL or missing references)
			//IL_3817: Expected Obj, but got Unknown
			//IL_3845: Unknown result type (might be due to invalid IL or missing references)
			//IL_384a: Expected Obj, but got Unknown
			//IL_385c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3861: Expected Obj, but got Unknown
			//IL_3873: Unknown result type (might be due to invalid IL or missing references)
			//IL_3878: Expected Obj, but got Unknown
			//IL_38a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_38ab: Expected Obj, but got Unknown
			//IL_38bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_38c2: Expected Obj, but got Unknown
			//IL_38d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_38d9: Expected Obj, but got Unknown
			//IL_3907: Unknown result type (might be due to invalid IL or missing references)
			//IL_390c: Expected Obj, but got Unknown
			//IL_391e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3923: Expected Obj, but got Unknown
			//IL_3935: Unknown result type (might be due to invalid IL or missing references)
			//IL_393a: Expected Obj, but got Unknown
			//IL_3968: Unknown result type (might be due to invalid IL or missing references)
			//IL_396d: Expected Obj, but got Unknown
			//IL_397f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3984: Expected Obj, but got Unknown
			//IL_3996: Unknown result type (might be due to invalid IL or missing references)
			//IL_399b: Expected Obj, but got Unknown
			//IL_39c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_39ce: Expected Obj, but got Unknown
			//IL_39e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_39e5: Expected Obj, but got Unknown
			//IL_39f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_39fc: Expected Obj, but got Unknown
			//IL_3a2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a2f: Expected Obj, but got Unknown
			//IL_3a41: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a46: Expected Obj, but got Unknown
			//IL_3a58: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a5d: Expected Obj, but got Unknown
			//IL_3a8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a90: Expected Obj, but got Unknown
			//IL_3aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3aa7: Expected Obj, but got Unknown
			//IL_3ab9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3abe: Expected Obj, but got Unknown
			bool flag = CountryData._listOfCountries == null;
			bool flag2 = !flag;
			CountryManager result = (CountryManager)(object)CountryData._listOfCountries;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country = default;
				object obj = country + 8;
				obj = "COUNTRY_NAME_AF";
				object obj2 = country + 12;
				obj2 = "Afghanistan";
				object obj3 = country + 16;
				obj3 = "af";
				List<Country> list = default;
				list.Add(country);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country2 = default;
				object obj4 = country2 + 8;
				obj4 = "COUNTRY_NAME_AL";
				object obj5 = country2 + 12;
				obj5 = "Albania";
				object obj6 = country2 + 16;
				obj6 = "al";
				list.Add(country2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country3 = default;
				object obj7 = country3 + 8;
				obj7 = "COUNTRY_NAME_DZ";
				object obj8 = country3 + 12;
				obj8 = "Algeria";
				object obj9 = country3 + 16;
				obj9 = "dz";
				list.Add(country3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country4 = default;
				object obj10 = country4 + 8;
				obj10 = "COUNTRY_NAME_AO";
				object obj11 = country4 + 12;
				obj11 = "Angola";
				object obj12 = country4 + 16;
				obj12 = "ao";
				list.Add(country4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country5 = default;
				object obj13 = country5 + 8;
				obj13 = "COUNTRY_NAME_AG";
				object obj14 = country5 + 12;
				obj14 = "Antigua-and-Barbuda";
				object obj15 = country5 + 16;
				obj15 = "ag";
				list.Add(country5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country6 = default;
				object obj16 = country6 + 8;
				obj16 = "COUNTRY_NAME_AR";
				object obj17 = country6 + 12;
				obj17 = "Argentina";
				object obj18 = country6 + 16;
				obj18 = "ar";
				list.Add(country6);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country7 = default;
				object obj19 = country7 + 8;
				obj19 = "COUNTRY_NAME_AM";
				object obj20 = country7 + 12;
				obj20 = "Armenia";
				object obj21 = country7 + 16;
				obj21 = "am";
				list.Add(country7);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country8 = default;
				object obj22 = country8 + 8;
				obj22 = "COUNTRY_NAME_AU";
				object obj23 = country8 + 12;
				obj23 = "Australia";
				object obj24 = country8 + 16;
				obj24 = "au";
				list.Add(country8);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country9 = default;
				object obj25 = country9 + 8;
				obj25 = "COUNTRY_NAME_AT";
				object obj26 = country9 + 12;
				obj26 = "Austria";
				object obj27 = country9 + 16;
				obj27 = "at";
				list.Add(country9);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country10 = default;
				object obj28 = country10 + 8;
				obj28 = "COUNTRY_NAME_AZ";
				object obj29 = country10 + 12;
				obj29 = "Azerbaijan";
				object obj30 = country10 + 16;
				obj30 = "az";
				list.Add(country10);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country11 = default;
				object obj31 = country11 + 8;
				obj31 = "COUNTRY_NAME_BS";
				object obj32 = country11 + 12;
				obj32 = "Bahamas";
				object obj33 = country11 + 16;
				obj33 = "bs";
				list.Add(country11);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country12 = default;
				object obj34 = country12 + 8;
				obj34 = "COUNTRY_NAME_BH";
				object obj35 = country12 + 12;
				obj35 = "Bahrain";
				object obj36 = country12 + 16;
				obj36 = "bh";
				list.Add(country12);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country13 = default;
				object obj37 = country13 + 8;
				obj37 = "COUNTRY_NAME_BD";
				object obj38 = country13 + 12;
				obj38 = "Bangladesh";
				object obj39 = country13 + 16;
				obj39 = "bd";
				list.Add(country13);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country14 = default;
				object obj40 = country14 + 8;
				obj40 = "COUNTRY_NAME_BB";
				object obj41 = country14 + 12;
				obj41 = "Barbados";
				object obj42 = country14 + 16;
				obj42 = "bb";
				list.Add(country14);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country15 = default;
				object obj43 = country15 + 8;
				obj43 = "COUNTRY_NAME_BY";
				object obj44 = country15 + 12;
				obj44 = "Belarus";
				object obj45 = country15 + 16;
				obj45 = "by";
				list.Add(country15);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country16 = default;
				object obj46 = country16 + 8;
				obj46 = "COUNTRY_NAME_BE";
				object obj47 = country16 + 12;
				obj47 = "Belgium";
				object obj48 = country16 + 16;
				obj48 = "be";
				list.Add(country16);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country17 = default;
				object obj49 = country17 + 8;
				obj49 = "COUNTRY_NAME_BZ";
				object obj50 = country17 + 12;
				obj50 = "Belize";
				object obj51 = country17 + 16;
				obj51 = "bz";
				list.Add(country17);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country18 = default;
				object obj52 = country18 + 8;
				obj52 = "COUNTRY_NAME_BJ";
				object obj53 = country18 + 12;
				obj53 = "Benin";
				object obj54 = country18 + 16;
				obj54 = "bj";
				list.Add(country18);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country19 = default;
				object obj55 = country19 + 8;
				obj55 = "COUNTRY_NAME_BO";
				object obj56 = country19 + 12;
				obj56 = "Bolivia";
				object obj57 = country19 + 16;
				obj57 = "bo";
				list.Add(country19);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country20 = default;
				object obj58 = country20 + 8;
				obj58 = "COUNTRY_NAME_BA";
				object obj59 = country20 + 12;
				obj59 = "Bosnia-and-Herzegovina";
				object obj60 = country20 + 16;
				obj60 = "ba";
				list.Add(country20);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country21 = default;
				object obj61 = country21 + 8;
				obj61 = "COUNTRY_NAME_BR";
				object obj62 = country21 + 12;
				obj62 = "Brazil";
				object obj63 = country21 + 16;
				obj63 = "br";
				list.Add(country21);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country22 = default;
				object obj64 = country22 + 8;
				obj64 = "COUNTRY_NAME_BN";
				object obj65 = country22 + 12;
				obj65 = "Brunei";
				object obj66 = country22 + 16;
				obj66 = "bn";
				list.Add(country22);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country23 = default;
				object obj67 = country23 + 8;
				obj67 = "COUNTRY_NAME_BG";
				object obj68 = country23 + 12;
				obj68 = "Bulgaria";
				object obj69 = country23 + 16;
				obj69 = "bg";
				list.Add(country23);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country24 = default;
				object obj70 = country24 + 8;
				obj70 = "COUNTRY_NAME_BF";
				object obj71 = country24 + 12;
				obj71 = "Burkina-Faso";
				object obj72 = country24 + 16;
				obj72 = "bf";
				list.Add(country24);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country25 = default;
				object obj73 = country25 + 8;
				obj73 = "COUNTRY_NAME_KH";
				object obj74 = country25 + 12;
				obj74 = "Cambodia";
				object obj75 = country25 + 16;
				obj75 = "kh";
				list.Add(country25);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country26 = default;
				object obj76 = country26 + 8;
				obj76 = "COUNTRY_NAME_CA";
				object obj77 = country26 + 12;
				obj77 = "Canada";
				object obj78 = country26 + 16;
				obj78 = "ca";
				list.Add(country26);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country27 = default;
				object obj79 = country27 + 8;
				obj79 = "COUNTRY_NAME_CF";
				object obj80 = country27 + 12;
				obj80 = "Central-African-Republic";
				object obj81 = country27 + 16;
				obj81 = "cf";
				list.Add(country27);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country28 = default;
				object obj82 = country28 + 8;
				obj82 = "COUNTRY_NAME_CL";
				object obj83 = country28 + 12;
				obj83 = "Chile";
				object obj84 = country28 + 16;
				obj84 = "cl";
				list.Add(country28);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country29 = default;
				object obj85 = country29 + 8;
				obj85 = "COUNTRY_NAME_CN";
				object obj86 = country29 + 12;
				obj86 = "China";
				object obj87 = country29 + 16;
				obj87 = "cn";
				list.Add(country29);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country30 = default;
				object obj88 = country30 + 8;
				obj88 = "COUNTRY_NAME_CO";
				object obj89 = country30 + 12;
				obj89 = "Colombia";
				object obj90 = country30 + 16;
				obj90 = "co";
				list.Add(country30);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country31 = default;
				object obj91 = country31 + 8;
				obj91 = "COUNTRY_NAME_CR";
				object obj92 = country31 + 12;
				obj92 = "Costa-Rica";
				object obj93 = country31 + 16;
				obj93 = "cr";
				list.Add(country31);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country32 = default;
				object obj94 = country32 + 8;
				obj94 = "COUNTRY_NAME_CI";
				object obj95 = country32 + 12;
				obj95 = "Cote-d'Ivoire";
				object obj96 = country32 + 16;
				obj96 = "ci";
				list.Add(country32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country33 = default;
				object obj97 = country33 + 8;
				obj97 = "COUNTRY_NAME_HR";
				object obj98 = country33 + 12;
				obj98 = "Croatia";
				object obj99 = country33 + 16;
				obj99 = "hr";
				list.Add(country33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country34 = default;
				object obj100 = country34 + 8;
				obj100 = "COUNTRY_NAME_CU";
				object obj101 = country34 + 12;
				obj101 = "Cuba";
				object obj102 = country34 + 16;
				obj102 = "cu";
				list.Add(country34);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country35 = default;
				object obj103 = country35 + 8;
				obj103 = "COUNTRY_NAME_CY";
				object obj104 = country35 + 12;
				obj104 = "Cyprus";
				object obj105 = country35 + 16;
				obj105 = "cy";
				list.Add(country35);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country36 = default;
				object obj106 = country36 + 8;
				obj106 = "COUNTRY_NAME_CZ";
				object obj107 = country36 + 12;
				obj107 = "Czech-Republic";
				object obj108 = country36 + 16;
				obj108 = "cz";
				list.Add(country36);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country37 = default;
				object obj109 = country37 + 8;
				obj109 = "COUNTRY_NAME_DK";
				object obj110 = country37 + 12;
				obj110 = "Denmark";
				object obj111 = country37 + 16;
				obj111 = "dk";
				list.Add(country37);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country38 = default;
				object obj112 = country38 + 8;
				obj112 = "COUNTRY_NAME_DO";
				object obj113 = country38 + 12;
				obj113 = "Dominican-Republic";
				object obj114 = country38 + 16;
				obj114 = "do";
				list.Add(country38);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country39 = default;
				object obj115 = country39 + 8;
				obj115 = "COUNTRY_NAME_EC";
				object obj116 = country39 + 12;
				obj116 = "Ecuador";
				object obj117 = country39 + 16;
				obj117 = "ec";
				list.Add(country39);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country40 = default;
				object obj118 = country40 + 8;
				obj118 = "COUNTRY_NAME_EG";
				object obj119 = country40 + 12;
				obj119 = "Egypt";
				object obj120 = country40 + 16;
				obj120 = "eg";
				list.Add(country40);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country41 = default;
				object obj121 = country41 + 8;
				obj121 = "COUNTRY_NAME_SV";
				object obj122 = country41 + 12;
				obj122 = "El-Salvador";
				object obj123 = country41 + 16;
				obj123 = "sv";
				list.Add(country41);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country42 = default;
				object obj124 = country42 + 8;
				obj124 = "COUNTRY_NAME_ER";
				object obj125 = country42 + 12;
				obj125 = "Eritrea";
				object obj126 = country42 + 16;
				obj126 = "er";
				list.Add(country42);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country43 = default;
				object obj127 = country43 + 8;
				obj127 = "COUNTRY_NAME_EE";
				object obj128 = country43 + 12;
				obj128 = "Estonia";
				object obj129 = country43 + 16;
				obj129 = "ee";
				list.Add(country43);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country44 = default;
				object obj130 = country44 + 8;
				obj130 = "COUNTRY_NAME_ET";
				object obj131 = country44 + 12;
				obj131 = "Ethiopia";
				object obj132 = country44 + 16;
				obj132 = "et";
				list.Add(country44);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country45 = default;
				object obj133 = country45 + 8;
				obj133 = "COUNTRY_NAME_FJ";
				object obj134 = country45 + 12;
				obj134 = "Fiji";
				object obj135 = country45 + 16;
				obj135 = "fj";
				list.Add(country45);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country46 = default;
				object obj136 = country46 + 8;
				obj136 = "COUNTRY_NAME_FI";
				object obj137 = country46 + 12;
				obj137 = "Finland";
				object obj138 = country46 + 16;
				obj138 = "fi";
				list.Add(country46);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country47 = default;
				object obj139 = country47 + 8;
				obj139 = "COUNTRY_NAME_FR";
				object obj140 = country47 + 12;
				obj140 = "France";
				object obj141 = country47 + 16;
				obj141 = "fr";
				list.Add(country47);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country48 = default;
				object obj142 = country48 + 8;
				obj142 = "COUNTRY_NAME_GE";
				object obj143 = country48 + 12;
				obj143 = "Georgia";
				object obj144 = country48 + 16;
				obj144 = "ge";
				list.Add(country48);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country49 = default;
				object obj145 = country49 + 8;
				obj145 = "COUNTRY_NAME_DE";
				object obj146 = country49 + 12;
				obj146 = "Germany";
				object obj147 = country49 + 16;
				obj147 = "de";
				list.Add(country49);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country50 = default;
				object obj148 = country50 + 8;
				obj148 = "COUNTRY_NAME_GH";
				object obj149 = country50 + 12;
				obj149 = "Ghana";
				object obj150 = country50 + 16;
				obj150 = "gh";
				list.Add(country50);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country51 = default;
				object obj151 = country51 + 8;
				obj151 = "COUNTRY_NAME_GR";
				object obj152 = country51 + 12;
				obj152 = "Greece";
				object obj153 = country51 + 16;
				obj153 = "gr";
				list.Add(country51);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country52 = default;
				object obj154 = country52 + 8;
				obj154 = "COUNTRY_NAME_GT";
				object obj155 = country52 + 12;
				obj155 = "Guatemala";
				object obj156 = country52 + 16;
				obj156 = "gt";
				list.Add(country52);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country53 = default;
				object obj157 = country53 + 8;
				obj157 = "COUNTRY_NAME_GY";
				object obj158 = country53 + 12;
				obj158 = "Guyana";
				object obj159 = country53 + 16;
				obj159 = "gy";
				list.Add(country53);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country54 = default;
				object obj160 = country54 + 8;
				obj160 = "COUNTRY_NAME_HT";
				object obj161 = country54 + 12;
				obj161 = "Haiti";
				object obj162 = country54 + 16;
				obj162 = "ht";
				list.Add(country54);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country55 = default;
				object obj163 = country55 + 8;
				obj163 = "COUNTRY_NAME_HN";
				object obj164 = country55 + 12;
				obj164 = "Honduras";
				object obj165 = country55 + 16;
				obj165 = "hn";
				list.Add(country55);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country56 = default;
				object obj166 = country56 + 8;
				obj166 = "COUNTRY_NAME_HK";
				object obj167 = country56 + 12;
				obj167 = "Hong-Kong";
				object obj168 = country56 + 16;
				obj168 = "hk";
				list.Add(country56);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country57 = default;
				object obj169 = country57 + 8;
				obj169 = "COUNTRY_NAME_HU";
				object obj170 = country57 + 12;
				obj170 = "Hungary";
				object obj171 = country57 + 16;
				obj171 = "hu";
				list.Add(country57);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country58 = default;
				object obj172 = country58 + 8;
				obj172 = "COUNTRY_NAME_IS";
				object obj173 = country58 + 12;
				obj173 = "Iceland";
				object obj174 = country58 + 16;
				obj174 = "is";
				list.Add(country58);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country59 = default;
				object obj175 = country59 + 8;
				obj175 = "COUNTRY_NAME_IN";
				object obj176 = country59 + 12;
				obj176 = "India";
				object obj177 = country59 + 16;
				obj177 = "in";
				list.Add(country59);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country60 = default;
				object obj178 = country60 + 8;
				obj178 = "COUNTRY_NAME_ID";
				object obj179 = country60 + 12;
				obj179 = "Indonesia";
				object obj180 = country60 + 16;
				obj180 = "id";
				list.Add(country60);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country61 = default;
				object obj181 = country61 + 8;
				obj181 = "COUNTRY_NAME_IR";
				object obj182 = country61 + 12;
				obj182 = "Iran";
				object obj183 = country61 + 16;
				obj183 = "ir";
				list.Add(country61);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country62 = default;
				object obj184 = country62 + 8;
				obj184 = "COUNTRY_NAME_IQ";
				object obj185 = country62 + 12;
				obj185 = "Iraq";
				object obj186 = country62 + 16;
				obj186 = "iq";
				list.Add(country62);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country63 = default;
				object obj187 = country63 + 8;
				obj187 = "COUNTRY_NAME_IE";
				object obj188 = country63 + 12;
				obj188 = "Ireland";
				object obj189 = country63 + 16;
				obj189 = "ie";
				list.Add(country63);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country64 = default;
				object obj190 = country64 + 8;
				obj190 = "COUNTRY_NAME_IL";
				object obj191 = country64 + 12;
				obj191 = "Israel";
				object obj192 = country64 + 16;
				obj192 = "il";
				list.Add(country64);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country65 = default;
				object obj193 = country65 + 8;
				obj193 = "COUNTRY_NAME_IT";
				object obj194 = country65 + 12;
				obj194 = "Italy";
				object obj195 = country65 + 16;
				obj195 = "it";
				list.Add(country65);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country66 = default;
				object obj196 = country66 + 8;
				obj196 = "COUNTRY_NAME_JM";
				object obj197 = country66 + 12;
				obj197 = "Jamaica";
				object obj198 = country66 + 16;
				obj198 = "jm";
				list.Add(country66);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country67 = default;
				object obj199 = country67 + 8;
				obj199 = "COUNTRY_NAME_JP";
				object obj200 = country67 + 12;
				obj200 = "Japan";
				object obj201 = country67 + 16;
				obj201 = "jp";
				list.Add(country67);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country68 = default;
				object obj202 = country68 + 8;
				obj202 = "COUNTRY_NAME_JO";
				object obj203 = country68 + 12;
				obj203 = "Jordan";
				object obj204 = country68 + 16;
				obj204 = "jo";
				list.Add(country68);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country69 = default;
				object obj205 = country69 + 8;
				obj205 = "COUNTRY_NAME_KZ";
				object obj206 = country69 + 12;
				obj206 = "Kazakhstan";
				object obj207 = country69 + 16;
				obj207 = "kz";
				list.Add(country69);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country70 = default;
				object obj208 = country70 + 8;
				obj208 = "COUNTRY_NAME_KE";
				object obj209 = country70 + 12;
				obj209 = "Kenya";
				object obj210 = country70 + 16;
				obj210 = "ke";
				list.Add(country70);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country71 = default;
				object obj211 = country71 + 8;
				obj211 = "COUNTRY_NAME_KI";
				object obj212 = country71 + 12;
				obj212 = "Kiribati";
				object obj213 = country71 + 16;
				obj213 = "ki";
				list.Add(country71);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country72 = default;
				object obj214 = country72 + 8;
				obj214 = "COUNTRY_NAME_KW";
				object obj215 = country72 + 12;
				obj215 = "Kuwait";
				object obj216 = country72 + 16;
				obj216 = "kw";
				list.Add(country72);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country73 = default;
				object obj217 = country73 + 8;
				obj217 = "COUNTRY_NAME_KG";
				object obj218 = country73 + 12;
				obj218 = "Kyrgyzstan";
				object obj219 = country73 + 16;
				obj219 = "kg";
				list.Add(country73);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country74 = default;
				object obj220 = country74 + 8;
				obj220 = "COUNTRY_NAME_LA";
				object obj221 = country74 + 12;
				obj221 = "Laos";
				object obj222 = country74 + 16;
				obj222 = "la";
				list.Add(country74);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country75 = default;
				object obj223 = country75 + 8;
				obj223 = "COUNTRY_NAME_LV";
				object obj224 = country75 + 12;
				obj224 = "Latvia";
				object obj225 = country75 + 16;
				obj225 = "lv";
				list.Add(country75);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country76 = default;
				object obj226 = country76 + 8;
				obj226 = "COUNTRY_NAME_LB";
				object obj227 = country76 + 12;
				obj227 = "Lebanon";
				object obj228 = country76 + 16;
				obj228 = "lb";
				list.Add(country76);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country77 = default;
				object obj229 = country77 + 8;
				obj229 = "COUNTRY_NAME_LY";
				object obj230 = country77 + 12;
				obj230 = "Libya";
				object obj231 = country77 + 16;
				obj231 = "ly";
				list.Add(country77);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country78 = default;
				object obj232 = country78 + 8;
				obj232 = "COUNTRY_NAME_LI";
				object obj233 = country78 + 12;
				obj233 = "Liechtenstein";
				object obj234 = country78 + 16;
				obj234 = "li";
				list.Add(country78);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country79 = default;
				object obj235 = country79 + 8;
				obj235 = "COUNTRY_NAME_LT";
				object obj236 = country79 + 12;
				obj236 = "Lithuania";
				object obj237 = country79 + 16;
				obj237 = "lt";
				list.Add(country79);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country80 = default;
				object obj238 = country80 + 8;
				obj238 = "COUNTRY_NAME_LU";
				object obj239 = country80 + 12;
				obj239 = "Luxembourg";
				object obj240 = country80 + 16;
				obj240 = "lu";
				list.Add(country80);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country81 = default;
				object obj241 = country81 + 8;
				obj241 = "COUNTRY_NAME_MK";
				object obj242 = country81 + 12;
				obj242 = "Macedonia";
				object obj243 = country81 + 16;
				obj243 = "mk";
				list.Add(country81);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country82 = default;
				object obj244 = country82 + 8;
				obj244 = "COUNTRY_NAME_MY";
				object obj245 = country82 + 12;
				obj245 = "Malaysia";
				object obj246 = country82 + 16;
				obj246 = "my";
				list.Add(country82);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country83 = default;
				object obj247 = country83 + 8;
				obj247 = "COUNTRY_NAME_MV";
				object obj248 = country83 + 12;
				obj248 = "Maldives";
				object obj249 = country83 + 16;
				obj249 = "mv";
				list.Add(country83);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country84 = default;
				object obj250 = country84 + 8;
				obj250 = "COUNTRY_NAME_ML";
				object obj251 = country84 + 12;
				obj251 = "Mali";
				object obj252 = country84 + 16;
				obj252 = "ml";
				list.Add(country84);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country85 = default;
				object obj253 = country85 + 8;
				obj253 = "COUNTRY_NAME_MT";
				object obj254 = country85 + 12;
				obj254 = "Malta";
				object obj255 = country85 + 16;
				obj255 = "mt";
				list.Add(country85);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country86 = default;
				object obj256 = country86 + 8;
				obj256 = "COUNTRY_NAME_MR";
				object obj257 = country86 + 12;
				obj257 = "Mauritania";
				object obj258 = country86 + 16;
				obj258 = "mr";
				list.Add(country86);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country87 = default;
				object obj259 = country87 + 8;
				obj259 = "COUNTRY_NAME_MU";
				object obj260 = country87 + 12;
				obj260 = "Mauritius";
				object obj261 = country87 + 16;
				obj261 = "mu";
				list.Add(country87);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country88 = default;
				object obj262 = country88 + 8;
				obj262 = "COUNTRY_NAME_MX";
				object obj263 = country88 + 12;
				obj263 = "Mexico";
				object obj264 = country88 + 16;
				obj264 = "mx";
				list.Add(country88);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country89 = default;
				object obj265 = country89 + 8;
				obj265 = "COUNTRY_NAME_MD";
				object obj266 = country89 + 12;
				obj266 = "Moldova";
				object obj267 = country89 + 16;
				obj267 = "md";
				list.Add(country89);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country90 = default;
				object obj268 = country90 + 8;
				obj268 = "COUNTRY_NAME_MN";
				object obj269 = country90 + 12;
				obj269 = "Mongolia";
				object obj270 = country90 + 16;
				obj270 = "mn";
				list.Add(country90);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country91 = default;
				object obj271 = country91 + 8;
				obj271 = "COUNTRY_NAME_ME";
				object obj272 = country91 + 12;
				obj272 = "Montenegro";
				object obj273 = country91 + 16;
				obj273 = "me";
				list.Add(country91);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country92 = default;
				object obj274 = country92 + 8;
				obj274 = "COUNTRY_NAME_MA";
				object obj275 = country92 + 12;
				obj275 = "Morocco";
				object obj276 = country92 + 16;
				obj276 = "ma";
				list.Add(country92);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country93 = default;
				object obj277 = country93 + 8;
				obj277 = "COUNTRY_NAME_MZ";
				object obj278 = country93 + 12;
				obj278 = "Mozambique";
				object obj279 = country93 + 16;
				obj279 = "mz";
				list.Add(country93);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country94 = default;
				object obj280 = country94 + 8;
				obj280 = "COUNTRY_NAME_MM";
				object obj281 = country94 + 12;
				obj281 = "Myanmar";
				object obj282 = country94 + 16;
				obj282 = "mm";
				list.Add(country94);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country95 = default;
				object obj283 = country95 + 8;
				obj283 = "COUNTRY_NAME_NA";
				object obj284 = country95 + 12;
				obj284 = "Namibia";
				object obj285 = country95 + 16;
				obj285 = "na";
				list.Add(country95);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country96 = default;
				object obj286 = country96 + 8;
				obj286 = "COUNTRY_NAME_NR";
				object obj287 = country96 + 12;
				obj287 = "Nauru";
				object obj288 = country96 + 16;
				obj288 = "nr";
				list.Add(country96);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country97 = default;
				object obj289 = country97 + 8;
				obj289 = "COUNTRY_NAME_NP";
				object obj290 = country97 + 12;
				obj290 = "Nepal";
				object obj291 = country97 + 16;
				obj291 = "np";
				list.Add(country97);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country98 = default;
				object obj292 = country98 + 8;
				obj292 = "COUNTRY_NAME_NL";
				object obj293 = country98 + 12;
				obj293 = "Netherlands";
				object obj294 = country98 + 16;
				obj294 = "nl";
				list.Add(country98);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country99 = default;
				object obj295 = country99 + 8;
				obj295 = "COUNTRY_NAME_NZ";
				object obj296 = country99 + 12;
				obj296 = "New-Zealand";
				object obj297 = country99 + 16;
				obj297 = "nz";
				list.Add(country99);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country100 = default;
				object obj298 = country100 + 8;
				obj298 = "COUNTRY_NAME_NI";
				object obj299 = country100 + 12;
				obj299 = "Nicaragua";
				object obj300 = country100 + 16;
				obj300 = "ni";
				list.Add(country100);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country101 = default;
				object obj301 = country101 + 8;
				obj301 = "COUNTRY_NAME_NG";
				object obj302 = country101 + 12;
				obj302 = "Nigeria";
				object obj303 = country101 + 16;
				obj303 = "ng";
				list.Add(country101);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country102 = default;
				object obj304 = country102 + 8;
				obj304 = "COUNTRY_NAME_KP";
				object obj305 = country102 + 12;
				obj305 = "North-Korea";
				object obj306 = country102 + 16;
				obj306 = "kp";
				list.Add(country102);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country103 = default;
				object obj307 = country103 + 8;
				obj307 = "COUNTRY_NAME_NO";
				object obj308 = country103 + 12;
				obj308 = "Norway";
				object obj309 = country103 + 16;
				obj309 = "no";
				list.Add(country103);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country104 = default;
				object obj310 = country104 + 8;
				obj310 = "COUNTRY_NAME_OM";
				object obj311 = country104 + 12;
				obj311 = "Oman";
				object obj312 = country104 + 16;
				obj312 = "om";
				list.Add(country104);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country105 = default;
				object obj313 = country105 + 8;
				obj313 = "COUNTRY_NAME_PK";
				object obj314 = country105 + 12;
				obj314 = "Pakistan";
				object obj315 = country105 + 16;
				obj315 = "pk";
				list.Add(country105);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country106 = default;
				object obj316 = country106 + 8;
				obj316 = "COUNTRY_NAME_PS";
				object obj317 = country106 + 12;
				obj317 = "Palestine";
				object obj318 = country106 + 16;
				obj318 = "ps";
				list.Add(country106);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country107 = default;
				object obj319 = country107 + 8;
				obj319 = "COUNTRY_NAME_PA";
				object obj320 = country107 + 12;
				obj320 = "Panama";
				object obj321 = country107 + 16;
				obj321 = "pa";
				list.Add(country107);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country108 = default;
				object obj322 = country108 + 8;
				obj322 = "COUNTRY_NAME_PY";
				object obj323 = country108 + 12;
				obj323 = "Paraguay";
				object obj324 = country108 + 16;
				obj324 = "py";
				list.Add(country108);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country109 = default;
				object obj325 = country109 + 8;
				obj325 = "COUNTRY_NAME_PE";
				object obj326 = country109 + 12;
				obj326 = "Peru";
				object obj327 = country109 + 16;
				obj327 = "pe";
				list.Add(country109);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country110 = default;
				object obj328 = country110 + 8;
				obj328 = "COUNTRY_NAME_PH";
				object obj329 = country110 + 12;
				obj329 = "Philippines";
				object obj330 = country110 + 16;
				obj330 = "ph";
				list.Add(country110);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country111 = default;
				object obj331 = country111 + 8;
				obj331 = "COUNTRY_NAME_PL";
				object obj332 = country111 + 12;
				obj332 = "Poland";
				object obj333 = country111 + 16;
				obj333 = "pl";
				list.Add(country111);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country112 = default;
				object obj334 = country112 + 8;
				obj334 = "COUNTRY_NAME_PT";
				object obj335 = country112 + 12;
				obj335 = "Portugal";
				object obj336 = country112 + 16;
				obj336 = "pt";
				list.Add(country112);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country113 = default;
				object obj337 = country113 + 8;
				obj337 = "COUNTRY_NAME_QA";
				object obj338 = country113 + 12;
				obj338 = "Qatar";
				object obj339 = country113 + 16;
				obj339 = "qa";
				list.Add(country113);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country114 = default;
				object obj340 = country114 + 8;
				obj340 = "COUNTRY_NAME_RO";
				object obj341 = country114 + 12;
				obj341 = "Romania";
				object obj342 = country114 + 16;
				obj342 = "ro";
				list.Add(country114);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country115 = default;
				object obj343 = country115 + 8;
				obj343 = "COUNTRY_NAME_RU";
				object obj344 = country115 + 12;
				obj344 = "Russia";
				object obj345 = country115 + 16;
				obj345 = "ru";
				list.Add(country115);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country116 = default;
				object obj346 = country116 + 8;
				obj346 = "COUNTRY_NAME_KN";
				object obj347 = country116 + 12;
				obj347 = "Saint-Kitts-and-Nevis";
				object obj348 = country116 + 16;
				obj348 = "kn";
				list.Add(country116);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country117 = default;
				object obj349 = country117 + 8;
				obj349 = "COUNTRY_NAME_LC";
				object obj350 = country117 + 12;
				obj350 = "Saint-Lucia";
				object obj351 = country117 + 16;
				obj351 = "lc";
				list.Add(country117);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country118 = default;
				object obj352 = country118 + 8;
				obj352 = "COUNTRY_NAME_VC";
				object obj353 = country118 + 12;
				obj353 = "Saint-Vincent-and-the-Grenadines";
				object obj354 = country118 + 16;
				obj354 = "vc";
				list.Add(country118);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country119 = default;
				object obj355 = country119 + 8;
				obj355 = "COUNTRY_NAME_SA";
				object obj356 = country119 + 12;
				obj356 = "Saudi-Arabia";
				object obj357 = country119 + 16;
				obj357 = "sa";
				list.Add(country119);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country120 = default;
				object obj358 = country120 + 8;
				obj358 = "COUNTRY_NAME_SN";
				object obj359 = country120 + 12;
				obj359 = "Senegal";
				object obj360 = country120 + 16;
				obj360 = "sn";
				list.Add(country120);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country121 = default;
				object obj361 = country121 + 8;
				obj361 = "COUNTRY_NAME_RS";
				object obj362 = country121 + 12;
				obj362 = "Serbia";
				object obj363 = country121 + 16;
				obj363 = "rs";
				list.Add(country121);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country122 = default;
				object obj364 = country122 + 8;
				obj364 = "COUNTRY_NAME_SG";
				object obj365 = country122 + 12;
				obj365 = "Singapore";
				object obj366 = country122 + 16;
				obj366 = "sg";
				list.Add(country122);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country123 = default;
				object obj367 = country123 + 8;
				obj367 = "COUNTRY_NAME_SK";
				object obj368 = country123 + 12;
				obj368 = "Slovakia";
				object obj369 = country123 + 16;
				obj369 = "sk";
				list.Add(country123);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country124 = default;
				object obj370 = country124 + 8;
				obj370 = "COUNTRY_NAME_SI";
				object obj371 = country124 + 12;
				obj371 = "Slovenia";
				object obj372 = country124 + 16;
				obj372 = "si";
				list.Add(country124);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country125 = default;
				object obj373 = country125 + 8;
				obj373 = "COUNTRY_NAME_ZA";
				object obj374 = country125 + 12;
				obj374 = "South-Africa";
				object obj375 = country125 + 16;
				obj375 = "za";
				list.Add(country125);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country126 = default;
				object obj376 = country126 + 8;
				obj376 = "COUNTRY_NAME_KR";
				object obj377 = country126 + 12;
				obj377 = "South-Korea";
				object obj378 = country126 + 16;
				obj378 = "kr";
				list.Add(country126);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country127 = default;
				object obj379 = country127 + 8;
				obj379 = "COUNTRY_NAME_SS";
				object obj380 = country127 + 12;
				obj380 = "South-Sudan";
				object obj381 = country127 + 16;
				obj381 = "ss";
				list.Add(country127);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country128 = default;
				object obj382 = country128 + 8;
				obj382 = "COUNTRY_NAME_ES";
				object obj383 = country128 + 12;
				obj383 = "Spain";
				object obj384 = country128 + 16;
				obj384 = "es";
				list.Add(country128);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country129 = default;
				object obj385 = country129 + 8;
				obj385 = "COUNTRY_NAME_LK";
				object obj386 = country129 + 12;
				obj386 = "Sri-Lanka";
				object obj387 = country129 + 16;
				obj387 = "lk";
				list.Add(country129);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country130 = default;
				object obj388 = country130 + 8;
				obj388 = "COUNTRY_NAME_SD";
				object obj389 = country130 + 12;
				obj389 = "Sudan";
				object obj390 = country130 + 16;
				obj390 = "sd";
				list.Add(country130);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country131 = default;
				object obj391 = country131 + 8;
				obj391 = "COUNTRY_NAME_SR";
				object obj392 = country131 + 12;
				obj392 = "Suriname";
				object obj393 = country131 + 16;
				obj393 = "sr";
				list.Add(country131);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country132 = default;
				object obj394 = country132 + 8;
				obj394 = "COUNTRY_NAME_SE";
				object obj395 = country132 + 12;
				obj395 = "Sweden";
				object obj396 = country132 + 16;
				obj396 = "se";
				list.Add(country132);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country133 = default;
				object obj397 = country133 + 8;
				obj397 = "COUNTRY_NAME_CH";
				object obj398 = country133 + 12;
				obj398 = "Switzerland";
				object obj399 = country133 + 16;
				obj399 = "ch";
				list.Add(country133);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country134 = default;
				object obj400 = country134 + 8;
				obj400 = "COUNTRY_NAME_SY";
				object obj401 = country134 + 12;
				obj401 = "Syria";
				object obj402 = country134 + 16;
				obj402 = "sy";
				list.Add(country134);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country135 = default;
				object obj403 = country135 + 8;
				obj403 = "COUNTRY_NAME_TW";
				object obj404 = country135 + 12;
				obj404 = "Taiwan";
				object obj405 = country135 + 16;
				obj405 = "tw";
				list.Add(country135);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country136 = default;
				object obj406 = country136 + 8;
				obj406 = "COUNTRY_NAME_TJ";
				object obj407 = country136 + 12;
				obj407 = "Tajikistan";
				object obj408 = country136 + 16;
				obj408 = "tj";
				list.Add(country136);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country137 = default;
				object obj409 = country137 + 8;
				obj409 = "COUNTRY_NAME_TZ";
				object obj410 = country137 + 12;
				obj410 = "Tanzania";
				object obj411 = country137 + 16;
				obj411 = "tz";
				list.Add(country137);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country138 = default;
				object obj412 = country138 + 8;
				obj412 = "COUNTRY_NAME_TH";
				object obj413 = country138 + 12;
				obj413 = "Thailand";
				object obj414 = country138 + 16;
				obj414 = "th";
				list.Add(country138);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country139 = default;
				object obj415 = country139 + 8;
				obj415 = "COUNTRY_NAME_TT";
				object obj416 = country139 + 12;
				obj416 = "Trinidad-and-Tobago";
				object obj417 = country139 + 16;
				obj417 = "tt";
				list.Add(country139);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country140 = default;
				object obj418 = country140 + 8;
				obj418 = "COUNTRY_NAME_TN";
				object obj419 = country140 + 12;
				obj419 = "Tunisia";
				object obj420 = country140 + 16;
				obj420 = "tn";
				list.Add(country140);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country141 = default;
				object obj421 = country141 + 8;
				obj421 = "COUNTRY_NAME_TR";
				object obj422 = country141 + 12;
				obj422 = "Turkey";
				object obj423 = country141 + 16;
				obj423 = "tr";
				list.Add(country141);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country142 = default;
				object obj424 = country142 + 8;
				obj424 = "COUNTRY_NAME_TM";
				object obj425 = country142 + 12;
				obj425 = "Turkmenistan";
				object obj426 = country142 + 16;
				obj426 = "tm";
				list.Add(country142);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country143 = default;
				object obj427 = country143 + 8;
				obj427 = "COUNTRY_NAME_TV";
				object obj428 = country143 + 12;
				obj428 = "Tuvalu";
				object obj429 = country143 + 16;
				obj429 = "tv";
				list.Add(country143);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country144 = default;
				object obj430 = country144 + 8;
				obj430 = "COUNTRY_NAME_UG";
				object obj431 = country144 + 12;
				obj431 = "Uganda";
				object obj432 = country144 + 16;
				obj432 = "ug";
				list.Add(country144);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country145 = default;
				object obj433 = country145 + 8;
				obj433 = "COUNTRY_NAME_UA";
				object obj434 = country145 + 12;
				obj434 = "Ukraine";
				object obj435 = country145 + 16;
				obj435 = "ua";
				list.Add(country145);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country146 = default;
				object obj436 = country146 + 8;
				obj436 = "COUNTRY_NAME_AE";
				object obj437 = country146 + 12;
				obj437 = "United-Arab-Emirates";
				object obj438 = country146 + 16;
				obj438 = "ae";
				list.Add(country146);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country147 = default;
				object obj439 = country147 + 8;
				obj439 = "COUNTRY_NAME_GB";
				object obj440 = country147 + 12;
				obj440 = "United-Kingdom";
				object obj441 = country147 + 16;
				obj441 = "gb";
				list.Add(country147);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country148 = default;
				object obj442 = country148 + 8;
				obj442 = "COUNTRY_NAME_US";
				object obj443 = country148 + 12;
				obj443 = "United-States";
				object obj444 = country148 + 16;
				obj444 = "us";
				list.Add(country148);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country149 = default;
				object obj445 = country149 + 8;
				obj445 = "COUNTRY_NAME_UY";
				object obj446 = country149 + 12;
				obj446 = "Uruguay";
				object obj447 = country149 + 16;
				obj447 = "uy";
				list.Add(country149);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country150 = default;
				object obj448 = country150 + 8;
				obj448 = "COUNTRY_NAME_UZ";
				object obj449 = country150 + 12;
				obj449 = "Uzbekistan";
				object obj450 = country150 + 16;
				obj450 = "uz";
				list.Add(country150);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country151 = default;
				object obj451 = country151 + 8;
				obj451 = "COUNTRY_NAME_VE";
				object obj452 = country151 + 12;
				obj452 = "Venezuela";
				object obj453 = country151 + 16;
				obj453 = "ve";
				list.Add(country151);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country152 = default;
				object obj454 = country152 + 8;
				obj454 = "COUNTRY_NAME_VN";
				object obj455 = country152 + 12;
				obj455 = "Vietnam";
				object obj456 = country152 + 16;
				obj456 = "vn";
				list.Add(country152);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country153 = default;
				object obj457 = country153 + 8;
				obj457 = "COUNTRY_NAME_YE";
				object obj458 = country153 + 12;
				obj458 = "Yemen";
				object obj459 = country153 + 16;
				obj459 = "ye";
				list.Add(country153);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country154 = default;
				object obj460 = country154 + 8;
				obj460 = "COUNTRY_NAME_ZM";
				object obj461 = country154 + 12;
				obj461 = "Zambia";
				object obj462 = country154 + 16;
				obj462 = "zm";
				list.Add(country154);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Country country155 = default;
				object obj463 = country155 + 8;
				obj463 = "COUNTRY_NAME_ZW";
				object obj464 = country155 + 12;
				obj464 = "Zimbabwe";
				object obj465 = country155 + 16;
				obj465 = "zw";
				list.Add(country155);
				CountryData._listOfCountries = list;
				result = (CountryManager)(object)list;
			}
			return result;
		}
	}

	private CountryManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public string GetDefaultCountryCodeFromDevice()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		bool flag;
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountryManager)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			string text = ((string)this).ToLowerInvariant();
			CountryManager countryManager = instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj6 != null)
					{
						object obj7 = obj4 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj4 + obj9;
						obj10 = 83;
						break;
					}
					continue;
				}
				object obj11 = obj4 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj4 + obj13;
				obj14 = 81;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj4 + obj15;
				if ((nint)obj16 == 83)
				{
					object obj17 = obj4 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					goto IL_0432;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj4 + obj19;
				if ((nint)obj20 == 81)
				{
					object obj21 = obj4 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					goto IL_0432;
				}
			}
			object obj23 = default;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0432;
		IL_0432:
		string result = default;
		return result;
	}

	public List<Country> GetListOfCountries()
	{
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
		Country currentTournamentCountry = ((CountryManager)(object)unfilteredLocale).GetCurrentTournamentCountry();
		string defaultCountryCodeFromDevice = ((CountryManager)(object)currentTournamentCountry).GetDefaultCountryCodeFromDevice();
		bool flag = defaultCountryCodeFromDevice == null;
		bool flag2 = !flag;
		string text = defaultCountryCodeFromDevice;
		if (!flag2)
		{
			Country countryForID = CountryData.GetCountryForID((string)(object)currentTournamentCountry);
			bool flag3 = countryForID == null;
			bool flag4 = !flag3;
			text = (string)(object)countryForID;
			if (!flag4)
			{
				return (List<Country>)(object)"US";
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ L0_v3 (System.String)+10]");
		return (List<Country>)(object)((string)0).ToUpperInvariant();
	}

	public int GetCurrentCountryIndex()
	{
		//IL_0009: Expected I4, but got Obj
		return (int)instance;
	}

	private static string GetCountryCodeFromLocale(string deviceLocale)
	{
		//IL_0100: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			string text2 = default;
			string text = text2.ToLowerInvariant();
			int num = 0;
			while (true)
			{
				CountryManager countryManager = instance;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v18 (CountryManager)+C]");
				if ((nint)num2 >= (nint)0)
				{
					return null;
				}
				CountryManager countryManager2 = instance;
				Country country = ((List<Country>)(object)countryManager2).get_Item(num);
				if (country.countryCode != text)
				{
					break;
				}
				int num3 = num + 1;
				num = num3;
			}
			return (string)num;
		}
		return null;
	}

	public Country GetCurrentTournamentCountry()
	{
		//IL_005e: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		bool flag;
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountryManager)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		bool flag2 = !flag;
		bool flag3 = !flag2;
		Country result = (Country)(object)string.Empty;
		if (!flag3)
		{
			string text = string.Copy((string)(object)this);
			string text2 = text.ToLowerInvariant();
			string text3 = text2.Replace((string)45, (string)95);
			bool flag4 = text3.EndsWith("_");
			bool flag5 = !flag4;
			result = (Country)(object)string.Empty;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num = default;
				object obj = num + 16;
				obj = 95;
				string text4 = text3.Substring(num);
				bool flag6 = text4.m_firstChar == '\u0002';
				bool flag7 = !flag6;
				result = (Country)(object)string.Empty;
				if (!flag7)
				{
					object obj2 = text4 + 20;
					result = (Country)obj2;
				}
			}
		}
		return result;
	}

	public static void LogError(string msg, Object context = null)
	{
	}

	public static void LogWarning(string msg, Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[CountryManager] ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	public static void Log(string msg, Object context = null)
	{
	}
}
