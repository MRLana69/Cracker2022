using System;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal sealed class InflateCodes
{
	private const int START = 0;

	private const int LEN = 1;

	private const int LENEXT = 2;

	private const int DIST = 3;

	private const int DISTEXT = 4;

	private const int COPY = 5;

	private const int LIT = 6;

	private const int WASH = 7;

	private const int END = 8;

	private const int BADCODE = 9;

	internal int mode;

	internal int len;

	internal int[] tree;

	internal int tree_index;

	internal int need;

	internal int lit;

	internal int bitsToGet;

	internal int dist;

	internal byte lbits;

	internal byte dbits;

	internal int[] ltree;

	internal int ltree_index;

	internal int[] dtree;

	internal int dtree_index;

	internal InflateCodes()
	{
	}

	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
	{
		ltree = tl;
		dbits = (byte)bd;
		lbits = (byte)bl;
		mode = 0;
		dtree = td;
		ltree_index = tl_index;
		tree = null;
		dtree_index = td_index;
	}

	internal int Process(InflateBlocks blocks, int r)
	{
		//IL_1696: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_01be: Expected I4, but got Obj
		//IL_01ea: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected I8, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_1566: Expected I4, but got Obj
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_1a04: Expected Obj, but got I4
		//IL_1a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a16: Expected I8, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected I4, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected I4, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected I4, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_0a01: Expected Obj, but got I4
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Obj, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected Obj, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected Obj, but got Unknown
		//IL_1952: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_080c: Expected Obj, but got I
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected I4, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_1593: Expected I4, but got Obj
		//IL_15bf: Expected Obj, but got I4
		//IL_15cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d1: Expected I8, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected Obj, but got Unknown
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Expected Obj, but got Unknown
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected Obj, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected Obj, but got Unknown
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected I4, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_0968: Expected Obj, but got I
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected I4, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_16aa: Expected Obj, but got I4
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got Unknown
		//IL_0cd4: Expected Obj, but got I
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected I4, but got Unknown
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected Obj, but got Unknown
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected Obj, but got Unknown
		//IL_1511: Unknown result type (might be due to invalid IL or missing references)
		//IL_1516: Expected Obj, but got Unknown
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected Obj, but got Unknown
		//IL_16c4: Expected I4, but got Obj
		//IL_16f0: Expected Obj, but got I4
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected I8, but got Unknown
		//IL_13a1: Expected Obj, but got I4
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected I4, but got Unknown
		//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10be: Expected Obj, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1113: Expected Obj, but got Unknown
		//IL_112f: Expected Obj, but got I4
		//IL_1260: Expected I4, but got Obj
		//IL_0f39: Expected Obj, but got I4
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected I4, but got Unknown
		//IL_1b13: Expected I4, but got Obj
		//IL_1165: Expected I4, but got Obj
		//IL_1191: Expected Obj, but got I4
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Expected I8, but got Unknown
		//IL_147b: Expected I4, but got Obj
		//IL_14a7: Expected Obj, but got I4
		//IL_14b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b9: Expected I8, but got Unknown
		//IL_1023: Expected I4, but got Obj
		//IL_104f: Expected Obj, but got I4
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected I8, but got Unknown
		ZlibCodec codec = blocks._codec;
		int num;
		if (blocks.writeAt < blocks.readAt)
		{
			object obj = blocks.readAt - blocks.writeAt;
			num = obj - 1;
		}
		else
		{
			num = blocks.end - blocks.writeAt;
		}
		int num2 = num;
		int num3 = blocks.writeAt;
		int num4 = codec.NextIn;
		int num5 = codec.AvailableBytesIn;
		int num6 = blocks.bitb;
		InflateCodes inflateCodes = (InflateCodes)blocks.bitk;
		int r2 = default;
		while (true)
		{
			int num10;
			int num24;
			if (mode != 0)
			{
				if (mode != 1)
				{
					if (mode != 2)
					{
						if (mode != 3)
						{
							int num16;
							if (mode != 4)
							{
								if (mode != 5)
								{
									if (mode != 6)
									{
										if (mode != 7)
										{
											if (mode != 8)
											{
												if (mode != 9)
												{
													blocks.bitk = (int)inflateCodes;
													blocks.bitb = num6;
													codec.AvailableBytesIn = num5;
													object obj2 = num4 - codec.NextIn;
													long totalBytesIn = codec.TotalBytesIn + obj2;
													codec.NextIn = num4;
													codec.TotalBytesIn = totalBytesIn;
													blocks.writeAt = num3;
													return blocks.Flush(-2);
												}
												goto IL_1586;
											}
										}
										else
										{
											if ((nint)inflateCodes >= 8)
											{
												InflateCodes inflateCodes2 = (InflateCodes)(inflateCodes - 8);
												int num7 = num5 + 1;
												int num8 = num4 - 1;
												num4 = num8;
												num5 = num7;
												inflateCodes = inflateCodes2;
											}
											blocks.writeAt = num3;
											int num9 = blocks.Flush(r2);
											if (blocks.writeAt >= blocks.readAt)
											{
											}
											if (blocks.readAt != blocks.writeAt)
											{
												blocks.bitk = (int)inflateCodes;
												blocks.bitb = num6;
												codec.AvailableBytesIn = num5;
												num3 = blocks.writeAt;
												r2 = num9;
												break;
											}
											mode = 8;
											num3 = blocks.writeAt;
										}
										blocks.bitk = (int)inflateCodes;
										blocks.bitb = num6;
										codec.AvailableBytesIn = num5;
										object obj3 = num4 - codec.NextIn;
										long totalBytesIn2 = codec.TotalBytesIn + obj3;
										codec.NextIn = num4;
										codec.TotalBytesIn = totalBytesIn2;
										blocks.writeAt = num3;
										return blocks.Flush(1);
									}
									if (num2 != 0)
									{
										num10 = num3;
									}
									else
									{
										int writeAt;
										if (num3 == blocks.end && blocks.readAt != 0)
										{
											int num11 = blocks.readAt - 1;
											if (blocks.readAt < 1)
											{
												num11 = num3;
											}
											num10 = 0;
											num2 = num11;
											bool flag = true;
											if (num11 != 0)
											{
												goto IL_14f6;
											}
											writeAt = 0;
											flag = true;
										}
										else
										{
											writeAt = num3;
										}
										blocks.writeAt = writeAt;
										int num12 = blocks.Flush(r2);
										int num13 = blocks.writeAt;
										int num14;
										if (blocks.writeAt < blocks.readAt)
										{
											object obj4 = blocks.readAt - blocks.writeAt;
											num14 = obj4 - 1;
										}
										else
										{
											num14 = blocks.end - blocks.writeAt;
										}
										if (num13 == blocks.end && blocks.readAt != 0)
										{
											if (blocks.readAt >= 1)
											{
												int num15 = blocks.readAt - 1;
												num2 = num15;
												num13 = 0;
											}
											else
											{
												num2 = num13;
												num13 = 0;
											}
										}
										else
										{
											num2 = num14;
										}
										num10 = num13;
										num16 = num12;
										bool flag2 = (byte)(int)inflateCodes != 0;
										if (num2 == 0)
										{
											blocks.bitk = (int)inflateCodes;
											blocks.bitb = num6;
											codec.AvailableBytesIn = num5;
											object obj5 = num4 - codec.NextIn;
											long totalBytesIn3 = codec.TotalBytesIn + obj5;
											codec.NextIn = num4;
											codec.TotalBytesIn = totalBytesIn3;
											blocks.writeAt = num13;
											return blocks.Flush(num12);
										}
									}
									goto IL_14f6;
								}
							}
							else
							{
								while (bitsToGet > (nint)inflateCodes)
								{
									if (num5 != 0)
									{
										int num17 = num5 - 1;
										object obj6 = num4 + codec.InputBuffer;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ S0_v326+10]");
										object obj7 = (nint)0 << (int)inflateCodes;
										int num18 = obj7 | num6;
										InflateCodes inflateCodes3 = (InflateCodes)(inflateCodes + 8);
										int num19 = num4 + 1;
										num4 = num19;
										num5 = num17;
										num6 = num18;
										inflateCodes = inflateCodes3;
										r2 = 0;
										continue;
									}
									goto IL_1559;
								}
								bool flag = (byte)(bitsToGet << 2) != 0;
								object obj8 = InternalInflateConstants.InflateMask + flag;
								int num20 = num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ S2_v85+10]");
								int num21 = (int)((nint)num20 & (nint)0);
								int num22 = num21 + dist;
								dist = num22;
								InflateCodes inflateCodes4 = (InflateCodes)(inflateCodes - bitsToGet);
								mode = 5;
								int num23 = num6 >> bitsToGet;
								num6 = num23;
								inflateCodes = inflateCodes4;
								num24 = 2;
								bool flag2 = (byte)dist != 0;
							}
							object obj9 = num3 - dist;
							object obj10 = obj9;
							while ((nint)obj10 < 0)
							{
								object obj11 = blocks.end + obj10;
								obj10 = obj11;
							}
							num16 = len;
							while (num16 != 0)
							{
								int num25;
								if (num2 != 0)
								{
									num25 = num3;
								}
								else
								{
									if (num3 == blocks.end && blocks.readAt != 0)
									{
										int num26 = blocks.readAt - 1;
										if (blocks.readAt < 1)
										{
											num26 = num3;
										}
										bool flag3 = num26 == 0;
										num3 = 0;
										if (!flag3)
										{
											num25 = 0;
											num2 = num26;
											goto IL_109e;
										}
									}
									blocks.writeAt = num3;
									int num27 = blocks.Flush(r2);
									int num28 = blocks.writeAt;
									int num29;
									if (blocks.writeAt < blocks.readAt)
									{
										object obj12 = blocks.readAt - blocks.writeAt;
										num29 = obj12 - 1;
									}
									else
									{
										num29 = blocks.end - blocks.writeAt;
									}
									if (num28 == blocks.end && blocks.readAt != 0)
									{
										if (blocks.readAt >= 1)
										{
											int num30 = blocks.readAt - 1;
											num2 = num30;
											num28 = 0;
										}
										else
										{
											num2 = num28;
											num28 = 0;
										}
									}
									else
									{
										num2 = num29;
									}
									num25 = num28;
									r2 = num27;
									if (num2 == 0)
									{
										blocks.bitk = (int)inflateCodes;
										blocks.bitb = num6;
										codec.AvailableBytesIn = num5;
										object obj13 = num4 - codec.NextIn;
										long totalBytesIn4 = codec.TotalBytesIn + obj13;
										codec.NextIn = num4;
										codec.TotalBytesIn = totalBytesIn4;
										blocks.writeAt = num28;
										return blocks.Flush(num27);
									}
								}
								goto IL_109e;
								IL_109e:
								int num31 = num25 + 1;
								object obj14 = num25 + blocks.window;
								object obj15 = obj10 + (object)blocks.window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ S1_v173+10]");
								_ = 0;
								int num32 = num2 - 1;
								int num33 = --len;
								object obj16 = obj10 + 1;
								bool flag2 = (nint)obj16 == blocks.end;
								object obj17 = 0;
								if (!flag2)
								{
									obj17 = obj16;
								}
								obj10 = obj17;
								num16 = num33;
								num2 = num32;
								num3 = num31;
								bool flag = (byte)blocks.end != 0;
							}
							mode = 0;
							continue;
						}
					}
					else
					{
						while (bitsToGet > (nint)inflateCodes)
						{
							if (num5 != 0)
							{
								int num34 = num5 - 1;
								object obj18 = num4 + codec.InputBuffer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v215+10]");
								object obj19 = (nint)0 << (int)inflateCodes;
								int num35 = obj19 | num6;
								InflateCodes inflateCodes5 = (InflateCodes)(inflateCodes + 8);
								int num36 = num4 + 1;
								num4 = num36;
								num5 = num34;
								num6 = num35;
								inflateCodes = inflateCodes5;
								r2 = 0;
								continue;
							}
							goto IL_1559;
						}
						int num37 = bitsToGet << 2;
						object obj20 = InternalInflateConstants.InflateMask + num37;
						int num38 = num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S2_v62+10]");
						int num39 = (int)((nint)num38 & (nint)0);
						int num40 = num39 + len;
						len = num40;
						InflateCodes inflateCodes6 = (InflateCodes)(inflateCodes - bitsToGet);
						need = dbits;
						tree = dtree;
						mode = 3;
						tree_index = dtree_index;
						int num41 = num6 >> bitsToGet;
						num6 = num41;
						inflateCodes = inflateCodes6;
					}
					while (need > (nint)inflateCodes)
					{
						if (num5 != 0)
						{
							int num42 = num5 - 1;
							object obj21 = num4 + codec.InputBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v184+10]");
							object obj22 = (nint)0 << (int)inflateCodes;
							int num43 = obj22 | num6;
							InflateCodes inflateCodes7 = (InflateCodes)(inflateCodes + 8);
							int num44 = num4 + 1;
							num4 = num44;
							num5 = num42;
							num6 = num43;
							inflateCodes = inflateCodes7;
							r2 = 0;
							continue;
						}
						goto IL_1559;
					}
					num24 = need << 2;
					object obj23 = InternalInflateConstants.InflateMask + num24;
					int num45 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S3_v32+10]");
					int num46 = (int)((nint)num45 & (nint)0);
					object obj24 = num46 + tree_index;
					object obj25 = obj24 * 3;
					object obj26 = obj25 + 1;
					object obj27 = obj26 << 2;
					object obj28 = (object)tree + obj27;
					int num47 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S1_v107+10]");
					int num48 = num47 >> 0;
					object obj29 = obj25 + 1;
					object obj30 = obj29 << 2;
					object obj31 = (object)tree + obj30;
					InflateCodes inflateCodes8 = inflateCodes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S1_v111+10]");
					InflateCodes inflateCodes9 = (InflateCodes)(inflateCodes8 - 0);
					object obj32 = obj25 << 2;
					object obj33 = (object)tree + obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v162+10]");
					if ((int)((nint)0 & (nint)0x10) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v162+10]");
						int num49 = (int)((nint)0 & (nint)0xF);
						bitsToGet = num49;
						object obj34 = obj25 + 2;
						object obj35 = obj34 << 2;
						object obj36 = (object)tree + obj35;
						mode = 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S0_v175+10]");
						dist = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v162+10]");
						int num16 = 0;
						num6 = num48;
						inflateCodes = inflateCodes9;
						bool flag = true;
						bool flag2 = true;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v162+10]");
					if ((int)((nint)0 & (nint)0x40) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v162+10]");
						need = 0;
						object obj37 = obj25 + 2;
						object obj38 = obj37 << 2;
						object obj39 = (object)tree + obj38;
						bool flag2 = (byte)(obj25 / 3) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ S1_v123+10]");
						int num50 = (int)((nint)0 + (nint)(flag2 ? 1 : 0));
						tree_index = num50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v162+10]");
						int num16 = 0;
						num6 = num48;
						inflateCodes = inflateCodes9;
						bool flag = true;
						continue;
					}
					mode = 9;
					codec.Message = "invalid distance code";
					num6 = num48;
					inflateCodes = inflateCodes9;
					goto IL_1586;
				}
			}
			else
			{
				bool flag4 = num2 < 258;
				InflateCodes inflateCodes10 = inflateCodes;
				if (!flag4)
				{
					bool flag5 = num5 < 10;
					inflateCodes10 = inflateCodes;
					if (!flag5)
					{
						blocks.bitk = (int)inflateCodes;
						blocks.bitb = num6;
						codec.AvailableBytesIn = num5;
						object obj40 = num4 - codec.NextIn;
						long totalBytesIn5 = codec.TotalBytesIn + obj40;
						codec.NextIn = num4;
						codec.TotalBytesIn = totalBytesIn5;
						blocks.writeAt = num3;
						int num51 = inflateCodes.InflateFast(lbits, dbits, ltree, ltree_index, dtree, dtree_index, blocks, codec);
						int num52;
						if (blocks.writeAt < blocks.readAt)
						{
							object obj41 = blocks.readAt - blocks.writeAt;
							num52 = obj41 - 1;
						}
						else
						{
							num52 = blocks.end - blocks.writeAt;
						}
						if (num51 != 0)
						{
							bool flag = num51 == 1;
							bool flag6 = true;
							if (!flag)
							{
								flag6 = true;
							}
							mode = (flag6 ? 1 : 0);
							num2 = num52;
							num3 = blocks.writeAt;
							num4 = codec.NextIn;
							num5 = codec.AvailableBytesIn;
							num6 = blocks.bitb;
							inflateCodes = (InflateCodes)blocks.bitk;
							r2 = num51;
							num24 = 1;
							bool flag2 = true;
							continue;
						}
						num2 = num52;
						num3 = blocks.writeAt;
						num4 = codec.NextIn;
						num5 = codec.AvailableBytesIn;
						num6 = blocks.bitb;
						inflateCodes10 = (InflateCodes)blocks.bitk;
						r2 = 0;
					}
				}
				need = lbits;
				tree = ltree;
				mode = 1;
				tree_index = ltree_index;
				inflateCodes = inflateCodes10;
			}
			while (need > (nint)inflateCodes)
			{
				if (num5 != 0)
				{
					int num53 = num5 - 1;
					object obj42 = num4 + codec.InputBuffer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v79+10]");
					object obj43 = (nint)0 << (int)inflateCodes;
					int num54 = obj43 | num6;
					InflateCodes inflateCodes11 = (InflateCodes)(inflateCodes + 8);
					int num55 = num4 + 1;
					num4 = num55;
					num5 = num53;
					num6 = num54;
					inflateCodes = inflateCodes11;
					r2 = 0;
					continue;
				}
				goto IL_1559;
			}
			num24 = need << 2;
			object obj44 = InternalInflateConstants.InflateMask + num24;
			int num56 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S3_v8+10]");
			int num57 = (int)((nint)num56 & (nint)0);
			object obj45 = num57 + tree_index;
			object obj46 = obj45 * 3;
			object obj47 = obj46 + 1;
			object obj48 = obj47 << 2;
			object obj49 = (object)tree + obj48;
			int num58 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S1_v18+10]");
			int num59 = num58 >> 0;
			object obj50 = obj46 + 1;
			object obj51 = obj50 << 2;
			object obj52 = (object)tree + obj51;
			InflateCodes inflateCodes12 = inflateCodes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S1_v22+10]");
			InflateCodes inflateCodes13 = (InflateCodes)(inflateCodes12 - 0);
			object obj53 = obj46 << 2;
			object obj54 = (object)tree + obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
			if ((nint)0 == 0)
			{
				object obj55 = obj46 + 2;
				object obj56 = obj55 << 2;
				object obj57 = (object)tree + obj56;
				mode = 6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S0_v70+10]");
				lit = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
				int num16 = 0;
				num6 = num59;
				inflateCodes = inflateCodes13;
				bool flag = true;
				bool flag2 = true;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
			if ((int)((nint)0 & (nint)0x10) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
				int num60 = (int)((nint)0 & (nint)0xF);
				bitsToGet = num60;
				object obj58 = obj46 + 2;
				object obj59 = obj58 << 2;
				object obj60 = (object)tree + obj59;
				mode = 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ S0_v64+10]");
				len = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
				int num16 = 0;
				num6 = num59;
				inflateCodes = inflateCodes13;
				bool flag = true;
				bool flag2 = true;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
			if ((int)((nint)0 & (nint)0x40) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
				need = 0;
				object obj61 = obj46 + 2;
				object obj62 = obj61 << 2;
				object obj63 = (object)tree + obj62;
				bool flag2 = (byte)(obj46 / 3) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S1_v36+10]");
				int num61 = (int)((nint)0 + (nint)(flag2 ? 1 : 0));
				tree_index = num61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
				int num16 = 0;
				num6 = num59;
				inflateCodes = inflateCodes13;
				bool flag = true;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
			if ((int)((nint)0 & (nint)0x20) != 0)
			{
				mode = 7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v46+10]");
				int num16 = 0;
				num6 = num59;
				inflateCodes = inflateCodes13;
				bool flag = true;
				bool flag2 = true;
				continue;
			}
			mode = 9;
			codec.Message = "invalid literal/length code";
			num6 = num59;
			inflateCodes = inflateCodes13;
			goto IL_1586;
			IL_1559:
			blocks.bitk = (int)inflateCodes;
			blocks.bitb = num6;
			codec.AvailableBytesIn = 0;
			break;
			IL_14f6:
			int num62 = num10 + 1;
			object obj64 = num10 + blocks.window;
			_ = lit;
			int num63 = num2 - 1;
			mode = 0;
			num2 = num63;
			num3 = num62;
			r2 = 0;
			continue;
			IL_1586:
			blocks.bitk = (int)inflateCodes;
			blocks.bitb = num6;
			codec.AvailableBytesIn = num5;
			object obj65 = num4 - codec.NextIn;
			long totalBytesIn6 = codec.TotalBytesIn + obj65;
			codec.NextIn = num4;
			codec.TotalBytesIn = totalBytesIn6;
			blocks.writeAt = num3;
			return blocks.Flush(-3);
		}
		object obj66 = num4 - codec.NextIn;
		long totalBytesIn7 = codec.TotalBytesIn + obj66;
		codec.NextIn = num4;
		codec.TotalBytesIn = totalBytesIn7;
		blocks.writeAt = num3;
		return blocks.Flush(r2);
	}

	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
	{
		//IL_0046: Expected Obj, but got I4
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected Obj, but got Unknown
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I
		//IL_10e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Expected Obj, but got Unknown
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected Obj, but got Unknown
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected I4, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected Obj, but got Unknown
		//IL_0aba: Expected Obj, but got I
		//IL_0ac8: Expected I4, but got Obj
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected I4, but got Unknown
		//IL_0b05: Expected Obj, but got I4
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0b3e: Expected Obj, but got I
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected Obj, but got Unknown
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Expected Obj, but got Unknown
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected Obj, but got Unknown
		//IL_0f42: Expected Obj, but got I4
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected Obj, but got Unknown
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f79: Expected Obj, but got Unknown
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected Obj, but got Unknown
		//IL_0ffd: Expected Obj, but got I
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_1225: Expected Obj, but got I4
		//IL_1232: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Expected I8, but got Unknown
		//IL_0503: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected I4, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05ec: Expected I4, but got Obj
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_0624: Expected Obj, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected I4, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0433: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected I4, but got Unknown
		//IL_0668: Expected Obj, but got I4
		//IL_1094: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I4
		//IL_086b: Expected Obj, but got I4
		//IL_0993: Expected Obj, but got I4
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_06ee: Expected Obj, but got I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected I4, but got Unknown
		//IL_070a: Expected Obj, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected I4, but got Unknown
		//IL_0895: Expected Obj, but got I4
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected Obj, but got Unknown
		object obj2;
		if (s.writeAt < s.readAt)
		{
			object obj = s.readAt - s.writeAt;
			obj2 = obj - 1;
		}
		else
		{
			obj2 = s.end - s.writeAt;
		}
		int num = bl << 2;
		object obj3 = InternalInflateConstants.InflateMask + num;
		int num2 = bd << 2;
		object obj4 = InternalInflateConstants.InflateMask + num2;
		int num3 = s.writeAt;
		object obj5 = obj2;
		int num4 = z.NextIn;
		int num5 = s.bitk;
		int num6 = s.bitb;
		int num7 = z.AvailableBytesIn;
		int num69 = default;
		int result;
		int num86;
		int num87;
		int availableBytesIn;
		while (true)
		{
			if (num5 <= 19)
			{
				int num8 = num7 - 1;
				object obj6 = num4 + z.InputBuffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v295+10]");
				int num9 = (int)((nint)0 << num5);
				int num10 = num9 | num6;
				int num11 = num5 + 8;
				int num12 = num4 + 1;
				num4 = num12;
				num5 = num11;
				num6 = num10;
				num7 = num8;
				continue;
			}
			int num13 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23+10]");
			int num14 = (int)((nint)num13 & (nint)0);
			object obj7 = num14 + tl_index;
			object obj8 = obj7 * 3;
			object obj9 = obj8 << 2;
			object obj10 = (object)tl + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v35+10]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v35+10]");
			object obj11 = 0;
			object obj12 = obj8;
			if (!flag2)
			{
				object obj13 = obj8 + 1;
				object obj14 = obj13 << 2;
				object obj15 = (object)tl + obj14;
				object obj16 = obj8 + 1;
				object obj17 = obj16 << 2;
				object obj18 = (object)tl + obj17;
				int num15 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v222+10]");
				int num16 = (int)((nint)num15 - (nint)0);
				object obj19 = num3 + s.window;
				object obj20 = obj8 + 2;
				object obj21 = obj20 << 2;
				object obj22 = (object)tl + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v227+10]");
				_ = 0;
				int num17 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v280+10]");
				int num18 = num17 >> 0;
				object obj23 = obj5 - 1;
				int num19 = num3 + 1;
				num3 = num19;
				obj5 = obj23;
				num5 = num16;
				num6 = num18;
				goto IL_0ede;
			}
			int num21;
			int num23;
			object obj38;
			while (true)
			{
				object obj24 = obj12 + 1;
				object obj25 = obj24 << 2;
				object obj26 = (object)tl + obj25;
				int num20 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v31+10]");
				num21 = num20 >> 0;
				object obj27 = obj12 + 1;
				object obj28 = obj27 << 2;
				object obj29 = (object)tl + obj28;
				int num22 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v34+10]");
				num23 = (int)((nint)num22 - (nint)0);
				object obj30 = obj11 & 0x10;
				if (obj30 != null)
				{
					break;
				}
				object obj31 = obj11 & 0x40;
				if (obj31 == null)
				{
					object obj32 = obj12 + 2;
					object obj33 = obj32 << 2;
					object obj34 = (object)tl + obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v77+10]");
					object obj35 = (nint)0 + (nint)num14;
					int num24 = obj11 << 2;
					object obj36 = InternalInflateConstants.InflateMask + num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S2_v33+10]");
					int num25 = (int)((nint)num21 & (nint)0);
					int num26 = num25 + obj35;
					object obj37 = num26 + tl_index;
					obj38 = obj37 * 3;
					object obj39 = obj38 << 2;
					object obj40 = (object)tl + obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v83+10]");
					obj11 = 0;
					obj12 = obj38;
					num5 = num23;
					num6 = num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v83+10]");
					if ((nint)0 != 0)
					{
						continue;
					}
					goto IL_0b6c;
				}
				goto IL_0c72;
			}
			object obj41 = obj12 + 2;
			object obj42 = obj41 << 2;
			object obj43 = (object)tl + obj42;
			object obj44 = obj11 & 0xF;
			int num27 = num21 >> (int)obj44;
			object obj45 = obj44 << 2;
			object obj46 = (object)InternalInflateConstants.InflateMask + obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S1_v82+10]");
			int num28 = (int)((nint)num21 & (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v99+10]");
			int num29 = (int)((nint)num28 + (nint)0);
			int num30 = num23 - obj44;
			int num31 = num27;
			int num32 = num30;
			while (num32 < 15)
			{
				int num33 = num7 - 1;
				object obj47 = num4 + z.InputBuffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v262+10]");
				int num34 = (int)((nint)0 << num32);
				int num35 = num34 | num31;
				int num36 = num32 + 8;
				int num37 = num4 + 1;
				num31 = num35;
				num4 = num37;
				num32 = num36;
				num7 = num33;
			}
			int num38 = num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29+10]");
			int num39 = (int)((nint)num38 & (nint)0);
			int num40 = num39;
			object obj49;
			int num42;
			int num44;
			while (true)
			{
				object obj48 = td_index + num40;
				obj49 = obj48 * 3;
				object obj50 = obj49 << 2;
				object obj51 = (object)td + obj50;
				object obj52 = obj49 + 1;
				object obj53 = obj52 << 2;
				object obj54 = (object)td + obj53;
				int num41 = num31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S1_v95+10]");
				num42 = num41 >> 0;
				object obj55 = obj49 + 1;
				object obj56 = obj55 << 2;
				object obj57 = (object)td + obj56;
				int num43 = num32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ S1_v98+10]");
				num44 = (int)((nint)num43 - (nint)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v117+10]");
				object obj58 = (nint)0 & (nint)0x10;
				if (obj58 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v117+10]");
				object obj59 = (nint)0 & (nint)0x40;
				if (obj59 == null)
				{
					object obj60 = obj49 + 2;
					object obj61 = obj60 << 2;
					object obj62 = (object)td + obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v251+10]");
					object obj63 = (nint)0 + (nint)num40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v117+10]");
					object obj64 = (nint)0 << 2;
					object obj65 = (object)InternalInflateConstants.InflateMask + obj64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S1_v201+10]");
					int num45 = (int)((nint)num42 & (nint)0);
					int num46 = num45 + obj63;
					num31 = num42;
					num40 = num46;
					num32 = num44;
					continue;
				}
				goto IL_0496;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v117+10]");
			object obj66 = (nint)0 & (nint)0xF;
			int num47 = num42;
			int num48 = num44;
			while (num48 < (nint)obj66)
			{
				int num49 = num7 - 1;
				object obj67 = num4 + z.InputBuffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S0_v229+10]");
				int num50 = (int)((nint)0 << num48);
				int num51 = num50 | num47;
				int num52 = num48 + 8;
				int num53 = num4 + 1;
				num47 = num51;
				num4 = num53;
				num48 = num52;
				num7 = num49;
			}
			object obj68 = obj49 + 2;
			object obj69 = obj68 << 2;
			object obj70 = (object)td + obj69;
			int num54 = num48 - obj66;
			object obj71 = obj5 - num29;
			int num55 = obj66 << 2;
			object obj72 = InternalInflateConstants.InflateMask + num55;
			int num56 = num47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S2_v68+10]");
			int num57 = (int)((nint)num56 & (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S0_v131+10]");
			object obj73 = (nint)num57 + (nint)0;
			int num58 = num3 - obj73;
			int num63;
			int num64;
			int num62;
			if (num3 >= (nint)obj73)
			{
				object obj74 = num3 - num58;
				if ((nint)obj74 >= 1)
				{
					object obj75 = num3 - num58;
					if ((nint)obj75 <= 1)
					{
						object obj76 = num3 + s.window;
						object obj77 = num58 + s.window;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ S1_v165+10]");
						_ = 0;
						object obj78 = num3 + 1;
						int num59 = obj78 + 1;
						object obj79 = num58 + 1;
						int num60 = obj79 + 1;
						object obj80 = obj78 + (object)s.window;
						object obj81 = obj79 + (object)s.window;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S1_v174+10]");
						_ = 0;
						int num61 = num29 - 2;
						num62 = num61;
						num63 = num59;
						num64 = num60;
						goto IL_107a;
					}
				}
				Array.Copy(s.window, num58, s.window, num3, 2);
				int num65 = num3 + 2;
				int num66 = num58 + 2;
				int num67 = num29 - 2;
				num62 = num67;
				num63 = num65;
				num64 = num66;
			}
			else
			{
				int num68 = num58;
				num68 = num69;
				int num70;
				do
				{
					num70 = s.end + num68;
				}
				while (num70 < 0);
				int num71 = s.end - num70;
				if (num71 >= num29)
				{
					num62 = num29;
					num63 = num3;
					num64 = num70;
				}
				else
				{
					int num72 = num29 - num71;
					object obj82 = num3 - num70;
					if ((nint)obj82 >= 1)
					{
						object obj83 = num3 - num70;
						if (num71 > (nint)obj83)
						{
							int num73;
							int num74;
							do
							{
								object obj84 = num3 + s.window;
								object obj85 = num70 + s.window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ S1_v148+10]");
								_ = 0;
								num73 = num3 + 1;
								num74 = num71 - 1;
								num3 = num73;
							}
							while (num74 != 0);
							num62 = num72;
							num63 = num73;
							num64 = 0;
							goto IL_107a;
						}
					}
					Array.Copy(s.window, num70, s.window, num3, num71);
					int num75 = num3 + num71;
					num62 = num72;
					num63 = num75;
					num64 = 0;
				}
			}
			goto IL_107a;
			IL_107a:
			int num76 = num47 >> (int)obj66;
			object obj86 = num63 - num64;
			if ((nint)obj86 >= 1)
			{
				object obj87 = num63 - num64;
				if (num62 > (nint)obj87)
				{
					int num78;
					int num79;
					do
					{
						object obj88 = num63 + s.window;
						object obj89 = num64 + s.window;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S1_v126+10]");
						_ = 0;
						int num77 = num64 + 1;
						num78 = num63 + 1;
						num79 = num62 - 1;
						num62 = num79;
						num63 = num78;
						num64 = num77;
					}
					while (num79 != 0);
					num62 = num79;
					num3 = num78;
					obj5 = obj71;
					num5 = num54;
					num6 = num76;
					goto IL_0ede;
				}
			}
			Array.Copy(s.window, num64, s.window, num63, num62);
			int num80 = num63 + num62;
			num3 = num80;
			obj5 = obj71;
			num5 = num54;
			num6 = num76;
			goto IL_0ede;
			IL_0ede:
			bool flag3 = (nint)obj5 >= 258;
			if (num7 <= 9)
			{
				flag3 = false;
			}
			if (flag3)
			{
				continue;
			}
			int num81 = num5 >> 3;
			int num82 = z.AvailableBytesIn - num7;
			bool flag4 = num81 < num82;
			result = 0;
			if (!flag4)
			{
				result = 0;
				num81 = num82;
			}
			goto IL_1263;
			IL_0496:
			z.Message = "invalid distance code";
			int num83 = num44 >> 3;
			int num84 = z.AvailableBytesIn - num7;
			if (num83 >= num84)
			{
				num83 = num84;
			}
			int num85 = num83 + num7;
			num86 = num4 - num83;
			result = -3;
			num87 = num83;
			num5 = num44;
			num6 = num42;
			availableBytesIn = num85;
			break;
			IL_1263:
			int num88 = num81 + num7;
			num86 = num4 - num81;
			num87 = num81;
			availableBytesIn = num88;
			break;
			IL_0c72:
			object obj90 = obj11 & 0x20;
			if (obj90 != null)
			{
				num81 = num23 >> 3;
				int num89 = z.AvailableBytesIn - num7;
				if (num81 >= num89)
				{
					num81 = num89;
				}
				result = 1;
				num5 = num23;
				num6 = num21;
			}
			else
			{
				z.Message = "invalid literal/length code";
				num81 = num23 >> 3;
				int num90 = z.AvailableBytesIn - num7;
				if (num81 >= num90)
				{
					num81 = num90;
				}
				result = -3;
				num5 = num23;
				num6 = num21;
			}
			goto IL_1263;
			IL_0b6c:
			object obj91 = obj38 + 1;
			object obj92 = obj91 << 2;
			object obj93 = (object)tl + obj92;
			object obj94 = obj38 + 1;
			object obj95 = obj94 << 2;
			object obj96 = (object)tl + obj95;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v63+10]");
			int num91 = (int)((nint)num23 - (nint)0);
			object obj97 = num3 + s.window;
			object obj98 = obj38 + 2;
			object obj99 = obj98 << 2;
			object obj100 = (object)tl + obj99;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v68+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v86+10]");
			int num92 = num21 >> 0;
			object obj101 = obj5 - 1;
			int num93 = num3 + 1;
			num3 = num93;
			obj5 = obj101;
			num5 = num91;
			num6 = num92;
			goto IL_0ede;
		}
		int num94 = num87 << 3;
		int bitk = num5 - num94;
		s.bitk = bitk;
		s.bitb = num6;
		z.AvailableBytesIn = availableBytesIn;
		object obj102 = num86 - z.NextIn;
		long totalBytesIn = z.TotalBytesIn + obj102;
		z.NextIn = num86;
		z.TotalBytesIn = totalBytesIn;
		s.writeAt = num3;
		return result;
	}
}
