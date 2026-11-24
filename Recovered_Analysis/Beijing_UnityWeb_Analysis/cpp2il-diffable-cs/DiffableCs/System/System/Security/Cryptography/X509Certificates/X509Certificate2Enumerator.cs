namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Certificate2Enumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x8

	public X509Certificate2 Current
	{
		 get { } //Length: 59
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 54
	}

	internal X509Certificate2Enumerator(X509Certificate2Collection collection) { }

	public X509Certificate2 get_Current() { }

	public bool MoveNext() { }

	private object System.Collections.IEnumerator.get_Current() { }

	private bool System.Collections.IEnumerator.MoveNext() { }

	private void System.Collections.IEnumerator.Reset() { }

}

