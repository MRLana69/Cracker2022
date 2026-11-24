namespace UnityEngine;

public class AsyncOperation : YieldInstruction
{
	internal nint m_Ptr; //Field offset: 0x8
	private Action<AsyncOperation> m_completeCallback; //Field offset: 0xC

	public bool allowSceneActivation
	{
		 set { } //Length: 20
	}

	public bool isDone
	{
		 get { } //Length: 77
	}

	public float progress
	{
		 get { } //Length: 12
	}

	public AsyncOperation() { }

	protected override void Finalize() { }

	public bool get_isDone() { }

	public float get_progress() { }

	private static void InternalDestroy(nint ptr) { }

	internal void InvokeCompletionEvent() { }

	public void set_allowSceneActivation(bool value) { }

}

