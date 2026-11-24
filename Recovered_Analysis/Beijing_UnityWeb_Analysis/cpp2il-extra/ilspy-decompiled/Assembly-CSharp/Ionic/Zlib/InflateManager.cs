using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

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

	private bool _handleRfc1950HeaderBytes;

	internal int wbits;

	internal InflateBlocks blocks;

	private static readonly byte[] mark;

	internal bool HandleRfc1950HeaderBytes
	{
		get
		{
			return mode == InflateManagerMode.FLAG;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected Obj, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected Obj, but got Unknown
			//IL_022d: Expected Obj, but got I4
			//IL_0236: Expected Obj, but got I4
			//IL_013b: Expected Obj, but got I
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected Obj, but got Unknown
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+30]");
			if ((nint)0 == 0)
			{
				if (value)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					}
				}
				_ = 1;
			}
			object obj3 = obj + 4;
			object obj4 = obj3 + 1;
			obj3 = obj4;
			object obj5 = obj4 << 2;
			object obj6 = obj + obj5;
			obj6 = 64;
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
				object obj8 = (nint)0 << 2;
				object obj9 = obj + obj8;
				if ((nint)obj9 == 64)
				{
					object obj10 = obj + 4;
					if ((nint)obj10 > -1)
					{
						object obj11 = obj10 + -1;
						obj10 = obj11;
					}
					return;
				}
			}
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
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
		return _handleRfc1950HeaderBytes ? 1 : 0;
	}

	internal int End()
	{
		//IL_0022: Expected I8, but got I4
		//IL_0030: Expected I8, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		ZlibCodec codec = _codec;
		ZlibCodec codec2 = _codec;
		codec2.TotalBytesOut = 0L;
		codec.TotalBytesIn = 0L;
		object obj = _codec + 56;
		obj = 0;
		InflateManagerMode inflateManagerMode = ((~(_handleRfc1950HeaderBytes ? 1u : 0u) != 0) ? InflateManagerMode.BLOCKS : InflateManagerMode.METHOD);
		mode = inflateManagerMode;
		int num = blocks.SyncPoint();
		return 0;
	}

	internal int Initialize(ZlibCodec codec, int w)
	{
		//IL_2524: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
		//IL_256d: Expected Obj, but got I
		//IL_259a: Expected I8, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		//IL_01fb: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected I4, but got Unknown
		//IL_0238: Expected I4, but got I8
		//IL_0351: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected I4, but got Unknown
		//IL_25cd: Expected I4, but got Obj
		//IL_25d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d8: Expected Obj, but got Unknown
		//IL_25e8: Expected Obj, but got I
		//IL_260d: Expected I8, but got I4
		//IL_03f3: Expected Obj, but got I
		//IL_289a: Expected I, but got Obj
		//IL_28b0: Expected Obj, but got I
		//IL_2e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e19: Expected Obj, but got Unknown
		//IL_2e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e36: Expected Obj, but got Unknown
		//IL_2e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e43: Expected I8, but got Unknown
		//IL_2e52: Expected Obj, but got I8
		//IL_2e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e60: Expected I4, but got Unknown
		//IL_2e7d: Expected Obj, but got I4
		//IL_2e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8b: Expected Obj, but got Unknown
		//IL_2e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e99: Expected Obj, but got Unknown
		//IL_2ec3: Expected Obj, but got I4
		//IL_2ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed1: Expected Obj, but got Unknown
		//IL_2ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ede: Expected I8, but got Unknown
		//IL_2eee: Expected Obj, but got I4
		//IL_2f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f09: Expected Obj, but got Unknown
		//IL_26dd: Expected I, but got Obj
		//IL_26f3: Expected Obj, but got I
		//IL_2649: Expected Obj, but got I
		//IL_2676: Expected I8, but got I
		//IL_26b9: Expected I4, but got I8
		//IL_26ca: Expected I4, but got Obj
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected Obj, but got Unknown
		//IL_0a9f: Expected I, but got Obj
		//IL_0a8c: Expected Obj, but got I4
		//IL_2bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfc: Expected Obj, but got Unknown
		//IL_2c0c: Expected Obj, but got I4
		//IL_2c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c26: Expected I8, but got Unknown
		//IL_2c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c35: Expected Obj, but got Unknown
		//IL_2c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6b: Expected Obj, but got Unknown
		//IL_2c7b: Expected Obj, but got I
		//IL_2ca8: Expected Obj, but got I4
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0afb: Expected Obj, but got I4
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Expected Obj, but got Unknown
		//IL_0b13: Expected I4, but got Obj
		//IL_0b6a: Expected Obj, but got I4
		//IL_0b7a: Expected I4, but got Obj
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1432: Expected Obj, but got Unknown
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected Obj, but got Unknown
		//IL_0a04: Expected Obj, but got I
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Expected Obj, but got Unknown
		//IL_0a2c: Expected I8, but got Obj
		//IL_056c: Expected I, but got Obj
		//IL_0559: Expected Obj, but got I4
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Expected Obj, but got Unknown
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected I4, but got Unknown
		//IL_0bf0: Expected Obj, but got I4
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got Unknown
		//IL_0c5f: Expected Obj, but got I4
		//IL_0c6f: Expected I4, but got Obj
		//IL_1f7e: Expected Obj, but got I
		//IL_1f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f93: Expected Obj, but got Unknown
		//IL_04c3: Expected Obj, but got I
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04eb: Expected I8, but got Obj
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_2911: Expected I, but got Obj
		//IL_2927: Expected Obj, but got I
		//IL_0e29: Expected Obj, but got I4
		//IL_0e39: Expected I4, but got Obj
		//IL_0cc5: Expected I4, but got Obj
		//IL_0ce2: Expected Obj, but got I4
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected I4, but got Unknown
		//IL_0d61: Expected Obj, but got I4
		//IL_0d71: Expected I4, but got Obj
		//IL_2f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5f: Expected Obj, but got Unknown
		//IL_2f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7c: Expected Obj, but got Unknown
		//IL_2f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f89: Expected I8, but got Unknown
		//IL_2f98: Expected Obj, but got I8
		//IL_2fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa6: Expected I4, but got Unknown
		//IL_2fc3: Expected Obj, but got I4
		//IL_2fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd1: Expected Obj, but got Unknown
		//IL_2fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fdf: Expected Obj, but got Unknown
		//IL_3009: Expected Obj, but got I4
		//IL_3012: Unknown result type (might be due to invalid IL or missing references)
		//IL_3017: Expected Obj, but got Unknown
		//IL_301f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3024: Expected I8, but got Unknown
		//IL_3034: Expected Obj, but got I4
		//IL_304a: Unknown result type (might be due to invalid IL or missing references)
		//IL_304f: Expected Obj, but got Unknown
		//IL_3058: Unknown result type (might be due to invalid IL or missing references)
		//IL_305d: Expected Obj, but got Unknown
		//IL_2747: Expected I, but got Obj
		//IL_275d: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I4
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Expected Obj, but got Unknown
		//IL_0f48: Expected I, but got Obj
		//IL_0f35: Expected Obj, but got I4
		//IL_2ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce9: Expected Obj, but got Unknown
		//IL_2cf9: Expected Obj, but got I4
		//IL_2d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d13: Expected I8, but got Unknown
		//IL_2d22: Expected I4, but got I8
		//IL_2d56: Expected Obj, but got I4
		//IL_2d8c: Expected Obj, but got I4
		//IL_24da: Expected Obj, but got I
		//IL_24ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ef: Expected Obj, but got Unknown
		//IL_109c: Expected I4, but got Obj
		//IL_10b9: Expected Obj, but got I4
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Expected Obj, but got Unknown
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected I4, but got Unknown
		//IL_1130: Expected Obj, but got I4
		//IL_1140: Expected I4, but got Obj
		//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Expected I4, but got Unknown
		//IL_0fbc: Expected Obj, but got I4
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected Obj, but got Unknown
		//IL_0fd4: Expected I4, but got Obj
		//IL_1023: Expected Obj, but got I4
		//IL_1033: Expected I4, but got Obj
		//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected Obj, but got Unknown
		//IL_0ead: Expected Obj, but got I
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected Obj, but got Unknown
		//IL_0ed5: Expected I8, but got Obj
		//IL_06e1: Expected I, but got Obj
		//IL_06ce: Expected Obj, but got I4
		//IL_108d: Expected Obj, but got I4
		//IL_0638: Expected Obj, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_0660: Expected I8, but got Obj
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_27ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_27cf: Expected Obj, but got Unknown
		//IL_27d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27dc: Expected Obj, but got Unknown
		//IL_27e6: Expected Obj, but got I4
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected Obj, but got Unknown
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected I4, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_2a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a21: Expected Obj, but got Unknown
		//IL_2a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2e: Expected Obj, but got Unknown
		//IL_2a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a41: Expected Obj, but got Unknown
		//IL_2a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4e: Expected Obj, but got Unknown
		//IL_2a72: Expected Obj, but got I4
		//IL_2a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a80: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected I4, but got Unknown
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected Obj, but got Unknown
		//IL_2839: Unknown result type (might be due to invalid IL or missing references)
		//IL_283e: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got I4
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected I4, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_2b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b13: Expected Obj, but got Unknown
		//IL_2b2d: Expected I4, but got Obj
		//IL_2b3b: Expected I4, but got Obj
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_0823: Expected I4, but got Obj
		//IL_12d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Expected Obj, but got Unknown
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e7: Expected I4, but got Unknown
		//IL_097d: Expected Obj, but got I4
		//IL_09a9: Expected Obj, but got I4
		//IL_2ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab5: Expected Obj, but got Unknown
		//IL_12b4: Expected Obj, but got I4
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Expected I4, but got Unknown
		//IL_13ab: Expected Obj, but got I4
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_126c: Expected Obj, but got Unknown
		//IL_1274: Expected I4, but got Obj
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_0959: Expected I4, but got Obj
		//IL_137a: Unknown result type (might be due to invalid IL or missing references)
		//IL_137f: Expected Obj, but got Unknown
		//IL_1387: Expected I4, but got Obj
		//IL_1fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd0: Expected Obj, but got Unknown
		//IL_2005: Expected Obj, but got I
		//IL_2015: Unknown result type (might be due to invalid IL or missing references)
		//IL_201a: Expected Obj, but got Unknown
		//IL_206c: Expected Obj, but got I
		//IL_207c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2081: Expected Obj, but got Unknown
		//IL_20d2: Expected Obj, but got I
		//IL_20e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e7: Expected Obj, but got Unknown
		//IL_211f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2124: Expected Obj, but got Unknown
		//IL_2159: Expected Obj, but got I
		//IL_2169: Unknown result type (might be due to invalid IL or missing references)
		//IL_216e: Expected Obj, but got Unknown
		//IL_21c0: Expected Obj, but got I
		//IL_21d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d5: Expected Obj, but got Unknown
		//IL_2225: Expected Obj, but got I
		//IL_2235: Unknown result type (might be due to invalid IL or missing references)
		//IL_223a: Expected Obj, but got Unknown
		//IL_228a: Expected Obj, but got I
		//IL_229a: Unknown result type (might be due to invalid IL or missing references)
		//IL_229f: Expected Obj, but got Unknown
		//IL_2305: Unknown result type (might be due to invalid IL or missing references)
		//IL_230a: Expected Obj, but got Unknown
		//IL_23a4: Expected Obj, but got I
		//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b9: Expected Obj, but got Unknown
		//IL_2373: Expected Obj, but got I4
		//IL_240e: Expected Obj, but got I
		//IL_241e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2423: Expected Obj, but got Unknown
		//IL_2474: Expected Obj, but got I
		//IL_2484: Unknown result type (might be due to invalid IL or missing references)
		//IL_2489: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [codec @ L1 (Ionic.Zlib.ZlibCodec)+2C]");
		object obj = 0;
		bool flag;
		if ((int)codec.CompressLevel < (int)codec._Adler32)
		{
			object obj2 = (int)codec._Adler32 - (int)codec.CompressLevel;
			flag = (byte)(obj2 - 1) != 0;
			CompressionLevel compressionLevel = CompressionLevel.BestSpeed;
		}
		else
		{
			object obj3 = codec - -64;
			flag = (byte)(obj3 - codec.CompressLevel) != 0;
			CompressionLevel compressionLevel = codec.CompressLevel;
		}
		int num = w;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
		uint num2 = 0u;
		long num3 = codec.TotalBytesOut;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [codec @ L1 (Ionic.Zlib.ZlibCodec)+34]");
		long num4 = 0L;
		CompressionLevel compressionLevel2 = codec.CompressLevel;
		bool flag2 = flag;
		CompressionLevel compressLevel = codec.CompressLevel;
		object obj5;
		CompressionLevel compressLevel2 = default;
		uint num5 = default;
		long totalBytesOut = default;
		CompressionLevel compressionLevel3 = default;
		int num7 = default;
		uint num8 = default;
		long num9 = default;
		uint num12 = default;
		long num13 = default;
		int num15 = default;
		CompressionLevel compressionLevel4 = default;
		int num31 = default;
		uint num33 = default;
		int num35 = default;
		uint num37 = default;
		long num38 = default;
		int num40 = default;
		long num51 = default;
		long totalBytesOut2 = default;
		CompressionLevel compressionLevel6 = default;
		uint num72 = default;
		int num74 = default;
		long num82 = default;
		long totalBytesOut3 = default;
		while (true)
		{
			int num30;
			int num32;
			object obj66;
			long num73;
			long num75;
			if (mode != InflateManagerMode.METHOD)
			{
				if (mode != InflateManagerMode.FLAG)
				{
					long num34;
					long num36;
					object obj35;
					if (mode != InflateManagerMode.DICT4)
					{
						if (mode != InflateManagerMode.DICT3)
						{
							object obj13;
							long num10;
							int num11;
							List<Color> list;
							CompressionLevel compressionLevel;
							if (mode != InflateManagerMode.DICT2)
							{
								if (mode != InflateManagerMode.DICT1)
								{
									if (mode != InflateManagerMode.DICT0)
									{
										if (mode != InflateManagerMode.BLOCKS)
										{
											if (mode != InflateManagerMode.CHECK4)
											{
												obj5 = ((mode != InflateManagerMode.CHECK3) ? ((object)116) : ((object)115));
												break;
											}
											compressLevel2 = compressionLevel2;
											object obj6 = obj4;
											num5 = num2;
											totalBytesOut = num3;
											obj5 = 114;
										}
										else
										{
											obj5 = 106;
										}
										break;
									}
									if (!flag2)
									{
										object obj7 = codec - -64;
										CompressionLevel compressLevel3;
										if ((nint)compressionLevel2 == (nint)obj7)
										{
											if (codec._Adler32 != 0)
											{
												bool flag3;
												if ((int)codec._Adler32 > 0)
												{
													flag3 = (byte)(codec._Adler32 - 1) != 0;
												}
												else
												{
													object obj8 = codec - -64;
													flag3 = (byte)(int)obj8 != 0;
												}
												if (flag3)
												{
													compressionLevel2 = CompressionLevel.None;
													flag2 = flag3;
													compressionLevel = (CompressionLevel)(-64);
													goto IL_27bc;
												}
												compressLevel3 = CompressionLevel.None;
											}
											else
											{
												compressLevel3 = compressionLevel2;
											}
										}
										else
										{
											compressLevel3 = compressionLevel2;
										}
										codec.CompressLevel = compressLevel3;
										int num6 = ((InflateManager)(object)codec).Inflate((FlushType)num);
										bool flag4;
										if ((int)codec.CompressLevel < (int)codec._Adler32)
										{
											object obj9 = (int)codec._Adler32 - (int)codec.CompressLevel;
											flag4 = (byte)(obj9 - 1) != 0;
										}
										else
										{
											object obj10 = codec - -64;
											flag4 = (byte)(obj10 - codec.CompressLevel) != 0;
										}
										object obj11 = codec - -64;
										bool flag5 = (nint)codec.CompressLevel == (nint)obj11;
										bool flag6 = !flag5;
										compressionLevel3 = codec.CompressLevel;
										flag2 = flag4;
										if (!flag6)
										{
											bool flag7 = codec._Adler32 == 0;
											compressionLevel3 = codec.CompressLevel;
											flag2 = flag4;
											if (!flag7)
											{
												bool flag8;
												if ((int)codec._Adler32 > 0)
												{
													flag8 = (byte)(codec._Adler32 - 1) != 0;
													compressionLevel3 = CompressionLevel.None;
												}
												else
												{
													object obj12 = codec - -64;
													flag8 = (byte)(int)obj12 != 0;
													compressionLevel3 = CompressionLevel.None;
												}
												flag2 = flag8;
											}
										}
										if (!flag2)
										{
											num7 = num6;
											obj5 = 104;
											break;
										}
										num7 = num6;
										compressionLevel2 = compressionLevel3;
										compressionLevel = (CompressionLevel)(-64);
									}
									goto IL_27bc;
								}
								obj13 = obj4;
								num8 = num2;
								num9 = num3;
								num10 = num4;
								num11 = num;
							}
							else
							{
								num12 = num2;
								num13 = num3;
								long num14 = num4;
								num15 = num;
								object obj14 = obj4;
								while (num13 < (_handleRfc1950HeaderBytes ? 1 : 0))
								{
									if (obj14 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+8]");
										object obj15 = (nint)0 + (nint)16;
										object obj16 = obj15 + num12;
										long num16 = num13 & 0x1F;
										long num17 = obj16 << (int)num16;
										long num18 = num17 | num14;
										long num19 = num13 + 8;
										uint num20 = num12 + 1;
										object obj17 = obj14 - 1;
										num12 = num20;
										num13 = num19;
										num14 = num18;
										num15 = 0;
										obj14 = obj17;
										continue;
									}
									goto IL_06c5;
								}
								nint num21 = (nint)typeof(InternalInflateConstants);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S0_v514 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+BA]");
								object obj18 = (nint)0 & (nint)0x200;
								if (obj18 != null)
								{
									nint num22 = (nint)typeof(InternalInflateConstants);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S0_v527 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj19 = InternalInflateConstants.InflateMask + 16;
								object obj20 = (_handleRfc1950HeaderBytes ? 1u : 0u) << 2;
								object obj21 = obj19 + obj20;
								long num23 = obj21 & num14;
								int num24 = (int)(num23 + wbits);
								wbits = num24;
								long num25 = num13 - (_handleRfc1950HeaderBytes ? 1 : 0);
								mode = InflateManagerMode.DICT1;
								object obj22 = (_handleRfc1950HeaderBytes ? 1 : 0) & 0x1F;
								long num26 = num14 >> (int)obj22;
								obj13 = obj14;
								num8 = num12;
								num9 = num25;
								num10 = num26;
								list = (List<Color>)2;
								num11 = num15;
								compressionLevel = (CompressionLevel)31;
							}
							uint num27 = (uint)(compressionLevel2 - wbits);
							uint num28 = num27;
							while ((int)num28 <= -1)
							{
								object obj23 = codec - -64;
								uint num29 = (uint)(int)(obj23 + num28);
								num28 = num29;
							}
							CompressionLevel compressionLevel5;
							object obj30;
							object obj32;
							object obj33;
							object obj31;
							bool flag15;
							IAsyncResult asyncResult;
							object obj34;
							IAsyncResult asyncResult2;
							for (compressLevel = compressionLevel2; _codec != null; compressionLevel5 = compressLevel + 1, obj30 = codec.dstate + 16, obj31 = obj30 + compressLevel, obj32 = codec.dstate + 16, obj33 = obj32 + num28, obj31 = obj33, flag15 = (byte)((flag2 ? 1u : 0u) - 1u) != 0, asyncResult = (IAsyncResult)(num28 + 1), obj34 = codec - -64, asyncResult2 = ((asyncResult != obj34) ? asyncResult : null), list = (List<Color>)(_codec - 1), _codec = (ZlibCodec)(object)list, flag2 = flag15, num28 = (uint)(int)asyncResult2, compressLevel = compressionLevel5, compressionLevel = (CompressionLevel)this)
							{
								if (flag2)
								{
									continue;
								}
								object obj24 = codec - -64;
								if ((nint)compressLevel == (nint)obj24 && codec._Adler32 != 0)
								{
									bool flag9;
									if ((int)codec._Adler32 > 0)
									{
										flag9 = (byte)(codec._Adler32 - 1) != 0;
									}
									else
									{
										object obj25 = codec - -64;
										flag9 = (byte)(int)obj25 != 0;
									}
									if (flag9)
									{
										flag2 = flag9;
										compressLevel = CompressionLevel.None;
										continue;
									}
									compressLevel = CompressionLevel.None;
								}
								codec.CompressLevel = compressLevel;
								num30 = ((InflateManager)(object)codec).Inflate((FlushType)num11);
								bool flag10;
								if ((int)codec.CompressLevel < (int)codec._Adler32)
								{
									object obj26 = (int)codec._Adler32 - (int)codec.CompressLevel;
									flag10 = (byte)(obj26 - 1) != 0;
								}
								else
								{
									object obj27 = codec - -64;
									flag10 = (byte)(obj27 - codec.CompressLevel) != 0;
								}
								object obj28 = codec - -64;
								bool flag11 = (nint)codec.CompressLevel == (nint)obj28;
								bool flag12 = !flag11;
								compressionLevel4 = codec.CompressLevel;
								flag2 = flag10;
								if (!flag12)
								{
									bool flag13 = codec._Adler32 == 0;
									compressionLevel4 = codec.CompressLevel;
									flag2 = flag10;
									if (!flag13)
									{
										bool flag14;
										if ((int)codec._Adler32 > 0)
										{
											flag14 = (byte)(codec._Adler32 - 1) != 0;
											compressionLevel4 = CompressionLevel.None;
										}
										else
										{
											object obj29 = codec - -64;
											flag14 = (byte)(int)obj29 != 0;
											compressionLevel4 = CompressionLevel.None;
										}
										flag2 = flag14;
									}
								}
								if (flag2)
								{
									num31 = num30;
									num11 = num30;
									compressLevel = compressionLevel4;
									continue;
								}
								goto IL_139a;
							}
							mode = InflateManagerMode.METHOD;
							obj4 = obj13;
							num2 = num8;
							num3 = num9;
							num4 = num10;
							compressionLevel2 = compressLevel;
							num32 = num11;
							goto IL_28f6;
						}
						num33 = num2;
						num34 = num4;
						num35 = num;
						num36 = num3;
						obj35 = obj4;
					}
					else
					{
						num37 = num2;
						num38 = num3;
						long num39 = num4;
						num40 = num;
						obj35 = obj4;
						while (num38 < (_handleRfc1950HeaderBytes ? 1 : 0))
						{
							if (obj35 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+8]");
								object obj36 = (nint)0 + (nint)16;
								object obj37 = obj36 + num37;
								long num41 = num38 & 0x1F;
								long num42 = obj37 << (int)num41;
								long num43 = num42 | num39;
								long num44 = num38 + 8;
								uint num45 = num37 + 1;
								object obj38 = obj35 - 1;
								num37 = num45;
								num38 = num44;
								num39 = num43;
								num40 = 0;
								obj35 = obj38;
								continue;
							}
							goto IL_0550;
						}
						nint num46 = (nint)typeof(InternalInflateConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v378 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+BA]");
						object obj39 = (nint)0 & (nint)0x200;
						if (obj39 != null)
						{
							nint num47 = (nint)typeof(InternalInflateConstants);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S0_v394 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj40 = InternalInflateConstants.InflateMask + 16;
						object obj41 = (_handleRfc1950HeaderBytes ? 1u : 0u) << 2;
						object obj42 = obj40 + obj41;
						long num48 = obj42 & num39;
						ZlibCodec codec2 = (ZlibCodec)(num48 + _codec);
						_codec = codec2;
						long num49 = num38 - (_handleRfc1950HeaderBytes ? 1 : 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+29]");
						expectedCheck = 0u;
						object obj43 = this + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+34]");
						obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+38]");
						computedCheck = 0u;
						mode = InflateManagerMode.DICT3;
						object obj44 = (_handleRfc1950HeaderBytes ? 1 : 0) & 0x1F;
						long num50 = num39 >> (int)obj44;
						num33 = num37;
						num34 = num50;
						num35 = num40;
						num36 = num49;
					}
					num51 = num36;
					long num52 = num34;
					object obj45 = obj35;
					while (num51 < (int)expectedCheck)
					{
						if (obj45 != null)
						{
							object obj46 = obj45 - 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+8]");
							object obj47 = (nint)0 + (nint)16;
							object obj48 = obj47 + num33;
							long num53 = num51 & 0x1F;
							long num54 = obj48 << (int)num53;
							long num55 = num54 | num52;
							long num56 = num51 + 8;
							uint num57 = num33 + 1;
							num51 = num56;
							num52 = num55;
							num33 = num57;
							obj45 = obj46;
							num35 = 0;
							continue;
						}
						goto IL_0f2c;
					}
					nint num58 = (nint)typeof(InternalInflateConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v311 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num59 = (nint)typeof(InternalInflateConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ S0_v343 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj50 = InternalInflateConstants.InflateMask + 16;
					int num60 = (int)(expectedCheck << 2);
					object obj51 = obj50 + num60;
					long num61 = obj51 & num52;
					object obj52 = num61 + (int)computedCheck;
					int num62 = obj52 * 3;
					int num63 = num62 << 2;
					object obj53 = method + num63;
					object obj54 = obj53 + 20;
					object obj55 = obj54 & 0x1F;
					long num64 = num52 >> (int)obj55;
					int num65 = num62 << 2;
					object obj56 = method + num65;
					object obj57 = obj56 + 20;
					long num66 = num51 - obj57;
					object obj58 = method + 16;
					int num67 = num62 << 2;
					object obj59 = obj58 + num67;
					object obj60 = obj59 & 0x10;
					if (obj60 != null)
					{
						bool handleRfc1950HeaderBytes = (byte)(obj59 & 0xF) != 0;
						_handleRfc1950HeaderBytes = handleRfc1950HeaderBytes;
						int num68 = num62 << 2;
						object obj61 = method + num68;
						object obj62 = obj61 + 24;
						wbits = (int)obj62;
						mode = InflateManagerMode.DICT2;
						totalBytesOut2 = num66;
						long num69 = num64;
						obj4 = obj45;
						num2 = num33;
						num3 = num66;
						num4 = num64;
						uint num28 = expectedCheck;
						List<Color> list = (List<Color>)2;
						int num11 = num62;
						compressLevel = (CompressionLevel)obj59;
						CompressionLevel compressionLevel = (CompressionLevel)24;
						num32 = num35;
					}
					else
					{
						object obj63 = obj59 & 0x40;
						long num69;
						if (obj63 != null)
						{
							totalBytesOut2 = num66;
							num69 = num64;
							obj5 = 54;
							break;
						}
						expectedCheck = (uint)(int)obj59;
						int num70 = num62 << 2;
						object obj64 = method + num70;
						object obj65 = obj64 + 24;
						CompressionLevel compressionLevel = (CompressionLevel)(num62 / 3);
						uint num71 = (uint)(int)(obj65 + compressionLevel);
						computedCheck = num71;
						totalBytesOut2 = num66;
						num69 = num64;
						obj4 = obj45;
						num2 = num33;
						num3 = num66;
						num4 = num64;
						uint num28 = expectedCheck;
						List<Color> list = (List<Color>)3;
						int num11 = num62;
						compressLevel = (CompressionLevel)obj59;
						num32 = num35;
					}
					goto IL_28f6;
				}
				compressionLevel6 = compressionLevel2;
				obj66 = obj4;
				num72 = num2;
				num73 = num4;
				num74 = num;
				num75 = num3;
			}
			else
			{
				bool flag16 = (flag2 ? 1 : 0) < 258;
				bool flag17 = (nint)obj4 < 10;
				object obj67 = flag16 | flag17;
				int num76;
				if (obj67 != null)
				{
					compressionLevel6 = compressionLevel2;
					obj66 = obj4;
					num72 = num2;
					num76 = (int)num4;
					num74 = num;
					num75 = num3;
				}
				else
				{
					codec.TotalBytesOut = num3;
					uint num77 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
					object obj68 = (nint)(int)num77 - (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
					object obj69 = obj68 + 0;
					codec.CompressLevel = compressionLevel2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
					List<Color> list = (List<Color>)0;
					InflateBlocks v = blocks;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+29]");
					nint num78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
					nint num79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+30]");
					nint num80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+34]");
					nint num81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+38]");
					IAsyncResult asyncResult3 = ((UIGeometry.OnCustomWrite)null).BeginInvoke((List<Vector3>)(object)v, (List<Vector2>)num78, (List<Color>)num79, (List<Vector3>)num80, (List<Vector4>)num81, (List<Vector4>)0, (AsyncCallback)(object)codec, obj);
					bool flag18;
					if ((int)codec.CompressLevel < (int)codec._Adler32)
					{
						object obj70 = (int)codec._Adler32 - (int)codec.CompressLevel;
						flag18 = (byte)(obj70 - 1) != 0;
					}
					else
					{
						object obj71 = codec - -64;
						flag18 = (byte)(obj71 - codec.CompressLevel) != 0;
					}
					if (asyncResult3 != null)
					{
						InflateManagerMode inflateManagerMode = (((nint)asyncResult3 != 1) ? InflateManagerMode.CHECK3 : InflateManagerMode.BLOCKS);
						mode = inflateManagerMode;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+10]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
						num2 = 0u;
						num3 = codec.TotalBytesOut;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [codec @ L1 (Ionic.Zlib.ZlibCodec)+34]");
						num4 = 0L;
						compressionLevel2 = codec.CompressLevel;
						flag2 = flag18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
						uint num28 = 0u;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [codec @ L1 (Ionic.Zlib.ZlibCodec)+34]");
						int num11 = 0;
						compressLevel = (CompressionLevel)codec.TotalBytesOut;
						CompressionLevel compressionLevel = CompressionLevel.BestSpeed;
						num32 = (int)asyncResult3;
						goto IL_28f6;
					}
					flag2 = flag18;
					compressionLevel6 = codec.CompressLevel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+10]");
					obj66 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
					num72 = 0u;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [codec @ L1 (Ionic.Zlib.ZlibCodec)+34]");
					num76 = 0;
					num74 = 0;
					num75 = codec.TotalBytesOut;
				}
				expectedCheck = (uint)(int)blocks;
				object obj72 = this + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				obj72 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+30]");
				computedCheck = 0u;
				mode = InflateManagerMode.FLAG;
				num73 = num76;
			}
			num82 = num75;
			long num83 = num73;
			while (num82 < (int)expectedCheck)
			{
				if (obj66 != null)
				{
					object obj73 = obj66 - 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+8]");
					object obj74 = (nint)0 + (nint)16;
					object obj75 = obj74 + num72;
					long num84 = num82 & 0x1F;
					long num85 = obj75 << (int)num84;
					long num86 = num85 | num83;
					long num87 = num82 + 8;
					uint num88 = num72 + 1;
					num82 = num87;
					num83 = num86;
					obj66 = obj73;
					num72 = num88;
					num74 = 0;
					continue;
				}
				goto IL_0a83;
			}
			nint num89 = (nint)typeof(InternalInflateConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v159 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+BA]");
			object obj76 = (nint)0 & (nint)0x200;
			if (obj76 != null)
			{
				nint num90 = (nint)typeof(InternalInflateConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S0_v214 (Il2CppClass<Ionic.Zlib.InternalInflateConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj77 = InternalInflateConstants.InflateMask + 16;
			int num91 = (int)(expectedCheck << 2);
			object obj78 = obj77 + num91;
			long num92 = obj78 & num83;
			object obj79 = num92 + (int)computedCheck;
			int num93 = obj79 * 3;
			int num94 = num93 << 2;
			object obj80 = method + num94;
			object obj81 = obj80 + 20;
			object obj82 = obj81 & 0x1F;
			long num95 = num83 >> (int)obj82;
			int num96 = num93 << 2;
			object obj83 = method + num96;
			object obj84 = obj83 + 20;
			long num97 = num82 - obj84;
			object obj85 = method + 16;
			int num98 = num93 << 2;
			object obj86 = obj85 + num98;
			if (obj86 == null)
			{
				int num99 = num93 << 2;
				object obj87 = method + num99;
				object obj88 = obj87 + 24;
				marker = (int)obj88;
				mode = InflateManagerMode.DICT0;
				totalBytesOut3 = num97;
				long num100 = num95;
				obj4 = obj66;
				num2 = num72;
				num3 = num97;
				num4 = num95;
				compressionLevel2 = compressionLevel6;
				uint num28 = expectedCheck;
				List<Color> list = (List<Color>)2;
				int num11 = num93;
				compressLevel = (CompressionLevel)obj86;
				CompressionLevel compressionLevel = (CompressionLevel)24;
				num32 = num74;
			}
			else
			{
				object obj89 = obj86 & 0x10;
				if (obj89 != null)
				{
					bool handleRfc1950HeaderBytes2 = (byte)(obj86 & 0xF) != 0;
					_handleRfc1950HeaderBytes = handleRfc1950HeaderBytes2;
					int num101 = num93 << 2;
					object obj90 = method + num101;
					object codec3 = obj90 + 24;
					_codec = (ZlibCodec)codec3;
					mode = InflateManagerMode.DICT4;
					totalBytesOut3 = num97;
					long num100 = num95;
					obj4 = obj66;
					num2 = num72;
					num3 = num97;
					num4 = num95;
					compressionLevel2 = compressionLevel6;
					uint num28 = expectedCheck;
					List<Color> list = (List<Color>)2;
					int num11 = num93;
					compressLevel = (CompressionLevel)obj86;
					CompressionLevel compressionLevel = (CompressionLevel)24;
					num32 = num74;
				}
				else
				{
					object obj91 = obj86 & 0x40;
					if (obj91 == null)
					{
						expectedCheck = (uint)(int)obj86;
						int num102 = num93 << 2;
						object obj92 = method + num102;
						object obj93 = obj92 + 24;
						CompressionLevel compressionLevel = (CompressionLevel)(num93 / 3);
						uint num103 = (uint)(int)(obj93 + compressionLevel);
						computedCheck = num103;
						totalBytesOut3 = num97;
						long num100 = num95;
						obj4 = obj66;
						num2 = num72;
						num3 = num97;
						num4 = num95;
						compressionLevel2 = compressionLevel6;
						uint num28 = expectedCheck;
						List<Color> list = (List<Color>)3;
						int num11 = num93;
						compressLevel = (CompressionLevel)obj86;
						num32 = num74;
					}
					else
					{
						object obj94 = obj86 & 0x20;
						long num100;
						if (obj94 == null)
						{
							totalBytesOut3 = num97;
							num100 = num95;
							obj5 = 32;
							break;
						}
						mode = InflateManagerMode.BLOCKS;
						totalBytesOut3 = num97;
						num100 = num95;
						obj4 = obj66;
						num2 = num72;
						num3 = num97;
						num4 = num95;
						compressionLevel2 = compressionLevel6;
						uint num28 = expectedCheck;
						List<Color> list = (List<Color>)2;
						int num11 = num93;
						compressLevel = (CompressionLevel)obj86;
						CompressionLevel compressionLevel = CompressionLevel.Level2;
						num32 = num74;
					}
				}
			}
			goto IL_28f6;
			IL_0f2c:
			obj5 = 45;
			break;
			IL_139a:
			num31 = num30;
			obj5 = 84;
			break;
			IL_0550:
			obj5 = 36;
			break;
			IL_0a83:
			obj5 = 19;
			break;
			IL_27bc:
			object obj95 = codec.dstate + 16;
			object obj96 = obj95 + compressionLevel2;
			obj96 = marker;
			bool flag19 = (byte)((flag2 ? 1u : 0u) - 1u) != 0;
			mode = InflateManagerMode.METHOD;
			CompressionLevel compressionLevel7 = compressionLevel2 + 1;
			compressionLevel2 = compressionLevel7;
			flag2 = flag19;
			num32 = 0;
			goto IL_28f6;
			IL_28f6:
			num = num32;
			continue;
			IL_06c5:
			obj5 = 58;
			break;
		}
		object obj97 = obj5 - 19;
		int flush = default;
		if ((nint)obj5 != 19)
		{
			if ((nint)obj97 != 1 && (nint)obj97 != 2 && (nint)obj97 != 3 && (nint)obj97 != 4 && (nint)obj97 != 5 && (nint)obj97 != 6 && (nint)obj97 != 7 && (nint)obj97 != 8 && (nint)obj97 != 9 && (nint)obj97 != 10 && (nint)obj97 != 11 && (nint)obj97 != 12)
			{
				if ((nint)obj97 != 13)
				{
					if ((nint)obj97 != 14 && (nint)obj97 != 15 && (nint)obj97 != 16)
					{
						if ((nint)obj97 != 17)
						{
							if ((nint)obj97 != 18 && (nint)obj97 != 19 && (nint)obj97 != 20 && (nint)obj97 != 21 && (nint)obj97 != 22 && (nint)obj97 != 23 && (nint)obj97 != 24 && (nint)obj97 != 25)
							{
								if ((nint)obj97 != 26)
								{
									if ((nint)obj97 != 27 && (nint)obj97 != 28 && (nint)obj97 != 29 && (nint)obj97 != 30 && (nint)obj97 != 31 && (nint)obj97 != 32 && (nint)obj97 != 33 && (nint)obj97 != 34)
									{
										if ((nint)obj97 != 35)
										{
											if ((nint)obj97 != 36 && (nint)obj97 != 37 && (nint)obj97 != 38)
											{
												if ((nint)obj97 != 39)
												{
													if ((nint)obj97 != 40 && (nint)obj97 != 41 && (nint)obj97 != 42 && (nint)obj97 != 43 && (nint)obj97 != 44 && (nint)obj97 != 45 && (nint)obj97 != 46 && (nint)obj97 != 47 && (nint)obj97 != 48 && (nint)obj97 != 49 && (nint)obj97 != 50 && (nint)obj97 != 51 && (nint)obj97 != 52 && (nint)obj97 != 53 && (nint)obj97 != 54 && (nint)obj97 != 55 && (nint)obj97 != 56 && (nint)obj97 != 57 && (nint)obj97 != 58 && (nint)obj97 != 59 && (nint)obj97 != 60 && (nint)obj97 != 61 && (nint)obj97 != 62 && (nint)obj97 != 63 && (nint)obj97 != 64)
													{
														if ((nint)obj97 != 65)
														{
															if ((nint)obj97 != 66 && (nint)obj97 != 67 && (nint)obj97 != 68 && (nint)obj97 != 69 && (nint)obj97 != 70 && (nint)obj97 != 71 && (nint)obj97 != 72 && (nint)obj97 != 73 && (nint)obj97 != 74 && (nint)obj97 != 75 && (nint)obj97 != 76 && (nint)obj97 != 77 && (nint)obj97 != 78 && (nint)obj97 != 79 && (nint)obj97 != 80 && (nint)obj97 != 81 && (nint)obj97 != 82 && (nint)obj97 != 83 && (nint)obj97 != 84)
															{
																if ((nint)obj97 != 85)
																{
																	if ((nint)obj97 != 86)
																	{
																		if ((nint)obj97 != 87)
																		{
																			if ((nint)obj97 != 88 && (nint)obj97 != 89 && (nint)obj97 != 90 && (nint)obj97 != 91 && (nint)obj97 != 92 && (nint)obj97 != 93 && (nint)obj97 != 94 && (nint)obj97 != 95)
																			{
																				if ((nint)obj97 != 96)
																				{
																					if ((nint)obj97 == 97)
																					{
																						codec.TotalBytesOut = num3;
																						uint num104 = num2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
																						object obj98 = (nint)(int)num104 - (nint)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
																						object obj99 = obj98 + 0;
																						codec.CompressLevel = compressionLevel2;
																						flush = -2;
																					}
																				}
																				else
																				{
																					codec.TotalBytesOut = num3;
																					uint num105 = num2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
																					object obj100 = (nint)(int)num105 - (nint)0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
																					object obj101 = obj100 + 0;
																					codec.CompressLevel = compressionLevel2;
																					flush = -3;
																				}
																			}
																		}
																		else
																		{
																			if (num3 >= 8)
																			{
																				long num106 = num3 - 8;
																				object obj102 = obj4 + 1;
																				uint num107 = num2 - 1;
																				obj4 = obj102;
																				num2 = num107;
																				num3 = num106;
																			}
																			codec.CompressLevel = compressionLevel2;
																			int num108 = ((InflateManager)(object)codec).Inflate((FlushType)num);
																			if ((int)codec.CompressLevel < (int)codec._Adler32)
																			{
																			}
																			if (codec._Adler32 == (uint)codec.CompressLevel)
																			{
																				mode = InflateManagerMode.CHECK4;
																				compressLevel2 = codec.CompressLevel;
																				object obj6 = obj4;
																				num5 = num2;
																				totalBytesOut = num3;
																				obj5 = 114;
																			}
																			else
																			{
																				codec.TotalBytesOut = num3;
																				uint num109 = num2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
																				object obj103 = (nint)(int)num109 - (nint)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
																				object obj104 = obj103 + 0;
																				codec.CompressLevel = codec.CompressLevel;
																				flush = num108;
																			}
																		}
																	}
																}
																else
																{
																	codec.TotalBytesOut = num3;
																	uint num110 = num2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
																	object obj105 = (nint)(int)num110 - (nint)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
																	object obj106 = obj105 + 0;
																	codec.CompressLevel = compressionLevel3;
																	flush = num7;
																}
															}
														}
														else
														{
															codec.TotalBytesOut = num9;
															uint num111 = num8;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
															object obj107 = (nint)(int)num111 - (nint)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
															object obj108 = obj107 + 0;
															codec.CompressLevel = compressionLevel4;
															flush = num31;
														}
													}
												}
												else
												{
													codec.TotalBytesOut = num13;
													_ = 0;
													uint num112 = num12;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
													object obj109 = (nint)(int)num112 - (nint)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
													object obj110 = obj109 + 0;
													codec.CompressLevel = compressionLevel2;
													flush = num15;
												}
											}
										}
										else
										{
											mode = InflateManagerMode.CHECK3;
											object obj111 = obj + 56;
											obj111 = "invalid distance code";
											codec.TotalBytesOut = totalBytesOut2;
											uint num113 = num33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
											object obj112 = (nint)(int)num113 - (nint)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
											object obj113 = obj112 + 0;
											codec.CompressLevel = compressionLevel2;
											flush = -3;
										}
									}
								}
								else
								{
									codec.TotalBytesOut = num51;
									_ = 0;
									uint num114 = num33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
									object obj114 = (nint)(int)num114 - (nint)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
									object obj115 = obj114 + 0;
									codec.CompressLevel = compressionLevel2;
									flush = num35;
								}
							}
						}
						else
						{
							codec.TotalBytesOut = num38;
							_ = 0;
							uint num115 = num37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
							object obj116 = (nint)(int)num115 - (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
							object obj117 = obj116 + 0;
							codec.CompressLevel = compressionLevel2;
							flush = num40;
						}
					}
				}
				else
				{
					mode = InflateManagerMode.CHECK3;
					object obj118 = obj + 56;
					obj118 = "invalid literal/length code";
					codec.TotalBytesOut = totalBytesOut3;
					uint num116 = num72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
					object obj119 = (nint)(int)num116 - (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
					object obj120 = obj119 + 0;
					codec.CompressLevel = compressionLevel6;
					flush = -3;
				}
			}
		}
		else
		{
			codec.TotalBytesOut = num82;
			_ = 0;
			uint num117 = num72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
			object obj121 = (nint)(int)num117 - (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
			object obj122 = obj121 + 0;
			codec.CompressLevel = compressionLevel6;
			flush = num74;
		}
		if ((nint)obj5 == 114)
		{
			codec.TotalBytesOut = totalBytesOut;
			uint num118 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+C]");
			object obj123 = (nint)(int)num118 - (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Object)+18]");
			object obj124 = obj123 + 0;
			codec.CompressLevel = compressLevel2;
			flush = 1;
		}
		return ((InflateManager)(object)codec).Inflate((FlushType)flush);
	}

	internal int Inflate(FlushType flush)
	{
		//IL_00a4: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected I4, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_043d: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_0174: Expected I, but got Obj
		object obj = default;
		while (true)
		{
			int num3;
			object obj21;
			if ((nint)obj <= 1)
			{
				bool flag = obj != null;
				object obj2;
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+48]");
					obj2 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+48]");
					if (num > 0)
					{
						object obj3 = this - -64;
						obj2 = obj3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+48]");
						obj2 = 0;
					}
				}
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
				int num2 = obj4 - 0;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v9+28]");
				bool flag2 = (nint)num2 > (nint)0;
				bool flag3 = !flag2;
				num3 = num2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v54+28]");
					num3 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v22+28]");
				object obj9 = -num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				object obj10 = 0;
				int num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v24+30]");
				object obj11 = (nint)num4 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+4C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
					object obj12 = 0;
					nint num5 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v45 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num6 = (nint)typeof(Adler);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v51 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+50]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+3C]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
					int num9 = ((ZlibBaseStream)num7).Read((byte[])num8, 0, num3);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+3C]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S2_v7+20]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S3_v4+24]");
				Array.ConstrainedCopy((Array)num10, (int)num11, (Array)num12, 0, num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+2C]");
				object obj16 = 0;
				int num13 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v31+24]");
				object obj17 = (nint)num13 + (nint)0;
				int num14 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
				object obj18 = (nint)num14 + (nint)0;
				object obj19 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+44]");
				bool flag4 = 0 != (nint)obj19;
				object obj20 = flag | flag4;
				if (obj20 != null)
				{
					obj21 = obj + 1;
					goto IL_0326;
				}
				_ = 0;
				object obj22 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateManager)+48]");
				if (0 == (nint)obj22)
				{
					_ = 0;
				}
				goto IL_037b;
			}
			return 0;
			IL_037b:
			obj21 = 0;
			goto IL_0326;
			IL_0326:
			obj = obj21 + 1;
			bool flag5 = 0 == -5;
			bool flag6 = num3 != 0;
			object obj23 = flag5 & flag6;
			if (obj23 == null)
			{
				continue;
			}
			goto IL_037b;
		}
		if (0 == -5)
		{
			return 0;
		}
		return 0;
	}

	internal int SetDictionary(byte[] dictionary)
	{
		//IL_001d: Expected I4, but got Obj
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02f4: Expected I4, but got Obj
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected I4, but got Unknown
		//IL_03b3: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_0405: Expected Obj, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0727: Expected I4, but got Obj
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected I4, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected Obj, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected I4, but got Unknown
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected Obj, but got Unknown
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Expected I4, but got Unknown
		//IL_1120: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected Obj, but got Unknown
		//IL_09cd: Expected Obj, but got I4
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected Obj, but got Unknown
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Expected Obj, but got Unknown
		//IL_0be3: Expected I4, but got Obj
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected Obj, but got Unknown
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Expected I4, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected Obj, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected I4, but got Unknown
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected Obj, but got Unknown
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected Obj, but got Unknown
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected I4, but got Unknown
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Expected Obj, but got Unknown
		//IL_11b6: Expected I4, but got Obj
		//IL_11e7: Expected I4, but got Obj
		ZlibCodec codec = _codec;
		if (codec.InputBuffer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"InputBuffer is null. " != 0);
			((InflateManager)(object)zlibBaseStream).Inflate(FlushType.None);
		}
		int num = -5;
		ZlibBaseStream zlibBaseStream2 = default;
		ZlibBaseStream zlibBaseStream3 = default;
		object[] args = default;
		object[] args2 = default;
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
								if (mode == InflateManagerMode.DICT1)
								{
									ZlibCodec codec2 = _codec;
									int result;
									if (codec2.AvailableBytesIn != 0)
									{
										ZlibCodec codec3 = _codec;
										int availableBytesIn = codec3.AvailableBytesIn - 1;
										codec3.AvailableBytesIn = availableBytesIn;
										ZlibCodec codec4 = _codec;
										long totalBytesIn = codec4.TotalBytesIn + 1;
										codec4.TotalBytesIn = totalBytesIn;
										ZlibCodec codec5 = _codec;
										ZlibCodec codec6 = _codec;
										int nextIn = codec6.NextIn + 1;
										codec6.NextIn = nextIn;
										object obj = codec5.InputBuffer + 16;
										object obj2 = obj + codec6.NextIn;
										uint num2 = (uint)(int)(obj2 + expectedCheck);
										expectedCheck = num2;
										ZlibCodec codec7 = _codec;
										codec7._Adler32 = expectedCheck;
										mode = InflateManagerMode.DICT0;
										result = 2;
									}
									else
									{
										result = num;
									}
									return result;
								}
								if (mode == InflateManagerMode.DICT0)
								{
									mode = InflateManagerMode.BAD;
									object obj3 = _codec + 56;
									obj3 = "need dictionary";
									marker = 0;
									return -2;
								}
								if (mode != InflateManagerMode.BLOCKS)
								{
									if (mode != InflateManagerMode.CHECK4)
									{
										if (mode != InflateManagerMode.CHECK3)
										{
											if (mode != InflateManagerMode.CHECK2)
											{
												if (mode != InflateManagerMode.CHECK1)
												{
													if (mode != InflateManagerMode.DONE)
													{
														if (mode == InflateManagerMode.BAD)
														{
															ZlibCodec codec8 = _codec;
															string text = $"Bad state ({(object[])(object)codec8.Message})";
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
															zlibBaseStream2.Dispose((byte)(int)text != 0);
															((InflateManager)(object)zlibBaseStream2).Inflate(FlushType.None);
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
															zlibBaseStream3.Dispose((byte)(int)"Stream error." != 0);
															((InflateManager)(object)zlibBaseStream3).Inflate(FlushType.None);
														}
														break;
													}
													return 1;
												}
												ZlibCodec codec9 = _codec;
												if (codec9.AvailableBytesIn == 0)
												{
													return num;
												}
												ZlibCodec codec10 = _codec;
												int availableBytesIn2 = codec10.AvailableBytesIn - 1;
												codec10.AvailableBytesIn = availableBytesIn2;
												ZlibCodec codec11 = _codec;
												long totalBytesIn2 = codec11.TotalBytesIn + 1;
												codec11.TotalBytesIn = totalBytesIn2;
												ZlibCodec codec12 = _codec;
												ZlibCodec codec13 = _codec;
												int nextIn2 = codec13.NextIn + 1;
												codec13.NextIn = nextIn2;
												object obj4 = codec12.InputBuffer + 16;
												object obj5 = obj4 + codec13.NextIn;
												uint num3 = (uint)(int)(obj5 + expectedCheck);
												expectedCheck = num3;
												if (computedCheck == expectedCheck)
												{
													mode = InflateManagerMode.DONE;
													return 1;
												}
												mode = InflateManagerMode.BAD;
												object obj6 = _codec + 56;
												obj6 = "incorrect data check";
												marker = 5;
												num = 0;
											}
											else
											{
												ZlibCodec codec14 = _codec;
												if (codec14.AvailableBytesIn == 0)
												{
													return num;
												}
												ZlibCodec codec15 = _codec;
												int availableBytesIn3 = codec15.AvailableBytesIn - 1;
												codec15.AvailableBytesIn = availableBytesIn3;
												ZlibCodec codec16 = _codec;
												long totalBytesIn3 = codec16.TotalBytesIn + 1;
												codec16.TotalBytesIn = totalBytesIn3;
												ZlibCodec codec17 = _codec;
												ZlibCodec codec18 = _codec;
												int nextIn3 = codec18.NextIn + 1;
												codec18.NextIn = nextIn3;
												object obj7 = codec17.InputBuffer + 16;
												object obj8 = obj7 + codec18.NextIn;
												object obj9 = obj8 << 8;
												uint num4 = (uint)(int)(obj9 + expectedCheck);
												expectedCheck = num4;
												mode = InflateManagerMode.CHECK1;
												num = 0;
											}
										}
										else
										{
											ZlibCodec codec19 = _codec;
											if (codec19.AvailableBytesIn == 0)
											{
												return num;
											}
											ZlibCodec codec20 = _codec;
											int availableBytesIn4 = codec20.AvailableBytesIn - 1;
											codec20.AvailableBytesIn = availableBytesIn4;
											ZlibCodec codec21 = _codec;
											long totalBytesIn4 = codec21.TotalBytesIn + 1;
											codec21.TotalBytesIn = totalBytesIn4;
											ZlibCodec codec22 = _codec;
											ZlibCodec codec23 = _codec;
											int nextIn4 = codec23.NextIn + 1;
											codec23.NextIn = nextIn4;
											object obj10 = codec22.InputBuffer + 16;
											object obj11 = obj10 + codec23.NextIn;
											object obj12 = obj11 << 16;
											uint num5 = (uint)(int)(obj12 + expectedCheck);
											expectedCheck = num5;
											mode = InflateManagerMode.CHECK2;
											num = 0;
										}
									}
									else
									{
										ZlibCodec codec24 = _codec;
										if (codec24.AvailableBytesIn == 0)
										{
											return num;
										}
										ZlibCodec codec25 = _codec;
										int availableBytesIn5 = codec25.AvailableBytesIn - 1;
										codec25.AvailableBytesIn = availableBytesIn5;
										ZlibCodec codec26 = _codec;
										long totalBytesIn5 = codec26.TotalBytesIn + 1;
										codec26.TotalBytesIn = totalBytesIn5;
										ZlibCodec codec27 = _codec;
										ZlibCodec codec28 = _codec;
										int nextIn5 = codec28.NextIn + 1;
										codec28.NextIn = nextIn5;
										object obj13 = codec27.InputBuffer + 16;
										object obj14 = obj13 + codec28.NextIn;
										uint num6 = (uint)(obj14 << 24);
										expectedCheck = num6;
										mode = InflateManagerMode.CHECK3;
										num = 0;
									}
									continue;
								}
								int num7 = blocks.Flush(num);
								object obj15 = num7 - -3;
								if (num7 != -3)
								{
									if ((nint)obj15 == 1 || (nint)obj15 == 2 || (nint)obj15 == 3 || (nint)obj15 != 4)
									{
										return num7;
									}
									int num8 = blocks.SyncPoint();
									computedCheck = (uint)num8;
									if (~(_handleRfc1950HeaderBytes ? 1u : 0u) != 0)
									{
										mode = InflateManagerMode.DONE;
										return 1;
									}
									mode = InflateManagerMode.CHECK4;
									num = 0;
								}
								else
								{
									mode = InflateManagerMode.BAD;
									marker = 0;
									num = -3;
								}
							}
							else
							{
								ZlibCodec codec29 = _codec;
								if (codec29.AvailableBytesIn == 0)
								{
									return num;
								}
								ZlibCodec codec30 = _codec;
								int availableBytesIn6 = codec30.AvailableBytesIn - 1;
								codec30.AvailableBytesIn = availableBytesIn6;
								ZlibCodec codec31 = _codec;
								long totalBytesIn6 = codec31.TotalBytesIn + 1;
								codec31.TotalBytesIn = totalBytesIn6;
								ZlibCodec codec32 = _codec;
								ZlibCodec codec33 = _codec;
								int nextIn6 = codec33.NextIn + 1;
								codec33.NextIn = nextIn6;
								object obj16 = codec32.InputBuffer + 16;
								object obj17 = obj16 + codec33.NextIn;
								object obj18 = obj17 << 8;
								uint num9 = (uint)(int)(obj18 + expectedCheck);
								expectedCheck = num9;
								mode = InflateManagerMode.DICT1;
								num = 0;
							}
						}
						else
						{
							ZlibCodec codec34 = _codec;
							if (codec34.AvailableBytesIn == 0)
							{
								return num;
							}
							ZlibCodec codec35 = _codec;
							int availableBytesIn7 = codec35.AvailableBytesIn - 1;
							codec35.AvailableBytesIn = availableBytesIn7;
							ZlibCodec codec36 = _codec;
							long totalBytesIn7 = codec36.TotalBytesIn + 1;
							codec36.TotalBytesIn = totalBytesIn7;
							ZlibCodec codec37 = _codec;
							ZlibCodec codec38 = _codec;
							int nextIn7 = codec38.NextIn + 1;
							codec38.NextIn = nextIn7;
							object obj19 = codec37.InputBuffer + 16;
							object obj20 = obj19 + codec38.NextIn;
							object obj21 = obj20 << 16;
							uint num10 = (uint)(int)(obj21 + expectedCheck);
							expectedCheck = num10;
							mode = InflateManagerMode.DICT2;
							num = 0;
						}
					}
					else
					{
						ZlibCodec codec39 = _codec;
						if (codec39.AvailableBytesIn == 0)
						{
							return num;
						}
						ZlibCodec codec40 = _codec;
						int availableBytesIn8 = codec40.AvailableBytesIn - 1;
						codec40.AvailableBytesIn = availableBytesIn8;
						ZlibCodec codec41 = _codec;
						long totalBytesIn8 = codec41.TotalBytesIn + 1;
						codec41.TotalBytesIn = totalBytesIn8;
						ZlibCodec codec42 = _codec;
						ZlibCodec codec43 = _codec;
						int nextIn8 = codec43.NextIn + 1;
						codec43.NextIn = nextIn8;
						object obj22 = codec42.InputBuffer + 16;
						object obj23 = obj22 + codec43.NextIn;
						uint num11 = (uint)(obj23 << 24);
						expectedCheck = num11;
						mode = InflateManagerMode.DICT3;
						num = 0;
					}
				}
				else
				{
					ZlibCodec codec44 = _codec;
					if (codec44.AvailableBytesIn == 0)
					{
						return num;
					}
					ZlibCodec codec45 = _codec;
					int availableBytesIn9 = codec45.AvailableBytesIn - 1;
					codec45.AvailableBytesIn = availableBytesIn9;
					ZlibCodec codec46 = _codec;
					long totalBytesIn9 = codec46.TotalBytesIn + 1;
					codec46.TotalBytesIn = totalBytesIn9;
					ZlibCodec codec47 = _codec;
					ZlibCodec codec48 = _codec;
					int nextIn9 = codec48.NextIn + 1;
					codec48.NextIn = nextIn9;
					object obj24 = codec47.InputBuffer + 16;
					object obj25 = obj24 + codec48.NextIn;
					int num12 = method << 8;
					object obj26 = obj25 + num12;
					object obj27 = obj26 / 31;
					object obj28 = obj27 * 31;
					if (obj26 != obj28)
					{
						mode = InflateManagerMode.BAD;
						object obj29 = _codec + 56;
						obj29 = "incorrect header check";
						marker = 5;
					}
					else
					{
						object obj30 = obj25 & 0x20;
						InflateManagerMode inflateManagerMode = ((obj30 == null) ? InflateManagerMode.BLOCKS : InflateManagerMode.DICT4);
						mode = inflateManagerMode;
					}
					num = 0;
				}
				continue;
			}
			ZlibCodec codec49 = _codec;
			if (codec49.AvailableBytesIn == 0)
			{
				return num;
			}
			ZlibCodec codec50 = _codec;
			int availableBytesIn10 = codec50.AvailableBytesIn - 1;
			codec50.AvailableBytesIn = availableBytesIn10;
			ZlibCodec codec51 = _codec;
			long totalBytesIn10 = codec51.TotalBytesIn + 1;
			codec51.TotalBytesIn = totalBytesIn10;
			ZlibCodec codec52 = _codec;
			ZlibCodec codec53 = _codec;
			int nextIn10 = codec53.NextIn + 1;
			codec53.NextIn = nextIn10;
			object obj31 = codec52.InputBuffer + 16;
			object obj32 = obj31 + codec53.NextIn;
			method = (int)obj32;
			int num13 = obj32 & 0xF;
			if (num13 != 8)
			{
				mode = InflateManagerMode.BAD;
				object obj33 = method;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj34 = _codec + 56;
				string text2 = $"unknown compression method (0x{args:X2})";
				obj34 = text2;
				marker = 5;
				num = 0;
				continue;
			}
			int num14 = method >> 4;
			object obj35 = num14 + 8;
			if ((nint)obj35 > wbits)
			{
				mode = InflateManagerMode.BAD;
				int num15 = method >> 4;
				object obj36 = num15 + 8;
				object obj33 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj37 = _codec + 56;
				string text3 = $"invalid window size ({args2})";
				obj37 = text3;
				marker = 5;
			}
			else
			{
				mode = InflateManagerMode.FLAG;
			}
			num = 0;
		}
		int result2 = default;
		return result2;
	}

	internal int Sync()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I4
		if (blocks != null)
		{
			((InflateCodes)(object)blocks)._002Ector();
		}
		object obj = this + 40;
		obj = 0;
		return 0;
	}

	internal int SyncPoint(ZlibCodec z)
	{
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0214: Expected I4, but got Obj
		//IL_0214: Expected Obj, but got I4
		//IL_001d: Expected I4, but got Obj
		//IL_0081: Expected I, but got Obj
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected I4, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_0160: Expected I4, but got Obj
		object obj = z + 12;
		if (mode != InflateManagerMode.DICT0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"Stream error." != 0);
			((InflateManager)(object)zlibBaseStream).SetDictionary((byte[])null);
		}
		nint num = (nint)typeof(Adler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v13 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Adler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v28 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ZlibBaseStream)1).Read((byte[])(object)z, 0, (int)obj);
		ZlibCodec codec = _codec;
		if (num3 == (int)codec._Adler32)
		{
			ZlibCodec codec2 = _codec;
			nint num4 = (nint)typeof(Adler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v12 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Adler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v20 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int adler = ((ZlibBaseStream)null).Read((byte[])null, 0, 0);
			codec2._Adler32 = (uint)adler;
			int num6 = wbits & 0x1F;
			int num7 = 1 << num6;
			int count;
			int offset;
			if ((nint)obj < num7)
			{
				count = (int)obj;
				offset = 0;
			}
			else
			{
				int num8 = wbits & 0x1F;
				int num9 = 1 << num8;
				int num10 = num9 - 1;
				offset = obj - num10;
				count = num10;
			}
			((ZlibBaseStream)(object)blocks).Write((byte[])(object)z, offset, count);
			mode = InflateManagerMode.BLOCKS;
			return 0;
		}
		return -3;
	}

	unsafe static InflateManager()
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0030: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj + 4);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		InternalInflateConstants.InflateMask = (int[])(object)unmanagedFunctionPointerAttribute;
	}
}
