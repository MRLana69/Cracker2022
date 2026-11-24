namespace InAppPurchase.Internal;

public class EditorPurchaseProvider : IPurchaseProvider
{
	private sealed class <>c__DisplayClass25_0
	{
		public IPurchaseValidationResult validationResult; //Field offset: 0x8

		public <>c__DisplayClass25_0() { }

		internal void <PurchaseCoroutine>b__0(IPurchaseValidationResult purchaseValidationResult) { }

	}

	private sealed class <ProductRequestCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string[] productIds; //Field offset: 0x10
		public EditorPurchaseProvider <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 421
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ProductRequestCoroutine>d__24(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PurchaseCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private <>c__DisplayClass25_0 <>8__1; //Field offset: 0x10
		public EditorPurchaseProvider <>4__this; //Field offset: 0x14
		public string productId; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 623
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PurchaseCoroutine>d__25(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RestoreCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string[] productIds; //Field offset: 0x10
		public EditorPurchaseProvider <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 340
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RestoreCoroutine>d__26(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float INITIALIZE_FAIL_CHANCE = 0; //Field offset: 0x0
	private const float PRODUCTREQUEST_FAIL_CHANCE = 0; //Field offset: 0x0
	private const float PRODUCTREQUEST_DELAY = 0; //Field offset: 0x0
	private const float PRODUCTREQUEST_INVALID_CHANCE = 0; //Field offset: 0x0
	private const float PURCHASE_DELAY = 0; //Field offset: 0x0
	private const float PURCHASE_FAIL_CHANCE = 0; //Field offset: 0x0
	private static readonly string[] DUMMY_PRICES_LOCALIZED; //Field offset: 0x0
	private static readonly bool USE_SINGLE_RESTORE_INSTEAD_OF_PURCHASE; //Field offset: 0x4
	public static readonly List<string> LIST_OF_IDS_TO_RESTORE; //Field offset: 0x8
	private PurchaseDelegate _purchaseDelegate; //Field offset: 0x8
	private ProductInfoRequestDelegate _productRequestDelegate; //Field offset: 0xC
	private ItemRestoredDelegate _itemRestoredDelegate; //Field offset: 0x10
	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate; //Field offset: 0x14
	private IPurchaseValidationServer _purchaseValidationServer; //Field offset: 0x18
	private IInAppManager _inAppManager; //Field offset: 0x1C
	private MonoBehaviour _coroutineBehaviour; //Field offset: 0x20

	public bool IsValidationServerSpecified
	{
		 get { } //Length: 3
	}

	private static EditorPurchaseProvider() { }

	public EditorPurchaseProvider() { }

	public bool CanMakePurchases() { }

	public void FinishPurchase(string productId, string transactionId, string purchaseToken) { }

	public bool get_IsValidationServerSpecified() { }

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer) { }

	private IEnumerator ProductRequestCoroutine(string[] productIds) { }

	private IEnumerator PurchaseCoroutine(string productId) { }

	public void RequestProductInfo(string[] productIds) { }

	private IEnumerator RestoreCoroutine(string[] productIds) { }

	public bool RestoreNonConsumablePurchases(string[] productIds) { }

	public bool StartPurchase(string productId) { }

	public bool StartPurchase(string productId, string cookie) { }

}

