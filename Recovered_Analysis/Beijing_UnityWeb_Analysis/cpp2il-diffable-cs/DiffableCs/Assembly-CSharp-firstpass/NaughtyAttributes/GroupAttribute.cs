namespace NaughtyAttributes;

public abstract class GroupAttribute : NaughtyAttribute
{
	private string name; //Field offset: 0x8

	public string Name
	{
		 get { } //Length: 6
	}

	public GroupAttribute(string name) { }

	public string get_Name() { }

}

