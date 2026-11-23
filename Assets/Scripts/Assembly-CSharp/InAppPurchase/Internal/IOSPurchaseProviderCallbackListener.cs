using System;
using Cpp2ILInjected;
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
		_onProductRequestSuccessful = onProductRequestSuccessful;
		_onProductRequestFailed = onProductRequestFailed;
		_onPurchasePurchased = onPurchasePurchased;
		_onPurchaseRestored = onPurchaseRestored;
		_onPurchaseFailed = onPurchaseFailed;
		_onRestoreFinished = onRestoreFinished;
	}

	private void IOSPurchaseProvider_ProductRequestSuccessful(string message)
	{
		Action<string> onProductRequestSuccessful = _onProductRequestSuccessful;
		if (_onProductRequestSuccessful != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void IOSPurchaseProvider_ProductRequestFailed()
	{
		Action onProductRequestFailed = _onProductRequestFailed;
		if (_onProductRequestFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void IOSPurchaseProvider_PurchasePurchased(string message)
	{
		Action<string> onPurchasePurchased = _onPurchasePurchased;
		if (_onPurchasePurchased != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void IOSPurchaseProvider_PurchaseRestored(string message)
	{
		Action<string> onPurchaseRestored = _onPurchaseRestored;
		if (_onPurchaseRestored != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void IOSPurchaseProvider_PurchaseFailed(string message)
	{
		Action<string> onPurchaseFailed = _onPurchaseFailed;
		if (_onPurchaseFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void IOSPurchaseProvider_RestoreFinished(string message)
	{
		Action<string> onRestoreFinished = _onRestoreFinished;
		if (_onRestoreFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void FireEventWithMessage(Action<string> handler, string message)
	{
		if (handler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [handler @ L1 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void FireEmptyEvent(Action handler)
	{
		if (handler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: handler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
