namespace System.Security.Cryptography;

public abstract class RC2 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4
	protected int EffectiveKeySizeValue; //Field offset: 0x2C

	public virtual int EffectiveKeySize
	{
		 get { } //Length: 55
		 set { } //Length: 71
	}

	public override int KeySize
	{
		 get { } //Length: 20
		 set { } //Length: 232
	}

	private static RC2() { }

	protected RC2() { }

	public static RC2 Create() { }

	public static RC2 Create(string AlgName) { }

	public virtual int get_EffectiveKeySize() { }

	public override int get_KeySize() { }

	public virtual void set_EffectiveKeySize(int value) { }

	public override void set_KeySize(int value) { }

}

