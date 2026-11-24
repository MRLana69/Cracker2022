using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Ads;
using Kiloo.Common.LocalizationManager;
using SYBO.Subway;
using SYBO.Subway.Inputs;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Popups.LimitedBoardPopupInternal;
using UnityEngine;

namespace UI.Popups.ConsumablesPopupInternal;

public class SellConsumablesHelper
{
	private int _purchaseCount;

	private bool _purchaseInProgress;

	private readonly UIScreenController _screenController;

	private static Dictionary<UpgradeType, int> _defaultVideoRewardAmounts;

	private static Dictionary<UpgradeType, string> _videoRewardAmountOSKeys;

	public static Action<InAppItemModel.ItemType, int> OnRewardWithVideo;

	public static Dictionary<UpgradeType, int> defaultVideoRewardAmounts
	{
		get
		{
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0210: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0130: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_01c6: Expected Obj, but got I
			//IL_00c7: Expected I, but got Obj
			//IL_00f7: Expected I, but got Obj
			//IL_011d: Expected I, but got Obj
			nint num = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (LimitedBoardPopupManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				LimitedBoardPopupManager limitedBoardPopupManager = default;
				limitedBoardPopupManager.Initialize();
				nint num3 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 == null;
				nint num4 = (nint)typeof(LimitedBoardPopupManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(LimitedBoardPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(LimitedBoardPopupManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(LimitedBoardPopupManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				obj3 = limitedBoardPopupManager;
			}
			nint num6 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Dictionary<UpgradeType, int>)(object)LimitedBoardPopupManager._instance;
		}
	}

	public static Dictionary<UpgradeType, string> videoRewardAmountOSKeys
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SellConsumablesHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Dictionary<UpgradeType, string>)(object)_defaultVideoRewardAmounts;
		}
	}

