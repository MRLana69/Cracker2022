namespace Kiloo.Common.Backend.PurchaseValidation;

public class SimulatedPurchaseValidationServer : IPurchaseValidationServer
{
	private sealed class <>c__DisplayClass0_0
	{
		public PurchaseValidationRequest purchaseValidationRequest; //Field offset: 0x8
		public Action<PurchaseValidationRequest> completeHandler; //Field offset: 0xC

		public <>c__DisplayClass0_0() { }

		internal void <ValidatePurchase>b__0() { }

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
			internal set { } //Length: 8
		}

		public Result() { }

		public Error get_error() { }

		public string get_purchaseToken() { }

		public ReceiptStatus get_receiptStatus() { }

		internal void set_error(Error value) { }

		internal void set_purchaseToken(string value) { }

		internal void set_receiptStatus(ReceiptStatus value) { }

	}


	public SimulatedPurchaseValidationServer() { }

	public Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler) { }

}

