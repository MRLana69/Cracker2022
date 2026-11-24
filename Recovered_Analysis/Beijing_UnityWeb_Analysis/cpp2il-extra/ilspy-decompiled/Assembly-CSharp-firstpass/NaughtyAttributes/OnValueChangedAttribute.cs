namespace NaughtyAttributes;

public class OnValueChangedAttribute : MetaAttribute
{
	private string callbackName;

	public string CallbackName
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)base.order;
		}
	}

	public OnValueChangedAttribute(string callbackName)
	{
		//IL_000a: Expected I4, but got Obj
		base.order = (int)callbackName;
	}
}
