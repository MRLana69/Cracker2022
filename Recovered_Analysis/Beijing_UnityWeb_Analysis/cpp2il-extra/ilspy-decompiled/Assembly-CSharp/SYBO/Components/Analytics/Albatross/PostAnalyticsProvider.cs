using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Analytics.Albatross;

public class PostAnalyticsProvider : IPostAnalytics
{
	public interface IHTTPPostLayer
	{
		void POST(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish);
	}

	private const string AUTH_FORMAT = "{0} {1}\n{2}";

	private const bool CompressContent = true;

	private string _baseURL;

	private string _applicationId;

	private string _userAgentString;

	private string _apiVersion;

	private HMACSHA1 _hmac;

	private IHTTPPostLayer _httpLayer;

	unsafe string IPostAnalytics.BaseURL
	{
		get
		{
			//IL_00c8: Expected Obj, but got I4
			//IL_00e0: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_003f: Expected I, but got Obj
			//IL_0055: Expected Obj, but got I
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0080: Expected I, but got Obj
			IFormatProvider formatProvider = (IFormatProvider)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num = default;
			object obj = num + 16;
			obj = 32;
			string text = ((string)this).Substring(num);
			if (text.m_firstChar > '\u0002')
			{
				object obj2 = text + 20;
				bool flag = ((int*)obj2)->System_002EIConvertible_002EToBoolean(formatProvider);
				return (string)(object)formatProvider;
			}
			nint num2 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Log.Analytics.LogErrorFormat("invalid response status:{0}", (object[])(object)this);
			return null;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public PostAnalyticsProvider(string baseUrl, string applicationId, string apiVersion, string userAgentString, byte[] key, IHTTPPostLayer httpLayer)
	{
	}

	public void PostAnalyticsEvents(byte[] analyticsJsonBytes, int uncompressedLength, string uncompressedMD5Hash, Action<ProcessAnalyticsEventsResponse> onFinished)
	{
		//IL_0016: Expected I4, but got Obj
		//IL_0016: Expected Obj, but got I4
		Dictionary<string, string> routine = GenerateHeaders((string)(object)analyticsJsonBytes, (string)uncompressedLength, uncompressedMD5Hash, (byte)(int)onFinished != 0);
		Coroutine coroutine = ((MonoBehaviour)(object)_baseURL).StartCoroutine_Auto((IEnumerator)routine);
	}

	private Dictionary<string, string> GenerateHeaders(string method, string uri, string uncompressedMD5Hash, bool gzipData)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Dictionary<string, string> dictionary = default;
		dictionary.buckets = null;
		object obj = dictionary + 28;
		obj = this;
		object obj2 = dictionary + 16;
		obj2 = method;
		object obj3 = dictionary + 24;
		obj3 = uri;
		object obj4 = dictionary + 20;
		obj4 = uncompressedMD5Hash;
		object obj5 = dictionary + 32;
		obj5 = gzipData;
		return dictionary;
	}
}
