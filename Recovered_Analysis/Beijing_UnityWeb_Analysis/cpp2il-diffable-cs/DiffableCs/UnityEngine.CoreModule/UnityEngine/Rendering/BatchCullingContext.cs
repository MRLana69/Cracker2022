namespace UnityEngine.Rendering;

public struct BatchCullingContext
{
	public readonly NativeArray<Plane> cullingPlanes; //Field offset: 0x0
	public NativeArray<BatchVisibility> batchVisibility; //Field offset: 0xC
	public NativeArray<int> visibleIndices; //Field offset: 0x18
	public readonly LODParameters lodParameters; //Field offset: 0x24

	public BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters) { }

}

