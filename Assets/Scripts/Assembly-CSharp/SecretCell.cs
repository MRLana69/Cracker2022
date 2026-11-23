using System;
using Cpp2ILInjected;

public class SecretCell
{
	public SecretCellType cellType;

	public string cellInfo;

	public string cellValue;

	public string cellTitle;

	public string cellInfo2;

	public string cellValue2;

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
