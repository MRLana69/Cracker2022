//Type is in global namespace

public class UISlider : UIProgressBar
{
	private enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2,
	}

	private Transform foreground; //Field offset: 0x40
	private float rawValue; //Field offset: 0x44
	private Direction direction; //Field offset: 0x48
	protected bool mInverted; //Field offset: 0x4C

	public bool inverted
	{
		 get { } //Length: 185
		 set { } //Length: 423
	}

	public bool isColliderEnabled
	{
		 get { } //Length: 683
	}

	public float sliderValue
	{
		 get { } //Length: 6
		 set { } //Length: 268
	}

	public UISlider() { }

	public bool get_inverted() { }

	public bool get_isColliderEnabled() { }

	public float get_sliderValue() { }

	protected void OnDragBackground(GameObject go, Vector2 delta) { }

	protected void OnDragForeground(GameObject go, Vector2 delta) { }

	public override void OnPan(Vector2 delta) { }

	protected void OnPressBackground(GameObject go, bool isPressed) { }

	protected void OnPressForeground(GameObject go, bool isPressed) { }

	protected override void OnStart() { }

	public void set_inverted(bool value) { }

	public void set_sliderValue(float value) { }

	protected override void Upgrade() { }

}

