using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase.Internal;

public class WSAPurchaseProvider : MonoBehaviour, IPurchaseProvider
{
	private const string CALLBACK_RECEIVER_NAME = "WSAPurchaseBridgeReceiver";

	private IInAppManager _inAppManager;

	private PurchaseDelegate _purchaseDelegate;

	private ItemRestoredDelegate _itemRestoredDelegate;

	private ItemRefundedDelegate _itemRefundedDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private ValidationMode _validationMode;

	private GameObject _callbackGameObject;

	public GameObject CreateCallbackGameObject()
	{
		GameObject gameObject = default;
		gameObject._002Ector("WSAPurchaseBridgeReceiver");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		WSAPurchaseProvider wSAPurchaseProvider = gameObject.AddComponent<WSAPurchaseProvider>();
		return gameObject;
	}

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		//IL_0134: Expected I, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		_inAppManager = inAppManager;
		NullReferenceException ex = new NullReferenceException();
		PurchaseDelegate purchaseDelegate = default;
		purchaseDelegate._002Ector(inAppManager, (IntPtr)ex);
		_purchaseDelegate = purchaseDelegate;
		NullReferenceException ex2 = new NullReferenceException();
		ProductInfoRequestDelegate productInfoRequestDelegate = default;
		productInfoRequestDelegate._002Ector(inAppManager, (IntPtr)ex2);
		_productRequestDelegate = productInfoRequestDelegate;
		NullReferenceException ex3 = new NullReferenceException();
		ItemRestoredDelegate itemRestoredDelegate = default;
		itemRestoredDelegate._002Ector(inAppManager, (IntPtr)ex3);
		_itemRestoredDelegate = itemRestoredDelegate;
		NullReferenceException ex4 = new NullReferenceException();
		ItemRefundedDelegate itemRefundedDelegate = default;
		itemRefundedDelegate._002Ector(inAppManager, (IntPtr)ex4);
		_itemRefundedDelegate = itemRefundedDelegate;
		NullReferenceException ex5 = new NullReferenceException();
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = default;
		restorePurchaseFinishedDelegate._002Ector(inAppManager, (IntPtr)ex5);
		_restorePurchaseFinishedDelegate = restorePurchaseFinishedDelegate;
		if (_callbackGameObject == null)
		{
			WSAPurchaseProvider wSAPurchaseProvider = (WSAPurchaseProvider)(this + 40);
			GameObject gameObject = wSAPurchaseProvider.CreateCallbackGameObject();
			wSAPurchaseProvider = (WSAPurchaseProvider)(object)gameObject;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public bool CanMakePurchases()
	{
		return false;
	}

	public void RequestProductInfo(string[] productIds)
	{
	}

	public bool StartPurchase(string productId)
	{
		bool flag = ((WSAPurchaseProvider)null).StartPurchase((string)null, (string)null);
		return true;
	}

	public bool StartPurchase(string productId, string cookie)
	{
		while (cookie != null && cookie._stringLength == 0)
		{
		}
		return true;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		throw new ArgumentException();
	}

	private void RestoreLicenses(Action<bool> onFinishHandler)
	{
	}

	private void FireEventWithMessage(Action<string> handler, string message)
	{
		if (handler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [handler @ L1 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void FireEmptyEvent(Action handler)
	{
		if (handler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: handler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void RestoreLicensesFinished(bool success)
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = _restorePurchaseFinishedDelegate;
		if (_restorePurchaseFinishedDelegate != null)
		{
			object obj = 2;
			if (!success)
			{
				obj = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void ValidateTransaction(string productId, string transactionId, string transactionRecieptBase64, InternalPurchaseResult purchaseResult)
	{
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "WSAPurchaseProvider: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
