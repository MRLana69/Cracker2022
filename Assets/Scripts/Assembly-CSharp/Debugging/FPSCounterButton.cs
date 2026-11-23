using UnityEngine;

namespace Debugging;

public class FPSCounterButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private bool _showCounter;

	private void OnEnable()
	{
		//IL_005e: Expected Obj, but got I4
		bool flag;
		if (!(FPSCounter._instance != null))
		{
			flag = _showCounter;
		}
		else
		{
			GameObject gameObject = FPSCounter._instance.gameObject;
			flag = (_showCounter = gameObject.activeInHierarchy);
		}
		object obj = (flag ? 1 : 0) & 0xFF;
		bool flag2 = obj != null;
		SetupButton(flag2);
	}

	public void Click()
	{
		bool showCounter = (byte)((_showCounter ? 1u : 0u) ^ 1u) != 0;
		_showCounter = showCounter;
		FPSCounter fPSCounter = FPSCounter._instance;
		if (~(_showCounter ? 1u : 0u) == 0)
		{
			if (FPSCounter._instance == null)
			{
				UIScreenController instance = UIScreenController.Instance;
				fPSCounter = FPSCounter.Create(instance.popupAnchor);
			}
			fPSCounter.ToggleVisible(visible: true);
		}
		else if (FPSCounter._instance != null)
		{
			FPSCounter._instance.ToggleVisible(visible: false);
		}
		SetupButton(_showCounter);
	}

	private void SetupButton(bool enabled)
	{
		object text = "FPS Counter: ON";
		if (!enabled)
		{
			text = "FPS Counter: OFF";
		}
		_titleLabel.text = (string)text;
	}
}
