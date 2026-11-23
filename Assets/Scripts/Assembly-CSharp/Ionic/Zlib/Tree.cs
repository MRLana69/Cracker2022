using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal sealed class Tree
{
	private static readonly int HEAP_SIZE;

	internal static readonly int[] ExtraLengthBits;

	internal static readonly int[] ExtraDistanceBits;

	internal static readonly int[] extra_blbits;

	internal static readonly sbyte[] bl_order;

	internal const int Buf_size = 16;

	private static readonly sbyte[] _dist_code;

	internal static readonly sbyte[] LengthCode;

	internal static readonly int[] LengthBase;

	internal static readonly int[] DistanceBase;

	internal short[] dyn_tree;

	internal int max_code;

	internal StaticTree staticTree;

	internal static int DistanceCode(int dist)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		int num = dist >> 7;
		int num2 = num + 256;
		if (dist < 256)
		{
			num2 = dist;
		}
		object obj = _dist_code + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+10]");
		return 0;
	}

	internal void gen_bitlen(DeflateManager s)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_074b: Expected Obj, but got I
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_079c: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I4
		//IL_07ae: Expected Obj, but got I4
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03ee: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_0452: Expected Obj, but got I
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_07d2: Expected Obj, but got I
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Obj, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected Obj, but got Unknown
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected I4, but got Unknown
		//IL_083f: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected I4, but got Unknown
		//IL_0350: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0577: Expected Obj, but got I
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_05cf: Expected Obj, but got I4
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected Obj, but got Unknown
		//IL_05f3: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_0658: Expected Obj, but got I
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected I4, but got Unknown
		//IL_06a2: Expected Obj, but got I
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		StaticTree staticTree = this.staticTree;
		int num2 = default;
		int num = num2;
		while (InternalConstants.MAX_BITS >= num)
		{
			int num3 = num << 1;
			object obj = s.bl_count + num3;
			_ = 0;
			int num4 = num + 1;
			num = num4;
		}
		int num5 = s.heap_max << 2;
		object obj2 = s.heap + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v6+10]");
		object obj3 = (nint)0 << 1;
		object obj4 = obj3 + 1;
		object obj5 = obj4 << 1;
		object obj6 = (object)dyn_tree + obj5;
		_ = 0;
		object obj7 = s.heap_max + 1;
		object obj8 = obj7;
		object obj9 = 2;
		object obj20 = default;
		object obj21 = default;
		while (HEAP_SIZE > (nint)obj8)
		{
			object obj10 = obj8 << 2;
			object obj11 = (object)s.heap + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
			object obj12 = (nint)0 << 1;
			object obj13 = obj12 + 1;
			object obj14 = obj13 << 1;
			object obj15 = (object)dyn_tree + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v42+10]");
			object obj16 = (nint)0 << 1;
			object obj17 = obj16 + 1;
			object obj18 = obj17 << 1;
			object obj19 = (object)dyn_tree + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v68+10]");
			int num6 = (int)((nint)0 + (nint)1);
			bool flag = staticTree.maxLength < num6;
			bool flag2 = !flag;
			int num7 = num6;
			if (!flag2)
			{
				obj20 = obj21 + 1;
				num7 = staticTree.maxLength;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
			object obj22 = (nint)0 << 1;
			object obj23 = obj22 + 1;
			object obj24 = obj23 << 1;
			object obj25 = (object)dyn_tree + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
			bool flag3 = (nint)0 > (nint)max_code;
			object obj26 = 2;
			object obj27 = 1;
			obj9 = 1;
			if (!flag3)
			{
				int num8 = num7 << 1;
				object obj28 = s.bl_count + num8;
				object obj29 = obj28 + 16;
				object obj30 = obj29 + 1;
				obj29 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
				bool flag4 = (nint)0 >= (nint)staticTree.extraBase;
				bool flag5 = !flag4;
				object obj31 = 0;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
					object obj32 = -staticTree.extraBase;
					object obj33 = obj32 << 2;
					object obj34 = (object)staticTree.extraBits + obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v117+10]");
					obj31 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
				object obj35 = (nint)0 << 2;
				object obj36 = (object)dyn_tree + obj35;
				obj9 = num7 + obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S2_v56+10]");
				object obj37 = 0 * obj9;
				int opt_len = s.opt_len + obj37;
				s.opt_len = opt_len;
				bool flag6 = staticTree.treeCodes == null;
				obj26 = 2;
				obj27 = obj31;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v16+10]");
					object obj38 = (nint)0 << 1;
					object obj39 = obj38 + 1;
					obj27 = obj39 << 1;
					object obj40 = (object)staticTree.treeCodes + obj27;
					object obj41 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S3_v30+10]");
					object obj42 = obj41 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S2_v56+10]");
					object obj43 = obj42 * 0;
					int static_len = s.static_len + obj43;
					s.static_len = static_len;
					obj26 = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S2_v56+10]");
					obj9 = 0;
				}
			}
			object obj44 = obj8 + 1;
			obj8 = obj44;
		}
		if (obj20 == null)
		{
			return;
		}
		bool flag7;
		int num13;
		do
		{
			int maxLength = staticTree.maxLength;
			maxLength = num2;
			int num9;
			do
			{
				num9 = maxLength - 1;
				int num10 = num9 << 1;
				object obj45 = s.bl_count + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v45+10]");
			}
			while ((nint)0 == 0);
			int num11 = num9 << 1;
			object obj46 = s.bl_count + num11;
			object obj47 = obj46 + 16;
			object obj48 = obj47 - 1;
			obj47 = obj48;
			object obj49 = num9 + 1;
			object obj50 = obj49 << 1;
			object obj51 = (object)s.bl_count + obj50;
			object obj52 = num9 + 1;
			object obj53 = obj52 << 1;
			object obj54 = (object)s.bl_count + obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v54+10]");
			object obj55 = (nint)0 + (nint)2;
			int num12 = staticTree.maxLength << 1;
			object obj56 = s.bl_count + num12;
			object obj57 = obj56 + 16;
			object obj58 = obj57 - 1;
			obj57 = obj58;
			object obj59 = obj20 - 2;
			flag7 = (nint)obj59 > 0;
			num13 = staticTree.maxLength;
		}
		while (flag7);
		while (num13 != 0)
		{
			int num14 = num13 << 1;
			object obj60 = s.bl_count + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v71+10]");
			object obj61 = 0;
			while (obj61 != null)
			{
				object obj62 = obj8 - 1;
				object obj63 = obj62 << 2;
				object obj64 = (object)s.heap + obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v83+10]");
				if ((nint)0 <= (nint)max_code)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v83+10]");
					object obj65 = (nint)0 << 1;
					object obj66 = obj65 + 1;
					object obj67 = obj66 << 1;
					object obj68 = (object)dyn_tree + obj67;
					int num15 = num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v55+10]");
					bool flag8 = (nint)num15 != 0;
					bool flag9 = !flag8;
					obj9 = 1;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v83+10]");
						object obj69 = (nint)0 << 2;
						object obj70 = (object)dyn_tree + obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v83+10]");
						object obj71 = (nint)0 << 1;
						object obj72 = obj71 + 1;
						object obj26 = obj72 << 1;
						object obj73 = (object)dyn_tree + obj26;
						int num16 = num13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S4_v8+10]");
						obj9 = (nint)num16 - (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S2_v35+10]");
						object obj74 = 0 * obj9;
						int opt_len2 = s.opt_len + obj74;
						s.opt_len = opt_len2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v83+10]");
						object obj75 = (nint)0 << 1;
						object obj76 = obj75 + 1;
						object obj77 = obj76 << 1;
						object obj78 = (object)dyn_tree + obj77;
					}
					object obj79 = obj61 - 1;
					obj8 = obj62;
					obj61 = obj79;
				}
			}
			int num17 = num13 - 1;
			num13 = num17;
		}
	}

	internal void build_tree(DeflateManager s)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got Unknown
		//IL_0703: Expected Obj, but got I
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_0768: Expected Obj, but got I
		//IL_077e: Expected Obj, but got I
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0452: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		StaticTree staticTree = this.staticTree;
		s.heap_len = 0;
		s.heap_max = HEAP_SIZE;
		int num = 0;
		int num2 = -1;
		while (num < staticTree.elems)
		{
			int num3 = num << 2;
			object obj = dyn_tree + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v111+10]");
			if ((nint)0 != 0)
			{
				int num4 = ++s.heap_len << 2;
				object obj2 = s.heap + num4;
				object obj3 = num + s.depth;
				_ = 0;
				num2 = num;
			}
			else
			{
				int num5 = num << 1;
				object obj4 = num5 + 1;
				object obj5 = obj4 << 1;
				object obj6 = (object)dyn_tree + obj5;
				_ = 0;
			}
			int num6 = num + 1;
			num = num6;
		}
		while (s.heap_len < 2)
		{
			int num7 = ++s.heap_len;
			bool flag = num2 <= 1;
			bool flag2 = !flag;
			int num8 = 0;
			if (!flag2)
			{
				int num9 = num2 + 1;
				num8 = num9;
				num2 = num9;
			}
			int num10 = num7 << 2;
			object obj7 = s.heap + num10;
			int num11 = num8 << 2;
			object obj8 = dyn_tree + num11;
			_ = 1;
			object obj9 = num8 + s.depth;
			_ = 0;
			int opt_len = s.opt_len - 1;
			s.opt_len = opt_len;
			if (staticTree.treeCodes != null)
			{
				int num12 = num8 << 1;
				object obj10 = num12 + 1;
				object obj11 = obj10 << 1;
				object obj12 = (object)staticTree.treeCodes + obj11;
				int static_len = s.static_len;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S2_v42+10]");
				int static_len2 = (int)((nint)static_len - (nint)0);
				s.static_len = static_len2;
			}
		}
		max_code = num2;
		int num13 = s.heap_len >> 1;
		int num14 = num13;
		int num15;
		while (true)
		{
			bool flag3 = num14 > 0;
			bool flag4 = !flag3;
			num15 = staticTree.elems;
			if (flag4)
			{
				break;
			}
			s.pqdownheap(dyn_tree, num14);
			int num16 = num14 - 1;
			num14 = num16;
		}
		bool flag5;
		do
		{
			int[] heap = s.heap;
			int[] heap2 = s.heap;
			int heap_len = s.heap_len - 1;
			s.heap_len = heap_len;
			int num17 = s.heap_len << 2;
			object obj13 = s.heap + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v20+10]");
			heap2[1] = 0;
			s.pqdownheap(dyn_tree, 1);
			int[] heap3 = s.heap;
			int num18 = --s.heap_max << 2;
			object obj14 = s.heap + num18;
			_ = heap[1];
			int num19 = --s.heap_max << 2;
			object obj15 = s.heap + num19;
			_ = heap3[1];
			int num20 = num15 << 2;
			object obj16 = dyn_tree + num20;
			int num21 = heap[1] << 2;
			object obj17 = dyn_tree + num21;
			int num22 = heap3[1] << 2;
			object obj18 = dyn_tree + num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v38+10]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S2_v17+10]");
			object obj19 = num23 + 0;
			object obj20 = heap[1] + s.depth;
			object obj21 = heap3[1] + s.depth;
			object obj22 = s.depth + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v59+10]");
			object obj23 = (nint)0 & (nint)0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v56+10]");
			object obj24 = (nint)0 & (nint)0xFF;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
			{
				obj23 = obj24;
			}
			object obj25 = obj23 + 1;
			int num24 = heap3[1] << 1;
			object obj26 = num24 + 1;
			object obj27 = obj26 << 1;
			object obj28 = (object)dyn_tree + obj27;
			int num25 = num15 << 16;
			int num26 = num25 >> 16;
			int num27 = heap[1] << 1;
			object obj29 = num27 + 1;
			object obj30 = obj29 << 1;
			object obj31 = (object)dyn_tree + obj30;
			int[] heap4 = s.heap;
			heap4[1] = num15;
			s.pqdownheap(dyn_tree, 1);
			int num28 = num15 + 1;
			flag5 = s.heap_len > 1;
			num15 = num28;
		}
		while (flag5);
		int num29 = --s.heap_max << 2;
		object obj32 = s.heap + num29;
		int[] heap5 = s.heap;
		_ = heap5[1];
		gen_bitlen(s);
		gen_codes(dyn_tree, num2, s.bl_count);
	}

	internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
	{
		//IL_01ae: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_018b: Expected I4, but got Obj
		object obj = InternalConstants.MAX_BITS + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 1;
		object obj2;
		object obj4 = default;
		object obj9 = default;
		while (true)
		{
			bool flag = InternalConstants.MAX_BITS >= num;
			bool flag2 = !flag;
			obj2 = 0;
			if (flag2)
			{
				break;
			}
			int num2 = num << 1;
			object obj3 = obj4 + num2;
			object obj5 = num - 1;
			object obj6 = obj5 << 1;
			object obj7 = (object)bl_count + obj6;
			object obj8 = obj9 << 16;
			object obj10 = obj8 >> 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v30+10]");
			object obj11 = 0 + obj10;
			object obj12 = obj11 << 17;
			object obj13 = obj12 >> 16;
			int num3 = num + 1;
			num = num3;
		}
		while (max_code >= (nint)obj2)
		{
			object obj14 = obj2 << 1;
			object obj15 = obj14 + 1;
			object obj16 = obj15 << 1;
			object obj17 = (object)tree + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v24+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v24+10]");
				int num4 = (int)((nint)0 << 1);
				object obj18 = obj4 + num4;
				object obj19 = obj18 + 16;
				object obj20 = obj19 + 1;
				obj19 = obj20;
				object obj21 = obj2 << 2;
				object obj22 = (object)tree + obj21;
				object obj23 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v24+10]");
				int num5 = bi_reverse((int)obj23, 0);
			}
			object obj24 = obj2 + 1;
			obj2 = obj24;
		}
	}

	internal static int bi_reverse(int code, int len)
	{
		//IL_0005: Expected I, but got Obj
		nint num = unchecked((nint)null);
		IntPtr intPtr = default;
		num = intPtr;
		int num3 = default;
		int num5;
		int num6;
		int num7 = default;
		do
		{
			int num2 = num3 & 1;
			int num4 = (int)(num2 | num);
			num5 = num4 << 1;
			num6 = num7 - 1;
		}
		while (num6 > 0);
		return num5 >> 1;
	}

	static Tree()
	{
		int num = InternalConstants.L_CODES << 1;
		int hEAP_SIZE = num + 1;
		HEAP_SIZE = hEAP_SIZE;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.F8D7861760C88CC514F66095AF0AED47ECBA063ADB65F47125ED07BCC2CF9842));
		ExtraLengthBits = (int[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E.B23D510F520CB4BA8AFA847F8A40E757C40CB6A55B237EFA1AC6D3984911B114));
		ExtraDistanceBits = (int[])array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array3 = default;
		RuntimeHelpers.InitializeArray(array3, __ldtoken(_003CPrivateImplementationDetails_003E._8FC498A953A183E1FE81A183AE59047435BB9B33D657C625FAB03D38BE19F92E));
		extra_blbits = (int[])array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array4 = default;
		RuntimeHelpers.InitializeArray(array4, __ldtoken(_003CPrivateImplementationDetails_003E._111B15B20E0428A22EEAA1E54B0D3B008A7A3E79C8F7F4E783710F569E9CEF15));
		bl_order = (sbyte[])array4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array5 = default;
		RuntimeHelpers.InitializeArray(array5, __ldtoken(_003CPrivateImplementationDetails_003E._3E4FB5FE52BF269D6EE955711016291D6D327A4AAC39B2464C53C6BD0D73242A));
		_dist_code = (sbyte[])array5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array6 = default;
		RuntimeHelpers.InitializeArray(array6, __ldtoken(_003CPrivateImplementationDetails_003E.B9D4AF390AFC6A0F149B843D651CFEBC1C4EC496A0263B72207836F9C525E1C4));
		LengthCode = (sbyte[])array6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array7 = default;
		RuntimeHelpers.InitializeArray(array7, __ldtoken(_003CPrivateImplementationDetails_003E._7DDF88204E7E265240211841F0AB290A5E77EE4F9223EB2E39F9B89C30C41B9D));
		LengthBase = (int[])array7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array8 = default;
		RuntimeHelpers.InitializeArray(array8, __ldtoken(_003CPrivateImplementationDetails_003E._5961BF1FCF83803CE7775E15E9DB8D21AF741539B85CCFDD643F9E22CC7820D6));
		DistanceBase = (int[])array8;
	}
}
