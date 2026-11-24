namespace UnityEngine.Rendering;

public static class RenderPipelineManager
{
	private static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x0
	private static RenderPipeline <currentPipeline>k__BackingField; //Field offset: 0x4

	public static RenderPipeline currentPipeline
	{
		 get { } //Length: 47
		private set { } //Length: 7
	}

	internal static void CleanupRenderPipeline() { }

	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, Camera[] cameras, nint loopPtr) { }

	public static RenderPipeline get_currentPipeline() { }

	private static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	private static void set_currentPipeline(RenderPipeline value) { }

}

