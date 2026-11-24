namespace System.Security.Cryptography.X509Certificates;

public class X509Chain : IDisposable
{
	private X509ChainImpl impl; //Field offset: 0x8

	public X509ChainElementCollection ChainElements
	{
		 get { } //Length: 17
	}

	public X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 15
		 set { } //Length: 17
	}

	public X509ChainStatus[] ChainStatus
	{
		 get { } //Length: 15
	}

	internal X509ChainImpl Impl
	{
		 get { } //Length: 59
	}

	public X509Chain() { }

	public X509Chain(bool useMachineContext) { }

	public bool Build(X509Certificate2 certificate) { }

	public static X509Chain Create() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public X509ChainElementCollection get_ChainElements() { }

	public X509ChainPolicy get_ChainPolicy() { }

	public X509ChainStatus[] get_ChainStatus() { }

	internal X509ChainImpl get_Impl() { }

	public void set_ChainPolicy(X509ChainPolicy value) { }

}

