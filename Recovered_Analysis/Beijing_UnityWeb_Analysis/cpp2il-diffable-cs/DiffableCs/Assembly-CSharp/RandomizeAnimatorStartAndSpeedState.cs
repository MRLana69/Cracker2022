//Type is in global namespace

public class RandomizeAnimatorStartAndSpeedState : StateMachineBehaviour
{
	private string _stateNameToPlay; //Field offset: 0xC
	private float _speedMin; //Field offset: 0x10
	private float _speedMax; //Field offset: 0x14
	private float _startTime; //Field offset: 0x18
	private bool _hadFirstRun; //Field offset: 0x1C

	public RandomizeAnimatorStartAndSpeedState() { }

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

