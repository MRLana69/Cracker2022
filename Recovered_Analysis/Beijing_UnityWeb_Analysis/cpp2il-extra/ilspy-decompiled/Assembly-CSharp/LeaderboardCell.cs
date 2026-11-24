using System;
using Cpp2ILInjected;
using UnityEngine;

public class LeaderboardCell
{
	public LeaderboardCellType cellType;

	public Friend friend;

	public LeaderboardDummyData.LeaderboardDummy dummyFriend;

	public int rank;

	public bool isPlayerRanked;

	public bool useDarkColour;

	public bool lockList;

	public string headerText;

	public Color headerColor;

	public bool adjustOverlay;

	public bool noFriends;

	public Action OnUpdateCell;

	public void UpdateCell()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 48;
		obj = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public LeaderboardCell()
	{
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
