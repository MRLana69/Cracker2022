namespace System.Security.Cryptography;

public struct DSAParameters
{
	public byte[] P; //Field offset: 0x0
	public byte[] Q; //Field offset: 0x4
	public byte[] G; //Field offset: 0x8
	public byte[] Y; //Field offset: 0xC
	public byte[] J; //Field offset: 0x10
	public byte[] X; //Field offset: 0x14
	public byte[] Seed; //Field offset: 0x18
	public int Counter; //Field offset: 0x1C

}

