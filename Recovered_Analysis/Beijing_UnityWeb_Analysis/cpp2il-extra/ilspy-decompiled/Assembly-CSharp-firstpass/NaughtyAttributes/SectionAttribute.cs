namespace NaughtyAttributes;

public class SectionAttribute : MetaAttribute
{
	private string sectionLabel;

	public string SectionLabel => sectionLabel;

	public SectionAttribute(string sectionLabel)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = sectionLabel;
	}
}
