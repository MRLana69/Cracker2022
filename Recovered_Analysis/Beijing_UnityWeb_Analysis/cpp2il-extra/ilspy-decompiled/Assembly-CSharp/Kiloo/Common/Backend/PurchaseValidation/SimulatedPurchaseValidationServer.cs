using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Backend.PurchaseValidation;

public class SimulatedPurchaseValidationServer : IPurchaseValidationServer
{
	private class Result : IPurchaseValidationResult
	{
		private ReceiptStatus receiptStatus__BackingField;

		private string purchaseToken__BackingField;

		public ReceiptStatus receiptStatus
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (ReceiptStatus)purchaseToken__BackingField;
			}
			internal set
			{
				receiptStatus__BackingField = value;
			}
		}

		public string purchaseToken
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (string)receiptStatus__BackingField;
			}
			internal set
			{
				//IL_000a: Expected I4, but got Obj
				receiptStatus__BackingField = (ReceiptStatus)value;
			}
		}

		public Error error
		{
			get
			{
				return (Error)(object)purchaseToken__BackingField;
			}
			internal set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 12;
				obj = value;
			}
		}

		public Result()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 20;
		obj = this;
		object obj2 = coroutine + 16;
		obj2 = purchaseValidationRequest;
		object obj3 = coroutine + 24;
		obj3 = completeHandler;
		return coroutine;
	}
}
