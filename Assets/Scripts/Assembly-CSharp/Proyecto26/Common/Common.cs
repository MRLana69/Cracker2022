using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Proyecto26.Common;

public static class Common
{
	private sealed class _003CSendWebRequestWithOptions_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RequestHelper options;

		public UnityWebRequest request;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Ref, but got Unknown
			//IL_01b8: Expected I, but got Obj
			//IL_014c: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I4
			//IL_0345: Expected Obj, but got I4
			//IL_0329: Expected Obj, but got I4
			//IL_0224: Expected Obj, but got I4
			//IL_0473: Expected Obj, but got I
			//IL_035a: Expected Obj, but got I
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Ref, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			int num;
			bool result;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				result = false;
				if (flag)
				{
					goto IL_03bc;
				}
				result = false;
				goto IL_03cb;
			}
			_003C_003E1__state = -1;
			RequestHelper requestHelper = options;
			_ = requestHelper._bodyRaw;
			_ = string.Empty;
			Dictionary<string, string> headers = options.Headers;
			bool flag2 = headers.TryGetValue("Content-Type", out *(string*)(obj + 8));
			RequestHelper requestHelper2 = options;
			if (flag2 || ~(requestHelper2._defaultContentType ? 1u : 0u) == 0)
			{
			}
			object body = requestHelper2._body;
			if (requestHelper2._body != null)
			{
				goto IL_0183;
			}
			RequestHelper requestHelper3 = options;
			string bodyString = requestHelper2._bodyString;
			object obj3;
			if (requestHelper2._bodyString != null)
			{
				obj3 = 0;
				if (bodyString._stringLength != 0)
				{
					goto IL_03f0;
				}
			}
			obj3 = 1;
			goto IL_03f0;
			IL_03fe:
			RequestHelper requestHelper4 = options;
			string contentType = requestHelper4._contentType;
			object obj4;
			if (requestHelper4._contentType != null)
			{
				obj4 = 0;
				if (contentType._stringLength != 0)
				{
					goto IL_0437;
				}
			}
			obj4 = 1;
			goto IL_0437;
			IL_03bc:
			_003C_003E1__state = num;
			goto IL_03cb;
			IL_0437:
			string contentType2;
			RequestHelper requestHelper5;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				contentType2 = (string)0;
				requestHelper5 = options;
			}
			else
			{
				RequestHelper requestHelper6 = options;
				_ = requestHelper6._contentType;
				contentType2 = requestHelper6._contentType;
				requestHelper5 = requestHelper6;
			}
			UnityWebRequest unityWebRequest = request;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			ConfigureWebRequestWithOptions(unityWebRequest, (byte[])0, contentType2, requestHelper5);
			UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = request.SendWebRequest();
			_003C_003E2__current = unityWebRequestAsyncOperation;
			num = 1;
			result = true;
			goto IL_03bc;
			IL_0195:
			Encoding uTF = Encoding.UTF8;
			string text;
			char[] array = text.ToCharArray();
			nint num2 = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S3_v10 (Il2CppClass<System.Text.Encoding>)+13C] (should have been resolved before IL gen)");
			goto IL_03fe;
			IL_0183:
			text = JsonUtility.ToJson(body);
			goto IL_0195;
			IL_03cb:
			return result;
			IL_03f0:
			if (obj3 == null)
			{
				body = requestHelper3._body;
				if (requestHelper3._body != null)
				{
					goto IL_0183;
				}
				text = requestHelper3._bodyString;
				goto IL_0195;
			}
			Dictionary<string, string> simpleForm = requestHelper3._simpleForm;
			bool flag3 = requestHelper3._simpleForm == null;
			RequestHelper requestHelper7 = requestHelper3;
			if (!flag3)
			{
				RequestHelper requestHelper8 = options;
				object obj5 = simpleForm._count - simpleForm._freeCount;
				bool flag4 = (nint)obj5 < 1;
				requestHelper7 = options;
				if (!flag4)
				{
					byte[] array2 = UnityWebRequest.SerializeSimpleForm(requestHelper8._simpleForm);
					goto IL_03fe;
				}
			}
			List<IMultipartFormSection> formSections = requestHelper7._formSections;
			if (requestHelper7._formSections != null)
			{
				bool flag5 = formSections._size < 1;
				requestHelper7 = options;
				if (!flag5)
				{
					string formSectionsContentType = GetFormSectionsContentType(out *(byte[]*)(obj + 12), options);
					goto IL_03fe;
				}
			}
			if (requestHelper7._formData != null)
			{
				_ = string.Empty;
			}
			goto IL_03fe;
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

	private const string CONTENT_TYPE_HEADER = "Content-Type";

	private const string DEFAULT_CONTENT_TYPE = "application/json";

	private unsafe static string GetFormSectionsContentType(out byte[] bodyRaw, RequestHelper options)
	{
		//IL_0016: Expected I, but got Obj
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		byte[] boundary = UnityWebRequest.GenerateBoundary();
		byte[] array = UnityWebRequest.SerializeFormSections(options._formSections, boundary);
		Encoding uTF = Encoding.UTF8;
		Encoding uTF2 = Encoding.UTF8;
		nint num = (nint)uTF2;
		object obj = uTF2 + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v3 (Il2CppClass<System.Text.Encoding>)+1EC] (should have been resolved before IL gen)");
		string text2 = default;
		string text = "\r\n--" + text2 + "--";
		nint num2 = (nint)uTF;
		object obj2 = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v8 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		int num3 = array.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v16 (System.Array)+C]");
		object obj3 = (nint)num3 + (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj4 = default;
		ref byte[] reference = ref *(byte[]*)obj4;
		Buffer.BlockCopy(array, 0, bodyRaw, 0, array.Length);
		byte[] dst = bodyRaw;
		int dstOffset = array.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v16 (System.Array)+C]");
		Array src = default;
		Buffer.BlockCopy(src, 0, dst, dstOffset, 0);
		Encoding uTF3 = Encoding.UTF8;
		nint num4 = (nint)uTF3;
		object obj5 = uTF3 + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S2_v19 (Il2CppClass<System.Text.Encoding>)+1EC] (should have been resolved before IL gen)");
		string text3 = default;
		return "multipart/form-data; boundary=" + text3;
	}

	private unsafe static void ConfigureWebRequestWithOptions(UnityWebRequest request, byte[] bodyRaw, string contentType, RequestHelper options)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected Obj, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected VT, but got Unknown
		//IL_0777: Expected Ref, but got VT
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected VT, but got Unknown
		//IL_07dd: Expected Ref, but got VT
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected VT, but got Unknown
		//IL_0843: Expected Ref, but got VT
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected VT, but got Unknown
		//IL_08a9: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (options._certificateHandler != null)
		{
			request.certificateHandler = options._certificateHandler;
		}
		if (options._uploadHandler != null)
		{
			request.uploadHandler = options._uploadHandler;
		}
		if (bodyRaw != null)
		{
			UploadHandlerRaw uploadHandlerRaw = default;
			uploadHandlerRaw._002Ector(bodyRaw);
			request.uploadHandler = uploadHandlerRaw;
			UploadHandler uploadHandler = request.m_UploadHandler;
			nint num = (nint)uploadHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S2_v66 (Il2CppClass<UnityEngine.Networking.UploadHandler>)+EC] (should have been resolved before IL gen)");
		}
		if (options._downloadHandler != null)
		{
			request.downloadHandler = options._downloadHandler;
			DownloadHandler downloadHandler = options._downloadHandler;
			bool flag = options._downloadHandler == null;
			DownloadHandler downloadHandler2 = null;
			if (!flag)
			{
				bool flag2 = (object)downloadHandler.GetType() == typeof(DownloadHandlerBuffer);
				downloadHandler2 = options._downloadHandler;
				if (!flag2)
				{
					downloadHandler2 = null;
				}
			}
			bool parseResponseBody = downloadHandler2 != null;
			options._parseResponseBody = parseResponseBody;
		}
		else
		{
			DownloadHandlerBuffer downloadHandlerBuffer = default;
			downloadHandlerBuffer._002Ector();
			request.downloadHandler = downloadHandlerBuffer;
		}
		object obj3;
		if (contentType != null)
		{
			obj3 = 0;
			if (contentType._stringLength != 0)
			{
				goto IL_09db;
			}
		}
		obj3 = 1;
		goto IL_09db;
		IL_09db:
		if (obj3 == null)
		{
			request.SetRequestHeader("Content-Type", contentType);
		}
		object obj4 = obj + 16;
		Dictionary<string, string> defaultRequestHeaders = RestClient.DefaultRequestHeaders;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj5 = obj + 72;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj7 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj7 == null)
				{
					goto IL_0431;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					_ = 0;
					object obj8 = obj - -64;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj9 = obj - -64;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj10 != obj11;
			object obj12 = obj13;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0431;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_0937;
			IL_0431:
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F8");
			object obj17 = obj + 16;
			Dictionary<string, string> headers = options.Headers;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj18 = obj + 72;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj19 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj20 == null)
					{
						goto IL_070f;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj21 != obj22;
				obj12 = obj23;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_070f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj24;
				break;
				IL_070f:
				object obj25 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F8");
				_ = options._timeout;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				if ((nint)0 != 0)
				{
					_ = options._timeout;
					int? num2 = (int?)(object)(obj + 48);
					int value = ((int?*)num2)->Value;
					request.timeout = value;
				}
				_ = options._chunkedTransfer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E]");
				if ((nint)0 != 0)
				{
					_ = options._chunkedTransfer;
					bool? flag5 = (bool?)(object)(obj + 46);
					bool value2 = ((bool?*)flag5)->Value;
					request.chunkedTransfer = value2;
				}
				_ = options._useHttpContinue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E]");
				if ((nint)0 != 0)
				{
					_ = options._useHttpContinue;
					bool? flag6 = (bool?)(object)(obj + 46);
					bool value3 = ((bool?*)flag6)->Value;
					request.useHttpContinue = value3;
				}
				_ = options._redirectLimit;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				if ((nint)0 != 0)
				{
					_ = options._redirectLimit;
					int? num3 = (int?)(object)(obj + 48);
					int value4 = ((int?*)num3)->Value;
					request.redirectLimit = value4;
				}
				options.Request__BackingField = request;
				return;
			}
			_ = 0;
			object obj26 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_0937;
			IL_0937:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public static IEnumerator SendWebRequestWithOptions(UnityWebRequest request, RequestHelper options)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
