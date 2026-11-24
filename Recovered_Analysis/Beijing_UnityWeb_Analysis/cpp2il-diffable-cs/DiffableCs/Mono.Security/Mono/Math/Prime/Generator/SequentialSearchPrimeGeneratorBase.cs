namespace Mono.Math.Prime.Generator;

public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
{

	public SequentialSearchPrimeGeneratorBase() { }

	public override BigInteger GenerateNewPrime(int bits) { }

	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

}

