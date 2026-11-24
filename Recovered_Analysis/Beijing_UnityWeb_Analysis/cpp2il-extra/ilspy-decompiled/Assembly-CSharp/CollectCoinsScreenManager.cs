using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

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
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			CollectCoinsScreenState collectCoinsScreenState = default;
			object obj = collectCoinsScreenState + 16;
			obj = this;
			return collectCoinsScreenState;
		}
		private set
		{
			//IL_000c: Expected Obj, but got I4
			//IL_001e: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0043: Expected Obj, but got I4
			//IL_0043: Expected Obj, but got I4
			((GameObject)_screenState).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CollectCoinsScreenManager)+10]");
			((GameObject)0).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CollectCoinsScreenManager)+14]");
			((GameObject)0).tag = null;
			((GameObject)value).tag = (string)1;
		}
	}

	public static CollectCoinsScreenManager Instance => (CollectCoinsScreenManager)(object)RenderTextureManager._instance;

	public static bool isInitialized
	{
		get
		{
			//IL_0145: Expected I, but got Obj
			//IL_015b: Expected Obj, but got I
			//IL_01c3: Expected I, but got Obj
			//IL_01d9: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01b5: Expected I4, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00f8: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(CollectCoinsScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CollectCoinsScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CollectCoinsScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<CollectCoinsScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = (nint)typeof(CollectCoinsScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<CollectCoinsScreenManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(CollectCoinsScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v39 (Il2CppClass<CollectCoinsScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CollectCoinsScreenManager instance = default;
				_instance = instance;
			}
			nint num5 = (nint)typeof(CollectCoinsScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<CollectCoinsScreenManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CollectCoinsScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v23 (Il2CppClass<CollectCoinsScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)_instance != 0;
		}
	}

	private void ScreenStateChanged(CollectCoinsScreenState newState)
	{
		if (_screenState != newState)
		{
			_screenState = newState;
			((DebugSettingsPopup)this).ScrollToLastIndex((DebugSettingsPopup.TabNumber)_screenState);
		}
	}

	private void UpdateScreenState()
	{
		_ = 90f;
		_ = 225f;
		_ = 56f;
		_ = 1f;
		_ = 450f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public CollectCoinsScreenManager()
	{
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0312: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010f: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0150: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v57 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Characters.CharacterId> availableCharacterTokens = MysteryBox.GetAvailableCharacterTokens();
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v53 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		object obj3 = availableCharacterTokens | 2;
		bool flag = (nint)obj3 == 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (System.Boolean)+70]");
		object obj4 = (nint)0 & (nint)(flag ? 1 : 0);
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (System.Boolean)+70]");
			object obj5 = (nint)0 >> 1;
			object obj6 = availableCharacterTokens | 1;
			bool flag2 = (nint)obj6 == 3;
			object obj7 = obj5 & flag2;
			if (obj7 != null)
			{
				goto IL_01d7;
			}
		}
		else
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Globals>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v43 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (System.Boolean)+70]");
			object obj9 = (nint)0 >> 1;
			object obj10 = availableCharacterTokens | 1;
			bool flag3 = (nint)obj10 == 3;
			object obj11 = obj9 & flag3;
			bool flag4 = obj11 != null;
			if (~(Globals.DEBUG_USE_DEBUG_LOGIN_STATE ? 1u : 0u) != 0)
			{
				if (flag4)
				{
					ScreenStateChanged(CollectCoinsScreenState.GameCenter);
				}
				else
				{
					ScreenStateChanged(CollectCoinsScreenState.Offline);
				}
				return;
			}
			if (flag4)
			{
				goto IL_01d7;
			}
		}
		ScreenStateChanged(CollectCoinsScreenState.Facebook);
		return;
		IL_01d7:
		ScreenStateChanged(CollectCoinsScreenState.FacebookAndGamecenter);
	}

	static CollectCoinsScreenManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		CelebrationTesterPopup._currentCelebrationReward = (CelebrationReward)(object)dailyChallengeRewardHelper;
	}
}
