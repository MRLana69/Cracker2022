using System;
using Cpp2ILInjected;

public class CollectCoinsCell
{
	public CollectCoinsCellType cellType;

	public Friend friend;

	public CollectCoinsDummyData.CollectCoinsDummy dummyFriend;

	public bool useDarkColour;

	public bool disableScrolling;

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
