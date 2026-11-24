namespace SYBO.Common.Visuals;

public class MeshCombiner : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<ComponentPositionWrapper<CombineableMesh>> <>9__12_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SortCombineableMeshes>b__12_0(ComponentPositionWrapper<CombineableMesh> x, ComponentPositionWrapper<CombineableMesh> y) { }

	}

	private const int MAX_MESH_VERTEX_COUNT = 65534; //Field offset: 0x0
	private const int MAX_BATCH_VERTEX_COUNT = 65534; //Field offset: 0x0
	private bool _initialized; //Field offset: 0xC
	private CombineableMesh[] combineableMeshes; //Field offset: 0x10
	private Transform _combinedMeshRootTransform; //Field offset: 0x14
	private int _combinedMeshesCount; //Field offset: 0x18

	public MeshCombiner() { }

	private void Awake() { }

	public void Combine() { }

	private void Combine(bool combineInactive) { }

	private void Combine(GameObject combinedMeshAssignGO, IList<ObjectModelInfo> meshInfos) { }

	public void CombineInactive() { }

	public void DestroyCombined() { }

	private GameObject GetCombinedMeshGO() { }

	private void InitializeCheck() { }

	private void SortCombineableMeshes() { }

}

