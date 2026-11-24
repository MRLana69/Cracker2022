namespace System.Collections;

public class Stack : ICollection, IEnumerable, ICloneable
{
	internal class StackDebugView
	{

	}

	private class StackEnumerator : IEnumerator, ICloneable
	{
		private Stack _stack; //Field offset: 0x8
		private int _index; //Field offset: 0xC
		private int _version; //Field offset: 0x10
		private object currentElement; //Field offset: 0x14

		public virtual object Current
		{
			 get { } //Length: 258
		}

		internal StackEnumerator(Stack stack) { }

		public object Clone() { }

		public virtual object get_Current() { }

		public virtual bool MoveNext() { }

		public virtual void Reset() { }

	}

	private object[] _array; //Field offset: 0x8
	private int _size; //Field offset: 0xC
	private int _version; //Field offset: 0x10

	public virtual int Count
	{
		 get { } //Length: 85
	}

	public Stack() { }

	public Stack(int initialCapacity) { }

	public virtual void Clear() { }

	public virtual object Clone() { }

	public virtual void CopyTo(Array array, int index) { }

	public virtual int get_Count() { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual object Peek() { }

	public virtual object Pop() { }

	public virtual void Push(object obj) { }

}

