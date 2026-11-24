namespace Mono.Math.Prime.Generator;

internal abstract class PrimeGeneratorBase
{

	public virtual ConfidenceFactor Confidence
	{
		 get { } //Length: 55
	}

	public virtual PrimalityTest PrimalityTest
	{
		 get { } //Length: 3
	}

	public virtual int TrialDivisionBounds
	{
		 get { } //Length: 86
	}

	protected PrimeGeneratorBase() { }

	public abstract BigInteger GenerateNewPrime(int bits) { }

	public virtual ConfidenceFactor get_Confidence() { }

	public virtual PrimalityTest get_PrimalityTest() { }

	public virtual int get_TrialDivisionBounds() { }

}

