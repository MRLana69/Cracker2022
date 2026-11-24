using UnityEngine;

public class EnemiesRig : MonoBehaviour
{
	private Animation _guardAnimation;

	private Animation _dogAnimation = (Animation)1f;

	public Animation GuardAnimation => _guardAnimation;

	public Animation DogAnimation => _guardAnimation;

	public EnemiesRig()
	{
		//IL_000b: Expected Obj, but got F4
		_ = 1f;
		CancelInvoke();
	}
}
