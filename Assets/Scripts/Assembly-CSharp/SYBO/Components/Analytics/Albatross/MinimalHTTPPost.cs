using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Analytics.Albatross;

public class MinimalHTTPPost(MonoBehaviour coroutineHost, float timeout = 60f) : PostAnalyticsProvider.IHTTPPostLayer
{
	private sealed class _003CWaitForWWWRequest_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public byte[] bytes;

		public Dictionary<string, string> headers;

		public Action<int, string, string> onFinish;

		private WWW _003Cwww_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0106: Expected Obj, but got I
			//IL_01b9: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got I4
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0211;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				WWW wWW = default;
				wWW._002Ector(url, bytes, headers);
				_003Cwww_003E5__2 = wWW;
			}
			object obj2;
			string empty2;
			if (_003Cwww_003E5__2.isDone)
			{
				int responseCode = GetResponseCode(_003Cwww_003E5__2);
				if (_003Cwww_003E5__2.isDone)
				{
					Dictionary<string, string> responseHeaders = _003Cwww_003E5__2.responseHeaders;
					if (responseHeaders != null)
					{
						Dictionary<string, string> responseHeaders2 = _003Cwww_003E5__2.responseHeaders;
						nint num = 0;
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S3_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
						object obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S3_v7+4] (should have been resolved before IL gen)");
					}
				}
				if (responseCode == 0)
				{
					string empty = string.Empty;
				}
				else
				{
					string empty = _003Cwww_003E5__2.text;
				}
				bool isDone = _003Cwww_003E5__2.isDone;
				bool flag = !isDone;
				empty2 = string.Empty;
				if (flag)
				{
					goto IL_0267;
				}
				string error = _003Cwww_003E5__2.error;
				if (error != null)
				{
					obj2 = 0;
					if (error._stringLength != 0)
					{
						goto IL_0280;
					}
				}
				obj2 = 1;
				goto IL_0280;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0280:
			empty2 = string.Empty;
			if (obj2 == null)
			{
				string error2 = _003Cwww_003E5__2.error;
				empty2 = error2;
			}
			goto IL_0267;
			IL_0211:
			return false;
			IL_0267:
			Action<int, string, string> action = onFinish;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S0_v39 (System.Action`3<System.Int32, System.String, System.String>)+C] (should have been resolved before IL gen)");
			goto IL_0211;
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

	private MonoBehaviour _coroutineHost = coroutineHost;

	private float _timeout = timeout;

	public void POST(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish)
	{
		IEnumerator routine = ((MinimalHTTPPost)(object)url).WaitForWWWRequest(url, headers, bytes, onFinish);
		Coroutine coroutine = _coroutineHost.StartCoroutine(routine);
	}

	private IEnumerator WaitForWWWRequest(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public static int GetResponseCode(WWW request)
	{
		//IL_0061: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		bool isDone = request.isDone;
		bool flag = !isDone;
		int result = 0;
		if (!flag)
		{
			Dictionary<string, string> responseHeaders = request.responseHeaders;
			bool flag2 = responseHeaders == null;
			result = 0;
			if (!flag2)
			{
				Dictionary<string, string> responseHeaders2 = request.responseHeaders;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				bool flag3 = obj4 == null;
				result = 0;
				if (!flag3)
				{
					Dictionary<string, string> responseHeaders3 = request.responseHeaders;
					string statusLine = responseHeaders3.get_Item("STATUS");
					int num3 = ParseResponseCode(statusLine);
					result = num3;
				}
			}
		}
		return result;
	}

	public unsafe static int ParseResponseCode(string statusLine)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = statusLine.Split(' ');
		if (array.Length <= 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		bool flag = int.TryParse(array[1], out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}
}
