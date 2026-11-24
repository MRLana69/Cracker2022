using System;
using System.IO;
using System.Runtime.InteropServices;
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
		//IL_038f: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+8]");
		if ((nint)0 != 13)
		{
			_ = 13;
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10+10]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+1C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+C]");
			object obj5 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
				object obj6 = 0;
				bool flag = (nint)obj4 > 3;
				bool flag2 = obj3 == null;
				object obj7 = flag | flag2;
				if (obj7 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21+8]");
				object obj8 = (nint)0 + (nint)16;
				object obj9 = obj8 + obj5;
				nint num = (nint)typeof(InflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v24 (Il2CppClass<Ionic.Zlib.InflateManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num2 = (nint)typeof(InflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v42 (Il2CppClass<Ionic.Zlib.InflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj11 = obj9 & 0xFF;
				object obj12 = InflateManager.mark + 16;
				object obj13 = obj12 + obj4;
				object obj14;
				if (obj11 == obj13)
				{
					obj14 = obj4 + 1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
					object obj16 = (nint)0 + (nint)16;
					object obj17 = obj16 + obj5;
					obj14 = ((obj17 == null) ? ((object)(4 - obj4)) : ((object)0));
				}
				object obj18 = obj5 + 1;
				object obj19 = obj3 - 1;
				obj3 = obj19;
				obj4 = obj14;
				obj5 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
			object obj20 = 0;
			object obj21 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v4+C]");
			object obj22 = obj21 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21+18]");
			object obj23 = obj22 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
			object obj25 = 0;
			if ((nint)obj4 == 4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
				object obj27 = 0;
				int num3 = ((InflateManager)dist).End();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v36+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dist @ L0 (System.Int32)+C]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v39+30]");
				_ = 0;
				_ = 7;
				return 0;
			}
			return -3;
		}
		return -5;
	}

	internal void gen_bitlen(DeflateManager s)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0175: Expected I4, but got Obj
		//IL_0175: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		if (dyn_tree != null)
		{
			int num = max_code;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v21 (System.Int32)+C]");
			if (0 < (nint)s)
			{
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj2 = default;
				obj = obj2;
			}
			Array.ClearInternal((Array)max_code, 0, (int)s);
			Array.ClearInternal((Array)(object)staticTree, 0, 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.Tree)+14]");
			object obj3 = (nint)0 + (nint)16;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.Tree)+14]");
			object obj4 = (nint)0 + (nint)20;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.Tree)+14]");
			object obj5 = (nint)0 + (nint)24;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.Tree)+18]");
			Array.ClearInternal((Array)0, 0, 15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.Tree)+1C]");
			Array.ClearInternal((Array)0, 0, 16);
		}
		else
		{
			object obj6 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj7 = default;
			obj6 = obj7;
			object obj8 = this + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj9 = default;
			obj8 = obj9;
			object obj10 = this + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj11 = default;
			obj10 = obj11;
			object obj12 = this + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj13 = default;
			obj12 = obj13;
			object obj14 = this + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj15 = default;
			obj14 = obj15;
			object obj16 = this + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj17 = default;
			obj16 = obj17;
		}
	}

	internal void build_tree(DeflateManager s)
	{
		//IL_07bc: Expected I, but got Obj
		//IL_07d2: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0914: Expected I, but got Obj
		//IL_092a: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected I4, but got Unknown
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected Obj, but got Unknown
		//IL_0850: Expected Obj, but got I4
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected I4, but got Unknown
		//IL_0326: Expected Obj, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected I4, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected I4, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_0757: Expected Obj, but got I4
		StaticTree staticTree = this.staticTree;
		StaticTree staticTree2 = this.staticTree;
		StaticTree staticTree3 = this.staticTree;
		StaticTree staticTree4 = this.staticTree;
		int num2 = default;
		int num = num2;
		while (true)
		{
			nint num3 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v145 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num > InternalConstants.MAX_BITS)
			{
				break;
			}
			object obj2 = s.bl_count + 16;
			int num5 = num << 1;
			object obj3 = obj2 + num5;
			obj3 = 0;
			int num6 = num + 1;
			num = num6;
		}
		object obj4 = s.heap + 16;
		int num7 = s.heap_max << 2;
		object obj5 = obj4 + num7;
		object obj6 = obj5 << 1;
		object obj7 = obj6 << 1;
		object obj8 = (object)dyn_tree + obj7;
		object obj9 = obj8 + 18;
		obj9 = 0;
		bool flag = staticTree.treeCodes == null;
		object obj10 = s.heap_max + 1;
		object obj11 = obj10;
		object obj12 = 0;
		while (true)
		{
			nint num8 = (nint)typeof(Tree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v38 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num9 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v133 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj11 >= HEAP_SIZE)
			{
				break;
			}
			object obj14 = s.heap + 16;
			object obj15 = obj11 << 2;
			object obj16 = obj14 + obj15;
			object obj17 = obj16 << 1;
			object obj18 = obj17 << 1;
			object obj19 = (object)dyn_tree + obj18;
			object obj20 = obj19 + 18;
			object obj21 = obj20 << 1;
			object obj22 = obj21 << 1;
			object obj23 = (object)dyn_tree + obj22;
			object obj24 = obj23 + 18;
			int num10 = obj24 + 1;
			bool flag2 = num10 > staticTree4.maxLength;
			bool flag3 = !flag2;
			int num11 = num10;
			if (!flag3)
			{
				object obj25 = obj12 + 1;
				num11 = staticTree4.maxLength;
				obj12 = obj25;
			}
			object obj26 = obj16 << 1;
			object obj27 = obj26 << 1;
			object obj28 = (object)dyn_tree + obj27;
			object obj29 = obj28 + 18;
			obj29 = num11;
			if ((nint)obj16 <= max_code)
			{
				object obj30 = s.bl_count + 16;
				int num12 = num11 << 1;
				object obj31 = obj30 + num12;
				object obj32 = obj31 + 1;
				obj31 = obj32;
				object obj33;
				if ((nint)obj16 < staticTree3.extraBase)
				{
					obj33 = 0;
				}
				else
				{
					object obj34 = staticTree2.extraBits + 16;
					object obj35 = obj16 - staticTree3.extraBase;
					object obj36 = obj35 << 2;
					object obj37 = obj34 + obj36;
					obj33 = obj37;
				}
				object obj38 = obj33 + num11;
				object obj39 = dyn_tree + 16;
				object obj40 = obj16 << 2;
				object obj41 = obj39 + obj40;
				object obj42 = obj38 * obj41;
				int opt_len = obj42 + s.opt_len;
				s.opt_len = opt_len;
				if (!flag)
				{
					object obj43 = obj16 << 1;
					object obj44 = obj43 << 1;
					object obj45 = (object)staticTree.treeCodes + obj44;
					object obj46 = obj45 + 18;
					object obj47 = obj33 + obj46;
					object obj48 = obj47 * obj41;
					int static_len = obj48 + s.static_len;
					s.static_len = static_len;
				}
			}
			object obj49 = obj11 + 1;
			obj11 = obj49;
		}
		if (obj12 == null)
		{
			return;
		}
		object obj63;
		do
		{
			int maxLength = staticTree4.maxLength;
			maxLength = num2;
			int num13;
			object obj51;
			do
			{
				object obj50 = s.bl_count + 16;
				num13 = maxLength - 1;
				int num14 = num13 << 1;
				obj51 = obj50 + num14;
			}
			while (obj51 == null);
			object obj52 = s.bl_count + 16;
			int num15 = num13 << 1;
			object obj53 = obj52 + num15;
			object obj54 = obj53 - 1;
			obj53 = obj54;
			int num16 = num13 << 1;
			object obj55 = s.bl_count + num16;
			object obj56 = obj55 + 18;
			int num17 = num13 << 1;
			object obj57 = s.bl_count + num17;
			object obj58 = obj57 + 18;
			object obj59 = obj58 + 2;
			obj56 = obj59;
			object obj60 = s.bl_count + 16;
			int num18 = staticTree4.maxLength << 1;
			object obj61 = obj60 + num18;
			object obj62 = obj61 - 1;
			obj61 = obj62;
			obj63 = obj12 - 2;
		}
		while ((nint)obj63 >= 1);
		int num19 = staticTree4.maxLength;
		object obj64 = obj11;
		while (num19 != 0)
		{
			int num20 = num19 & 0xFFFF;
			object obj65 = s.bl_count + 16;
			int num21 = num19 << 1;
			object obj66 = obj65 + num21;
			object obj67 = obj66;
			while (true)
			{
				bool flag4 = obj67 == null;
				object obj69;
				object obj71;
				while (!flag4)
				{
					object obj68 = s.heap + 16;
					obj69 = obj64 - 1;
					object obj70 = obj69 << 2;
					obj71 = obj68 + obj70;
					if ((nint)obj71 > max_code)
					{
						continue;
					}
					goto IL_0615;
				}
				break;
				IL_0615:
				object obj72 = obj71 << 1;
				object obj73 = obj72 << 1;
				object obj74 = (object)dyn_tree + obj73;
				object obj75 = obj74 + 18;
				if (num19 != (nint)obj75)
				{
					object obj76 = dyn_tree + 16;
					object obj77 = obj71 << 2;
					object obj78 = obj76 + obj77;
					object obj79 = obj71 << 1;
					object obj80 = obj79 << 1;
					object obj81 = (object)dyn_tree + obj80;
					object obj82 = obj81 + 18;
					object obj83 = num19 - obj82;
					object obj84 = obj78 * obj83;
					int opt_len2 = obj84 + s.opt_len;
					s.opt_len = opt_len2;
					object obj85 = obj71 << 1;
					object obj86 = obj85 << 1;
					object obj87 = (object)dyn_tree + obj86;
					object obj88 = obj87 + 18;
					obj88 = num20;
				}
				object obj89 = obj67 - 1;
				obj67 = obj89;
				obj64 = obj69;
			}
			int num22 = num19 - 1;
			num19 = num22;
		}
	}

	internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I4
		((ZlibStream)(object)tree)._002Ector((Stream)max_code, (CompressionMode)bl_count, CompressionLevel.Default, false);
	}

	internal static int bi_reverse(int code, int len)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [code @ L0 (System.Int32)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
		return ((nint)0 == 1) ? 1 : 0;
	}

	unsafe static Tree()
	{
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected I4, but got Unknown
		//IL_022f: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I
		//IL_0026: Expected I4, but got Obj
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I
		//IL_008f: Expected I4, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I
		//IL_00f8: Expected I4, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I
		//IL_0161: Expected I4, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01bc: Expected I4, but got Obj
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 20;
		obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 24);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		InfTree.fixed_tl = (int[])(object)unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = obj2 + 16;
		obj3 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		nint num = (nint)typeof(InfTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27 (Il2CppClass<Ionic.Zlib.InfTree>)+5C]");
		object obj4 = (nint)0 + (nint)4;
		obj4 = unmanagedFunctionPointerAttribute2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = obj2 + 12;
		obj5 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj5;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute3 = default;
		unmanagedFunctionPointerAttribute3._002Ector(callingConvention);
		nint num2 = (nint)typeof(InfTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v38 (Il2CppClass<Ionic.Zlib.InfTree>)+5C]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = unmanagedFunctionPointerAttribute3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = obj2 + 8;
		obj7 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj7;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute4 = default;
		unmanagedFunctionPointerAttribute4._002Ector(callingConvention);
		nint num3 = (nint)typeof(InfTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v49 (Il2CppClass<Ionic.Zlib.InfTree>)+5C]");
		object obj8 = (nint)0 + (nint)12;
		obj8 = unmanagedFunctionPointerAttribute4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj9 = obj2 + 4;
		obj9 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj9;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute5 = default;
		unmanagedFunctionPointerAttribute5._002Ector(callingConvention);
		nint num4 = (nint)typeof(InfTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v60 (Il2CppClass<Ionic.Zlib.InfTree>)+5C]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = unmanagedFunctionPointerAttribute5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj2 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute6 = default;
		unmanagedFunctionPointerAttribute6._002Ector(callingConvention);
		nint num5 = (nint)typeof(InfTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v70 (Il2CppClass<Ionic.Zlib.InfTree>)+5C]");
		object obj11 = (nint)0 + (nint)20;
		obj11 = unmanagedFunctionPointerAttribute6;
	}
}
