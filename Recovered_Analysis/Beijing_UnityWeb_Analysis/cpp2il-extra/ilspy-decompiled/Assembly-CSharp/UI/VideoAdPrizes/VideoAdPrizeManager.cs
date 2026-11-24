using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using UI.Screens.RewardManagement;
using UI.SlideIns;
using UnityEngine;

namespace UI.VideoAdPrizes;

public class VideoAdPrizeManager
{
	public const string LOGGING_SYMBOL = "ENABLE_VIDEO_AD_PRIZE_MANAGER_LOGS";

	private const string ONLINE_SETTING_KEYS_REWARDED_FOR_VIDEO = "keys_rewarded_for_video_ad";

	private const int DEFAULT_NUMBER_OF_KEYS_TO_REWARD_FOR_VIDEO_AD = 2;

	private List<VideoAdPrize> _introPrizePool;

	private List<VideoAdPrize> _randomPrizePool;

	private VideoAdPrize _currentVideoAdPrize;

	private VideoAdPrizePools _videoAdPrizePools;

	private int _currentVideoAdPrizeIndex;

	private PrizePoolState _prizePoolState;

	private static VideoAdPrizeManager _instance;

	public PrizePoolState prizePoolState
	{
		get
		{
			//IL_0030: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			object obj = 0;
			if ((nint)_introPrizePool == 6)
			{
				obj = 4;
			}
			else
			{
				obj = _introPrizePool;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
	}

	public static VideoAdPrizeManager instance
	{
		get
		{
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_017e: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00e2: Expected I, but got Obj
			//IL_0054: Expected I, but got Obj
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 7)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v21 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (VideoAdPrizeManager)(object)DeviceUtility.GetBundleIdentifier();
			}
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hasAdRemovalUpgrade = UserSave.hasAdRemovalUpgrade;
			return (VideoAdPrizeManager)hasAdRemovalUpgrade;
		}
	}

	public void DebugReload()
	{
		_ = 52;
	}

