//Type is in global namespace

public class CelebrationBackgroundHelper : MonoBehaviour
{
	public Transform backgroundRoot; //Field offset: 0xC
	public Transform celebrationCloner; //Field offset: 0x10
	private bool shouldRotate; //Field offset: 0x14
	private AnimationCurve _bragCelebrationAnimationCurve; //Field offset: 0x18

	public bool visible
	{
		 get { } //Length: 183
		 set { } //Length: 86
	}

	public CelebrationBackgroundHelper() { }

	public bool get_visible() { }

	public float GetBragCelebrationAnimationCurveValue(float pos) { }

	public void Hide() { }

	public void InvertParticlesDirection(bool invert) { }

	public void set_visible(bool value) { }

	public void SetParticleAnimationSpeed(float speed) { }

	public void Show(Quaternion rotation, bool shouldAnimateStripes, bool shouldRotateBackground) { }

	private void Update() { }

}

