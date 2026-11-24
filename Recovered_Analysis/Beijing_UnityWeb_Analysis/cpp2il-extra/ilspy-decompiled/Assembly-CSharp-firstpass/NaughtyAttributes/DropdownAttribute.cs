namespace NaughtyAttributes;

public class DropdownAttribute : DrawerAttribute
{
	private string valuesFieldName;

	public string ValuesFieldName => valuesFieldName;

	public DropdownAttribute(string valuesFieldName)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = valuesFieldName;
	}
}
