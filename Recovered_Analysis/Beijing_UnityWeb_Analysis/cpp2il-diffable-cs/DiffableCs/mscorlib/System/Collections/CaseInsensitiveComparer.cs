namespace System.Collections;

public class CaseInsensitiveComparer : IComparer
{
	private CompareInfo m_compareInfo; //Field offset: 0x8

	public static CaseInsensitiveComparer Default
	{
		 get { } //Length: 29
	}

	public CaseInsensitiveComparer() { }

	public CaseInsensitiveComparer(CultureInfo culture) { }

	public int Compare(object a, object b) { }

	public static CaseInsensitiveComparer get_Default() { }

}

