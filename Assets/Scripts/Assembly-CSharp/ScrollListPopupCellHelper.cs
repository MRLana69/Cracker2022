using UnityEngine;

public class ScrollListPopupCellHelper : MonoBehaviour
{
	public UILabel Title;

	public GameObject OffIcon;

	public GameObject OnIcon;

	public string cellID;

	private bool currentIconState;

	public void UpdateTitle(string title)
	{
		Title.text = title;
	}

	public void SetToggleIcon(bool selected)
	{
		bool active = (byte)((selected ? 1u : 0u) ^ 1u) != 0;
		OffIcon.SetActive(active);
		OnIcon.SetActive(selected);
		currentIconState = selected;
	}

	public void ToggleIcon()
	{
		bool flag = (byte)((currentIconState ? 1u : 0u) ^ 1u) != 0;
		currentIconState = flag;
		bool active = currentIconState;
		OffIcon.SetActive(active);
		OnIcon.SetActive(currentIconState);
	}
}
