namespace System.Reflection;

public delegate TypeFilter
{

	public TypeFilter(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(Type m, object filterCriteria, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(Type m, object filterCriteria) { }

}

