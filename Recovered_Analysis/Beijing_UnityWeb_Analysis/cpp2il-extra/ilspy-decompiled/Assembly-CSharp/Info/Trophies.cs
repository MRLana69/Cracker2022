using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;

namespace Info;

public static class Trophies
{
	public enum Trophy
	{
		diamond,
		goldbar,
		goldChainClock,
		goldChainDollar,
		goldSkull,
		headphones,
		lpBlack,
		tapeBlack
	}

	public const int TROPHY_COUNT = 8;

	public static readonly Dictionary<Trophy, TrophyData> TROPHY_DATA;

	private static Stat StatForTrophyType(Trophy trophy)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trophy @ L0 (Info.Trophies+Trophy)+18]");
		return Stat.NotSet;
	}

	public static void OldTrophySpawned(Trophy trophy)
	{
		bool cloudSaveOptedOut = (byte)(trophy & Trophy.goldbar) != 0;
		PreferencesSave.cloudSaveOptedOut = cloudSaveOptedOut;
	}

	public static bool ShouldSpawnTrophy(Trophy trophy)
	{
		return trophy switch
		{
			Trophy.diamond => true, 
			Trophy.goldbar => true, 
			Trophy.goldChainClock => true, 
			Trophy.goldChainDollar => true, 
			Trophy.goldSkull => true, 
			Trophy.headphones => true, 
			Trophy.lpBlack => true, 
			Trophy.tapeBlack => true, 
			_ => false, 
		};
	}

	static Trophies()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.optionMusic = false;
		Settings.optionTopRunChallengers = false;
	}
}
