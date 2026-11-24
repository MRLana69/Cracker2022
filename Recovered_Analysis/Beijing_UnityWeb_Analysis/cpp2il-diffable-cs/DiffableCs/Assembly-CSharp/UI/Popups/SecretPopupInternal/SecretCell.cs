namespace UI.Popups.SecretPopupInternal;

public class SecretCell
{
	public SecretCellType cellType; //Field offset: 0x8
	public string cellInfo; //Field offset: 0xC
	public string cellValue; //Field offset: 0x10
	public string cellTitle; //Field offset: 0x14
	public string cellInfo2; //Field offset: 0x18
	public string cellValue2; //Field offset: 0x1C
	public Action OnUpdateCell; //Field offset: 0x20

	public SecretCell() { }

	public void UpdateCell() { }

}

