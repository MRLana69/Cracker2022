namespace System.Net;

internal static class TimerThread
{
	internal delegate Callback
	{

		public Callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Timer timer, int timeNoticed, object context) { }

	}

	private class InfiniteTimerQueue : Queue
	{

		internal InfiniteTimerQueue() { }

	}

	internal abstract class Queue
	{
		private readonly int m_DurationMilliseconds; //Field offset: 0x8

		internal Queue(int durationMilliseconds) { }

	}

	internal abstract class Timer : IDisposable
	{
		private readonly int m_StartTimeMilliseconds; //Field offset: 0x8
		private readonly int m_DurationMilliseconds; //Field offset: 0xC

		internal Timer(int durationMilliseconds) { }

		internal abstract bool Cancel() { }

		public void Dispose() { }

	}

	private class TimerNode : Timer
	{
		private enum TimerState
		{
			Ready = 0,
			Fired = 1,
			Cancelled = 2,
			Sentinel = 3,
		}

		private TimerState m_TimerState; //Field offset: 0x10
		private Callback m_Callback; //Field offset: 0x14
		private object m_Context; //Field offset: 0x18
		private object m_QueueLock; //Field offset: 0x1C
		private TimerNode next; //Field offset: 0x20
		private TimerNode prev; //Field offset: 0x24

		internal TimerNode Next
		{
			 get { } //Length: 741
			 set { } //Length: 104
		}

		internal TimerNode Prev
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		internal TimerNode() { }

		internal override bool Cancel() { }

		internal TimerNode get_Next() { }

		internal TimerNode get_Prev() { }

		internal void set_Next(TimerNode value) { }

		internal void set_Prev(TimerNode value) { }

	}

	private class TimerQueue : Queue
	{
		private readonly TimerNode m_Timers; //Field offset: 0xC

		internal TimerQueue(int durationMilliseconds) { }

	}

	private static LinkedList<WeakReference> s_Queues; //Field offset: 0x0
	private static LinkedList<WeakReference> s_NewQueues; //Field offset: 0x4
	private static int s_ThreadState; //Field offset: 0x8
	private static AutoResetEvent s_ThreadReadyEvent; //Field offset: 0xC
	private static ManualResetEvent s_ThreadShutdownEvent; //Field offset: 0x10
	private static WaitHandle[] s_ThreadEvents; //Field offset: 0x14
	private static Hashtable s_QueuesCache; //Field offset: 0x18

	private static TimerThread() { }

	internal static Queue CreateQueue(int durationMilliseconds) { }

	private static void OnDomainUnload(object sender, EventArgs e) { }

	private static void StopTimerThread() { }

}

