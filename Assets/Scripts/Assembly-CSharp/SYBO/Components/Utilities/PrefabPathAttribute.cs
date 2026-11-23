using System;

namespace SYBO.Components.Utilities;

public class PrefabPathAttribute : Attribute
{
	public string Path
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public PrefabPathAttribute(string path)
	{
		Path__BackingField = path;
	}
}
