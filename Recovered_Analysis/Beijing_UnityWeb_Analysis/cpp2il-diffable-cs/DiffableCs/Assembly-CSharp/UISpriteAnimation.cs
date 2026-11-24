//Type is in global namespace

public class UISpriteAnimation : MonoBehaviour
{
	public int frameIndex; //Field offset: 0xC
	protected int mFPS; //Field offset: 0x10
	protected string mPrefix; //Field offset: 0x14
	protected bool mLoop; //Field offset: 0x18
	protected bool mSnap; //Field offset: 0x19
	protected UISprite mSprite; //Field offset: 0x1C
	protected float mDelta; //Field offset: 0x20
	protected bool mActive; //Field offset: 0x24
	protected List<string> mSpriteNames; //Field offset: 0x28

	public int frames
	{
		 get { } //Length: 368
	}

	public int framesPerSecond
	{
		 get { } //Length: 52
		 set { } //Length: 132
	}

	public bool isPlaying
	{
		 get { } //Length: 9
	}

	public bool loop
	{
		 get { } //Length: 6
		 set { } //Length: 35
	}

	public string namePrefix
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public UISpriteAnimation() { }

	public int get_frames() { }

	public int get_framesPerSecond() { }

	public bool get_isPlaying() { }

	public bool get_loop() { }

	public string get_namePrefix() { }

	public void Pause() { }

	public void Play() { }

	public void RebuildSpriteList() { }

	public void ResetToBeginning() { }

	public void set_framesPerSecond(int value) { }

	public void set_loop(bool value) { }

	public void set_namePrefix(string value) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

