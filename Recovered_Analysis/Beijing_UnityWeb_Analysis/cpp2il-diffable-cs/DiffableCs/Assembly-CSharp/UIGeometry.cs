//Type is in global namespace

public class UIGeometry
{
	public delegate OnCustomWrite
	{

		public OnCustomWrite(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2) { }

	}

	public List<Vector3> verts; //Field offset: 0x8
	public List<Vector2> uvs; //Field offset: 0xC
	public List<Color> cols; //Field offset: 0x10
	public OnCustomWrite onCustomWrite; //Field offset: 0x14
	private List<Vector3> mRtpVerts; //Field offset: 0x18
	private Vector3 mRtpNormal; //Field offset: 0x1C
	private Vector4 mRtpTan; //Field offset: 0x28

	public bool hasTransformed
	{
		 get { } //Length: 55
	}

	public bool hasVertices
	{
		 get { } //Length: 118
	}

	public UIGeometry() { }

	public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true) { }

	public void Clear() { }

	public bool get_hasTransformed() { }

	public bool get_hasVertices() { }

	public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2) { }

}

