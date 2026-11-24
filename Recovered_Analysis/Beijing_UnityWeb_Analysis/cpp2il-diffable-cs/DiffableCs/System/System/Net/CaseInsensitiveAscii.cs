namespace System.Net;

internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
{
	internal static readonly CaseInsensitiveAscii StaticInstance; //Field offset: 0x0
	internal static readonly byte[] AsciiToLower; //Field offset: 0x4

	private static CaseInsensitiveAscii() { }

	public CaseInsensitiveAscii() { }

	public int Compare(object firstObject, object secondObject) { }

	public bool Equals(object firstObject, object secondObject) { }

	private int FastGetHashCode(string myString) { }

	public int GetHashCode(object myObject) { }

}

