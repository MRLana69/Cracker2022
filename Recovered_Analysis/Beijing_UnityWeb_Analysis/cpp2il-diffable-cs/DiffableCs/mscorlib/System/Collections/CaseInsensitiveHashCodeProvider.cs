namespace System.Collections;

public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{
	private TextInfo m_text; //Field offset: 0x8

	public static CaseInsensitiveHashCodeProvider Default
	{
		 get { } //Length: 103
	}

	public CaseInsensitiveHashCodeProvider() { }

	public CaseInsensitiveHashCodeProvider(CultureInfo culture) { }

	public static CaseInsensitiveHashCodeProvider get_Default() { }

	public int GetHashCode(object obj) { }

}

