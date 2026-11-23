using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public static class SaveMeManager
{
	private static int _numberOfUsedKeysInCurrentRun = 1;

	private const string SAVE_ME_LOCALES_KEY = "save_me_locales";

	public static bool IS_PURCHASE_MADE_FROM_INGAME;

	public static bool IS_PURCHASE_RUNNING_INGAME;

	public static void IncrementNumberOfUsedKeys()
	{
		if (_numberOfUsedKeysInCurrentRun <= 0)
		{
			_numberOfUsedKeysInCurrentRun = 1;
			return;
		}
		int numberOfUsedKeysInCurrentRun = _numberOfUsedKeysInCurrentRun << 1;
		_numberOfUsedKeysInCurrentRun = numberOfUsedKeysInCurrentRun;
	}

	public static int GetNumberOfKeysToSaveMe()
	{
		return _numberOfUsedKeysInCurrentRun;
	}

	public static void ResetSaveMeForNewRun()
	{
		_numberOfUsedKeysInCurrentRun = 1;
	}

	public static void HasShownKeysPopup()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance._hasShownKeysPopup)
		{
			instance._dirty = true;
			instance._hasShownKeysPopup = true;
		}
	}

	public static bool IsSaveMePopupEnabled()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance._isSaveMePopupEnabled;
	}

	public static void SkipReviveIfPurchaseFailed()
	{
		if (!UIScreenController.IsInstanced)
		{
			return;
		}
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (topScreenName == "IngameUI" && ~(IS_PURCHASE_MADE_FROM_INGAME ? 1u : 0u) == 0)
		{
			IS_PURCHASE_MADE_FROM_INGAME = false;
			IS_PURCHASE_RUNNING_INGAME = false;
			Revive instance2 = Revive.Instance;
			if (instance2 != null)
			{
				instance2.SendSkipRevive();
			}
		}
	}

	public static void SendReviveIfPurchaseSucceeded()
	{
		//IL_0062: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		if (!UIScreenController.IsInstanced)
		{
			return;
		}
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		object obj;
		if (topScreenName != null)
		{
			obj = 0;
			if (topScreenName._stringLength != 0)
			{
				goto IL_01fd;
			}
		}
		obj = 1;
		goto IL_01fd;
		IL_01fd:
		if (obj == null && topScreenName.Equals("IngameUI") && ~(IS_PURCHASE_MADE_FROM_INGAME ? 1u : 0u) == 0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfKeys = instance2.amountOfKeys;
			object obj2 = amountOfKeys - _numberOfUsedKeysInCurrentRun;
			if ((nint)obj2 >= 0)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				int amountOfKeys2 = instance3.amountOfKeys;
				int amountOfKeys3 = amountOfKeys2 - _numberOfUsedKeysInCurrentRun;
				instance3.amountOfKeys = amountOfKeys3;
				MissionsManager instance4 = MissionsManager.Instance;
				instance4.PlayerDidThis(MissionTarget.SpendKeys, _numberOfUsedKeysInCurrentRun);
			}
			IS_PURCHASE_MADE_FROM_INGAME = false;
			IS_PURCHASE_RUNNING_INGAME = false;
			Revive instance5 = Revive.Instance;
			if (instance5 != null)
			{
				instance5.SendRevive();
			}
			IncrementNumberOfUsedKeys();
			UIScreenController instance6 = UIScreenController.Instance;
			string topScreenName2 = instance6.GetTopScreenName();
			UIScreen screenFromCache = instance6.GetScreenFromCache(topScreenName2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			Object obj3 = default;
			if (!(obj3 == null))
			{
				((IngameScreen)obj3).SetPauseButtonVisibility(true);
			}
		}
	}
}
