namespace NaughtyAttributes;

public class OnValueChangedAttribute : MetaAttribute
{
	private string callbackName; //Field offset: 0xC

	public string CallbackName
	{
		 get { } //Length: 6
	}

	public OnValueChangedAttribute(string callbackName) { }

	public string get_CallbackName() { }

}

