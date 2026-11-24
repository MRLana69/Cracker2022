//Type is in global namespace

public class UIButton : UIButtonColor
{
	public static UIButton current; //Field offset: 0x0
	public bool dragHighlight; //Field offset: 0x70
	public string hoverSprite; //Field offset: 0x74
	public string pressedSprite; //Field offset: 0x78
	public string disabledSprite; //Field offset: 0x7C
	public Sprite hoverSprite2D; //Field offset: 0x80
	public Sprite pressedSprite2D; //Field offset: 0x84
	public Sprite disabledSprite2D; //Field offset: 0x88
	public bool pixelSnap; //Field offset: 0x8C
	public List<EventDelegate> onClick; //Field offset: 0x90
	private UISprite mSprite; //Field offset: 0x94
	private UI2DSprite mSprite2D; //Field offset: 0x98
	private string mNormalSprite; //Field offset: 0x9C
	private Sprite mNormalSprite2D; //Field offset: 0xA0

	public override bool isEnabled
	{
		 get { } //Length: 9
		 set { } //Length: 110
	}

	public string normalSprite
	{
		 get { } //Length: 208
		 set { } //Length: 389
	}

	public Sprite normalSprite2D
	{
		 get { } //Length: 24
		 set { } //Length: 258
	}

	public UIButton() { }

	public override bool get_isEnabled() { }

	public string get_normalSprite() { }

	public Sprite get_normalSprite2D() { }

	protected virtual void OnClick() { }

	protected override void OnDragOut() { }

	protected override void OnDragOver() { }

	protected override void OnEnable() { }

	protected override void OnInit() { }

	public override void set_isEnabled(bool value) { }

	public void set_normalSprite(string value) { }

	public void set_normalSprite2D(Sprite value) { }

	protected void SetSprite(string sp) { }

	protected void SetSprite(Sprite sp) { }

	public override void SetState(State state, bool immediate) { }

}

