using UI;
using UnityEngine;

public class BoardsNotificationHelper : MonoBehaviour
{
	private UISprite notificationIcon;

	private UILabel notificationLabel;

	private bool _hasGoneToZero;

	private const float UPDATE_INTERVAL = 0.1f;

	private float _currentInterval;

	private void OnEnable()
	{
		RefreshNotification();
	}

	private void Update()
	{
		if (_hasGoneToZero)
		{
			return;
		}
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (topScreenName == "BoardScreen")
		{
			if (!(_currentInterval > 0f))
			{
				float currentInterval = _currentInterval + 0.1f;
				_currentInterval = currentInterval;
				RefreshNotification();
			}
			else
			{
				float deltaTime = Time.deltaTime;
				float currentInterval2 = _currentInterval - deltaTime;
				_currentInterval = currentInterval2;
			}
		}
	}

	private unsafe void RefreshNotification()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int numberOfNewHoverboardsAndThemes = HoverboardStickerManager.GetNumberOfNewHoverboardsAndThemes();
		if (numberOfNewHoverboardsAndThemes >= 1)
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
