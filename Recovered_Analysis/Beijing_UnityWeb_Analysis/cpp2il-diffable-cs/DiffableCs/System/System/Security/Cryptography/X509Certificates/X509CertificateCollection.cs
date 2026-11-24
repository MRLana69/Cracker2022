namespace System.Security.Cryptography.X509Certificates;

public class X509CertificateCollection : CollectionBase
{
	public class X509CertificateEnumerator : IEnumerator
	{
		private IEnumerator enumerator; //Field offset: 0x8

		public X509Certificate Current
		{
			 get { } //Length: 15
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 66
		}

		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		public X509Certificate get_Current() { }

		public bool MoveNext() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private bool System.Collections.IEnumerator.MoveNext() { }

		private void System.Collections.IEnumerator.Reset() { }

	}


	public X509Certificate Item
	{
		 get { } //Length: 154
	}

	public X509CertificateCollection() { }

	public X509CertificateCollection(X509CertificateCollection value) { }

	public int Add(X509Certificate value) { }

	public void AddRange(X509CertificateCollection value) { }

	public X509Certificate get_Item(int index) { }

	public X509CertificateEnumerator GetEnumerator() { }

	public override int GetHashCode() { }

}

