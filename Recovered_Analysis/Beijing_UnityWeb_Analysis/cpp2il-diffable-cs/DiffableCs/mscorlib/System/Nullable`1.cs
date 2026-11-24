namespace System;

public struct Nullable`1
{
	internal T value; //Field offset: 0x0
	internal bool has_value; //Field offset: 0x0

	public bool HasValue
	{
		 get { } //Length: 84
	}

	public T Value
	{
		 get { } //Length: 93
	}

	public Nullable`1(T value) { }

	private static object Box(Nullable<T> o) { }

	public override bool Equals(object other) { }

	private bool Equals(Nullable<T> other) { }

	public bool get_HasValue() { }

	public T get_Value() { }

	public override int GetHashCode() { }

	public T GetValueOrDefault() { }

	public override string ToString() { }

	private static Nullable<T> Unbox(object o) { }

}

