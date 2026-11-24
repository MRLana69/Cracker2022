namespace System.Collections.Generic;

public sealed class LinkedListNode`1
{
	internal LinkedList<T> list; //Field offset: 0x0
	internal LinkedListNode<T> next; //Field offset: 0x0
	internal LinkedListNode<T> prev; //Field offset: 0x0
	internal T item; //Field offset: 0x0

	public LinkedListNode<T> Next
	{
		 get { } //Length: 12
	}

	public T Value
	{
		 get { } //Length: 37
		 set { } //Length: 11
	}

	public LinkedListNode`1(T value) { }

	internal LinkedListNode`1(LinkedList<T> list, T value) { }

	public LinkedListNode<T> get_Next() { }

	public T get_Value() { }

	internal void Invalidate() { }

	public void set_Value(T value) { }

}

