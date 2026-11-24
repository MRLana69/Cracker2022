namespace System.Security.Cryptography;

public struct HashAlgorithmName : IEquatable<HashAlgorithmName>
{
	private readonly string _name; //Field offset: 0x0

	public static HashAlgorithmName MD5
	{
		 get { } //Length: 3
	}

	public string Name
	{
		 get { } //Length: 6
	}

	public static HashAlgorithmName SHA1
	{
		 get { } //Length: 75
	}

	public static HashAlgorithmName SHA256
	{
		 get { } //Length: 75
	}

	public static HashAlgorithmName SHA384
	{
		 get { } //Length: 75
	}

	public static HashAlgorithmName SHA512
	{
		 get { } //Length: 75
	}

	public HashAlgorithmName(string name) { }

	public override bool Equals(object obj) { }

	public bool Equals(HashAlgorithmName other) { }

	public static HashAlgorithmName get_MD5() { }

	public string get_Name() { }

	public static HashAlgorithmName get_SHA1() { }

	public static HashAlgorithmName get_SHA256() { }

	public static HashAlgorithmName get_SHA384() { }

	public static HashAlgorithmName get_SHA512() { }

	public override int GetHashCode() { }

	public static bool op_Equality(HashAlgorithmName left, HashAlgorithmName right) { }

	public static bool op_Inequality(HashAlgorithmName left, HashAlgorithmName right) { }

	public override string ToString() { }

}

