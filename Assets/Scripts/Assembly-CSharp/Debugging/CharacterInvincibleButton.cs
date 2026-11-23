using UnityEngine;

namespace Debugging;

public class CharacterInvincibleButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private bool _enabled;

	private void OnEnable()
	{
		SetupButton(_enabled);
	}

	public void Click()
	{
		bool flag = (byte)((_enabled ? 1u : 0u) ^ 1u) != 0;
		_enabled = flag;
		bool flag2 = (byte)(~(_enabled ? 1u : 0u)) != 0;
		SetupButton(flag2);
	}

	private void SetupButton(bool enabled)
	{
		object text = "Invincible: ON";
		if (!enabled)
		{
			text = "Invincible: OFF";
		}
		_titleLabel.text = (string)text;
	}
}
