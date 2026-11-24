namespace System.Globalization;

internal class CodePageDataItem
{
	private static readonly char[] sep; //Field offset: 0x0
	internal int m_dataIndex; //Field offset: 0x8
	internal int m_uiFamilyCodePage; //Field offset: 0xC
	internal string m_webName; //Field offset: 0x10
	internal string m_headerName; //Field offset: 0x14
	internal string m_bodyName; //Field offset: 0x18
	internal uint m_flags; //Field offset: 0x1C

	public string HeaderName
	{
		 get { } //Length: 174
	}

	public string WebName
	{
		 get { } //Length: 3
	}

	private static CodePageDataItem() { }

	internal CodePageDataItem(int dataIndex) { }

	internal static string CreateString(string pStrings, uint index) { }

	public string get_HeaderName() { }

	public string get_WebName() { }

}

