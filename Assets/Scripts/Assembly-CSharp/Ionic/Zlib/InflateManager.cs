using Cpp2ILInjected;

namespace Ionic.Zlib;

internal sealed class InflateManager
{
	private enum InflateManagerMode
	{
		METHOD,
		FLAG,
		DICT4,
		DICT3,
		DICT2,
		DICT1,
		DICT0,
		BLOCKS,
		CHECK4,
		CHECK3,
		CHECK2,
		CHECK1,
		DONE,
		BAD
	}

	private const int PRESET_DICT = 32;

	private const int Z_DEFLATED = 8;

	private InflateManagerMode mode;

	internal ZlibCodec _codec;

	internal int method;

	internal uint computedCheck;

	internal uint expectedCheck;

	internal int marker;

	private bool _handleRfc1950HeaderBytes = true;

	internal int wbits;

	internal InflateBlocks blocks;

	private static readonly byte[] mark;

	internal bool HandleRfc1950HeaderBytes
	{
		get
		{
			return _handleRfc1950HeaderBytes;
		}
		set
		{
			_handleRfc1950HeaderBytes = value;
		}
	}

	public InflateManager()
	{
	}

	public InflateManager(bool expectRfc1950HeaderBytes)
	{
		_handleRfc1950HeaderBytes = expectRfc1950HeaderBytes;
	}

	internal int Reset()
	{
		//IL_0022: Expected I8, but got I4
		//IL_0030: Expected I8, but got I4
		ZlibCodec codec = _codec;
		codec.Message = null;
		codec.TotalBytesIn = 0L;
		codec.TotalBytesOut = 0L;
		InflateManagerMode inflateManagerMode = InflateManagerMode.METHOD;
		if (!_handleRfc1950HeaderBytes)
		{
			inflateManagerMode = InflateManagerMode.BLOCKS;
		}
		mode = inflateManagerMode;
		uint num = blocks.Reset();
		return 0;
	}

