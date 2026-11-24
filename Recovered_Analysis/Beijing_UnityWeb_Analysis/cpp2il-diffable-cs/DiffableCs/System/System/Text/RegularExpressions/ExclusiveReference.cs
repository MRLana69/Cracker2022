namespace System.Text.RegularExpressions;

internal sealed class ExclusiveReference
{
	private RegexRunner _ref; //Field offset: 0x8
	private object _obj; //Field offset: 0xC
	private int _locked; //Field offset: 0x10

	public ExclusiveReference() { }

	internal object Get() { }

	internal void Release(object obj) { }

}

