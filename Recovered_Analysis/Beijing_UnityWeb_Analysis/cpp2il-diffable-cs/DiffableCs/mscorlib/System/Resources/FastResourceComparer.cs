namespace System.Resources;

internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
{
	internal static readonly FastResourceComparer Default; //Field offset: 0x0

	private static FastResourceComparer() { }

	public FastResourceComparer() { }

	public int Compare(object a, object b) { }

	public int Compare(string a, string b) { }

	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	public bool Equals(string a, string b) { }

	public bool Equals(object a, object b) { }

	public int GetHashCode(object key) { }

	public int GetHashCode(string key) { }

	internal static int HashFunction(string key) { }

}

