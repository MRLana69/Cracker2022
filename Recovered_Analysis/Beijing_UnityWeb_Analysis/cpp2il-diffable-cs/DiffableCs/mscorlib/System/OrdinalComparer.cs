namespace System;

internal sealed class OrdinalComparer : StringComparer
{
	private bool _ignoreCase; //Field offset: 0x8

	internal OrdinalComparer(bool ignoreCase) { }

	public override int Compare(string x, string y) { }

	public override bool Equals(string x, string y) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode(string obj) { }

	public override int GetHashCode() { }

}

