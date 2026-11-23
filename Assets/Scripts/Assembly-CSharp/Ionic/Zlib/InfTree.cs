using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

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
		//IL_000d: Expected I, but got Obj
		//IL_0c29: Expected Obj, but got I
		//IL_0c5a: Expected Obj, but got I
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Expected Obj, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_106d: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0217: Expected I4, but got Obj
		//IL_0314: Expected Obj, but got I4
		//IL_031d: Expected Obj, but got I4
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Expected Obj, but got Unknown
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_046f: Expected Obj, but got I
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_08cd: Expected I4, but got Obj
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected I4, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04eb: Expected Obj, but got I4
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Obj, but got Unknown
		//IL_09e1: Expected Obj, but got I
		//IL_0a12: Expected Obj, but got I
		//IL_0a40: Expected I4, but got Obj
		//IL_0a58: Expected I4, but got Obj
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected Obj, but got Unknown
		//IL_0a7a: Expected Obj, but got I
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected Obj, but got Unknown
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected Obj, but got Unknown
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected Obj, but got Unknown
		//IL_0e84: Expected Obj, but got I4
		//IL_09b0: Expected Obj, but got I4
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0eb0: Expected I4, but got Obj
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected Obj, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_0b2d: Expected Obj, but got I4
		//IL_0b3b: Expected Obj, but got I4
		//IL_09c7: Expected Obj, but got I4
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected I4, but got Unknown
		//IL_074b: Expected I4, but got Obj
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_07bb: Expected Obj, but got I
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_07f4: Expected I4, but got Obj
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected I4, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0f94: Expected Obj, but got I4
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected Obj, but got Unknown
		//IL_0670: Expected Obj, but got I4
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected Obj, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		int num = n;
		nint num2 = unchecked((nint)null);
		int num3 = default;
		num = num3;
		IntPtr intPtr = default;
		num2 = intPtr;
		do
		{
			object obj = bindex + num2;
			object obj2 = obj << 2;
			object obj3 = (object)b + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v3+10]");
			object obj4 = (nint)0 << 2;
			object obj5 = (object)c + obj4;
			object obj6 = obj5 + 16;
			object obj7 = obj6 + 1;
			obj6 = obj7;
		}
		while (num - 1 != 0);
		int[] array = c;
		if (n == array[0])
		{
			t[0] = -1;
			m[0] = 0;
			return 0;
		}
		int num4 = 1;
		while (num4 <= 15)
		{
			int num5 = num4 << 2;
			object obj8 = c + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v242+10]");
			if ((nint)0 != 0)
			{
				break;
			}
			int num6 = num4 + 1;
			num4 = num6;
		}
		bool flag = m[0] < num4;
		int num7 = num4;
		if (!flag)
		{
			num7 = m[0];
		}
		int num8 = 15;
		while (num8 != 0)
		{
			int num9 = num8 << 2;
			object obj9 = c + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v235+10]");
			if ((nint)0 != 0)
			{
				break;
			}
			int num10 = num8 - 1;
			num8 = num10;
		}
		bool flag2 = num7 > num8;
		int num11 = num8;
		if (!flag2)
		{
			num11 = num7;
		}
		m[0] = num11;
		int num12 = 1 << num4;
		int num13 = num12;
		int num14 = num4;
		while (num14 < num8)
		{
			int num15 = num14 << 2;
			object obj10 = c + num15;
			int num16 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v183+10]");
			object obj11 = (nint)num16 - (nint)0;
			if ((nint)obj11 < 0)
			{
				return -3;
			}
			int num17 = obj11 << 1;
			int num18 = num14 + 1;
			num13 = num17;
			num14 = num18;
		}
		int num19 = num8 << 2;
		object obj12 = c + num19;
		int num20 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v27+10]");
		object obj13 = (nint)num20 - (nint)0;
		bool flag3 = (nint)obj13 < 0;
		int result = -3;
		if (!flag3)
		{
			int num21 = num8 << 2;
			object obj14 = c + num21;
			object obj15 = obj14 + 16;
			object obj16 = obj13 + obj15;
			obj15 = obj16;
			int[] array2 = x;
			array2[1] = 0;
			int num22 = num8;
			object obj22 = default;
			while (true)
			{
				int num23 = num22 - 1;
				if (num22 == 1)
				{
					break;
				}
				object obj17 = 2 << 2;
				object obj18 = (object)x + obj17;
				object obj19 = 1 << 2;
				object obj20 = (object)c + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v177+10]");
				object obj21 = 0 + obj22;
				num22 = num23;
			}
			object obj23 = 0;
			object obj24 = 0;
			bool flag4;
			do
			{
				object obj25 = bindex + obj24;
				object obj26 = obj25 << 2;
				object obj27 = (object)b + obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v59+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v59+10]");
					object obj28 = (nint)0 << 2;
					object obj29 = (object)x + obj28;
					object obj30 = obj29 + 16;
					object obj31 = obj30 + 1;
					obj30 = obj31;
					object obj32 = obj30 << 2;
					object obj33 = (object)v + obj32;
				}
				object obj34 = obj24 + 1;
				object obj35 = obj23 + 1;
				flag4 = (nint)obj35 < n;
				obj23 = obj35;
				obj24 = obj34;
			}
			while (flag4);
			int num24 = num8 << 2;
			object obj36 = x + num24;
			int[] array3 = x;
			array3[0] = 0;
			int[] array4 = u;
			array4[0] = 0;
			object obj37 = -num11;
			int num25 = num11 << 24;
			int num26 = num25 >> 24;
			object obj38 = 0;
			int num27 = 0;
			object obj39 = -1;
			object obj40 = 0;
			object obj41 = obj37;
			object obj86 = default;
			while (true)
			{
				if (num4 <= num8)
				{
					int num28 = num4 << 2;
					object obj42 = c + num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v94+10]");
					object obj43 = 0;
					while (true)
					{
						object obj44 = obj43 - 1;
						if (obj43 == null)
						{
							break;
						}
						while (true)
						{
							object obj45 = obj41 + num11;
							if (num4 <= (nint)obj45)
							{
								break;
							}
							object obj46 = obj39 + 1;
							object obj47 = obj41 + num11;
							int num29 = num8 - obj47;
							object obj48 = num4 - obj47;
							object obj49 = 1 << (int)obj48;
							object obj50 = obj44 + 1;
							bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50);
							obj40 = obj49;
							object obj51 = obj48;
							if (!flag5)
							{
								object obj52 = obj44 + 1;
								object obj53 = obj49 - obj52;
								bool flag6 = num11 < num29;
								int num30 = num11;
								if (!flag6)
								{
									num30 = num29;
								}
								bool flag7 = (nint)obj48 >= num30;
								object obj54 = obj53;
								object obj55 = obj48;
								int num31 = num4;
								obj40 = obj49;
								obj51 = obj48;
								if (!flag7)
								{
									object obj56;
									while (true)
									{
										obj56 = obj55 + 1;
										if ((nint)obj56 >= num30)
										{
											break;
										}
										object obj57 = obj54 << 1;
										int num32 = num31 + 1;
										int num33 = num32 << 2;
										object obj58 = c + num33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S1_v157+10]");
										bool flag8 = (nint)obj57 <= 0;
										flag6 = true;
										if (flag8)
										{
											break;
										}
										int num34 = num32 << 2;
										object obj59 = c + num34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ S1_v161+10]");
										object obj60 = obj57 - 0;
										obj54 = obj60;
										obj55 = obj56;
										flag6 = true;
										num31 = num32;
									}
									object obj61 = 1 << (int)obj56;
									obj40 = obj61;
									obj51 = obj56;
								}
							}
							object obj62 = obj40 + hn[0];
							bool flag9 = (nint)obj62 > 1440;
							result = -3;
							if (flag9)
							{
								goto end_IL_100c;
							}
							object obj63 = obj46 << 2;
							object obj64 = (object)u + obj63;
							_ = hn[0];
							object obj65 = hn + 16;
							object obj66 = obj40 + obj65;
							obj65 = obj66;
							if (obj46 != null)
							{
								object obj67 = obj46 << 2;
								object obj68 = (object)x + obj67;
								int[] array5 = r;
								object obj69 = obj51 << 24;
								object obj70 = obj69 >> 24;
								array5[0] = (int)obj70;
								int[] array6 = r;
								array6[1] = num26;
								int[] array7 = r;
								object obj71 = obj46 - 1;
								object obj72 = obj71 << 2;
								object obj73 = (object)u + obj72;
								int num35 = hn[0];
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S2_v76+10]");
								object obj74 = (nint)num35 - (nint)0;
								object obj75 = obj47 - num11;
								object obj76 = obj38 >> (int)obj75;
								object obj77 = obj74 - obj76;
								array7[2] = (int)obj77;
								object obj78 = obj46 - 1;
								object obj79 = obj78 << 2;
								object obj80 = (object)u + obj79;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S4_v20+10]");
								object obj81 = obj76 + 0;
								int destinationIndex = obj81 * 3;
								Array.Copy(r, 0, hp, destinationIndex, 3);
							}
							else
							{
								t[0] = hn[0];
							}
							num27 = hn[0];
							obj39 = obj46;
							obj41 = obj47;
						}
						int[] array8 = r;
						object obj82 = num4 - obj41;
						object obj83 = obj82 << 24;
						object obj84 = obj83 >> 24;
						array8[1] = (int)obj84;
						object obj85 = obj86;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v69+10]");
						if ((nint)obj85 >= 0)
						{
							int[] array9 = r;
							array9[0] = 192;
						}
						else
						{
							int[] array10 = r;
							object obj87 = obj86 << 2;
							object obj88 = (object)v + obj87;
							object obj89 = obj86 << 2;
							object obj90 = (object)v + obj89;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v150+10]");
							if ((nint)0 < (nint)s)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v147+10]");
								bool flag10 = (nint)0 > (nint)255;
								object obj91 = 96;
								if (!flag10)
								{
									obj91 = 0;
								}
								array10[0] = (int)obj91;
								int[] array11 = r;
								object obj92 = obj86 << 2;
								object obj93 = (object)v + obj92;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S1_v109+10]");
								array11[2] = 0;
								object obj94 = obj86 + 1;
								obj86 = obj94;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v147+10]");
								object obj95 = -s;
								object obj96 = obj95 << 2;
								object obj97 = (object)e + obj96;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S1_v97+10]");
								object obj98 = (nint)0 + (nint)80;
								object obj99 = obj98 << 24;
								object obj100 = obj99 >> 24;
								array10[0] = (int)obj100;
								int[] array12 = r;
								int num36 = obj86 << 2;
								object obj101 = v + num36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S2_v56+10]");
								object obj102 = -s;
								object obj103 = obj102 << 2;
								object obj104 = (object)d + obj103;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S1_v103+10]");
								array12[2] = 0;
								object obj105 = obj86 + 1;
								obj86 = obj105;
							}
						}
						object obj106 = num4 - obj41;
						object obj107 = 1 << (int)obj106;
						object obj108 = obj38 >> (int)obj41;
						object obj109 = obj108;
						while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj109) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40))
						{
							object obj110 = num27 + obj109;
							int destinationIndex2 = obj110 * 3;
							Array.Copy(r, 0, hp, destinationIndex2, 3);
							object obj111 = obj109 + obj107;
							obj109 = obj111;
						}
						object obj112 = num4 - 1;
						object obj113 = 1 << (int)obj112;
						object obj114 = obj113;
						object obj115;
						while (true)
						{
							obj115 = obj38 ^ obj114;
							object obj116 = obj38 & obj114;
							if (obj116 == null)
							{
								break;
							}
							object obj117 = obj114 >> 1;
							obj38 = obj115;
							obj114 = obj117;
						}
						while (true)
						{
							object obj118 = obj39 << 2;
							object obj119 = (object)x + obj118;
							object obj120 = 1 << (int)obj41;
							object obj121 = obj120 - 1;
							object obj122 = obj115 & obj121;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S0_v128+10]");
							if (0 == (nint)obj122)
							{
								break;
							}
							object obj123 = obj39 - 1;
							object obj124 = obj41 - num11;
							obj39 = obj123;
							obj41 = obj124;
						}
						obj38 = obj115;
						obj43 = obj44;
					}
					int num37 = num4 + 1;
					num4 = num37;
					continue;
				}
				if (obj13 == null)
				{
					result = 0;
					break;
				}
				bool flag11 = num8 == 1;
				int result2 = 0;
				if (!flag11)
				{
					result2 = -5;
				}
				return result2;
				continue;
				end_IL_100c:
				break;
			}
		}
		return result;
	}

	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
	{
		//IL_00f7: Expected Obj, but got I4
		initWorkArea(19);
		int[] array = hn;
		array[0] = 0;
		int num = huft_build(c, 0, 19, 19, null, null, tb, bb, hp, hn, v);
		object obj = num + 5;
		int result;
		if (obj != null)
		{
			if ((nint)obj != 1 && (nint)obj == 2)
			{
				z.Message = "oversubscribed dynamic bit lengths tree";
				goto IL_0114;
			}
			result = num;
			if (bb[0] != 0)
			{
				goto IL_0122;
			}
		}
		z.Message = "incomplete dynamic bit lengths tree";
		goto IL_0114;
		IL_0122:
		return result;
		IL_0114:
		result = -3;
		goto IL_0122;
	}

	internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		initWorkArea(288);
		int[] array = hn;
		array[0] = 0;
		int num = huft_build(c, 0, nl, 257, cplens, cplext, tl, bl, hp, hn, v);
		object obj = num + 4;
		bool flag = obj == null;
		int result = num;
		if (flag)
		{
			goto IL_02c9;
		}
		int num2;
		if ((nint)obj != 1)
		{
			if ((nint)obj != 2 && (nint)obj != 3 && (nint)obj == 4 && bl[0] != 0)
			{
				initWorkArea(288);
				num2 = huft_build(c, nl, nd, 0, cpdist, cpdext, td, bd, hp, hn, v);
				if (num2 != 0)
				{
					goto IL_01ab;
				}
				result = 0;
				if (bd[0] == 0)
				{
					bool flag2 = nl < 258;
					result = 0;
					if (!flag2)
					{
						goto IL_01ab;
					}
				}
				goto IL_02c9;
			}
			z.Message = "incomplete literal/length tree";
		}
		else
		{
			z.Message = "oversubscribed literal/length tree";
		}
		goto IL_02ce;
		IL_02c9:
		return result;
		IL_01ab:
		object obj2 = num2 + 5;
		if (obj2 != null)
		{
			bool flag3 = (nint)obj2 == 1;
			result = num2;
			if (!flag3)
			{
				if ((nint)obj2 != 2)
				{
					z.Message = "empty distance tree with lengths";
					goto IL_02ce;
				}
				z.Message = "oversubscribed distance tree";
				result = num2;
			}
			goto IL_02c9;
		}
		z.Message = "incomplete distance tree";
		goto IL_02ce;
		IL_02ce:
		result = -3;
		goto IL_02c9;
	}

	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
	{
		bl[0] = 9;
		bd[0] = 5;
		throw new ArrayTypeMismatchException();
	}

	private void initWorkArea(int vsize)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		if (hn == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] array = default;
			hn = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] array2 = default;
			v = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] array3 = default;
			c = array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] array4 = default;
			r = array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] array5 = default;
			u = array5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] array6 = default;
			x = array6;
			return;
		}
		int[] array7 = v;
		Array array8;
		if (vsize > array7.Length)
		{
			object obj = this + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj2 = default;
			obj = obj2;
			array8 = (Array)obj;
		}
		else
		{
			array8 = array7;
		}
		Array.Clear(array8, 0, vsize);
		Array.Clear(c, 0, 16);
		int[] array9 = r;
		array9[0] = 0;
		int[] array10 = r;
		array10[1] = 0;
		int[] array11 = r;
		array11[2] = 0;
		Array.Clear(u, 0, 15);
		Array.Clear(x, 0, 16);
	}

	static InfTree()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._8AE83CF30C3CEAC5F4B9F025200D65EFAEC851DE0098817DB69F0E547407C095));
		fixed_tl = (int[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E._5D34088B4ABB1F3FE88DCF84DD5C145EFD5EA01DF1B05BB8FEAD12305B0979B7));
		fixed_td = (int[])array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array3 = default;
		RuntimeHelpers.InitializeArray(array3, __ldtoken(_003CPrivateImplementationDetails_003E._61358F81002F15B87F2746D4CD7FE28FD2CB45B8F0840B807B18C5A23F791CB1));
		cplens = (int[])array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array4 = default;
		RuntimeHelpers.InitializeArray(array4, __ldtoken(_003CPrivateImplementationDetails_003E._5D6878AD6E68B2CCB04A7CD7942BE07C15F947CCA8824203021DD465D90712AD));
		cplext = (int[])array4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array5 = default;
		RuntimeHelpers.InitializeArray(array5, __ldtoken(_003CPrivateImplementationDetails_003E.FC216F5C5AE2947D800794ECD5F752EE8381073C2E5D0D095FDA040F541702F3));
		cpdist = (int[])array5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array6 = default;
		RuntimeHelpers.InitializeArray(array6, __ldtoken(_003CPrivateImplementationDetails_003E.B23D510F520CB4BA8AFA847F8A40E757C40CB6A55B237EFA1AC6D3984911B114));
		cpdext = (int[])array6;
	}
}
