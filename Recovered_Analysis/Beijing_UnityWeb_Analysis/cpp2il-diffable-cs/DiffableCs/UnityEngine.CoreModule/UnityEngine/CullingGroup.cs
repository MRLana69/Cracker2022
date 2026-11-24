namespace UnityEngine;

public class CullingGroup
{
	public delegate StateChanged
	{

		public StateChanged(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(CullingGroupEvent sphere) { }

	}

	internal nint m_Ptr; //Field offset: 0x8
	private StateChanged m_OnStateChanged; //Field offset: 0xC

	protected override void Finalize() { }

	private void FinalizerFailure() { }

	private static void SendEvents(CullingGroup cullingGroup, nint eventsPtr, int count) { }

}

