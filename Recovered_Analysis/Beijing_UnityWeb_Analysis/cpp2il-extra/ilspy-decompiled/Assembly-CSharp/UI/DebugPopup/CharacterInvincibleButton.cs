using UnityEngine;

namespace UI.DebugPopup;

public class CharacterInvincibleButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private bool _enabled;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public void Click()
	{
		bool flag = _enabled;
		((FPSCounterButton)this).SetupButton(flag);
	}

	private void SetupButton(bool enabled)
	{
		//IL_002a: Expected I4, but got Obj
		//IL_0015: Expected I4, but got Obj
		if (enabled)
		{
			_titleLabel.fontSize = (int)"Ignore Obstacles: ON";
		}
		else
		{
			_titleLabel.fontSize = (int)"Ignore Obstacles: OFF";
		}
	}

	public CharacterInvincibleButton()
	{
		bool flag = _enabled;
		bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		_enabled = flag2;
		bool flag3 = _enabled;
		((FPSCounterButton)this).SetupButton(flag3);
	}
}
