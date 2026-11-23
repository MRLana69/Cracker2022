using System;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase.Internal;

public class KindlePurchaseProvider : MonoBehaviour, IPurchaseProvider
{
	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "KindleInAppCallback";

	private const string FINISHED_TRANSACTION_ID_PREFIX = "SHOULD_CONSUME_";

	private const string SEPARATOR_CHAR = ";";

	private static readonly char[] SEPARATOR_FOR_STRING_SPLIT;

	private PurchaseDelegate _purchaseDelegate;

	private ItemRestoredDelegate _itemRestoredDelegate;

	private ItemRefundedDelegate _itemRefundedDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private AndroidJavaObject _iabInstance;

	private GameObject _callbackGameObject;

	public GameObject CreateCallbackGameObject()
	{
		GameObject gameObject = default;
		gameObject._002Ector("KindleInAppCallback");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		KindlePurchaseProviderCallbackListener kindlePurchaseProviderCallbackListener = gameObject.AddComponent<KindlePurchaseProviderCallbackListener>();
		throw new ArgumentException();
	}

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		//IL_015c: Expected I, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
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
			GameObject callbackGameObject = CreateCallbackGameObject();
			_callbackGameObject = callbackGameObject;
		}
		AndroidJavaObject iabInstance = _iabInstance;
		if (_iabInstance == null)
		{
			object[] args = Array.Empty<object>();
			AndroidJavaObject androidJavaObject = default;
			androidJavaObject._002Ector("com.kiloo.kindleinapppurchase.KindleManager", args);
			_iabInstance = androidJavaObject;
			iabInstance = _iabInstance;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ S4_v13 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Set>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
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

	public void RequestProductInfo(string[] productIds)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string text = string.Join(";", productIds);
		throw new ArrayTypeMismatchException();
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		return true;
	}

	public bool StartPurchase(string productId)
	{
		bool flag = StartPurchase(productId, (string)(object)this);
		return true;
	}

	public bool StartPurchase(string productId, string cookie)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public unsafe void ProductRequestSuccessful(string message)
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
		if (((KindlePurchaseProvider)(object)message).TryParseProductInfo(message, out *(ProductRequestResultInfo[]*)(obj + 28)))
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector("KindlePurchaseProvider ProductInfo:\n");
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
			string msg = "KindlePurchaseProvider ERROR: Malformed message from native code: " + message;
			LogError(msg);
		}
	}

	public void ProductRequestFailed(string message)
	{
		ProductInfoRequestDelegate productRequestDelegate = _productRequestDelegate;
		if (_productRequestDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoredSuccessfully(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Restored);
	}

	public void ProductRestoreFinished()
	{
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = _restorePurchaseFinishedDelegate;
		if (_restorePurchaseFinishedDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoreFailed()
	{
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = _restorePurchaseFinishedDelegate;
		if (_restorePurchaseFinishedDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoreFinishedButNothingHasBeenRestored()
	{
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = _restorePurchaseFinishedDelegate;
		if (_restorePurchaseFinishedDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductPurchasedSuccessfully(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Completed);
	}

	public void ProductPurchaseInvalidId(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.ItemUnavailable);
	}

	public void ProductPurchaseFailed(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Canceled);
	}

	public void ProductRefunded(string message)
	{
		HandlePurchaseEnded(message, InternalPurchaseResult.Refunded);
	}

	private void ValidateTransaction(string productId, string transactionId, string transactionRecieptBase64, InternalPurchaseResult internalPurchaseResult)
	{
	}

	private unsafe void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Ref, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Ref, but got Unknown
		//IL_0021: Expected Obj, but got I4
		object obj = default;
		KindlePurchaseProvider kindlePurchaseProvider = (KindlePurchaseProvider)(obj - 16);
		kindlePurchaseProvider._purchaseDelegate = null;
		((UnityEngine.Object)kindlePurchaseProvider).m_CachedPtr = (IntPtr)0;
		if (kindlePurchaseProvider.TryParsePurchaseEndedMessage(message, out *(string*)(kindlePurchaseProvider + 12), out *(string*)(kindlePurchaseProvider + 8)))
		{
			object obj2 = internalPurchaseResult - 5;
			if (internalPurchaseResult != InternalPurchaseResult.Restored)
			{
				if ((nint)obj2 == 1)
				{
					ItemRefundedDelegate itemRefundedDelegate = _itemRefundedDelegate;
					if (_itemRefundedDelegate != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					return;
				}
				PurchaseDelegate purchaseDelegate = _purchaseDelegate;
				if (_purchaseDelegate != null)
				{
					bool flag = internalPurchaseResult < InternalPurchaseResult.Restored;
					InternalPurchaseResult internalPurchaseResult2 = internalPurchaseResult;
					if (!flag)
					{
						internalPurchaseResult2 = InternalPurchaseResult.Failed;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v123.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			else
			{
				ItemRestoredDelegate itemRestoredDelegate = _itemRestoredDelegate;
				if (_itemRestoredDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
		else
		{
			string msg = "KindlePurchaseProvider ERROR: Malformed message from native code: " + message;
			LogError(msg);
		}
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

	private unsafe bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId)
	{
		string[] array = message.Split(SEPARATOR_FOR_STRING_SPLIT);
		if (array.Length == 2)
		{
			ref string reference = ref *(string*)array[0];
			ref string reference2 = ref *(string*)array[1];
		}
		else
		{
			ref string reference = ref *(string*)string.Empty;
			ref string reference2 = ref *(string*)string.Empty;
		}
		return array.Length == 2;
	}

	private static void LogError(string msg)
	{
		string text = "[KindlePurchaseProvider] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}

	static KindlePurchaseProvider()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = ';';
		SEPARATOR_FOR_STRING_SPLIT = array;
	}
}
