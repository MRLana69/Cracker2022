using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Mono.Globalization.Unicode;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;
using WordHunt;

namespace Ionic.Zlib;

internal sealed class InflateBlocks
{
	private enum InflateBlockMode
	{
		TYPE,
		LENS,
		STORED,
		TABLE,
		BTREE,
		DTREE,
		CODES,
		DRY,
		DONE,
		BAD
	}

	private const int MANY = 1440;

	internal static readonly int[] border;

	private InflateBlockMode mode;

	internal int left;

	internal int table;

	internal int index;

	internal int[] blens;

	internal int[] bb;

	internal int[] tb;

	internal InflateCodes codes;

	internal int last;

	internal ZlibCodec _codec;

	internal int bitk;

	internal int bitb;

	internal int[] hufts;

	internal byte[] window;

	internal int end;

	internal int readAt;

	internal int writeAt;

	internal object checkfn;

	internal uint check;

	internal InfTree inftree;

	internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
	{
		//IL_00cf: Expected I4, but got Obj
		if (bitk != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("GZipStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		ZlibCodec codec2 = _codec;
		if (codec2.TotalBytesIn == 2)
		{
			ZlibCodec codec3 = _codec;
			if (codec3.NextOut != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InvalidProgramException ex = default;
				ex._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			else
			{
				byte[] array = GZipStream.CompressString((string)(object)this);
				last = (int)array;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	internal uint Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0215: Expected I4, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)this != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 35;
		object obj7 = 0;
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj2 + obj8;
			if ((nint)obj9 == 35)
			{
				object obj10 = obj2 + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
				goto IL_0277;
			}
		}
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0277;
		IL_0277:
		uint result = default;
		return result;
	}

	internal int Process(int r)
	{
		//IL_0d23: Expected I, but got Obj
		//IL_0d39: Expected Obj, but got I
		//IL_109b: Expected Obj, but got I4
		//IL_10a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Expected Obj, but got Unknown
		//IL_10d2: Expected Obj, but got I
		//IL_10ed: Expected I4, but got Obj
		//IL_0c92: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0d86: Expected Obj, but got I4
		//IL_00ae: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I4
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_020e: Expected I, but got Obj
		//IL_0db3: Expected Obj, but got I4
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected Obj, but got Unknown
		//IL_0de2: Expected I4, but got Obj
		//IL_05e7: Expected Obj, but got I4
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_025b: Expected I, but got Obj
		//IL_0271: Expected Obj, but got I
		//IL_0176: Expected I, but got Obj
		//IL_0623: Expected I, but got Obj
		//IL_0639: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I4
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected Obj, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected Obj, but got Unknown
		//IL_0e70: Expected Obj, but got I
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_029c: Expected I, but got Obj
		//IL_0664: Expected I, but got Obj
		//IL_05c5: Expected Obj, but got I4
		//IL_0ecf: Expected I4, but got Obj
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_1137: Expected Obj, but got I4
		//IL_113f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Expected Obj, but got Unknown
		//IL_114d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Expected Obj, but got Unknown
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_115f: Expected Obj, but got Unknown
		//IL_116d: Expected I, but got Obj
		//IL_1183: Expected Obj, but got I
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected Obj, but got Unknown
		//IL_1240: Expected Obj, but got I4
		//IL_1270: Unknown result type (might be due to invalid IL or missing references)
		//IL_1275: Expected Obj, but got Unknown
		//IL_128f: Expected Obj, but got I4
		//IL_02fc: Expected I, but got Obj
		//IL_0312: Expected Obj, but got I
		//IL_0874: Expected I, but got Obj
		//IL_088a: Expected Obj, but got I
		//IL_06e0: Expected I, but got Obj
		//IL_06f6: Expected Obj, but got I
		//IL_11b8: Expected I, but got Obj
		//IL_11ce: Expected Obj, but got I
		//IL_038a: Expected I, but got Obj
		//IL_0f75: Expected Obj, but got I4
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected Obj, but got Unknown
		//IL_0fa4: Expected I4, but got Obj
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03f3: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04b5: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_0516: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I
		//IL_033d: Expected I, but got Obj
		//IL_0967: Expected Obj, but got I4
		//IL_08b5: Expected I, but got Obj
		//IL_0721: Expected I, but got Obj
		//IL_0552: Expected I, but got Obj
		//IL_07a1: Expected I, but got Obj
		//IL_07b7: Expected Obj, but got I
		//IL_102b: Expected Obj, but got I4
		//IL_07e2: Expected I, but got Obj
		//IL_09f8: Expected Obj, but got I4
		//IL_0a60: Expected Obj, but got I4
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected Obj, but got Unknown
		//IL_0ae7: Expected Obj, but got I4
		//IL_0b16: Expected Obj, but got I
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected Obj, but got Unknown
		//IL_0b48: Expected Obj, but got I4
		//IL_0b77: Expected Obj, but got I
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected Obj, but got Unknown
		//IL_0ba9: Expected Obj, but got I4
		//IL_0bd8: Expected Obj, but got I
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected Obj, but got Unknown
		//IL_0c0a: Expected Obj, but got I4
		//IL_0c33: Expected Obj, but got I
		//IL_0c3e: Expected Obj, but got I4
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected Obj, but got Unknown
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected Obj, but got Unknown
		//IL_0a3a: Expected Obj, but got I4
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		int num = left;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Int32)+20]");
		bool flag;
		if ((nint)0 != 0)
		{
			int num2 = left;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v21 (System.Int32)+8]");
			if ((nint)0 == 0)
			{
				int num3 = left;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v271 (System.Int32)+10]");
				if ((nint)0 != 0)
				{
					goto IL_0d15;
				}
			}
			nint num4 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num5 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v264 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = r == 4;
			bool flag2 = table != DeflateManager.FINISH_STATE;
			object obj2 = flag | flag2;
			if (obj2 != null)
			{
				int num6 = left;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (System.Int32)+28]");
				if ((nint)0 == 0)
				{
					nint num7 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v235 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num8 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v248 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = left + 56;
					object obj5 = DeflateManager._ErrorMessage + 44;
					obj4 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ZlibBaseStream zlibBaseStream = default;
					zlibBaseStream.Dispose((byte)(int)"OutputBuffer is full (AvailableBytesOut == 0)" != 0);
					((DeflateManager)(object)zlibBaseStream).Deflate(FlushType.None);
				}
				codes = (InflateCodes)r;
				nint num9 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v32 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v228 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (table == DeflateManager.INIT_STATE)
				{
					nint num11 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v168 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num12 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v251 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj8 = _codec - 8;
					object obj9 = obj8 << 4;
					object obj10 = obj9 + DeflateManager.Z_DEFLATED;
					object obj11 = obj10 << 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateBlocks)+7C]");
					object obj12 = -1;
					object obj13 = obj12 >> 1;
					object obj14 = obj13 & 0x7F;
					if ((nint)obj14 >= 3)
					{
						obj14 = 3;
					}
					object obj15 = obj14 << 6;
					int num13 = obj15 | obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateBlocks)+6C]");
					bool flag3 = (nint)0 == 0;
					int num14 = num13;
					if (!flag3)
					{
						nint num15 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v235 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num16 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v243 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num17 = DeflateManager.PRESET_DICT | num13;
						num14 = num17;
					}
					int num18 = num14 / 31;
					object obj17 = num18 * 31;
					object obj18 = num14 - obj17;
					object obj19 = 31 - obj18;
					object obj20 = obj19 + num14;
					nint num19 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v194 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num20 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v228 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					table = DeflateManager.BUSY_STATE;
					int[] array = (int[])(bb + 1);
					bb = array;
					object obj22 = index + 16;
					object obj23 = obj22 + (object)bb;
					object obj24 = obj20 >> 8;
					obj23 = obj24;
					int[] array2 = (int[])(bb + 1);
					bb = array2;
					object obj25 = index + 16;
					object obj26 = obj25 + (object)bb;
					obj26 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateBlocks)+6C]");
					if ((nint)0 != 0)
					{
						int[] array3 = (int[])(bb + 1);
						bb = array3;
						object obj27 = index + 16;
						object obj28 = obj27 + (object)bb;
						int num21 = left;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S1_v203 (System.Int32)+44]");
						object obj29 = (nint)0 >> 24;
						obj28 = obj29;
						int[] array4 = (int[])(bb + 1);
						bb = array4;
						object obj30 = index + 16;
						object obj31 = obj30 + (object)bb;
						int num22 = left;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S1_v210 (System.Int32)+44]");
						object obj32 = (nint)0 >> 16;
						obj31 = obj32;
						int[] array5 = (int[])(bb + 1);
						bb = array5;
						object obj33 = index + 16;
						object obj34 = obj33 + (object)bb;
						int num23 = left;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ S1_v217 (System.Int32)+44]");
						object obj35 = (nint)0 >> 8;
						obj34 = obj35;
						int[] array6 = (int[])(bb + 1);
						bb = array6;
						object obj36 = index + 16;
						object obj37 = obj36 + (object)bb;
						int num24 = left;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S1_v224 (System.Int32)+44]");
						obj37 = 0;
					}
					int num25 = left;
					nint num26 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S1_v189 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
					object obj38 = (nint)0 & (nint)0x200;
					if (obj38 != null)
					{
						nint num27 = (nint)typeof(Adler);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S1_v195 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num28 = ((ZlibBaseStream)null).Read((byte[])null, 0, 0);
				}
				int num29 = left;
				if (bb != null)
				{
					((ZlibStream)num29).Flush();
					int num30 = left;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v164 (System.Int32)+28]");
					if ((nint)0 == 0)
					{
						codes = (InflateCodes)(-1);
						goto IL_0607;
					}
				}
				else
				{
					bool flag4 = (nint)codes < r;
					object obj39 = flag4 | ((Stream)num29)._asyncActiveSemaphore;
					object obj40 = flag | obj39;
					if (obj40 == null)
					{
						goto IL_0607;
					}
				}
				nint num31 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v43 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num32 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v145 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (table == DeflateManager.FINISH_STATE)
				{
					int num33 = left;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v149 (System.Int32)+10]");
					if ((nint)0 != 0)
					{
						nint num34 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S1_v126 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
						object obj42 = (nint)0 & (nint)0x200;
						if (obj42 != null)
						{
							nint num35 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S1_v139 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj43 = left + 56;
						object obj44 = DeflateManager._ErrorMessage + 44;
						obj43 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						ZlibBaseStream zlibBaseStream2 = default;
						zlibBaseStream2.Dispose((byte)(int)"status == FINISH_STATE && _codec.AvailableBytesIn != 0" != 0);
						((DeflateManager)(object)zlibBaseStream2).Deflate(FlushType.None);
					}
				}
				int num36 = left;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v58 (System.Int32)+10]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateBlocks)+74]");
					if ((nint)0 == 0)
					{
						if (r != 0)
						{
							nint num37 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S1_v112 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
							object obj45 = (nint)0 & (nint)0x200;
							if (obj45 != null)
							{
								nint num38 = (nint)typeof(DeflateManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S1_v119 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (table != DeflateManager.FINISH_STATE)
							{
								goto IL_0826;
							}
						}
						goto IL_0fda;
					}
				}
				goto IL_0826;
			}
		}
		goto IL_0d15;
		IL_0d15:
		nint num39 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v4 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj46 = (nint)0 & (nint)0x200;
		if (obj46 != null)
		{
			nint num40 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v19 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj47 = left + 56;
		object obj48 = DeflateManager._ErrorMessage + 32;
		obj47 = obj48;
		int num41 = left;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v15 (System.Int32)+38]");
		string text = $"Something is fishy. [{(object[])0}]";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream3 = default;
		zlibBaseStream3.Dispose((byte)(int)text != 0);
		((DeflateManager)(object)zlibBaseStream3).Deflate(FlushType.None);
		return 0;
		IL_0607:
		int result = 0;
		goto IL_0f36;
		IL_0933:
		int num42 = left;
		result = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S1_v87 (System.Int32)+28]");
		if ((nint)0 == 0)
		{
			codes = (InflateCodes)(-1);
			result = 0;
		}
		goto IL_0f36;
		IL_0826:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A076");
		object obj50 = default;
		object obj49 = obj50 & -2;
		if ((nint)obj49 == 2)
		{
			nint num43 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v130 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj51 = (nint)0 & (nint)0x200;
			if (obj51 != null)
			{
				nint num44 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S0_v135 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			table = DeflateManager.FINISH_STATE;
		}
		if (obj50 == null)
		{
			goto IL_0933;
		}
		if ((nint)obj50 != 1)
		{
			if ((nint)obj50 == 2)
			{
				goto IL_0933;
			}
		}
		else
		{
			if (r == 1)
			{
				((DeflateManager)this).set_data_type();
			}
			else
			{
				((DeflateManager)this)._tr_flush_block(0, 0, false);
				if (r == 3)
				{
					object obj52 = 0;
					while ((nint)obj52 < writeAt)
					{
						object obj53 = this - -64;
						object obj54 = obj53 + 16;
						object obj55 = obj52 << 1;
						object obj56 = obj54 + obj55;
						obj56 = 0;
						object obj57 = obj52 + 1;
						obj52 = obj57;
					}
				}
			}
			((ZlibStream)left).Flush();
			int num45 = left;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S0_v109 (System.Int32)+28]");
			if ((nint)0 == 0)
			{
				codes = (InflateCodes)(-1);
				result = 0;
				goto IL_0f36;
			}
		}
		goto IL_0fda;
		IL_0f36:
		return result;
		IL_0fda:
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateBlocks)+D9]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateBlocks)+D8]");
				if ((nint)0 == 0)
				{
					int[] array7 = (int[])(bb + 1);
					bb = array7;
					object obj58 = index + 16;
					object obj59 = obj58 + (object)bb;
					int num46 = left;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S1_v56 (System.Int32)+44]");
					object obj60 = (nint)0 >> 24;
					obj59 = obj60;
					int[] array8 = (int[])(bb + 1);
					bb = array8;
					object obj61 = index + 16;
					object obj62 = obj61 + (object)bb;
					int num47 = left;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S1_v63 (System.Int32)+44]");
					object obj63 = (nint)0 >> 16;
					obj62 = obj63;
					int[] array9 = (int[])(bb + 1);
					bb = array9;
					object obj64 = index + 16;
					object obj65 = obj64 + (object)bb;
					int num48 = left;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ S1_v70 (System.Int32)+44]");
					object obj66 = (nint)0 >> 8;
					obj65 = obj66;
					int[] array10 = (int[])(bb + 1);
					bb = array10;
					object obj67 = index + 16;
					object obj68 = obj67 + (object)bb;
					int num49 = left;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S1_v77 (System.Int32)+44]");
					obj68 = 0;
					((ZlibStream)left).Flush();
					_ = 1;
					return (bb == null) ? 1 : 0;
				}
				result = 1;
			}
			else
			{
				result = 1;
			}
		}
		else
		{
			result = 0;
		}
		goto IL_0f36;
	}

	internal void Free()
	{
		if (bitk != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("GZipStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	internal void SetDictionary(byte[] d, int start, int n)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		object obj = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		object obj5 = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = default;
		obj5 = obj6;
		object obj7 = this + 84;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj8 = default;
		obj7 = obj8;
		object obj9 = this + 44;
		obj9 = d;
		object obj10 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj11 = default;
		obj10 = obj11;
		object obj12 = this + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		obj12 = obj13;
		object obj14 = this - -64;
		obj14 = n;
		object obj15 = this + 76;
		obj15 = start;
		mode = InflateBlockMode.TYPE;
		int num = SyncPoint();
	}

	internal int SyncPoint()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		mode = InflateBlockMode.TYPE;
		bitk = 0;
		bitb = 0;
		writeAt = 0;
		readAt = 0;
		if (checkfn != null)
		{
			ZlibCodec codec = _codec;
			nint num = (nint)typeof(Adler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v8 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Adler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v14 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			codec._Adler32 = (check = (uint)((ZlibBaseStream)null).Read((byte[])null, 0, 0));
		}
		return (int)check;
	}

	internal unsafe int Flush(int r)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		//IL_4147: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_041c: Expected I4, but got Obj
		//IL_0384: Expected Obj, but got I4
		//IL_1745: Unknown result type (might be due to invalid IL or missing references)
		//IL_174a: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0324: Expected I4, but got Obj
		//IL_2974: Expected Obj, but got I4
		//IL_2981: Unknown result type (might be due to invalid IL or missing references)
		//IL_2986: Expected I8, but got Unknown
		//IL_0689: Expected Obj, but got I4
		//IL_067b: Expected Obj, but got I4
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		//IL_0906: Expected Obj, but got I4
		//IL_0497: Expected I, but got Obj
		//IL_04ad: Expected Obj, but got I
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_061b: Expected I4, but got Obj
		//IL_3965: Unknown result type (might be due to invalid IL or missing references)
		//IL_396a: Expected Obj, but got Unknown
		//IL_3978: Expected Obj, but got I4
		//IL_3986: Expected Obj, but got I4
		//IL_399c: Expected Obj, but got I4
		//IL_3aa9: Expected I4, but got Obj
		//IL_4548: Expected Obj, but got I4
		//IL_04d8: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I4
		//IL_3427: Expected Obj, but got I4
		//IL_3434: Unknown result type (might be due to invalid IL or missing references)
		//IL_3439: Expected I8, but got Unknown
		//IL_346f: Expected I4, but got Obj
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Expected I4, but got Unknown
		//IL_34ed: Expected Obj, but got I4
		//IL_34fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ff: Expected I8, but got Unknown
		//IL_3bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcc: Expected Obj, but got Unknown
		//IL_0a24: Expected Obj, but got I4
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected I4, but got Unknown
		//IL_0846: Expected Obj, but got I4
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected I4, but got Unknown
		//IL_07de: Expected Obj, but got I4
		//IL_07d0: Expected Obj, but got I4
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got Unknown
		//IL_0d92: Expected Obj, but got I4
		//IL_0dbb: Expected VT, but got Obj
		//IL_0dbb: Expected VT, but got Obj
		//IL_0dbb: Expected VT, but got Obj
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected Obj, but got Unknown
		//IL_055c: Expected Obj, but got I4
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected Obj, but got Unknown
		//IL_09d8: Expected I4, but got Obj
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected Obj, but got Unknown
		//IL_0833: Expected Obj, but got I4
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected Obj, but got Unknown
		//IL_0770: Expected I4, but got Obj
		//IL_0e4f: Expected Obj, but got I4
		//IL_0cf9: Expected I, but got Obj
		//IL_0d0f: Expected Obj, but got I
		//IL_44e1: Expected Obj, but got I4
		//IL_44e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ee: Expected Obj, but got Unknown
		//IL_36de: Expected Obj, but got I4
		//IL_36eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f0: Expected I8, but got Unknown
		//IL_0b1e: Expected Obj, but got I4
		//IL_3d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3da3: Expected Obj, but got Unknown
		//IL_3dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db2: Expected Obj, but got Unknown
		//IL_3dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dcf: Expected Obj, but got Unknown
		//IL_3df3: Expected Obj, but got I4
		//IL_3d1b: Expected I, but got Obj
		//IL_3d31: Expected Obj, but got I
		//IL_139b: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Expected Obj, but got Unknown
		//IL_13a9: Expected Obj, but got I4
		//IL_13c1: Expected Obj, but got I4
		//IL_13ca: Expected Obj, but got I4
		//IL_3843: Expected Obj, but got I4
		//IL_3850: Unknown result type (might be due to invalid IL or missing references)
		//IL_3855: Expected I8, but got Unknown
		//IL_363e: Expected Obj, but got I4
		//IL_364b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3650: Expected I8, but got Unknown
		//IL_0e6a: Expected Obj, but got I4
		//IL_0d3a: Expected I, but got Obj
		//IL_424d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4252: Expected Obj, but got Unknown
		//IL_425c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4261: Expected Obj, but got Unknown
		//IL_4279: Unknown result type (might be due to invalid IL or missing references)
		//IL_427e: Expected Obj, but got Unknown
		//IL_42af: Expected Obj, but got I4
		//IL_13e7: Expected Obj, but got I
		//IL_13f0: Expected Obj, but got I4
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_35e8: Expected Obj, but got I4
		//IL_0cac: Expected I, but got Obj
		//IL_0c99: Expected Obj, but got I4
		//IL_1427: Expected Obj, but got I4
		//IL_1488: Expected I4, but got Obj
		//IL_149a: Expected Obj, but got I4
		//IL_1662: Unknown result type (might be due to invalid IL or missing references)
		//IL_1667: Expected Obj, but got Unknown
		//IL_1671: Unknown result type (might be due to invalid IL or missing references)
		//IL_1676: Expected I4, but got Unknown
		//IL_15e7: Expected Obj, but got I4
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected Obj, but got Unknown
		//IL_0ae2: Expected I4, but got Obj
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected Obj, but got Unknown
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got Unknown
		//IL_0c39: Expected I4, but got Obj
		//IL_151c: Expected Obj, but got I4
		//IL_3e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e08: Expected Obj, but got Unknown
		//IL_3e16: Expected I, but got Obj
		//IL_3e2c: Expected Obj, but got I
		//IL_1649: Expected Obj, but got I4
		//IL_1652: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Expected I4, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_432f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4334: Expected Obj, but got Unknown
		//IL_433e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4343: Expected Obj, but got Unknown
		//IL_4366: Unknown result type (might be due to invalid IL or missing references)
		//IL_436b: Expected I4, but got Unknown
		//IL_4373: Unknown result type (might be due to invalid IL or missing references)
		//IL_4378: Expected Obj, but got Unknown
		//IL_4381: Unknown result type (might be due to invalid IL or missing references)
		//IL_4386: Expected Obj, but got Unknown
		//IL_43ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_43b1: Expected Obj, but got Unknown
		//IL_43d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d9: Expected I4, but got Unknown
		//IL_43e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e9: Expected Obj, but got Unknown
		//IL_43f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43f6: Expected Obj, but got Unknown
		//IL_43ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_4404: Expected Obj, but got Unknown
		//IL_442a: Unknown result type (might be due to invalid IL or missing references)
		//IL_442f: Expected Obj, but got Unknown
		//IL_1537: Expected Obj, but got I4
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected I4, but got Unknown
		//IL_131e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1323: Expected Obj, but got Unknown
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected Obj, but got Unknown
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Expected Obj, but got Unknown
		//IL_0fca: Expected I, but got Obj
		//IL_0fb7: Expected Obj, but got I4
		//IL_16b7: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected Obj, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected Obj, but got Unknown
		//IL_0f57: Expected I4, but got Obj
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_104d: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_103a: Expected Obj, but got I4
		//IL_1069: Expected Obj, but got I4
		//IL_154a: Expected Obj, but got I4
		//IL_1558: Expected Obj, but got I
		//IL_1566: Expected Obj, but got I4
		//IL_1575: Expected Obj, but got I4
		//IL_105b: Expected Obj, but got I4
		//IL_445f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4464: Expected Obj, but got Unknown
		//IL_4472: Expected I, but got Obj
		//IL_4488: Expected Obj, but got I
		//IL_3ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef9: Expected Obj, but got Unknown
		//IL_3f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f22: Expected Obj, but got Unknown
		//IL_3f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f3c: Expected I4, but got Unknown
		//IL_3f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f49: Expected Obj, but got Unknown
		//IL_3f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f57: Expected Obj, but got Unknown
		//IL_3f71: Expected I4, but got Obj
		//IL_3f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f80: Expected Obj, but got Unknown
		//IL_3fbc: Expected Obj, but got I4
		//IL_3fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fc9: Expected Obj, but got Unknown
		//IL_11dc: Expected Obj, but got I4
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Expected Obj, but got Unknown
		//IL_1151: Expected I, but got Obj
		//IL_113e: Expected Obj, but got I4
		//IL_11a9: Expected Obj, but got I4
		//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected Obj, but got Unknown
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected Obj, but got Unknown
		//IL_10de: Expected I4, but got Obj
		//IL_29ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f1: Expected Obj, but got Unknown
		//IL_2a67: Expected Obj, but got I4
		//IL_2a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a79: Expected I8, but got Unknown
		//IL_128b: Expected Obj, but got I4
		//IL_122a: Expected Obj, but got I4
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Expected Obj, but got Unknown
		//IL_1270: Unknown result type (might be due to invalid IL or missing references)
		//IL_1275: Expected Obj, but got Unknown
		//IL_4020: Unknown result type (might be due to invalid IL or missing references)
		//IL_4025: Expected Obj, but got Unknown
		//IL_403b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4040: Expected Obj, but got Unknown
		//IL_4051: Unknown result type (might be due to invalid IL or missing references)
		//IL_4056: Expected Obj, but got Unknown
		//IL_2b0f: Expected Obj, but got I4
		//IL_2b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b21: Expected I8, but got Unknown
		//IL_2b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7f: Expected Obj, but got Unknown
		//IL_2bd9: Expected Obj, but got I4
		//IL_2be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2beb: Expected I8, but got Unknown
		//IL_2c81: Expected Obj, but got I4
		//IL_2c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c93: Expected I8, but got Unknown
		//IL_2d27: Expected Obj, but got I4
		//IL_2d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d39: Expected I8, but got Unknown
		//IL_2dce: Expected Obj, but got I4
		//IL_2ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de0: Expected I8, but got Unknown
		//IL_2e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e3e: Expected Obj, but got Unknown
		//IL_2e98: Expected Obj, but got I4
		//IL_2ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eaa: Expected I8, but got Unknown
		//IL_2f40: Expected Obj, but got I4
		//IL_2f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f52: Expected I8, but got Unknown
		//IL_2f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa0: Expected Obj, but got Unknown
		//IL_2fa9: Expected Obj, but got I4
		//IL_2fbd: Expected Obj, but got I4
		//IL_2fc6: Expected Obj, but got I4
		//IL_3025: Expected Obj, but got I4
		//IL_3032: Unknown result type (might be due to invalid IL or missing references)
		//IL_3037: Expected I8, but got Unknown
		//IL_30cc: Expected Obj, but got I4
		//IL_30d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_30de: Expected I8, but got Unknown
		//IL_3127: Unknown result type (might be due to invalid IL or missing references)
		//IL_312c: Expected Obj, but got Unknown
		//IL_3135: Expected Obj, but got I4
		//IL_314b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3150: Expected Obj, but got Unknown
		//IL_31aa: Expected Obj, but got I4
		//IL_31b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_31bc: Expected I8, but got Unknown
		//IL_3206: Unknown result type (might be due to invalid IL or missing references)
		//IL_320b: Expected Obj, but got Unknown
		//IL_3214: Expected Obj, but got I4
		//IL_3231: Expected Obj, but got I4
		//IL_3252: Expected Obj, but got I4
		//IL_32d9: Expected Obj, but got I4
		//IL_32e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32eb: Expected I8, but got Unknown
		//IL_3380: Expected Obj, but got I4
		//IL_338d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3392: Expected I8, but got Unknown
		ZlibCodec codec = _codec;
		ZlibCodec codec2 = _codec;
		int num;
		if (writeAt < readAt)
		{
			object obj = readAt - writeAt;
			num = obj - 1;
		}
		else
		{
			object obj2 = this - -64;
			num = obj2 - writeAt;
		}
		int num2 = writeAt;
		int num3 = codec2.AvailableBytesIn;
		int num4 = codec.NextIn;
		int num5 = bitb;
		int num6 = bitk;
		int num7 = r;
		int num8 = num;
		int num11 = default;
		int num18 = default;
		int num15 = default;
		int num14 = default;
		int num16 = default;
		int num17 = default;
		CelebrationPopup celebrationPopup = default;
		Characters.CharacterId characterId = default;
		int num31 = default;
		UIModelController.ModelScreen modelScreen = default;
		int num37 = default;
		int num38 = default;
		int num39 = default;
		int num40 = default;
		int num42 = default;
		int num43 = default;
		int num44 = default;
		int num49 = default;
		int availableBytesIn2 = default;
		int num50 = default;
		int num51 = default;
		int num52 = default;
		int num53 = default;
		int num54 = default;
		int num55 = default;
		int num56 = default;
		int num57 = default;
		int num58 = default;
		int num59 = default;
		int num60 = default;
		int num61 = default;
		int num62 = default;
		object obj14 = default;
		int num78 = default;
		int num81 = default;
		int num82 = default;
		int num83 = default;
		int num84 = default;
		int num85 = default;
		int num86 = default;
		int num98 = default;
		int num100 = default;
		int flush = default;
		int num113 = default;
		int num114 = default;
		int num115 = default;
		int num116 = default;
		int nextIn = default;
		int num117 = default;
		int num121 = default;
		int num122 = default;
		int num123 = default;
		int num124 = default;
		int num136 = default;
		int num137 = default;
		int num138 = default;
		int num139 = default;
		int num140 = default;
		int num165 = default;
		byte* ptr = default;
		bool flag8 = default;
		Mono.Globalization.Unicode.SimpleCollator.ExtenderType extenderType = default;
		bool flag9 = default;
		int num170 = default;
		int num171 = default;
		int num172 = default;
		int num173 = default;
		IEnumerator enumerator2 = default;
		while (true)
		{
			int num9 = num7;
			int num10 = num3;
			int num109;
			int num110;
			while (true)
			{
				string text = (string)num11;
				int num12 = num4;
				int num13;
				object obj5;
				for (num13 = num10; mode == InflateBlockMode.TYPE; num9 = num18, num12 = num15, num13 = num14)
				{
					num14 = num13;
					num15 = num12;
					num16 = num6;
					num17 = num5;
					num18 = num9;
					while (num16 <= 2)
					{
						if (num14 != 0)
						{
							int num19 = num14 - 1;
							ZlibCodec codec3 = _codec;
							object obj3 = codec3.InputBuffer + 16;
							object obj4 = obj3 + num15;
							int num20 = num16 & 0x1F;
							int num21 = obj4 << num20;
							int num22 = num21 | num17;
							int num23 = num16 + 8;
							int num24 = num15 + 1;
							num14 = num19;
							num15 = num24;
							num16 = num23;
							num17 = num22;
							num18 = 0;
							continue;
						}
						goto IL_037b;
					}
					int num25 = num17 & 1;
					last = num25;
					int num26 = num17 >> 1;
					switch (num26 & 3)
					{
					case 3:
						obj5 = 26;
						break;
					case 0:
					{
						object obj8 = num16 - 3;
						object obj9 = obj8 & 7;
						int num34 = obj8 - obj9;
						mode = InflateBlockMode.LENS;
						int num35 = num17 >> 3;
						int num36 = num35 >> (int)obj9;
						num5 = num36;
						num6 = num34;
						continue;
					}
					case 1:
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						nint num29 = (nint)typeof(InfTree);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1867 @ S0_v356 (Il2CppClass<Ionic.Zlib.InfTree>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num30 = (nint)typeof(InfTree);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ S0_v369 (Il2CppClass<Ionic.Zlib.InfTree>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						GameObject gameObject = celebrationPopup.ShowModel(characterId, num31, modelScreen, false);
						object year = celebrationPopup + 16;
						object month = characterId + 16;
						object obj7 = num31 + 16;
						text = (string)obj7;
						object minute = modelScreen + 16;
						((WordHuntManager)(object)codes).CalculateAndSaveLastKnownServerTime((string)year, (string)month, (string)obj7, (string)null, (string)minute, (string)null);
						int num32 = num16 - 3;
						mode = InflateBlockMode.CODES;
						int num33 = num17 >> 3;
						num5 = num33;
						num6 = num32;
						continue;
					}
					case 2:
					{
						int num27 = num16 - 3;
						mode = InflateBlockMode.TABLE;
						int num28 = num17 >> 3;
						num5 = num28;
						num6 = num27;
						continue;
					}
					default:
						obj5 = 18;
						break;
					}
					goto IL_173c;
					IL_037b:
					obj5 = 15;
					goto IL_173c;
				}
				int num41;
				int num45;
				int availableBytesIn;
				int num46;
				int num47;
				int w;
				int num48;
				int num74;
				if (mode != InflateBlockMode.LENS)
				{
					if (mode != InflateBlockMode.STORED)
					{
						if (mode != InflateBlockMode.TABLE)
						{
							if (mode == InflateBlockMode.BTREE)
							{
								num37 = num13;
								num38 = num12;
								num39 = num6;
								num40 = num5;
								num41 = num9;
								goto IL_452a;
							}
							if (mode == InflateBlockMode.DTREE)
							{
								num42 = num13;
								num43 = num6;
								num44 = num5;
								num41 = num9;
								num45 = num12;
								goto IL_37e5;
							}
							if (mode == InflateBlockMode.CODES)
							{
								availableBytesIn = num13;
								num46 = num6;
								num47 = num5;
								w = num9;
								num48 = num12;
								goto IL_37f2;
							}
							if (mode != InflateBlockMode.DRY)
							{
								if (mode != InflateBlockMode.DONE)
								{
									obj5 = ((mode != InflateBlockMode.BAD) ? ((object)141) : ((object)140));
								}
								else
								{
									num49 = num2;
									availableBytesIn2 = num13;
									num50 = num12;
									num51 = num6;
									num52 = num5;
									obj5 = 139;
								}
							}
							else
							{
								obj5 = 133;
								num53 = num2;
								num54 = num13;
								num55 = num12;
								num56 = num6;
								num57 = num5;
							}
						}
						else
						{
							num58 = num12;
							num59 = num6;
							num60 = num5;
							num61 = num9;
							num62 = num13;
							while (num59 <= 13)
							{
								if (num62 != 0)
								{
									int num63 = num62 - 1;
									ZlibCodec codec4 = _codec;
									object obj10 = codec4.InputBuffer + 16;
									object obj11 = obj10 + num58;
									int num64 = num59 & 0x1F;
									int num65 = obj11 << num64;
									int num66 = num65 | num60;
									int num67 = num59 + 8;
									int num68 = num58 + 1;
									num58 = num68;
									num59 = num67;
									num60 = num66;
									num61 = 0;
									num62 = num63;
									continue;
								}
								goto IL_07c7;
							}
							int num69 = num60 & 0x3FFF;
							table = num69;
							int num70 = num60 & 0x1F;
							if (num70 > 29)
							{
								obj5 = 64;
							}
							else
							{
								int num71 = num60 >> 5;
								int num72 = num71 & 0x1F;
								if (num72 < 30)
								{
									object obj12 = num70 + 258;
									int num73 = num72 + obj12;
									if (blens != null)
									{
										int[] array = blens;
										if (array.Length >= num73)
										{
											Array.ClearInternal((Array)blens, 0, num73);
											goto IL_3b03;
										}
									}
									object obj13 = this + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
									obj13 = obj14;
									goto IL_3b03;
								}
								obj5 = 64;
							}
						}
					}
					else
					{
						if (num13 != 0)
						{
							if (num8 != 0)
							{
								num74 = num8;
							}
							else
							{
								object obj15 = this - -64;
								int num75;
								if (num2 == (nint)obj15)
								{
									if (readAt != 0)
									{
										if (readAt > 0)
										{
											num74 = readAt - 1;
										}
										else
										{
											object obj16 = this - -64;
											num74 = (int)obj16;
										}
										if (num74 != 0)
										{
											num2 = 0;
											goto IL_3b7f;
										}
										num75 = 0;
									}
									else
									{
										num75 = num2;
									}
								}
								else
								{
									num75 = num2;
								}
								writeAt = num75;
								int num76 = ((InflateManager)this).Inflate((FlushType)num9);
								int num77;
								if (writeAt < readAt)
								{
									object obj17 = readAt - writeAt;
									num77 = obj17 - 1;
								}
								else
								{
									object obj18 = this - -64;
									num77 = obj18 - writeAt;
								}
								object obj19 = this - -64;
								bool flag = writeAt == (nint)obj19;
								bool flag2 = !flag;
								num78 = writeAt;
								int num79 = num77;
								if (!flag2)
								{
									bool flag3 = readAt == 0;
									num78 = writeAt;
									num79 = num77;
									if (!flag3)
									{
										int num80;
										if (readAt > 0)
										{
											num80 = readAt - 1;
											num78 = 0;
										}
										else
										{
											object obj20 = this - -64;
											num80 = (int)obj20;
											num78 = 0;
										}
										num79 = num80;
									}
								}
								if (num79 == 0)
								{
									num81 = num76;
									obj5 = 54;
									goto IL_173c;
								}
								num81 = num76;
								num2 = num78;
								num74 = num79;
							}
							goto IL_3b7f;
						}
						obj5 = 37;
					}
				}
				else
				{
					num82 = num13;
					num83 = num12;
					num84 = num6;
					num85 = num5;
					num86 = num9;
					while (num84 <= 31)
					{
						if (num82 != 0)
						{
							int num87 = num82 - 1;
							ZlibCodec codec5 = _codec;
							object obj21 = codec5.InputBuffer + 16;
							object obj22 = obj21 + num83;
							int num88 = num84 & 0x1F;
							int num89 = obj22 << num88;
							int num90 = num89 | num85;
							int num91 = num84 + 8;
							int num92 = num83 + 1;
							num82 = num87;
							num83 = num92;
							num84 = num91;
							num85 = num90;
							num86 = 0;
							continue;
						}
						goto IL_0672;
					}
					int num93 = num85 >> 16;
					int num94 = num93 ^ 0xFFFF;
					int num95 = num85 & 0xFFFF;
					if (num94 == num95)
					{
						left = num94;
						InflateBlockMode inflateBlockMode = ((left == 0) ? ((last != 0) ? InflateBlockMode.DRY : InflateBlockMode.TYPE) : InflateBlockMode.STORED);
						mode = inflateBlockMode;
						num11 = (int)text;
						num9 = num86;
						num4 = num83;
						num5 = 0;
						num6 = 0;
						num10 = num82;
						continue;
					}
					obj5 = 32;
				}
				goto IL_173c;
				IL_3b03:
				int num96 = num59 - 14;
				index = 0;
				mode = InflateBlockMode.BTREE;
				int num97 = num60 >> 14;
				num37 = num62;
				num38 = num58;
				num39 = num96;
				num40 = num97;
				num41 = num61;
				goto IL_452a;
				IL_1190:
				int num99;
				num98 = num99;
				int num101;
				num100 = num101;
				obj5 = 116;
				goto IL_173c;
				IL_0672:
				obj5 = 29;
				goto IL_173c;
				IL_3b7f:
				ZlibCodec codec6 = _codec;
				int num102 = left;
				int num103;
				if (left > num13)
				{
					num102 = num13;
					num103 = num13;
				}
				else
				{
					num103 = left;
				}
				int num104 = ((num102 <= num74) ? num103 : num74);
				Array.ConstrainedCopy(codec6.InputBuffer, num12, window, num2, num104);
				int num105 = num104 + num12;
				int num106 = num13 - num104;
				int num107 = num104 + num2;
				int num108 = num74 - num104;
				if ((left -= num104) == 0)
				{
					InflateBlockMode inflateBlockMode2 = ((last != 0) ? InflateBlockMode.DRY : InflateBlockMode.TYPE);
					mode = inflateBlockMode2;
				}
				num2 = num107;
				num11 = num104;
				num109 = num108;
				num4 = num105;
				num110 = num106;
				break;
				IL_07c7:
				obj5 = 60;
				goto IL_173c;
				IL_37f2:
				bitb = num47;
				bitk = num46;
				ZlibCodec codec7 = _codec;
				codec7.AvailableBytesIn = availableBytesIn;
				ZlibCodec codec8 = _codec;
				ZlibCodec codec9 = _codec;
				object obj23 = num48 - codec9.NextIn;
				long totalBytesIn = obj23 + codec8.TotalBytesIn;
				codec8.TotalBytesIn = totalBytesIn;
				ZlibCodec codec10 = _codec;
				codec10.NextIn = num48;
				writeAt = num2;
				int num111 = ((InflateManager)(object)codes).Initialize((ZlibCodec)(object)this, w);
				if (num111 != 1)
				{
					flush = num111;
					obj5 = 0;
				}
				else
				{
					ZlibCodec codec11 = _codec;
					ZlibCodec codec12 = _codec;
					num110 = codec12.AvailableBytesIn;
					int num112;
					if (writeAt < readAt)
					{
						object obj24 = readAt - writeAt;
						num112 = obj24 - 1;
					}
					else
					{
						object obj25 = this - -64;
						num112 = obj25 - writeAt;
					}
					if (last == 0)
					{
						mode = InflateBlockMode.TYPE;
						num113 = writeAt;
						num114 = bitk;
						num115 = bitb;
						num116 = num110;
						nextIn = codec11.NextIn;
						num2 = writeAt;
						num11 = 0;
						num109 = num112;
						num4 = codec11.NextIn;
						num5 = bitb;
						num6 = bitk;
						break;
					}
					num113 = writeAt;
					num114 = bitk;
					num115 = bitb;
					num116 = num110;
					nextIn = codec11.NextIn;
					obj5 = 132;
				}
				goto IL_173c;
				IL_37e5:
				num117 = num45;
				while (true)
				{
					int num118 = table >> 5;
					int num119 = num118 & 0x1F;
					int num120 = table & 0x1F;
					object obj26 = num120 + 258;
					object obj27 = num119 + obj26;
					if (index >= (nint)obj27)
					{
						break;
					}
					object obj28 = bb + 16;
					num121 = num117;
					num122 = num43;
					num123 = num44;
					num124 = num41;
					int num125 = num42;
					while (num122 < (nint)obj28)
					{
						if (num125 != 0)
						{
							int num126 = num125 - 1;
							ZlibCodec codec13 = _codec;
							object obj29 = codec13.InputBuffer + 16;
							object obj30 = obj29 + num121;
							int num127 = num122 & 0x1F;
							int num128 = obj30 << num127;
							int num129 = num128 | num123;
							int num130 = num122 + 8;
							int num131 = num121 + 1;
							num121 = num131;
							num122 = num130;
							num123 = num129;
							num124 = 0;
							num125 = num126;
							continue;
						}
						goto IL_0fae;
					}
					object obj31 = tb + 16;
					nint num132 = (nint)typeof(InternalInflateConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1895 @ S0_v667 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num133 = (nint)typeof(InternalInflateConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2009 @ S0_v764 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj33 = InternalInflateConstants.InflateMask + 16;
					object obj34 = InternalInflateConstants.InflateMask + 16;
					object obj35 = obj28 << 2;
					object obj36 = obj34 + obj35;
					int num134 = obj36 & num123;
					object obj37 = num134 + obj31;
					object obj38 = obj37 * 3;
					object obj39 = obj38 << 2;
					object obj40 = (object)hufts + obj39;
					object obj41 = obj40 + 20;
					object obj42 = obj41 << 2;
					object obj43 = obj33 + obj42;
					int num135 = obj43 & num123;
					object obj44 = tb + 16;
					object obj45 = num135 + obj44;
					object obj46 = obj45 * 3;
					object obj47 = obj46 << 2;
					object obj48 = (object)hufts + obj47;
					object obj49 = obj48 + 24;
					int num158;
					int num159;
					int num160;
					if ((nint)obj49 > 15)
					{
						bool flag4 = (nint)obj49 == 18;
						object obj50 = ((!flag4) ? ((object)(obj49 - 14)) : ((object)7));
						object obj51 = ((!flag4) ? ((object)3) : ((object)11));
						num136 = num122;
						num137 = num123;
						num138 = num124;
						num139 = num125;
						num140 = num121;
						while (true)
						{
							object obj52 = obj50 + obj41;
							if (num136 >= (nint)obj52)
							{
								break;
							}
							if (num139 != 0)
							{
								int num141 = num139 - 1;
								ZlibCodec codec14 = _codec;
								object obj53 = codec14.InputBuffer + 16;
								object obj54 = obj53 + num140;
								int num142 = num136 & 0x1F;
								int num143 = obj54 << num142;
								int num144 = num143 | num137;
								int num145 = num136 + 8;
								int num146 = num140 + 1;
								num136 = num145;
								num137 = num144;
								num138 = 0;
								num139 = num141;
								num140 = num146;
								continue;
							}
							goto IL_1135;
						}
						object obj55 = num136 - obj41;
						nint num147 = (nint)typeof(InternalInflateConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2397 @ S1_v462 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+BA]");
						object obj56 = (nint)0 & (nint)0x200;
						if (obj56 != null)
						{
							nint num148 = (nint)typeof(InternalInflateConstants);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ S1_v500 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj57 = InternalInflateConstants.InflateMask + 16;
						object obj58 = obj50 << 2;
						object obj59 = obj57 + obj58;
						object obj60 = obj41 & 0x1F;
						int num149 = num137 >> (int)obj60;
						int num150 = obj59 & num149;
						object obj61 = num150 + obj51;
						object obj62 = obj50 & 0x1F;
						num101 = num149 >> (int)obj62;
						num99 = obj55 - obj50;
						object obj63 = obj61 + index;
						int num151 = table >> 5;
						int num152 = num151 & 0x1F;
						int num153 = table & 0x1F;
						object obj64 = num153 + 258;
						object obj65 = num152 + obj64;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj63) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65))
						{
							bool flag5 = index > 0;
							bool flag6 = (nint)obj49 == 16;
							object obj66 = (flag6 ? 1 : 0) ^ 1;
							object obj67 = flag5 | obj66;
							if (obj67 == null)
							{
								goto IL_1211;
							}
							object obj70;
							if (flag6)
							{
								int num154 = index << 2;
								object obj68 = blens + num154;
								object obj69 = obj68 + 12;
								obj70 = obj69;
							}
							else
							{
								obj70 = 0;
							}
							int num155 = index;
							object obj71 = obj61;
							int num156;
							while (true)
							{
								num156 = num155 + 1;
								object obj72 = blens + 16;
								int num157 = num155 << 2;
								object obj73 = obj72 + num157;
								obj73 = obj70;
								object obj74 = obj71 - 1;
								if ((nint)obj71 == 1)
								{
									break;
								}
								num155 = num156;
								obj71 = obj74;
							}
							index = num156;
							num98 = num99;
							num100 = num101;
							num158 = num139;
							num159 = num140;
							num43 = num99;
							num44 = num101;
							num160 = num138;
							goto IL_4073;
						}
						goto IL_1190;
					}
					int num161 = num122 - obj41;
					int num162 = index + 1;
					index = num162;
					object obj75 = blens + 16;
					int num163 = index << 2;
					object obj76 = obj75 + num163;
					obj76 = obj49;
					object obj77 = obj41 & 0x1F;
					int num164 = num123 >> (int)obj77;
					num158 = num125;
					num159 = num121;
					num43 = num161;
					num44 = num164;
					num160 = num124;
					goto IL_4073;
					IL_4073:
					num117 = num159;
					num42 = num158;
					num41 = num160;
				}
				object obj78 = tb + 16;
				obj78 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj79 = num165 + 16;
				obj79 = 9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj80 = (object)(ptr + 16);
				obj80 = 6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num166 = table & 0x1F;
				string s = (string)(num166 + 257);
				int num167 = table >> 5;
				int num168 = num167 & 0x1F;
				bool flag7 = ((Mono.Globalization.Unicode.SimpleCollator)(object)inftree).MatchesForwardCore(s, ref *(int*)(num168 + 1), (int)blens, num165, ptr, flag8, extenderType, ref *(Mono.Globalization.Unicode.Contraction*)hufts, ref *(Mono.Globalization.Unicode.SimpleCollator.Context*)_codec);
				object obj81 = (flag7 ? 1 : 0) - -3;
				if ((flag7 ? 1 : 0) != -3)
				{
					if ((nint)obj81 != 1 && (nint)obj81 != 2 && (nint)obj81 == 3)
					{
						object year2 = num165 + 16;
						object month2 = (object)(ptr + 16);
						object hour = (flag8 ? 1 : 0) + 16;
						object second = extenderType + 16;
						((WordHuntManager)(object)codes).CalculateAndSaveLastKnownServerTime((string)year2, (string)month2, (string)(object)hufts, (string)hour, (string)(object)hufts, (string)second);
						mode = InflateBlockMode.CODES;
						availableBytesIn = num42;
						num46 = num43;
						num47 = num44;
						w = num41;
						num48 = num117;
						goto IL_37f2;
					}
					flag9 = flag7;
					obj5 = 124;
				}
				else
				{
					obj5 = 123;
				}
				goto IL_173c;
				IL_1135:
				obj5 = 109;
				goto IL_173c;
				IL_0fae:
				obj5 = 96;
				goto IL_173c;
				IL_452a:
				while (true)
				{
					int num169 = table >> 10;
					object obj82 = num169 + 4;
					if (index >= (nint)obj82)
					{
						break;
					}
					num170 = num38;
					num171 = num39;
					num172 = num40;
					num173 = num41;
					int num174 = num37;
					while (num171 <= 2)
					{
						if (num174 != 0)
						{
							int num175 = num174 - 1;
							ZlibCodec codec15 = _codec;
							object obj83 = codec15.InputBuffer + 16;
							object obj84 = obj83 + num170;
							int num176 = num171 & 0x1F;
							int num177 = obj84 << num176;
							int num178 = num177 | num172;
							int num179 = num171 + 8;
							int num180 = num170 + 1;
							num170 = num180;
							num171 = num179;
							num172 = num178;
							num173 = 0;
							num174 = num175;
							continue;
						}
						goto IL_0c90;
					}
					nint num181 = (nint)typeof(InflateBlocks);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1572 @ S1_v344 (Il2CppClass<Ionic.Zlib.InflateBlocks>)+BA]");
					object obj85 = (nint)0 & (nint)0x200;
					if (obj85 != null)
					{
						nint num182 = (nint)typeof(InflateBlocks);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1728 @ S1_v362 (Il2CppClass<Ionic.Zlib.InflateBlocks>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num183 = index + 1;
					index = num183;
					object obj86 = blens + 16;
					object obj87 = border + 16;
					int num184 = index << 2;
					object obj88 = obj87 + num184;
					object obj89 = obj88 << 2;
					object obj90 = obj86 + obj89;
					int num185 = num172 & 7;
					obj90 = num185;
					int num186 = num172 >> 3;
					int num187 = num171 - 3;
					num37 = num174;
					num38 = num170;
					num39 = num187;
					num40 = num186;
					num41 = num173;
				}
				while (index <= 18)
				{
					nint num188 = (nint)typeof(InflateBlocks);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ S1_v320 (Il2CppClass<Ionic.Zlib.InflateBlocks>)+BA]");
					object obj91 = (nint)0 & (nint)0x200;
					if (obj91 != null)
					{
						nint num189 = (nint)typeof(InflateBlocks);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1578 @ S1_v335 (Il2CppClass<Ionic.Zlib.InflateBlocks>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num190 = index + 1;
					index = num190;
					object obj92 = blens + 16;
					object obj93 = border + 16;
					int num191 = index << 2;
					object obj94 = obj93 + num191;
					object obj95 = obj94 << 2;
					object obj96 = obj92 + obj95;
					obj96 = 0;
				}
				object obj97 = bb + 16;
				obj97 = 7;
				IEnumerator enumerator = ((CharacterNameEventPopup)(object)inftree).DelayPositioning((UISprite)(object)blens, (GameObject)(object)bb, (Vector3)tb, (Vector3)hufts, (Vector3)_codec);
				object obj98 = enumerator - -3;
				if ((nint)enumerator != -3)
				{
					if ((nint)obj98 != 1 && (nint)obj98 != 2 && (nint)obj98 == 3)
					{
						index = 0;
						mode = InflateBlockMode.DTREE;
						num42 = num37;
						num43 = num39;
						num44 = num40;
						num45 = num38;
						goto IL_37e5;
					}
					enumerator2 = enumerator;
					obj5 = 89;
				}
				else
				{
					obj5 = 88;
				}
				goto IL_173c;
				IL_1211:
				num98 = num99;
				num100 = num101;
				obj5 = 116;
				goto IL_173c;
				IL_173c:
				object obj99 = obj5 - 15;
				FlushType flush2;
				if ((nint)obj5 != 15)
				{
					bool flag10 = (nint)obj99 == 1;
					flush2 = (FlushType)num9;
					if (!flag10)
					{
						bool flag11 = (nint)obj99 == 2;
						flush2 = (FlushType)num9;
						if (!flag11)
						{
							if ((nint)obj99 != 3)
							{
								bool flag12 = (nint)obj99 == 4;
								flush2 = (FlushType)num9;
								if (!flag12)
								{
									bool flag13 = (nint)obj99 == 5;
									flush2 = (FlushType)num9;
									if (!flag13)
									{
										bool flag14 = (nint)obj99 == 6;
										flush2 = (FlushType)num9;
										if (!flag14)
										{
											bool flag15 = (nint)obj99 == 7;
											flush2 = (FlushType)num9;
											if (!flag15)
											{
												bool flag16 = (nint)obj99 == 8;
												flush2 = (FlushType)num9;
												if (!flag16)
												{
													bool flag17 = (nint)obj99 == 9;
													flush2 = (FlushType)num9;
													if (!flag17)
													{
														bool flag18 = (nint)obj99 == 10;
														flush2 = (FlushType)num9;
														if (!flag18)
														{
															if ((nint)obj99 != 11)
															{
																bool flag19 = (nint)obj99 == 12;
																flush2 = (FlushType)num9;
																if (!flag19)
																{
																	bool flag20 = (nint)obj99 == 13;
																	flush2 = (FlushType)num9;
																	if (!flag20)
																	{
																		if ((nint)obj99 != 14)
																		{
																			bool flag21 = (nint)obj99 == 15;
																			flush2 = (FlushType)num9;
																			if (!flag21)
																			{
																				bool flag22 = (nint)obj99 == 16;
																				flush2 = (FlushType)num9;
																				if (!flag22)
																				{
																					if ((nint)obj99 != 17)
																					{
																						bool flag23 = (nint)obj99 == 18;
																						flush2 = (FlushType)num9;
																						if (!flag23)
																						{
																							bool flag24 = (nint)obj99 == 19;
																							flush2 = (FlushType)num9;
																							if (!flag24)
																							{
																								bool flag25 = (nint)obj99 == 20;
																								flush2 = (FlushType)num9;
																								if (!flag25)
																								{
																									bool flag26 = (nint)obj99 == 21;
																									flush2 = (FlushType)num9;
																									if (!flag26)
																									{
																										if ((nint)obj99 != 22)
																										{
																											bool flag27 = (nint)obj99 == 23;
																											flush2 = (FlushType)num9;
																											if (!flag27)
																											{
																												bool flag28 = (nint)obj99 == 24;
																												flush2 = (FlushType)num9;
																												if (!flag28)
																												{
																													bool flag29 = (nint)obj99 == 25;
																													flush2 = (FlushType)num9;
																													if (!flag29)
																													{
																														bool flag30 = (nint)obj99 == 26;
																														flush2 = (FlushType)num9;
																														if (!flag30)
																														{
																															bool flag31 = (nint)obj99 == 27;
																															flush2 = (FlushType)num9;
																															if (!flag31)
																															{
																																bool flag32 = (nint)obj99 == 28;
																																flush2 = (FlushType)num9;
																																if (!flag32)
																																{
																																	bool flag33 = (nint)obj99 == 29;
																																	flush2 = (FlushType)num9;
																																	if (!flag33)
																																	{
																																		bool flag34 = (nint)obj99 == 30;
																																		flush2 = (FlushType)num9;
																																		if (!flag34)
																																		{
																																			bool flag35 = (nint)obj99 == 31;
																																			flush2 = (FlushType)num9;
																																			if (!flag35)
																																			{
																																				bool flag36 = (nint)obj99 == 32;
																																				flush2 = (FlushType)num9;
																																				if (!flag36)
																																				{
																																					bool flag37 = (nint)obj99 == 33;
																																					flush2 = (FlushType)num9;
																																					if (!flag37)
																																					{
																																						bool flag38 = (nint)obj99 == 34;
																																						flush2 = (FlushType)num9;
																																						if (!flag38)
																																						{
																																							bool flag39 = (nint)obj99 == 35;
																																							flush2 = (FlushType)num9;
																																							if (!flag39)
																																							{
																																								bool flag40 = (nint)obj99 == 36;
																																								flush2 = (FlushType)num9;
																																								if (!flag40)
																																								{
																																									bool flag41 = (nint)obj99 == 37;
																																									flush2 = (FlushType)num9;
																																									if (!flag41)
																																									{
																																										bool flag42 = (nint)obj99 == 38;
																																										flush2 = (FlushType)num9;
																																										if (!flag42)
																																										{
																																											if ((nint)obj99 != 39)
																																											{
																																												bool flag43 = (nint)obj99 == 40;
																																												flush2 = (FlushType)num9;
																																												if (!flag43)
																																												{
																																													bool flag44 = (nint)obj99 == 41;
																																													flush2 = (FlushType)num9;
																																													if (!flag44)
																																													{
																																														bool flag45 = (nint)obj99 == 42;
																																														flush2 = (FlushType)num9;
																																														if (!flag45)
																																														{
																																															bool flag46 = (nint)obj99 == 43;
																																															flush2 = (FlushType)num9;
																																															if (!flag46)
																																															{
																																																bool flag47 = (nint)obj99 == 44;
																																																flush2 = (FlushType)num9;
																																																if (!flag47)
																																																{
																																																	if ((nint)obj99 != 45)
																																																	{
																																																		bool flag48 = (nint)obj99 == 46;
																																																		flush2 = (FlushType)num9;
																																																		if (!flag48)
																																																		{
																																																			bool flag49 = (nint)obj99 == 47;
																																																			flush2 = (FlushType)num9;
																																																			if (!flag49)
																																																			{
																																																				bool flag50 = (nint)obj99 == 48;
																																																				flush2 = (FlushType)num9;
																																																				if (!flag50)
																																																				{
																																																					if ((nint)obj99 != 49)
																																																					{
																																																						bool flag51 = (nint)obj99 == 50;
																																																						flush2 = (FlushType)num9;
																																																						if (!flag51)
																																																						{
																																																							bool flag52 = (nint)obj99 == 51;
																																																							flush2 = (FlushType)num9;
																																																							if (!flag52)
																																																							{
																																																								bool flag53 = (nint)obj99 == 52;
																																																								flush2 = (FlushType)num9;
																																																								if (!flag53)
																																																								{
																																																									bool flag54 = (nint)obj99 == 53;
																																																									flush2 = (FlushType)num9;
																																																									if (!flag54)
																																																									{
																																																										bool flag55 = (nint)obj99 == 54;
																																																										flush2 = (FlushType)num9;
																																																										if (!flag55)
																																																										{
																																																											bool flag56 = (nint)obj99 == 55;
																																																											flush2 = (FlushType)num9;
																																																											if (!flag56)
																																																											{
																																																												bool flag57 = (nint)obj99 == 56;
																																																												flush2 = (FlushType)num9;
																																																												if (!flag57)
																																																												{
																																																													bool flag58 = (nint)obj99 == 57;
																																																													flush2 = (FlushType)num9;
																																																													if (!flag58)
																																																													{
																																																														if ((nint)obj99 != 58)
																																																														{
																																																															bool flag59 = (nint)obj99 == 59;
																																																															flush2 = (FlushType)num9;
																																																															if (!flag59)
																																																															{
																																																																bool flag60 = (nint)obj99 == 60;
																																																																flush2 = (FlushType)num9;
																																																																if (!flag60)
																																																																{
																																																																	bool flag61 = (nint)obj99 == 61;
																																																																	flush2 = (FlushType)num9;
																																																																	if (!flag61)
																																																																	{
																																																																		bool flag62 = (nint)obj99 == 62;
																																																																		flush2 = (FlushType)num9;
																																																																		if (!flag62)
																																																																		{
																																																																			bool flag63 = (nint)obj99 == 63;
																																																																			flush2 = (FlushType)num9;
																																																																			if (!flag63)
																																																																			{
																																																																				bool flag64 = (nint)obj99 == 64;
																																																																				flush2 = (FlushType)num9;
																																																																				if (!flag64)
																																																																				{
																																																																					bool flag65 = (nint)obj99 == 65;
																																																																					flush2 = (FlushType)num9;
																																																																					if (!flag65)
																																																																					{
																																																																						bool flag66 = (nint)obj99 == 66;
																																																																						flush2 = (FlushType)num9;
																																																																						if (!flag66)
																																																																						{
																																																																							bool flag67 = (nint)obj99 == 67;
																																																																							flush2 = (FlushType)num9;
																																																																							if (!flag67)
																																																																							{
																																																																								bool flag68 = (nint)obj99 == 68;
																																																																								flush2 = (FlushType)num9;
																																																																								if (!flag68)
																																																																								{
																																																																									bool flag69 = (nint)obj99 == 69;
																																																																									flush2 = (FlushType)num9;
																																																																									if (!flag69)
																																																																									{
																																																																										bool flag70 = (nint)obj99 == 70;
																																																																										flush2 = (FlushType)num9;
																																																																										if (!flag70)
																																																																										{
																																																																											bool flag71 = (nint)obj99 == 71;
																																																																											flush2 = (FlushType)num9;
																																																																											if (!flag71)
																																																																											{
																																																																												bool flag72 = (nint)obj99 == 72;
																																																																												flush2 = (FlushType)num9;
																																																																												if (!flag72)
																																																																												{
																																																																													if ((nint)obj99 != 73)
																																																																													{
																																																																														bool flag73 = (nint)obj99 == 74;
																																																																														flush2 = (FlushType)num9;
																																																																														if (!flag73)
																																																																														{
																																																																															bool flag74 = (nint)obj99 == 75;
																																																																															flush2 = (FlushType)num9;
																																																																															if (!flag74)
																																																																															{
																																																																																bool flag75 = (nint)obj99 == 76;
																																																																																flush2 = (FlushType)num9;
																																																																																if (!flag75)
																																																																																{
																																																																																	bool flag76 = (nint)obj99 == 77;
																																																																																	flush2 = (FlushType)num9;
																																																																																	if (!flag76)
																																																																																	{
																																																																																		bool flag77 = (nint)obj99 == 78;
																																																																																		flush2 = (FlushType)num9;
																																																																																		if (!flag77)
																																																																																		{
																																																																																			bool flag78 = (nint)obj99 == 79;
																																																																																			flush2 = (FlushType)num9;
																																																																																			if (!flag78)
																																																																																			{
																																																																																				bool flag79 = (nint)obj99 == 80;
																																																																																				flush2 = (FlushType)num9;
																																																																																				if (!flag79)
																																																																																				{
																																																																																					if ((nint)obj99 != 81)
																																																																																					{
																																																																																						bool flag80 = (nint)obj99 == 82;
																																																																																						flush2 = (FlushType)num9;
																																																																																						if (!flag80)
																																																																																						{
																																																																																							bool flag81 = (nint)obj99 == 83;
																																																																																							flush2 = (FlushType)num9;
																																																																																							if (!flag81)
																																																																																							{
																																																																																								bool flag82 = (nint)obj99 == 84;
																																																																																								flush2 = (FlushType)num9;
																																																																																								if (!flag82)
																																																																																								{
																																																																																									bool flag83 = (nint)obj99 == 85;
																																																																																									flush2 = (FlushType)num9;
																																																																																									if (!flag83)
																																																																																									{
																																																																																										bool flag84 = (nint)obj99 == 86;
																																																																																										flush2 = (FlushType)num9;
																																																																																										if (!flag84)
																																																																																										{
																																																																																											bool flag85 = (nint)obj99 == 87;
																																																																																											flush2 = (FlushType)num9;
																																																																																											if (!flag85)
																																																																																											{
																																																																																												bool flag86 = (nint)obj99 == 88;
																																																																																												flush2 = (FlushType)num9;
																																																																																												if (!flag86)
																																																																																												{
																																																																																													bool flag87 = (nint)obj99 == 89;
																																																																																													flush2 = (FlushType)num9;
																																																																																													if (!flag87)
																																																																																													{
																																																																																														bool flag88 = (nint)obj99 == 90;
																																																																																														flush2 = (FlushType)num9;
																																																																																														if (!flag88)
																																																																																														{
																																																																																															bool flag89 = (nint)obj99 == 91;
																																																																																															flush2 = (FlushType)num9;
																																																																																															if (!flag89)
																																																																																															{
																																																																																																bool flag90 = (nint)obj99 == 92;
																																																																																																flush2 = (FlushType)num9;
																																																																																																if (!flag90)
																																																																																																{
																																																																																																	bool flag91 = (nint)obj99 == 93;
																																																																																																	flush2 = (FlushType)num9;
																																																																																																	if (!flag91)
																																																																																																	{
																																																																																																		if ((nint)obj99 != 94)
																																																																																																		{
																																																																																																			bool flag92 = (nint)obj99 == 95;
																																																																																																			flush2 = (FlushType)num9;
																																																																																																			if (!flag92)
																																																																																																			{
																																																																																																				bool flag93 = (nint)obj99 == 96;
																																																																																																				flush2 = (FlushType)num9;
																																																																																																				if (!flag93)
																																																																																																				{
																																																																																																					bool flag94 = (nint)obj99 == 97;
																																																																																																					flush2 = (FlushType)num9;
																																																																																																					if (!flag94)
																																																																																																					{
																																																																																																						bool flag95 = (nint)obj99 == 98;
																																																																																																						flush2 = (FlushType)num9;
																																																																																																						if (!flag95)
																																																																																																						{
																																																																																																							bool flag96 = (nint)obj99 == 99;
																																																																																																							flush2 = (FlushType)num9;
																																																																																																							if (!flag96)
																																																																																																							{
																																																																																																								bool flag97 = (nint)obj99 == 100;
																																																																																																								flush2 = (FlushType)num9;
																																																																																																								if (!flag97)
																																																																																																								{
																																																																																																									if ((nint)obj99 != 101)
																																																																																																									{
																																																																																																										bool flag98 = (nint)obj99 == 102;
																																																																																																										flush2 = (FlushType)num9;
																																																																																																										if (!flag98)
																																																																																																										{
																																																																																																											bool flag99 = (nint)obj99 == 103;
																																																																																																											flush2 = (FlushType)num9;
																																																																																																											if (!flag99)
																																																																																																											{
																																																																																																												bool flag100 = (nint)obj99 == 104;
																																																																																																												flush2 = (FlushType)num9;
																																																																																																												if (!flag100)
																																																																																																												{
																																																																																																													bool flag101 = (nint)obj99 == 105;
																																																																																																													flush2 = (FlushType)num9;
																																																																																																													if (!flag101)
																																																																																																													{
																																																																																																														bool flag102 = (nint)obj99 == 106;
																																																																																																														flush2 = (FlushType)num9;
																																																																																																														if (!flag102)
																																																																																																														{
																																																																																																															bool flag103 = (nint)obj99 == 107;
																																																																																																															flush2 = (FlushType)num9;
																																																																																																															if (!flag103)
																																																																																																															{
																																																																																																																if ((nint)obj99 != 108)
																																																																																																																{
																																																																																																																	bool flag104 = (nint)obj99 == 109;
																																																																																																																	flush2 = (FlushType)num9;
																																																																																																																	if (!flag104)
																																																																																																																	{
																																																																																																																		bool flag105 = (nint)obj99 == 110;
																																																																																																																		flush2 = (FlushType)num9;
																																																																																																																		if (!flag105)
																																																																																																																		{
																																																																																																																			bool flag106 = (nint)obj99 == 111;
																																																																																																																			flush2 = (FlushType)num9;
																																																																																																																			if (!flag106)
																																																																																																																			{
																																																																																																																				bool flag107 = (nint)obj99 == 112;
																																																																																																																				flush2 = (FlushType)num9;
																																																																																																																				if (!flag107)
																																																																																																																				{
																																																																																																																					bool flag108 = (nint)obj99 == 113;
																																																																																																																					flush2 = (FlushType)num9;
																																																																																																																					if (!flag108)
																																																																																																																					{
																																																																																																																						bool flag109 = (nint)obj99 == 114;
																																																																																																																						flush2 = (FlushType)num9;
																																																																																																																						if (!flag109)
																																																																																																																						{
																																																																																																																							bool flag110 = (nint)obj99 == 115;
																																																																																																																							flush2 = (FlushType)num9;
																																																																																																																							if (!flag110)
																																																																																																																							{
																																																																																																																								bool flag111 = (nint)obj99 == 116;
																																																																																																																								flush2 = (FlushType)num9;
																																																																																																																								if (!flag111)
																																																																																																																								{
																																																																																																																									if ((nint)obj99 != 117)
																																																																																																																									{
																																																																																																																										bool flag112 = (nint)obj99 == 118;
																																																																																																																										flush2 = (FlushType)num9;
																																																																																																																										if (!flag112)
																																																																																																																										{
																																																																																																																											bool flag113 = (nint)obj99 == 119;
																																																																																																																											flush2 = (FlushType)num9;
																																																																																																																											if (!flag113)
																																																																																																																											{
																																																																																																																												bool flag114 = (nint)obj99 == 120;
																																																																																																																												flush2 = (FlushType)num9;
																																																																																																																												if (!flag114)
																																																																																																																												{
																																																																																																																													bool flag115 = (nint)obj99 == 121;
																																																																																																																													flush2 = (FlushType)num9;
																																																																																																																													if (!flag115)
																																																																																																																													{
																																																																																																																														bool flag116 = (nint)obj99 == 122;
																																																																																																																														flush2 = (FlushType)num9;
																																																																																																																														if (!flag116)
																																																																																																																														{
																																																																																																																															bool flag117 = (nint)obj99 == 123;
																																																																																																																															flush2 = (FlushType)num9;
																																																																																																																															if (!flag117)
																																																																																																																															{
																																																																																																																																bool flag118 = (nint)obj99 == 124;
																																																																																																																																flush2 = (FlushType)num9;
																																																																																																																																if (!flag118)
																																																																																																																																{
																																																																																																																																	if ((nint)obj99 != 125)
																																																																																																																																	{
																																																																																																																																		if ((nint)obj99 != 126)
																																																																																																																																		{
																																																																																																																																			flush2 = (FlushType)num9;
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			bitb = num5;
																																																																																																																																			bitk = num6;
																																																																																																																																			ZlibCodec codec16 = _codec;
																																																																																																																																			codec16.AvailableBytesIn = num13;
																																																																																																																																			ZlibCodec codec17 = _codec;
																																																																																																																																			ZlibCodec codec18 = _codec;
																																																																																																																																			object obj100 = num12 - codec18.NextIn;
																																																																																																																																			long totalBytesIn2 = obj100 + codec17.TotalBytesIn;
																																																																																																																																			codec17.TotalBytesIn = totalBytesIn2;
																																																																																																																																			ZlibCodec codec19 = _codec;
																																																																																																																																			codec19.NextIn = num12;
																																																																																																																																			writeAt = num2;
																																																																																																																																			flush = -2;
																																																																																																																																			flush2 = (FlushType)num9;
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		bitb = num5;
																																																																																																																																		bitk = num6;
																																																																																																																																		ZlibCodec codec20 = _codec;
																																																																																																																																		codec20.AvailableBytesIn = num13;
																																																																																																																																		ZlibCodec codec21 = _codec;
																																																																																																																																		ZlibCodec codec22 = _codec;
																																																																																																																																		object obj101 = num12 - codec22.NextIn;
																																																																																																																																		long totalBytesIn3 = obj101 + codec21.TotalBytesIn;
																																																																																																																																		codec21.TotalBytesIn = totalBytesIn3;
																																																																																																																																		ZlibCodec codec23 = _codec;
																																																																																																																																		codec23.NextIn = num12;
																																																																																																																																		writeAt = num2;
																																																																																																																																		flush = -3;
																																																																																																																																		flush2 = (FlushType)num9;
																																																																																																																																	}
																																																																																																																																}
																																																																																																																															}
																																																																																																																														}
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										mode = InflateBlockMode.DRY;
																																																																																																																										obj5 = 133;
																																																																																																																										num53 = num113;
																																																																																																																										num54 = num116;
																																																																																																																										num55 = nextIn;
																																																																																																																										num56 = num114;
																																																																																																																										num57 = num115;
																																																																																																																										flush2 = FlushType.None;
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
																																																																																																																else
																																																																																																																{
																																																																																																																	object obj102 = this + 24;
																																																																																																																	obj102 = 0;
																																																																																																																	mode = InflateBlockMode.BAD;
																																																																																																																	flag9 = true;
																																																																																																																	obj5 = 124;
																																																																																																																	flush2 = (FlushType)num9;
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																									else
																																																																																																									{
																																																																																																										object obj103 = this + 24;
																																																																																																										obj103 = 0;
																																																																																																										mode = InflateBlockMode.BAD;
																																																																																																										object obj104 = _codec + 56;
																																																																																																										obj104 = "invalid bit length repeat";
																																																																																																										bitb = num100;
																																																																																																										bitk = num98;
																																																																																																										ZlibCodec codec24 = _codec;
																																																																																																										codec24.AvailableBytesIn = num139;
																																																																																																										ZlibCodec codec25 = _codec;
																																																																																																										ZlibCodec codec26 = _codec;
																																																																																																										object obj105 = num140 - codec26.NextIn;
																																																																																																										long totalBytesIn4 = obj105 + codec25.TotalBytesIn;
																																																																																																										codec25.TotalBytesIn = totalBytesIn4;
																																																																																																										ZlibCodec codec27 = _codec;
																																																																																																										codec27.NextIn = num140;
																																																																																																										writeAt = num2;
																																																																																																										flush = -3;
																																																																																																										flush2 = (FlushType)num9;
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			bitb = num137;
																																																																																																			bitk = num136;
																																																																																																			ZlibCodec codec28 = _codec;
																																																																																																			codec28.AvailableBytesIn = 0;
																																																																																																			ZlibCodec codec29 = _codec;
																																																																																																			ZlibCodec codec30 = _codec;
																																																																																																			object obj106 = num140 - codec30.NextIn;
																																																																																																			long totalBytesIn5 = obj106 + codec29.TotalBytesIn;
																																																																																																			codec29.TotalBytesIn = totalBytesIn5;
																																																																																																			ZlibCodec codec31 = _codec;
																																																																																																			codec31.NextIn = num140;
																																																																																																			writeAt = num2;
																																																																																																			flush = num138;
																																																																																																			flush2 = (FlushType)num9;
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
																																																																																					else
																																																																																					{
																																																																																						bitb = num123;
																																																																																						bitk = num122;
																																																																																						ZlibCodec codec32 = _codec;
																																																																																						codec32.AvailableBytesIn = 0;
																																																																																						ZlibCodec codec33 = _codec;
																																																																																						ZlibCodec codec34 = _codec;
																																																																																						object obj107 = num121 - codec34.NextIn;
																																																																																						long totalBytesIn6 = obj107 + codec33.TotalBytesIn;
																																																																																						codec33.TotalBytesIn = totalBytesIn6;
																																																																																						ZlibCodec codec35 = _codec;
																																																																																						codec35.NextIn = num121;
																																																																																						writeAt = num2;
																																																																																						flush = num124;
																																																																																						flush2 = (FlushType)num9;
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																													else
																																																																													{
																																																																														object obj108 = this + 24;
																																																																														obj108 = 0;
																																																																														mode = InflateBlockMode.BAD;
																																																																														enumerator2 = (IEnumerator)(-3);
																																																																														obj5 = 89;
																																																																														flush2 = (FlushType)num9;
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
																																																														}
																																																														else
																																																														{
																																																															bitb = num172;
																																																															bitk = num171;
																																																															ZlibCodec codec36 = _codec;
																																																															codec36.AvailableBytesIn = 0;
																																																															ZlibCodec codec37 = _codec;
																																																															ZlibCodec codec38 = _codec;
																																																															object obj109 = num170 - codec38.NextIn;
																																																															long totalBytesIn7 = obj109 + codec37.TotalBytesIn;
																																																															codec37.TotalBytesIn = totalBytesIn7;
																																																															ZlibCodec codec39 = _codec;
																																																															codec39.NextIn = num170;
																																																															writeAt = num2;
																																																															flush = num173;
																																																															flush2 = (FlushType)num9;
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
																																																					else
																																																					{
																																																						mode = InflateBlockMode.BAD;
																																																						object obj110 = _codec + 56;
																																																						obj110 = "too many length or distance symbols";
																																																						bitb = num60;
																																																						bitk = num59;
																																																						ZlibCodec codec40 = _codec;
																																																						codec40.AvailableBytesIn = num62;
																																																						ZlibCodec codec41 = _codec;
																																																						ZlibCodec codec42 = _codec;
																																																						object obj111 = num58 - codec42.NextIn;
																																																						long totalBytesIn8 = obj111 + codec41.TotalBytesIn;
																																																						codec41.TotalBytesIn = totalBytesIn8;
																																																						ZlibCodec codec43 = _codec;
																																																						codec43.NextIn = num58;
																																																						writeAt = num2;
																																																						flush = -3;
																																																						flush2 = (FlushType)num9;
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																	else
																																																	{
																																																		bitb = num60;
																																																		bitk = num59;
																																																		ZlibCodec codec44 = _codec;
																																																		codec44.AvailableBytesIn = 0;
																																																		ZlibCodec codec45 = _codec;
																																																		ZlibCodec codec46 = _codec;
																																																		object obj112 = num58 - codec46.NextIn;
																																																		long totalBytesIn9 = obj112 + codec45.TotalBytesIn;
																																																		codec45.TotalBytesIn = totalBytesIn9;
																																																		ZlibCodec codec47 = _codec;
																																																		codec47.NextIn = num58;
																																																		writeAt = num2;
																																																		flush = num61;
																																																		flush2 = (FlushType)num9;
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																											else
																																											{
																																												bitb = num5;
																																												bitk = num6;
																																												ZlibCodec codec48 = _codec;
																																												codec48.AvailableBytesIn = num13;
																																												ZlibCodec codec49 = _codec;
																																												ZlibCodec codec50 = _codec;
																																												object obj113 = num12 - codec50.NextIn;
																																												long totalBytesIn10 = obj113 + codec49.TotalBytesIn;
																																												codec49.TotalBytesIn = totalBytesIn10;
																																												ZlibCodec codec51 = _codec;
																																												codec51.NextIn = num12;
																																												writeAt = num78;
																																												flush = num81;
																																												flush2 = (FlushType)num9;
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
																												}
																											}
																										}
																										else
																										{
																											bitb = num5;
																											bitk = num6;
																											ZlibCodec codec52 = _codec;
																											codec52.AvailableBytesIn = 0;
																											ZlibCodec codec53 = _codec;
																											ZlibCodec codec54 = _codec;
																											object obj114 = num12 - codec54.NextIn;
																											long totalBytesIn11 = obj114 + codec53.TotalBytesIn;
																											codec53.TotalBytesIn = totalBytesIn11;
																											ZlibCodec codec55 = _codec;
																											codec55.NextIn = num12;
																											writeAt = num2;
																											flush = num9;
																											flush2 = (FlushType)num9;
																										}
																									}
																								}
																							}
																						}
																					}
																					else
																					{
																						mode = InflateBlockMode.BAD;
																						object obj115 = _codec + 56;
																						obj115 = "invalid stored block lengths";
																						bitb = num85;
																						bitk = num84;
																						ZlibCodec codec56 = _codec;
																						codec56.AvailableBytesIn = num82;
																						ZlibCodec codec57 = _codec;
																						ZlibCodec codec58 = _codec;
																						object obj116 = num83 - codec58.NextIn;
																						long totalBytesIn12 = obj116 + codec57.TotalBytesIn;
																						codec57.TotalBytesIn = totalBytesIn12;
																						ZlibCodec codec59 = _codec;
																						codec59.NextIn = num83;
																						writeAt = num2;
																						flush = -3;
																						flush2 = (FlushType)num9;
																					}
																				}
																			}
																		}
																		else
																		{
																			bitb = num85;
																			bitk = num84;
																			ZlibCodec codec60 = _codec;
																			codec60.AvailableBytesIn = 0;
																			ZlibCodec codec61 = _codec;
																			ZlibCodec codec62 = _codec;
																			object obj117 = num83 - codec62.NextIn;
																			long totalBytesIn13 = obj117 + codec61.TotalBytesIn;
																			codec61.TotalBytesIn = totalBytesIn13;
																			ZlibCodec codec63 = _codec;
																			codec63.NextIn = num83;
																			writeAt = num2;
																			flush = num86;
																			flush2 = (FlushType)num9;
																		}
																	}
																}
															}
															else
															{
																mode = InflateBlockMode.BAD;
																object obj118 = _codec + 56;
																obj118 = "invalid block type";
																int num192 = num17 >> 3;
																bitb = num192;
																int num193 = num16 - 3;
																bitk = num193;
																ZlibCodec codec64 = _codec;
																codec64.AvailableBytesIn = num14;
																ZlibCodec codec65 = _codec;
																ZlibCodec codec66 = _codec;
																object obj119 = num15 - codec66.NextIn;
																long totalBytesIn14 = obj119 + codec65.TotalBytesIn;
																codec65.TotalBytesIn = totalBytesIn14;
																ZlibCodec codec67 = _codec;
																codec67.NextIn = num15;
																writeAt = num2;
																flush = -3;
																flush2 = (FlushType)num9;
															}
														}
													}
												}
											}
										}
									}
								}
							}
							else
							{
								flush2 = (FlushType)num9;
							}
						}
					}
				}
				else
				{
					bitb = num17;
					bitk = num16;
					ZlibCodec codec68 = _codec;
					codec68.AvailableBytesIn = 0;
					ZlibCodec codec69 = _codec;
					ZlibCodec codec70 = _codec;
					object obj120 = num15 - codec70.NextIn;
					long totalBytesIn15 = obj120 + codec69.TotalBytesIn;
					codec69.TotalBytesIn = totalBytesIn15;
					ZlibCodec codec71 = _codec;
					codec71.NextIn = num15;
					writeAt = num2;
					flush = num18;
					flush2 = (FlushType)num9;
				}
				if ((nint)obj5 == 89)
				{
					bitb = num40;
					bitk = num39;
					ZlibCodec codec72 = _codec;
					codec72.AvailableBytesIn = num37;
					ZlibCodec codec73 = _codec;
					ZlibCodec codec74 = _codec;
					object obj121 = num38 - codec74.NextIn;
					long totalBytesIn16 = obj121 + codec73.TotalBytesIn;
					codec73.TotalBytesIn = totalBytesIn16;
					ZlibCodec codec75 = _codec;
					codec75.NextIn = num38;
					writeAt = num2;
					flush = (int)enumerator2;
				}
				else if ((nint)obj5 == 124)
				{
					bitb = num44;
					bitk = num43;
					ZlibCodec codec76 = _codec;
					codec76.AvailableBytesIn = num42;
					ZlibCodec codec77 = _codec;
					ZlibCodec codec78 = _codec;
					object obj122 = num117 - codec78.NextIn;
					long totalBytesIn17 = obj122 + codec77.TotalBytesIn;
					codec77.TotalBytesIn = totalBytesIn17;
					ZlibCodec codec79 = _codec;
					codec79.NextIn = num117;
					writeAt = num2;
					flush = (flag9 ? 1 : 0);
				}
				else if ((nint)obj5 == 133)
				{
					writeAt = num53;
					int num194 = ((InflateManager)this).Inflate(flush2);
					if (writeAt < readAt)
					{
					}
					if (readAt == writeAt)
					{
						mode = InflateBlockMode.DONE;
						num49 = writeAt;
						availableBytesIn2 = num54;
						num50 = num55;
						num51 = num56;
						num52 = num57;
						obj5 = 139;
					}
					else
					{
						bitb = num57;
						bitk = num56;
						ZlibCodec codec80 = _codec;
						codec80.AvailableBytesIn = num54;
						ZlibCodec codec81 = _codec;
						ZlibCodec codec82 = _codec;
						object obj123 = num55 - codec82.NextIn;
						long totalBytesIn18 = obj123 + codec81.TotalBytesIn;
						codec81.TotalBytesIn = totalBytesIn18;
						ZlibCodec codec83 = _codec;
						codec83.NextIn = num55;
						writeAt = writeAt;
						flush = num194;
					}
				}
				if ((nint)obj5 == 139)
				{
					bitb = num52;
					bitk = num51;
					ZlibCodec codec84 = _codec;
					codec84.AvailableBytesIn = availableBytesIn2;
					ZlibCodec codec85 = _codec;
					ZlibCodec codec86 = _codec;
					object obj124 = num50 - codec86.NextIn;
					long totalBytesIn19 = obj124 + codec85.TotalBytesIn;
					codec85.TotalBytesIn = totalBytesIn19;
					ZlibCodec codec87 = _codec;
					codec87.NextIn = num50;
					writeAt = num49;
					flush = 1;
				}
				return ((InflateManager)this).Inflate((FlushType)flush);
				IL_0c90:
				obj5 = 73;
				goto IL_173c;
			}
			num3 = num110;
			num7 = 0;
			num8 = num109;
		}
	}

	static InflateBlocks()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_004d: Expected VT, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC8A");
		obj2 = obj;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		GZipStream._unixEpoch = (DateTime)obj3;
		byte[] preamble = ((Encoding)(object)"iso-8859-1").GetPreamble();
		nint num = (nint)typeof(GZipStream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v18 (Il2CppClass<Ionic.Zlib.GZipStream>)+5C]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = preamble;
	}
}
