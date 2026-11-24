namespace System.Collections;

public class Queue : ICollection, IEnumerable, ICloneable
{
	internal class QueueDebugView
	{

	}

	private class QueueEnumerator : IEnumerator, ICloneable
	{
		private Queue _q; //Field offset: 0x8
		private int _index; //Field offset: 0xC
		private int _version; //Field offset: 0x10
		private object currentElement; //Field offset: 0x14

		public virtual object Current
		{
			 get { } //Length: 194
		}

		internal QueueEnumerator(Queue q) { }

		public object Clone() { }

		public virtual object get_Current() { }

		public virtual bool MoveNext() { }

		public virtual void Reset() { }

	}

	private object[] _array; //Field offset: 0x8
	private int _head; //Field offset: 0xC
	private int _tail; //Field offset: 0x10
	private int _size; //Field offset: 0x14
	private int _growFactor; //Field offset: 0x18
	private int _version; //Field offset: 0x1C

	public virtual int Count
	{
		 get { } //Length: 113
	}

	public Queue() { }

	public Queue(int capacity) { }

	public Queue(int capacity, float growFactor) { }

	public Queue(ICollection col) { }

	public virtual object Clone() { }

	public virtual void CopyTo(Array array, int index) { }

	public virtual object Dequeue() { }

	public virtual void Enqueue(object obj) { }

	public virtual int get_Count() { }

	internal object GetElement(int i) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual object Peek() { }

	private void SetCapacity(int capacity) { }

}

