using Cpp2ILInjected;
using UnityEngine;

public class RandomizeAnimatorStartAndSpeedState : StateMachineBehaviour
{
	private string _stateNameToPlay;

	private float _speedMin;

	private float _speedMax;

	private float _startTime;

	private bool _hadFirstRun;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got VT
		object obj = this + 44;
		obj = stateInfo;
	}

	public RandomizeAnimatorStartAndSpeedState()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
