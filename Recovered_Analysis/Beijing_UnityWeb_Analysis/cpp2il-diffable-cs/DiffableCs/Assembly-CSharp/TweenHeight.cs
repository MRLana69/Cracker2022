//Type is in global namespace

public class TweenHeight : UITweener
{
	public int from; //Field offset: 0x58
	public int to; //Field offset: 0x5C
	public bool updateTable; //Field offset: 0x60
	private UIWidget mWidget; //Field offset: 0x64
	private UITable mTable; //Field offset: 0x68

	public UIWidget cachedWidget
	{
		 get { } //Length: 115
	}

	public int height
	{
		 get { } //Length: 115
		 set { } //Length: 534
	}

	public int value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public TweenHeight() { }

	public static TweenHeight Begin(UIWidget widget, float duration, int height) { }

	public UIWidget get_cachedWidget() { }

	public int get_height() { }

	public int get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_height(int value) { }

	public void set_value(int value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

