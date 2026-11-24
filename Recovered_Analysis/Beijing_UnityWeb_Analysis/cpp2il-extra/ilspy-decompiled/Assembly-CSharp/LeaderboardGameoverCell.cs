using System;
using Cpp2ILInjected;

public class LeaderboardGameoverCell
{
	public LeaderboardGameoverCellType cellType;

	public Friend friend;

	public LeaderboardDummyData.LeaderboardDummy dummyFriend;

	public int rank;

	public bool isPlayerRanked;

	public bool useDarkColour;

	public bool lockList;

	public bool noFriends;

	public Action OnUpdateCell;

	public void UpdateCell()
	{
	}

	public LeaderboardGameoverCell()
	{
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
