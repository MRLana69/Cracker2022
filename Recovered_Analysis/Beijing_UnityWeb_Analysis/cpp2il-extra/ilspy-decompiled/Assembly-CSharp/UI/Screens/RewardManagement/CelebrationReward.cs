using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Missions;
using SYBO.Subway.Info;
using UI.Screens.UpgradeScreenInternal;
using UnityEngine;

namespace UI.Screens.RewardManagement;

public class CelebrationReward
{
	public CelebrationRewardOrigin CelebrationRewardOrigin = CelebrationRewardOrigin.Notset;

	public CelebrationRewardType rewardType = CelebrationRewardType._notset;

	public UnlockItemSource unlockItemSource = UnlockItemSource.NotSet;

	public int amount = 0;

	public Characters.CharacterId characterId = Characters.CharacterId.slick;

	public int characterOutfitIndex = 0;

	public Boards.BoardId boardId = Boards.BoardId.normal;

	public Trophies.Trophy trophyType = Trophies.Trophy.diamond;

	public UpgradeType upgradeType = UpgradeType._notset;

	public long Uid = 0L;

	public AwardTierType awardTierType = AwardTierType.None;

	public string awardTitle;

	public int rank;

	public int score;

	public int weekNumber;

	public Hoverboard.BoardAbility boardPower;

	public int characterEventCompleted;

	public string description;

	public List<HoverboardThemes.ThemeIdentifier> bundledThemes;

	public string kilooAnalyticsSourceId;

	public ObtainableItemSource syboAnalyticsSource;

	public long syboAnalyticsSourceId;

	public string syboAnalyticsSourceMetaOrNull;

	public override string ToString()
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.RewardManagement.CelebrationReward)+6C]");
		return (string)0;
	}

	public void PopulateFromString(string rewardAsString)
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I8
		string tag = ((Component)amount).tag;
		((GameObject)(object)tag).tag = rewardAsString;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.RewardManagement.CelebrationReward)+34]");
		string tag2 = ((Component)0).tag;
		string tag3 = (string)(rewardAsString ^ 1);
		((GameObject)(object)tag2).tag = tag3;
		((GameObject)Uid).tag = rewardAsString;
		((UpgradeHelper)this).OnClick();
	}

	private void ResetToDefaultValues()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public CelebrationReward()
	{
		//IL_0073: Expected I8, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I4
		object obj = this + 60;
		obj = "";
		object obj2 = this - -64;
		obj2 = 1;
		score = 0;
		weekNumber = 1;
		boardPower = Hoverboard.BoardAbility.None;
	}
}
