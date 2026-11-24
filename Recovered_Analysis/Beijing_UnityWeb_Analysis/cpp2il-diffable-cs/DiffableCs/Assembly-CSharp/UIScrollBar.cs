//Type is in global namespace

public class UIScrollBar : UISlider
{
	private enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2,
	}

	protected float mSize; //Field offset: 0x50
	private float mScroll; //Field offset: 0x54
	private Direction mDir; //Field offset: 0x58

	public float barSize
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float scrollValue
	{
		 get { } //Length: 184
		 set { } //Length: 930
	}

	public UIScrollBar() { }

	public override void ForceUpdate() { }

	public float get_barSize() { }

	public float get_scrollValue() { }

	protected override float LocalToValue(Vector2 localPos) { }

	protected override void OnStart() { }

	public void set_barSize(float value) { }

	public void set_scrollValue(float value) { }

	protected override void Upgrade() { }

}

