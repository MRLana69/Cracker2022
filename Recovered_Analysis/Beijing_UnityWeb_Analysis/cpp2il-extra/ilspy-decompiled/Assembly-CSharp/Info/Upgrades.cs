using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

namespace Info;

public static class Upgrades
{
	private const int SPAWNRATE_FOR_CHARACTER_LETTERS = 25;

	private const int SPAWNRATE_TO_FORCE_A_SPAWNING = 1500000000;

	private const int SPAWNRATE_FOR_LETTERS = 1500000000;

	private const int SPAWNRATE_FOR_MYSTERYPOWERUP = 23;

	public const int SCORE_BOOSTER_MULTIPLIER_TIER1 = 5;

	public const int SCORE_BOOSTER_MULTIPLIER_TIER2 = 6;

	public const int SCORE_BOOSTER_MULTIPLIER_TIER3 = 7;

	public const int CHARACTER_DAY_MULTIPLIER = 5;

	public const int PLUS_MULTIPLIER_MYSTERY_POWERUP = 10;

	private const float HEADSTART_TIER_ONE_SPEED = 400f;

	private const float HEADSTART_TIER_ONE_LAND_SPEED = 0.01f;

	private const float HEADSTART_TIER_ONE_DURATION = 6f;

	public static readonly HeadstartTier[] HEADSTART_TIERS;

	public static readonly Dictionary<UpgradeType, Upgrade> upgrades;

	public static float GetUpgradeDuration(UpgradeType type)
	{
		//IL_000d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L0 (Info.UpgradeType)+10]");
		return 0f;
	}

	public static int CountUpgradeTiers()
	{
		bool cloudSaveOptedOut = PreferencesSave.cloudSaveOptedOut;
		bool flag = (cloudSaveOptedOut ? 1 : 0) == -1;
		bool flag2 = !flag;
		bool result = cloudSaveOptedOut;
		if (!flag2)
		{
			string dataPath = Application.dataPath;
			bool flag3 = (((nint)dataPath == 11) ? true : true);
			bool flag4 = (nint)dataPath == 8;
			bool flag5 = !flag4;
			result = flag3;
			if (!flag5)
			{
				result = false;
			}
		}
		return result ? 1 : 0;
	}

	static Upgrades()
	{
		//IL_03c9: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = "TROPHY_GEMSTONE";
		_ = 1;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj14 = default;
		object obj13 = obj14 + 8;
		obj13 = "TROPHY_GOLD_BAR";
		_ = 1;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v12+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v13+48]");
		object obj17 = 0;
		object obj18 = obj17 & 0x7FF;
		object obj19 = obj18 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj21 = default;
		object obj20 = obj21 + 8;
		obj20 = "TROPHY_CLASSY_CLOCK";
		_ = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v17+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v18+48]");
		object obj24 = 0;
		object obj25 = obj24 & 0x7FF;
		object obj26 = obj25 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj28 = default;
		object obj27 = obj28 + 8;
		obj27 = "TROPHY_DOLLAR_CHAIN";
		_ = 1;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v22+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v23+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v136 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj35 = default;
		object obj34 = obj35 + 8;
		obj34 = "TROPHY_PAPERWEIGHT";
		_ = 1;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S4_v27+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S4_v28+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S5_v22 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj42 = default;
		object obj41 = obj42 + 8;
		obj41 = "TROPHY_HEADPHONES";
		_ = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S4_v32+60]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v33+48]");
		object obj45 = 0;
		object obj46 = obj45 & 0x7FF;
		object obj47 = obj46 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v190 @ S5_v26 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj49 = default;
		object obj48 = obj49 + 8;
		obj48 = "TROPHY_PLATINUM_RECORD";
		_ = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S4_v37+60]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S4_v38+48]");
		object obj52 = 0;
		object obj53 = obj52 & 0x7FF;
		object obj54 = obj53 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v217 @ S5_v30 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj56 = default;
		object obj55 = obj56 + 8;
		obj55 = "TROPHY_CASSETTE";
		_ = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S4_v42+60]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S4_v43+48]");
		object obj59 = 0;
		object obj60 = obj59 & 0x7FF;
		object obj61 = obj60 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v244 @ S5_v34 (should have been resolved before IL gen)");
		Dictionary<Trophies.Trophy, TrophyData> tROPHY_DATA = default;
		Trophies.TROPHY_DATA = tROPHY_DATA;
	}
}
