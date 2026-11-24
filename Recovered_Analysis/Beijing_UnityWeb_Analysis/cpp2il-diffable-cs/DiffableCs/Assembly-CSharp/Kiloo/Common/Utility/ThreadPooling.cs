namespace Kiloo.Common.Utility;

public class ThreadPooling : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public Action<ProgressDelegate> task; //Field offset: 0x8
		public ThreadPooling <>4__this; //Field offset: 0xC
		public Action callback; //Field offset: 0x10
		public ProgressDelegate <>9__1; //Field offset: 0x14

		public <>c__DisplayClass10_0() { }

		internal void <RunAsync>b__0() { }

		internal void <RunAsync>b__1(Action progress) { }

	}

	private sealed class <>c__DisplayClass12_0`1
	{
		public Action<T, ProgressDelegate> iterate; //Field offset: 0x0
		public IList<T> elements; //Field offset: 0x0

		public <>c__DisplayClass12_0`1() { }

		internal void <Foreach>b__0(int i, ProgressDelegate progress) { }

	}

	private sealed class <>c__DisplayClass13_0
	{
		public Action<int, ProgressDelegate> iterate; //Field offset: 0x8
		public int start; //Field offset: 0xC
		public int end; //Field offset: 0x10
		public int nextIteration; //Field offset: 0x14
		public int endIteration; //Field offset: 0x18
		public Action<ProgressDelegate> <>9__1; //Field offset: 0x1C
		public Action<Action> <>9__0; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <For>b__0(Action action) { }

		internal void <For>b__1(ProgressDelegate progress) { }

	}

	private sealed class <>c__DisplayClass3_0
	{
		public Action task; //Field offset: 0x8

		public <>c__DisplayClass3_0() { }

		internal void <QueueUserWorkItem>b__0(ProgressDelegate progress) { }

	}

	public delegate ProgressDelegate
	{

		public ProgressDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Action progress, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Action progress) { }

	}

	private class Task
	{
		public Action process; //Field offset: 0x8
		public StackTrace stackTrace; //Field offset: 0xC

		public Task() { }

	}

	private static ThreadPooling s_instance; //Field offset: 0x0
	private static int _numThreads; //Field offset: 0x4
	private readonly List<Action> LockedTasks; //Field offset: 0xC
	private readonly List<Action> Tasks; //Field offset: 0x10
	private readonly List<Exception> LockedExceptions; //Field offset: 0x14
	private readonly List<Exception> Exceptions; //Field offset: 0x18

	public ThreadPooling() { }

	public static void Destroy() { }

	public static void For(int start, int end, Action<int, ProgressDelegate> iterate, Action callback) { }

	public static void Foreach(IList<T> elements, Action<T, ProgressDelegate> iterate, Action callback) { }

	public static void QueueUserWorkItem(Action task, Action callback) { }

	public static void QueueUserWorkItemWithProgress(Action<ProgressDelegate> task, Action callback) { }

	private static void RunAction(object newTask) { }

	private void RunAsync(Action<ProgressDelegate> task, Action callback) { }

	private void Update() { }

}

