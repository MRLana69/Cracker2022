using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.HTTP.Internal;

internal class UnityRequest : Request
{
	private sealed class _003CSendCoroutine_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UnityRequest _003C_003E4__this;

		private bool _003Cok_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_03f7: Expected Obj, but got I
				//IL_0843: Unknown result type (might be due to invalid IL or missing references)
				//IL_0848: Expected Obj, but got Unknown
				//IL_0851: Expected Obj, but got I4
				//IL_0695: Expected Obj, but got I
				//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_06a5: Expected Obj, but got Unknown
				//IL_06ae: Expected Obj, but got I4
				//IL_0429: Unknown result type (might be due to invalid IL or missing references)
				//IL_042e: Expected Obj, but got Unknown
				//IL_0437: Expected Obj, but got I4
				//IL_044b: Expected Obj, but got I4
				//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04bc: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 16;
				obj2 = obj;
				_ = -1;
				UnityRequest unityRequest = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cok_003E5__2 = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				if (~(_003Cok_003E5__2 ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Kiloo.Common.HTTP.Internal.UnityRequest)+48]");
					Type parentTypeDisallowingMultipleInclusion = UnityEngine.AttributeHelperEngine.GetParentTypeDisallowingMultipleInclusion((Type)0);
					if ((object)parentTypeDisallowingMultipleInclusion == null)
					{
						object obj3 = this + 12;
						obj3 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				if (~(_003Cok_003E5__2 ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj4 = _003C_003E4__this + 12;
					object obj5 = default;
					obj4 = obj5;
					((Request)unityRequest).state__BackingField = RequestState.Done;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Kiloo.Common.HTTP.Internal.UnityRequest)+4C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Kiloo.Common.HTTP.Internal.UnityRequest)+4C]");
					((UnityWebRequest)0).DisposeHandlers();
					object obj6 = _003C_003E4__this + 76;
					obj6 = 0;
				}
				object obj7 = _003C_003E4__this + 72;
				obj7 = 0;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected Obj, but got VT
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00bc: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = DateTime.MinValue;
			object obj3 = obj2 + 8;
			obj3 = obj2;
			_003C_003E1__state = (int)obj3;
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

	private AsyncOperation _sendAsyncOperation;

	private UnityWebRequest _unityWebRequest;

	public UnityRequest(string method, Uri uri, byte[] bytes)
		: base(method, uri, bytes)
	{
	}

	public override void PrepareFetchResponse()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[SocketsResponse] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	public override void FetchResponseAsync()
	{
		//IL_0015: Expected VT, but got Obj
		if (~(base.acceptGzip__BackingField ? 1u : 0u) == 0)
		{
			Headers headers = base.headers__BackingField.Add((KeyValuePair<string, string>)"Accept-Encoding");
			if (headers == null)
			{
				string text = base.headers__BackingField.Get("Accept-Encoding", "gzip");
			}
		}
	}

	public override void FetchResponse()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Request.Log((string)(object)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj3 = default;
		object obj4 = default;
		if (obj3 == obj4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj6 = default;
			object obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj8 = default;
			object obj7 = obj8;
		}
		else
		{
			object obj9 = default;
			object obj7 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private IEnumerator SendCoroutine()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		bool flag = ((Headers)(object)base.exception__BackingField).Contains("Content-Encoding");
		if (!((string)flag).EndsWith("gzip"))
		{
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			IEnumerator enumerator = default;
			if (~(base.ignoreCertificateErrors__BackingField ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj4 = default;
				if ((nint)obj4 < 1)
				{
					enumerator = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			else
			{
				enumerator = null;
			}
			object obj5 = obj2 + 4;
			object obj6 = obj5 + 1;
			obj5 = obj6;
			object obj7 = obj6 << 2;
			object obj8 = obj2 + obj7;
			obj8 = 108;
			IEnumerator result = enumerator;
			object obj9 = 0;
			if (obj3 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj2 + obj10;
				if ((nint)obj11 == 108)
				{
					object obj12 = obj2 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return result;
				}
			}
			if (obj9 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		IEnumerator result2 = default;
		return result2;
	}

	private void SendUnityWebRequest()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0448: Expected Obj, but got I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_037a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Request.Log((string)(object)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj3 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj4 = this + 12;
		object obj5 = default;
		obj4 = obj5;
		base.state__BackingField = RequestState.Done;
		if (_unityWebRequest != null)
		{
			_unityWebRequest.DisposeHandlers();
			object obj6 = this + 76;
			obj6 = 0;
		}
		object obj7 = this + 72;
		obj7 = 0;
	}

	private IResponse CreateResponseFromUnityWebRequest()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IResponse response = default;
		object obj = response + 16;
		obj = this;
		return response;
	}

	private static void LogError(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_072e: Expected Obj, but got I4
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0751: Expected Obj, but got I4
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_0797: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_05c0: Expected Obj, but got I
		//IL_084f: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I
		//IL_06e6: Expected Obj, but got I
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected Obj, but got Unknown
		//IL_0705: Expected Obj, but got I
		//IL_0689: Expected Obj, but got I
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_06a3: Expected Obj, but got I
		//IL_06b3: Expected Obj, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got Unknown
		//IL_0559: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UnityWebRequest unityWebRequest = default;
		string name = default;
		unityWebRequest.SetRequestHeader(name, (string)msg.m_stringLength);
		object obj6 = msg + 76;
		obj6 = unityWebRequest;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
		((UnityWebRequest)num).chunkedTransfer = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+3C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj10;
			if ((nint)obj9 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj10 = obj11;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj10 = obj12;
			}
			bool flag;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ L1_v23+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
		}
		object obj13 = 27;
		object obj14 = obj13 - 9;
		object obj21;
		object obj22 = default;
		if ((nint)obj13 != 9 && (nint)obj14 != 1 && (nint)obj14 != 2 && (nint)obj14 != 3)
		{
			if ((nint)obj14 == 4 || (nint)obj14 == 5 || (nint)obj14 == 6)
			{
				goto IL_0859;
			}
			if ((nint)obj14 != 7)
			{
				if ((nint)obj14 != 8)
				{
					if ((nint)obj14 == 9 || (nint)obj14 == 10)
					{
						goto IL_0859;
					}
					if ((nint)obj14 != 11)
					{
						if ((nint)obj14 == 12 || (nint)obj14 == 13 || (nint)obj14 == 14 || (nint)obj14 == 15)
						{
							goto IL_0859;
						}
						if ((nint)obj14 != 16)
						{
							if ((nint)obj14 != 17)
							{
								if ((nint)obj14 == 18)
								{
									object obj15 = obj5 + 4;
									object obj16 = obj15 + 1;
									obj15 = obj16;
									object obj17 = obj16 << 2;
									object obj18 = obj5 + obj17;
									obj18 = 172;
								}
								goto IL_0859;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj20 = default;
							object obj19 = obj20;
							obj21 = obj22;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj23 = default;
							object obj19 = obj23;
							obj21 = obj22;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj24 = default;
						object obj19 = obj24;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj25 = default;
					object obj19 = obj25;
					obj21 = obj22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj26 = default;
				object obj19 = obj26;
				obj21 = obj22;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj27 = default;
			object obj19 = obj27;
			obj21 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj28 = default;
		if (obj21 == obj28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0859;
		IL_087e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+34]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+34]");
			UploadHandlerRaw uploadHandlerRaw = default;
			uploadHandlerRaw.InternalSetContentType((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
			((UnityWebRequest)0).downloadHandler = (DownloadHandler)(object)uploadHandlerRaw;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
			object obj29 = 0;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DownloadHandlerBuffer downloadHandlerBuffer = default;
		downloadHandlerBuffer.InternalCreateBuffer();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
		UnityWebRequest.SetupPost((UnityWebRequest)0, (WWWForm)(object)downloadHandlerBuffer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
		object obj30 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
		((UnityWebRequest)0).uploadHandler = null;
		object obj31 = msg + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4C]");
		UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = ((UnityWebRequest)0).SendWebRequest();
		obj31 = unityWebRequestAsyncOperation;
		return;
		IL_0859:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj32 = (nint)0 << 2;
			object obj33 = obj5 + obj32;
			if ((nint)obj33 == 172)
			{
				object obj34 = obj5 + 4;
				if ((nint)obj34 > -1)
				{
					object obj35 = obj34 + -1;
					obj34 = obj35;
				}
				goto IL_087e;
			}
		}
		object obj36 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_087e;
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = string.ConcatArray((string[])(object)"[UnityRequest] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)text);
	}
}
