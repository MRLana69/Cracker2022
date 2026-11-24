using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Ionic.Zlib;

internal sealed class InfTree
{
	private const int MANY = 1440;

	private const int Z_OK = 0;

	private const int Z_STREAM_END = 1;

	private const int Z_NEED_DICT = 2;

	private const int Z_ERRNO = -1;

	private const int Z_STREAM_ERROR = -2;

	private const int Z_DATA_ERROR = -3;

	private const int Z_MEM_ERROR = -4;

	private const int Z_BUF_ERROR = -5;

	private const int Z_VERSION_ERROR = -6;

	internal const int fixed_bl = 9;

	internal const int fixed_bd = 5;

	internal static readonly int[] fixed_tl;

	internal static readonly int[] fixed_td;

	internal static readonly int[] cplens;

	internal static readonly int[] cplext;

	internal static readonly int[] cpdist;

	internal static readonly int[] cpdext;

	internal const int BMAX = 15;

	internal int[] hn;

	internal int[] v;

	internal int[] c;

	internal int[] r;

	internal int[] u;

	internal int[] x;

	private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0;
	}

	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
	{
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I4
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_042e: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I
		//IL_001d: Expected I4, but got Obj
		//IL_04dc: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_03a9: Expected I4, but got Obj
		//IL_035d: Expected I, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_01eb: Expected I, but got Obj
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_052d: Expected Obj, but got I
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected I4, but got Unknown
		object obj = this + 12;
		obj = c;
		object obj2 = v + 56;
		obj2 = 0;
		object obj3 = tb + -9;
		if ((nint)obj3 > 6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"windowBits must be in the range 9..15." != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if ((nint)hp > 0)
		{
			nint num = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v44 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v96 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DeflateManager.MEM_LEVEL_MAX >= (nint)hp)
			{
				object obj5 = v + 60;
				obj5 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+2C]");
				object obj6 = (nint)0 & (nint)0x1F;
				object obj7 = 1 << (int)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+28]");
				object obj8 = -1;
				object obj9 = hp + 7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+4C]");
				object obj10 = (nint)0 & (nint)0x1F;
				object obj11 = 1 << (int)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+48]");
				object obj12 = -1;
				nint num3 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v64 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num4 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v90 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int mIN_MATCH = DeflateManager.MIN_MATCH;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+4C]");
				object obj14 = (nint)mIN_MATCH + (nint)0;
				object obj15 = obj14 - 1;
				if (DeflateManager.MIN_MATCH != 0)
				{
					bool flag = (nint)obj15 == int.MinValue;
					bool flag2 = DeflateManager.MIN_MATCH == -1;
					object obj16 = flag & flag2;
					if (obj16 != null)
					{
						int num5 = 0;
					}
					else
					{
						int num5 = obj15 / DeflateManager.MIN_MATCH;
					}
				}
				else
				{
					int num5 = 0;
				}
				object obj17 = this + 52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+28]");
				object obj18 = (nint)0 << 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj19 = default;
				obj17 = obj19;
				object obj20 = this + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj21 = default;
				obj20 = obj21;
				object obj22 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj23 = default;
				obj22 = obj23;
				object obj24 = hp + 6;
				object obj25 = obj24 & 0x1F;
				object obj26 = 1 << (int)obj25;
				object obj27 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+B4]");
				object obj28 = (nint)0 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj29 = default;
				obj27 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+B4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InfTree)+B4]");
				object obj30 = (nint)0 * (nint)3;
				((DeflateManager)this).SetDeflater();
				return 0;
			}
		}
		nint num6 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v21 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num7 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj32 = DeflateManager.MEM_LEVEL_MAX;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"memLevel must be in the range 1.. {args}";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream2 = default;
		zlibBaseStream2.Dispose((byte)(int)text != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0;
	}

	internal unsafe int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
	{
		//IL_1843: Unknown result type (might be due to invalid IL or missing references)
		//IL_1848: Expected VT, but got Unknown
		//IL_1851: Unknown result type (might be due to invalid IL or missing references)
		//IL_1856: Expected Obj, but got Unknown
		//IL_185f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1864: Expected Obj, but got Unknown
		//IL_186d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Expected Obj, but got Unknown
		//IL_187b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1880: Expected Obj, but got Unknown
		//IL_1889: Unknown result type (might be due to invalid IL or missing references)
		//IL_188e: Expected Obj, but got Unknown
		//IL_1897: Expected Obj, but got I4
		//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ab: Expected Obj, but got Unknown
		//IL_18b4: Expected Obj, but got I4
		//IL_18cd: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_195f: Expected Obj, but got I4
		//IL_067a: Expected Obj, but got I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_1a83: Expected Obj, but got I4
		//IL_0daf: Expected Obj, but got I4
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected Obj, but got Unknown
		//IL_1b82: Expected Obj, but got I4
		//IL_0f35: Expected Obj, but got I4
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected Obj, but got Unknown
		//IL_1c2c: Expected Obj, but got I4
		//IL_1c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Expected Obj, but got Unknown
		//IL_1c83: Expected Obj, but got I4
		//IL_1b41: Expected Obj, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I4
		//IL_12a5: Expected Obj, but got I4
		//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c1: Expected Obj, but got Unknown
		//IL_1110: Expected Obj, but got I4
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected Obj, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_156a: Expected Obj, but got I4
		//IL_1bb4: Expected Obj, but got I4
		//IL_0b91: Expected Obj, but got I4
		//IL_0bb2: Expected Obj, but got I4
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_15b4: Expected Obj, but got I4
		//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d0: Expected Obj, but got Unknown
		//IL_12f7: Expected I, but got Obj
		//IL_130d: Expected Obj, but got I
		//IL_1167: Expected Obj, but got I4
		//IL_117e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected Obj, but got Unknown
		//IL_0bd3: Expected I, but got Obj
		//IL_0be9: Expected Obj, but got I
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_1cfa: Expected F4, but got Obj
		//IL_1cf5: Expected native int or pointer, but got VT
		//IL_1d0c: Expected F4, but got I4
		//IL_1d07: Expected native int or pointer, but got VT
		//IL_0ee6: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got I4
		//IL_054f: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I4
		//IL_1606: Expected I, but got Obj
		//IL_161c: Expected Obj, but got I
		//IL_1391: Expected I4, but got Obj
		//IL_1338: Expected I, but got Obj
		//IL_11be: Expected Obj, but got I4
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da: Expected Obj, but got Unknown
		//IL_0c14: Expected I, but got Obj
		//IL_0ae2: Expected Obj, but got I4
		//IL_0aab: Expected Obj, but got I4
		//IL_0b19: Expected Obj, but got I4
		//IL_05f4: Expected Obj, but got I4
		//IL_0586: Expected Obj, but got I4
		//IL_1e86: Expected Obj, but got I4
		//IL_1eb3: Expected F4, but got Obj
		//IL_1eae: Expected native int or pointer, but got VT
		//IL_1ec5: Expected F4, but got I4
		//IL_1ec0: Expected native int or pointer, but got VT
		//IL_1ece: Expected I4, but got VT
		//IL_1beb: Expected Obj, but got I4
		//IL_0c61: Expected I, but got Obj
		//IL_0c77: Expected Obj, but got I
		//IL_0b50: Expected Obj, but got I4
		//IL_16a0: Expected I4, but got Obj
		//IL_16a0: Expected Obj, but got I4
		//IL_1647: Expected I, but got Obj
		//IL_1224: Expected Obj, but got I4
		//IL_19f0: Expected Obj, but got I4
		//IL_0ca2: Expected I, but got Obj
		//IL_125f: Expected I4, but got Obj
		//IL_0cea: Expected I4, but got Obj
		//IL_0cf7: Expected I4, but got Obj
		//IL_0d0e: Expected I, but got Obj
		//IL_0d24: Expected Obj, but got I
		//IL_1f0f: Expected F4, but got Obj
		//IL_1f0a: Expected native int or pointer, but got VT
		//IL_1f24: Expected F4, but got I
		//IL_1f1f: Expected native int or pointer, but got VT
		//IL_1f31: Expected Obj, but got I4
		//IL_1417: Expected Obj, but got I
		//IL_1427: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Expected Obj, but got Unknown
		//IL_1439: Expected F4, but got Obj
		//IL_1434: Expected native int or pointer, but got VT
		//IL_144e: Expected F4, but got I
		//IL_1449: Expected native int or pointer, but got VT
		//IL_0d4f: Expected I, but got Obj
		//IL_171b: Expected F4, but got Obj
		//IL_1716: Expected native int or pointer, but got VT
		//IL_1730: Expected F4, but got I
		//IL_172b: Expected native int or pointer, but got VT
		//IL_1d7f: Expected F4, but got Obj
		//IL_1d7a: Expected native int or pointer, but got VT
		//IL_1d94: Expected F4, but got I
		//IL_1d8f: Expected native int or pointer, but got VT
		//IL_1da1: Expected Obj, but got I4
		//IL_1482: Expected F4, but got Obj
		//IL_147d: Expected native int or pointer, but got VT
		//IL_1497: Expected F4, but got I
		//IL_1492: Expected native int or pointer, but got VT
		//IL_1760: Expected I, but got Obj
		//IL_1776: Expected Obj, but got I
		//IL_1793: Expected I, but got Obj
		//IL_1f4c: Expected Obj, but got I
		//IL_1fb5: Expected F4, but got Obj
		//IL_1fb0: Expected native int or pointer, but got VT
		//IL_1fca: Expected F4, but got I
		//IL_1fc5: Expected native int or pointer, but got VT
		//IL_1fe7: Expected F4, but got I
		//IL_1fe7: Expected I4, but got VT
		//IL_1fe7: Expected I4, but got Obj
		//IL_1fe7: Expected Ref, but got VT
		//IL_1ff4: Expected Obj, but got F4
		//IL_14c7: Expected I, but got Obj
		//IL_14dd: Expected Obj, but got I
		//IL_14fa: Expected I, but got Obj
		//IL_17af: Expected I, but got Obj
		//IL_17bd: Expected I, but got Obj
		//IL_1dbc: Expected Obj, but got I
		//IL_1e25: Expected F4, but got Obj
		//IL_1e20: Expected native int or pointer, but got VT
		//IL_1e3a: Expected F4, but got I
		//IL_1e35: Expected native int or pointer, but got VT
		//IL_1e57: Expected F4, but got I
		//IL_1e57: Expected I4, but got VT
		//IL_1e57: Expected I4, but got Obj
		//IL_1e57: Expected Ref, but got VT
		//IL_1e64: Expected Obj, but got F4
		//IL_1516: Expected I, but got Obj
		//IL_1524: Expected I, but got Obj
		//IL_17eb: Expected I, but got Obj
		//IL_1552: Expected I, but got Obj
		Matrix4x4 matrix4x = default;
		Color color = (Color)(matrix4x + 112);
		string text = (string)(matrix4x + 96);
		object obj = matrix4x + 48;
		object obj2 = matrix4x + 32;
		object obj3 = matrix4x + 16;
		object obj4 = matrix4x + 80;
		obj4 = 0;
		_ = 0;
		object obj5 = matrix4x - -64;
		obj5 = 0;
		_ = 0;
		object obj6 = ((int*)nl)->m_value + 3;
		int[] array = hn;
		int result;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<int[], UIntPtr>(ref array))
		{
			result = 0;
		}
		else
		{
			string[] array2 = ((string)this).Split((char[])((int*)nl)->m_value);
			object obj7 = array2 & 0xFFFF;
			if ((nint)obj7 == 91)
			{
				char[] separator = (char[])(((int*)nl)->m_value + 2);
				string[] array3 = ((string)this).Split(separator);
				object obj8 = array3 & 0xFFFF;
				if ((nint)obj8 == 93)
				{
					char[] separator2 = (char[])(((int*)nl)->m_value + 1);
					string[] array4 = ((string)this).Split(separator2);
					object obj9 = array4 & 0xFFFF;
					if ((nint)obj9 == 45)
					{
						if (nd != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nd @ L2 (System.Int32)+C]");
							if ((nint)0 >= (nint)2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nd @ L2 (System.Int32)+C]");
								int index = (int)(-1);
								((BetterList<Color>)nd).RemoveAt(index);
							}
						}
						int value = ((int*)nl)->m_value + 3;
						((int*)nl)->m_value = value;
						result = 1;
						goto IL_19b5;
					}
					string text2 = ((string)this).InternalSubString(((int*)nl)->m_value, 3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C9E1");
					object obj10 = default;
					if ((nint)obj10 < 2063584547)
					{
						if ((nint)obj10 < 1993767120)
						{
							if ((nint)obj10 < 1993767119)
							{
								object obj11 = obj10 - 1992236928;
								if (obj11 == null && !(text2 == "[u]"))
								{
									goto IL_05b4;
								}
							}
							else
							{
								object obj12 = obj10 - 1993767119;
								if (obj12 == null && !(text2 == "[b]"))
								{
									goto IL_0546;
								}
							}
						}
						else if ((nint)obj10 < 2061024690)
						{
							object obj13 = obj10 - 1998151356;
							if (obj13 == null && !(text2 == "[I]"))
							{
								goto IL_057d;
							}
						}
						else if ((nint)obj10 < 2063584546)
						{
							object obj14 = obj10 - 2061024690;
							if (obj14 == null && !(text2 == "[c]"))
							{
								goto IL_0622;
							}
						}
						else
						{
							object obj15 = obj10 - 2063584546;
							if (obj15 == null && !(text2 == "[S]"))
							{
								goto IL_05eb;
							}
						}
					}
					else if ((nint)obj10 < -1223739871)
					{
						if ((nint)obj10 < -1223739872)
						{
							object obj16 = obj10 - -1228271204;
							if (obj16 == null && !(text2 == "[i]"))
							{
								goto IL_057d;
							}
						}
						else
						{
							object obj17 = obj10 - -1223739872;
							if (obj17 == null && !(text2 == "[U]"))
							{
								goto IL_05b4;
							}
						}
					}
					else if ((nint)obj10 < -1162838014)
					{
						object obj18 = obj10 - -1222312849;
						if (obj18 == null && !(text2 == "[B]"))
						{
							goto IL_0546;
						}
					}
					else if ((nint)obj10 < -1155055278)
					{
						object obj19 = obj10 - -1162838014;
						if (obj19 == null && !(text2 == "[s]"))
						{
							goto IL_05eb;
						}
					}
					else
					{
						object obj20 = obj10 - -1155055278;
						if (obj20 == null && !(text2 == "[C]"))
						{
							goto IL_0622;
						}
					}
				}
				object obj21 = ((int*)nl)->m_value + 4;
				int[] array5 = hn;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) > System.Runtime.CompilerServices.Unsafe.As<int[], UIntPtr>(ref array5))
				{
					result = 0;
				}
				else
				{
					char[] separator3 = (char[])(((int*)nl)->m_value + 3);
					string[] array6 = ((string)this).Split(separator3);
					object obj22 = array6 & 0xFFFF;
					if ((nint)obj22 == 93)
					{
						string text3 = ((string)this).InternalSubString(((int*)nl)->m_value, 4);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C9E1");
						object obj23 = default;
						if ((nint)obj23 < 629802538)
						{
							if ((nint)obj23 < 560426396)
							{
								if ((nint)obj23 < 560426395)
								{
									object obj24 = obj23 - 557763371;
									if (obj24 == null && !(text3 == "[/S]"))
									{
										goto IL_0b10;
									}
								}
								else
								{
									object obj25 = obj23 - 560426395;
									if (obj25 == null && !(text3 == "[/c]"))
									{
										goto IL_0b47;
									}
								}
							}
							else if ((nint)obj23 < 627683966)
							{
								object obj26 = obj23 - 626551133;
								if (obj26 == null && !(text3 == "[/i]"))
								{
									goto IL_0aa2;
								}
							}
							else if ((nint)obj23 < 629802537)
							{
								object obj27 = obj23 - 627683966;
								if (obj27 == null && text3 != "[/b]")
								{
									goto IL_19e7;
								}
							}
							else
							{
								object obj28 = obj23 - 629802537;
								if (obj28 == null && !(text3 == "[/u]"))
								{
									goto IL_0ad9;
								}
							}
						}
						else if ((nint)obj23 < 1636753868)
						{
							if ((nint)obj23 < 1636753867)
							{
								object obj29 = obj23 - 1628971131;
								if (obj29 == null && !(text3 == "[/C]"))
								{
									goto IL_0b47;
								}
							}
							else
							{
								object obj30 = obj23 - 1636753867;
								if (obj30 == null && !(text3 == "[/s]"))
								{
									goto IL_0b10;
								}
							}
						}
						else if ((nint)obj23 < 1696228702)
						{
							object obj31 = obj23 - 1695095869;
							if (obj31 == null && !(text3 == "[/I]"))
							{
								goto IL_0aa2;
							}
						}
						else if ((nint)obj23 < 1698347273)
						{
							object obj32 = obj23 - 1696228702;
							if (obj32 == null && text3 != "[/B]")
							{
								goto IL_19e7;
							}
						}
						else
						{
							object obj33 = obj23 - 1698347273;
							if (obj33 == null && !(text3 == "[/U]"))
							{
								goto IL_0ad9;
							}
						}
						char[] separator4 = (char[])(((int*)nl)->m_value + 1);
						string[] array7 = ((string)this).Split(separator4);
						char[] separator5 = (char[])(((int*)nl)->m_value + 2);
						string[] array8 = ((string)this).Split(separator5);
						nint num = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ S0_v302 (Il2CppClass<NGUIText>)+BA]");
						object obj34 = (nint)0 & (nint)0x200;
						if (obj34 != null)
						{
							nint num2 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v340 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text4 = NGUIText.StripSymbols((string)(object)array7);
						if (text4 != null)
						{
							nint num3 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ S0_v310 (Il2CppClass<NGUIText>)+BA]");
							object obj35 = (nint)0 & (nint)0x200;
							if (obj35 != null)
							{
								nint num4 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ S0_v336 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text5 = NGUIText.StripSymbols((string)(object)array8);
							if (text5 != null)
							{
								char c2 = NGUIMath.DecimalToHexChar((int)array7);
								char c3 = NGUIMath.DecimalToHexChar((int)array8);
								nint num5 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ S0_v322 (Il2CppClass<NGUIText>)+BA]");
								object obj36 = (nint)0 & (nint)0x200;
								if (obj36 != null)
								{
									nint num6 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ S0_v330 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int num7 = (int)((uint)c2 << 4);
								int num8 = num7 | c3;
								float mAlpha = (float)num8 / 255f;
								NGUIText.mAlpha = mAlpha;
								int value2 = ((int*)nl)->m_value + 4;
								((int*)nl)->m_value = value2;
								result = 1;
								goto IL_19b5;
							}
						}
					}
					object obj37 = ((int*)nl)->m_value + 5;
					int[] array9 = hn;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37) > System.Runtime.CompilerServices.Unsafe.As<int[], UIntPtr>(ref array9))
					{
						result = 0;
					}
					else
					{
						char[] separator6 = (char[])(((int*)nl)->m_value + 4);
						string[] array10 = ((string)this).Split(separator6);
						object obj38 = array10 & 0xFFFF;
						if ((nint)obj38 != 93)
						{
							goto IL_1b6f;
						}
						string text6 = ((string)this).InternalSubString(((int*)nl)->m_value, 5);
						if (!(text6 != "[sub]") && !(text6 != "[SUB]"))
						{
							if (!(text6 != "[sup]") && !(text6 != "[SUP]"))
							{
								goto IL_1b6f;
							}
							int[] array11 = (int[])2;
							int value3 = ((int*)nl)->m_value + 5;
							((int*)nl)->m_value = value3;
							result = 1;
						}
						else
						{
							int[] array11 = (int[])1;
							int value4 = ((int*)nl)->m_value + 5;
							((int*)nl)->m_value = value4;
							result = 1;
						}
					}
				}
			}
			else
			{
				result = 0;
			}
		}
		goto IL_19b5;
		IL_19e7:
		int[] array12 = (int[])0;
		int value5 = ((int*)nl)->m_value + 4;
		((int*)nl)->m_value = value5;
		result = 1;
		goto IL_19b5;
		IL_05eb:
		int[] array13 = (int[])1;
		int value6 = ((int*)nl)->m_value + 3;
		((int*)nl)->m_value = value6;
		result = 1;
		goto IL_19b5;
		IL_0b10:
		array13 = (int[])0;
		int value7 = ((int*)nl)->m_value + 4;
		((int*)nl)->m_value = value7;
		result = 1;
		goto IL_19b5;
		IL_05b4:
		int[] array14 = (int[])1;
		int value8 = ((int*)nl)->m_value + 3;
		((int*)nl)->m_value = value8;
		result = 1;
		goto IL_19b5;
		IL_0622:
		ZlibCodec zlibCodec = (ZlibCodec)1;
		int value9 = ((int*)nl)->m_value + 3;
		((int*)nl)->m_value = value9;
		result = 1;
		goto IL_19b5;
		IL_0546:
		array12 = (int[])1;
		int value10 = ((int*)nl)->m_value + 3;
		((int*)nl)->m_value = value10;
		result = 1;
		goto IL_19b5;
		IL_0aa2:
		int[] array15 = (int[])0;
		int value11 = ((int*)nl)->m_value + 4;
		((int*)nl)->m_value = value11;
		result = 1;
		goto IL_19b5;
		IL_1b6f:
		object obj39 = ((int*)nl)->m_value + 6;
		int[] array16 = hn;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) > System.Runtime.CompilerServices.Unsafe.As<int[], UIntPtr>(ref array16))
		{
			result = 0;
		}
		else
		{
			char[] separator7 = (char[])(((int*)nl)->m_value + 5);
			string[] array17 = ((string)this).Split(separator7);
			object obj40 = array17 & 0xFFFF;
			if ((nint)obj40 != 93)
			{
				goto IL_1c19;
			}
			string text7 = ((string)this).InternalSubString(((int*)nl)->m_value, 6);
			if (!(text7 != "[/sub]") && !(text7 != "[/SUB]"))
			{
				if (!(text7 != "[/sup]") && !(text7 != "[/SUP]"))
				{
					if (!(text7 != "[/url]") && !(text7 != "[/URL]"))
					{
						goto IL_1c19;
					}
					int value12 = ((int*)nl)->m_value + 6;
					((int*)nl)->m_value = value12;
					result = 1;
				}
				else
				{
					int[] array11 = (int[])0;
					int value13 = ((int*)nl)->m_value + 6;
					((int*)nl)->m_value = value13;
					result = 1;
				}
			}
			else
			{
				int[] array11 = (int[])0;
				int value14 = ((int*)nl)->m_value + 6;
				((int*)nl)->m_value = value14;
				result = 1;
			}
		}
		goto IL_19b5;
		IL_0ad9:
		array14 = (int[])0;
		int value15 = ((int*)nl)->m_value + 4;
		((int*)nl)->m_value = value15;
		result = 1;
		goto IL_19b5;
		IL_057d:
		array15 = (int[])1;
		int value16 = ((int*)nl)->m_value + 3;
		((int*)nl)->m_value = value16;
		result = 1;
		goto IL_19b5;
		IL_0b47:
		zlibCodec = (ZlibCodec)0;
		int value17 = ((int*)nl)->m_value + 4;
		((int*)nl)->m_value = value17;
		result = 1;
		goto IL_19b5;
		IL_19b5:
		return result;
		IL_1c19:
		char[] separator8 = (char[])(((int*)nl)->m_value + 1);
		string[] array18 = ((string)this).Split(separator8);
		object obj41 = array18 & 0xFFFF;
		if ((nint)obj41 == 117)
		{
			char[] separator9 = (char[])(((int*)nl)->m_value + 2);
			string[] array19 = ((string)this).Split(separator9);
			object obj42 = array19 & 0xFFFF;
			if ((nint)obj42 == 114)
			{
				char[] separator10 = (char[])(((int*)nl)->m_value + 3);
				string[] array20 = ((string)this).Split(separator10);
				object obj43 = array20 & 0xFFFF;
				if ((nint)obj43 == 108)
				{
					char[] separator11 = (char[])(((int*)nl)->m_value + 4);
					string[] array21 = ((string)this).Split(separator11);
					object obj44 = array21 & 0xFFFF;
					if ((nint)obj44 == 61)
					{
						int startIndex = ((int*)nl)->m_value + 4;
						int num9 = ((string)this).IndexOfAny((char[])93, startIndex);
						if (num9 == -1)
						{
							((int*)nl)->m_value = (int)hn;
						}
						else
						{
							int value18 = num9 + 1;
							((int*)nl)->m_value = value18;
						}
						result = 1;
						goto IL_19b5;
					}
				}
			}
		}
		object obj45 = ((int*)nl)->m_value + 8;
		int[] array22 = hn;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) > System.Runtime.CompilerServices.Unsafe.As<int[], UIntPtr>(ref array22))
		{
			result = 0;
		}
		else
		{
			char[] separator12 = (char[])(((int*)nl)->m_value + 7);
			string[] array23 = ((string)this).Split(separator12);
			object obj46 = array23 & 0xFFFF;
			if ((nint)obj46 == 93)
			{
				nint num10 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S0_v152 (Il2CppClass<NGUIText>)+BA]");
				object obj47 = (nint)0 & (nint)0x200;
				if (obj47 != null)
				{
					nint num11 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S0_v211 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int offset = ((int*)nl)->m_value + 1;
				Color color2 = NGUIText.ParseColor32((string)(object)this, offset);
				obj4 = text;
				_ = text.m_stringLength;
				((Color*)(nint)color)->r = (float)text;
				((Color*)(nint)color)->b = text.m_stringLength;
				string text8 = NGUIText.EncodeColor32(color);
				int startIndex2 = ((int*)nl)->m_value + 1;
				string text9 = ((string)this).InternalSubString(startIndex2, 6);
				string text10 = text9.ToUpperInvariant();
				char c4 = text8.get_Chars((int)text10);
				result = 0;
				if (c4 == '\0')
				{
					if (nd != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nd @ L2 (System.Int32)+C]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nd @ L2 (System.Int32)+C]");
							object obj48 = (nint)0 << 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nd @ L2 (System.Int32)+8]");
							object obj49 = 0 + obj48;
							((Color*)(nint)color)->r = (float)obj49;
							Color color3 = color;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ S1_v154+8]");
							((Color*)(nint)color3)->b = 0f;
							_ = color.a;
							if (c != null)
							{
								((Color*)(nint)color)->r = (float)obj4;
								Color color4 = color;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
								((Color*)(nint)color4)->b = 0f;
								if (color.a != 1f)
								{
									nint num12 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v187 (Il2CppClass<NGUIText>)+BA]");
									object obj50 = (nint)0 & (nint)0x200;
									bool flag = obj50 == null;
									nint num13 = (nint)typeof(NGUIText);
									if (!flag)
									{
										nint num14 = (nint)typeof(NGUIText);
										num13 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ S0_v206 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											num13 = (nint)typeof(NGUIText);
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ L0_v16 (Il2CppClass<NGUIText>)+5C]");
									object obj51 = (nint)0 + (nint)144;
									obj = obj51;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ S1_v174+8]");
									_ = 0;
									obj2 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
									_ = 0;
									obj3 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
									_ = 0;
									text = (string)obj;
									string text11 = text;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
									text11.m_stringLength = 0;
									((Color*)(nint)color)->r = (float)obj2;
									Color color5 = color;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
									((Color*)(nint)color5)->b = 0f;
									Matrix4x4 matrix4x2 = matrix4x;
									string text12 = text;
									Color color6 = color;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+C]");
									((Matrix4x4*)matrix4x2)->set_Item((int)text12, (int)color6, 0f);
									obj4 = matrix4x.m00;
									_ = matrix4x.m20;
								}
							}
							((Color*)(nint)color)->r = (float)obj4;
							Color color7 = color;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
							((Color*)(nint)color7)->b = 0f;
							((BetterList<Color>)nd).Add(color);
						}
					}
					int value19 = ((int*)nl)->m_value + 8;
					((int*)nl)->m_value = value19;
					result = 1;
				}
			}
			else
			{
				object obj52 = ((int*)nl)->m_value + 10;
				int[] array24 = hn;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52) > System.Runtime.CompilerServices.Unsafe.As<int[], UIntPtr>(ref array24))
				{
					result = 0;
				}
				else
				{
					char[] separator13 = (char[])(((int*)nl)->m_value + 9);
					string[] array25 = ((string)this).Split(separator13);
					object obj53 = array25 & 0xFFFF;
					if ((nint)obj53 == 93)
					{
						nint num15 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ S0_v91 (Il2CppClass<NGUIText>)+BA]");
						object obj54 = (nint)0 & (nint)0x200;
						if (obj54 != null)
						{
							nint num16 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S0_v146 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						List<int> indices = (List<int>)(((int*)nl)->m_value + 1);
						NGUIText.PrintApproximateCharacterPositions(text, (List<Vector3>)(object)this, indices);
						obj5 = text;
						_ = text.m_stringLength;
						((Color*)(nint)color)->r = (float)text;
						((Color*)(nint)color)->b = text.m_stringLength;
						bool flag2 = NGUIText.IsHex((char)(int)color);
						int startIndex3 = ((int*)nl)->m_value + 1;
						string text13 = ((string)this).InternalSubString(startIndex3, 8);
						string text14 = text13.ToUpperInvariant();
						if (((string)flag2).get_Chars((int)text14) != '\0')
						{
							result = 0;
						}
						else
						{
							if (nd != 0)
							{
								if (c != null)
								{
									((Color*)(nint)color)->r = (float)obj5;
									Color color8 = color;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+8]");
									((Color*)(nint)color8)->b = 0f;
									if (color.a != 1f)
									{
										nint num17 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ S0_v121 (Il2CppClass<NGUIText>)+BA]");
										object obj55 = (nint)0 & (nint)0x200;
										bool flag3 = obj55 == null;
										nint num18 = (nint)typeof(NGUIText);
										if (!flag3)
										{
											nint num19 = (nint)typeof(NGUIText);
											num18 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ S0_v140 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												num18 = (nint)typeof(NGUIText);
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1298 @ L0_v8 (Il2CppClass<NGUIText>)+5C]");
										object obj56 = (nint)0 + (nint)144;
										obj = obj56;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ S1_v109+8]");
										_ = 0;
										obj2 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+8]");
										_ = 0;
										obj3 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+8]");
										_ = 0;
										text = (string)obj;
										string text15 = text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
										text15.m_stringLength = 0;
										((Color*)(nint)color)->r = (float)obj2;
										Color color9 = color;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
										((Color*)(nint)color9)->b = 0f;
										Matrix4x4 matrix4x3 = matrix4x;
										string text16 = text;
										Color color10 = color;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+C]");
										((Matrix4x4*)matrix4x3)->set_Item((int)text16, (int)color10, 0f);
										obj5 = matrix4x.m00;
										_ = matrix4x.m20;
									}
								}
								((Color*)(nint)color)->r = (float)obj5;
								Color color11 = color;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22+8]");
								((Color*)(nint)color11)->b = 0f;
								((BetterList<Color>)nd).Add(color);
							}
							int value20 = ((int*)nl)->m_value + 10;
							((int*)nl)->m_value = value20;
							result = 1;
						}
					}
					else
					{
						result = 0;
					}
				}
			}
		}
		goto IL_19b5;
	}

	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((InfTree)(object)bl).inflate_trees_bits(bd, (int[])(object)tl, (int[])(object)td, (int[])DeflateManager.MEM_LEVEL_DEFAULT, z);
		return 0;
	}

	private void initWorkArea(int vsize)
	{
		_ = 1;
		int num = vsize & 1;
	}

	public InfTree()
	{
		_ = 1;
	}

	static InfTree()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		byte[] array = default;
		object obj = array + 18;
		obj = -1;
		object obj2 = array + 19;
		obj2 = -1;
		InflateManager.mark = array;
	}
}
