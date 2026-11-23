using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InAppPurchase.Internal;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase;

public class InAppPurchaseProvider : IPurchaseProvider, IInAppManager
{
	private IPurchaseProvider _provider;

	private IAPPluginInitializationState _currentInitializationState;

	private IInAppManager _inAppManager;

	private Dictionary<string, ProductRequestResultInfo> _latestProductInfo;

	private static InAppPurchaseProvider _instance;

	public static InAppPurchaseProvider instance
	{
		get
		{
			if (_instance == null)
			{
				InAppPurchaseProvider inAppPurchaseProvider = default;
				inAppPurchaseProvider._002Ector();
				_instance = inAppPurchaseProvider;
			}
			return _instance;
		}
	}

	public bool isInstanced => _instance != null;

	private InAppPurchaseProvider()
	{
		//IL_0013: Expected Obj, but got I4
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppPurchase.ProductRequestResultInfo>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, ProductRequestResultInfo> latestProductInfo = default;
		_latestProductInfo = latestProductInfo;
		RuntimePlatform platform = Application.platform;
		IPurchaseProvider provider;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj = platform - 7;
			if (platform != RuntimePlatform.WindowsEditor)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj != 2 && (nint)obj != 3)
					{
						if ((nint)obj == 4)
						{
							IPurchaseProvider purchaseProvider = default;
							provider = purchaseProvider;
							goto IL_0112;
						}
						if (platform == RuntimePlatform.MetroPlayerARM)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B6");
							IPurchaseProvider provider2 = default;
							_provider = provider2;
							return;
						}
					}
					LogError("There's no provider for the current platform.");
					return;
				}
				IPurchaseProvider purchaseProvider2 = default;
				provider = purchaseProvider2;
				goto IL_0112;
			}
		}
		IPurchaseProvider purchaseProvider3 = default;
		provider = purchaseProvider3;
		goto IL_0112;
		IL_0112:
		_provider = provider;
	}

	public ProductRequestResultInfo[] GetLatestRequestedProductInfo()
	{
		Dictionary<string, ProductRequestResultInfo>.ValueCollection values = _latestProductInfo.Values;
		ProductRequestResultInfo[] array = Enumerable.ToArray(values);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @378");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		ProductRequestResultInfo[] result = default;
		return result;
	}

	public unsafe bool TryGetLatestRequestedProductInfoForProductId(string productId, out ProductRequestResultInfo productInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Dictionary<string, ProductRequestResultInfo>.ValueCollection values = _latestProductInfo.Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5338");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj5 = obj + 16;
		object obj6 = obj5 | 4;
		object obj8 = default;
		object obj10 = default;
		bool result;
		object obj12 = default;
		object obj13 = default;
		bool flag2 = default;
		bool flag3 = default;
		while (true)
		{
			_ = 0;
			object obj7 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj8 == null)
				{
					goto IL_01ff;
				}
				_ = 0;
				object obj9 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v56+C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v56+14]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24+8]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj10 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							ref ProductRequestResultInfo reference = ref *(ProductRequestResultInfo*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
							_ = 0;
							object obj11 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F18");
							result = true;
							break;
						}
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
			bool flag = obj12 != obj13;
			result = flag2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01ff;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag3;
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
			break;
			IL_01ff:
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F18");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			result = false;
			break;
		}
		return result;
	}

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer = null)
	{
		if (_currentInitializationState == IAPPluginInitializationState.NotInitialized)
		{
			_inAppManager = inAppManager;
			_currentInitializationState = IAPPluginInitializationState.Initializing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
	}

	public bool CanMakePurchases()
	{
		if (_currentInitializationState == IAPPluginInitializationState.InitializedSuccessfully)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}

	public void RequestProductInfo(string[] productIds)
	{
		if (CanMakePurchases())
		{
			IEnumerable<string> source = Enumerable.Distinct(productIds);
			string[] array = Enumerable.ToArray(source);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public bool StartPurchase(string productId)
	{
		if (!CanMakePurchases())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A7C");
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		bool result = default;
		return result;
	}

	public bool StartPurchase(string productId, string cookie)
	{
		if (!CanMakePurchases())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A7C");
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		bool result = default;
		return result;
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		if (!CanMakePurchases())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		bool result = default;
		return result;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		if (CanMakePurchases())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58D");
		}
	}

	public void InitFinishedCallback(bool success)
	{
		IAPPluginInitializationState currentInitializationState = IAPPluginInitializationState.InitializedSuccessfully;
		if (!success)
		{
			currentInitializationState = IAPPluginInitializationState.NotInitialized;
		}
		_currentInitializationState = currentInitializationState;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public string getInAppAPIKey()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public IsIAPConsumableValue IsProductConsumable(string productID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		IsIAPConsumableValue result = default;
		return result;
	}

	public unsafe void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected VT, but got Unknown
		//IL_0204: Expected Obj, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_015d: Expected native int or pointer, but got VT
		//IL_0177: Expected Obj, but got I
		//IL_0172: Expected native int or pointer, but got VT
		//IL_0192: Expected Obj, but got I
		object obj = default;
		ProductRequestResultInfo productRequestResultInfo = (ProductRequestResultInfo)(obj - 96);
		if (success)
		{
			object obj2 = productRequestResultInfo + 48;
			object obj3 = obj2 | 4;
			object obj4 = productRequestResultInfo + 32;
			object obj5 = obj4 | 4;
			object obj6 = productRequestResultInfo - -64;
			object obj7 = obj6 | 4;
			object obj8 = default;
			object obj14 = default;
			object obj16 = default;
			while ((nint)obj8 < productInfo.Length)
			{
				object obj9 = productRequestResultInfo - -64;
				object obj10 = obj8 << 4;
				object obj11 = (object)productInfo + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v18+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v18+10]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21+8]");
				_ = 0;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S3_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppPurchase.ProductRequestResultInfo>>)+54]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S3_v8+4] (should have been resolved before IL gen)");
				object obj13 = obj14 ^ -1;
				object obj15 = obj13 >> 31;
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+40]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+50]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+38]");
					System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo)->title, (string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+30]");
					System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo)->productId, (string)0);
					Dictionary<string, ProductRequestResultInfo> latestProductInfo = _latestProductInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+40]");
					latestProductInfo.set_Item((string)0, productRequestResultInfo);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+40]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+50]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+20]");
					_ = 0;
					ProductRequestResultInfo value = (ProductRequestResultInfo)(productRequestResultInfo + 16);
					Dictionary<string, ProductRequestResultInfo> latestProductInfo2 = _latestProductInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (InAppPurchase.ProductRequestResultInfo)+40]");
					latestProductInfo2.Add((string)0, value);
				}
				obj8 = obj16 + 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
	}

	public void PurchaseRequestCallback(string productId, string transactionId, string transationIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A7C");
	}

	public void ItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @960");
	}

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @960");
	}

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	private static void LogError(string msg)
	{
		string text = "[InAppPurchaseProvider] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}
}
