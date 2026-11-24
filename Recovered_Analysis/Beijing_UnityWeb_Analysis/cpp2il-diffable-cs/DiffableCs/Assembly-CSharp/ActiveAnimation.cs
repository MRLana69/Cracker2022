//Type is in global namespace

public class ActiveAnimation : MonoBehaviour
{
	public static ActiveAnimation current; //Field offset: 0x0
	public List<EventDelegate> onFinished; //Field offset: 0xC
	public GameObject eventReceiver; //Field offset: 0x10
	public string callWhenFinished; //Field offset: 0x14
	private Animation mAnim; //Field offset: 0x18
	private Direction mLastDirection; //Field offset: 0x1C
	private Direction mDisableDirection; //Field offset: 0x20
	private bool mNotify; //Field offset: 0x24
	private Animator mAnimator; //Field offset: 0x28
	private string mClip; //Field offset: 0x2C

	public bool isPlaying
	{
		 get { } //Length: 255
	}

	private float playbackTime
	{
		 get { } //Length: 9
	}

	public ActiveAnimation() { }

	public void Finish() { }

	public bool get_isPlaying() { }

	private float get_playbackTime() { }

	private void Play(string clipName, Direction playDirection) { }

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition) { }

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection) { }

	public static ActiveAnimation Play(Animation anim, Direction playDirection) { }

	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition) { }

	public void Reset() { }

	private void Start() { }

	private void Update() { }

}

