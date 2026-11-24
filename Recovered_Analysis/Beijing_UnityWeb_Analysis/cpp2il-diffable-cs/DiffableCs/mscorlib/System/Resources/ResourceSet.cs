namespace System.Resources;

public class ResourceSet : IDisposable, IEnumerable
{
	protected IResourceReader Reader; //Field offset: 0x8
	protected Hashtable Table; //Field offset: 0xC
	private Hashtable _caseInsensitiveTable; //Field offset: 0x10

	protected ResourceSet() { }

	internal ResourceSet(bool junk) { }

	private void CommonInit() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	private object GetCaseInsensitiveObjectInternal(string name) { }

	public virtual IDictionaryEnumerator GetEnumerator() { }

	private IDictionaryEnumerator GetEnumeratorHelper() { }

	public virtual object GetObject(string name) { }

	public virtual object GetObject(string name, bool ignoreCase) { }

	private object GetObjectInternal(string name) { }

	public virtual string GetString(string name) { }

	public virtual string GetString(string name, bool ignoreCase) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

