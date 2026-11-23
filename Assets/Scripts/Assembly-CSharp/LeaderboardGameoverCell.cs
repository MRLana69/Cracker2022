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
		Action onUpdateCell = OnUpdateCell;
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
