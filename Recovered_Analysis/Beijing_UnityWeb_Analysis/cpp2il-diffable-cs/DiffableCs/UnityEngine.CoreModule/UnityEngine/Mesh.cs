namespace UnityEngine;

public sealed class Mesh : Object
{
	internal enum InternalVertexChannelType
	{
		Float = 0,
		Color = 2,
	}


	public int blendShapeCount
	{
		 get { } //Length: 49
	}

	internal bool canAccess
	{
		 get { } //Length: 49
	}

	public Color32[] colors32
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public Vector3[] normals
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public int subMeshCount
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Vector4[] tangents
	{
		 get { } //Length: 51
	}

	public int[] triangles
	{
		 get { } //Length: 55
		 set { } //Length: 57
	}

	public Vector2[] uv
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public Vector2[] uv2
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public Vector2[] uv3
	{
		 get { } //Length: 51
	}

	public Vector2[] uv4
	{
		 get { } //Length: 51
	}

	public int vertexCount
	{
		 get { } //Length: 49
	}

	public Vector3[] vertices
	{
		 get { } //Length: 145
		 set { } //Length: 53
	}

	public Mesh() { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	public void Clear() { }

	private void ClearImpl(bool keepVertexLayout) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	public int get_blendShapeCount() { }

	internal bool get_canAccess() { }

	public Color32[] get_colors32() { }

	public Vector3[] get_normals() { }

	public int get_subMeshCount() { }

	public Vector4[] get_tangents() { }

	public int[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_uv2() { }

	public Vector2[] get_uv3() { }

	public Vector2[] get_uv4() { }

	public int get_vertexCount() { }

	public Vector3[] get_vertices() { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, InternalVertexChannelType format, int dim) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, InternalVertexChannelType format, int dim) { }

	public int[] GetIndices(int submesh) { }

	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	public int[] GetTriangles(int submesh) { }

	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	internal VertexAttribute GetUVChannel(int uvIndex) { }

	internal bool HasChannel(VertexAttribute ch) { }

	private static void Internal_Create(Mesh mono) { }

	public void MarkDynamic() { }

	private void MarkDynamicImpl() { }

	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	public void RecalculateBounds() { }

	private void RecalculateBoundsImpl() { }

	public void set_colors32(Color32[] value) { }

	public void set_normals(Vector3[] value) { }

	public void set_subMeshCount(int value) { }

	public void set_triangles(int[] value) { }

	public void set_uv(Vector2[] value) { }

	public void set_uv2(Vector2[] value) { }

	public void set_vertices(Vector3[] value) { }

	private void SetArrayForChannel(VertexAttribute channel, T[] values) { }

	private void SetArrayForChannel(VertexAttribute channel, InternalVertexChannelType format, int dim, T[] values) { }

	private void SetArrayForChannelImpl(VertexAttribute channel, InternalVertexChannelType format, int dim, Array values, int arraySize) { }

	public void SetColors(List<Color> inColors) { }

	public void SetColors(List<Color32> inColors) { }

	private void SetIndicesImpl(int submesh, MeshTopology topology, Array indices, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, InternalVertexChannelType format, int dim, List<T> values) { }

	private void SetListForChannel(VertexAttribute channel, List<T> values) { }

	public void SetNormals(List<Vector3> inNormals) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, InternalVertexChannelType format, int dim, Array values, int valuesCount) { }

	public void SetTangents(List<Vector4> inTangents) { }

	public void SetTriangles(int[] triangles, int submesh) { }

	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List<int> triangles, int submesh) { }

	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	private void SetTrianglesImpl(int submesh, Array triangles, int arraySize, bool calculateBounds, int baseVertex) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	public void SetUVs(int channel, List<Vector2> uvs) { }

	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs) { }

	public void SetVertices(List<Vector3> inVertices) { }

}

