namespace System.Text.RegularExpressions;

internal sealed class RegexBoyerMoore
{
	internal int[] _positive; //Field offset: 0x8
	internal int[] _negativeASCII; //Field offset: 0xC
	internal int[][] _negativeUnicode; //Field offset: 0x10
	internal string _pattern; //Field offset: 0x14
	internal int _lowASCII; //Field offset: 0x18
	internal int _highASCII; //Field offset: 0x1C
	internal bool _rightToLeft; //Field offset: 0x20
	internal bool _caseInsensitive; //Field offset: 0x21
	internal CultureInfo _culture; //Field offset: 0x24

	internal RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	private bool MatchPattern(string text, int index) { }

	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	public override string ToString() { }

}

