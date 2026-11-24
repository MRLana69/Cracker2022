namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListContentElementReferences
{
	private ListElementHelper listElementHelper__BackingField;

	private ScrollView scrollView__BackingField;

	private CenterOnChild centerOnChild__BackingField;

	public ListElementHelper listElementHelper
	{
		get
		{
			return (ListElementHelper)(object)centerOnChild__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public ScrollView scrollView
	{
		get
		{
			return (ScrollView)(object)listElementHelper__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public CenterOnChild centerOnChild
	{
		get
		{
			return (CenterOnChild)(object)scrollView__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public string initialContent
	{
		get
		{
			return (string)(object)centerOnChild__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}
}
