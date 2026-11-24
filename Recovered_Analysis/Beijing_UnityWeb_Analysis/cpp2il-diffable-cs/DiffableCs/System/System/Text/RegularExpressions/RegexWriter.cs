namespace System.Text.RegularExpressions;

internal sealed class RegexWriter
{
	internal int[] _intStack; //Field offset: 0x8
	internal int _depth; //Field offset: 0xC
	internal int[] _emitted; //Field offset: 0x10
	internal int _curpos; //Field offset: 0x14
	internal Dictionary<string, int> _stringhash; //Field offset: 0x18
	internal List<string> _stringtable; //Field offset: 0x1C
	internal bool _counting; //Field offset: 0x20
	internal int _count; //Field offset: 0x24
	internal int _trackcount; //Field offset: 0x28
	internal Hashtable _caps; //Field offset: 0x2C

	private RegexWriter() { }

	internal int CurPos() { }

	internal void Emit(int op) { }

	internal void Emit(int op, int opd1) { }

	internal void Emit(int op, int opd1, int opd2) { }

	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }

	internal bool EmptyStack() { }

	internal ArgumentException MakeException(string message) { }

	internal int MapCapnum(int capnum) { }

	internal void PatchJump(int Offset, int jumpDest) { }

	internal int PopInt() { }

	internal void PushInt(int I) { }

	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	internal int StringCode(string str) { }

	internal static RegexCode Write(RegexTree t) { }

}

