//Type is in global namespace

public class DebugSettingsCell
{
	public DebugSettingsCellType cellType; //Field offset: 0x8
	public DebugSetting settingType; //Field offset: 0xC
	public string cellTitle; //Field offset: 0x10
	public string cellDescription; //Field offset: 0x14
	public string cellFunctionName; //Field offset: 0x18
	public ButtonIcon cellButtonIcon; //Field offset: 0x1C
	private Dictionary<string, string> <_items>k__BackingField; //Field offset: 0x20
	public bool multiSelect; //Field offset: 0x24
	public Action callback; //Field offset: 0x28

	public Dictionary<string, string> _items
	{
		 get { } //Length: 66
		private set { } //Length: 414
	}

	public DebugSettingsCell() { }

	public Dictionary<string, string> get__items() { }

	private void set__items(Dictionary<string, string> value) { }

}

