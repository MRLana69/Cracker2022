namespace NaughtyAttributes;

public class DropdownAttribute : DrawerAttribute
{
	private string valuesFieldName; //Field offset: 0x8

	public string ValuesFieldName
	{
		 get { } //Length: 6
	}

	public DropdownAttribute(string valuesFieldName) { }

	public string get_ValuesFieldName() { }

}

