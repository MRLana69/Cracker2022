namespace UnityEngine;

public sealed class Coroutine : YieldInstruction
{
	internal nint m_Ptr; //Field offset: 0x8

	private Coroutine() { }

	protected override void Finalize() { }

	private static void ReleaseCoroutine(nint ptr) { }

}

