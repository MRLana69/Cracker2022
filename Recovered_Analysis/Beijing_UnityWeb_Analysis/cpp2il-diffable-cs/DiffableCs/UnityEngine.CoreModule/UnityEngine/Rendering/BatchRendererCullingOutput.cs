namespace UnityEngine.Rendering;

internal struct BatchRendererCullingOutput
{
	public JobHandle cullingJobsFence; //Field offset: 0x0
	public Plane* cullingPlanes; //Field offset: 0x8
	public BatchVisibility* batchVisibility; //Field offset: 0xC
	public int* visibleIndices; //Field offset: 0x10
	public int cullingPlanesCount; //Field offset: 0x14
	public int batchVisibilityCount; //Field offset: 0x18
	public int visibleIndicesCount; //Field offset: 0x1C

}

