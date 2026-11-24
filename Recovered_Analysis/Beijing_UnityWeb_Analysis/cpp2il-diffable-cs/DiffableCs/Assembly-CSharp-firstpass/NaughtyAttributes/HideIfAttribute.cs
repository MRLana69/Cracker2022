namespace NaughtyAttributes;

public class HideIfAttribute : DrawConditionAttribute
{
	private string conditionName; //Field offset: 0x8

	public string ConditionName
	{
		 get { } //Length: 35
	}

	public HideIfAttribute(string conditionName) { }

	public string get_ConditionName() { }

}

