using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] array = default;
		bb = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] array2 = default;
		tb = array2;
		InflateCodes inflateCodes = default;
		codes = inflateCodes;
		InfTree infTree = default;
		inftree = infTree;
		_codec = codec;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] array3 = default;
		hufts = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array4 = default;
		window = array4;
		this.checkfn = checkfn;
		end = w;
		mode = InflateBlockMode.TYPE;
		uint num = Reset();
	}

	internal uint Reset()
	{
		bitk = 0;
		mode = InflateBlockMode.TYPE;
		readAt = 0;
		if (checkfn != null)
		{
			ZlibCodec codec = _codec;
			codec._Adler32 = (check = Adler.Adler32(0u, null, 0, 0));
		}
		return check;
	}

	internal int Process(int r)
	{
		//IL_19f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fd: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		//IL_1fcd: Expected Obj, but got I4
		//IL_1fef: Expected Obj, but got I4
		//IL_20b9: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_18a6: Expected I4, but got Obj
		//IL_18da: Expected Obj, but got I4
		//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ec: Expected I8, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected I4, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected I4, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_04ed: Expected Obj, but got I4
		//IL_0681: Expected Obj, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected I4, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected I4, but got Unknown
		//IL_1cce: Expected I4, but got Obj
		//IL_1cf8: Expected I4, but got Obj
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_1c26: Expected I4, but got Obj
		//IL_1c38: Expected Obj, but got I4
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4a: Expected I8, but got Unknown
		//IL_183b: Expected I4, but got Obj
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0306: Expected I4, but got Obj
		//IL_09a3: Expected I4, but got Obj
		//IL_1da2: Expected Obj, but got I4
		//IL_1dc5: Expected Obj, but got I4
		//IL_2146: Unknown result type (might be due to invalid IL or missing references)
		//IL_214b: Expected I4, but got Unknown
		//IL_219c: Expected I4, but got Obj
		//IL_09b6: Expected Obj, but got I4
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected I4, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_0897: Expected Obj, but got I
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected I4, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_0cc0: Expected Obj, but got I4
		//IL_1e4c: Expected Obj, but got I4
		//IL_1e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e77: Expected Obj, but got Unknown
		//IL_078a: Expected Obj, but got I4
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected I4, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected Obj, but got Unknown
		//IL_0c4e: Expected Obj, but got I
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected Obj, but got Unknown
		//IL_0bad: Expected Obj, but got I
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected I4, but got Unknown
		//IL_00f7: Expected I4, but got Obj
		//IL_2074: Expected I4, but got Obj
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected I4, but got Unknown
		//IL_1958: Expected I4, but got Obj
		//IL_196a: Expected Obj, but got I4
		//IL_1977: Unknown result type (might be due to invalid IL or missing references)
		//IL_197c: Expected I8, but got Unknown
		//IL_0d9d: Expected Obj, but got I4
		//IL_1a6d: Expected I4, but got Obj
		//IL_1a82: Expected Obj, but got I
		//IL_1a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a97: Expected Obj, but got Unknown
		//IL_146f: Expected Obj, but got I4
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected Obj, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected Obj, but got Unknown
		//IL_0b08: Expected Obj, but got I
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected I4, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected Obj, but got Unknown
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected Obj, but got Unknown
		//IL_0ebb: Expected Obj, but got I4
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Expected Obj, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Expected Obj, but got Unknown
		//IL_0f0a: Expected Obj, but got I
		//IL_0f44: Expected Obj, but got I4
		//IL_0f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f52: Expected Obj, but got Unknown
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Expected Obj, but got Unknown
		//IL_17b4: Expected I4, but got Obj
		//IL_17c6: Expected Obj, but got I4
		//IL_17d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d8: Expected I8, but got Unknown
		//IL_1f2e: Expected I4, but got Obj
		//IL_1f40: Expected Obj, but got I4
		//IL_1f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f52: Expected I8, but got Unknown
		//IL_15fd: Expected Obj, but got I4
		//IL_1606: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Expected I4, but got Unknown
		//IL_1b68: Expected I4, but got Obj
		//IL_1b7a: Expected Obj, but got I4
		//IL_1b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8c: Expected I8, but got Unknown
		//IL_1092: Expected Obj, but got I
		//IL_109b: Expected Obj, but got I4
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc5: Expected I4, but got Unknown
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected Obj, but got Unknown
		//IL_16cc: Expected Obj, but got I4
		//IL_1eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb5: Expected Obj, but got Unknown
		//IL_106e: Expected Obj, but got I4
		//IL_1077: Expected Obj, but got I4
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected Obj, but got Unknown
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected Obj, but got Unknown
		//IL_0dfe: Expected Obj, but got I
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Expected I4, but got Unknown
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Expected Obj, but got Unknown
		//IL_11a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Expected Obj, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bb: Expected Obj, but got Unknown
		//IL_11c8: Expected I4, but got Obj
		//IL_11df: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected Obj, but got Unknown
		//IL_1202: Expected Obj, but got I4
		//IL_1228: Unknown result type (might be due to invalid IL or missing references)
		//IL_122d: Expected Obj, but got Unknown
		//IL_1716: Expected I4, but got Obj
		//IL_1728: Expected Obj, but got I4
		//IL_1735: Unknown result type (might be due to invalid IL or missing references)
		//IL_173a: Expected I8, but got Unknown
		//IL_12fc: Expected Obj, but got I4
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected Obj, but got Unknown
		//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e7: Expected Obj, but got Unknown
		//IL_10fc: Expected Obj, but got I
		//IL_1104: Unknown result type (might be due to invalid IL or missing references)
		//IL_1109: Expected I4, but got Unknown
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_1117: Expected Obj, but got Unknown
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e2: Expected Obj, but got Unknown
		//IL_20fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2103: Expected Obj, but got Unknown
		//IL_131a: Expected Obj, but got I4
		//IL_1345: Expected Obj, but got I
		ZlibCodec codec = _codec;
		int num;
		if (writeAt < readAt)
		{
			object obj = readAt - writeAt;
			num = obj - 1;
		}
		else
		{
			num = end - writeAt;
		}
		object obj2 = this + 24;
		int num2 = writeAt;
		int num3 = num;
		int num4 = codec.NextIn;
		int num5 = bitk;
		int num6 = bitb;
		int num7 = codec.AvailableBytesIn;
		int[] array2 = default;
		int num8 = default;
		int[] array5 = default;
		int[] array7 = default;
		int r3 = default;
		object obj9 = default;
		int[] array14 = default;
		int[] array15 = default;
		int[][] array16 = default;
		int[][] array17 = default;
		object obj56 = default;
		int num83 = default;
		int[] array24 = default;
		int[] array25 = default;
		int[] array26 = default;
		int[] array27 = default;
		while (true)
		{
			int[] array = array2;
			int[][] array3 = (int[][])num8;
			int[][] array4 = (int[][])(object)array5;
			InflateBlockMode inflateBlockMode = mode;
			int[] array6 = array7;
			int[] array8 = (int[])num7;
			while (true)
			{
				bool flag = inflateBlockMode == InflateBlockMode.TYPE;
				ZlibCodec zlibCodec = (ZlibCodec)num5;
				int num9;
				int num10;
				if (!flag)
				{
					if (inflateBlockMode != InflateBlockMode.LENS)
					{
						if (inflateBlockMode == InflateBlockMode.STORED)
						{
							bool flag2 = array8 == null;
							zlibCodec = (ZlibCodec)num5;
							if (!flag2)
							{
								num9 = num2;
								num10 = num3;
								if (num3 == 0)
								{
									if (num2 == end && readAt != 0)
									{
										int num11 = readAt - 1;
										if (readAt < 1)
										{
											num11 = num2;
										}
										num2 = 0;
										num9 = 0;
										num10 = num11;
										if (num11 != 0)
										{
											goto IL_1819;
										}
									}
									writeAt = num2;
									int r2 = Flush(r3);
									int num12 = writeAt;
									int num13;
									if (writeAt < readAt)
									{
										object obj3 = readAt - writeAt;
										num13 = obj3 - 1;
									}
									else
									{
										num13 = end - writeAt;
									}
									if (num12 == end && readAt != 0)
									{
										if (readAt >= 1)
										{
											int num14 = readAt - 1;
											num10 = num14;
											num12 = 0;
										}
										else
										{
											num10 = num12;
											num12 = 0;
										}
									}
									else
									{
										num10 = num13;
									}
									num9 = num12;
									if (num10 == 0)
									{
										bitk = num5;
										bitb = num6;
										ZlibCodec codec2 = _codec;
										codec2.AvailableBytesIn = (int)array8;
										object obj4 = num4 - codec2.NextIn;
										long totalBytesIn = codec2.TotalBytesIn + obj4;
										codec2.TotalBytesIn = totalBytesIn;
										ZlibCodec codec3 = _codec;
										codec3.NextIn = num4;
										writeAt = num12;
										return Flush(r2);
									}
								}
								goto IL_1819;
							}
							goto IL_189c;
						}
						bool flag3 = inflateBlockMode == InflateBlockMode.TABLE;
						zlibCodec = (ZlibCodec)num5;
						if (!flag3)
						{
							if (inflateBlockMode == InflateBlockMode.BTREE)
							{
								goto IL_1d84;
							}
							if (inflateBlockMode == InflateBlockMode.DTREE)
							{
								goto IL_1e2e;
							}
							bool flag4 = inflateBlockMode == InflateBlockMode.CODES;
							array2 = array;
							num8 = (int)array3;
							array5 = (int[])(object)array4;
							array7 = array6;
							if (flag4)
							{
								goto IL_1a42;
							}
							if (inflateBlockMode == InflateBlockMode.DRY)
							{
								goto IL_1afc;
							}
							if (inflateBlockMode == InflateBlockMode.DONE)
							{
								goto IL_1b3d;
							}
							if (inflateBlockMode != InflateBlockMode.BAD)
							{
								bitk = num5;
								bitb = num6;
								ZlibCodec codec4 = _codec;
								codec4.AvailableBytesIn = (int)array8;
								object obj5 = num4 - codec4.NextIn;
								long totalBytesIn2 = codec4.TotalBytesIn + obj5;
								codec4.TotalBytesIn = totalBytesIn2;
								ZlibCodec codec5 = _codec;
								codec5.NextIn = num4;
								writeAt = num2;
								return Flush(-2);
							}
						}
						else
						{
							while ((nint)zlibCodec < 14)
							{
								if (array8 != null)
								{
									int[] array9 = (int[])(array8 - 1);
									ZlibCodec codec6 = _codec;
									object obj6 = num4 + codec6.InputBuffer;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S0_v452+10]");
									object obj7 = (nint)0 << (int)zlibCodec;
									int num15 = obj7 | num6;
									ZlibCodec zlibCodec2 = (ZlibCodec)(zlibCodec + 8);
									int num16 = num4 + 1;
									num4 = num16;
									zlibCodec = zlibCodec2;
									r3 = 0;
									num6 = num15;
									array8 = array9;
									continue;
								}
								goto IL_189c;
							}
							int num17 = num6 & 0x3FFF;
							table = num17;
							int num18 = num6 & 0x1F;
							if (num18 <= 29)
							{
								int num19 = num6 >> 5;
								int num20 = num19 & 0x1F;
								if (num20 < 30)
								{
									object obj8 = num18 + 258;
									int num21 = num20 + obj8;
									Array array10 = (Array)obj2;
									if (obj2 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ S0_v433 (System.Array)+C]");
										if ((nint)0 >= (nint)num21)
										{
											Array.Clear((Array)obj2, 0, num21);
											goto IL_0a3d;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
									obj2 = obj9;
									goto IL_0a3d;
								}
							}
							mode = InflateBlockMode.BAD;
							ZlibCodec codec7 = _codec;
							codec7.Message = "too many length or distance symbols";
							num5 = (int)zlibCodec;
						}
					}
					else
					{
						while (num5 < 32)
						{
							bool flag5 = array8 == null;
							zlibCodec = (ZlibCodec)num5;
							if (!flag5)
							{
								int[] array11 = (int[])(array8 - 1);
								ZlibCodec codec8 = _codec;
								object obj10 = num4 + codec8.InputBuffer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v127+10]");
								int num22 = (int)((nint)0 << num5);
								int num23 = num22 | num6;
								int num24 = num5 + 8;
								int num25 = num4 + 1;
								num4 = num25;
								num5 = num24;
								r3 = 0;
								num6 = num23;
								array8 = array11;
								continue;
							}
							goto IL_189c;
						}
						int num26 = num6 ^ -1;
						int num27 = num26 >> 16;
						int num28 = num6 & 0xFFFF;
						if (num27 == num28)
						{
							left = num27;
							InflateBlockMode inflateBlockMode2;
							if (num27 != 0)
							{
								inflateBlockMode2 = InflateBlockMode.STORED;
							}
							else
							{
								inflateBlockMode2 = InflateBlockMode.DRY;
								if (last == 0)
								{
									inflateBlockMode2 = InflateBlockMode.TYPE;
								}
							}
							mode = inflateBlockMode2;
							array2 = array;
							num8 = (int)array3;
							array5 = (int[])(object)array4;
							array7 = array6;
							num5 = 0;
							num6 = 0;
							num7 = (int)array8;
							break;
						}
						mode = InflateBlockMode.BAD;
						ZlibCodec codec9 = _codec;
						codec9.Message = "invalid stored block lengths";
					}
					goto IL_1bce;
				}
				while ((nint)zlibCodec < 3)
				{
					if (array8 != null)
					{
						int[] array12 = (int[])(array8 - 1);
						ZlibCodec codec10 = _codec;
						object obj11 = num4 + codec10.InputBuffer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v88+10]");
						object obj12 = (nint)0 << (int)zlibCodec;
						int num29 = obj12 | num6;
						ZlibCodec zlibCodec3 = (ZlibCodec)(zlibCodec + 8);
						int num30 = num4 + 1;
						num4 = num30;
						zlibCodec = zlibCodec3;
						r3 = 0;
						num6 = num29;
						array8 = array12;
						continue;
					}
					goto IL_189c;
				}
				int num31 = num6 & 1;
				last = num31;
				int num32 = num6 >> 1;
				int num33 = num32 & 3;
				object obj13 = num33 - 1;
				if (num33 != 1)
				{
					if ((nint)obj13 != 1)
					{
						if ((nint)obj13 != 2)
						{
							int num34 = num6 >> 3;
							object obj14 = zlibCodec - 3;
							int[] array13 = (int[])(obj14 & 7);
							int num35 = num34 >> (int)array13;
							int num36 = obj14 - (object)array13;
							inflateBlockMode = InflateBlockMode.LENS;
							array6 = array13;
							num5 = num36;
							num6 = num35;
							goto IL_188d;
						}
						mode = InflateBlockMode.BAD;
						ZlibCodec codec11 = _codec;
						codec11.Message = "invalid block type";
						int num37 = zlibCodec - 3;
						bitk = num37;
						int num38 = num6 >> 3;
						bitb = num38;
						goto IL_1c0f;
					}
					int num39 = num6 >> 3;
					int num40 = zlibCodec - 3;
					inflateBlockMode = InflateBlockMode.TABLE;
					num5 = num40;
					num6 = num39;
					goto IL_188d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				int num41 = InfTree.inflate_trees_fixed(array14, array15, array16, array17, zlibCodec);
				array = array17[0];
				codes.Init(array14[0], array15[0], array16[0], 0, array17[0], 0);
				int num42 = num6 >> 3;
				int num43 = zlibCodec - 3;
				bool flag6 = false;
				int num44 = 0;
				array3 = array17;
				array4 = array16;
				inflateBlockMode = InflateBlockMode.CODES;
				array6 = array15;
				num5 = num43;
				num6 = num42;
				goto IL_188d;
				IL_192d:
				bitk = num5;
				bitb = num6;
				ZlibCodec codec12 = _codec;
				codec12.AvailableBytesIn = (int)array8;
				object obj15 = num4 - codec12.NextIn;
				long totalBytesIn3 = codec12.TotalBytesIn + obj15;
				codec12.TotalBytesIn = totalBytesIn3;
				ZlibCodec codec13 = _codec;
				codec13.NextIn = num4;
				writeAt = num2;
				int r4;
				return Flush(r4);
				IL_1a42:
				bitk = num5;
				bitb = num6;
				ZlibCodec codec14 = _codec;
				codec14.AvailableBytesIn = (int)array8;
				int num45 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ S0_v490 (Ionic.Zlib.ZlibCodec)+C]");
				object obj16 = (nint)num45 - (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ S0_v490 (Ionic.Zlib.ZlibCodec)+18]");
				object obj17 = 0 + obj16;
				ZlibCodec codec15 = _codec;
				codec15.NextIn = num4;
				writeAt = num2;
				int num46 = codes.Process(this, r3);
				if (num46 != 1)
				{
					return Flush(num46);
				}
				ZlibCodec codec16 = _codec;
				int num47;
				if (writeAt < readAt)
				{
					object obj18 = readAt - writeAt;
					num47 = obj18 - 1;
				}
				else
				{
					num47 = end - writeAt;
				}
				if (last == 0)
				{
					mode = InflateBlockMode.TYPE;
					num2 = writeAt;
					num3 = num47;
					num4 = codec16.NextIn;
					num5 = bitk;
					r3 = 0;
					num6 = bitb;
					num7 = codec16.AvailableBytesIn;
					break;
				}
				mode = InflateBlockMode.DRY;
				num2 = writeAt;
				num4 = codec16.NextIn;
				num5 = bitk;
				r3 = 0;
				num6 = bitb;
				array8 = (int[])codec16.AvailableBytesIn;
				goto IL_1afc;
				IL_0a3d:
				int num48 = zlibCodec - 14;
				mode = InflateBlockMode.BTREE;
				index = 0;
				int num49 = num6 >> 14;
				num5 = num48;
				num6 = num49;
				goto IL_1d84;
				IL_1c0f:
				ZlibCodec codec17 = _codec;
				codec17.AvailableBytesIn = (int)array8;
				object obj19 = num4 - codec17.NextIn;
				long totalBytesIn4 = codec17.TotalBytesIn + obj19;
				codec17.TotalBytesIn = totalBytesIn4;
				ZlibCodec codec18 = _codec;
				codec18.NextIn = num4;
				writeAt = num2;
				return Flush(-3);
				IL_189c:
				bitk = (int)zlibCodec;
				bitb = num6;
				ZlibCodec codec19 = _codec;
				codec19.AvailableBytesIn = 0;
				object obj20 = num4 - codec19.NextIn;
				long totalBytesIn5 = codec19.TotalBytesIn + obj20;
				codec19.TotalBytesIn = totalBytesIn5;
				ZlibCodec codec20 = _codec;
				codec20.NextIn = num4;
				writeAt = num2;
				return Flush(r3);
				IL_1819:
				ZlibCodec codec21 = _codec;
				bool flag7 = left > (nint)array8;
				int num50 = (int)array8;
				if (!flag7)
				{
					num50 = left;
				}
				flag6 = num50 > num10;
				num44 = num10;
				if (!flag6)
				{
					num44 = num50;
				}
				Array.Copy(codec21.InputBuffer, num4, window, num9, num44);
				int num51 = num4 + num44;
				int num52 = array8 - num44;
				int num53 = num44 + num9;
				int num54 = num10 - num44;
				int num55 = (left -= num44);
				num2 = num53;
				num3 = num54;
				array2 = null;
				num8 = (int)array3;
				array5 = (int[])(object)array4;
				array7 = array6;
				num4 = num51;
				r3 = 0;
				num7 = num52;
				if (num55 == 0)
				{
					InflateBlockMode inflateBlockMode3 = InflateBlockMode.DRY;
					if (last == 0)
					{
						inflateBlockMode3 = InflateBlockMode.TYPE;
					}
					mode = inflateBlockMode3;
					num2 = num53;
					num3 = num54;
					array2 = null;
					num8 = (int)array3;
					array5 = (int[])(object)array4;
					array7 = array6;
					num4 = num51;
					r3 = 0;
					num7 = num52;
				}
				break;
				IL_188d:
				mode = inflateBlockMode;
				continue;
				IL_1bce:
				bitk = num5;
				bitb = num6;
				goto IL_1c0f;
				IL_1afc:
				writeAt = num2;
				int num56 = Flush(r3);
				if (writeAt < readAt)
				{
					bool flag8 = readAt != writeAt;
					num2 = writeAt;
					r4 = num56;
					if (flag8)
					{
						goto IL_192d;
					}
					mode = InflateBlockMode.DONE;
					num2 = writeAt;
				}
				goto IL_1b3d;
				IL_1e2e:
				int num77;
				int num78;
				while (true)
				{
					int num57 = table & 0x1F;
					object obj21 = num57 + 258;
					int num58 = table >> 5;
					int num59 = num58 & 0x1F;
					object obj22 = obj21 + num59;
					if (index >= (nint)obj22)
					{
						break;
					}
					int[] array18 = bb;
					zlibCodec = (ZlibCodec)num5;
					while ((nint)zlibCodec < array18[0])
					{
						if (array8 != null)
						{
							int[] array19 = (int[])(array8 - 1);
							ZlibCodec codec22 = _codec;
							object obj23 = num4 + codec22.InputBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S0_v345+10]");
							object obj24 = (nint)0 << (int)zlibCodec;
							int num60 = obj24 | num6;
							ZlibCodec zlibCodec4 = (ZlibCodec)(zlibCodec + 8);
							int num61 = num4 + 1;
							num4 = num61;
							zlibCodec = zlibCodec4;
							r3 = 0;
							num6 = num60;
							array8 = array19;
							continue;
						}
						goto IL_189c;
					}
					int[] array20 = tb;
					int[] array21 = tb;
					int num62 = array18[0] << 2;
					object obj25 = InternalInflateConstants.InflateMask + num62;
					int num63 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ S6_v20+10]");
					int num64 = (int)((nint)num63 & (nint)0);
					object obj26 = num64 + array20[0];
					object obj27 = obj26 * 3;
					object obj28 = obj27 + 1;
					object obj29 = obj28 << 2;
					object obj30 = (object)hufts + obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S4_v17+10]");
					object obj31 = (nint)0 << 2;
					object obj32 = (object)InternalInflateConstants.InflateMask + obj31;
					int num65 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ S3_v41+10]");
					int num66 = (int)((nint)num65 & (nint)0);
					object obj33 = array21[0] + num66;
					object obj34 = obj33 * 3;
					object obj35 = obj34 + 2;
					object obj36 = obj35 << 2;
					object obj37 = (object)hufts + obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S0_v262+10]");
					if ((nint)0 <= (nint)15)
					{
						ZlibCodec zlibCodec5 = zlibCodec;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S4_v17+10]");
						int num67 = zlibCodec5 - 0;
						int num68 = index + 1;
						index = num68;
						int num69 = index << 2;
						object obj38 = blens + num69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S0_v262+10]");
						_ = 0;
						int num70 = num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S4_v17+10]");
						int num71 = num70 >> 0;
						num5 = num67;
						num6 = num71;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S0_v262+10]");
					object obj39;
					object obj40;
					if ((nint)0 == 18)
					{
						obj39 = 11;
						obj40 = 7;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S0_v262+10]");
						obj40 = -14;
						obj39 = 3;
					}
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S4_v17+10]");
						object obj41 = 0 + obj40;
						if (System.Runtime.CompilerServices.Unsafe.As<ZlibCodec, UIntPtr>(ref zlibCodec) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41))
						{
							break;
						}
						if (array8 != null)
						{
							int[] array22 = (int[])(array8 - 1);
							ZlibCodec codec23 = _codec;
							object obj42 = num4 + codec23.InputBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ S0_v317+10]");
							object obj43 = (nint)0 << (int)zlibCodec;
							int num72 = obj43 | num6;
							ZlibCodec zlibCodec6 = (ZlibCodec)(zlibCodec + 8);
							int num73 = num4 + 1;
							num4 = num73;
							zlibCodec = zlibCodec6;
							r3 = 0;
							num6 = num72;
							array8 = array22;
							continue;
						}
						goto IL_189c;
					}
					int num74 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S4_v17+10]");
					int num75 = num74 >> 0;
					object obj44 = obj40 << 2;
					object obj45 = (object)InternalInflateConstants.InflateMask + obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1578 @ S1_v184+10]");
					int num76 = (int)((nint)num75 & (nint)0);
					object obj46 = num76 + obj39;
					ZlibCodec zlibCodec7 = zlibCodec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ S4_v17+10]");
					object obj47 = zlibCodec7 - 0;
					num77 = obj47 - obj40;
					num78 = num75 >> (int)obj40;
					object obj48 = obj46 + index;
					int num79 = table & 0x1F;
					object obj49 = num79 + 258;
					int num80 = table >> 5;
					int num81 = num80 & 0x1F;
					object obj50 = obj49 + num81;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S0_v262+10]");
						bool flag9 = (nint)0 != 16;
						if (flag9 || index > 0)
						{
							bool flag10 = !flag9;
							bool flag11 = !flag10;
							object obj51 = 0;
							if (!flag11)
							{
								object obj52 = index - 1;
								object obj53 = obj52 << 2;
								object obj54 = obj2 + obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ S0_v308+10]");
								obj51 = 0;
							}
							object obj55 = obj46;
							int num82 = index;
							obj55 = obj56;
							num82 = num83;
							int num85;
							object obj58;
							do
							{
								int num84 = num82 << 2;
								object obj57 = obj2 + num84;
								num85 = num82 + 1;
								obj58 = obj55 - 1;
							}
							while (obj58 != null);
							index = num85;
							num5 = num77;
							num6 = num78;
							continue;
						}
					}
					goto IL_129e;
				}
				int[] array23 = tb;
				array23[0] = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				array24[0] = 9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				array25[0] = 6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				int num86 = table & 0x1F;
				int nl = num86 + 257;
				int num87 = table >> 5;
				int num88 = num87 & 0x1F;
				int nd = num88 + 1;
				int num89 = inftree.inflate_trees_dynamic(nl, nd, blens, array24, array25, array26, array27, hufts, _codec);
				object obj59 = num89 + 3;
				if (obj59 != null)
				{
					if ((nint)obj59 != 1 && (nint)obj59 != 2 && (nint)obj59 == 3)
					{
						num44 = array26[0];
						array2 = hufts;
						codes.Init(array24[0], array25[0], hufts, array26[0], hufts, array27[0]);
						mode = InflateBlockMode.CODES;
						flag6 = (byte)array27[0] != 0;
						num8 = num89;
						array5 = array27;
						array7 = array26;
						goto IL_1a42;
					}
				}
				else
				{
					blens = null;
					mode = InflateBlockMode.BAD;
				}
				bitk = num5;
				bitb = num6;
				ZlibCodec codec24 = _codec;
				codec24.AvailableBytesIn = (int)array8;
				object obj60 = num4 - codec24.NextIn;
				long totalBytesIn6 = codec24.TotalBytesIn + obj60;
				codec24.TotalBytesIn = totalBytesIn6;
				ZlibCodec codec25 = _codec;
				codec25.NextIn = num4;
				writeAt = num2;
				return Flush(num89);
				IL_1d84:
				while (true)
				{
					int num90 = table >> 10;
					object obj61 = num90 + 4;
					bool flag12 = index < (nint)obj61;
					bool flag13 = !flag12;
					zlibCodec = (ZlibCodec)num5;
					if (flag13)
					{
						break;
					}
					while ((nint)zlibCodec < 3)
					{
						if (array8 != null)
						{
							int[] array28 = (int[])(array8 - 1);
							ZlibCodec codec26 = _codec;
							object obj62 = num4 + codec26.InputBuffer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ S0_v406+10]");
							object obj63 = (nint)0 << (int)zlibCodec;
							int num91 = obj63 | num6;
							ZlibCodec zlibCodec8 = (ZlibCodec)(zlibCodec + 8);
							int num92 = num4 + 1;
							num4 = num92;
							zlibCodec = zlibCodec8;
							r3 = 0;
							num6 = num91;
							array8 = array28;
							continue;
						}
						goto IL_189c;
					}
					int num93 = index + 1;
					index = num93;
					int num94 = index << 2;
					object obj64 = border + num94;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ S1_v270+10]");
					object obj65 = (nint)0 << 2;
					object obj66 = (object)blens + obj65;
					int num95 = num6 & 7;
					int num96 = num6 >> 3;
					int num97 = zlibCodec - 3;
					num5 = num97;
					num6 = num96;
				}
				while (index < 19)
				{
					int num98 = index + 1;
					index = num98;
					int num99 = index << 2;
					object obj67 = border + num99;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ S1_v260+10]");
					object obj68 = (nint)0 << 2;
					object obj69 = (object)blens + obj68;
					_ = 0;
				}
				int[] array29 = bb;
				array29[0] = 7;
				int num100 = inftree.inflate_trees_bits(blens, bb, tb, hufts, _codec);
				object obj70 = num100 + 3;
				if (obj70 != null)
				{
					bool flag14 = (nint)obj70 == 1;
					r4 = num100;
					if (!flag14)
					{
						bool flag15 = (nint)obj70 == 2;
						r4 = num100;
						if (!flag15)
						{
							if ((nint)obj70 == 3)
							{
								mode = InflateBlockMode.DTREE;
								index = 0;
								goto IL_1e2e;
							}
							r4 = num100;
						}
					}
				}
				else
				{
					blens = null;
					mode = InflateBlockMode.BAD;
					r4 = num100;
				}
				goto IL_192d;
				IL_129e:
				blens = null;
				mode = InflateBlockMode.BAD;
				ZlibCodec codec27 = _codec;
				codec27.Message = "invalid bit length repeat";
				num5 = num77;
				num6 = num78;
				goto IL_1bce;
				IL_1b3d:
				bitk = num5;
				bitb = num6;
				ZlibCodec codec28 = _codec;
				codec28.AvailableBytesIn = (int)array8;
				object obj71 = num4 - codec28.NextIn;
				long totalBytesIn7 = codec28.TotalBytesIn + obj71;
				codec28.TotalBytesIn = totalBytesIn7;
				ZlibCodec codec29 = _codec;
				codec29.NextIn = num4;
				writeAt = num2;
				return Flush(1);
			}
		}
	}

	internal void Free()
	{
		uint num = Reset();
		window = null;
		hufts = null;
	}

	internal void SetDictionary(byte[] d, int start, int n)
	{
		Array.Copy(d, start, window, 0, n);
		readAt = n;
		writeAt = n;
	}

	internal int SyncPoint()
	{
		return (mode == InflateBlockMode.LENS) ? 1 : 0;
	}

	internal int Flush(int r)
	{
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected I4, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		object obj = this - -64;
		object obj2 = this + 72;
		object obj3 = default;
		int num4 = default;
		while (true)
		{
			if ((nint)obj3 < 2)
			{
				object obj4;
				if (obj3 != null)
				{
					obj4 = obj2;
				}
				else
				{
					bool flag = readAt > (nint)obj2;
					obj4 = obj;
					if (!flag)
					{
						obj4 = obj2;
					}
				}
				int num = obj4 - readAt;
				if ((nint)obj4 == readAt)
				{
					break;
				}
				ZlibCodec codec = _codec;
				bool flag2 = codec.AvailableBytesOut < num;
				int num2 = codec.AvailableBytesOut;
				if (!flag2)
				{
					num2 = num;
				}
				int availableBytesOut = codec.AvailableBytesOut - num2;
				codec.AvailableBytesOut = availableBytesOut;
				ZlibCodec codec2 = _codec;
				long totalBytesOut = codec2.TotalBytesOut + num2;
				codec2.TotalBytesOut = totalBytesOut;
				if (checkfn != null)
				{
					ZlibCodec codec3 = _codec;
					codec3._Adler32 = (check = Adler.Adler32(check, window, readAt, num2));
				}
				ZlibCodec codec4 = _codec;
				Array.Copy(window, readAt, codec4.OutputBuffer, codec4.NextOut, num2);
				ZlibCodec codec5 = _codec;
				int nextOut = num2 + codec5.NextOut;
				codec5.NextOut = nextOut;
				int num3 = (readAt = num2 + readAt);
				num4 = 0;
				if (num2 == 0)
				{
					num4 = num4;
				}
				if (num4 != -5)
				{
					num4 = num4;
				}
				object obj5;
				if (obj3 == null && num3 == end)
				{
					readAt = 0;
					bool flag3 = writeAt != num3;
					obj5 = 0;
					if (!flag3)
					{
						obj2 = 0;
						obj5 = 0;
					}
				}
				else
				{
					obj5 = obj3 + 1;
				}
				obj3 = obj5 + 1;
				continue;
			}
			return num4;
		}
		bool flag4 = num4 == -5;
		int result = 0;
		if (!flag4)
		{
			result = num4;
		}
		return result;
	}

	static InflateBlocks()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.C133E473E5E653C5C4AEDB8BCC1C1A3A44D384FC0B6C0FCF04672B1B325EC01B));
		border = (int[])array;
	}
}
