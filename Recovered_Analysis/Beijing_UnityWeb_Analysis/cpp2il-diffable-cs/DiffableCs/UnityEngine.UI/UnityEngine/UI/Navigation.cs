namespace UnityEngine.UI;

public struct Navigation : IEquatable<Navigation>
{
	public enum Mode
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Automatic = 3,
		Explicit = 4,
	}

	private Mode m_Mode; //Field offset: 0x0
	private Selectable m_SelectOnUp; //Field offset: 0x4
	private Selectable m_SelectOnDown; //Field offset: 0x8
	private Selectable m_SelectOnLeft; //Field offset: 0xC
	private Selectable m_SelectOnRight; //Field offset: 0x10

	public static Navigation defaultNavigation
	{
		 get { } //Length: 128
	}

	public Mode mode
	{
		 get { } //Length: 571
		 set { } //Length: 524
	}

	public Selectable selectOnDown
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Selectable selectOnLeft
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Selectable selectOnRight
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Selectable selectOnUp
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool Equals(Navigation other) { }

	public static Navigation get_defaultNavigation() { }

	public Mode get_mode() { }

	public Selectable get_selectOnDown() { }

	public Selectable get_selectOnLeft() { }

	public Selectable get_selectOnRight() { }

	public Selectable get_selectOnUp() { }

	public void set_mode(Mode value) { }

	public void set_selectOnDown(Selectable value) { }

	public void set_selectOnLeft(Selectable value) { }

	public void set_selectOnRight(Selectable value) { }

	public void set_selectOnUp(Selectable value) { }

}

