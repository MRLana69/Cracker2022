using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Backend.PurchaseValidation;

public sealed class PurchaseValidationServer : IPurchaseValidationServer
{
	private class ApiPurchaseValidationResponse : IPurchaseValidationResult
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
			set
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
			set
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
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 12;
				obj = value;
			}
		}
	}

	private class ApiPurchaseValidationRequest
	{
		private string productId__BackingField;

		public string productId
		{
			get
			{
				//IL_000d: Expected Obj, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer+ApiPurchaseValidationRequest)+10]");
				return (string)0;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 16;
				obj = value;
			}
		}

		public string receipt
		{
			get
			{
				return productId__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}
	}

	private sealed class _003CValidatePurchaseCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseValidationRequest purchaseValidationRequest;

		public PurchaseValidationServer _003C_003E4__this;

		public Action<PurchaseValidationRequest> completeHandler;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_038c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0391: Expected VT, but got Unknown
				//IL_039a: Unknown result type (might be due to invalid IL or missing references)
				//IL_039f: Expected Ref, but got Unknown
				//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b6: Expected Obj, but got Unknown
				//IL_03bf: Expected Obj, but got I4
				//IL_03ce: Expected Obj, but got I4
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected Obj, but got Unknown
				//IL_004d: Expected Obj, but got I4
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Expected Obj, but got Unknown
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Expected Obj, but got Unknown
				//IL_00d5: Expected I, but got Obj
				//IL_00eb: Expected Obj, but got I
				//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Expected Obj, but got Unknown
				//IL_0116: Expected I, but got Obj
				//IL_01b6: Expected I4, but got Obj
				//IL_01b1: Expected native int or pointer, but got VT
				//IL_01cb: Expected Obj, but got I
				//IL_01c6: Expected native int or pointer, but got VT
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d6: Expected Obj, but got Unknown
				//IL_02c4: Expected Obj, but got I4
				//IL_020b: Expected Obj, but got I4
				//IL_028f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0294: Expected Obj, but got Unknown
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				ref _0021_00210 reference = ref *(_0021_00210*)(obj + 24);
				reference = ref *(_0021_00210*)null;
				object obj2 = obj + 8;
				obj2 = 0;
				_ = 0;
				obj = 0;
				PurchaseValidationServer purchaseValidationServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj3 = default;
						if (obj3 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							IResponse response = default;
							if (ResponseExtensions.TryParseBson<T>(response, out System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (IBsonSerializer)purchaseValidationServer._jsonSerializer))
							{
								object obj4 = this.purchaseValidationRequest + 16;
								obj4 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
								if (completeHandler != null)
								{
									completeHandler(this.purchaseValidationRequest);
								}
								return null;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						obj = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj5 = this.purchaseValidationRequest + 16;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = default;
				object obj6 = obj7 + 8;
				PurchaseValidationRequest purchaseValidationRequest = this.purchaseValidationRequest;
				obj6 = purchaseValidationRequest.productId;
				object obj8 = obj7 + 12;
				PurchaseValidationRequest purchaseValidationRequest2 = this.purchaseValidationRequest;
				obj8 = purchaseValidationRequest2.receipt;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Uri uri = default;
				uri._002Ector(purchaseValidationServer.baseUri__BackingField, (Uri)(object)"api/v1/purchasevalidation");
				nint num = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v37 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num2 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v58 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj10 = this + 28;
				IRequest request = KilooWebClient.CreateGet(uri);
				IRequest request2 = RequestExtensions.WithKeepAlive(request, purchaseValidationServer.timeout__BackingField);
				IRequest request3 = RequestExtensions.WithBsonContent(request2, obj7, (IBsonSerializer)purchaseValidationServer._jsonSerializer);
				obj10 = request3;
				if (~(purchaseValidationServer.debug__BackingField ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Headers headers2 = default;
					Headers headers = headers2.SetAll("Kiloo-Debug", (IEnumerable<string>)(object)"true");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj2 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
				object obj11 = this + 12;
				Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__2, null, sendOptions);
				obj11 = coroutine;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CValidatePurchaseCoroutine_003Ed__16(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private Uri baseUri__BackingField;

	private bool debug__BackingField;

	private float timeout__BackingField;

	private const string API_POST_VALIDATE_PURCHASE = "api/v1/purchasevalidation";

	private readonly IJsonSerializer _jsonSerializer;

	public Uri baseUri
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			Uri result = default;
			return result;
		}
		set
		{
			//IL_013c: Expected I, but got Obj
			//IL_0152: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I4
			//IL_01f8: Expected Obj, but got I4
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_007a: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0198: Expected I, but got Obj
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected Obj, but got Unknown
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj2 = num3 + 16;
			obj2 = 45;
			string text = unfilteredLocale.Substring(num3);
			object obj3 = text + 16;
			string text2 = ((string)obj3).ToUpper();
			PurchaseValidationServer purchaseValidationServer = (PurchaseValidationServer)(object)text2;
			nint num4 = (nint)this;
			bool flag;
			if (this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18 (Il2CppClass<Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer>)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				purchaseValidationServer = (PurchaseValidationServer)(object)"en";
			}
			string text3;
			if (text.m_firstChar > '\u0001')
			{
				object obj4 = text + 20;
				text3 = ((string)obj4).ToString();
			}
			else
			{
				text3 = null;
			}
			Uri uri = (Uri)(object)text3;
			nint num5 = (nint)value;
			bool flag2;
			if ((object)value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v23 (Il2CppClass<System.Uri>)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				uri = (Uri)(object)"US";
			}
		}
	}

	public bool debug
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)baseUri__BackingField != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public float timeout
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.PurchaseValidation.PurchaseValidationServer)+38]");
			return 0f;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0018: Expected VT, but got Obj
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected Obj, but got Unknown
			//IL_0030: Expected VT, but got Obj
			//IL_003e: Expected Obj, but got I4
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected Obj, but got Unknown
			object obj = default;
			Transform transform = (Transform)(obj + 24);
			transform.position = (Vector3)this;
			Transform transform2 = (Transform)(obj + 12);
			transform2.position = (Vector3)this;
			obj = 0;
			_ = 0;
			obj = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
			_ = 0;
			Transform transform3 = (Transform)(obj + 36);
			transform3 = (Transform)obj;
			Transform transform4 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform3.localPosition;
		}
	}

	public unsafe PurchaseValidationServer(Uri baseUri, IJsonSerializer jsonSerializer, bool debug = false, float timeout = 0f)
	{
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected Obj, but got Unknown
		//IL_07a8: Expected Obj, but got I4
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07c5: Expected Obj, but got I4
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_07e2: Expected Obj, but got I4
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_07ff: Expected Obj, but got I4
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I4
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0839: Expected Obj, but got I4
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_0856: Expected Obj, but got I4
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I4
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0890: Expected Obj, but got I4
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected Obj, but got Unknown
		//IL_08ad: Expected Obj, but got I4
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected VT, but got Unknown
		//IL_08d8: Expected Obj, but got F4
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected VT, but got Unknown
		//IL_0907: Expected Obj, but got F4
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected VT, but got Unknown
		//IL_092c: Expected native int or pointer, but got VT
		//IL_093e: Expected native int or pointer, but got VT
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_0a0f: Expected Obj, but got I
		//IL_0a2b: Expected Obj, but got F4
		//IL_0a48: Expected Obj, but got I
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected Obj, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Expected Obj, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected Obj, but got Unknown
		//IL_0b41: Expected Obj, but got I
		//IL_0b73: Expected Obj, but got I
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Expected Obj, but got Unknown
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected Obj, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected Obj, but got Unknown
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Expected Obj, but got Unknown
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected Obj, but got Unknown
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected Obj, but got Unknown
		//IL_0c6c: Expected Obj, but got I
		//IL_0c9e: Expected Obj, but got I
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected Obj, but got Unknown
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Expected Obj, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected Obj, but got Unknown
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected Obj, but got Unknown
		//IL_0d97: Expected Obj, but got I
		//IL_0dc9: Expected Obj, but got I
		//IL_0ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Expected Obj, but got Unknown
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected Obj, but got Unknown
		//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected Obj, but got Unknown
		//IL_0e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Expected Obj, but got Unknown
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected Obj, but got Unknown
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected Obj, but got Unknown
		//IL_0ec2: Expected Obj, but got I
		//IL_0ef4: Expected Obj, but got I
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected Obj, but got Unknown
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected Obj, but got Unknown
		//IL_0f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f52: Expected Obj, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected Obj, but got Unknown
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected Obj, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected Obj, but got Unknown
		//IL_0fed: Expected Obj, but got I
		//IL_101f: Expected Obj, but got I
		//IL_1032: Unknown result type (might be due to invalid IL or missing references)
		//IL_1037: Expected Obj, but got Unknown
		//IL_1055: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected Obj, but got Unknown
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Expected Obj, but got Unknown
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected Obj, but got Unknown
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected Obj, but got Unknown
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Expected Obj, but got Unknown
		//IL_1118: Expected Obj, but got I
		//IL_114a: Expected Obj, but got I
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Expected Obj, but got Unknown
		//IL_1180: Unknown result type (might be due to invalid IL or missing references)
		//IL_1185: Expected Obj, but got Unknown
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected Obj, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cb: Expected Obj, but got Unknown
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected Obj, but got Unknown
		//IL_1235: Expected Obj, but got I
		//IL_1267: Expected Obj, but got I
		//IL_127f: Expected I, but got Obj
		//IL_1295: Expected Obj, but got I
		//IL_1314: Expected Obj, but got I4
		//IL_132f: Expected I, but got Obj
		//IL_1345: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_136f: Expected F4, but got Obj
		//IL_136a: Expected native int or pointer, but got VT
		//IL_1384: Expected F4, but got I
		//IL_137f: Expected native int or pointer, but got VT
		//IL_1391: Expected F4, but got Obj
		//IL_138c: Expected native int or pointer, but got VT
		//IL_13a6: Expected F4, but got I
		//IL_13a1: Expected native int or pointer, but got VT
		//IL_13b3: Expected F4, but got Obj
		//IL_13ae: Expected native int or pointer, but got VT
		//IL_13c8: Expected F4, but got I
		//IL_13c3: Expected native int or pointer, but got VT
		//IL_13ea: Expected F4, but got Obj
		//IL_13e5: Expected native int or pointer, but got VT
		//IL_13ff: Expected F4, but got I
		//IL_13fa: Expected native int or pointer, but got VT
		//IL_140c: Expected F4, but got Obj
		//IL_1407: Expected native int or pointer, but got VT
		//IL_1421: Expected F4, but got I
		//IL_141c: Expected native int or pointer, but got VT
		//IL_1433: Expected F4, but got I4
		//IL_142e: Expected native int or pointer, but got VT
		//IL_1448: Expected F4, but got I
		//IL_1443: Expected native int or pointer, but got VT
		//IL_146a: Expected F4, but got Obj
		//IL_1465: Expected native int or pointer, but got VT
		//IL_147f: Expected F4, but got I
		//IL_147a: Expected native int or pointer, but got VT
		//IL_148c: Expected F4, but got Obj
		//IL_1487: Expected native int or pointer, but got VT
		//IL_14a1: Expected F4, but got I
		//IL_149c: Expected native int or pointer, but got VT
		//IL_14b3: Expected F4, but got I4
		//IL_14ae: Expected native int or pointer, but got VT
		//IL_14c8: Expected F4, but got I
		//IL_14c3: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0092: Expected Obj, but got F4
		//IL_00a9: Expected F4, but got Obj
		//IL_00a4: Expected native int or pointer, but got VT
		//IL_00be: Expected F4, but got I
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_0309: Expected F4, but got Obj
		//IL_0304: Expected native int or pointer, but got VT
		//IL_031e: Expected F4, but got I
		//IL_0319: Expected native int or pointer, but got VT
		//IL_032b: Expected F4, but got Obj
		//IL_0326: Expected native int or pointer, but got VT
		//IL_0340: Expected F4, but got I
		//IL_033b: Expected native int or pointer, but got VT
		//IL_0352: Expected F4, but got I4
		//IL_034d: Expected native int or pointer, but got VT
		//IL_0367: Expected F4, but got I
		//IL_0362: Expected native int or pointer, but got VT
		//IL_0389: Expected F4, but got Obj
		//IL_0384: Expected native int or pointer, but got VT
		//IL_039e: Expected F4, but got I
		//IL_0399: Expected native int or pointer, but got VT
		//IL_03ab: Expected F4, but got Obj
		//IL_03a6: Expected native int or pointer, but got VT
		//IL_03c0: Expected F4, but got I
		//IL_03bb: Expected native int or pointer, but got VT
		//IL_03d2: Expected F4, but got I4
		//IL_03cd: Expected native int or pointer, but got VT
		//IL_03e7: Expected F4, but got I
		//IL_03e2: Expected native int or pointer, but got VT
		//IL_02bd: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got F4
		//IL_00f8: Expected F4, but got Obj
		//IL_00f3: Expected native int or pointer, but got VT
		//IL_010d: Expected F4, but got I
		//IL_0108: Expected native int or pointer, but got VT
		//IL_0140: Expected F4, but got Obj
		//IL_013b: Expected native int or pointer, but got VT
		//IL_0155: Expected F4, but got I
		//IL_0150: Expected native int or pointer, but got VT
		//IL_040e: Expected F4, but got Obj
		//IL_0409: Expected native int or pointer, but got VT
		//IL_0423: Expected F4, but got I
		//IL_041e: Expected native int or pointer, but got VT
		//IL_0430: Expected F4, but got Obj
		//IL_042b: Expected native int or pointer, but got VT
		//IL_0445: Expected F4, but got I
		//IL_0440: Expected native int or pointer, but got VT
		//IL_0457: Expected F4, but got I4
		//IL_0452: Expected native int or pointer, but got VT
		//IL_046c: Expected F4, but got I
		//IL_0467: Expected native int or pointer, but got VT
		//IL_048e: Expected F4, but got Obj
		//IL_0489: Expected native int or pointer, but got VT
		//IL_04a3: Expected F4, but got I
		//IL_049e: Expected native int or pointer, but got VT
		//IL_04b0: Expected F4, but got Obj
		//IL_04ab: Expected native int or pointer, but got VT
		//IL_04c5: Expected F4, but got I
		//IL_04c0: Expected native int or pointer, but got VT
		//IL_04d7: Expected F4, but got I4
		//IL_04d2: Expected native int or pointer, but got VT
		//IL_04ec: Expected F4, but got I
		//IL_04e7: Expected native int or pointer, but got VT
		//IL_018d: Expected F4, but got Obj
		//IL_0188: Expected native int or pointer, but got VT
		//IL_01a2: Expected F4, but got I
		//IL_019d: Expected native int or pointer, but got VT
		//IL_01d5: Expected F4, but got Obj
		//IL_01d0: Expected native int or pointer, but got VT
		//IL_01ea: Expected F4, but got I
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_0513: Expected F4, but got Obj
		//IL_050e: Expected native int or pointer, but got VT
		//IL_0528: Expected F4, but got I
		//IL_0523: Expected native int or pointer, but got VT
		//IL_0535: Expected F4, but got Obj
		//IL_0530: Expected native int or pointer, but got VT
		//IL_054a: Expected F4, but got I
		//IL_0545: Expected native int or pointer, but got VT
		//IL_055c: Expected F4, but got I4
		//IL_0557: Expected native int or pointer, but got VT
		//IL_0571: Expected F4, but got I
		//IL_056c: Expected native int or pointer, but got VT
		//IL_0593: Expected F4, but got Obj
		//IL_058e: Expected native int or pointer, but got VT
		//IL_05a8: Expected F4, but got I
		//IL_05a3: Expected native int or pointer, but got VT
		//IL_05b5: Expected F4, but got Obj
		//IL_05b0: Expected native int or pointer, but got VT
		//IL_05ca: Expected F4, but got I
		//IL_05c5: Expected native int or pointer, but got VT
		//IL_05dc: Expected F4, but got I4
		//IL_05d7: Expected native int or pointer, but got VT
		//IL_05f1: Expected F4, but got I
		//IL_05ec: Expected native int or pointer, but got VT
		//IL_0222: Expected F4, but got Obj
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0237: Expected F4, but got I
		//IL_0232: Expected native int or pointer, but got VT
		//IL_026a: Expected F4, but got Obj
		//IL_0265: Expected native int or pointer, but got VT
		//IL_027f: Expected F4, but got I
		//IL_027a: Expected native int or pointer, but got VT
		//IL_0618: Expected F4, but got Obj
		//IL_0613: Expected native int or pointer, but got VT
		//IL_062d: Expected F4, but got I
		//IL_0628: Expected native int or pointer, but got VT
		//IL_063a: Expected F4, but got Obj
		//IL_0635: Expected native int or pointer, but got VT
		//IL_064f: Expected F4, but got I
		//IL_064a: Expected native int or pointer, but got VT
		//IL_0661: Expected F4, but got I4
		//IL_065c: Expected native int or pointer, but got VT
		//IL_0676: Expected F4, but got I
		//IL_0671: Expected native int or pointer, but got VT
		//IL_0698: Expected F4, but got Obj
		//IL_0693: Expected native int or pointer, but got VT
		//IL_06ad: Expected F4, but got I
		//IL_06a8: Expected native int or pointer, but got VT
		//IL_06ba: Expected F4, but got Obj
		//IL_06b5: Expected native int or pointer, but got VT
		//IL_06cf: Expected F4, but got I
		//IL_06ca: Expected native int or pointer, but got VT
		//IL_06e1: Expected F4, but got I4
		//IL_06dc: Expected native int or pointer, but got VT
		//IL_06f6: Expected F4, but got I
		//IL_06f1: Expected native int or pointer, but got VT
		//IL_071d: Expected F4, but got Obj
		//IL_0718: Expected native int or pointer, but got VT
		//IL_0732: Expected F4, but got I
		//IL_072d: Expected native int or pointer, but got VT
		//IL_073f: Expected F4, but got Obj
		//IL_073a: Expected native int or pointer, but got VT
		//IL_0754: Expected F4, but got I
		//IL_074f: Expected native int or pointer, but got VT
		//IL_0766: Expected F4, but got I4
		//IL_0761: Expected native int or pointer, but got VT
		//IL_077b: Expected F4, but got I
		//IL_0776: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 676;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 664;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 652;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 640;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 628;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 616;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 604;
		obj8 = 0;
		_ = 0;
		object obj9 = obj2 + 592;
		obj9 = 0;
		_ = 0;
		object obj10 = obj2 + 580;
		obj10 = 0;
		_ = 0;
		object obj11 = obj2 + 568;
		obj11 = 0;
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 712);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		obj10 = vector.x;
		_ = vector.z;
		Vector3 vector2 = (Vector3)(obj2 + 700);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		obj11 = vector2.x;
		_ = vector2.z;
		Vector3 vector3 = (Vector3)(obj2 + 688);
		((Vector3*)(nint)vector3)->x = vector2.x;
		((Vector3*)(nint)vector3)->z = vector2.z;
		object obj12 = obj2 + 556;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj13 = obj2 + 544;
		obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj14 = obj2 + 528;
		obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj15 = obj2 + 516;
		obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj16 = obj2 + 504;
		obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v67+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v71+8]");
		object obj17 = num - 0;
		float num2 = vector3.x - (float)obj12;
		obj = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v57+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v62+4]");
		object obj18 = num3 + 0;
		object obj19 = obj2 + 492;
		obj19 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj20 = obj2 + 480;
		obj20 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj21 = obj2 + 468;
		obj21 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj22 = obj2 + 456;
		obj22 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj23 = obj2 + 444;
		obj23 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj24 = obj2 + 432;
		obj24 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v96+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v106+8]");
		object obj25 = num4 - 0;
		object obj26 = obj19 + obj20;
		obj3 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v86+4]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v91+4]");
		object obj27 = num5 + 0;
		object obj28 = obj2 + 420;
		obj28 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj29 = obj2 + 408;
		obj29 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj30 = obj2 + 396;
		obj30 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj31 = obj2 + 384;
		obj31 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj32 = obj2 + 372;
		obj32 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj33 = obj2 + 360;
		obj33 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v125+8]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S1_v141+8]");
		object obj34 = num6 - 0;
		object obj35 = obj28 - obj29;
		obj4 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v115+4]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v120+4]");
		object obj36 = num7 - 0;
		object obj37 = obj2 + 348;
		obj37 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj38 = obj2 + 336;
		obj38 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj39 = obj2 + 324;
		obj39 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj40 = obj2 + 312;
		obj40 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj41 = obj2 + 300;
		obj41 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj42 = obj2 + 288;
		obj42 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v154+8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v176+8]");
		object obj43 = num8 - 0;
		object obj44 = obj37 + obj38;
		obj5 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v144+4]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v149+4]");
		object obj45 = num9 - 0;
		object obj46 = obj2 + 276;
		obj46 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj47 = obj2 + 264;
		obj47 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj48 = obj2 + 252;
		obj48 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj49 = obj2 + 240;
		obj49 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj50 = obj2 + 228;
		obj50 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj51 = obj2 + 216;
		obj51 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v183+8]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v211+8]");
		object obj52 = num10 + 0;
		object obj53 = obj46 - obj47;
		obj6 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v173+4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v178+4]");
		object obj54 = num11 + 0;
		object obj55 = obj2 + 204;
		obj55 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj56 = obj2 + 192;
		obj56 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj57 = obj2 + 180;
		obj57 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj58 = obj2 + 168;
		obj58 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj59 = obj2 + 156;
		obj59 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj60 = obj2 + 144;
		obj60 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S0_v212+8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S1_v246+8]");
		object obj61 = num12 + 0;
		object obj62 = obj55 + obj56;
		obj7 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v202+4]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v207+4]");
		object obj63 = num13 + 0;
		object obj64 = obj2 + 132;
		obj64 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj65 = obj2 + 120;
		obj65 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj66 = obj2 + 108;
		obj66 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj67 = obj2 + 96;
		obj67 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj68 = obj2 + 84;
		obj68 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj69 = obj2 + 72;
		obj69 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S0_v241+8]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S1_v281+8]");
		object obj70 = num14 + 0;
		object obj71 = obj64 - obj65;
		obj8 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v231+4]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S0_v236+4]");
		object obj72 = num15 - 0;
		object obj73 = obj2 + 60;
		obj73 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj74 = obj2 + 48;
		obj74 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj75 = obj2 + 36;
		obj75 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		object obj76 = obj2 + 24;
		obj76 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		object obj77 = obj2 + 12;
		obj77 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
		_ = 0;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ S0_v270+8]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj78 = num16 + 0;
		object obj79 = obj73 + obj74;
		obj9 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S0_v260+4]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S0_v265+4]");
		object obj80 = num17 - 0;
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ S0_v279 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj81 = (nint)0 & (nint)0x200;
		if (obj81 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ S0_v426 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)jsonSerializer).FindKernel((string)null) != 0)
		{
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Vector3 vector5 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj = vector2.x;
			_ = vector2.z;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			Vector3 vector7 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj3 = vector3.x;
			_ = vector3.z;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Vector3 vector9 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj4 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v52+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector10 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			Vector3 vector11 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj5 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v57+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj6;
			Vector3 vector12 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
			((Vector3*)(nint)vector12)->z = 0f;
			Vector3 vector13 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj6 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v62+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj7;
			Vector3 vector14 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			Vector3 vector15 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj7 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v67+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector16 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
			((Vector3*)(nint)vector16)->z = 0f;
			Vector3 vector17 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj8 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v71+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Vector3 vector18 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
			((Vector3*)(nint)vector18)->z = 0f;
			Vector3 vector19 = ((Transform)jsonSerializer).InverseTransformPoint(vector);
			obj9 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v76+8]");
			_ = 0;
		}
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj14 = ((bool*)(debug ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		_ = 0;
		nint num20 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ S0_v293 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj82 = (nint)0 & (nint)0x200;
		if (obj82 != null)
		{
			nint num21 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ S0_v382 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector3)->x = (float)obj12;
		Vector3 vector20 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v52+8]");
		((Vector3*)(nint)vector20)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj13;
		Vector3 vector21 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v57+8]");
		((Vector3*)(nint)vector21)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj14;
		Vector3 vector22 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v62+8]");
		((Vector3*)(nint)vector22)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector23 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector23)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Vector3 vector24 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector24)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector25 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector25)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj5;
		Vector3 vector26 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector26)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Vector3 vector27 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector27)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector28 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector28)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector29 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector29)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Vector3 vector30 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector30)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector31 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector31)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj6;
		Vector3 vector32 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		((Vector3*)(nint)vector32)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector33 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((Vector3*)(nint)vector33)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector34 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector34)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj7;
		Vector3 vector35 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((Vector3*)(nint)vector35)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector36 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
		((Vector3*)(nint)vector36)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector37 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector37)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj9;
		Vector3 vector38 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
		((Vector3*)(nint)vector38)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector39 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
		((Vector3*)(nint)vector39)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector40 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector40)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj8;
		Vector3 vector41 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
		((Vector3*)(nint)vector41)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector42 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		((Vector3*)(nint)vector42)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector43 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector43)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj;
		Vector3 vector44 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector44)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector45 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		((Vector3*)(nint)vector45)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector46 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector46)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector47 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector47)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector48 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((Vector3*)(nint)vector48)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector49 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector49)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj5;
		Vector3 vector50 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector50)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector51 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
		((Vector3*)(nint)vector51)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector52 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector52)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector53 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector53)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector54 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
		((Vector3*)(nint)vector54)->z = 0f;
		((Vector3*)(nint)vector)->x = (((bool*)(debug ? 1 : 0))->m_value ? 1 : 0);
		Vector3 vector55 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [debug @ L3 (System.Boolean)+8]");
		((Vector3*)(nint)vector55)->z = 0f;
		Debug.DrawRay(vector3, vector2, (Color)vector, timeout);
	}

	public Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler)
	{
		//IL_000e: Expected I4, but got Obj
		//IL_000e: Expected I4, but got Obj
		//IL_0026: Expected Obj, but got I4
		int num = ((string)this).LastIndexOf((char)(int)purchaseValidationRequest, (int)completeHandler);
		bool flag = num > -1;
		return (Coroutine)flag;
	}

	private IEnumerator ValidatePurchaseCoroutine(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler)
	{
		Coroutine list = ((SimulatedPurchaseValidationServer)this).ValidatePurchase(purchaseValidationRequest, completeHandler);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}
}
