namespace System.Security.Cryptography;

public struct RSAParameters
{
	public byte[] Exponent; //Field offset: 0x0
	public byte[] Modulus; //Field offset: 0x4
	public byte[] P; //Field offset: 0x8
	public byte[] Q; //Field offset: 0xC
	public byte[] DP; //Field offset: 0x10
	public byte[] DQ; //Field offset: 0x14
	public byte[] InverseQ; //Field offset: 0x18
	public byte[] D; //Field offset: 0x1C

}

