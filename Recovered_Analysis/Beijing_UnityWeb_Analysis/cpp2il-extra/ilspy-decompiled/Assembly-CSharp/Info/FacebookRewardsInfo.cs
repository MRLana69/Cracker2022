using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Save;
using Kiloo.Common.Plugins.DeviceUtility;

namespace Info;

public static class FacebookRewardsInfo
{
	public enum FacebookRewardType
	{
		Coins
	}

	public static int POPUP_DISPLAY_TIME_LIMIT;

	public static int POPUP_DISPLAY_RUN_LIMIT;

	public static string FACEBOOK_REWARD_RUN_LIMIT_KEY;

	public static string FACEBOOK_REWARD_TIME_LIMIT_KEY;

	public static int characterTheme;

	public static DateTime connectPopupLastShownOnGameOver;

	public static DateTime connectPopupLastShownOnFriendsScreen;

	public static Dictionary<FacebookRewardType, int> facebookRewardPack;

	public static bool ShouldShowConnectPopupOnGameOver(int showCounter)
	{
		//IL_035f: Expected Obj, but got I4
		//IL_036d: Expected I, but got Obj
		//IL_0383: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_0113: Expected I4, but got Obj
		//IL_03cf: Expected I, but got Obj
		//IL_03e5: Expected Obj, but got I
		//IL_023d: Expected I, but got Obj
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_01af: Expected I, but got Obj
		//IL_01c5: Expected Obj, but got I
		//IL_042e: Expected I4, but got Obj
		//IL_02fb: Expected I, but got Obj
		//IL_01f0: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v85 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = EarnCoinsData.profiles + 16;
		int num3 = showCounter << 2;
		object obj4 = obj3 + num3;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+8]");
		object obj6 = -9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+8]");
		bool result;
		if ((nint)0 != 9)
		{
			if ((nint)obj6 == 1)
			{
				string debugSaveDirectory = SaveGameDebug.debugSaveDirectory;
				result = (byte)(int)debugSaveDirectory != 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+10]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+8]");
						bool flag = (nint)0 != 8;
						result = true;
						if (!flag)
						{
							nint num4 = (nint)typeof(EarnCoinsData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v75 (Il2CppClass<Info.EarnCoinsData>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num5 = (nint)typeof(EarnCoinsData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v81 (Il2CppClass<Info.EarnCoinsData>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int numberOfDisplayedNonOfferEarners = EarnCoinsData.GetNumberOfDisplayedNonOfferEarners();
							result = (byte)numberOfDisplayedNonOfferEarners != 0;
						}
						goto IL_03bc;
					}
				}
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v41 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num7 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v66 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string lastVersionRated = UserSave.lastVersionRated;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
				object obj9 = default;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+10]");
					if ((nint)0 == 1)
					{
						nint num8 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v55 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num9 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v62 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
						char c = ((string)obj).get_Chars((int)bundleIdentifier);
						result = true;
						if (c != '\0')
						{
							goto IL_03bc;
						}
					}
					result = false;
				}
				else
				{
					result = true;
				}
			}
		}
		else
		{
			nint num10 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num11 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
			result = (byte)((allAssetBundlesDownloaded ? 1u : 0u) ^ 1u) != 0;
		}
		goto IL_03bc;
		IL_03bc:
		return result;
	}

	public static bool ShouldShowConnectPopupOnFriendsScreen()
	{
		//IL_017f: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		bool flag = false;
		int num3 = default;
		int num6 = default;
		while (true)
		{
			nint num = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v8 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v31 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
			if (num3 >= profiles.Length)
			{
				break;
			}
			nint num4 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (ShouldShowConnectPopupOnGameOver(num3))
			{
				bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
				flag = flag2;
			}
			num3 = num6 + 1;
		}
		return flag;
	}

	static FacebookRewardsInfo()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EarnCoinsData._003C_003Ec obj = default;
		obj._002Ector();
		_ = 8;
		_ = 1;
		_ = 2;
		object obj2 = obj + 24;
		obj2 = "EARN_PRIZE_SPONSORED_VIDEO";
		object obj3 = obj + 28;
		obj3 = "EARN_PRIZE_SPONSORED_VIDEO_DESCRIPTION";
		object obj4 = obj + 32;
		obj4 = "EARN_PRIZE_SPONSORED_VIDEO_DESCRIPTION";
		object obj5 = obj + 36;
		obj5 = "icon_small_mini_mysteryBox_glow";
		object obj6 = obj + 44;
		obj6 = "videoads_defaultreward";
		throw new ArrayTypeMismatchException();
	}
}
