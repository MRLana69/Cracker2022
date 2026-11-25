using System;
using System.Collections;
using System.Collections.Generic;
using Extra;
using UnityEngine;

public class InAppManager : MonoBehaviour
{
	private enum InAppPurchaseState
	{
		NotStarted = 0,
		Started = 1,
		Failed = 2,
		Complete = 3
	}

	private const string GAME_OBJECT_NAME = "InAppManager";

	private static InAppManager _instance;

	private static InAppData inAppData;

	[NonSerialized]
	public AudioClip purchaseSuccessSound;

	private InAppPurchaseState _inAppPurchaseState;

	[HideInInspector]
	public bool productRequestSucceeded;

	public Action onPurchaseSuccess;

	public Action onProductRequestSuccess;

	private string inAppPurchaseKey = string.Empty;

	private string itemRequested = string.Empty;

	public static InAppManager Instance
	{
		get
		{
			Init();
			return _instance;
		}
	}

	public static bool IsInstanced()
	{
		return _instance != null;
	}

	public static void Init()
	{
		if (_instance == null)
		{
			Debug.Log("InAppManager init()");
			GameObject gameObject = new GameObject();
			gameObject.name = "InAppManager";
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.AddComponent<InAppManager>();
		}
	}

	private void Awake()
	{
		_instance = this;
	}

	private void Start()
	{
		productRequestSucceeded = false;
		inAppData = new InAppData();
	}

	public void QueryInApps()
	{
	}

	public void BuyInApp(string purchaseId)
	{
	}

	public void BuyFromPopup(string purchaseId)
	{
	}

	private void StartPurchase(string inAppPurchaseId)
	{
	}

	public void SetupNativePopup(int cost, string senderName)
	{
		itemRequested = senderName;
		int num = 0;
		num = cost - PlayerInfo.Instance.amountOfCoins;
		string text = string.Empty;
		if (Instance.productRequestSucceeded)
		{
			foreach (KeyValuePair<string, InAppProfile> inAppDatum in InAppData.inAppData)
			{
				if (!inAppDatum.Value.validInApp || inAppDatum.Value.amountOfCoins <= num)
				{
					continue;
				}
				if (!string.IsNullOrEmpty(text))
				{
					if (InAppData.inAppData[text].amountOfCoins > InAppData.inAppData[inAppDatum.Key].amountOfCoins)
					{
						text = inAppDatum.Key;
					}
				}
				else
				{
					text = inAppDatum.Key;
				}
			}
		}
		inAppPurchaseKey = text;
		string textNotEnough = Wrapper.GetTextNotEnough();
		if (!string.IsNullOrEmpty(inAppPurchaseKey))
		{
			string message = string.Format(Wrapper.GetTextYouNeedMoreCoins(), num, InAppData.inAppData[text].amountOfCoins);
			DeviceUtility.showNativePopup(textNotEnough, message, "Ok");
		}
		else
		{
			string message2 = string.Format(Wrapper.GetTextYouNeedMoreCoins(), num);
			DeviceUtility.showNativePopup(textNotEnough, message2, "Ok");
		}
	}

	public void NativePurchaseInappPack(string message)
	{
	}

	public void PurchaseStatePurchased(string productId)
	{
		if (UIScreenController.isInstanced)
		{
			UIScreenController.Instance.HideInAppPurchaseOverlay();
		}
		return;
	}

	public void PurchaseStateCanceled(string itemId)
	{
		UIScreenController.Instance.HideInAppPurchaseOverlay();
		Screen.sleepTimeout = -2;
	}

	public void PurchaseStateRefunded(string itemId)
	{
		UIScreenController.Instance.HideInAppPurchaseOverlay();
		Screen.sleepTimeout = -2;
	}

	public void RequestSuccessful(string productId)
	{
		UIScreenController.Instance.HideInAppPurchaseOverlay();
		Screen.sleepTimeout = -2;
	}

	public void RequestFailed(string error)
	{
		UIScreenController.Instance.HideInAppPurchaseOverlay();
		Screen.sleepTimeout = -2;
	}

	public void RequestCancelled(string error)
	{
		UIScreenController.Instance.HideInAppPurchaseOverlay();
		Screen.sleepTimeout = -2;
	}

	public void ConfirmationFail(string productId)
	{
	}

	private void StartPurchaseAndroid(string inAppPurchaseId)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
