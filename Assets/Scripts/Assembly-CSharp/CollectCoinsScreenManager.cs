using System;
using Cpp2ILInjected;

public class CollectCoinsScreenManager
{
	public enum CollectCoinsScreenState
	{
		Offline,
		Facebook,
		GameCenter,
		FacebookAndGamecenter
	}

	private static CollectCoinsScreenManager _instance;

	public const int GCFriendsThreshold = 3;

	public Action<CollectCoinsScreenState> OnCollectCoinsScreenStateChangedEvent;

	private CollectCoinsScreenState _screenState;

	public CollectCoinsScreenState screenState
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
				Action<CollectCoinsScreenState> onCollectCoinsScreenStateChangedEvent = OnCollectCoinsScreenStateChangedEvent;
				if (OnCollectCoinsScreenStateChangedEvent != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S0_v6 (System.Action`1<CollectCoinsScreenManager+CollectCoinsScreenState>)+C] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public static CollectCoinsScreenManager Instance
	{
		get
		{
			if (_instance == null)
			{
				CollectCoinsScreenManager instance = default;
				_instance = instance;
			}
			return _instance;
		}
	}

	public static bool isInitialized => _instance != null;

	private void ScreenStateChanged(CollectCoinsScreenState newState)
	{
		Action<CollectCoinsScreenState> onCollectCoinsScreenStateChangedEvent = OnCollectCoinsScreenStateChangedEvent;
		if (OnCollectCoinsScreenStateChangedEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<CollectCoinsScreenManager+CollectCoinsScreenState>)+C] (should have been resolved before IL gen)");
		}
	}

	private void UpdateScreenState()
	{
		//IL_0026: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		Globals.LogInState loginState = Globals.GetLoginState();
		SocialManager instance = SocialManager.instance;
		int num = instance._consolidationState >> 1;
		object obj = loginState & (Globals.LogInState)(-2);
		bool flag = (nint)obj == 2;
		int num2 = num & (flag ? 1 : 0);
		int num3 = 3;
		if (num2 == 0)
		{
			num3 = 1;
		}
		int num4 = num2 << 1;
		object obj2 = loginState & (Globals.LogInState)(-3);
		bool flag2 = (nint)obj2 == 1;
		if (((uint)instance._consolidationState & (flag2 ? 1u : 0u)) == 0)
		{
			num3 = num4;
		}
		screenState = (CollectCoinsScreenState)num3;
	}
}
