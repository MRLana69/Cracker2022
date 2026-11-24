namespace UnityEngine.UI;

public class RawImage : MaskableGraphic
{
	private Texture m_Texture; //Field offset: 0x6C
	private Rect m_UVRect; //Field offset: 0x70

	public override Texture mainTexture
	{
		 get { } //Length: 9
	}

	public Texture texture
	{
		 get { } //Length: 286
		 set { } //Length: 11
	}

	public Rect uvRect
	{
		 get { } //Length: 115
		 set { } //Length: 27
	}

	protected RawImage() { }

	public override Texture get_mainTexture() { }

	public Texture get_texture() { }

	public Rect get_uvRect() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void set_texture(Texture value) { }

	public void set_uvRect(Rect value) { }

	public override void SetNativeSize() { }

}

