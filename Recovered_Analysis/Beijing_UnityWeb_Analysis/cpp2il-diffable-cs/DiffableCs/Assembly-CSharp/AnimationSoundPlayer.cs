//Type is in global namespace

public class AnimationSoundPlayer : MonoBehaviour
{
	private static List<string> nodesInitialized; //Field offset: 0x0
	public Animation TargetAnimation; //Field offset: 0xC
	public List<KeyFrameAudio> AudioClips; //Field offset: 0x10
	private int nextAudioClipIndex; //Field offset: 0x14
	private List<KeyFrameAudio> AudioClipsInitialized; //Field offset: 0x18

	private static AnimationSoundPlayer() { }

	public AnimationSoundPlayer() { }

	public void Add(KeyFrameAudio key) { }

	public virtual void PlayKeyframeAnimation(int soundIndex) { }

	private void Start() { }

}

