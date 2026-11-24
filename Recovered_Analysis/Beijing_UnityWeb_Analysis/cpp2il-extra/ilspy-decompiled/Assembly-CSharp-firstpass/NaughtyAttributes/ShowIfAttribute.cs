namespace NaughtyAttributes;

public class ShowIfAttribute : DrawConditionAttribute
{
	private string conditionName;

	public string ConditionName => conditionName;

	public ShowIfAttribute(string conditionName)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = conditionName;
	}
}
