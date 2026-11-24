namespace System.Security.Cryptography;

public abstract class SHA1 : HashAlgorithm
{

	protected SHA1() { }

	public static SHA1 Create() { }

	public static SHA1 Create(string hashName) { }

}