	private SellableConsumable activeConsumable
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper)+1C]");
			return (SellableConsumable)0;
		}
	}

	public SellConsumablesHelper()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got VT
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e0: Expected I4, but got Obj
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v27 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = GlobalColors.COUNTRY_POPUP_NORMAL_CELL_TEXT_COLOUR;
		object obj4 = obj3 + 8;
		obj4 = obj2;
		object obj5 = obj3 + 16;
		obj5 = obj4;
		_purchaseInProgress = (byte)(int)obj5 != 0;
		object obj6 = obj3 + 4;
		obj6 = GlobalColors.COUNTRY_POPUP_SELECTED_CELL_TEXT_COLOUR;
		obj3 = obj6;
		obj5 = obj3;
		_screenController = (UIScreenController)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void DidShowConsumablesPopup()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		obj2 = flag;
	}

	public void DidHideConsumablesPopup()
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		((Game)isInstantiated).HandleProductionInput(InputType.SwipeUp);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73B9");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		_purchaseCount = 0;
	}

	public void MakePurchase(bool isInRun, Action OnPurchaseSuccessful = null, Action OnPurchaseFailed = null)
	{
		//IL_00c7: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0038: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		if ((string)isInRun == "com.kiloo.subwaysurfers.welcomePackTier01" && !((string)isInRun != "com.kiloo.subwaysurfers.welcomePackTier02"))
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((WelcomePackPopup)null)._002Ector();
	}

	public bool IsConsumableVideoCached(bool isInRun)
	{
		//IL_01ef: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_01c7: Expected I4, but got Obj
		//IL_00b7: Expected Obj, but got I
		OfferWallManager instance = OfferWallManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isInRun @ L1 (System.Boolean)+8]");
		object format;
		if (((AdSystemManager)(object)instance).HasPriorityListWrapped((string)0))
		{
			OfferWallManager instance2 = OfferWallManager.instance;
			if (((AdSystemManager)(object)instance2).IsCached((AdLocationInfo)isInRun))
			{
				format = "ready";
			}
			else
			{
				OfferWallManager instance3 = OfferWallManager.instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isInRun @ L1 (System.Boolean)+8]");
				if (((NativeInterstitialHelper)(object)instance3).UpdateAdObject((NativeInterstitialAdObject)0))
				{
					format = "pending";
				}
				else
				{
					OfferWallManager instance4 = OfferWallManager.instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isInRun @ L1 (System.Boolean)+8]");
					string lastShowedProviderForLocation = ((AdSystemManager)(object)instance4).GetLastShowedProviderForLocation((string)0);
					format = ((lastShowedProviderForLocation == null) ? "not cached" : "caching");
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isInRun @ L1 (System.Boolean)+C]");
			if ((nint)0 == 0)
			{
				OfferWallManager instance5 = OfferWallManager.instance;
				string idOfAdlocationBeingShown = ((AdSystemManager)(object)instance5).GetIdOfAdlocationBeingShown();
				bool flag = idOfAdlocationBeingShown == null;
				format = "n/a";
				if (flag)
				{
					goto IL_0211;
				}
			}
			format = "off";
		}
		goto IL_0211;
		IL_0211:
		OfferWallManager instance6 = OfferWallManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isInRun @ L1 (System.Boolean)+8]");
		string currentProviderIDForLocation = ((AdSystemManager)(object)instance6).GetCurrentProviderIDForLocation((string)0);
		string adLocationStatus = ((SecretPopup)null).GetAdLocationStatus((AdLocationInfo)(object)currentProviderIDForLocation);
		OfferWallManager instance7 = OfferWallManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isInRun @ L1 (System.Boolean)+8]");
		bool availabilityForLocation = ((AdSystemManager)(object)instance7).GetAvailabilityForLocation((string)0);
		string adLocationStatus2 = ((SecretPopup)null).GetAdLocationStatus((AdLocationInfo)availabilityForLocation);
		return (byte)(int)string.Format((IFormatProvider)(object)"{0}      lp: {1}      cp: {2}", (string)format, adLocationStatus, adLocationStatus2) != 0;
	}

	public bool IsConsumableVideoLocationAvailable(bool isInRun)
	{
		//IL_0041: Expected Obj, but got I4
		int consumableRewardForVideo = GetConsumableRewardForVideo(isInRun);
		if (consumableRewardForVideo != 0)
		{
			OfferWallManager instance = OfferWallManager.instance;
			return ((AdSystemManager)(object)instance).IsCaching((string)consumableRewardForVideo);
		}
		return false;
	}

	private string GetVideoIdForConsumable(bool isInRun)
	{
		//IL_007e: Expected Obj, but got I4
		AdLocationInfo adLocationInfo = GetAdLocationInfo(isInRun);
		if (adLocationInfo == null || adLocationInfo.id == null)
		{
			return null;
		}
		OfferWallManager instance = OfferWallManager.instance;
		bool flag = ((AdSystemManager)(object)instance).HasPriorityListWrapped((string)(object)adLocationInfo);
		return (string)flag;
	}

	public AdLocationInfo GetAdLocationInfo(bool isInRun)
	{
		//IL_0015: Expected Obj, but got I
		int consumableRewardForVideo = GetConsumableRewardForVideo(isInRun);
		bool flag = consumableRewardForVideo == 0;
		AdLocationInfo result = (AdLocationInfo)(object)"";
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v8 (System.Int32)+8]");
			result = (AdLocationInfo)0;
		}
		return result;
	}

	public int GetConsumableRewardForVideo(bool isInRun)
	{
		//IL_03ab: Expected I, but got Obj
		//IL_03c1: Expected Obj, but got I
		//IL_0477: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_03ec: Expected I, but got Obj
		//IL_01f3: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I
		//IL_044d: Expected I4, but got Obj
		//IL_0234: Expected I, but got Obj
		//IL_0281: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_045b: Expected I4, but got Obj
		//IL_02c2: Expected I, but got Obj
		//IL_030f: Expected I, but got Obj
		//IL_0325: Expected Obj, but got I
		//IL_0469: Expected I4, but got Obj
		//IL_0350: Expected I, but got Obj
		if (isInRun)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v22+8]");
			object obj = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v22+8]");
			if ((nint)0 != 1)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2)
					{
						nint num = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v41 (Il2CppClass<AdLocations>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(AdLocations);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v48 (Il2CppClass<AdLocations>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return (int)AdLocations.HEADSTART_RUN_VIDEOS;
					}
					if ((nint)obj != 3 && (nint)obj != 4 && (nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9 && (nint)obj != 10 && (nint)obj != 11 && (nint)obj != 12 && (nint)obj != 13 && (nint)obj == 14)
					{
						nint num3 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v55 (Il2CppClass<AdLocations>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num4 = (nint)typeof(AdLocations);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v62 (Il2CppClass<AdLocations>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return (int)AdLocations.SCOREBOOSTER_RUN_VIDEOS;
					}
				}
				return 0;
			}
			nint num5 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v26 (Il2CppClass<AdLocations>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v33 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)AdLocations.HOVERBOARD_RUN_VIDEOS;
		}
		nint num7 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<AdLocations>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v15 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (int)AdLocations.HOVERBOARD_POPUP_VIDEOS;
	}

	public SellableConsumable GetConsumableReward(bool isInRun)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I4
		//IL_00e2: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_01bd: Expected I, but got Obj
		if (GetConsumableUpgradeType(isInRun) != UpgradeType._notset)
		{
			nint num = (nint)typeof(SellConsumablesHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v54 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v4 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v5+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v6+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S3_v5 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 > -1)
			{
				nint num4 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num5 = (nint)typeof(SellConsumablesHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v48 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<UpgradeType, int> dictionary = _defaultVideoRewardAmounts;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (Info.UpgradeType)+8]");
				int num6 = dictionary.get_Item(UpgradeType._notset);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B30");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v12 (Il2CppMethodInfo)+C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v13+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S2_v14+44]");
				object obj11 = 0;
				object obj12 = obj11 & 0x1FFF;
				object obj13 = obj12 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S3_v10 (should have been resolved before IL gen)");
				object obj14 = default;
				bool flag = (nint)obj14 > -1;
				bool flag2 = !flag;
				int num8 = num6;
				if (!flag2)
				{
					nint num9 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num10 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v44 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string saveDataPath = OnlineSettings.GetSaveDataPath();
					nint num11 = (nint)typeof(SellConsumablesHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v18 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num12 = (nint)typeof(SellConsumablesHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v25 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B30");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (Info.UpgradeType)+8]");
					Dictionary<UpgradeType, string> dictionary2 = default;
					string key = dictionary2.get_Item(UpgradeType._notset);
					uint value = ((OnlineSettings)(object)saveDataPath).GetValue(key, (uint)num6);
					num8 = (int)value;
				}
				return (SellableConsumable)num8;
			}
			return null;
		}
		return null;
	}

	public UpgradeType GetConsumableUpgradeType(bool isInRun)
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00c9: Expected I4, but got Obj
		//IL_0063: Expected I, but got Obj
		if (isInRun)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
			UpgradeType result = default;
			return result;
		}
		nint num = (nint)typeof(SellableConsumable);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<Info.SellableConsumable>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SellableConsumable);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v15 (Il2CppClass<Info.SellableConsumable>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (UpgradeType)SellableConsumable.hoverboard;
	}

	public void ShowVideoForConsumable(bool isInRun, Action onVideoFinished)
	{
		//IL_001e: Expected I4, but got Obj
		//IL_001e: Expected Obj, but got I4
		((UILabel)(object)_screenController).fontSize = (isInRun ? 1 : 0);
		((UILabel)_purchaseInProgress).fontSize = (int)onVideoFinished;
	}

	private void LogPurchases()
	{
		//IL_001c: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I
		_screenController.SwitchScreen("IngameUI");
		CloudSaveConfirmationPopupPayload.activePayload = (CloudSaveConfirmationPopupPayload)(object)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9+8]");
		((Cooldown)0).id = (string)_purchaseCount;
	}

	private unsafe static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected VT, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I
		//IL_0049: Expected F4, but got I4
		//IL_0044: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_001b: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0308: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I
		//IL_032d: Expected Obj, but got F4
		//IL_033a: Expected F4, but got Obj
		//IL_0335: Expected native int or pointer, but got VT
		//IL_0354: Expected F4, but got Obj
		//IL_034f: Expected native int or pointer, but got VT
		//IL_0369: Expected F4, but got I
		//IL_0364: Expected native int or pointer, but got VT
		//IL_037e: Expected I4, but got VT
		//IL_037e: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_02b9: Expected F4, but got I
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02cf: Expected I4, but got Obj
		//IL_0391: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 16;
		object obj3 = msg + 28;
		obj3 = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
		if ((Locale)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
			((UILabel)0).fontSize = (int)"";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
			((Component)0).tag = null;
			return;
		}
		((Matrix4x4*)(nint)matrix4x)->m00 = (int)msg.m_firstChar;
		bool soundEffectsEnabled = PreferencesSave.soundEffectsEnabled;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v25 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v60 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
		float m;
		bool flag3;
		if ((Locale)num3 != (Locale)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
			object obj5 = 0;
			bool flag = soundEffectsEnabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v33+18]");
			if (!((string)flag != (string)0))
			{
				bool flag2;
				if (soundEffectsEnabled)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (System.Boolean)+8]");
					flag2 = (nint)0 == 0;
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					m = matrix4x.m00;
					flag3 = false;
					goto IL_02f8;
				}
			}
			Matrix4x4 matrix4x2 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
			((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
			m = matrix4x.m00;
			flag3 = (byte)(int)"icon_character_selected" != 0;
		}
		else
		{
			m = matrix4x.m00;
			flag3 = false;
		}
		goto IL_02f8;
		IL_02f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v16+1C]");
		((UILabel)num4).fontSize = 0;
		obj2 = m;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Matrix4x4 matrix4x4 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
		((UISprite)0).fillCenter = flag3;
		bool flag4;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ L2_v4 (System.Boolean)+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		string tag = (string)((flag4 ? 1 : 0) ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
		((Component)0).tag = tag;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}
}
