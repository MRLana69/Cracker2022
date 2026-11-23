using UnityEngine;
using UnityEngine.UI;

public class SaveMeAnimateClock : MonoBehaviour
{
	public Image clockSprite;

	public void FillSpriteAmount(float amount)
	{
		if (clockSprite != null)
		{
			clockSprite.fillAmount = amount;
		}
	}
}
