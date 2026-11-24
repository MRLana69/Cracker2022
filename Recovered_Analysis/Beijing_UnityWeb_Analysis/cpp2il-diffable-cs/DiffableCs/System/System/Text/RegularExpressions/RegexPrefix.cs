namespace System.Text.RegularExpressions;

internal sealed class RegexPrefix
{
	internal static RegexPrefix _empty; //Field offset: 0x0
	internal string _prefix; //Field offset: 0x8
	internal bool _caseInsensitive; //Field offset: 0xC

	internal bool CaseInsensitive
	{
		 get { } //Length: 6
	}

	internal static RegexPrefix Empty
	{
		 get { } //Length: 332
	}

	internal string Prefix
	{
		 get { } //Length: 9
	}

	private static RegexPrefix() { }

	internal RegexPrefix(string prefix, bool ci) { }

	internal bool get_CaseInsensitive() { }

	internal static RegexPrefix get_Empty() { }

	internal string get_Prefix() { }

}

