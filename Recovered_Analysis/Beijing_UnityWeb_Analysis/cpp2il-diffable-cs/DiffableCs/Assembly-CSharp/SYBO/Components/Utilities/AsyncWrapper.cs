namespace SYBO.Components.Utilities;

public abstract class AsyncWrapper
{
	protected IAsyncResult _asyncResult; //Field offset: 0x8
	protected Action _asyncMethod; //Field offset: 0xC
	protected Exception Error; //Field offset: 0x10

	protected AsyncWrapper() { }

	public void EndInvoke() { }

}

