using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using InAppPurchase;
using InAppPurchase.Internal;
using Kiloo;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Utility;
using SYBO.Common.Utilities;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class InAppManager : MonoBehaviour, IInAppManager
{
	public delegate void OnProductRequestDone();

	public delegate void OnPurchaseSuccess(string productId, bool wasRestored);

	public delegate void OnPurchaseFailure(string productId, PurchaseResult result);

	public delegate void OnPurchaseCanceled(string productId, PurchaseResult result);

	public delegate void OnPurchaseItemNotAvailable(string productId, PurchaseResult result);

	public delegate void OnInitializeFinished(bool success);

	public delegate void OnItemRestored(string productId);

	public delegate void OnItemRestoreFinished(RestoreFinishedResult result);

	public delegate void OnItemRefunded(string productId);

	private const string INAPP_API_KEY_ANDROID = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnV3V5Ht4U8dR2R/R7Fvk4aIyNtuTZk90drulZJrQ8a7v3FtSENNAHqj8v104Snrc+4ICGGixqYlf73m2jlDYjTF5N0fKfWiujyJrnL9+FEOYOudgwQCx9qmrIBbICnodqecNJeWnxwutuiFdQ2/WOwC1bqHVVws8Qz+KQNqQ86gFQRM1kBLZaEg8tl5n2WsEddqJ7T+/TheYtmimoyEe9xxXr8vB0KynXez3RwIyUjvbVDWW7tlAbUjROeIELDUWMkARfDCem8xlbAoDUiepNF3LDHOYUDcCkgcdi6HK0SSj4FrWW9hrrhxMjRxlMnhKuKP2n1ws7b4cwOjMPCaZUwIDAQAB";

	private const string ONLINESETTINGS_IAP_VALIDATION_URL_KEY = "iap_validation_url";

	private const string DEFAULT_IAP_VALIDATION_URL = "https://purchasevalidation.kiloo-games.com/";

	private const string ONLINESETTINGS_IAP_VALIDATION_ENABLED = "iap_validation_enabled";

	private const string ONLINESETTINGS_DISCOUNT_END_TIME_KEY = "discount_end_time";

	private const double DEFAULT_DISCOUNT_END_TIME = 0.0;

	private const bool DEFAULT_IAP_VALIDATION_ENABLED = true;

	private static readonly Dictionary<string, int> _debugDiscount;

	private static InAppManager _instance;

	private static PurchaseHandler _purchaseHandler;

	private string _itemRequested;

	private string _inAppPurchaseKey;

	private bool _productRequestSucceeded;

	private static bool _isRestoredManually;

	private const string GAME_OBJECT_NAME = "InAppManager";

	private InAppManagerPopupData _popupData;

	[NonSerialized]
	public AudioClip purchaseSuccessSound;

	private readonly PurchaseValidationServer _purchaseValidationServer;

	private static bool _hasSuccessfullyInitialized;

	private static bool _applicationIsQuiting;

	private bool _isQueryingProductInfo;

	private OnProductRequestDone m_onProductRequestDone;

	private OnPurchaseSuccess m_onPurchaseSuccess;

	private OnPurchaseFailure m_onPurchaseFailure;

	private OnPurchaseCanceled m_onPurchaseCanceled;

	private OnPurchaseItemNotAvailable m_onPurchaseItemNotAvailable;

	private OnItemRestored m_onItemRestored;

	private OnItemRefunded m_onItemRefunded;

	private OnItemRestoreFinished m_onItemRestoreFinished;

	private static OnInitializeFinished m_onInitializeFinished;

	public string itemRequested => _itemRequested;

	public static bool isInitialized
	{
		get
		{
			if (_instance != null)
			{
				return _hasSuccessfullyInitialized;
			}
			return false;
		}
	}

	public static InAppManager instance
	{
		get
		{
			Init();
			return _instance;
		}
	}

	public unsafe static bool IsAnyDiscountAvailable
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0091: Expected I8, but got I4
			//IL_008c: Expected native int or pointer, but got VT
			//IL_00b8: Expected native int or pointer, but got VT
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected VT, but got Unknown
			//IL_0038: Expected Ref, but got VT
			//IL_0069: Invalid comparison between VT and I4
			object obj = default;
			DateTime dateTime = (DateTime)(obj - 16);
			_ = 0;
			double discountEndTime = GetDiscountEndTime();
			((DateTime*)(nint)dateTime)->_dateData = 0uL;
			*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			_ = dateTime._dateData;
			DateTime dateTime2 = dateTime + 8;
			DateTime dateTime3 = ((DateTime*)dateTime2)->AddSeconds(discountEndTime);
			DateTime utcNow = CDateTime.UtcNow;
			TimeSpan timeSpan = dateTime3 - utcNow;
			return timeSpan > (object)0;
		}
	}

	public static bool IsDoubleCoinsDiscountActive
	{
		get
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			bool result;
			if (!playerInfo._hasDoubleCoinsUpgrade && IsAnyDiscountAvailable)
			{
				string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId("com.kiloo.subways.doublecoins");
				int discountValue = GetDiscountValue(inAppOnlineSettingsId, 0);
				if (discountValue <= -1)
				{
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item("com.kiloo.subways.doublecoinsdiscount");
					result = true;
					if (inAppItemModel.IsValidated__BackingField)
					{
						goto IL_00d1;
					}
				}
			}
			result = false;
			goto IL_00d1;
			IL_00d1:
			return result;
		}
	}

	public static bool IsAnyCurrencyDiscountActive
	{
		get
		{
			//IL_016b: Expected Obj, but got I4
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected Obj, but got Unknown
			//IL_0058: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I4
			//IL_0087: Expected Obj, but got I4
			//IL_00e4: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [52FE18]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			string[] inAppCurrencyTiers = InAppData.inAppCurrencyTiers;
			object obj = 0;
			bool flag3;
			while (true)
			{
				flag3 = (nint)obj < inAppCurrencyTiers.Length;
				if (!flag3)
				{
					break;
				}
				object obj2 = obj << 2;
				object obj3 = (object)inAppCurrencyTiers + obj2;
				if (!IsAnyDiscountAvailable)
				{
					goto IL_0112;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25+10]");
				string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId((string)0);
				object obj4;
				if (inAppOnlineSettingsId != null)
				{
					obj4 = 0;
					if (inAppOnlineSettingsId._stringLength != 0)
					{
						goto IL_0170;
					}
				}
				obj4 = 1;
				goto IL_0170;
				IL_0112:
				object obj5 = obj + 1;
				obj = obj5;
				continue;
				IL_0170:
				if (obj4 == null && IsDiscountActive(inAppOnlineSettingsId))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25+10]");
					string discountIdForNormalOffer = InAppData.GetDiscountIdForNormalOffer((string)0);
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(discountIdForNormalOffer);
					if (inAppItemModel.IsValidated__BackingField)
					{
						break;
					}
				}
				goto IL_0112;
			}
			return flag3;
		}
	}

	public event OnProductRequestDone onProductRequestDone
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_onProductRequestDone;
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
			object obj = this + 40;
			Delegate obj2 = this.m_onProductRequestDone;
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

	public event OnPurchaseSuccess onPurchaseSuccess
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_onPurchaseSuccess;
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
			object obj = this + 44;
			Delegate obj2 = this.m_onPurchaseSuccess;
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

	public event OnPurchaseFailure onPurchaseFailure
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_onPurchaseFailure;
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
			object obj = this + 48;
			Delegate obj2 = this.m_onPurchaseFailure;
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

	public event OnPurchaseCanceled onPurchaseCanceled
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_onPurchaseCanceled;
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
			object obj = this + 52;
			Delegate obj2 = this.m_onPurchaseCanceled;
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

	public event OnPurchaseItemNotAvailable onPurchaseItemNotAvailable
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_onPurchaseItemNotAvailable;
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
			object obj = this + 56;
			Delegate obj2 = this.m_onPurchaseItemNotAvailable;
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

	public event OnItemRestored onItemRestored
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 60;
			Delegate obj2 = this.m_onItemRestored;
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
			object obj = this + 60;
			Delegate obj2 = this.m_onItemRestored;
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

	public event OnItemRefunded onItemRefunded
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_onItemRefunded;
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
			object obj = this - -64;
			Delegate obj2 = this.m_onItemRefunded;
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

	public event OnItemRestoreFinished onItemRestoreFinished
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 68;
			Delegate obj2 = this.m_onItemRestoreFinished;
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
			object obj = this + 68;
			Delegate obj2 = this.m_onItemRestoreFinished;
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

	public static event OnInitializeFinished onInitializeFinished
	{
		add
		{
			Delegate obj = InAppManager.m_onInitializeFinished;
			OnInitializeFinished onInitializeFinished2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InAppManager.m_onInitializeFinished;
				OnInitializeFinished onInitializeFinished = onInitializeFinished2;
				if (!flag)
				{
					onInitializeFinished = InAppManager.m_onInitializeFinished;
				}
				InAppManager.m_onInitializeFinished = onInitializeFinished;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InAppManager.m_onInitializeFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = InAppManager.m_onInitializeFinished;
			OnInitializeFinished onInitializeFinished2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == InAppManager.m_onInitializeFinished;
				OnInitializeFinished onInitializeFinished = onInitializeFinished2;
				if (!flag)
				{
					onInitializeFinished = InAppManager.m_onInitializeFinished;
				}
				InAppManager.m_onInitializeFinished = onInitializeFinished;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = InAppManager.m_onInitializeFinished;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private InAppManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_0403: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(obj2 - 16) + 8;
		_ = 0;
		_itemRequested = string.Empty;
		_inAppPurchaseKey = string.Empty;
		base._002Ector();
		OnlineSettings onlineSettings = OnlineSettings.instance;
		if (!onlineSettings.GetValue("iap_validation_enabled", defaultValue: true))
		{
			return;
		}
		string value = OnlineSettings.instance.GetValue("iap_validation_url", "https://purchasevalidation.kiloo-games.com/");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					PurchaseValidationServer purchaseValidationServer = default;
					Uri uri = default;
					purchaseValidationServer.baseUri__BackingField = uri;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_purchaseValidationServer = purchaseValidationServer;
						goto IL_04e4;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0189;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0189;
		IL_0189:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			InAppManager inAppManager;
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj10 = obj + (object)((nint)0 << 2);
						obj10 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj12 = (object)((nint)0 << 2) + obj - 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ S1_v65+E4] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = -1;
						goto IL_04e4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					inAppManager = (InAppManager)0;
					obj5 = obj8;
					if (flag2)
					{
						goto IL_0503;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			inAppManager = (InAppManager)0;
			object obj15 = default;
			obj5 = obj15;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				inAppManager = (InAppManager)0;
				obj5 = obj15;
			}
		}
		goto IL_0503;
		IL_0503:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_04e4;
		IL_04e4:
		if (_purchaseValidationServer != null && Application.platform == RuntimePlatform.IPhonePlayer)
		{
			_purchaseValidationServer.debug__BackingField = Globals.DEBUG;
		}
	}

	public static void Init()
	{
		if (_instance == null && !_applicationIsQuiting)
		{
			GameObject gameObject = default;
			gameObject._002Ector();
			gameObject.name = "InAppManager";
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			InAppManager inAppManager = gameObject.AddComponent<InAppManager>();
			Transform childTransform = gameObject.transform;
			HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
			Transform asLastSibling = gameObject.transform;
			HierarchyUtility.SetAsLastSibling(asLastSibling);
		}
	}

	private void Awake()
	{
		if (_instance != null)
		{
			UnityEngine.Object.DestroyImmediate(this);
		}
		else
		{
			_instance = this;
		}
	}

	private void OnApplicationQuit()
	{
		_applicationIsQuiting = true;
		_instance = null;
	}

	public void RequestIAPInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (~(_isQueryingProductInfo ? 1u : 0u) == 0)
		{
			return;
		}
		_isQueryingProductInfo = true;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01f3;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_01f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_01f3:
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142C");
			return;
		}
		_ = 0;
		object obj14 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public void StartPurchase(string productId)
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		string contactingStoreOverlayText = ((InAppManager)null).GetContactingStoreOverlayText();
		uIScreenController.ShowInAppPurchaseOverlay(contactingStoreOverlayText);
	}

	public bool RestoreNonConsumablePurchases(string[] productIds, bool calledManually = true)
	{
		//IL_0043: Expected Obj, but got I4
		if (calledManually && UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			string contactingStoreOverlayText = ((InAppManager)calledManually).GetContactingStoreOverlayText();
			uIScreenController.ShowInAppPurchaseOverlay(contactingStoreOverlayText);
		}
		_isRestoredManually = calledManually;
		InAppPurchaseProvider inAppPurchaseProvider = InAppPurchaseProvider.instance;
		return inAppPurchaseProvider.RestoreNonConsumablePurchases(productIds);
	}

	public bool ProductRequestSucceeded()
	{
		return _productRequestSucceeded;
	}

	public void InitFinishedCallback(bool success)
	{
		_hasSuccessfullyInitialized = success;
		OnInitializeFinished onInitializeFinished = InAppManager.m_onInitializeFinished;
		if (InAppManager.m_onInitializeFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (success)
		{
			RequestIAPInfo();
		}
	}

	public string getInAppAPIKey()
	{
		return "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnV3V5Ht4U8dR2R/R7Fvk4aIyNtuTZk90drulZJrQ8a7v3FtSENNAHqj8v104Snrc+4ICGGixqYlf73m2jlDYjTF5N0fKfWiujyJrnL9+FEOYOudgwQCx9qmrIBbICnodqecNJeWnxwutuiFdQ2/WOwC1bqHVVws8Qz+KQNqQ86gFQRM1kBLZaEg8tl5n2WsEddqJ7T+/TheYtmimoyEe9xxXr8vB0KynXez3RwIyUjvbVDWW7tlAbUjROeIELDUWMkARfDCem8xlbAoDUiepNF3LDHOYUDcCkgcdi6HK0SSj4FrWW9hrrhxMjRxlMnhKuKP2n1ws7b4cwOjMPCaZUwIDAQAB";
	}

	public IsIAPConsumableValue IsProductConsumable(string productID)
	{
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productID);
		return (IsIAPConsumableValue)((inAppItemModel.IsConsumable__BackingField ? 1 : 0) ^ 1);
	}

	public void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		if (success)
		{
			_productRequestSucceeded = true;
			object obj3 = default;
			object obj13 = default;
			object obj8 = default;
			for (; (nint)obj3 < productInfo.Length; obj3 = obj13 + 1)
			{
				object obj4 = obj3 << 4;
				object obj5 = (object)productInfo + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v15+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v15+10]");
				obj = 0;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S3_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+54]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S3_v7+4] (should have been resolved before IL gen)");
				object obj7 = obj8 ^ -1;
				object obj9 = obj7 >> 31;
				object obj10;
				if (obj9 != null)
				{
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)obj);
					inAppItemModel.IsValidated__BackingField = true;
					InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item((string)obj);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					inAppItemModel2._localizedPrize = (string)0;
					InAppItemModel inAppItemModel3 = InAppData.inAppData.get_Item((string)obj);
					string localizedPrice = inAppItemModel3.LocalizedPrice;
					if (localizedPrice != null)
					{
						obj10 = 0;
						if (localizedPrice._stringLength != 0)
						{
							goto IL_02f1;
						}
					}
					obj10 = 1;
					goto IL_02f1;
				}
				InAppItemModel inAppItemModel4 = InAppItemModel.CreateEmpty();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				inAppItemModel4._localizedPrize = (string)0;
				inAppItemModel4.IsDynamic__BackingField = true;
				string localizedPrice2 = inAppItemModel4.LocalizedPrice;
				object obj11;
				if (localizedPrice2 != null)
				{
					obj11 = 0;
					if (localizedPrice2._stringLength != 0)
					{
						goto IL_032c;
					}
				}
				obj11 = 1;
				goto IL_032c;
				IL_032c:
				if (obj11 == null)
				{
					string localizedPrice3 = inAppItemModel4.LocalizedPrice;
					string localizedPrize = Regex.Replace(localizedPrice3, "\\u00A0", " ");
					inAppItemModel4._localizedPrize = localizedPrize;
				}
				inAppItemModel4.IsValidated__BackingField = true;
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+5C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ S5_v7+4] (should have been resolved before IL gen)");
				continue;
				IL_02f1:
				if (obj10 == null)
				{
					InAppItemModel inAppItemModel5 = InAppData.inAppData.get_Item((string)obj);
					InAppItemModel inAppItemModel6 = InAppData.inAppData.get_Item((string)obj);
					string localizedPrice4 = inAppItemModel6.LocalizedPrice;
					string localizedPrize2 = Regex.Replace(localizedPrice4, "\\u00A0", " ");
					inAppItemModel5._localizedPrize = localizedPrize2;
				}
			}
		}
		else
		{
			_productRequestSucceeded = false;
		}
		OnProductRequestDone onProductRequestDone = this.m_onProductRequestDone;
		if (this.m_onProductRequestDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		_isQueryingProductInfo = false;
	}

	public void PurchaseRequestCallback(string productId, string transactionId, string transactionIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult)
	{
		//IL_0154: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		bool flag;
		bool flag3;
		object obj;
		object obj2;
		switch (result)
		{
		case PurchaseResult.Completed:
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			flag = playerInfo.AddTransactionToHistory(transactionId, productId);
			RuntimePlatform platform2 = Application.platform;
			bool flag2 = platform2 != RuntimePlatform.Android;
			flag3 = false;
			if (flag2)
			{
				goto IL_0147;
			}
			if (transactionIdBase64 != null)
			{
				obj = 0;
				if (transactionIdBase64._stringLength != 0)
				{
					goto IL_0313;
				}
			}
			obj = 1;
			goto IL_0313;
		}
		case PurchaseResult.Canceled:
		{
			PurchaseCanceled((string)(object)this);
			RuntimePlatform platform4 = Application.platform;
			OnPurchaseCanceled onPurchaseCanceled = this.m_onPurchaseCanceled;
			if (this.m_onPurchaseCanceled != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			break;
		}
		case PurchaseResult.ItemUnavailable:
		{
			PurchaseItemUnavailable((string)(object)this);
			RuntimePlatform platform3 = Application.platform;
			OnPurchaseItemNotAvailable onPurchaseItemNotAvailable = this.m_onPurchaseItemNotAvailable;
			if (this.m_onPurchaseItemNotAvailable != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			break;
		}
		default:
			{
				PurchaseFailed((string)(object)this);
				RuntimePlatform platform = Application.platform;
				OnPurchaseFailure onPurchaseFailure = this.m_onPurchaseFailure;
				if (this.m_onPurchaseFailure != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				break;
			}
			IL_0313:
			flag3 = false;
			if (obj == null)
			{
				PlayerInfo playerInfo2 = PlayerInfo.Instance;
				flag3 = playerInfo2.AddTransactionToHistory(transactionIdBase64, productId);
			}
			goto IL_0147;
			IL_0147:
			obj2 = flag3 | flag;
			if (obj2 != null)
			{
				PayoutInAppPurchase(productId);
				if (PurchaseValidationExtensions.WasPreviousPurchaseValid)
				{
					PlayerInfo playerInfo3 = PlayerInfo.Instance;
					long syboLastPurchaseNumber = playerInfo3._syboLastPurchaseNumber + 1;
					playerInfo3._dirty = true;
					playerInfo3._syboLastPurchaseNumber = syboLastPurchaseNumber;
				}
				OnPurchaseSuccess onPurchaseSuccess = this.m_onPurchaseSuccess;
				if (this.m_onPurchaseSuccess != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			break;
		}
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.HideInAppPurchaseOverlay();
		}
	}

	public void ItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult)
	{
		PurchasedRestored(productId);
		OnItemRestored onItemRestored = this.m_onItemRestored;
		if (this.m_onItemRestored != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		OnPurchaseSuccess onPurchaseSuccess = this.m_onPurchaseSuccess;
		if (this.m_onPurchaseSuccess != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.DelayedHideInAppPurchaseOverlay();
		}
	}

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult)
	{
		OnItemRefunded onItemRefunded = this.m_onItemRefunded;
		if (this.m_onItemRefunded != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.HideInAppPurchaseOverlay();
		}
	}

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result)
	{
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.HideInAppPurchaseOverlay();
		}
		StringID key;
		if (result != RestoreFinishedResult.Failed)
		{
			if (result == RestoreFinishedResult.NothingToRestore)
			{
				bool flag = (byte)(~(_isRestoredManually ? 1u : 0u)) != 0;
				key = StringID.SLIDEIN_RESTORE_NO_PREVIOUS_PURCHASES;
				if (!flag)
				{
					goto IL_009e;
				}
			}
		}
		else
		{
			key = StringID.SLIDEIN_RESTORE_NETWORK_PROBLEM;
			if (_isRestoredManually)
			{
				goto IL_009e;
			}
		}
		goto IL_00d0;
		IL_00d0:
		OnItemRestoreFinished onItemRestoreFinished = this.m_onItemRestoreFinished;
		if (this.m_onItemRestoreFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		_isRestoredManually = false;
		return;
		IL_009e:
		UIScreenController uIScreenController2 = UIScreenController.Instance;
		string message = Strings.Get(key);
		uIScreenController2.QueueErrorMessageSlidein(message);
		goto IL_00d0;
	}

	private void PurchasedRefunded(string productId)
	{
	}

	private void PurchasedRestored(string productId)
	{
		if (productId == "com.kiloo.subways.doublecoins" || productId == "com.kiloo.subways.doublecoinsdiscount")
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			if (!playerInfo._hasDoubleCoinsUpgrade)
			{
				PlayerInfo playerInfo2 = PlayerInfo.Instance;
				if (!playerInfo2._hasDoubleCoinsUpgrade)
				{
					playerInfo2._dirty = true;
					playerInfo2._hasDoubleCoinsUpgrade = true;
				}
				if (UIScreenController.IsInstanced)
				{
					UIScreenController uIScreenController = UIScreenController.Instance;
					UIScreenController.SlideIn slideIn = default;
					slideIn._002Ector(UIScreenController.SlideInType.Unlock, "Double Coins");
					uIScreenController.QueueSlideIn(slideIn);
				}
				PlayerInfo playerInfo3 = PlayerInfo.Instance;
				int inAppRestoredPurchaseCount = playerInfo3._inAppRestoredPurchaseCount + 1;
				playerInfo3._dirty = true;
				playerInfo3._inAppRestoredPurchaseCount = inAppRestoredPurchaseCount;
			}
		}
		else if (InAppData.InappidIsDynamicLimitedCharacterPurchase(productId))
		{
			((InAppManager)(object)productId).LimitedCharacterPurchaseSuccesful(productId, true);
		}
		else if (InAppData.InappidIsDynamicLimitedBoardPurchase(productId))
		{
			((InAppManager)(object)productId).LimitedBoardPurchaseSuccesful(productId, true);
		}
		PlayerInfo playerInfo4 = PlayerInfo.Instance;
		playerInfo4.SaveIfDirty();
	}

	private void PurchaseItemUnavailable(string productId)
	{
		((InAppManager)null).TriggerFailForPurchaseHandler();
		((InAppManager)null).NativePurchaseFinished(false);
		if (UIScreenController.IsInstanced)
		{
			string popupTitle = Strings.Get(StringID.PURCHASE_FAILED_TITLE);
			InAppManagerPopupData inAppManagerPopupData = default;
			inAppManagerPopupData.popupTitle = popupTitle;
			string popupDescription = Strings.Get(StringID.PURCHASE_FAILED_BODY);
			inAppManagerPopupData.popupDescription = popupDescription;
			inAppManagerPopupData.isErrorMessage = true;
			inAppManagerPopupData.canMakePurchase = false;
			_popupData = inAppManagerPopupData;
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.PushPopup("NotEnoughCurencyPopup");
		}
	}

	private void PurchaseCanceled(string productId)
	{
		((InAppManager)null).TriggerFailForPurchaseHandler();
		((InAppManager)null).NativePurchaseFinished(false);
	}

	private void PurchaseFailed(string productId)
	{
		((InAppManager)null).TriggerFailForPurchaseHandler();
		if (UIScreenController.IsInstanced)
		{
			string popupTitle = Strings.Get(StringID.PURCHASE_FAILED_TITLE);
			InAppManagerPopupData inAppManagerPopupData = default;
			inAppManagerPopupData.popupTitle = popupTitle;
			string popupDescription = Strings.Get(StringID.PURCHASE_FAILED_BODY);
			inAppManagerPopupData.popupDescription = popupDescription;
			inAppManagerPopupData.isErrorMessage = true;
			inAppManagerPopupData.canMakePurchase = false;
			_popupData = inAppManagerPopupData;
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.PushPopup("NotEnoughCurencyPopup");
		}
	}

	private void PayoutInAppPurchase(string productId)
	{
		//IL_0745: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		//IL_063d: Expected Obj, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		string[] inAppCurrencyTiers = InAppData.inAppCurrencyTiers;
		string[] inAppCurrencyDiscountTiers = InAppData.inAppCurrencyDiscountTiers;
		object obj = 0;
		PlayerInfo playerInfo3;
		UIScreenController.SlideIn slideIn = default;
		while (true)
		{
			if (inAppCurrencyTiers.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)inAppCurrencyTiers + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v213+10]");
				if ((string)0 == productId)
				{
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productId);
					PlayerInfo playerInfo = PlayerInfo.Instance;
					if (inAppItemModel.InAppItemType__BackingField == InAppItemModel.ItemType.Coins)
					{
						int amountOfCoins = playerInfo.amountOfCoins;
						InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(productId);
						int amountOfCoins2 = inAppItemModel2.PayoutAmount__BackingField + amountOfCoins;
						playerInfo.amountOfCoins = amountOfCoins2;
					}
					else
					{
						int amountOfKeys = playerInfo.amountOfKeys;
						InAppItemModel inAppItemModel3 = InAppData.inAppData.get_Item(productId);
						int amountOfKeys2 = inAppItemModel3.PayoutAmount__BackingField + amountOfKeys;
						playerInfo.amountOfKeys = amountOfKeys2;
					}
					PlayerInfo playerInfo2 = PlayerInfo.Instance;
					int inAppConsumablePurchaseCount = playerInfo2._inAppConsumablePurchaseCount + 1;
					playerInfo2._dirty = true;
					playerInfo2._inAppConsumablePurchaseCount = inAppConsumablePurchaseCount;
					PlayPurchaseSucessSound();
					playerInfo3 = playerInfo2;
					break;
				}
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			InAppManager inAppManager = null;
			while (true)
			{
				string inAppOnlineSettingsId;
				object obj7;
				if (inAppCurrencyDiscountTiers.Length > (nint)inAppManager)
				{
					object obj5 = (object)inAppManager << 2;
					object obj6 = (object)inAppCurrencyDiscountTiers + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v159+10]");
					if ((string)0 == productId)
					{
						Dictionary<string, InAppItemModel> inAppData = InAppData.inAppData;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v159+10]");
						InAppItemModel inAppItemModel4 = inAppData.get_Item((string)0);
						inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId(inAppItemModel4.NormalOfferId__BackingField);
						if (inAppOnlineSettingsId != null)
						{
							obj7 = 0;
							if (inAppOnlineSettingsId._stringLength != 0)
							{
								goto IL_0794;
							}
						}
						obj7 = 1;
						goto IL_0794;
					}
					InAppManager inAppManager2 = (InAppManager)(inAppManager + 1);
					inAppManager = inAppManager2;
					continue;
				}
				if (productId == "com.kiloo.subways.doublecoins" || productId == "com.kiloo.subways.doublecoinsdiscount")
				{
					PlayerInfo playerInfo4 = PlayerInfo.Instance;
					if (!playerInfo4._hasDoubleCoinsUpgrade)
					{
						PlayerInfo playerInfo5 = PlayerInfo.Instance;
						if (!playerInfo5._hasDoubleCoinsUpgrade)
						{
							playerInfo5._dirty = true;
							playerInfo5._hasDoubleCoinsUpgrade = true;
						}
						if (UIScreenController.IsInstanced)
						{
							UIScreenController uIScreenController = UIScreenController.Instance;
							slideIn._002Ector(UIScreenController.SlideInType.Unlock, "Double Coins");
							uIScreenController.QueueSlideIn(slideIn);
						}
					}
					PlayerInfo playerInfo6 = PlayerInfo.Instance;
					int inAppNonconsumablePurchaseCount = playerInfo6._inAppNonconsumablePurchaseCount + 1;
					playerInfo6._dirty = true;
					playerInfo6._inAppNonconsumablePurchaseCount = inAppNonconsumablePurchaseCount;
					playerInfo3 = playerInfo6;
					break;
				}
				if (InAppData.InappidIsDynamicLimitedCharacterPurchase(productId))
				{
					inAppManager.LimitedCharacterPurchaseSuccesful(productId, unlockedByRestore: false);
					PlayerInfo playerInfo7 = PlayerInfo.Instance;
					int inAppNonconsumablePurchaseCount2 = playerInfo7._inAppNonconsumablePurchaseCount + 1;
					playerInfo7._dirty = true;
					playerInfo7._inAppNonconsumablePurchaseCount = inAppNonconsumablePurchaseCount2;
					playerInfo3 = playerInfo7;
					break;
				}
				if (InAppData.InappidIsDynamicLimitedBoardPurchase(productId))
				{
					inAppManager.LimitedBoardPurchaseSuccesful(productId, unlockedByRestore: false);
					PlayerInfo playerInfo8 = PlayerInfo.Instance;
					int inAppNonconsumablePurchaseCount3 = playerInfo8._inAppNonconsumablePurchaseCount + 1;
					playerInfo8._dirty = true;
					playerInfo8._inAppNonconsumablePurchaseCount = inAppNonconsumablePurchaseCount3;
					playerInfo3 = playerInfo8;
					break;
				}
				string[] inAppBundleTiers = InAppData.inAppBundleTiers;
				playerInfo3 = null;
				while ((nint)playerInfo3 < inAppBundleTiers.Length)
				{
					object obj8 = (object)playerInfo3 << 2;
					object obj9 = (object)inAppBundleTiers + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v118+10]");
					if ((string)0 == productId)
					{
						((InAppManager)(object)playerInfo3).DeliverBundle(productId);
						PlayerInfo playerInfo9 = PlayerInfo.Instance;
						playerInfo9.UpdateLastPurchasedBundle();
						PlayPurchaseSucessSound();
						PlayerInfo playerInfo10 = PlayerInfo.Instance;
						int inAppConsumablePurchaseCount2 = playerInfo10._inAppConsumablePurchaseCount + 1;
						playerInfo10._dirty = true;
						playerInfo10._inAppConsumablePurchaseCount = inAppConsumablePurchaseCount2;
						playerInfo3 = playerInfo10;
						break;
					}
					PlayerInfo playerInfo11 = (PlayerInfo)(playerInfo3 + 1);
					playerInfo3 = playerInfo11;
				}
				break;
				IL_0794:
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v159+10]");
					string text = "Could not find a discout id for the pricepoint: " + (string)0;
					return;
				}
				InAppItemModel inAppItemModel5 = InAppData.inAppData.get_Item(productId);
				PlayerInfo playerInfo12 = PlayerInfo.Instance;
				if (inAppItemModel5.InAppItemType__BackingField == InAppItemModel.ItemType.Coins)
				{
					int amountOfCoins3 = playerInfo12.amountOfCoins;
					int itemPayoutAmount = ((InAppManager)(object)inAppOnlineSettingsId).GetItemPayoutAmount(productId, inAppOnlineSettingsId);
					int amountOfCoins4 = amountOfCoins3 + itemPayoutAmount;
					playerInfo12.amountOfCoins = amountOfCoins4;
				}
				else
				{
					int amountOfKeys3 = playerInfo12.amountOfKeys;
					int itemPayoutAmount2 = ((InAppManager)(object)inAppOnlineSettingsId).GetItemPayoutAmount(productId, inAppOnlineSettingsId);
					int amountOfKeys4 = amountOfKeys3 + itemPayoutAmount2;
					playerInfo12.amountOfKeys = amountOfKeys4;
				}
				PlayerInfo playerInfo13 = PlayerInfo.Instance;
				int inAppConsumablePurchaseCount3 = playerInfo13._inAppConsumablePurchaseCount + 1;
				playerInfo13._dirty = true;
				playerInfo13._inAppConsumablePurchaseCount = inAppConsumablePurchaseCount3;
				PlayPurchaseSucessSound();
				playerInfo3 = playerInfo13;
				break;
			}
			break;
		}
		PlayerInfo playerInfo14 = PlayerInfo.Instance;
		playerInfo14.SaveIfDirty();
		((InAppManager)(object)playerInfo3).NativePurchaseFinished(true);
		Flurry.LogInAppPurchase(productId, _itemRequested);
		_itemRequested = string.Empty;
	}

	public int GetItemPayoutAmount(string productId, string onlineSettingsDiscountId = null)
	{
		//IL_0058: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		string text = default;
		string inAppOnlineSettingsId = default;
		if (text == null)
		{
			InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productId);
			inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId(inAppItemModel.NormalOfferId__BackingField);
		}
		object obj;
		if (inAppOnlineSettingsId != null)
		{
			obj = 0;
			if (inAppOnlineSettingsId._stringLength != 0)
			{
				goto IL_00c7;
			}
		}
		obj = 1;
		goto IL_00c7;
		IL_00c7:
		bool flag = obj == null;
		bool flag2 = !flag;
		int num = 0;
		if (!flag2)
		{
			int num2 = GetDiscountValue(inAppOnlineSettingsId, 0);
			if (num2 <= 0)
			{
				num2 = 0;
			}
			num = num2;
		}
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(productId);
		return num + inAppItemModel2.PayoutAmount__BackingField;
	}

	private void PlayPurchaseSucessSound()
	{
		if (purchaseSuccessSound != null)
		{
			AudioSource audioSource = NGUITools.PlaySound(purchaseSuccessSound);
		}
	}

	private unsafe void LimitedCharacterPurchaseSuccesful(string itemId, bool unlockedByRestore)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (InAppData.TryConvertDynamicPurchaseIdToCharacterType(itemId, out *(Characters.CharacterType*)(obj + 12)))
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if (!playerInfo.IsCharacterOwned(Characters.CharacterType.slick))
			{
				Dictionary<Characters.CharacterType, Characters.Model> characterData = Characters.characterData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				Characters.Model model = characterData.get_Item(Characters.CharacterType.slick);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				playerInfo.CollectToken(Characters.CharacterType.slick, model.Price);
				if (_purchaseHandler != null)
				{
					PurchaseHandler purchaseHandler = _purchaseHandler;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					purchaseHandler.OnPurchaseCharacterWithInappSucceded(Characters.CharacterType.slick, itemId);
				}
				if (unlockedByRestore && UIScreenController.IsInstanced)
				{
					PlayerInfo playerInfo2 = PlayerInfo.Instance;
					int inAppRestoredPurchaseCount = playerInfo2._inAppRestoredPurchaseCount + 1;
					playerInfo2._dirty = true;
					playerInfo2._inAppRestoredPurchaseCount = inAppRestoredPurchaseCount;
					CharacterScreen.forceRefreshOnCharacterScreen = true;
					UIScreenController uIScreenController = UIScreenController.Instance;
					string payload = Strings.Get(model.name);
					UIScreenController.SlideIn slideIn = default;
					slideIn._002Ector(UIScreenController.SlideInType.Unlock, payload);
					uIScreenController.QueueSlideIn(slideIn);
				}
			}
		}
		if (_purchaseHandler != null)
		{
			PurchaseHandler purchaseHandler2 = _purchaseHandler;
			purchaseHandler2._onFailedToPurchaseEventItemWithInapp = null;
		}
		_purchaseHandler = null;
	}

	private unsafe void LimitedBoardPurchaseSuccesful(string itemId, bool unlockedByRestore)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (InAppData.TryConvertDynamicBoardIdToBoardType(itemId, out *(Hoverboards.BoardType*)(obj + 12)))
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if (!playerInfo.IsHoverboardUnlocked(Hoverboards.BoardType.normal))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				playerInfo.UnlockHoverboard(Hoverboards.BoardType.normal);
				if (_purchaseHandler != null)
				{
					PurchaseHandler purchaseHandler = _purchaseHandler;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					purchaseHandler.OnPurchaseBoardWithInappSucceded(itemId, Hoverboards.BoardType.normal);
				}
				if (unlockedByRestore && UIScreenController.IsInstanced)
				{
					PlayerInfo playerInfo2 = PlayerInfo.Instance;
					int inAppRestoredPurchaseCount = playerInfo2._inAppRestoredPurchaseCount + 1;
					playerInfo2._dirty = true;
					playerInfo2._inAppRestoredPurchaseCount = inAppRestoredPurchaseCount;
					BoardScreenManager boardScreenManager = BoardScreenManager.Instance;
					boardScreenManager.forceRefreshOnBoardScreen__BackingField = true;
					UIScreenController uIScreenController = UIScreenController.Instance;
					Dictionary<Hoverboards.BoardType, Hoverboards.Board> boardData = Hoverboards.boardData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					Hoverboards.Board board = boardData.get_Item(Hoverboards.BoardType.normal);
					string payload = Strings.Get(board.name);
					UIScreenController.SlideIn slideIn = default;
					slideIn._002Ector(UIScreenController.SlideInType.Unlock, payload);
					uIScreenController.QueueSlideIn(slideIn);
				}
			}
		}
		if (_purchaseHandler != null)
		{
			PurchaseHandler purchaseHandler2 = _purchaseHandler;
			purchaseHandler2._onFailedToPurchaseEventItemWithInapp = null;
		}
		_purchaseHandler = null;
	}

	private void TriggerFailForPurchaseHandler()
	{
		if (_purchaseHandler != null)
		{
			PurchaseHandler purchaseHandler = _purchaseHandler;
			Action onFailedToPurchaseEventItemWithInapp = purchaseHandler._onFailedToPurchaseEventItemWithInapp;
			if (purchaseHandler._onFailedToPurchaseEventItemWithInapp != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				purchaseHandler._onFailedToPurchaseEventItemWithInapp = null;
			}
			_purchaseHandler = null;
		}
	}

	public void NativePurchaseFinished(bool success)
	{
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.HideInAppPurchaseOverlay();
		}
		if (success)
		{
			SaveMeManager.SendReviveIfPurchaseSucceeded();
		}
		else
		{
			SaveMeManager.SkipReviveIfPurchaseFailed();
		}
	}

	public void NativePurchaseInappPack(string message)
	{
		if (message == "0")
		{
			_inAppPurchaseKey = string.Empty;
			SaveMeManager.SkipReviveIfPurchaseFailed();
		}
		else if (~(_productRequestSucceeded ? 1u : 0u) == 0)
		{
			StartPurchase((string)(object)this);
		}
		else
		{
			_inAppPurchaseKey = string.Empty;
		}
	}

	public void NativePurchaseFail(string message)
	{
		_inAppPurchaseKey = string.Empty;
		if (message == "0")
		{
			NativePurchaseFinished(success: false);
		}
	}

	public void BuyExpiredLimitedCharacter(string inappId, string characterName, PurchaseHandler sender)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		_purchaseHandler = sender;
		object obj;
		if (inappId != null)
		{
			obj = 0;
			if (inappId._stringLength != 0)
			{
				goto IL_0065;
			}
		}
		obj = 1;
		goto IL_0065;
		IL_0065:
		if (obj == null)
		{
			StartPurchase((string)(object)sender);
		}
	}

	public void BuyExpiredLimitedBoard(string inappId, string boardName, PurchaseHandler sender)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		_purchaseHandler = sender;
		object obj;
		if (inappId != null)
		{
			obj = 0;
			if (inappId._stringLength != 0)
			{
				goto IL_0065;
			}
		}
		obj = 1;
		goto IL_0065;
		IL_0065:
		if (obj == null)
		{
			StartPurchase((string)(object)sender);
		}
	}

	private unsafe void DeliverBundle(string bundleId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Ref, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Ref, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Ref, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Ref, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(bundleId);
		_ = 0;
		bool flag = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Coins, out *(int*)(obj + 28));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		if ((nint)0 >= (nint)1)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			int amountOfCoins = playerInfo.amountOfCoins;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			int amountOfCoins2 = (int)((nint)amountOfCoins + (nint)0);
			playerInfo.amountOfCoins = amountOfCoins2;
		}
		_ = 0;
		bool flag2 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Keys, out *(int*)(obj + 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		if ((nint)0 >= (nint)1)
		{
			PlayerInfo playerInfo2 = PlayerInfo.Instance;
			int amountOfKeys = playerInfo2.amountOfKeys;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			int amountOfKeys2 = (int)((nint)amountOfKeys + (nint)0);
			playerInfo2.amountOfKeys = amountOfKeys2;
		}
		_ = 0;
		bool flag3 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Hoverboards, out *(int*)(obj + 20));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		if ((nint)0 >= (nint)1)
		{
			PlayerInfo playerInfo3 = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			playerInfo3.IncreaseUpgradeAmount(PowerupType.hoverboard, 0);
		}
		_ = 0;
		bool flag4 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Scoreboosters, out *(int*)(obj + 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		if ((nint)0 >= (nint)1)
		{
			PlayerInfo playerInfo4 = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			playerInfo4.IncreaseUpgradeAmount(PowerupType.scorebooster, 0);
		}
		_ = 0;
		bool flag5 = inAppItemModel.BundleContents__BackingField.TryGetValue(InAppItemModel.ItemType.Headstarts, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 >= (nint)1)
		{
			PlayerInfo playerInfo5 = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			playerInfo5.IncreaseUpgradeAmount(PowerupType.headstart2000, 0);
		}
	}

	public void SuggestInAppPopup(int cost, string senderName, InAppItemModel.ItemType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected Obj, but got Unknown
		//IL_0d15: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0d82: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0820: Expected Obj, but got I4
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0804: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected Obj, but got Unknown
		//IL_083b: Expected Obj, but got I
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected Obj, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_072d: Expected Obj, but got I
		//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9f: Expected Obj, but got Unknown
		//IL_0ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Expected Obj, but got Unknown
		//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f87: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Expected Obj, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f18: Expected Obj, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I
		//IL_05de: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I
		//IL_0503: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_itemRequested = senderName;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		InAppItemModel.ItemType itemType = default;
		int num = ((itemType != InAppItemModel.ItemType.Coins) ? playerInfo.amountOfKeys : playerInfo.amountOfCoins);
		object obj4 = cost - num;
		bool flag = (byte)(~(_productRequestSucceeded ? 1u : 0u)) != 0;
		string text = string.Empty;
		InAppManager inAppManager = default;
		if (!flag)
		{
			object obj5 = obj + 16;
			Dictionary<string, InAppItemModel> activeInAppOffers = GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			object obj6 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj7 = obj + 48;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			text = string.Empty;
			object obj9 = default;
			object obj16 = default;
			object obj19 = default;
			object obj20 = default;
			object obj21 = default;
			object obj22 = default;
			object obj23 = default;
			while (true)
			{
				_ = 0;
				object obj8 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj13;
				if ((nint)0 != 1)
				{
					if (obj9 == null)
					{
						goto IL_069f;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj10 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v301+40]");
							if ((nint)0 == 0)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj11 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v316+30]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
								if (num2 != 0)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
								object obj12 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S0_v331+18]");
									if (0 < (nint)obj4)
									{
										continue;
									}
									_ = 0;
									if (text != null)
									{
										obj13 = 0;
										if (text._stringLength != 0)
										{
											goto IL_0df0;
										}
									}
									obj13 = 1;
									goto IL_0df0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0610;
				IL_0e1b:
				string text2;
				text = text2;
				continue;
				IL_069f:
				object obj14 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142C");
				break;
				IL_0610:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj15 = obj16;
				goto IL_0627;
				IL_0df0:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj13 == null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
								object obj17 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S0_v398+18]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S0_v412+18]");
									if (num3 <= 0)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
									text2 = (string)0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
											object obj18 = 0;
											goto IL_0e1b;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										obj15 = obj19;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
										text = (string)0;
										goto IL_0627;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
						text2 = (string)0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
								object obj18 = 0;
								goto IL_0e1b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj15 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
							text = (string)0;
							goto IL_0627;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0610;
				IL_0627:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj21 == obj22)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_069f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj15 = obj23;
				}
				_ = 0;
				object obj24 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				inAppManager = (InAppManager)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0758;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		_inAppPurchaseKey = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
		object obj25 = -5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
		string popupTitle;
		bool isCoinsPack;
		if ((nint)0 != 5)
		{
			if ((nint)obj25 == 1)
			{
				string text3 = Strings.Get(StringID.NOT_ENOUGH_KEYS);
				popupTitle = text3;
				isCoinsPack = false;
			}
			else
			{
				Enum obj26 = (Enum)(obj + 16);
				_ = -1;
				obj26 = (Enum)(object)typeof(InAppItemModel.ItemType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				_ = 0;
				string text4 = obj26.ToString();
				string text5 = "No handling implemented for item type: " + text4;
				popupTitle = string.Empty;
				isCoinsPack = false;
			}
			goto IL_0e28;
		}
		goto IL_0fa7;
		IL_0e28:
		string inAppPurchaseKey = inAppManager._inAppPurchaseKey;
		object obj27;
		if (inAppManager._inAppPurchaseKey != null)
		{
			obj27 = 0;
			if (inAppPurchaseKey._stringLength != 0)
			{
				goto IL_0e57;
			}
		}
		obj27 = 1;
		goto IL_0e57;
		IL_0758:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0fa7;
		IL_0fa7:
		string text6 = Strings.Get(StringID.NOT_ENOUGH_COINS);
		popupTitle = text6;
		isCoinsPack = true;
		goto IL_0e28;
		IL_0e57:
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			object obj28 = -5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			string popupDescription;
			if ((nint)0 != 5)
			{
				if ((nint)obj28 == 1)
				{
					bool flag2 = (nint)obj4 > 1;
					StringID key = StringID.PURCHASE_KEYS_MULTIPLE;
					if (!flag2)
					{
						key = StringID.PURCHASE_KEYS_ONE;
					}
					string format = Strings.Get(key);
					object obj29 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ L3_v20+18]");
					_ = 0;
					object obj30 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(text);
					string localizedPrice = inAppItemModel.LocalizedPrice;
					object arg = default;
					object arg2 = default;
					string text7 = string.Format(format, arg, arg2, localizedPrice);
					popupDescription = text7;
				}
				else
				{
					Enum obj31 = (Enum)(obj + 16);
					_ = -1;
					obj31 = (Enum)(object)typeof(InAppItemModel.ItemType);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					_ = 0;
					string text8 = obj31.ToString();
					string text9 = "No handling implemented for item type: " + text8;
					popupDescription = string.Empty;
				}
			}
			else
			{
				bool flag3 = (nint)obj4 > 1;
				StringID key2 = StringID.PURCHASE_COINS_MULTIPLE;
				if (!flag3)
				{
					key2 = StringID.PURCHASE_COINS_ONE;
				}
				string format2 = Strings.Get(key2);
				object obj32 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ L3_v20+18]");
				_ = 0;
				object obj33 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(text);
				string localizedPrice2 = inAppItemModel2.LocalizedPrice;
				object arg3 = default;
				object arg4 = default;
				string text10 = string.Format(format2, arg3, arg4, localizedPrice2);
				popupDescription = text10;
			}
			if (UIScreenController.IsInstanced)
			{
				InAppManagerPopupData inAppManagerPopupData = default;
				inAppManagerPopupData.popupTitle = popupTitle;
				inAppManagerPopupData.popupDescription = popupDescription;
				inAppManagerPopupData.isErrorMessage = false;
				inAppManagerPopupData.isCoinsPack = isCoinsPack;
				inAppManagerPopupData.canMakePurchase = true;
				inAppManager._popupData = inAppManagerPopupData;
				UIScreenController uIScreenController = UIScreenController.Instance;
				uIScreenController.PushPopup("NotEnoughCurencyPopup");
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
		object obj34 = -5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
		if ((nint)0 != 5)
		{
			if ((nint)obj34 == 1)
			{
				bool flag4 = (nint)obj4 > 1;
				StringID key3 = StringID.PURCHASE_KEYS_MULTIPLE_NO_INTERNET;
				if (!flag4)
				{
					key3 = StringID.PURCHASE_KEYS_ONE_NO_INTERNET;
				}
				string format3 = Strings.Get(key3);
				object obj35 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg5 = default;
				string popupDescription2 = string.Format(format3, arg5);
				if (UIScreenController.IsInstanced)
				{
					InAppManagerPopupData inAppManagerPopupData2 = default;
					inAppManagerPopupData2.popupTitle = popupTitle;
					inAppManagerPopupData2.popupDescription = popupDescription2;
					inAppManagerPopupData2.isErrorMessage = false;
					inAppManagerPopupData2.isCoinsPack = isCoinsPack;
					inAppManagerPopupData2.canMakePurchase = false;
					inAppManager._popupData = inAppManagerPopupData2;
					UIScreenController uIScreenController2 = UIScreenController.Instance;
					uIScreenController2.PushPopup("NotEnoughCurencyPopup");
				}
			}
			else
			{
				Enum obj36 = (Enum)(obj + 16);
				_ = -1;
				obj36 = (Enum)(object)typeof(InAppItemModel.ItemType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				_ = 0;
				string text11 = obj36.ToString();
				string text12 = "No handling implemented for item type: " + text11;
			}
		}
		else
		{
			bool flag5 = (nint)obj4 > 1;
			StringID key4 = StringID.PURCHASE_COINS_MULTIPLE_NO_INTERNET;
			if (!flag5)
			{
				key4 = StringID.PURCHASE_COINS_ONE_NO_INTERNET;
			}
			string format4 = Strings.Get(key4);
			object obj37 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg6 = default;
			string popupDescription3 = string.Format(format4, arg6);
			if (UIScreenController.IsInstanced)
			{
				InAppManagerPopupData inAppManagerPopupData3 = default;
				inAppManagerPopupData3.popupTitle = popupTitle;
				inAppManagerPopupData3.popupDescription = popupDescription3;
				inAppManagerPopupData3.isErrorMessage = false;
				inAppManagerPopupData3.isCoinsPack = isCoinsPack;
				inAppManagerPopupData3.canMakePurchase = false;
				inAppManager._popupData = inAppManagerPopupData3;
				UIScreenController uIScreenController3 = UIScreenController.Instance;
				uIScreenController3.PushPopup("NotEnoughCurencyPopup");
			}
		}
	}

	private static bool IsDiscountActive(string onlineSettingsId)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		bool result;
		if (~(Globals.DEBUG_ENABLE_SALES ? 1u : 0u) == 0)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S4_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S4_v6+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			result = true;
			if (obj4 != null)
			{
				goto IL_0082;
			}
		}
		OnlineSettings onlineSettings = OnlineSettings.instance;
		result = onlineSettings.HasValue(onlineSettingsId);
		goto IL_0082;
		IL_0082:
		return result;
	}

	public static int GetDiscountValue(string onlineSettingsId, int defaultValue)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		if (~(Globals.DEBUG_ENABLE_SALES ? 1u : 0u) == 0)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S3_v6+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			if (obj4 != null)
			{
				return _debugDiscount.get_Item(onlineSettingsId);
			}
		}
		OnlineSettings onlineSettings = OnlineSettings.instance;
		return onlineSettings.GetValue(onlineSettingsId, defaultValue);
	}

	public static Dictionary<string, InAppItemModel> GetActiveInAppOffers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0510: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>>)+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj14 = default;
		for (string[] inAppCurrencyTiers = InAppData.inAppCurrencyTiers; inAppCurrencyTiers.Length > (nint)obj3; obj3 = obj14 + 1)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)inAppCurrencyTiers + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
			string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId((string)0);
			object obj6;
			if (ignoredInAppOnlineSettingsId != null)
			{
				obj6 = 0;
				if (ignoredInAppOnlineSettingsId._stringLength != 0)
				{
					goto IL_0455;
				}
			}
			obj6 = 1;
			goto IL_0455;
			IL_0455:
			bool flag = obj6 == null;
			string key = ignoredInAppOnlineSettingsId;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
				string text = "could not find an ignored inApp id for the pricepont: " + (string)0;
				key = string.Empty;
			}
			OnlineSettings onlineSettings = OnlineSettings.instance;
			if (onlineSettings.HasValue(key))
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
			string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId((string)0);
			object obj7;
			if (inAppOnlineSettingsId != null)
			{
				obj7 = 0;
				if (inAppOnlineSettingsId._stringLength != 0)
				{
					goto IL_048d;
				}
			}
			obj7 = 1;
			goto IL_048d;
			IL_048d:
			bool flag2 = obj7 == null;
			string onlineSettingsId = inAppOnlineSettingsId;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
				string text2 = "could not find a discout id for the pricepont: " + (string)0;
				onlineSettingsId = string.Empty;
			}
			Dictionary<string, InAppItemModel> inAppData = InAppData.inAppData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
			InAppItemModel objectToClone = inAppData.get_Item((string)0);
			InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
			if (IsDiscountActive(onlineSettingsId) && IsAnyDiscountAvailable)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
				string discountIdForNormalOffer = InAppData.GetDiscountIdForNormalOffer((string)0);
				InAppItemModel objectToClone2 = InAppData.inAppData.get_Item(discountIdForNormalOffer);
				InAppItemModel inAppItemModel2 = InAppItemModel.Clone(objectToClone2);
				int discountValue = GetDiscountValue(onlineSettingsId, 0);
				if (discountValue <= -1)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S5_v25 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+5C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ S5_v26+4] (should have been resolved before IL gen)");
				}
				else if (discountValue != 0)
				{
					object obj9 = inAppItemModel2.InAppItemType__BackingField - 5;
					if ((nint)obj9 <= 1)
					{
						int num5 = discountValue + inAppItemModel2.PayoutAmount__BackingField;
						inAppItemModel2.ItemOfferType__BackingField = InAppItemModel.OfferType.Promotion;
						inAppItemModel2.PayoutAmount__BackingField = num5;
						nint num6 = 0;
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S5_v20 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+5C]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v341 @ S5_v21+4] (should have been resolved before IL gen)");
					}
					else
					{
						_ = inAppItemModel2.InAppItemType__BackingField;
						_ = -1;
						obj = (Enum)(object)typeof(InAppItemModel.ItemType);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
						_ = 0;
						string text3 = obj.ToString();
						string text4 = "Invalid item type: " + text3 + ". No sales are implemented for this item type.";
						nint num8 = 0;
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S5_v15 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+5C]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v385 @ S5_v16+4] (should have been resolved before IL gen)");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31+10]");
					string text5 = "Invalid discount value for item: " + (string)0;
					nint num10 = 0;
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S5_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+5C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v374 @ S5_v11+4] (should have been resolved before IL gen)");
				}
			}
			else
			{
				nint num12 = 0;
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+5C]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ S5_v6+4] (should have been resolved before IL gen)");
			}
		}
		Dictionary<string, InAppItemModel> result = default;
		return result;
	}

	public unsafe static double GetDiscountEndTime()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected VT, but got Unknown
		//IL_0046: Expected Ref, but got VT
		//IL_0064: Expected F8, but got I8
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(Globals.DEBUG_ENABLE_SALES ? 1u : 0u) == 0)
		{
			DateTime utcNow = CDateTime.UtcNow;
			DateTime dateTime = (DateTime)(obj + 8);
			DateTime time = ((DateTime*)dateTime)->AddDays(1.0);
			long num = TimeUtility.ToUnixTime(time);
			return num;
		}
		OnlineSettings onlineSettings = OnlineSettings.instance;
		return onlineSettings.GetValue("discount_end_time", 0.0);
	}

	private string GetContactingStoreOverlayText()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			return Strings.Get(StringID.INAPP_MANAGER_OVERLAY_TEXT_GOOGLEPLAY);
		}
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.IPhonePlayer)
		{
			return Strings.Get(StringID.INAPP_MANAGER_OVERLAY_TEXT_APPSTORE);
		}
		RuntimePlatform platform3 = Application.platform;
		if (platform3 == RuntimePlatform.MetroPlayerARM)
		{
			return Strings.Get(StringID.INAPP_MANAGER_OVERLAY_TEXT_WINDOWSSTORE);
		}
		return string.Empty;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public InAppManagerPopupData GetPopupData()
	{
		return _popupData;
	}

	public void DeletePopupData()
	{
		_popupData = null;
	}

	static InAppManager()
	{
		//IL_003f: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S5_v19+4] (should have been resolved before IL gen)");
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S5_v24+4] (should have been resolved before IL gen)");
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S5_v29+4] (should have been resolved before IL gen)");
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S5_v34+4] (should have been resolved before IL gen)");
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S5_v39+4] (should have been resolved before IL gen)");
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ S5_v44+4] (should have been resolved before IL gen)");
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ S5_v49+4] (should have been resolved before IL gen)");
		Dictionary<string, int> debugDiscount = default;
		_debugDiscount = debugDiscount;
		_isRestoredManually = false;
		_hasSuccessfullyInitialized = false;
		_applicationIsQuiting = false;
	}
}
