namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListContentElement
{
	public int id;

	public int value;

	public string content
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

	public ListElementHelper helper
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public ListContentElement(string content, int value, int id)
	{
		this.content__BackingField = content;
		this.id = id;
		this.value = value;
	}
}
