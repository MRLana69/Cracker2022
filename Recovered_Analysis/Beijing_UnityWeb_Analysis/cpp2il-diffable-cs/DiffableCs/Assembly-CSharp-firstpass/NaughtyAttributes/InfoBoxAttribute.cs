namespace NaughtyAttributes;

public class InfoBoxAttribute : MetaAttribute
{
	private string text; //Field offset: 0xC
	private InfoBoxType type; //Field offset: 0x10
	private string visibleIf; //Field offset: 0x14

	public string Text
	{
		 get { } //Length: 6
	}

	public InfoBoxType Type
	{
		 get { } //Length: 6
	}

	public string VisibleIf
	{
		 get { } //Length: 6
	}

	public InfoBoxAttribute(string text, InfoBoxType type = 0, string visibleIf = null) { }

	public InfoBoxAttribute(string text, string visibleIf) { }

	public string get_Text() { }

	public InfoBoxType get_Type() { }

	public string get_VisibleIf() { }

}

