namespace System.Collections;

internal static class HashHelpers
{
	public static readonly int[] primes; //Field offset: 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_SerializationInfoTable; //Field offset: 0x4

	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable
	{
		 get { } //Length: 103
	}

	private static HashHelpers() { }

	public static int ExpandPrime(int oldSize) { }

	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	public static int GetPrime(int min) { }

	public static bool IsPrime(int candidate) { }

}

