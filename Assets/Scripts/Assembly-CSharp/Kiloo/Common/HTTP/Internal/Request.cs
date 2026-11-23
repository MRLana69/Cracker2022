using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Common.HTTP.Internal;

internal abstract class Request : IRequest
{
	private DateTime _startTime;

	private IResponse response__BackingField;

	private Exception exception__BackingField;

	private RequestState state__BackingField;

	private float timeout__BackingField;

	private float minBackOffTime__BackingField = 1f;

	private float maxBackOffTime__BackingField;

	private Uri uri__BackingField;

	public string method
	{
		get
		{
			return field;
		}
		protected set
		{
			field = value;
		}
	}

	public string protocol
	{
		get
		{
			return field;
		}
		protected set
		{
			field = value;
		}
	} = "HTTP/1.1";

	public IResponse response
	{
		get
		{
			return response__BackingField;
		}
		set
		{
			response__BackingField = value;
		}
	}

	public uint maxRedirectCount
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = 8u;

	public Exception exception
	{
		get
		{
			return exception__BackingField;
		}
		set
		{
			exception__BackingField = value;
		}
	}

	public RequestState state
	{
		get
		{
			return state__BackingField;
		}
		set
		{
			state__BackingField = value;
		}
	}

	public bool ignoreCertificateErrors
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = false;

	public bool ignoreContentMD5
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

	public float minBackOffTime
	{
		get
		{
			return minBackOffTime__BackingField;
		}
		set
		{
			minBackOffTime__BackingField = value;
		}
	}

	public float maxBackOffTime
	{
		get
		{
			return maxBackOffTime__BackingField;
		}
		set
		{
			maxBackOffTime__BackingField = value;
		}
	}

	public bool acceptGzip
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = true;

	public Uri uri
	{
		get
		{
			return uri__BackingField;
		}
		set
		{
			uri__BackingField = value;
		}
	}

	public byte[] bytes
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

	public float keepAlive
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	} = 5f;

	public Headers headers
	{
		get
		{
			return field;
		}
		protected set
		{
			field = value;
		}
	}

	public float simulatedRequestLatency
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

	public IEnumerable<SimulatedRequestResult> simulatedRequestResults
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

	public bool isFinished
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = state__BackingField - 3;
			return (nint)obj < 4;
		}
	}

	public bool isSuccessful
	{
		get
		{
			if (state__BackingField == RequestState.Done)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj = default;
				return (nint)obj == 2;
			}
			return false;
		}
	}

	public string statusMessage
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_0060: Expected I, but got Obj
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			_ = 0;
			if (exception__BackingField != null)
			{
				obj = state__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				object obj4 = default;
				object obj3 = obj4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S1_v24+BC] (should have been resolved before IL gen)");
				Exception ex = exception__BackingField;
				nint num = (nint)ex;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S1_v27 (Il2CppClass<System.Exception>)+E4] (should have been resolved before IL gen)");
				object arg = default;
				object arg2 = default;
				object arg3 = default;
				return $"{arg}, {arg2}: {arg3}";
			}
			if (response__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj5 = default;
				obj = (Enum)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object arg4 = default;
				object arg5 = default;
				return $"{arg4}: {arg5}";
			}
			_ = state__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(RequestState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			return obj.ToString();
		}
	}

	protected Request(string method, Uri uri, byte[] bytes)
	{
		Headers headers = default;
		headers._002Ector();
		this.headers__BackingField = headers;
		string text = method.ToUpperInvariant();
		this.method__BackingField = text;
		this.uri__BackingField = uri;
		this.bytes__BackingField = bytes;
	}

	protected static bool IsFinalState(RequestState state)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = state - 3;
		return (nint)obj < 4;
	}

	public unsafe void CheckBackOff()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006c: Expected Ref, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		string host = uri__BackingField.Host;
		double backOffSeconds = Hosts.GetBackOffSeconds(host);
		if (backOffSeconds > 0.0)
		{
			string host2 = uri__BackingField.Host;
			double num = (double)obj + 8.0;
			string text = ((double*)num)->ToString();
			string text2 = host2 + " is busy, cannot make request at this time (waiting " + text + " more seconds)";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @52CD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void UpdateBackOffError()
	{
		if (maxBackOffTime__BackingField > 0f)
		{
			string host = uri__BackingField.Host;
			Hosts.BackOff(host, minBackOffTime__BackingField, maxBackOffTime__BackingField);
		}
	}

	public void UpdateBackOff(IResponse response)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		string host = uri__BackingField.Host;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		object obj = obj2 - 500;
		if ((nint)obj2 == 500 || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Headers headers = default;
			if (headers.Contains("Retry-After"))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers headers2 = default;
				DateTime dateTime = headers2.Get("Retry-After", DateTime.MinValue, allowDeltaTimeSeconds: true);
				DateTime utcNow = CDateTime.UtcNow;
				if (dateTime > utcNow)
				{
					Hosts.BackOff(host, dateTime);
					return;
				}
			}
			if (maxBackOffTime__BackingField > 0f)
			{
				string host2 = uri__BackingField.Host;
				Hosts.BackOff(host2, minBackOffTime__BackingField, maxBackOffTime__BackingField);
			}
		}
		else
		{
			Hosts.DontBackOff(host);
		}
	}

	public abstract void FetchResponseAsync();

	public abstract void FetchResponse();

	protected void PrepareFetchResponse()
	{
		//IL_002f: Expected Obj, but got I4
		InvalidOperationException ex = default;
		if (state__BackingField != RequestState.None)
		{
			object obj = state__BackingField - 3;
			if ((nint)obj >= 4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ex._002Ector("Fetch already in process");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
		}
		((Request)(object)ex).response__BackingField = null;
		((Request)(object)ex).exception__BackingField = null;
		((Request)(object)ex).state__BackingField = RequestState.Waiting;
		DateTime utcNow = CDateTime.UtcNow;
		((Request)(object)ex)._startTime = utcNow;
	}

	protected void AssertNotCanceled(string step)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (timeout__BackingField > 0f)
		{
			DateTime utcNow = CDateTime.UtcNow;
			TimeSpan timeSpan = utcNow - _startTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0 * 1E-07;
			if ((double)timeout__BackingField < num)
			{
				state__BackingField = RequestState.TimedOut;
			}
		}
		object obj3 = state__BackingField - 3;
		if ((nint)obj3 >= 4)
		{
			return;
		}
		object obj4 = state__BackingField - 4;
		string msg;
		if (state__BackingField != RequestState.Canceled)
		{
			if ((nint)obj4 != 1)
			{
				string message = "Unexpected request state (" + step + ")";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				HTTPException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				return;
			}
			string text = "Request was canceled because it failed to complete in time (" + step + ")";
			msg = text;
		}
		else
		{
			string text2 = "Request was canceled (" + step + ")";
			msg = text2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		HTTPRequestCanceledException ex2 = default;
		ex2._002Ector(msg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private static void Log(string msg)
	{
	}
}
