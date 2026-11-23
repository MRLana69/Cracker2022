using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Monetization.Offerwall;

public class OfferWall
{
	private List<IOfferWallProvider> _providers;

	private IOfferWallProvider _activeProvider;

	private IOfferWallDataManager _dataManager;

	private Action<List<IDisplayableOffer>, bool> m_onOffersReceived;

	private Action m_onOffersRequestFailed;

	private Action<int> m_onPendingRewardsReceived;

	private Action m_onPendingRewardsRequestFailed;

	private Action<OffersResponseData> m_notifyOffersReceivedVSOffersRequested;

	public event Action<List<IDisplayableOffer>, bool> onOffersReceived
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
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
			object obj = this + 20;
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
			object obj = this + 24;
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
			object obj = this + 24;
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
			object obj = this + 28;
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
			object obj = this + 28;
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
			object obj = this + 32;
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
			object obj = this + 32;
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

	public event Action<OffersResponseData> notifyOffersReceivedVSOffersRequested
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_notifyOffersReceivedVSOffersRequested;
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
			object obj = this + 36;
			Delegate obj2 = this.m_notifyOffersReceivedVSOffersRequested;
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

	public bool AreOffersAllowedOnDevice()
	{
		if (((OfferWall)null).IsSupportedOnPlatform())
		{
			bool flag = IsOfferWallDisabled();
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		return false;
	}

	public void Initialize(IOfferWallDataManager dataManager, List<IOfferWallProvider> possibleProviders)
	{
		_dataManager = dataManager;
		_providers = possibleProviders;
		if (AreOffersAllowedOnDevice())
		{
			if (dataManager != null && possibleProviders != null)
			{
				ChangeActiveProvider();
			}
			else
			{
				LogError("The OfferWall cannot be initialized due to faulty parameters!");
			}
		}
	}

	public void RefreshOffers(bool bypassTimeLimitsEnforcedByOutside = false)
	{
		if (AreOffersAllowedOnDevice())
		{
			IOfferWallProvider offerWallProvider = ((_dataManager == null) ? null : _activeProvider);
			if (offerWallProvider != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			}
			else
			{
				LogError("The OfferWall needs initializing before it can RefreshOffers.");
			}
		}
	}

	public void GetPendingRewards(bool bypassTimeLimitsEnforcedByOutside = false)
	{
		if (AreOffersAllowedOnDevice())
		{
			IOfferWallProvider offerWallProvider = ((_dataManager == null) ? null : _activeProvider);
			if (offerWallProvider != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			}
			else
			{
				LogError("The OfferWall needs initializing before it can GetPendingRewards.");
			}
		}
	}

	private bool IsInitialized()
	{
		if (_dataManager == null)
		{
			return false;
		}
		return _activeProvider != null;
	}

	private bool IsOfferWallDisabled()
	{
		if (_dataManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		LogError("The OfferWall needs to be initialized first!");
		return false;
	}

	private bool IsSupportedOnPlatform()
	{
		RuntimePlatform platform = Application.platform;
		bool result;
		if (platform == RuntimePlatform.Android)
		{
			bool isKindleDevice = DeviceUtility.isKindleDevice;
			bool flag = !isKindleDevice;
			result = true;
			if (flag)
			{
				goto IL_006a;
			}
		}
		result = false;
		goto IL_006a;
		IL_006a:
		return result;
	}

	private void ChangeActiveProvider()
	{
		List<IOfferWallProvider> providers = _providers;
		if (providers._size >= 1)
		{
			IOfferWallProvider offerWallProvider = _providers.get_Item(0);
			if (offerWallProvider != null)
			{
				SetUpActiveProvider(offerWallProvider);
			}
		}
	}

	private void SetUpActiveProvider(IOfferWallProvider newProvider)
	{
		if (_activeProvider != null)
		{
			bool flag = newProvider == null;
			IOfferWallProvider activeProvider = _activeProvider;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj = default;
				object obj2 = default;
				if (obj == obj2)
				{
					goto IL_0098;
				}
				activeProvider = _activeProvider;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
		goto IL_0098;
		IL_0098:
		_activeProvider = newProvider;
		if (_activeProvider != null)
		{
			throw new ArgumentException();
		}
	}

	private void OnOffersReceived(List<IDisplayableOffer> offers, bool cached)
	{
		Action<List<IDisplayableOffer>, bool> action = this.m_onOffersReceived;
		if (this.m_onOffersReceived != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`2<System.Collections.Generic.List`1<Kiloo.Monetization.Offerwall.IDisplayableOffer>, System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "OfferWall: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public OfferWall()
	{
		List<IOfferWallProvider> list = default;
		list._002Ector();
		_providers = list;
	}
}
