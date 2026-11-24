namespace Missions;

public class AwardStaticData
{
	public enum AwardType
	{
		NotSet = 0,
		Stat = 1,
		DailyChallengeInRow = 2,
		OwnCharacters = 3,
		OwnBoards = 4,
		OwnCharacterOutfits = 5,
		ScorePointsSingleRunNoCoins = 6,
		CompleteMissionsSingleRun = 7,
		HaveSupersneakersXTime = 8,
		CollectCoinsSingleRun = 9,
		ScorePointsSingleRunNoJumpOrRoll = 10,
		ScorePointsSingleLane = 11,
	}

	private AwardId <id>k__BackingField; //Field offset: 0x8
	private bool <isHidden>k__BackingField; //Field offset: 0xC
	private string <title>k__BackingField; //Field offset: 0x10
	private string <description>k__BackingField; //Field offset: 0x14
	private bool <hasDescription>k__BackingField; //Field offset: 0x18
	private Dictionary<AwardTierType, AwardTier> <missionTiers>k__BackingField; //Field offset: 0x1C
	private bool <useFacebook>k__BackingField; //Field offset: 0x20
	private bool <useStatOffset>k__BackingField; //Field offset: 0x21
	private bool <migrateToUseStatOffset>k__BackingField; //Field offset: 0x22
	private AwardType <awardType>k__BackingField; //Field offset: 0x24
	private bool <hasAnotherDescriptionForOneItemGoal>k__BackingField; //Field offset: 0x28
	private string <descriptionForOneItemGoal>k__BackingField; //Field offset: 0x2C

	public AwardType awardType
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string description
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string descriptionForOneItemGoal
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool hasAnotherDescriptionForOneItemGoal
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool hasDescription
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public AwardId id
	{
		 get { } //Length: 89
		 set { } //Length: 111
	}

	public bool isHidden
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool migrateToUseStatOffset
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Dictionary<AwardTierType, AwardTier> missionTiers
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string title
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool useFacebook
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool useStatOffset
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public AwardStaticData() { }

	public AwardType get_awardType() { }

	public string get_description() { }

	public string get_descriptionForOneItemGoal() { }

	public bool get_hasAnotherDescriptionForOneItemGoal() { }

	public bool get_hasDescription() { }

	public AwardId get_id() { }

	public bool get_isHidden() { }

	public bool get_migrateToUseStatOffset() { }

	public Dictionary<AwardTierType, AwardTier> get_missionTiers() { }

	public string get_title() { }

	public bool get_useFacebook() { }

	public bool get_useStatOffset() { }

	public void set_awardType(AwardType value) { }

	public void set_description(string value) { }

	public void set_descriptionForOneItemGoal(string value) { }

	public void set_hasAnotherDescriptionForOneItemGoal(bool value) { }

	public void set_hasDescription(bool value) { }

	public void set_id(AwardId value) { }

	public void set_isHidden(bool value) { }

	public void set_migrateToUseStatOffset(bool value) { }

	public void set_missionTiers(Dictionary<AwardTierType, AwardTier> value) { }

	public void set_title(string value) { }

	public void set_useFacebook(bool value) { }

	public void set_useStatOffset(bool value) { }

}

