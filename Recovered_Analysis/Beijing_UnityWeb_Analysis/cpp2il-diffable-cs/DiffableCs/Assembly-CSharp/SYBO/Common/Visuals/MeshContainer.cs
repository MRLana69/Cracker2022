namespace SYBO.Common.Visuals;

public class MeshContainer
{
	private Dictionary<Mesh, ModelInfo> _combinedMeshes; //Field offset: 0x10
	private Dictionary<Mesh, Action<ModelInfo>> _combinedMeshCallbacks; //Field offset: 0x14
	private Dictionary<CombineableMeshGroup, ModelInfo> _combinedMeshesGroups; //Field offset: 0x18
	private Dictionary<CombineableMeshGroup, Action<ModelInfo>> _combinedMeshGroupCallbacks; //Field offset: 0x1C

	public MeshContainer() { }

	public void AddGroup(CombineableMeshGroup combineableMeshGroup, ModelInfo combinedMeshInfo) { }

	public void AddMesh(Mesh originalMesh, ModelInfo combinedMeshInfo) { }

	public void AddMeshGroupCombinedCallback(CombineableMeshGroup meshGroup, Action<ModelInfo> meshReceiveCallback) { }

	public void AddMeshGroupCombinedCallback(Mesh mesh, Action<ModelInfo> meshReceiveCallback) { }

	public bool HasCombinedMesh(Mesh originalMesh) { }

	public bool HasGroupMesh(CombineableMeshGroup combineableMeshGroup) { }

	public bool IsMeshCombineInProgress(Mesh mesh) { }

	public bool IsMeshGroupCombineInProgress(CombineableMeshGroup meshGroup) { }

	public void NotifyMeshCombineFailed(Mesh mesh) { }

	public void NotifyMeshCombineInProgress(Mesh mesh) { }

	public void NotifyMeshGroupCombineCanceled(CombineableMeshGroup meshGroup) { }

	public void NotifyMeshGroupCombineInProgress(CombineableMeshGroup meshGroup) { }

	public void RemoveGroup(CombineableMeshGroup combineableMeshGroup) { }

	public void RemoveMesh(Mesh originalMesh) { }

	public void RemoveMeshCombinedCallback(Mesh mesh, Action<ModelInfo> meshReceiveCallback) { }

	public void RemoveMeshGroupCombinedCallback(CombineableMeshGroup meshGroup, Action<ModelInfo> meshReceiveCallback) { }

	protected override void SubclassInitialize() { }

	public bool TryGetGroupMesh(CombineableMeshGroup combineableMeshGroup, out ModelInfo combinedMeshInfo) { }

	public bool TryGetMesh(Mesh originalMesh, out ModelInfo combinedMeshInfo) { }

}

