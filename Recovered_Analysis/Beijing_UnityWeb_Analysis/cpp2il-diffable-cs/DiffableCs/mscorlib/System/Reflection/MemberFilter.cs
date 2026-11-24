namespace System.Reflection;

public delegate MemberFilter
{

	public MemberFilter(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(MemberInfo m, object filterCriteria, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }

}

