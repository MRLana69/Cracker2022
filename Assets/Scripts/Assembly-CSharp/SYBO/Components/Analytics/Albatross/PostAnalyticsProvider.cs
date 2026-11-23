using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Albatross;

public class PostAnalyticsProvider : IPostAnalytics
{
	public interface IHTTPPostLayer
	{
		void POST(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish);
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public byte[] analyticsJsonBytes;

		public int uncompressedLength;

		public string url;

		public Action<ProcessAnalyticEventsResponse> onFinished;

		internal void _003CPostAnalyticsEvents_003Eb__0(int responseCode, string httpResponse, string errorMessage)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected Obj, but got Unknown
			//IL_003e: Expected Obj, but got I4
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected Obj, but got Unknown
			//IL_04fc: Expected Obj, but got I4
			//IL_066e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0673: Expected Obj, but got Unknown
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_053c: Expected Obj, but got Unknown
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Expected Obj, but got Unknown
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			switch (responseCode)
			{
			case 0:
			{
				if (errorMessage == string.Empty || errorMessage.Contains("SSL"))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					byte[] array = analyticsJsonBytes;
					_ = array.Length;
					object obj3 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				byte[] array2 = analyticsJsonBytes;
				_ = array2.Length;
				object obj4 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
			case 200:
			{
				Action<ProcessAnalyticEventsResponse> action = onFinished;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S0_v68 (System.Action`1<SYBO.Components.Analytics.ProcessAnalyticEventsResponse>)+C] (should have been resolved before IL gen)");
				return;
			}
			}
			object obj5 = responseCode - 400;
			if ((nint)obj5 <= 99)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				byte[] array3 = analyticsJsonBytes;
				if (responseCode == 408)
				{
					_ = array3.Length;
					object obj6 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					throw new ArrayTypeMismatchException();
				}
				_ = array3.Length;
				object obj7 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			byte[] array4 = analyticsJsonBytes;
			object obj8 = responseCode - 500;
			if ((nint)obj8 <= 99)
			{
				_ = array4.Length;
				object obj9 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
			_ = array4.Length;
			object obj10 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	private const string AUTH_FORMAT = "{0} {1}\n{2}";

	private const bool CompressContent = true;

	private string _baseURL;

	private string _applicationId;

	private string _userAgentString;

	private string _apiVersion;

	private HMACSHA1 _hmac;

	private IHTTPPostLayer _httpLayer;

	string IPostAnalytics.BaseURL
	{
		get
		{
			return _baseURL;
		}
		set
		{
			_baseURL = value;
		}
	}

	public PostAnalyticsProvider(string baseUrl, string applicationId, string apiVersion, string userAgentString, byte[] key, IHTTPPostLayer httpLayer)
	{
		_baseURL = baseUrl;
		_applicationId = applicationId;
		_apiVersion = apiVersion;
		_userAgentString = userAgentString;
		HMACSHA1 hMACSHA = default;
		hMACSHA._002Ector(key);
		_hmac = hMACSHA;
		_httpLayer = httpLayer;
	}

	public unsafe void PostAnalyticsEvents(byte[] analyticsJsonBytes, int uncompressedLength, string uncompressedMD5Hash, Action<ProcessAnalyticEventsResponse> onFinished)
	{
		string text = "/" + _applicationId + "/analytics";
		string text2 = _baseURL + text;
		Dictionary<string, string> dictionary = GenerateHeaders("POST", text, uncompressedMD5Hash, gzipData: true);
		Action<, , > action = default;
		object obj = default;
		((Action<T1, T2, T3>)(object)action)._002Ector(obj, (IntPtr)(nint)__ldftn(_003C_003Ec__DisplayClass13_0._003CPostAnalyticsEvents_003Eb__0));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @960");
	}

	private Dictionary<string, string> GenerateHeaders(string method, string uri, string uncompressedMD5Hash, bool gzipData)
	{
		//IL_01b6: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S5_v9+4] (should have been resolved before IL gen)");
		object obj3;
		if (uncompressedMD5Hash != null)
		{
			obj3 = 0;
			if (uncompressedMD5Hash._stringLength != 0)
			{
				goto IL_0203;
			}
		}
		obj3 = 1;
		goto IL_0203;
		IL_0203:
		bool flag = obj3 == null;
		bool flag2 = !flag;
		string empty = string.Empty;
		if (!flag2)
		{
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S5_v20+4] (should have been resolved before IL gen)");
			if (gzipData)
			{
				nint num9 = 0;
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S5_v30 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S5_v31+4] (should have been resolved before IL gen)");
			}
			nint num11 = 0;
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S5_v25 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S5_v26+4] (should have been resolved before IL gen)");
			empty = uncompressedMD5Hash;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
