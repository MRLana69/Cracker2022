using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Backend.PurchaseValidation;

public sealed class PurchaseValidationServer : IPurchaseValidationServer
{
	private class PurchaseValidationResult : IPurchaseValidationResult
	{
		public ReceiptStatus receiptStatus
		{
			get
			{
				return field;
			}
			set
			{
				field = value;
			}
		}

		public string purchaseToken
		{
			get
			{
				return field;
			}
			set
			{
				field = value;
			}
		}

		public Error error
		{
			get
			{
				return field;
			}
			set
			{
				field = value;
			}
		}
	}

	[Serializable]
	private class ApiPurchaseValidationResponse
	{
		public string receiptStatus;

		public string purchaseToken;

		public Error error;
	}

	[Serializable]
	private class ApiPurchaseValidationRequest
	{
		public string productId;

		public string receipt;
	}

	private sealed class _003CValidatePurchaseCoroutine_003Ed__18(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseValidationRequest purchaseValidationRequest;

		public PurchaseValidationServer _003C_003E4__this;

		public Action<PurchaseValidationRequest> completeHandler;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected Obj, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected Ref, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_0178: Expected Obj, but got I
			//IL_0188: Expected Obj, but got I
			//IL_0198: Expected VT, but got Obj
			//IL_030e: Expected Obj, but got I4
			//IL_0260: Expected Obj, but got I
			object obj = default;
			PurchaseValidationServer purchaseValidationServer = (PurchaseValidationServer)(obj - 48);
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj2 = default;
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						IResponse response = default;
						if (purchaseValidationServer.TryParseResponse(response, out *(PurchaseValidationResult*)(purchaseValidationServer + 44)))
						{
							PurchaseValidationRequest purchaseValidationRequest = this.purchaseValidationRequest;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer)+2C]");
							purchaseValidationRequest.result = (IPurchaseValidationResult)0;
							goto IL_0375;
						}
					}
					PurchaseValidationRequest purchaseValidationRequest2 = this.purchaseValidationRequest;
					_ = 1;
					Enum obj3 = (Enum)(purchaseValidationServer + 16);
					_ = -1;
					obj3 = (Enum)(object)typeof(ErrorCategory);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer)+1C]");
					_ = 0;
					string text = obj3.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj4 = default;
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					}
					else
					{
						object obj5 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					string text3 = default;
					string text2 = "Purchase validation request failed: " + text3;
					IPurchaseValidationResult result = default;
					purchaseValidationRequest2.result = result;
					goto IL_0375;
				}
				bool result2 = default;
				return result2;
			}
			PurchaseValidationServer purchaseValidationServer2 = _003C_003E4__this;
			_003C_003E1__state = -1;
			PurchaseValidationRequest purchaseValidationRequest3 = this.purchaseValidationRequest;
			purchaseValidationRequest3.result = null;
			PurchaseValidationRequest purchaseValidationRequest4 = this.purchaseValidationRequest;
			_ = purchaseValidationRequest4.productId;
			PurchaseValidationRequest purchaseValidationRequest5 = this.purchaseValidationRequest;
			_ = purchaseValidationRequest5.receipt;
			object obj6 = default;
			string content = JsonUtility.ToJson(obj6, prettyPrint: true);
			Uri uri = default;
			uri._002Ector(purchaseValidationServer2.baseUri__BackingField, "api/v1/purchasevalidation");
			IRequest request = KilooWebClient.CreatePost(uri);
			IRequest request2 = RequestExtensions.WithTimeout(request, purchaseValidationServer2.timeout__BackingField);
			IRequest request3 = RequestExtensions.WithContent(request2, content, "application/json");
			_003Crequest_003E5__2 = request3;
			if (~(purchaseValidationServer2.debug__BackingField ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers headers2 = default;
				Headers headers = headers2.Set("Kiloo-Debug", "true");
			}
			object obj7 = purchaseValidationServer + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			PurchaseValidationServer purchaseValidationServer3 = purchaseValidationServer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer)+28]");
			purchaseValidationServer3.baseUri__BackingField = (Uri)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer)+20]");
			purchaseValidationServer = (PurchaseValidationServer)0;
			Coroutine coroutine = RequestExtensions.SendAsync(_003Crequest_003E5__2, null, (WebClient.SendOptions)purchaseValidationServer);
			_003C_003E2__current = coroutine;
			_003C_003E1__state = 1;
			return true;
			IL_0375:
			Action<PurchaseValidationRequest> action = completeHandler;
			if (completeHandler == null)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ S0_v57 (System.Action`1<Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationRequest>)+C] (should have been resolved before IL gen)");
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private const string API_POST_VALIDATE_PURCHASE = "api/v1/purchasevalidation";

	private Uri baseUri__BackingField;

	private bool debug__BackingField;

	private float timeout__BackingField;

	public Uri baseUri
	{
		get
		{
			return baseUri__BackingField;
		}
		set
		{
			baseUri__BackingField = value;
		}
	}

	public bool debug
	{
		get
		{
			return debug__BackingField;
		}
		set
		{
			debug__BackingField = value;
		}
	}

	public float timeout
	{
		get
		{
			return timeout__BackingField;
		}
		set
		{
			timeout__BackingField = value;
		}
	}

	public PurchaseValidationServer(Uri baseUri)
	{
		this.baseUri__BackingField = baseUri;
	}

	public Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler)
	{
		IEnumerator coroutine = ValidatePurchaseCoroutine(purchaseValidationRequest, completeHandler);
		return CoroutineUtil.StartCoroutine(coroutine);
	}

	private IEnumerator ValidatePurchaseCoroutine(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe bool TryParseResponse(IResponse response, out PurchaseValidationResult responseData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_0402: Expected I4, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v90+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v90+C]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj4 = default;
											ref PurchaseValidationResult reference = ref *(PurchaseValidationResult*)obj4;
											result = true;
											goto IL_053f;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_027f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_027f;
		IL_0544:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_053f;
		IL_027f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag = obj5 != obj6;
		bool flag2 = default;
		result = flag2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj3 + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						ref PurchaseValidationResult reference = ref *(PurchaseValidationResult*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = -1;
						result = false;
						goto IL_053f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					bool flag3 = default;
					((bool*)(flag3 ? 1 : 0))->m_value = (byte)(int)obj8 != 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					result = flag3;
					if (flag4)
					{
						goto IL_0544;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 != 1;
			bool flag6 = default;
			result = flag6;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = flag6;
			}
		}
		goto IL_0544;
		IL_053f:
		return result;
	}
}
