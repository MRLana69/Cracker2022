namespace Kiloo.Common.Utility;

public class ActionQueue
{
	private sealed class <>c__DisplayClass8_0
	{
		public ActionQueue <>4__this; //Field offset: 0x8
		public Action callback; //Field offset: 0xC

		public <>c__DisplayClass8_0() { }

	}

	private sealed class <>c__DisplayClass8_1
	{
		public LinkedListNode<Action<Action>> element; //Field offset: 0x8
		public Action recursiveAction; //Field offset: 0xC
		public <>c__DisplayClass8_0 CS$<>8__locals1; //Field offset: 0x10

		public <>c__DisplayClass8_1() { }

		internal void <RunSequentially>b__0() { }

	}

	private sealed class <>c__DisplayClass9_0
	{
		public ActionQueue <>4__this; //Field offset: 0x8
		public Action callback; //Field offset: 0xC

		public <>c__DisplayClass9_0() { }

	}

	private sealed class <>c__DisplayClass9_1
	{
		public int size; //Field offset: 0x8
		public <>c__DisplayClass9_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass9_1() { }

	}

	private sealed class <>c__DisplayClass9_2
	{
		public int index; //Field offset: 0x8
		public <>c__DisplayClass9_1 CS$<>8__locals2; //Field offset: 0xC

		public <>c__DisplayClass9_2() { }

		internal void <RunParallel>b__0() { }

	}

	private readonly LinkedList<Action<Action>> actionQueue; //Field offset: 0x8
	private bool _running; //Field offset: 0xC

	public int Count
	{
		 get { } //Length: 1713
	}

	public ActionQueue() { }

	public void AddAction(Action<Action> action) { }

	public void AddAllActionsFromQueue(ActionQueue queue) { }

	public void AddAndRunSequentially(Action<Action> action) { }

	public void Clear() { }

	public int get_Count() { }

	public void RunParallel(Action callback = null) { }

	public void RunSequentially(Action callback = null) { }

}

