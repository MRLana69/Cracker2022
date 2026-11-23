using UnityEngine;

public class InAppHelper : MonoBehaviour
{
	private AudioClip purchaseSuccessSound;

	private void Start()
	{
		InAppManager instance = InAppManager.instance;
		instance.purchaseSuccessSound = purchaseSuccessSound;
	}
}
