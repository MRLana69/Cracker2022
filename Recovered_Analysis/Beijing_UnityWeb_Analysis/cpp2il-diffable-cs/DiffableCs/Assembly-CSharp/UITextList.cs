//Type is in global namespace

public class UITextList : MonoBehaviour
{
	protected class Paragraph
	{
		public string text; //Field offset: 0x8
		public string[] lines; //Field offset: 0xC

		public Paragraph() { }

	}

	public enum Style
	{
		Text = 0,
		Chat = 1,
	}

	private static Dictionary<string, BetterList<Paragraph>> mHistory; //Field offset: 0x0
	public UILabel textLabel; //Field offset: 0xC
	public UIProgressBar scrollBar; //Field offset: 0x10
	public Style style; //Field offset: 0x14
	public int paragraphHistory; //Field offset: 0x18
	protected char[] mSeparator; //Field offset: 0x1C
	protected float mScroll; //Field offset: 0x20
	protected int mTotalLines; //Field offset: 0x24
	protected int mLastWidth; //Field offset: 0x28
	protected int mLastHeight; //Field offset: 0x2C
	private BetterList<Paragraph> mParagraphs; //Field offset: 0x30

	public bool isValid
	{
		 get { } //Length: 271
	}

	protected float lineHeight
	{
		 get { } //Length: 6
	}

	protected BetterList<Paragraph> paragraphs
	{
		 get { } //Length: 27
	}

	protected int scrollHeight
	{
		 get { } //Length: 161
	}

	public float scrollValue
	{
		 get { } //Length: 106
		 set { } //Length: 252
	}

	private static UITextList() { }

	public UITextList() { }

	protected void Add(string text, bool updateVisible) { }

	public void Add(string text) { }

	public void Clear() { }

	public bool get_isValid() { }

	protected float get_lineHeight() { }

	protected BetterList<Paragraph> get_paragraphs() { }

	protected int get_scrollHeight() { }

	public float get_scrollValue() { }

	public void OnDrag(Vector2 delta) { }

	public void OnScroll(float val) { }

	private void OnScrollBar() { }

	protected void Rebuild() { }

	public void set_scrollValue(float value) { }

	private void Start() { }

	private void Update() { }

	protected void UpdateVisibleText() { }

}

