using System;
using Cpp2ILInjected;
using TopRun;

public class TopRunCell
{
	public TopRunCellType cellType;

	public int rank = -1;

	public int bestScore;

	public IPlayer player;

	public bool useDarkColour;

	public bool isLocalUser;

	public bool noPadding;

	public Action OnUpdateCell;

	public TopRunPlayerCell topRunPlayerCellScript;

	public void UpdateCell()
	{
		Action onUpdateCell = OnUpdateCell;
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