	internal int End()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I4
		if (blocks != null)
		{
			blocks.Free();
		}
		object obj = this + 40;
		obj = 0;
		return 0;
	}

	internal int Initialize(ZlibCodec codec, int w)
	{
		_codec = codec;
		ZlibCodec codec2 = _codec;
		codec2.Message = null;
		blocks = null;
		int num = w & -8;
		ZlibException ex = default;
		if (num != 8)
		{
			int num2 = End();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("Bad window size.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		((InflateManager)(object)ex).wbits = w;
		object checkfn = ex;
		if (!((InflateManager)(object)ex)._handleRfc1950HeaderBytes)
		{
			checkfn = null;
		}
		int w2 = 1 << w;
		InflateBlocks inflateBlocks = default;
		inflateBlocks._002Ector(codec, checkfn, w2);
		((InflateManager)(object)ex).blocks = inflateBlocks;
		int num3 = ((InflateManager)(object)ex).Reset();
		return 0;
	}

	internal int Inflate(FlushType flush)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1091: Expected I4, but got Obj
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_0522: Expected Obj, but got I
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I4
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_05ac: Expected Obj, but got I
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected Obj, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_079e: Expected Obj, but got I
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected I4, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_08a5: Expected Obj, but got I
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected I4, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_0a08: Expected Obj, but got I4
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Expected Obj, but got Unknown
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected Obj, but got Unknown
		//IL_0d1e: Expected Obj, but got I
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected I4, but got Unknown
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Expected Obj, but got Unknown
		//IL_0e25: Expected Obj, but got I
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Expected I4, but got Unknown
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		ZlibCodec codec = _codec;
		if (codec.InputBuffer != null)
		{
			int num = -5;
			int result;
			ZlibException ex = default;
			ZlibException ex2 = default;
			object arg = default;
			object arg2 = default;
			while (true)
			{
				if (mode != InflateManagerMode.METHOD)
				{
					if (mode != InflateManagerMode.FLAG)
					{
						if (mode != InflateManagerMode.DICT4)
						{
							if (mode != InflateManagerMode.DICT3)
							{
								if (mode != InflateManagerMode.DICT2)
								{
									if (mode != InflateManagerMode.DICT1)
									{
										if (mode != InflateManagerMode.DICT0)
										{
											if (mode == InflateManagerMode.BLOCKS)
											{
												int num2 = blocks.Process(num);
												object obj3 = num2 + 3;
												if (obj3 != null)
												{
													bool flag = (nint)obj3 == 1;
													result = num2;
													if (flag)
													{
														break;
													}
													bool flag2 = (nint)obj3 == 2;
													result = num2;
													if (flag2)
													{
														break;
													}
													bool flag3 = (nint)obj3 == 3;
													result = num2;
													if (flag3)
													{
														break;
													}
													if ((nint)obj3 != 4)
													{
														result = num2;
														break;
													}
													uint num3 = blocks.Reset();
													computedCheck = num3;
													if (~(_handleRfc1950HeaderBytes ? 1u : 0u) != 0)
													{
														mode = InflateManagerMode.DONE;
														result = 1;
														break;
													}
													mode = InflateManagerMode.CHECK4;
													num = 0;
												}
												else
												{
													marker = 0;
													mode = InflateManagerMode.BAD;
													num = -3;
												}
												continue;
											}
											if (mode == InflateManagerMode.CHECK4)
											{
												ZlibCodec codec2 = _codec;
												bool flag4 = codec2.AvailableBytesIn == 0;
												result = num;
												if (flag4)
												{
													break;
												}
												int availableBytesIn = codec2.AvailableBytesIn - 1;
												codec2.AvailableBytesIn = availableBytesIn;
												ZlibCodec codec3 = _codec;
												long totalBytesIn = codec3.TotalBytesIn + 1;
												codec3.TotalBytesIn = totalBytesIn;
												ZlibCodec codec4 = _codec;
												int nextIn = codec4.NextIn + 1;
												codec4.NextIn = nextIn;
												object obj4 = codec4.NextIn + codec4.InputBuffer;
												mode = InflateManagerMode.CHECK3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v203+10]");
												uint num4 = (uint)((nint)0 << 24);
												expectedCheck = num4;
												num = 0;
												continue;
											}
											if (mode == InflateManagerMode.CHECK3)
											{
												ZlibCodec codec5 = _codec;
												bool flag5 = codec5.AvailableBytesIn == 0;
												result = num;
												if (flag5)
												{
													break;
												}
												int availableBytesIn2 = codec5.AvailableBytesIn - 1;
												codec5.AvailableBytesIn = availableBytesIn2;
												ZlibCodec codec6 = _codec;
												long totalBytesIn2 = codec6.TotalBytesIn + 1;
												codec6.TotalBytesIn = totalBytesIn2;
												ZlibCodec codec7 = _codec;
												int nextIn2 = codec7.NextIn + 1;
												codec7.NextIn = nextIn2;
												object obj5 = codec7.NextIn + codec7.InputBuffer;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S0_v223+10]");
												object obj6 = (nint)0 << 16;
												uint num5 = (uint)(int)(obj6 + expectedCheck);
												mode = InflateManagerMode.CHECK2;
												expectedCheck = num5;
												num = 0;
												continue;
											}
											if (mode == InflateManagerMode.CHECK2)
											{
												ZlibCodec codec8 = _codec;
												bool flag6 = codec8.AvailableBytesIn == 0;
												result = num;
												if (flag6)
												{
													break;
												}
												int availableBytesIn3 = codec8.AvailableBytesIn - 1;
												codec8.AvailableBytesIn = availableBytesIn3;
												ZlibCodec codec9 = _codec;
												long totalBytesIn3 = codec9.TotalBytesIn + 1;
												codec9.TotalBytesIn = totalBytesIn3;
												ZlibCodec codec10 = _codec;
												int nextIn3 = codec10.NextIn + 1;
												codec10.NextIn = nextIn3;
												object obj7 = codec10.NextIn + codec10.InputBuffer;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S0_v245+10]");
												object obj8 = (nint)0 << 8;
												uint num6 = (uint)(int)(obj8 + expectedCheck);
												mode = InflateManagerMode.CHECK1;
												expectedCheck = num6;
												num = 0;
												continue;
											}
											if (mode == InflateManagerMode.CHECK1)
											{
												ZlibCodec codec11 = _codec;
												bool flag7 = codec11.AvailableBytesIn == 0;
												result = num;
												if (flag7)
												{
													break;
												}
												int availableBytesIn4 = codec11.AvailableBytesIn - 1;
												codec11.AvailableBytesIn = availableBytesIn4;
												ZlibCodec codec12 = _codec;
												long totalBytesIn4 = codec12.TotalBytesIn + 1;
												codec12.TotalBytesIn = totalBytesIn4;
												ZlibCodec codec13 = _codec;
												int nextIn4 = codec13.NextIn + 1;
												codec13.NextIn = nextIn4;
												object obj9 = codec13.NextIn + codec13.InputBuffer;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S1_v179+10]");
												uint num7 = (expectedCheck = (uint)((nuint)0u + (nuint)(int)expectedCheck));
												if (computedCheck != num7)
												{
													mode = InflateManagerMode.BAD;
													ZlibCodec codec14 = _codec;
													codec14.Message = "incorrect data check";
													marker = 5;
													num = 0;
													continue;
												}
												mode = InflateManagerMode.DONE;
												result = 1;
												break;
											}
											bool flag8 = mode == InflateManagerMode.DONE;
											result = 1;
											if (flag8)
											{
												break;
											}
											if (mode == InflateManagerMode.BAD)
											{
												ZlibCodec codec15 = _codec;
												string s = "Bad state (" + codec15.Message + ")";
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
												ex._002Ector(s);
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
											ex2._002Ector("Stream error.");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
										}
										((InflateManager)(object)ex2).mode = InflateManagerMode.BAD;
										ZlibCodec codec16 = ((InflateManager)(object)ex2)._codec;
										codec16.Message = "need dictionary";
										((InflateManager)(object)ex2).marker = 0;
										result = -2;
									}
									else
									{
										ZlibCodec codec17 = _codec;
										bool flag9 = codec17.AvailableBytesIn == 0;
										result = num;
										if (!flag9)
										{
											int availableBytesIn5 = codec17.AvailableBytesIn - 1;
											codec17.AvailableBytesIn = availableBytesIn5;
											ZlibCodec codec18 = _codec;
											long totalBytesIn5 = codec18.TotalBytesIn + 1;
											codec18.TotalBytesIn = totalBytesIn5;
											ZlibCodec codec19 = _codec;
											int nextIn5 = codec19.NextIn + 1;
											codec19.NextIn = nextIn5;
											object obj10 = codec19.NextIn + codec19.InputBuffer;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S1_v113+10]");
											uint adler = (expectedCheck = (uint)((nuint)0u + (nuint)(int)expectedCheck));
											ZlibCodec codec20 = _codec;
											codec20._Adler32 = adler;
											mode = InflateManagerMode.DICT0;
											result = 2;
										}
									}
									break;
								}
								ZlibCodec codec21 = _codec;
								bool flag10 = codec21.AvailableBytesIn == 0;
								result = num;
								if (flag10)
								{
									break;
								}
								int availableBytesIn6 = codec21.AvailableBytesIn - 1;
								codec21.AvailableBytesIn = availableBytesIn6;
								ZlibCodec codec22 = _codec;
								long totalBytesIn6 = codec22.TotalBytesIn + 1;
								codec22.TotalBytesIn = totalBytesIn6;
								ZlibCodec codec23 = _codec;
								int nextIn6 = codec23.NextIn + 1;
								codec23.NextIn = nextIn6;
								object obj11 = codec23.NextIn + codec23.InputBuffer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v143+10]");
								object obj12 = (nint)0 << 8;
								uint num8 = (uint)(int)(obj12 + expectedCheck);
								mode = InflateManagerMode.DICT1;
								expectedCheck = num8;
								num = 0;
							}
							else
							{
								ZlibCodec codec24 = _codec;
								bool flag11 = codec24.AvailableBytesIn == 0;
								result = num;
								if (flag11)
								{
									break;
								}
								int availableBytesIn7 = codec24.AvailableBytesIn - 1;
								codec24.AvailableBytesIn = availableBytesIn7;
								ZlibCodec codec25 = _codec;
								long totalBytesIn7 = codec25.TotalBytesIn + 1;
								codec25.TotalBytesIn = totalBytesIn7;
								ZlibCodec codec26 = _codec;
								int nextIn7 = codec26.NextIn + 1;
								codec26.NextIn = nextIn7;
								object obj13 = codec26.NextIn + codec26.InputBuffer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v121+10]");
								object obj14 = (nint)0 << 16;
								uint num9 = (uint)(int)(obj14 + expectedCheck);
								mode = InflateManagerMode.DICT2;
								expectedCheck = num9;
								num = 0;
							}
						}
						else
						{
							ZlibCodec codec27 = _codec;
							bool flag12 = codec27.AvailableBytesIn == 0;
							result = num;
							if (flag12)
							{
								break;
							}
							int availableBytesIn8 = codec27.AvailableBytesIn - 1;
							codec27.AvailableBytesIn = availableBytesIn8;
							ZlibCodec codec28 = _codec;
							long totalBytesIn8 = codec28.TotalBytesIn + 1;
							codec28.TotalBytesIn = totalBytesIn8;
							ZlibCodec codec29 = _codec;
							int nextIn8 = codec29.NextIn + 1;
							codec29.NextIn = nextIn8;
							object obj15 = codec29.NextIn + codec29.InputBuffer;
							mode = InflateManagerMode.DICT3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v101+10]");
							uint num10 = (uint)((nint)0 << 24);
							expectedCheck = num10;
							num = 0;
						}
						continue;
					}
					ZlibCodec codec30 = _codec;
					bool flag13 = codec30.AvailableBytesIn == 0;
					result = num;
					if (flag13)
					{
						break;
					}
					int availableBytesIn9 = codec30.AvailableBytesIn - 1;
					codec30.AvailableBytesIn = availableBytesIn9;
					ZlibCodec codec31 = _codec;
					long totalBytesIn9 = codec31.TotalBytesIn + 1;
					codec31.TotalBytesIn = totalBytesIn9;
					ZlibCodec codec32 = _codec;
					int nextIn9 = codec32.NextIn + 1;
					codec32.NextIn = nextIn9;
					object obj16 = codec32.NextIn + codec32.InputBuffer;
					int num11 = method << 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v77+10]");
					object obj17 = (nint)0 + (nint)num11;
					object obj18 = obj17 / 31;
					object obj19 = obj18 * 31;
					if (obj17 != obj19)
					{
						mode = InflateManagerMode.BAD;
						ZlibCodec codec33 = _codec;
						codec33.Message = "incorrect header check";
						marker = 5;
						num = 0;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v77+10]");
					object obj20 = (nint)0 & (nint)0x20;
					InflateManagerMode inflateManagerMode = InflateManagerMode.DICT4;
					if (obj20 == null)
					{
						inflateManagerMode = InflateManagerMode.BLOCKS;
					}
					mode = inflateManagerMode;
					num = 0;
					continue;
				}
				ZlibCodec codec34 = _codec;
				bool flag14 = codec34.AvailableBytesIn == 0;
				result = num;
				if (flag14)
				{
					break;
				}
				int availableBytesIn10 = codec34.AvailableBytesIn - 1;
				codec34.AvailableBytesIn = availableBytesIn10;
				ZlibCodec codec35 = _codec;
				long totalBytesIn10 = codec35.TotalBytesIn + 1;
				codec35.TotalBytesIn = totalBytesIn10;
				ZlibCodec codec36 = _codec;
				int nextIn10 = codec36.NextIn + 1;
				codec36.NextIn = nextIn10;
				object obj21 = codec36.NextIn + codec36.InputBuffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v19+10]");
				method = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v19+10]");
				int num12 = (int)((nint)0 & (nint)0xF);
				if (num12 != 8)
				{
					mode = InflateManagerMode.BAD;
					ZlibCodec codec37 = _codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v19+10]");
					_ = 0;
					object obj22 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					string message = $"unknown compression method (0x{arg:X2})";
					codec37.Message = message;
					marker = 5;
					num = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v19+10]");
				int num13 = (int)((nint)0 >> 4);
				object obj23 = num13 + 8;
				if (wbits < (nint)obj23)
				{
					mode = InflateManagerMode.BAD;
					ZlibCodec codec38 = _codec;
					int num14 = method >> 4;
					object obj24 = num14 + 8;
					object obj25 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					string message2 = $"invalid window size ({arg2})";
					codec38.Message = message2;
					marker = 5;
					num = 0;
				}
				else
				{
					mode = InflateManagerMode.FLAG;
					num = 0;
				}
			}
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex3 = default;
		ex3._002Ector("InputBuffer is null. ");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex3;
	}

	internal int SetDictionary(byte[] dictionary)
	{
		//IL_0155: Expected I4, but got Obj
		if (mode == InflateManagerMode.DICT0)
		{
			uint num = Adler.Adler32(1u, dictionary, 0, dictionary.Length);
			ZlibCodec codec = _codec;
			if (num == codec._Adler32)
			{
				uint adler = Adler.Adler32(0u, null, 0, 0);
				codec._Adler32 = adler;
				int num2 = 1 << wbits;
				int start;
				int n;
				if (num2 <= dictionary.Length)
				{
					int num3 = num2 - 1;
					start = dictionary.Length - num3;
					n = num3;
				}
				else
				{
					start = 0;
					n = dictionary.Length;
				}
				blocks.SetDictionary(dictionary, start, n);
				mode = InflateManagerMode.BLOCKS;
				return 0;
			}
			return -3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex = default;
		ex._002Ector("Stream error.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex;
	}

	internal int Sync()
	{
		//IL_0126: Expected Obj, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I8, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		if (mode != InflateManagerMode.BAD)
		{
			marker = 0;
			mode = InflateManagerMode.BAD;
		}
		ZlibCodec codec = _codec;
		if (codec.AvailableBytesIn == 0)
		{
			return -5;
		}
		int num = codec.AvailableBytesIn;
		int num2 = codec.NextIn;
		int num3 = marker;
		ZlibCodec codec2;
		while (true)
		{
			codec2 = _codec;
			if (num3 > 3 || num == 0)
			{
				break;
			}
			object obj = num2 + codec2.InputBuffer;
			int num4 = num3 + 1;
			object obj2 = num3 + mark;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+10]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S2_v5+10]");
			if (num5 != 0)
			{
				ZlibCodec codec3 = _codec;
				object obj3 = num2 + codec3.InputBuffer;
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v27+10]");
				if ((nint)0 == 0)
				{
					num4 = 4 - num3;
				}
			}
			int num6 = num2 + 1;
			int num7 = num - 1;
			num = num7;
			num2 = num6;
			num3 = num4;
		}
		object obj4 = num2 - codec2.NextIn;
		long totalBytesIn = codec2.TotalBytesIn + obj4;
		codec2.TotalBytesIn = totalBytesIn;
		ZlibCodec codec4 = _codec;
		codec4.AvailableBytesIn = num;
		codec4.NextIn = num2;
		marker = num3;
		if (num3 == 4)
		{
			int num8 = Reset();
			ZlibCodec codec5 = _codec;
			codec5.TotalBytesOut = codec4.TotalBytesOut;
			codec5.TotalBytesIn = codec4.TotalBytesIn;
			mode = InflateManagerMode.BLOCKS;
			return 0;
		}
		return -3;
	}

	internal int SyncPoint(ZlibCodec z)
	{
		InflateBlocks inflateBlocks = blocks;
		return (inflateBlocks.mode == InflateBlocks.InflateBlockMode.LENS) ? 1 : 0;
	}

	static InflateManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		array[2] = byte.MaxValue;
		array[3] = byte.MaxValue;
		mark = array;
	}
}
