namespace NaughtyAttributes;

public class ShowIfAttribute : DrawConditionAttribute
{
	private string conditionName; //Field offset: 0x8

	public string ConditionName
	{
		 get { } //Length: 6
	}

	public ShowIfAttribute(string conditionName) { }

	public string get_ConditionName() { }

}

