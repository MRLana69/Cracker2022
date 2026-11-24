namespace System.Text.RegularExpressions;

internal sealed class RegexTree
{
	internal RegexNode _root; //Field offset: 0x8
	internal Hashtable _caps; //Field offset: 0xC
	internal int[] _capnumlist; //Field offset: 0x10
	internal Hashtable _capnames; //Field offset: 0x14
	internal string[] _capslist; //Field offset: 0x18
	internal RegexOptions _options; //Field offset: 0x1C
	internal int _captop; //Field offset: 0x20

	internal RegexTree(RegexNode root, Hashtable caps, int[] capnumlist, int captop, Hashtable capnames, string[] capslist, RegexOptions opts) { }

}

