using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Ionic.Zlib;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;
using UnityEngine.Rendering;

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

	private CheckedItemRestoredDelegate _checkedItemRestoredDelegate;

	private ItemRefundedDelegate _itemRefundedDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private IInAppManager _inAppManager;

	private IPurchaseValidationServer _purchaseValidationServer;

	private string _iapAPIKey;

	private GameObject _callbackGameObject;

	public bool IsValidationServerSpecified
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool result = default;
			return result;
		}
	}

	public unsafe void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected VT, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0049: Expected native int or pointer, but got VT
		//IL_0063: Expected Obj, but got I
		//IL_005e: Expected native int or pointer, but got VT
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_017f: Expected native int or pointer, but got VT
		//IL_0199: Expected Obj, but got I
		//IL_0194: Expected native int or pointer, but got VT
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0130: Expected native int or pointer, but got VT
		//IL_014a: Expected Obj, but got I
		//IL_0145: Expected native int or pointer, but got VT
		object obj = default;
		ProductRequestResultInfo productRequestResultInfo = (ProductRequestResultInfo)(obj + 32);
		object obj2 = obj + 16;
		obj2 = 0;
		_ = 0;
		if (inAppManager != null)
		{
			object obj3 = purchaseValidationServer + 12;
			object obj4 = default;
			object obj12 = default;
			object obj13 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj5 = purchaseValidationServer + 16;
				object obj6 = obj4 << 4;
				object productId = obj5 + obj6;
				System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo)->productId, productId);
				ProductRequestResultInfo productRequestResultInfo2 = productRequestResultInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v16+8]");
				System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo2)->title, (string)0);
				obj2 = productRequestResultInfo.productId;
				_ = productRequestResultInfo.title;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S2_v13 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S2_v14+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v15+44]");
				object obj9 = 0;
				object obj10 = obj9 & 0x1FFF;
				object obj11 = obj10 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v128 @ S3_v8 (should have been resolved before IL gen)");
				if ((nint)obj12 > -1)
				{
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo)->productId, obj2);
					ProductRequestResultInfo productRequestResultInfo3 = productRequestResultInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo3)->title, (string)0);
					((Dictionary<string, ProductRequestResultInfo>)(object)_checkedItemRestoredDelegate).set_Item((string)obj, productRequestResultInfo);
				}
				else
				{
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo)->productId, obj2);
					ProductRequestResultInfo productRequestResultInfo4 = productRequestResultInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					System.Runtime.CompilerServices.Unsafe.Write(&((ProductRequestResultInfo*)(nint)productRequestResultInfo4)->title, (string)0);
					((Dictionary<string, ProductRequestResultInfo>)(object)_checkedItemRestoredDelegate).Add((string)obj, productRequestResultInfo);
				}
				obj4 = obj13 + 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
	}

	public bool CanMakePurchases()
	{
		return _purchaseValidationServer != null;
	}

	public void RequestProductInfo(string[] productIds)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
	}

	public bool StartPurchase(string productId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		bool result = default;
		return result;
	}

	public bool StartPurchase(string productId, string cookie)
	{
		string inAppAPIKey = ((InAppPurchaseProvider)this).getInAppAPIKey();
		if (inAppAPIKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			bool result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8947");
		return false;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
	}

	private string ProductIDsAsString(string[] productIds)
	{
		return null;
	}

	private string ProductIsConsumableAsString(string[] productIds)
	{
		//IL_0017: Expected Obj, but got I4
		return (string)string.CompareOrdinalIgnoreCaseHelper(";", (string)(object)productIds);
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		//IL_009d: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_0094: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		object obj = 0;
		object obj2 = productIds + 12;
		string text = "";
		object obj3 = default;
		object obj7 = default;
		Type type = default;
		object obj9 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = productIds + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			bool flag = obj7 == null;
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
			object obj8 = ((IConvertible)text).ToType(type, (IFormatProvider)(object)";");
			obj3 = obj9 + 1;
			text = (string)obj8;
		}
		return (byte)(int)text != 0;
	}

	private void InitSuccessful()
	{
	}

	private void InitFailed()
	{
		//IL_002f: Expected Obj, but got I4
		if (_initDelegate != null)
		{
			_initDelegate.EndInvoke((IAsyncResult)1);
		}
	}

	private void ProductRequestSuccessful(string message)
	{
		//IL_0185: Expected Obj, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0121: Expected I, but got Obj
		object obj = 0;
		int num = string.CompareOrdinalIgnoreCaseHelper(";", message);
		object obj2 = message + 12;
		string text = "";
		object obj3 = default;
		object obj7 = default;
		Type type = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = message + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			bool flag = obj7 == null;
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
			object obj8 = ((IConvertible)text).ToType(type, (IFormatProvider)(object)";");
			string b = ((string)obj6).ToLowerInvariant();
			if (!string.Equals((string)obj6, b))
			{
				object msg = ((IConvertible)"The product id: ").ToType((Type)obj6, (IFormatProvider)(object)" contains uppercase letters. This is an error, as it will not be accepted by Google Play!");
				nint num2 = (nint)typeof(AndroidPurchaseProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v20 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num3 = (nint)typeof(AndroidPurchaseProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v25 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Log((string)msg);
			}
			obj3 = obj10 + 1;
			text = (string)obj8;
		}
	}

	private void ProductRequestFailed()
	{
		if (_initDelegate != null)
		{
			_initDelegate.EndInvoke(null);
		}
	}

	private void PurchasePurchased(string message)
	{
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I4
		//IL_0150: Expected I4, but got Obj
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_001d: Expected I4, but got Obj
		//IL_01a3: Expected I, but got Obj
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00da: Expected I4, but got Obj
		//IL_00da: Expected I4, but got Obj
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		string text = (string)(obj2 - -64);
		text = (string)0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		if (((EditorPurchaseProvider)null).StartPurchase(message, text))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			stringBuilder.Length = (int)"AndroidPurchaseProvider ProductInfo:\n";
			object obj5 = text + 12;
			object obj6 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj7 = text + 16;
				object obj8 = obj6 << 4;
				object obj9 = obj7 + obj8;
				obj = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v33+8]");
				_ = 0;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
				_ = 0;
				object obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				int value = "    productId: ".IndexOf((char)(int)obj10, (int)"  localized price: ", 0);
				StringBuilder stringBuilder2 = stringBuilder.Append((char)value);
				object obj11 = obj6 + 1;
				obj6 = obj11;
			}
			if (_productRequestDelegate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
			}
			return;
		}
		string msg = string.ConcatArray((string[])(object)"AndroidPurchaseProvider ERROR: Malformed message from native code: ", (int)message);
		nint num = (nint)typeof(AndroidPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v14 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num2 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log(msg);
	}

	private void PurchaseRestored(string message)
	{
		((AndroidPurchaseProviderCallbackListener)this).FireEventWithMessage((Action<string>)(object)message, (string)null);
	}

	private void PurchaseRefunded(string message)
	{
		//IL_000f: Expected Obj, but got I4
		((AndroidPurchaseProviderCallbackListener)this).FireEventWithMessage((Action<string>)(object)message, (string)5);
	}

	private void PurchaseFailed(string message)
	{
		//IL_000f: Expected Obj, but got I4
		((AndroidPurchaseProviderCallbackListener)this).FireEventWithMessage((Action<string>)(object)message, (string)6);
	}

	private void RestoreFinished(string message)
	{
		//IL_020e: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I
		//IL_025e: Expected I4, but got Obj
		//IL_01fb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		nint num = (nint)typeof(AndroidPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = default;
		string text = text2.Substring((int)SEPARATOR_FOR_STRING_SPLIT);
		if (text.m_firstChar == '\u0006')
		{
			object obj2 = text + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A2D2");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj3 = text + 16;
			throw new ArrayTypeMismatchException();
		}
		string message2 = (string)1;
		TypeCode typeCode = default;
		((AndroidPurchaseProviderCallbackListener)this).FireEventWithMessage((Action<string>)typeCode, message2);
	}

	private unsafe void ConsumeFinished(string message)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		IFormatProvider formatProvider = (IFormatProvider)0;
		bool flag = ((int*)message)->System_002EIConvertible_002EToBoolean(formatProvider);
		if (_restorePurchaseFinishedDelegate != null)
		{
			bool flag2 = (nint)formatProvider == 2;
			IAsyncResult asyncResult = (((nint)formatProvider != 1) ? null : ((IAsyncResult)2));
			IAsyncResult result = ((!flag2) ? asyncResult : ((IAsyncResult)3));
			_restorePurchaseFinishedDelegate.EndInvoke(result);
		}
	}

	private void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_023c: Expected I, but got Obj
		//IL_0293: Expected I4, but got Obj
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b9: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0392: Expected Obj, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_02fa: Expected I, but got Obj
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		object obj = this + 36;
		obj = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = message;
		object obj4 = this + 8;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = message;
		object obj7 = this + 12;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex3 = new NullReferenceException();
		object obj9 = default;
		object obj8 = obj9 + 16;
		obj8 = message;
		object obj10 = this + 28;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex4 = new NullReferenceException();
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = message;
		object obj13 = this + 16;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex5 = new NullReferenceException();
		object obj15 = default;
		object obj14 = obj15 + 16;
		obj14 = message;
		object obj16 = this + 20;
		obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex6 = new NullReferenceException();
		object obj18 = default;
		object obj17 = obj18 + 16;
		obj17 = message;
		object obj19 = this + 24;
		obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex7 = new NullReferenceException();
		object obj21 = default;
		object obj20 = obj21 + 16;
		obj20 = message;
		object obj22 = this + 32;
		obj22 = obj21;
		object obj23 = this + 40;
		obj23 = internalPurchaseResult;
		object obj24 = this + 44;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj25 = default;
		obj24 = obj25;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v170 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_callbackGameObject != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"AndroidPurchaseBridge_callback";
		object obj27 = this + 48;
		obj27 = gameObject;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v166 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)_callbackGameObject).Exec();
		AndroidPurchaseProviderCallbackListener androidPurchaseProviderCallbackListener = _callbackGameObject.AddComponent<AndroidPurchaseProviderCallbackListener>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		List<TopRunCell> list = default;
		list._items = (TopRunCell[])num5;
		list._syncRoot = 0;
		object obj29 = list + 16;
		obj29 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		TopRunOnlineGameOverScreen topRunOnlineGameOverScreen = default;
		((UnityEngine.Object)topRunOnlineGameOverScreen).m_CachedPtr = cachedPtr;
		topRunOnlineGameOverScreen._rankHeaderPrefab = (GameObject)0;
		object obj30 = topRunOnlineGameOverScreen + 16;
		obj30 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr2 = 0;
		GameObject gameObject2 = default;
		((UnityEngine.Object)gameObject2).m_CachedPtr = cachedPtr2;
		_ = 0;
		object obj31 = gameObject2 + 16;
		obj31 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr3 = 0;
		GameObject gameObject3 = default;
		((UnityEngine.Object)gameObject3).m_CachedPtr = cachedPtr3;
		_ = 0;
		object obj32 = gameObject3 + 16;
		obj32 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr4 = 0;
		GameObject gameObject4 = default;
		((UnityEngine.Object)gameObject4).m_CachedPtr = cachedPtr4;
		_ = 0;
		object obj33 = gameObject4 + 16;
		obj33 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr5 = 0;
		GameObject gameObject5 = default;
		((UnityEngine.Object)gameObject5).m_CachedPtr = cachedPtr5;
		_ = 0;
		object obj34 = gameObject5 + 16;
		obj34 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr6 = 0;
		GameObject gameObject6 = default;
		((UnityEngine.Object)gameObject6).m_CachedPtr = cachedPtr6;
		_ = 0;
		object obj35 = gameObject6 + 16;
		obj35 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr7 = 0;
		GameObject gameObject7 = default;
		((UnityEngine.Object)gameObject7).m_CachedPtr = cachedPtr7;
		_ = 0;
		object obj36 = gameObject7 + 16;
		obj36 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr8 = 0;
		GameObject gameObject8 = default;
		((UnityEngine.Object)gameObject8).m_CachedPtr = cachedPtr8;
		_ = 0;
		object obj37 = gameObject8 + 16;
		obj37 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr9 = 0;
		GameObject gameObject9 = default;
		((UnityEngine.Object)gameObject9).m_CachedPtr = cachedPtr9;
		_ = 0;
		object obj38 = gameObject9 + 16;
		obj38 = this;
		((TopRunOnlineGameOverScreen.TopRunListAdapter)(object)androidPurchaseProviderCallbackListener)._002Ector(list, topRunOnlineGameOverScreen, gameObject2, gameObject3, gameObject4, gameObject5, gameObject6, gameObject7, gameObject8, gameObject9);
	}

	private bool HasTransactionBeenMadeInGame(string productId, string transactionId)
	{
		return false;
	}

	private void HandleRestore(string productId, string transactionId, string cookie, string receipt)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	private void InvokeItemRestore(string productId, string transactionId, string cookie)
	{
		//IL_0057: Expected I4, but got Obj
		//IL_00bf: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		object obj = default;
		if (obj == null)
		{
			if (transactionId != null && transactionId.m_stringLength != 0)
			{
				string text = string.ConcatArray((string[])(object)"SHOULD_CONSUME_", (int)transactionId);
				((TooltipAttribute)(object)text)._002Ector(productId);
			}
			if (cookie != null && cookie.m_stringLength != 0)
			{
				string text2 = string.ConcatArray((string[])(object)"SHOULD_CONSUME_TOKEN_", (int)cookie);
				((TooltipAttribute)(object)text2)._002Ector(productId);
			}
			RenderPipelineManager.CleanupRenderPipeline();
		}
	}

	private void InvokeCheckedItemRestore(string productId, string transactionId, string cookie, string receipt)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		object obj = default;
		if (obj == null)
		{
			InvokeItemRestore(productId, transactionId, receipt);
		}
		HandleRefund(productId, transactionId, cookie);
		HandleCancel(productId, transactionId, cookie, receipt);
	}

	private void HandleRefund(string productId, string transactionId, string cookie)
	{
		if (_itemRestoredDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
		}
	}

	private void HandleCancel(string productId, string transactionId, string cookie, string receipt)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0189: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 12;
		obj = productId;
		object obj3 = obj2 + 16;
		obj3 = transactionId;
		object obj4 = obj2 + 20;
		obj4 = cookie;
		object obj5 = obj2 + 8;
		obj5 = _checkedItemRestoredDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		if ((nint)0 == 0 || _purchaseValidationServer == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		int num2 = default;
		object obj6 = num2 + 16;
		obj6 = obj2;
		nint num3 = (nint)typeof(PurchaseValidationExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v12 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(PurchaseValidationExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v17 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IPurchaseValidationServer purchaseValidationServer = _purchaseValidationServer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		((DeflateManager)(object)purchaseValidationServer).send_all_trees(0, (int)receipt, num2);
	}

	private unsafe void HandleDefaultCases(InternalPurchaseResult internalPurchaseResult, string productId, string transactionId, string cookie, string receipt)
	{
		//IL_0996: Expected VT, but got Ref
		//IL_09a4: Expected Obj, but got Ref
		//IL_09b2: Expected Obj, but got Ref
		//IL_09c0: Expected Obj, but got Ref
		//IL_09ce: Expected Obj, but got Ref
		//IL_09dc: Expected Obj, but got Ref
		//IL_09ea: Expected Obj, but got Ref
		//IL_09f8: Expected Obj, but got Ref
		//IL_0a06: Expected Obj, but got Ref
		//IL_0a14: Expected Obj, but got Ref
		//IL_0a22: Expected Obj, but got Ref
		//IL_0a30: Expected Obj, but got Ref
		//IL_0a3e: Expected Obj, but got Ref
		//IL_0a4c: Expected Obj, but got Ref
		//IL_0a5a: Expected Obj, but got Ref
		//IL_0a68: Expected Obj, but got Ref
		//IL_0a76: Expected Obj, but got Ref
		//IL_0a7f: Expected Obj, but got I4
		//IL_0ab7: Expected Obj, but got Ref
		//IL_0ac0: Expected Obj, but got I4
		//IL_0ad4: Expected Obj, but got Ref
		//IL_0add: Expected Obj, but got I4
		//IL_0af1: Expected Obj, but got Ref
		//IL_0afa: Expected Obj, but got I4
		//IL_0b0e: Expected Obj, but got Ref
		//IL_0b17: Expected Obj, but got I4
		//IL_0b2b: Expected Obj, but got Ref
		//IL_0b34: Expected Obj, but got I4
		//IL_0b48: Expected Obj, but got Ref
		//IL_0b51: Expected Obj, but got I4
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_0b86: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_115d: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected I4, but got Unknown
		//IL_0bd9: Expected Ref, but got VT
		//IL_0be6: Expected Obj, but got F4
		//IL_0c4c: Expected I, but got Obj
		//IL_0c62: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_0cab: Expected I, but got Obj
		//IL_0cc1: Expected Obj, but got I
		//IL_0282: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_0386: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got VT
		//IL_031c: Expected I, but got Obj
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I4
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_044a: Expected Obj, but got I
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_102d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1032: Expected Obj, but got Unknown
		//IL_04e6: Expected Obj, but got I
		//IL_051f: Expected Obj, but got I
		//IL_0550: Expected I, but got Obj
		//IL_0566: Expected Obj, but got I
		//IL_05ee: Invalid comparison between F4 and I
		//IL_0591: Expected I, but got Obj
		//IL_0d7b: Expected Obj, but got I
		//IL_0dde: Expected Obj, but got I4
		//IL_0e06: Expected Obj, but got I
		//IL_0e39: Expected Obj, but got I
		//IL_0e4f: Expected Obj, but got I
		//IL_0e7d: Expected Obj, but got I4
		//IL_0eac: Expected I, but got Obj
		//IL_0ec2: Expected Obj, but got I
		//IL_0eec: Expected F4, but got Obj
		//IL_0ee7: Expected native int or pointer, but got VT
		//IL_0f01: Expected F4, but got I
		//IL_0efc: Expected native int or pointer, but got VT
		//IL_0f23: Expected VT, but got Ref
		//IL_0f3d: Expected F4, but got Obj
		//IL_0f38: Expected native int or pointer, but got VT
		//IL_0f52: Expected F4, but got I
		//IL_0f4d: Expected native int or pointer, but got VT
		//IL_0f78: Expected VT, but got Ref
		//IL_061d: Expected F4, but got I
		//IL_06a7: Expected I, but got Obj
		//IL_06bd: Expected Obj, but got I
		//IL_0630: Expected I, but got Obj
		//IL_0f97: Expected F4, but got Obj
		//IL_0f92: Expected native int or pointer, but got VT
		//IL_0fac: Expected F4, but got I
		//IL_0fa7: Expected native int or pointer, but got VT
		//IL_0fd2: Expected VT, but got Ref
		//IL_1001: Expected Obj, but got I
		//IL_071a: Expected F4, but got Obj
		//IL_0715: Expected native int or pointer, but got VT
		//IL_072f: Expected F4, but got I
		//IL_072a: Expected native int or pointer, but got VT
		//IL_0755: Expected VT, but got Ref
		//IL_077e: Expected Obj, but got I
		//IL_07de: Expected F4, but got Obj
		//IL_07d9: Expected native int or pointer, but got VT
		//IL_07f3: Expected F4, but got I
		//IL_07ee: Expected native int or pointer, but got VT
		//IL_06e8: Expected I, but got Obj
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fe: Expected Obj, but got Unknown
		//IL_086f: Expected I, but got Obj
		//IL_0885: Expected Obj, but got I
		//IL_104c: Expected F4, but got Obj
		//IL_1047: Expected native int or pointer, but got VT
		//IL_105e: Expected F4, but got I
		//IL_1059: Expected native int or pointer, but got VT
		//IL_1080: Expected VT, but got Ref
		//IL_10b0: Expected F4, but got Obj
		//IL_10ab: Expected native int or pointer, but got VT
		//IL_10c5: Expected F4, but got I
		//IL_10c0: Expected native int or pointer, but got VT
		//IL_10e7: Expected VT, but got Ref
		//IL_08e2: Expected Ref, but got VT
		//IL_0900: Expected VT, but got Ref
		//IL_0900: Expected I4, but got Obj
		//IL_08b0: Expected I, but got Obj
		//IL_091c: Expected Obj, but got F4
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected Obj, but got Unknown
		ref Quaternion reference2 = default;
		ref Quaternion reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 448);
		Vector3 vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 384));
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 368));
		UI2DSprite uI2DSprite = (UI2DSprite)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 200));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 32));
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 184));
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 16));
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 168));
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 152));
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 140));
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 128));
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 112));
		object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 96));
		object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 80));
		object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 68));
		object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 56));
		object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 44));
		object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 304));
		obj15 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 288));
		obj16 = 0;
		_ = 0;
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 272));
		obj17 = 0;
		_ = 0;
		object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 260));
		obj18 = 0;
		_ = 0;
		object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 248));
		obj19 = 0;
		_ = 0;
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 232));
		obj20 = 0;
		_ = 0;
		object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 216));
		obj21 = 0;
		_ = 0;
		if (transactionId == null || transactionId.m_firstChar == '\0')
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v322 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+60]");
		if ((UnityEngine.Object)0 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v81+144]");
		object obj24;
		if ((nint)0 == 1)
		{
			obj24 = 2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v81+144]");
			if ((nint)0 == 2)
			{
				obj24 = 5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v81+144]");
				obj24 = (((nint)0 != 3) ? ((object)1) : ((object)9));
			}
		}
		int num3;
		if (obj24 != null)
		{
			bool flag = transactionId.m_firstChar == int.MinValue;
			bool flag2 = (nint)obj24 == -1;
			object obj25 = flag & flag2;
			num3 = ((obj25 == null) ? (transactionId.m_firstChar / obj24) : 0);
		}
		else
		{
			num3 = 0;
		}
		int num4 = num3 / 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+60]");
		string sortingLayerName = ((UIPanel)0).sortingLayerName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+64]");
		if ((nint)0 != (int)transactionId.m_firstChar)
		{
			_ = transactionId.m_firstChar;
			((TweenLetters)this).GetLetterDuration(num4);
			Vector3 position = ((TweenPosition)num4).position;
		}
		nint num5 = (nint)typeof(Matrix4x4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v95 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num6 = (nint)typeof(Matrix4x4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v322 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)vector)->Normalize();
		obj15 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+38]");
		_ = 0;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v109 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v318 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		nint num9 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v117 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num10 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v314 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		obj17 = uI2DSprite;
		_ = ((UnityEngine.Object)uI2DSprite).m_CachedPtr;
		Vector3 forward = Vector3.forward;
		obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		_ = 0;
		Vector3 one2 = Vector3.one;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+70]");
		string text = (string)((nint)0 + (nint)48);
		obj4 = text;
		_ = text.m_stringLength;
		reference = ref *(Quaternion*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference2, out reference);
		obj20 = reference2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 one3 = Vector3.one;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
		obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+50]");
		object obj29 = 0 * _restorePurchaseFinishedDelegate;
		string text2 = text;
		object obj30 = default;
		object obj63 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
		{
			object obj31 = 0;
			while ((nint)obj31 < num4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+68]");
				object obj32 = (nint)0 + (nint)16;
				object obj33 = obj31 << 2;
				object obj34 = obj32 + obj33;
				object obj35 = obj34 << 2;
				object obj36 = num4 * obj30;
				object obj37 = obj36 << 2;
				string text3 = obj35 + obj37;
				bool flag3 = (nint)text3 < (int)transactionId.m_firstChar;
				bool flag4 = !flag3;
				text2 = (string)obj34;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+6C]");
					object obj38 = (nint)0 + (nint)16;
					object obj39 = obj34 << 2;
					object obj40 = obj38 + obj39;
					object obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+6C]");
					object obj42 = (nint)0 + (nint)16;
					object obj43 = obj34 << 2;
					object obj44 = obj42 + obj43;
					object obj45 = obj44;
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v177 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj46 = (nint)0 & (nint)0x200;
					if (obj46 != null)
					{
						nint num12 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S0_v310 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num13 = (float)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v168+8]");
					float num14 = num13 - 0f;
					if (num14 < 0f)
					{
						num14 = 0f;
					}
					else
					{
						float num15 = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v174+C]");
						if (num15 > 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v174+C]");
							num14 = 0f;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+6C]");
					object obj47 = (nint)0 + (nint)16;
					object obj48 = obj34 << 2;
					object obj49 = obj47 + obj48;
					object obj50 = obj49;
					float num16 = num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S2_v23+C]");
					float defaultValue = num16 / 0f;
					float num17 = PlayerPrefs.GetFloat((string)(object)_checkedItemRestoredDelegate, defaultValue);
					uI2DSprite.OnFill((List<Vector3>)(object)transactionId, (List<Vector2>)(object)text3, (List<Color>)4);
					obj19 = uI2DSprite;
					_ = ((UnityEngine.Object)uI2DSprite).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+6C]");
					object obj51 = (nint)0 + (nint)16;
					object obj52 = obj34 << 2;
					object obj53 = obj51 + obj52;
					object obj54 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S1_v160+10]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+70]");
					object obj55 = (nint)0 + (nint)36;
					obj3 = obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S1_v164+8]");
					_ = 0;
					obj4 = obj2;
					reference2 = ref *(Quaternion*)obj2;
					obj5 = 0;
					_ = 0;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+4]");
					_ = 0;
					_ = 0f;
					nint num18 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v204 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						nint num19 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S0_v306 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)obj3;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					reference = ref *(Quaternion*)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
					_ = 0;
					Vector3 vector3 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					Vector3 one4 = Vector3.one;
					((Vector3*)(nint)vector)->x = (float)obj6;
					Vector3 vector4 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
					((Vector3*)(nint)vector4)->z = 0f;
					reference = ref *(Quaternion*)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
					_ = 0;
					Quaternion quaternion = Quaternion.Slerp((Quaternion)vector, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), num17);
					obj16 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
					_ = 0;
					obj9 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v64+8]");
					_ = 0;
					nint num20 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S0_v224 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
					object obj57 = (nint)0 & (nint)0x200;
					if (obj57 != null)
					{
						nint num21 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ S0_v303 (Il2CppClass<UnityEngine.Quaternion>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector2 zero2 = Vector2.zero;
					((Vector3*)(nint)vector)->x = (float)obj9;
					Vector3 vector5 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
					((Vector3*)(nint)vector5)->z = 0f;
					reference = ref *(Quaternion*)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
					_ = 0;
					Quaternion quaternion2 = Quaternion.Lerp((Quaternion)vector, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), num17);
					obj17 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+70]");
					object obj58 = (nint)0 + (nint)60;
					obj12 = obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S1_v220+8]");
					_ = 0;
					Vector3 forward2 = Vector3.forward;
					((Vector3*)(nint)vector)->x = (float)obj12;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					reference = ref *(Quaternion*)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
					_ = 0;
					Quaternion quaternion3 = Quaternion.Slerp((Quaternion)vector, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), num17);
					obj18 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.AndroidPurchaseProvider)+70]");
					object obj59 = 0;
					float num22 = 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S0_v247+48]");
					float num23 = num22 - 0f;
					float num24 = num23 * num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S0_v247+48]");
					float num25 = 0f + num24;
					obj = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj17;
					Vector3 vector7 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					reference = ref *(Quaternion*)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6C7");
					text2 = text3;
					while (true)
					{
						object obj60 = text3 + 4;
						if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60))
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
						uI2DSprite = (UI2DSprite)obj;
						UI2DSprite uI2DSprite2 = uI2DSprite;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((UnityEngine.Object)uI2DSprite2).m_CachedPtr = (IntPtr)0;
						obj2 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v61+8]");
						_ = 0;
						nint num26 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ S0_v267 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj61 = (nint)0 & (nint)0x200;
						if (obj61 != null)
						{
							nint num27 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S0_v300 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = (float)uI2DSprite;
						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uI2DSprite).m_CachedPtr;
						reference = ref *(Quaternion*)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						_ = 0;
						Quaternion quaternion4 = Quaternion.FromToRotation(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
						reference = ref *(Quaternion*)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
						((Vector3*)(nint)vector)->x = (float)obj4;
						Vector3 vector8 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
						((Vector3*)(nint)vector8)->z = 0f;
						reference = ref *(Quaternion*)obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v61+8]");
						_ = 0;
						one3 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						reference = ref *(Quaternion*)reference2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
						_ = 0;
						((List<Vector3>)(object)transactionId).set_Item((int)text2, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8875");
						obj21 = vector.x;
						_ = vector.z;
						reference = ref *(Quaternion*)obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v67+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8876");
						string text4 = text2 + 1;
						text2 = text4;
					}
				}
				object obj62 = obj31 + 1;
				obj31 = obj62;
			}
			obj30 = obj63 + 1;
		}
	}

	private void HandlePurchase(string productId, string transactionId, string cookie, string receipt, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_010d: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		if (productId != null)
		{
			if (_purchaseDelegate != null)
			{
				if (productId == null || ((nint)productId != 1 && ((nint)productId == 2 || (nint)productId == 3 || (nint)productId == 4)))
				{
					string text = productId;
				}
				else
				{
					string text = (string)1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8940");
			}
		}
		else
		{
			((KindlePurchaseProvider)this).HandleDefaultCase(transactionId, cookie, receipt, (string)internalPurchaseResult, InternalPurchaseResult.Completed);
		}
	}

	private InternalPurchaseResult GetProperPurchaseResult(string errorCode)
	{
		return InternalPurchaseResult.Completed;
	}

	private unsafe bool TryParseProductInfo(string message, out ProductRequestResultInfo[] productInfo)
	{
		string key = string.ConcatArray((string[])(object)"SHOULD_CONSUME_", (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref productInfo));
		bool flag = PlayerPrefs.HasKey(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		object obj = default;
		if ((nint)obj == 1)
		{
			return true;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (System.Boolean)+8]");
			return (nint)0 == 0;
		}
		return true;
	}

	private bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId, out string purchaseSignature, out string cookie, out string receipt)
	{
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		bool result = default;
		return result;
	}

	private static void LogError(string msg)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
		}
	}

	private static void Log(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[AndroidPurchaseProvider] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	static AndroidPurchaseProvider()
	{
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)UITooltip.mInstance).FindKernel((string)null) != 0)
		{
			object obj2 = UITooltip.mInstance + 36;
			obj2 = 0;
			UITooltip mInstance = UITooltip.mInstance;
			mInstance.mTarget = 0f;
		}
	}
}
