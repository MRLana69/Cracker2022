using Cpp2ILInjected;

namespace Ionic.Zlib;

public sealed class Adler
{
	private static readonly uint BASE = 65521u;

	private static readonly int NMAX = 5552;

	public static uint Adler32(uint adler, byte[] buf, int index, int len)
	{
		//IL_05b0: Expected Obj, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected I4, but got Unknown
		//IL_05d9: Expected Obj, but got I4
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected I4, but got Unknown
		//IL_0057: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected I4, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected I4, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected I4, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		if (buf == null)
		{
			return 1u;
		}
		int num = (int)adler >> 16;
		int num2 = (int)(adler & 0xFFFF);
		int num3 = num2;
		int num4 = num;
		int num5 = default;
		int num7 = default;
		while (num5 > 0)
		{
			int num6 = num5;
			num5 -= num5;
			while (num6 > 15)
			{
				object obj = num7 + 1;
				object obj2 = obj + 1;
				object obj3 = obj2 + 1;
				object obj4 = obj3 + 1;
				object obj5 = obj4 + 1;
				object obj6 = obj5 + 1;
				object obj7 = obj6 + 1;
				object obj8 = obj7 + 1;
				object obj9 = obj8 + 1;
				object obj10 = obj9 + 1;
				object obj11 = obj10 + 1;
				object obj12 = obj11 + 1;
				object obj13 = obj12 + 1;
				object obj14 = obj13 + 1;
				object obj15 = obj14 + 1;
				object obj16 = buf + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v62+10]");
				object obj17 = (nint)0 + (nint)num3;
				object obj18 = obj17 + num4;
				object obj19 = (object)buf + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v49+10]");
				object obj20 = 0 + obj17;
				object obj21 = obj18 + obj20;
				object obj22 = (object)buf + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v53+10]");
				object obj23 = 0 + obj20;
				object obj24 = obj21 + obj23;
				object obj25 = (object)buf + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v57+10]");
				object obj26 = 0 + obj23;
				object obj27 = obj24 + obj26;
				object obj28 = (object)buf + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v61+10]");
				object obj29 = 0 + obj26;
				object obj30 = obj27 + obj29;
				object obj31 = (object)buf + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v65+10]");
				object obj32 = 0 + obj29;
				object obj33 = obj30 + obj32;
				object obj34 = (object)buf + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v69+10]");
				object obj35 = 0 + obj32;
				object obj36 = obj33 + obj35;
				object obj37 = (object)buf + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v73+10]");
				object obj38 = 0 + obj35;
				object obj39 = obj36 + obj38;
				object obj40 = (object)buf + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v77+10]");
				object obj41 = 0 + obj38;
				object obj42 = obj39 + obj41;
				object obj43 = (object)buf + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v81+10]");
				object obj44 = 0 + obj41;
				object obj45 = obj42 + obj44;
				object obj46 = (object)buf + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v85+10]");
				object obj47 = 0 + obj44;
				object obj48 = obj45 + obj47;
				object obj49 = (object)buf + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v89+10]");
				object obj50 = 0 + obj47;
				object obj51 = obj48 + obj50;
				object obj52 = (object)buf + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v93+10]");
				object obj53 = 0 + obj50;
				object obj54 = obj51 + obj53;
				object obj55 = (object)buf + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S1_v97+10]");
				object obj56 = 0 + obj53;
				object obj57 = obj54 + obj56;
				object obj58 = (object)buf + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v101+10]");
				object obj59 = 0 + obj56;
				object obj60 = obj57 + obj59;
				int num8 = obj15 + 1;
				object obj61 = (object)buf + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v106+10]");
				int num9 = 0 + obj59;
				int num10 = obj60 + num9;
				int num11 = num6 - 16;
				num7 = num8;
				num6 = num11;
				num3 = num9;
				num4 = num10;
			}
			bool flag = num6 == 0;
			int num12 = num7;
			int num13 = num3;
			int num14 = num4;
			if (!flag)
			{
				int num18;
				do
				{
					object obj62 = buf + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v37+10]");
					int num15 = (int)((nint)0 + (nint)num3);
					int num16 = num15 + num4;
					int num17 = num7 + 1;
					num18 = num6 - 1;
					num7 = num17;
					num6 = num18;
					num3 = num15;
					num4 = num16;
					num12 = num17;
					num13 = num15;
					num14 = num16;
				}
				while (num18 != 0);
			}
			int num19 = num13 / (int)BASE;
			object obj63 = num19 * (int)BASE;
			int num20 = num13 - obj63;
			int num21 = num14 / (int)BASE;
			object obj64 = num21 * (int)BASE;
			int num22 = num14 - obj64;
			num7 = num12;
			num3 = num20;
			num4 = num22;
		}
		int num23 = num4 << 16;
		return (uint)(num23 | num3);
	}
}
