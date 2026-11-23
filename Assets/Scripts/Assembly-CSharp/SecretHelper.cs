using UnityEngine;

public class SecretHelper : MonoBehaviour
{
	public UILabel SecretValue;

	public UILabel SecretInfo;

	public UILabel SecretTitle;

	public UILabel SecretInfo2;

	public UILabel SecretValue2;

	public void UpdateInfo(string info, string value)
	{
		SecretInfo.text = info;
		SecretValue.text = value;
	}

	public void UpdateTitle(string title)
	{
		SecretTitle.text = title;
	}

	public void UpdateInfoDouble(string info, string value, string info2, string value2)
	{
		SecretInfo.text = info;
		SecretValue.text = value;
		SecretInfo2.text = info2;
		SecretValue2.text = value2;
	}
}
