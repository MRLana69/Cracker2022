namespace System.Security.Cryptography;

public sealed class AsnEncodedDataEnumerator : IEnumerator
{
	private AsnEncodedDataCollection _collection; //Field offset: 0x8
	private int _position; //Field offset: 0xC

	public AsnEncodedData Current
	{
		 get { } //Length: 68
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 102
	}

	internal AsnEncodedDataEnumerator(AsnEncodedDataCollection collection) { }

	internal AsnEncodedDataEnumerator() { }

	public AsnEncodedData get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

	private object System.Collections.IEnumerator.get_Current() { }

}

