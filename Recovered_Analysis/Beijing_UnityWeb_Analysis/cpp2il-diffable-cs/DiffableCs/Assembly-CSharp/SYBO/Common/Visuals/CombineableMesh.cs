namespace SYBO.Common.Visuals;

public class CombineableMesh : MonoBehaviour
{
	private sealed class <CombineMeshesAsync>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public IList<CombineableMesh> combineableMeshes; //Field offset: 0x10
		public CombineableMesh <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 198
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CombineMeshesAsync>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const int CombineableMeshVertexLimit = 4000; //Field offset: 0x0
	private bool _combineSubmeshesLowEndDevice; //Field offset: 0xC
	private bool _initialized; //Field offset: 0xD
	private Mesh _originalMesh; //Field offset: 0x10
	private MeshRenderer _meshRenderer; //Field offset: 0x14
	private MeshFilter _meshFilter; //Field offset: 0x18
	private MeshContainer _meshContainer; //Field offset: 0x1C
	private bool _startedMeshCombining; //Field offset: 0x20

	public MeshFilter MeshFilter
	{
		 get { } //Length: 14
	}

	public ObjectModelInfo MeshInfo
	{
		 get { } //Length: 14
	}

	public MeshRenderer MeshRenderer
	{
		 get { } //Length: 76
	}

	public CombineableMesh() { }

	private void Awake() { }

	private IEnumerator CombineMeshesAsync(IList<CombineableMesh> combineableMeshes) { }

	public MeshFilter get_MeshFilter() { }

	public ObjectModelInfo get_MeshInfo() { }

	public MeshRenderer get_MeshRenderer() { }

	private void InitializeCheck() { }

	private void MergeSubmeshes() { }

	private void UpdateToCombinedMesh(ModelInfo combinedMesh) { }

}

