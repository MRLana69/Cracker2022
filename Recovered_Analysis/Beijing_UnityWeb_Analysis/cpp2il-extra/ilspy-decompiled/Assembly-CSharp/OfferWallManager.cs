using System;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using UnityEngine;

public class OfferWallManager
{
	private enum RequestStates
	{
		NotStarted,
		InProgress,
		Succeeded,
		Failed
	}

	private const string OFFERWALL_INITIALIZE_FAIL_CODE = "fail";

	private const string OFFERWALL_DISABLED_ONLINE_SETTING = "offerwall_disabled";

	private const string OFFERWALL_EVENT_NAME = "Offerwall";

	private const bool DEFAULT_DISABLED_ONLINE_SETTING = false;

	private const int DEFAULT_REWARDS_REFRESH_INTERVAL_AFTER_FAIL = 30;

	private const int DEFAULT_REWARDS_REFRESH_INTERVAL_AFTER_SUCCESS = 120;

	private Action m_onOfferWallReceived;

	private Action<int> m_onPendingRewardsReceived;

	private static OfferWallManager _instance;

	private RequestStates _requestRewardState;

	private RequestStates _spendRewardState;

	private DateTime _lastTimeRewardsWereRequested;

	private int _amountPendingApprovalToBeRewarded;

	private int _amountApprovedToBeRewarded;

	private string _lastOriginForShow;

	private bool _listenersSet;

	private int MINIMUM_SUPPORTED_ANDROID_API;

	public static OfferWallManager instance
	{
		get
		{
			//IL_005c: Expected I, but got Obj
			//IL_0072: Expected Obj, but got I
			//IL_00a8: Expected I, but got Obj
			//IL_00be: Expected Obj, but got I
			//IL_002b: Expected I, but got Obj
			//IL_0041: Expected Obj, but got I
			nint num = (nint)typeof(AdSystemManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AdSystemManager>)+5C]");
			object obj = -(-64);
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				AdSystemManager adSystemManager = default;
				adSystemManager._003CShow_003Eb__66_0();
				nint num2 = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v21 (Il2CppClass<AdSystemManager>)+5C]");
				object obj2 = -(-64);
				obj2 = adSystemManager;
			}
			nint num3 = (nint)typeof(AdSystemManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<AdSystemManager>)+5C]");
			return (OfferWallManager)(-(-64));
		}
	}

	public bool isOfferWallDisabled
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"Offerwall" != 0;
		}
	}

	public event Action onOfferWallReceived
	{
		add
		{
			//IL_0013: Expected I4, but got Obj
			string msg = string.ConcatArray((string[])(object)"NativeInterstitialHelper: ", (int)value);
			SDebug.LogFormat(msg, null);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onOfferWallReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<int> onPendingRewardsReceived
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onOfferWallReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPendingRewardsReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private string GetSDKAppID()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private string GetSDKAppKey()
	{
		string flurryApiKey = AdConstants.FlurryApiKey;
		return ((AdConstants)(object)flurryApiKey).TapJoyAppKey;
	}

	private string GetSDKEventName()
	{
		string flurryApiKey = AdConstants.FlurryApiKey;
		return (string)(object)((AdConstants)(object)flurryApiKey).TapJoyCacheIDs;
	}

	private bool HasTimeIntervalPassedSinceDate(DateTime lastRequestDateTime, int timeInterval)
	{
		//IL_0005: Expected I, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S5_v2 (Il2CppClass<OfferWallManager>)+10]");
		object obj = (nint)0 & (nint)7;
		object obj2 = obj + 43529;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S5_v5 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public void Initialize()
	{
		_ = 7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void SetListeners()
	{
	}

	public unsafe bool IsOfferWallAllowed()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
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
		return ((OnlineSettings)(object)saveDataPath).TryGetValue("offerwall_disabled", out *(string*)null);
	}

	public void RequestOfferWall()
	{
	}

	public void ShowOfferWall(string origin)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onPendingRewardsReceived;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)origin);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 12;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public bool IsOfferWallReady()
	{
		return false;
	}

	public void GetPendingRewards()
	{
	}

	private void SpendPoints(int amount)
	{
	}

	private void PayoutRewardToUser(int rewardAmount)
	{
	}

	private void OnOfferWallResponse(string message)
	{
		//IL_022f: Expected I4, but got Obj
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I4
		//IL_0111: Expected I, but got Obj
		if ((nint)message <= 0)
		{
			return;
		}
		if (this.m_onPendingRewardsReceived != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v10 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S3_v8 (should have been resolved before IL gen)");
		}
		InventorySave.IncreaseKeys((int)message, "Offerwall");
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v48 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v38 (Il2CppClass<UIScreenController>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 9;
			object obj7 = text + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			object obj8 = default;
			obj7 = obj8;
			((UIScreenController)flag)._QueueMessage(text);
		}
		nint num6 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v28 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v33 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	private void OnInitializeFinished(string s)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)this.m_onOfferWallReceived);
	}

	private void OnViewDidAppear(string viewType)
	{
		//IL_0013: Expected I4, but got Obj
		char c = viewType.get_Chars((int)"fail");
	}

	private void OnViewDidDisappear(string viewType)
	{
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		bool flag = ((OfferWallManager)null).isOfferWallDisabled;
		if (!(viewType != (string)flag))
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v14 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void OnGotPoints(string amount)
	{
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		bool flag = ((OfferWallManager)null).isOfferWallDisabled;
		if (!(amount != (string)flag))
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v14 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void OnGetPointsError()
	{
	}

	private unsafe void OnSpendPoints(string amountOfPointsLeftInUsersBalance)
	{
		//IL_006a: Expected Obj, but got I4
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected I4, but got Obj
		IFormatProvider formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v29 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		formatProvider = (IFormatProvider)0;
		bool flag = ((int*)amountOfPointsLeftInUsersBalance)->System_002EIConvertible_002EToBoolean(formatProvider);
		object obj2 = (flag ? 1 : 0) ^ 1;
		bool flag2 = (nint)formatProvider < 1;
		object obj3 = flag2 | obj2;
		if (obj3 == null)
		{
			_amountPendingApprovalToBeRewarded = (int)formatProvider;
		}
		_requestRewardState = RequestStates.Succeeded;
	}

	private void OnSpendPointsError()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_requestRewardState = RequestStates.Failed;
	}

	private void OnEarnPoints(string amount)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I4
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int amountApprovedToBeRewarded = _amountPendingApprovalToBeRewarded + _amountApprovedToBeRewarded;
		_amountApprovedToBeRewarded = amountApprovedToBeRewarded;
		_amountPendingApprovalToBeRewarded = 0;
		if (_amountApprovedToBeRewarded > -1)
		{
			OnOfferWallResponse((string)_amountApprovedToBeRewarded);
			_amountApprovedToBeRewarded = 0;
		}
		_spendRewardState = RequestStates.Succeeded;
	}

	private void Log(string message)
	{
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public OfferWallManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_spendRewardState = RequestStates.Failed;
	}
}
