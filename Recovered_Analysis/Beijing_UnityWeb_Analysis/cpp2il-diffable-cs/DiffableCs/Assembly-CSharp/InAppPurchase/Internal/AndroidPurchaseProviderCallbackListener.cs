namespace InAppPurchase.Internal;

public class AndroidPurchaseProviderCallbackListener : MonoBehaviour
{
	private Action _onInitSuccessful; //Field offset: 0xC
	private Action _onInitFailed; //Field offset: 0x10
	private Action<string> _onProductRequestSuccessful; //Field offset: 0x14
	private Action _onProductRequestFailed; //Field offset: 0x18
	private Action<string> _onPurchasePurchased; //Field offset: 0x1C
	private Action<string> _onPurchaseRestored; //Field offset: 0x20
	private Action<string> _onPurchaseRefunded; //Field offset: 0x24
	private Action<string> _onPurchaseFailed; //Field offset: 0x28
	private Action<string> _onRestoreFinished; //Field offset: 0x2C
	private Action<string> _onConsumeFinished; //Field offset: 0x30

	public AndroidPurchaseProviderCallbackListener() { }

	private void AndroidPurchaseProvider_ConsumeFinished(string message) { }

	private void AndroidPurchaseProvider_InitFailed(string notUsed) { }

	private void AndroidPurchaseProvider_InitSuccessful(string notUsed) { }

	private void AndroidPurchaseProvider_ProductRequestFailed(string notUsed) { }

	private void AndroidPurchaseProvider_ProductRequestSuccessful(string message) { }

	private void AndroidPurchaseProvider_PurchaseFailed(string message) { }

	private void AndroidPurchaseProvider_PurchasePurchased(string message) { }

	private void AndroidPurchaseProvider_PurchaseRefunded(string message) { }

	private void AndroidPurchaseProvider_PurchaseRestored(string message) { }

	private void AndroidPurchaseProvider_RestoreFinished(string message) { }

	private void FireEmptyEvent(Action handler) { }

	private void FireEventWithMessage(Action<string> handler, string message) { }

	public void Setup(Action onInitSuccessful, Action onInitFailed, Action<string> onProductRequestSuccessful, Action onProductRequestFailed, Action<string> onPurchasePurchased, Action<string> onPurchaseRestored, Action<string> onPurchaseRefunded, Action<string> onPurchaseFailed, Action<string> onRestoreFinished, Action<string> onConsumeFinished) { }

}

