namespace System.Security.Cryptography;

public class PKCS1MaskGenerationMethod : MaskGenerationMethod
{
	private string HashNameValue; //Field offset: 0x8

	public string HashName
	{
		 get { } //Length: 293
		 set { } //Length: 349
	}

	public PKCS1MaskGenerationMethod() { }

	public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn) { }

	public string get_HashName() { }

	public void set_HashName(string value) { }

}

