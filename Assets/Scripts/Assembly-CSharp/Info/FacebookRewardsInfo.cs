using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Subway.Info;

namespace Info;

public static class FacebookRewardsInfo
{
	public enum FacebookRewardType
	{
		Coins,
		Keys,
		Hoverboards,
		Headstarts
	}

	public static int POPUP_DISPLAY_TIME_LIMIT;

	public static int POPUP_DISPLAY_RUN_LIMIT;

	public static string FACEBOOK_REWARD_RUN_LIMIT_KEY;

	public static string FACEBOOK_REWARD_TIME_LIMIT_KEY;

	public static bool isCharacterRewarded;

	public static Characters.CharacterType awardedCharacter;

	public static int characterTheme;

	public static DateTime connectPopupLastShownOnGameOver;

	public static DateTime connectPopupLastShownOnFriendsScreen;

	public static Dictionary<FacebookRewardType, int> facebookRewardPack;

	public static bool ShouldShowConnectPopupOnGameOver(int showCounter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got VT
		//IL_013b: Expected F8, but got I4
		//IL_01d7: Expected Obj, but got F8
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01a8: Expected F8, but got I4
		//IL_021d: Expected Obj, but got F8
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (!AgeRestriction.isRestricted)
		{
			DateTime now = CDateTime.Now;
			TimeSpan timeSpan = now - connectPopupLastShownOnGameOver;
			DateTime now2 = CDateTime.Now;
			TimeSpan timeSpan2 = now2 - connectPopupLastShownOnFriendsScreen;
			obj = timeSpan2;
			OnlineSettings instance = OnlineSettings.instance;
			int value = instance.GetValue(FACEBOOK_REWARD_TIME_LIMIT_KEY, POPUP_DISPLAY_TIME_LIMIT);
			OnlineSettings instance2 = OnlineSettings.instance;
			int value2 = instance2.GetValue(FACEBOOK_REWARD_RUN_LIMIT_KEY, POPUP_DISPLAY_RUN_LIMIT);
			if (!HasReceivedAllAvailableRewards())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				double num = 0.0 * 1E-07;
				double num2 = Math.Abs(num);
				double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : num);
				object obj3 = num3 >> 31;
				double num4 = (double)obj3 + num3;
				object obj4 = num4 ^ obj3;
				if (value <= (nint)obj4)
				{
					double num5 = (double)obj * 1E-07;
					double num6 = Math.Abs(num5);
					double num7 = ((!(num6 < 2147483648.0)) ? (-2147483648.0) : num5);
					object obj5 = num7 >> 31;
					double num8 = (double)obj5 + num7;
					object obj6 = num8 ^ obj5;
					bool flag = value <= (nint)obj6;
					bool flag2 = showCounter >= value2;
					return flag & flag2;
				}
			}
		}
		bool result = default;
		return result;
	}

	public static bool ShouldShowConnectPopupOnFriendsScreen()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ee: Expected F8, but got I4
		//IL_011d: Expected Obj, but got F8
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (!AgeRestriction.isRestricted)
		{
			DateTime now = CDateTime.Now;
			TimeSpan timeSpan = now - connectPopupLastShownOnFriendsScreen;
			OnlineSettings instance = OnlineSettings.instance;
			int value = instance.GetValue(FACEBOOK_REWARD_TIME_LIMIT_KEY, POPUP_DISPLAY_TIME_LIMIT);
			if (!HasReceivedAllAvailableRewards())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				double num = 0.0 * 1E-07;
				double num2 = Math.Abs(num);
				double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : num);
				object obj3 = num3 >> 31;
				double num4 = (double)obj3 + num3;
				object obj4 = num4 ^ obj3;
				return value <= (nint)obj4;
			}
		}
		bool result = default;
		return result;
	}

	public static bool HasReceivedAllAvailableRewards()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = (byte)(~(instance._hasPayedOutFacebook ? 1u : 0u)) != 0;
		bool flag2 = false;
		if (!flag)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			bool hasPayedOutFacebookPack = instance2._hasPayedOutFacebookPack;
			flag2 = hasPayedOutFacebookPack;
		}
		bool flag3 = (byte)(~(isCharacterRewarded ? 1u : 0u)) != 0;
		bool flag4 = flag3 & flag2;
		bool flag5 = (byte)(~(isCharacterRewarded ? 1u : 0u)) != 0;
		bool result = flag4;
		if (!flag5)
		{
			bool flag6 = !flag2;
			result = flag4;
			if (!flag6)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				bool hasPayedOutFacebookCharacter = instance3._hasPayedOutFacebookCharacter;
				result = hasPayedOutFacebookCharacter;
			}
		}
		return result;
	}

	unsafe static FacebookRewardsInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected VT, but got Unknown
		//IL_0190: Expected Ref, but got VT
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected VT, but got Unknown
		//IL_004a: Expected Ref, but got VT
		//IL_0096: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		POPUP_DISPLAY_TIME_LIMIT = 300;
		POPUP_DISPLAY_RUN_LIMIT = 3;
		FACEBOOK_REWARD_RUN_LIMIT_KEY = "facebook_reward_run_limit";
		FACEBOOK_REWARD_TIME_LIMIT_KEY = "facebook_reward_time_limit";
		isCharacterRewarded = true;
		awardedCharacter = Characters.CharacterType.facebookRewardCharacter01;
		characterTheme = 0;
		DateTime now = CDateTime.Now;
		DateTime dateTime = (DateTime)(obj + 8);
		DateTime dateTime2 = ((DateTime*)dateTime)->AddDays(-1.0);
		connectPopupLastShownOnGameOver = dateTime2;
		DateTime now2 = CDateTime.Now;
		DateTime dateTime3 = (DateTime)(obj + 8);
		DateTime dateTime4 = ((DateTime*)dateTime3)->AddDays(-1.0);
		connectPopupLastShownOnFriendsScreen = dateTime4;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.FacebookRewardsInfo+FacebookRewardType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.FacebookRewardsInfo+FacebookRewardType, System.Int32>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.FacebookRewardsInfo+FacebookRewardType, System.Int32>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.FacebookRewardsInfo+FacebookRewardType, System.Int32>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.FacebookRewardsInfo+FacebookRewardType, System.Int32>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S5_v19+4] (should have been resolved before IL gen)");
		Dictionary<FacebookRewardType, int> dictionary = default;
		facebookRewardPack = dictionary;
	}
}
