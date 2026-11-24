namespace InAppPurchase.Internal;

internal static class PurchaseValidationExtensions
{
	private sealed class <>c__DisplayClass2_0
	{
		public Action<IPurchaseValidationResult> completeHandler; //Field offset: 0x8

		public <>c__DisplayClass2_0() { }

	}

	private sealed class <>c__DisplayClass2_1
	{
		public PurchaseValidationRequest purchaseValidationRequest; //Field offset: 0x8
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass2_1() { }

		internal void <ValidateTransaction>b__0(PurchaseValidationRequest request) { }

	}

	private class Result : IPurchaseValidationResult
	{
		private ReceiptStatus <receiptStatus>k__BackingField; //Field offset: 0x8
		private string <purchaseToken>k__BackingField; //Field offset: 0xC
		private Error <error>k__BackingField; //Field offset: 0x10

		public Error error
		{
			 get { } //Length: 6
			internal set { } //Length: 11
		}

		public string purchaseToken
		{
			 get { } //Length: 6
			internal set { } //Length: 8
		}

		public ReceiptStatus receiptStatus
		{
			 get { } //Length: 6
			internal set { } //Length: 26
		}

		public Result() { }

		public Error get_error() { }

		public string get_purchaseToken() { }

		public ReceiptStatus get_receiptStatus() { }

		internal void set_error(Error value) { }

		internal void set_purchaseToken(string value) { }

		internal void set_receiptStatus(ReceiptStatus value) { }

	}

	private static bool _hasDetectedAnyInvalidPurchases; //Field offset: 0x0

	private static PurchaseValidationExtensions() { }

	public static bool HasDetectedAnyInvalidPurchases(IPurchaseValidationServer purchaseValidationServer) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public static void ValidateTransaction(IPurchaseValidationServer purchaseValidationServer, string productId, string transactionReceiptBase64, Action<IPurchaseValidationResult> completeHandler) { }

}

