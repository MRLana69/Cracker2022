namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509ChainImpl : IDisposable
{

	public abstract X509ChainElementCollection ChainElements
	{
		 get { } //Length: 0
	}

	public abstract X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract X509ChainStatus[] ChainStatus
	{
		 get { } //Length: 0
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	protected X509ChainImpl() { }

	public abstract bool Build(X509Certificate2 certificate) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public abstract X509ChainElementCollection get_ChainElements() { }

	public abstract X509ChainPolicy get_ChainPolicy() { }

	public abstract X509ChainStatus[] get_ChainStatus() { }

	public abstract bool get_IsValid() { }

	public abstract void Reset() { }

	public abstract void set_ChainPolicy(X509ChainPolicy value) { }

}

