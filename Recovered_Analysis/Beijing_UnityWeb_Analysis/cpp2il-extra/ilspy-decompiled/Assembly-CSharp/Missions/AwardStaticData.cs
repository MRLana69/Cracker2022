using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Missions;

public class AwardStaticData
{
	public enum AwardType
	{
		NotSet,
		Stat,
		DailyChallengeInRow,
		OwnCharacters,
		OwnBoards,
		OwnCharacterOutfits,
		ScorePointsSingleRunNoCoins,
		CompleteMissionsSingleRun,
		HaveSupersneakersXTime,
		CollectCoinsSingleRun,
		ScorePointsSingleRunNoJumpOrRoll,
		ScorePointsSingleLane
	}

	private AwardId id__BackingField;

	private bool isHidden__BackingField;

	private string title__BackingField;

	private string description__BackingField;

	private bool hasDescription__BackingField;

	private Dictionary<AwardTierType, AwardTier> missionTiers__BackingField;

	private bool useFacebook__BackingField;

	private bool useStatOffset__BackingField;

	private bool migrateToUseStatOffset__BackingField;

	private AwardType awardType__BackingField;

	private bool hasAnotherDescriptionForOneItemGoal__BackingField;

	public AwardId id
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_00c8: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.AwardsData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AwardsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Missions.AwardsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3F2");
			object obj3 = default;
			object obj2 = obj3 + 16;
			object obj4 = (object)this << 2;
			object obj5 = obj2 + obj4;
			return (AwardId)obj5;
		}
		set
		{
			//IL_002a: Expected Obj, but got I4
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = (Delegate)hasAnotherDescriptionForOneItemGoal__BackingField;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public bool isHidden
	{
		get
		{
			return (byte)id__BackingField != 0;
		}
		set
		{
			id__BackingField = (value ? AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB : AwardId.COLLECT_OLD_TROPHY_ITEMS_MB);
		}
	}

	public string title
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isHidden__BackingField;
			return (string)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isHidden__BackingField = flag;
		}
	}

	public string description
	{
		get
		{
			return title__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public bool hasDescription
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)description__BackingField != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public Dictionary<AwardTierType, AwardTier> missionTiers
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = hasDescription__BackingField;
			return (Dictionary<AwardTierType, AwardTier>)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			hasDescription__BackingField = flag;
		}
	}

	public bool useFacebook
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)missionTiers__BackingField != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 28;
			obj = value;
		}
	}

	public bool useStatOffset
	{
		get
		{
			return useFacebook__BackingField;
		}
		set
		{
			useFacebook__BackingField = value;
		}
	}

	public bool migrateToUseStatOffset
	{
		get
		{
			return useStatOffset__BackingField;
		}
		set
		{
			useStatOffset__BackingField = value;
		}
	}

	public AwardType awardType
	{
		get
		{
			return migrateToUseStatOffset__BackingField ? AwardType.Stat : AwardType.NotSet;
		}
		set
		{
			bool flag = (byte)(value & AwardType.Stat) != 0;
			migrateToUseStatOffset__BackingField = flag;
		}
	}

	public bool hasAnotherDescriptionForOneItemGoal
	{
		get
		{
			return (byte)awardType__BackingField != 0;
		}
		set
		{
			awardType__BackingField = (value ? AwardType.Stat : AwardType.NotSet);
		}
	}

	public string descriptionForOneItemGoal
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = hasAnotherDescriptionForOneItemGoal__BackingField;
			return (string)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			hasAnotherDescriptionForOneItemGoal__BackingField = flag;
		}
	}

	public AwardStaticData()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AwardsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.AwardsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Missions.AwardsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AwardsData.awards__BackingField = (AwardStaticData[])(object)this;
	}
}
