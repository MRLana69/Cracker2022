using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal sealed class DeflateManager
{
	internal delegate BlockState CompressFunc(FlushType flush);

	internal class Config
	{
		internal int GoodLength;

		internal int MaxLazy;

		internal int NiceLength;

		internal int MaxChainLength;

		internal DeflateFlavor Flavor;

		private static readonly Config[] Table;

		private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
		{
			Flavor = flavor;
			MaxChainLength = maxChainLength;
			NiceLength = niceLength;
			MaxLazy = maxLazy;
			GoodLength = goodLength;
		}

		static Config()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			throw new ArrayTypeMismatchException();
		}

		public static Config Lookup(CompressionLevel level)
		{
			//IL_0013: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got I
			object obj = (int)level << 2;
			object obj2 = (object)Table + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+10]");
			return (Config)0;
		}
	}

	private static readonly int MEM_LEVEL_MAX = 9;

	private static readonly int MEM_LEVEL_DEFAULT = 8;

	private CompressFunc DeflateFunction;

	private static readonly string[] _ErrorMessage;

	private static readonly int PRESET_DICT;

	private static readonly int INIT_STATE;

	private static readonly int BUSY_STATE;

	private static readonly int FINISH_STATE;

	private static readonly int Z_DEFLATED;

	private static readonly int STORED_BLOCK;

	private static readonly int STATIC_TREES;

	private static readonly int DYN_TREES;

	private static readonly int Z_BINARY;

	private static readonly int Z_ASCII;

	private static readonly int Z_UNKNOWN;

	private static readonly int Buf_size;

	private static readonly int MIN_MATCH;

	private static readonly int MAX_MATCH;

	private static readonly int MIN_LOOKAHEAD;

	private static readonly int HEAP_SIZE;

	private static readonly int END_BLOCK;

	internal ZlibCodec _codec;

	internal int status;

	internal byte[] pending;

	internal int nextPending;

	internal int pendingCount;

	internal sbyte data_type;

	internal int last_flush;

	internal int w_size;

	internal int w_bits;

	internal int w_mask;

	internal byte[] window;

	internal int window_size;

	internal short[] prev;

	internal short[] head;

	internal int ins_h;

	internal int hash_size;

	internal int hash_bits;

	internal int hash_mask;

	internal int hash_shift;

	internal int block_start;

	private Config config;

	internal int match_length;

	internal int prev_match;

	internal int match_available;

	internal int strstart;

	internal int match_start;

	internal int lookahead;

	internal int prev_length;

	internal CompressionLevel compressionLevel;

	internal CompressionStrategy compressionStrategy;

	internal short[] dyn_ltree;

	internal short[] dyn_dtree;

	internal short[] bl_tree;

	internal Tree treeLiterals;

	internal Tree treeDistances;

	internal Tree treeBitLengths;

	internal short[] bl_count;

	internal int[] heap;

	internal int heap_len;

	internal int heap_max;

	internal sbyte[] depth;

	internal int _lengthOffset;

	internal int lit_bufsize;

	internal int last_lit;

	internal int _distanceOffset;

	internal int opt_len;

	internal int static_len;

	internal int matches;

	internal int last_eob_len;

	internal short bi_buf;

	internal int bi_valid;

	private bool Rfc1950BytesEmitted;

	private bool _WantRfc1950HeaderBytes;

	internal bool WantRfc1950HeaderBytes
	{
		get
		{
			return _WantRfc1950HeaderBytes;
		}
		set
		{
			_WantRfc1950HeaderBytes = value;
		}
	}

	internal DeflateManager()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		Tree tree = default;
		treeLiterals = tree;
		Tree tree2 = default;
		treeDistances = tree2;
		Tree tree3 = default;
		treeBitLengths = tree3;
		object obj = InternalConstants.MAX_BITS + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		short[] array = default;
		bl_count = array;
		int num = InternalConstants.L_CODES << 1;
		object obj2 = num + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] array2 = default;
		heap = array2;
		int num2 = InternalConstants.L_CODES << 1;
		object obj3 = num2 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		sbyte[] array3 = default;
		depth = array3;
		_WantRfc1950HeaderBytes = true;
		int num3 = HEAP_SIZE << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		short[] array4 = default;
		dyn_ltree = array4;
		int num4 = InternalConstants.D_CODES << 1;
		object obj4 = num4 + 1;
		object obj5 = obj4 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		short[] array5 = default;
		dyn_dtree = array5;
		int num5 = InternalConstants.BL_CODES << 1;
		object obj6 = num5 + 1;
		object obj7 = obj6 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		short[] array6 = default;
		bl_tree = array6;
	}

	private void _InitializeLazyMatch()
	{
		int num = w_size << 1;
		window_size = num;
		Array.Clear(head, 0, hash_size);
		Config config = Config.Lookup(compressionLevel);
		this.config = config;
		SetDeflater();
		lookahead = 0;
		block_start = 0;
		strstart = 0;
		int num2 = MIN_MATCH - 1;
		match_available = 0;
		match_length = num2;
		prev_length = num2;
		ins_h = 0;
	}

	private void _InitializeTreeData()
	{
		Tree tree = treeLiterals;
		tree.dyn_tree = dyn_ltree;
		Tree tree2 = treeLiterals;
		tree2.staticTree = StaticTree.Literals;
		Tree tree3 = treeDistances;
		tree3.dyn_tree = dyn_dtree;
		Tree tree4 = treeDistances;
		tree4.staticTree = StaticTree.Distances;
		Tree tree5 = treeBitLengths;
		tree5.dyn_tree = bl_tree;
		Tree tree6 = treeBitLengths;
		tree6.staticTree = StaticTree.BitLengths;
		bi_valid = 0;
		bi_buf = 0;
		last_eob_len = 8;
		_InitializeBlocks();
	}

	internal void _InitializeBlocks()
	{
		//IL_012a: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		object obj = 0;
		while (InternalConstants.L_CODES > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)dyn_ltree + obj2;
			_ = 0;
			object obj4 = obj + 1;
			obj = obj4;
		}
		object obj5 = 0;
		while (InternalConstants.D_CODES > (nint)obj5)
		{
			object obj6 = obj5 << 2;
			object obj7 = (object)dyn_dtree + obj6;
			_ = 0;
			object obj8 = obj5 + 1;
			obj5 = obj8;
		}
		object obj9 = 0;
		while (InternalConstants.BL_CODES > (nint)obj9)
		{
			object obj10 = obj9 << 2;
			object obj11 = (object)bl_tree + obj10;
			_ = 0;
			object obj12 = obj9 + 1;
			obj9 = obj12;
		}
		int num = END_BLOCK << 2;
		object obj13 = dyn_ltree + num;
		_ = 1;
		matches = 0;
		opt_len = 0;
		last_lit = 0;
	}

	internal void pqdownheap(short[] tree, int k)
	{
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		int num2 = default;
		int num = num2 << 2;
		object obj = heap + num;
		int num4 = default;
		while (true)
		{
			int num3 = num4 << 1;
			if (num3 > heap_len)
			{
				break;
			}
			bool flag = num3 >= heap_len;
			num4 = num3;
			if (!flag)
			{
				object obj2 = num3 + 1;
				object obj3 = obj2 << 2;
				object obj4 = (object)heap + obj3;
				int num5 = num3 << 2;
				object obj5 = heap + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36+10]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40+10]");
				bool flag2 = _IsSmaller(tree, (int)num6, 0, depth);
				bool flag3 = !flag2;
				num4 = num3;
				if (!flag3)
				{
					int num7 = num3 + 1;
					num4 = num7;
				}
			}
			int num8 = num4 << 2;
			object obj6 = heap + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v22+10]");
			if (_IsSmaller(tree, (int)num9, 0, depth))
			{
				break;
			}
			int num10 = num2 << 2;
			object obj7 = num10 + heap;
			int num11 = num4 << 2;
			object obj8 = heap + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v21+10]");
			_ = 0;
		}
		int num12 = num4 << 2;
		object obj9 = heap + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
		_ = 0;
	}

	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		int num = n << 2;
		object obj = tree + num;
		int num2 = m << 2;
		object obj2 = tree + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v4+10]");
		bool flag = num3 < 0;
		bool result = true;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v4+10]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+10]");
			bool flag2 = num4 != 0;
			result = false;
			if (!flag2)
			{
				object obj3 = n + depth;
				object obj4 = m + depth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v5+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10+10]");
				result = num5 <= 0;
			}
		}
		return result;
	}

	internal void scan_tree(short[] tree, int max_code)
	{
		//IL_02f1: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_0435: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		int num = max_code << 1;
		object obj = num + 3;
		object obj2 = obj << 1;
		object obj3 = (object)tree + obj2;
		_ = 32767;
		object obj4 = 7;
		if (tree[1] == 0)
		{
			obj4 = 138;
		}
		object obj5 = 4;
		if (tree[1] == 0)
		{
			obj5 = 3;
		}
		object obj6 = obj5;
		object obj7 = obj4;
		short num2 = -1;
		short num3 = tree[1];
		object obj8 = default;
		object obj10 = default;
		object obj32 = default;
		while (max_code >= (nint)obj8)
		{
			object obj9 = obj10 + 1;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj11 = obj8 << 1;
			object obj12 = obj11 + 3;
			object obj13 = obj12 << 1;
			object obj14 = (object)tree + obj13;
			short num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S3_v3+10]");
			if ((nint)num4 != 0)
			{
				flag = false;
			}
			bool flag2 = !flag;
			bool flag3 = !flag2;
			obj10 = obj9;
			if (!flag3)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
				{
					int num5 = num3 << 2;
					object obj15 = bl_tree + num5;
					int num6 = num3 << 2;
					object obj16 = bl_tree + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v71+10]");
					object obj17 = 0 + obj9;
				}
				else if (num3 != 0)
				{
					if (num3 != num2)
					{
						int num7 = num3 << 2;
						object obj18 = bl_tree + num7;
						object obj19 = obj18 + 16;
						object obj20 = obj19 + 1;
						obj19 = obj20;
					}
					int num8 = InternalConstants.REP_3_6 << 2;
					object obj21 = bl_tree + num8;
					object obj22 = obj21 + 16;
					object obj23 = obj22 + 1;
					obj22 = obj23;
				}
				else if ((nint)obj9 <= 10)
				{
					int num9 = InternalConstants.REPZ_3_10 << 2;
					object obj24 = bl_tree + num9;
					object obj25 = obj24 + 16;
					object obj26 = obj25 + 1;
					obj25 = obj26;
				}
				else
				{
					int num10 = InternalConstants.REPZ_11_138 << 2;
					object obj27 = bl_tree + num10;
					object obj28 = obj27 + 16;
					object obj29 = obj28 + 1;
					obj28 = obj29;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S3_v3+10]");
				object obj30;
				if ((nint)0 == 0)
				{
					obj7 = 138;
					obj30 = 3;
				}
				else
				{
					short num11 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S3_v3+10]");
					bool flag4 = (nint)num11 == 0;
					object obj31 = 6;
					if (!flag4)
					{
						obj31 = 7;
					}
					obj7 = obj31;
					obj30 = 3;
					if (!flag4)
					{
						obj7 = obj31;
						obj30 = 4;
					}
				}
				obj6 = obj30;
				num2 = num3;
				obj10 = 0;
			}
			obj8 = obj32 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S3_v3+10]");
			num3 = 0;
		}
	}

	internal int build_bl_tree()
	{
		//IL_00af: Expected Obj, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected I4, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		Tree tree = treeLiterals;
		scan_tree(dyn_ltree, tree.max_code);
		Tree tree2 = treeDistances;
		scan_tree(dyn_dtree, tree2.max_code);
		treeBitLengths.build_tree(this);
		int num = InternalConstants.BL_CODES - 1;
		int num2 = num;
		while (num2 >= 3)
		{
			object obj = num2 + Tree.bl_order;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v15+10]");
			object obj2 = (nint)0 << 1;
			object obj3 = obj2 + 1;
			object obj4 = obj3 << 1;
			object obj5 = (object)bl_tree + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v27+10]");
			if ((nint)0 != 0)
			{
				break;
			}
			int num3 = num2 - 1;
			num2 = num3;
		}
		object obj6 = num2 * 3;
		object obj7 = obj6 + 17;
		int num4 = opt_len + obj7;
		opt_len = num4;
		return num2;
	}

	internal void send_all_trees(int lcodes, int dcodes, int blcodes)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		int value = lcodes - 257;
		send_bits(value, 5);
		int value2 = dcodes - 1;
		send_bits(value2, 5);
		int value3 = blcodes - 4;
		send_bits(value3, 4);
		object obj = 0;
		while (blcodes > (nint)obj)
		{
			object obj2 = obj + (object)Tree.bl_order;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v13+10]");
			object obj3 = (nint)0 << 1;
			object obj4 = obj3 + 1;
			object obj5 = obj4 << 1;
			object obj6 = (object)bl_tree + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v15+10]");
			send_bits(0, 3);
			object obj7 = obj + 1;
			obj = obj7;
		}
		int max_code = lcodes - 1;
		send_tree(dyn_ltree, max_code);
		int max_code2 = dcodes - 1;
		send_tree(dyn_dtree, max_code2);
	}

	internal void send_tree(short[] tree, int max_code)
	{
		//IL_0298: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected I4, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected I4, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected I4, but got Unknown
		//IL_025c: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I4
		object obj = 7;
		if (tree[1] == 0)
		{
			obj = 138;
		}
		object obj2 = 4;
		if (tree[1] == 0)
		{
			obj2 = 3;
		}
		object obj3 = obj2;
		object obj4 = obj;
		short num = -1;
		short num2 = tree[1];
		object obj5 = default;
		object obj7 = default;
		object obj17 = default;
		while (max_code >= (nint)obj5)
		{
			object obj6 = obj7 + 1;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj8 = obj5 << 1;
			object obj9 = obj8 + 3;
			object obj10 = obj9 << 1;
			object obj11 = (object)tree + obj10;
			short num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S3_v3+10]");
			if ((nint)num3 != 0)
			{
				flag = false;
			}
			bool flag2 = !flag;
			bool flag3 = !flag2;
			obj7 = obj6;
			if (!flag3)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					object obj12;
					do
					{
						send_code(num2, bl_tree);
						obj12 = obj6 - 1;
					}
					while (obj12 != null);
				}
				else if (num2 != 0)
				{
					bool flag4 = num2 != num;
					bool flag5 = !flag4;
					object obj13 = obj6;
					if (!flag5)
					{
						send_code(num2, bl_tree);
						object obj14 = obj6 - 1;
						obj13 = obj14;
					}
					send_code(InternalConstants.REP_3_6, bl_tree);
					int value = obj13 - 3;
					send_bits(value, 2);
				}
				else if ((nint)obj6 <= 10)
				{
					send_code(InternalConstants.REPZ_3_10, bl_tree);
					int value2 = obj6 - 3;
					send_bits(value2, 3);
				}
				else
				{
					send_code(InternalConstants.REPZ_11_138, bl_tree);
					int value3 = obj6 - 11;
					send_bits(value3, 7);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S3_v3+10]");
				object obj15;
				if ((nint)0 == 0)
				{
					obj4 = 138;
					obj15 = 3;
				}
				else
				{
					short num4 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S3_v3+10]");
					bool flag6 = (nint)num4 == 0;
					object obj16 = 6;
					if (!flag6)
					{
						obj16 = 7;
					}
					obj4 = obj16;
					obj15 = 3;
					if (!flag6)
					{
						obj4 = obj16;
						obj15 = 4;
					}
				}
				obj3 = obj15;
				num = num2;
				obj7 = 0;
			}
			obj5 = obj17 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S3_v3+10]");
			num2 = 0;
		}
	}

	private void put_bytes(byte[] p, int start, int len)
	{
		Array.Copy(p, start, pending, pendingCount, len);
		int num = len + pendingCount;
		pendingCount = num;
	}

	internal void send_code(int c, short[] tree)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		int num = c << 1;
		int num2 = num << 1;
		object obj = tree + num2;
		object obj2 = num + 1;
		object obj3 = obj2 << 1;
		object obj4 = (object)tree + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v2+10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v5+10]");
		send_bits((int)num3, 0);
	}

	internal void send_bits(int value, int length)
	{
		//IL_00da: Expected Obj, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected I4, but got Unknown
		object obj = Buf_size - length;
		int num = value << bi_valid;
		int num2 = bi_buf | num;
		bi_buf = (short)num2;
		int num6;
		if (bi_valid > (nint)obj)
		{
			int num3 = pendingCount + 1;
			pendingCount = num3;
			object obj2 = pending + pendingCount;
			_ = bi_buf;
			int num4 = pendingCount + 1;
			pendingCount = num4;
			object obj3 = pending + pendingCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateManager)+D1]");
			_ = 0;
			object obj4 = Buf_size - bi_valid;
			int num5 = value >> (int)obj4;
			bi_buf = (short)num5;
			object obj5 = length - Buf_size;
			num6 = bi_valid + obj5;
		}
		else
		{
			num6 = length + bi_valid;
		}
		bi_valid = num6;
	}

	internal void _tr_align()
	{
		//IL_0030: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		int value = STATIC_TREES << 1;
		send_bits(value, 3);
		send_code(END_BLOCK, StaticTree.lengthAndLiteralsTreeCodes);
		bi_flush();
		object obj = last_eob_len + 11;
		object obj2 = obj - bi_valid;
		if ((nint)obj2 <= 8)
		{
			int value2 = STATIC_TREES << 1;
			send_bits(value2, 3);
			send_code(END_BLOCK, StaticTree.lengthAndLiteralsTreeCodes);
			bi_flush();
		}
		last_eob_len = 7;
	}

	internal bool _tr_tally(int dist, int lc)
	{
		//IL_02a7: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected I4, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		int num = last_lit << 1;
		object obj = _distanceOffset + num;
		object obj2 = (object)pending + obj;
		int num2 = dist >> 8;
		int num3 = last_lit << 1;
		object obj3 = _distanceOffset + num3;
		object obj4 = obj3 + 1;
		object obj5 = (object)pending + obj4;
		object obj6 = _lengthOffset + last_lit;
		object obj7 = (object)pending + obj6;
		int num4 = last_lit + 1;
		last_lit = num4;
		short[] array;
		int num7 = default;
		if (dist == 0)
		{
			array = dyn_ltree;
		}
		else
		{
			int num5 = matches + 1;
			matches = num5;
			int dist2 = dist - 1;
			int num6 = default;
			object obj8 = num6 + Tree.LengthCode;
			int lITERALS = InternalConstants.LITERALS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v69+10]");
			object obj9 = (nint)lITERALS + (nint)0;
			object obj10 = obj9 << 2;
			object obj11 = (object)dyn_ltree + obj10;
			object obj12 = obj11 + 20;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			num7 = Tree.DistanceCode(dist2);
			array = dyn_dtree;
		}
		int num8 = num7 << 2;
		object obj14 = array + num8;
		object obj15 = obj14 + 16;
		object obj16 = obj15 + 1;
		obj15 = obj16;
		int num9 = last_lit & 0x1FFF;
		int num10 = last_lit;
		bool result;
		if (num9 == 0)
		{
			bool flag = compressionLevel < CompressionLevel.Level3;
			num10 = last_lit;
			if (!flag)
			{
				int num11 = last_lit << 3;
				object obj17 = strstart - block_start;
				int num12 = num11;
				object obj18 = 0;
				while (InternalConstants.D_CODES > (nint)obj18)
				{
					object obj19 = obj18 << 2;
					object obj20 = (object)dyn_dtree + obj19;
					object obj21 = obj18 << 2;
					object obj22 = (object)Tree.ExtraDistanceBits + obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S2_v30+10]");
					object obj23 = (nint)0 + (nint)5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v53+10]");
					object obj24 = 0 * obj23;
					int num13 = num12 + obj24;
					object obj25 = obj18 + 1;
					num12 = num13;
					obj18 = obj25;
				}
				int num14 = last_lit / 2;
				bool flag2 = matches >= num14;
				num10 = last_lit;
				if (!flag2)
				{
					object obj26 = obj17 / 2;
					int num15 = num12 >> 3;
					bool flag3 = (nint)obj26 > num15;
					num10 = last_lit;
					result = true;
					if (flag3)
					{
						goto IL_0400;
					}
				}
			}
		}
		object obj27 = lit_bufsize - 1;
		bool flag4 = num10 == (nint)obj27;
		result = true;
		if (!flag4)
		{
			result = last_lit == lit_bufsize;
		}
		goto IL_0400;
		IL_0400:
		return result;
	}

	internal void send_compressed_block(short[] ltree, short[] dtree)
	{
		//IL_0316: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		//IL_0091: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I4, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		if (last_lit != 0)
		{
			object obj = 0;
			bool flag;
			do
			{
				object obj2 = obj << 1;
				object obj3 = _distanceOffset + obj2;
				object obj4 = obj + _lengthOffset;
				object obj5 = (object)pending + obj4;
				object obj6 = obj + 1;
				object obj7 = obj3 + 1;
				object obj8 = (object)pending + obj7;
				object obj9 = obj3 + (object)pending;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19+10]");
				object obj10 = (nint)0 << 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v25+10]");
				object obj11 = 0 | obj10;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+10]");
					send_code(0, ltree);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+10]");
					object obj12 = 0 + Tree.LengthCode;
					int lITERALS = InternalConstants.LITERALS;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v35+10]");
					object obj13 = (nint)lITERALS + (nint)0;
					int c = obj13 + 1;
					send_code(c, ltree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v35+10]");
					object obj14 = (nint)0 << 2;
					object obj15 = (object)Tree.ExtraLengthBits + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v44+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v35+10]");
						object obj16 = (nint)0 << 2;
						object obj17 = (object)Tree.LengthBase + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+10]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S2_v39+10]");
						int value = (int)(num - 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v44+10]");
						send_bits(value, 0);
					}
					int num2 = obj11 - 1;
					int num3 = Tree.DistanceCode(num2);
					send_code(num3, dtree);
					int num4 = num3 << 2;
					object obj18 = Tree.ExtraDistanceBits + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v54+10]");
					if ((nint)0 != 0)
					{
						int num5 = num3 << 2;
						object obj19 = Tree.DistanceBase + num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S2_v32+10]");
						int value2 = (int)((nint)num2 - (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v54+10]");
						send_bits(value2, 0);
					}
				}
				flag = (nint)obj6 < last_lit;
				obj = obj6;
			}
			while (flag);
		}
		send_code(END_BLOCK, ltree);
		int num6 = END_BLOCK << 1;
		object obj20 = num6 + 1;
		object obj21 = obj20 << 1;
		object obj22 = (object)ltree + obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v8+10]");
		last_eob_len = 0;
	}

	internal void set_data_type()
	{
		//IL_0154: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_010a: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01f0: Expected I4, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		object obj = 0;
		object obj5 = default;
		while ((nint)obj < 7)
		{
			object obj2 = obj << 2;
			object obj3 = (object)dyn_ltree + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v39+10]");
			object obj4 = 0 + obj5;
			object obj6 = obj + 1;
			obj = obj6;
			obj5 = obj4;
		}
		object obj9 = default;
		object obj10 = default;
		while ((nint)obj < 128)
		{
			object obj7 = obj << 2;
			object obj8 = (object)dyn_ltree + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v32+10]");
			obj9 = 0 + obj10;
			object obj11 = obj + 1;
			obj = obj11;
		}
		while (InternalConstants.LITERALS > (nint)obj)
		{
			object obj12 = obj << 2;
			object obj13 = (object)dyn_ltree + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v25+10]");
			object obj14 = 0 + obj5;
			object obj15 = obj + 1;
			obj = obj15;
			obj5 = obj14;
		}
		nint num = (nint)typeof(DeflateManager);
		object obj16 = obj9 >> 2;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
		object obj17 = 44;
		if (!flag)
		{
			obj17 = 48;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v9 (Il2CppClass<Ionic.Zlib.DeflateManager>)+5C]");
		object obj18 = 0 + obj17;
		data_type = (sbyte)(int)obj18;
	}

	internal void bi_flush()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		int num3;
		if (bi_valid == 16)
		{
			int num = pendingCount + 1;
			pendingCount = num;
			object obj = pending + pendingCount;
			_ = bi_buf;
			int num2 = pendingCount + 1;
			pendingCount = num2;
			object obj2 = pending + pendingCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateManager)+D1]");
			_ = 0;
			bi_buf = 0;
			num3 = 0;
		}
		else
		{
			if (bi_valid < 8)
			{
				return;
			}
			int num4 = pendingCount + 1;
			pendingCount = num4;
			object obj3 = pending + pendingCount;
			_ = bi_buf;
			int num5 = bi_buf >> 8;
			bi_buf = (short)num5;
			num3 = bi_valid - 8;
		}
		bi_valid = num3;
	}

	internal void bi_windup()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		if (bi_valid >= 9)
		{
			int num = pendingCount + 1;
			pendingCount = num;
			object obj = pending + pendingCount;
			_ = bi_buf;
			int num2 = pendingCount + 1;
			pendingCount = num2;
			object obj2 = pending + pendingCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateManager)+D1]");
			_ = 0;
		}
		else if (bi_valid >= 1)
		{
			int num3 = pendingCount + 1;
			pendingCount = num3;
			object obj3 = pending + pendingCount;
			_ = bi_buf;
		}
		bi_valid = 0;
		bi_buf = 0;
	}

	internal void copy_block(int buf, int len, bool header)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		bi_windup();
		last_eob_len = 8;
		if (header)
		{
			int num = pendingCount + 1;
			pendingCount = num;
			object obj = pending + pendingCount;
			int num2 = pendingCount + 1;
			pendingCount = num2;
			object obj2 = pending + pendingCount;
			int num3 = len >> 8;
			int num4 = pendingCount + 1;
			pendingCount = num4;
			object obj3 = pending + pendingCount;
			int num5 = len ^ -1;
			int num6 = pendingCount + 1;
			pendingCount = num6;
			object obj4 = pending + pendingCount;
			int num7 = num5 >> 8;
		}
		put_bytes(window, buf, len);
	}

	internal void flush_block_only(bool eof)
	{
		bool flag = block_start > -1;
		int buf = block_start;
		if (!flag)
		{
			buf = -1;
		}
		int stored_len = strstart - block_start;
		_tr_flush_block(buf, stored_len, eof);
		block_start = strstart;
		_codec.flush_pending();
	}

	internal BlockState DeflateNone(FlushType flush)
	{
		//IL_0208: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected I4, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I4
		byte[] array = pending;
		object obj = array.Length - 5;
		bool flag = (nint)obj <= 65534;
		bool flag2 = !flag;
		object obj2 = 65535;
		if (!flag2)
		{
			byte[] array2 = pending;
			object obj3 = array2.Length - 5;
			obj2 = obj3;
		}
		BlockState result;
		while (true)
		{
			bool flag3 = lookahead > 1;
			int num = lookahead;
			if (!flag3)
			{
				_fillWindow();
				num = lookahead;
				if (lookahead == 0)
				{
					if (flush == FlushType.None)
					{
						return BlockState.NeedMore;
					}
					bool flag4 = flush == FlushType.Finish;
					flush_block_only(flag4);
					ZlibCodec codec = _codec;
					if (codec.AvailableBytesOut != 0)
					{
						BlockState blockState = BlockState.FinishDone;
						if (!flag4)
						{
							blockState = BlockState.BlockDone;
						}
						result = blockState;
						break;
					}
					return (BlockState)((flag4 ? 1u : 0u) << 1);
				}
			}
			int num2 = num + strstart;
			lookahead = 0;
			strstart = num2;
			int num3 = obj2 + block_start;
			bool flag5 = num3 > strstart;
			int num4 = strstart;
			if (!flag5)
			{
				num4 = 0;
			}
			bool flag6 = num4 == 0;
			bool flag7 = !flag6;
			int num5 = strstart;
			if (!flag7)
			{
				strstart = num3;
				int num6 = strstart - num3;
				lookahead = num6;
				flush_block_only(eof: false);
				ZlibCodec codec2 = _codec;
				bool flag8 = codec2.AvailableBytesOut == 0;
				result = BlockState.NeedMore;
				if (flag8)
				{
					break;
				}
				num5 = strstart;
			}
			object obj4 = num5 - block_start;
			object obj5 = w_size - MIN_LOOKAHEAD;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				flush_block_only(eof: false);
				ZlibCodec codec3 = _codec;
				if (codec3.AvailableBytesOut == 0)
				{
					result = BlockState.NeedMore;
					break;
				}
			}
		}
		return result;
	}

	internal void _tr_stored_block(int buf, int stored_len, bool eof)
	{
		int num = STORED_BLOCK << 1;
		int value = (eof ? 1 : 0) + num;
		send_bits(value, 3);
		copy_block(buf, stored_len, header: true);
	}

	internal void _tr_flush_block(int buf, int stored_len, bool eof)
	{
		//IL_00d4: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		int num = default;
		object obj2;
		object obj5;
		if (compressionLevel >= CompressionLevel.BestSpeed)
		{
			if (Z_UNKNOWN == data_type)
			{
				set_data_type();
			}
			treeLiterals.build_tree(this);
			treeDistances.build_tree(this);
			num = build_bl_tree();
			object obj = opt_len + 10;
			obj2 = obj >> 3;
			object obj3 = static_len + 10;
			object obj4 = obj3 >> 3;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				obj2 = obj4;
			}
			obj5 = obj4;
		}
		else
		{
			obj2 = stored_len + 5;
			obj5 = obj2;
		}
		object obj6 = stored_len + 4;
		if (buf != -1 && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			_tr_stored_block(buf, stored_len, eof);
		}
		else if (obj5 == obj2)
		{
			int num2 = STATIC_TREES << 1;
			int value = (eof ? 1 : 0) + num2;
			send_bits(value, 3);
			send_compressed_block(StaticTree.lengthAndLiteralsTreeCodes, StaticTree.distTreeCodes);
		}
		else
		{
			int num3 = DYN_TREES << 1;
			int value2 = (eof ? 1 : 0) + num3;
			send_bits(value2, 3);
			Tree tree = treeLiterals;
			int lcodes = tree.max_code + 1;
			Tree tree2 = treeDistances;
			int dcodes = tree2.max_code + 1;
			int blcodes = num + 1;
			send_all_trees(lcodes, dcodes, blcodes);
			send_compressed_block(dyn_ltree, dyn_dtree);
		}
		_InitializeBlocks();
		if (eof)
		{
			bi_windup();
		}
	}

	private void _fillWindow()
	{
		//IL_038f: Expected Obj, but got I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected I4, but got Unknown
		//IL_03ac: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04ae: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		ZlibCodec codec2;
		do
		{
			object obj = window_size - lookahead;
			int num = obj - strstart;
			object obj2 = num + 1;
			int size;
			if (obj2 != null)
			{
				int num2;
				if ((nint)obj2 == 1)
				{
					num2 = strstart;
					if (strstart == 0)
					{
						num2 = 0;
						if (lookahead == 0)
						{
							size = w_size;
							goto IL_02da;
						}
					}
				}
				else
				{
					num2 = strstart;
				}
				object obj3 = w_size + w_size;
				object obj4 = obj3 - MIN_LOOKAHEAD;
				bool flag = num2 < (nint)obj4;
				size = num;
				if (!flag)
				{
					Array.Copy(window, w_size, window, 0, w_size);
					int num3 = match_start - w_size;
					match_start = num3;
					int num4 = strstart - w_size;
					strstart = num4;
					int num5 = block_start - w_size;
					block_start = num5;
					int num6 = hash_size;
					int num10;
					do
					{
						int num7 = num6 - 1;
						int num8 = num7 << 1;
						object obj5 = head + num8;
						int num9 = num7 << 1;
						object obj6 = head + num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v56+10]");
						object obj7 = (nint)0 & (nint)0xFFFF;
						if (w_size > (nint)obj7)
						{
							object obj8 = 0;
						}
						else
						{
							object obj8 = obj7 - w_size;
						}
						num10 = hash_size - 1;
						num6 = num7;
					}
					while (num10 != 0);
					int num11 = w_size;
					int num15;
					do
					{
						int num12 = num11 - 1;
						int num13 = num12 << 1;
						object obj9 = prev + num13;
						int num14 = num12 << 1;
						object obj10 = prev + num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v68+10]");
						object obj11 = (nint)0 & (nint)0xFFFF;
						if (w_size > (nint)obj11)
						{
							object obj12 = 0;
						}
						else
						{
							object obj12 = obj11 - w_size;
						}
						num15 = w_size - 1;
						num11 = num12;
					}
					while (num15 != 0);
					int num16 = w_size + num;
					size = num16;
				}
			}
			else
			{
				size = -2;
			}
			goto IL_02da;
			IL_02da:
			ZlibCodec codec = _codec;
			if (codec.AvailableBytesIn != 0)
			{
				int start = strstart + lookahead;
				int num17 = codec.read_buf(window, start, size);
				int num18 = (lookahead = num17 + lookahead);
				if (MIN_MATCH <= num18)
				{
					object obj13 = window + strstart;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v21+10]");
					ins_h = 0;
					object obj14 = strstart + 1;
					object obj15 = (object)window + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v21+10]");
					int num19 = (int)((nint)0 << hash_shift);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v14+10]");
					int num20 = (int)((nint)0 ^ (nint)num19);
					int num21 = hash_mask & num20;
					ins_h = num21;
				}
				if (lookahead < MIN_LOOKAHEAD)
				{
					codec2 = _codec;
					continue;
				}
				break;
			}
			break;
		}
		while (codec2.AvailableBytesIn != 0);
	}

	internal BlockState DeflateFast(FlushType flush)
	{
		//IL_00c9: Expected Obj, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0462: Expected Obj, but got I4
		//IL_070e: Expected Obj, but got I4
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected Obj, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		bool flag = default;
		BlockState result;
		int num11 = default;
		int num12 = default;
		int num13 = default;
		while (true)
		{
			int num;
			int num2;
			if (MIN_LOOKAHEAD <= lookahead)
			{
				num = (flag ? 1 : 0);
				num2 = lookahead;
			}
			else
			{
				_fillWindow();
				bool flag2 = MIN_LOOKAHEAD > lookahead;
				bool flag3 = false;
				if (flush == FlushType.None)
				{
					flag3 = flag2;
				}
				result = BlockState.NeedMore;
				if (flag3)
				{
					break;
				}
				bool flag4 = lookahead == 0;
				num = lookahead;
				num2 = lookahead;
				if (flag4)
				{
					bool flag5 = flush == FlushType.Finish;
					flush_block_only(flag5);
					ZlibCodec codec = _codec;
					if (codec.AvailableBytesOut != 0)
					{
						BlockState blockState = BlockState.FinishDone;
						if (!flag5)
						{
							blockState = BlockState.BlockDone;
						}
						result = blockState;
						break;
					}
					return (BlockState)((flag5 ? 1u : 0u) << 1);
				}
			}
			if (MIN_MATCH <= num2)
			{
				object obj = MIN_MATCH - 1;
				object obj2 = obj + strstart;
				object obj3 = obj2 + (object)window;
				int num3 = ins_h << hash_shift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v57+10]");
				int num4 = (int)((nint)0 ^ (nint)num3);
				int num5 = (ins_h = hash_mask & num4) << 1;
				object obj4 = head + num5;
				int num6 = w_mask & strstart;
				int num7 = num6 << 1;
				object obj5 = prev + num7;
				int num8 = ins_h << 1;
				object obj6 = head + num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v93+10]");
				_ = 0;
				int num9 = ins_h << 1;
				object obj7 = head + num9;
				_ = strstart;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v133+10]");
				int num10 = (int)((nint)0 & (nint)0xFFFF);
				num11 = hash_shift;
				num12 = hash_shift;
				num13 = num10;
				num = ins_h;
			}
			bool flag6 = num13 == 0;
			bool flag7 = (byte)num != 0;
			if (!flag6)
			{
				object obj8 = w_size - MIN_LOOKAHEAD;
				object obj9 = strstart - num13;
				object obj10 = obj9 & 0xFFFF;
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
				flag7 = (byte)strstart != 0;
				if (!flag8)
				{
					bool flag9 = compressionStrategy == CompressionStrategy.HuffmanOnly;
					flag7 = (byte)strstart != 0;
					if (!flag9)
					{
						int num14 = longest_match(num13);
						match_length = num14;
						flag7 = (byte)strstart != 0;
					}
				}
			}
			int num28;
			int num29;
			int num30;
			if (MIN_MATCH <= match_length)
			{
				int dist = strstart - match_start;
				int lc = match_length - MIN_MATCH;
				bool flag10 = _tr_tally(dist, lc);
				int num15 = (lookahead -= match_length);
				Config config = this.config;
				bool flag11 = match_length > config.MaxLazy;
				int num16 = match_length;
				if (!flag11)
				{
					bool flag12 = num15 < MIN_MATCH;
					num16 = match_length;
					if (!flag12)
					{
						int num17 = match_length - 1;
						match_length = num17;
						do
						{
							int num18 = ++strstart;
							object obj11 = MIN_MATCH - 1;
							object obj12 = obj11 + num18;
							object obj13 = obj12 + (object)window;
							int num19 = ins_h << hash_shift;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S2_v35+10]");
							int num20 = (int)((nint)0 ^ (nint)num19);
							int num21 = (ins_h = hash_mask & num20) << 1;
							object obj14 = head + num21;
							int num22 = w_mask & strstart;
							int num23 = num22 << 1;
							object obj15 = prev + num23;
							int num24 = ins_h << 1;
							object obj16 = head + num24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S1_v58+10]");
							_ = 0;
							int num25 = ins_h << 1;
							object obj17 = head + num25;
							_ = strstart;
						}
						while (--match_length != 0);
						int num26 = strstart + 1;
						strstart = num26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v92+10]");
						int num27 = (int)((nint)0 & (nint)0xFFFF);
						bool flag13 = !flag10;
						num11 = hash_shift;
						num12 = ins_h;
						num13 = num27;
						flag = flag10;
						if (flag13)
						{
							continue;
						}
						num28 = hash_shift;
						num29 = ins_h;
						num30 = num27;
						flag7 = flag10;
						goto IL_05a9;
					}
				}
				int num31 = num16 + strstart;
				match_length = 0;
				strstart = num31;
				object obj18 = num31 + window;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v32+10]");
				ins_h = 0;
				object obj19 = strstart + 1;
				object obj20 = (object)window + obj19;
				num11 = hash_shift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v32+10]");
				int num32 = (int)((nint)0 << hash_shift);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S2_v23+10]");
				int num33 = (int)((nint)0 ^ (nint)num32);
				int num34 = hash_mask & num33;
				ins_h = num34;
				bool flag14 = !flag10;
				num12 = num15;
				flag = flag10;
				if (flag14)
				{
					continue;
				}
				num28 = hash_shift;
				num29 = num15;
				num30 = num13;
				flag7 = flag10;
			}
			else
			{
				object obj21 = window + strstart;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S2_v10+10]");
				bool flag15 = _tr_tally(0, 0);
				int num35 = lookahead - 1;
				lookahead = num35;
				int num36 = strstart + 1;
				strstart = num36;
				bool flag16 = !flag15;
				num28 = num11;
				num29 = num12;
				num30 = num13;
				flag = flag7;
				if (flag16)
				{
					continue;
				}
			}
			goto IL_05a9;
			IL_05a9:
			flush_block_only(eof: false);
			ZlibCodec codec2 = _codec;
			num11 = num28;
			num12 = num29;
			num13 = num30;
			flag = flag7;
			if (codec2.AvailableBytesOut == 0)
			{
				result = BlockState.NeedMore;
				break;
			}
		}
		return result;
	}

	internal BlockState DeflateSlow(FlushType flush)
	{
		//IL_00b7: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_06fc: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected I4, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected I4, but got Unknown
		//IL_03dd: Expected Obj, but got I4
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected I4, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I4
		BlockState result;
		int num10 = default;
		while (true)
		{
			int num;
			if (MIN_LOOKAHEAD <= lookahead)
			{
				num = lookahead;
			}
			else
			{
				_fillWindow();
				bool flag = MIN_LOOKAHEAD > lookahead;
				bool flag2 = false;
				if (flush == FlushType.None)
				{
					flag2 = flag;
				}
				result = BlockState.NeedMore;
				if (flag2)
				{
					break;
				}
				bool flag3 = lookahead == 0;
				num = lookahead;
				if (flag3)
				{
					if (match_available != 0)
					{
						object obj = strstart - 1;
						object obj2 = (object)window + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S2_v81+10]");
						bool flag4 = _tr_tally(0, 0);
						match_available = 0;
					}
					bool flag5 = flush == FlushType.Finish;
					flush_block_only(flag5);
					ZlibCodec codec = _codec;
					if (codec.AvailableBytesOut != 0)
					{
						BlockState blockState = BlockState.FinishDone;
						if (!flag5)
						{
							blockState = BlockState.BlockDone;
						}
						result = blockState;
						break;
					}
					return (BlockState)((flag5 ? 1u : 0u) << 1);
				}
			}
			if (MIN_MATCH <= num)
			{
				object obj3 = MIN_MATCH - 1;
				object obj4 = obj3 + strstart;
				object obj5 = obj4 + (object)window;
				int num2 = ins_h << hash_shift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S2_v62+10]");
				int num3 = (int)((nint)0 ^ (nint)num2);
				int num4 = (ins_h = hash_mask & num3) << 1;
				object obj6 = head + num4;
				int num5 = w_mask & strstart;
				int num6 = num5 << 1;
				object obj7 = prev + num6;
				int num7 = ins_h << 1;
				object obj8 = head + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v133+10]");
				_ = 0;
				int num8 = ins_h << 1;
				object obj9 = head + num8;
				_ = strstart;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v160+10]");
				int num9 = (int)((nint)0 & (nint)0xFFFF);
				num10 = num9;
			}
			prev_length = match_length;
			prev_match = match_start;
			int num11 = MIN_MATCH - 1;
			match_length = num11;
			if (num10 != 0)
			{
				Config config = this.config;
				if (prev_length < config.MaxLazy)
				{
					object obj10 = w_size - MIN_LOOKAHEAD;
					object obj11 = strstart - num10;
					object obj12 = obj11 & 0xFFFF;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
					{
						int num12 = ((compressionStrategy == CompressionStrategy.HuffmanOnly) ? match_length : (match_length = longest_match(num10)));
						if (num12 <= 5)
						{
							if (compressionStrategy == CompressionStrategy.Filtered)
							{
								goto IL_032a;
							}
							if (num12 == MIN_MATCH)
							{
								object obj13 = strstart - match_start;
								if ((nint)obj13 >= 4097)
								{
									goto IL_032a;
								}
							}
						}
					}
				}
			}
			goto IL_07f2;
			IL_07f2:
			if (prev_length >= MIN_MATCH && match_length <= prev_length)
			{
				object obj14 = lookahead + strstart;
				int num13 = obj14 - MIN_MATCH;
				object obj15 = strstart - 1;
				int dist = obj15 - prev_match;
				int lc = prev_length - MIN_MATCH;
				bool flag6 = _tr_tally(dist, lc);
				object obj16 = prev_length - 1;
				int num14 = lookahead - obj16;
				lookahead = num14;
				int num15 = prev_length - 2;
				prev_length = num15;
				do
				{
					int num16 = ++strstart;
					if (num16 <= num13)
					{
						object obj17 = MIN_MATCH - 1;
						object obj18 = obj17 + num16;
						object obj19 = obj18 + (object)window;
						int num17 = ins_h << hash_shift;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S2_v40+10]");
						int num18 = (int)((nint)0 ^ (nint)num17);
						int num19 = (ins_h = hash_mask & num18) << 1;
						object obj20 = head + num19;
						int num20 = w_mask & strstart;
						int num21 = num20 << 1;
						object obj21 = prev + num21;
						int num22 = ins_h << 1;
						object obj22 = head + num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S1_v85+10]");
						_ = 0;
						int num23 = ins_h << 1;
						object obj23 = head + num23;
						_ = strstart;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v101+10]");
						int num24 = (int)((nint)0 & (nint)0xFFFF);
						num10 = num24;
					}
				}
				while (--prev_length != 0);
				match_available = 0;
				int num25 = MIN_MATCH - 1;
				match_length = num25;
				int num26 = strstart + 1;
				strstart = num26;
				if (flag6)
				{
					flush_block_only(eof: false);
					ZlibCodec codec2 = _codec;
					if (codec2.AvailableBytesOut == 0)
					{
						result = BlockState.NeedMore;
						break;
					}
				}
			}
			else if (match_available != 0)
			{
				object obj24 = strstart - 1;
				object obj25 = (object)window + obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S2_v11+10]");
				if (_tr_tally(0, 0))
				{
					flush_block_only(eof: false);
				}
				int num27 = strstart + 1;
				strstart = num27;
				int num28 = lookahead - 1;
				lookahead = num28;
				ZlibCodec codec3 = _codec;
				if (codec3.AvailableBytesOut == 0)
				{
					return BlockState.NeedMore;
				}
			}
			else
			{
				match_available = 1;
				int num29 = strstart + 1;
				strstart = num29;
				int num30 = lookahead - 1;
				lookahead = num30;
			}
			continue;
			IL_032a:
			int num31 = MIN_MATCH - 1;
			match_length = num31;
			goto IL_07f2;
		}
		return result;
	}

	internal int longest_match(int cur_match)
	{
		//IL_0653: Expected Obj, but got I4
		//IL_068d: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I4
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06cc: Expected Obj, but got I4
		//IL_0888: Expected Obj, but got I
		//IL_0898: Expected Obj, but got I
		//IL_0829: Expected Obj, but got I
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected Obj, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected I4, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected I4, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_0565: Expected Obj, but got I4
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_058f: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		Config config = this.config;
		int num = config.MaxChainLength;
		object obj = w_size - MIN_LOOKAHEAD;
		bool flag = strstart > (nint)obj;
		bool flag2 = !flag;
		Config config2 = this.config;
		object obj2 = MAX_MATCH + strstart;
		object obj3 = prev_length + strstart;
		object obj4 = obj3 - 1;
		object obj5 = (object)window + obj4;
		object obj6 = prev_length + strstart;
		object obj7 = (object)window + obj6;
		int num2 = config.MaxChainLength >> 2;
		Config config3 = this.config;
		if (prev_length >= config3.GoodLength)
		{
			num = num2;
		}
		bool flag3 = lookahead < config2.NiceLength;
		int niceLength = lookahead;
		if (!flag3)
		{
			niceLength = config2.NiceLength;
		}
		int num3 = prev_length;
		int num4 = strstart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v39+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v35+10]");
		object obj9 = 0;
		int num18;
		int num20 = default;
		object obj66 = default;
		int num22;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v22+10]");
			object obj10 = (nint)0 + (nint)num3;
			object obj11 = (object)window + obj10;
			object obj12 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v17+10]");
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v22+10]");
				object obj13 = (nint)0 + (nint)num3;
				object obj14 = obj13 - 1;
				object obj15 = (object)window + obj14;
				object obj16 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v29+10]");
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v22+10]");
					object obj17 = 0 + window;
					object obj18 = num4 + window;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v62+10]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v34+10]");
					if (num5 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v22+10]");
						int num6 = (int)((nint)0 + (nint)1);
						object obj19 = num6 + window;
						object obj20 = num4 + 1;
						object obj21 = (object)window + obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v67+10]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v41+10]");
						if (num7 == 0)
						{
							object obj22 = num4 + 2;
							object obj23 = num6 + 1;
							object obj24 = obj22;
							object obj25 = obj23;
							object obj30;
							bool flag12;
							do
							{
								object obj26 = obj24 + 1;
								object obj27 = obj26 + (object)window;
								object obj28 = obj25 + 1;
								object obj29 = obj28 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v77+10]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v51+10]");
								bool flag4 = num8 != 0;
								obj30 = obj26;
								if (flag4)
								{
									break;
								}
								object obj31 = obj26 + 1;
								object obj32 = obj31 + (object)window;
								object obj33 = obj28 + 1;
								object obj34 = obj33 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v107+10]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v73+10]");
								bool flag5 = num9 != 0;
								obj30 = obj31;
								if (flag5)
								{
									break;
								}
								object obj35 = obj31 + 1;
								object obj36 = obj35 + (object)window;
								object obj37 = obj33 + 1;
								object obj38 = obj37 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v112+10]");
								nint num10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v80+10]");
								bool flag6 = num10 != 0;
								obj30 = obj35;
								if (flag6)
								{
									break;
								}
								object obj39 = obj35 + 1;
								object obj40 = obj39 + (object)window;
								object obj41 = obj37 + 1;
								object obj42 = obj41 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v117+10]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S1_v87+10]");
								bool flag7 = num11 != 0;
								obj30 = obj39;
								if (flag7)
								{
									break;
								}
								object obj43 = obj39 + 1;
								object obj44 = obj43 + (object)window;
								object obj45 = obj41 + 1;
								object obj46 = obj45 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v122+10]");
								nint num12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v94+10]");
								bool flag8 = num12 != 0;
								obj30 = obj43;
								if (flag8)
								{
									break;
								}
								object obj47 = obj43 + 1;
								object obj48 = obj47 + (object)window;
								object obj49 = obj45 + 1;
								object obj50 = obj49 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v127+10]");
								nint num13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S1_v101+10]");
								bool flag9 = num13 != 0;
								obj30 = obj47;
								if (flag9)
								{
									break;
								}
								object obj51 = obj47 + 1;
								object obj52 = obj51 + (object)window;
								object obj53 = obj49 + 1;
								object obj54 = obj53 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v132+10]");
								nint num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v108+10]");
								bool flag10 = num14 != 0;
								obj30 = obj51;
								if (flag10)
								{
									break;
								}
								object obj55 = obj51 + 1;
								object obj56 = obj55 + (object)window;
								object obj57 = obj53 + 1;
								object obj58 = obj57 + (object)window;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v137+10]");
								nint num15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S1_v115+10]");
								bool flag11 = num15 != 0;
								obj30 = obj55;
								if (flag11)
								{
									break;
								}
								flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
								obj30 = obj55;
								obj24 = obj55;
								obj25 = obj57;
							}
							while (flag12);
							object obj59 = obj2 - obj30;
							int num16 = MAX_MATCH - obj59;
							int num17 = obj2 - MAX_MATCH;
							bool flag13 = num3 >= num16;
							num4 = num17;
							if (!flag13)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v22+10]");
								match_start = 0;
								if (num16 >= niceLength)
								{
									num18 = num16;
									break;
								}
								object obj60 = num16 + num17;
								object obj61 = obj60 - 1;
								object obj62 = (object)window + obj61;
								object obj63 = num16 + num17;
								object obj64 = (object)window + obj63;
								num3 = num16;
								num4 = num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v101+10]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v97+10]");
								obj9 = 0;
							}
						}
					}
				}
			}
			int num19 = num20 & w_mask;
			int num21 = num19 << 1;
			object obj65 = prev + num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v22+10]");
			bool flag14 = (nint)obj66 >= 0;
			num18 = num3;
			if (flag14)
			{
				break;
			}
			num22 = num - 1;
			num18 = num3;
		}
		while (num22 != 0);
		int result = lookahead;
		if (lookahead >= num18)
		{
			result = num18;
		}
		return result;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level)
	{
		int num = Initialize(codec, level, 15);
		return 0;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
	{
		int num = Initialize(codec, level, bits, MEM_LEVEL_DEFAULT, CompressionStrategy.Default);
		return 0;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
	{
		int num = Initialize(codec, level, bits, MEM_LEVEL_DEFAULT, compressionStrategy);
		return 0;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02fd: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected I4, but got Unknown
		//IL_02d1: Expected I4, but got Obj
		//IL_017d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_codec = codec;
		ZlibCodec codec2 = _codec;
		codec2.Message = null;
		object obj3 = windowBits - 9;
		if ((nint)obj3 < 7)
		{
			if (memLevel >= 1 && MEM_LEVEL_MAX >= memLevel)
			{
				ZlibCodec codec3 = _codec;
				codec3.dstate = this;
				int num = (w_size = 1 << windowBits);
				w_bits = windowBits;
				int num2 = num - 1;
				w_mask = num2;
				int num3 = (hash_size = 1 << (hash_bits = memLevel + 7)) - 1;
				hash_mask = num3;
				object obj4 = MIN_MATCH + hash_bits;
				object obj5 = obj4 - 1;
				int num4 = obj5 / MIN_MATCH;
				hash_shift = num4;
				int num5 = w_size << 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				byte[] array = default;
				window = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				short[] array2 = default;
				prev = array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				short[] array3 = default;
				head = array3;
				object obj6 = memLevel + 6;
				int num6 = (lit_bufsize = 1 << (int)obj6) << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				byte[] array4 = default;
				pending = array4;
				_distanceOffset = lit_bufsize;
				compressionStrategy = strategy;
				compressionLevel = level;
				int lengthOffset = lit_bufsize * 3;
				_lengthOffset = lengthOffset;
				Reset();
				return 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("windowBits must be in the range 9..15.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v9+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj8 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string s = $"memLevel must be in the range 1.. {arg}";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex2 = default;
		ex2._002Ector(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex2;
	}

	internal void Reset()
	{
		//IL_003c: Expected I8, but got I4
		//IL_004a: Expected I8, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a6: Expected I4, but got Obj
		//IL_000e: Expected Obj, but got I4
		ZlibCodec codec = _codec;
		codec.Message = null;
		codec.TotalBytesIn = 0L;
		codec.TotalBytesOut = 0L;
		Rfc1950BytesEmitted = false;
		nextPending = 0;
		nint num = (nint)typeof(DeflateManager);
		object obj = 16;
		if (!_WantRfc1950HeaderBytes)
		{
			obj = 20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8 (Il2CppClass<Ionic.Zlib.DeflateManager>)+5C]");
		object obj2 = 0 + obj;
		status = (int)obj2;
		ZlibCodec codec2 = _codec;
		uint adler = Adler.Adler32(0u, null, 0, 0);
		codec2._Adler32 = adler;
		last_flush = 0;
		_InitializeTreeData();
		_InitializeLazyMatch();
	}

	internal int End()
	{
		if (status == INIT_STATE || status == BUSY_STATE || status == FINISH_STATE)
		{
			pending = null;
			head = null;
			prev = null;
			window = null;
			bool flag = status == BUSY_STATE;
			int result = -3;
			if (!flag)
			{
				result = 0;
			}
			return result;
		}
		return -2;
	}

	private void SetDeflater()
	{
		Config config = this.config;
		bool flag = config.Flavor == DeflateFlavor.Store;
		nint method = 0;
		if (!flag)
		{
			if (config.Flavor != DeflateFlavor.Fast)
			{
				if (config.Flavor != DeflateFlavor.Slow)
				{
					return;
				}
				method = 0;
			}
			else
			{
				method = 0;
			}
		}
		CompressFunc compressFunc = default;
		compressFunc._002Ector(this, method);
		DeflateFunction = compressFunc;
	}

	internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
	{
		bool flag = level != compressionLevel;
		bool flag2 = !flag;
		int result = 0;
		if (!flag2)
		{
			Config config = Config.Lookup(level);
			Config config2 = this.config;
			bool flag3 = config.Flavor == config2.Flavor;
			result = 0;
			if (!flag3)
			{
				ZlibCodec codec = _codec;
				bool flag4 = codec.TotalBytesIn == 0;
				result = 0;
				if (!flag4)
				{
					int num = codec.Deflate(FlushType.Partial);
					result = num;
				}
			}
			this.config = config;
			compressionLevel = level;
			SetDeflater();
		}
		compressionStrategy = strategy;
		return result;
	}

	internal int SetDictionary(byte[] dictionary)
	{
		//IL_021e: Expected I4, but got Obj
		//IL_0071: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected I4, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		if (INIT_STATE == status)
		{
			ZlibCodec codec = _codec;
			uint adler = Adler.Adler32(codec._Adler32, dictionary, 0, dictionary.Length);
			codec._Adler32 = adler;
			if (dictionary.Length >= MIN_MATCH)
			{
				object obj = w_size - MIN_LOOKAHEAD;
				int sourceIndex;
				int num2;
				if (dictionary.Length > (nint)obj)
				{
					int num = w_size - MIN_LOOKAHEAD;
					sourceIndex = dictionary.Length - num;
					num2 = num;
				}
				else
				{
					num2 = dictionary.Length;
					sourceIndex = 0;
				}
				Array.Copy(dictionary, sourceIndex, window, 0, num2);
				block_start = num2;
				strstart = num2;
				byte[] array = window;
				ins_h = array[0];
				byte[] array2 = window;
				int num3 = array[0] << hash_shift;
				int num4 = array2[1] ^ num3;
				int num5 = hash_mask & num4;
				ins_h = num5;
				object obj2 = 0;
				while (true)
				{
					object obj3 = num2 - MIN_MATCH;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
					{
						break;
					}
					object obj4 = MIN_MATCH - 1;
					object obj5 = obj4 + obj2;
					object obj6 = obj5 + (object)window;
					int num6 = ins_h << hash_shift;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v24+10]");
					int num7 = (int)((nint)0 ^ (nint)num6);
					int num8 = (ins_h = hash_mask & num7);
					int num9 = w_mask & obj2;
					int num10 = num9 << 1;
					object obj7 = prev + num10;
					int num11 = num8 << 1;
					object obj8 = head + num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v37+10]");
					_ = 0;
					int num12 = ins_h << 1;
					object obj9 = head + num12;
					object obj10 = obj2 + 1;
					obj2 = obj10;
				}
			}
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex = default;
		ex._002Ector("Stream error.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex;
	}

	internal int Deflate(FlushType flush)
	{
		//IL_080e: Expected Obj, but got I
		//IL_081e: Expected Obj, but got I
		//IL_0833: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I
		//IL_08be: Expected Obj, but got I
		//IL_08d3: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0917: Expected I4, but got Obj
		//IL_09c1: Expected Obj, but got I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected Obj, but got Unknown
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected Obj, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected Obj, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected Obj, but got Unknown
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_036c: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_05bf: Expected Obj, but got I4
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		ZlibCodec codec = _codec;
		bool flag = codec.OutputBuffer == null;
		ZlibCodec zlibCodec = codec;
		if (flag)
		{
			goto IL_07e5;
		}
		if (codec.InputBuffer == null)
		{
			zlibCodec = codec;
			if (codec.AvailableBytesIn != 0)
			{
				goto IL_07e5;
			}
		}
		ZlibCodec codec2 = _codec;
		if (flush != FlushType.Finish)
		{
			bool flag2 = status == FINISH_STATE;
			zlibCodec = codec2;
			if (flag2)
			{
				goto IL_07e5;
			}
		}
		bool flag3 = codec2.AvailableBytesOut == 0;
		zlibCodec = codec2;
		int result;
		DeflateManager deflateManager2;
		DeflateManager deflateManager;
		if (!flag3)
		{
			last_flush = (int)flush;
			if (INIT_STATE == status)
			{
				object obj = compressionLevel - 1;
				object obj2 = obj >> 1;
				object obj3 = obj2 & 0x7F;
				if ((nint)obj3 >= 3)
				{
					obj3 = 3;
				}
				object obj4 = obj3 << 6;
				object obj5 = w_bits - 8;
				object obj6 = obj5 << 4;
				object obj7 = Z_DEFLATED + obj6;
				object obj8 = obj7 << 8;
				object obj9 = obj4 | obj8;
				status = BUSY_STATE;
				int num = pendingCount + 1;
				pendingCount = num;
				object obj10 = pending + pendingCount;
				object obj11 = obj9 / 31;
				object obj12 = obj11 * 31;
				object obj13 = obj9 - obj12;
				object obj14 = 31 - obj13;
				object obj15 = obj14 + obj9;
				object obj16 = obj15 >> 8;
				int num2 = pendingCount + 1;
				pendingCount = num2;
				object obj17 = pending + pendingCount;
				if (strstart != 0)
				{
					int num3 = pendingCount + 1;
					pendingCount = num3;
					object obj18 = pending + pendingCount;
					ZlibCodec codec3 = _codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v140 (Ionic.Zlib.ZlibCodec)+47]");
					_ = 0;
					int num4 = pendingCount + 1;
					pendingCount = num4;
					object obj19 = pending + pendingCount;
					ZlibCodec codec4 = _codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S1_v147 (Ionic.Zlib.ZlibCodec)+46]");
					_ = 0;
					int num5 = pendingCount + 1;
					pendingCount = num5;
					object obj20 = pending + pendingCount;
					ZlibCodec codec5 = _codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S1_v154 (Ionic.Zlib.ZlibCodec)+45]");
					_ = 0;
					int num6 = pendingCount + 1;
					pendingCount = num6;
					object obj21 = pending + pendingCount;
					ZlibCodec codec6 = _codec;
					_ = codec6._Adler32;
				}
				ZlibCodec codec7 = _codec;
				uint adler = Adler.Adler32(0u, null, 0, 0);
				codec7._Adler32 = adler;
			}
			ZlibCodec codec8 = _codec;
			if (pendingCount != 0)
			{
				codec8.flush_pending();
				ZlibCodec codec9 = _codec;
				if (codec9.AvailableBytesOut == 0)
				{
					goto IL_091c;
				}
			}
			else if (codec8.AvailableBytesIn == 0 && (int)flush <= last_flush)
			{
				bool flag4 = flush != FlushType.Finish;
				result = 0;
				if (flag4)
				{
					goto IL_0a32;
				}
			}
			ZlibCodec codec10 = _codec;
			if (FINISH_STATE == status)
			{
				if (codec10.AvailableBytesIn == 0)
				{
					goto IL_03d5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S1_v92+5C]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v93+8]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v94+2C]");
				codec10.Message = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ZlibException ex = default;
				ex._002Ector("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				deflateManager = (DeflateManager)(object)ex;
			}
			deflateManager2 = this;
			if (codec10.AvailableBytesIn == 0)
			{
				goto IL_03d5;
			}
			goto IL_0435;
		}
		goto IL_0961;
		IL_0a32:
		return result;
		IL_091c:
		last_flush = -1;
		return 0;
		IL_0435:
		CompressFunc deflateFunction = deflateManager2.DeflateFunction;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v456.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj24 = default;
		if (obj24 == null)
		{
			goto IL_0503;
		}
		DeflateManager deflateManager3;
		if ((nint)obj24 != 1)
		{
			if ((nint)obj24 != 2 && (nint)obj24 != 3)
			{
				deflateManager3 = deflateManager2;
			}
			else
			{
				deflateManager2.status = FINISH_STATE;
				bool flag5 = (nint)obj24 != 2;
				deflateManager3 = deflateManager2;
				if (!flag5)
				{
					goto IL_0503;
				}
			}
		}
		else
		{
			if (flush == FlushType.Partial)
			{
				deflateManager2._tr_align();
			}
			else
			{
				deflateManager2._tr_stored_block(0, 0, eof: false);
				if (flush == FlushType.Full)
				{
					object obj25 = 0;
					while ((nint)obj25 < deflateManager2.hash_size)
					{
						object obj26 = obj25 << 1;
						object obj27 = (object)deflateManager2.head + obj26;
						_ = 0;
						object obj28 = obj25 + 1;
						obj25 = obj28;
					}
				}
			}
			deflateManager2._codec.flush_pending();
			ZlibCodec codec11 = deflateManager2._codec;
			bool flag6 = codec11.AvailableBytesOut == 0;
			deflateManager3 = deflateManager2;
			deflateManager = deflateManager2;
			if (flag6)
			{
				goto IL_091c;
			}
		}
		goto IL_0605;
		IL_0503:
		ZlibCodec codec12 = deflateManager2._codec;
		bool flag7 = codec12.AvailableBytesOut == 0;
		deflateManager = deflateManager2;
		if (flag7)
		{
			goto IL_091c;
		}
		result = 0;
		goto IL_0a32;
		IL_07e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v15+5C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v16+8]");
		object obj30 = 0;
		ZlibCodec zlibCodec2 = zlibCodec;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v17+20]");
		zlibCodec2.Message = (string)0;
		ZlibCodec codec13 = _codec;
		string s = "Something is fishy. [" + codec13.Message + "]";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex2 = default;
		ex2._002Ector(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0961;
		IL_0605:
		bool flag8 = flush != FlushType.Finish;
		result = 0;
		if (!flag8)
		{
			bool flag9 = (byte)(~(deflateManager3._WantRfc1950HeaderBytes ? 1u : 0u)) != 0;
			result = 1;
			if (!flag9)
			{
				result = 1;
				if (!deflateManager3.Rfc1950BytesEmitted)
				{
					int num7 = deflateManager3.pendingCount + 1;
					deflateManager3.pendingCount = num7;
					object obj31 = deflateManager3.pending + deflateManager3.pendingCount;
					ZlibCodec codec14 = deflateManager3._codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S1_v40 (Ionic.Zlib.ZlibCodec)+47]");
					_ = 0;
					int num8 = deflateManager3.pendingCount + 1;
					deflateManager3.pendingCount = num8;
					object obj32 = deflateManager3.pending + deflateManager3.pendingCount;
					ZlibCodec codec15 = deflateManager3._codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S1_v47 (Ionic.Zlib.ZlibCodec)+46]");
					_ = 0;
					int num9 = deflateManager3.pendingCount + 1;
					deflateManager3.pendingCount = num9;
					object obj33 = deflateManager3.pending + deflateManager3.pendingCount;
					ZlibCodec codec16 = deflateManager3._codec;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S1_v54 (Ionic.Zlib.ZlibCodec)+45]");
					_ = 0;
					int num10 = deflateManager3.pendingCount + 1;
					deflateManager3.pendingCount = num10;
					object obj34 = deflateManager3.pending + deflateManager3.pendingCount;
					ZlibCodec codec17 = deflateManager3._codec;
					_ = codec17._Adler32;
					deflateManager3._codec.flush_pending();
					deflateManager3.Rfc1950BytesEmitted = true;
					return (deflateManager3.pendingCount == 0) ? 1 : 0;
				}
			}
		}
		goto IL_0a32;
		IL_0961:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v5+5C]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v6+8]");
		object obj36 = 0;
		ZlibCodec zlibCodec3 = zlibCodec;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v7+2C]");
		zlibCodec3.Message = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex3 = default;
		ex3._002Ector("OutputBuffer is full (AvailableBytesOut == 0)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		result = (int)zlibCodec;
		goto IL_0a32;
		IL_03d5:
		deflateManager2 = this;
		if (lookahead != 0)
		{
			goto IL_0435;
		}
		bool flag10 = flush == FlushType.None;
		deflateManager3 = this;
		if (!flag10)
		{
			bool flag11 = status == FINISH_STATE;
			deflateManager2 = this;
			deflateManager3 = this;
			if (!flag11)
			{
				goto IL_0435;
			}
		}
		goto IL_0605;
	}

	static DeflateManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
