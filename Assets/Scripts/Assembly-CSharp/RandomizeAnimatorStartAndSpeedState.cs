using UnityEngine;

public class RandomizeAnimatorStartAndSpeedState : StateMachineBehaviour
{
	private string _stateNameToPlay;

	private float _speedMin;

	private float _speedMax = 1f;

	private float _startTime;

	private bool _hadFirstRun;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		bool flag = _startTime < 0f;
		bool flag2 = !flag;
		float startTime = _startTime;
		if (!flag2)
		{
			startTime = _startTime;
			if (!_hadFirstRun)
			{
				float value = Random.value;
				_startTime = value;
				float value2 = Random.value;
				float num = _speedMax - _speedMin;
				float num2 = value2 * num;
				float speed = num2 + _speedMin;
				animator.speed = speed;
				startTime = _startTime;
			}
		}
		animator.Play(_stateNameToPlay, 0, startTime);
		_startTime = 0f;
	}
}
