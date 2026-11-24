namespace Kiloo.Common.Backend.PurchaseValidation;

public sealed class PurchaseValidationServer : IPurchaseValidationServer
{
	private sealed class <ValidatePurchaseCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PurchaseValidationRequest purchaseValidationRequest; //Field offset: 0x10
		public PurchaseValidationServer <>4__this; //Field offset: 0x14
		public Action<PurchaseValidationRequest> completeHandler; //Field offset: 0x18
		private IRequest <request>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 764
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ValidatePurchaseCoroutine>d__16(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class ApiPurchaseValidationRequest
	{
		private string <productId>k__BackingField; //Field offset: 0x8
		private string <receipt>k__BackingField; //Field offset: 0xC

		public string productId
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string receipt
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public ApiPurchaseValidationRequest() { }

		public string get_productId() { }

		public string get_receipt() { }

		public void set_productId(string value) { }

		public void set_receipt(string value) { }

	}

	private class ApiPurchaseValidationResponse : IPurchaseValidationResult
	{
		private ReceiptStatus <receiptStatus>k__BackingField; //Field offset: 0x8
		private string <purchaseToken>k__BackingField; //Field offset: 0xC
		private Error <error>k__BackingField; //Field offset: 0x10

		public Error error
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string purchaseToken
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public ReceiptStatus receiptStatus
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public ApiPurchaseValidationResponse() { }

		public Error get_error() { }

		public string get_purchaseToken() { }

		public ReceiptStatus get_receiptStatus() { }

		public void set_error(Error value) { }

		public void set_purchaseToken(string value) { }

		public void set_receiptStatus(ReceiptStatus value) { }

	}

	private const string API_POST_VALIDATE_PURCHASE = "api/v1/purchasevalidation"; //Field offset: 0x0
	private Uri <baseUri>k__BackingField; //Field offset: 0x8
	private bool <debug>k__BackingField; //Field offset: 0xC
	private float <timeout>k__BackingField; //Field offset: 0x10
	private readonly IJsonSerializer _jsonSerializer; //Field offset: 0x14

	public Uri baseUri
	{
		 get { } //Length: 105
		 set { } //Length: 253
	}

	public bool debug
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public float timeout
	{
		 get { } //Length: 6
		 set { } //Length: 130
	}

	public PurchaseValidationServer(Uri baseUri, IJsonSerializer jsonSerializer, bool debug = false, float timeout = 0) { }

	public Uri get_baseUri() { }

	public bool get_debug() { }

	public float get_timeout() { }

	public void set_baseUri(Uri value) { }

	public void set_debug(bool value) { }

	public void set_timeout(float value) { }

	public Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler) { }

	private IEnumerator ValidatePurchaseCoroutine(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler) { }

}

