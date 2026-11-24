namespace System.Security.Cryptography;

public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding>
{
	private static readonly RSASignaturePadding s_pkcs1; //Field offset: 0x0
	private static readonly RSASignaturePadding s_pss; //Field offset: 0x4
	private readonly RSASignaturePaddingMode _mode; //Field offset: 0x8

	public RSASignaturePaddingMode Mode
	{
		 get { } //Length: 90
	}

	public static RSASignaturePadding Pkcs1
	{
		 get { } //Length: 89
	}

	public static RSASignaturePadding Pss
	{
		 get { } //Length: 89
	}

	private static RSASignaturePadding() { }

	private RSASignaturePadding(RSASignaturePaddingMode mode) { }

	internal RSASignaturePadding() { }

	public override bool Equals(object obj) { }

	public bool Equals(RSASignaturePadding other) { }

	public RSASignaturePaddingMode get_Mode() { }

	public static RSASignaturePadding get_Pkcs1() { }

	public static RSASignaturePadding get_Pss() { }

	public override int GetHashCode() { }

	public static bool op_Equality(RSASignaturePadding left, RSASignaturePadding right) { }

	public static bool op_Inequality(RSASignaturePadding left, RSASignaturePadding right) { }

	public override string ToString() { }

}

