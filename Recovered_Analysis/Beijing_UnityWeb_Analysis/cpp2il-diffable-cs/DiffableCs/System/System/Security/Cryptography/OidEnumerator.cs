namespace System.Security.Cryptography;

public sealed class OidEnumerator : IEnumerator
{
	private OidCollection m_oids; //Field offset: 0x8
	private int m_current; //Field offset: 0xC

	public Oid Current
	{
		 get { } //Length: 3
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 17
	}

	private OidEnumerator() { }

	internal OidEnumerator(OidCollection oids) { }

	public Oid get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

	private object System.Collections.IEnumerator.get_Current() { }

}

