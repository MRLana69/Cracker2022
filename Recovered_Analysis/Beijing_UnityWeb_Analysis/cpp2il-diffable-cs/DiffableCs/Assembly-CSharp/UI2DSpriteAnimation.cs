//Type is in global namespace

public class UI2DSpriteAnimation : MonoBehaviour
{
	public int frameIndex; //Field offset: 0xC
	protected int framerate; //Field offset: 0x10
	public bool ignoreTimeScale; //Field offset: 0x14
	public bool loop; //Field offset: 0x15
	public Sprite[] frames; //Field offset: 0x18
	private SpriteRenderer mUnitySprite; //Field offset: 0x1C
	private UI2DSprite mNguiSprite; //Field offset: 0x20
	private float mUpdate; //Field offset: 0x24

	public int framesPerSecond
	{
		 get { } //Length: 9
		 set { } //Length: 256
	}

	public bool isPlaying
	{
		 get { } //Length: 149
	}

	public UI2DSpriteAnimation() { }

	public int get_framesPerSecond() { }

	public bool get_isPlaying() { }

	public void Pause() { }

	public void Play() { }

	public void ResetToBeginning() { }

	public void set_framesPerSecond(int value) { }

	private void Start() { }

	private void Update() { }

	private void UpdateSprite() { }

}

