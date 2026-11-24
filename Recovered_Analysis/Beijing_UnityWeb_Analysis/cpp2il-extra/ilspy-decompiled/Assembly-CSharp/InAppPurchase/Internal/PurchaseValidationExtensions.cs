using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend;
using Kiloo.Common.Backend.PurchaseValidation;

namespace InAppPurchase.Internal;

internal static class PurchaseValidationExtensions
{
	private class Result : IPurchaseValidationResult
	{
		private ReceiptStatus receiptStatus__BackingField;

		private string purchaseToken__BackingField;

		public ReceiptStatus receiptStatus
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (ReceiptStatus)purchaseToken__BackingField;
			}
			internal set
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8960");
			}
		}

		public string purchaseToken
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (string)receiptStatus__BackingField;
			}
			internal set
			{
				//IL_000a: Expected I4, but got Obj
				receiptStatus__BackingField = (ReceiptStatus)value;
			}
		}

		public Error error
		{
			get
			{
				return (Error)(object)purchaseToken__BackingField;
			}
			internal set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 12;
				obj = value;
			}
		}
	}

	private static bool _hasDetectedAnyInvalidPurchases;

	public static bool HasDetectedAnyInvalidPurchases(IPurchaseValidationServer purchaseValidationServer)
	{
		return false;
	}

	public static void ValidateTransaction(IPurchaseValidationServer purchaseValidationServer, string productId, string transactionReceiptBase64, Action<IPurchaseValidationResult> completeHandler)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [purchaseValidationServer @ L0 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationServer)+14]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8960");
		}
	}

	private static void LogError(string msg)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private static void Log(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[PurchaseValidationExtensions] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	static PurchaseValidationExtensions()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		char[] array = default;
		object obj = array + 16;
		obj = 59;
		KindlePurchaseProvider.SEPARATOR_FOR_STRING_SPLIT = array;
	}
}
