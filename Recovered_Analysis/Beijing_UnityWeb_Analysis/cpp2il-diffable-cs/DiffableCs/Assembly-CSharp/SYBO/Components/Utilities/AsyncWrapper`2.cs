namespace SYBO.Components.Utilities;

public class AsyncWrapper`2 : AsyncWrapper
{
	private Action<T1, T2> _method; //Field offset: 0x0
	private T1 _argument1; //Field offset: 0x0
	private T2 _argument2; //Field offset: 0x0

	public AsyncWrapper`2(Action<T1, T2> method) { }

	public void BeginInvoke(T1 argument1, T2 argument2, AsyncCallback callback) { }

	public void ThreadCatchingWrapper() { }

}

