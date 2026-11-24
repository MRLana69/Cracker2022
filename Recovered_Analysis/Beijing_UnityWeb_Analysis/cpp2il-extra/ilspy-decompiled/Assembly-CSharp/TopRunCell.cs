using System;
using Cpp2ILInjected;
using TopRun;
using UI.Screens;

public class TopRunCell
{
	public TopRunCellType cellType;

	public int rank;

	public int bestScore;

	public IPlayer player;

	public bool useDarkColour;

	public bool isLocalUser;

	public bool noPadding;

	public Action OnUpdateCell;

	public TopRunPlayerCell topRunPlayerCellScript;

	public void UpdateCell()
	{
		_ = 1;
		((UpgradeScreen)this).Start();
	}

	public TopRunCell()
	{
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