	private VideoAdPrizeManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		VideoAdPrizeManager videoAdPrizeManager = default;
		videoAdPrizeManager.SetVideoAdPrizeIndexes();
		_instance = videoAdPrizeManager;
	}

	private void SetVideoAdPrizeIndexes()
	{
		InitPrizePools();
		InitRandomPrizePool();
		UpdateValueOfCurrentVideoAdPrizeIndex();
		GoToNextVideoAdPrize();
	}

	private void InitPrizePools()
	{
		//IL_02f0: Expected I, but got Obj
		//IL_0306: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		_currentVideoAdPrizeIndex = -1;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v88 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_GET_2_KEYS ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v60 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v82 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Globals.DEBUG_INTRO_VIDEO_AD_PRIZE_INDEX > -1)
			{
				nint num5 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v69 (Il2CppClass<Globals>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v76 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AdsSave.currentRandomVideoAdPrizeIndex = Globals.DEBUG_INTRO_VIDEO_AD_PRIZE_INDEX;
			}
		}
		nint num7 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v53 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_GET_2_KEYS ? 1u : 0u) != 0)
		{
			return;
		}
		nint num9 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v25 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v47 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Globals.DEBUG_RANDOM_VIDEO_AD_PRIZE_INDEX <= -1)
		{
			return;
		}
		nint num11 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v34 (Il2CppClass<Globals>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v41 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AdsSave.currentVideoAdPrizeSeed = Globals.DEBUG_RANDOM_VIDEO_AD_PRIZE_INDEX;
	}

	private void InitRandomPrizePool()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SlideIn slideIn = default;
		slideIn._002Ector();
		object obj = this + 20;
		obj = slideIn;
		object obj2 = this + 8;
		VideoAdPrizePools videoAdPrizePools = _videoAdPrizePools;
		obj2 = videoAdPrizePools.introPrizePool;
	}

	public void GiveReward(UnlockItemSource rewardSource)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		object obj = rewardSource;
		_currentVideoAdPrize = (VideoAdPrize)1;
		string text = ((VideoAdPrize)this).AsString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void GoToNextVideoAdPrize()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		if (_prizePoolState != PrizePoolState.Intro)
		{
			if (_prizePoolState == PrizePoolState.Random)
			{
				object obj = this + 12;
				int videosWatchedSinceDailyKeys = AdsSave.videosWatchedSinceDailyKeys;
				AudioClipInfo slideInSound = ((SlideInData)(object)_videoAdPrizePools).GetSlideInSound((SlideIn)videosWatchedSinceDailyKeys);
				obj = slideInSound;
			}
		}
		else
		{
			UpdatePrizePoolState();
		}
	}

	private void ResetRandomPrizePoolIfAllPrizesTaken()
	{
		if (_prizePoolState != PrizePoolState.Intro)
		{
			if (_prizePoolState == PrizePoolState.Random)
			{
				int currentVideoAdPrizeSeed = AdsSave.currentVideoAdPrizeSeed;
				int currentVideoAdPrizeSeed2 = currentVideoAdPrizeSeed + 1;
				AdsSave.currentVideoAdPrizeSeed = currentVideoAdPrizeSeed2;
				ResetRandomPrizePool();
			}
		}
		else
		{
			int currentRandomVideoAdPrizeIndex = AdsSave.currentRandomVideoAdPrizeIndex;
			int currentRandomVideoAdPrizeIndex2 = currentRandomVideoAdPrizeIndex + 1;
			AdsSave.currentRandomVideoAdPrizeIndex = currentRandomVideoAdPrizeIndex2;
		}
		UpdateValueOfCurrentVideoAdPrizeIndex();
	}

	private void ResetRandomPrizePool()
	{
		int currentVideoAdPrizeSeed = AdsSave.currentVideoAdPrizeSeed;
		List<VideoAdPrize> randomPrizePool = _randomPrizePool;
		if (currentVideoAdPrizeSeed >= randomPrizePool._size && _prizePoolState == PrizePoolState.Random)
		{
			UpdatePrizePoolState();
		}
	}

	public bool IsVideoForKeysAvailable()
	{
		return (byte)_prizePoolState != 0;
	}

	private bool AbleToWatchAVideoForKeysToday()
	{
		if (((VideoAdPrizeManager)null).GetAmountOfKeysRewardedForVideo() != 0)
		{
			VideoAdPrize videoAdPrize = ((VideoAdPrizeManager)null).GetVideoAdPrize();
			return (nint)videoAdPrize > 0;
		}
		return false;
	}

	public DateTime GetLastTimeAVideoForKeysWasSeen()
	{
		//IL_0017: Expected VT, but got I
		int currentVideoAdPrizeIndex = _currentVideoAdPrizeIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (System.Int32)+10]");
		return (DateTime)0;
	}

	public int GetAmountOfKeysRewardedForVideo()
	{
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0244: Expected Obj, but got VT
		//IL_005a: Expected Obj, but got VT
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v48 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastDailyOnlineLog = UserSave.lastDailyOnlineLog;
		obj = lastDailyOnlineLog;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		DateTime lastTimeAppWasUpdatedOrInstalled = UserSave.lastTimeAppWasUpdatedOrInstalled;
		obj = lastTimeAppWasUpdatedOrInstalled;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v44 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		object obj6 = default;
		obj5 = obj6;
		object obj7 = default;
		obj2 = obj7;
		object obj8 = obj2 + 24;
		obj8 = obj5;
		object obj9 = obj2 + 32;
		obj9 = obj2;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		object obj11 = obj9 & 0x3FFFFFFFFFFFFFFFL;
		object obj12;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			obj12 = 1;
		}
		else
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
			object obj13 = (flag ? 1u : 0u) << 31;
			obj12 = obj13 >> 31;
		}
		return (obj12 != null) ? 1 : 0;
	}

	public VideoAdPrize GetVideoAdPrize()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (VideoAdPrize)((OnlineSettings)(object)saveDataPath).GetValue("keys_rewarded_for_video_ad", 2u);
	}

	private void UpdatePrizePoolState()
	{
		//IL_0022: Expected I4, but got Obj
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		AdsSave.currentVideoAdPrizeSeed = 0;
		VideoAdPrize introPoolPrize = ((VideoAdPrizeManager)null).GetIntroPoolPrize();
		AdsSave.videosWatchedSinceDailyKeys = (int)introPoolPrize;
		object obj = this + 12;
		int videosWatchedSinceDailyKeys = AdsSave.videosWatchedSinceDailyKeys;
		AudioClipInfo slideInSound = ((SlideInData)(object)_videoAdPrizePools).GetSlideInSound((SlideIn)videosWatchedSinceDailyKeys);
		obj = slideInSound;
	}

	private bool HasVideoAdPrizeIndexChanged()
	{
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02d3: Expected I4, but got Obj
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v75 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_GET_2_KEYS ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v42 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v69 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Globals.DEBUG_VIDEO_AD_PRIZE_TYPE != VideoAdPrizeType.NotSet)
			{
				nint num5 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v51 (Il2CppClass<Globals>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v63 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = Globals.DEBUG_VIDEO_AD_PRIZE_TYPE;
				_ = 1;
				_ = 0;
				bool result = default;
				return result;
			}
		}
		if (AbleToWatchAVideoForKeysToday())
		{
			VideoAdPrize videoAdPrize = ((VideoAdPrizeManager)null).GetVideoAdPrize();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 6;
			_ = 0;
			object obj4 = this + 16;
			object obj5 = default;
			obj4 = obj5;
		}
		else
		{
			if (GetRandomVideoAdPrizeSeed() == 0)
			{
				VideoAdPrize currentVideoAdPrize = _currentVideoAdPrize;
				if (~(currentVideoAdPrize.hasBeenRewarded__BackingField ? 1u : 0u) != 0)
				{
					goto IL_02c9;
				}
			}
			SetNewVideoAdPrize();
			SetIntroPrize();
		}
		goto IL_02c9;
		IL_02c9:
		return (byte)(int)_currentVideoAdPrize != 0;
	}

	private void UpdateValueOfCurrentVideoAdPrizeIndex()
	{
		List<VideoAdPrize> introPrizePool = _introPrizePool;
		int currentRandomVideoAdPrizeIndex = AdsSave.currentRandomVideoAdPrizeIndex;
		if (introPrizePool._size > currentRandomVideoAdPrizeIndex)
		{
			_prizePoolState = PrizePoolState.Intro;
			return;
		}
		List<VideoAdPrize> introPrizePool2 = _introPrizePool;
		int currentRandomVideoAdPrizeIndex2 = AdsSave.currentRandomVideoAdPrizeIndex;
		if (introPrizePool2._size <= currentRandomVideoAdPrizeIndex2)
		{
			_prizePoolState = PrizePoolState.Random;
		}
	}

	private int GetRandomVideoAdPrizeSeed()
	{
		if (_prizePoolState != PrizePoolState.Intro)
		{
			if (_prizePoolState == PrizePoolState.Random)
			{
				int currentVideoAdPrizeSeed = AdsSave.currentVideoAdPrizeSeed;
				return (_currentVideoAdPrizeIndex != currentVideoAdPrizeSeed) ? 1 : 0;
			}
			return 0;
		}
		int currentRandomVideoAdPrizeIndex = AdsSave.currentRandomVideoAdPrizeIndex;
		return (_currentVideoAdPrizeIndex != currentRandomVideoAdPrizeIndex) ? 1 : 0;
	}

	private void SetNewVideoAdPrize()
	{
		if (_prizePoolState != PrizePoolState.Intro)
		{
			if (_prizePoolState == PrizePoolState.Random)
			{
				int currentVideoAdPrizeSeed = AdsSave.currentVideoAdPrizeSeed;
				_currentVideoAdPrizeIndex = currentVideoAdPrizeSeed;
			}
		}
		else
		{
			int currentRandomVideoAdPrizeIndex = AdsSave.currentRandomVideoAdPrizeIndex;
			_currentVideoAdPrizeIndex = currentRandomVideoAdPrizeIndex;
		}
	}

	private void SetIntroPrize()
	{
		if (_prizePoolState != PrizePoolState.Intro)
		{
			if (_prizePoolState == PrizePoolState.Random)
			{
				Log(this);
			}
		}
		else
		{
			SetRandomPrize();
		}
	}

	private VideoAdPrize GetIntroPoolPrize()
	{
		//IL_0257: Expected Obj, but got I4
		//IL_0265: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I8
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f5: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_033d: Expected Obj, but got I4
		//IL_01bd: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v63 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ENABLE_GET_2_KEYS ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v35 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v57 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Globals.DEBUG_RANDOM_VIDEO_AD_PRIZE_SEED >= 0)
			{
				nint num5 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v44 (Il2CppClass<Globals>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v51 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (VideoAdPrize)Globals.DEBUG_RANDOM_VIDEO_AD_PRIZE_SEED;
			}
		}
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v30 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj = systemTimeAsFileTime;
		int[] values = (int[])(obj & 0x3FFFFFFFFFFFFFFFL);
		nint num9 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v18 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num11 = Mathf.Min(values);
		return (VideoAdPrize)num11;
	}

	private void SetRandomPrize()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 16;
		IEnumerator enumerator = ((UISlideIn)this).PreloadSlideIn();
		obj = enumerator;
	}

	public static void Log(object message)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I
		object obj = message + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ L0 (System.Object)+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ L0 (System.Object)+18]");
		VideoAdPrize videoAdPrize = ((List<VideoAdPrize>)num).get_Item(0);
		obj = videoAdPrize;
	}
}
