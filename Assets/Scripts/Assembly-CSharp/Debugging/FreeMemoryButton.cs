using UnityEngine;

namespace Debugging;

public class FreeMemoryButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private bool _showingCounter;

	private void OnEnable()
	{
		//IL_005e: Expected Obj, but got I4
		bool flag;
		if (!(FreeMemoryStatus._instance != null))
		{
			flag = _showingCounter;
		}
		else
		{
			GameObject gameObject = FreeMemoryStatus._instance.gameObject;
			flag = (_showingCounter = gameObject.activeInHierarchy);
		}
		object obj = (flag ? 1 : 0) & 0xFF;
		bool flag2 = obj != null;
		SetupButton(flag2);
	}

	public void Click()
	{
		bool showingCounter;
		if (~(_showingCounter ? 1u : 0u) != 0)
		{
			bool flag = FreeMemoryStatus._instance == null;
			bool flag2 = !flag;
			Object obj = FreeMemoryStatus._instance;
			if (!flag2)
			{
				UIScreenController instance = UIScreenController.Instance;
				FreeMemoryStatus freeMemoryStatus = FreeMemoryStatus.Create(instance.popupAnchor);
				obj = freeMemoryStatus;
			}
			if (!(obj != null))
			{
				goto IL_00f0;
			}
			((FreeMemoryStatus)obj).ToggleVisible(true);
			showingCounter = true;
		}
		else
		{
			if (!(FreeMemoryStatus._instance != null))
			{
				goto IL_00f0;
			}
			FreeMemoryStatus._instance.ToggleVisible(visible: false);
			showingCounter = false;
		}
		_showingCounter = showingCounter;
		goto IL_00f0;
		IL_00f0:
		SetupButton(_showingCounter);
	}

	private void SetupButton(bool enabled)
	{
		object text = "Free Memory Status: ON";
		if (!enabled)
		{
			text = "Free Memory Status: OFF";
		}
		_titleLabel.text = (string)text;
	}
}
