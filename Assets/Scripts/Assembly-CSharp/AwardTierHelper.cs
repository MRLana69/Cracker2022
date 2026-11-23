using UnityEngine;

public class AwardTierHelper : MonoBehaviour
{
	private GameObject inactiveElementsParent;

	private GameObject activeElement;

	public GameObject tierEffectSprite;

	public void TierComplete(bool complete)
	{
		bool active = (byte)((complete ? 1u : 0u) ^ 1u) != 0;
		inactiveElementsParent.SetActive(active);
		activeElement.SetActive(complete);
	}
}
