//Type is in global namespace

public class TypewriterEffect : MonoBehaviour
{
	private struct FadeEntry
	{
		public int index; //Field offset: 0x0
		public string text; //Field offset: 0x4
		public float alpha; //Field offset: 0x8

	}

	public static TypewriterEffect current; //Field offset: 0x0
	public int charsPerSecond; //Field offset: 0xC
	public float fadeInTime; //Field offset: 0x10
	public float delayOnPeriod; //Field offset: 0x14
	public float delayOnNewLine; //Field offset: 0x18
	public UIScrollView scrollView; //Field offset: 0x1C
	public bool keepFullDimensions; //Field offset: 0x20
	public List<EventDelegate> onFinished; //Field offset: 0x24
	private UILabel mLabel; //Field offset: 0x28
	private string mFullText; //Field offset: 0x2C
	private int mCurrentOffset; //Field offset: 0x30
	private float mNextChar; //Field offset: 0x34
	private bool mReset; //Field offset: 0x38
	private bool mActive; //Field offset: 0x39
	private BetterList<FadeEntry> mFade; //Field offset: 0x3C

	public bool isActive
	{
		 get { } //Length: 79
	}

	public TypewriterEffect() { }

	public void Finish() { }

	public bool get_isActive() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void ResetToBeginning() { }

	private void Update() { }

}

