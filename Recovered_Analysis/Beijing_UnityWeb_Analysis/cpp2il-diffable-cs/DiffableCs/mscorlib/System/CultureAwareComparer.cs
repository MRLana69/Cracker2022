namespace System;

internal sealed class CultureAwareComparer : StringComparer
{
	private CompareInfo _compareInfo; //Field offset: 0x8
	private bool _ignoreCase; //Field offset: 0xC
	private CompareOptions _options; //Field offset: 0x10

	internal CultureAwareComparer(CultureInfo culture, bool ignoreCase) { }

	public override int Compare(string x, string y) { }

	public override bool Equals(string x, string y) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode(string obj) { }

	public override int GetHashCode() { }

}

