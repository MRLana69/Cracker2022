namespace System.Collections.Specialized;

internal class CompatibleComparer : IEqualityComparer
{
	private static IComparer defaultComparer; //Field offset: 0x0
	private static IHashCodeProvider defaultHashProvider; //Field offset: 0x4
	private IComparer _comparer; //Field offset: 0x8
	private IHashCodeProvider _hcp; //Field offset: 0xC

	public IComparer Comparer
	{
		 get { } //Length: 133
	}

	public static IComparer DefaultComparer
	{
		 get { } //Length: 89
	}

	public static IHashCodeProvider DefaultHashCodeProvider
	{
		 get { } //Length: 149
	}

	public IHashCodeProvider HashCodeProvider
	{
		 get { } //Length: 6
	}

	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	public bool Equals(object a, object b) { }

	public IComparer get_Comparer() { }

	public static IComparer get_DefaultComparer() { }

	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

	public IHashCodeProvider get_HashCodeProvider() { }

	public int GetHashCode(object obj) { }

}

