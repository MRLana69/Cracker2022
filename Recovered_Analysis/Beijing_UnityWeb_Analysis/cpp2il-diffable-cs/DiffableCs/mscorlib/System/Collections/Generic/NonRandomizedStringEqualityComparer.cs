namespace System.Collections.Generic;

internal sealed class NonRandomizedStringEqualityComparer
{

	public NonRandomizedStringEqualityComparer() { }

	public sealed override bool Equals(string x, string y) { }

	public sealed override int GetHashCode(string obj) { }

}

