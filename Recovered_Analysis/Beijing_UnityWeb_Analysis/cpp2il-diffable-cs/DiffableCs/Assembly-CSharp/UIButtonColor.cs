//Type is in global namespace

public class UIButtonColor : UIWidgetContainer
{
	public enum State
	{
		Normal = 0,
		Hover = 1,
		Pressed = 2,
		Disabled = 3,
	}

	public GameObject tweenTarget; //Field offset: 0xC
	public Color hover; //Field offset: 0x10
	public Color pressed; //Field offset: 0x20
	public Color disabledColor; //Field offset: 0x30
	public float duration; //Field offset: 0x40
	protected Color mStartingColor; //Field offset: 0x44
	protected Color mDefaultColor; //Field offset: 0x54
	protected bool mInitDone; //Field offset: 0x64
	protected UIWidget mWidget; //Field offset: 0x68
	protected State mState; //Field offset: 0x6C

	public Color defaultColor
	{
		 get { } //Length: 13
		 set { } //Length: 44
	}

	public virtual bool isEnabled
	{
		 get { } //Length: 6
		 set { } //Length: 105
	}

	public State state
	{
		 get { } //Length: 24
		 set { } //Length: 229
	}

	public UIButtonColor() { }

	public void CacheDefaultColor() { }

	public Color get_defaultColor() { }

	public virtual bool get_isEnabled() { }

	public State get_state() { }

	protected virtual void OnDisable() { }

	protected virtual void OnDragOut() { }

	protected virtual void OnDragOver() { }

	protected virtual void OnEnable() { }

	protected virtual void OnHover(bool isOver) { }

	protected virtual void OnInit() { }

	protected virtual void OnPress(bool isPressed) { }

	public void ResetDefaultColor() { }

	public void set_defaultColor(Color value) { }

	public virtual void set_isEnabled(bool value) { }

	public void set_state(State value) { }

	public virtual void SetState(State state, bool instant) { }

	private void Start() { }

	public void UpdateColor(bool instant) { }

}

