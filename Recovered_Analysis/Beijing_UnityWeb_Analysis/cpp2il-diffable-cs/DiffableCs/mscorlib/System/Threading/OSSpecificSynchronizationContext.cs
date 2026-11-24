namespace System.Threading;

internal class OSSpecificSynchronizationContext : SynchronizationContext
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

	}

	private class InvocationContext
	{
		private SendOrPostCallback m_Delegate; //Field offset: 0x8
		private object m_State; //Field offset: 0xC

		public InvocationContext(SendOrPostCallback d, object state) { }

		public void Invoke() { }

	}

	private delegate InvocationEntryDelegate
	{

		public InvocationEntryDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(nint arg, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(nint arg) { }

	}

	private sealed class MonoPInvokeCallbackAttribute : Attribute
	{

		public MonoPInvokeCallbackAttribute(Type t) { }

	}

	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; //Field offset: 0x0
	private object m_OSSynchronizationContext; //Field offset: 0xC

	private static OSSpecificSynchronizationContext() { }

	private OSSpecificSynchronizationContext(object osContext) { }

	public override SynchronizationContext CreateCopy() { }

	public static OSSpecificSynchronizationContext Get() { }

	private static object GetOSContext() { }

	private static void InvocationEntry(nint arg) { }

	public override void Post(SendOrPostCallback d, object state) { }

	private static void PostInternal(object osSynchronizationContext, nint callback, nint arg) { }

	public override void Send(SendOrPostCallback d, object state) { }

}

