using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Proyecto26;

public class RequestHelper
{
	private string _uri;

	private string _method;

	private object _body;

	private string _bodyString;

	private byte[] _bodyRaw;

	private int? _timeout;

	private string _contentType;

	private int _retries;

	private float _retrySecondsDelay;

	private Action<RequestException, int> _retryCallback;

	private bool _enableDebug;

	private bool? _chunkedTransfer;

	private bool? _useHttpContinue;

	private int? _redirectLimit;

	private bool _ignoreHttpException;

	private WWWForm _formData;

	private Dictionary<string, string> _simpleForm;

	private List<IMultipartFormSection> _formSections;

	private CertificateHandler _certificateHandler;

	private UploadHandler _uploadHandler;

	private DownloadHandler _downloadHandler;

	private Dictionary<string, string> _headers;

	private Dictionary<string, string> _params;

	private bool _parseResponseBody;

	private UnityWebRequest Request__BackingField;

	private bool _isAborted;

	private bool _defaultContentType;

	public string Uri
	{
		get
		{
			return _uri;
		}
		set
		{
			_uri = value;
		}
	}

	public string Method
	{
		get
		{
			return _method;
		}
		set
		{
			_method = value;
		}
	}

	public object Body
	{
		get
		{
			return _body;
		}
		set
		{
			_body = value;
		}
	}

	public string BodyString
	{
		get
		{
			return _bodyString;
		}
		set
		{
			_bodyString = value;
		}
	}

	public byte[] BodyRaw
	{
		get
		{
			return _bodyRaw;
		}
		set
		{
			_bodyRaw = value;
		}
	}

	public int? Timeout
	{
		get
		{
			return _timeout;
		}
		set
		{
			_timeout = value;
		}
	}

	public string ContentType
	{
		get
		{
			return _contentType;
		}
		set
		{
			_contentType = value;
		}
	}

	public int Retries
	{
		get
		{
			return _retries;
		}
		set
		{
			_retries = value;
		}
	}

	public float RetrySecondsDelay
	{
		get
		{
			return _retrySecondsDelay;
		}
		set
		{
			_retrySecondsDelay = value;
		}
	}

	public Action<RequestException, int> RetryCallback
	{
		get
		{
			return _retryCallback;
		}
		set
		{
			_retryCallback = value;
		}
	}

	public bool EnableDebug
	{
		get
		{
			return _enableDebug;
		}
		set
		{
			_enableDebug = value;
		}
	}

	public bool? ChunkedTransfer
	{
		get
		{
			return _chunkedTransfer;
		}
		set
		{
			_chunkedTransfer = value;
		}
	}

	public bool? UseHttpContinue
	{
		get
		{
			return _useHttpContinue;
		}
		set
		{
			_useHttpContinue = value;
		}
	}

	public int? RedirectLimit
	{
		get
		{
			return _redirectLimit;
		}
		set
		{
			_redirectLimit = value;
		}
	}

	public bool IgnoreHttpException
	{
		get
		{
			return _ignoreHttpException;
		}
		set
		{
			_ignoreHttpException = value;
		}
	}

	public WWWForm FormData
	{
		get
		{
			return _formData;
		}
		set
		{
			_formData = value;
		}
	}

	public Dictionary<string, string> SimpleForm
	{
		get
		{
			return _simpleForm;
		}
		set
		{
			_simpleForm = value;
		}
	}

	public List<IMultipartFormSection> FormSections
	{
		get
		{
			return _formSections;
		}
		set
		{
			_formSections = value;
		}
	}

	public CertificateHandler CertificateHandler
	{
		get
		{
			return _certificateHandler;
		}
		set
		{
			_certificateHandler = value;
		}
	}

	public UploadHandler UploadHandler
	{
		get
		{
			return _uploadHandler;
		}
		set
		{
			_uploadHandler = value;
		}
	}

	public DownloadHandler DownloadHandler
	{
		get
		{
			return _downloadHandler;
		}
		set
		{
			_downloadHandler = value;
		}
	}

	public Dictionary<string, string> Headers
	{
		get
		{
			if (_headers != null)
			{
				return _headers;
			}
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, string> headers = default;
			_headers = headers;
			return _headers;
		}
		set
		{
			_headers = value;
		}
	}

	public Dictionary<string, string> Params
	{
		get
		{
			if (_params != null)
			{
				return _params;
			}
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, string> dictionary = default;
			_params = dictionary;
			return _params;
		}
		set
		{
			_params = value;
		}
	}

	public bool ParseResponseBody
	{
		get
		{
			return _parseResponseBody;
		}
		set
		{
			_parseResponseBody = value;
		}
	}

	public UnityWebRequest Request
	{
		private get
		{
			return Request__BackingField;
		}
		set
		{
			Request__BackingField = value;
		}
	}

	public float UploadProgress
	{
		get
		{
			if (Request__BackingField == null)
			{
				return 0f;
			}
			return Request__BackingField.uploadProgress;
		}
	}

	public ulong UploadedBytes
	{
		get
		{
			//IL_0030: Expected I8, but got I4
			if (Request__BackingField == null)
			{
				return 0uL;
			}
			return Request__BackingField.uploadedBytes;
		}
	}

	public float DownloadProgress
	{
		get
		{
			if (Request__BackingField == null)
			{
				return 0f;
			}
			return Request__BackingField.downloadProgress;
		}
	}

	public ulong DownloadedBytes
	{
		get
		{
			//IL_0030: Expected I8, but got I4
			if (Request__BackingField == null)
			{
				return 0uL;
			}
			return Request__BackingField.downloadedBytes;
		}
	}

	public bool IsAborted
	{
		get
		{
			return _isAborted;
		}
		set
		{
			_isAborted = value;
		}
	}

	public bool DefaultContentType
	{
		get
		{
			return _defaultContentType;
		}
		set
		{
			_defaultContentType = value;
		}
	}

	public unsafe string GetHeader(string name)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Ref, but got Unknown
		//IL_006d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (Request__BackingField != null)
		{
			return Request__BackingField.GetRequestHeader(name);
		}
		Dictionary<string, string> headers = Headers;
		bool flag = headers.TryGetValue(name, out *(string*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (string)0;
	}

	public void Abort()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (Request__BackingField == null || _isAborted)
		{
			return;
		}
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		object obj4 = 0;
		_ = 1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj5 = default;
			object obj6 = default;
			bool flag = obj5 != obj6;
			object obj8 = default;
			object obj7 = obj8;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_015a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj9 = default;
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		goto IL_015a;
		IL_015a:
		object obj11 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9530");
	}

	public RequestHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 1;
		_ = 1;
		_defaultContentType = true;
		_parseResponseBody = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E]");
		_useHttpContinue = (bool?)(object)0;
	}
}
