using System;

namespace SYBO.Components.Settings;

public class SerializeFileAttribute(string settingFile) : Attribute
{
	public string SettingFile = settingFile;
}
