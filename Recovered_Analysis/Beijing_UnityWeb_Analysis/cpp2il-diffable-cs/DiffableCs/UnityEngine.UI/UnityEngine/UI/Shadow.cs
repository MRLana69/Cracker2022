namespace UnityEngine.UI;

public class Shadow : BaseMeshEffect
{
	private const float kMaxEffectDistance = 600; //Field offset: 0x0
	private Color m_EffectColor; //Field offset: 0x10
	private Vector2 m_EffectDistance; //Field offset: 0x20
	private bool m_UseGraphicAlpha; //Field offset: 0x28

	public Color effectColor
	{
		 get { } //Length: 622
		 set { } //Length: 26
	}

	public Vector2 effectDistance
	{
		 get { } //Length: 164
		 set { } //Length: 11
	}

	public bool useGraphicAlpha
	{
		 get { } //Length: 114
		 set { } //Length: 451
	}

	protected Shadow() { }

	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	public Color get_effectColor() { }

	public Vector2 get_effectDistance() { }

	public bool get_useGraphicAlpha() { }

	public override void ModifyMesh(VertexHelper vh) { }

	public void set_effectColor(Color value) { }

	public void set_effectDistance(Vector2 value) { }

	public void set_useGraphicAlpha(bool value) { }

}

