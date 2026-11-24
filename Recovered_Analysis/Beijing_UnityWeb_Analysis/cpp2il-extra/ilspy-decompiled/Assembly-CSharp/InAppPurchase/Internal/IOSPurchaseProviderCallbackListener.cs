using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase.Internal;

public class IOSPurchaseProviderCallbackListener : MonoBehaviour
{
	private Action<string> _onProductRequestSuccessful;

	private Action _onProductRequestFailed;

	private Action<string> _onPurchasePurchased;

	private Action<string> _onPurchaseRestored;

	private Action<string> _onPurchaseFailed;

	private Action<string> _onRestoreFinished;

	public void Setup(Action<string> onProductRequestSuccessful, Action onProductRequestFailed, Action<string> onPurchasePurchased, Action<string> onPurchaseRestored, Action<string> onPurchaseFailed, Action<string> onRestoreFinished)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8947");
	}

	private void IOSPurchaseProvider_ProductRequestSuccessful(string message)
	{
	}

	private void IOSPurchaseProvider_ProductRequestFailed()
	{
	}

	private void IOSPurchaseProvider_PurchasePurchased(string message)
	{
		((KindlePurchaseProvider)null).Init((IInAppManager)(object)_onProductRequestSuccessful, (IPurchaseValidationServer)(object)message);
	}

	private void IOSPurchaseProvider_PurchaseRestored(string message)
	{
		((KindlePurchaseProvider)null).Init((IInAppManager)(object)_onPurchasePurchased, (IPurchaseValidationServer)(object)message);
	}

	private void IOSPurchaseProvider_PurchaseFailed(string message)
	{
		((KindlePurchaseProvider)null).Init((IInAppManager)(object)_onPurchaseRestored, (IPurchaseValidationServer)(object)message);
	}

	private void IOSPurchaseProvider_RestoreFinished(string message)
	{
		((KindlePurchaseProvider)null).Init((IInAppManager)(object)_onPurchaseFailed, (IPurchaseValidationServer)(object)message);
	}

	private void FireEventWithMessage(Action<string> handler, string message)
	{
		if (_onProductRequestFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
		}
	}

	private void FireEmptyEvent(Action handler)
	{
		((KindlePurchaseProvider)null).Init((IInAppManager)(object)_onRestoreFinished, (IPurchaseValidationServer)(object)handler);
	}

	public IOSPurchaseProviderCallbackListener()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}
}
