namespace UnityEngine.UI;

public struct SpriteState : IEquatable<SpriteState>
{
	private Sprite m_HighlightedSprite; //Field offset: 0x0
	private Sprite m_PressedSprite; //Field offset: 0x4
	private Sprite m_SelectedSprite; //Field offset: 0x8
	private Sprite m_DisabledSprite; //Field offset: 0xC

	public Sprite disabledSprite
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Sprite highlightedSprite
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public Sprite pressedSprite
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Sprite selectedSprite
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool Equals(SpriteState other) { }

	public Sprite get_disabledSprite() { }

	public Sprite get_highlightedSprite() { }

	public Sprite get_pressedSprite() { }

	public Sprite get_selectedSprite() { }

	public void set_disabledSprite(Sprite value) { }

	public void set_highlightedSprite(Sprite value) { }

	public void set_pressedSprite(Sprite value) { }

	public void set_selectedSprite(Sprite value) { }

}

