namespace UnityEngine;

internal class GlobalJavaObjectRef
{
	private bool m_disposed; //Field offset: 0x8
	protected nint m_jobject; //Field offset: 0xC

	public GlobalJavaObjectRef(nint jobject) { }

	public void Dispose() { }

	protected override void Finalize() { }

	public static nint op_Implicit(GlobalJavaObjectRef obj) { }

}

