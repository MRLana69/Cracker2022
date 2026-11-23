using UnityEngine;

public class BundleContentSlot : MonoBehaviour
{
	private UILabel amountField;

	public void UpdateAmount(string amount)
	{
		amountField.text = amount;
	}
}
