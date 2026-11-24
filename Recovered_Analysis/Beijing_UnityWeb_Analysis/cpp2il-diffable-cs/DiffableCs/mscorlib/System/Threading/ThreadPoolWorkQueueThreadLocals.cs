namespace System.Threading;

internal sealed class ThreadPoolWorkQueueThreadLocals
{
	public static ThreadPoolWorkQueueThreadLocals threadLocals; //Field offset: 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x8
	public readonly WorkStealingQueue workStealingQueue; //Field offset: 0xC
	public readonly Random random; //Field offset: 0x10

	public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq) { }

	private void CleanUp() { }

	protected override void Finalize() { }

}

