using SYBO.Common.Automation.Steps;

namespace SYBO.Subway.Automation.Steps;

public class ReviveStep : AutomationStep
{
	private bool _waitFrame;

	public override void Cleanup()
	{
		_waitFrame = false;
		base.IsDone__BackingField = false;
	}

	public override void Update(float unscaledDeltaTime)
	{
		if (~(_waitFrame ? 1u : 0u) == 0)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			instance.AddSaveMeTokenToUnlock(SaveMeManager._numberOfUsedKeysInCurrentRun);
			SaveMeButton.RevivePlayer();
			base.IsDone__BackingField = true;
			return;
		}
		UIScreenController instance2 = UIScreenController.Instance;
		if (instance2.isShowingPopup)
		{
			UIScreenController instance3 = UIScreenController.Instance;
			string currentPopupName = instance3.GetCurrentPopupName();
			if (currentPopupName.Equals("SaveMePopup"))
			{
				_waitFrame = true;
			}
		}
	}
}
