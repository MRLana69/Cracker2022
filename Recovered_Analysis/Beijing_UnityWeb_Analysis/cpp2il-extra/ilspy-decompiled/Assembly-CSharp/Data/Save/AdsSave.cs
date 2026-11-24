using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save.Internal;
using InApp;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Ads;

namespace Data.Save;

public class AdsSave : DataManager<AdsSave>
{
	public unsafe static bool behavioralAdsAllowed
	{
		get
		{
			//IL_0149: Expected I, but got Obj
			//IL_015f: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_018a: Expected I, but got Obj
			//IL_01a0: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_0220: Expected Obj, but got I4
			//IL_00fc: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool flag;
			if (((OnlineSettings)(object)saveDataPath).TryGetValue("new_year_sale_active", out *(string*)null))
			{
				flag = true;
			}
			else
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Globals>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag = Globals.DEBUG_ENABLE_NEW_YEAR_SALES;
			}
			nint num5 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v7 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v15 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isDoubleCoinsDiscountActive = InAppManager.IsDoubleCoinsDiscountActive;
			object obj4 = flag & isDoubleCoinsDiscountActive;
			return obj4 != null;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	public static DateTime scheduledFirstInterstitialShowTime
	{
		get
		{
			//IL_0115: Expected Obj, but got I4
			//IL_0123: Expected I, but got Obj
			//IL_0139: Expected Obj, but got I
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected Obj, but got Unknown
			//IL_0107: Expected VT, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0171: Expected Obj, but got I4
			//IL_00e8: Expected VT, but got Obj
			//IL_00a1: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v40 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = obj + 8;
			if (AgeRestriction.IsConsentGiven())
			{
				nint num3 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v24 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v36 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int ageRestrictionInputYear = UserSave.ageRestrictionInputYear;
				bool cloudSaveEnabled = UserSave.cloudSaveEnabled;
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
				return (DateTime)obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj3 = obj;
			return (DateTime)obj;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static Dictionary<string, string> lastShowedProviders
	{
		get
		{
			//IL_002d: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+148]");
			bool flag = (nint)0 != 0;
			return (Dictionary<string, string>)flag;
		}
		set
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0039: Expected I4, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			object obj = value + 8;
			obj = value;
			cloudData.obfuscatedUnrewardedCoins = (int)obj;
		}
	}

	public static InterstitialStats interstitialStats
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (InterstitialStats)(object)cloudData.upgrades;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 24;
			obj = value;
		}
	}

	public static int currentIntroVideoAdPrizeIndex
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+14C]");
			return 0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 332;
			obj = value;
		}
	}

	public static int currentRandomVideoAdPrizeIndex
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1F8]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int currentVideoAdPrizeSeed
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1FC]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int videosWatchedSinceDailyKeys
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+200]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static Cooldowns cooldowns
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+204]");
			return (Cooldowns)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public AdsSave()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 344;
		obj = this;
	}
}
