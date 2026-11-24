//Type is in global namespace

public class RunnerAnimation : MonoBehaviour
{
	private static bool addedListeners; //Field offset: 0x0
	public float AnimationSpeedUpFactor; //Field offset: 0xC
	private AnimationEventBroadcaster animationEventBroadcaster; //Field offset: 0x10

	private static RunnerAnimation() { }

	public RunnerAnimation() { }

	private void Awake() { }

	public void SetAnimationSpeedEvent(AnimationEvent animEvent) { }

	private void SetSpeed(AnimationState animationState, float speed) { }

}

