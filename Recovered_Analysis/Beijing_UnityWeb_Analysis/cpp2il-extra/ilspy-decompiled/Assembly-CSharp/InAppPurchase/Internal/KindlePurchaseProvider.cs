using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Ionic.Zlib;
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

	private GameObject _callbackGameObject;

	public unsafe bool IsValidationServerSpecified
	{
		get
		{
			//IL_0299: Expected I4, but got Obj
			//IL_02a7: Expected I, but got Obj
			//IL_02bd: Expected Obj, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected Obj, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected Obj, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected Obj, but got Unknown
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected Obj, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected Obj, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected Obj, but got Unknown
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected Obj, but got Unknown
			//IL_0281: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"KindleInAppCallback";
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
			KindlePurchaseProviderCallbackListener kindlePurchaseProviderCallbackListener = gameObject.AddComponent<KindlePurchaseProviderCallbackListener>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(KindlePurchaseProvider.ProductRequestSuccessful);
			object obj2 = action + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(KindlePurchaseProvider.ProductRequestFailed);
			object obj3 = action2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<string> action3 = default;
			object obj4 = action3 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Action action4 = default;
			((Delegate)action4).method_ptr = method_ptr3;
			((Delegate)action4).method = (nint)__ldftn(KindlePurchaseProvider.ProductRestoreFailed);
			object obj5 = action4 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			Action<string> action5 = default;
			object obj6 = action5 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Action<string> action6 = default;
			object obj7 = action6 + 16;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num6 = 0;
			_ = 0;
			Action<string> action7 = default;
			object obj8 = action7 + 16;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			Action<string> action8 = default;
			object obj9 = action8 + 16;
			obj9 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			_ = 0;
			Action<string> action9 = default;
			object obj10 = action9 + 16;
			obj10 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			Action<string> action10 = default;
			object obj11 = action10 + 16;
			obj11 = this;
			((AndroidPurchaseProviderCallbackListener)(object)kindlePurchaseProviderCallbackListener).Setup(action, action2, action3, action4, action5, action6, action7, action8, action9, action10);
			return (byte)(int)gameObject != 0;
		}
	}

	public GameObject CreateCallbackGameObject()
	{
		return null;
	}

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		((Action<string>)(object)inAppManager)?.Invoke((string)(object)purchaseValidationServer);
	}

	public bool CanMakePurchases()
	{
		return false;
	}

	public void RequestProductInfo(string[] productIds)
	{
		if (productIds != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public unsafe bool RestoreNonConsumablePurchases(string[] productIds)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_00eb: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_00de: Expected I, but got Obj
		IFormatProvider formatProvider = (IFormatProvider)0;
		if (!((int*)productIds)->System_002EIConvertible_002EToBoolean(formatProvider))
		{
			goto IL_00fd;
		}
		nint num;
		if (formatProvider != null)
		{
			if ((nint)formatProvider == 1)
			{
				goto IL_00fd;
			}
			if ((nint)formatProvider != 2)
			{
				if ((nint)formatProvider != 3)
				{
					if ((nint)formatProvider != 4)
					{
						goto IL_00fd;
					}
					num = (nint)formatProvider;
				}
				else
				{
					num = (nint)formatProvider;
				}
			}
			else
			{
				num = (nint)formatProvider;
			}
		}
		else
		{
			num = (nint)formatProvider;
		}
		goto IL_010b;
		IL_00fd:
		num = 1;
		goto IL_010b;
		IL_010b:
		return (byte)num != 0;
	}

	public bool StartPurchase(string productId)
	{
		return false;
	}

	public unsafe bool StartPurchase(string productId, string cookie)
	{
		//IL_026a: Expected Obj, but got I4
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_02e5: Expected I4, but got Obj
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		IFormatProvider formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(IOSPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InAppPurchase.Internal.IOSPurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(IOSPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v67 (Il2CppClass<InAppPurchase.Internal.IOSPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = productId.Substring((int)IOSPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		object obj2 = text + 12;
		string text2;
		if ((nint)obj2 >= 1)
		{
			object obj3 = text + 16;
			if (((int*)obj3)->System_002EIConvertible_002EToBoolean(formatProvider))
			{
				object obj4 = (object)formatProvider << 2;
				object obj5 = obj4 + 1;
				if (obj2 == obj5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj6 = 0;
					object obj22 = default;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<IFormatProvider, UIntPtr>(ref formatProvider))
					{
						object obj7 = text + 16;
						object obj8 = obj6 << 2;
						object obj9 = obj8 + 1;
						object obj10 = obj9 << 2;
						object obj11 = obj7 + obj10;
						object obj12 = obj9 << 2;
						object obj13 = text + obj12;
						object obj14 = obj13 + 20;
						object obj15 = obj9 << 2;
						object obj16 = text + obj15;
						object obj17 = obj16 + 24;
						object obj18 = obj9 << 2;
						object obj19 = text + obj18;
						object obj20 = obj19 + 28;
						object obj21 = obj22 + 16;
						object obj23 = obj6 << 4;
						object obj24 = obj21 + obj23;
						obj24 = obj11;
						object obj25 = obj24 + 4;
						obj25 = obj14;
						object obj26 = obj24 + 8;
						obj26 = obj17;
						object obj27 = obj24 + 12;
						obj27 = obj20;
						object obj28 = obj6 + 1;
						obj6 = obj28;
					}
					text2 = (string)obj22;
					return true;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj29 = default;
		text2 = (string)obj29;
		return false;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00ca: Expected I4, but got Obj
		//IL_00ca: Expected I4, but got Obj
		//IL_00ca: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		if ((object)_callbackGameObject == null)
		{
			return;
		}
		nint num = (nint)typeof(PurchaseValidationExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PurchaseValidationExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v9 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DeflateManager)(object)_callbackGameObject).send_all_trees((int)productId, (int)transactionId, (int)purchaseToken);
	}

	public void ProductRequestSuccessful(string message)
	{
	}

	public unsafe void ProductRequestFailed(string message)
	{
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected I4, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_0250: Expected I4, but got Obj
		//IL_015a: Expected I4, but got Obj
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_001d: Expected I4, but got Obj
		//IL_01ad: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_00e4: Expected I4, but got Obj
		//IL_00e4: Expected I4, but got Obj
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		int num = obj2 - -64;
		((int*)num)->m_value = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		if (((DeflateManager)null)._tr_tally((int)message, num))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			stringBuilder.Length = (int)"KindlePurchaseProvider ProductInfo:\n";
			object obj5 = ((int*)num)->m_value + 12;
			object obj6 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj7 = ((int*)num)->m_value + 16;
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
		string msg = string.ConcatArray((string[])(object)"KindlePurchaseProvider ERROR: Malformed message from native code: ", (int)message);
		nint num2 = (nint)typeof(KindlePurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v14 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num3 = (nint)typeof(KindlePurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v19 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg);
	}

	public void ProductRestoredSuccessfully(string message)
	{
		if (_productRequestDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
		}
	}

	public void ProductRestoreFinished()
	{
		CancelInvoke();
	}

	public void ProductRestoreFailed()
	{
		//IL_002f: Expected Obj, but got I4
		if (_restorePurchaseFinishedDelegate != null)
		{
			_restorePurchaseFinishedDelegate.EndInvoke((IAsyncResult)3);
		}
	}

	public void ProductRestoreFinishedButNothingHasBeenRestored()
	{
		if (_restorePurchaseFinishedDelegate != null)
		{
			_restorePurchaseFinishedDelegate.EndInvoke(null);
		}
	}

	public void ProductPurchasedSuccessfully(string message)
	{
		//IL_000f: Expected Obj, but got I4
		HandleRestore(message, (string)5);
	}

	public void ProductPurchaseInvalidId(string message)
	{
		HandleRestore(message, null);
	}

	public void ProductPurchaseFailed(string message)
	{
		//IL_000f: Expected Obj, but got I4
		HandleRestore(message, (string)4);
	}

	public void ProductRefunded(string message)
	{
		//IL_000f: Expected Obj, but got I4
		HandleRestore(message, (string)2);
	}

	private void ValidateTransaction(string productId, string transactionId, string transactionRecieptBase64, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = productId;
		object obj4 = obj2 + 16;
		obj4 = transactionId;
		object obj5 = obj2 + 20;
		obj5 = transactionRecieptBase64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj6 = text + 16;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+14]");
		FinishPurchase((string)num2, (string)0, text);
	}

	private void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
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
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		object obj2 = default;
		object obj = obj2 + 16;
		obj = message;
		object obj3 = this + 12;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = message;
		object obj6 = this + 24;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex3 = new NullReferenceException();
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = message;
		object obj9 = this + 16;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex4 = new NullReferenceException();
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = message;
		object obj12 = this + 20;
		obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex5 = new NullReferenceException();
		object obj14 = default;
		object obj13 = obj14 + 16;
		obj13 = message;
		object obj15 = this + 28;
		obj15 = obj14;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_callbackGameObject != null)
		{
			object obj17 = this + 32;
			bool isValidationServerSpecified = IsValidationServerSpecified;
			obj17 = isValidationServerSpecified;
		}
	}

	private unsafe void HandleRestore(string productId, string transactionId)
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected I4, but got Unknown
		//IL_0169: Expected Obj, but got I4
		//IL_017b: Expected I4, but got Obj
		//IL_00b2: Expected I4, but got Obj
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_009f: Expected I4, but got Obj
		//IL_009f: Expected I4, but got Obj
		//IL_009f: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got I4
		sbyte[] array = default;
		int num = array + 4;
		((int*)num)->m_value = 0;
		array = (sbyte[])0;
		if (DeflateManager._IsSmaller(null, (int)productId, num, array))
		{
			object obj = transactionId - 5;
			if ((nint)transactionId != 5)
			{
				if ((nint)obj == 1)
				{
					PurchaseValidationExtensions.ValidateTransaction((IPurchaseValidationServer)this, (string)((int*)num)->m_value, (string)(object)array, (Action<IPurchaseValidationResult>)(object)string.Empty);
				}
				else
				{
					((StaticTree)(object)this)._002Ector((short[])((int*)num)->m_value, (int[])(object)array, (int)string.Empty, (int)string.Empty, (int)transactionId);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @895D");
			}
			return;
		}
		string msg = string.ConcatArray((string[])(object)"KindlePurchaseProvider ERROR: Malformed message from native code: ", (int)productId);
		nint num2 = (nint)typeof(KindlePurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v10 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(KindlePurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v15 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg);
	}

	private void HandleRefund(string productId, string transactionId, string cookie)
	{
	}

	private void HandleDefaultCase(string productId, string transactionId, string transactionRecieptBase64, string cookie, InternalPurchaseResult internalPurchaseResult)
	{
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = productId;
		object obj4 = obj2 + 16;
		obj4 = transactionId;
		object obj5 = obj2 + 20;
		obj5 = cookie;
		object obj6 = obj2 + 24;
		obj6 = transactionRecieptBase64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
		string key = string.ConcatArray((string[])(object)"SHOULD_CONSUME_", 0);
		bool flag = PlayerPrefs.HasKey(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		object obj7 = default;
		if ((nint)obj7 != 1)
		{
			bool flag2;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+14]");
				((AndroidPurchaseProvider)(object)this).InvokeItemRestore((string)num, (string)num2, (string)0);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.KindlePurchaseProvider)+28]");
		object obj8;
		if ((nint)0 == 0)
		{
			if (_purchaseDelegate == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1C]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1C]");
				if ((nint)0 == 1)
				{
					goto IL_01c0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1C]");
				if ((nint)0 != 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1C]");
					if ((nint)0 != 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1C]");
						if ((nint)0 != 4)
						{
							goto IL_01c0;
						}
					}
				}
			}
			goto IL_033f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		int num4 = default;
		object obj9 = num4 + 16;
		obj9 = obj2;
		nint num5 = (nint)typeof(PurchaseValidationExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v14 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(PurchaseValidationExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S3_v19 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.KindlePurchaseProvider)+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+14]");
		((DeflateManager)num7).send_all_trees((int)num8, 0, num4);
		return;
		IL_01c0:
		obj8 = 1;
		goto IL_033f;
		IL_033f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8940");
	}

	private bool TryParseProductInfo(string message, out ProductRequestResultInfo[] productInfo)
	{
		return false;
	}

	private bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = message;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		bool result = default;
		return result;
	}

	private static void LogError(string msg)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
		}
	}

	private static void LogWarning(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[KindlePurchaseProvider] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	private static void Log(string msg)
	{
	}

	static KindlePurchaseProvider()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		char[] array = default;
		object obj = array + 16;
		obj = 59;
		IOSPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT = array;
	}
}
