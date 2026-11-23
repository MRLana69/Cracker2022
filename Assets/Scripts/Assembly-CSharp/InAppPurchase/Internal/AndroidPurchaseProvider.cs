using System;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase.Internal;

public class AndroidPurchaseProvider : IPurchaseProvider
{
	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "AndroidPurchaseBridge_callback";

	private const string FINISHED_TRANSACTION_ID_PREFIX = "SHOULD_CONSUME_";

	private const string FINISHED_PURCHASE_TOKEN_PREFIX = "SHOULD_CONSUME_TOKEN_";

	private const string SEPARATOR_CHAR = ";";

	private static readonly char[] SEPARATOR_FOR_STRING_SPLIT;

	private InitDelegate _initDelegate;

	private PurchaseDelegate _purchaseDelegate;

	private ItemRestoredDelegate _itemRestoredDelegate;

	private ItemRefundedDelegate _itemRefundedDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private IInAppManager _inAppManager;

	private IPurchaseValidationServer _purchaseValidationServer;

	private string _iapAPIKey;

	private AndroidJavaObject _iabInstance;

	private GameObject _callbackGameObject;

	public unsafe void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		//IL_02d0: Expected I, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
		//IL_00dc: Expected I, but got Obj
		_inAppManager = inAppManager;
		NullReferenceException ex = new NullReferenceException();
		InitDelegate initDelegate = default;
		initDelegate._002Ector(inAppManager, (IntPtr)ex);
		_initDelegate = initDelegate;
		NullReferenceException ex2 = new NullReferenceException();
		PurchaseDelegate purchaseDelegate = default;
		purchaseDelegate._002Ector(inAppManager, (IntPtr)ex2);
		_purchaseDelegate = purchaseDelegate;
		NullReferenceException ex3 = new NullReferenceException();
		ProductInfoRequestDelegate productInfoRequestDelegate = default;
		productInfoRequestDelegate._002Ector(inAppManager, (IntPtr)ex3);
		_productRequestDelegate = productInfoRequestDelegate;
		NullReferenceException ex4 = new NullReferenceException();
		ItemRestoredDelegate itemRestoredDelegate = default;
		itemRestoredDelegate._002Ector(inAppManager, (IntPtr)ex4);
		_itemRestoredDelegate = itemRestoredDelegate;
		NullReferenceException ex5 = new NullReferenceException();
		ItemRefundedDelegate itemRefundedDelegate = default;
		itemRefundedDelegate._002Ector(inAppManager, (IntPtr)ex5);
		_itemRefundedDelegate = itemRefundedDelegate;
		NullReferenceException ex6 = new NullReferenceException();
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = default;
		restorePurchaseFinishedDelegate._002Ector(inAppManager, (IntPtr)ex6);
		_restorePurchaseFinishedDelegate = restorePurchaseFinishedDelegate;
		_purchaseValidationServer = purchaseValidationServer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string iapAPIKey = default;
		_iapAPIKey = iapAPIKey;
		AndroidJavaObject iabInstance = _iabInstance;
		if (_iabInstance == null)
		{
			object[] args = Array.Empty<object>();
			AndroidJavaObject androidJavaObject = default;
			androidJavaObject._002Ector("com.kiloo.androidiablibrary.IABBridge", args);
			_iabInstance = androidJavaObject;
			iabInstance = _iabInstance;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S4_v15 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Set>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v167 @ S4_v19 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Set>>)+4] (should have been resolved before IL gen)");
		if (_callbackGameObject == null)
		{
			GameObject gameObject = default;
			gameObject._002Ector("AndroidPurchaseBridge_callback");
			_callbackGameObject = gameObject;
			UnityEngine.Object.DontDestroyOnLoad(_callbackGameObject);
			AndroidPurchaseProviderCallbackListener androidPurchaseProviderCallbackListener = _callbackGameObject.AddComponent<AndroidPurchaseProviderCallbackListener>();
			Action action = default;
			action._002Ector(this, (nint)__ldftn(AndroidPurchaseProvider.InitSuccessful));
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(AndroidPurchaseProvider.InitFailed));
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public bool CanMakePurchases()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public unsafe void RequestProductInfo(string[] productIds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
		//IL_0098: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = string.Join(";", productIds);
		string text2 = string.Empty;
		object obj3 = default;
		object obj6 = default;
		object obj7 = default;
		while (productIds.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)productIds + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool flag = obj6 == null;
			bool flag2 = (byte)(obj + 15) != 0;
			string text3 = (flag2 ? ((bool*)1) : ((bool*)null))->ToString();
			string text4 = text2 + text3 + ";";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v3+10]");
			string value = ((string)0).ToLower();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v3+10]");
			if (!((string)0).Equals(value))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v3+10]");
				string msg = "The product id: " + (string)0 + " contains uppercase letters. This is an error, as it will not be accepted by Google Play!";
				LogError(msg);
			}
			obj3 = obj7 + 1;
			text2 = text4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public bool StartPurchase(string productId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public bool StartPurchase(string productId, string cookie)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj = default;
		if (obj != null)
		{
			goto IL_00e5;
		}
		object obj2;
		if (transactionId != null)
		{
			obj2 = 0;
			if (transactionId._stringLength != 0)
			{
				goto IL_0188;
			}
		}
		obj2 = 1;
		goto IL_0188;
		IL_0188:
		if (obj2 == null)
		{
			string key = "SHOULD_CONSUME_" + transactionId;
			PlayerPrefs.SetString(key, productId);
		}
		object obj3;
		if (purchaseToken != null)
		{
			obj3 = 0;
			if (purchaseToken._stringLength != 0)
			{
				goto IL_01b0;
			}
		}
		obj3 = 1;
		goto IL_01b0;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
		IL_01b0:
		if (obj3 == null)
		{
			string key2 = "SHOULD_CONSUME_TOKEN_" + purchaseToken;
			PlayerPrefs.SetString(key2, productId);
		}
		PlayerPrefs.Save();
		goto IL_00e5;
	}

	private string ProductIDsAsString(string[] productIds)
	{
		return string.Join(";", productIds);
	}

	private unsafe string ProductIsConsumableAsString(string[] productIds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = string.Empty;
		object obj3 = default;
		object obj6 = default;
		object obj7 = default;
		while (productIds.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)productIds + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool flag = obj6 == null;
			bool flag2 = (byte)(obj + 15) != 0;
			string text2 = (flag2 ? ((bool*)1) : ((bool*)null))->ToString();
			string text3 = text + text2 + ";";
			obj3 = obj7 + 1;
			text = text3;
		}
		return text;
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AndroidPurchaseProvider androidPurchaseProvider = default;
		string text = androidPurchaseProvider.ProductIDsAsString(productIds);
		throw new ArrayTypeMismatchException();
	}

	private void InitSuccessful()
	{
		InitDelegate initDelegate = _initDelegate;
		if (_initDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void InitFailed()
	{
		InitDelegate initDelegate = _initDelegate;
		if (_initDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private unsafe void ProductRequestSuccessful(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Ref, but got Unknown
		//IL_0036: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (((AndroidPurchaseProvider)(object)message).TryParseProductInfo(message, out *(ProductRequestResultInfo[]*)(obj + 28)))
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector("AndroidPurchaseProvider ProductInfo:\n");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj3 = 0;
			object obj4 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23+C]");
				if (0 <= (nint)obj4)
				{
					break;
				}
				object obj5 = obj4 << 4;
				object obj6 = obj3 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v15+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v15+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				string value = "    productId: " + (string)num + "  localized price: " + (string)0;
				StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
				object obj7 = obj4 + 1;
				obj4 = obj7;
			}
			ProductInfoRequestDelegate productRequestDelegate = _productRequestDelegate;
			if (_productRequestDelegate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v126.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		else
		{
			string msg = "AndroidPurchaseProvider ERROR: Malformed message from native code: " + message;
			LogError(msg);
		}
	}

	private void ProductRequestFailed()
	{
		ProductInfoRequestDelegate productRequestDelegate = _productRequestDelegate;
		if (_productRequestDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void PurchasePurchased(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Completed);
	}

	private void PurchaseRestored(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Restored);
	}

	private void PurchaseRefunded(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Refunded);
	}

	private void PurchaseFailed(string message)
	{
		string text = default;
		string[] array = text.Split(SEPARATOR_FOR_STRING_SPLIT);
		bool flag = array.Length == 6;
		bool flag2 = !flag;
		InternalPurchaseResult internalPurchaseResult = InternalPurchaseResult.Failed;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3665");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		string message2 = default;
		HandlePurchaseEnded(message2, internalPurchaseResult);
	}

	private unsafe void RestoreFinished(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = int.TryParse(message, out *(int*)(obj + 12));
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = _restorePurchaseFinishedDelegate;
		if (_restorePurchaseFinishedDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag2 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag3 = (nint)0 == 2;
			bool flag4 = true;
			if (!flag3)
			{
				flag4 = flag2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private unsafe void ConsumeFinished(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = message.Split(SEPARATOR_FOR_STRING_SPLIT);
		string text2;
		string text3;
		if (array.Length != 2)
		{
			_ = array.Length;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string msg = "Unexpected length of message in ConsumeFinished, expected 2, received " + text;
			LogError(msg);
			text2 = string.Empty;
			text3 = string.Empty;
		}
		else
		{
			text2 = array[0];
			text3 = array[1];
		}
		string key = "SHOULD_CONSUME_" + text2;
		string text4 = PlayerPrefs.GetString(key);
		string key2 = "SHOULD_CONSUME_TOKEN_" + text3;
		string text5 = PlayerPrefs.GetString(key2);
		object obj3;
		if (text4 != null)
		{
			obj3 = 0;
			if (text4._stringLength != 0)
			{
				goto IL_020e;
			}
		}
		obj3 = 1;
		goto IL_020e;
		IL_020e:
		if (obj3 == null)
		{
			string key3 = "SHOULD_CONSUME_" + text2;
			PlayerPrefs.DeleteKey(key3);
		}
		object obj4;
		if (text5 != null)
		{
			obj4 = 0;
			if (text5._stringLength != 0)
			{
				goto IL_0236;
			}
		}
		obj4 = 1;
		goto IL_0236;
		IL_0236:
		if (obj4 == null)
		{
			string key4 = "SHOULD_CONSUME_TOKEN_" + text3;
			PlayerPrefs.DeleteKey(key4);
		}
		else if (obj3 != null)
		{
			return;
		}
		PlayerPrefs.Save();
	}

	private unsafe void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0398: Expected Obj, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Ref, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Ref, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Ref, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Ref, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Ref, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		AndroidPurchaseProvider androidPurchaseProvider = default;
		androidPurchaseProvider._initDelegate = (InitDelegate)(object)this;
		androidPurchaseProvider._restorePurchaseFinishedDelegate = (RestorePurchaseFinishedDelegate)internalPurchaseResult;
		object obj6;
		if (androidPurchaseProvider.TryParsePurchaseEndedMessage(message, out *(string*)(androidPurchaseProvider + 12), out *(string*)(androidPurchaseProvider + 16), out *(string*)(obj + 12), out *(string*)(androidPurchaseProvider + 24), out *(string*)(androidPurchaseProvider + 20)))
		{
			object obj3 = androidPurchaseProvider._restorePurchaseFinishedDelegate - 2;
			if ((nint)androidPurchaseProvider._restorePurchaseFinishedDelegate != 2)
			{
				if ((nint)obj3 != 1 && (nint)obj3 != 2)
				{
					if ((nint)obj3 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						object obj4 = default;
						if (obj4 == null)
						{
							FinishPurchase((string)(object)androidPurchaseProvider._purchaseDelegate, (string)(object)androidPurchaseProvider._itemRestoredDelegate, (string)(object)androidPurchaseProvider._itemRefundedDelegate);
						}
						ItemRestoredDelegate itemRestoredDelegate = _itemRestoredDelegate;
						if (_itemRestoredDelegate != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v218.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
						return;
					}
					if ((nint)obj3 == 4)
					{
						ItemRefundedDelegate itemRefundedDelegate = _itemRefundedDelegate;
						if (_itemRefundedDelegate != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
						return;
					}
				}
				string key = "SHOULD_CONSUME_" + (string)(object)androidPurchaseProvider._itemRestoredDelegate;
				string text = PlayerPrefs.GetString(key);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj5 = default;
				if ((nint)obj5 == 1)
				{
					goto IL_0266;
				}
				if (text != null)
				{
					obj6 = 0;
					if (text._stringLength != 0)
					{
						goto IL_041c;
					}
				}
				obj6 = 1;
				goto IL_041c;
			}
			PurchaseDelegate purchaseDelegate = _purchaseDelegate;
			if (_purchaseDelegate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
		}
		string msg = "AndroidPurchaseProvider ERROR: Malformed message from native code: " + message;
		LogError(msg);
		return;
		IL_0266:
		if (_purchaseValidationServer != null && androidPurchaseProvider._restorePurchaseFinishedDelegate == null)
		{
			throw new ArgumentException();
		}
		PurchaseDelegate purchaseDelegate2 = _purchaseDelegate;
		if (_purchaseDelegate != null)
		{
			RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = androidPurchaseProvider._restorePurchaseFinishedDelegate;
			if ((nint)androidPurchaseProvider._restorePurchaseFinishedDelegate >= 5)
			{
				restorePurchaseFinishedDelegate = (RestorePurchaseFinishedDelegate)1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v242.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_041c:
		if (obj6 == null)
		{
			FinishPurchase((string)(object)androidPurchaseProvider._purchaseDelegate, (string)(object)androidPurchaseProvider._itemRestoredDelegate, (string)(object)androidPurchaseProvider._itemRefundedDelegate);
			return;
		}
		goto IL_0266;
	}

	private unsafe InternalPurchaseResult GetProperPurchaseResult(string errorCode)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = int.TryParse(errorCode, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		InternalPurchaseResult result = InternalPurchaseResult.Completed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 >= (nint)5)
		{
			result = InternalPurchaseResult.Failed;
		}
		if (!flag)
		{
			result = InternalPurchaseResult.Failed;
		}
		return result;
	}

	private unsafe bool TryParseProductInfo(string message, out ProductRequestResultInfo[] productInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_006b: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = message.Split(SEPARATOR_FOR_STRING_SPLIT);
		object obj23;
		bool result;
		if (array.Length >= 1 && int.TryParse(array[0], out *(int*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = (nint)0 << 2;
			object obj4 = obj3 + 1;
			if (array.Length == (nint)obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj5 = 0;
				object obj21 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					if (0 <= (nint)obj5)
					{
						break;
					}
					object obj6 = obj5 << 2;
					object obj7 = obj6 + 1;
					object obj8 = obj7 << 2;
					object obj9 = (object)array + obj8;
					object obj10 = obj7 + 1;
					object obj11 = obj10 << 2;
					object obj12 = (object)array + obj11;
					object obj13 = obj7 + 2;
					object obj14 = obj13 << 2;
					object obj15 = (object)array + obj14;
					object obj16 = obj7 + 3;
					object obj17 = obj16 << 2;
					object obj18 = (object)array + obj17;
					object obj19 = obj5 << 4;
					object obj20 = obj21 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v41+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v44+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v47+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v50+10]");
					_ = 0;
					object obj22 = obj5 + 1;
					obj5 = obj22;
				}
				obj23 = obj21;
				result = true;
				goto IL_026a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj24 = default;
		obj23 = obj24;
		result = false;
		goto IL_026a;
		IL_026a:
		ref ProductRequestResultInfo[] reference = ref *(ProductRequestResultInfo[]*)obj23;
		return result;
	}

	private unsafe bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId, out string purchaseSignature, out string cookie, out string receipt)
	{
		string[] array = message.Split(SEPARATOR_FOR_STRING_SPLIT);
		if (array.Length == 5)
		{
			ref string reference = ref *(string*)array[0];
			ref string reference2 = ref *(string*)array[1];
			ref string reference3 = ref *(string*)array[2];
			ref string reference4 = ref *(string*)array[3];
			ref string reference5 = ref *(string*)array[4];
		}
		else
		{
			ref string reference = ref *(string*)string.Empty;
			ref string reference2 = ref *(string*)string.Empty;
			ref string reference3 = ref *(string*)string.Empty;
			ref string reference4 = ref *(string*)string.Empty;
			ref string reference5 = ref *(string*)string.Empty;
		}
		return array.Length == 5;
	}

	private static void LogError(string msg)
	{
		string text = "[AndroidPurchaseProvider] " + msg;
	}

	private static void Log(string msg)
	{
	}

	static AndroidPurchaseProvider()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = ';';
		SEPARATOR_FOR_STRING_SPLIT = array;
	}
}
