namespace System.Collections;

internal class CompatibleComparer : IEqualityComparer
{
	private IComparer _comparer; //Field offset: 0x8
	private IHashCodeProvider _hcp; //Field offset: 0xC

	internal IComparer Comparer
	{
		 get { } //Length: 15
	}

	internal IHashCodeProvider HashCodeProvider
	{
		 get { } //Length: 6
	}

	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	public int Compare(object a, object b) { }

	public bool Equals(object a, object b) { }

	internal IComparer get_Comparer() { }

	internal IHashCodeProvider get_HashCodeProvider() { }

	public int GetHashCode(object obj) { }

}

