namespace System.Text.RegularExpressions;

internal sealed class RegexReplacement
{
	internal string _rep; //Field offset: 0x8
	internal List<string> _strings; //Field offset: 0xC
	internal List<int> _rules; //Field offset: 0x10

	internal string Pattern
	{
		 get { } //Length: 15
	}

	internal RegexReplacement(string rep, RegexNode concat, Hashtable _caps) { }

	internal string get_Pattern() { }

	internal string Replace(Regex regex, string input, int count, int startat) { }

	private void ReplacementImpl(StringBuilder sb, Match match) { }

	private void ReplacementImplRTL(List<string> al, Match match) { }

}

