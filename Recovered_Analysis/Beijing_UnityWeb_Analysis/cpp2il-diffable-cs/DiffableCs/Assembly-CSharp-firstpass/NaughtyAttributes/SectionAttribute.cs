namespace NaughtyAttributes;

public class SectionAttribute : MetaAttribute
{
	private string sectionLabel; //Field offset: 0xC

	public string SectionLabel
	{
		 get { } //Length: 6
	}

	public SectionAttribute(string sectionLabel) { }

	public string get_SectionLabel() { }

}

