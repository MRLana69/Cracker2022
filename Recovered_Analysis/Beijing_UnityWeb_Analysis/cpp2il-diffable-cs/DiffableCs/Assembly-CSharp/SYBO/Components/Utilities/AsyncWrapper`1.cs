namespace SYBO.Components.Utilities;

public class AsyncWrapper`1 : AsyncWrapper
{
	private Action<T> _method; //Field offset: 0x0
	private T _argument; //Field offset: 0x0

	public AsyncWrapper`1(Action<T> method) { }

	public void BeginInvoke(T argument, AsyncCallback callback) { }

	public void ThreadCatchingWrapper() { }

}

