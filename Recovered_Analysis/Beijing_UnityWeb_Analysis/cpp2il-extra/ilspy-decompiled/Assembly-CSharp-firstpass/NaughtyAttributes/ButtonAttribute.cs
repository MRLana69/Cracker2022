namespace NaughtyAttributes;

public class ButtonAttribute : DrawerAttribute
{
	private string text;

	public string Text => text;

	public ButtonAttribute(string text = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = text;
	}
}
