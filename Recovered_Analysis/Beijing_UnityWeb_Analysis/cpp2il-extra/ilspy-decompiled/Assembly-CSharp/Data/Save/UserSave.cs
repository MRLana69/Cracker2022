using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save.Internal;
using InApp;
using Info;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Components.Analytics.Integration;
using SYBO.Subway.Info;
using UI.Breadcrumbs;
using UnityEngine;

namespace Data.Save;

public class UserSave : DataManager<UserSave>
{
	private static Action m_onKnownServerTimeChange;

	public static bool hasMigratedPlayerInfo
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+144]");
			return false;
		}
		set
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I4
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UserSave.m_onKnownServerTimeChange;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)UserSave.m_onKnownServerTimeChange == obj2)
				{
					UserSave.m_onKnownServerTimeChange = action;
				}
				if ((object)UserSave.m_onKnownServerTimeChange != obj2)
				{
					obj2 = UserSave.m_onKnownServerTimeChange;
					continue;
				}
				break;
			}
		}
	}

	public static int migratedPlayerPrefsVersion
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (cloudData.obfuscatedCoins != 0) ? 1 : 0;
		}
		set
		{
			CloudData cloudData = DataManager<>.cloud;
			int obfuscatedCoins = value & 1;
			cloudData.obfuscatedCoins = obfuscatedCoins;
		}
	}

	public static DateTime lastKnownServerTime
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+88]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static bool hasPurchasedOrRestored
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (byte)cloudData.obfuscatedKeys != 0;
		}
	}

	public unsafe static int inAppLegacyPurchaseCount
	{
		get
		{
			//IL_0234: Expected I, but got Obj
			//IL_024a: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_01bd: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = inAppNonConsumablePurchaseCount;
			if (num3 < 1)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v51 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num6 = inAppRestoredPurchaseCount;
				if (num6 < 1)
				{
					nint num7 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num8 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v47 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, string> dictionary = inAppPurchaseHistory;
					if ((nint)dictionary < 1)
					{
						nint num9 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num10 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v43 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num11 = inAppConsumablePurchaseCount;
						return (num11 > 0) ? 1 : 0;
					}
					return 1;
				}
				return 1;
			}
			return 1;
		}
		set
		{
			//IL_0068: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_008b: Expected I4, but got Obj
			//IL_0099: Expected I, but got Obj
			//IL_00af: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			object obj = ((int*)value)->m_value;
			object obj2 = obj + 8;
			obj2 = obj;
			cloudData.missionSetCompletedCount = (int)obj2;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v12 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TransformExtensions.Reset((Transform)(object)UserSave.m_onKnownServerTimeChange);
		}
	}

	public static int inAppConsumablePurchaseCount
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+15C]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int inAppNonConsumablePurchaseCount
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+160]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int inAppRestoredPurchaseCount
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+168]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static Dictionary<string, string> inAppPurchaseHistory
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+164]");
			return (Dictionary<string, string>)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool isFreshInstall
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1B8]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 440;
			obj = value;
		}
	}

	public static DateTime lastDailyOnlineLog
	{
		get
		{
			//IL_0018: Expected VT, but got I4
			CloudData cloudData = DataManager<>.cloud;
			return (DateTime)cloudData.missionSetCompletedCount;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static DateTime lastPlayDate
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+170]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static DateTime lastQuitDate
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+178]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public unsafe static InAppData.BundleTier lastPurchasedBundle
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+16C]");
			return ((nint)0 != 0) ? InAppData.BundleTier.BundleTier1 : InAppData.BundleTier.None;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = ((InAppData.BundleTier*)(int)value)->value__;
			object obj2 = obj + 8;
			obj2 = obj;
		}
	}

	public static bool hasPaidOutFacebookReward
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+188]");
			return false;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool allAssetBundlesDownloaded
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+18C]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int latestAvailableAssetBundlesVersion
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (cloudData.awardsProgress != null) ? 1 : 0;
		}
		set
		{
			//IL_0029: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			int num = value & 1;
			cloudData.awardsProgress = (Dictionary<AwardId, PersistentAwardProgress>)num;
		}
	}

	public static Dictionary<Characters.CharacterId, HashSet<int>> characterOutfitsSeen
	{
		private get
		{
			//IL_001b: Expected Obj, but got I
			CloudData cloudData = DataManager<>.cloud;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.CloudData)+84]");
			return (Dictionary<Characters.CharacterId, HashSet<int>>)0;
		}
		set
		{
			CloudData cloudData = DataManager<>.cloud;
		}
	}

	public static CollectCoinsDummy[] collectCoinsDummyData
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1AC]");
			return (CollectCoinsDummy[])0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 428;
			obj = value;
		}
	}

	public static bool hasSeenFrontScreenFirstTime
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1B0]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 432;
			obj = value;
		}
	}

	public static bool hasMadeOneValidPurchase
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+18D]");
			return (nint)0 != 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static DateTime firstInstallDate
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+180]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static string firstInstalledVersion
	{
		get
		{
			//IL_002d: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+18E]");
			bool flag = (nint)0 != 0;
			return (string)flag;
		}
		set
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value + 8;
			obj = value;
		}
	}

	public static bool hasAdRemovalUpgrade
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+190]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 400;
			obj = value;
		}
	}

	public static bool hasDoubleCoinsUpgrade
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1A1]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_0048: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1A1]");
			bool flag = (nint)0 != 0;
			object obj = flag ^ value;
			if (obj != null)
			{
				LocalDebugData localDebugData2 = DataManager<>.localDebug;
			}
		}
	}

	public static Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen
	{
		get
		{
			//IL_002d: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1A0]");
			bool flag = (nint)0 != 0;
			return (Dictionary<Characters.CharacterId, bool>)flag;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value & 1;
		}
	}

	public static Dictionary<Boards.BoardId, bool> hasBoardBeenSeen
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1A4]");
			return (Dictionary<Boards.BoardId, bool>)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 420;
			obj = value;
		}
	}

	public static Dictionary<EarnCoinsData.Id, string> earnCurrencyData
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1A8]");
			return (Dictionary<EarnCoinsData.Id, string>)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 424;
			obj = value;
		}
	}

	public static string lastVersionRated
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1B4]");
			return (string)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 436;
			obj = value;
		}
	}

	public static DateTime lastTimeAVideoForKeysWasSeen
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+198]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static DateTime lastTimeAppWasUpdatedOrInstalled
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1E8]");
			return (DateTime)0;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected I8, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager._nextRewardUid = (long)value;
		}
	}

	public unsafe static int numberOfBreadCrumbsShownOnFrontPage
	{
		get
		{
			//IL_0018: Expected I4, but got VT
			CloudData cloudData = DataManager<>.cloud;
			return (int)cloudData.currentSkipForVideoIndexSetAt;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_003e: Expected VT, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			object obj = ((int*)value)->m_value;
			object obj2 = obj + 8;
			obj2 = obj;
			cloudData.lastTimeMissionWasSkippedForVideo = (DateTime)obj2;
		}
	}

	public static int ageRestrictionInputVersion
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1BC]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int ageRestrictionInputMonth
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1C0]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int ageRestrictionInputYear
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1C4]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static DateTime welcomePackStartTime
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return cloudData.lastTimeMissionWasSkippedForVideo;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public unsafe static bool cloudSaveEnabled
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1C8]");
			return false;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = ((bool*)(value ? 1 : 0))->m_value;
			object obj2 = obj + 8;
			obj2 = obj;
		}
	}

	public static DateTime latestSuccessfulCloudSaveSyncTime
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1F0]");
			return (DateTime)0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static DateTime lastCloudSaveReminderShownTime
	{
		get
		{
			//IL_0018: Expected VT, but got I4
			CloudData cloudData = DataManager<>.cloud;
			return (DateTime)cloudData.unreportedGames;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected I8, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager._nextRewardUid = (long)value;
		}
	}

	public unsafe static bool hasCloudSaveCelebrationBeenShown
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return cloudData.hasSkippedMissionForVideoThisSet;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_003e: Expected VT, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			object obj = ((bool*)(value ? 1 : 0))->m_value;
			object obj2 = obj + 8;
			obj2 = obj;
			cloudData.unreportedGamesTimeStamp = (DateTime)obj2;
		}
	}

	public static int introductionPopupShownCount
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (cloudData.highScore != 0) ? 1 : 0;
		}
		set
		{
			CloudData cloudData = DataManager<>.cloud;
			int highScore = value & 1;
			cloudData.highScore = highScore;
		}
	}

	public static bool hasUserRunAppBefore
	{
		get
		{
			//IL_0018: Expected I4, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			return (byte)(int)cloudData.unlockedTrophies != 0;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			cloudData.unlockedTrophies = (bool[])value;
		}
	}

	public static Breadcrumb.BreadcrumbSave breadcrumbs
	{
		get
		{
			//IL_002d: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+16D]");
			bool flag = (nint)0 != 0;
			return (Breadcrumb.BreadcrumbSave)flag;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value & 1;
		}
	}

	public static SSEventType lastEventTypeShown
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1CC]");
			return SSEventType.None;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 460;
			obj = value;
		}
	}

	public static DateTime lastEventShownTimestamp
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return cloudData.unreportedGamesTimeStamp;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static string lastSeenBundleVersion
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1D0]");
			return (string)0;
		}
		set
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value + 8;
			obj = value;
		}
	}

	public static event Action onKnownServerTimeChange
	{
		add
		{
			((DataManager<>)(object)value).OnSaveGameChanged();
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UserSave.m_onKnownServerTimeChange;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)UserSave.m_onKnownServerTimeChange == obj2)
				{
					UserSave.m_onKnownServerTimeChange = action;
				}
				if ((object)UserSave.m_onKnownServerTimeChange != obj2)
				{
					obj2 = UserSave.m_onKnownServerTimeChange;
					continue;
				}
				break;
			}
		}
	}

	public static void OutfitSeen(Characters.CharacterId character, int index)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		object obj = index;
		SampleState syboAnalyticsSampleState = SyboAnalyticsSave.syboAnalyticsSampleState;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 <= -1)
		{
			SampleState syboAnalyticsSampleState2 = SyboAnalyticsSave.syboAnalyticsSampleState;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v6+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v7+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public unsafe static bool IsCharacterOutfitSeen(Characters.CharacterId character, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_00c3: Expected I, but got Obj
		//IL_0312: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj3 = num + 16;
		obj3 = 58;
		string text = ((string)character).Substring(num);
		object obj4 = text.m_firstChar - 3;
		if (text.m_firstChar != '\u0003')
		{
			if ((nint)obj4 == 1)
			{
				((int*)index)->m_value = 0;
			}
			else
			{
				object msg = ((IConvertible)"Unexpected number of parameters: ").ToType((Type)character, (IFormatProvider)(object)". Aborting parsing.");
				SDebug.LogFormat((string)msg, null);
				((int*)index)->m_value = 0;
			}
			bool result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj5 = text + 20;
		nint num2 = (nint)typeof(bool);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v80 (Il2CppClass<System.Boolean>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v114 (Il2CppClass<System.Boolean>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj8 = default;
		object obj7 = obj8 & 1;
		object obj9 = text + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		int value = default;
		((int*)index)->m_value = value;
		int value2 = ((int*)index)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v101 (System.Int32)+10]");
		if ((nint)0 <= (nint)25)
		{
			return true;
		}
		int value3 = ((int*)index)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v105 (System.Int32)+10]");
		object obj10 = -25;
		return true;
	}

	public static void IncrementNumberOfBreadCrumbsShownOnFrontPage()
	{
		Dictionary<string, string> syboAnalyticsUnhandledAbTestData = SyboAnalyticsSave.syboAnalyticsUnhandledAbTestData;
		throw new IndexOutOfRangeException();
	}

	public UserSave()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 480;
		obj = this;
	}

	static UserSave()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ageRestrictionInputVersion;
		int num4 = num3 + 1;
		ageRestrictionInputVersion = num4;
	}
}
