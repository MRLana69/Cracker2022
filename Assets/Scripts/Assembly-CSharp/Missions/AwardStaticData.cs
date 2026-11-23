using System.Collections.Generic;

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

	public AwardId id
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool isHidden
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = false;

	public StringID title
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public StringID description
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool hasDescription
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = true;

	public Dictionary<AwardTierType, AwardTier> missionTiers
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool useFacebook
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = false;

	public bool useStatOffset
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool migrateToUseStatOffset
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = false;

	public AwardType awardType
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool hasAnotherDescriptionForOneItemGoal
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = false;

	public StringID descriptionForOneItemGoal
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}
}
