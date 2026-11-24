//Type is in global namespace

public class KeyframeBehaviour : MonoBehaviour
{
	private Animation TargetAnimation; //Field offset: 0xC
	public ParticleSystem[] TargetObjects; //Field offset: 0x10
	public List<KeyFrameAction> Actions; //Field offset: 0x14

	public KeyframeBehaviour() { }

	private void DoKeyframeAnimation(int soundIndex) { }

	public void Initialize() { }

}

