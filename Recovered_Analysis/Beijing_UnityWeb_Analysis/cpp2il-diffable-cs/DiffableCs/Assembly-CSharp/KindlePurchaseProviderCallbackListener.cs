//Type is in global namespace

public class KindlePurchaseProviderCallbackListener : MonoBehaviour
{
	private Action<string> _onProductRequestSuccessful; //Field offset: 0xC
	private Action<string> _onProductRequestFailed; //Field offset: 0x10
	private Action _onRestoreFinished; //Field offset: 0x14
	private Action _onRestoreFailed; //Field offset: 0x18
	private Action _onRestoreFinishedNothingToRestore; //Field offset: 0x1C
	private Action<string> _onRestoreSuccessful; //Field offset: 0x20
	private Action<string> _onPurchaseSuccessful; //Field offset: 0x24
	private Action<string> _onPurchaseFailedInvalidId; //Field offset: 0x28
	private Action<string> _onPurchaseFailed; //Field offset: 0x2C
	private Action<string> _onPurchaseRefunded; //Field offset: 0x30

	public KindlePurchaseProviderCallbackListener() { }

	private void FireEmptyEvent(Action handler) { }

	private void FireEventWithMessage(Action<string> handler, string message) { }

	public void ProductPurchasedSuccessfully(string message) { }

	public void ProductPurchaseFailed(string message) { }

	public void ProductPurchaseInvalidId(string message) { }

	public void ProductRefunded(string message) { }

	public void ProductRequestFailed(string message) { }

	public void ProductRequestSuccessful(string message) { }

	public void ProductRestoredSuccessfully(string message) { }

	public void ProductRestoreFailed(string empty) { }

	public void ProductRestoreFinished(string empty) { }

	public void ProductRestoreFinishedButNothingHasBeenRestored(string empty) { }

	public void Setup(Action<string> onProductRequestSuccessful, Action<string> onProductRequestFailed, Action onRestoreFinished, Action onRestoreFailed, Action onRestoreFinishedNothingToRestore, Action<string> onRestoreSuccessful, Action<string> onPurchaseSuccessful, Action<string> onPurchaseFailedInvalidId, Action<string> onPurchaseFailed, Action<string> onPurchaseRefunded) { }

}

