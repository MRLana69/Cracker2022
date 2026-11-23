using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI;

public class PlayerNameInputControl : MonoBehaviour
{
	public TMP_InputField inputName;

	private void OnEnable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		string userName = instance.UserName;
		inputName.text = userName;
	}

	private void Start()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		string userName = instance.UserName;
		inputName.text = userName;
		TMP_InputField tMP_InputField = inputName;
		throw new ArgumentException();
	}

	private void _003CStart_003Eb__2_0(string value)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.UserName = value;
		PlayerInfo instance2 = PlayerInfo.Instance;
		string userName = instance2.UserName;
		inputName.text = userName;
	}
}
