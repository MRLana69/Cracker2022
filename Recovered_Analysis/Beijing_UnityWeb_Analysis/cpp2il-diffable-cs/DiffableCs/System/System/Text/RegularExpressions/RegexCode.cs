namespace System.Text.RegularExpressions;

internal sealed class RegexCode
{
	internal int[] _codes; //Field offset: 0x8
	internal string[] _strings; //Field offset: 0xC
	internal int _trackcount; //Field offset: 0x10
	internal Hashtable _caps; //Field offset: 0x14
	internal int _capsize; //Field offset: 0x18
	internal RegexPrefix _fcPrefix; //Field offset: 0x1C
	internal RegexBoyerMoore _bmPrefix; //Field offset: 0x20
	internal int _anchors; //Field offset: 0x24
	internal bool _rightToLeft; //Field offset: 0x28

	internal RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, int anchors, bool rightToLeft) { }

	internal static bool OpcodeBacktracks(int Op) { }

}

