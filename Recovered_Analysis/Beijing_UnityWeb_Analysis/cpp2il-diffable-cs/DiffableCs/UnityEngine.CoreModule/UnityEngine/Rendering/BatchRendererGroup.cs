namespace UnityEngine.Rendering;

public class BatchRendererGroup
{
	public delegate OnPerformCulling
	{

		public OnPerformCulling(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

		public virtual JobHandle EndInvoke(IAsyncResult result) { }

		public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	}

	private nint m_GroupHandle; //Field offset: 0x8
	private OnPerformCulling m_PerformCulling; //Field offset: 0xC

	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

