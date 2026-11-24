namespace System.Threading;

public class SynchronizationContext
{
	private static Type s_cachedPreparedType1; //Field offset: 0x0
	private static Type s_cachedPreparedType2; //Field offset: 0x4
	private static Type s_cachedPreparedType3; //Field offset: 0x8
	private static Type s_cachedPreparedType4; //Field offset: 0xC
	private static Type s_cachedPreparedType5; //Field offset: 0x10
	private SynchronizationContextProperties _props; //Field offset: 0x8

	public static SynchronizationContext Current
	{
		 get { } //Length: 81
	}

	internal static SynchronizationContext CurrentNoFlow
	{
		 get { } //Length: 68
	}

	public SynchronizationContext() { }

	public virtual SynchronizationContext CreateCopy() { }

	public static SynchronizationContext get_Current() { }

	internal static SynchronizationContext get_CurrentNoFlow() { }

	private static SynchronizationContext GetThreadLocalContext() { }

	public virtual void Post(SendOrPostCallback d, object state) { }

	public virtual void Send(SendOrPostCallback d, object state) { }

	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

}

