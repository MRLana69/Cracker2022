namespace UnityEngine;

public class TrackedReference
{
	internal nint m_Ptr; //Field offset: 0x8

	protected TrackedReference() { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

	public static bool op_Implicit(TrackedReference exists) { }

	public static bool op_Inequality(TrackedReference x, TrackedReference y) { }

}

