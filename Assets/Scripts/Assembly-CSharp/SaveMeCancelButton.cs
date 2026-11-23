using UnityEngine;

public class SaveMeCancelButton : MonoBehaviour
{
	public SaveMePopup saveMePopup;

	private void OnClick()
	{
		if (this.saveMePopup != null)
		{
			SaveMePopup saveMePopup = this.saveMePopup;
			if (saveMePopup.timeLeft < 2f)
			{
				CloseSaveMe();
			}
		}
	}

	public static void CloseSaveMe()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups("SaveMePopup");
		Revive instance2 = Revive.Instance;
		instance2.SendSkipRevive();
		SaveMeManager.ResetSaveMeForNewRun();
	}
}
