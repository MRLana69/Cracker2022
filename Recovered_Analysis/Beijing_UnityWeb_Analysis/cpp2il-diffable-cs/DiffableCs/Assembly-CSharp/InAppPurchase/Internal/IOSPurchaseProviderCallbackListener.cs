namespace InAppPurchase.Internal;

public class IOSPurchaseProviderCallbackListener : MonoBehaviour
{
	private Action<string> _onProductRequestSuccessful; //Field offset: 0xC
	private Action _onProductRequestFailed; //Field offset: 0x10
	private Action<string> _onPurchasePurchased; //Field offset: 0x14
	private Action<string> _onPurchaseRestored; //Field offset: 0x18
	private Action<string> _onPurchaseFailed; //Field offset: 0x1C
	private Action<string> _onRestoreFinished; //Field offset: 0x20

	public IOSPurchaseProviderCallbackListener() { }

	private void FireEmptyEvent(Action handler) { }

	private void FireEventWithMessage(Action<string> handler, string message) { }

	private void IOSPurchaseProvider_ProductRequestFailed() { }

	private void IOSPurchaseProvider_ProductRequestSuccessful(string message) { }

	private void IOSPurchaseProvider_PurchaseFailed(string message) { }

	private void IOSPurchaseProvider_PurchasePurchased(string message) { }

	private void IOSPurchaseProvider_PurchaseRestored(string message) { }

	private void IOSPurchaseProvider_RestoreFinished(string message) { }

	public void Setup(Action<string> onProductRequestSuccessful, Action onProductRequestFailed, Action<string> onPurchasePurchased, Action<string> onPurchaseRestored, Action<string> onPurchaseFailed, Action<string> onRestoreFinished) { }

}

