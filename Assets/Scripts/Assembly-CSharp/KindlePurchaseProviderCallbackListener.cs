using System;
using Cpp2ILInjected;
using UnityEngine;

public class KindlePurchaseProviderCallbackListener : MonoBehaviour
{
	private Action<string> _onProductRequestSuccessful;

	private Action<string> _onProductRequestFailed;

	private Action _onRestoreFinished;

	private Action _onRestoreFailed;

	private Action _onRestoreFinishedNothingToRestore;

	private Action<string> _onRestoreSuccessful;

	private Action<string> _onPurchaseSuccessful;

	private Action<string> _onPurchaseFailedInvalidId;

	private Action<string> _onPurchaseFailed;

	private Action<string> _onPurchaseRefunded;

	public void Setup(Action<string> onProductRequestSuccessful, Action<string> onProductRequestFailed, Action onRestoreFinished, Action onRestoreFailed, Action onRestoreFinishedNothingToRestore, Action<string> onRestoreSuccessful, Action<string> onPurchaseSuccessful, Action<string> onPurchaseFailedInvalidId, Action<string> onPurchaseFailed, Action<string> onPurchaseRefunded)
	{
		_onProductRequestSuccessful = onProductRequestSuccessful;
		_onProductRequestFailed = onProductRequestFailed;
		_onRestoreFinished = onRestoreFinished;
		_onRestoreFailed = onRestoreFailed;
		_onRestoreFinishedNothingToRestore = onRestoreFinishedNothingToRestore;
		_onRestoreSuccessful = onRestoreSuccessful;
		_onPurchaseSuccessful = onPurchaseSuccessful;
		_onPurchaseFailedInvalidId = onPurchaseFailedInvalidId;
		_onPurchaseFailed = onPurchaseFailed;
		_onPurchaseRefunded = onPurchaseRefunded;
	}

	public void ProductRequestSuccessful(string message)
	{
		Action<string> onProductRequestSuccessful = _onProductRequestSuccessful;
		if (_onProductRequestSuccessful != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ProductRequestFailed(string message)
	{
		Action<string> onProductRequestFailed = _onProductRequestFailed;
		if (_onProductRequestFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoredSuccessfully(string message)
	{
		Action<string> onRestoreSuccessful = _onRestoreSuccessful;
		if (_onRestoreSuccessful != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoreFinished(string empty)
	{
		Action onRestoreFinished = _onRestoreFinished;
		if (_onRestoreFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoreFinishedButNothingHasBeenRestored(string empty)
	{
		Action onRestoreFinishedNothingToRestore = _onRestoreFinishedNothingToRestore;
		if (_onRestoreFinishedNothingToRestore != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductRestoreFailed(string empty)
	{
		Action onRestoreFailed = _onRestoreFailed;
		if (_onRestoreFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ProductPurchasedSuccessfully(string message)
	{
		Action<string> onPurchaseSuccessful = _onPurchaseSuccessful;
		if (_onPurchaseSuccessful != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ProductPurchaseInvalidId(string message)
	{
		Action<string> onPurchaseFailedInvalidId = _onPurchaseFailedInvalidId;
		if (_onPurchaseFailedInvalidId != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ProductPurchaseFailed(string message)
	{
		Action<string> onPurchaseFailed = _onPurchaseFailed;
		if (_onPurchaseFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.String>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ProductRefunded(string message)
	{
		Action<string> onPurchaseRefunded = _onPurchaseRefunded;
		if (_onPurchaseRefunded != null)
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
