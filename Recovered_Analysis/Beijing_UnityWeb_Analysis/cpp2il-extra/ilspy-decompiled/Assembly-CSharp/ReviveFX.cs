using UnityEngine;

public class ReviveFX : MonoBehaviour
{
	public Animation ReviveAnimation;

	public ReviveFX()
	{
		_ = 0.144f;
		_ = 250f;
		CancelInvoke();
	}
}
