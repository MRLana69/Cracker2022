namespace System;

public abstract class MulticastDelegate : Delegate
{
	private Delegate[] delegates; //Field offset: 0x34

	protected sealed override Delegate CombineImpl(Delegate follow) { }

	public sealed override bool Equals(object obj) { }

	public sealed override int GetHashCode() { }

	public sealed override Delegate[] GetInvocationList() { }

	protected override MethodInfo GetMethodImpl() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

