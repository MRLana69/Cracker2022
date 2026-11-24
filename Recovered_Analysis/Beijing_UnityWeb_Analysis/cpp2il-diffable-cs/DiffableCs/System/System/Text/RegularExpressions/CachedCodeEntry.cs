namespace System.Text.RegularExpressions;

internal sealed class CachedCodeEntry
{
	internal string _key; //Field offset: 0x8
	internal RegexCode _code; //Field offset: 0xC
	internal Hashtable _caps; //Field offset: 0x10
	internal Hashtable _capnames; //Field offset: 0x14
	internal string[] _capslist; //Field offset: 0x18
	internal int _capsize; //Field offset: 0x1C
	internal RegexRunnerFactory _factory; //Field offset: 0x20
	internal ExclusiveReference _runnerref; //Field offset: 0x24
	internal SharedReference _replref; //Field offset: 0x28

	internal CachedCodeEntry(string key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, SharedReference repl) { }

}

