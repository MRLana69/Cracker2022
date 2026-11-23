using Missions;
using UnityEngine;

public class AwardsNotificationHelper : MonoBehaviour
{
	private UISprite notificationIcon;

	private UILabel notificationLabel;

	private bool _hasGoneToZero;

	private void OnEnable()
	{
		RefreshNotification();
	}

	private void Update()
	{
		if (!_hasGoneToZero)
		{
			UIScreenController instance = UIScreenController.Instance;
			string topScreenName = instance.GetTopScreenName();
			if (topScreenName == "AwardsScreen")
			{
				RefreshNotification();
			}
		}
	}

	private unsafe void RefreshNotification()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		AwardsManager instance = AwardsManager.instance;
		int numberOfNewVisibleAwards = instance.GetNumberOfNewVisibleAwards();
		if (numberOfNewVisibleAwards >= 1)
		{
			notificationIcon.enabled = true;
			notificationLabel.enabled = true;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			notificationLabel.text = text;
		}
		else
		{
			notificationIcon.enabled = false;
			notificationLabel.enabled = false;
			_hasGoneToZero = true;
		}
	}
}
