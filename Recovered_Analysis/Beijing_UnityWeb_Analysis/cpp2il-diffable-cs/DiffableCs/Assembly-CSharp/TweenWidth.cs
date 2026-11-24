//Type is in global namespace

public class TweenWidth : UITweener
{
	public int from; //Field offset: 0x58
	public int to; //Field offset: 0x5C
	public bool updateTable; //Field offset: 0x60
	private UIWidget mWidget; //Field offset: 0x64
	private UITable mTable; //Field offset: 0x68

	public UIWidget cachedWidget
	{
		 get { } //Length: 304
	}

	public int value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int width
	{
		 get { } //Length: 115
		 set { } //Length: 46
	}

	public TweenWidth() { }

	public static TweenWidth Begin(UIWidget widget, float duration, int width) { }

	public UIWidget get_cachedWidget() { }

	public int get_value() { }

	public int get_width() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_value(int value) { }

	public void set_width(int value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

