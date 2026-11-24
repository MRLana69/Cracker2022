namespace UnityEngine;

public class Animator : Behaviour
{

	public bool hasBoundPlayables
	{
		 get { } //Length: 49
	}

	public AnimatorControllerParameter[] parameters
	{
		 get { } //Length: 9
	}

	public float speed
	{
		 set { } //Length: 14
	}

	public bool get_hasBoundPlayables() { }

	public AnimatorControllerParameter[] get_parameters() { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	public bool GetBool(int id) { }

	private bool GetBoolID(int id) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public float GetFloat(int id) { }

	private float GetFloatID(int id) { }

	public int GetInteger(int id) { }

	private int GetIntegerID(int id) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	public bool IsInTransition(int layerIndex) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	public void Play(int stateNameHash) { }

	public void Play(string stateName) { }

	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void ResetTrigger(string name) { }

	private void ResetTriggerString(string name) { }

	public void set_speed(float value) { }

	public void SetBool(int id, bool value) { }

	private void SetBoolID(int id, bool value) { }

	public void SetFloat(int id, float value) { }

	private void SetFloatID(int id, float value) { }

	public void SetInteger(int id, int value) { }

	private void SetIntegerID(int id, int value) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	private void SetTriggerID(int id) { }

	private void SetTriggerString(string name) { }

	public void StopPlayback() { }

	public static int StringToHash(string name) { }

	public void Update(float deltaTime) { }

}

