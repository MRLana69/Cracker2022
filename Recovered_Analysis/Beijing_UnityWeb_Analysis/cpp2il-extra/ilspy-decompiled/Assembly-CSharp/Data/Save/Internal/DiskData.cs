using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Debugging;
using InApp;
using Info;
using Kiloo.Common.Ads;
using SYBO.Components.Analytics;
using SYBO.Components.Analytics.Integration;
using SYBO.Subway.Info;
using TopRun.UI;
using UI.Screens.RewardManagement;

namespace Data.Save.Internal;

public abstract class DiskData
{
	public abstract void Obfuscate();

	public abstract void Deobfuscate();

	protected unsafe DiskData()
	{
		//IL_1d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d18: Expected Obj, but got Unknown
		//IL_1d21: Expected Obj, but got I4
		//IL_1d2f: Expected I, but got Obj
		//IL_1d45: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_040d: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_0532: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_05a3: Expected Obj, but got I
		//IL_05b3: Expected Obj, but got I
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_0686: Expected I, but got Obj
		//IL_069c: Expected Obj, but got I
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d70: Expected Obj, but got Unknown
		//IL_1d79: Expected Obj, but got VT
		//IL_1d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d87: Expected I, but got Unknown
		//IL_1d94: Expected I, but got Obj
		//IL_1da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dac: Expected Obj, but got Unknown
		//IL_1db5: Expected Obj, but got VT
		//IL_1dc2: Expected I, but got Obj
		//IL_1dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1def: Expected Obj, but got Unknown
		//IL_1e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e05: Expected Obj, but got Unknown
		//IL_1e0e: Expected Obj, but got VT
		//IL_1e1b: Expected I, but got Obj
		//IL_1e33: Expected I, but got Obj
		//IL_1e49: Expected Obj, but got I
		//IL_1e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e74: Expected Obj, but got Unknown
		//IL_1e8f: Expected I, but got Obj
		//IL_1eaa: Expected I, but got Obj
		//IL_1ec0: Expected Obj, but got I
		//IL_06c7: Expected I, but got Obj
		//IL_1efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f02: Expected Obj, but got Unknown
		//IL_0714: Expected I, but got Obj
		//IL_07c8: Expected Obj, but got I
		//IL_07d8: Expected Obj, but got I
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Obj, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected Obj, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got VT
		//IL_083d: Expected I, but got Obj
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected Obj, but got Unknown
		//IL_0870: Expected I, but got Obj
		//IL_0761: Expected I, but got Obj
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_08da: Expected I, but got Obj
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected Obj, but got Unknown
		//IL_093b: Expected Obj, but got I
		//IL_094b: Expected Obj, but got I
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected Obj, but got Unknown
		//IL_098f: Expected Obj, but got I
		//IL_099f: Expected Obj, but got I
		//IL_09af: Expected Obj, but got I
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected Obj, but got Unknown
		//IL_09eb: Expected Obj, but got I
		//IL_09fb: Expected Obj, but got I
		//IL_0a0b: Expected Obj, but got I
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected Obj, but got Unknown
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Expected Obj, but got Unknown
		//IL_0a47: Expected Obj, but got I
		//IL_0a57: Expected Obj, but got I
		//IL_0a67: Expected Obj, but got I
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected Obj, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_0aa3: Expected Obj, but got I
		//IL_0ab3: Expected Obj, but got I
		//IL_0ac3: Expected Obj, but got I
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected Obj, but got Unknown
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected Obj, but got Unknown
		//IL_0aff: Expected Obj, but got I
		//IL_0b0f: Expected Obj, but got I
		//IL_0b1f: Expected Obj, but got I
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected Obj, but got Unknown
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected Obj, but got Unknown
		//IL_0b5b: Expected Obj, but got I
		//IL_0b6b: Expected Obj, but got I
		//IL_0b7b: Expected Obj, but got I
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected Obj, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected Obj, but got Unknown
		//IL_0bb7: Expected Obj, but got I
		//IL_0bc7: Expected Obj, but got I
		//IL_0bd7: Expected Obj, but got I
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0c13: Expected Obj, but got I
		//IL_0c23: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected Obj, but got Unknown
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got I
		//IL_0c7f: Expected Obj, but got I
		//IL_0c8f: Expected Obj, but got I
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected Obj, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected Obj, but got Unknown
		//IL_0ccb: Expected Obj, but got I
		//IL_0cdb: Expected Obj, but got I
		//IL_0ceb: Expected Obj, but got I
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		//IL_0d27: Expected Obj, but got I
		//IL_0d37: Expected Obj, but got I
		//IL_0d47: Expected Obj, but got I
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d55: Expected Obj, but got Unknown
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected Obj, but got Unknown
		//IL_0d83: Expected Obj, but got I
		//IL_0d93: Expected Obj, but got I
		//IL_0da3: Expected Obj, but got I
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Expected Obj, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected Obj, but got Unknown
		//IL_0ddf: Expected Obj, but got I
		//IL_0def: Expected Obj, but got I
		//IL_0dff: Expected Obj, but got I
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected Obj, but got Unknown
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Expected Obj, but got Unknown
		//IL_0e3b: Expected Obj, but got I
		//IL_0e4b: Expected Obj, but got I
		//IL_0e5b: Expected Obj, but got I
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected Obj, but got Unknown
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e77: Expected Obj, but got Unknown
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Expected Obj, but got Unknown
		//IL_0eb4: Expected Obj, but got I
		//IL_0ec4: Expected Obj, but got I
		//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected Obj, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected Obj, but got Unknown
		//IL_0f08: Expected Obj, but got I
		//IL_0f18: Expected Obj, but got I
		//IL_0f28: Expected Obj, but got I
		//IL_0f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f36: Expected Obj, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected Obj, but got Unknown
		//IL_0f64: Expected Obj, but got I
		//IL_0f74: Expected Obj, but got I
		//IL_0f84: Expected Obj, but got I
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected Obj, but got Unknown
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected Obj, but got Unknown
		//IL_0fc0: Expected Obj, but got I
		//IL_0fd0: Expected Obj, but got I
		//IL_0fe0: Expected Obj, but got I
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Expected Obj, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected Obj, but got Unknown
		//IL_101c: Expected Obj, but got I
		//IL_102c: Expected Obj, but got I
		//IL_103c: Expected Obj, but got I
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Expected Obj, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_1078: Expected Obj, but got I
		//IL_1088: Expected Obj, but got I
		//IL_1098: Expected Obj, but got I
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a6: Expected Obj, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected Obj, but got Unknown
		//IL_10d4: Expected Obj, but got I
		//IL_10e4: Expected Obj, but got I
		//IL_10f4: Expected Obj, but got I
		//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Expected Obj, but got Unknown
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Expected Obj, but got Unknown
		//IL_1130: Expected Obj, but got I
		//IL_1140: Expected Obj, but got I
		//IL_1150: Expected Obj, but got I
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Expected Obj, but got Unknown
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Expected Obj, but got Unknown
		//IL_118c: Expected Obj, but got I
		//IL_119c: Expected Obj, but got I
		//IL_11ac: Expected Obj, but got I
		//IL_11b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ba: Expected Obj, but got Unknown
		//IL_11c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c8: Expected Obj, but got Unknown
		//IL_11e8: Expected Obj, but got I
		//IL_11f8: Expected Obj, but got I
		//IL_1208: Expected Obj, but got I
		//IL_1211: Unknown result type (might be due to invalid IL or missing references)
		//IL_1216: Expected Obj, but got Unknown
		//IL_121f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1224: Expected Obj, but got Unknown
		//IL_1244: Expected Obj, but got I
		//IL_1254: Expected Obj, but got I
		//IL_1264: Expected Obj, but got I
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Expected Obj, but got Unknown
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected Obj, but got Unknown
		//IL_12a0: Expected Obj, but got I
		//IL_12b0: Expected Obj, but got I
		//IL_12c0: Expected Obj, but got I
		//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ce: Expected Obj, but got Unknown
		//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dc: Expected Obj, but got Unknown
		//IL_12fc: Expected Obj, but got I
		//IL_130c: Expected Obj, but got I
		//IL_131c: Expected Obj, but got I
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_132a: Expected Obj, but got Unknown
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_1338: Expected Obj, but got Unknown
		//IL_1358: Expected Obj, but got I
		//IL_1368: Expected Obj, but got I
		//IL_1378: Expected Obj, but got I
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_138f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1394: Expected Obj, but got Unknown
		//IL_13b4: Expected Obj, but got I
		//IL_13c4: Expected Obj, but got I
		//IL_13d4: Expected Obj, but got I
		//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e2: Expected Obj, but got Unknown
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f0: Expected Obj, but got Unknown
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Expected Obj, but got Unknown
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_1418: Expected Obj, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Expected Obj, but got Unknown
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Expected Obj, but got Unknown
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Expected Obj, but got Unknown
		//IL_14eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f0: Expected Obj, but got Unknown
		//IL_14ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Expected Obj, but got Unknown
		//IL_1516: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Expected Obj, but got Unknown
		//IL_1531: Expected Obj, but got I8
		//IL_153e: Expected I, but got Obj
		//IL_1556: Expected I, but got Obj
		//IL_156c: Expected Obj, but got I
		//IL_1f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Expected Obj, but got Unknown
		//IL_1f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f36: Expected Obj, but got Unknown
		//IL_1f5f: Expected Obj, but got I
		//IL_1f6f: Expected Obj, but got I
		//IL_1f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f85: Expected Obj, but got Unknown
		//IL_1f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f93: Expected Obj, but got Unknown
		//IL_1fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa8: Expected Obj, but got Unknown
		//IL_1fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc7: Expected Obj, but got Unknown
		//IL_1fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe4: Expected Obj, but got Unknown
		//IL_1ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff8: Expected Obj, but got Unknown
		//IL_15e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Expected Obj, but got Unknown
		//IL_1597: Expected I, but got Obj
		//IL_1617: Expected Obj, but got I
		//IL_1627: Expected Obj, but got I
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Expected Obj, but got Unknown
		//IL_1646: Unknown result type (might be due to invalid IL or missing references)
		//IL_164b: Expected Obj, but got Unknown
		//IL_165b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1660: Expected Obj, but got Unknown
		//IL_1688: Expected Obj, but got I
		//IL_1698: Expected Obj, but got I
		//IL_16a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ae: Expected Obj, but got Unknown
		//IL_16b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bc: Expected Obj, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected Obj, but got Unknown
		//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected Obj, but got Unknown
		//IL_1704: Expected Obj, but got I4
		//IL_1713: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Expected Obj, but got Unknown
		//IL_1721: Expected Obj, but got VT
		//IL_172e: Expected I, but got Obj
		//IL_1741: Unknown result type (might be due to invalid IL or missing references)
		//IL_1746: Expected Obj, but got Unknown
		//IL_174f: Expected Obj, but got VT
		//IL_175c: Expected I, but got Obj
		//IL_176f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1774: Expected Obj, but got Unknown
		//IL_177d: Expected Obj, but got VT
		//IL_178a: Expected I, but got Obj
		//IL_179a: Unknown result type (might be due to invalid IL or missing references)
		//IL_179f: Expected Obj, but got Unknown
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b6: Expected Obj, but got Unknown
		//IL_17bf: Expected Obj, but got VT
		//IL_17cc: Expected I, but got Obj
		//IL_17fb: Expected Obj, but got I
		//IL_180b: Expected Obj, but got I
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected Obj, but got Unknown
		//IL_182a: Unknown result type (might be due to invalid IL or missing references)
		//IL_182f: Expected Obj, but got Unknown
		//IL_183f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1844: Expected Obj, but got Unknown
		//IL_186c: Expected Obj, but got I
		//IL_187c: Expected Obj, but got I
		//IL_188d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Expected Obj, but got Unknown
		//IL_189b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a0: Expected Obj, but got Unknown
		//IL_18b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b5: Expected Obj, but got Unknown
		//IL_18e2: Expected Obj, but got I
		//IL_18f2: Expected Obj, but got I
		//IL_1903: Unknown result type (might be due to invalid IL or missing references)
		//IL_1908: Expected Obj, but got Unknown
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_1916: Expected Obj, but got Unknown
		//IL_1926: Unknown result type (might be due to invalid IL or missing references)
		//IL_192b: Expected Obj, but got Unknown
		//IL_1939: Unknown result type (might be due to invalid IL or missing references)
		//IL_193e: Expected Obj, but got Unknown
		//IL_1974: Expected Obj, but got I
		//IL_1984: Expected Obj, but got I
		//IL_1995: Unknown result type (might be due to invalid IL or missing references)
		//IL_199a: Expected Obj, but got Unknown
		//IL_19a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a8: Expected Obj, but got Unknown
		//IL_19b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Expected Obj, but got Unknown
		//IL_19e5: Expected Obj, but got I
		//IL_19f5: Expected Obj, but got I
		//IL_1a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0b: Expected Obj, but got Unknown
		//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a19: Expected Obj, but got Unknown
		//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2e: Expected Obj, but got Unknown
		//IL_1a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a59: Expected Obj, but got Unknown
		//IL_1a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Expected Obj, but got Unknown
		//IL_1a78: Expected Obj, but got VT
		//IL_1a85: Expected I, but got Obj
		//IL_1a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9a: Expected Obj, but got Unknown
		//IL_1aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab1: Expected Obj, but got Unknown
		//IL_1aba: Expected Obj, but got VT
		//IL_1ac7: Expected I, but got Obj
		//IL_1ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adf: Expected Obj, but got Unknown
		//IL_1ae8: Expected Obj, but got VT
		//IL_1af5: Expected I, but got Obj
		//IL_1b24: Expected Obj, but got I
		//IL_1b34: Expected Obj, but got I
		//IL_1b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4a: Expected Obj, but got Unknown
		//IL_1b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b58: Expected Obj, but got Unknown
		//IL_1b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6d: Expected Obj, but got Unknown
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Expected Obj, but got Unknown
		//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb5: Expected Obj, but got Unknown
		//IL_1bbe: Expected Obj, but got VT
		//IL_1bcb: Expected I, but got Obj
		//IL_1c05: Expected Obj, but got VT
		//IL_1c12: Expected I, but got Obj
		//IL_1c4e: Expected Obj, but got I4
		//IL_1c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c59: Expected Obj, but got Unknown
		//IL_1c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c76: Expected Obj, but got Unknown
		//IL_1c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8a: Expected Obj, but got Unknown
		//IL_1cb8: Expected Obj, but got I
		//IL_1cc8: Expected Obj, but got I
		//IL_1cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cde: Expected Obj, but got Unknown
		//IL_1ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cec: Expected Obj, but got Unknown
		//IL_1cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d01: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Utils>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v410 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string intBinaryString = Utils.GetIntBinaryString(0);
		string intBinaryString2 = Utils.GetIntBinaryString(5);
		string intBinaryString3 = Utils.GetIntBinaryString(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v3+60]");
		object obj5 = (object)((object)0 & 0x1FFF) + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S4_v4 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v8+48]");
		object obj8 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v83 @ S5_v6 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S4_v12+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S4_v13+48]");
		object obj11 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S5_v10 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v17+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v18+48]");
		object obj14 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v117 @ S5_v14 (should have been resolved before IL gen)");
		object obj15 = this + 20;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S3_v10 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S3_v11+60]");
		object obj18 = (object)((object)0 & 0x1FFF) + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v140 @ S4_v23 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v25 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S4_v26+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S4_v27+48]");
		object obj21 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v157 @ S5_v20 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v30 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S4_v31+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S4_v32+48]");
		object obj24 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v174 @ S5_v24 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S4_v35 (Il2CppMethodInfo)+C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v36+60]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S4_v37+48]");
		object obj27 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v191 @ S5_v28 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S4_v40 (Il2CppMethodInfo)+C]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S4_v41+60]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S4_v42+48]");
		object obj30 = (object)((object)0 & 0x7FF) + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v208 @ S5_v32 (should have been resolved before IL gen)");
		object obj31 = this + 24;
		object obj32 = default;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<CelebrationReward> list = default;
		list._002Ector();
		object obj33 = this + 28;
		obj33 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S3_v19 (Il2CppMethodInfo)+C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S3_v20+60]");
		object obj35 = 0;
		object obj36 = obj35;
		object obj37 = obj36 & 0x1FFF;
		object obj38 = obj37 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v241 @ S4_v47 (should have been resolved before IL gen)");
		object obj39 = this + 32;
		object obj40 = default;
		obj39 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Characters.CharacterId> list2 = default;
		list2._002Ector();
		list2.Add(Characters.CharacterId.slick);
		object obj41 = this + 36;
		obj41 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S3_v24 (Il2CppMethodInfo)+C]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S3_v25+60]");
		object obj43 = 0;
		object obj44 = obj43;
		object obj45 = obj44 & 0x1FFF;
		object obj46 = obj45 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v278 @ S4_v51 (should have been resolved before IL gen)");
		object obj47 = this + 40;
		object obj48 = default;
		obj47 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S3_v29 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S3_v30+60]");
		object obj50 = 0;
		object obj51 = obj50;
		object obj52 = obj51 & 0x1FFF;
		object obj53 = obj52 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v301 @ S4_v55 (should have been resolved before IL gen)");
		object obj54 = this + 44;
		object obj55 = default;
		obj54 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S3_v34 (Il2CppMethodInfo)+C]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S3_v35+60]");
		object obj57 = 0;
		object obj58 = obj57;
		object obj59 = obj58 & 0x1FFF;
		object obj60 = obj59 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v324 @ S4_v59 (should have been resolved before IL gen)");
		object obj61 = this + 48;
		object obj62 = default;
		obj61 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Boards.BoardId> list3 = default;
		list3._002Ector();
		object obj63 = this + 52;
		obj63 = list3;
		object obj64 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj65 = default;
		obj64 = obj65;
		_ = -1;
		object obj66 = this - -64;
		obj66 = -1;
		object obj67 = this + 68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj68 = default;
		obj67 = obj68;
		nint num16 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v86 (Il2CppClass<System.DateTime>)+BA]");
		object obj69 = (nint)0 & (nint)0x200;
		if (obj69 != null)
		{
			nint num17 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v404 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj70 = obj2 + 104;
		obj70 = DateTime.MinValue;
		nint num18 = (nint)(obj2 + 112);
		((IntPtr*)num18)->m_value = (void*)(nint)obj70;
		_ = ((IntPtr*)num18)->m_value;
		object obj71 = obj2 + 96;
		obj71 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj71;
		_ = ((IntPtr*)num18)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list4 = default;
		list4._002Ector(41);
		object obj72 = this + 100;
		obj72 = list4;
		object obj73 = obj2 + 88;
		obj73 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj73;
		_ = ((IntPtr*)num18)->m_value;
		nint num19 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v111 (Il2CppClass<System.Type>)+BA]");
		object obj74 = (nint)0 & (nint)0x200;
		if (obj74 != null)
		{
			nint num20 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v400 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj75 = obj2 + 132;
		obj75 = typeof(Trophies.Trophy);
		((IntPtr*)num18)->m_value = (void*)(nint)obj75;
		Type enumType = Type.internal_from_handle((IntPtr)num18);
		nint num21 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S1_v99 (Il2CppClass<System.Enum>)+BA]");
		object obj76 = (nint)0 & (nint)0x200;
		if (obj76 != null)
		{
			nint num22 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S1_v403 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
		int rank = array.Rank;
		object obj77 = this + 124;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj78 = default;
		obj77 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S3_v39 (Il2CppMethodInfo)+C]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S3_v40+60]");
		object obj80 = 0;
		object obj81 = obj80;
		object obj82 = obj81 & 0x1FFF;
		object obj83 = obj82 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v504 @ S4_v63 (should have been resolved before IL gen)");
		object obj84 = this + 128;
		object obj85 = default;
		obj84 = obj85;
		object obj86 = obj2 + 80;
		obj86 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj86;
		_ = ((IntPtr*)num18)->m_value;
		object obj87 = obj2 + 128;
		obj87 = typeof(Stat);
		((IntPtr*)num18)->m_value = (void*)(nint)obj87;
		Type enumType2 = Type.internal_from_handle((IntPtr)num18);
		string[] array2 = Enum.InternalGetNames((System.RuntimeType)enumType2);
		object obj88 = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj89 = default;
		obj88 = obj89;
		object obj90 = obj2 + 124;
		obj90 = typeof(MysteryBox.Type);
		((IntPtr*)num18)->m_value = (void*)(nint)obj90;
		Type enumType3 = Type.internal_from_handle((IntPtr)num18);
		string[] array3 = Enum.InternalGetNames((System.RuntimeType)enumType3);
		object obj91 = this + 148;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj92 = default;
		obj91 = obj92;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S3_v44 (Il2CppMethodInfo)+C]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S3_v45+60]");
		object obj94 = 0;
		object obj95 = obj94;
		object obj96 = obj95 & 0x1FFF;
		object obj97 = obj96 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v587 @ S4_v67 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S4_v69 (Il2CppMethodInfo)+C]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S4_v70+60]");
		object obj99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S4_v71+48]");
		object obj100 = 0;
		object obj101 = obj100 & 0x7FF;
		object obj102 = obj101 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v604 @ S5_v48 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S4_v74 (Il2CppMethodInfo)+C]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S4_v75+60]");
		object obj104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S4_v76+48]");
		object obj105 = 0;
		object obj106 = obj105 & 0x7FF;
		object obj107 = obj106 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v621 @ S5_v52 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S4_v79 (Il2CppMethodInfo)+C]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S4_v80+60]");
		object obj109 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S4_v81+48]");
		object obj110 = 0;
		object obj111 = obj110 & 0x7FF;
		object obj112 = obj111 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v638 @ S5_v56 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ S4_v84 (Il2CppMethodInfo)+C]");
		object obj113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S4_v85+60]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S4_v86+48]");
		object obj115 = 0;
		object obj116 = obj115 & 0x7FF;
		object obj117 = obj116 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v655 @ S5_v60 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S4_v89 (Il2CppMethodInfo)+C]");
		object obj118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S4_v90+60]");
		object obj119 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ S4_v91+48]");
		object obj120 = 0;
		object obj121 = obj120 & 0x7FF;
		object obj122 = obj121 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v672 @ S5_v64 (should have been resolved before IL gen)");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ S4_v94 (Il2CppMethodInfo)+C]");
		object obj123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S4_v95+60]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S4_v96+48]");
		object obj125 = 0;
		object obj126 = obj125 & 0x7FF;
		object obj127 = obj126 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v689 @ S5_v68 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S4_v99 (Il2CppMethodInfo)+C]");
		object obj128 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S4_v100+60]");
		object obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S4_v101+48]");
		object obj130 = 0;
		object obj131 = obj130 & 0x7FF;
		object obj132 = obj131 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v706 @ S5_v72 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S4_v104 (Il2CppMethodInfo)+C]");
		object obj133 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S4_v105+60]");
		object obj134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S4_v106+48]");
		object obj135 = 0;
		object obj136 = obj135 & 0x7FF;
		object obj137 = obj136 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v723 @ S5_v76 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S4_v109 (Il2CppMethodInfo)+C]");
		object obj138 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S4_v110+60]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S4_v111+48]");
		object obj140 = 0;
		object obj141 = obj140 & 0x7FF;
		object obj142 = obj141 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v740 @ S5_v80 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ S4_v114 (Il2CppMethodInfo)+C]");
		object obj143 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ S4_v115+60]");
		object obj144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S4_v116+48]");
		object obj145 = 0;
		object obj146 = obj145 & 0x7FF;
		object obj147 = obj146 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v757 @ S5_v84 (should have been resolved before IL gen)");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ S4_v119 (Il2CppMethodInfo)+C]");
		object obj148 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S4_v120+60]");
		object obj149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ S4_v121+48]");
		object obj150 = 0;
		object obj151 = obj150 & 0x7FF;
		object obj152 = obj151 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v774 @ S5_v88 (should have been resolved before IL gen)");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S4_v124 (Il2CppMethodInfo)+C]");
		object obj153 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ S4_v125+60]");
		object obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S4_v126+48]");
		object obj155 = 0;
		object obj156 = obj155 & 0x7FF;
		object obj157 = obj156 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v791 @ S5_v92 (should have been resolved before IL gen)");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S4_v129 (Il2CppMethodInfo)+C]");
		object obj158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S4_v130+60]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S4_v131+48]");
		object obj160 = 0;
		object obj161 = obj160 & 0x7FF;
		object obj162 = obj161 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v808 @ S5_v96 (should have been resolved before IL gen)");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ S4_v134 (Il2CppMethodInfo)+C]");
		object obj163 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S4_v135+60]");
		object obj164 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ S4_v136+48]");
		object obj165 = 0;
		object obj166 = obj165 & 0x7FF;
		object obj167 = obj166 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v825 @ S5_v100 (should have been resolved before IL gen)");
		object obj168 = this + 168;
		object obj169 = default;
		obj168 = obj169;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ S3_v63 (Il2CppMethodInfo)+C]");
		object obj170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S3_v64+60]");
		object obj171 = 0;
		object obj172 = obj171;
		object obj173 = obj172 & 0x1FFF;
		object obj174 = obj173 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v848 @ S4_v141 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ S4_v143 (Il2CppMethodInfo)+C]");
		object obj175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ S4_v144+60]");
		object obj176 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S4_v145+48]");
		object obj177 = 0;
		object obj178 = obj177 & 0x7FF;
		object obj179 = obj178 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v865 @ S5_v106 (should have been resolved before IL gen)");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S4_v148 (Il2CppMethodInfo)+C]");
		object obj180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S4_v149+60]");
		object obj181 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ S4_v150+48]");
		object obj182 = 0;
		object obj183 = obj182 & 0x7FF;
		object obj184 = obj183 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v882 @ S5_v110 (should have been resolved before IL gen)");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ S4_v153 (Il2CppMethodInfo)+C]");
		object obj185 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S4_v154+60]");
		object obj186 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S4_v155+48]");
		object obj187 = 0;
		object obj188 = obj187 & 0x7FF;
		object obj189 = obj188 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v899 @ S5_v114 (should have been resolved before IL gen)");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ S4_v158 (Il2CppMethodInfo)+C]");
		object obj190 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S4_v159+60]");
		object obj191 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S4_v160+48]");
		object obj192 = 0;
		object obj193 = obj192 & 0x7FF;
		object obj194 = obj193 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v916 @ S5_v118 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ S4_v163 (Il2CppMethodInfo)+C]");
		object obj195 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ S4_v164+60]");
		object obj196 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ S4_v165+48]");
		object obj197 = 0;
		object obj198 = obj197 & 0x7FF;
		object obj199 = obj198 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v933 @ S5_v122 (should have been resolved before IL gen)");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S4_v168 (Il2CppMethodInfo)+C]");
		object obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ S4_v169+60]");
		object obj201 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ S4_v170+48]");
		object obj202 = 0;
		object obj203 = obj202 & 0x7FF;
		object obj204 = obj203 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v950 @ S5_v126 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S4_v173 (Il2CppMethodInfo)+C]");
		object obj205 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ S4_v174+60]");
		object obj206 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ S4_v175+48]");
		object obj207 = 0;
		object obj208 = obj207 & 0x7FF;
		object obj209 = obj208 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v967 @ S5_v130 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ S4_v178 (Il2CppMethodInfo)+C]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S4_v179+60]");
		object obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ S4_v180+48]");
		object obj212 = 0;
		object obj213 = obj212 & 0x7FF;
		object obj214 = obj213 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v984 @ S5_v134 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S4_v183 (Il2CppMethodInfo)+C]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ S4_v184+60]");
		object obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ S4_v185+48]");
		object obj217 = 0;
		object obj218 = obj217 & 0x7FF;
		object obj219 = obj218 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1001 @ S5_v138 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ S4_v188 (Il2CppMethodInfo)+C]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ S4_v189+60]");
		object obj221 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ S4_v190+48]");
		object obj222 = 0;
		object obj223 = obj222 & 0x7FF;
		object obj224 = obj223 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1018 @ S5_v142 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S4_v193 (Il2CppMethodInfo)+C]");
		object obj225 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ S4_v194+60]");
		object obj226 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ S4_v195+48]");
		object obj227 = 0;
		object obj228 = obj227 & 0x7FF;
		object obj229 = obj228 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1035 @ S5_v146 (should have been resolved before IL gen)");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ S4_v198 (Il2CppMethodInfo)+C]");
		object obj230 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ S4_v199+60]");
		object obj231 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ S4_v200+48]");
		object obj232 = 0;
		object obj233 = obj232 & 0x7FF;
		object obj234 = obj233 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1052 @ S5_v150 (should have been resolved before IL gen)");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ S4_v203 (Il2CppMethodInfo)+C]");
		object obj235 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ S4_v204+60]");
		object obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ S4_v205+48]");
		object obj237 = 0;
		object obj238 = obj237 & 0x7FF;
		object obj239 = obj238 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1069 @ S5_v154 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ S4_v208 (Il2CppMethodInfo)+C]");
		object obj240 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S4_v209+60]");
		object obj241 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ S4_v210+48]");
		object obj242 = 0;
		object obj243 = obj242 & 0x7FF;
		object obj244 = obj243 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1086 @ S5_v158 (should have been resolved before IL gen)");
		object obj245 = this + 172;
		object obj246 = default;
		obj245 = obj246;
		object obj247 = this + 180;
		obj247 = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<bool> list5 = default;
		list5.Add(item: true);
		list5.Add(item: true);
		list5.Add(item: true);
		list5.Add(item: true);
		object obj248 = this + 184;
		obj248 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FPSCounter fPSCounter = default;
		fPSCounter.Awake();
		object obj249 = this + 188;
		obj249 = fPSCounter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ExpiredLimitedBoardEventManager expiredLimitedBoardEventManager = default;
		expiredLimitedBoardEventManager.SaveProgress();
		object obj250 = this + 208;
		obj250 = expiredLimitedBoardEventManager;
		object obj251 = this + 248;
		obj251 = "";
		object obj252 = this + 256;
		obj252 = "";
		object obj253 = obj2 + 72;
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj253 = systemTimeAsFileTime;
		((IntPtr*)num18)->m_value = (void*)(nint)obj253;
		_ = ((IntPtr*)num18)->m_value;
		nint num54 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1166 @ S0_v245 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj254 = (nint)0 & (nint)0x200;
		if (obj254 != null)
		{
			nint num55 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ S0_v394 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_ = AnalyticsIntegration.SampleStateDefault;
		object obj255 = this + 276;
		obj255 = AnalyticsIntegration.AnalyticsUserIdPersistedDefault;
		object obj256 = this + 280;
		obj256 = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ S3_v82 (Il2CppMethodInfo)+C]");
		object obj257 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ S3_v83+60]");
		object obj258 = 0;
		object obj259 = obj258;
		object obj260 = obj259 & 0x1FFF;
		object obj261 = obj260 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1217 @ S4_v215 (should have been resolved before IL gen)");
		object obj262 = this + 284;
		object obj263 = default;
		obj262 = obj263;
		_ = AnalyticsIntegration.CurrentSessionPersistedDefault;
		_ = -1;
		object obj264 = this + 300;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj265 = default;
		obj264 = obj265;
		object obj266 = this + 304;
		obj266 = "";
		object obj267 = this + 308;
		obj267 = "";
		_ = -1;
		_ = -1;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InterstitialStats interstitialStats = default;
		interstitialStats.CheckTime();
		object obj268 = this + 332;
		obj268 = interstitialStats;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S3_v87 (Il2CppMethodInfo)+C]");
		object obj269 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S3_v88+60]");
		object obj270 = 0;
		object obj271 = obj270;
		object obj272 = obj271 & 0x1FFF;
		object obj273 = obj272 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1279 @ S4_v219 (should have been resolved before IL gen)");
		object obj274 = this + 336;
		object obj275 = default;
		obj274 = obj275;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ S3_v92 (Il2CppMethodInfo)+C]");
		object obj276 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ S3_v93+60]");
		object obj277 = 0;
		object obj278 = obj277;
		object obj279 = obj278 & 0x1FFF;
		object obj280 = obj279 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1302 @ S4_v223 (should have been resolved before IL gen)");
		object obj281 = this + 340;
		object obj282 = default;
		obj281 = obj282;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Characters.CharacterId characterId = default;
		InAppData.PrintDynamicIdsForCharacterTypeForAllPlatforms(characterId);
		object obj283 = this + 344;
		obj283 = characterId;
		_ = 1;
		object obj284 = obj2 - -64;
		obj284 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj284;
		_ = ((IntPtr*)num18)->m_value;
		object obj285 = obj2 + 56;
		obj285 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj285;
		_ = ((IntPtr*)num18)->m_value;
		object obj286 = obj2 + 48;
		obj286 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj286;
		_ = ((IntPtr*)num18)->m_value;
		object obj287 = this + 400;
		obj287 = string.Empty;
		object obj288 = obj2 + 40;
		obj288 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj288;
		_ = ((IntPtr*)num18)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1389 @ S3_v97 (Il2CppMethodInfo)+C]");
		object obj289 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1390 @ S3_v98+60]");
		object obj290 = 0;
		object obj291 = obj290;
		object obj292 = obj291 & 0x1FFF;
		object obj293 = obj292 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1399 @ S4_v227 (should have been resolved before IL gen)");
		object obj294 = this + 420;
		object obj295 = default;
		obj294 = obj295;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ S3_v102 (Il2CppMethodInfo)+C]");
		object obj296 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ S3_v103+60]");
		object obj297 = 0;
		object obj298 = obj297;
		object obj299 = obj298 & 0x1FFF;
		object obj300 = obj299 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1422 @ S4_v231 (should have been resolved before IL gen)");
		object obj301 = this + 424;
		object obj302 = default;
		obj301 = obj302;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ S3_v107 (Il2CppMethodInfo)+C]");
		object obj303 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ S3_v108+60]");
		object obj304 = 0;
		object obj305 = obj304;
		object obj306 = obj305 & 0x1FFF;
		object obj307 = obj306 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1445 @ S4_v235 (should have been resolved before IL gen)");
		object obj308 = this + 428;
		object obj309 = default;
		obj308 = obj309;
		object obj310 = this + 432;
		GameStats instance = GameStats.Instance;
		obj310 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1463 @ S3_v112 (Il2CppMethodInfo)+C]");
		object obj311 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ S3_v113+60]");
		object obj312 = 0;
		object obj313 = obj312;
		object obj314 = obj313 & 0x1FFF;
		object obj315 = obj314 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1473 @ S4_v239 (should have been resolved before IL gen)");
		object obj316 = this + 436;
		object obj317 = default;
		obj316 = obj317;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ S3_v117 (Il2CppMethodInfo)+C]");
		object obj318 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ S3_v118+60]");
		object obj319 = 0;
		object obj320 = obj319;
		object obj321 = obj320 & 0x1FFF;
		object obj322 = obj321 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1496 @ S4_v243 (should have been resolved before IL gen)");
		object obj323 = this + 440;
		object obj324 = default;
		obj323 = obj324;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TopRunOnlineScreen._003CRefreshAdapterListDelayed_003Ed__48 obj325 = default;
		((IDisposable)obj325).Dispose();
		object obj326 = this + 460;
		obj326 = obj325;
		object obj327 = obj2 + 32;
		obj327 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj327;
		_ = ((IntPtr*)num18)->m_value;
		object obj328 = this + 480;
		obj328 = string.Empty;
		object obj329 = obj2 + 24;
		obj329 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj329;
		_ = ((IntPtr*)num18)->m_value;
		object obj330 = obj2 + 16;
		obj330 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj330;
		_ = ((IntPtr*)num18)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1567 @ S3_v122 (Il2CppMethodInfo)+C]");
		object obj331 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ S3_v123+60]");
		object obj332 = 0;
		object obj333 = obj332;
		object obj334 = obj333 & 0x1FFF;
		object obj335 = obj334 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1577 @ S4_v247 (should have been resolved before IL gen)");
		object obj336 = this + 520;
		object obj337 = default;
		obj336 = obj337;
		object obj338 = this + 548;
		obj338 = string.Empty;
		_ = 1;
		_ = 1;
		_ = 1;
		_ = 1;
		_ = -1;
		object obj339 = obj2 + 8;
		obj339 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj339;
		_ = ((IntPtr*)num18)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UnityRandomGen unityRandomGen = default;
		unityRandomGen._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9015");
		obj2 = DateTime.MinValue;
		((IntPtr*)num18)->m_value = (void*)(nint)obj2;
		_ = ((IntPtr*)num18)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UnityRandomGen unityRandomGen2 = default;
		unityRandomGen2._002Ector();
		bool flag = ((SyboRandom)(object)unityRandomGen2).Bool();
		obj = flag;
		object obj340 = this + 592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @110C5");
		object obj341 = default;
		obj340 = obj341;
		object obj342 = this + 596;
		obj342 = string.Empty;
		object obj343 = this + 600;
		obj343 = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ S3_v127 (Il2CppMethodInfo)+C]");
		object obj344 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1671 @ S3_v128+60]");
		object obj345 = 0;
		object obj346 = obj345;
		object obj347 = obj346 & 0x1FFF;
		object obj348 = obj347 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1680 @ S4_v251 (should have been resolved before IL gen)");
		object obj349 = this + 608;
		object obj350 = default;
		obj349 = obj350;
	}
}
