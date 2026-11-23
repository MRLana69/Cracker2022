using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Monetization.Offerwall;
using UnityEngine;

public class OfferWallManager
{
	private static OfferWall _offerWall = null;

	private bool _isInitialized;

	private List<IDisplayableOffer> _currentOffers;

	private static readonly List<string> ALLOWED_REFRESH_SCREENS;

	private static OfferWallManager _instance;

	private Action<List<IDisplayableOffer>, bool> m_onOffersReceived;

	private Action m_onOffersRequestFailed;

	private Action<int> m_onPendingRewardsReceived;

	private Action m_onPendingRewardsRequestFailed;

	public List<IDisplayableOffer> CurrentOffers
	{
		get
		{
			bool flag = _currentOffers == null;
			bool flag2 = !flag;
			List<IDisplayableOffer> result = _currentOffers;
			if (!flag2)
			{
				List<IDisplayableOffer> list = default;
				list._002Ector();
				result = list;
			}
			return result;
		}
	}

	public static OfferWallManager Instance
	{
		get
		{
			if (_instance == null)
			{
				OfferWallManager instance = default;
				_instance = instance;
			}
			return _instance;
		}
	}

	public event Action<List<IDisplayableOffer>, bool> onOffersReceived
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onOffersReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onOffersReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onOffersRequestFailed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_onOffersRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_onOffersRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<int> onPendingRewardsReceived
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_onPendingRewardsReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_onPendingRewardsReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onPendingRewardsRequestFailed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_onPendingRewardsRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_onPendingRewardsRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private OfferWallManager()
	{
	}

	public bool AreOffersAllowedOnDevice()
	{
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return _offerWall.AreOffersAllowedOnDevice();
		}
		return false;
	}

	public void Initialize()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			OfferWall offerWall = default;
			offerWall._002Ector();
			_offerWall = offerWall;
			throw new ArgumentException();
		}
	}

	private void OnOffersReceived(List<IDisplayableOffer> offers, bool cached)
	{
		if (offers != null && offers._size >= 1)
		{
			_currentOffers = offers;
		}
		Action<List<IDisplayableOffer>, bool> action = this.m_onOffersReceived;
		if (this.m_onOffersReceived != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S0_v9 (System.Action`2<System.Collections.Generic.List`1<Kiloo.Monetization.Offerwall.IDisplayableOffer>, System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	public void RefreshOffers(bool bypassTimeLimitsEnforcedByOutside = false)
	{
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			_offerWall.RefreshOffers(bypassTimeLimitsEnforcedByOutside);
		}
	}

	public void GetPendingRewards(bool bypassTimeLimitsEnforcedByOutside = false)
	{
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			_offerWall.GetPendingRewards(bypassTimeLimitsEnforcedByOutside);
		}
	}

	private unsafe void PayoutRewardToUser(int rewardAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		//IL_0163: Expected F8, but got Obj
		//IL_00db: Expected F8, but got I4
		//IL_01a0: Expected I4, but got F8
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected I4, but got Unknown
		//IL_00cd: Expected F8, but got Obj
		object obj = default;
		OfferWallManager offerWallManager = (OfferWallManager)(obj - 16);
		offerWallManager._currentOffers = (List<IDisplayableOffer>)rewardAmount;
		offerWallManager._isInitialized = false;
		if (rewardAmount >= 1)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			int amountOfCoins = instance.amountOfCoins;
			int amountOfCoins2 = amountOfCoins + rewardAmount;
			instance.amountOfCoins = amountOfCoins2;
			int num = offerWallManager + 12;
			string offerAmount = ((int*)num)->ToString();
			string rewardAmountCategoryForValue = offerWallManager.GetRewardAmountCategoryForValue(offerAmount);
			if (UIScreenController.IsInstanced)
			{
				UIScreenController instance2 = UIScreenController.Instance;
				double num2 = Math.Abs((double)offerWallManager._currentOffers);
				double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)offerWallManager._currentOffers));
				offerWallManager._isInitialized = (byte)(int)num3 != 0;
				int num4 = offerWallManager + 8;
				string payload = ((int*)num4)->ToString();
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.OfferWall, payload);
				instance2.QueueSlideIn(slideIn);
			}
			Action<int> action = this.m_onPendingRewardsReceived;
			if (this.m_onPendingRewardsReceived != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S0_v32 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe void OfferClicked(IDisplayableOffer offer, CoinEarnerLoadingOffer.OfferSourceScreen source, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected I4, but got Unknown
		//IL_00ef: Expected Obj, but got I
		object obj = default;
		OfferWallManager offerWallManager = (OfferWallManager)(obj - 16);
		offerWallManager._currentOffers = (List<IDisplayableOffer>)index;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string offerAmount = default;
		string rewardAmountCategoryForValue = offerWallManager.GetRewardAmountCategoryForValue(offerAmount);
		bool flag = source == CoinEarnerLoadingOffer.OfferSourceScreen.OfferWallPopup;
		object obj2 = "Offer Clicked Reward";
		if (!flag)
		{
			obj2 = "Daily report of coins";
		}
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S5_v4+4] (should have been resolved before IL gen)");
		int num5 = offerWallManager + 12;
		string text = ((int*)num5)->ToString();
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S5_v9+4] (should have been resolved before IL gen)");
		if (flag)
		{
		}
	}

	private unsafe string GetRewardAmountCategoryForValue(string offerAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Ref, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		//IL_006d: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		bool flag = int.TryParse(offerAmount, out *(int*)(obj + 12));
		bool flag2 = !flag;
		string result = string.Empty;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = (nint)0 / (nint)100;
			object obj4 = obj3 * 100;
			int num = obj + 8;
			string text = ((int*)num)->ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj5 = (nint)0 / (nint)100;
			object obj6 = obj5 * 100;
			object obj7 = obj6 + 99;
			int num2 = obj + 8;
			string text2 = ((int*)num2)->ToString();
			string text3 = text + " - " + text2;
			result = text3;
		}
		return result;
	}

	private void RefreshPendingRewardsOnScreenShow(string screenName)
	{
		if (ALLOWED_REFRESH_SCREENS.Contains(screenName))
		{
			GetPendingRewards();
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "OfferWallManager: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static OfferWallManager()
	{
		List<string> list = default;
		list._002Ector();
		list.Add("CoinsUI_shop");
		list.Add("UpgradesUI_shop");
		list.Add("EarnCoinsScreen");
		list.Add("AwardsScreen");
		list.Add("BoardScreen");
		list.Add("CharacterScreen");
		list.Add("FriendsUI");
		list.Add("LeaderboardUI");
		list.Add("FrontUI");
		ALLOWED_REFRESH_SCREENS = list;
		_instance = null;
	}
}
