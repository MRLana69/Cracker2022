using System;
using Cpp2ILInjected;
using UnityEngine;

namespace InAppPurchase.Internal;

public class AndroidPurchaseProviderCallbackListener : MonoBehaviour
{
	private Action _onInitSuccessful;

	private Action _onInitFailed;

	private Action<string> _onProductRequestSuccessful;

	private Action _onProductRequestFailed;

	private Action<string> _onPurchasePurchased;

	private Action<string> _onPurchaseRestored;

	private Action<string> _onPurchaseRefunded;

	private Action<string> _onPurchaseFailed;

	private Action<string> _onRestoreFinished;

	private Action<string> _onConsumeFinished;

	public void Setup(Action onInitSuccessful, Action onInitFailed, Action<string> onProductRequestSuccessful, Action onProductRequestFailed, Action<string> onPurchasePurchased, Action<string> onPurchaseRestored, Action<string> onPurchaseRefunded, Action<string> onPurchaseFailed, Action<string> onRestoreFinished, Action<string> onConsumeFinished)
	{
		_onInitSuccessful = onInitSuccessful;
		_onInitFailed = onInitFailed;
		_onProductRequestSuccessful = onProductRequestSuccessful;
		_onProductRequestFailed = onProductRequestFailed;
		_onPurchasePurchased = onPurchasePurchased;
		_onPurchaseRefunded = onPurchaseRefunded;
		_onPurchaseRestored = onPurchaseRestored;
		_onPurchaseFailed = onPurchaseFailed;
		_onRestoreFinished = onRestoreFinished;
		_onConsumeFinished = onConsumeFinished;
	}

	private void AndroidPurchaseProvider_InitSuccessful(string notUsed)
	{
		Action onInitSuccessful = _onInitSuccessful;
		if (_onInitSuccessful != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_InitFailed(string notUsed)
	{
		Action onInitFailed = _onInitFailed;
		if (_onInitFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_ProductRequestSuccessful(string message)
	{
		Action<string> onProductRequestSuccessful = _onProductRequestSuccessful;
		if (_onProductRequestSuccessful != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_ProductRequestFailed(string notUsed)
	{
		Action onProductRequestFailed = _onProductRequestFailed;
		if (_onProductRequestFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_PurchasePurchased(string message)
	{
		Action<string> onPurchasePurchased = _onPurchasePurchased;
		if (_onPurchasePurchased != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_PurchaseRestored(string message)
	{
		Action<string> onPurchaseRestored = _onPurchaseRestored;
		if (_onPurchaseRestored != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_PurchaseRefunded(string message)
	{
		Action<string> onPurchaseRefunded = _onPurchaseRefunded;
		if (_onPurchaseRefunded != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_PurchaseFailed(string message)
	{
		Action<string> onPurchaseFailed = _onPurchaseFailed;
		if (_onPurchaseFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_RestoreFinished(string message)
	{
		Action<string> onRestoreFinished = _onRestoreFinished;
		if (_onRestoreFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	private void AndroidPurchaseProvider_ConsumeFinished(string message)
	{
		Action<string> onConsumeFinished = _onConsumeFinished;
		if (_onConsumeFinished != null)
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
