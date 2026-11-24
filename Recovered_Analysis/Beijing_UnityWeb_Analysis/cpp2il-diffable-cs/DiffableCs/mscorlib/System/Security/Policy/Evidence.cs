namespace System.Security.Policy;

public sealed class Evidence : ICollection, IEnumerable
{
	private class EvidenceEnumerator : IEnumerator
	{
		private IEnumerator currentEnum; //Field offset: 0x8
		private IEnumerator hostEnum; //Field offset: 0xC
		private IEnumerator assemblyEnum; //Field offset: 0x10

		public object Current
		{
			 get { } //Length: 131
		}

		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum) { }

		public object get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private bool _locked; //Field offset: 0x8
	private ArrayList hostEvidenceList; //Field offset: 0xC
	private ArrayList assemblyEvidenceList; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 9
	}

	public Evidence() { }

	public void CopyTo(Array array, int index) { }

	public int get_Count() { }

	public IEnumerator GetEnumerator() { }

}

