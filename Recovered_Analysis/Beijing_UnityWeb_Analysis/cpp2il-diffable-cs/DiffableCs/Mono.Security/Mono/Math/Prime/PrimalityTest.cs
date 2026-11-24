namespace Mono.Math.Prime;

public delegate PrimalityTest
{

	public PrimalityTest(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(BigInteger bi, ConfidenceFactor confidence, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }

}

