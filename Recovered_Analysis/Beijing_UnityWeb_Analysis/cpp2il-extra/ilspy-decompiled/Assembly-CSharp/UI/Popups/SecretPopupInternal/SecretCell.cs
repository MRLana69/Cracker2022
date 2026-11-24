using System;
using Cpp2ILInjected;

namespace UI.Popups.SecretPopupInternal;

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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public SecretCell()
	{
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
