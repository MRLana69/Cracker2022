using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Migration;
using Data.Save;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Subway.Info;

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
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Expected Obj, but got Unknown
			//IL_0374: Expected Obj, but got I4
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03a4: Expected I, but got Obj
			//IL_03ba: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_0125: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I
			//IL_04d3: Expected I, but got Obj
			//IL_04e9: Expected Obj, but got I
			//IL_0266: Expected Obj, but got I
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected Obj, but got Unknown
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected Obj, but got Unknown
			//IL_041f: Expected Obj, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_031e: Expected I, but got Obj
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected Obj, but got Unknown
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			nint num = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<LeaderboardDummyData>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(LeaderboardDummyData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v125 (Il2CppClass<LeaderboardDummyData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			LeaderboardScreenState leaderboardScreenState = LeaderboardScreenState.Facebook;
			object obj6 = default;
			object obj7 = default;
			LeaderboardScreenState result = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v111+C]");
					if (0 > (nint)obj7)
					{
						LeaderboardScreenState leaderboardScreenState2 = leaderboardScreenState + 1;
						leaderboardScreenState = leaderboardScreenState2;
						continue;
					}
					object obj8 = obj4 + 4;
					object obj9 = obj8 + 1;
					obj8 = obj9;
					object obj10 = obj9 << 2;
					object obj11 = obj4 + obj10;
					obj11 = 82;
					result = leaderboardScreenState;
					break;
				}
				object obj12 = obj4 + 4;
				object obj13 = obj12 + 1;
				obj12 = obj13;
				object obj14 = obj13 << 2;
				object obj15 = obj4 + obj14;
				obj15 = 69;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj16 = (nint)0 << 2;
				object obj17 = obj4 + obj16;
				if ((nint)obj17 == 82)
				{
					object obj18 = obj4 + 4;
					if ((nint)obj18 > -1)
					{
						object obj19 = obj18 + -1;
						obj18 = obj19;
					}
					goto IL_04c0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj20 = (nint)0 << 2;
				object obj21 = obj4 + obj20;
				if ((nint)obj21 == 69)
				{
					object obj22 = obj4 + 4;
					if ((nint)obj22 > -1)
					{
						object obj23 = obj22 + -1;
						obj22 = obj23;
					}
					goto IL_04c5;
				}
			}
			object obj24 = default;
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_04c5;
			IL_04c0:
			return result;
			IL_04c5:
			nint num3 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v47 (Il2CppClass<LeaderboardDummyData>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num4 = (nint)typeof(LeaderboardDummyData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v58 (Il2CppClass<LeaderboardDummyData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<LeaderboardDummyData.LeaderboardDummy> dummyData = LeaderboardDummyData.dummyData;
			LeaderboardScreenState leaderboardScreenState3 = (LeaderboardScreenState)(dummyData._size + 1);
			result = leaderboardScreenState3;
			goto IL_04c0;
		}
		private set
		{
			((LeaderboardOnlineScreen)this).ResetFriendList();
		}
	}

	public static LeaderboardScreenManager Instance
	{
		get
		{
			//IL_02c0: Expected I, but got Obj
			//IL_02d6: Expected Obj, but got I
			//IL_0429: Expected I, but got Obj
			//IL_043f: Expected Obj, but got I
			//IL_030e: Expected I, but got Obj
			//IL_0324: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0364: Expected Obj, but got I4
			//IL_0364: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_011d: Expected Obj, but got I4
			//IL_0152: Expected I, but got Obj
			//IL_0168: Expected Obj, but got I
			//IL_03b5: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I4
			//IL_0193: Expected I, but got Obj
			//IL_01e0: Expected I, but got Obj
			//IL_01f6: Expected Obj, but got I
			//IL_03d1: Expected I, but got Obj
			//IL_03e7: Expected Obj, but got I
			//IL_0221: Expected I, but got Obj
			//IL_026e: Expected I, but got Obj
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
			nint num3 = (nint)typeof(FrontScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(FrontScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v32 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = ((FrontScreen)(object)bundleIdentifier).CanShowInterstitial();
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v14 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerInfoData playerInfoData = PlayerInfoMigrator.LoadPlayerInfoData();
			bool flag2 = ((FrontScreen)(object)playerInfoData).CanShowInterstitial();
			LeaderboardScreenManager result;
			if (string.Equals((string)flag2, (string)flag))
			{
				result = null;
			}
			else if ((string)flag2 != "")
			{
				result = null;
			}
			else
			{
				nint num7 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v26 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v32 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9349");
				result = (LeaderboardScreenManager)1;
			}
			if (!string.Equals((string)flag2, (string)flag))
			{
				nint num9 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v18 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v24 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string bundleIdentifier2 = DeviceUtility.GetBundleIdentifier();
				nint num11 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S2_v8 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num12 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v13 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((UserSave)(object)bundleIdentifier2)._002Ector();
			}
			return result;
		}
	}

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
			nint num = (nint)typeof(LeaderboardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LeaderboardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = (nint)typeof(LeaderboardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(LeaderboardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v39 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LeaderboardScreenManager instance = default;
				_instance = instance;
			}
			nint num5 = (nint)typeof(LeaderboardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(LeaderboardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v23 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)_instance != 0;
		}
	}

	private void ScreenStateChanged(LeaderboardScreenState newState)
	{
		if (_screenState != newState)
		{
			_screenState = newState;
			((PauseScreen)this).OnMissionCellAnimationComplete((int)_screenState);
		}
	}

	private void UpdateScreenState()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 92;
		object obj2 = default;
		obj = obj2;
		object obj4 = default;
		object obj3 = obj4 + 12;
		obj3 = 0;
		obj3 = 0;
		obj3 = 28;
		_ = 103;
		_ = -98;
		_ = -1;
		object obj5 = obj4 + 8;
		obj5 = obj3;
		object obj6 = obj4 + 16;
		obj6 = obj5;
		object obj7 = obj4 + 4;
		obj7 = 0;
		obj7 = 0;
		obj7 = 87;
		_ = -66;
		_ = -62;
		_ = -1;
		obj4 = obj7;
		obj6 = obj4;
		((UpgradeScreen)this).Start();
	}

	public LeaderboardScreenManager()
	{
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0332: Expected I, but got Obj
		//IL_0348: Expected Obj, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_037b: Expected Obj, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_0149: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v67 (Il2CppClass<Globals>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v63 (Il2CppClass<SocialManager>)+74]");
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
		bool flag2;
		if (obj4 != null)
		{
			flag2 = true;
		}
		else
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v48 (Il2CppClass<Globals>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v56 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag2 = Globals.DEBUG_USE_DEBUG_LOGIN_STATE;
		}
		nint num7 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v23 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (System.Boolean)+70]");
		object obj7 = (nint)0 >> 1;
		object obj8 = availableCharacterTokens | 1;
		bool flag3 = (nint)obj8 == 3;
		object obj9 = obj7 & flag3;
		bool flag4 = obj9 != null;
		if (AgeRestriction.waitForAgeRestriction)
		{
			ScreenStateChanged(LeaderboardScreenState.AgeRestricted);
		}
		else if (flag2)
		{
			if (flag4)
			{
				ScreenStateChanged(LeaderboardScreenState.FacebookAndGamecenter);
			}
			else
			{
				ScreenStateChanged(LeaderboardScreenState.Facebook);
			}
		}
		else if (flag4)
		{
			ScreenStateChanged(LeaderboardScreenState.GameCenter);
		}
		else
		{
			ScreenStateChanged(LeaderboardScreenState.Offline);
		}
	}

	static LeaderboardScreenManager()
	{
		FrontScreen._firstTimeShown = true;
	}
}
