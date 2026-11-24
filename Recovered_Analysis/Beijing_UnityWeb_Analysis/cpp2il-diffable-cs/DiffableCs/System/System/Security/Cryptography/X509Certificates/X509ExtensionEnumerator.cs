namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ExtensionEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x8

	public X509Extension Current
	{
		 get { } //Length: 66
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 66
	}

	internal X509ExtensionEnumerator(ArrayList list) { }

	public X509Extension get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

	private object System.Collections.IEnumerator.get_Current() { }

}

