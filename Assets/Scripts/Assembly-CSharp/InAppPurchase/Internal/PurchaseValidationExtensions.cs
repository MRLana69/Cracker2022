using System;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Backend;
using Kiloo.Common.Backend.PurchaseValidation;

namespace InAppPurchase.Internal;

internal static class PurchaseValidationExtensions
{
	private class Result : IPurchaseValidationResult
	{
		public ReceiptStatus receiptStatus
		{
			get
			{
				return field;
			}
			internal set
			{
				field = value;
			}
		}

		public string purchaseToken
		{
			get
			{
				return field;
			}
			internal set
			{
				field = value;
			}
		}

		public Error error
		{
			get
			{
				return field;
			}
			internal set
			{
				field = value;
			}
		}
	}

	private static bool _previousInvalidPurchase;

	public static bool WasPreviousPurchaseValid => (byte)(~(_previousInvalidPurchase ? 1u : 0u)) != 0;

	public static void ValidateTransaction(IPurchaseValidationServer purchaseValidationServer, string productId, string transactionReceiptBase64, Action<IPurchaseValidationResult> completeHandler)
	{
		//IL_00db: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		if (purchaseValidationServer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			_ = 0;
			if (~(_previousInvalidPurchase ? 1u : 0u) != 0)
			{
				InAppManager instance = InAppManager.instance;
				_ = instance._itemRequested;
				throw new ArgumentException();
			}
			_ = 2;
			Encoding uTF = Encoding.UTF8;
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v4 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
			byte[] inArray = default;
			string text = Convert.ToBase64String(inArray);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S0_v34+C] (should have been resolved before IL gen)");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S0_v11+C] (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg)
	{
		string text = "[PurchaseValidationExtensions] " + msg;
	}

	private static void Log(string msg)
	{
	}
}
