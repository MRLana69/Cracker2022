using System;
using Cpp2ILInjected;
using Info;

namespace UI.Screens;

public class LeaderboardScreenManager
{
	public enum LeaderboardScreenState
	{
		Offline,
		Facebook,
		GameCenter,
		FacebookAndGamecenter,
		AgeRestricted
	}

	private static LeaderboardScreenManager _instance;

	public Action<LeaderboardScreenState> OnLeaderboardScreenStateChangedEvent;

	private LeaderboardScreenState _screenState;

	public LeaderboardScreenState screenState
	{
		get
		{
			UpdateScreenState();
			return _screenState;
		}
		private set
		{
			if (value != _screenState)
			{
				_screenState = value;
				Action<LeaderboardScreenState> onLeaderboardScreenStateChangedEvent = OnLeaderboardScreenStateChangedEvent;
				if (OnLeaderboardScreenStateChangedEvent != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S0_v6 (System.Action`1<UI.Screens.LeaderboardScreenManager+LeaderboardScreenState>)+C] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public static LeaderboardScreenManager Instance
	{
		get
		{
			if (_instance == null)
			{
				LeaderboardScreenManager instance = default;
				_instance = instance;
			}
			return _instance;
		}
	}

	public static bool isInitialized => _instance != null;

	private void ScreenStateChanged(LeaderboardScreenState newState)
	{
		Action<LeaderboardScreenState> onLeaderboardScreenStateChangedEvent = OnLeaderboardScreenStateChangedEvent;
		if (OnLeaderboardScreenStateChangedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<UI.Screens.LeaderboardScreenManager+LeaderboardScreenState>)+C] (should have been resolved before IL gen)");
		}
	}

	private void UpdateScreenState()
	{
		//IL_004b: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		Globals.LogInState loginState = Globals.GetLoginState();
		SocialManager instance = SocialManager.instance;
		bool isRestricted = AgeRestriction.isRestricted;
		LeaderboardScreenState leaderboardScreenState = LeaderboardScreenState.AgeRestricted;
		if (!isRestricted)
		{
			int num = instance._consolidationState >> 1;
			object obj = loginState & (Globals.LogInState)(-2);
			bool flag = (nint)obj == 2;
			int num2 = num & (flag ? 1 : 0);
			leaderboardScreenState = LeaderboardScreenState.FacebookAndGamecenter;
			if (num2 == 0)
			{
				leaderboardScreenState = LeaderboardScreenState.Facebook;
			}
			object obj2 = loginState & (Globals.LogInState)(-3);
			bool flag2 = (nint)obj2 == 1;
			if (((flag2 ? 1u : 0u) & (uint)instance._consolidationState) == 0)
			{
				int num3 = num2 << 1;
				leaderboardScreenState = (LeaderboardScreenState)num3;
			}
		}
		screenState = leaderboardScreenState;
	}
}
