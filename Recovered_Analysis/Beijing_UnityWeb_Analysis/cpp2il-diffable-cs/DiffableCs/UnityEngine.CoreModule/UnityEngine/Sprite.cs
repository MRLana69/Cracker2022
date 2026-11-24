namespace UnityEngine;

public sealed class Sprite : Object
{

	public Texture2D associatedAlphaSplitTexture
	{
		 get { } //Length: 49
	}

	public Vector4 border
	{
		 get { } //Length: 60
	}

	public Bounds bounds
	{
		 get { } //Length: 60
	}

	public bool packed
	{
		 get { } //Length: 49
	}

	public SpritePackingMode packingMode
	{
		 get { } //Length: 12
	}

	public Vector2 pivot
	{
		 get { } //Length: 60
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 6
	}

	public Rect rect
	{
		 get { } //Length: 77
	}

	public Texture2D texture
	{
		 get { } //Length: 49
	}

	public Rect textureRect
	{
		 get { } //Length: 43
	}

	public Vector2 textureRectOffset
	{
		 get { } //Length: 100
	}

	public ushort[] triangles
	{
		 get { } //Length: 49
	}

	public Vector2[] uv
	{
		 get { } //Length: 49
	}

	public Vector2[] vertices
	{
		 get { } //Length: 9
	}

	private Sprite() { }

	public Texture2D get_associatedAlphaSplitTexture() { }

	public Vector4 get_border() { }

	private void get_border_Injected(out Vector4 ret) { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_packed() { }

	public SpritePackingMode get_packingMode() { }

	public Vector2 get_pivot() { }

	private void get_pivot_Injected(out Vector2 ret) { }

	public float get_pixelsPerUnit() { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public Texture2D get_texture() { }

	public Rect get_textureRect() { }

	public Vector2 get_textureRectOffset() { }

	public ushort[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_vertices() { }

	internal Vector4 GetInnerUVs() { }

	private void GetInnerUVs_Injected(out Vector4 ret) { }

	internal Vector4 GetOuterUVs() { }

	private void GetOuterUVs_Injected(out Vector4 ret) { }

	internal int GetPacked() { }

	internal int GetPackingMode() { }

	internal Vector4 GetPadding() { }

	private void GetPadding_Injected(out Vector4 ret) { }

	internal Rect GetTextureRect() { }

	private void GetTextureRect_Injected(out Rect ret) { }

	internal Vector2 GetTextureRectOffset() { }

	private void GetTextureRectOffset_Injected(out Vector2 ret) { }

}

