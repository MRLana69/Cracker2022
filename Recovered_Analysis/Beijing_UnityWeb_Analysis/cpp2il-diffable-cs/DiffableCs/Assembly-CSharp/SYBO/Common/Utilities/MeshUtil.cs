namespace SYBO.Common.Utilities;

public static class MeshUtil
{
	private sealed class <>c__DisplayClass4_0
	{
		public ModelInfo cobinedMesh; //Field offset: 0x8

		public <>c__DisplayClass4_0() { }

		internal void <CombineMeshes>b__0(ModelInfo cm) { }

	}

	private sealed class <CombineMeshesAsync>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Action<ModelInfo> meshReceiveCallback; //Field offset: 0x10
		public GameObject parentGO; //Field offset: 0x14
		public IList<ObjectModelInfo> meshInfos; //Field offset: 0x18
		private Dictionary<MeshFilter, Matrix4x4> <localPosMapping>5__2; //Field offset: 0x1C
		private Matrix4x4 <goWorldToLocalMatrix>5__3; //Field offset: 0x20
		private List<Vector3> <cVertices>5__4; //Field offset: 0x60
		private List<Vector3> <cNormals>5__5; //Field offset: 0x64
		private List<Color32> <cColors>5__6; //Field offset: 0x68
		private List<Vector2> <cUV1s>5__7; //Field offset: 0x6C
		private List<Vector2> <cUV2s>5__8; //Field offset: 0x70
		private Dictionary<Material, List<int>> <cSubMeshes>5__9; //Field offset: 0x74
		private int <i>5__10; //Field offset: 0x78

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 2579
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CombineMeshesAsync>d__6(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CombineMeshesAsync>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public IList<ObjectModelInfo> meshInfos; //Field offset: 0x10
		public GameObject parentGO; //Field offset: 0x14
		public Action<ModelInfo[]> meshReceiveCallback; //Field offset: 0x18
		private Matrix4x4 <goWorldToLocalMatrix>5__2; //Field offset: 0x1C
		private List<Vector3> <cVertices>5__3; //Field offset: 0x5C
		private List<Vector3> <cNormals>5__4; //Field offset: 0x60
		private List<Vector2> <cUV1s>5__5; //Field offset: 0x64
		private List<Vector2> <cUV2s>5__6; //Field offset: 0x68
		private List<int> <cTriangles>5__7; //Field offset: 0x6C
		private Dictionary<int, int> <oldToNewVertsIDs>5__8; //Field offset: 0x70
		private int <cmi>5__9; //Field offset: 0x74
		private ModelInfo[] <combinedMeshes>5__10; //Field offset: 0x78
		private Enumerator<Material, List<SubMeshInfo>> <>7__wrap10; //Field offset: 0x7C
		private KeyValuePair<Material, List<SubMeshInfo>> <kvp>5__12; //Field offset: 0x94
		private List<SubMeshInfo> <subMeshInfos>5__13; //Field offset: 0x9C
		private int <i>5__14; //Field offset: 0xA0

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 5911
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CombineMeshesAsync>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	public static ModelInfo CombineMeshes(GameObject parentGO, IList<MeshRenderer> meshRenderers) { }

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<CombineableMesh> combineableMeshes) { }

	public static ModelInfo CombineMeshes(GameObject parentGO, IList<ObjectModelInfo> meshInfos) { }

	public static ModelInfo CombineMeshes(GameObject parentGO, bool combineInactive) { }

	public static ModelInfo CombineMeshes(GameObject go) { }

	public static IEnumerator CombineMeshesAsync(GameObject parentGO, IList<ObjectModelInfo> meshInfos, Action<ModelInfo> meshReceiveCallback) { }

	public static IEnumerator CombineMeshesAsync(GameObject parentGO, IList<ObjectModelInfo> meshInfos, Action<ModelInfo[]> meshReceiveCallback = null) { }

	public static IList<ObjectModelInfo> GetMeshInfos(IList<CombineableMesh> combineableMeshes) { }

	public static IList<ObjectModelInfo> GetMeshInfos(IList<MeshRenderer> meshRenderers) { }

	private static void MergeMeshInto(Mesh mesh, Material[] materials, Matrix4x4 transformMatrix, List<Vector3> cVertices, List<Vector3> cNormals, List<Color32> cColors, List<Vector2> cUV1s, List<Vector2> cUV2s, Dictionary<Material, List<int>> cSubMeshes) { }

	private static void MergeSubmeshInto(Mesh mesh, int submeshIndex, Matrix4x4 transformMatrix, List<Vector3> cVertices, List<Vector3> cNormals, List<Vector2> cUV1s, List<Vector2> cUV2s, List<int> cTriangles, Dictionary<int, int> oldToNewVertIDs) { }

}

