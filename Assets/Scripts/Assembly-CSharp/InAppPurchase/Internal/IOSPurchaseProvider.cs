using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase.Internal;

public class IOSPurchaseProvider : IPurchaseProvider
{
	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "IOSPurchaseBridge_callback";

	private const char SEPARATOR_CHAR = ';';

	private static readonly char[] SEPARATOR_FOR_STRING_SPLIT;

	private IInAppManager _inAppManager;

	private PurchaseDelegate _purchaseDelegate;

	private ItemRestoredDelegate _itemRestoredDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private IPurchaseValidationServer _purchaseValidationServer;

	private GameObject _callbackGameObject;

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		//IL_01cb: Expected I, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
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
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = default;
		restorePurchaseFinishedDelegate._002Ector(inAppManager, (IntPtr)ex4);
		_restorePurchaseFinishedDelegate = restorePurchaseFinishedDelegate;
		_purchaseValidationServer = purchaseValidationServer;
		if (_callbackGameObject == null)
		{
			GameObject gameObject = default;
			gameObject._002Ector("IOSPurchaseBridge_callback");
			_callbackGameObject = gameObject;
			UnityEngine.Object.DontDestroyOnLoad(_callbackGameObject);
			IOSPurchaseProviderCallbackListener iOSPurchaseProviderCallbackListener = _callbackGameObject.AddComponent<IOSPurchaseProviderCallbackListener>();
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public bool CanMakePurchases()
	{
		return false;
	}

	public void RequestProductInfo(string[] productIds)
	{
		string text = ((IOSPurchaseProvider)(object)productIds).ArrayToString(productIds);
	}

	public bool StartPurchase(string productId)
	{
		bool flag = ((IOSPurchaseProvider)(object)productId).StartPurchase(productId, (string)null);
		return false;
	}

	public bool StartPurchase(string productId, string cookie)
	{
		if (cookie == null || cookie._stringLength == 0)
		{
		}
		return false;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		return false;
	}

	private string ArrayToString(string[] array)
	{
		//IL_00cb: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9+10]");
			StringBuilder stringBuilder2 = stringBuilder.Append((string)0);
			object obj4 = array.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				StringBuilder stringBuilder3 = stringBuilder.Append(';');
			}
			object obj5 = obj + 1;
			obj = obj5;
		}
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v6 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private unsafe void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_0168: Expected Obj, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Ref, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Ref, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Ref, but got Unknown
		//IL_0126: Expected Obj, but got I4
		IOSPurchaseProvider iOSPurchaseProvider = default;
		iOSPurchaseProvider._inAppManager = (IInAppManager)this;
		iOSPurchaseProvider._restorePurchaseFinishedDelegate = (RestorePurchaseFinishedDelegate)internalPurchaseResult;
		if (iOSPurchaseProvider.TryParsePurchaseEndedMessage(message, out *(string*)(iOSPurchaseProvider + 12), out *(string*)(iOSPurchaseProvider + 16), out *(string*)(iOSPurchaseProvider + 20)))
		{
			if (_purchaseValidationServer != null && iOSPurchaseProvider._restorePurchaseFinishedDelegate == null)
			{
				throw new ArgumentException();
			}
			if ((nint)iOSPurchaseProvider._restorePurchaseFinishedDelegate == 5)
			{
				ItemRestoredDelegate itemRestoredDelegate = _itemRestoredDelegate;
				if (_itemRestoredDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				return;
			}
			PurchaseDelegate purchaseDelegate = _purchaseDelegate;
			if (_purchaseDelegate != null)
			{
				bool flag = (nint)iOSPurchaseProvider._restorePurchaseFinishedDelegate < 5;
				RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = iOSPurchaseProvider._restorePurchaseFinishedDelegate;
				if (!flag)
				{
					restorePurchaseFinishedDelegate = (RestorePurchaseFinishedDelegate)1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		else
		{
			string msg = "IOSPurchaseProvider ERROR: Malformed message from native code: " + message;
			LogError(msg);
		}
	}

	private unsafe bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId, out string transactionRecieptBase64)
	{
		string[] array = message.Split(SEPARATOR_FOR_STRING_SPLIT);
		if (array.Length == 3)
		{
			ref string reference = ref *(string*)array[0];
			ref string reference2 = ref *(string*)array[1];
			ref string reference3 = ref *(string*)array[2];
		}
		else
		{
			ref string reference = ref *(string*)string.Empty;
			ref string reference2 = ref *(string*)string.Empty;
			ref string reference3 = ref *(string*)string.Empty;
		}
		return array.Length == 3;
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
		if (((IOSPurchaseProvider)(object)message).TryParseProductInfo(message, out *(ProductRequestResultInfo[]*)(obj + 28)))
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector("IOSPurchaseProvider ProductInfo:\n");
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
			string msg = "IOSPurchaseProvider ERROR: Malformed message from native code: " + message;
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

	private void PurchaseFailed(string message)
	{
		string text = default;
		string[] array = text.Split(SEPARATOR_FOR_STRING_SPLIT);
		bool flag = array.Length == 4;
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
		//IL_006c: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = int.TryParse(message, out *(int*)(obj + 12));
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = _restorePurchaseFinishedDelegate;
		if (_restorePurchaseFinishedDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj4 = -1;
			if ((nint)obj4 >= 3)
			{
				obj3 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg)
	{
		string text = "[IOSPurchaseProvider] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}

	private static void IOSPurchaseBridge_Init()
	{
	}

	private static bool IOSPurchaseBridge_CanMakePayments()
	{
		return false;
	}

	private static void IOSPurchaseBridge_RunProductsRequest(string productIdsList)
	{
	}

	private static bool IOSPurchaseBridge_StartPurchase(string productId)
	{
		return false;
	}

	private static void IOSPurchaseBridge_FinishTransaction(string productId, string transactionId)
	{
	}

	private static bool IOSPurchaseBridge_RestoreNonConsumablePurchases()
	{
		return false;
	}

	private static bool IOSPurchaseBridge_EnableDebugLogs(string enabledBoolString)
	{
		return false;
	}

	static IOSPurchaseProvider()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = ';';
		SEPARATOR_FOR_STRING_SPLIT = array;
	}
}
