namespace UnityEngine;

public struct CharacterInfo
{
	public int index; //Field offset: 0x0
	public Rect uv; //Field offset: 0x4
	public Rect vert; //Field offset: 0x14
	public float width; //Field offset: 0x24
	public int size; //Field offset: 0x28
	public FontStyle style; //Field offset: 0x2C
	public bool flipped; //Field offset: 0x30

	public int advance
	{
		 get { } //Length: 49
	}

	public int maxX
	{
		 get { } //Length: 12
	}

	public int maxY
	{
		 get { } //Length: 12
	}

	public int minX
	{
		 get { } //Length: 12
	}

	public int minY
	{
		 get { } //Length: 12
	}

	public Vector2 uvBottomLeft
	{
		 get { } //Length: 14
	}

	internal Vector2 uvBottomLeftUnFlipped
	{
		 get { } //Length: 53
	}

	public Vector2 uvBottomRight
	{
		 get { } //Length: 14
	}

	internal Vector2 uvBottomRightUnFlipped
	{
		 get { } //Length: 14
	}

	public Vector2 uvTopLeft
	{
		 get { } //Length: 14
	}

	internal Vector2 uvTopLeftUnFlipped
	{
		 get { } //Length: 14
	}

	public Vector2 uvTopRight
	{
		 get { } //Length: 14
	}

	internal Vector2 uvTopRightUnFlipped
	{
		 get { } //Length: 14
	}

	public int get_advance() { }

	public int get_maxX() { }

	public int get_maxY() { }

	public int get_minX() { }

	public int get_minY() { }

	public Vector2 get_uvBottomLeft() { }

	internal Vector2 get_uvBottomLeftUnFlipped() { }

	public Vector2 get_uvBottomRight() { }

	internal Vector2 get_uvBottomRightUnFlipped() { }

	public Vector2 get_uvTopLeft() { }

	internal Vector2 get_uvTopLeftUnFlipped() { }

	public Vector2 get_uvTopRight() { }

	internal Vector2 get_uvTopRightUnFlipped() { }

}

